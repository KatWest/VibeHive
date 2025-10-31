using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AlbumInventoryClient;
using Grpc.Core;
using Grpc.Net.Client;

namespace VibeHive
{
    public partial class AlbumInventory : Form
    {
        public AlbumInventory()
        {
            InitializeComponent();
        }

        // this video is very helpful
        // https://www.youtube.com/watch?v=kZ3rwpg3QJc 
        private async void AlbumInventory_Load(object sender, EventArgs e)
        {
            using var channel = GrpcChannel.ForAddress("https://localhost:7144");
            var client = new AlbumService.AlbumServiceClient(channel);
        }
    }
}
