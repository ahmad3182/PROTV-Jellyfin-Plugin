using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;

namespace PROTV.Wpf.Views;

public class ProfileView : BasePage<ProfilePageViewModel>, IComponentConnector
{
	internal ScrollViewer scrollviewer;

	private bool z1VvpKEZra;

	public ProfileView()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector();
		hao3Y68m7Zvx79IIOKw.D35lls5iF(this, hao3Y68m7Zvx79IIOKw.oHY8hYeB0h);
	}

	public ProfileView(ProfilePageViewModel specificViewModel)
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector(specificViewModel);
		hao3Y68m7Zvx79IIOKw.D35lls5iF(this, hao3Y68m7Zvx79IIOKw.oHY8hYeB0h);
	}

	private void ypdvx3e483(object P_0, MouseWheelEventArgs P_1)
	{
		mAdJWQ9yhneCbEXlGMc.D35lls5iF(scrollviewer, bATk1clKMSyO8g9EVbN.D35lls5iF(scrollviewer, bATk1clKMSyO8g9EVbN.HMvHoGcjPR) - (double)m9MGZR7k2RmVqYXYS5.D35lls5iF(P_1, m9MGZR7k2RmVqYXYS5.BoXHlIwNQk), mAdJWQ9yhneCbEXlGMc.OCfH9YuRTt);
	}

	[GeneratedCode("PresentationBuildTasks", "5.0.4.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!z1VvpKEZra)
		{
			z1VvpKEZra = true;
			Uri uri = new Uri(iFZ5je3XFYKwkvcE5D.D35lls5iF(3618, iFZ5je3XFYKwkvcE5D.N06TeK0ao), UriKind.Relative);
			TUdx26d4l5VwJTvopv.D35lls5iF(this, uri, TUdx26d4l5VwJTvopv.W3oUN4AKb);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "5.0.4.0")]
	[DebuggerNonUserCode]
	internal Delegate mGsvymOWo6(Type P_0, string P_1)
	{
		return E6A9Xm2C8YsY6OX49j.D35lls5iF(P_0, this, P_1, E6A9Xm2C8YsY6OX49j.lecZDyFnW);
	}

	[GeneratedCode("PresentationBuildTasks", "5.0.4.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		case 1:
			scrollviewer = (ScrollViewer)target;
			break;
		case 2:
			W73HvvHD4Ka6B2vKd4e.D35lls5iF((ListView)target, ypdvx3e483, W73HvvHD4Ka6B2vKd4e.MIbHH5Gk3A);
			break;
		case 3:
			W73HvvHD4Ka6B2vKd4e.D35lls5iF((ListView)target, ypdvx3e483, W73HvvHD4Ka6B2vKd4e.MIbHH5Gk3A);
			break;
		default:
			z1VvpKEZra = true;
			break;
		}
	}
}
