using System.Threading.Tasks;
using PROTV.Abstractions.Common;
using PROTV.Abstractions.DataTransferObjects;
using PROTV.Abstractions.Search;

namespace PROTV.Abstractions.Apis;

public interface IQuranService
{
	Task<Response<RecitatorResponseDto>> GetRecitatorAsync(int Id);

	Task<ResponseList<RecitatorResponseDto>> GetRecitatorsAsync(ApiQuery<GeneralSearch, GeneralSort> query);

	Task<Response<SurahResponseDto>> GetSurahAsync(int Id);

	Task<ResponseList<SurahResponseDto>> GetSurahsAsync(ApiQuery<GeneralSearch, GeneralSort> query);
}
