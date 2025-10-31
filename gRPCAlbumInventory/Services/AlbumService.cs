using System.Collections.Concurrent;
using Grpc.Core;

namespace gRPCAlbumInventory.Services
{
    public class AlbumService : gRPCAlbumInventory.AlbumService.AlbumServiceBase
    {
        private static readonly ConcurrentDictionary<string, AlbumModel> albums = new();

        public override Task<AlbumModel> GetAlbum(AlbumId request, ServerCallContext context)
        {
            if (albums.TryGetValue(request.Id, out var album))
                return Task.FromResult(album);
            else
                throw new RpcException(new Status(StatusCode.NotFound, $"Album not found for the albumId that was provided {request.Id}"));
        }
        public override Task<AlbumModel> AddAlbum(AlbumData request, ServerCallContext context)
        {
            var albumID = Guid.NewGuid().ToString();
            var album = new AlbumModel
            {
                Id = albumID,
                Title = request.Title,
                Artist = request.Artist,
                Genre = request.Genre,
                Year = request.Year,
                Available = true
            };
            if (albums.TryAdd(albumID, album))
                return Task.FromResult(album);
            else
                throw new RpcException(new Status(StatusCode.Internal, "Failed to add new album"));
        }
        public override Task<AlbumId> UpdateAlbum(AlbumModel request, ServerCallContext context)
        {
            if (albums.TryGetValue(request.Id, out AlbumModel album))
            {
                albums[request.Id] = request;
                return Task.FromResult(new AlbumId { Id = album.Id });
            }
            else
                throw new RpcException(new Status(StatusCode.Internal, "Failed to update album"));
        }
        public override Task<AlbumData> DeleteAlbum(AlbumId request, ServerCallContext context)
        {
            if (albums.TryRemove(request.Id, out AlbumModel album))
                return Task.FromResult(new AlbumData
                {
                    Title = album.Title,
                    Artist = album.Artist,
                    Genre = album.Genre,
                    Year = album.Year,
                    Available = album.Available
                });
            else
                throw new RpcException(new Status(StatusCode.Internal, "Failed to remove album"));
        }
        public override Task<AlbumsResponse> ListAlbums(AllAlbumsRequest request, ServerCallContext context)
        {
            AlbumsResponse response = new AlbumsResponse();
            foreach (var album in albums)
                response.Album.Add(album.Value);
            return Task.FromResult(response);
        }
    }
}
