using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace PROTV.Abstractions.Common;

[JsonConverter(typeof(StringEnumConverter))]
public enum PersonType
{
	Actor,
	Singer,
	Director,
	Writer,
	Other
}
