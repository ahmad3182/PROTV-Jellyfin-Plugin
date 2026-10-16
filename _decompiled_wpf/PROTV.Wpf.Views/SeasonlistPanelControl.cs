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

public class SeasonlistPanelControl : UserControl, IComponentConnector
{
	internal Grid PlaylistPanelContentList;

	internal ListBox PlaylistItemsControl;

	private bool EjgWGAXijG;

	public SeasonlistPanelControl()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector();
		hao3Y68m7Zvx79IIOKw.D35lls5iF(this, hao3Y68m7Zvx79IIOKw.uI7nv5Myy8);
	}

	private void dx5W0BGNyW(object P_0, MouseWheelEventArgs P_1)
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
		if (!EjgWGAXijG)
		{
			EjgWGAXijG = true;
			Uri uri = new Uri(iFZ5je3XFYKwkvcE5D.D35lls5iF(4582, iFZ5je3XFYKwkvcE5D.N06TeK0ao), UriKind.Relative);
			TUdx26d4l5VwJTvopv.D35lls5iF(this, uri, TUdx26d4l5VwJTvopv.W3oUN4AKb);
		}
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "5.0.4.0")]
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
			EjgWGAXijG = true;
			break;
		}
	}
}
