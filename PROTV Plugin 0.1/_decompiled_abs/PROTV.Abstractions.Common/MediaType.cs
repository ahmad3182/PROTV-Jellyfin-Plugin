using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace PROTV.Abstractions.Common;

[JsonConverter(typeof(StringEnumConverter))]
public enum MediaType
{
	Movie,
	Series,
	Season,
	Episode,
	Person,
	Album,
	Song,
	Surah
}
