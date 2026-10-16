using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Controls;
using System.Windows.Markup;

namespace PROTV.Wpf.Views;

public class LiveViewSettings : UserControl, IComponentConnector
{
	internal RadioButton None;

	internal RadioButton NVIDIA;

	internal RadioButton Direct9;

	internal RadioButton Direct11;

	private bool QkMWF7dYTK;

	public LiveViewSettings()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector();
		hao3Y68m7Zvx79IIOKw.D35lls5iF(this, hao3Y68m7Zvx79IIOKw.fyXns2eyhS);
	}

	[GeneratedCode("PresentationBuildTasks", "5.0.4.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!QkMWF7dYTK)
		{
			QkMWF7dYTK = true;
			Uri uri = new Uri(iFZ5je3XFYKwkvcE5D.D35lls5iF(4976, iFZ5je3XFYKwkvcE5D.N06TeK0ao), UriKind.Relative);
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
			None = (RadioButton)target;
			break;
		case 2:
			NVIDIA = (RadioButton)target;
			break;
		case 3:
			Direct9 = (RadioButton)target;
			break;
		case 4:
			Direct11 = (RadioButton)target;
			break;
		default:
			QkMWF7dYTK = true;
			break;
		}
	}
}
