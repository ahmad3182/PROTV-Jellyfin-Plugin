using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Controls;
using System.Windows.Markup;

namespace PROTV.Wpf.Views;

public class MyWatchListPage : BasePage<MyListViewModel>, IComponentConnector
{
	internal Grid grid;

	internal ScrollViewer MyScrollViewer;

	internal ListView listView;

	private bool rsswpq5wL;

	public MyWatchListPage()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector();
		AJv70itXcdnxnNYjSQ.D35lls5iF(this, AJv70itXcdnxnNYjSQ.BOKDO8N5l0);
	}

	public MyWatchListPage(MyListViewModel specificViewModel)
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector(specificViewModel);
		AJv70itXcdnxnNYjSQ.D35lls5iF(this, AJv70itXcdnxnNYjSQ.BOKDO8N5l0);
	}

	[GeneratedCode("PresentationBuildTasks", "5.0.4.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!rsswpq5wL)
		{
			rsswpq5wL = true;
			Uri uri = new Uri(iFZ5je3XFYKwkvcE5D.D35lls5iF(850, iFZ5je3XFYKwkvcE5D.N06TeK0ao), UriKind.Relative);
			TUdx26d4l5VwJTvopv.D35lls5iF(this, uri, TUdx26d4l5VwJTvopv.W3oUN4AKb);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "5.0.4.0")]
	[DebuggerNonUserCode]
	internal Delegate P5ZRSgPRp(Type P_0, string P_1)
	{
		return E6A9Xm2C8YsY6OX49j.D35lls5iF(P_0, this, P_1, E6A9Xm2C8YsY6OX49j.lecZDyFnW);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "5.0.4.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		case 1:
			grid = (Grid)target;
			break;
		case 2:
			MyScrollViewer = (ScrollViewer)target;
			break;
		case 3:
			listView = (ListView)target;
			break;
		default:
			rsswpq5wL = true;
			break;
		}
	}
}
