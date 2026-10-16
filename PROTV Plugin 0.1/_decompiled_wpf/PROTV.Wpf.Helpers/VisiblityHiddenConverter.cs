using System;
using System.Globalization;
using System.Windows;
using System.Windows.Navigation;

namespace PROTV.Wpf.Helpers;

public class VisiblityHiddenConverter : BaseValueConverter<VisiblityHiddenConverter>
{
	public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (value is bool flag)
		{
			if (S1a0wT9Ixre9OpDny8h.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(parameter, wq2usy8gNndpuTw5mR.ajcDe8nffb), iFZ5je3XFYKwkvcE5D.D35lls5iF(14002, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO))
			{
				return (!flag) ? Visibility.Hidden : Visibility.Visible;
			}
			if (S1a0wT9Ixre9OpDny8h.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(parameter, wq2usy8gNndpuTw5mR.ajcDe8nffb), iFZ5je3XFYKwkvcE5D.D35lls5iF(14018, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO))
			{
				return flag ? Visibility.Hidden : Visibility.Visible;
			}
			if (S1a0wT9Ixre9OpDny8h.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(parameter, wq2usy8gNndpuTw5mR.ajcDe8nffb), iFZ5je3XFYKwkvcE5D.D35lls5iF(14104, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO))
			{
				return flag ? NavigationUIVisibility.Visible : NavigationUIVisibility.Hidden;
			}
		}
		if (value == null)
		{
			if (S1a0wT9Ixre9OpDny8h.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(parameter, wq2usy8gNndpuTw5mR.ajcDe8nffb), iFZ5je3XFYKwkvcE5D.D35lls5iF(14002, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO))
			{
				return Visibility.Hidden;
			}
			if (S1a0wT9Ixre9OpDny8h.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(parameter, wq2usy8gNndpuTw5mR.ajcDe8nffb), iFZ5je3XFYKwkvcE5D.D35lls5iF(14018, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO))
			{
				return Visibility.Visible;
			}
		}
		if (value is string text)
		{
			if (S1a0wT9Ixre9OpDny8h.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(parameter, wq2usy8gNndpuTw5mR.ajcDe8nffb), iFZ5je3XFYKwkvcE5D.D35lls5iF(14002, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO))
			{
				return M6ZErPEr2LZyWYpa5O.D35lls5iF(text, M6ZErPEr2LZyWYpa5O.tZ53SRMKfw) ? Visibility.Hidden : Visibility.Visible;
			}
			if (S1a0wT9Ixre9OpDny8h.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(parameter, wq2usy8gNndpuTw5mR.ajcDe8nffb), iFZ5je3XFYKwkvcE5D.D35lls5iF(14018, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO))
			{
				return (!M6ZErPEr2LZyWYpa5O.D35lls5iF(text, M6ZErPEr2LZyWYpa5O.tZ53SRMKfw)) ? Visibility.Hidden : Visibility.Visible;
			}
		}
		if (value is int num && S1a0wT9Ixre9OpDny8h.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(parameter, wq2usy8gNndpuTw5mR.ajcDe8nffb), iFZ5je3XFYKwkvcE5D.D35lls5iF(9382, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO))
		{
			return (num == 0) ? Visibility.Hidden : Visibility.Visible;
		}
		return Visibility.Visible;
	}

	public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}

	public VisiblityHiddenConverter()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector();
	}
}
