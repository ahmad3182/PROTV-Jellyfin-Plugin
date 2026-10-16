using System.Threading.Tasks;
using PROTV.Abstractions.Common;
using PROTV.Abstractions.DataTransferObjects;
using PROTV.Abstractions.Search;
using Refit;

namespace PROTV.Abstractions.Apis;

[Headers(new string[] { "Authorization: Bearer" })]
public interface IPeopleApi : IApi
{
	[Get("/api/People")]
	Task<ResponseList<PersonResponseDto>> GetPeopleAsync([Query] ApiQuery<PeopleSearch, GeneralSort> query);

	[Get("/api/People/{id}")]
	Task<Response<PersonResponseDto>> GetPersonAsync([AliasAs("id")] int Id);
}
