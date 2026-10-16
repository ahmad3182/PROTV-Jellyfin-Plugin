using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;

namespace PROTV.Wpf.Views;

public class ControllerPanelControl : UserControl, IComponentConnector
{
	internal Grid Controls;

	internal Slider PositionSlider;

	internal DockPanel ProgressPanel;

	internal Grid ControlsPanel;

	internal DockPanel LeftControls;

	internal ToggleButton OpenMenuButton;

	internal ToggleButton ToggleFullscreenButton;

	internal ToggleButton SoundMenuButton;

	internal Popup SoundMenuPopup;

	internal ToggleButton MuteUnmuteButton;

	internal ToggleButton OpenTextSizeButton;

	internal DockPanel RightControls;

	internal ToggleButton OpenDebugButton;

	internal DockPanel CenterControls;

	private bool lB9Leu698;

	public ControllerPanelControl()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector();
		AJv70itXcdnxnNYjSQ.D35lls5iF(this, AJv70itXcdnxnNYjSQ.AKpDbeeWGN);
	}

	[GeneratedCode("PresentationBuildTasks", "5.0.4.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!lB9Leu698)
		{
			lB9Leu698 = true;
			Uri uri = new Uri(iFZ5je3XFYKwkvcE5D.D35lls5iF(1062, iFZ5je3XFYKwkvcE5D.N06TeK0ao), UriKind.Relative);
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
			Controls = (Grid)target;
			break;
		case 2:
			PositionSlider = (Slider)target;
			break;
		case 3:
			ProgressPanel = (DockPanel)target;
			break;
		case 4:
			ControlsPanel = (Grid)target;
			break;
		case 5:
			LeftControls = (DockPanel)target;
			break;
		case 6:
			OpenMenuButton = (ToggleButton)target;
			break;
		case 7:
			ToggleFullscreenButton = (ToggleButton)target;
			break;
		case 8:
			SoundMenuButton = (ToggleButton)target;
			break;
		case 9:
			SoundMenuPopup = (Popup)target;
			break;
		case 10:
			MuteUnmuteButton = (ToggleButton)target;
			break;
		case 11:
			OpenTextSizeButton = (ToggleButton)target;
			break;
		case 12:
			RightControls = (DockPanel)target;
			break;
		case 13:
			OpenDebugButton = (ToggleButton)target;
			break;
		case 14:
			CenterControls = (DockPanel)target;
			break;
		default:
			lB9Leu698 = true;
			break;
		}
	}
}
