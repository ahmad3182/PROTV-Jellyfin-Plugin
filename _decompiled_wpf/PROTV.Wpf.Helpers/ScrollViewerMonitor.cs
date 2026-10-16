using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace PROTV.Wpf.Helpers;

public class ScrollViewerMonitor
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass8_0
	{
		public ScrollViewer sNXkGVW4O3;

		public FrameworkElement P6GkTb6Frr;

		public _003C_003Ec__DisplayClass8_0()
		{
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
			base._002Ector();
		}

		internal void Jw7k0bJNpw(object o, EventArgs args)
		{
			int num = T9sNieeduAumIbMO43W.D35lls5iF((DependencyObject)(object)sNXkGVW4O3, T9sNieeduAumIbMO43W.Hyyt7JbxwZ);
			if (bATk1clKMSyO8g9EVbN.D35lls5iF(sNXkGVW4O3, bATk1clKMSyO8g9EVbN.HMvHoGcjPR) >= Rfe4g0pfhM1nR3u94hp.D35lls5iF(sNXkGVW4O3, Rfe4g0pfhM1nR3u94hp.bwmtcYKUqC) - (double)num)
			{
				ICommand command = UhY6LUtMjjbUmBiy3bA.D35lls5iF((DependencyObject)(object)P6GkTb6Frr, UhY6LUtMjjbUmBiy3bA.loptS0udqf);
				if (command != null)
				{
					KBhlAv9D2TgBJ1kkc0B.D35lls5iF(command, null, KBhlAv9D2TgBJ1kkc0B.uvttKcGM0h);
				}
			}
		}
	}

	public static DependencyProperty AtEndCommandProperty;

	public static DependencyProperty VerticalOffsetAtEndProperty;

	private static void WiGGKlkyNZ(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
	}

	public static int GetVerticalOffsetAtEnd(DependencyObject obj)
	{
		return (int)EmqD3J86gxqLokWBlHc.D35lls5iF(obj, VerticalOffsetAtEndProperty, EmqD3J86gxqLokWBlHc.zno8ILg6BC);
	}

	public static void SetVerticalOffsetAtEnd(DependencyObject obj, int value)
	{
		jsMkaY8wkGDPQeJiaWA.D35lls5iF(obj, VerticalOffsetAtEndProperty, value, jsMkaY8wkGDPQeJiaWA.ffyrmsSweV);
	}

	public static ICommand GetAtEndCommand(DependencyObject obj)
	{
		return (ICommand)EmqD3J86gxqLokWBlHc.D35lls5iF(obj, AtEndCommandProperty, EmqD3J86gxqLokWBlHc.zno8ILg6BC);
	}

	public static void SetAtEndCommand(DependencyObject obj, ICommand value)
	{
		jsMkaY8wkGDPQeJiaWA.D35lls5iF(obj, AtEndCommandProperty, value, jsMkaY8wkGDPQeJiaWA.ffyrmsSweV);
	}

	public static void OnAtEndCommandChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
	{
		FrameworkElement frameworkElement = (FrameworkElement)(object)d;
		if (frameworkElement != null)
		{
			dp97HSDjYOMxMALpn4D.D35lls5iF(frameworkElement, kU2GkGfp0j, dp97HSDjYOMxMALpn4D.bI5rM9OU3O);
			dp97HSDjYOMxMALpn4D.D35lls5iF(frameworkElement, kU2GkGfp0j, dp97HSDjYOMxMALpn4D.gUprRPD5S8);
		}
	}

	private static void kU2GkGfp0j(object P_0, RoutedEventArgs P_1)
	{
		_003C_003Ec__DisplayClass8_0 CS_0024_003C_003E8__locals11 = new _003C_003Ec__DisplayClass8_0();
		CS_0024_003C_003E8__locals11.P6GkTb6Frr = (FrameworkElement)P_0;
		dp97HSDjYOMxMALpn4D.D35lls5iF(CS_0024_003C_003E8__locals11.P6GkTb6Frr, kU2GkGfp0j, dp97HSDjYOMxMALpn4D.bI5rM9OU3O);
		if (P_0 is ScrollViewer)
		{
			CS_0024_003C_003E8__locals11.sNXkGVW4O3 = P_0 as ScrollViewer;
		}
		else
		{
			CS_0024_003C_003E8__locals11.sNXkGVW4O3 = CYsG8or0lq<ScrollViewer>((DependencyObject)(object)CS_0024_003C_003E8__locals11.P6GkTb6Frr);
		}
		if (CS_0024_003C_003E8__locals11.sNXkGVW4O3 == null)
		{
			return;
		}
		oWQd0Zea7VgaKjr1HRi.D35lls5iF(brMuCheCCTTUSwVI36i.D35lls5iF(ScrollViewer.VerticalOffsetProperty, sjYxHO8OWlc6X80hFj7.D35lls5iF(typeof(ScrollViewer).TypeHandle, sjYxHO8OWlc6X80hFj7.uWZ8ugU7r5), brMuCheCCTTUSwVI36i.wA7emQTnZp), CS_0024_003C_003E8__locals11.sNXkGVW4O3, delegate
		{
			int num = T9sNieeduAumIbMO43W.D35lls5iF((DependencyObject)(object)CS_0024_003C_003E8__locals11.sNXkGVW4O3, T9sNieeduAumIbMO43W.Hyyt7JbxwZ);
			if (bATk1clKMSyO8g9EVbN.D35lls5iF(CS_0024_003C_003E8__locals11.sNXkGVW4O3, bATk1clKMSyO8g9EVbN.HMvHoGcjPR) >= Rfe4g0pfhM1nR3u94hp.D35lls5iF(CS_0024_003C_003E8__locals11.sNXkGVW4O3, Rfe4g0pfhM1nR3u94hp.bwmtcYKUqC) - (double)num)
			{
				ICommand command = UhY6LUtMjjbUmBiy3bA.D35lls5iF((DependencyObject)(object)CS_0024_003C_003E8__locals11.P6GkTb6Frr, UhY6LUtMjjbUmBiy3bA.loptS0udqf);
				if (command != null)
				{
					KBhlAv9D2TgBJ1kkc0B.D35lls5iF(command, null, KBhlAv9D2TgBJ1kkc0B.uvttKcGM0h);
				}
			}
		}, oWQd0Zea7VgaKjr1HRi.Ok6eIuw4Zn);
	}

	private static mmyhI241KTH9XdMuxk CYsG8or0lq<mmyhI241KTH9XdMuxk>(DependencyObject P_0) where mmyhI241KTH9XdMuxk : class
	{
		Queue<DependencyObject> queue = new Queue<DependencyObject>();
		queue.Enqueue(P_0);
		while (queue.Count > 0)
		{
			DependencyObject val = queue.Dequeue();
			int num = T9sNieeduAumIbMO43W.D35lls5iF(val, T9sNieeduAumIbMO43W.YeDeUK3q8R) - 1;
			while (0 <= num)
			{
				DependencyObject val2 = tJmv7Vet2tiZMCree4E.D35lls5iF(val, num, tJmv7Vet2tiZMCree4E.RWfeVmUdAF);
				if (val2 is mmyhI241KTH9XdMuxk result)
				{
					return result;
				}
				queue.Enqueue(val2);
				num--;
			}
		}
		return null;
	}

	public ScrollViewerMonitor()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector();
	}

	static ScrollViewerMonitor()
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		AtEndCommandProperty = BrQfd88PXGwGWbvCv5M.D35lls5iF(iFZ5je3XFYKwkvcE5D.D35lls5iF(13032, iFZ5je3XFYKwkvcE5D.N06TeK0ao), sjYxHO8OWlc6X80hFj7.D35lls5iF(typeof(ICommand).TypeHandle, sjYxHO8OWlc6X80hFj7.uWZ8ugU7r5), sjYxHO8OWlc6X80hFj7.D35lls5iF(typeof(ScrollViewerMonitor).TypeHandle, sjYxHO8OWlc6X80hFj7.uWZ8ugU7r5), new PropertyMetadata(new PropertyChangedCallback(OnAtEndCommandChanged)), BrQfd88PXGwGWbvCv5M.oV7raoV9pQ);
		VerticalOffsetAtEndProperty = BrQfd88PXGwGWbvCv5M.D35lls5iF(iFZ5je3XFYKwkvcE5D.D35lls5iF(13060, iFZ5je3XFYKwkvcE5D.N06TeK0ao), sjYxHO8OWlc6X80hFj7.D35lls5iF(typeof(int).TypeHandle, sjYxHO8OWlc6X80hFj7.uWZ8ugU7r5), sjYxHO8OWlc6X80hFj7.D35lls5iF(typeof(ScrollViewerMonitor).TypeHandle, sjYxHO8OWlc6X80hFj7.uWZ8ugU7r5), new PropertyMetadata((object)0, new PropertyChangedCallback(WiGGKlkyNZ)), BrQfd88PXGwGWbvCv5M.oV7raoV9pQ);
	}
}
