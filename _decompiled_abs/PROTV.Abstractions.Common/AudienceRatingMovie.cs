using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace PROTV.Abstractions.Common;

[JsonConverter(typeof(StringEnumConverter))]
public enum AudienceRatingMovie
{
	General,
	R17,
	R18,
	PG13,
	PG14,
	PG15,
	PG,
	Unknown
}
