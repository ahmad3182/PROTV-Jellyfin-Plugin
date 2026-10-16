using System.Text.Json.Serialization;
using Newtonsoft.Json.Converters;

namespace PROTV.Abstractions.Common;

[JsonConverter(typeof(StringEnumConverter))]
public enum ChannelSort
{
	Id,
	Name,
	SecondName,
	ActivateDate,
	CreateDate,
	ModifiedDate,
	Random,
	Number
}
