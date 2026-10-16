using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Threading;
using PROTV.Abstractions.DataTransferObjects;
using PROTV.Wpf.Helpers;
using PROTV.Wpf.ViewModels;
using Unosquare.FFME;

namespace PROTV.Wpf.Views;

public class MovieFFMEPlayer : BasePage<MoviePlayerViewModel>, IComponentConnector
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnUserControlKeyDown_003Ed__11 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public KeyEventArgs e;

		public MovieFFMEPlayer _003C_003E4__this;

		private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_006b: Invalid comparison between Unknown and I4
			//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0111: Unknown result type (might be due to invalid IL or missing references)
			//IL_0150: Unknown result type (might be due to invalid IL or missing references)
			//IL_0157: Invalid comparison between Unknown and I4
			//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01df: Invalid comparison between Unknown and I4
			//IL_0260: Unknown result type (might be due to invalid IL or missing references)
			//IL_0267: Invalid comparison between Unknown and I4
			//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a8: Invalid comparison between Unknown and I4
			//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e9: Invalid comparison between Unknown and I4
			int num = _003C_003E1__state;
			MovieFFMEPlayer movieFFMEPlayer = _003C_003E4__this;
			try
			{
				ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_01c0;
				}
				if (num == 1)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_0248;
				}
				if (!(RAspAbuaTQFU0nSRiQ.D35lls5iF(e, RAspAbuaTQFU0nSRiQ.YRbPgco79) is TextBox))
				{
					yfy1wssmHv811G3r43.D35lls5iF((DependencyObject)(object)movieFFMEPlayer, true, yfy1wssmHv811G3r43.fw2hEbsAm);
					lpNmWGxSvw4A2wThUG.D35lls5iF((DependencyObject)(object)movieFFMEPlayer, movieFFMEPlayer, lpNmWGxSvw4A2wThUG.NYpYJBiHr);
					if ((int)X6dagBgIU5bQsE98LL.D35lls5iF(e, X6dagBgIU5bQsE98LL.dcKiqyPBj) == 50)
					{
						lhUOEJ6uOhY2TVo9HQv.D35lls5iF(movieFFMEPlayer.Media, (VkgK106SaE0lyTM0iEu.D35lls5iF(movieFFMEPlayer.Media, VkgK106SaE0lyTM0iEu.oTH6KhvPET) == p5s3FJHfrZC71uwBS7V.D35lls5iF(p5s3FJHfrZC71uwBS7V.j0F6NCjo6k)) ? p5s3FJHfrZC71uwBS7V.D35lls5iF(p5s3FJHfrZC71uwBS7V.KWM6OUxbGV) : p5s3FJHfrZC71uwBS7V.D35lls5iF(p5s3FJHfrZC71uwBS7V.j0F6NCjo6k), lhUOEJ6uOhY2TVo9HQv.SYx6PflhV0);
					}
					else if (Enumerable.Contains(sDjjhvcBjU, X6dagBgIU5bQsE98LL.D35lls5iF(e, X6dagBgIU5bQsE98LL.dcKiqyPBj)) && uEUVCI48fycroqgRFqy.D35lls5iF(movieFFMEPlayer.Media, uEUVCI48fycroqgRFqy.RIVAOZeovq))
					{
						movieFFMEPlayer.NdBj2PBqeO.OnPauseCommandExcuteAsync();
					}
					else if (Enumerable.Contains(sDjjhvcBjU, X6dagBgIU5bQsE98LL.D35lls5iF(e, X6dagBgIU5bQsE98LL.dcKiqyPBj)) && !uEUVCI48fycroqgRFqy.D35lls5iF(movieFFMEPlayer.Media, uEUVCI48fycroqgRFqy.RIVAOZeovq))
					{
						movieFFMEPlayer.NdBj2PBqeO.OnPlayCommandExcuteAsync();
					}
					else
					{
						if ((int)X6dagBgIU5bQsE98LL.D35lls5iF(e, X6dagBgIU5bQsE98LL.dcKiqyPBj) == 23)
						{
							awaiter = wd2eJ2Asf3I9epXUKxU.D35lls5iF(movieFFMEPlayer.Media, wd2eJ2Asf3I9epXUKxU.nHuAhAMFhD).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_01c0;
						}
						if ((int)X6dagBgIU5bQsE98LL.D35lls5iF(e, X6dagBgIU5bQsE98LL.dcKiqyPBj) == 25)
						{
							awaiter = wd2eJ2Asf3I9epXUKxU.D35lls5iF(movieFFMEPlayer.Media, wd2eJ2Asf3I9epXUKxU.KSYAxc5OtD).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = (_003C_003E1__state = 1);
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_0248;
						}
						if ((int)X6dagBgIU5bQsE98LL.D35lls5iF(e, X6dagBgIU5bQsE98LL.dcKiqyPBj) == 24)
						{
							Unosquare.FFME.MediaElement media = movieFFMEPlayer.Media;
							mAdJWQ9yhneCbEXlGMc.D35lls5iF(media, bATk1clKMSyO8g9EVbN.D35lls5iF(media, bATk1clKMSyO8g9EVbN.r4LAXMWUOq) + 0.05, mAdJWQ9yhneCbEXlGMc.QMBAfkYTl6);
						}
						else if ((int)X6dagBgIU5bQsE98LL.D35lls5iF(e, X6dagBgIU5bQsE98LL.dcKiqyPBj) == 26)
						{
							Unosquare.FFME.MediaElement media2 = movieFFMEPlayer.Media;
							mAdJWQ9yhneCbEXlGMc.D35lls5iF(media2, bATk1clKMSyO8g9EVbN.D35lls5iF(media2, bATk1clKMSyO8g9EVbN.r4LAXMWUOq) - 0.05, mAdJWQ9yhneCbEXlGMc.QMBAfkYTl6);
						}
						else if ((int)X6dagBgIU5bQsE98LL.D35lls5iF(e, X6dagBgIU5bQsE98LL.dcKiqyPBj) == 13)
						{
							movieFFMEPlayer.NdBj2PBqeO.Controller.Isfullscreen = false;
						}
					}
				}
				goto end_IL_0015;
				IL_01c0:
				awaiter.GetResult();
				goto end_IL_0015;
				IL_0248:
				awaiter.GetResult();
				end_IL_0015:;
			}
			catch (Exception ex)
			{
				_003C_003E1__state = -2;
				N2XUglA3neBsnlZfRPQ.D35lls5iF(ref _003C_003Et__builder, ex, N2XUglA3neBsnlZfRPQ.l4pATRumoW);
				return;
			}
			_003C_003E1__state = -2;
			T4XmPoA4VNJJP1afcgL.D35lls5iF(ref _003C_003Et__builder, T4XmPoA4VNJJP1afcgL.TRyALZckCh);
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			dHWo7jAEn6E4X7bsY4R.D35lls5iF(ref _003C_003Et__builder, stateMachine, dHWo7jAEn6E4X7bsY4R.z3hAB6UZ9o);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	private static readonly Key[] sDjjhvcBjU;

	private DateTime QxLjl93Aj9;

	private Point uMnjUtyH2L;

	private DispatcherTimer M9SjL3qmq1;

	private MoviePlayerViewModel NdBj2PBqeO;

	[CompilerGenerated]
	private readonly MediaElementEvents<MovieResponseDto> AwVjzkqZin;

	internal Grid GridPlayer;

	internal Grid Controls;

	internal ControllerPanelControl ControllerPanel;

	internal PropertiesPanelControl PropertiesPanel;

	internal Unosquare.FFME.MediaElement Media;

	private bool RfgvcQF0tY;

	public MediaElementEvents<MovieResponseDto> MediaElementEventsInit
	{
		[CompilerGenerated]
		get
		{
			return AwVjzkqZin;
		}
	}

	public MovieFFMEPlayer()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector();
		tApScD14t76npcHoQ1x.D35lls5iF(this, tApScD14t76npcHoQ1x.D2P1bk4UNX);
	}

	public MovieFFMEPlayer(MoviePlayerViewModel viewModel)
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector(viewModel);
		tApScD14t76npcHoQ1x.D35lls5iF(this, tApScD14t76npcHoQ1x.D2P1bk4UNX);
		NdBj2PBqeO = RAspAbuaTQFU0nSRiQ.D35lls5iF(this, RAspAbuaTQFU0nSRiQ.G1FymcVoT) as MoviePlayerViewModel;
		AwVjzkqZin = new MediaElementEvents<MovieResponseDto>(NdBj2PBqeO);
		YQ4csVD2gHt33yWHvSL.D35lls5iF(ControllerPanel.OpenMenuButton, Visibility.Collapsed, YQ4csVD2gHt33yWHvSL.xX51WbqrR2);
	}

	internal void u7rjrvTWJB()
	{
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00a5: Expected O, but got Unknown
		XgfudvNjrG5dZKyndN.D35lls5iF(VqWOinl9PO0jF3BJej0.D35lls5iF(Jr0pTQlovwB9pdID1EB.D35lls5iF(Jr0pTQlovwB9pdID1EB.CxrllgXtD4), VqWOinl9PO0jF3BJej0.XwJlDOAaeh), iumjHWCH5e, XgfudvNjrG5dZKyndN.tRNlHCnpGP);
		QxLjl93Aj9 = BvlWxPl1hnvXiXiwcCq.D35lls5iF(BvlWxPl1hnvXiXiwcCq.EYWl8ivUIj);
		Av2eQglnElp5ZoM4x07.D35lls5iF(this, delegate(object P_0, MouseEventArgs P_1)
		{
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0090: Unknown result type (might be due to invalid IL or missing references)
			Point val2 = USqZXQlvmGLrody4O9t.D35lls5iF(P_1, this, USqZXQlvmGLrody4O9t.nH9lA1iUxt);
			if (dcJjqelwgiZ4n97w1vs.D35lls5iF(h9FJZ2l6apsXs25G7nL.D35lls5iF(ref val2, h9FJZ2l6apsXs25G7nL.Hhilp1Ei0F) - h9FJZ2l6apsXs25G7nL.D35lls5iF(ref uMnjUtyH2L, h9FJZ2l6apsXs25G7nL.Hhilp1Ei0F), dcJjqelwgiZ4n97w1vs.jM2lCY9POn) > double.Epsilon || dcJjqelwgiZ4n97w1vs.D35lls5iF(h9FJZ2l6apsXs25G7nL.D35lls5iF(ref val2, h9FJZ2l6apsXs25G7nL.Rwnlm4hpqZ) - h9FJZ2l6apsXs25G7nL.D35lls5iF(ref uMnjUtyH2L, h9FJZ2l6apsXs25G7nL.Rwnlm4hpqZ), dcJjqelwgiZ4n97w1vs.jM2lCY9POn) > double.Epsilon)
			{
				QxLjl93Aj9 = BvlWxPl1hnvXiXiwcCq.D35lls5iF(BvlWxPl1hnvXiXiwcCq.EYWl8ivUIj);
			}
			uMnjUtyH2L = val2;
		}, Av2eQglnElp5ZoM4x07.LUOl3dJrii);
		Av2eQglnElp5ZoM4x07.D35lls5iF(this, delegate
		{
			DateTime dateTime = BvlWxPl1hnvXiXiwcCq.D35lls5iF(BvlWxPl1hnvXiXiwcCq.EYWl8ivUIj);
			QxLjl93Aj9 = NfWVCQlIPmCreciYdpZ.D35lls5iF(ref dateTime, aNJrrPl4soK5NDOndiN.D35lls5iF(10.0, aNJrrPl4soK5NDOndiN.Ca9lahqtKS), NfWVCQlIPmCreciYdpZ.v3GldeXUtY);
		}, Av2eQglnElp5ZoM4x07.LdBlThdhVx);
		DispatcherTimer val = new DispatcherTimer((DispatcherPriority)4);
		AKwYZ1lE8mnNaTGlMo6.D35lls5iF((object)val, aNJrrPl4soK5NDOndiN.D35lls5iF(150.0, aNJrrPl4soK5NDOndiN.V5YlLGDQcw), AKwYZ1lE8mnNaTGlMo6.EaBlBG90pn);
		QnJnl7fVDKI4mA6voc.D35lls5iF((object)val, true, QnJnl7fVDKI4mA6voc.Jd4l02EqPh);
		M9SjL3qmq1 = val;
		ytk50glr3dmeojxPvdr.D35lls5iF(M9SjL3qmq1, delegate
		{
			DateTime dateTime = BvlWxPl1hnvXiXiwcCq.D35lls5iF(BvlWxPl1hnvXiXiwcCq.EYWl8ivUIj);
			TimeSpan timeSpan = zDNlydlUqWxR09wbg1x.D35lls5iF(ref dateTime, QxLjl93Aj9, zDNlydlUqWxR09wbg1x.kq0ltTVoZs);
			if (LUSRjplVkOtM7DbdDL3.D35lls5iF(ref timeSpan, LUSRjplVkOtM7DbdDL3.UWpl72ecwd) >= 3000.0 && hjMnupQVVDlRZAYQJC.D35lls5iF(Media, hjMnupQVVDlRZAYQJC.duTlSYqJTf) && !hjMnupQVVDlRZAYQJC.D35lls5iF(ControllerPanel, hjMnupQVVDlRZAYQJC.e2YlcKn06I) && hjMnupQVVDlRZAYQJC.D35lls5iF(Media, hjMnupQVVDlRZAYQJC.e2YlcKn06I) && !hjMnupQVVDlRZAYQJC.D35lls5iF(ControllerPanel.SoundMenuPopup, hjMnupQVVDlRZAYQJC.l4MlMSZyE9))
			{
				if (!(dcJjqelwgiZ4n97w1vs.D35lls5iF(bATk1clKMSyO8g9EVbN.D35lls5iF(ControllerPanel, bATk1clKMSyO8g9EVbN.PH9lNJgLuW), dcJjqelwgiZ4n97w1vs.jM2lCY9POn) <= double.Epsilon))
				{
					nWRWwrlPjsVJinPCfSv.D35lls5iF(this, OtSKhKlO4MmVwIGXHry.D35lls5iF(OtSKhKlO4MmVwIGXHry.PPAluYG5eE), nWRWwrlPjsVJinPCfSv.XMHlsUiQ5K);
					VxlFRVlhcPfXr3rr0Qe.D35lls5iF(ControllerPanel, 0.3f, VxlFRVlhcPfXr3rr0Qe.D0olxudYdZ);
					VxlFRVlhcPfXr3rr0Qe.D35lls5iF(Controls, 0.3f, VxlFRVlhcPfXr3rr0Qe.D0olxudYdZ);
				}
			}
			else if (!(dcJjqelwgiZ4n97w1vs.D35lls5iF(bATk1clKMSyO8g9EVbN.D35lls5iF(ControllerPanel, bATk1clKMSyO8g9EVbN.PH9lNJgLuW) - 1.0, dcJjqelwgiZ4n97w1vs.jM2lCY9POn) <= double.Epsilon))
			{
				nWRWwrlPjsVJinPCfSv.D35lls5iF(this, OtSKhKlO4MmVwIGXHry.D35lls5iF(OtSKhKlO4MmVwIGXHry.u1slQYEeU2), nWRWwrlPjsVJinPCfSv.XMHlsUiQ5K);
				VxlFRVlhcPfXr3rr0Qe.D35lls5iF(ControllerPanel, 0.1f, VxlFRVlhcPfXr3rr0Qe.d9UlXfnAaT);
				VxlFRVlhcPfXr3rr0Qe.D35lls5iF(Controls, 0.1f, VxlFRVlhcPfXr3rr0Qe.d9UlXfnAaT);
			}
		}, ytk50glr3dmeojxPvdr.Lgkle9IPtT);
		AJv70itXcdnxnNYjSQ.D35lls5iF(M9SjL3qmq1, AJv70itXcdnxnNYjSQ.JRYlG0QuuU);
	}

	[AsyncStateMachine(typeof(_003COnUserControlKeyDown_003Ed__11))]
	private void iumjHWCH5e(object P_0, KeyEventArgs P_1)
	{
		_003COnUserControlKeyDown_003Ed__11 stateMachine = default(_003COnUserControlKeyDown_003Ed__11);
		stateMachine._003C_003Et__builder = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
		stateMachine._003C_003E4__this = this;
		stateMachine.e = P_1;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "5.0.4.0")]
	public void InitializeComponent()
	{
		if (!RfgvcQF0tY)
		{
			RfgvcQF0tY = true;
			Uri uri = new Uri(iFZ5je3XFYKwkvcE5D.D35lls5iF(2248, iFZ5je3XFYKwkvcE5D.N06TeK0ao), UriKind.Relative);
			TUdx26d4l5VwJTvopv.D35lls5iF(this, uri, TUdx26d4l5VwJTvopv.W3oUN4AKb);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "5.0.4.0")]
	internal Delegate oeujoj1QBB(Type P_0, string P_1)
	{
		return E6A9Xm2C8YsY6OX49j.D35lls5iF(P_0, this, P_1, E6A9Xm2C8YsY6OX49j.lecZDyFnW);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "5.0.4.0")]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		case 1:
			GridPlayer = (Grid)target;
			break;
		case 2:
			Controls = (Grid)target;
			break;
		case 3:
			ControllerPanel = (ControllerPanelControl)target;
			break;
		case 4:
			PropertiesPanel = (PropertiesPanelControl)target;
			break;
		case 5:
			Media = (Unosquare.FFME.MediaElement)target;
			break;
		default:
			RfgvcQF0tY = true;
			break;
		}
	}

	static MovieFFMEPlayer()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		Key[] array = new Key[3];
		ODLiVRlRE2AwTHTxA2m.D35lls5iF(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, ODLiVRlRE2AwTHTxA2m.rwklk7wPqp);
		sDjjhvcBjU = (Key[])(object)array;
	}

	[CompilerGenerated]
	private void PAijgv4TiL(object P_0, MouseEventArgs P_1)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		Point val = USqZXQlvmGLrody4O9t.D35lls5iF(P_1, this, USqZXQlvmGLrody4O9t.nH9lA1iUxt);
		if (dcJjqelwgiZ4n97w1vs.D35lls5iF(h9FJZ2l6apsXs25G7nL.D35lls5iF(ref val, h9FJZ2l6apsXs25G7nL.Hhilp1Ei0F) - h9FJZ2l6apsXs25G7nL.D35lls5iF(ref uMnjUtyH2L, h9FJZ2l6apsXs25G7nL.Hhilp1Ei0F), dcJjqelwgiZ4n97w1vs.jM2lCY9POn) > double.Epsilon || dcJjqelwgiZ4n97w1vs.D35lls5iF(h9FJZ2l6apsXs25G7nL.D35lls5iF(ref val, h9FJZ2l6apsXs25G7nL.Rwnlm4hpqZ) - h9FJZ2l6apsXs25G7nL.D35lls5iF(ref uMnjUtyH2L, h9FJZ2l6apsXs25G7nL.Rwnlm4hpqZ), dcJjqelwgiZ4n97w1vs.jM2lCY9POn) > double.Epsilon)
		{
			QxLjl93Aj9 = BvlWxPl1hnvXiXiwcCq.D35lls5iF(BvlWxPl1hnvXiXiwcCq.EYWl8ivUIj);
		}
		uMnjUtyH2L = val;
	}

	[CompilerGenerated]
	private void dSVj1aEsW5(object P_0, MouseEventArgs P_1)
	{
		DateTime dateTime = BvlWxPl1hnvXiXiwcCq.D35lls5iF(BvlWxPl1hnvXiXiwcCq.EYWl8ivUIj);
		QxLjl93Aj9 = NfWVCQlIPmCreciYdpZ.D35lls5iF(ref dateTime, aNJrrPl4soK5NDOndiN.D35lls5iF(10.0, aNJrrPl4soK5NDOndiN.Ca9lahqtKS), NfWVCQlIPmCreciYdpZ.v3GldeXUtY);
	}

	[CompilerGenerated]
	private void PRdjJ8dqof(object P_0, EventArgs P_1)
	{
		DateTime dateTime = BvlWxPl1hnvXiXiwcCq.D35lls5iF(BvlWxPl1hnvXiXiwcCq.EYWl8ivUIj);
		TimeSpan timeSpan = zDNlydlUqWxR09wbg1x.D35lls5iF(ref dateTime, QxLjl93Aj9, zDNlydlUqWxR09wbg1x.kq0ltTVoZs);
		if (LUSRjplVkOtM7DbdDL3.D35lls5iF(ref timeSpan, LUSRjplVkOtM7DbdDL3.UWpl72ecwd) >= 3000.0 && hjMnupQVVDlRZAYQJC.D35lls5iF(Media, hjMnupQVVDlRZAYQJC.duTlSYqJTf) && !hjMnupQVVDlRZAYQJC.D35lls5iF(ControllerPanel, hjMnupQVVDlRZAYQJC.e2YlcKn06I) && hjMnupQVVDlRZAYQJC.D35lls5iF(Media, hjMnupQVVDlRZAYQJC.e2YlcKn06I) && !hjMnupQVVDlRZAYQJC.D35lls5iF(ControllerPanel.SoundMenuPopup, hjMnupQVVDlRZAYQJC.l4MlMSZyE9))
		{
			if (!(dcJjqelwgiZ4n97w1vs.D35lls5iF(bATk1clKMSyO8g9EVbN.D35lls5iF(ControllerPanel, bATk1clKMSyO8g9EVbN.PH9lNJgLuW), dcJjqelwgiZ4n97w1vs.jM2lCY9POn) <= double.Epsilon))
			{
				nWRWwrlPjsVJinPCfSv.D35lls5iF(this, OtSKhKlO4MmVwIGXHry.D35lls5iF(OtSKhKlO4MmVwIGXHry.PPAluYG5eE), nWRWwrlPjsVJinPCfSv.XMHlsUiQ5K);
				VxlFRVlhcPfXr3rr0Qe.D35lls5iF(ControllerPanel, 0.3f, VxlFRVlhcPfXr3rr0Qe.D0olxudYdZ);
				VxlFRVlhcPfXr3rr0Qe.D35lls5iF(Controls, 0.3f, VxlFRVlhcPfXr3rr0Qe.D0olxudYdZ);
			}
		}
		else if (!(dcJjqelwgiZ4n97w1vs.D35lls5iF(bATk1clKMSyO8g9EVbN.D35lls5iF(ControllerPanel, bATk1clKMSyO8g9EVbN.PH9lNJgLuW) - 1.0, dcJjqelwgiZ4n97w1vs.jM2lCY9POn) <= double.Epsilon))
		{
			nWRWwrlPjsVJinPCfSv.D35lls5iF(this, OtSKhKlO4MmVwIGXHry.D35lls5iF(OtSKhKlO4MmVwIGXHry.u1slQYEeU2), nWRWwrlPjsVJinPCfSv.XMHlsUiQ5K);
			VxlFRVlhcPfXr3rr0Qe.D35lls5iF(ControllerPanel, 0.1f, VxlFRVlhcPfXr3rr0Qe.d9UlXfnAaT);
			VxlFRVlhcPfXr3rr0Qe.D35lls5iF(Controls, 0.1f, VxlFRVlhcPfXr3rr0Qe.d9UlXfnAaT);
		}
	}
}
