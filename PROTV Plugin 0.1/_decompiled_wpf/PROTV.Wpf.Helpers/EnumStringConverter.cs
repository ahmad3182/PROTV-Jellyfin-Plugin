using System;
using System.Globalization;
using PROTV.Abstractions.Common;

namespace PROTV.Wpf.Helpers;

public class EnumStringConverter : BaseValueConverter<EnumStringConverter>
{
	public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (value is SeriesSort)
		{
			return (SeriesSort)value switch
			{
				SeriesSort.ActivateDate => iFZ5je3XFYKwkvcE5D.D35lls5iF(13252, iFZ5je3XFYKwkvcE5D.N06TeK0ao), 
				SeriesSort.Name => iFZ5je3XFYKwkvcE5D.D35lls5iF(13266, iFZ5je3XFYKwkvcE5D.N06TeK0ao), 
				SeriesSort.Rating => iFZ5je3XFYKwkvcE5D.D35lls5iF(13278, iFZ5je3XFYKwkvcE5D.N06TeK0ao), 
				SeriesSort.ReleaseYear => iFZ5je3XFYKwkvcE5D.D35lls5iF(8566, iFZ5je3XFYKwkvcE5D.N06TeK0ao), 
				SeriesSort.Hot => iFZ5je3XFYKwkvcE5D.D35lls5iF(13290, iFZ5je3XFYKwkvcE5D.N06TeK0ao), 
				SeriesSort.New => iFZ5je3XFYKwkvcE5D.D35lls5iF(13300, iFZ5je3XFYKwkvcE5D.N06TeK0ao), 
				SeriesSort.Random => iFZ5je3XFYKwkvcE5D.D35lls5iF(13310, iFZ5je3XFYKwkvcE5D.N06TeK0ao), 
				SeriesSort.ModifiedDate => iFZ5je3XFYKwkvcE5D.D35lls5iF(13326, iFZ5je3XFYKwkvcE5D.N06TeK0ao), 
				_ => null, 
			};
		}
		if (value is MovieSort)
		{
			return (MovieSort)value switch
			{
				MovieSort.ActivateDate => iFZ5je3XFYKwkvcE5D.D35lls5iF(13252, iFZ5je3XFYKwkvcE5D.N06TeK0ao), 
				MovieSort.Name => iFZ5je3XFYKwkvcE5D.D35lls5iF(13266, iFZ5je3XFYKwkvcE5D.N06TeK0ao), 
				MovieSort.Rating => iFZ5je3XFYKwkvcE5D.D35lls5iF(13278, iFZ5je3XFYKwkvcE5D.N06TeK0ao), 
				MovieSort.ReleaseYear => iFZ5je3XFYKwkvcE5D.D35lls5iF(8566, iFZ5je3XFYKwkvcE5D.N06TeK0ao), 
				MovieSort.Hot => iFZ5je3XFYKwkvcE5D.D35lls5iF(13290, iFZ5je3XFYKwkvcE5D.N06TeK0ao), 
				MovieSort.New => iFZ5je3XFYKwkvcE5D.D35lls5iF(13300, iFZ5je3XFYKwkvcE5D.N06TeK0ao), 
				MovieSort.WatchCount => iFZ5je3XFYKwkvcE5D.D35lls5iF(13344, iFZ5je3XFYKwkvcE5D.N06TeK0ao), 
				MovieSort.Random => iFZ5je3XFYKwkvcE5D.D35lls5iF(13310, iFZ5je3XFYKwkvcE5D.N06TeK0ao), 
				MovieSort.ModifiedDate => iFZ5je3XFYKwkvcE5D.D35lls5iF(13326, iFZ5je3XFYKwkvcE5D.N06TeK0ao), 
				_ => null, 
			};
		}
		if (value is SeriesType)
		{
			return (SeriesType)value switch
			{
				SeriesType.Movie => iFZ5je3XFYKwkvcE5D.D35lls5iF(13358, iFZ5je3XFYKwkvcE5D.N06TeK0ao), 
				SeriesType.Series => iFZ5je3XFYKwkvcE5D.D35lls5iF(13404, iFZ5je3XFYKwkvcE5D.N06TeK0ao), 
				SeriesType.Show => iFZ5je3XFYKwkvcE5D.D35lls5iF(13444, iFZ5je3XFYKwkvcE5D.N06TeK0ao), 
				_ => null, 
			};
		}
		if (value is ChannelSort channelSort)
		{
			return channelSort switch
			{
				ChannelSort.Number => iFZ5je3XFYKwkvcE5D.D35lls5iF(13482, iFZ5je3XFYKwkvcE5D.N06TeK0ao), 
				ChannelSort.Name => iFZ5je3XFYKwkvcE5D.D35lls5iF(13266, iFZ5je3XFYKwkvcE5D.N06TeK0ao), 
				ChannelSort.Random => iFZ5je3XFYKwkvcE5D.D35lls5iF(13310, iFZ5je3XFYKwkvcE5D.N06TeK0ao), 
				_ => null, 
			};
		}
		if (value is string text)
		{
			if (!S1a0wT9Ixre9OpDny8h.D35lls5iF(text, iFZ5je3XFYKwkvcE5D.D35lls5iF(13498, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO))
			{
				if (S1a0wT9Ixre9OpDny8h.D35lls5iF(text, iFZ5je3XFYKwkvcE5D.D35lls5iF(13516, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO))
				{
					return iFZ5je3XFYKwkvcE5D.D35lls5iF(13532, iFZ5je3XFYKwkvcE5D.N06TeK0ao);
				}
				return ulZEdKePYK6Kl9wGM0E.D35lls5iF(text, '_', '-', ulZEdKePYK6Kl9wGM0E.i4yesekRFF);
			}
			return iFZ5je3XFYKwkvcE5D.D35lls5iF(13526, iFZ5je3XFYKwkvcE5D.N06TeK0ao);
		}
		return iFZ5je3XFYKwkvcE5D.D35lls5iF(13538, iFZ5je3XFYKwkvcE5D.N06TeK0ao);
	}

	public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}

	public EnumStringConverter()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector();
	}
}
