using System.Collections.Generic;
using System.Threading.Tasks;
using PROTV.Abstractions.Common;
using PROTV.Abstractions.DataTransferObjects;
using PROTV.Abstractions.Search;
using Refit;

namespace PROTV.Abstractions.Apis;

[Headers(new string[] { "Authorization: Bearer" })]
public interface ILiveApi : IApi
{
	[Get("/api/Channels/{Id}")]
	Task<Response<ChannelResponseDto>> GetChannelAsync([AliasAs("id")] int Id);

	[Get("/api/Channels")]
	Task<ResponseList<ChannelResponseDto>> GetChannelsAsync([Query] ApiQuery<ChannelSearch, ChannelSort> query);

	[Get("/api/Channels/Favorites")]
	Task<ResponseList<ChannelResponseDto>> GetFavoritesAsync([Query] ApiQuery<ChannelSearch, ChannelSort> query);

	[Post("/api/Channels/ToggleFavorites/{id}")]
	Task<Response<bool>> ToggleFavoritesAsync([AliasAs("id")] int Id);

	[Post("/api/Channels/ToggleLock")]
	Task<Response<bool>> ToggleLockAsync([Query] int Id);

	[Post("/api/Channels/Watch")]
	Task<Response<string>> WatchAsync([Query] int Id);

	[Get("/api/Channels/EPG/{channelId}")]
	Task<Response<IEnumerable<EPGChannelResponseDto>>> GetChannelEPGAsync([AliasAs("channelId")] int ChannelId);

	[Get("/api/Channels/EPG/")]
	Task<Response<IEnumerable<EPGChannelResponseDto>>> GetChannelsEPGAsync([Query] ApiQuery<ChannelSearch, ChannelSort> query);

	[Get("/api/Channels/EPGs")]
	Task<Response<IEnumerable<EPGDataResponseDto>>> GetChannelsEPGsAsync([Query] ApiQuery<ChannelSearch, ChannelSort> query);
}
