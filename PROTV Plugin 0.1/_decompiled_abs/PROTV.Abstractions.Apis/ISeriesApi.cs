using System.Threading.Tasks;
using PROTV.Abstractions.Common;
using PROTV.Abstractions.DataTransferObjects;
using PROTV.Abstractions.Search;
using Refit;

namespace PROTV.Abstractions.Apis;

[Headers(new string[] { "Authorization: Bearer" })]
public interface ISeriesApi : IApi
{
	[Get("/api/Series/{id}")]
	[Headers(new string[] { "Accept-Language: ar-AE" })]
	Task<Response<SeriesResponseDto>> GetSeriesDetailsAsync([AliasAs("id")] int Id);

	[Get("/api/Series")]
	Task<ResponseList<SeriesResponseDto>> GetSeriesAsync([Query] ApiQuery<SeriesSearch, SeriesSort> query);
}
