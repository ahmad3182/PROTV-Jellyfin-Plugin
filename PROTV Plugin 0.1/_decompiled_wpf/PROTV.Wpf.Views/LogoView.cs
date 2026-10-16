using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Threading;
using PROTV.Wpf.Bootstrap;
using PROTV.Wpf.ViewModels;

namespace PROTV.Wpf.Views;

public class LogoView : BasePage, IComponentConnector
{
	internal TextBlock date;

	private bool QFmj9wVCea;

	public LogoView()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector();
		tApScD14t76npcHoQ1x.D35lls5iF(this, tApScD14t76npcHoQ1x.KBP1QsGSnw);
		TextBlock textBlock = date;
		DateTime dateTime = BvlWxPl1hnvXiXiwcCq.D35lls5iF(BvlWxPl1hnvXiXiwcCq.YfD1XHDES3);
		qni3xrDkAJ3vF35eMav.D35lls5iF(textBlock, JDI4hi1f6L0Vn3H1mNe.D35lls5iF(ref dateTime, iFZ5je3XFYKwkvcE5D.D35lls5iF(1978, iFZ5je3XFYKwkvcE5D.N06TeK0ao), JDI4hi1f6L0Vn3H1mNe.TSS1FX3P8P), qni3xrDkAJ3vF35eMav.wbO12W4fCg);
		tApScD14t76npcHoQ1x.D35lls5iF(this, tApScD14t76npcHoQ1x.Vub1ZHheZU);
		KBhlAv9D2TgBJ1kkc0B.D35lls5iF(this, AppContainer.Resolve<HomeViewModel>(), KBhlAv9D2TgBJ1kkc0B.rHR9H7nUZq);
	}

	private void Ve0jRQdyNX()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_004b: Expected O, but got Unknown
		DispatcherTimer val = new DispatcherTimer();
		AKwYZ1lE8mnNaTGlMo6.D35lls5iF((object)val, aNJrrPl4soK5NDOndiN.D35lls5iF(1.0, aNJrrPl4soK5NDOndiN.y1C1jpngkJ), AKwYZ1lE8mnNaTGlMo6.EaBlBG90pn);
		ytk50glr3dmeojxPvdr.D35lls5iF((object)val, tmkjwr5OcO, ytk50glr3dmeojxPvdr.Lgkle9IPtT);
		AJv70itXcdnxnNYjSQ.D35lls5iF((object)val, AJv70itXcdnxnNYjSQ.JRYlG0QuuU);
	}

	private void tmkjwr5OcO(object P_0, EventArgs P_1)
	{
		TextBlock textBlock = date;
		DateTime dateTime = BvlWxPl1hnvXiXiwcCq.D35lls5iF(BvlWxPl1hnvXiXiwcCq.YfD1XHDES3);
		qni3xrDkAJ3vF35eMav.D35lls5iF(textBlock, JDI4hi1f6L0Vn3H1mNe.D35lls5iF(ref dateTime, iFZ5je3XFYKwkvcE5D.D35lls5iF(1978, iFZ5je3XFYKwkvcE5D.N06TeK0ao), JDI4hi1f6L0Vn3H1mNe.TSS1FX3P8P), qni3xrDkAJ3vF35eMav.wbO12W4fCg);
	}

	[GeneratedCode("PresentationBuildTasks", "5.0.4.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!QFmj9wVCea)
		{
			QFmj9wVCea = true;
			Uri uri = new Uri(iFZ5je3XFYKwkvcE5D.D35lls5iF(2036, iFZ5je3XFYKwkvcE5D.N06TeK0ao), UriKind.Relative);
			TUdx26d4l5VwJTvopv.D35lls5iF(this, uri, TUdx26d4l5VwJTvopv.W3oUN4AKb);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "5.0.4.0")]
	internal Delegate KbDjE4xpEO(Type P_0, string P_1)
	{
		return E6A9Xm2C8YsY6OX49j.D35lls5iF(P_0, this, P_1, E6A9Xm2C8YsY6OX49j.lecZDyFnW);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "5.0.4.0")]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		if (connectionId == 1)
		{
			date = (TextBlock)target;
		}
		else
		{
			QFmj9wVCea = true;
		}
	}
}
