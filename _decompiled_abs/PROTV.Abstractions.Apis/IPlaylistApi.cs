using System.Threading.Tasks;
using PROTV.Abstractions.Common;
using PROTV.Abstractions.DataTransferObjects;
using PROTV.Abstractions.Search;
using Refit;

namespace PROTV.Abstractions.Apis;

[Headers(new string[] { "Authorization: Bearer" })]
public interface IPlaylistApi : IApi
{
	[Get("/api/Playlists")]
	Task<ResponseList<PlaylistResponseDto<T>>> GetPlaylistsAsync<T>([Query] ApiQuery<PlaylistSearch, GeneralSort> query);

	[Post("/api/Playlists")]
	Task<Response<PlaylistResponseDto<T>>> CreatePlaylistAsync<T>([Body] NewPlaylistRequest playlistDto);

	[Post("/api/Playlists/Remove")]
	Task<Response<string>> RemovePlaylistAsync([Body] UpdatePlaylistRequest playlistDto);

	[Post("/api/Playlists/Media")]
	Task<Response<string>> AddMediaToPlayList([Body] NewMediaToPlaylistRequest playlistDto);

	[Post("/api/Playlists/Media/Remove")]
	Task<Response<string>> RemoveMediaFromPlaylist([Body] NewMediaToPlaylistRequest playlistDto);

	[Post("/api/Playlists/Rename")]
	Task<Response<PlaylistResponseDto<T>>> RenamePlaylistAsync<T>([Body] UpdatePlaylistRequest playlist);
}
