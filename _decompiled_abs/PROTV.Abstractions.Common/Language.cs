using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace PROTV.Abstractions.Common;

[JsonConverter(typeof(StringEnumConverter))]
public enum Language
{
	English,
	Arabic,
	Turkish,
	Japanese,
	Other
}
