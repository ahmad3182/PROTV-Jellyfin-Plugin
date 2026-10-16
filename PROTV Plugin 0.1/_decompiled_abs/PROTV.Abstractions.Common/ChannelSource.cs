using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace PROTV.Abstractions.Common;

[JsonConverter(typeof(StringEnumConverter))]
public enum ChannelSource
{
	OSN,
	Bein,
	FTA,
	NetFlix,
	PROTVHD,
	Internet,
	Private
}
