using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Markup;
using PROTV.Wpf.Helpers;

namespace PROTV.Wpf.Views;

public class YtWatchLaterView : UserControl, IComponentConnector
{
	internal Button MuteUnmuteButton;

	internal ToggleButton SoundMenuButton;

	internal Popup SoundMenuPopup;

	internal ListBox list;

	private bool gvH4uor2PK;

	public YtWatchLaterView()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector();
		xLO56JniGyickVjO1Ot.D35lls5iF(this, xLO56JniGyickVjO1Ot.vkjnzMo4JP);
	}

	private void XMo4bTJJyv(object P_0, MouseWheelEventArgs P_1)
	{
		ScrollViewer visualDescendant = ((DependencyObject)(object)list).GetVisualDescendant<ScrollViewer>();
		mAdJWQ9yhneCbEXlGMc.D35lls5iF(visualDescendant, bATk1clKMSyO8g9EVbN.D35lls5iF(visualDescendant, bATk1clKMSyO8g9EVbN.HMvHoGcjPR) - (double)m9MGZR7k2RmVqYXYS5.D35lls5iF(P_1, m9MGZR7k2RmVqYXYS5.BoXHlIwNQk), mAdJWQ9yhneCbEXlGMc.OCfH9YuRTt);
	}

	private void Xjp47hDV1r(object P_0, RoutedEventArgs P_1)
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "5.0.4.0")]
	public void InitializeComponent()
	{
		if (!gvH4uor2PK)
		{
			gvH4uor2PK = true;
			Uri uri = new Uri(iFZ5je3XFYKwkvcE5D.D35lls5iF(6772, iFZ5je3XFYKwkvcE5D.N06TeK0ao), UriKind.Relative);
			TUdx26d4l5VwJTvopv.D35lls5iF(this, uri, TUdx26d4l5VwJTvopv.W3oUN4AKb);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "5.0.4.0")]
	internal Delegate Cx445ClE2N(Type P_0, string P_1)
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
			dp97HSDjYOMxMALpn4D.D35lls5iF(MuteUnmuteButton, Xjp47hDV1r, dp97HSDjYOMxMALpn4D.boI1UheDEc);
			break;
		case 2:
			SoundMenuButton = (ToggleButton)target;
			break;
		case 3:
			SoundMenuPopup = (Popup)target;
			break;
		case 4:
			list = (ListBox)target;
			break;
		default:
			gvH4uor2PK = true;
			break;
		}
	}
}
