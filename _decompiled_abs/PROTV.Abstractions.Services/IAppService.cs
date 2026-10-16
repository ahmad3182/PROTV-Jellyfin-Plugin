using System.Collections.Generic;
using System.Threading.Tasks;
using PROTV.Abstractions.Common;
using PROTV.Abstractions.DataTransferObjects;
using PROTV.Abstractions.Search;

namespace PROTV.Abstractions.Services;

public interface IAppService
{
	Task<Response<ClientMessageResponseDto>> SendMessageAsync(ClientMessageRequest clientMessage);

	Task<Response<ClientRequestResponseDto>> SendRequestAsync(ClientRequestRequest clientRequest);

	Task<ResponseList<DeviceResponseDto>> GetDevicesAsync(ApiQuery<GeneralSearch, GeneralSort> query);

	Task<Response<DeviceResponseDto>> GetCurrentDeviceAsync();

	Task<Response<string>> TerminateDeviceAsync(string deviceId);

	Task<ResponseList<CityResponseDto>> GetCitiesAsync(ApiQuery<GeneralSearch, GeneralSort> query);

	Task<Response<WeatherResponseDto>> GetCityWeatherAsync(int Id);

	Task<Response<WeatherResponseDto>> GetWeatherAsync(string lan, string lon);

	Task<ResponseList<CategoryResponseDto>> GetCategoriesAsync(ApiQuery<CategorySearch, GeneralSort> query);

	Task<Response<List<LanguageResponseDto>>> GetLanguagesAsync();

	Task<Response<AppVersionResponseDto>> GetLatestVersionAsync();

	Task<ResponseList<GalleryImageResponseDto>> GetGalleryImagesAsync(ApiQuery<GallerySearch, GeneralSort> query);

	Task<Response<EntertainmentResponseDto>> GetEntertainmentAsync();
}
