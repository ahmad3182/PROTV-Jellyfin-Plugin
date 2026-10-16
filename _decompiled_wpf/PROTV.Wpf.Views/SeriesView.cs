using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media.Animation;
using PROTV.Wpf.ViewModels;

namespace PROTV.Wpf.Views;

public class SeriesView : BasePage<SeriesViewModel>, IComponentConnector, IStyleConnector
{
	internal Grid grid1;

	internal ComboBox movielist;

	internal ScrollViewer scollviewer;

	private bool mwOWY5phF9;

	public SeriesView()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector();
		hao3Y68m7Zvx79IIOKw.D35lls5iF(this, hao3Y68m7Zvx79IIOKw.OignpmqWOo);
	}

	public SeriesView(SeriesViewModel specificViewModel)
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector(specificViewModel);
		hao3Y68m7Zvx79IIOKw.D35lls5iF(this, hao3Y68m7Zvx79IIOKw.OignpmqWOo);
	}

	private void kwRWAvSkcR(object P_0, MouseWheelEventArgs P_1)
	{
		mAdJWQ9yhneCbEXlGMc.D35lls5iF(scollviewer, bATk1clKMSyO8g9EVbN.D35lls5iF(scollviewer, bATk1clKMSyO8g9EVbN.HMvHoGcjPR) - (double)m9MGZR7k2RmVqYXYS5.D35lls5iF(P_1, m9MGZR7k2RmVqYXYS5.BoXHlIwNQk), mAdJWQ9yhneCbEXlGMc.OCfH9YuRTt);
	}

	private void aqyWNxJNLN(object P_0, MouseEventArgs P_1)
	{
		Canvas canvas = P_0 as Canvas;
		TextBlock textBlock = a2DeiOnwg60giMkvL04.D35lls5iF(HP4bh0HYlNhH02dtQyD.D35lls5iF(canvas, HP4bh0HYlNhH02dtQyD.xGDHg4mrX2), 0, a2DeiOnwg60giMkvL04.fu5nCHPSa4) as TextBlock;
		if (!hjMnupQVVDlRZAYQJC.D35lls5iF(textBlock, hjMnupQVVDlRZAYQJC.e5Knm0FKKL) && !(bATk1clKMSyO8g9EVbN.D35lls5iF(textBlock, bATk1clKMSyO8g9EVbN.LZ5naZ8G19) < bATk1clKMSyO8g9EVbN.D35lls5iF(canvas, bATk1clKMSyO8g9EVbN.LZ5naZ8G19)))
		{
			double num = bATk1clKMSyO8g9EVbN.D35lls5iF(canvas, bATk1clKMSyO8g9EVbN.jUBnILD6KS) - bATk1clKMSyO8g9EVbN.D35lls5iF(textBlock, bATk1clKMSyO8g9EVbN.jUBnILD6KS);
			VKPgscndlUWLn8geWtk.D35lls5iF(textBlock, new Thickness(0.0, num / 2.0, 0.0, 0.0), VKPgscndlUWLn8geWtk.t0onUS0HAZ);
			DoubleAnimation doubleAnimation = new DoubleAnimation();
			YqunhentMQKNCD4wpOZ.D35lls5iF(doubleAnimation, 0.0, YqunhentMQKNCD4wpOZ.b0CnVdTyrO);
			YqunhentMQKNCD4wpOZ.D35lls5iF(doubleAnimation, bATk1clKMSyO8g9EVbN.D35lls5iF(canvas, bATk1clKMSyO8g9EVbN.LZ5naZ8G19) - bATk1clKMSyO8g9EVbN.D35lls5iF(textBlock, bATk1clKMSyO8g9EVbN.LZ5naZ8G19) - 50.0, YqunhentMQKNCD4wpOZ.Pl6n74M0Z5);
			Ddn7jUnSuCuIl3Ud50C.D35lls5iF(doubleAnimation, dt7QxPncDClNwKpdD8w.D35lls5iF(dt7QxPncDClNwKpdD8w.Y7MnMYaerD), Ddn7jUnSuCuIl3Ud50C.in0nKhlnyt);
			vxpSXTnNiJtJZveTWAu.D35lls5iF(doubleAnimation, new Duration(aNJrrPl4soK5NDOndiN.D35lls5iF(dcJjqelwgiZ4n97w1vs.D35lls5iF(bATk1clKMSyO8g9EVbN.D35lls5iF(canvas, bATk1clKMSyO8g9EVbN.LZ5naZ8G19) - bATk1clKMSyO8g9EVbN.D35lls5iF(textBlock, bATk1clKMSyO8g9EVbN.LZ5naZ8G19) - 50.0, dcJjqelwgiZ4n97w1vs.jM2lCY9POn) / 25.0, aNJrrPl4soK5NDOndiN.Ca9lahqtKS)), vxpSXTnNiJtJZveTWAu.sGenOfQp8k);
			PPDimmnugvGlHAm79pa.D35lls5iF(textBlock, Canvas.LeftProperty, doubleAnimation, PPDimmnugvGlHAm79pa.YpEnPXJgoG);
		}
	}

	private void YJaWM0Zp6G(object P_0, MouseEventArgs P_1)
	{
		TextBlock textBlock = a2DeiOnwg60giMkvL04.D35lls5iF(HP4bh0HYlNhH02dtQyD.D35lls5iF(P_0 as Canvas, HP4bh0HYlNhH02dtQyD.xGDHg4mrX2), 0, a2DeiOnwg60giMkvL04.fu5nCHPSa4) as TextBlock;
		if (hjMnupQVVDlRZAYQJC.D35lls5iF(textBlock, hjMnupQVVDlRZAYQJC.e5Knm0FKKL))
		{
			PPDimmnugvGlHAm79pa.D35lls5iF(textBlock, Canvas.LeftProperty, null, PPDimmnugvGlHAm79pa.YpEnPXJgoG);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "5.0.4.0")]
	public void InitializeComponent()
	{
		if (!mwOWY5phF9)
		{
			mwOWY5phF9 = true;
			Uri uri = new Uri(iFZ5je3XFYKwkvcE5D.D35lls5iF(4874, iFZ5je3XFYKwkvcE5D.N06TeK0ao), UriKind.Relative);
			TUdx26d4l5VwJTvopv.D35lls5iF(this, uri, TUdx26d4l5VwJTvopv.W3oUN4AKb);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "5.0.4.0")]
	[DebuggerNonUserCode]
	internal Delegate yTxWCtFh9s(Type P_0, string P_1)
	{
		return E6A9Xm2C8YsY6OX49j.D35lls5iF(P_0, this, P_1, E6A9Xm2C8YsY6OX49j.lecZDyFnW);
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "5.0.4.0")]
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
		case 4:
			scollviewer = (ScrollViewer)target;
			break;
		case 5:
			W73HvvHD4Ka6B2vKd4e.D35lls5iF((ListBox)target, kwRWAvSkcR, W73HvvHD4Ka6B2vKd4e.MIbHH5Gk3A);
			break;
		default:
			mwOWY5phF9 = true;
			break;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "5.0.4.0")]
	[DebuggerNonUserCode]
	void IStyleConnector.Connect(int connectionId, object target)
	{
		if (connectionId == 3)
		{
			Av2eQglnElp5ZoM4x07.D35lls5iF((Canvas)target, YJaWM0Zp6G, Av2eQglnElp5ZoM4x07.Sm1H60E3gg);
			Av2eQglnElp5ZoM4x07.D35lls5iF((Canvas)target, aqyWNxJNLN, Av2eQglnElp5ZoM4x07.VD7HAHAE20);
		}
	}
}
