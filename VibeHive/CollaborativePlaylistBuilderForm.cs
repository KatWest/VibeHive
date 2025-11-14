using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VibeHive.Models;
using System.Threading;

namespace VibeHive
{
    public partial class CollaborativePlaylistBuilderForm : Form
    {
        private static readonly HttpClient _httpClient = new HttpClient();
        private static readonly string apiBaseUrl = "https://localhost:7235/api";
        
        private readonly System.Windows.Forms.Timer _songRefreshTimer = new System.Windows.Forms.Timer();
        private readonly SemaphoreSlim _refreshLock = new SemaphoreSlim(1,1);

        public CollaborativePlaylistBuilderForm()
        {
            InitializeComponent();

            _songRefreshTimer.Interval = 10_000; //10 second timer
            _songRefreshTimer.Tick += async(s, e) => await RefreshSongsPeriodically();
        }

        private async void CollaborativePlaylistBuilder_Load(object sender, EventArgs e)
        {
            await LoadUsersAsync();
        }

        private async void button_createPlaylist_Click(object sender, EventArgs e)
        {
            //check which collab option chosen
            bool _isCollab = false; //default of false
            if (radioButton_false_isCollaborative.Checked)
            {
                _isCollab = false;
            }
            if (radioButton_true_isCollaborative.Checked)
            {
                _isCollab = true;
            }

            //create playlist object
            var newPlaylist = new
            {
                CreatedBy = textBox_userId.Text,
                Name = textBox_playlistName.Text,
                IsCollaborative = _isCollab
            };

            var json = JsonConvert.SerializeObject(newPlaylist);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage message = await _httpClient.PostAsync($"{apiBaseUrl}/playlist", content);

            if (message.IsSuccessStatusCode)
            {
                MessageBox.Show($"New playlist added successfully.");
                await LoadPlaylistsAsync();

                //clear fields not tied to current selection
                textBox_userId.Clear();
                textBox_playlistName.Clear();
                radioButton_false_isCollaborative.Checked = false;
                radioButton_true_isCollaborative.Checked = false;
            }
            else
            {
                MessageBox.Show("Failed to add new playlist.", "Error");
            }
        }

