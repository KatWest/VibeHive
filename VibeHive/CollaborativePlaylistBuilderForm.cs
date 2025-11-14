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

namespace VibeHive
{
    public partial class CollaborativePlaylistBuilderForm : Form
    {
        private static readonly HttpClient _httpClient = new HttpClient();
        private static readonly string apiBaseUrl = "https://localhost:7235/api";
        public CollaborativePlaylistBuilderForm()
        {
            InitializeComponent();
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
            //Todo: do i need to verify user is auth to add song?
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
                int currentVotes = item.Votes.Count;

                var songVote = new
                {
                    songId = item.SongId,
                    playlistId = playlistId,
                    vote = newVote
                };

                var json = JsonConvert.SerializeObject(songVote);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await _httpClient.PostAsync($"{apiBaseUrl}/playlist/{playlistId}/vote", content);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show($"New song was added to the playlist successfully.");
                    LoadPlaylistSongsAsync(playlistId);
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

        private async Task LoadUsersAsync()
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync($"{apiBaseUrl}/user");
                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    var users = JsonConvert.DeserializeObject<List<UserDto>>(json);

                    listBox_users.DataSource = users.Select(u => new { Display = $"{u.id} - {u.name}", Value = u.id })
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
                        Display = $"{p.Id} - {p.Name} - {p.CreatedBy} - {p.isCollaborative}",
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
            //Todo: deal with loading without error when count =0;
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync($"{apiBaseUrl}/playlist/{playlistId}/rankings");
                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    var playlistSongs = JsonConvert.DeserializeObject<List<SongDto>>(json);

                    listBox_PlaylistSongs.DataSource = playlistSongs.Select(s => new
                    {
                        Display = $"{s.Id} - {s.Title} - {s.Artist} - {s.Genre} - {s.Duration} - {s.Votes}",
                        Value = s.Id
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
        }

        private void listBox_PlaylistSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            dynamic item = listBox_PlaylistSongs.SelectedItem;
            textBox_songId_songVote.Text = item.SongId.ToString();
        }
    }
}
