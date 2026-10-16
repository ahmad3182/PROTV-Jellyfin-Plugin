using System.Threading.Tasks;
using PROTV.Abstractions.Common;
using PROTV.Abstractions.DataTransferObjects;
using Refit;

namespace PROTV.Abstractions.Apis;

public interface IAuthApi : IApi
{
	[Post("/api/Account/Login")]
	[Headers(new string[] { "Accept-Language: en-US", "device-type: Desktop", "device-os: Windows10", "push-token: ", "notification-token: " })]
	Task<Response<LoginResponseDto>> LoginAsync([Body] LoginApiRequest loginApiRequest, [Header("app-version")] string appVersion, [Header("app-id")] string appId, [Header("device-mac-address")] string DeviceMacAddress, [Header("router-mac-address")] string RouterMacAddress, [Header("device-ip")] string ipAddress, [Header("device-model")] string model);

	[Post("/api/Account/RefreshToken")]
	[Headers(new string[] { "Accept-Language: en-US", "device-type: Desktop", "device-os: Windows10", "push-token: ", "notification-token: " })]
	Task<Response<LoginResponseDto>> RefreshTokenAsync([Header("refresh-token")] string oldRefreshToken, [Header("app-version")] string appVersion, [Header("app-id")] string appId, [Header("device-mac-address")] string DeviceMacAddress, [Header("router-mac-address")] string RouterMacAddress, [Header("device-ip")] string ipAddress, [Header("device-model")] string model);

	[Headers(new string[] { "Authorization: Bearer" })]
	[Get("/api/Account/Me")]
	Task<Response<ClientResponseDto>> GetMeAsync();

	[Headers(new string[] { "Authorization: Bearer" })]
	[Get("/api/Account/Profile")]
	Task<Response<LoginResponseDto>> GetProfileAsync();

	[Headers(new string[] { "Authorization: Bearer" })]
	[Get("/api/Account/Preferences")]
	Task<Response<PreferencesReponseDto>> GetPreferncesAsync();
}
