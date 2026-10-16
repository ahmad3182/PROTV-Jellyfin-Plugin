using System.Threading.Tasks;
using PROTV.Abstractions.Common;
using PROTV.Abstractions.DataTransferObjects;
using PROTV.Abstractions.Search;
using Refit;

namespace PROTV.Abstractions.Apis;

[Headers(new string[] { "Authorization: Bearer" })]
public interface ISeasonApi : IApi
{
	[Get("/api/Seasons/{id}")]
	Task<Response<SeasonResponseDto>> GetSeasonAsync([AliasAs("id")] int Id);

	[Get("/api/Seasons")]
	Task<ResponseList<SeasonResponseDto>> GetSeasonsAsync([Query] ApiQuery<SeriesSearch, SeriesSort> query);

	[Post("/api/Seasons/Rate")]
	Task<ResponseList<RateMediaResponseDto>> RateSeasonAsync(RateMediaRequest rate);

	[Get("/api/Episodes/{id}")]
	Task<Response<EpisodeResponseDto>> GetEpisodeAsync([AliasAs("id")] int Id);

	[Get("/api/Episodes")]
	Task<ResponseList<EpisodeResponseDto>> GetEpisodesAsync([Query] ApiQuery<SeriesSearch, SeriesSort> query);

	[Post("/api/Episodes/Rent/{id}")]
	Task<Response<RentResponseDto>> RentEpisodeAsync([AliasAs("id")] int episodeId);

	[Post("/api/Episodes/Rate")]
	Task<Response<RateMediaResponseDto>> RateEpisodeAsync(RateMediaRequest rate);

	[Get("/api/Episodes/CheckRent")]
	Task<Response<RateResponseDto>> CheckRentEpisodeAsync([Query] int episodeId);

	[Get("/api/Episodes/Favorites")]
	Task<ResponseList<EpisodeResponseDto>> GetFavoritesAsync([Query] ApiQuery<SeriesSearch, GeneralSort> query);

	[Post("/api/Episodes/ToggleFavorites")]
	Task<Response<bool>> ToggleFavoritesAsync([Query] int Id);
}
