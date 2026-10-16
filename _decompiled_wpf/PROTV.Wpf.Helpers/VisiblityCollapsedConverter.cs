using System;
using System.Globalization;
using System.Windows;
using PROTV.Abstractions.DataTransferObjects;
using PROTV.Wpf.ViewModels;
using PROTV.Wpf.Views;

namespace PROTV.Wpf.Helpers;

public class VisiblityCollapsedConverter : BaseValueConverter<VisiblityCollapsedConverter>
{
	public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (value is bool flag)
		{
			if (S1a0wT9Ixre9OpDny8h.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(parameter, wq2usy8gNndpuTw5mR.ajcDe8nffb), iFZ5je3XFYKwkvcE5D.D35lls5iF(14002, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO))
			{
				return (!flag) ? Visibility.Collapsed : Visibility.Visible;
			}
			if (S1a0wT9Ixre9OpDny8h.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(parameter, wq2usy8gNndpuTw5mR.ajcDe8nffb), iFZ5je3XFYKwkvcE5D.D35lls5iF(14018, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO))
			{
				return flag ? Visibility.Collapsed : Visibility.Visible;
			}
		}
		else if (value is int)
		{
			if (S1a0wT9Ixre9OpDny8h.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(parameter, wq2usy8gNndpuTw5mR.ajcDe8nffb), iFZ5je3XFYKwkvcE5D.D35lls5iF(14002, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO))
			{
				return ((int)value != 0) ? Visibility.Collapsed : Visibility.Visible;
			}
			if (S1a0wT9Ixre9OpDny8h.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(parameter, wq2usy8gNndpuTw5mR.ajcDe8nffb), iFZ5je3XFYKwkvcE5D.D35lls5iF(14018, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO))
			{
				return ((int)value == 0) ? Visibility.Collapsed : Visibility.Visible;
			}
			if (S1a0wT9Ixre9OpDny8h.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(parameter, wq2usy8gNndpuTw5mR.ajcDe8nffb), iFZ5je3XFYKwkvcE5D.D35lls5iF(13996, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO))
			{
				return ((int)value != 0) ? Visibility.Collapsed : Visibility.Visible;
			}
			if (S1a0wT9Ixre9OpDny8h.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(parameter, wq2usy8gNndpuTw5mR.ajcDe8nffb), iFZ5je3XFYKwkvcE5D.D35lls5iF(14034, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO))
			{
				return ((int)value != 1) ? Visibility.Collapsed : Visibility.Visible;
			}
			if (S1a0wT9Ixre9OpDny8h.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(parameter, wq2usy8gNndpuTw5mR.ajcDe8nffb), iFZ5je3XFYKwkvcE5D.D35lls5iF(14040, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO))
			{
				return ((int)value != 2) ? Visibility.Collapsed : Visibility.Visible;
			}
			if (S1a0wT9Ixre9OpDny8h.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(parameter, wq2usy8gNndpuTw5mR.ajcDe8nffb), iFZ5je3XFYKwkvcE5D.D35lls5iF(14046, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO))
			{
				return ((int)value != 3) ? Visibility.Collapsed : Visibility.Visible;
			}
			if (S1a0wT9Ixre9OpDny8h.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(parameter, wq2usy8gNndpuTw5mR.ajcDe8nffb), iFZ5je3XFYKwkvcE5D.D35lls5iF(14052, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO))
			{
				return ((int)value != 4) ? Visibility.Collapsed : Visibility.Visible;
			}
		}
		else
		{
			if (value is PlaylistItemType)
			{
				return ((PlaylistItemType)value != PlaylistItemType.TvChannel) ? Visibility.Collapsed : Visibility.Visible;
			}
			if (value is EPGItemResponseDto ePGItemResponseDto)
			{
				DateTime? dateTime = jyJOWlG4c4VgR6hR3yW.D35lls5iF(ePGItemResponseDto, jyJOWlG4c4VgR6hR3yW.qZyGLhG8Kh);
				DateTime dateTime2 = BvlWxPl1hnvXiXiwcCq.D35lls5iF(BvlWxPl1hnvXiXiwcCq.YfD1XHDES3);
				if (dateTime.HasValue && gZUxeoGEEKS2SICdd4E.D35lls5iF(dateTime.GetValueOrDefault(), dateTime2, gZUxeoGEEKS2SICdd4E.q1iGBmBcnO))
				{
					return Visibility.Collapsed;
				}
				if (M6ZErPEr2LZyWYpa5O.D35lls5iF(QQLie3eYkZwbFFm9Jjw.D35lls5iF(ePGItemResponseDto, QQLie3eYkZwbFFm9Jjw.y7UG04iGRK), M6ZErPEr2LZyWYpa5O.tZ53SRMKfw))
				{
					return Visibility.Collapsed;
				}
				return Visibility.Visible;
			}
		}
		if (parameter != null && S1a0wT9Ixre9OpDny8h.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(parameter, wq2usy8gNndpuTw5mR.ajcDe8nffb), iFZ5je3XFYKwkvcE5D.D35lls5iF(9914, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO))
		{
			if (value == null || (value is string && M6ZErPEr2LZyWYpa5O.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(value, wq2usy8gNndpuTw5mR.ajcDe8nffb), M6ZErPEr2LZyWYpa5O.tZ53SRMKfw)))
			{
				return Visibility.Collapsed;
			}
			return Visibility.Visible;
		}
		if (value is string text)
		{
			if (S1a0wT9Ixre9OpDny8h.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(parameter, wq2usy8gNndpuTw5mR.ajcDe8nffb), iFZ5je3XFYKwkvcE5D.D35lls5iF(14002, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO))
			{
				return (!S1a0wT9Ixre9OpDny8h.D35lls5iF(text, iFZ5je3XFYKwkvcE5D.D35lls5iF(8390, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO) && !S1a0wT9Ixre9OpDny8h.D35lls5iF(text, iFZ5je3XFYKwkvcE5D.D35lls5iF(14058, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO)) ? Visibility.Collapsed : Visibility.Visible;
			}
			if (S1a0wT9Ixre9OpDny8h.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(parameter, wq2usy8gNndpuTw5mR.ajcDe8nffb), iFZ5je3XFYKwkvcE5D.D35lls5iF(14018, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO))
			{
				return (S1a0wT9Ixre9OpDny8h.D35lls5iF(text, iFZ5je3XFYKwkvcE5D.D35lls5iF(8390, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO) || S1a0wT9Ixre9OpDny8h.D35lls5iF(text, iFZ5je3XFYKwkvcE5D.D35lls5iF(14058, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO)) ? Visibility.Collapsed : Visibility.Visible;
			}
			if (S1a0wT9Ixre9OpDny8h.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(parameter, wq2usy8gNndpuTw5mR.ajcDe8nffb), iFZ5je3XFYKwkvcE5D.D35lls5iF(14074, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO))
			{
				return (S1a0wT9Ixre9OpDny8h.D35lls5iF(text, iFZ5je3XFYKwkvcE5D.D35lls5iF(9308, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO) || S1a0wT9Ixre9OpDny8h.D35lls5iF(text, iFZ5je3XFYKwkvcE5D.D35lls5iF(11834, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO)) ? Visibility.Collapsed : Visibility.Visible;
			}
		}
		if (parameter != null && S1a0wT9Ixre9OpDny8h.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(parameter, wq2usy8gNndpuTw5mR.ajcDe8nffb), iFZ5je3XFYKwkvcE5D.D35lls5iF(14088, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO))
		{
			if (value != null)
			{
				return ((MusicType)value != MusicType.Playlist) ? Visibility.Collapsed : Visibility.Visible;
			}
			return "";
		}
		return Visibility.Visible;
	}

	public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}

	public VisiblityCollapsedConverter()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector();
	}
}
