using System.Threading.Tasks;
using PROTV.Abstractions.Common;
using PROTV.Abstractions.DataTransferObjects;
using PROTV.Abstractions.Search;

namespace PROTV.Abstractions.Apis;

public interface IPeopleService
{
	Task<ResponseList<PersonResponseDto>> GetPeopleAsync(ApiQuery<PeopleSearch, GeneralSort> query);

	Task<Response<PersonResponseDto>> GetPersonAsync(int Id);
}
