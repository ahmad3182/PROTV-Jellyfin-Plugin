using System.Collections.Generic;
using System.Threading.Tasks;
using PROTV.Abstractions.Common;
using PROTV.Abstractions.DataTransferObjects;
using PROTV.Abstractions.Search;

namespace PROTV.Abstractions.Apis;

public interface ILiveService
{
	Task<Response<ChannelResponseDto>> GetChannelAsync(int Id);

	Task<ResponseList<ChannelResponseDto>> GetChannelsAsync(ApiQuery<ChannelSearch, ChannelSort> query);

	Task<bool> ToggleChannelFavoriteAsync(int Id);

	Task<ResponseList<ChannelResponseDto>> GetChannelFavoritesAAsync(ApiQuery<ChannelSearch, ChannelSort> query);

	Task<Response<IEnumerable<EPGDataResponseDto>>> GetChannelsEPGsAsync();
}
