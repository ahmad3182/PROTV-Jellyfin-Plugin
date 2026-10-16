using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Controls;
using System.Windows.Markup;

namespace PROTV.Wpf.Views;

public class SongInfoView : UserControl, IComponentConnector
{
	internal StackPanel ButtonsList;

	private bool moMvNuvYtp;

	public SongInfoView()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector();
		tApScD14t76npcHoQ1x.D35lls5iF(this, tApScD14t76npcHoQ1x.CTg8eGd94u);
	}

	[GeneratedCode("PresentationBuildTasks", "5.0.4.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!moMvNuvYtp)
		{
			moMvNuvYtp = true;
			Uri uri = new Uri(iFZ5je3XFYKwkvcE5D.D35lls5iF(3204, iFZ5je3XFYKwkvcE5D.N06TeK0ao), UriKind.Relative);
			TUdx26d4l5VwJTvopv.D35lls5iF(this, uri, TUdx26d4l5VwJTvopv.W3oUN4AKb);
		}
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "5.0.4.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		if (connectionId == 1)
		{
			ButtonsList = (StackPanel)target;
		}
		else
		{
			moMvNuvYtp = true;
		}
	}
}
