using System;
using System.Globalization;
using System.Windows;

namespace PROTV.Wpf.Helpers;

public class TimeSpanToSecondsConverter : BaseValueConverter<TimeSpanToSecondsConverter>
{
	public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (parameter == null)
		{
			double num2;
			if (!(value is TimeSpan timeSpan))
			{
				if (value is Duration duration)
				{
					double num;
					if (!oVxORNeQlCpPxZCPgi4.D35lls5iF(ref duration, oVxORNeQlCpPxZCPgi4.k8ieXS7BAd))
					{
						num = 0.0;
					}
					else
					{
						TimeSpan timeSpan2 = nOITceef1fP5NFuVb8T.D35lls5iF(ref duration, nOITceef1fP5NFuVb8T.MLPeFi5w6W);
						num = LUSRjplVkOtM7DbdDL3.D35lls5iF(ref timeSpan2, LUSRjplVkOtM7DbdDL3.LAf3veRADK);
					}
					num2 = num;
				}
				else
				{
					num2 = 0.0;
				}
			}
			else
			{
				num2 = LUSRjplVkOtM7DbdDL3.D35lls5iF(ref timeSpan, LUSRjplVkOtM7DbdDL3.LAf3veRADK);
			}
			return num2;
		}
		if (!(value is TimeSpan timeSpan3))
		{
			if (value is Duration duration2)
			{
				string result;
				if (!oVxORNeQlCpPxZCPgi4.D35lls5iF(ref duration2, oVxORNeQlCpPxZCPgi4.k8ieXS7BAd))
				{
					result = iFZ5je3XFYKwkvcE5D.D35lls5iF(13996, iFZ5je3XFYKwkvcE5D.N06TeK0ao);
				}
				else
				{
					TimeSpan timeSpan2 = nOITceef1fP5NFuVb8T.D35lls5iF(ref duration2, nOITceef1fP5NFuVb8T.MLPeFi5w6W);
					result = HrpiJZGoPBjvFbQkn9K.D35lls5iF(ref timeSpan2, iFZ5je3XFYKwkvcE5D.D35lls5iF(13956, iFZ5je3XFYKwkvcE5D.N06TeK0ao), HrpiJZGoPBjvFbQkn9K.Wk8GliFt3m);
				}
				return result;
			}
			return iFZ5je3XFYKwkvcE5D.D35lls5iF(13996, iFZ5je3XFYKwkvcE5D.N06TeK0ao);
		}
		return (jKm2qyeyNVIxg5p6ynU.D35lls5iF(ref timeSpan3, jKm2qyeyNVIxg5p6ynU.jbFezbgdES) == 0) ? HrpiJZGoPBjvFbQkn9K.D35lls5iF(ref timeSpan3, iFZ5je3XFYKwkvcE5D.D35lls5iF(13980, iFZ5je3XFYKwkvcE5D.N06TeK0ao), HrpiJZGoPBjvFbQkn9K.Wk8GliFt3m) : HrpiJZGoPBjvFbQkn9K.D35lls5iF(ref timeSpan3, iFZ5je3XFYKwkvcE5D.D35lls5iF(13956, iFZ5je3XFYKwkvcE5D.N06TeK0ao), HrpiJZGoPBjvFbQkn9K.Wk8GliFt3m);
	}

	public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (!(value is double))
		{
			return 0.0;
		}
		TimeSpan timeSpan = SEiprnGHmVBJxvgPKIH.D35lls5iF(Xcc0NiG9FOtYWqkbCKW.D35lls5iF(10000000.0 * (double)value, Xcc0NiG9FOtYWqkbCKW.DhRGDaDn7Z), SEiprnGHmVBJxvgPKIH.z8vG1iaB80);
		if (YTBMa7G8kmj2EvUpZf9.D35lls5iF(targetType, sjYxHO8OWlc6X80hFj7.D35lls5iF(typeof(TimeSpan).TypeHandle, sjYxHO8OWlc6X80hFj7.uWZ8ugU7r5), YTBMa7G8kmj2EvUpZf9.bRuGnR8yaO))
		{
			return timeSpan;
		}
		if (!YTBMa7G8kmj2EvUpZf9.D35lls5iF(targetType, sjYxHO8OWlc6X80hFj7.D35lls5iF(typeof(Duration).TypeHandle, sjYxHO8OWlc6X80hFj7.uWZ8ugU7r5), YTBMa7G8kmj2EvUpZf9.bRuGnR8yaO))
		{
			return UqvPu7G3UxCtkkDAbOx.D35lls5iF(targetType, UqvPu7G3UxCtkkDAbOx.BqoGTW6fNd);
		}
		return new Duration(timeSpan);
	}

	public TimeSpanToSecondsConverter()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector();
	}
}
