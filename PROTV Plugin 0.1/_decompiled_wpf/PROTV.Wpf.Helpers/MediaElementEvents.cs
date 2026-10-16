using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;
using FFmpeg.AutoGen;
using HandyControl.Data;
using PROTV.Abstractions.Common;
using PROTV.Abstractions.DataTransferObjects;
using PROTV.Abstractions.Services;
using PROTV.DataAccess;
using PROTV.Wpf.Bootstrap;
using PROTV.Wpf.ViewModels;
using Unosquare.FFME;
using Unosquare.FFME.ClosedCaptions;
using Unosquare.FFME.Common;

namespace PROTV.Wpf.Helpers;

public class MediaElementEvents<T> where T : new()
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnAudioDeviceStopped_003Ed__15 : IAsyncStateMachine
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
				if (sender is MediaElement mediaElement)
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

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass20_0
	{
		public MediaElementEvents<T> _003C_003E4__this;

		public MediaElement media;

		public StreamInfo videoStream;

		public _003C_003Ec__DisplayClass20_0()
		{
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
			base._002Ector();
		}

		internal bool F7tkbMb4PM(HardwareDeviceInfo d)
		{
			return aMnygB67j3N3yuQbSMF.D35lls5iF(d, aMnygB67j3N3yuQbSMF.PKP6cQZX8R) == _003C_003E4__this.FFMEViewModel.AVHWDeviceType;
		}

		internal void qask7m80bK()
		{
			K8DNce6twv9Np34xpPr.D35lls5iF(media, uEUVCI48fycroqgRFqy.D35lls5iF(videoStream, uEUVCI48fycroqgRFqy.hx66UqOmg8) ? CaptionsChannel.CC1 : CaptionsChannel.CCP, K8DNce6twv9Np34xpPr.qtR6VreiE6);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass22_0
	{
		public MoviePosition episode;

		public MediaElementEvents<T> _003C_003E4__this;

		public _003C_003Ec__DisplayClass22_0()
		{
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
			base._002Ector();
		}

		internal bool Fkdk5Un2Wp(bool isConfirmed)
		{
			if (isConfirmed)
			{
				AKwYZ1lE8mnNaTGlMo6.D35lls5iF(_003C_003E4__this.brSG6HeMSj, aNJrrPl4soK5NDOndiN.D35lls5iF(bATk1clKMSyO8g9EVbN.D35lls5iF(episode, bATk1clKMSyO8g9EVbN.yiiEWvK63c), aNJrrPl4soK5NDOndiN.Ca9lahqtKS), AKwYZ1lE8mnNaTGlMo6.DvFpdwo5LV);
			}
			return true;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass22_1
	{
		public SeriesPosition episode;

		public MediaElementEvents<T> _003C_003E4__this;

		public _003C_003Ec__DisplayClass22_1()
		{
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
			base._002Ector();
		}

		internal bool tHKku2kSRf(bool isConfirmed)
		{
			if (isConfirmed)
			{
				AKwYZ1lE8mnNaTGlMo6.D35lls5iF(_003C_003E4__this.brSG6HeMSj, aNJrrPl4soK5NDOndiN.D35lls5iF(bATk1clKMSyO8g9EVbN.D35lls5iF(episode, bATk1clKMSyO8g9EVbN.sSHBpJLQZw), aNJrrPl4soK5NDOndiN.Ca9lahqtKS), AKwYZ1lE8mnNaTGlMo6.DvFpdwo5LV);
			}
			return true;
		}
	}

	private MediaElement brSG6HeMSj;

	private readonly IStoreContext kVoGsqtnOI;

	private Unosquare.FFME.Common.MediaType XarGxHSxGy;

	[CompilerGenerated]
	private FFMEBaseViewModel<T> md0GybPNKG;

	public FFMEBaseViewModel<T> FFMEViewModel
	{
		[CompilerGenerated]
		get
		{
			return md0GybPNKG;
		}
		[CompilerGenerated]
		set
		{
			md0GybPNKG = value;
		}
	}

	public MediaElementEvents(FFMEBaseViewModel<T> fFMEViewModel)
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		XarGxHSxGy = Unosquare.FFME.Common.MediaType.None;
		base._002Ector();
		FFMEViewModel = fFMEViewModel;
		kVoGsqtnOI = AppContainer.Resolve<IStoreContext>();
	}

	public void InitializeMediaEvents(MediaElement media)
	{
		brSG6HeMSj = media;
		bHOmLK93DudIdGBrb75.D35lls5iF(OnMediaFFmpegMessageLogged, bHOmLK93DudIdGBrb75.Fod9TIsSiB);
		PaIS6u94vkelmQi5rj0.D35lls5iF(media, OnMediaDoubleClick, PaIS6u94vkelmQi5rj0.MEx9LXd1lc);
		i3gnNI9Eg29lNWhhmj9.D35lls5iF(media, zHaGAVIOl9, i3gnNI9Eg29lNWhhmj9.x0y9BgXsjM);
		qIyXdQ90W8ud3wp2ybv.D35lls5iF(media, x7QGNsAfdS, qIyXdQ90W8ud3wp2ybv.G9b9r6c2Bl);
		XeTMat9eHdgUsPwyBUr.D35lls5iF(media, OnMediaOpened, XeTMat9eHdgUsPwyBUr.xeJ9GY5CYT);
		ytk50glr3dmeojxPvdr.D35lls5iF(media, OnMediaReady, ytk50glr3dmeojxPvdr.VLo9RbyDNh);
		ytk50glr3dmeojxPvdr.D35lls5iF(media, OnMediaClosed, ytk50glr3dmeojxPvdr.KQE9kKpkPQ);
		Q2oTAJ39TRkEgkqcOHT.D35lls5iF(media, OnMediaMessageLogged, Q2oTAJ39TRkEgkqcOHT.z4P3DY1V4p);
		qIyXdQ90W8ud3wp2ybv.D35lls5iF(media, OnMediaChanging, qIyXdQ90W8ud3wp2ybv.BuQ9vYnSId);
		ytk50glr3dmeojxPvdr.D35lls5iF(media, OnAudioDeviceStopped, ytk50glr3dmeojxPvdr.hxb9lGDlo9);
		XeTMat9eHdgUsPwyBUr.D35lls5iF(media, OnMediaChanged, XeTMat9eHdgUsPwyBUr.fVH9ALNi6D);
		C0UEi896TGi2A8w1c4U.D35lls5iF(media, OnMediaFailed, C0UEi896TGi2A8w1c4U.ta09pyJDvh);
		ytk50glr3dmeojxPvdr.D35lls5iF(media, Wb9GuHwoFZ, ytk50glr3dmeojxPvdr.Qv416M3eAn);
		sL2f5q3HEoK3kXZhkwR.D35lls5iF(media, OnMediaStateChanged, sL2f5q3HEoK3kXZhkwR.gVw31EfBmF);
		s2XNFc38XiiCGfjorVj.D35lls5iF(media, OnMediaPositionChanged, s2XNFc38XiiCGfjorVj.phJ3nuffZf);
	}

	protected void OnMediaFFmpegMessageLogged(object sender, MediaLogMessageEventArgs e)
	{
		if ((tGMrJE9wjDS38eXmODX.D35lls5iF(e, tGMrJE9wjDS38eXmODX.MmY9CRb1AT) == MediaLogMessageType.Warning || tGMrJE9wjDS38eXmODX.D35lls5iF(e, tGMrJE9wjDS38eXmODX.MmY9CRb1AT) == MediaLogMessageType.Error) && (M6ZErPEr2LZyWYpa5O.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(e, wq2usy8gNndpuTw5mR.nlj9mLUBnu), M6ZErPEr2LZyWYpa5O.rg89aHbgYh) || !S1a0wT9Ixre9OpDny8h.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(e, wq2usy8gNndpuTw5mR.nlj9mLUBnu), iFZ5je3XFYKwkvcE5D.D35lls5iF(340, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.l249ddg9vO)) && M6ZErPEr2LZyWYpa5O.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(e, wq2usy8gNndpuTw5mR.nlj9mLUBnu), M6ZErPEr2LZyWYpa5O.rg89aHbgYh) && VMs7lU9URBMKdJRC1h1.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(e, wq2usy8gNndpuTw5mR.nlj9mLUBnu), iFZ5je3XFYKwkvcE5D.D35lls5iF(402, iFZ5je3XFYKwkvcE5D.N06TeK0ao), VMs7lU9URBMKdJRC1h1.p7T9tIfMiJ) && VMs7lU9URBMKdJRC1h1.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(e, wq2usy8gNndpuTw5mR.nlj9mLUBnu), iFZ5je3XFYKwkvcE5D.D35lls5iF(442, iFZ5je3XFYKwkvcE5D.N06TeK0ao), VMs7lU9URBMKdJRC1h1.p7T9tIfMiJ))
		{
			gsYNF433WqUIGma3CNX.D35lls5iF(iFZ5je3XFYKwkvcE5D.D35lls5iF(6902, iFZ5je3XFYKwkvcE5D.N06TeK0ao), "", gsYNF433WqUIGma3CNX.MAY3Ti847u);
		}
	}

	protected void OnMediaDoubleClick(object sender, MouseButtonEventArgs e)
	{
		if (sender != null && GmMLaTD7kV8rq88ZFvR.D35lls5iF(sender, brSG6HeMSj, GmMLaTD7kV8rq88ZFvR.BQ5Dcmx5Pp))
		{
			QnJnl7fVDKI4mA6voc.D35lls5iF(e, true, QnJnl7fVDKI4mA6voc.WSpDMQcj8Y);
			FFMEViewModel.Controller.Isfullscreen = !FFMEViewModel.Controller.Isfullscreen;
		}
	}

	private void Wb9GuHwoFZ(object P_0, EventArgs P_1)
	{
		xLO56JniGyickVjO1Ot.D35lls5iF(Xlypb0Hnr2C3ydrYEdG.D35lls5iF(AppContainer.Resolve<HomeViewModel>(), Xlypb0Hnr2C3ydrYEdG.U3Z1IKMGuZ), xLO56JniGyickVjO1Ot.qdjnQKYWM8);
	}

	protected void OnMediaMessageLogged(object sender, MediaLogMessageEventArgs e)
	{
		tGMrJE9wjDS38eXmODX.D35lls5iF(e, tGMrJE9wjDS38eXmODX.MmY9CRb1AT);
		_ = 4;
	}

	protected void OnMediaFailed(object sender, MediaFailedEventArgs e)
	{
		gsYNF433WqUIGma3CNX.D35lls5iF(iFZ5je3XFYKwkvcE5D.D35lls5iF(6902, iFZ5je3XFYKwkvcE5D.N06TeK0ao), "", gsYNF433WqUIGma3CNX.MAY3Ti847u);
	}

	protected void OnMediaChanged(object sender, MediaOpenedEventArgs e)
	{
	}

	[AsyncStateMachine(typeof(MediaElementEvents<>._003COnAudioDeviceStopped_003Ed__15))]
	protected void OnAudioDeviceStopped(object sender, EventArgs e)
	{
		_003COnAudioDeviceStopped_003Ed__15 stateMachine = default(_003COnAudioDeviceStopped_003Ed__15);
		stateMachine._003C_003Et__builder = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
		stateMachine.sender = sender;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	protected void OnMediaStateChanged(object sender, MediaStateChangedEventArgs e)
	{
	}

	protected void OnMediaPositionChanged(object sender, PositionChangedEventArgs e)
	{
		MediaElement mediaElement = sender as MediaElement;
		if (FFMEViewModel is SereisPlayerViewModel sereisPlayerViewModel)
		{
			TimeSpan timeSpan = moA0183RanLCkEiLXks.D35lls5iF(mediaElement, moA0183RanLCkEiLXks.K3o3krsS6B);
			mAdJWQ9yhneCbEXlGMc.D35lls5iF(sereisPlayerViewModel, LUSRjplVkOtM7DbdDL3.D35lls5iF(ref timeSpan, LUSRjplVkOtM7DbdDL3.LAf3veRADK), mAdJWQ9yhneCbEXlGMc.BcMGbDMxcR);
			timeSpan = XLgPbA36DhJ4A0tFJ41.D35lls5iF(mediaElement, XLgPbA36DhJ4A0tFJ41.tP43pEUL5Y).Value;
			mAdJWQ9yhneCbEXlGMc.D35lls5iF(sereisPlayerViewModel, LUSRjplVkOtM7DbdDL3.D35lls5iF(ref timeSpan, LUSRjplVkOtM7DbdDL3.LAf3veRADK), mAdJWQ9yhneCbEXlGMc.hllGWEhkUF);
		}
		if (FFMEViewModel is MoviePlayerViewModel moviePlayerViewModel)
		{
			TimeSpan timeSpan = moA0183RanLCkEiLXks.D35lls5iF(mediaElement, moA0183RanLCkEiLXks.K3o3krsS6B);
			mAdJWQ9yhneCbEXlGMc.D35lls5iF(moviePlayerViewModel, LUSRjplVkOtM7DbdDL3.D35lls5iF(ref timeSpan, LUSRjplVkOtM7DbdDL3.LAf3veRADK), mAdJWQ9yhneCbEXlGMc.IAaG5XBWKI);
			timeSpan = XLgPbA36DhJ4A0tFJ41.D35lls5iF(mediaElement, XLgPbA36DhJ4A0tFJ41.tP43pEUL5Y).Value;
			mAdJWQ9yhneCbEXlGMc.D35lls5iF(moviePlayerViewModel, LUSRjplVkOtM7DbdDL3.D35lls5iF(ref timeSpan, LUSRjplVkOtM7DbdDL3.LAf3veRADK), mAdJWQ9yhneCbEXlGMc.ayWGzNaDWT);
		}
	}

	protected void OnMediaChanging(object sender, MediaOpeningEventArgs e)
	{
		List<StreamInfo> list = (from x in YrCoj4DChUfyKXuSvMK.D35lls5iF(Pu8ZkM9Q72E1xo0KU8s.D35lls5iF(e, Pu8ZkM9Q72E1xo0KU8s.mf79X0XhAB), YrCoj4DChUfyKXuSvMK.osNDmFEjj6)
			where Up3ObFDSJspBLFTGC8N.D35lls5iF(x.Value, Up3ObFDSJspBLFTGC8N.z70DKvMmSu) == (AVMediaType)XarGxHSxGy
			select x.Value).ToList();
		if (list.Count > 0)
		{
			if (XarGxHSxGy != Unosquare.FFME.Common.MediaType.Video)
			{
				list.Add(null);
			}
			int num;
			switch (XarGxHSxGy)
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
			switch (XarGxHSxGy)
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

	private void zHaGAVIOl9(object P_0, MediaInitializingEventArgs P_1)
	{
		if (RJdEUw97wnVnGsBRmDG.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(P_1, wq2usy8gNndpuTw5mR.Jgy9VSHVYB), iFZ5je3XFYKwkvcE5D.D35lls5iF(458, iFZ5je3XFYKwkvcE5D.N06TeK0ao), StringComparison.OrdinalIgnoreCase, RJdEUw97wnVnGsBRmDG.y949cPsE49))
		{
			dq1xgG9KNu7RfbYkGMV.D35lls5iF(uIIaqd9MWbmAhTXPYKL.D35lls5iF(P_1, uIIaqd9MWbmAhTXPYKL.a3y9SGZNdS), dq1xgG9KNu7RfbYkGMV.xWD9NR1CqV)[iFZ5je3XFYKwkvcE5D.D35lls5iF(474, iFZ5je3XFYKwkvcE5D.N06TeK0ao)] = iFZ5je3XFYKwkvcE5D.D35lls5iF(3966, iFZ5je3XFYKwkvcE5D.N06TeK0ao);
			QnJnl7fVDKI4mA6voc.D35lls5iF(nXvH3V9ON1PquOtoxuq.D35lls5iF(uIIaqd9MWbmAhTXPYKL.D35lls5iF(P_1, uIIaqd9MWbmAhTXPYKL.a3y9SGZNdS), nXvH3V9ON1PquOtoxuq.g2g9uaXBwW), !FFMEViewModel.StreamHasBuffer, QnJnl7fVDKI4mA6voc.J0Z9Ppmjjt);
		}
		if (RJdEUw97wnVnGsBRmDG.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(P_1, wq2usy8gNndpuTw5mR.Jgy9VSHVYB), iFZ5je3XFYKwkvcE5D.D35lls5iF(3948, iFZ5je3XFYKwkvcE5D.N06TeK0ao), StringComparison.OrdinalIgnoreCase, RJdEUw97wnVnGsBRmDG.y949cPsE49))
		{
			dq1xgG9KNu7RfbYkGMV.D35lls5iF(uIIaqd9MWbmAhTXPYKL.D35lls5iF(P_1, uIIaqd9MWbmAhTXPYKL.a3y9SGZNdS), dq1xgG9KNu7RfbYkGMV.xWD9NR1CqV)[iFZ5je3XFYKwkvcE5D.D35lls5iF(474, iFZ5je3XFYKwkvcE5D.N06TeK0ao)] = iFZ5je3XFYKwkvcE5D.D35lls5iF(3966, iFZ5je3XFYKwkvcE5D.N06TeK0ao);
			QnJnl7fVDKI4mA6voc.D35lls5iF(nXvH3V9ON1PquOtoxuq.D35lls5iF(uIIaqd9MWbmAhTXPYKL.D35lls5iF(P_1, uIIaqd9MWbmAhTXPYKL.a3y9SGZNdS), nXvH3V9ON1PquOtoxuq.g2g9uaXBwW), false, QnJnl7fVDKI4mA6voc.J0Z9Ppmjjt);
			AKwYZ1lE8mnNaTGlMo6.D35lls5iF(uIIaqd9MWbmAhTXPYKL.D35lls5iF(P_1, uIIaqd9MWbmAhTXPYKL.a3y9SGZNdS), aNJrrPl4soK5NDOndiN.D35lls5iF(10.0, aNJrrPl4soK5NDOndiN.Ca9lahqtKS), AKwYZ1lE8mnNaTGlMo6.zL6nlX0JV7);
		}
		if (RJdEUw97wnVnGsBRmDG.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(P_1, wq2usy8gNndpuTw5mR.Jgy9VSHVYB), iFZ5je3XFYKwkvcE5D.D35lls5iF(3976, iFZ5je3XFYKwkvcE5D.N06TeK0ao), StringComparison.OrdinalIgnoreCase, RJdEUw97wnVnGsBRmDG.y949cPsE49) || RJdEUw97wnVnGsBRmDG.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(P_1, wq2usy8gNndpuTw5mR.Jgy9VSHVYB), iFZ5je3XFYKwkvcE5D.D35lls5iF(3994, iFZ5je3XFYKwkvcE5D.N06TeK0ao), StringComparison.OrdinalIgnoreCase, RJdEUw97wnVnGsBRmDG.y949cPsE49))
		{
			dq1xgG9KNu7RfbYkGMV.D35lls5iF(uIIaqd9MWbmAhTXPYKL.D35lls5iF(P_1, uIIaqd9MWbmAhTXPYKL.a3y9SGZNdS), dq1xgG9KNu7RfbYkGMV.xWD9NR1CqV)[iFZ5je3XFYKwkvcE5D.D35lls5iF(474, iFZ5je3XFYKwkvcE5D.N06TeK0ao)] = iFZ5je3XFYKwkvcE5D.D35lls5iF(3966, iFZ5je3XFYKwkvcE5D.N06TeK0ao);
			AKwYZ1lE8mnNaTGlMo6.D35lls5iF(uIIaqd9MWbmAhTXPYKL.D35lls5iF(P_1, uIIaqd9MWbmAhTXPYKL.a3y9SGZNdS), aNJrrPl4soK5NDOndiN.D35lls5iF(10.0, aNJrrPl4soK5NDOndiN.Ca9lahqtKS), AKwYZ1lE8mnNaTGlMo6.zL6nlX0JV7);
			QnJnl7fVDKI4mA6voc.D35lls5iF(nXvH3V9ON1PquOtoxuq.D35lls5iF(uIIaqd9MWbmAhTXPYKL.D35lls5iF(P_1, uIIaqd9MWbmAhTXPYKL.a3y9SGZNdS), nXvH3V9ON1PquOtoxuq.g2g9uaXBwW), true, QnJnl7fVDKI4mA6voc.J0Z9Ppmjjt);
			vQKA0r9sJ1kArsIHc16.D35lls5iF(nXvH3V9ON1PquOtoxuq.D35lls5iF(uIIaqd9MWbmAhTXPYKL.D35lls5iF(P_1, uIIaqd9MWbmAhTXPYKL.a3y9SGZNdS), nXvH3V9ON1PquOtoxuq.g2g9uaXBwW), 524288, vQKA0r9sJ1kArsIHc16.km39hJJ5mo);
			AKwYZ1lE8mnNaTGlMo6.D35lls5iF(nXvH3V9ON1PquOtoxuq.D35lls5iF(uIIaqd9MWbmAhTXPYKL.D35lls5iF(P_1, uIIaqd9MWbmAhTXPYKL.a3y9SGZNdS), nXvH3V9ON1PquOtoxuq.g2g9uaXBwW), aNJrrPl4soK5NDOndiN.D35lls5iF(1.0, aNJrrPl4soK5NDOndiN.Ca9lahqtKS), AKwYZ1lE8mnNaTGlMo6.HSE9xIihv0);
			vQKA0r9sJ1kArsIHc16.D35lls5iF(nXvH3V9ON1PquOtoxuq.D35lls5iF(uIIaqd9MWbmAhTXPYKL.D35lls5iF(P_1, uIIaqd9MWbmAhTXPYKL.a3y9SGZNdS), nXvH3V9ON1PquOtoxuq.g2g9uaXBwW), 32768, vQKA0r9sJ1kArsIHc16.Ebr9YCG3u1);
		}
	}

	private void x7QGNsAfdS(object P_0, MediaOpeningEventArgs P_1)
	{
		_003C_003Ec__DisplayClass20_0 CS_0024_003C_003E8__locals12 = new _003C_003Ec__DisplayClass20_0();
		CS_0024_003C_003E8__locals12._003C_003E4__this = this;
		CS_0024_003C_003E8__locals12.media = P_0 as MediaElement;
		AKwYZ1lE8mnNaTGlMo6.D35lls5iF(YQF0kW9goqSdXoWtJAF.D35lls5iF(P_1, YQF0kW9goqSdXoWtJAF.XRw9ikEf4n), TimeSpan.Zero, AKwYZ1lE8mnNaTGlMo6.IOXn9cTIlY);
		vQKA0r9sJ1kArsIHc16.D35lls5iF(YQF0kW9goqSdXoWtJAF.D35lls5iF(P_1, YQF0kW9goqSdXoWtJAF.XRw9ikEf4n), -1, vQKA0r9sJ1kArsIHc16.mB0RoiAYD6);
		vQKA0r9sJ1kArsIHc16.D35lls5iF(YQF0kW9goqSdXoWtJAF.D35lls5iF(P_1, YQF0kW9goqSdXoWtJAF.XRw9ikEf4n), -1, vQKA0r9sJ1kArsIHc16.xf0RlhE9YO);
		QnJnl7fVDKI4mA6voc.D35lls5iF(YQF0kW9goqSdXoWtJAF.D35lls5iF(P_1, YQF0kW9goqSdXoWtJAF.XRw9ikEf4n), S1a0wT9Ixre9OpDny8h.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(Pu8ZkM9Q72E1xo0KU8s.D35lls5iF(P_1, Pu8ZkM9Q72E1xo0KU8s.mf79X0XhAB), wq2usy8gNndpuTw5mR.wly9fwaPxr), iFZ5je3XFYKwkvcE5D.D35lls5iF(516, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO) || VMs7lU9URBMKdJRC1h1.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(Pu8ZkM9Q72E1xo0KU8s.D35lls5iF(P_1, Pu8ZkM9Q72E1xo0KU8s.mf79X0XhAB), wq2usy8gNndpuTw5mR.NVF92wcVcL), iFZ5je3XFYKwkvcE5D.D35lls5iF(546, iFZ5je3XFYKwkvcE5D.N06TeK0ao), VMs7lU9URBMKdJRC1h1.HFs9ZRW5q1), QnJnl7fVDKI4mA6voc.b6Y9jnPMS4);
		mAdJWQ9yhneCbEXlGMc.D35lls5iF(YQF0kW9goqSdXoWtJAF.D35lls5iF(P_1, YQF0kW9goqSdXoWtJAF.XRw9ikEf4n), 0.5, mAdJWQ9yhneCbEXlGMc.BP19qeiSg6);
		QnJnl7fVDKI4mA6voc.D35lls5iF(q1Gx2v9JbW9cOXEmWet.D35lls5iF(brSG6HeMSj, q1Gx2v9JbW9cOXEmWet.adR9bl47sF), hjMnupQVVDlRZAYQJC.D35lls5iF(YQF0kW9goqSdXoWtJAF.D35lls5iF(P_1, YQF0kW9goqSdXoWtJAF.XRw9ikEf4n), hjMnupQVVDlRZAYQJC.xuq9WWJfIB) || RJdEUw97wnVnGsBRmDG.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(Pu8ZkM9Q72E1xo0KU8s.D35lls5iF(P_1, Pu8ZkM9Q72E1xo0KU8s.mf79X0XhAB), wq2usy8gNndpuTw5mR.NVF92wcVcL), iFZ5je3XFYKwkvcE5D.D35lls5iF(570, iFZ5je3XFYKwkvcE5D.N06TeK0ao), StringComparison.OrdinalIgnoreCase, RJdEUw97wnVnGsBRmDG.Omd951BO6P), QnJnl7fVDKI4mA6voc.xcM9zZ9GfC);
		if (FFMEViewModel is MoviePlayerViewModel moviePlayerViewModel && eLYdi6EfurHf7Oowrq2.D35lls5iF(moviePlayerViewModel, eLYdi6EfurHf7Oowrq2.lfHR9p6V8n) == MoviePalyerType.Movie && mN4twN37Cb4EtEpQsEk.D35lls5iF(TMNvN3DsY49dcntqfIs.D35lls5iF(moviePlayerViewModel, TMNvN3DsY49dcntqfIs.ME9RDPjddX), mN4twN37Cb4EtEpQsEk.v1FRHG4RTO) != null && mN4twN37Cb4EtEpQsEk.D35lls5iF(TMNvN3DsY49dcntqfIs.D35lls5iF(moviePlayerViewModel, TMNvN3DsY49dcntqfIs.ME9RDPjddX), mN4twN37Cb4EtEpQsEk.v1FRHG4RTO).Any())
		{
			string apiRoute = UwSEfC4rh9eVlFenwI.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(mN4twN37Cb4EtEpQsEk.D35lls5iF(TMNvN3DsY49dcntqfIs.D35lls5iF(moviePlayerViewModel, TMNvN3DsY49dcntqfIs.ME9RDPjddX), mN4twN37Cb4EtEpQsEk.v1FRHG4RTO).FirstOrDefault(), wq2usy8gNndpuTw5mR.Kgp3MRM8cC), "", UwSEfC4rh9eVlFenwI.J6G3NC9nSO);
			qni3xrDkAJ3vF35eMav.D35lls5iF(YQF0kW9goqSdXoWtJAF.D35lls5iF(P_1, YQF0kW9goqSdXoWtJAF.XRw9ikEf4n), d27jrd3uD0dgsTkvn8k.D35lls5iF(hjMnupQVVDlRZAYQJC.D35lls5iF(kVoGsqtnOI, hjMnupQVVDlRZAYQJC.YLV3Oa3St2), apiRoute, d27jrd3uD0dgsTkvn8k.fC53Pw5IkY), qni3xrDkAJ3vF35eMav.abln1mMUvb);
		}
		if (FFMEViewModel is SereisPlayerViewModel sereisPlayerViewModel && mN4twN37Cb4EtEpQsEk.D35lls5iF(sereisPlayerViewModel.PlayerPlaylistViewModel.SelectedItem, mN4twN37Cb4EtEpQsEk.zsxR158YYO) != null && mN4twN37Cb4EtEpQsEk.D35lls5iF(sereisPlayerViewModel.PlayerPlaylistViewModel.SelectedItem, mN4twN37Cb4EtEpQsEk.zsxR158YYO).Any())
		{
			string apiRoute2 = UwSEfC4rh9eVlFenwI.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(mN4twN37Cb4EtEpQsEk.D35lls5iF(sereisPlayerViewModel.PlayerPlaylistViewModel.SelectedItem, mN4twN37Cb4EtEpQsEk.zsxR158YYO).FirstOrDefault(), wq2usy8gNndpuTw5mR.Kgp3MRM8cC), "", UwSEfC4rh9eVlFenwI.J6G3NC9nSO);
			qni3xrDkAJ3vF35eMav.D35lls5iF(YQF0kW9goqSdXoWtJAF.D35lls5iF(P_1, YQF0kW9goqSdXoWtJAF.XRw9ikEf4n), d27jrd3uD0dgsTkvn8k.D35lls5iF(hjMnupQVVDlRZAYQJC.D35lls5iF(kVoGsqtnOI, hjMnupQVVDlRZAYQJC.YLV3Oa3St2), apiRoute2, d27jrd3uD0dgsTkvn8k.fC53Pw5IkY), qni3xrDkAJ3vF35eMav.abln1mMUvb);
		}
		CS_0024_003C_003E8__locals12.videoStream = nrSOHAD8YrC91Hd87Ly.D35lls5iF(YQF0kW9goqSdXoWtJAF.D35lls5iF(P_1, YQF0kW9goqSdXoWtJAF.XRw9ikEf4n), nrSOHAD8YrC91Hd87Ly.EaoDno9rGj);
		if (CS_0024_003C_003E8__locals12.videoStream == null)
		{
			return;
		}
		ODLiVRlRE2AwTHTxA2m.D35lls5iF(new AVHWDeviceType[3], (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, ODLiVRlRE2AwTHTxA2m.rwklk7wPqp);
		if (bATk1clKMSyO8g9EVbN.D35lls5iF(CS_0024_003C_003E8__locals12.videoStream, bATk1clKMSyO8g9EVbN.CcVD3lb0hu) <= 30.0)
		{
			HardwareDeviceInfo hardwareDeviceInfo = MSyPQaDTrfJtr3GUW48.D35lls5iF(CS_0024_003C_003E8__locals12.videoStream, MSyPQaDTrfJtr3GUW48.ESUD4s2tw8).FirstOrDefault((HardwareDeviceInfo d) => aMnygB67j3N3yuQbSMF.D35lls5iF(d, aMnygB67j3N3yuQbSMF.PKP6cQZX8R) == CS_0024_003C_003E8__locals12._003C_003E4__this.FFMEViewModel.AVHWDeviceType);
			OZFi5cDLea4g6MgMYOr.D35lls5iF(YQF0kW9goqSdXoWtJAF.D35lls5iF(P_1, YQF0kW9goqSdXoWtJAF.XRw9ikEf4n), hardwareDeviceInfo, OZFi5cDLea4g6MgMYOr.e4mDEqBveZ);
		}
		StringBuilder stringBuilder = new StringBuilder();
		if (hjMnupQVVDlRZAYQJC.D35lls5iF(CS_0024_003C_003E8__locals12.videoStream, hjMnupQVVDlRZAYQJC.a2an8cXkZR))
		{
			Iqu9Z2D0u6duXqVdeBe.D35lls5iF(stringBuilder, iFZ5je3XFYKwkvcE5D.D35lls5iF(4024, iFZ5je3XFYKwkvcE5D.N06TeK0ao), Iqu9Z2D0u6duXqVdeBe.No5DrBqXtD);
		}
		if (m9MGZR7k2RmVqYXYS5.D35lls5iF(CS_0024_003C_003E8__locals12.videoStream, m9MGZR7k2RmVqYXYS5.l8vDBfi6TL) > 1080)
		{
			Iqu9Z2D0u6duXqVdeBe.D35lls5iF(stringBuilder, iFZ5je3XFYKwkvcE5D.D35lls5iF(582, iFZ5je3XFYKwkvcE5D.N06TeK0ao), Iqu9Z2D0u6duXqVdeBe.No5DrBqXtD);
		}
		qni3xrDkAJ3vF35eMav.D35lls5iF(YQF0kW9goqSdXoWtJAF.D35lls5iF(P_1, YQF0kW9goqSdXoWtJAF.XRw9ikEf4n), slLC9nDGSMhIcv2FTUB.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(stringBuilder, wq2usy8gNndpuTw5mR.ajcDe8nffb), ',', slLC9nDGSMhIcv2FTUB.yv2DRs3jeV), qni3xrDkAJ3vF35eMav.dmJDvBNs4m);
		Dispatcher obj = bRAh8kDAgKIlehXIXku.D35lls5iF(CS_0024_003C_003E8__locals12.media, bRAh8kDAgKIlehXIXku.oESD6ce9jH);
		if (obj != null)
		{
			QDm1hrDpKcWfLbL64Vl.D35lls5iF(obj, delegate
			{
				K8DNce6twv9Np34xpPr.D35lls5iF(CS_0024_003C_003E8__locals12.media, uEUVCI48fycroqgRFqy.D35lls5iF(CS_0024_003C_003E8__locals12.videoStream, uEUVCI48fycroqgRFqy.hx66UqOmg8) ? CaptionsChannel.CC1 : CaptionsChannel.CCP, K8DNce6twv9Np34xpPr.qtR6VreiE6);
			}, QDm1hrDpKcWfLbL64Vl.cxUDwIkrIx);
		}
	}

	protected void OnMediaOpened(object sender, MediaOpenedEventArgs e)
	{
		try
		{
			if (FFMEViewModel is MoviePlayerViewModel moviePlayerViewModel)
			{
				if (eLYdi6EfurHf7Oowrq2.D35lls5iF(moviePlayerViewModel, eLYdi6EfurHf7Oowrq2.lfHR9p6V8n) == MoviePalyerType.Movie)
				{
					MovieResponseDto movieResponseDto = TMNvN3DsY49dcntqfIs.D35lls5iF(moviePlayerViewModel, TMNvN3DsY49dcntqfIs.ME9RDPjddX);
					Qw4DJ51mcF3L167FXXP.D35lls5iF(AppContainer.Resolve<IHistoryService>(), m9MGZR7k2RmVqYXYS5.D35lls5iF(movieResponseDto, m9MGZR7k2RmVqYXYS5.j871CQO7pP), HistoryType.Movie, Qw4DJ51mcF3L167FXXP.A2c1a9DBq6);
				}
				if (eLYdi6EfurHf7Oowrq2.D35lls5iF(moviePlayerViewModel, eLYdi6EfurHf7Oowrq2.lfHR9p6V8n) == MoviePalyerType.Movie && mN4twN37Cb4EtEpQsEk.D35lls5iF(TMNvN3DsY49dcntqfIs.D35lls5iF(moviePlayerViewModel, TMNvN3DsY49dcntqfIs.ME9RDPjddX), mN4twN37Cb4EtEpQsEk.v1FRHG4RTO) != null && mN4twN37Cb4EtEpQsEk.D35lls5iF(TMNvN3DsY49dcntqfIs.D35lls5iF(moviePlayerViewModel, TMNvN3DsY49dcntqfIs.ME9RDPjddX), mN4twN37Cb4EtEpQsEk.v1FRHG4RTO).Any())
				{
					SubtitleResponseDto subtitleResponseDto = mN4twN37Cb4EtEpQsEk.D35lls5iF(TMNvN3DsY49dcntqfIs.D35lls5iF(moviePlayerViewModel, TMNvN3DsY49dcntqfIs.ME9RDPjddX), mN4twN37Cb4EtEpQsEk.v1FRHG4RTO).FirstOrDefault();
					vXHBYh3hTMsNFn2js2K.D35lls5iF(brSG6HeMSj, (Po4t9wnrBA7594AVo65.D35lls5iF(subtitleResponseDto, Po4t9wnrBA7594AVo65.xcF3sUbHwS) == Language.Arabic) ? FlowDirection.RightToLeft : FlowDirection.LeftToRight, vXHBYh3hTMsNFn2js2K.I4m3xpnXs7);
					moviePlayerViewModel.Controller.TextSizeButtonVisibility = Visibility.Visible;
				}
			}
			if (FFMEViewModel is SereisPlayerViewModel sereisPlayerViewModel)
			{
				Qw4DJ51mcF3L167FXXP.D35lls5iF(AppContainer.Resolve<IHistoryService>(), m9MGZR7k2RmVqYXYS5.D35lls5iF(sereisPlayerViewModel.PlayerPlaylistViewModel.SelectedItem, m9MGZR7k2RmVqYXYS5.j871CQO7pP), HistoryType.Episode, Qw4DJ51mcF3L167FXXP.A2c1a9DBq6);
				if (mN4twN37Cb4EtEpQsEk.D35lls5iF(sereisPlayerViewModel.PlayerPlaylistViewModel.SelectedItem, mN4twN37Cb4EtEpQsEk.zsxR158YYO) != null && mN4twN37Cb4EtEpQsEk.D35lls5iF(sereisPlayerViewModel.PlayerPlaylistViewModel.SelectedItem, mN4twN37Cb4EtEpQsEk.zsxR158YYO).Any())
				{
					SubtitleResponseDto subtitleResponseDto2 = mN4twN37Cb4EtEpQsEk.D35lls5iF(sereisPlayerViewModel.PlayerPlaylistViewModel.SelectedItem, mN4twN37Cb4EtEpQsEk.zsxR158YYO).FirstOrDefault();
					vXHBYh3hTMsNFn2js2K.D35lls5iF(brSG6HeMSj, (Po4t9wnrBA7594AVo65.D35lls5iF(subtitleResponseDto2, Po4t9wnrBA7594AVo65.xcF3sUbHwS) == Language.Arabic) ? FlowDirection.RightToLeft : FlowDirection.LeftToRight, vXHBYh3hTMsNFn2js2K.I4m3xpnXs7);
					sereisPlayerViewModel.Controller.TextSizeButtonVisibility = Visibility.Visible;
				}
			}
		}
		catch
		{
		}
	}

	protected void OnMediaReady(object sender, EventArgs e)
	{
		if (FFMEViewModel is MoviePlayerViewModel moviePlayerViewModel)
		{
			if (eLYdi6EfurHf7Oowrq2.D35lls5iF(moviePlayerViewModel, eLYdi6EfurHf7Oowrq2.lfHR9p6V8n) != MoviePalyerType.Movie)
			{
				return;
			}
			try
			{
				_003C_003Ec__DisplayClass22_0 CS_0024_003C_003E8__locals9 = new _003C_003Ec__DisplayClass22_0();
				CS_0024_003C_003E8__locals9._003C_003E4__this = this;
				IClientDataStore clientDataStore = AppContainer.Resolve<IClientDataStore>();
				CS_0024_003C_003E8__locals9.episode = M0bpFS3Y60ER3R6Ysry.D35lls5iF(clientDataStore, m9MGZR7k2RmVqYXYS5.D35lls5iF(TMNvN3DsY49dcntqfIs.D35lls5iF(moviePlayerViewModel, TMNvN3DsY49dcntqfIs.ME9RDPjddX), m9MGZR7k2RmVqYXYS5.j871CQO7pP), M0bpFS3Y60ER3R6Ysry.dv63gEpjAp);
				if (CS_0024_003C_003E8__locals9.episode != null)
				{
					GrowlInfo growlInfo = new GrowlInfo();
					qni3xrDkAJ3vF35eMav.D35lls5iF(growlInfo, iFZ5je3XFYKwkvcE5D.D35lls5iF(6962, iFZ5je3XFYKwkvcE5D.N06TeK0ao), qni3xrDkAJ3vF35eMav.uO13ijEghe);
					qni3xrDkAJ3vF35eMav.D35lls5iF(growlInfo, iFZ5je3XFYKwkvcE5D.D35lls5iF(7056, iFZ5je3XFYKwkvcE5D.N06TeK0ao), qni3xrDkAJ3vF35eMav.qyG3QmClWc);
					qni3xrDkAJ3vF35eMav.D35lls5iF(growlInfo, iFZ5je3XFYKwkvcE5D.D35lls5iF(7072, iFZ5je3XFYKwkvcE5D.N06TeK0ao), qni3xrDkAJ3vF35eMav.End3XMD82W);
					pMc99K3f9n18uQscAet.D35lls5iF(growlInfo, delegate(bool isConfirmed)
					{
						if (isConfirmed)
						{
							AKwYZ1lE8mnNaTGlMo6.D35lls5iF(CS_0024_003C_003E8__locals9._003C_003E4__this.brSG6HeMSj, aNJrrPl4soK5NDOndiN.D35lls5iF(bATk1clKMSyO8g9EVbN.D35lls5iF(CS_0024_003C_003E8__locals9.episode, bATk1clKMSyO8g9EVbN.yiiEWvK63c), aNJrrPl4soK5NDOndiN.Ca9lahqtKS), AKwYZ1lE8mnNaTGlMo6.DvFpdwo5LV);
						}
						return true;
					}, pMc99K3f9n18uQscAet.Hkt3F19C5f);
					vQKA0r9sJ1kArsIHc16.D35lls5iF(growlInfo, 1, vQKA0r9sJ1kArsIHc16.J2H32QZip9);
					N6BDbM3ZCKImRHES6LV.D35lls5iF(growlInfo, InfoType.Ask, N6BDbM3ZCKImRHES6LV.PMC3j7Ampb);
					QnJnl7fVDKI4mA6voc.D35lls5iF(growlInfo, false, QnJnl7fVDKI4mA6voc.lro3y5Gpy2);
					QnJnl7fVDKI4mA6voc.D35lls5iF(growlInfo, false, QnJnl7fVDKI4mA6voc.Fhs3qEKDES);
					NMRVYn3JvZav0metctL.D35lls5iF(growlInfo, NMRVYn3JvZav0metctL.ARG3bx3kOw);
					jVNDxp3z6q0wxScCRcS.D35lls5iF(zCLuoH3WcnknlpuuTlM.D35lls5iF(zCLuoH3WcnknlpuuTlM.svG354j6uj), delegate
					{
						o8rGMJ7gPS();
					}, jVNDxp3z6q0wxScCRcS.yRPToClv04);
				}
			}
			catch
			{
			}
		}
		if (!(FFMEViewModel is SereisPlayerViewModel sereisPlayerViewModel))
		{
			return;
		}
		try
		{
			_003C_003Ec__DisplayClass22_1 CS_0024_003C_003E8__locals11 = new _003C_003Ec__DisplayClass22_1();
			CS_0024_003C_003E8__locals11._003C_003E4__this = this;
			vQKA0r9sJ1kArsIHc16.D35lls5iF(sereisPlayerViewModel, m9MGZR7k2RmVqYXYS5.D35lls5iF(sereisPlayerViewModel.PlayerPlaylistViewModel.SelectedItem, m9MGZR7k2RmVqYXYS5.j871CQO7pP), vQKA0r9sJ1kArsIHc16.vTRR8vbEm0);
			IClientDataStore clientDataStore2 = AppContainer.Resolve<IClientDataStore>();
			CS_0024_003C_003E8__locals11.episode = aLsmqmRni3bjbjlPRJN.D35lls5iF(clientDataStore2, m9MGZR7k2RmVqYXYS5.D35lls5iF(sereisPlayerViewModel.PlayerPlaylistViewModel.SelectedItem, m9MGZR7k2RmVqYXYS5.j871CQO7pP), aLsmqmRni3bjbjlPRJN.VKGR3SFt38);
			if (CS_0024_003C_003E8__locals11.episode == null)
			{
				return;
			}
			GrowlInfo growlInfo2 = new GrowlInfo();
			qni3xrDkAJ3vF35eMav.D35lls5iF(growlInfo2, iFZ5je3XFYKwkvcE5D.D35lls5iF(6962, iFZ5je3XFYKwkvcE5D.N06TeK0ao), qni3xrDkAJ3vF35eMav.uO13ijEghe);
			qni3xrDkAJ3vF35eMav.D35lls5iF(growlInfo2, iFZ5je3XFYKwkvcE5D.D35lls5iF(7056, iFZ5je3XFYKwkvcE5D.N06TeK0ao), qni3xrDkAJ3vF35eMav.qyG3QmClWc);
			qni3xrDkAJ3vF35eMav.D35lls5iF(growlInfo2, iFZ5je3XFYKwkvcE5D.D35lls5iF(7072, iFZ5je3XFYKwkvcE5D.N06TeK0ao), qni3xrDkAJ3vF35eMav.End3XMD82W);
			pMc99K3f9n18uQscAet.D35lls5iF(growlInfo2, delegate(bool isConfirmed)
			{
				if (isConfirmed)
				{
					AKwYZ1lE8mnNaTGlMo6.D35lls5iF(CS_0024_003C_003E8__locals11._003C_003E4__this.brSG6HeMSj, aNJrrPl4soK5NDOndiN.D35lls5iF(bATk1clKMSyO8g9EVbN.D35lls5iF(CS_0024_003C_003E8__locals11.episode, bATk1clKMSyO8g9EVbN.sSHBpJLQZw), aNJrrPl4soK5NDOndiN.Ca9lahqtKS), AKwYZ1lE8mnNaTGlMo6.DvFpdwo5LV);
				}
				return true;
			}, pMc99K3f9n18uQscAet.Hkt3F19C5f);
			vQKA0r9sJ1kArsIHc16.D35lls5iF(growlInfo2, 1, vQKA0r9sJ1kArsIHc16.J2H32QZip9);
			N6BDbM3ZCKImRHES6LV.D35lls5iF(growlInfo2, InfoType.Ask, N6BDbM3ZCKImRHES6LV.PMC3j7Ampb);
			QnJnl7fVDKI4mA6voc.D35lls5iF(growlInfo2, false, QnJnl7fVDKI4mA6voc.lro3y5Gpy2);
			QnJnl7fVDKI4mA6voc.D35lls5iF(growlInfo2, false, QnJnl7fVDKI4mA6voc.Fhs3qEKDES);
			NMRVYn3JvZav0metctL.D35lls5iF(growlInfo2, NMRVYn3JvZav0metctL.ARG3bx3kOw);
			jVNDxp3z6q0wxScCRcS.D35lls5iF(zCLuoH3WcnknlpuuTlM.D35lls5iF(zCLuoH3WcnknlpuuTlM.svG354j6uj), delegate
			{
				o8rGMJ7gPS();
			}, jVNDxp3z6q0wxScCRcS.yRPToClv04);
		}
		catch
		{
		}
	}

	private void o8rGMJ7gPS()
	{
		BL5g3hTlaZ1Y7krOIPW.D35lls5iF(10000, BL5g3hTlaZ1Y7krOIPW.q83T9Ahgr7);
		bRAh8kDAgKIlehXIXku.D35lls5iF(Jr0pTQlovwB9pdID1EB.D35lls5iF(Jr0pTQlovwB9pdID1EB.CxrllgXtD4), bRAh8kDAgKIlehXIXku.oESD6ce9jH).Invoke((Action)delegate
		{
			iEiFM8eVSwxJTPFVS0.D35lls5iF("", iEiFM8eVSwxJTPFVS0.vMYpaW66Nu);
		});
	}

	protected void OnMediaClosed(object sender, EventArgs e)
	{
		try
		{
			if (FFMEViewModel is MoviePlayerViewModel moviePlayerViewModel)
			{
				moviePlayerViewModel.SaveMediaItem(null);
			}
			if (FFMEViewModel is SereisPlayerViewModel sereisPlayerViewModel)
			{
				sereisPlayerViewModel.SaveMediaItem(null);
			}
		}
		catch
		{
		}
	}

	[CompilerGenerated]
	private bool v10GCjMLcV(KeyValuePair<int, StreamInfo> P_0)
	{
		return Up3ObFDSJspBLFTGC8N.D35lls5iF(P_0.Value, Up3ObFDSJspBLFTGC8N.z70DKvMmSu) == (AVMediaType)XarGxHSxGy;
	}

	[CompilerGenerated]
	private void oQ1GYABycU()
	{
		o8rGMJ7gPS();
	}

	[CompilerGenerated]
	private void z0JGFZySSr()
	{
		o8rGMJ7gPS();
	}
}
