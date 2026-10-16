using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows;
using PROTV.Abstractions.Common;

namespace PROTV.Wpf.Helpers;

public class TextLanguageConverter : BaseValueConverter<TextLanguageConverter>
{
	public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (value is Language && (Language)value == Language.Arabic)
		{
			return HorizontalAlignment.Right;
		}
		if (value is Language)
		{
			return HorizontalAlignment.Left;
		}
		Regex regex = new Regex(iFZ5je3XFYKwkvcE5D.D35lls5iF(13778, iFZ5je3XFYKwkvcE5D.N06TeK0ao));
		if (value is string && VMs7lU9URBMKdJRC1h1.D35lls5iF(regex, (string)value, VMs7lU9URBMKdJRC1h1.htCeixeaqX))
		{
			if (parameter == null)
			{
				return HorizontalAlignment.Right;
			}
			return FlowDirection.RightToLeft;
		}
		if (parameter == null)
		{
			return HorizontalAlignment.Left;
		}
		return FlowDirection.LeftToRight;
	}

	public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}

	public TextLanguageConverter()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector();
	}
}
