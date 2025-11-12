using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VibeHive
{
    public partial class CollaborativePlaylistBuilder : Form
    {
        private static readonly HttpClient _httpClient = new HttpClient();
        private static readonly string apiBaseUrl = "https://localhost:5156/api";
        public CollaborativePlaylistBuilder()
        {
            InitializeComponent();
        }

        private async void CollaborativePlaylistBuilder_Load(object sender, EventArgs e)
        {
            await 
        }

        private void button_createPlaylist_Click(object sender, EventArgs e)
        {

        }

        private async Task LoadUsersAsync()
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync($"{apiBaseUrl}/users");
                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    var users = json.convert.DeserializeObject<List<UserDto>>(json);


                }
            }
        }

    }
}
