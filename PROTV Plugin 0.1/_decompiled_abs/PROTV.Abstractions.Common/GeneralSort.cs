using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace PROTV.Abstractions.Common;

[JsonConverter(typeof(StringEnumConverter))]
public enum GeneralSort
{
	Id,
	Name,
	SecondName,
	Number,
	Rating,
	Hottness,
	Popularity,
	Index,
	ReleaseYear,
	CreateDate,
	ActivateDate,
	ModifiedDate,
	Random
}
