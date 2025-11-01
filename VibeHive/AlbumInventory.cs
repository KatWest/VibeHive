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
        private string grpcServerAddress = "https://localhost:7144";
        private List<AlbumModel> albumsList = new List<AlbumModel>();
        public AlbumInventory()
        {
            InitializeComponent();
        }

        // this video is very helpful
        // https://www.youtube.com/watch?v=kZ3rwpg3QJc 
        private async void AlbumInventory_Load(object sender, EventArgs e)
        {
            using var channel = GrpcChannel.ForAddress(grpcServerAddress);
            var client = new AlbumService.AlbumServiceClient(channel);

            await RunAllAlbums(client);
        }
        private async void addBtn_Click(object sender, EventArgs e)
        {
            using var channel = GrpcChannel.ForAddress(grpcServerAddress);
            var client = new AlbumService.AlbumServiceClient(channel);

            await RunAddAlbum(client);
        }


        private async Task RunAllAlbums(AlbumService.AlbumServiceClient client)
        {
            try
            {
                AlbumsResponse albums = await client.ListAlbumsAsync(new AllAlbumsRequest());

                if (albums != null && albums.Album != null && albums.Album.Count > 0)
                {
                    albumsList = [.. albums.Album];
                    albumsDgv.DataSource = albumsList;
                }
            }
            catch (RpcException rpcException)
            {
                Console.WriteLine("There was an error communicating with gRPC server");
                Console.WriteLine($"Code: {rpcException.StatusCode}, Status: {rpcException.Status}");

                MessageBox.Show($"There was an error communicating with gRPC server\nCode: {rpcException.StatusCode}, Status: {rpcException.Status}", "Error");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show($"ex", "Exception");
            }
        }
        private async Task RunAddAlbum(AlbumService.AlbumServiceClient client)
        {
            AlbumData albumData = new AlbumData();
            albumData.Title = titleTxb.Text.Trim();
            albumData.Artist = artistTxb.Text.Trim();
            albumData.Genre = genreTxb.Text.Trim();
            albumData.Year = (int)yearNud.Value;

            DialogResult result = MessageBox.Show($"Are you sure you want to add this ablum?\n\nAlbum Title: {albumData.Title}\nAlbum Artist: {albumData.Artist}\nGenre: {albumData.Genre}\nRelease Year: {albumData.Year}", "Confirm");

            if (result == DialogResult.Yes)
            {

            }
        }
    }
}
