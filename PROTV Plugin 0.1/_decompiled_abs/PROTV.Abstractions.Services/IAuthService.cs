using System.Threading.Tasks;
using PROTV.Abstractions.Common;
using PROTV.Abstractions.DataTransferObjects;

namespace PROTV.Abstractions.Services;

public interface IAuthService
{
	Task<Response<LoginResponseDto>> LoginAsync(string userName, string Password);

	string GetDeviceMACAddress();

	Task<string> GetRouterMACAddress();

	Task<string> GetDeviceIPAddress();

	Task<Response<LoginResponseDto>> RefreshTokenAsync();

	Task<Response<ClientResponseDto>> GetMeAsync();

	Task<Response<LoginResponseDto>> GetProfileAsync();

	Task<Response<PreferencesReponseDto>> GetPreferncesAsync();

	string GetDeviceModel();
}
