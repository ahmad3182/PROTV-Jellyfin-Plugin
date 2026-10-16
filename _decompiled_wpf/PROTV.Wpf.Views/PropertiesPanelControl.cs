using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Controls;
using System.Windows.Markup;

namespace PROTV.Wpf.Views;

public class PropertiesPanelControl : UserControl, IComponentConnector
{
	internal Border PropertyExplorerPanel;

	internal Grid PropertyExplorerPanelContent;

	private bool P7xvmrepvU;

	public PropertiesPanelControl()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector();
		hao3Y68m7Zvx79IIOKw.D35lls5iF(this, hao3Y68m7Zvx79IIOKw.Va18q2I0i4);
	}

	[GeneratedCode("PresentationBuildTasks", "5.0.4.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!P7xvmrepvU)
		{
			P7xvmrepvU = true;
			Uri uri = new Uri(iFZ5je3XFYKwkvcE5D.D35lls5iF(3722, iFZ5je3XFYKwkvcE5D.N06TeK0ao), UriKind.Relative);
			TUdx26d4l5VwJTvopv.D35lls5iF(this, uri, TUdx26d4l5VwJTvopv.W3oUN4AKb);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "5.0.4.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		case 1:
			PropertyExplorerPanel = (Border)target;
			break;
		case 2:
			PropertyExplorerPanelContent = (Grid)target;
			break;
		default:
			P7xvmrepvU = true;
			break;
		}
	}
}
