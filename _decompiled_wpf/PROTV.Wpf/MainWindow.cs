using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using HandyControl.Controls;

namespace PROTV.Wpf;

public class MainWindow : HandyControl.Controls.Window, IComponentConnector
{
	private bool cUodGmyhI;

	public MainWindow()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector();
		AJv70itXcdnxnNYjSQ.D35lls5iF(this, AJv70itXcdnxnNYjSQ.c0rKvIO37);
		XgfudvNjrG5dZKyndN.D35lls5iF(this, HKhB02Awj, XgfudvNjrG5dZKyndN.gLjOD6KQ7);
	}

	private void HKhB02Awj(object P_0, KeyEventArgs P_1)
	{
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Invalid comparison between Unknown and I4
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Invalid comparison between Unknown and I4
		if (!(RAspAbuaTQFU0nSRiQ.D35lls5iF(P_1, RAspAbuaTQFU0nSRiQ.YRbPgco79) is System.Windows.Controls.TextBox) && !(RAspAbuaTQFU0nSRiQ.D35lls5iF(P_1, RAspAbuaTQFU0nSRiQ.YRbPgco79) is System.Windows.Controls.PasswordBox) && !(RAspAbuaTQFU0nSRiQ.D35lls5iF(P_1, RAspAbuaTQFU0nSRiQ.YRbPgco79) is CheckBox))
		{
			yfy1wssmHv811G3r43.D35lls5iF((DependencyObject)(object)this, true, yfy1wssmHv811G3r43.fw2hEbsAm);
			lpNmWGxSvw4A2wThUG.D35lls5iF((DependencyObject)(object)this, this, lpNmWGxSvw4A2wThUG.NYpYJBiHr);
			if ((int)X6dagBgIU5bQsE98LL.D35lls5iF(P_1, X6dagBgIU5bQsE98LL.dcKiqyPBj) == 100)
			{
				QnJnl7fVDKI4mA6voc.D35lls5iF(this, !hjMnupQVVDlRZAYQJC.D35lls5iF(this, hjMnupQVVDlRZAYQJC.MZZXolWCl), QnJnl7fVDKI4mA6voc.MeDF15iNn);
			}
			if ((int)X6dagBgIU5bQsE98LL.D35lls5iF(P_1, X6dagBgIU5bQsE98LL.dcKiqyPBj) == 13)
			{
				QnJnl7fVDKI4mA6voc.D35lls5iF(this, false, QnJnl7fVDKI4mA6voc.MeDF15iNn);
			}
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "5.0.4.0")]
	public void InitializeComponent()
	{
		if (!cUodGmyhI)
		{
			cUodGmyhI = true;
			Uri uri = new Uri(iFZ5je3XFYKwkvcE5D.D35lls5iF(108, iFZ5je3XFYKwkvcE5D.N06TeK0ao), UriKind.Relative);
			TUdx26d4l5VwJTvopv.D35lls5iF(this, uri, TUdx26d4l5VwJTvopv.W3oUN4AKb);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "5.0.4.0")]
	[DebuggerNonUserCode]
	internal Delegate eF6DewDGs(Type P_0, string P_1)
	{
		return E6A9Xm2C8YsY6OX49j.D35lls5iF(P_0, this, P_1, E6A9Xm2C8YsY6OX49j.lecZDyFnW);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "5.0.4.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		cUodGmyhI = true;
	}
}