        private async void button_AddCollaborator_Click(object sender, EventArgs e)
        {
            try
            {
                dynamic playlist = listBox_Playlists.SelectedItem;
                dynamic user = listBox_users.SelectedItem;

                var addCollab = new
                {
                    playlistId = playlist.Value.ToString(),
                    userId = playlist.CreatorId.ToString(),
                    collabUserId = user.Value.ToString()
                };

                var json = JsonConvert.SerializeObject(addCollab);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await _httpClient.PostAsync($"{apiBaseUrl}/playlist/{playlist.Value.ToString()}/invite", content);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show($"Collaborator added to playlist successfully.");

                    //clear fields 
                    textBox_creatorId.Clear();
                    textBox_collabUserId.Clear();
                    textBox_playlistId_addCollab.Clear();
                }
                else
                {
                    MessageBox.Show($"Failed to add collaborator: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async void button_addSong_Click(object sender, EventArgs e)
        {
            //Future Todo: Add auth so can verify who user is to approve editing playlist
            try
            {
                dynamic playlist = listBox_Playlists.SelectedItem;

                var newSong = new
                {
                    Title = textBox_songTitle.Text,
                    Artist = textBox_songArtist.Text,
                    Genre = textBox_songGenre.Text,
                    DurationMinutes = numericUpDown_songMinutes.Value,
                    DurationSeconds = numericUpDown_songSeconds.Value
                };

                var json = JsonConvert.SerializeObject(newSong);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await _httpClient.PostAsync($"{apiBaseUrl}/playlist/{playlist.Value.ToString()}/add", content);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show($"New song was added to the playlist successfully.");
                    LoadPlaylistSongsAsync(playlist.Value.ToString());

                    //clear fields
                    textBox_playlistID_addSong.Clear();
                    textBox_songGenre.Clear();
                    textBox_songTitle.Clear();
                    textBox_songArtist.Clear();
                    numericUpDown_songMinutes.Value = 0;
                    numericUpDown_songSeconds.Value = 0;
                }
                else
                {
                    MessageBox.Show($"Failed to add the new song: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async void button_Vote_Click(object sender, EventArgs e)
        {
            try
            {
                bool newVote = false; //Default false
                //if upvote selected the update to true to upvote
                if(radioButton_Up.Checked) 
                {
                    newVote = true;
                }

                var playlistId = textBox_playlistId_songVote.Text;

                dynamic item = listBox_PlaylistSongs.SelectedItem;

                var songVote = new
                {
                    songId = item.Value,
                    vote = newVote
                };

                var json = JsonConvert.SerializeObject(songVote);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await _httpClient.PostAsync($"{apiBaseUrl}/playlist/{playlistId}/vote", content);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show($"The vote was successfully counted towards the song.");
                    LoadPlaylistSongsAsync(playlistId);

                    //clear current selection *note on reload it does select the top song and reload songId field
                    textBox_playlistId_songVote.Clear();
                    textBox_songId_songVote.Clear();
                    radioButton_downVote.Checked = false;
                    radioButton_Up.Checked = false;
                }
                else
                {
                    MessageBox.Show($"Failed to add your vote to the song: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async Task LoadUsersAsync()
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync($"{apiBaseUrl}/user");
                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    var users = JsonConvert.DeserializeObject<List<UserDto>>(json);

                    listBox_users.DataSource = users.Select(u => new { Display = $"User -- Id: {u.id} - Name: {u.name}", Value = u.id })
                    .ToList();
                    listBox_users.DisplayMember = "Display";
                    listBox_users.ValueMember = "Value";
                }
                else
                {
                    MessageBox.Show($"Failed to load users: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async Task LoadPlaylistsAsync()
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync($"{apiBaseUrl}/playlist");
                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    var playlists = JsonConvert.DeserializeObject<List<PlaylistDto>>(json);

                    listBox_Playlists.DataSource = playlists.Select(p => new
                    {
                        Display = $"Playlist -- Id: {p.Id} - Name: {p.Name} - Created By: {p.CreatedBy} - isCollaborative: {p.isCollaborative}",
                        Value = p.Id,
                        CreatorId = p.CreatedBy
                    })
                    .ToList();
                    listBox_Playlists.DisplayMember = "Display";
                    listBox_Playlists.ValueMember = "Value";
                }
                else
                {
                    MessageBox.Show($"Failed to load playlists: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async Task LoadPlaylistSongsAsync(string playlistId)
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync($"{apiBaseUrl}/playlist/{playlistId}/rankings");
                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    var playlistSongs = JsonConvert.DeserializeObject<List<SongDto>>(json);

                    listBox_PlaylistSongs.DataSource = playlistSongs.Select(s => new
                    {
                        Display = $"Song -- Id: {s.Id} - Title: {s.Title} - Artist: {s.Artist} - Genre: {s.Genre} - Duration: {s.Duration} - Votes: {s.Votes}",
                        Value = s.Id,
                        Vote = s.Votes
                    })
                    .ToList();
                    listBox_PlaylistSongs.DisplayMember = "Display";
                    listBox_PlaylistSongs.ValueMember = "Value";
                }
                else
                {
                    MessageBox.Show($"Failed to load the songs for Playlist Id: {playlistId}: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void listBox_users_SelectedIndexChanged(object sender, EventArgs e)
        {
            dynamic item = listBox_users.SelectedItem;
            //popular id for playlist owner textboxes
            textBox_userId.Text = item.Value.ToString();
            textBox_collabUserId.Text = item.Value.ToString();
        }

        private void listBox_Playlists_SelectedIndexChanged(object sender, EventArgs e)
        {
            dynamic item = listBox_Playlists.SelectedItem;
            if(item == null)
            {
                _songRefreshTimer.Stop();
                return;
            }

            //populate add collab section
            textBox_creatorId.Text = item.CreatorId.ToString();
            textBox_playlistId_addCollab.Text = item.Value.ToString();
            //populate add song section
            textBox_playlistID_addSong.Text = item.Value.ToString();
            //populate song voting - playlistId
            textBox_playlistId_songVote.Text = item.Value.ToString();

            //populates playlists songs once clicked
            LoadPlaylistSongsAsync(item.Value.ToString());

            //start periodic refresh
            if (!_songRefreshTimer.Enabled)
            {
                _songRefreshTimer.Start();
            }
        }

        private void listBox_PlaylistSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            dynamic item = listBox_PlaylistSongs.SelectedItem;
            textBox_songId_songVote.Text = item.Value.ToString();
        }
    
        private async Task RefreshSongsPeriodically()
        {
            //if no playlist selected, no songs to update so does nothing
            dynamic playlistSelected = listBox_Playlists.SelectedItem;
            if(playlistSelected == null)
            {
                return;
            }

            string playlistId = playlistSelected.Value.ToString();

            //doesn't refresh if already working on it
            if(await _refreshLock.WaitAsync(0))
            {
                return;
            }

            try
            {
                await LoadPlaylistSongsAsync(playlistId);
                label_songUpdateStatus.Text = $"Songs updated at {DateTime.Now:T}";
            }
            finally
            {
                _refreshLock.Release();
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            //cleanup after playlist builder form closes
            _songRefreshTimer.Stop();
            _songRefreshTimer.Dispose();
            base.OnFormClosing(e);
        }
    }
}
