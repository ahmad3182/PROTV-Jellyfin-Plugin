using System.Collections.Generic;
using System.Threading.Tasks;
using PROTV.Abstractions.Common;
using PROTV.Abstractions.DataTransferObjects;
using PROTV.Abstractions.Search;

namespace PROTV.Abstractions.Apis;

public interface IMovieService
{
	Task<Response<MovieResponseDto>> GetMovieAsync(int Id);

	Task<ResponseList<MovieResponseDto>> GetMoviesAsync(ApiQuery<MovieSearch, MovieSort> query);

	Task<Response<RentResponseDto>> RentMovieAsync(int Id);

	Task<Response<IEnumerable<MovieResponseDto>>> GetRelatedMovieAsync(int Id);

	Task<Response<bool>> ToggleFavoritesAsync(int Id);
}
