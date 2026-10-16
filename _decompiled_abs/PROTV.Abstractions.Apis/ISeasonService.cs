using System.Threading.Tasks;
using PROTV.Abstractions.Common;
using PROTV.Abstractions.DataTransferObjects;
using PROTV.Abstractions.Search;

namespace PROTV.Abstractions.Apis;

public interface ISeasonService
{
	Task<Response<EpisodeResponseDto>> GetEpisodeAsync(int Id);

	Task<ResponseList<EpisodeResponseDto>> GetEpisodesAsync(ApiQuery<SeriesSearch, SeriesSort> query);

	Task<Response<SeasonResponseDto>> GetSeasonAsync(int Id);

	Task<ResponseList<SeasonResponseDto>> GetSeasonsAsync(ApiQuery<SeriesSearch, SeriesSort> query);

	Task<Response<RentResponseDto>> RentEpisodeAsync(int Id);
}
