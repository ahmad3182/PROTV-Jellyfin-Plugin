using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace PROTV.Abstractions.Common;

[JsonConverter(typeof(StringEnumConverter))]
public enum DeviceType
{
	General,
	Android,
	IOS,
	Desktop,
	Launcher,
	Web
}
