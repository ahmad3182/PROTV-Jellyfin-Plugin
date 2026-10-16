using System;
using System.Globalization;
using PROTV.Abstractions.Services;
using PROTV.Wpf.Bootstrap;

namespace PROTV.Wpf.Helpers;

public class ImageUrlConverter : BaseValueConverter<ImageUrlConverter>
{
	public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		IStoreContext storeContext = AppContainer.Resolve<IStoreContext>();
		return d27jrd3uD0dgsTkvn8k.D35lls5iF(storeContext != null && hjMnupQVVDlRZAYQJC.D35lls5iF(storeContext, hjMnupQVVDlRZAYQJC.YLV3Oa3St2), (value != null) ? wq2usy8gNndpuTw5mR.D35lls5iF(value, wq2usy8gNndpuTw5mR.ajcDe8nffb) : null, d27jrd3uD0dgsTkvn8k.fC53Pw5IkY);
	}

	public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}

	public ImageUrlConverter()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector();
	}
}
