using System.Threading.Tasks;
using PROTV.Abstractions.Common;
using PROTV.Abstractions.DataTransferObjects;
using PROTV.Abstractions.Search;
using Refit;

namespace PROTV.Abstractions.Apis;

[Headers(new string[] { "Authorization: Bearer" })]
public interface IQuranApi : IApi
{
	[Get("/api/Quran/Surahs")]
	Task<ResponseList<SurahResponseDto>> GetSurahsAsync([Query] ApiQuery<GeneralSearch, GeneralSort> query);

	[Get("/api/Quran/Recitators")]
	Task<ResponseList<RecitatorResponseDto>> GetRecitatorsAsync([Query] ApiQuery<GeneralSearch, GeneralSort> query);

	[Get("/api/Quran/Recitators/{id}")]
	Task<Response<RecitatorResponseDto>> GetRecitatorAsync([AliasAs("Id")] int Id);

	[Get("/api/Quran/Surahs/{id}")]
	Task<Response<SurahResponseDto>> GetSurahAsync([AliasAs("Id")] int Id);

	[Get("/api/Quran/Favorites")]
	Task<ResponseList<SongResponseDto>> GetSurahsFavoirte([Query] ApiQuery<GeneralSearch, GeneralSort> query);

	[Post("/api/Quran/ToggleFavorites")]
	Task<Response<bool>> ToggleSurahFavorite([Query] int Id);

	[Post("/api/Quran/Watch")]
	Task<Response<string>> AddSurahToWatch([Query] int SurahId);
}
