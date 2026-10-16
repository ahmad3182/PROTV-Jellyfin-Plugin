using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using PROTV.Abstractions.Common;
using PROTV.Wpf.ViewModels;

namespace PROTV.Wpf.Views;

public class PageHost : UserControl, IComponentConnector
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass9_0
	{
		public ContentControl y4yTr0liv6;

		public Action FiKTHYqmM8;

		public _003C_003Ec__DisplayClass9_0()
		{
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
			base._002Ector();
		}

		internal void HnHTegPLn6(Task t)
		{
			bRAh8kDAgKIlehXIXku.D35lls5iF(Jr0pTQlovwB9pdID1EB.D35lls5iF(Jr0pTQlovwB9pdID1EB.CxrllgXtD4), bRAh8kDAgKIlehXIXku.oESD6ce9jH).Invoke((Action)delegate
			{
				try
				{
					fp757nBYjo8889efKFJ.D35lls5iF(RAspAbuaTQFU0nSRiQ.D35lls5iF(y4yTr0liv6, RAspAbuaTQFU0nSRiQ.ON08dhk9Rp) as BasePage, fp757nBYjo8889efKFJ.kZZprll0Oa);
				}
				catch
				{
				}
				KBhlAv9D2TgBJ1kkc0B.D35lls5iF(y4yTr0liv6, null, KBhlAv9D2TgBJ1kkc0B.BEM8tsTOb9);
			});
		}

		internal void TKwTOPVDRx()
		{
			try
			{
				fp757nBYjo8889efKFJ.D35lls5iF(RAspAbuaTQFU0nSRiQ.D35lls5iF(y4yTr0liv6, RAspAbuaTQFU0nSRiQ.ON08dhk9Rp) as BasePage, fp757nBYjo8889efKFJ.kZZprll0Oa);
			}
			catch
			{
			}
			KBhlAv9D2TgBJ1kkc0B.D35lls5iF(y4yTr0liv6, null, KBhlAv9D2TgBJ1kkc0B.BEM8tsTOb9);
		}
	}

	public static readonly DependencyProperty CurrentAppPageProperty;

	public static readonly DependencyProperty CurrentAppPageViewModelProperty;

	internal ContentControl OldPage;

	internal ContentControl NewPage;

	private bool IF6vsFh6xG;

	public ApplicationPage CurrentAppPage
	{
		get
		{
			return (ApplicationPage)EmqD3J86gxqLokWBlHc.D35lls5iF(this, CurrentAppPageProperty, EmqD3J86gxqLokWBlHc.q0W8pLlgXM);
		}
		set
		{
			jsMkaY8wkGDPQeJiaWA.D35lls5iF(this, CurrentAppPageProperty, value, jsMkaY8wkGDPQeJiaWA.ppe8CdkjEY);
		}
	}

	public BaseViewModel CurrentAppPageViewModel
	{
		get
		{
			return (BaseViewModel)EmqD3J86gxqLokWBlHc.D35lls5iF(this, CurrentAppPageViewModelProperty, EmqD3J86gxqLokWBlHc.q0W8pLlgXM);
		}
		set
		{
			jsMkaY8wkGDPQeJiaWA.D35lls5iF(this, CurrentAppPageViewModelProperty, value, jsMkaY8wkGDPQeJiaWA.ppe8CdkjEY);
		}
	}

	public PageHost()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector();
		hao3Y68m7Zvx79IIOKw.D35lls5iF(this, hao3Y68m7Zvx79IIOKw.rUk8aCCGok);
	}

	private static object dduv6o7Gq1(DependencyObject P_0, object P_1)
	{
		try
		{
			_003C_003Ec__DisplayClass9_0 CS_0024_003C_003E8__locals4 = new _003C_003Ec__DisplayClass9_0();
			ApplicationPage applicationPage = (ApplicationPage)P_1;
			object obj = EmqD3J86gxqLokWBlHc.D35lls5iF(P_0, CurrentAppPageViewModelProperty, EmqD3J86gxqLokWBlHc.zno8ILg6BC);
			ContentControl newPage = (P_0 as PageHost).NewPage;
			CS_0024_003C_003E8__locals4.y4yTr0liv6 = (P_0 as PageHost).OldPage;
			if (RAspAbuaTQFU0nSRiQ.D35lls5iF(newPage, RAspAbuaTQFU0nSRiQ.ON08dhk9Rp) is BasePage)
			{
				BasePage basePage = (BasePage)RAspAbuaTQFU0nSRiQ.D35lls5iF(newPage, RAspAbuaTQFU0nSRiQ.ON08dhk9Rp);
				if (Ad8NmsHKMDNoqEDFjtJ.D35lls5iF(basePage, Ad8NmsHKMDNoqEDFjtJ.ljhHNvS1WJ) == applicationPage)
				{
					KBhlAv9D2TgBJ1kkc0B.D35lls5iF(basePage, obj, KBhlAv9D2TgBJ1kkc0B.Sfr8Ug70UF);
					return P_1;
				}
			}
			object obj2 = RAspAbuaTQFU0nSRiQ.D35lls5iF(newPage, RAspAbuaTQFU0nSRiQ.ON08dhk9Rp);
			KBhlAv9D2TgBJ1kkc0B.D35lls5iF(newPage, null, KBhlAv9D2TgBJ1kkc0B.BEM8tsTOb9);
			KBhlAv9D2TgBJ1kkc0B.D35lls5iF(CS_0024_003C_003E8__locals4.y4yTr0liv6, obj2, KBhlAv9D2TgBJ1kkc0B.BEM8tsTOb9);
			if (obj2 is BasePage)
			{
				BasePage obj3 = (BasePage)obj2;
				QnJnl7fVDKI4mA6voc.D35lls5iF(obj3, true, QnJnl7fVDKI4mA6voc.r7e8V6mZuC);
				pXnCdP8KeYuFY8wPQAa.D35lls5iF(pvrKKy8Mk1kpdmIfp3A.D35lls5iF((int)(p4mfse87pettnXd8Scc.D35lls5iF(obj3, p4mfse87pettnXd8Scc.AyD8cOWXYr) * 1000f), pvrKKy8Mk1kpdmIfp3A.aVh8SPrFkE), delegate
				{
					bRAh8kDAgKIlehXIXku.D35lls5iF(Jr0pTQlovwB9pdID1EB.D35lls5iF(Jr0pTQlovwB9pdID1EB.CxrllgXtD4), bRAh8kDAgKIlehXIXku.oESD6ce9jH).Invoke((Action)delegate
					{
						try
						{
							fp757nBYjo8889efKFJ.D35lls5iF(RAspAbuaTQFU0nSRiQ.D35lls5iF(CS_0024_003C_003E8__locals4.y4yTr0liv6, RAspAbuaTQFU0nSRiQ.ON08dhk9Rp) as BasePage, fp757nBYjo8889efKFJ.kZZprll0Oa);
						}
						catch
						{
						}
						KBhlAv9D2TgBJ1kkc0B.D35lls5iF(CS_0024_003C_003E8__locals4.y4yTr0liv6, null, KBhlAv9D2TgBJ1kkc0B.BEM8tsTOb9);
					});
				}, pXnCdP8KeYuFY8wPQAa.CGo8N7sWCB);
			}
			KBhlAv9D2TgBJ1kkc0B.D35lls5iF(newPage, IyGDDwHBiPv8vfOFJDF.D35lls5iF(applicationPage, obj, IyGDDwHBiPv8vfOFJDF.hivH0XYhaE), KBhlAv9D2TgBJ1kkc0B.BEM8tsTOb9);
			return P_1;
		}
		catch
		{
			return P_1;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "5.0.4.0")]
	public void InitializeComponent()
	{
		if (!IF6vsFh6xG)
		{
			IF6vsFh6xG = true;
			Uri uri = new Uri(iFZ5je3XFYKwkvcE5D.D35lls5iF(3438, iFZ5je3XFYKwkvcE5D.N06TeK0ao), UriKind.Relative);
			TUdx26d4l5VwJTvopv.D35lls5iF(this, uri, TUdx26d4l5VwJTvopv.W3oUN4AKb);
		}
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "5.0.4.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		case 1:
			OldPage = (ContentControl)target;
			break;
		case 2:
			NewPage = (ContentControl)target;
			break;
		default:
			IF6vsFh6xG = true;
			break;
		}
	}

	static PageHost()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		CurrentAppPageProperty = BrQfd88PXGwGWbvCv5M.D35lls5iF(iFZ5je3XFYKwkvcE5D.D35lls5iF(3536, iFZ5je3XFYKwkvcE5D.N06TeK0ao), sjYxHO8OWlc6X80hFj7.D35lls5iF(typeof(ApplicationPage).TypeHandle, sjYxHO8OWlc6X80hFj7.uWZ8ugU7r5), sjYxHO8OWlc6X80hFj7.D35lls5iF(typeof(PageHost).TypeHandle, sjYxHO8OWlc6X80hFj7.uWZ8ugU7r5), (PropertyMetadata)(object)new UIPropertyMetadata(ApplicationPage.Login, null, new CoerceValueCallback(dduv6o7Gq1)), BrQfd88PXGwGWbvCv5M.ped8sxNsq3);
		CurrentAppPageViewModelProperty = BrQfd88PXGwGWbvCv5M.D35lls5iF(iFZ5je3XFYKwkvcE5D.D35lls5iF(3568, iFZ5je3XFYKwkvcE5D.N06TeK0ao), sjYxHO8OWlc6X80hFj7.D35lls5iF(typeof(BaseViewModel).TypeHandle, sjYxHO8OWlc6X80hFj7.uWZ8ugU7r5), sjYxHO8OWlc6X80hFj7.D35lls5iF(typeof(PageHost).TypeHandle, sjYxHO8OWlc6X80hFj7.uWZ8ugU7r5), (PropertyMetadata)(object)new UIPropertyMetadata(), BrQfd88PXGwGWbvCv5M.ped8sxNsq3);
	}
}
