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

public class YtlistPanelControl : UserControl, IComponentConnector
{
	internal Grid PlaylistPanelContentList;

	internal ListBox PlaylistItemsControl;

	private bool uxJWzhVEWS;

	public YtlistPanelControl()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector();
		xLO56JniGyickVjO1Ot.D35lls5iF(this, xLO56JniGyickVjO1Ot.v7vnFqNtB9);
	}

	private void qN3W2Alcf4(object P_0, MouseWheelEventArgs P_1)
	{
		ScrollViewer scrollViewer = ((DependencyObject)((P_0 is DependencyObject) ? P_0 : null)).FindParentOfType<ScrollViewer>();
		if (scrollViewer != null)
		{
			mAdJWQ9yhneCbEXlGMc.D35lls5iF(scrollViewer, bATk1clKMSyO8g9EVbN.D35lls5iF(scrollViewer, bATk1clKMSyO8g9EVbN.HMvHoGcjPR) - (double)m9MGZR7k2RmVqYXYS5.D35lls5iF(P_1, m9MGZR7k2RmVqYXYS5.BoXHlIwNQk), mAdJWQ9yhneCbEXlGMc.OCfH9YuRTt);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "5.0.4.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!uxJWzhVEWS)
		{
			uxJWzhVEWS = true;
			Uri uri = new Uri(iFZ5je3XFYKwkvcE5D.D35lls5iF(5488, iFZ5je3XFYKwkvcE5D.N06TeK0ao), UriKind.Relative);
			TUdx26d4l5VwJTvopv.D35lls5iF(this, uri, TUdx26d4l5VwJTvopv.W3oUN4AKb);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "5.0.4.0")]
	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		case 1:
			PlaylistPanelContentList = (Grid)target;
			break;
		case 2:
			PlaylistItemsControl = (ListBox)target;
			break;
		default:
			uxJWzhVEWS = true;
			break;
		}
	}
}
