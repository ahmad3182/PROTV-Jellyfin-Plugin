using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Security;
using System.Windows.Controls;
using System.Windows.Markup;
using PROTV.Wpf.ViewModels;

namespace PROTV.Wpf.Views;

public class LogInView : BasePage<LoginViewModel>, IHavePassword, IComponentConnector
{
	internal LogInView Page;

	internal TextBox email;

	internal PasswordBox password;

	internal CheckBox rememberme;

	private bool ApUjXVuJkR;

	public SecureString SecurePassword => WdEd4P1YqUyNUXB2roT.D35lls5iF(password, WdEd4P1YqUyNUXB2roT.tqs1gFb4oJ);

	public LogInView()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector();
		tApScD14t76npcHoQ1x.D35lls5iF(this, tApScD14t76npcHoQ1x.vQ51cFovjG);
		if (GmMLaTD7kV8rq88ZFvR.D35lls5iF(xrWtp71MaQsXtvtrqkf.D35lls5iF(Jr0pTQlovwB9pdID1EB.D35lls5iF(Jr0pTQlovwB9pdID1EB.CxrllgXtD4), xrWtp71MaQsXtvtrqkf.fxR1SMKb5A), iFZ5je3XFYKwkvcE5D.D35lls5iF(1844, iFZ5je3XFYKwkvcE5D.N06TeK0ao), GmMLaTD7kV8rq88ZFvR.VGG1KpDfXX))
		{
			qni3xrDkAJ3vF35eMav.D35lls5iF(email, wq2usy8gNndpuTw5mR.D35lls5iF(auEPOZ1NWYKXdU711jq.D35lls5iF(xrWtp71MaQsXtvtrqkf.D35lls5iF(Jr0pTQlovwB9pdID1EB.D35lls5iF(Jr0pTQlovwB9pdID1EB.CxrllgXtD4), xrWtp71MaQsXtvtrqkf.fxR1SMKb5A), iFZ5je3XFYKwkvcE5D.D35lls5iF(1844, iFZ5je3XFYKwkvcE5D.N06TeK0ao), auEPOZ1NWYKXdU711jq.Y1J1OKa53W), wq2usy8gNndpuTw5mR.ajcDe8nffb), qni3xrDkAJ3vF35eMav.nVo1urWcMH);
		}
		if (GmMLaTD7kV8rq88ZFvR.D35lls5iF(xrWtp71MaQsXtvtrqkf.D35lls5iF(Jr0pTQlovwB9pdID1EB.D35lls5iF(Jr0pTQlovwB9pdID1EB.CxrllgXtD4), xrWtp71MaQsXtvtrqkf.fxR1SMKb5A), iFZ5je3XFYKwkvcE5D.D35lls5iF(1858, iFZ5je3XFYKwkvcE5D.N06TeK0ao), GmMLaTD7kV8rq88ZFvR.VGG1KpDfXX))
		{
			qni3xrDkAJ3vF35eMav.D35lls5iF(password, wq2usy8gNndpuTw5mR.D35lls5iF(auEPOZ1NWYKXdU711jq.D35lls5iF(xrWtp71MaQsXtvtrqkf.D35lls5iF(Jr0pTQlovwB9pdID1EB.D35lls5iF(Jr0pTQlovwB9pdID1EB.CxrllgXtD4), xrWtp71MaQsXtvtrqkf.fxR1SMKb5A), iFZ5je3XFYKwkvcE5D.D35lls5iF(1858, iFZ5je3XFYKwkvcE5D.N06TeK0ao), auEPOZ1NWYKXdU711jq.Y1J1OKa53W), wq2usy8gNndpuTw5mR.ajcDe8nffb), qni3xrDkAJ3vF35eMav.LBs1PZD4lL);
		}
		if (!M6ZErPEr2LZyWYpa5O.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(email, wq2usy8gNndpuTw5mR.iOM1s39R7S), M6ZErPEr2LZyWYpa5O.rg89aHbgYh))
		{
			vDQO3v1hqDY2TXHP9L4.D35lls5iF(rememberme, true, vDQO3v1hqDY2TXHP9L4.mYN1xm43mN);
		}
	}

	public LogInView(LoginViewModel specificViewModel)
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector(specificViewModel);
		tApScD14t76npcHoQ1x.D35lls5iF(this, tApScD14t76npcHoQ1x.vQ51cFovjG);
		if (GmMLaTD7kV8rq88ZFvR.D35lls5iF(xrWtp71MaQsXtvtrqkf.D35lls5iF(Jr0pTQlovwB9pdID1EB.D35lls5iF(Jr0pTQlovwB9pdID1EB.CxrllgXtD4), xrWtp71MaQsXtvtrqkf.fxR1SMKb5A), iFZ5je3XFYKwkvcE5D.D35lls5iF(1844, iFZ5je3XFYKwkvcE5D.N06TeK0ao), GmMLaTD7kV8rq88ZFvR.VGG1KpDfXX))
		{
			qni3xrDkAJ3vF35eMav.D35lls5iF(email, wq2usy8gNndpuTw5mR.D35lls5iF(auEPOZ1NWYKXdU711jq.D35lls5iF(xrWtp71MaQsXtvtrqkf.D35lls5iF(Jr0pTQlovwB9pdID1EB.D35lls5iF(Jr0pTQlovwB9pdID1EB.CxrllgXtD4), xrWtp71MaQsXtvtrqkf.fxR1SMKb5A), iFZ5je3XFYKwkvcE5D.D35lls5iF(1844, iFZ5je3XFYKwkvcE5D.N06TeK0ao), auEPOZ1NWYKXdU711jq.Y1J1OKa53W), wq2usy8gNndpuTw5mR.ajcDe8nffb), qni3xrDkAJ3vF35eMav.nVo1urWcMH);
		}
		if (GmMLaTD7kV8rq88ZFvR.D35lls5iF(xrWtp71MaQsXtvtrqkf.D35lls5iF(Jr0pTQlovwB9pdID1EB.D35lls5iF(Jr0pTQlovwB9pdID1EB.CxrllgXtD4), xrWtp71MaQsXtvtrqkf.fxR1SMKb5A), iFZ5je3XFYKwkvcE5D.D35lls5iF(1858, iFZ5je3XFYKwkvcE5D.N06TeK0ao), GmMLaTD7kV8rq88ZFvR.VGG1KpDfXX))
		{
			qni3xrDkAJ3vF35eMav.D35lls5iF(password, wq2usy8gNndpuTw5mR.D35lls5iF(auEPOZ1NWYKXdU711jq.D35lls5iF(xrWtp71MaQsXtvtrqkf.D35lls5iF(Jr0pTQlovwB9pdID1EB.D35lls5iF(Jr0pTQlovwB9pdID1EB.CxrllgXtD4), xrWtp71MaQsXtvtrqkf.fxR1SMKb5A), iFZ5je3XFYKwkvcE5D.D35lls5iF(1858, iFZ5je3XFYKwkvcE5D.N06TeK0ao), auEPOZ1NWYKXdU711jq.Y1J1OKa53W), wq2usy8gNndpuTw5mR.ajcDe8nffb), qni3xrDkAJ3vF35eMav.LBs1PZD4lL);
		}
		if (!M6ZErPEr2LZyWYpa5O.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(email, wq2usy8gNndpuTw5mR.iOM1s39R7S), M6ZErPEr2LZyWYpa5O.rg89aHbgYh))
		{
			vDQO3v1hqDY2TXHP9L4.D35lls5iF(rememberme, true, vDQO3v1hqDY2TXHP9L4.mYN1xm43mN);
		}
	}

	public override void Dispose()
	{
		tApScD14t76npcHoQ1x.D35lls5iF(this, tApScD14t76npcHoQ1x.oMK1iBRN6V);
	}

	[GeneratedCode("PresentationBuildTasks", "5.0.4.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!ApUjXVuJkR)
		{
			ApUjXVuJkR = true;
			Uri uri = new Uri(iFZ5je3XFYKwkvcE5D.D35lls5iF(1878, iFZ5je3XFYKwkvcE5D.N06TeK0ao), UriKind.Relative);
			TUdx26d4l5VwJTvopv.D35lls5iF(this, uri, TUdx26d4l5VwJTvopv.W3oUN4AKb);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "5.0.4.0")]
	[DebuggerNonUserCode]
	internal Delegate ShXjmIawPV(Type P_0, string P_1)
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
			Page = (LogInView)target;
			break;
		case 2:
			email = (TextBox)target;
			break;
		case 3:
			password = (PasswordBox)target;
			break;
		case 4:
			rememberme = (CheckBox)target;
			break;
		default:
			ApUjXVuJkR = true;
			break;
		}
	}
}
