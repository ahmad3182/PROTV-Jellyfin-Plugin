using System.Threading.Tasks;
using PROTV.Abstractions.Common;

namespace PROTV.Abstractions.Services;

public interface IHistoryService
{
	Task<Response<string>> AddMediaToHistoryAsync(int Id, HistoryType history);
}
