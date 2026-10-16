using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using PROTV.Wpf.Helpers;

namespace PROTV.Wpf.Views;

public class YtHomeView : UserControl, IComponentConnector, IStyleConnector
{
	internal ListBox list;

	private bool y5D4VjTjLH;

	public YtHomeView()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector();
		xLO56JniGyickVjO1Ot.D35lls5iF(this, xLO56JniGyickVjO1Ot.brqnya5j0I);
	}

	private void mcL4q7GPvo(object P_0, MouseWheelEventArgs P_1)
	{
		ScrollViewer visualDescendant = ((DependencyObject)(object)list).GetVisualDescendant<ScrollViewer>();
		mAdJWQ9yhneCbEXlGMc.D35lls5iF(visualDescendant, bATk1clKMSyO8g9EVbN.D35lls5iF(visualDescendant, bATk1clKMSyO8g9EVbN.HMvHoGcjPR) - (double)m9MGZR7k2RmVqYXYS5.D35lls5iF(P_1, m9MGZR7k2RmVqYXYS5.BoXHlIwNQk), mAdJWQ9yhneCbEXlGMc.OCfH9YuRTt);
	}

	private void ai94IGYZEI(object P_0, SelectionChangedEventArgs P_1)
	{
	}

	[GeneratedCode("PresentationBuildTasks", "5.0.4.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!y5D4VjTjLH)
		{
			y5D4VjTjLH = true;
			Uri uri = new Uri(iFZ5je3XFYKwkvcE5D.D35lls5iF(6018, iFZ5je3XFYKwkvcE5D.N06TeK0ao), UriKind.Relative);
			TUdx26d4l5VwJTvopv.D35lls5iF(this, uri, TUdx26d4l5VwJTvopv.W3oUN4AKb);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "5.0.4.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		if (connectionId == 1)
		{
			list = (ListBox)target;
		}
		else
		{
			y5D4VjTjLH = true;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "5.0.4.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IStyleConnector.Connect(int connectionId, object target)
	{
		if (connectionId == 2)
		{
			oumatx81yvZcpsmEIHa.D35lls5iF((ListBox)target, ai94IGYZEI, oumatx81yvZcpsmEIHa.rZD88lCdXp);
			W73HvvHD4Ka6B2vKd4e.D35lls5iF((ListBox)target, mcL4q7GPvo, W73HvvHD4Ka6B2vKd4e.MIbHH5Gk3A);
		}
	}
}
