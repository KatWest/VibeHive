using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
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

            await RunAllAlbums();
        }
        private async void addBtn_Click(object sender, EventArgs e)
        {
            using var channel = GrpcChannel.ForAddress(grpcServerAddress);
            var client = new AlbumService.AlbumServiceClient(channel);

            await RunAddAlbum(client);
        }
        private async void updateBtn_Click(object sender, EventArgs e)
        {
            using var channel = GrpcChannel.ForAddress(grpcServerAddress);
            var client = new AlbumService.AlbumServiceClient(channel);

            await RunUpdateAlbum(client);
        }
        private async void deleteBtn_Click(object sender, EventArgs e)
        {
            using var channel = GrpcChannel.ForAddress(grpcServerAddress);
            var client = new AlbumService.AlbumServiceClient(channel);

            AlbumId albumId = new AlbumId
            {
                Id = _albumId
            };

            DialogResult result = MessageBox.Show($"Are you sure you want to delete this ablum with id = {albumId.Id}", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    var response = client.DeleteAlbum(albumId);
                    MessageBox.Show($"Album successfully removed!\nBelow you can see the deleted album information:\n{FormatAlbum(response)}", "Complete");
                    resetDataInputs();
                    await RunAllAlbums();
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
            else
                MessageBox.Show("Album delete canceled", "Result");
        }
        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            using var channel = GrpcChannel.ForAddress(grpcServerAddress);
            var client = new AlbumService.AlbumServiceClient(channel);

            await RunAllAlbums();
        }
        private void clearBtn_Click(object sender, EventArgs e)
        {
            resetDataInputs();
        }


        private string _albumId = "";
        private async Task RunAllAlbums()
        {
            using var channel = GrpcChannel.ForAddress(grpcServerAddress);
            var client = new AlbumService.AlbumServiceClient(channel);

            try
            {
                AlbumsResponse albums = await client.ListAlbumsAsync(new AllAlbumsRequest());
                albumsList = [.. albums.Album];
                albumsDgv.DataSource = albumsList;
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

            DialogResult result = MessageBox.Show($"Are you sure you want to add this ablum?\n\n{FormatAlbum(albumData)}", "Confirm", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                try
                {
                    var response = client.AddAlbum(albumData);
                    MessageBox.Show($"New Album successfully added!\nBelow you can see the album information with assigned IDs from the server:\n{FormatAlbum(response)}", "Complete");
                    _albumId = response.Id;
                    await RunAllAlbums();
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
            else
                MessageBox.Show("Album add canceled", "Result");
        }
        private async Task RunUpdateAlbum(AlbumService.AlbumServiceClient client)
        {
            if (_albumId != null || _albumId != "")
            {
                AlbumModel albumModel = new AlbumModel();
                albumModel.Id = _albumId;
                albumModel.Title = titleTxb.Text.Trim();
                albumModel.Artist = artistTxb.Text.Trim();
                albumModel.Genre = genreTxb.Text.Trim();
                albumModel.Year = (int)yearNud.Value;

                DialogResult result = MessageBox.Show($"Are you sure you want to update this ablum?\n\nAlbum Title: {albumModel.Title}\nAlbum Artist: {albumModel.Artist}\nGenre: {albumModel.Genre}\nRelease Year: {albumModel.Year}", "Confirm", MessageBoxButtons.YesNo);
                if (result != DialogResult.Yes)
                {
                    try
                    {
                        var response = client.UpdateAlbum(albumModel);
                        MessageBox.Show($"Album with id = {response.Id} successfully updated!", "Complete");
                        await RunAllAlbums();
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
                else
                    MessageBox.Show("Album update canceled", "Result");
            }
        }
        private void albumsDgv_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var dvg = sender as DataGridView;
            var rowData = dvg.Rows[e.RowIndex];
            var album = rowData.DataBoundItem as AlbumModel;

            _albumId = album.Id;
            titleTxb.Text = album.Title;
            artistTxb.Text = album.Artist;
            genreTxb.Text = album.Genre;
            yearNud.Value = album.Year;
        }

        private string FormatAlbum(AlbumModel model)
        {
            if (model != null)
            {
                return $"Album ID: {model.Id}\n" +
                        $"Title: {model.Title}\n" +
                        $"Artist: {model.Artist}\n" +
                        $"Genre: {model.Genre}\n" +
                        $"Publication Year: {model.Year}" +
                        $"Avalable?: {(model.Available ? "Yes" : "No")}";
            }
            else return "";
        }
        private string FormatAlbum(AlbumData data)
        {
            if (data != null)
            {
                return $"Title: {data.Title}\n" +
                        $"Artist: {data.Artist}\n" +
                        $"Genre: {data.Genre}\n" +
                        $"Publication Year: {data.Year}";
            }
            else return "";
        }
        private void resetDataInputs()
        {
            titleTxb.Text = "";
            artistTxb.Text = "";
            genreTxb.Text = "";
            yearNud.Value = 0;
            _albumId = "";
        }
    }
}
