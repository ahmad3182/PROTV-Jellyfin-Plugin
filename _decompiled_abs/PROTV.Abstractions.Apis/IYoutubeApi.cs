using System.Threading.Tasks;
using PROTV.Abstractions.Common;
using PROTV.Abstractions.DataTransferObjects;
using PROTV.Abstractions.Search;
using Refit;

namespace PROTV.Abstractions.Apis;

[Headers(new string[] { "Authorization: Bearer" })]
public interface IYoutubeApi : IApi
{
	[Get("/api/Youtube/HomePage")]
	Task<Response<YTHomePageResponseDto>> GetHomePageVideosAsync();

	[Get("/api/Youtube/Videos/{id}")]
	Task<Response<YTVideoResponseDto>> GetVideoAsync([AliasAs("id")] int Id);

	[Get("/api/Youtube/Videos")]
	Task<ResponseList<YTVideoResponseDto>> GetVideosAsync([Query] ApiQuery<YTSearch, YTVideoSort> query);

	[Post("/api/Youtube/Videos/{Id}/ToggleWatchLater")]
	Task<Response<bool>> ToggleWatchLaterAsync([AliasAs("id")] int Id);

	[Post("/api/Youtube/Videos/Like")]
	Task<Response<YTReactionResponseDto>> ReactYoutubeVideoAsync([Body] ReactYtVideoRequest request);

	[Get("/api/Youtube/Playlists/{id}")]
	Task<Response<YTPlaylisTResponseDto>> GetPlaylistAsync([AliasAs("id")] int Id);

	[Get("/api/Youtube/Playlists")]
	Task<ResponseList<YTPlaylisTResponseDto>> GetPlaylistsAsync([Query] ApiQuery<YTSearch, GeneralSort> query);

	[Get("/api/Youtube/Channels/{id}")]
	Task<Response<YTChannelResponseDto>> GetChannelAsync([AliasAs("id")] int Id);

	[Get("/api/Youtube/Channels")]
	Task<ResponseList<YTChannelResponseDto>> GetChannelsAsync([Query] ApiQuery<YTSearch, YTChannelSort> query);

	[Post("/api/Youtube/Channels/{Id}/ToggleSubscribe")]
	Task<Response<bool>> ToggleSubscribeChannelAsync([AliasAs("id")] int Id);

	[Get("/api/Youtube/History")]
	Task<ResponseList<YTHistoryResponseDto>> GetHistoryAsync([Query] ApiQuery<YTSearch, GeneralSort> query);

	[Post("/api/Youtube/History")]
	Task<Response<YTHistoryResponseDto>> AddVideoToHistoryAsync([Body] YTHistoryRequest request);

	[Delete("/api/Youtube/History/{Id}")]
	Task<Response<string>> DeleteHistoryAsync([AliasAs("Id")] int Id);

	[Delete("/api/Youtube/History/Clear")]
	Task<Response<string>> ClearHistoryAsync();
}
