using System.Windows;
using System.Windows.Data;
using System.Windows.Input;

namespace PROTV.Wpf.Helpers;

public static class InputBindingsManager
{
	public static readonly DependencyProperty UpdatePropertySourceWhenEnterPressedProperty;

	static InputBindingsManager()
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		UpdatePropertySourceWhenEnterPressedProperty = BrQfd88PXGwGWbvCv5M.D35lls5iF(iFZ5je3XFYKwkvcE5D.D35lls5iF(12778, iFZ5je3XFYKwkvcE5D.N06TeK0ao), sjYxHO8OWlc6X80hFj7.D35lls5iF(typeof(DependencyProperty).TypeHandle, sjYxHO8OWlc6X80hFj7.uWZ8ugU7r5), sjYxHO8OWlc6X80hFj7.D35lls5iF(typeof(InputBindingsManager).TypeHandle, sjYxHO8OWlc6X80hFj7.uWZ8ugU7r5), new PropertyMetadata((object)null, new PropertyChangedCallback(ihrG4xrX4B)), BrQfd88PXGwGWbvCv5M.oV7raoV9pQ);
	}

	public static void SetUpdatePropertySourceWhenEnterPressed(DependencyObject dp, DependencyProperty value)
	{
		jsMkaY8wkGDPQeJiaWA.D35lls5iF(dp, UpdatePropertySourceWhenEnterPressedProperty, value, jsMkaY8wkGDPQeJiaWA.ffyrmsSweV);
	}

	public static DependencyProperty GetUpdatePropertySourceWhenEnterPressed(DependencyObject dp)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		return (DependencyProperty)EmqD3J86gxqLokWBlHc.D35lls5iF(dp, UpdatePropertySourceWhenEnterPressedProperty, EmqD3J86gxqLokWBlHc.zno8ILg6BC);
	}

	private static void ihrG4xrX4B(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		if (P_0 is UIElement uIElement)
		{
			if (kO8WlprtJQWYYRfm8Ps.D35lls5iF(ref P_1, kO8WlprtJQWYYRfm8Ps.QOfr5Tax7V) != null)
			{
				XgfudvNjrG5dZKyndN.D35lls5iF(uIElement, P8TGBbW8HK, XgfudvNjrG5dZKyndN.RHkrzPdp8W);
			}
			if (kO8WlprtJQWYYRfm8Ps.D35lls5iF(ref P_1, kO8WlprtJQWYYRfm8Ps.v81rV7KHVP) != null)
			{
				XgfudvNjrG5dZKyndN.D35lls5iF(uIElement, P8TGBbW8HK, XgfudvNjrG5dZKyndN.tRNlHCnpGP);
			}
		}
	}

	private static void P8TGBbW8HK(object P_0, KeyEventArgs P_1)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Invalid comparison between Unknown and I4
		if ((int)X6dagBgIU5bQsE98LL.D35lls5iF(P_1, X6dagBgIU5bQsE98LL.dcKiqyPBj) == 6)
		{
			b3QyiYL4pm5cgsTYbRX.D35lls5iF(RAspAbuaTQFU0nSRiQ.D35lls5iF(P_1, RAspAbuaTQFU0nSRiQ.sEPeowRjUg), b3QyiYL4pm5cgsTYbRX.qlXel7xAlk);
		}
	}

	private static void LQDGDnIfts(object P_0)
	{
		DependencyProperty val = MxkKg4e9t3EhacPnFO3.D35lls5iF((DependencyObject)((P_0 is DependencyObject) ? P_0 : null), MxkKg4e9t3EhacPnFO3.KoEeDpddIy);
		if (val != null && P_0 is UIElement uIElement)
		{
			BindingExpression bindingExpression = F5fVmQeHZZbpd2IHK6v.D35lls5iF((DependencyObject)(object)uIElement, val, F5fVmQeHZZbpd2IHK6v.cOne1ee3rk);
			if (bindingExpression != null)
			{
				fp757nBYjo8889efKFJ.D35lls5iF(bindingExpression, fp757nBYjo8889efKFJ.LHae8cqmiE);
			}
		}
	}
}
