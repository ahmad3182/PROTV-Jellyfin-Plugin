using System;
using System.Globalization;
using System.Windows;
using PROTV.Wpf.ViewModels;

namespace PROTV.Wpf.Helpers;

public class BoolToMarginConverter : BaseValueConverter<BoolToMarginConverter>
{
	public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (value is bool)
		{
			return ((bool)value) ? new Thickness(0.0, 0.0, 0.0, 0.0) : new Thickness(0.0, 45.0, 0.0, 0.0);
		}
		if (value is PlaylistItemType)
		{
			return ((PlaylistItemType)value == PlaylistItemType.TvChannel) ? new Thickness(0.0, 0.0, 0.0, 120.0) : new Thickness(0.0, 0.0, 0.0, 175.0);
		}
		return new Thickness(0.0, 0.0, 0.0, 0.0);
	}

	public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}

	public BoolToMarginConverter()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector();
	}
}
