using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace PROTV.Wpf.Helpers;

public class ClipFromBorderProperty : BaseAttachedProperty<ClipFromBorderProperty, bool>
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass2_0
	{
		public ClipFromBorderProperty U2ykvrdyBF;

		public FrameworkElement ueFkW7rNWF;

		public _003C_003Ec__DisplayClass2_0()
		{
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
			base._002Ector();
		}

		internal void h7MkcLynOB(object s1, RoutedEventArgs e1)
		{
			aaUWa1tGShtxHKZKVvf.D35lls5iF(U2ykvrdyBF, s1, e1, ueFkW7rNWF, aaUWa1tGShtxHKZKVvf.thWtRJp2Zs);
		}

		internal void nR0kjXt7wA(object s1, SizeChangedEventArgs e1)
		{
			aaUWa1tGShtxHKZKVvf.D35lls5iF(U2ykvrdyBF, s1, e1, ueFkW7rNWF, aaUWa1tGShtxHKZKVvf.thWtRJp2Zs);
		}
	}

	private RoutedEventHandler qwFGjFLpOX;

	private SizeChangedEventHandler EP3GvUiHyB;

	public override void OnValueChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
	{
		_003C_003Ec__DisplayClass2_0 CS_0024_003C_003E8__locals7 = new _003C_003Ec__DisplayClass2_0();
		CS_0024_003C_003E8__locals7.U2ykvrdyBF = this;
		CS_0024_003C_003E8__locals7.ueFkW7rNWF = sender as FrameworkElement;
		if (!(GvfQ9rrIdyZy2ca2rjW.D35lls5iF(CS_0024_003C_003E8__locals7.ueFkW7rNWF, GvfQ9rrIdyZy2ca2rjW.CjGrdUJWlk) is Border border))
		{
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.jiWrUpulIF);
			return;
		}
		qwFGjFLpOX = delegate(object s1, RoutedEventArgs e2)
		{
			aaUWa1tGShtxHKZKVvf.D35lls5iF(CS_0024_003C_003E8__locals7.U2ykvrdyBF, s1, e2, CS_0024_003C_003E8__locals7.ueFkW7rNWF, aaUWa1tGShtxHKZKVvf.thWtRJp2Zs);
		};
		EP3GvUiHyB = delegate(object s1, SizeChangedEventArgs e2)
		{
			aaUWa1tGShtxHKZKVvf.D35lls5iF(CS_0024_003C_003E8__locals7.U2ykvrdyBF, s1, e2, CS_0024_003C_003E8__locals7.ueFkW7rNWF, aaUWa1tGShtxHKZKVvf.thWtRJp2Zs);
		};
		if ((bool)kO8WlprtJQWYYRfm8Ps.D35lls5iF(ref e, kO8WlprtJQWYYRfm8Ps.v81rV7KHVP))
		{
			dp97HSDjYOMxMALpn4D.D35lls5iF(border, qwFGjFLpOX, dp97HSDjYOMxMALpn4D.gUprRPD5S8);
			m6IVaOr7Pbr55wvyZUH.D35lls5iF(border, EP3GvUiHyB, m6IVaOr7Pbr55wvyZUH.HRyrccQGtn);
		}
		else
		{
			dp97HSDjYOMxMALpn4D.D35lls5iF(border, qwFGjFLpOX, dp97HSDjYOMxMALpn4D.bI5rM9OU3O);
			m6IVaOr7Pbr55wvyZUH.D35lls5iF(border, EP3GvUiHyB, m6IVaOr7Pbr55wvyZUH.uCcrSrd8S3);
		}
	}

	private void kiVGc7S46w(object P_0, RoutedEventArgs P_1, FrameworkElement P_2)
	{
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		Border border = (Border)P_0;
		if (bATk1clKMSyO8g9EVbN.D35lls5iF(border, bATk1clKMSyO8g9EVbN.LZ5naZ8G19) != 0.0 || bATk1clKMSyO8g9EVbN.D35lls5iF(border, bATk1clKMSyO8g9EVbN.jUBnILD6KS) != 0.0)
		{
			RectangleGeometry rectangleGeometry = new RectangleGeometry();
			CornerRadius cornerRadius = S1iIqTrKOYhgA4w0fcf.D35lls5iF(border, S1iIqTrKOYhgA4w0fcf.XPhrNSRDII);
			double num = Fbg8kirOYkbCq3U8JZd.D35lls5iF(ref cornerRadius, Fbg8kirOYkbCq3U8JZd.wsgruQlMjx);
			Thickness thickness = HJyUNNrPvNefdXHGvJZ.D35lls5iF(border, HJyUNNrPvNefdXHGvJZ.Ixers7weID);
			double num2;
			mAdJWQ9yhneCbEXlGMc.D35lls5iF(rectangleGeometry, num2 = e3E2ZWrYciYham5tWhj.D35lls5iF(0.0, num - R2rV9Krhd02jm8wrUwd.D35lls5iF(ref thickness, R2rV9Krhd02jm8wrUwd.p4TrxG3fvp) * 0.5, e3E2ZWrYciYham5tWhj.dgErg9Sn92), mAdJWQ9yhneCbEXlGMc.Kyyri7YJYY);
			mAdJWQ9yhneCbEXlGMc.D35lls5iF(rectangleGeometry, num2, mAdJWQ9yhneCbEXlGMc.rxxrQYy0WN);
			o2iaqtrFfDSwmbNKtL9.D35lls5iF(rectangleGeometry, new Rect(GAFcFirX4H1KbV9nid5.D35lls5iF(P_2, GAFcFirX4H1KbV9nid5.lpLrfHFLLp)), o2iaqtrFfDSwmbNKtL9.FoBr2b9Cp7);
			CIWnKXrZQnR1QOP4n5r.D35lls5iF(P_2, rectangleGeometry, CIWnKXrZQnR1QOP4n5r.F8BrjM5rsL);
		}
	}

	public ClipFromBorderProperty()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector();
	}
}
