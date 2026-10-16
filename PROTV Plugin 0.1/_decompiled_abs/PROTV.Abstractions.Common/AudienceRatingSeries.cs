using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace PROTV.Abstractions.Common;

[JsonConverter(typeof(StringEnumConverter))]
public enum AudienceRatingSeries
{
	General,
	TV_PG,
	TV_MA,
	TV_MiniSeries,
	TV_14,
	Unknown
}
