using PROTV.Abstractions.DataTransferObjects;

namespace PROTV.Abstractions.Services;

public interface IStoreContext
{
	string AppId { get; set; }

	string AppVersion { get; set; }

	string DeviceMacAddress { get; set; }

	string RouterMacAddress { get; set; }

	string IPAddress { get; set; }

	bool InternalConnectionStatus { get; set; }

	ClientResponseDto Client { get; set; }

	DeviceResponseDto Device { get; set; }

	ProfileResponseDto Profile { get; set; }

	PackageReponseDto Package { get; set; }

	ProviderSettingsReponseDto ProviderSetting { get; set; }

	string DeviceModel { get; set; }

	string PayDate { get; set; }

	string Token { get; set; }

	string RefreshToken { get; set; }

	string ConnectionStatus { get; set; }

	string Password { get; set; }

	string Email { get; set; }
}
