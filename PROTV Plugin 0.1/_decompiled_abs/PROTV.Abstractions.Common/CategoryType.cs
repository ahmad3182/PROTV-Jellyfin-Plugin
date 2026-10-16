using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace PROTV.Abstractions.Common;

[JsonConverter(typeof(StringEnumConverter))]
public enum CategoryType
{
	Movie,
	Series,
	Channel,
	Music,
	Show
}
