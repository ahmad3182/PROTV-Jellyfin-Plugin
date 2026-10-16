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
using HandyControl.Controls;
using PROTV.Wpf.ViewModels;
using Unosquare.FFME;
using Unosquare.FFME.ClosedCaptions;
using Unosquare.FFME.Common;

namespace PROTV.Wpf.Views;

public class RadioFFMEPlayer : UserControl, IComponentConnector
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass10_0
	{
		public Unosquare.FFME.MediaElement fe4Tz1qVT2;

		public StreamInfo YA3ZcgZJpp;

		public _003C_003Ec__DisplayClass10_0()
		{
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
			base._002Ector();
		}

		internal void uuOT2LZ6ut()
		{
			K8DNce6twv9Np34xpPr.D35lls5iF(fe4Tz1qVT2, uEUVCI48fycroqgRFqy.D35lls5iF(YA3ZcgZJpp, uEUVCI48fycroqgRFqy.hx66UqOmg8) ? CaptionsChannel.CC1 : CaptionsChannel.CCP, K8DNce6twv9Np34xpPr.qtR6VreiE6);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass10_1
	{
		public AVHWDeviceType E6tZvtvaIo;

		public _003C_003Ec__DisplayClass10_1()
		{
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
			base._002Ector();
		}

		internal bool LGGZjE60Kt(HardwareDeviceInfo d)
		{
			return aMnygB67j3N3yuQbSMF.D35lls5iF(d, aMnygB67j3N3yuQbSMF.PKP6cQZX8R) == E6tZvtvaIo;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnAudioDeviceStopped_003Ed__16 : IAsyncStateMachine
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
	private struct _003COnUserControlKeyDown_003Ed__17 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public KeyEventArgs e;

		public RadioFFMEPlayer _003C_003E4__this;

		private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_006b: Invalid comparison between Unknown and I4
			//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cf: Invalid comparison between Unknown and I4
			//IL_0150: Unknown result type (might be due to invalid IL or missing references)
			//IL_0157: Invalid comparison between Unknown and I4
			//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01df: Invalid comparison between Unknown and I4
			//IL_0219: Unknown result type (might be due to invalid IL or missing references)
			//IL_0220: Invalid comparison between Unknown and I4
			//IL_025a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0261: Invalid comparison between Unknown and I4
			int num = _003C_003E1__state;
			RadioFFMEPlayer radioFFMEPlayer = _003C_003E4__this;
			try
			{
				ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_0138;
				}
				if (num == 1)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_01c0;
				}
				if (!(RAspAbuaTQFU0nSRiQ.D35lls5iF(e, RAspAbuaTQFU0nSRiQ.YRbPgco79) is System.Windows.Controls.TextBox))
				{
					yfy1wssmHv811G3r43.D35lls5iF((DependencyObject)(object)radioFFMEPlayer, true, yfy1wssmHv811G3r43.fw2hEbsAm);
					lpNmWGxSvw4A2wThUG.D35lls5iF((DependencyObject)(object)radioFFMEPlayer, radioFFMEPlayer, lpNmWGxSvw4A2wThUG.NYpYJBiHr);
					if ((int)X6dagBgIU5bQsE98LL.D35lls5iF(e, X6dagBgIU5bQsE98LL.dcKiqyPBj) == 50)
					{
						lhUOEJ6uOhY2TVo9HQv.D35lls5iF(radioFFMEPlayer.Media, (VkgK106SaE0lyTM0iEu.D35lls5iF(radioFFMEPlayer.Media, VkgK106SaE0lyTM0iEu.oTH6KhvPET) == p5s3FJHfrZC71uwBS7V.D35lls5iF(p5s3FJHfrZC71uwBS7V.j0F6NCjo6k)) ? p5s3FJHfrZC71uwBS7V.D35lls5iF(p5s3FJHfrZC71uwBS7V.KWM6OUxbGV) : p5s3FJHfrZC71uwBS7V.D35lls5iF(p5s3FJHfrZC71uwBS7V.j0F6NCjo6k), lhUOEJ6uOhY2TVo9HQv.SYx6PflhV0);
					}
					else
					{
						if ((int)X6dagBgIU5bQsE98LL.D35lls5iF(e, X6dagBgIU5bQsE98LL.dcKiqyPBj) == 23)
						{
							awaiter = wd2eJ2Asf3I9epXUKxU.D35lls5iF(radioFFMEPlayer.Media, wd2eJ2Asf3I9epXUKxU.nHuAhAMFhD).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_0138;
						}
						if ((int)X6dagBgIU5bQsE98LL.D35lls5iF(e, X6dagBgIU5bQsE98LL.dcKiqyPBj) == 25)
						{
							awaiter = wd2eJ2Asf3I9epXUKxU.D35lls5iF(radioFFMEPlayer.Media, wd2eJ2Asf3I9epXUKxU.KSYAxc5OtD).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = (_003C_003E1__state = 1);
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_01c0;
						}
						if ((int)X6dagBgIU5bQsE98LL.D35lls5iF(e, X6dagBgIU5bQsE98LL.dcKiqyPBj) == 24)
						{
							Unosquare.FFME.MediaElement media = radioFFMEPlayer.Media;
							mAdJWQ9yhneCbEXlGMc.D35lls5iF(media, bATk1clKMSyO8g9EVbN.D35lls5iF(media, bATk1clKMSyO8g9EVbN.r4LAXMWUOq) + 0.05, mAdJWQ9yhneCbEXlGMc.QMBAfkYTl6);
						}
						else if ((int)X6dagBgIU5bQsE98LL.D35lls5iF(e, X6dagBgIU5bQsE98LL.dcKiqyPBj) == 26)
						{
							Unosquare.FFME.MediaElement media2 = radioFFMEPlayer.Media;
							mAdJWQ9yhneCbEXlGMc.D35lls5iF(media2, bATk1clKMSyO8g9EVbN.D35lls5iF(media2, bATk1clKMSyO8g9EVbN.r4LAXMWUOq) - 0.05, mAdJWQ9yhneCbEXlGMc.QMBAfkYTl6);
						}
						else if ((int)X6dagBgIU5bQsE98LL.D35lls5iF(e, X6dagBgIU5bQsE98LL.dcKiqyPBj) == 13)
						{
							QnJnl7fVDKI4mA6voc.D35lls5iF(VqWOinl9PO0jF3BJej0.D35lls5iF(Jr0pTQlovwB9pdID1EB.D35lls5iF(Jr0pTQlovwB9pdID1EB.CxrllgXtD4), VqWOinl9PO0jF3BJej0.XwJlDOAaeh) as HandyControl.Controls.Window, false, QnJnl7fVDKI4mA6voc.rhqn3tRO5f);
						}
					}
				}
				goto end_IL_0015;
				IL_0138:
				awaiter.GetResult();
				goto end_IL_0015;
				IL_01c0:
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

	private static readonly Key[] RV9W4a3LPv;

	private MediaType JsZWBvqiJK;

	private LivePlayerViewModel RkVWDuj5jX;

	internal Unosquare.FFME.MediaElement Media;

	private bool lbaWdtO8P5;

	public RadioFFMEPlayer()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		JsZWBvqiJK = MediaType.None;
		base._002Ector();
		hao3Y68m7Zvx79IIOKw.D35lls5iF(this, hao3Y68m7Zvx79IIOKw.gD8nTsSWEI);
		hao3Y68m7Zvx79IIOKw.D35lls5iF(this, hao3Y68m7Zvx79IIOKw.l3Bn4GOcdC);
		hao3Y68m7Zvx79IIOKw.D35lls5iF(this, hao3Y68m7Zvx79IIOKw.XmUnL7jlI3);
		RkVWDuj5jX = RAspAbuaTQFU0nSRiQ.D35lls5iF(this, RAspAbuaTQFU0nSRiQ.G1FymcVoT) as LivePlayerViewModel;
		RkVWDuj5jX.MediaElement = Media;
	}

	private void FfRvLJ2DL6()
	{
		XgfudvNjrG5dZKyndN.D35lls5iF(VqWOinl9PO0jF3BJej0.D35lls5iF(Jr0pTQlovwB9pdID1EB.D35lls5iF(Jr0pTQlovwB9pdID1EB.CxrllgXtD4), VqWOinl9PO0jF3BJej0.XwJlDOAaeh), xW7WjvPIBH, XgfudvNjrG5dZKyndN.tRNlHCnpGP);
	}

	private void CHyv2p1bun()
	{
		bHOmLK93DudIdGBrb75.D35lls5iF(OnMediaFFmpegMessageLogged, bHOmLK93DudIdGBrb75.Fod9TIsSiB);
		PaIS6u94vkelmQi5rj0.D35lls5iF(Media, f0TWvkcTUI, PaIS6u94vkelmQi5rj0.MEx9LXd1lc);
		i3gnNI9Eg29lNWhhmj9.D35lls5iF(Media, KIrvzWwSE0, i3gnNI9Eg29lNWhhmj9.x0y9BgXsjM);
		qIyXdQ90W8ud3wp2ybv.D35lls5iF(Media, AK4WcBkmOT, qIyXdQ90W8ud3wp2ybv.G9b9r6c2Bl);
		XeTMat9eHdgUsPwyBUr.D35lls5iF(Media, OnMediaOpened, XeTMat9eHdgUsPwyBUr.xeJ9GY5CYT);
		ytk50glr3dmeojxPvdr.D35lls5iF(Media, OnMediaReady, ytk50glr3dmeojxPvdr.VLo9RbyDNh);
		ytk50glr3dmeojxPvdr.D35lls5iF(Media, OnMediaClosed, ytk50glr3dmeojxPvdr.KQE9kKpkPQ);
		qIyXdQ90W8ud3wp2ybv.D35lls5iF(Media, OnMediaChanging, qIyXdQ90W8ud3wp2ybv.BuQ9vYnSId);
		ytk50glr3dmeojxPvdr.D35lls5iF(Media, OnAudioDeviceStopped, ytk50glr3dmeojxPvdr.hxb9lGDlo9);
		XeTMat9eHdgUsPwyBUr.D35lls5iF(Media, OnMediaChanged, XeTMat9eHdgUsPwyBUr.fVH9ALNi6D);
		C0UEi896TGi2A8w1c4U.D35lls5iF(Media, OnMediaFailed, C0UEi896TGi2A8w1c4U.ta09pyJDvh);
	}

	protected void OnMediaMessageLogged(object sender, MediaLogMessageEventArgs e)
	{
		tGMrJE9wjDS38eXmODX.D35lls5iF(e, tGMrJE9wjDS38eXmODX.MmY9CRb1AT);
		_ = 4;
	}

	protected void OnMediaFFmpegMessageLogged(object sender, MediaLogMessageEventArgs e)
	{
		if ((tGMrJE9wjDS38eXmODX.D35lls5iF(e, tGMrJE9wjDS38eXmODX.MmY9CRb1AT) == MediaLogMessageType.Warning || tGMrJE9wjDS38eXmODX.D35lls5iF(e, tGMrJE9wjDS38eXmODX.MmY9CRb1AT) == MediaLogMessageType.Error) && (M6ZErPEr2LZyWYpa5O.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(e, wq2usy8gNndpuTw5mR.nlj9mLUBnu), M6ZErPEr2LZyWYpa5O.rg89aHbgYh) || !S1a0wT9Ixre9OpDny8h.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(e, wq2usy8gNndpuTw5mR.nlj9mLUBnu), iFZ5je3XFYKwkvcE5D.D35lls5iF(340, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.l249ddg9vO)) && M6ZErPEr2LZyWYpa5O.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(e, wq2usy8gNndpuTw5mR.nlj9mLUBnu), M6ZErPEr2LZyWYpa5O.rg89aHbgYh) && VMs7lU9URBMKdJRC1h1.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(e, wq2usy8gNndpuTw5mR.nlj9mLUBnu), iFZ5je3XFYKwkvcE5D.D35lls5iF(402, iFZ5je3XFYKwkvcE5D.N06TeK0ao), VMs7lU9URBMKdJRC1h1.p7T9tIfMiJ))
		{
			VMs7lU9URBMKdJRC1h1.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(e, wq2usy8gNndpuTw5mR.nlj9mLUBnu), iFZ5je3XFYKwkvcE5D.D35lls5iF(442, iFZ5je3XFYKwkvcE5D.N06TeK0ao), VMs7lU9URBMKdJRC1h1.p7T9tIfMiJ);
		}
	}

	protected void OnMediaFailed(object sender, MediaFailedEventArgs e)
	{
	}

	private void KIrvzWwSE0(object P_0, MediaInitializingEventArgs P_1)
	{
		if (RJdEUw97wnVnGsBRmDG.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(P_1, wq2usy8gNndpuTw5mR.Jgy9VSHVYB), iFZ5je3XFYKwkvcE5D.D35lls5iF(458, iFZ5je3XFYKwkvcE5D.N06TeK0ao), StringComparison.OrdinalIgnoreCase, RJdEUw97wnVnGsBRmDG.y949cPsE49))
		{
			QnJnl7fVDKI4mA6voc.D35lls5iF(nXvH3V9ON1PquOtoxuq.D35lls5iF(uIIaqd9MWbmAhTXPYKL.D35lls5iF(P_1, uIIaqd9MWbmAhTXPYKL.a3y9SGZNdS), nXvH3V9ON1PquOtoxuq.g2g9uaXBwW), true, QnJnl7fVDKI4mA6voc.J0Z9Ppmjjt);
			vQKA0r9sJ1kArsIHc16.D35lls5iF(nXvH3V9ON1PquOtoxuq.D35lls5iF(uIIaqd9MWbmAhTXPYKL.D35lls5iF(P_1, uIIaqd9MWbmAhTXPYKL.a3y9SGZNdS), nXvH3V9ON1PquOtoxuq.g2g9uaXBwW), 8192, vQKA0r9sJ1kArsIHc16.km39hJJ5mo);
			AKwYZ1lE8mnNaTGlMo6.D35lls5iF(nXvH3V9ON1PquOtoxuq.D35lls5iF(uIIaqd9MWbmAhTXPYKL.D35lls5iF(P_1, uIIaqd9MWbmAhTXPYKL.a3y9SGZNdS), nXvH3V9ON1PquOtoxuq.g2g9uaXBwW), aNJrrPl4soK5NDOndiN.D35lls5iF(1.0, aNJrrPl4soK5NDOndiN.Ca9lahqtKS), AKwYZ1lE8mnNaTGlMo6.HSE9xIihv0);
		}
		if (RJdEUw97wnVnGsBRmDG.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(P_1, wq2usy8gNndpuTw5mR.Jgy9VSHVYB), iFZ5je3XFYKwkvcE5D.D35lls5iF(3948, iFZ5je3XFYKwkvcE5D.N06TeK0ao), StringComparison.OrdinalIgnoreCase, RJdEUw97wnVnGsBRmDG.y949cPsE49))
		{
			dq1xgG9KNu7RfbYkGMV.D35lls5iF(uIIaqd9MWbmAhTXPYKL.D35lls5iF(P_1, uIIaqd9MWbmAhTXPYKL.a3y9SGZNdS), dq1xgG9KNu7RfbYkGMV.xWD9NR1CqV)[iFZ5je3XFYKwkvcE5D.D35lls5iF(474, iFZ5je3XFYKwkvcE5D.N06TeK0ao)] = iFZ5je3XFYKwkvcE5D.D35lls5iF(3966, iFZ5je3XFYKwkvcE5D.N06TeK0ao);
			QnJnl7fVDKI4mA6voc.D35lls5iF(nXvH3V9ON1PquOtoxuq.D35lls5iF(uIIaqd9MWbmAhTXPYKL.D35lls5iF(P_1, uIIaqd9MWbmAhTXPYKL.a3y9SGZNdS), nXvH3V9ON1PquOtoxuq.g2g9uaXBwW), true, QnJnl7fVDKI4mA6voc.J0Z9Ppmjjt);
			AKwYZ1lE8mnNaTGlMo6.D35lls5iF(uIIaqd9MWbmAhTXPYKL.D35lls5iF(P_1, uIIaqd9MWbmAhTXPYKL.a3y9SGZNdS), aNJrrPl4soK5NDOndiN.D35lls5iF(10.0, aNJrrPl4soK5NDOndiN.Ca9lahqtKS), AKwYZ1lE8mnNaTGlMo6.zL6nlX0JV7);
		}
		if (!RJdEUw97wnVnGsBRmDG.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(P_1, wq2usy8gNndpuTw5mR.Jgy9VSHVYB), iFZ5je3XFYKwkvcE5D.D35lls5iF(3976, iFZ5je3XFYKwkvcE5D.N06TeK0ao), StringComparison.OrdinalIgnoreCase, RJdEUw97wnVnGsBRmDG.y949cPsE49))
		{
			RJdEUw97wnVnGsBRmDG.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(P_1, wq2usy8gNndpuTw5mR.Jgy9VSHVYB), iFZ5je3XFYKwkvcE5D.D35lls5iF(3994, iFZ5je3XFYKwkvcE5D.N06TeK0ao), StringComparison.OrdinalIgnoreCase, RJdEUw97wnVnGsBRmDG.y949cPsE49);
		}
	}

	private void AK4WcBkmOT(object P_0, MediaOpeningEventArgs P_1)
	{
		_003C_003Ec__DisplayClass10_0 CS_0024_003C_003E8__locals15 = new _003C_003Ec__DisplayClass10_0();
		CS_0024_003C_003E8__locals15.fe4Tz1qVT2 = P_0 as Unosquare.FFME.MediaElement;
		AKwYZ1lE8mnNaTGlMo6.D35lls5iF(YQF0kW9goqSdXoWtJAF.D35lls5iF(P_1, YQF0kW9goqSdXoWtJAF.XRw9ikEf4n), TimeSpan.Zero, AKwYZ1lE8mnNaTGlMo6.IOXn9cTIlY);
		mAdJWQ9yhneCbEXlGMc.D35lls5iF(YQF0kW9goqSdXoWtJAF.D35lls5iF(P_1, YQF0kW9goqSdXoWtJAF.XRw9ikEf4n), 1.0, mAdJWQ9yhneCbEXlGMc.BP19qeiSg6);
		QnJnl7fVDKI4mA6voc.D35lls5iF(q1Gx2v9JbW9cOXEmWet.D35lls5iF(CS_0024_003C_003E8__locals15.fe4Tz1qVT2, q1Gx2v9JbW9cOXEmWet.adR9bl47sF), hjMnupQVVDlRZAYQJC.D35lls5iF(YQF0kW9goqSdXoWtJAF.D35lls5iF(P_1, YQF0kW9goqSdXoWtJAF.XRw9ikEf4n), hjMnupQVVDlRZAYQJC.xuq9WWJfIB) || RJdEUw97wnVnGsBRmDG.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(Pu8ZkM9Q72E1xo0KU8s.D35lls5iF(P_1, Pu8ZkM9Q72E1xo0KU8s.mf79X0XhAB), wq2usy8gNndpuTw5mR.NVF92wcVcL), iFZ5je3XFYKwkvcE5D.D35lls5iF(570, iFZ5je3XFYKwkvcE5D.N06TeK0ao), StringComparison.OrdinalIgnoreCase, RJdEUw97wnVnGsBRmDG.Omd951BO6P), QnJnl7fVDKI4mA6voc.xcM9zZ9GfC);
		vQKA0r9sJ1kArsIHc16.D35lls5iF(q1Gx2v9JbW9cOXEmWet.D35lls5iF(CS_0024_003C_003E8__locals15.fe4Tz1qVT2, q1Gx2v9JbW9cOXEmWet.adR9bl47sF), 0, vQKA0r9sJ1kArsIHc16.U5RDoantIq);
		string text = string.Empty;
		try
		{
			Uri uri = new Uri(wq2usy8gNndpuTw5mR.D35lls5iF(Pu8ZkM9Q72E1xo0KU8s.D35lls5iF(P_1, Pu8ZkM9Q72E1xo0KU8s.mf79X0XhAB), wq2usy8gNndpuTw5mR.NVF92wcVcL));
			text = ((hjMnupQVVDlRZAYQJC.D35lls5iF(uri, hjMnupQVVDlRZAYQJC.BPnDlBRbx2) || hjMnupQVVDlRZAYQJC.D35lls5iF(uri, hjMnupQVVDlRZAYQJC.QNSD9EFv9p)) ? vr2NVdDHkMwed7KwMIr.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(uri, wq2usy8gNndpuTw5mR.xEYDDHV3gk), vr2NVdDHkMwed7KwMIr.a3qD1DVINi) : string.Empty);
		}
		catch
		{
		}
		if (!M6ZErPEr2LZyWYpa5O.D35lls5iF(text, M6ZErPEr2LZyWYpa5O.rg89aHbgYh))
		{
			string text2 = UwSEfC4rh9eVlFenwI.D35lls5iF(text, iFZ5je3XFYKwkvcE5D.D35lls5iF(4014, iFZ5je3XFYKwkvcE5D.N06TeK0ao), UwSEfC4rh9eVlFenwI.Bv2nDYQycM);
			if (M6ZErPEr2LZyWYpa5O.D35lls5iF(text2, M6ZErPEr2LZyWYpa5O.WPpnHj4Wcq))
			{
				qni3xrDkAJ3vF35eMav.D35lls5iF(YQF0kW9goqSdXoWtJAF.D35lls5iF(P_1, YQF0kW9goqSdXoWtJAF.XRw9ikEf4n), text2, qni3xrDkAJ3vF35eMav.abln1mMUvb);
			}
		}
		CS_0024_003C_003E8__locals15.YA3ZcgZJpp = nrSOHAD8YrC91Hd87Ly.D35lls5iF(YQF0kW9goqSdXoWtJAF.D35lls5iF(P_1, YQF0kW9goqSdXoWtJAF.XRw9ikEf4n), nrSOHAD8YrC91Hd87Ly.EaoDno9rGj);
		if (CS_0024_003C_003E8__locals15.YA3ZcgZJpp == null)
		{
			return;
		}
		AVHWDeviceType[] array = new AVHWDeviceType[3];
		ODLiVRlRE2AwTHTxA2m.D35lls5iF(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, ODLiVRlRE2AwTHTxA2m.rwklk7wPqp);
		AVHWDeviceType[] array2 = array;
		if (bATk1clKMSyO8g9EVbN.D35lls5iF(CS_0024_003C_003E8__locals15.YA3ZcgZJpp, bATk1clKMSyO8g9EVbN.CcVD3lb0hu) <= 30.0)
		{
			AVHWDeviceType[] array3 = array2;
			for (int i = 0; i < array3.Length; i++)
			{
				_003C_003Ec__DisplayClass10_1 CS_0024_003C_003E8__locals13 = new _003C_003Ec__DisplayClass10_1();
				CS_0024_003C_003E8__locals13.E6tZvtvaIo = array3[i];
				HardwareDeviceInfo hardwareDeviceInfo = MSyPQaDTrfJtr3GUW48.D35lls5iF(CS_0024_003C_003E8__locals15.YA3ZcgZJpp, MSyPQaDTrfJtr3GUW48.ESUD4s2tw8).Reverse().FirstOrDefault((HardwareDeviceInfo d) => aMnygB67j3N3yuQbSMF.D35lls5iF(d, aMnygB67j3N3yuQbSMF.PKP6cQZX8R) == CS_0024_003C_003E8__locals13.E6tZvtvaIo);
				if (hardwareDeviceInfo != null)
				{
					OZFi5cDLea4g6MgMYOr.D35lls5iF(YQF0kW9goqSdXoWtJAF.D35lls5iF(P_1, YQF0kW9goqSdXoWtJAF.XRw9ikEf4n), hardwareDeviceInfo, OZFi5cDLea4g6MgMYOr.e4mDEqBveZ);
					break;
				}
			}
		}
		StringBuilder stringBuilder = new StringBuilder();
		if (hjMnupQVVDlRZAYQJC.D35lls5iF(CS_0024_003C_003E8__locals15.YA3ZcgZJpp, hjMnupQVVDlRZAYQJC.a2an8cXkZR))
		{
			Iqu9Z2D0u6duXqVdeBe.D35lls5iF(stringBuilder, iFZ5je3XFYKwkvcE5D.D35lls5iF(4024, iFZ5je3XFYKwkvcE5D.N06TeK0ao), Iqu9Z2D0u6duXqVdeBe.No5DrBqXtD);
		}
		if (m9MGZR7k2RmVqYXYS5.D35lls5iF(CS_0024_003C_003E8__locals15.YA3ZcgZJpp, m9MGZR7k2RmVqYXYS5.l8vDBfi6TL) > 1080)
		{
			Iqu9Z2D0u6duXqVdeBe.D35lls5iF(stringBuilder, iFZ5je3XFYKwkvcE5D.D35lls5iF(582, iFZ5je3XFYKwkvcE5D.N06TeK0ao), Iqu9Z2D0u6duXqVdeBe.No5DrBqXtD);
		}
		qni3xrDkAJ3vF35eMav.D35lls5iF(YQF0kW9goqSdXoWtJAF.D35lls5iF(P_1, YQF0kW9goqSdXoWtJAF.XRw9ikEf4n), slLC9nDGSMhIcv2FTUB.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(stringBuilder, wq2usy8gNndpuTw5mR.ajcDe8nffb), ',', slLC9nDGSMhIcv2FTUB.yv2DRs3jeV), qni3xrDkAJ3vF35eMav.dmJDvBNs4m);
		Dispatcher obj2 = bRAh8kDAgKIlehXIXku.D35lls5iF(CS_0024_003C_003E8__locals15.fe4Tz1qVT2, bRAh8kDAgKIlehXIXku.oESD6ce9jH);
		if (obj2 != null)
		{
			QDm1hrDpKcWfLbL64Vl.D35lls5iF(obj2, delegate
			{
				K8DNce6twv9Np34xpPr.D35lls5iF(CS_0024_003C_003E8__locals15.fe4Tz1qVT2, uEUVCI48fycroqgRFqy.D35lls5iF(CS_0024_003C_003E8__locals15.YA3ZcgZJpp, uEUVCI48fycroqgRFqy.hx66UqOmg8) ? CaptionsChannel.CC1 : CaptionsChannel.CCP, K8DNce6twv9Np34xpPr.qtR6VreiE6);
			}, QDm1hrDpKcWfLbL64Vl.cxUDwIkrIx);
		}
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
			where Up3ObFDSJspBLFTGC8N.D35lls5iF(x.Value, Up3ObFDSJspBLFTGC8N.z70DKvMmSu) == (AVMediaType)JsZWBvqiJK
			select x.Value).ToList();
		if (list.Count > 0)
		{
			if (JsZWBvqiJK != MediaType.Video)
			{
				list.Add(null);
			}
			int num;
			switch (JsZWBvqiJK)
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
			switch (JsZWBvqiJK)
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

	[AsyncStateMachine(typeof(_003COnAudioDeviceStopped_003Ed__16))]
	protected void OnAudioDeviceStopped(object sender, EventArgs e)
	{
		_003COnAudioDeviceStopped_003Ed__16 stateMachine = default(_003COnAudioDeviceStopped_003Ed__16);
		stateMachine._003C_003Et__builder = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
		stateMachine.sender = sender;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003COnUserControlKeyDown_003Ed__17))]
	private void xW7WjvPIBH(object P_0, KeyEventArgs P_1)
	{
		_003COnUserControlKeyDown_003Ed__17 stateMachine = default(_003COnUserControlKeyDown_003Ed__17);
		stateMachine._003C_003Et__builder = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
		stateMachine._003C_003E4__this = this;
		stateMachine.e = P_1;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void f0TWvkcTUI(object P_0, MouseButtonEventArgs P_1)
	{
		if (P_0 != null && GmMLaTD7kV8rq88ZFvR.D35lls5iF(P_0, Media, GmMLaTD7kV8rq88ZFvR.BQ5Dcmx5Pp))
		{
			QnJnl7fVDKI4mA6voc.D35lls5iF(P_1, true, QnJnl7fVDKI4mA6voc.WSpDMQcj8Y);
			QnJnl7fVDKI4mA6voc.D35lls5iF(VqWOinl9PO0jF3BJej0.D35lls5iF(Jr0pTQlovwB9pdID1EB.D35lls5iF(Jr0pTQlovwB9pdID1EB.CxrllgXtD4), VqWOinl9PO0jF3BJej0.XwJlDOAaeh) as HandyControl.Controls.Window, !hjMnupQVVDlRZAYQJC.D35lls5iF(VqWOinl9PO0jF3BJej0.D35lls5iF(Jr0pTQlovwB9pdID1EB.D35lls5iF(Jr0pTQlovwB9pdID1EB.CxrllgXtD4), VqWOinl9PO0jF3BJej0.XwJlDOAaeh) as HandyControl.Controls.Window, hjMnupQVVDlRZAYQJC.DIqnn19PDf), QnJnl7fVDKI4mA6voc.rhqn3tRO5f);
		}
	}

	protected void OnMediaPositionChanged(object sender, PositionChangedEventArgs e)
	{
	}

	protected void OnMediaStateChanged(object sender, MediaStateChangedEventArgs e)
	{
	}

	[GeneratedCode("PresentationBuildTasks", "5.0.4.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!lbaWdtO8P5)
		{
			lbaWdtO8P5 = true;
			Uri uri = new Uri(iFZ5je3XFYKwkvcE5D.D35lls5iF(4178, iFZ5je3XFYKwkvcE5D.N06TeK0ao), UriKind.Relative);
			TUdx26d4l5VwJTvopv.D35lls5iF(this, uri, TUdx26d4l5VwJTvopv.W3oUN4AKb);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "5.0.4.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		if (connectionId == 1)
		{
			Media = (Unosquare.FFME.MediaElement)target;
		}
		else
		{
			lbaWdtO8P5 = true;
		}
	}

	static RadioFFMEPlayer()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		Key[] array = new Key[3];
		ODLiVRlRE2AwTHTxA2m.D35lls5iF(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, ODLiVRlRE2AwTHTxA2m.rwklk7wPqp);
		RV9W4a3LPv = (Key[])(object)array;
	}

	[CompilerGenerated]
	private bool V9dWWvxF1E(KeyValuePair<int, StreamInfo> P_0)
	{
		return Up3ObFDSJspBLFTGC8N.D35lls5iF(P_0.Value, Up3ObFDSJspBLFTGC8N.z70DKvMmSu) == (AVMediaType)JsZWBvqiJK;
	}
}
