using System.Collections.Generic;
using System.Threading.Tasks;
using PROTV.Abstractions.Common;
using PROTV.Abstractions.DataTransferObjects;
using PROTV.Abstractions.Search;

namespace PROTV.Abstractions.Services;

public interface IMusicService
{
	Task<Response<string>> AddSongToWatchAsync(int Id);

	Task<AlbumResponseDto> GetAlbumAsync(int Id);

	Task<ResponseList<AlbumResponseDto>> GetAlbumListAsync(ApiQuery<AlbumSearch, GeneralSort> query);

	Task<SongResponseDto> GetSongAsync(int Id);

	Task<List<SongResponseDto>> GetSongsFavoirteAsync(ApiQuery<GeneralSearch, GeneralSort> query);

	Task<ResponseList<SongResponseDto>> GetSongsListAsync(ApiQuery<SongSearch, SongSort> query);

	Task<bool> ToggleSongFavoriteAsync(int Id);
}
