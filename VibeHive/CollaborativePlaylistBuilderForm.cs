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

        private void button_AddCollaborator_Click(object sender, EventArgs e)
        {

        }

        private void button_addSong_Click(object sender, EventArgs e)
        {

        }

        private void button_Vote_Click(object sender, EventArgs e)
        {

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

                    listBox_Playlists.DataSource = playlists.Select(p => new { Display = $"{p.Id} - {p.Name} - {p.CreatedBy} - {p.isCollaborative}", Value = p.Id })
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
                HttpResponseMessage response = await _httpClient.GetAsync($"{apiBaseUrl}/{playlistId}/playlist/rankings");
                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    var playlistSongs = JsonConvert.DeserializeObject<List<PlaylistDto>>(json);

                    listBox_PlaylistSongs.DataSource = playlistSongs.Select(p => new { Display = $"{p.Id} - {p.Name} - {p.CreatedBy} - {p.isCollaborative}", Value = p.Id })
                    .ToList();
                    listBox_Playlists.DisplayMember = "Display";
                    listBox_Playlists.ValueMember = "Value";
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
    }
}
