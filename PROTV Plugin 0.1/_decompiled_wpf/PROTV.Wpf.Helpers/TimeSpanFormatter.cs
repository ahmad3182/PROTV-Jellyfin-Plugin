using System;
using System.Globalization;
using System.Windows;

namespace PROTV.Wpf.Helpers;

public class TimeSpanFormatter : BaseValueConverter<TimeSpanFormatter>
{
	public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		TimeSpan? timeSpan2;
		if (!(value is TimeSpan timeSpan))
		{
			if (value is Duration duration)
			{
				Duration duration2 = duration;
				if (oVxORNeQlCpPxZCPgi4.D35lls5iF(ref duration2, oVxORNeQlCpPxZCPgi4.k8ieXS7BAd))
				{
					timeSpan2 = nOITceef1fP5NFuVb8T.D35lls5iF(ref duration2, nOITceef1fP5NFuVb8T.MLPeFi5w6W);
					goto IL_007b;
				}
			}
			return string.Empty;
		}
		TimeSpan value2 = timeSpan;
		timeSpan2 = value2;
		goto IL_007b;
		IL_007b:
		if (B8EsrPe223yYTVY3q8k.D35lls5iF(timeSpan2.Value, TimeSpan.MinValue, B8EsrPe223yYTVY3q8k.FQDeZnp35T))
		{
			return iFZ5je3XFYKwkvcE5D.D35lls5iF(13886, iFZ5je3XFYKwkvcE5D.N06TeK0ao);
		}
		string text = iFZ5je3XFYKwkvcE5D.D35lls5iF(13896, iFZ5je3XFYKwkvcE5D.N06TeK0ao);
		object[] array = new object[4];
		TimeSpan value3 = timeSpan2.Value;
		array[0] = (int)LUSRjplVkOtM7DbdDL3.D35lls5iF(ref value3, LUSRjplVkOtM7DbdDL3.uvxejPr1Uh);
		value3 = timeSpan2.Value;
		array[1] = jKm2qyeyNVIxg5p6ynU.D35lls5iF(ref value3, jKm2qyeyNVIxg5p6ynU.G1Veqcwke8);
		value3 = timeSpan2.Value;
		array[2] = jKm2qyeyNVIxg5p6ynU.D35lls5iF(ref value3, jKm2qyeyNVIxg5p6ynU.NEMeJfSji7);
		value3 = timeSpan2.Value;
		array[3] = jKm2qyeyNVIxg5p6ynU.D35lls5iF(ref value3, jKm2qyeyNVIxg5p6ynU.C6KebmBiak);
		return hVwZOQeWVVUuf28XB1R.D35lls5iF(text, array, hVwZOQeWVVUuf28XB1R.QZGe52mDnd);
	}

	public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}

	public TimeSpanFormatter()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector();
	}
}
