using System.Threading.Tasks;
using PROTV.Abstractions.Common;
using PROTV.Abstractions.DataTransferObjects;
using PROTV.Abstractions.Search;
using Refit;

namespace PROTV.Abstractions.Apis;

[Headers(new string[] { "Authorization: Bearer" })]
public interface IHistoryApi : IApi
{
	[Get("/api/History")]
	Task<ResponseList<PlaylistResponseDto<T>>> GetHistoryAsync<T>([Query] ApiQuery<HistorySearch, GeneralSort> query);

	[Delete("/api/History/Clear")]
	Task<Response<string>> ClearHistoryAsync([Query] HistoryType type);

	[Delete("/api/History")]
	Task<Response<string>> RemoveMediaFromHistoryAsync([Body] NewMediaToHistoryRequest historyDto);

	[Post("/api/History")]
	Task<Response<string>> AddMediaToHistoryAsync([Body] NewMediaToHistoryRequest historyDto);
}
