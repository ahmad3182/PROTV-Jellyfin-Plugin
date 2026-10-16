using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Threading;
using FFmpeg.AutoGen;
using PROTV.Abstractions.DataTransferObjects;
using PROTV.Wpf.Bootstrap;
using PROTV.Wpf.ViewModels;
using Unosquare.FFME;
using Unosquare.FFME.Common;

namespace PROTV.Wpf.Views;

public class YtFFMEPlayer : BasePage<YtVideoPlayerViewModel>, IComponentConnector
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass15_0
	{
		public AVHWDeviceType CseZd0wdpY;

		public _003C_003Ec__DisplayClass15_0()
		{
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
			base._002Ector();
		}

		internal bool S5FZDCwpxH(HardwareDeviceInfo d)
		{
			return aMnygB67j3N3yuQbSMF.D35lls5iF(d, aMnygB67j3N3yuQbSMF.PKP6cQZX8R) == CseZd0wdpY;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnAudioDeviceStopped_003Ed__21 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public object sender;

		private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			try
			{
				ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_0085;
				}
				if (sender is Unosquare.FFME.MediaElement mediaElement)
				{
					awaiter = wd2eJ2Asf3I9epXUKxU.D35lls5iF(mediaElement, wd2eJ2Asf3I9epXUKxU.lWJ6M1uBV4).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_0085;
				}
				goto end_IL_000e;
				IL_0085:
				awaiter.GetResult();
				end_IL_000e:;
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

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnUserControlKeyDown_003Ed__22 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public KeyEventArgs e;

		public YtFFMEPlayer _003C_003E4__this;

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
			YtFFMEPlayer ytFFMEPlayer = _003C_003E4__this;
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
					yfy1wssmHv811G3r43.D35lls5iF((DependencyObject)(object)ytFFMEPlayer, true, yfy1wssmHv811G3r43.fw2hEbsAm);
					lpNmWGxSvw4A2wThUG.D35lls5iF((DependencyObject)(object)ytFFMEPlayer, ytFFMEPlayer, lpNmWGxSvw4A2wThUG.NYpYJBiHr);
					if ((int)X6dagBgIU5bQsE98LL.D35lls5iF(e, X6dagBgIU5bQsE98LL.dcKiqyPBj) == 50)
					{
						lhUOEJ6uOhY2TVo9HQv.D35lls5iF(ytFFMEPlayer.Media, (VkgK106SaE0lyTM0iEu.D35lls5iF(ytFFMEPlayer.Media, VkgK106SaE0lyTM0iEu.oTH6KhvPET) == p5s3FJHfrZC71uwBS7V.D35lls5iF(p5s3FJHfrZC71uwBS7V.j0F6NCjo6k)) ? p5s3FJHfrZC71uwBS7V.D35lls5iF(p5s3FJHfrZC71uwBS7V.KWM6OUxbGV) : p5s3FJHfrZC71uwBS7V.D35lls5iF(p5s3FJHfrZC71uwBS7V.j0F6NCjo6k), lhUOEJ6uOhY2TVo9HQv.SYx6PflhV0);
					}
					else if (Enumerable.Contains(f0yWHO5N2j, X6dagBgIU5bQsE98LL.D35lls5iF(e, X6dagBgIU5bQsE98LL.dcKiqyPBj)) && uEUVCI48fycroqgRFqy.D35lls5iF(ytFFMEPlayer.Media, uEUVCI48fycroqgRFqy.RIVAOZeovq))
					{
						ytFFMEPlayer.ey4WhrYlwV.OnPauseCommandExcuteAsync();
					}
					else if (Enumerable.Contains(f0yWHO5N2j, X6dagBgIU5bQsE98LL.D35lls5iF(e, X6dagBgIU5bQsE98LL.dcKiqyPBj)) && !uEUVCI48fycroqgRFqy.D35lls5iF(ytFFMEPlayer.Media, uEUVCI48fycroqgRFqy.RIVAOZeovq))
					{
						ytFFMEPlayer.ey4WhrYlwV.OnPlayCommandExcuteAsync();
					}
					else
					{
						if ((int)X6dagBgIU5bQsE98LL.D35lls5iF(e, X6dagBgIU5bQsE98LL.dcKiqyPBj) == 23)
						{
							awaiter = wd2eJ2Asf3I9epXUKxU.D35lls5iF(ytFFMEPlayer.Media, wd2eJ2Asf3I9epXUKxU.nHuAhAMFhD).GetAwaiter();
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
							awaiter = wd2eJ2Asf3I9epXUKxU.D35lls5iF(ytFFMEPlayer.Media, wd2eJ2Asf3I9epXUKxU.KSYAxc5OtD).GetAwaiter();
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
							Unosquare.FFME.MediaElement media = ytFFMEPlayer.Media;
							mAdJWQ9yhneCbEXlGMc.D35lls5iF(media, bATk1clKMSyO8g9EVbN.D35lls5iF(media, bATk1clKMSyO8g9EVbN.r4LAXMWUOq) + 0.05, mAdJWQ9yhneCbEXlGMc.QMBAfkYTl6);
						}
						else if ((int)X6dagBgIU5bQsE98LL.D35lls5iF(e, X6dagBgIU5bQsE98LL.dcKiqyPBj) == 26)
						{
							Unosquare.FFME.MediaElement media2 = ytFFMEPlayer.Media;
							mAdJWQ9yhneCbEXlGMc.D35lls5iF(media2, bATk1clKMSyO8g9EVbN.D35lls5iF(media2, bATk1clKMSyO8g9EVbN.r4LAXMWUOq) - 0.05, mAdJWQ9yhneCbEXlGMc.QMBAfkYTl6);
						}
						else if ((int)X6dagBgIU5bQsE98LL.D35lls5iF(e, X6dagBgIU5bQsE98LL.dcKiqyPBj) == 13)
						{
							ytFFMEPlayer.ey4WhrYlwV.Controller.Isfullscreen = false;
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

	private static readonly Key[] f0yWHO5N2j;

	private DateTime rMDWogimqH;

	private Point p1qWgiykrl;

	private DispatcherTimer d1AW1wdhcS;

	private MediaType wbSWJA2xBk;

	private YtVideoPlayerViewModel ey4WhrYlwV;

	internal Grid GridPlayer;

	internal Grid Controls;

	internal ControllerPanelControl ControllerPanel;

	internal YtlistPanelControl ChannellistPanel;

	internal Unosquare.FFME.MediaElement Media;

	private bool ssMWlZooBQ;

	public YtFFMEPlayer()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		wbSWJA2xBk = MediaType.None;
		base._002Ector();
		hao3Y68m7Zvx79IIOKw.D35lls5iF(this, hao3Y68m7Zvx79IIOKw.u3Nnxeiaif);
		hao3Y68m7Zvx79IIOKw.D35lls5iF(this, hao3Y68m7Zvx79IIOKw.EkSnY9chkP);
		hao3Y68m7Zvx79IIOKw.D35lls5iF(this, hao3Y68m7Zvx79IIOKw.bBgngSHvup);
	}

	public YtFFMEPlayer(YtVideoPlayerViewModel viewModel)
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		wbSWJA2xBk = MediaType.None;
		base._002Ector(viewModel);
		hao3Y68m7Zvx79IIOKw.D35lls5iF(this, hao3Y68m7Zvx79IIOKw.u3Nnxeiaif);
		ey4WhrYlwV = RAspAbuaTQFU0nSRiQ.D35lls5iF(this, RAspAbuaTQFU0nSRiQ.G1FymcVoT) as YtVideoPlayerViewModel;
		ey4WhrYlwV.Controller.LikeButtonVisibility = Visibility.Visible;
		if (!viewModel.PlayerPlaylistViewModel.Items.Any())
		{
			YQ4csVD2gHt33yWHvSL.D35lls5iF(ControllerPanel.OpenMenuButton, Visibility.Collapsed, YQ4csVD2gHt33yWHvSL.xX51WbqrR2);
		}
	}

	internal void VHWWylQSue()
	{
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00a5: Expected O, but got Unknown
		XgfudvNjrG5dZKyndN.D35lls5iF(VqWOinl9PO0jF3BJej0.D35lls5iF(Jr0pTQlovwB9pdID1EB.D35lls5iF(Jr0pTQlovwB9pdID1EB.CxrllgXtD4), VqWOinl9PO0jF3BJej0.XwJlDOAaeh), muNWXfpFNu, XgfudvNjrG5dZKyndN.tRNlHCnpGP);
		rMDWogimqH = BvlWxPl1hnvXiXiwcCq.D35lls5iF(BvlWxPl1hnvXiXiwcCq.EYWl8ivUIj);
		Av2eQglnElp5ZoM4x07.D35lls5iF(this, delegate(object P_0, MouseEventArgs P_1)
		{
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0090: Unknown result type (might be due to invalid IL or missing references)
			Point val2 = USqZXQlvmGLrody4O9t.D35lls5iF(P_1, this, USqZXQlvmGLrody4O9t.nH9lA1iUxt);
			if (dcJjqelwgiZ4n97w1vs.D35lls5iF(h9FJZ2l6apsXs25G7nL.D35lls5iF(ref val2, h9FJZ2l6apsXs25G7nL.Hhilp1Ei0F) - h9FJZ2l6apsXs25G7nL.D35lls5iF(ref p1qWgiykrl, h9FJZ2l6apsXs25G7nL.Hhilp1Ei0F), dcJjqelwgiZ4n97w1vs.jM2lCY9POn) > double.Epsilon || dcJjqelwgiZ4n97w1vs.D35lls5iF(h9FJZ2l6apsXs25G7nL.D35lls5iF(ref val2, h9FJZ2l6apsXs25G7nL.Rwnlm4hpqZ) - h9FJZ2l6apsXs25G7nL.D35lls5iF(ref p1qWgiykrl, h9FJZ2l6apsXs25G7nL.Rwnlm4hpqZ), dcJjqelwgiZ4n97w1vs.jM2lCY9POn) > double.Epsilon)
			{
				rMDWogimqH = BvlWxPl1hnvXiXiwcCq.D35lls5iF(BvlWxPl1hnvXiXiwcCq.EYWl8ivUIj);
			}
			p1qWgiykrl = val2;
		}, Av2eQglnElp5ZoM4x07.LUOl3dJrii);
		Av2eQglnElp5ZoM4x07.D35lls5iF(this, delegate
		{
			DateTime dateTime = BvlWxPl1hnvXiXiwcCq.D35lls5iF(BvlWxPl1hnvXiXiwcCq.EYWl8ivUIj);
			rMDWogimqH = NfWVCQlIPmCreciYdpZ.D35lls5iF(ref dateTime, aNJrrPl4soK5NDOndiN.D35lls5iF(10.0, aNJrrPl4soK5NDOndiN.Ca9lahqtKS), NfWVCQlIPmCreciYdpZ.v3GldeXUtY);
		}, Av2eQglnElp5ZoM4x07.LdBlThdhVx);
		DispatcherTimer val = new DispatcherTimer((DispatcherPriority)4);
		AKwYZ1lE8mnNaTGlMo6.D35lls5iF((object)val, aNJrrPl4soK5NDOndiN.D35lls5iF(150.0, aNJrrPl4soK5NDOndiN.V5YlLGDQcw), AKwYZ1lE8mnNaTGlMo6.EaBlBG90pn);
		QnJnl7fVDKI4mA6voc.D35lls5iF((object)val, true, QnJnl7fVDKI4mA6voc.Jd4l02EqPh);
		d1AW1wdhcS = val;
		ytk50glr3dmeojxPvdr.D35lls5iF(d1AW1wdhcS, delegate
		{
			DateTime dateTime = BvlWxPl1hnvXiXiwcCq.D35lls5iF(BvlWxPl1hnvXiXiwcCq.EYWl8ivUIj);
			TimeSpan timeSpan = zDNlydlUqWxR09wbg1x.D35lls5iF(ref dateTime, rMDWogimqH, zDNlydlUqWxR09wbg1x.kq0ltTVoZs);
			if (LUSRjplVkOtM7DbdDL3.D35lls5iF(ref timeSpan, LUSRjplVkOtM7DbdDL3.UWpl72ecwd) >= 3000.0 && hjMnupQVVDlRZAYQJC.D35lls5iF(Media, hjMnupQVVDlRZAYQJC.duTlSYqJTf) && !hjMnupQVVDlRZAYQJC.D35lls5iF(ControllerPanel, hjMnupQVVDlRZAYQJC.e2YlcKn06I) && hjMnupQVVDlRZAYQJC.D35lls5iF(Media, hjMnupQVVDlRZAYQJC.e2YlcKn06I) && !hjMnupQVVDlRZAYQJC.D35lls5iF(ControllerPanel.SoundMenuPopup, hjMnupQVVDlRZAYQJC.l4MlMSZyE9))
			{
				if (!(dcJjqelwgiZ4n97w1vs.D35lls5iF(bATk1clKMSyO8g9EVbN.D35lls5iF(ControllerPanel, bATk1clKMSyO8g9EVbN.PH9lNJgLuW), dcJjqelwgiZ4n97w1vs.jM2lCY9POn) <= double.Epsilon))
				{
					nWRWwrlPjsVJinPCfSv.D35lls5iF(this, OtSKhKlO4MmVwIGXHry.D35lls5iF(OtSKhKlO4MmVwIGXHry.PPAluYG5eE), nWRWwrlPjsVJinPCfSv.XMHlsUiQ5K);
					VxlFRVlhcPfXr3rr0Qe.D35lls5iF(ControllerPanel, 0.3f, VxlFRVlhcPfXr3rr0Qe.D0olxudYdZ);
					VxlFRVlhcPfXr3rr0Qe.D35lls5iF(Controls, 0.1f, VxlFRVlhcPfXr3rr0Qe.D0olxudYdZ);
					if (!hjMnupQVVDlRZAYQJC.D35lls5iF(ChannellistPanel, hjMnupQVVDlRZAYQJC.e2YlcKn06I))
					{
						ey4WhrYlwV.IsPlaylistPanelOpen = false;
					}
				}
			}
			else if (!(dcJjqelwgiZ4n97w1vs.D35lls5iF(bATk1clKMSyO8g9EVbN.D35lls5iF(ControllerPanel, bATk1clKMSyO8g9EVbN.PH9lNJgLuW) - 1.0, dcJjqelwgiZ4n97w1vs.jM2lCY9POn) <= double.Epsilon))
			{
				nWRWwrlPjsVJinPCfSv.D35lls5iF(this, OtSKhKlO4MmVwIGXHry.D35lls5iF(OtSKhKlO4MmVwIGXHry.u1slQYEeU2), nWRWwrlPjsVJinPCfSv.XMHlsUiQ5K);
				VxlFRVlhcPfXr3rr0Qe.D35lls5iF(ControllerPanel, 0.1f, VxlFRVlhcPfXr3rr0Qe.d9UlXfnAaT);
				VxlFRVlhcPfXr3rr0Qe.D35lls5iF(Controls, 0.1f, VxlFRVlhcPfXr3rr0Qe.d9UlXfnAaT);
			}
		}, ytk50glr3dmeojxPvdr.Lgkle9IPtT);
		AJv70itXcdnxnNYjSQ.D35lls5iF(d1AW1wdhcS, AJv70itXcdnxnNYjSQ.JRYlG0QuuU);
		mAdJWQ9yhneCbEXlGMc.D35lls5iF(Media, 16.0, mAdJWQ9yhneCbEXlGMc.Uypn6qoJa8);
	}

	internal void MT1WpB4E1l()
	{
		bHOmLK93DudIdGBrb75.D35lls5iF(OnMediaFFmpegMessageLogged, bHOmLK93DudIdGBrb75.Fod9TIsSiB);
		PaIS6u94vkelmQi5rj0.D35lls5iF(Media, Q9sWR8IRJB, PaIS6u94vkelmQi5rj0.MEx9LXd1lc);
		i3gnNI9Eg29lNWhhmj9.D35lls5iF(Media, W67W3n8b5H, i3gnNI9Eg29lNWhhmj9.x0y9BgXsjM);
		qIyXdQ90W8ud3wp2ybv.D35lls5iF(Media, tEbWmqkdOn, qIyXdQ90W8ud3wp2ybv.G9b9r6c2Bl);
		XeTMat9eHdgUsPwyBUr.D35lls5iF(Media, OnMediaOpened, XeTMat9eHdgUsPwyBUr.xeJ9GY5CYT);
		ytk50glr3dmeojxPvdr.D35lls5iF(Media, OnMediaReady, ytk50glr3dmeojxPvdr.VLo9RbyDNh);
		ytk50glr3dmeojxPvdr.D35lls5iF(Media, OnMediaClosed, ytk50glr3dmeojxPvdr.KQE9kKpkPQ);
		qIyXdQ90W8ud3wp2ybv.D35lls5iF(Media, OnMediaChanging, qIyXdQ90W8ud3wp2ybv.BuQ9vYnSId);
		ytk50glr3dmeojxPvdr.D35lls5iF(Media, OnAudioDeviceStopped, ytk50glr3dmeojxPvdr.hxb9lGDlo9);
		XeTMat9eHdgUsPwyBUr.D35lls5iF(Media, OnMediaChanged, XeTMat9eHdgUsPwyBUr.fVH9ALNi6D);
		C0UEi896TGi2A8w1c4U.D35lls5iF(Media, OnMediaFailed, C0UEi896TGi2A8w1c4U.ta09pyJDvh);
		ytk50glr3dmeojxPvdr.D35lls5iF(Media, cQPWi9eQit, ytk50glr3dmeojxPvdr.Qv416M3eAn);
	}

	private void cQPWi9eQit(object P_0, EventArgs P_1)
	{
		try
		{
			YTVideoResponseDto item = ey4WhrYlwV.PlayerPlaylistViewModel.Items.FirstOrDefault((YTVideoResponseDto yTVideoResponseDto) => m9MGZR7k2RmVqYXYS5.D35lls5iF(yTVideoResponseDto, m9MGZR7k2RmVqYXYS5.r6tnXN0WTV) == m9MGZR7k2RmVqYXYS5.D35lls5iF(ey4WhrYlwV.PlayerPlaylistViewModel.SelectedItem, m9MGZR7k2RmVqYXYS5.r6tnXN0WTV));
			int num = ey4WhrYlwV.PlayerPlaylistViewModel.Items.IndexOf(item);
			num++;
			if (num == ey4WhrYlwV.PlayerPlaylistViewModel.Items.Count)
			{
				xLO56JniGyickVjO1Ot.D35lls5iF(Xlypb0Hnr2C3ydrYEdG.D35lls5iF(AppContainer.Resolve<HomeViewModel>(), Xlypb0Hnr2C3ydrYEdG.U3Z1IKMGuZ), xLO56JniGyickVjO1Ot.qdjnQKYWM8);
			}
			else
			{
				ey4WhrYlwV.PlayerPlaylistViewModel.SelectedItem = ey4WhrYlwV.PlayerPlaylistViewModel.Items.ElementAt(num);
			}
		}
		catch
		{
			xLO56JniGyickVjO1Ot.D35lls5iF(Xlypb0Hnr2C3ydrYEdG.D35lls5iF(AppContainer.Resolve<HomeViewModel>(), Xlypb0Hnr2C3ydrYEdG.U3Z1IKMGuZ), xLO56JniGyickVjO1Ot.qdjnQKYWM8);
		}
	}

	protected void OnMediaMessageLogged(object sender, MediaLogMessageEventArgs e)
	{
		tGMrJE9wjDS38eXmODX.D35lls5iF(e, tGMrJE9wjDS38eXmODX.MmY9CRb1AT);
		_ = 4;
	}

	protected void OnMediaFFmpegMessageLogged(object sender, MediaLogMessageEventArgs e)
	{
	}

	protected void OnMediaFailed(object sender, MediaFailedEventArgs e)
	{
	}

	private void W67W3n8b5H(object P_0, MediaInitializingEventArgs P_1)
	{
		if (RJdEUw97wnVnGsBRmDG.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(P_1, wq2usy8gNndpuTw5mR.Jgy9VSHVYB), iFZ5je3XFYKwkvcE5D.D35lls5iF(3948, iFZ5je3XFYKwkvcE5D.N06TeK0ao), StringComparison.OrdinalIgnoreCase, RJdEUw97wnVnGsBRmDG.y949cPsE49))
		{
			dq1xgG9KNu7RfbYkGMV.D35lls5iF(uIIaqd9MWbmAhTXPYKL.D35lls5iF(P_1, uIIaqd9MWbmAhTXPYKL.a3y9SGZNdS), dq1xgG9KNu7RfbYkGMV.xWD9NR1CqV)[iFZ5je3XFYKwkvcE5D.D35lls5iF(474, iFZ5je3XFYKwkvcE5D.N06TeK0ao)] = iFZ5je3XFYKwkvcE5D.D35lls5iF(3966, iFZ5je3XFYKwkvcE5D.N06TeK0ao);
			QnJnl7fVDKI4mA6voc.D35lls5iF(nXvH3V9ON1PquOtoxuq.D35lls5iF(uIIaqd9MWbmAhTXPYKL.D35lls5iF(P_1, uIIaqd9MWbmAhTXPYKL.a3y9SGZNdS), nXvH3V9ON1PquOtoxuq.g2g9uaXBwW), true, QnJnl7fVDKI4mA6voc.J0Z9Ppmjjt);
			AKwYZ1lE8mnNaTGlMo6.D35lls5iF(nXvH3V9ON1PquOtoxuq.D35lls5iF(uIIaqd9MWbmAhTXPYKL.D35lls5iF(P_1, uIIaqd9MWbmAhTXPYKL.a3y9SGZNdS), nXvH3V9ON1PquOtoxuq.g2g9uaXBwW), aNJrrPl4soK5NDOndiN.D35lls5iF(1.0, aNJrrPl4soK5NDOndiN.Ca9lahqtKS), AKwYZ1lE8mnNaTGlMo6.HSE9xIihv0);
			AKwYZ1lE8mnNaTGlMo6.D35lls5iF(uIIaqd9MWbmAhTXPYKL.D35lls5iF(P_1, uIIaqd9MWbmAhTXPYKL.a3y9SGZNdS), aNJrrPl4soK5NDOndiN.D35lls5iF(10.0, aNJrrPl4soK5NDOndiN.Ca9lahqtKS), AKwYZ1lE8mnNaTGlMo6.zL6nlX0JV7);
		}
		if (RJdEUw97wnVnGsBRmDG.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(P_1, wq2usy8gNndpuTw5mR.Jgy9VSHVYB), iFZ5je3XFYKwkvcE5D.D35lls5iF(3976, iFZ5je3XFYKwkvcE5D.N06TeK0ao), StringComparison.OrdinalIgnoreCase, RJdEUw97wnVnGsBRmDG.y949cPsE49) || RJdEUw97wnVnGsBRmDG.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(P_1, wq2usy8gNndpuTw5mR.Jgy9VSHVYB), iFZ5je3XFYKwkvcE5D.D35lls5iF(3994, iFZ5je3XFYKwkvcE5D.N06TeK0ao), StringComparison.OrdinalIgnoreCase, RJdEUw97wnVnGsBRmDG.y949cPsE49))
		{
			QnJnl7fVDKI4mA6voc.D35lls5iF(nXvH3V9ON1PquOtoxuq.D35lls5iF(uIIaqd9MWbmAhTXPYKL.D35lls5iF(P_1, uIIaqd9MWbmAhTXPYKL.a3y9SGZNdS), nXvH3V9ON1PquOtoxuq.g2g9uaXBwW), true, QnJnl7fVDKI4mA6voc.J0Z9Ppmjjt);
			vQKA0r9sJ1kArsIHc16.D35lls5iF(nXvH3V9ON1PquOtoxuq.D35lls5iF(uIIaqd9MWbmAhTXPYKL.D35lls5iF(P_1, uIIaqd9MWbmAhTXPYKL.a3y9SGZNdS), nXvH3V9ON1PquOtoxuq.g2g9uaXBwW), 524288, vQKA0r9sJ1kArsIHc16.km39hJJ5mo);
			AKwYZ1lE8mnNaTGlMo6.D35lls5iF(nXvH3V9ON1PquOtoxuq.D35lls5iF(uIIaqd9MWbmAhTXPYKL.D35lls5iF(P_1, uIIaqd9MWbmAhTXPYKL.a3y9SGZNdS), nXvH3V9ON1PquOtoxuq.g2g9uaXBwW), aNJrrPl4soK5NDOndiN.D35lls5iF(1.0, aNJrrPl4soK5NDOndiN.Ca9lahqtKS), AKwYZ1lE8mnNaTGlMo6.HSE9xIihv0);
			vQKA0r9sJ1kArsIHc16.D35lls5iF(nXvH3V9ON1PquOtoxuq.D35lls5iF(uIIaqd9MWbmAhTXPYKL.D35lls5iF(P_1, uIIaqd9MWbmAhTXPYKL.a3y9SGZNdS), nXvH3V9ON1PquOtoxuq.g2g9uaXBwW), 32768, vQKA0r9sJ1kArsIHc16.Ebr9YCG3u1);
		}
	}

	private void tEbWmqkdOn(object P_0, MediaOpeningEventArgs P_1)
	{
		AKwYZ1lE8mnNaTGlMo6.D35lls5iF(YQF0kW9goqSdXoWtJAF.D35lls5iF(P_1, YQF0kW9goqSdXoWtJAF.XRw9ikEf4n), TimeSpan.Zero, AKwYZ1lE8mnNaTGlMo6.IOXn9cTIlY);
		QnJnl7fVDKI4mA6voc.D35lls5iF(YQF0kW9goqSdXoWtJAF.D35lls5iF(P_1, YQF0kW9goqSdXoWtJAF.XRw9ikEf4n), S1a0wT9Ixre9OpDny8h.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(Pu8ZkM9Q72E1xo0KU8s.D35lls5iF(P_1, Pu8ZkM9Q72E1xo0KU8s.mf79X0XhAB), wq2usy8gNndpuTw5mR.wly9fwaPxr), iFZ5je3XFYKwkvcE5D.D35lls5iF(516, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO) || VMs7lU9URBMKdJRC1h1.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(Pu8ZkM9Q72E1xo0KU8s.D35lls5iF(P_1, Pu8ZkM9Q72E1xo0KU8s.mf79X0XhAB), wq2usy8gNndpuTw5mR.NVF92wcVcL), iFZ5je3XFYKwkvcE5D.D35lls5iF(546, iFZ5je3XFYKwkvcE5D.N06TeK0ao), VMs7lU9URBMKdJRC1h1.HFs9ZRW5q1), QnJnl7fVDKI4mA6voc.b6Y9jnPMS4);
		mAdJWQ9yhneCbEXlGMc.D35lls5iF(YQF0kW9goqSdXoWtJAF.D35lls5iF(P_1, YQF0kW9goqSdXoWtJAF.XRw9ikEf4n), S1a0wT9Ixre9OpDny8h.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(Pu8ZkM9Q72E1xo0KU8s.D35lls5iF(P_1, Pu8ZkM9Q72E1xo0KU8s.mf79X0XhAB), wq2usy8gNndpuTw5mR.wly9fwaPxr), iFZ5je3XFYKwkvcE5D.D35lls5iF(516, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO) ? 0.0 : 0.5, mAdJWQ9yhneCbEXlGMc.BP19qeiSg6);
		QnJnl7fVDKI4mA6voc.D35lls5iF(q1Gx2v9JbW9cOXEmWet.D35lls5iF(Media, q1Gx2v9JbW9cOXEmWet.adR9bl47sF), hjMnupQVVDlRZAYQJC.D35lls5iF(YQF0kW9goqSdXoWtJAF.D35lls5iF(P_1, YQF0kW9goqSdXoWtJAF.XRw9ikEf4n), hjMnupQVVDlRZAYQJC.xuq9WWJfIB) || RJdEUw97wnVnGsBRmDG.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(Pu8ZkM9Q72E1xo0KU8s.D35lls5iF(P_1, Pu8ZkM9Q72E1xo0KU8s.mf79X0XhAB), wq2usy8gNndpuTw5mR.NVF92wcVcL), iFZ5je3XFYKwkvcE5D.D35lls5iF(570, iFZ5je3XFYKwkvcE5D.N06TeK0ao), StringComparison.OrdinalIgnoreCase, RJdEUw97wnVnGsBRmDG.Omd951BO6P), QnJnl7fVDKI4mA6voc.xcM9zZ9GfC);
		StreamInfo streamInfo = nrSOHAD8YrC91Hd87Ly.D35lls5iF(YQF0kW9goqSdXoWtJAF.D35lls5iF(P_1, YQF0kW9goqSdXoWtJAF.XRw9ikEf4n), nrSOHAD8YrC91Hd87Ly.EaoDno9rGj);
		if (streamInfo == null)
		{
			return;
		}
		AVHWDeviceType[] array = new AVHWDeviceType[3];
		ODLiVRlRE2AwTHTxA2m.D35lls5iF(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, ODLiVRlRE2AwTHTxA2m.rwklk7wPqp);
		AVHWDeviceType[] array2 = array;
		if (bATk1clKMSyO8g9EVbN.D35lls5iF(streamInfo, bATk1clKMSyO8g9EVbN.CcVD3lb0hu) <= 30.0)
		{
			AVHWDeviceType[] array3 = array2;
			for (int i = 0; i < array3.Length; i++)
			{
				_003C_003Ec__DisplayClass15_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass15_0();
				CS_0024_003C_003E8__locals2.CseZd0wdpY = array3[i];
				HardwareDeviceInfo hardwareDeviceInfo = MSyPQaDTrfJtr3GUW48.D35lls5iF(streamInfo, MSyPQaDTrfJtr3GUW48.ESUD4s2tw8).Reverse().FirstOrDefault((HardwareDeviceInfo d) => aMnygB67j3N3yuQbSMF.D35lls5iF(d, aMnygB67j3N3yuQbSMF.PKP6cQZX8R) == CS_0024_003C_003E8__locals2.CseZd0wdpY);
				if (hardwareDeviceInfo != null)
				{
					OZFi5cDLea4g6MgMYOr.D35lls5iF(YQF0kW9goqSdXoWtJAF.D35lls5iF(P_1, YQF0kW9goqSdXoWtJAF.XRw9ikEf4n), hardwareDeviceInfo, OZFi5cDLea4g6MgMYOr.e4mDEqBveZ);
					break;
				}
			}
		}
		StringBuilder stringBuilder = new StringBuilder();
		if (hjMnupQVVDlRZAYQJC.D35lls5iF(streamInfo, hjMnupQVVDlRZAYQJC.a2an8cXkZR))
		{
			Iqu9Z2D0u6duXqVdeBe.D35lls5iF(stringBuilder, iFZ5je3XFYKwkvcE5D.D35lls5iF(4024, iFZ5je3XFYKwkvcE5D.N06TeK0ao), Iqu9Z2D0u6duXqVdeBe.No5DrBqXtD);
		}
		if (m9MGZR7k2RmVqYXYS5.D35lls5iF(streamInfo, m9MGZR7k2RmVqYXYS5.l8vDBfi6TL) > 1080)
		{
			Iqu9Z2D0u6duXqVdeBe.D35lls5iF(stringBuilder, iFZ5je3XFYKwkvcE5D.D35lls5iF(582, iFZ5je3XFYKwkvcE5D.N06TeK0ao), Iqu9Z2D0u6duXqVdeBe.No5DrBqXtD);
		}
		qni3xrDkAJ3vF35eMav.D35lls5iF(YQF0kW9goqSdXoWtJAF.D35lls5iF(P_1, YQF0kW9goqSdXoWtJAF.XRw9ikEf4n), slLC9nDGSMhIcv2FTUB.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(stringBuilder, wq2usy8gNndpuTw5mR.ajcDe8nffb), ',', slLC9nDGSMhIcv2FTUB.yv2DRs3jeV), qni3xrDkAJ3vF35eMav.dmJDvBNs4m);
	}

	protected void OnMediaOpened(object sender, MediaOpenedEventArgs e)
	{
	}

	protected void OnMediaReady(object sender, EventArgs e)
	{
	}

	protected void OnMediaClosed(object sender, EventArgs e)
	{
	}

	protected void OnMediaChanging(object sender, MediaOpeningEventArgs e)
	{
		List<StreamInfo> list = (from x in YrCoj4DChUfyKXuSvMK.D35lls5iF(Pu8ZkM9Q72E1xo0KU8s.D35lls5iF(e, Pu8ZkM9Q72E1xo0KU8s.mf79X0XhAB), YrCoj4DChUfyKXuSvMK.osNDmFEjj6)
			where Up3ObFDSJspBLFTGC8N.D35lls5iF(x.Value, Up3ObFDSJspBLFTGC8N.z70DKvMmSu) == (AVMediaType)wbSWJA2xBk
			select x.Value).ToList();
		if (list.Count > 0)
		{
			if (wbSWJA2xBk != MediaType.Video)
			{
				list.Add(null);
			}
			int num;
			switch (wbSWJA2xBk)
			{
			default:
				return;
			case MediaType.Audio:
				num = list.IndexOf(nrSOHAD8YrC91Hd87Ly.D35lls5iF(YQF0kW9goqSdXoWtJAF.D35lls5iF(e, YQF0kW9goqSdXoWtJAF.XRw9ikEf4n), nrSOHAD8YrC91Hd87Ly.kQEDayfkOb));
				break;
			case MediaType.Video:
				num = list.IndexOf(nrSOHAD8YrC91Hd87Ly.D35lls5iF(YQF0kW9goqSdXoWtJAF.D35lls5iF(e, YQF0kW9goqSdXoWtJAF.XRw9ikEf4n), nrSOHAD8YrC91Hd87Ly.EaoDno9rGj));
				break;
			case MediaType.Subtitle:
				num = list.IndexOf(nrSOHAD8YrC91Hd87Ly.D35lls5iF(YQF0kW9goqSdXoWtJAF.D35lls5iF(e, YQF0kW9goqSdXoWtJAF.XRw9ikEf4n), nrSOHAD8YrC91Hd87Ly.h1MDIuPtG3));
				break;
			case (MediaType)2:
				return;
			}
			num++;
			if (num >= list.Count)
			{
				num = 0;
			}
			StreamInfo streamInfo = list[num];
			switch (wbSWJA2xBk)
			{
			case MediaType.Audio:
				zWVKfNDdAAWj4PIoemO.D35lls5iF(YQF0kW9goqSdXoWtJAF.D35lls5iF(e, YQF0kW9goqSdXoWtJAF.XRw9ikEf4n), streamInfo, zWVKfNDdAAWj4PIoemO.iUiDUFofUR);
				break;
			case MediaType.Video:
				zWVKfNDdAAWj4PIoemO.D35lls5iF(YQF0kW9goqSdXoWtJAF.D35lls5iF(e, YQF0kW9goqSdXoWtJAF.XRw9ikEf4n), streamInfo, zWVKfNDdAAWj4PIoemO.O8xDt8r9Nr);
				break;
			case MediaType.Subtitle:
				zWVKfNDdAAWj4PIoemO.D35lls5iF(YQF0kW9goqSdXoWtJAF.D35lls5iF(e, YQF0kW9goqSdXoWtJAF.XRw9ikEf4n), streamInfo, zWVKfNDdAAWj4PIoemO.gDnDVRIkpN);
				break;
			case (MediaType)2:
				break;
			}
		}
	}

	protected void OnMediaChanged(object sender, MediaOpenedEventArgs e)
	{
	}

	[AsyncStateMachine(typeof(_003COnAudioDeviceStopped_003Ed__21))]
	protected void OnAudioDeviceStopped(object sender, EventArgs e)
	{
		_003COnAudioDeviceStopped_003Ed__21 stateMachine = default(_003COnAudioDeviceStopped_003Ed__21);
		stateMachine._003C_003Et__builder = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
		stateMachine.sender = sender;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003COnUserControlKeyDown_003Ed__22))]
	private void muNWXfpFNu(object P_0, KeyEventArgs P_1)
	{
		_003COnUserControlKeyDown_003Ed__22 stateMachine = default(_003COnUserControlKeyDown_003Ed__22);
		stateMachine._003C_003Et__builder = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
		stateMachine._003C_003E4__this = this;
		stateMachine.e = P_1;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void Q9sWR8IRJB(object P_0, MouseButtonEventArgs P_1)
	{
		if (P_0 != null && GmMLaTD7kV8rq88ZFvR.D35lls5iF(P_0, Media, GmMLaTD7kV8rq88ZFvR.BQ5Dcmx5Pp))
		{
			QnJnl7fVDKI4mA6voc.D35lls5iF(P_1, true, QnJnl7fVDKI4mA6voc.WSpDMQcj8Y);
			ey4WhrYlwV.Controller.Isfullscreen = !ey4WhrYlwV.Controller.Isfullscreen;
		}
	}

	protected void OnMediaPositionChanged(object sender, PositionChangedEventArgs e)
	{
	}

	protected void OnMediaStateChanged(object sender, MediaStateChangedEventArgs e)
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "5.0.4.0")]
	public void InitializeComponent()
	{
		if (!ssMWlZooBQ)
		{
			ssMWlZooBQ = true;
			Uri uri = new Uri(iFZ5je3XFYKwkvcE5D.D35lls5iF(5210, iFZ5je3XFYKwkvcE5D.N06TeK0ao), UriKind.Relative);
			TUdx26d4l5VwJTvopv.D35lls5iF(this, uri, TUdx26d4l5VwJTvopv.W3oUN4AKb);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "5.0.4.0")]
	[DebuggerNonUserCode]
	internal Delegate JTDWw6SysA(Type P_0, string P_1)
	{
		return E6A9Xm2C8YsY6OX49j.D35lls5iF(P_0, this, P_1, E6A9Xm2C8YsY6OX49j.lecZDyFnW);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "5.0.4.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
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
			ChannellistPanel = (YtlistPanelControl)target;
			break;
		case 5:
			Media = (Unosquare.FFME.MediaElement)target;
			break;
		default:
			ssMWlZooBQ = true;
			break;
		}
	}

	static YtFFMEPlayer()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		Key[] array = new Key[3];
		ODLiVRlRE2AwTHTxA2m.D35lls5iF(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, ODLiVRlRE2AwTHTxA2m.rwklk7wPqp);
		f0yWHO5N2j = (Key[])(object)array;
	}

	[CompilerGenerated]
	private void bjpWEmfxck(object P_0, MouseEventArgs P_1)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		Point val = USqZXQlvmGLrody4O9t.D35lls5iF(P_1, this, USqZXQlvmGLrody4O9t.nH9lA1iUxt);
		if (dcJjqelwgiZ4n97w1vs.D35lls5iF(h9FJZ2l6apsXs25G7nL.D35lls5iF(ref val, h9FJZ2l6apsXs25G7nL.Hhilp1Ei0F) - h9FJZ2l6apsXs25G7nL.D35lls5iF(ref p1qWgiykrl, h9FJZ2l6apsXs25G7nL.Hhilp1Ei0F), dcJjqelwgiZ4n97w1vs.jM2lCY9POn) > double.Epsilon || dcJjqelwgiZ4n97w1vs.D35lls5iF(h9FJZ2l6apsXs25G7nL.D35lls5iF(ref val, h9FJZ2l6apsXs25G7nL.Rwnlm4hpqZ) - h9FJZ2l6apsXs25G7nL.D35lls5iF(ref p1qWgiykrl, h9FJZ2l6apsXs25G7nL.Rwnlm4hpqZ), dcJjqelwgiZ4n97w1vs.jM2lCY9POn) > double.Epsilon)
		{
			rMDWogimqH = BvlWxPl1hnvXiXiwcCq.D35lls5iF(BvlWxPl1hnvXiXiwcCq.EYWl8ivUIj);
		}
		p1qWgiykrl = val;
	}

	[CompilerGenerated]
	private void cglW9BXDaN(object P_0, MouseEventArgs P_1)
	{
		DateTime dateTime = BvlWxPl1hnvXiXiwcCq.D35lls5iF(BvlWxPl1hnvXiXiwcCq.EYWl8ivUIj);
		rMDWogimqH = NfWVCQlIPmCreciYdpZ.D35lls5iF(ref dateTime, aNJrrPl4soK5NDOndiN.D35lls5iF(10.0, aNJrrPl4soK5NDOndiN.Ca9lahqtKS), NfWVCQlIPmCreciYdpZ.v3GldeXUtY);
	}

	[CompilerGenerated]
	private void MAGWeluSZY(object P_0, EventArgs P_1)
	{
		DateTime dateTime = BvlWxPl1hnvXiXiwcCq.D35lls5iF(BvlWxPl1hnvXiXiwcCq.EYWl8ivUIj);
		TimeSpan timeSpan = zDNlydlUqWxR09wbg1x.D35lls5iF(ref dateTime, rMDWogimqH, zDNlydlUqWxR09wbg1x.kq0ltTVoZs);
		if (LUSRjplVkOtM7DbdDL3.D35lls5iF(ref timeSpan, LUSRjplVkOtM7DbdDL3.UWpl72ecwd) >= 3000.0 && hjMnupQVVDlRZAYQJC.D35lls5iF(Media, hjMnupQVVDlRZAYQJC.duTlSYqJTf) && !hjMnupQVVDlRZAYQJC.D35lls5iF(ControllerPanel, hjMnupQVVDlRZAYQJC.e2YlcKn06I) && hjMnupQVVDlRZAYQJC.D35lls5iF(Media, hjMnupQVVDlRZAYQJC.e2YlcKn06I) && !hjMnupQVVDlRZAYQJC.D35lls5iF(ControllerPanel.SoundMenuPopup, hjMnupQVVDlRZAYQJC.l4MlMSZyE9))
		{
			if (!(dcJjqelwgiZ4n97w1vs.D35lls5iF(bATk1clKMSyO8g9EVbN.D35lls5iF(ControllerPanel, bATk1clKMSyO8g9EVbN.PH9lNJgLuW), dcJjqelwgiZ4n97w1vs.jM2lCY9POn) <= double.Epsilon))
			{
				nWRWwrlPjsVJinPCfSv.D35lls5iF(this, OtSKhKlO4MmVwIGXHry.D35lls5iF(OtSKhKlO4MmVwIGXHry.PPAluYG5eE), nWRWwrlPjsVJinPCfSv.XMHlsUiQ5K);
				VxlFRVlhcPfXr3rr0Qe.D35lls5iF(ControllerPanel, 0.3f, VxlFRVlhcPfXr3rr0Qe.D0olxudYdZ);
				VxlFRVlhcPfXr3rr0Qe.D35lls5iF(Controls, 0.1f, VxlFRVlhcPfXr3rr0Qe.D0olxudYdZ);
				if (!hjMnupQVVDlRZAYQJC.D35lls5iF(ChannellistPanel, hjMnupQVVDlRZAYQJC.e2YlcKn06I))
				{
					ey4WhrYlwV.IsPlaylistPanelOpen = false;
				}
			}
		}
		else if (!(dcJjqelwgiZ4n97w1vs.D35lls5iF(bATk1clKMSyO8g9EVbN.D35lls5iF(ControllerPanel, bATk1clKMSyO8g9EVbN.PH9lNJgLuW) - 1.0, dcJjqelwgiZ4n97w1vs.jM2lCY9POn) <= double.Epsilon))
		{
			nWRWwrlPjsVJinPCfSv.D35lls5iF(this, OtSKhKlO4MmVwIGXHry.D35lls5iF(OtSKhKlO4MmVwIGXHry.u1slQYEeU2), nWRWwrlPjsVJinPCfSv.XMHlsUiQ5K);
			VxlFRVlhcPfXr3rr0Qe.D35lls5iF(ControllerPanel, 0.1f, VxlFRVlhcPfXr3rr0Qe.d9UlXfnAaT);
			VxlFRVlhcPfXr3rr0Qe.D35lls5iF(Controls, 0.1f, VxlFRVlhcPfXr3rr0Qe.d9UlXfnAaT);
		}
	}

	[CompilerGenerated]
	private bool PDLWO2C1CM(YTVideoResponseDto P_0)
	{
		return m9MGZR7k2RmVqYXYS5.D35lls5iF(P_0, m9MGZR7k2RmVqYXYS5.r6tnXN0WTV) == m9MGZR7k2RmVqYXYS5.D35lls5iF(ey4WhrYlwV.PlayerPlaylistViewModel.SelectedItem, m9MGZR7k2RmVqYXYS5.r6tnXN0WTV);
	}

	[CompilerGenerated]
	private bool ivDWrourXM(KeyValuePair<int, StreamInfo> P_0)
	{
		return Up3ObFDSJspBLFTGC8N.D35lls5iF(P_0.Value, Up3ObFDSJspBLFTGC8N.z70DKvMmSu) == (AVMediaType)wbSWJA2xBk;
	}
}
