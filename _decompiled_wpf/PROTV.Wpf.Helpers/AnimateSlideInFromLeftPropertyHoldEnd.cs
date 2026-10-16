using System.Windows;
using PROTV.Abstractions.Common;

namespace PROTV.Wpf.Helpers;

public class AnimateSlideInFromLeftPropertyHoldEnd : AnimateBaseProperty<AnimateSlideInFromLeftPropertyHoldEnd>
{
	protected override void DoAnimation(FrameworkElement element, bool value, bool firstLoad)
	{
		if (value)
		{
			OWYw0ark325dZwZ0Nip.D35lls5iF(element, AnimationSlideIndirection.Left, firstLoad, firstLoad ? 0f : 0.5f, false, 0, true, OWYw0ark325dZwZ0Nip.r83rvaaav5);
		}
		else
		{
			t3Ng4grATnOPOBoYAlB.D35lls5iF(element, AnimationSlideIndirection.Left, firstLoad ? 0f : 0.5f, false, 0, true, t3Ng4grATnOPOBoYAlB.lLgr6TCaQa);
		}
	}

	public AnimateSlideInFromLeftPropertyHoldEnd()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector();
	}
}
