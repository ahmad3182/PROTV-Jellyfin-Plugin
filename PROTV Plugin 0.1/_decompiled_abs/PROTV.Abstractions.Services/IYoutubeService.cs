using System.Collections.Generic;
using System.Threading.Tasks;
using PROTV.Abstractions.Common;
using PROTV.Abstractions.DataTransferObjects;
using PROTV.Abstractions.Search;

namespace PROTV.Abstractions.Services;

public interface IYoutubeService
{
	Task<bool> AddVideoToHistoryAsync(int Id);

	Task<bool> ClearHistoryAsync();

	Task<bool> DeleteVideoFromHistoryAsync(int Id);

	Task<YTChannelResponseDto> GetChannelAsync(int Id);

	Task<ResponseList<YTChannelResponseDto>> GetChannelListAsync(ApiQuery<YTSearch, YTChannelSort> query);

	Task<Response<YTHomePageResponseDto>> GetHomePageVideosAsync();

	Task<YTPlaylisTResponseDto> GetPlaylistAsync(int Id);

	Task<List<YTPlaylisTResponseDto>> GetPlaylistListAsync(ApiQuery<YTSearch, GeneralSort> query);

	Task<YTVideoResponseDto> GetVideoAsync(int Id);

	Task<ResponseList<YTHistoryResponseDto>> GetVideoHistoryAsync(ApiQuery<YTSearch, GeneralSort> query);

	Task<ResponseList<YTVideoResponseDto>> GetVideoListAsync(ApiQuery<YTSearch, YTVideoSort> query);

	Task<int?> ReactYoutubeVideoAsync(int Id, int like);

	Task<bool> ToggleSubscribeChannelAsync(int Id);

	Task<bool> ToggleWatchLaterAsync(int Id);
}
