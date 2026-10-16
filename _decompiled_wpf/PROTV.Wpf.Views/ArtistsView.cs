using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;

namespace PROTV.Wpf.Views;

public class ArtistsView : UserControl, IComponentConnector
{
	internal ScrollViewer scollviewer;

	private bool rhqvtFHMeh;

	public ArtistsView()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector();
		tApScD14t76npcHoQ1x.D35lls5iF(this, tApScD14t76npcHoQ1x.U6Y8LnitIm);
	}

	private void EqqvTUK368(object P_0, MouseWheelEventArgs P_1)
	{
		mAdJWQ9yhneCbEXlGMc.D35lls5iF(scollviewer, bATk1clKMSyO8g9EVbN.D35lls5iF(scollviewer, bATk1clKMSyO8g9EVbN.HMvHoGcjPR) - (double)m9MGZR7k2RmVqYXYS5.D35lls5iF(P_1, m9MGZR7k2RmVqYXYS5.BoXHlIwNQk), mAdJWQ9yhneCbEXlGMc.OCfH9YuRTt);
	}

	[GeneratedCode("PresentationBuildTasks", "5.0.4.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!rhqvtFHMeh)
		{
			rhqvtFHMeh = true;
			Uri uri = new Uri(iFZ5je3XFYKwkvcE5D.D35lls5iF(2950, iFZ5je3XFYKwkvcE5D.N06TeK0ao), UriKind.Relative);
			TUdx26d4l5VwJTvopv.D35lls5iF(this, uri, TUdx26d4l5VwJTvopv.W3oUN4AKb);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "5.0.4.0")]
	[DebuggerNonUserCode]
	internal Delegate CG3vZJxTER(Type P_0, string P_1)
	{
		return E6A9Xm2C8YsY6OX49j.D35lls5iF(P_0, this, P_1, E6A9Xm2C8YsY6OX49j.lecZDyFnW);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "5.0.4.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		case 1:
			scollviewer = (ScrollViewer)target;
			break;
		case 2:
			W73HvvHD4Ka6B2vKd4e.D35lls5iF((ListBox)target, EqqvTUK368, W73HvvHD4Ka6B2vKd4e.MIbHH5Gk3A);
			break;
		default:
			rhqvtFHMeh = true;
			break;
		}
	}
}
