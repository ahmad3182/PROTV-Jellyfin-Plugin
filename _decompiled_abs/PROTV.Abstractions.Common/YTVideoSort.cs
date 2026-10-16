using System.Text.Json.Serialization;
using Newtonsoft.Json.Converters;

namespace PROTV.Abstractions.Common;

[JsonConverter(typeof(StringEnumConverter))]
public enum YTVideoSort
{
	Id,
	Name,
	SecondName,
	ActivateDate,
	CreateDate,
	ModifiedDate,
	Random,
	Index,
	Popularity,
	Rating,
	WatchCount,
	WatchLaterDate
}
