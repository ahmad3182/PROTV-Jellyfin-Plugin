using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using PROTV.Wpf.ViewModels;

namespace PROTV.Wpf.Views;

public class MoviesView : BasePage<MoviesViewModel>, IComponentConnector
{
	internal Grid grid1;

	internal ComboBox movielist;

	internal ScrollViewer scollviewer;

	internal ListBox listx;

	private bool iJHv4mQ1ay;

	public MoviesView()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector();
		tApScD14t76npcHoQ1x.D35lls5iF(this, tApScD14t76npcHoQ1x.CYw15xuXhi);
	}

	public MoviesView(MoviesViewModel specificViewModel)
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector(specificViewModel);
		tApScD14t76npcHoQ1x.D35lls5iF(this, tApScD14t76npcHoQ1x.CYw15xuXhi);
	}

	private void LcFvjxWNMF(object P_0, MouseWheelEventArgs P_1)
	{
		mAdJWQ9yhneCbEXlGMc.D35lls5iF(scollviewer, bATk1clKMSyO8g9EVbN.D35lls5iF(scollviewer, bATk1clKMSyO8g9EVbN.HMvHoGcjPR) - (double)m9MGZR7k2RmVqYXYS5.D35lls5iF(P_1, m9MGZR7k2RmVqYXYS5.BoXHlIwNQk), mAdJWQ9yhneCbEXlGMc.OCfH9YuRTt);
	}

	private void VvevviCWAV(object P_0, SelectionChangedEventArgs P_1)
	{
		if (RAspAbuaTQFU0nSRiQ.D35lls5iF(listx, RAspAbuaTQFU0nSRiQ.Bbw1z2gdCH) != null)
		{
			_ = k4QmcH8D3DQM6cKOKge.D35lls5iF(Avn84T8ocVcbIlJ2Y1e.D35lls5iF(listx, Avn84T8ocVcbIlJ2Y1e.Wrp8lMdWHg), m9MGZR7k2RmVqYXYS5.D35lls5iF(listx, m9MGZR7k2RmVqYXYS5.EJB89J1EPo), k4QmcH8D3DQM6cKOKge.iTE8H1djYB) is ListBoxItem;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "5.0.4.0")]
	public void InitializeComponent()
	{
		if (!iJHv4mQ1ay)
		{
			iJHv4mQ1ay = true;
			Uri uri = new Uri(iFZ5je3XFYKwkvcE5D.D35lls5iF(2384, iFZ5je3XFYKwkvcE5D.N06TeK0ao), UriKind.Relative);
			TUdx26d4l5VwJTvopv.D35lls5iF(this, uri, TUdx26d4l5VwJTvopv.W3oUN4AKb);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "5.0.4.0")]
	internal Delegate bgWvWS8W0o(Type P_0, string P_1)
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
			grid1 = (Grid)target;
			break;
		case 2:
			movielist = (ComboBox)target;
			break;
		case 3:
			scollviewer = (ScrollViewer)target;
			break;
		case 4:
			listx = (ListBox)target;
			oumatx81yvZcpsmEIHa.D35lls5iF(listx, VvevviCWAV, oumatx81yvZcpsmEIHa.rZD88lCdXp);
			W73HvvHD4Ka6B2vKd4e.D35lls5iF(listx, LcFvjxWNMF, W73HvvHD4Ka6B2vKd4e.MIbHH5Gk3A);
			break;
		default:
			iJHv4mQ1ay = true;
			break;
		}
	}
}
