using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Navigation;
using System.Windows.Threading;
using FFmpeg.AutoGen;
using PROTV.Abstractions.Common;
using PROTV.Abstractions.Services;
using PROTV.Wpf.Bootstrap;
using PROTV.Wpf.ViewModels;
using Unosquare.FFME;
using Unosquare.FFME.ClosedCaptions;
using Unosquare.FFME.Common;

namespace PROTV.Wpf.Views;

public class HomeView : BasePage<HomeViewModel>, IComponentConnector
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass10_0
	{
		public HomeView KhPTyDNRPC;

		public HomeViewModel PVhTpQYW38;

		public _003C_003Ec__DisplayClass10_0()
		{
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
			base._002Ector();
		}

		internal void fd4T6E2KZ4(object s, MouseEventArgs e)
		{
			KhPTyDNRPC.v5cjtR5A7L = true;
			KhPTyDNRPC.cD8jZAPccq = BvlWxPl1hnvXiXiwcCq.D35lls5iF(BvlWxPl1hnvXiXiwcCq.EYWl8ivUIj);
		}

		internal void K1KTsj1DhU(object s, MouseEventArgs e)
		{
			if (KhPTyDNRPC.v5cjtR5A7L)
			{
				KhPTyDNRPC.cD8jZAPccq = BvlWxPl1hnvXiXiwcCq.D35lls5iF(BvlWxPl1hnvXiXiwcCq.EYWl8ivUIj);
			}
			KhPTyDNRPC.v5cjtR5A7L = false;
		}

		internal void mgvTxyfGk2(object s, EventArgs e)
		{
			DateTime dateTime = BvlWxPl1hnvXiXiwcCq.D35lls5iF(BvlWxPl1hnvXiXiwcCq.EYWl8ivUIj);
			TimeSpan timeSpan = zDNlydlUqWxR09wbg1x.D35lls5iF(ref dateTime, KhPTyDNRPC.cD8jZAPccq, zDNlydlUqWxR09wbg1x.kq0ltTVoZs);
			if (LUSRjplVkOtM7DbdDL3.D35lls5iF(ref timeSpan, LUSRjplVkOtM7DbdDL3.LAf3veRADK) >= 3.0 && !hjMnupQVVDlRZAYQJC.D35lls5iF(KhPTyDNRPC.TabbedPannel, hjMnupQVVDlRZAYQJC.e2YlcKn06I) && !KhPTyDNRPC.eudj8kJIVv && !hjMnupQVVDlRZAYQJC.D35lls5iF(KhPTyDNRPC.TabbedPannel, hjMnupQVVDlRZAYQJC.e2YlcKn06I))
			{
				QnJnl7fVDKI4mA6voc.D35lls5iF(PVhTpQYW38, false, QnJnl7fVDKI4mA6voc.Aq9HvCxSeV);
			}
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnMediaEnded_003Ed__16 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public HomeView _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			HomeView homeView = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(pvrKKy8Mk1kpdmIfp3A.D35lls5iF(2000, pvrKKy8Mk1kpdmIfp3A.aVh8SPrFkE), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
					if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
				}
				oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
				bool flag = uEUVCI48fycroqgRFqy.D35lls5iF(homeView.UFCjkvE5S9.MediaElement, uEUVCI48fycroqgRFqy.RIVAOZeovq);
				if (!uEUVCI48fycroqgRFqy.D35lls5iF(homeView.UFCjkvE5S9, uEUVCI48fycroqgRFqy.wIRp3h4JSC) && !flag)
				{
					TimeSpan value = XLgPbA36DhJ4A0tFJ41.D35lls5iF(homeView.UFCjkvE5S9.MediaElement, XLgPbA36DhJ4A0tFJ41.tP43pEUL5Y).Value;
					double num2 = LUSRjplVkOtM7DbdDL3.D35lls5iF(ref value, LUSRjplVkOtM7DbdDL3.LAf3veRADK);
					value = moA0183RanLCkEiLXks.D35lls5iF(homeView.UFCjkvE5S9.MediaElement, moA0183RanLCkEiLXks.K3o3krsS6B);
					if (num2 - LUSRjplVkOtM7DbdDL3.D35lls5iF(ref value, LUSRjplVkOtM7DbdDL3.LAf3veRADK) <= 2.0)
					{
						fp757nBYjo8889efKFJ.D35lls5iF(homeView.UFCjkvE5S9, fp757nBYjo8889efKFJ.saIpTMSUYR);
					}
				}
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
	private sealed class _003C_003Ec__DisplayClass21_0
	{
		public Unosquare.FFME.MediaElement d7eT3YKnu1;

		public StreamInfo dl6TmAN7Zj;

		public _003C_003Ec__DisplayClass21_0()
		{
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
			base._002Ector();
		}

		internal void JO0TitX3JO()
		{
			K8DNce6twv9Np34xpPr.D35lls5iF(d7eT3YKnu1, uEUVCI48fycroqgRFqy.D35lls5iF(dl6TmAN7Zj, uEUVCI48fycroqgRFqy.hx66UqOmg8) ? CaptionsChannel.CC1 : CaptionsChannel.CCP, K8DNce6twv9Np34xpPr.qtR6VreiE6);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass21_1
	{
		public AVHWDeviceType qNgTR4Cxyw;

		public _003C_003Ec__DisplayClass21_1()
		{
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
			base._002Ector();
		}

		internal bool my4TXI40YP(HardwareDeviceInfo d)
		{
			return aMnygB67j3N3yuQbSMF.D35lls5iF(d, aMnygB67j3N3yuQbSMF.PKP6cQZX8R) == qNgTR4Cxyw;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnAudioDeviceStopped_003Ed__27 : IAsyncStateMachine
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
	private struct _003C_003CNavigationFrame_Navigated_003Eb__12_0_003Ed : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public HomeView _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			HomeView homeView = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(xvst7LA88CbscxBNUCX.D35lls5iF(xvst7LA88CbscxBNUCX.fm6AmQoqGx), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
					if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
				}
				oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
				IStoreContext storeContext = AppContainer.Resolve<IStoreContext>();
				hH6DVMBvgw3ANNRyBk6.D35lls5iF(homeView.TiDjTli5MS, wq2usy8gNndpuTw5mR.D35lls5iF(storeContext, wq2usy8gNndpuTw5mR.Ef8TjHOTJx), hH6DVMBvgw3ANNRyBk6.OT3p4YkWHd);
			}
			catch (Exception ex)
			{
				_003C_003E1__state = -2;
				NNK1eXA7fWQ87oSUty7.D35lls5iF(ref _003C_003Et__builder, ex, NNK1eXA7fWQ87oSUty7.G3EAcW9Om7);
				return;
			}
			_003C_003E1__state = -2;
			meFicnAMHIVtdhf671p.D35lls5iF(ref _003C_003Et__builder, meFicnAMHIVtdhf671p.bsDASenQ5I);
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			vxBFJcAKZoecNtbdqxt.D35lls5iF(ref _003C_003Et__builder, stateMachine, vxBFJcAKZoecNtbdqxt.tuxANdhu18);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	private HomeViewModel TiDjTli5MS;

	private DateTime cD8jZAPccq;

	private bool v5cjtR5A7L;

	private DispatcherTimer sI2jS3q6bS;

	private static readonly Key[] h9ajfNAElv;

	private Unosquare.FFME.Common.MediaType PJOjKkBROT;

	private MainPlayerViewModel UFCjkvE5S9;

	private bool eudj8kJIVv;

	internal Unosquare.FFME.MediaElement Media;

	internal Frame NavigationFrame;

	internal Grid TabbedPannel;

	internal ScrollViewer MyScrollViewer;

	internal ListView listView;

	private bool RZbjQeZZLy;

	private void HN9jjwNHCv(object P_0, DependencyPropertyChangedEventArgs P_1)
	{
		_ = RAspAbuaTQFU0nSRiQ.D35lls5iF(this, RAspAbuaTQFU0nSRiQ.G1FymcVoT) is MainPlayerViewModel;
	}

	public HomeView()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		v5cjtR5A7L = true;
		PJOjKkBROT = Unosquare.FFME.Common.MediaType.None;
		base._002Ector();
		AJv70itXcdnxnNYjSQ.D35lls5iF(this, AJv70itXcdnxnNYjSQ.hYHH1KuvgY);
	}

	public HomeView(HomeViewModel specificViewModel)
	{
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected O, but got Unknown
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected O, but got Unknown
		//IL_0181: Expected O, but got Unknown
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		v5cjtR5A7L = true;
		PJOjKkBROT = Unosquare.FFME.Common.MediaType.None;
		_003C_003Ec__DisplayClass10_0 CS_0024_003C_003E8__locals17 = new _003C_003Ec__DisplayClass10_0();
		CS_0024_003C_003E8__locals17.PVhTpQYW38 = specificViewModel;
		base._002Ector(CS_0024_003C_003E8__locals17.PVhTpQYW38);
		CS_0024_003C_003E8__locals17.KhPTyDNRPC = this;
		AJv70itXcdnxnNYjSQ.D35lls5iF(this, AJv70itXcdnxnNYjSQ.hYHH1KuvgY);
		dp97HSDjYOMxMALpn4D.D35lls5iF(this, xu8jVY2xp3, dp97HSDjYOMxMALpn4D.qfpH8tNVkP);
		pP5yD4HTn2JAX7Hk2oY.D35lls5iF(CS_0024_003C_003E8__locals17.PVhTpQYW38, Xlypb0Hnr2C3ydrYEdG.D35lls5iF(NavigationFrame, Xlypb0Hnr2C3ydrYEdG.sKhH3C8T7d), pP5yD4HTn2JAX7Hk2oY.cU6H4PoRL6);
		yIfmqUHLHJhLvL11x1E.D35lls5iF(CS_0024_003C_003E8__locals17.PVhTpQYW38, NavigationFrame, yIfmqUHLHJhLvL11x1E.UspHEXxCDh);
		Page page = new Page();
		KBhlAv9D2TgBJ1kkc0B.D35lls5iF(page, IyGDDwHBiPv8vfOFJDF.D35lls5iF(ApplicationPage.LogoPage, null, IyGDDwHBiPv8vfOFJDF.hivH0XYhaE), KBhlAv9D2TgBJ1kkc0B.fWUHrWO7Sa);
		qni3xrDkAJ3vF35eMav.D35lls5iF(page, EBgwuVHeVLDJVVfMaAk.D35lls5iF(ApplicationPage.LogoPage, EBgwuVHeVLDJVVfMaAk.mtcHG3MEy3), qni3xrDkAJ3vF35eMav.Ra7HRFTvnD);
		Page page2 = page;
		GmMLaTD7kV8rq88ZFvR.D35lls5iF(Xlypb0Hnr2C3ydrYEdG.D35lls5iF(NavigationFrame, Xlypb0Hnr2C3ydrYEdG.sKhH3C8T7d), page2, GmMLaTD7kV8rq88ZFvR.iMJHkmaaRY);
		QnJnl7fVDKI4mA6voc.D35lls5iF(CS_0024_003C_003E8__locals17.PVhTpQYW38, true, QnJnl7fVDKI4mA6voc.Aq9HvCxSeV);
		TiDjTli5MS = CS_0024_003C_003E8__locals17.PVhTpQYW38;
		cD8jZAPccq = BvlWxPl1hnvXiXiwcCq.D35lls5iF(BvlWxPl1hnvXiXiwcCq.EYWl8ivUIj);
		Av2eQglnElp5ZoM4x07.D35lls5iF(TabbedPannel, delegate
		{
			CS_0024_003C_003E8__locals17.KhPTyDNRPC.v5cjtR5A7L = true;
			CS_0024_003C_003E8__locals17.KhPTyDNRPC.cD8jZAPccq = BvlWxPl1hnvXiXiwcCq.D35lls5iF(BvlWxPl1hnvXiXiwcCq.EYWl8ivUIj);
		}, Av2eQglnElp5ZoM4x07.VD7HAHAE20);
		Av2eQglnElp5ZoM4x07.D35lls5iF(TabbedPannel, delegate
		{
			if (CS_0024_003C_003E8__locals17.KhPTyDNRPC.v5cjtR5A7L)
			{
				CS_0024_003C_003E8__locals17.KhPTyDNRPC.cD8jZAPccq = BvlWxPl1hnvXiXiwcCq.D35lls5iF(BvlWxPl1hnvXiXiwcCq.EYWl8ivUIj);
			}
			CS_0024_003C_003E8__locals17.KhPTyDNRPC.v5cjtR5A7L = false;
		}, Av2eQglnElp5ZoM4x07.Sm1H60E3gg);
		DispatcherTimer val = new DispatcherTimer((DispatcherPriority)4);
		AKwYZ1lE8mnNaTGlMo6.D35lls5iF((object)val, aNJrrPl4soK5NDOndiN.D35lls5iF(150.0, aNJrrPl4soK5NDOndiN.V5YlLGDQcw), AKwYZ1lE8mnNaTGlMo6.EaBlBG90pn);
		QnJnl7fVDKI4mA6voc.D35lls5iF((object)val, true, QnJnl7fVDKI4mA6voc.Jd4l02EqPh);
		sI2jS3q6bS = val;
		ytk50glr3dmeojxPvdr.D35lls5iF(sI2jS3q6bS, delegate
		{
			DateTime dateTime = BvlWxPl1hnvXiXiwcCq.D35lls5iF(BvlWxPl1hnvXiXiwcCq.EYWl8ivUIj);
			TimeSpan timeSpan = zDNlydlUqWxR09wbg1x.D35lls5iF(ref dateTime, CS_0024_003C_003E8__locals17.KhPTyDNRPC.cD8jZAPccq, zDNlydlUqWxR09wbg1x.kq0ltTVoZs);
			if (LUSRjplVkOtM7DbdDL3.D35lls5iF(ref timeSpan, LUSRjplVkOtM7DbdDL3.LAf3veRADK) >= 3.0 && !hjMnupQVVDlRZAYQJC.D35lls5iF(CS_0024_003C_003E8__locals17.KhPTyDNRPC.TabbedPannel, hjMnupQVVDlRZAYQJC.e2YlcKn06I) && !CS_0024_003C_003E8__locals17.KhPTyDNRPC.eudj8kJIVv && !hjMnupQVVDlRZAYQJC.D35lls5iF(CS_0024_003C_003E8__locals17.KhPTyDNRPC.TabbedPannel, hjMnupQVVDlRZAYQJC.e2YlcKn06I))
			{
				QnJnl7fVDKI4mA6voc.D35lls5iF(CS_0024_003C_003E8__locals17.PVhTpQYW38, false, QnJnl7fVDKI4mA6voc.Aq9HvCxSeV);
			}
		}, ytk50glr3dmeojxPvdr.Lgkle9IPtT);
		AJv70itXcdnxnNYjSQ.D35lls5iF(sI2jS3q6bS, AJv70itXcdnxnNYjSQ.JRYlG0QuuU);
		iHTvSbHpsNuCgTmqEag.D35lls5iF(NavigationFrame, IuEjWkTLnR, iHTvSbHpsNuCgTmqEag.BnRHwlvgxf);
		dp97HSDjYOMxMALpn4D.D35lls5iF(this, Agqjvn5iOc, dp97HSDjYOMxMALpn4D.vtODyN5sav);
	}

	private void Agqjvn5iOc(object P_0, RoutedEventArgs P_1)
	{
		MI3oOiHCZASyM6ERRUP.D35lls5iF(TiDjTli5MS, MI3oOiHCZASyM6ERRUP.h0JHmOSEFB).MediaElement = Media;
		AJv70itXcdnxnNYjSQ.D35lls5iF(this, AJv70itXcdnxnNYjSQ.B8cHaaWRoq);
		UFCjkvE5S9 = MI3oOiHCZASyM6ERRUP.D35lls5iF(TiDjTli5MS, MI3oOiHCZASyM6ERRUP.h0JHmOSEFB);
	}

	private void IuEjWkTLnR(object P_0, NavigationEventArgs P_1)
	{
		TVLePdHICaM6OkL9Y6W.D35lls5iF([AsyncStateMachine(typeof(_003C_003CNavigationFrame_Navigated_003Eb__12_0_003Ed))] () =>
		{
			_003C_003CNavigationFrame_Navigated_003Eb__12_0_003Ed stateMachine = default(_003C_003CNavigationFrame_Navigated_003Eb__12_0_003Ed);
			stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
			stateMachine._003C_003E4__this = this;
			stateMachine._003C_003E1__state = -1;
			stateMachine._003C_003Et__builder.Start(ref stateMachine);
			return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
		}, TVLePdHICaM6OkL9Y6W.sqgHdsJXG7);
		if (pyK9koHUJmxk64T5R2W.D35lls5iF(TiDjTli5MS, pyK9koHUJmxk64T5R2W.uKgHthtmRL) != null)
		{
			oZcl3dHVcWPiI4Ao1YB.D35lls5iF(TiDjTli5MS, pyK9koHUJmxk64T5R2W.D35lls5iF(TiDjTli5MS, pyK9koHUJmxk64T5R2W.uKgHthtmRL).LastOrDefault(), oZcl3dHVcWPiI4Ao1YB.sPAH7oEm7s);
		}
		AJv70itXcdnxnNYjSQ.D35lls5iF(TiDjTli5MS, AJv70itXcdnxnNYjSQ.BiKHcjQZJT);
		BasePage basePage = RAspAbuaTQFU0nSRiQ.D35lls5iF(RAspAbuaTQFU0nSRiQ.D35lls5iF(P_1, RAspAbuaTQFU0nSRiQ.Er7HM5JiS7) as Page, RAspAbuaTQFU0nSRiQ.UVfHSpoUCc) as BasePage;
		ApplicationPage applicationPage = Ad8NmsHKMDNoqEDFjtJ.D35lls5iF(basePage, Ad8NmsHKMDNoqEDFjtJ.ljhHNvS1WJ);
		QnJnl7fVDKI4mA6voc.D35lls5iF(TiDjTli5MS, true, QnJnl7fVDKI4mA6voc.vjRHOd6ZiQ);
		switch (applicationPage)
		{
		case ApplicationPage.LogoPage:
		{
			MainPlayerViewModel mainPlayerViewModel3 = MI3oOiHCZASyM6ERRUP.D35lls5iF(TiDjTli5MS, MI3oOiHCZASyM6ERRUP.h0JHmOSEFB);
			if (((mainPlayerViewModel3 != null) ? I7R9FpHuQv8JsJPdFiv.D35lls5iF(mainPlayerViewModel3, I7R9FpHuQv8JsJPdFiv.PTqHPF39pv) : null) != null)
			{
				QnJnl7fVDKI4mA6voc.D35lls5iF(TiDjTli5MS, true, QnJnl7fVDKI4mA6voc.dUxHsdI86U);
			}
			QnJnl7fVDKI4mA6voc.D35lls5iF(TiDjTli5MS, false, QnJnl7fVDKI4mA6voc.nOjHh2nnTx);
			eudj8kJIVv = true;
			QnJnl7fVDKI4mA6voc.D35lls5iF(TiDjTli5MS, true, QnJnl7fVDKI4mA6voc.Aq9HvCxSeV);
			break;
		}
		case ApplicationPage.TVShowPage:
		{
			MainPlayerViewModel mainPlayerViewModel10 = MI3oOiHCZASyM6ERRUP.D35lls5iF(TiDjTli5MS, MI3oOiHCZASyM6ERRUP.h0JHmOSEFB);
			if (mainPlayerViewModel10 != null)
			{
				Unosquare.FFME.MediaElement mediaElement5 = mainPlayerViewModel10.MediaElement;
				if (((mediaElement5 != null) ? new bool?(hjMnupQVVDlRZAYQJC.D35lls5iF(mediaElement5, hjMnupQVVDlRZAYQJC.sXPHxO1Jaq)) : ((bool?)null)) == true)
				{
					MI3oOiHCZASyM6ERRUP.D35lls5iF(TiDjTli5MS, MI3oOiHCZASyM6ERRUP.h0JHmOSEFB).OnPauseCommandExcuteAsync();
				}
			}
			QnJnl7fVDKI4mA6voc.D35lls5iF(TiDjTli5MS, true, QnJnl7fVDKI4mA6voc.nOjHh2nnTx);
			eudj8kJIVv = false;
			QnJnl7fVDKI4mA6voc.D35lls5iF(TiDjTli5MS, false, QnJnl7fVDKI4mA6voc.Aq9HvCxSeV);
			VideoPlayerView videoPlayerView = basePage as VideoPlayerView;
			oVGnJdHiFOJD6HkOCEU.D35lls5iF(HP4bh0HYlNhH02dtQyD.D35lls5iF(videoPlayerView.GridPlayer, HP4bh0HYlNhH02dtQyD.xGDHg4mrX2), videoPlayerView.FFMEVideoView, oVGnJdHiFOJD6HkOCEU.iaiHQIukm3);
			videoPlayerView.FFMEVideoView = null;
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.Ro8HXUS3H5);
			kbGuAqq0wIxs9tTnF0.D35lls5iF(videoPlayerView.ViewModel, null, kbGuAqq0wIxs9tTnF0.fSLJ2EGhO);
			Unosquare.FFME.MediaElement mediaElement6 = new Unosquare.FFME.MediaElement();
			KrwGbEH22h4JrmXnrNO.D35lls5iF(mediaElement6, p5s3FJHfrZC71uwBS7V.D35lls5iF(p5s3FJHfrZC71uwBS7V.UgDHFqlDQF), KrwGbEH22h4JrmXnrNO.a8THZSVKbt);
			bd2g87HjdsPQhE4qXsh.D35lls5iF(mediaElement6, MediaPlaybackState.Play, bd2g87HjdsPQhE4qXsh.Ur2HydBCcL);
			videoPlayerView.FFMEVideoView = mediaElement6;
			vbvGsRHqNSgTAE8CCJP.D35lls5iF(videoPlayerView.FFMEVideoView, -1, vbvGsRHqNSgTAE8CCJP.MygHJ9tVSo);
			kbGuAqq0wIxs9tTnF0.D35lls5iF(videoPlayerView.ViewModel, videoPlayerView.FFMEVideoView, kbGuAqq0wIxs9tTnF0.fSLJ2EGhO);
			qK9g1jHbhC1TNyMkwZd.D35lls5iF(HP4bh0HYlNhH02dtQyD.D35lls5iF(videoPlayerView.GridPlayer, HP4bh0HYlNhH02dtQyD.xGDHg4mrX2), videoPlayerView.FFMEVideoView, qK9g1jHbhC1TNyMkwZd.q3eHWViHZH);
			AJv70itXcdnxnNYjSQ.D35lls5iF(videoPlayerView, AJv70itXcdnxnNYjSQ.xaoH5lgcul);
			kbGuAqq0wIxs9tTnF0.D35lls5iF(u3rKUFWXnFniIaN34B.D35lls5iF(videoPlayerView, u3rKUFWXnFniIaN34B.tEHHzES4xG), videoPlayerView.FFMEVideoView, kbGuAqq0wIxs9tTnF0.awez3yikQ);
			if (NRXQg219ahcEpkUqugy.D35lls5iF(kNkAAf1oS8EBBquLcPe.D35lls5iF(videoPlayerView.ViewModel, kNkAAf1oS8EBBquLcPe.HUa1lHiUNn), NRXQg219ahcEpkUqugy.J4U1D5ws5N) != null)
			{
				BbUsgb1HAFAD1uIhrpH.D35lls5iF(videoPlayerView.ViewModel, NRXQg219ahcEpkUqugy.D35lls5iF(kNkAAf1oS8EBBquLcPe.D35lls5iF(videoPlayerView.ViewModel, kNkAAf1oS8EBBquLcPe.HUa1lHiUNn), NRXQg219ahcEpkUqugy.J4U1D5ws5N), BbUsgb1HAFAD1uIhrpH.NMM11NbRt6);
			}
			break;
		}
		case ApplicationPage.ShowMoviePage:
		{
			MainPlayerViewModel mainPlayerViewModel6 = MI3oOiHCZASyM6ERRUP.D35lls5iF(TiDjTli5MS, MI3oOiHCZASyM6ERRUP.h0JHmOSEFB);
			if (mainPlayerViewModel6 != null)
			{
				Unosquare.FFME.MediaElement mediaElement = mainPlayerViewModel6.MediaElement;
				if (((mediaElement != null) ? new bool?(hjMnupQVVDlRZAYQJC.D35lls5iF(mediaElement, hjMnupQVVDlRZAYQJC.sXPHxO1Jaq)) : ((bool?)null)) == true)
				{
					MI3oOiHCZASyM6ERRUP.D35lls5iF(TiDjTli5MS, MI3oOiHCZASyM6ERRUP.h0JHmOSEFB).OnPauseCommandExcuteAsync();
				}
			}
			QnJnl7fVDKI4mA6voc.D35lls5iF(TiDjTli5MS, false, QnJnl7fVDKI4mA6voc.nOjHh2nnTx);
			eudj8kJIVv = false;
			QnJnl7fVDKI4mA6voc.D35lls5iF(TiDjTli5MS, false, QnJnl7fVDKI4mA6voc.Aq9HvCxSeV);
			MovieFFMEPlayer movieFFMEPlayer = basePage as MovieFFMEPlayer;
			oVGnJdHiFOJD6HkOCEU.D35lls5iF(HP4bh0HYlNhH02dtQyD.D35lls5iF(movieFFMEPlayer.GridPlayer, HP4bh0HYlNhH02dtQyD.xGDHg4mrX2), movieFFMEPlayer.Media, oVGnJdHiFOJD6HkOCEU.iaiHQIukm3);
			movieFFMEPlayer.Media = null;
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.Ro8HXUS3H5);
			movieFFMEPlayer.ViewModel.MediaElement = null;
			Unosquare.FFME.MediaElement mediaElement2 = new Unosquare.FFME.MediaElement();
			KrwGbEH22h4JrmXnrNO.D35lls5iF(mediaElement2, p5s3FJHfrZC71uwBS7V.D35lls5iF(p5s3FJHfrZC71uwBS7V.UgDHFqlDQF), KrwGbEH22h4JrmXnrNO.a8THZSVKbt);
			bd2g87HjdsPQhE4qXsh.D35lls5iF(mediaElement2, MediaPlaybackState.Play, bd2g87HjdsPQhE4qXsh.Ur2HydBCcL);
			movieFFMEPlayer.Media = mediaElement2;
			vbvGsRHqNSgTAE8CCJP.D35lls5iF(movieFFMEPlayer.Media, -1, vbvGsRHqNSgTAE8CCJP.MygHJ9tVSo);
			movieFFMEPlayer.ViewModel.MediaElement = movieFFMEPlayer.Media;
			qK9g1jHbhC1TNyMkwZd.D35lls5iF(HP4bh0HYlNhH02dtQyD.D35lls5iF(movieFFMEPlayer.GridPlayer, HP4bh0HYlNhH02dtQyD.xGDHg4mrX2), movieFFMEPlayer.Media, qK9g1jHbhC1TNyMkwZd.q3eHWViHZH);
			AJv70itXcdnxnNYjSQ.D35lls5iF(movieFFMEPlayer, AJv70itXcdnxnNYjSQ.es818afsQF);
			fbbBEQ1ntYrLWqHlP2L.D35lls5iF(movieFFMEPlayer, fbbBEQ1ntYrLWqHlP2L.L6c13IkA8q).InitializeMediaEvents(movieFFMEPlayer.Media);
			break;
		}
		case ApplicationPage.YoutubePlayer:
		{
			MainPlayerViewModel mainPlayerViewModel11 = MI3oOiHCZASyM6ERRUP.D35lls5iF(TiDjTli5MS, MI3oOiHCZASyM6ERRUP.h0JHmOSEFB);
			if (mainPlayerViewModel11 != null)
			{
				Unosquare.FFME.MediaElement mediaElement7 = mainPlayerViewModel11.MediaElement;
				if (((mediaElement7 != null) ? new bool?(hjMnupQVVDlRZAYQJC.D35lls5iF(mediaElement7, hjMnupQVVDlRZAYQJC.sXPHxO1Jaq)) : ((bool?)null)) == true)
				{
					MI3oOiHCZASyM6ERRUP.D35lls5iF(TiDjTli5MS, MI3oOiHCZASyM6ERRUP.h0JHmOSEFB).OnPauseCommandExcuteAsync();
				}
			}
			QnJnl7fVDKI4mA6voc.D35lls5iF(TiDjTli5MS, false, QnJnl7fVDKI4mA6voc.nOjHh2nnTx);
			eudj8kJIVv = false;
			QnJnl7fVDKI4mA6voc.D35lls5iF(TiDjTli5MS, false, QnJnl7fVDKI4mA6voc.Aq9HvCxSeV);
			YtFFMEPlayer ytFFMEPlayer = basePage as YtFFMEPlayer;
			oVGnJdHiFOJD6HkOCEU.D35lls5iF(HP4bh0HYlNhH02dtQyD.D35lls5iF(ytFFMEPlayer.GridPlayer, HP4bh0HYlNhH02dtQyD.xGDHg4mrX2), ytFFMEPlayer.Media, oVGnJdHiFOJD6HkOCEU.iaiHQIukm3);
			ytFFMEPlayer.Media = null;
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.Ro8HXUS3H5);
			ytFFMEPlayer.ViewModel.MediaElement = null;
			Unosquare.FFME.MediaElement mediaElement8 = new Unosquare.FFME.MediaElement();
			KrwGbEH22h4JrmXnrNO.D35lls5iF(mediaElement8, p5s3FJHfrZC71uwBS7V.D35lls5iF(p5s3FJHfrZC71uwBS7V.UgDHFqlDQF), KrwGbEH22h4JrmXnrNO.a8THZSVKbt);
			bd2g87HjdsPQhE4qXsh.D35lls5iF(mediaElement8, MediaPlaybackState.Play, bd2g87HjdsPQhE4qXsh.Ur2HydBCcL);
			ytFFMEPlayer.Media = mediaElement8;
			vbvGsRHqNSgTAE8CCJP.D35lls5iF(ytFFMEPlayer.Media, -1, vbvGsRHqNSgTAE8CCJP.MygHJ9tVSo);
			ytFFMEPlayer.ViewModel.MediaElement = ytFFMEPlayer.Media;
			qK9g1jHbhC1TNyMkwZd.D35lls5iF(HP4bh0HYlNhH02dtQyD.D35lls5iF(ytFFMEPlayer.GridPlayer, HP4bh0HYlNhH02dtQyD.xGDHg4mrX2), ytFFMEPlayer.Media, qK9g1jHbhC1TNyMkwZd.q3eHWViHZH);
			AJv70itXcdnxnNYjSQ.D35lls5iF(ytFFMEPlayer, AJv70itXcdnxnNYjSQ.y491TWyNeJ);
			tApScD14t76npcHoQ1x.D35lls5iF(ytFFMEPlayer, tApScD14t76npcHoQ1x.M6N1LHfRLy);
			break;
		}
		case ApplicationPage.ShowSeriesPage:
		{
			MainPlayerViewModel mainPlayerViewModel8 = MI3oOiHCZASyM6ERRUP.D35lls5iF(TiDjTli5MS, MI3oOiHCZASyM6ERRUP.h0JHmOSEFB);
			if (mainPlayerViewModel8 != null)
			{
				Unosquare.FFME.MediaElement mediaElement3 = mainPlayerViewModel8.MediaElement;
				if (((mediaElement3 != null) ? new bool?(hjMnupQVVDlRZAYQJC.D35lls5iF(mediaElement3, hjMnupQVVDlRZAYQJC.sXPHxO1Jaq)) : ((bool?)null)) == true)
				{
					MI3oOiHCZASyM6ERRUP.D35lls5iF(TiDjTli5MS, MI3oOiHCZASyM6ERRUP.h0JHmOSEFB).OnPauseCommandExcuteAsync();
				}
			}
			QnJnl7fVDKI4mA6voc.D35lls5iF(TiDjTli5MS, false, QnJnl7fVDKI4mA6voc.nOjHh2nnTx);
			eudj8kJIVv = false;
			QnJnl7fVDKI4mA6voc.D35lls5iF(TiDjTli5MS, false, QnJnl7fVDKI4mA6voc.Aq9HvCxSeV);
			SeriesFFMEPlayer seriesFFMEPlayer = basePage as SeriesFFMEPlayer;
			oVGnJdHiFOJD6HkOCEU.D35lls5iF(HP4bh0HYlNhH02dtQyD.D35lls5iF(seriesFFMEPlayer.GridPlayer, HP4bh0HYlNhH02dtQyD.xGDHg4mrX2), seriesFFMEPlayer.Media, oVGnJdHiFOJD6HkOCEU.iaiHQIukm3);
			seriesFFMEPlayer.Media = null;
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.Ro8HXUS3H5);
			seriesFFMEPlayer.ViewModel.MediaElement = null;
			Unosquare.FFME.MediaElement mediaElement4 = new Unosquare.FFME.MediaElement();
			KrwGbEH22h4JrmXnrNO.D35lls5iF(mediaElement4, p5s3FJHfrZC71uwBS7V.D35lls5iF(p5s3FJHfrZC71uwBS7V.UgDHFqlDQF), KrwGbEH22h4JrmXnrNO.a8THZSVKbt);
			bd2g87HjdsPQhE4qXsh.D35lls5iF(mediaElement4, MediaPlaybackState.Play, bd2g87HjdsPQhE4qXsh.Ur2HydBCcL);
			seriesFFMEPlayer.Media = mediaElement4;
			vbvGsRHqNSgTAE8CCJP.D35lls5iF(seriesFFMEPlayer.Media, -1, vbvGsRHqNSgTAE8CCJP.MygHJ9tVSo);
			seriesFFMEPlayer.ViewModel.MediaElement = seriesFFMEPlayer.Media;
			qK9g1jHbhC1TNyMkwZd.D35lls5iF(HP4bh0HYlNhH02dtQyD.D35lls5iF(seriesFFMEPlayer.GridPlayer, HP4bh0HYlNhH02dtQyD.xGDHg4mrX2), seriesFFMEPlayer.Media, qK9g1jHbhC1TNyMkwZd.q3eHWViHZH);
			tApScD14t76npcHoQ1x.D35lls5iF(seriesFFMEPlayer, tApScD14t76npcHoQ1x.DCl1EpZOxh);
			LixYso1BenICT3qwH1x.D35lls5iF(seriesFFMEPlayer, LixYso1BenICT3qwH1x.naW10efAJE).InitializeMediaEvents(seriesFFMEPlayer.Media);
			if (seriesFFMEPlayer.ViewModel.PlayerPlaylistViewModel.SelectedItem != null)
			{
				seriesFFMEPlayer.ViewModel.OnOpenCommandExcuteAsync(seriesFFMEPlayer.ViewModel.PlayerPlaylistViewModel.SelectedItem);
			}
			break;
		}
		case ApplicationPage.PlayListDetailsView:
			QnJnl7fVDKI4mA6voc.D35lls5iF(TiDjTli5MS, false, QnJnl7fVDKI4mA6voc.nOjHh2nnTx);
			eudj8kJIVv = false;
			QnJnl7fVDKI4mA6voc.D35lls5iF(TiDjTli5MS, false, QnJnl7fVDKI4mA6voc.Aq9HvCxSeV);
			break;
		case ApplicationPage.MyMoviePage:
		case ApplicationPage.ProfilePage:
		case ApplicationPage.SeriesDetailsPage:
		case ApplicationPage.MovieDetailsPage:
		{
			MainPlayerViewModel mainPlayerViewModel13 = MI3oOiHCZASyM6ERRUP.D35lls5iF(TiDjTli5MS, MI3oOiHCZASyM6ERRUP.h0JHmOSEFB);
			if (((mainPlayerViewModel13 != null) ? I7R9FpHuQv8JsJPdFiv.D35lls5iF(mainPlayerViewModel13, I7R9FpHuQv8JsJPdFiv.PTqHPF39pv) : null) != null)
			{
				QnJnl7fVDKI4mA6voc.D35lls5iF(TiDjTli5MS, true, QnJnl7fVDKI4mA6voc.dUxHsdI86U);
			}
			QnJnl7fVDKI4mA6voc.D35lls5iF(TiDjTli5MS, false, QnJnl7fVDKI4mA6voc.nOjHh2nnTx);
			eudj8kJIVv = false;
			QnJnl7fVDKI4mA6voc.D35lls5iF(TiDjTli5MS, false, QnJnl7fVDKI4mA6voc.Aq9HvCxSeV);
			break;
		}
		case ApplicationPage.RadioPage:
		{
			MainPlayerViewModel mainPlayerViewModel4 = MI3oOiHCZASyM6ERRUP.D35lls5iF(TiDjTli5MS, MI3oOiHCZASyM6ERRUP.h0JHmOSEFB);
			if (((mainPlayerViewModel4 != null) ? I7R9FpHuQv8JsJPdFiv.D35lls5iF(mainPlayerViewModel4, I7R9FpHuQv8JsJPdFiv.PTqHPF39pv) : null) != null)
			{
				QnJnl7fVDKI4mA6voc.D35lls5iF(TiDjTli5MS, true, QnJnl7fVDKI4mA6voc.dUxHsdI86U);
			}
			QnJnl7fVDKI4mA6voc.D35lls5iF(TiDjTli5MS, false, QnJnl7fVDKI4mA6voc.nOjHh2nnTx);
			eudj8kJIVv = false;
			QnJnl7fVDKI4mA6voc.D35lls5iF(TiDjTli5MS, false, QnJnl7fVDKI4mA6voc.Aq9HvCxSeV);
			break;
		}
		case ApplicationPage.ArtistDetailsView:
		{
			MainPlayerViewModel mainPlayerViewModel9 = MI3oOiHCZASyM6ERRUP.D35lls5iF(TiDjTli5MS, MI3oOiHCZASyM6ERRUP.h0JHmOSEFB);
			if (((mainPlayerViewModel9 != null) ? I7R9FpHuQv8JsJPdFiv.D35lls5iF(mainPlayerViewModel9, I7R9FpHuQv8JsJPdFiv.PTqHPF39pv) : null) != null)
			{
				QnJnl7fVDKI4mA6voc.D35lls5iF(TiDjTli5MS, true, QnJnl7fVDKI4mA6voc.dUxHsdI86U);
			}
			QnJnl7fVDKI4mA6voc.D35lls5iF(TiDjTli5MS, false, QnJnl7fVDKI4mA6voc.nOjHh2nnTx);
			eudj8kJIVv = false;
			QnJnl7fVDKI4mA6voc.D35lls5iF(TiDjTli5MS, false, QnJnl7fVDKI4mA6voc.Aq9HvCxSeV);
			break;
		}
		case ApplicationPage.Movies:
		{
			MainPlayerViewModel mainPlayerViewModel2 = MI3oOiHCZASyM6ERRUP.D35lls5iF(TiDjTli5MS, MI3oOiHCZASyM6ERRUP.h0JHmOSEFB);
			if (((mainPlayerViewModel2 != null) ? I7R9FpHuQv8JsJPdFiv.D35lls5iF(mainPlayerViewModel2, I7R9FpHuQv8JsJPdFiv.PTqHPF39pv) : null) != null)
			{
				QnJnl7fVDKI4mA6voc.D35lls5iF(TiDjTli5MS, true, QnJnl7fVDKI4mA6voc.dUxHsdI86U);
			}
			QnJnl7fVDKI4mA6voc.D35lls5iF(TiDjTli5MS, true, QnJnl7fVDKI4mA6voc.nOjHh2nnTx);
			eudj8kJIVv = false;
			QnJnl7fVDKI4mA6voc.D35lls5iF(TiDjTli5MS, false, QnJnl7fVDKI4mA6voc.Aq9HvCxSeV);
			MoviesViewModel moviesViewModel = RAspAbuaTQFU0nSRiQ.D35lls5iF(basePage, RAspAbuaTQFU0nSRiQ.IoP1rAL1GD) as MoviesViewModel;
			qni3xrDkAJ3vF35eMav.D35lls5iF(TiDjTli5MS, wq2usy8gNndpuTw5mR.D35lls5iF(moviesViewModel, wq2usy8gNndpuTw5mR.OqU1e3BWB8), qni3xrDkAJ3vF35eMav.T2S1GdgeU8);
			break;
		}
		case ApplicationPage.Series:
		{
			MainPlayerViewModel mainPlayerViewModel5 = MI3oOiHCZASyM6ERRUP.D35lls5iF(TiDjTli5MS, MI3oOiHCZASyM6ERRUP.h0JHmOSEFB);
			if (((mainPlayerViewModel5 != null) ? I7R9FpHuQv8JsJPdFiv.D35lls5iF(mainPlayerViewModel5, I7R9FpHuQv8JsJPdFiv.PTqHPF39pv) : null) != null)
			{
				QnJnl7fVDKI4mA6voc.D35lls5iF(TiDjTli5MS, true, QnJnl7fVDKI4mA6voc.dUxHsdI86U);
			}
			QnJnl7fVDKI4mA6voc.D35lls5iF(TiDjTli5MS, true, QnJnl7fVDKI4mA6voc.nOjHh2nnTx);
			eudj8kJIVv = false;
			QnJnl7fVDKI4mA6voc.D35lls5iF(TiDjTli5MS, false, QnJnl7fVDKI4mA6voc.Aq9HvCxSeV);
			SeriesViewModel seriesViewModel = RAspAbuaTQFU0nSRiQ.D35lls5iF(basePage, RAspAbuaTQFU0nSRiQ.IoP1rAL1GD) as SeriesViewModel;
			qni3xrDkAJ3vF35eMav.D35lls5iF(TiDjTli5MS, wq2usy8gNndpuTw5mR.D35lls5iF(seriesViewModel, wq2usy8gNndpuTw5mR.pmN1REf2Mo), qni3xrDkAJ3vF35eMav.T2S1GdgeU8);
			break;
		}
		case ApplicationPage.ShowPage:
		{
			MainPlayerViewModel mainPlayerViewModel12 = MI3oOiHCZASyM6ERRUP.D35lls5iF(TiDjTli5MS, MI3oOiHCZASyM6ERRUP.h0JHmOSEFB);
			if (((mainPlayerViewModel12 != null) ? I7R9FpHuQv8JsJPdFiv.D35lls5iF(mainPlayerViewModel12, I7R9FpHuQv8JsJPdFiv.PTqHPF39pv) : null) != null)
			{
				QnJnl7fVDKI4mA6voc.D35lls5iF(TiDjTli5MS, true, QnJnl7fVDKI4mA6voc.dUxHsdI86U);
			}
			QnJnl7fVDKI4mA6voc.D35lls5iF(TiDjTli5MS, true, QnJnl7fVDKI4mA6voc.nOjHh2nnTx);
			eudj8kJIVv = false;
			QnJnl7fVDKI4mA6voc.D35lls5iF(TiDjTli5MS, false, QnJnl7fVDKI4mA6voc.Aq9HvCxSeV);
			SeriesViewModel seriesViewModel2 = RAspAbuaTQFU0nSRiQ.D35lls5iF(basePage, RAspAbuaTQFU0nSRiQ.IoP1rAL1GD) as SeriesViewModel;
			qni3xrDkAJ3vF35eMav.D35lls5iF(TiDjTli5MS, wq2usy8gNndpuTw5mR.D35lls5iF(seriesViewModel2, wq2usy8gNndpuTw5mR.pmN1REf2Mo), qni3xrDkAJ3vF35eMav.T2S1GdgeU8);
			break;
		}
		case ApplicationPage.Quran:
		{
			MainPlayerViewModel mainPlayerViewModel7 = MI3oOiHCZASyM6ERRUP.D35lls5iF(TiDjTli5MS, MI3oOiHCZASyM6ERRUP.h0JHmOSEFB);
			if (((mainPlayerViewModel7 != null) ? I7R9FpHuQv8JsJPdFiv.D35lls5iF(mainPlayerViewModel7, I7R9FpHuQv8JsJPdFiv.PTqHPF39pv) : null) != null)
			{
				QnJnl7fVDKI4mA6voc.D35lls5iF(TiDjTli5MS, true, QnJnl7fVDKI4mA6voc.dUxHsdI86U);
			}
			QnJnl7fVDKI4mA6voc.D35lls5iF(TiDjTli5MS, true, QnJnl7fVDKI4mA6voc.nOjHh2nnTx);
			eudj8kJIVv = false;
			QnJnl7fVDKI4mA6voc.D35lls5iF(TiDjTli5MS, false, QnJnl7fVDKI4mA6voc.Aq9HvCxSeV);
			RecitatorsViewModel recitatorsViewModel = RAspAbuaTQFU0nSRiQ.D35lls5iF(basePage, RAspAbuaTQFU0nSRiQ.IoP1rAL1GD) as RecitatorsViewModel;
			qni3xrDkAJ3vF35eMav.D35lls5iF(TiDjTli5MS, wq2usy8gNndpuTw5mR.D35lls5iF(recitatorsViewModel, wq2usy8gNndpuTw5mR.jjk1kCTZjW), qni3xrDkAJ3vF35eMav.T2S1GdgeU8);
			break;
		}
		default:
		{
			MainPlayerViewModel mainPlayerViewModel = MI3oOiHCZASyM6ERRUP.D35lls5iF(TiDjTli5MS, MI3oOiHCZASyM6ERRUP.h0JHmOSEFB);
			if (((mainPlayerViewModel != null) ? I7R9FpHuQv8JsJPdFiv.D35lls5iF(mainPlayerViewModel, I7R9FpHuQv8JsJPdFiv.PTqHPF39pv) : null) != null)
			{
				QnJnl7fVDKI4mA6voc.D35lls5iF(TiDjTli5MS, true, QnJnl7fVDKI4mA6voc.dUxHsdI86U);
			}
			QnJnl7fVDKI4mA6voc.D35lls5iF(TiDjTli5MS, true, QnJnl7fVDKI4mA6voc.nOjHh2nnTx);
			eudj8kJIVv = false;
			QnJnl7fVDKI4mA6voc.D35lls5iF(TiDjTli5MS, false, QnJnl7fVDKI4mA6voc.Aq9HvCxSeV);
			break;
		}
		}
	}

	private void mjoj4PG9IT(object P_0, RoutedEventArgs P_1)
	{
		QnJnl7fVDKI4mA6voc.D35lls5iF(RAspAbuaTQFU0nSRiQ.D35lls5iF(this, RAspAbuaTQFU0nSRiQ.G1FymcVoT) as HomeViewModel, true, QnJnl7fVDKI4mA6voc.Aq9HvCxSeV);
	}

	private void WkMjBeRx1V(object P_0, MouseWheelEventArgs P_1)
	{
		mAdJWQ9yhneCbEXlGMc.D35lls5iF(MyScrollViewer, bATk1clKMSyO8g9EVbN.D35lls5iF(MyScrollViewer, bATk1clKMSyO8g9EVbN.z6w1v72wsS) - (double)m9MGZR7k2RmVqYXYS5.D35lls5iF(P_1, m9MGZR7k2RmVqYXYS5.BoXHlIwNQk), mAdJWQ9yhneCbEXlGMc.HXW1ApOOWD);
	}

	private void FnajD9Tdr7()
	{
		bHOmLK93DudIdGBrb75.D35lls5iF(OnMediaFFmpegMessageLogged, bHOmLK93DudIdGBrb75.Fod9TIsSiB);
		PaIS6u94vkelmQi5rj0.D35lls5iF(Media, hHJjI2XBZj, PaIS6u94vkelmQi5rj0.MEx9LXd1lc);
		i3gnNI9Eg29lNWhhmj9.D35lls5iF(Media, PjajPTt6Hf, i3gnNI9Eg29lNWhhmj9.x0y9BgXsjM);
		qIyXdQ90W8ud3wp2ybv.D35lls5iF(Media, zJ6jqamlkl, qIyXdQ90W8ud3wp2ybv.G9b9r6c2Bl);
		XeTMat9eHdgUsPwyBUr.D35lls5iF(Media, OnMediaOpened, XeTMat9eHdgUsPwyBUr.xeJ9GY5CYT);
		ytk50glr3dmeojxPvdr.D35lls5iF(Media, OnMediaReady, ytk50glr3dmeojxPvdr.VLo9RbyDNh);
		ytk50glr3dmeojxPvdr.D35lls5iF(Media, OnMediaClosed, ytk50glr3dmeojxPvdr.KQE9kKpkPQ);
		qIyXdQ90W8ud3wp2ybv.D35lls5iF(Media, OnMediaChanging, qIyXdQ90W8ud3wp2ybv.BuQ9vYnSId);
		ytk50glr3dmeojxPvdr.D35lls5iF(Media, OnAudioDeviceStopped, ytk50glr3dmeojxPvdr.hxb9lGDlo9);
		XeTMat9eHdgUsPwyBUr.D35lls5iF(Media, OnMediaChanged, XeTMat9eHdgUsPwyBUr.fVH9ALNi6D);
		C0UEi896TGi2A8w1c4U.D35lls5iF(Media, OnMediaFailed, C0UEi896TGi2A8w1c4U.ta09pyJDvh);
		ytk50glr3dmeojxPvdr.D35lls5iF(Media, op0jd8mPDG, ytk50glr3dmeojxPvdr.Qv416M3eAn);
	}

	[AsyncStateMachine(typeof(_003COnMediaEnded_003Ed__16))]
	private void op0jd8mPDG(object P_0, EventArgs P_1)
	{
		_003COnMediaEnded_003Ed__16 stateMachine = default(_003COnMediaEnded_003Ed__16);
		stateMachine._003C_003Et__builder = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	protected void OnMediaMessageLogged(object sender, MediaLogMessageEventArgs e)
	{
	}

	protected void OnMediaFFmpegMessageLogged(object sender, MediaLogMessageEventArgs e)
	{
	}

	protected void OnMediaFailed(object sender, MediaFailedEventArgs e)
	{
	}

	private void PjajPTt6Hf(object P_0, MediaInitializingEventArgs P_1)
	{
		if (RJdEUw97wnVnGsBRmDG.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(P_1, wq2usy8gNndpuTw5mR.Jgy9VSHVYB), iFZ5je3XFYKwkvcE5D.D35lls5iF(458, iFZ5je3XFYKwkvcE5D.N06TeK0ao), StringComparison.OrdinalIgnoreCase, RJdEUw97wnVnGsBRmDG.y949cPsE49))
		{
			dq1xgG9KNu7RfbYkGMV.D35lls5iF(uIIaqd9MWbmAhTXPYKL.D35lls5iF(P_1, uIIaqd9MWbmAhTXPYKL.a3y9SGZNdS), dq1xgG9KNu7RfbYkGMV.xWD9NR1CqV)[iFZ5je3XFYKwkvcE5D.D35lls5iF(474, iFZ5je3XFYKwkvcE5D.N06TeK0ao)] = iFZ5je3XFYKwkvcE5D.D35lls5iF(506, iFZ5je3XFYKwkvcE5D.N06TeK0ao);
			QnJnl7fVDKI4mA6voc.D35lls5iF(nXvH3V9ON1PquOtoxuq.D35lls5iF(uIIaqd9MWbmAhTXPYKL.D35lls5iF(P_1, uIIaqd9MWbmAhTXPYKL.a3y9SGZNdS), nXvH3V9ON1PquOtoxuq.g2g9uaXBwW), true, QnJnl7fVDKI4mA6voc.J0Z9Ppmjjt);
			vQKA0r9sJ1kArsIHc16.D35lls5iF(nXvH3V9ON1PquOtoxuq.D35lls5iF(uIIaqd9MWbmAhTXPYKL.D35lls5iF(P_1, uIIaqd9MWbmAhTXPYKL.a3y9SGZNdS), nXvH3V9ON1PquOtoxuq.g2g9uaXBwW), 8192, vQKA0r9sJ1kArsIHc16.km39hJJ5mo);
			AKwYZ1lE8mnNaTGlMo6.D35lls5iF(nXvH3V9ON1PquOtoxuq.D35lls5iF(uIIaqd9MWbmAhTXPYKL.D35lls5iF(P_1, uIIaqd9MWbmAhTXPYKL.a3y9SGZNdS), nXvH3V9ON1PquOtoxuq.g2g9uaXBwW), aNJrrPl4soK5NDOndiN.D35lls5iF(1.0, aNJrrPl4soK5NDOndiN.Ca9lahqtKS), AKwYZ1lE8mnNaTGlMo6.HSE9xIihv0);
			vQKA0r9sJ1kArsIHc16.D35lls5iF(nXvH3V9ON1PquOtoxuq.D35lls5iF(uIIaqd9MWbmAhTXPYKL.D35lls5iF(P_1, uIIaqd9MWbmAhTXPYKL.a3y9SGZNdS), nXvH3V9ON1PquOtoxuq.g2g9uaXBwW), 8192, vQKA0r9sJ1kArsIHc16.Ebr9YCG3u1);
		}
	}

	private void zJ6jqamlkl(object P_0, MediaOpeningEventArgs P_1)
	{
		_003C_003Ec__DisplayClass21_0 CS_0024_003C_003E8__locals13 = new _003C_003Ec__DisplayClass21_0();
		CS_0024_003C_003E8__locals13.d7eT3YKnu1 = P_0 as Unosquare.FFME.MediaElement;
		QnJnl7fVDKI4mA6voc.D35lls5iF(YQF0kW9goqSdXoWtJAF.D35lls5iF(P_1, YQF0kW9goqSdXoWtJAF.XRw9ikEf4n), S1a0wT9Ixre9OpDny8h.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(Pu8ZkM9Q72E1xo0KU8s.D35lls5iF(P_1, Pu8ZkM9Q72E1xo0KU8s.mf79X0XhAB), wq2usy8gNndpuTw5mR.wly9fwaPxr), iFZ5je3XFYKwkvcE5D.D35lls5iF(516, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO) || VMs7lU9URBMKdJRC1h1.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(Pu8ZkM9Q72E1xo0KU8s.D35lls5iF(P_1, Pu8ZkM9Q72E1xo0KU8s.mf79X0XhAB), wq2usy8gNndpuTw5mR.NVF92wcVcL), iFZ5je3XFYKwkvcE5D.D35lls5iF(546, iFZ5je3XFYKwkvcE5D.N06TeK0ao), VMs7lU9URBMKdJRC1h1.HFs9ZRW5q1), QnJnl7fVDKI4mA6voc.b6Y9jnPMS4);
		mAdJWQ9yhneCbEXlGMc.D35lls5iF(YQF0kW9goqSdXoWtJAF.D35lls5iF(P_1, YQF0kW9goqSdXoWtJAF.XRw9ikEf4n), S1a0wT9Ixre9OpDny8h.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(Pu8ZkM9Q72E1xo0KU8s.D35lls5iF(P_1, Pu8ZkM9Q72E1xo0KU8s.mf79X0XhAB), wq2usy8gNndpuTw5mR.wly9fwaPxr), iFZ5je3XFYKwkvcE5D.D35lls5iF(516, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO) ? 0.0 : 0.5, mAdJWQ9yhneCbEXlGMc.BP19qeiSg6);
		QnJnl7fVDKI4mA6voc.D35lls5iF(q1Gx2v9JbW9cOXEmWet.D35lls5iF(Media, q1Gx2v9JbW9cOXEmWet.adR9bl47sF), hjMnupQVVDlRZAYQJC.D35lls5iF(YQF0kW9goqSdXoWtJAF.D35lls5iF(P_1, YQF0kW9goqSdXoWtJAF.XRw9ikEf4n), hjMnupQVVDlRZAYQJC.xuq9WWJfIB) || RJdEUw97wnVnGsBRmDG.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(Pu8ZkM9Q72E1xo0KU8s.D35lls5iF(P_1, Pu8ZkM9Q72E1xo0KU8s.mf79X0XhAB), wq2usy8gNndpuTw5mR.NVF92wcVcL), iFZ5je3XFYKwkvcE5D.D35lls5iF(570, iFZ5je3XFYKwkvcE5D.N06TeK0ao), StringComparison.OrdinalIgnoreCase, RJdEUw97wnVnGsBRmDG.Omd951BO6P), QnJnl7fVDKI4mA6voc.xcM9zZ9GfC);
		vQKA0r9sJ1kArsIHc16.D35lls5iF(q1Gx2v9JbW9cOXEmWet.D35lls5iF(CS_0024_003C_003E8__locals13.d7eT3YKnu1, q1Gx2v9JbW9cOXEmWet.adR9bl47sF), 0, vQKA0r9sJ1kArsIHc16.U5RDoantIq);
		_ = string.Empty;
		try
		{
			Uri uri = new Uri(wq2usy8gNndpuTw5mR.D35lls5iF(Pu8ZkM9Q72E1xo0KU8s.D35lls5iF(P_1, Pu8ZkM9Q72E1xo0KU8s.mf79X0XhAB), wq2usy8gNndpuTw5mR.NVF92wcVcL));
			if (!hjMnupQVVDlRZAYQJC.D35lls5iF(uri, hjMnupQVVDlRZAYQJC.BPnDlBRbx2) && !hjMnupQVVDlRZAYQJC.D35lls5iF(uri, hjMnupQVVDlRZAYQJC.QNSD9EFv9p))
			{
				_ = string.Empty;
			}
			else
			{
				vr2NVdDHkMwed7KwMIr.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(uri, wq2usy8gNndpuTw5mR.xEYDDHV3gk), vr2NVdDHkMwed7KwMIr.a3qD1DVINi);
			}
		}
		catch
		{
		}
		CS_0024_003C_003E8__locals13.dl6TmAN7Zj = nrSOHAD8YrC91Hd87Ly.D35lls5iF(YQF0kW9goqSdXoWtJAF.D35lls5iF(P_1, YQF0kW9goqSdXoWtJAF.XRw9ikEf4n), nrSOHAD8YrC91Hd87Ly.EaoDno9rGj);
		if (CS_0024_003C_003E8__locals13.dl6TmAN7Zj == null)
		{
			return;
		}
		AVHWDeviceType[] array = new AVHWDeviceType[2]
		{
			AVHWDeviceType.AV_HWDEVICE_TYPE_DXVA2,
			AVHWDeviceType.AV_HWDEVICE_TYPE_D3D11VA
		};
		if (bATk1clKMSyO8g9EVbN.D35lls5iF(CS_0024_003C_003E8__locals13.dl6TmAN7Zj, bATk1clKMSyO8g9EVbN.CcVD3lb0hu) <= 30.0)
		{
			AVHWDeviceType[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				_003C_003Ec__DisplayClass21_1 CS_0024_003C_003E8__locals11 = new _003C_003Ec__DisplayClass21_1();
				CS_0024_003C_003E8__locals11.qNgTR4Cxyw = array2[i];
				if (MSyPQaDTrfJtr3GUW48.D35lls5iF(CS_0024_003C_003E8__locals13.dl6TmAN7Zj, MSyPQaDTrfJtr3GUW48.ESUD4s2tw8).FirstOrDefault((HardwareDeviceInfo d) => aMnygB67j3N3yuQbSMF.D35lls5iF(d, aMnygB67j3N3yuQbSMF.PKP6cQZX8R) == CS_0024_003C_003E8__locals11.qNgTR4Cxyw) != null)
				{
					OZFi5cDLea4g6MgMYOr.D35lls5iF(YQF0kW9goqSdXoWtJAF.D35lls5iF(P_1, YQF0kW9goqSdXoWtJAF.XRw9ikEf4n), null, OZFi5cDLea4g6MgMYOr.e4mDEqBveZ);
					break;
				}
			}
		}
		StringBuilder stringBuilder = new StringBuilder();
		if (m9MGZR7k2RmVqYXYS5.D35lls5iF(CS_0024_003C_003E8__locals13.dl6TmAN7Zj, m9MGZR7k2RmVqYXYS5.l8vDBfi6TL) > 1080)
		{
			Iqu9Z2D0u6duXqVdeBe.D35lls5iF(stringBuilder, iFZ5je3XFYKwkvcE5D.D35lls5iF(582, iFZ5je3XFYKwkvcE5D.N06TeK0ao), Iqu9Z2D0u6duXqVdeBe.No5DrBqXtD);
		}
		qni3xrDkAJ3vF35eMav.D35lls5iF(YQF0kW9goqSdXoWtJAF.D35lls5iF(P_1, YQF0kW9goqSdXoWtJAF.XRw9ikEf4n), slLC9nDGSMhIcv2FTUB.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(stringBuilder, wq2usy8gNndpuTw5mR.ajcDe8nffb), ',', slLC9nDGSMhIcv2FTUB.yv2DRs3jeV), qni3xrDkAJ3vF35eMav.dmJDvBNs4m);
		Dispatcher obj2 = bRAh8kDAgKIlehXIXku.D35lls5iF(CS_0024_003C_003E8__locals13.d7eT3YKnu1, bRAh8kDAgKIlehXIXku.oESD6ce9jH);
		if (obj2 != null)
		{
			QDm1hrDpKcWfLbL64Vl.D35lls5iF(obj2, delegate
			{
				K8DNce6twv9Np34xpPr.D35lls5iF(CS_0024_003C_003E8__locals13.d7eT3YKnu1, uEUVCI48fycroqgRFqy.D35lls5iF(CS_0024_003C_003E8__locals13.dl6TmAN7Zj, uEUVCI48fycroqgRFqy.hx66UqOmg8) ? CaptionsChannel.CC1 : CaptionsChannel.CCP, K8DNce6twv9Np34xpPr.qtR6VreiE6);
			}, QDm1hrDpKcWfLbL64Vl.cxUDwIkrIx);
		}
	}

	protected void OnMediaOpened(object sender, MediaOpenedEventArgs e)
	{
		try
		{
			if (UFCjkvE5S9.PlayerPlaylistViewModel.SelectedItem != null && UOCWOF1pc2UOe4PjABW.D35lls5iF(UFCjkvE5S9.PlayerPlaylistViewModel.SelectedItem, UOCWOF1pc2UOe4PjABW.TuV1w2E8GR) == PROTV.Abstractions.Common.MediaType.Song)
			{
				Qw4DJ51mcF3L167FXXP.D35lls5iF(AppContainer.Resolve<IHistoryService>(), m9MGZR7k2RmVqYXYS5.D35lls5iF(UFCjkvE5S9.PlayerPlaylistViewModel.SelectedItem, m9MGZR7k2RmVqYXYS5.j871CQO7pP), HistoryType.Song, Qw4DJ51mcF3L167FXXP.A2c1a9DBq6);
			}
		}
		catch
		{
		}
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
			where Up3ObFDSJspBLFTGC8N.D35lls5iF(x.Value, Up3ObFDSJspBLFTGC8N.z70DKvMmSu) == (AVMediaType)PJOjKkBROT
			select x.Value).ToList();
		if (list.Count > 0)
		{
			if (PJOjKkBROT != Unosquare.FFME.Common.MediaType.Video)
			{
				list.Add(null);
			}
			int num;
			switch (PJOjKkBROT)
			{
			default:
				return;
			case Unosquare.FFME.Common.MediaType.Audio:
				num = list.IndexOf(nrSOHAD8YrC91Hd87Ly.D35lls5iF(YQF0kW9goqSdXoWtJAF.D35lls5iF(e, YQF0kW9goqSdXoWtJAF.XRw9ikEf4n), nrSOHAD8YrC91Hd87Ly.kQEDayfkOb));
				break;
			case Unosquare.FFME.Common.MediaType.Video:
				num = list.IndexOf(nrSOHAD8YrC91Hd87Ly.D35lls5iF(YQF0kW9goqSdXoWtJAF.D35lls5iF(e, YQF0kW9goqSdXoWtJAF.XRw9ikEf4n), nrSOHAD8YrC91Hd87Ly.EaoDno9rGj));
				break;
			case Unosquare.FFME.Common.MediaType.Subtitle:
				num = list.IndexOf(nrSOHAD8YrC91Hd87Ly.D35lls5iF(YQF0kW9goqSdXoWtJAF.D35lls5iF(e, YQF0kW9goqSdXoWtJAF.XRw9ikEf4n), nrSOHAD8YrC91Hd87Ly.h1MDIuPtG3));
				break;
			case (Unosquare.FFME.Common.MediaType)2:
				return;
			}
			num++;
			if (num >= list.Count)
			{
				num = 0;
			}
			StreamInfo streamInfo = list[num];
			switch (PJOjKkBROT)
			{
			case Unosquare.FFME.Common.MediaType.Audio:
				zWVKfNDdAAWj4PIoemO.D35lls5iF(YQF0kW9goqSdXoWtJAF.D35lls5iF(e, YQF0kW9goqSdXoWtJAF.XRw9ikEf4n), streamInfo, zWVKfNDdAAWj4PIoemO.iUiDUFofUR);
				break;
			case Unosquare.FFME.Common.MediaType.Video:
				zWVKfNDdAAWj4PIoemO.D35lls5iF(YQF0kW9goqSdXoWtJAF.D35lls5iF(e, YQF0kW9goqSdXoWtJAF.XRw9ikEf4n), streamInfo, zWVKfNDdAAWj4PIoemO.O8xDt8r9Nr);
				break;
			case Unosquare.FFME.Common.MediaType.Subtitle:
				zWVKfNDdAAWj4PIoemO.D35lls5iF(YQF0kW9goqSdXoWtJAF.D35lls5iF(e, YQF0kW9goqSdXoWtJAF.XRw9ikEf4n), streamInfo, zWVKfNDdAAWj4PIoemO.gDnDVRIkpN);
				break;
			case (Unosquare.FFME.Common.MediaType)2:
				break;
			}
		}
	}

	protected void OnMediaChanged(object sender, MediaOpenedEventArgs e)
	{
	}

	[AsyncStateMachine(typeof(_003COnAudioDeviceStopped_003Ed__27))]
	protected void OnAudioDeviceStopped(object sender, EventArgs e)
	{
		_003COnAudioDeviceStopped_003Ed__27 stateMachine = default(_003COnAudioDeviceStopped_003Ed__27);
		stateMachine._003C_003Et__builder = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
		stateMachine.sender = sender;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void hHJjI2XBZj(object P_0, MouseButtonEventArgs P_1)
	{
		if (P_0 != null && GmMLaTD7kV8rq88ZFvR.D35lls5iF(P_0, Media, GmMLaTD7kV8rq88ZFvR.BQ5Dcmx5Pp))
		{
			QnJnl7fVDKI4mA6voc.D35lls5iF(P_1, true, QnJnl7fVDKI4mA6voc.WSpDMQcj8Y);
		}
	}

	protected void OnMediaPositionChanged(object sender, PositionChangedEventArgs e)
	{
	}

	protected void OnMediaStateChanged(object sender, MediaStateChangedEventArgs e)
	{
	}

	private void xu8jVY2xp3(object P_0, RoutedEventArgs P_1)
	{
		HomeViewModel homeViewModel = AppContainer.Resolve<HomeViewModel>();
		ApplicationPage applicationPage = Ad8NmsHKMDNoqEDFjtJ.D35lls5iF(RAspAbuaTQFU0nSRiQ.D35lls5iF(RAspAbuaTQFU0nSRiQ.D35lls5iF(Xlypb0Hnr2C3ydrYEdG.D35lls5iF(homeViewModel, Xlypb0Hnr2C3ydrYEdG.U3Z1IKMGuZ), RAspAbuaTQFU0nSRiQ.u5F1dXRFmB) as Page, RAspAbuaTQFU0nSRiQ.UVfHSpoUCc) as BasePage, Ad8NmsHKMDNoqEDFjtJ.ljhHNvS1WJ);
		if (applicationPage == ApplicationPage.ShowSeriesPage)
		{
			(RAspAbuaTQFU0nSRiQ.D35lls5iF(RAspAbuaTQFU0nSRiQ.D35lls5iF(RAspAbuaTQFU0nSRiQ.D35lls5iF(Xlypb0Hnr2C3ydrYEdG.D35lls5iF(homeViewModel, Xlypb0Hnr2C3ydrYEdG.U3Z1IKMGuZ), RAspAbuaTQFU0nSRiQ.u5F1dXRFmB) as Page, RAspAbuaTQFU0nSRiQ.UVfHSpoUCc) as BasePage, RAspAbuaTQFU0nSRiQ.IoP1rAL1GD) as SereisPlayerViewModel).SaveMediaItem(null);
		}
		else if (applicationPage == ApplicationPage.ShowSeriesPage)
		{
			(RAspAbuaTQFU0nSRiQ.D35lls5iF(RAspAbuaTQFU0nSRiQ.D35lls5iF(RAspAbuaTQFU0nSRiQ.D35lls5iF(Xlypb0Hnr2C3ydrYEdG.D35lls5iF(homeViewModel, Xlypb0Hnr2C3ydrYEdG.U3Z1IKMGuZ), RAspAbuaTQFU0nSRiQ.u5F1dXRFmB) as Page, RAspAbuaTQFU0nSRiQ.UVfHSpoUCc) as BasePage, RAspAbuaTQFU0nSRiQ.IoP1rAL1GD) as MoviePlayerViewModel).SaveMediaItem(null);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "5.0.4.0")]
	public void InitializeComponent()
	{
		if (!RZbjQeZZLy)
		{
			RZbjQeZZLy = true;
			Uri uri = new Uri(iFZ5je3XFYKwkvcE5D.D35lls5iF(1316, iFZ5je3XFYKwkvcE5D.N06TeK0ao), UriKind.Relative);
			TUdx26d4l5VwJTvopv.D35lls5iF(this, uri, TUdx26d4l5VwJTvopv.W3oUN4AKb);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "5.0.4.0")]
	internal Delegate gy4ja6B7QL(Type P_0, string P_1)
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
			Media = (Unosquare.FFME.MediaElement)target;
			break;
		case 2:
			NavigationFrame = (Frame)target;
			break;
		case 3:
			TabbedPannel = (Grid)target;
			break;
		case 4:
			MyScrollViewer = (ScrollViewer)target;
			W73HvvHD4Ka6B2vKd4e.D35lls5iF(MyScrollViewer, WkMjBeRx1V, W73HvvHD4Ka6B2vKd4e.MIbHH5Gk3A);
			break;
		case 5:
			listView = (ListView)target;
			break;
		case 6:
			dp97HSDjYOMxMALpn4D.D35lls5iF((Button)target, mjoj4PG9IT, dp97HSDjYOMxMALpn4D.boI1UheDEc);
			break;
		default:
			RZbjQeZZLy = true;
			break;
		}
	}

	static HomeView()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		Key[] array = new Key[3];
		ODLiVRlRE2AwTHTxA2m.D35lls5iF(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, ODLiVRlRE2AwTHTxA2m.rwklk7wPqp);
		h9ajfNAElv = (Key[])(object)array;
	}

	[CompilerGenerated]
	[AsyncStateMachine(typeof(_003C_003CNavigationFrame_Navigated_003Eb__12_0_003Ed))]
	private Task aowj0FBgZN()
	{
		_003C_003CNavigationFrame_Navigated_003Eb__12_0_003Ed stateMachine = default(_003C_003CNavigationFrame_Navigated_003Eb__12_0_003Ed);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	[CompilerGenerated]
	private bool DLSjGXkET0(KeyValuePair<int, StreamInfo> P_0)
	{
		return Up3ObFDSJspBLFTGC8N.D35lls5iF(P_0.Value, Up3ObFDSJspBLFTGC8N.z70DKvMmSu) == (AVMediaType)PJOjKkBROT;
	}
}
