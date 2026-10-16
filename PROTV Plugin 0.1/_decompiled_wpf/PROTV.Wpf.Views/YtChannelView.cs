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

public class YtChannelView : UserControl, IComponentConnector
{
	internal ScrollViewer scollviewer;

	internal ListBox listxxx;

	internal ListBox listx;

	private bool X8l4BYOnTe;

	public YtChannelView()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector();
		xLO56JniGyickVjO1Ot.D35lls5iF(this, xLO56JniGyickVjO1Ot.OGCnZi1wYf);
	}

	private void rVg4jseFoq(object P_0, MouseWheelEventArgs P_1)
	{
		ScrollViewer visualDescendant = ((DependencyObject)(object)listx).GetVisualDescendant<ScrollViewer>();
		mAdJWQ9yhneCbEXlGMc.D35lls5iF(visualDescendant, bATk1clKMSyO8g9EVbN.D35lls5iF(visualDescendant, bATk1clKMSyO8g9EVbN.HMvHoGcjPR) - (double)m9MGZR7k2RmVqYXYS5.D35lls5iF(P_1, m9MGZR7k2RmVqYXYS5.BoXHlIwNQk), mAdJWQ9yhneCbEXlGMc.OCfH9YuRTt);
	}

	private void uiw4vrAR7K(object P_0, MouseWheelEventArgs P_1)
	{
		mAdJWQ9yhneCbEXlGMc.D35lls5iF(scollviewer, bATk1clKMSyO8g9EVbN.D35lls5iF(scollviewer, bATk1clKMSyO8g9EVbN.HMvHoGcjPR) - (double)m9MGZR7k2RmVqYXYS5.D35lls5iF(P_1, m9MGZR7k2RmVqYXYS5.BoXHlIwNQk), mAdJWQ9yhneCbEXlGMc.OCfH9YuRTt);
	}

	private void qMc4WTSmHD(object P_0, SelectionChangedEventArgs P_1)
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "5.0.4.0")]
	public void InitializeComponent()
	{
		if (!X8l4BYOnTe)
		{
			X8l4BYOnTe = true;
			Uri uri = new Uri(iFZ5je3XFYKwkvcE5D.D35lls5iF(5760, iFZ5je3XFYKwkvcE5D.N06TeK0ao), UriKind.Relative);
			TUdx26d4l5VwJTvopv.D35lls5iF(this, uri, TUdx26d4l5VwJTvopv.W3oUN4AKb);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "5.0.4.0")]
	internal Delegate qRR44hng03(Type P_0, string P_1)
	{
		return E6A9Xm2C8YsY6OX49j.D35lls5iF(P_0, this, P_1, E6A9Xm2C8YsY6OX49j.lecZDyFnW);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "5.0.4.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		case 1:
			scollviewer = (ScrollViewer)target;
			break;
		case 2:
			listxxx = (ListBox)target;
			W73HvvHD4Ka6B2vKd4e.D35lls5iF(listxxx, uiw4vrAR7K, W73HvvHD4Ka6B2vKd4e.MIbHH5Gk3A);
			oumatx81yvZcpsmEIHa.D35lls5iF(listxxx, qMc4WTSmHD, oumatx81yvZcpsmEIHa.rZD88lCdXp);
			break;
		case 3:
			listx = (ListBox)target;
			break;
		default:
			X8l4BYOnTe = true;
			break;
		}
	}
}
