using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;

namespace PROTV.Wpf.Helpers;

public abstract class BaseValueConverter<T> : MarkupExtension, IValueConverter where T : class, new()
{
	private static T Converter;

	public override object ProvideValue(IServiceProvider serviceProvider)
	{
		return Converter ?? (Converter = new T());
	}

	public abstract object Convert(object value, Type targetType, object parameter, CultureInfo culture);

	public abstract object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture);

	protected BaseValueConverter()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector();
	}
}
