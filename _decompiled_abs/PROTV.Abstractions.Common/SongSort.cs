using System.Text.Json.Serialization;
using Newtonsoft.Json.Converters;

namespace PROTV.Abstractions.Common;

[JsonConverter(typeof(StringEnumConverter))]
public enum SongSort
{
	Id,
	Name,
	SecondName,
	ActivateDate,
	CreateDate,
	ModifiedDate,
	Random,
	ReleaseYear,
	Index,
	Hot,
	WatchCount
}
