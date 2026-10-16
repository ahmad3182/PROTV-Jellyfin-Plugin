using System.Collections.Generic;
using System.Threading.Tasks;
using PROTV.Abstractions.Common;
using PROTV.Abstractions.DataTransferObjects;
using PROTV.Abstractions.Search;
using Refit;

namespace PROTV.Abstractions.Apis;

[Headers(new string[] { "Authorization: Bearer" })]
public interface IMovieApi : IApi
{
	[Get("/api/Movies/{id}")]
	[Headers(new string[] { "Accept-Language: ar-AE" })]
	Task<Response<MovieResponseDto>> GetMovieAsync([AliasAs("id")] int Id);

	[Get("/api/Movies")]
	Task<ResponseList<MovieResponseDto>> GetMoviesAsync([Query] ApiQuery<MovieSearch, MovieSort> query);

	[Post("/api/Movies/Rent/{id}")]
	Task<Response<RentResponseDto>> RentMovieAsync([AliasAs("id")] int id);

	[Post("/api/Movies/Rate")]
	Task<Response<MovieResponseDto>> RateMovieAsync(RateMediaRequest rate);

	[Get("/api/Movies/CheckRent")]
	Task<Response<RentResponseDto>> CheckRentMovieAsync([Query] int movieId);

	[Get("/api/Movies/Favorites")]
	Task<ResponseList<MovieResponseDto>> GetFavoritesAsync([Query] ApiQuery<MovieSearch, GeneralSort> query);

	[Post("/api/Movies/ToggleFavorites/{id}")]
	Task<Response<bool>> ToggleFavoritesAsync([AliasAs("id")] int id);

	[Get("/api/Movies/{id}/Related")]
	Task<Response<IEnumerable<MovieResponseDto>>> GetRelatedMovieAsync([AliasAs("id")] int Id);
}
