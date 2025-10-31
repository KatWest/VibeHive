using gRPCAlbumInventory;
using gRPCAlbumInventory.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddGrpc();
builder.Services.AddSingleton<gRPCAlbumInventory.Services.AlbumService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapGrpcService<gRPCAlbumInventory.Services.AlbumService>();

app.Run();
