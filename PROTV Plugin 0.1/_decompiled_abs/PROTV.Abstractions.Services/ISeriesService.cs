using System.Threading.Tasks;
using PROTV.Abstractions.Common;
using PROTV.Abstractions.DataTransferObjects;
using PROTV.Abstractions.Search;

namespace PROTV.Abstractions.Services;

public interface ISeriesService
{
	Task<ResponseList<SeriesResponseDto>> GetSeriesAsync(ApiQuery<SeriesSearch, SeriesSort> query);

	Task<Response<SeriesResponseDto>> GetSeriesDetailsAsync(int Id);
}
