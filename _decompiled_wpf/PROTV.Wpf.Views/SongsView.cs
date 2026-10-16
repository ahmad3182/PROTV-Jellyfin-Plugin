using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using PROTV.Wpf.ViewModels;

namespace PROTV.Wpf.Views;

public class SongsView : UserControl, IComponentConnector
{
	internal ScrollViewer scollviewer;

	internal ListBox SongsList;

	internal Grid playlist;

	internal TextBox NewPlaylistName;

	private bool sofvFX8lys;

	public SongsView()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector();
		tApScD14t76npcHoQ1x.D35lls5iF(this, tApScD14t76npcHoQ1x.a9g8GO8VHL);
		G3VdnL8Rqe8pMl42pwq.D35lls5iF(this, new DependencyPropertyChangedEventHandler(btQvMDrXjh), G3VdnL8Rqe8pMl42pwq.pYG8km6cZy);
	}

	private void btQvMDrXjh(object P_0, DependencyPropertyChangedEventArgs P_1)
	{
		if (RAspAbuaTQFU0nSRiQ.D35lls5iF(this, RAspAbuaTQFU0nSRiQ.G1FymcVoT) is SongsViewModel songsViewModel)
		{
			gIK66e8viInneWK7Ck2.D35lls5iF(songsViewModel, SongsList, gIK66e8viInneWK7Ck2.qhZ8AO08gS);
		}
	}

	private void Vy9vCsCVOf(object P_0, MouseWheelEventArgs P_1)
	{
		mAdJWQ9yhneCbEXlGMc.D35lls5iF(scollviewer, bATk1clKMSyO8g9EVbN.D35lls5iF(scollviewer, bATk1clKMSyO8g9EVbN.HMvHoGcjPR) - (double)m9MGZR7k2RmVqYXYS5.D35lls5iF(P_1, m9MGZR7k2RmVqYXYS5.BoXHlIwNQk), mAdJWQ9yhneCbEXlGMc.OCfH9YuRTt);
	}

	[GeneratedCode("PresentationBuildTasks", "5.0.4.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!sofvFX8lys)
		{
			sofvFX8lys = true;
			Uri uri = new Uri(iFZ5je3XFYKwkvcE5D.D35lls5iF(3324, iFZ5je3XFYKwkvcE5D.N06TeK0ao), UriKind.Relative);
			TUdx26d4l5VwJTvopv.D35lls5iF(this, uri, TUdx26d4l5VwJTvopv.W3oUN4AKb);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "5.0.4.0")]
	internal Delegate fGOvYtEhbQ(Type P_0, string P_1)
	{
		return E6A9Xm2C8YsY6OX49j.D35lls5iF(P_0, this, P_1, E6A9Xm2C8YsY6OX49j.lecZDyFnW);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "5.0.4.0")]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		case 1:
			scollviewer = (ScrollViewer)target;
			break;
		case 2:
			SongsList = (ListBox)target;
			W73HvvHD4Ka6B2vKd4e.D35lls5iF(SongsList, Vy9vCsCVOf, W73HvvHD4Ka6B2vKd4e.MIbHH5Gk3A);
			break;
		case 3:
			playlist = (Grid)target;
			break;
		case 4:
			NewPlaylistName = (TextBox)target;
			break;
		default:
			sofvFX8lys = true;
			break;
		}
	}
}
