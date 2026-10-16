using System.Collections.Generic;
using System.Threading.Tasks;
using PROTV.Abstractions.Common;
using PROTV.Abstractions.DataTransferObjects;
using PROTV.Abstractions.Search;
using Refit;

namespace PROTV.Abstractions.Apis;

[Headers(new string[] { "Authorization: Bearer" })]
public interface IAppApi : IApi
{
	[Post("/api/Support/SendMessage")]
	Task<Response<ClientMessageResponseDto>> SendMessageAsync([Body] ClientMessageRequest clientMessage);

	[Post("/api/Support/SendRequest")]
	Task<Response<ClientRequestResponseDto>> SendRequestAsync([Body] ClientRequestRequest clientRequest);

	[Get("/api/Devices")]
	Task<ResponseList<DeviceResponseDto>> GetDevicesAsync([Query] ApiQuery<GeneralSearch, GeneralSort> query);

	[Get("/api/Devices/Current")]
	Task<Response<DeviceResponseDto>> GetCurrentDeviceAsync();

	[Delete("/api/Devices/Terminate")]
	Task<Response<string>> TerminateDeviceAsync([Query] string DeviceId);

	[Get("/api/Meta/Cities")]
	Task<ResponseList<CityResponseDto>> GetCitiesAsync([Query] ApiQuery<GeneralSearch, GeneralSort> query);

	[Get("/api/Meta/Weather/{cityId}")]
	Task<Response<WeatherResponseDto>> GetCityWeatherAsync([Query] int CityId);

	[Get("/api/Meta/Weather")]
	Task<Response<WeatherResponseDto>> GetWeatherAsync([Query] string longitude, [Query] string latitude);

	[Get("/api/Meta/Categories")]
	Task<ResponseList<CategoryResponseDto>> GetCategoriesAsync([Query] ApiQuery<CategorySearch, GeneralSort> query);

	[Get("/api/Meta/Languages")]
	Task<Response<List<LanguageResponseDto>>> GetLanguagesAsync();

	[Get("/api/Meta/LatestVersion")]
	Task<Response<AppVersionResponseDto>> GetLatestVersionAsync();

	[Get("/api/Meta/Gallery")]
	Task<ResponseList<GalleryImageResponseDto>> GetGalleryAsync([Query] ApiQuery<GallerySearch, GeneralSort> query);

	[Get("/api/Meta/Entertainment")]
	Task<Response<EntertainmentResponseDto>> GetEntertainmentAsync();
}
