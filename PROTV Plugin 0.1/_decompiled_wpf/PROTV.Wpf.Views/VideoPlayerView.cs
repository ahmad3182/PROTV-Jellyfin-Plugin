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
using HandyControl.Data;
using PROTV.Wpf.ViewModels;
using Unosquare.FFME;

namespace PROTV.Wpf.Views;

public class VideoPlayerView : BasePage<VideoPlayerViewModel>, IComponentConnector
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnUserControlKeyDown_003Ed__11 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public KeyEventArgs e;

		public VideoPlayerView _003C_003E4__this;

		private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fd: Invalid comparison between Unknown and I4
			//IL_017e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0185: Invalid comparison between Unknown and I4
			//IL_0206: Unknown result type (might be due to invalid IL or missing references)
			//IL_020d: Invalid comparison between Unknown and I4
			//IL_021d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0227: Invalid comparison between Unknown and I4
			//IL_028d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0294: Invalid comparison between Unknown and I4
			//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ae: Invalid comparison between Unknown and I4
			//IL_0314: Unknown result type (might be due to invalid IL or missing references)
			//IL_031b: Invalid comparison between Unknown and I4
			//IL_032b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0335: Invalid comparison between Unknown and I4
			//IL_036d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0374: Invalid comparison between Unknown and I4
			//IL_03ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b5: Invalid comparison between Unknown and I4
			//IL_03ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f6: Invalid comparison between Unknown and I4
			int num = _003C_003E1__state;
			VideoPlayerView videoPlayerView = _003C_003E4__this;
			try
			{
				ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_0166;
				}
				if (num == 1)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_01ee;
				}
				if (!(RAspAbuaTQFU0nSRiQ.D35lls5iF(e, RAspAbuaTQFU0nSRiQ.YRbPgco79) is TextBox))
				{
					yfy1wssmHv811G3r43.D35lls5iF((DependencyObject)(object)videoPlayerView, true, yfy1wssmHv811G3r43.fw2hEbsAm);
					lpNmWGxSvw4A2wThUG.D35lls5iF((DependencyObject)(object)videoPlayerView, videoPlayerView, lpNmWGxSvw4A2wThUG.NYpYJBiHr);
					if (Enumerable.Contains(G0OSygrPj, X6dagBgIU5bQsE98LL.D35lls5iF(e, X6dagBgIU5bQsE98LL.dcKiqyPBj)) && uEUVCI48fycroqgRFqy.D35lls5iF(videoPlayerView.FFMEVideoView, uEUVCI48fycroqgRFqy.RIVAOZeovq))
					{
						fp757nBYjo8889efKFJ.D35lls5iF(videoPlayerView.XHPfWCPtw, fp757nBYjo8889efKFJ.dpEAu2E4pt);
					}
					else if (Enumerable.Contains(G0OSygrPj, X6dagBgIU5bQsE98LL.D35lls5iF(e, X6dagBgIU5bQsE98LL.dcKiqyPBj)) && !uEUVCI48fycroqgRFqy.D35lls5iF(videoPlayerView.FFMEVideoView, uEUVCI48fycroqgRFqy.RIVAOZeovq))
					{
						fp757nBYjo8889efKFJ.D35lls5iF(videoPlayerView.XHPfWCPtw, fp757nBYjo8889efKFJ.KStAPSXm1u);
					}
					else
					{
						if ((int)X6dagBgIU5bQsE98LL.D35lls5iF(e, X6dagBgIU5bQsE98LL.dcKiqyPBj) == 23)
						{
							awaiter = wd2eJ2Asf3I9epXUKxU.D35lls5iF(videoPlayerView.FFMEVideoView, wd2eJ2Asf3I9epXUKxU.nHuAhAMFhD).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_0166;
						}
						if ((int)X6dagBgIU5bQsE98LL.D35lls5iF(e, X6dagBgIU5bQsE98LL.dcKiqyPBj) == 25)
						{
							awaiter = wd2eJ2Asf3I9epXUKxU.D35lls5iF(videoPlayerView.FFMEVideoView, wd2eJ2Asf3I9epXUKxU.KSYAxc5OtD).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = (_003C_003E1__state = 1);
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_01ee;
						}
						if ((int)X6dagBgIU5bQsE98LL.D35lls5iF(e, X6dagBgIU5bQsE98LL.dcKiqyPBj) == 85 || (int)X6dagBgIU5bQsE98LL.D35lls5iF(e, X6dagBgIU5bQsE98LL.dcKiqyPBj) == 131)
						{
							Unosquare.FFME.MediaElement fFMEVideoView = videoPlayerView.FFMEVideoView;
							mAdJWQ9yhneCbEXlGMc.D35lls5iF(fFMEVideoView, bATk1clKMSyO8g9EVbN.D35lls5iF(fFMEVideoView, bATk1clKMSyO8g9EVbN.SnnAY7C5iH) + ((bATk1clKMSyO8g9EVbN.D35lls5iF(videoPlayerView.FFMEVideoView, bATk1clKMSyO8g9EVbN.SnnAY7C5iH) >= 1.0) ? 0.0 : 0.05), mAdJWQ9yhneCbEXlGMc.uL1Ag9irU8);
						}
						else if ((int)X6dagBgIU5bQsE98LL.D35lls5iF(e, X6dagBgIU5bQsE98LL.dcKiqyPBj) == 87 || (int)X6dagBgIU5bQsE98LL.D35lls5iF(e, X6dagBgIU5bQsE98LL.dcKiqyPBj) == 130)
						{
							Unosquare.FFME.MediaElement fFMEVideoView2 = videoPlayerView.FFMEVideoView;
							mAdJWQ9yhneCbEXlGMc.D35lls5iF(fFMEVideoView2, bATk1clKMSyO8g9EVbN.D35lls5iF(fFMEVideoView2, bATk1clKMSyO8g9EVbN.SnnAY7C5iH) - ((bATk1clKMSyO8g9EVbN.D35lls5iF(videoPlayerView.FFMEVideoView, bATk1clKMSyO8g9EVbN.SnnAY7C5iH) <= 0.0) ? 0.0 : 0.05), mAdJWQ9yhneCbEXlGMc.uL1Ag9irU8);
						}
						else if ((int)X6dagBgIU5bQsE98LL.D35lls5iF(e, X6dagBgIU5bQsE98LL.dcKiqyPBj) == 56 || (int)X6dagBgIU5bQsE98LL.D35lls5iF(e, X6dagBgIU5bQsE98LL.dcKiqyPBj) == 129)
						{
							jPB9Q5LdIM9wsuWV1q7.D35lls5iF(videoPlayerView.FFMEVideoView, !uEUVCI48fycroqgRFqy.D35lls5iF(videoPlayerView.FFMEVideoView, uEUVCI48fycroqgRFqy.qYqAiq0qeH), jPB9Q5LdIM9wsuWV1q7.RM3AQWojml);
						}
						else if ((int)X6dagBgIU5bQsE98LL.D35lls5iF(e, X6dagBgIU5bQsE98LL.dcKiqyPBj) == 24)
						{
							Unosquare.FFME.MediaElement fFMEVideoView3 = videoPlayerView.FFMEVideoView;
							mAdJWQ9yhneCbEXlGMc.D35lls5iF(fFMEVideoView3, bATk1clKMSyO8g9EVbN.D35lls5iF(fFMEVideoView3, bATk1clKMSyO8g9EVbN.r4LAXMWUOq) + 0.05, mAdJWQ9yhneCbEXlGMc.QMBAfkYTl6);
						}
						else if ((int)X6dagBgIU5bQsE98LL.D35lls5iF(e, X6dagBgIU5bQsE98LL.dcKiqyPBj) == 26)
						{
							Unosquare.FFME.MediaElement fFMEVideoView4 = videoPlayerView.FFMEVideoView;
							mAdJWQ9yhneCbEXlGMc.D35lls5iF(fFMEVideoView4, bATk1clKMSyO8g9EVbN.D35lls5iF(fFMEVideoView4, bATk1clKMSyO8g9EVbN.r4LAXMWUOq) - 0.05, mAdJWQ9yhneCbEXlGMc.QMBAfkYTl6);
						}
						else if ((int)X6dagBgIU5bQsE98LL.D35lls5iF(e, X6dagBgIU5bQsE98LL.dcKiqyPBj) == 13)
						{
							QnJnl7fVDKI4mA6voc.D35lls5iF(cdbdBC3E9OhMyh2CjfD.D35lls5iF(videoPlayerView.XHPfWCPtw, cdbdBC3E9OhMyh2CjfD.dh33BjQ0nJ), false, QnJnl7fVDKI4mA6voc.jhh3rDePKn);
						}
					}
				}
				goto end_IL_0015;
				IL_01ee:
				awaiter.GetResult();
				goto end_IL_0015;
				IL_0166:
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

	[CompilerGenerated]
	private readonly MediaElementEvents shttID5L1;

	private static readonly Key[] G0OSygrPj;

	private VideoPlayerViewModel XHPfWCPtw;

	private DateTime pDdKKbV7F;

	private Point YIhk8C2D2;

	private DispatcherTimer e6T8p07y6;

	internal Grid GridPlayer;

	internal LiveViewSettings SettingsPanel;

	internal ChannellistPanelControl ChannellistPanel;

	internal PropertiesPanelControl PropertiesPanel;

	internal ControllerPanelControl ControllerPanel;

	internal Unosquare.FFME.MediaElement FFMEVideoView;

	private bool gybQXpYS9;

	public MediaElementEvents MediaElementEventsInit
	{
		[CompilerGenerated]
		get
		{
			return shttID5L1;
		}
	}

	public VideoPlayerView()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector();
		AJv70itXcdnxnNYjSQ.D35lls5iF(this, AJv70itXcdnxnNYjSQ.Wfejfu5ji);
	}

	public VideoPlayerView(VideoPlayerViewModel specificViewModel)
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector(specificViewModel);
		AJv70itXcdnxnNYjSQ.D35lls5iF(this, AJv70itXcdnxnNYjSQ.Wfejfu5ji);
		XHPfWCPtw = RAspAbuaTQFU0nSRiQ.D35lls5iF(this, RAspAbuaTQFU0nSRiQ.G1FymcVoT) as VideoPlayerViewModel;
		kbGuAqq0wIxs9tTnF0.D35lls5iF(XHPfWCPtw, FFMEVideoView, kbGuAqq0wIxs9tTnF0.fSLJ2EGhO);
		AJv70itXcdnxnNYjSQ.D35lls5iF(this, AJv70itXcdnxnNYjSQ.ENab9rJm4);
		shttID5L1 = new MediaElementEvents(XHPfWCPtw);
		kbGuAqq0wIxs9tTnF0.D35lls5iF(u3rKUFWXnFniIaN34B.D35lls5iF(this, u3rKUFWXnFniIaN34B.cMC56uEpp), FFMEVideoView, kbGuAqq0wIxs9tTnF0.awez3yikQ);
	}

	internal void mLdIbvGVs()
	{
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00a5: Expected O, but got Unknown
		XgfudvNjrG5dZKyndN.D35lls5iF(VqWOinl9PO0jF3BJej0.D35lls5iF(Jr0pTQlovwB9pdID1EB.D35lls5iF(Jr0pTQlovwB9pdID1EB.CxrllgXtD4), VqWOinl9PO0jF3BJej0.XwJlDOAaeh), TPKVQSVWg, XgfudvNjrG5dZKyndN.tRNlHCnpGP);
		pDdKKbV7F = BvlWxPl1hnvXiXiwcCq.D35lls5iF(BvlWxPl1hnvXiXiwcCq.EYWl8ivUIj);
		Av2eQglnElp5ZoM4x07.D35lls5iF(this, delegate(object P_0, MouseEventArgs P_1)
		{
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0090: Unknown result type (might be due to invalid IL or missing references)
			Point yIhk8C2D = USqZXQlvmGLrody4O9t.D35lls5iF(P_1, this, USqZXQlvmGLrody4O9t.nH9lA1iUxt);
			if (dcJjqelwgiZ4n97w1vs.D35lls5iF(h9FJZ2l6apsXs25G7nL.D35lls5iF(ref yIhk8C2D, h9FJZ2l6apsXs25G7nL.Hhilp1Ei0F) - h9FJZ2l6apsXs25G7nL.D35lls5iF(ref YIhk8C2D2, h9FJZ2l6apsXs25G7nL.Hhilp1Ei0F), dcJjqelwgiZ4n97w1vs.jM2lCY9POn) > double.Epsilon || dcJjqelwgiZ4n97w1vs.D35lls5iF(h9FJZ2l6apsXs25G7nL.D35lls5iF(ref yIhk8C2D, h9FJZ2l6apsXs25G7nL.Rwnlm4hpqZ) - h9FJZ2l6apsXs25G7nL.D35lls5iF(ref YIhk8C2D2, h9FJZ2l6apsXs25G7nL.Rwnlm4hpqZ), dcJjqelwgiZ4n97w1vs.jM2lCY9POn) > double.Epsilon)
			{
				pDdKKbV7F = BvlWxPl1hnvXiXiwcCq.D35lls5iF(BvlWxPl1hnvXiXiwcCq.EYWl8ivUIj);
			}
			YIhk8C2D2 = yIhk8C2D;
		}, Av2eQglnElp5ZoM4x07.LUOl3dJrii);
		Av2eQglnElp5ZoM4x07.D35lls5iF(this, delegate
		{
			DateTime dateTime = BvlWxPl1hnvXiXiwcCq.D35lls5iF(BvlWxPl1hnvXiXiwcCq.EYWl8ivUIj);
			pDdKKbV7F = NfWVCQlIPmCreciYdpZ.D35lls5iF(ref dateTime, aNJrrPl4soK5NDOndiN.D35lls5iF(10.0, aNJrrPl4soK5NDOndiN.Ca9lahqtKS), NfWVCQlIPmCreciYdpZ.v3GldeXUtY);
		}, Av2eQglnElp5ZoM4x07.LdBlThdhVx);
		DispatcherTimer val = new DispatcherTimer((DispatcherPriority)4);
		AKwYZ1lE8mnNaTGlMo6.D35lls5iF((object)val, aNJrrPl4soK5NDOndiN.D35lls5iF(150.0, aNJrrPl4soK5NDOndiN.V5YlLGDQcw), AKwYZ1lE8mnNaTGlMo6.EaBlBG90pn);
		QnJnl7fVDKI4mA6voc.D35lls5iF((object)val, true, QnJnl7fVDKI4mA6voc.Jd4l02EqPh);
		e6T8p07y6 = val;
		ytk50glr3dmeojxPvdr.D35lls5iF(e6T8p07y6, delegate
		{
			DateTime dateTime = BvlWxPl1hnvXiXiwcCq.D35lls5iF(BvlWxPl1hnvXiXiwcCq.EYWl8ivUIj);
			TimeSpan timeSpan = zDNlydlUqWxR09wbg1x.D35lls5iF(ref dateTime, pDdKKbV7F, zDNlydlUqWxR09wbg1x.kq0ltTVoZs);
			if (LUSRjplVkOtM7DbdDL3.D35lls5iF(ref timeSpan, LUSRjplVkOtM7DbdDL3.UWpl72ecwd) >= 3000.0 && !hjMnupQVVDlRZAYQJC.D35lls5iF(ControllerPanel, hjMnupQVVDlRZAYQJC.e2YlcKn06I) && !hjMnupQVVDlRZAYQJC.D35lls5iF(PropertiesPanel, hjMnupQVVDlRZAYQJC.e2YlcKn06I) && !hjMnupQVVDlRZAYQJC.D35lls5iF(ControllerPanel.SoundMenuPopup, hjMnupQVVDlRZAYQJC.l4MlMSZyE9) && FFMEVideoView != null && hjMnupQVVDlRZAYQJC.D35lls5iF(FFMEVideoView, hjMnupQVVDlRZAYQJC.duTlSYqJTf) && hjMnupQVVDlRZAYQJC.D35lls5iF(FFMEVideoView, hjMnupQVVDlRZAYQJC.e2YlcKn06I))
			{
				if (!(dcJjqelwgiZ4n97w1vs.D35lls5iF(bATk1clKMSyO8g9EVbN.D35lls5iF(ControllerPanel, bATk1clKMSyO8g9EVbN.PH9lNJgLuW), dcJjqelwgiZ4n97w1vs.jM2lCY9POn) <= double.Epsilon))
				{
					nWRWwrlPjsVJinPCfSv.D35lls5iF(this, OtSKhKlO4MmVwIGXHry.D35lls5iF(OtSKhKlO4MmVwIGXHry.PPAluYG5eE), nWRWwrlPjsVJinPCfSv.XMHlsUiQ5K);
					VxlFRVlhcPfXr3rr0Qe.D35lls5iF(ControllerPanel, 0.3f, VxlFRVlhcPfXr3rr0Qe.D0olxudYdZ);
					if (!hjMnupQVVDlRZAYQJC.D35lls5iF(ChannellistPanel, hjMnupQVVDlRZAYQJC.e2YlcKn06I))
					{
						QnJnl7fVDKI4mA6voc.D35lls5iF(XHPfWCPtw, false, QnJnl7fVDKI4mA6voc.pkHlYE79sm);
					}
					if (!hjMnupQVVDlRZAYQJC.D35lls5iF(PropertiesPanel, hjMnupQVVDlRZAYQJC.e2YlcKn06I))
					{
						QnJnl7fVDKI4mA6voc.D35lls5iF(XHPfWCPtw, false, QnJnl7fVDKI4mA6voc.jBPlg8OVUR);
					}
					if (!hjMnupQVVDlRZAYQJC.D35lls5iF(SettingsPanel, hjMnupQVVDlRZAYQJC.e2YlcKn06I))
					{
						QnJnl7fVDKI4mA6voc.D35lls5iF(XHPfWCPtw, false, QnJnl7fVDKI4mA6voc.TYVliOClqC);
					}
				}
			}
			else if (!(dcJjqelwgiZ4n97w1vs.D35lls5iF(bATk1clKMSyO8g9EVbN.D35lls5iF(ControllerPanel, bATk1clKMSyO8g9EVbN.PH9lNJgLuW) - 1.0, dcJjqelwgiZ4n97w1vs.jM2lCY9POn) <= double.Epsilon))
			{
				nWRWwrlPjsVJinPCfSv.D35lls5iF(this, OtSKhKlO4MmVwIGXHry.D35lls5iF(OtSKhKlO4MmVwIGXHry.u1slQYEeU2), nWRWwrlPjsVJinPCfSv.XMHlsUiQ5K);
				VxlFRVlhcPfXr3rr0Qe.D35lls5iF(ControllerPanel, 0.1f, VxlFRVlhcPfXr3rr0Qe.d9UlXfnAaT);
			}
		}, ytk50glr3dmeojxPvdr.Lgkle9IPtT);
		AJv70itXcdnxnNYjSQ.D35lls5iF(e6T8p07y6, AJv70itXcdnxnNYjSQ.JRYlG0QuuU);
	}

	[AsyncStateMachine(typeof(_003COnUserControlKeyDown_003Ed__11))]
	private void TPKVQSVWg(object P_0, KeyEventArgs P_1)
	{
		_003COnUserControlKeyDown_003Ed__11 stateMachine = default(_003COnUserControlKeyDown_003Ed__11);
		stateMachine._003C_003Et__builder = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
		stateMachine._003C_003E4__this = this;
		stateMachine.e = P_1;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void ukiayfAFn(object P_0, FunctionEventArgs<DateTime> P_1)
	{
	}

	[GeneratedCode("PresentationBuildTasks", "5.0.4.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!gybQXpYS9)
		{
			gybQXpYS9 = true;
			Uri uri = new Uri(iFZ5je3XFYKwkvcE5D.D35lls5iF(198, iFZ5je3XFYKwkvcE5D.N06TeK0ao), UriKind.Relative);
			TUdx26d4l5VwJTvopv.D35lls5iF(this, uri, TUdx26d4l5VwJTvopv.W3oUN4AKb);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "5.0.4.0")]
	[DebuggerNonUserCode]
	internal Delegate X6703Ysep(Type P_0, string P_1)
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
			GridPlayer = (Grid)target;
			break;
		case 2:
			SettingsPanel = (LiveViewSettings)target;
			break;
		case 3:
			ChannellistPanel = (ChannellistPanelControl)target;
			break;
		case 4:
			PropertiesPanel = (PropertiesPanelControl)target;
			break;
		case 5:
			ControllerPanel = (ControllerPanelControl)target;
			break;
		case 6:
			FFMEVideoView = (Unosquare.FFME.MediaElement)target;
			break;
		default:
			gybQXpYS9 = true;
			break;
		}
	}

	static VideoPlayerView()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		Key[] array = new Key[3];
		ODLiVRlRE2AwTHTxA2m.D35lls5iF(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, ODLiVRlRE2AwTHTxA2m.rwklk7wPqp);
		G0OSygrPj = (Key[])(object)array;
	}

	[CompilerGenerated]
	private void cctGkgqxq(object P_0, MouseEventArgs P_1)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		Point yIhk8C2D = USqZXQlvmGLrody4O9t.D35lls5iF(P_1, this, USqZXQlvmGLrody4O9t.nH9lA1iUxt);
		if (dcJjqelwgiZ4n97w1vs.D35lls5iF(h9FJZ2l6apsXs25G7nL.D35lls5iF(ref yIhk8C2D, h9FJZ2l6apsXs25G7nL.Hhilp1Ei0F) - h9FJZ2l6apsXs25G7nL.D35lls5iF(ref YIhk8C2D2, h9FJZ2l6apsXs25G7nL.Hhilp1Ei0F), dcJjqelwgiZ4n97w1vs.jM2lCY9POn) > double.Epsilon || dcJjqelwgiZ4n97w1vs.D35lls5iF(h9FJZ2l6apsXs25G7nL.D35lls5iF(ref yIhk8C2D, h9FJZ2l6apsXs25G7nL.Rwnlm4hpqZ) - h9FJZ2l6apsXs25G7nL.D35lls5iF(ref YIhk8C2D2, h9FJZ2l6apsXs25G7nL.Rwnlm4hpqZ), dcJjqelwgiZ4n97w1vs.jM2lCY9POn) > double.Epsilon)
		{
			pDdKKbV7F = BvlWxPl1hnvXiXiwcCq.D35lls5iF(BvlWxPl1hnvXiXiwcCq.EYWl8ivUIj);
		}
		YIhk8C2D2 = yIhk8C2D;
	}

	[CompilerGenerated]
	private void IaMThCkXt(object P_0, MouseEventArgs P_1)
	{
		DateTime dateTime = BvlWxPl1hnvXiXiwcCq.D35lls5iF(BvlWxPl1hnvXiXiwcCq.EYWl8ivUIj);
		pDdKKbV7F = NfWVCQlIPmCreciYdpZ.D35lls5iF(ref dateTime, aNJrrPl4soK5NDOndiN.D35lls5iF(10.0, aNJrrPl4soK5NDOndiN.Ca9lahqtKS), NfWVCQlIPmCreciYdpZ.v3GldeXUtY);
	}

	[CompilerGenerated]
	private void RDwZ5VQT0(object P_0, EventArgs P_1)
	{
		DateTime dateTime = BvlWxPl1hnvXiXiwcCq.D35lls5iF(BvlWxPl1hnvXiXiwcCq.EYWl8ivUIj);
		TimeSpan timeSpan = zDNlydlUqWxR09wbg1x.D35lls5iF(ref dateTime, pDdKKbV7F, zDNlydlUqWxR09wbg1x.kq0ltTVoZs);
		if (LUSRjplVkOtM7DbdDL3.D35lls5iF(ref timeSpan, LUSRjplVkOtM7DbdDL3.UWpl72ecwd) >= 3000.0 && !hjMnupQVVDlRZAYQJC.D35lls5iF(ControllerPanel, hjMnupQVVDlRZAYQJC.e2YlcKn06I) && !hjMnupQVVDlRZAYQJC.D35lls5iF(PropertiesPanel, hjMnupQVVDlRZAYQJC.e2YlcKn06I) && !hjMnupQVVDlRZAYQJC.D35lls5iF(ControllerPanel.SoundMenuPopup, hjMnupQVVDlRZAYQJC.l4MlMSZyE9) && FFMEVideoView != null && hjMnupQVVDlRZAYQJC.D35lls5iF(FFMEVideoView, hjMnupQVVDlRZAYQJC.duTlSYqJTf) && hjMnupQVVDlRZAYQJC.D35lls5iF(FFMEVideoView, hjMnupQVVDlRZAYQJC.e2YlcKn06I))
		{
			if (!(dcJjqelwgiZ4n97w1vs.D35lls5iF(bATk1clKMSyO8g9EVbN.D35lls5iF(ControllerPanel, bATk1clKMSyO8g9EVbN.PH9lNJgLuW), dcJjqelwgiZ4n97w1vs.jM2lCY9POn) <= double.Epsilon))
			{
				nWRWwrlPjsVJinPCfSv.D35lls5iF(this, OtSKhKlO4MmVwIGXHry.D35lls5iF(OtSKhKlO4MmVwIGXHry.PPAluYG5eE), nWRWwrlPjsVJinPCfSv.XMHlsUiQ5K);
				VxlFRVlhcPfXr3rr0Qe.D35lls5iF(ControllerPanel, 0.3f, VxlFRVlhcPfXr3rr0Qe.D0olxudYdZ);
				if (!hjMnupQVVDlRZAYQJC.D35lls5iF(ChannellistPanel, hjMnupQVVDlRZAYQJC.e2YlcKn06I))
				{
					QnJnl7fVDKI4mA6voc.D35lls5iF(XHPfWCPtw, false, QnJnl7fVDKI4mA6voc.pkHlYE79sm);
				}
				if (!hjMnupQVVDlRZAYQJC.D35lls5iF(PropertiesPanel, hjMnupQVVDlRZAYQJC.e2YlcKn06I))
				{
					QnJnl7fVDKI4mA6voc.D35lls5iF(XHPfWCPtw, false, QnJnl7fVDKI4mA6voc.jBPlg8OVUR);
				}
				if (!hjMnupQVVDlRZAYQJC.D35lls5iF(SettingsPanel, hjMnupQVVDlRZAYQJC.e2YlcKn06I))
				{
					QnJnl7fVDKI4mA6voc.D35lls5iF(XHPfWCPtw, false, QnJnl7fVDKI4mA6voc.TYVliOClqC);
				}
			}
		}
		else if (!(dcJjqelwgiZ4n97w1vs.D35lls5iF(bATk1clKMSyO8g9EVbN.D35lls5iF(ControllerPanel, bATk1clKMSyO8g9EVbN.PH9lNJgLuW) - 1.0, dcJjqelwgiZ4n97w1vs.jM2lCY9POn) <= double.Epsilon))
		{
			nWRWwrlPjsVJinPCfSv.D35lls5iF(this, OtSKhKlO4MmVwIGXHry.D35lls5iF(OtSKhKlO4MmVwIGXHry.u1slQYEeU2), nWRWwrlPjsVJinPCfSv.XMHlsUiQ5K);
			VxlFRVlhcPfXr3rr0Qe.D35lls5iF(ControllerPanel, 0.1f, VxlFRVlhcPfXr3rr0Qe.d9UlXfnAaT);
		}
	}
}
