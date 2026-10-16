using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace PROTV.Abstractions.Common;

[JsonConverter(typeof(StringEnumConverter))]
public enum CreditType
{
	Actor,
	Artist,
	Producer,
	Director,
	Writer,
	Musician,
	Other
}
