using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace PROTV.Abstractions.Common;

[JsonConverter(typeof(StringEnumConverter))]
public enum LanguageAr
{
	الأنكليزية,
	العربية,
	التركية,
	اليابانية,
	اخرى
}
