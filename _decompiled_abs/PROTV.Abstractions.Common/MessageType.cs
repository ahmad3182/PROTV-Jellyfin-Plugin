using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace PROTV.Abstractions.Common;

[JsonConverter(typeof(StringEnumConverter))]
public enum MessageType
{
	Message,
	Complain,
	Suggest,
	Note,
	Appreciate,
	Inquery,
	Other
}
