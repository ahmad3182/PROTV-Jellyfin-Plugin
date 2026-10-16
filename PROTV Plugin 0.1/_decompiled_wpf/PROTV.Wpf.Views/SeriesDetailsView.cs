using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using PROTV.Abstractions.Common;
using PROTV.Wpf.ViewModels;

namespace PROTV.Wpf.Views;

public class SeriesDetailsView : BasePage<SeriesItemViewModel>, IComponentConnector
{
	internal ScrollViewer mainscroll;

	internal TextBlock text;

	internal ScrollViewer MyScrollViewer;

	internal ListView listView;

	private bool YBaWI7mcFA;

	public SeriesDetailsView()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector();
		hao3Y68m7Zvx79IIOKw.D35lls5iF(this, hao3Y68m7Zvx79IIOKw.cdVnE3MXDG);
	}

	public SeriesDetailsView(SeriesItemViewModel specificViewModel)
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector(specificViewModel);
		hao3Y68m7Zvx79IIOKw.D35lls5iF(this, hao3Y68m7Zvx79IIOKw.cdVnE3MXDG);
		if (Po4t9wnrBA7594AVo65.D35lls5iF(wFALqDnBsAqnd0Cclwg.D35lls5iF(specificViewModel, wFALqDnBsAqnd0Cclwg.HyTn0O4MGX), Po4t9wnrBA7594AVo65.VwAnewPiPr) == PROTV.Abstractions.Common.Language.Arabic)
		{
			k2ca1InG5erYrdWfuxS.D35lls5iF(text, FlowDirection.RightToLeft, k2ca1InG5erYrdWfuxS.wr6nRiDCmo);
		}
	}

	private void uFAWPq5ppQ(object P_0, MouseWheelEventArgs P_1)
	{
		mAdJWQ9yhneCbEXlGMc.D35lls5iF(MyScrollViewer, bATk1clKMSyO8g9EVbN.D35lls5iF(MyScrollViewer, bATk1clKMSyO8g9EVbN.z6w1v72wsS) - (double)m9MGZR7k2RmVqYXYS5.D35lls5iF(P_1, m9MGZR7k2RmVqYXYS5.BoXHlIwNQk), mAdJWQ9yhneCbEXlGMc.HXW1ApOOWD);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "5.0.4.0")]
	public void InitializeComponent()
	{
		if (!YBaWI7mcFA)
		{
			YBaWI7mcFA = true;
			Uri uri = new Uri(iFZ5je3XFYKwkvcE5D.D35lls5iF(4314, iFZ5je3XFYKwkvcE5D.N06TeK0ao), UriKind.Relative);
			TUdx26d4l5VwJTvopv.D35lls5iF(this, uri, TUdx26d4l5VwJTvopv.W3oUN4AKb);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "5.0.4.0")]
	[DebuggerNonUserCode]
	internal Delegate snhWqdeIOl(Type P_0, string P_1)
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
			mainscroll = (ScrollViewer)target;
			break;
		case 2:
			text = (TextBlock)target;
			break;
		case 3:
			MyScrollViewer = (ScrollViewer)target;
			W73HvvHD4Ka6B2vKd4e.D35lls5iF(MyScrollViewer, uFAWPq5ppQ, W73HvvHD4Ka6B2vKd4e.MIbHH5Gk3A);
			break;
		case 4:
			listView = (ListView)target;
			break;
		default:
			YBaWI7mcFA = true;
			break;
		}
	}
}
