using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Controls;
using System.Windows.Markup;
using PROTV.Wpf.Helpers;
using PROTV.Wpf.ViewModels;

namespace PROTV.Wpf.Views;

public class MovieDetailsView : BasePage<MovieItemViewModel>, IComponentConnector
{
	internal PROTV.Wpf.Helpers.Image imagex;

	internal PROTV.Wpf.Helpers.Image imagexx;

	internal TextBlock text;

	private bool GcwjOX2Rf4;

	public MovieDetailsView()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector();
		tApScD14t76npcHoQ1x.D35lls5iF(this, tApScD14t76npcHoQ1x.TME1yYS5GD);
	}

	public MovieDetailsView(MovieItemViewModel specificViewModel)
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector(specificViewModel);
		tApScD14t76npcHoQ1x.D35lls5iF(this, tApScD14t76npcHoQ1x.TME1yYS5GD);
	}

	public override void Dispose()
	{
		HA9xp31qTso7BFFbOAp.D35lls5iF(imagex, null, HA9xp31qTso7BFFbOAp.ak51JUGhyn);
		HA9xp31qTso7BFFbOAp.D35lls5iF(imagexx, null, HA9xp31qTso7BFFbOAp.ak51JUGhyn);
		tApScD14t76npcHoQ1x.D35lls5iF(this, tApScD14t76npcHoQ1x.oMK1iBRN6V);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "5.0.4.0")]
	public void InitializeComponent()
	{
		if (!GcwjOX2Rf4)
		{
			GcwjOX2Rf4 = true;
			Uri uri = new Uri(iFZ5je3XFYKwkvcE5D.D35lls5iF(2134, iFZ5je3XFYKwkvcE5D.N06TeK0ao), UriKind.Relative);
			TUdx26d4l5VwJTvopv.D35lls5iF(this, uri, TUdx26d4l5VwJTvopv.W3oUN4AKb);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "5.0.4.0")]
	[DebuggerNonUserCode]
	internal Delegate dXkjefqfEi(Type P_0, string P_1)
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
			imagex = (PROTV.Wpf.Helpers.Image)target;
			break;
		case 2:
			imagexx = (PROTV.Wpf.Helpers.Image)target;
			break;
		case 3:
			text = (TextBlock)target;
			break;
		default:
			GcwjOX2Rf4 = true;
			break;
		}
	}
}
