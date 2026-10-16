using System.Text.Json.Serialization;
using Newtonsoft.Json.Converters;

namespace PROTV.Abstractions.Common;

[JsonConverter(typeof(StringEnumConverter))]
public enum MovieSort
{
	Id,
	Name,
	SecondName,
	ActivateDate,
	CreateDate,
	ModifiedDate,
	Random,
	ReleaseYear,
	Rating,
	Hot,
	WatchCount,
	New
}
