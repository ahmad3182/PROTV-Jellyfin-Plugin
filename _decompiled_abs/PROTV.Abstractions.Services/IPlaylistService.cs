using System.Threading.Tasks;
using PROTV.Abstractions.Common;
using PROTV.Abstractions.DataTransferObjects;
using PROTV.Abstractions.Search;

namespace PROTV.Abstractions.Services;

public interface IPlaylistService
{
	Task<ResponseList<PlaylistResponseDto<T>>> GetPlaylistsAsync<T>(ApiQuery<PlaylistSearch, GeneralSort> query);

	Task<Response<PlaylistResponseDto<T>>> CreatePlaylisAsyncAsync<T>(string name);

	Task<Response<string>> AddMediaToPlayListAsync(int MediaId, int PlaylistId);

	Task<Response<string>> RemoveMediaFromPlaylist(int MediaId, int PlaylistId);

	Task<Response<PlaylistResponseDto<T>>> UpdatePlaylisAsyncAsync<T>(int MediaId, string title);

	Task<Response<string>> RemovPlaylistAsync(int Id);
}
