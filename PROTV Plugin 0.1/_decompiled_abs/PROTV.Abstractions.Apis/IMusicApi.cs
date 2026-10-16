using System.Threading.Tasks;
using PROTV.Abstractions.Common;
using PROTV.Abstractions.DataTransferObjects;
using PROTV.Abstractions.Search;
using Refit;

namespace PROTV.Abstractions.Apis;

[Headers(new string[] { "Authorization: Bearer" })]
public interface IMusicApi : IApi
{
	[Get("/api/Albums")]
	Task<ResponseList<AlbumResponseDto>> GetAlbumsAsync([Query] ApiQuery<AlbumSearch, GeneralSort> query);

	[Get("/api/Albums/{id}")]
	Task<Response<AlbumResponseDto>> GetAlbumAsync([AliasAs("id")] int Id);

	[Get("/api/Songs")]
	Task<ResponseList<SongResponseDto>> GetSongsAsync([Query] ApiQuery<SongSearch, SongSort> query);

	[Get("/api/Songs/{id}")]
	Task<Response<SongResponseDto>> GetSongAsync([AliasAs("id")] int Id);

	[Get("/api/Songs/Favorites")]
	Task<ResponseList<SongResponseDto>> GetSongsFavoirte([Query] ApiQuery<GeneralSearch, GeneralSort> query);

	[Post("/api/Songs/ToggleFavorites/{id}")]
	Task<Response<bool>> ToggleSongFavorite([AliasAs("id")] int Id);

	[Post("/api/Songs/Watch")]
	Task<Response<string>> AddSongToWatch([Query] int SongId);
}
