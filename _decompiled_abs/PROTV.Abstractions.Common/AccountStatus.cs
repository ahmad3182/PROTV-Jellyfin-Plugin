using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace PROTV.Abstractions.Common;

[JsonConverter(typeof(StringEnumConverter))]
public enum AccountStatus
{
	Active,
	Suspended,
	Frozen,
	TempActive,
	Deleted,
	Blocked,
	UnSubscribed,
	Removed
}
