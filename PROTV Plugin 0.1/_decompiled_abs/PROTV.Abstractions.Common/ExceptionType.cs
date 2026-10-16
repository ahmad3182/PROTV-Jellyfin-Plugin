using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace PROTV.Abstractions.Common;

[JsonConverter(typeof(StringEnumConverter))]
public enum ExceptionType
{
	Unknown,
	AuthorizationTokenInvalid,
	OldVersion,
	NoInternet,
	LoginFaild,
	NoNetwork,
	AlreadyExist,
	InvalidInput
}
