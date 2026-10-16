using System;
using System.Globalization;
using System.Windows.Media.Imaging;

namespace PROTV.Wpf.Helpers;

public class ImageResourceConverter : BaseValueConverter<ImageResourceConverter>
{
	public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (value == null)
		{
			if (parameter == null)
			{
				return wS8IbsehRNRvhenFrrg.D35lls5iF(wS8IbsehRNRvhenFrrg.yj0exDwTsb);
			}
			if (S1a0wT9Ixre9OpDny8h.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(parameter, wq2usy8gNndpuTw5mR.ajcDe8nffb), iFZ5je3XFYKwkvcE5D.D35lls5iF(13550, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO))
			{
				return new BitmapImage(new Uri(iFZ5je3XFYKwkvcE5D.D35lls5iF(13574, iFZ5je3XFYKwkvcE5D.N06TeK0ao)));
			}
			return wS8IbsehRNRvhenFrrg.D35lls5iF(wS8IbsehRNRvhenFrrg.yj0exDwTsb);
		}
		if (S1a0wT9Ixre9OpDny8h.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(value, wq2usy8gNndpuTw5mR.ajcDe8nffb), "", S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO))
		{
			return wS8IbsehRNRvhenFrrg.D35lls5iF(wS8IbsehRNRvhenFrrg.yj0exDwTsb);
		}
		return value;
	}

	public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}

	public ImageResourceConverter()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector();
	}
}
