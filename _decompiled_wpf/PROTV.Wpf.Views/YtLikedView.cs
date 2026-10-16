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

public class YtLikedView : UserControl, IComponentConnector
{
	internal Button MuteUnmuteButton;

	internal ListBox list;

	private bool t7h4ZYjpkY;

	public YtLikedView()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector();
		xLO56JniGyickVjO1Ot.D35lls5iF(this, xLO56JniGyickVjO1Ot.dKwnqDWqJw);
	}

	private void H7I4aI9Foi(object P_0, MouseWheelEventArgs P_1)
	{
		ScrollViewer visualDescendant = ((DependencyObject)(object)list).GetVisualDescendant<ScrollViewer>();
		mAdJWQ9yhneCbEXlGMc.D35lls5iF(visualDescendant, bATk1clKMSyO8g9EVbN.D35lls5iF(visualDescendant, bATk1clKMSyO8g9EVbN.HMvHoGcjPR) - (double)m9MGZR7k2RmVqYXYS5.D35lls5iF(P_1, m9MGZR7k2RmVqYXYS5.BoXHlIwNQk), mAdJWQ9yhneCbEXlGMc.OCfH9YuRTt);
	}

	private void Mcq401tyU7(object P_0, SelectionChangedEventArgs P_1)
	{
	}

	private void rhE4GGKVTv(object P_0, RoutedEventArgs P_1)
	{
	}

	[GeneratedCode("PresentationBuildTasks", "5.0.4.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!t7h4ZYjpkY)
		{
			t7h4ZYjpkY = true;
			Uri uri = new Uri(iFZ5je3XFYKwkvcE5D.D35lls5iF(6136, iFZ5je3XFYKwkvcE5D.N06TeK0ao), UriKind.Relative);
			TUdx26d4l5VwJTvopv.D35lls5iF(this, uri, TUdx26d4l5VwJTvopv.W3oUN4AKb);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "5.0.4.0")]
	[DebuggerNonUserCode]
	internal Delegate egJ4TJo2vj(Type P_0, string P_1)
	{
		return E6A9Xm2C8YsY6OX49j.D35lls5iF(P_0, this, P_1, E6A9Xm2C8YsY6OX49j.lecZDyFnW);
	}

	[GeneratedCode("PresentationBuildTasks", "5.0.4.0")]
	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		case 1:
			MuteUnmuteButton = (Button)target;
			dp97HSDjYOMxMALpn4D.D35lls5iF(MuteUnmuteButton, rhE4GGKVTv, dp97HSDjYOMxMALpn4D.boI1UheDEc);
			break;
		case 2:
			list = (ListBox)target;
			break;
		default:
			t7h4ZYjpkY = true;
			break;
		}
	}
}
