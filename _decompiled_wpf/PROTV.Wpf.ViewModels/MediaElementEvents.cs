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
using Unosquare.FFME;
using Unosquare.FFME.ClosedCaptions;
using Unosquare.FFME.Common;

namespace PROTV.Wpf.ViewModels;

public class MediaElementEvents
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnAudioDeviceStopped_003Ed__24 : IAsyncStateMachine
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
	private sealed class _003C_003Ec__DisplayClass29_0
	{
		public MediaElementEvents VWVZSMjUHJ;

		public MediaElement heTZfHLxk6;

		public StreamInfo khhZKX7gw2;

		public _003C_003Ec__DisplayClass29_0()
		{
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
			base._002Ector();
		}

		internal bool T9cZZJQdXB(HardwareDeviceInfo d)
		{
			return aMnygB67j3N3yuQbSMF.D35lls5iF(d, aMnygB67j3N3yuQbSMF.PKP6cQZX8R) == aMnygB67j3N3yuQbSMF.D35lls5iF(TkGxlh3CuVnrJFKZIh9.D35lls5iF(GZeA7834rWuxcAAP0En.D35lls5iF(VWVZSMjUHJ, GZeA7834rWuxcAAP0En.KIv3LwZjJa), TkGxlh3CuVnrJFKZIh9.BsP3mEDPkc), aMnygB67j3N3yuQbSMF.hm1pIvah3g);
		}

		internal void USHZt0svy9()
		{
			K8DNce6twv9Np34xpPr.D35lls5iF(heTZfHLxk6, uEUVCI48fycroqgRFqy.D35lls5iF(khhZKX7gw2, uEUVCI48fycroqgRFqy.hx66UqOmg8) ? CaptionsChannel.CC1 : CaptionsChannel.CCP, K8DNce6twv9Np34xpPr.qtR6VreiE6);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass31_0
	{
		public MoviePosition GtPZ8ia249;

		public MediaElementEvents RCsZQAntbi;

		public _003C_003Ec__DisplayClass31_0()
		{
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
			base._002Ector();
		}

		internal bool a4lZkClcsH(bool isConfirmed)
		{
			if (isConfirmed)
			{
				AKwYZ1lE8mnNaTGlMo6.D35lls5iF(RCsZQAntbi.f9X4yOqxSP, aNJrrPl4soK5NDOndiN.D35lls5iF(bATk1clKMSyO8g9EVbN.D35lls5iF(GtPZ8ia249, bATk1clKMSyO8g9EVbN.yiiEWvK63c), aNJrrPl4soK5NDOndiN.Ca9lahqtKS), AKwYZ1lE8mnNaTGlMo6.DvFpdwo5LV);
			}
			return true;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnMediaClosed_003Ed__33 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public MediaElementEvents _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			MediaElementEvents mediaElementEvents = _003C_003E4__this;
			try
			{
				try
				{
					TaskAwaiter awaiter;
					if (num == 0)
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter);
						num = (_003C_003E1__state = -1);
						goto IL_00c0;
					}
					if (xllcp23egxiMKQFcV8K.D35lls5iF(GZeA7834rWuxcAAP0En.D35lls5iF(mediaElementEvents, GZeA7834rWuxcAAP0En.KIv3LwZjJa), xllcp23egxiMKQFcV8K.UyJ3GDGNGy) == PlaylistItemType.Movie)
					{
						awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(xK80H3pVooFUKtGbrbS.D35lls5iF(mediaElementEvents.f9X4yOqxSP, mediaElementEvents.Lya43GXaTW, bATk1clKMSyO8g9EVbN.D35lls5iF(mediaElementEvents, bATk1clKMSyO8g9EVbN.RKFpUXOl6C), bATk1clKMSyO8g9EVbN.D35lls5iF(mediaElementEvents, bATk1clKMSyO8g9EVbN.zdUptxDWR7), xK80H3pVooFUKtGbrbS.EAEp7vIse3), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
						if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
						{
							num = (_003C_003E1__state = 0);
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_00c0;
					}
					goto end_IL_0018;
					IL_00c0:
					oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
					end_IL_0018:;
				}
				catch
				{
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

	private MediaElement f9X4yOqxSP;

	private readonly IStoreContext DBY4pBvuGh;

	private Unosquare.FFME.Common.MediaType PHh4i6gQWI;

	private int Lya43GXaTW;

	[CompilerGenerated]
	private VideoPlayerViewModel ERV4m5Uvue;

	[CompilerGenerated]
	private double plM4Xm2kij;

	[CompilerGenerated]
	private double n2b4RteWvR;

	public VideoPlayerViewModel VideoPlayerViewModel
	{
		[CompilerGenerated]
		get
		{
			return ERV4m5Uvue;
		}
		[CompilerGenerated]
		set
		{
			ERV4m5Uvue = value;
		}
	}

	public double ClosedPosition
	{
		[CompilerGenerated]
		get
		{
			return plM4Xm2kij;
		}
		[CompilerGenerated]
		private set
		{
			plM4Xm2kij = value;
		}
	}

	public double ClosedTotalSeconds
	{
		[CompilerGenerated]
		get
		{
			return n2b4RteWvR;
		}
		[CompilerGenerated]
		private set
		{
			n2b4RteWvR = value;
		}
	}

	public MediaElementEvents(VideoPlayerViewModel videoPlayerViewModel)
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		PHh4i6gQWI = Unosquare.FFME.Common.MediaType.None;
		base._002Ector();
		NPm3TB3oNdBOYjmbsFN.D35lls5iF(this, videoPlayerViewModel, NPm3TB3oNdBOYjmbsFN.qOx3lPFshe);
		DBY4pBvuGh = AppContainer.Resolve<IStoreContext>();
	}

	public void InitializeMediaEvents(MediaElement media)
	{
		f9X4yOqxSP = media;
		bHOmLK93DudIdGBrb75.D35lls5iF(OnMediaFFmpegMessageLogged, bHOmLK93DudIdGBrb75.Fod9TIsSiB);
		PaIS6u94vkelmQi5rj0.D35lls5iF(media, OnMediaDoubleClick, PaIS6u94vkelmQi5rj0.MEx9LXd1lc);
		i3gnNI9Eg29lNWhhmj9.D35lls5iF(media, dUX4MPCfTR, i3gnNI9Eg29lNWhhmj9.x0y9BgXsjM);
		qIyXdQ90W8ud3wp2ybv.D35lls5iF(media, hKi4Cxsopd, qIyXdQ90W8ud3wp2ybv.G9b9r6c2Bl);
		XeTMat9eHdgUsPwyBUr.D35lls5iF(media, OnMediaOpened, XeTMat9eHdgUsPwyBUr.xeJ9GY5CYT);
		ytk50glr3dmeojxPvdr.D35lls5iF(media, OnMediaReady, ytk50glr3dmeojxPvdr.VLo9RbyDNh);
		ytk50glr3dmeojxPvdr.D35lls5iF(media, OnMediaClosed, ytk50glr3dmeojxPvdr.KQE9kKpkPQ);
		Q2oTAJ39TRkEgkqcOHT.D35lls5iF(media, OnMediaMessageLogged, Q2oTAJ39TRkEgkqcOHT.z4P3DY1V4p);
		qIyXdQ90W8ud3wp2ybv.D35lls5iF(media, OnMediaChanging, qIyXdQ90W8ud3wp2ybv.BuQ9vYnSId);
		ytk50glr3dmeojxPvdr.D35lls5iF(media, OnAudioDeviceStopped, ytk50glr3dmeojxPvdr.hxb9lGDlo9);
		XeTMat9eHdgUsPwyBUr.D35lls5iF(media, OnMediaChanged, XeTMat9eHdgUsPwyBUr.fVH9ALNi6D);
		C0UEi896TGi2A8w1c4U.D35lls5iF(media, OnMediaFailed, C0UEi896TGi2A8w1c4U.ta09pyJDvh);
		ytk50glr3dmeojxPvdr.D35lls5iF(media, Y7V4ND9hf6, ytk50glr3dmeojxPvdr.Qv416M3eAn);
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
		if (sender != null && GmMLaTD7kV8rq88ZFvR.D35lls5iF(sender, f9X4yOqxSP, GmMLaTD7kV8rq88ZFvR.BQ5Dcmx5Pp))
		{
			QnJnl7fVDKI4mA6voc.D35lls5iF(e, true, QnJnl7fVDKI4mA6voc.WSpDMQcj8Y);
			QnJnl7fVDKI4mA6voc.D35lls5iF(cdbdBC3E9OhMyh2CjfD.D35lls5iF(GZeA7834rWuxcAAP0En.D35lls5iF(this, GZeA7834rWuxcAAP0En.KIv3LwZjJa), cdbdBC3E9OhMyh2CjfD.dh33BjQ0nJ), !hjMnupQVVDlRZAYQJC.D35lls5iF(cdbdBC3E9OhMyh2CjfD.D35lls5iF(GZeA7834rWuxcAAP0En.D35lls5iF(this, GZeA7834rWuxcAAP0En.KIv3LwZjJa), cdbdBC3E9OhMyh2CjfD.dh33BjQ0nJ), hjMnupQVVDlRZAYQJC.bJr30XbgeR), QnJnl7fVDKI4mA6voc.jhh3rDePKn);
		}
	}

	private void Y7V4ND9hf6(object P_0, EventArgs P_1)
	{
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

	[AsyncStateMachine(typeof(_003COnAudioDeviceStopped_003Ed__24))]
	protected void OnAudioDeviceStopped(object sender, EventArgs e)
	{
		_003COnAudioDeviceStopped_003Ed__24 stateMachine = default(_003COnAudioDeviceStopped_003Ed__24);
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
		if (xllcp23egxiMKQFcV8K.D35lls5iF(GZeA7834rWuxcAAP0En.D35lls5iF(this, GZeA7834rWuxcAAP0En.KIv3LwZjJa), xllcp23egxiMKQFcV8K.UyJ3GDGNGy) == PlaylistItemType.Movie)
		{
			TimeSpan timeSpan = moA0183RanLCkEiLXks.D35lls5iF(mediaElement, moA0183RanLCkEiLXks.K3o3krsS6B);
			if (LUSRjplVkOtM7DbdDL3.D35lls5iF(ref timeSpan, LUSRjplVkOtM7DbdDL3.LAf3veRADK) >= 5.0)
			{
				timeSpan = moA0183RanLCkEiLXks.D35lls5iF(mediaElement, moA0183RanLCkEiLXks.K3o3krsS6B);
				mAdJWQ9yhneCbEXlGMc.D35lls5iF(this, LUSRjplVkOtM7DbdDL3.D35lls5iF(ref timeSpan, LUSRjplVkOtM7DbdDL3.LAf3veRADK), mAdJWQ9yhneCbEXlGMc.b0B3A42Lpa);
				timeSpan = XLgPbA36DhJ4A0tFJ41.D35lls5iF(mediaElement, XLgPbA36DhJ4A0tFJ41.tP43pEUL5Y).Value;
				mAdJWQ9yhneCbEXlGMc.D35lls5iF(this, LUSRjplVkOtM7DbdDL3.D35lls5iF(ref timeSpan, LUSRjplVkOtM7DbdDL3.LAf3veRADK), mAdJWQ9yhneCbEXlGMc.xFZ3wgXlGe);
			}
		}
	}

	protected void OnMediaChanging(object sender, MediaOpeningEventArgs e)
	{
		List<StreamInfo> list = (from x in YrCoj4DChUfyKXuSvMK.D35lls5iF(Pu8ZkM9Q72E1xo0KU8s.D35lls5iF(e, Pu8ZkM9Q72E1xo0KU8s.mf79X0XhAB), YrCoj4DChUfyKXuSvMK.osNDmFEjj6)
			where Up3ObFDSJspBLFTGC8N.D35lls5iF(x.Value, Up3ObFDSJspBLFTGC8N.z70DKvMmSu) == (AVMediaType)PHh4i6gQWI
			select x.Value).ToList();
		if (list.Count > 0)
		{
			if (PHh4i6gQWI != Unosquare.FFME.Common.MediaType.Video)
			{
				list.Add(null);
			}
			int num;
			switch (PHh4i6gQWI)
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
			switch (PHh4i6gQWI)
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

	private void dUX4MPCfTR(object P_0, MediaInitializingEventArgs P_1)
	{
		if (RJdEUw97wnVnGsBRmDG.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(P_1, wq2usy8gNndpuTw5mR.Jgy9VSHVYB), iFZ5je3XFYKwkvcE5D.D35lls5iF(458, iFZ5je3XFYKwkvcE5D.N06TeK0ao), StringComparison.OrdinalIgnoreCase, RJdEUw97wnVnGsBRmDG.y949cPsE49))
		{
			f3dfG03IBSc0rrgMAgN.D35lls5iF(uIIaqd9MWbmAhTXPYKL.D35lls5iF(P_1, uIIaqd9MWbmAhTXPYKL.a3y9SGZNdS), !hjMnupQVVDlRZAYQJC.D35lls5iF(TkGxlh3CuVnrJFKZIh9.D35lls5iF(GZeA7834rWuxcAAP0En.D35lls5iF(this, GZeA7834rWuxcAAP0En.KIv3LwZjJa), TkGxlh3CuVnrJFKZIh9.BsP3mEDPkc), hjMnupQVVDlRZAYQJC.v423a5trvI), f3dfG03IBSc0rrgMAgN.ldh3dgmX42);
		}
		if (RJdEUw97wnVnGsBRmDG.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(P_1, wq2usy8gNndpuTw5mR.Jgy9VSHVYB), iFZ5je3XFYKwkvcE5D.D35lls5iF(3948, iFZ5je3XFYKwkvcE5D.N06TeK0ao), StringComparison.OrdinalIgnoreCase, RJdEUw97wnVnGsBRmDG.y949cPsE49))
		{
			f3dfG03IBSc0rrgMAgN.D35lls5iF(uIIaqd9MWbmAhTXPYKL.D35lls5iF(P_1, uIIaqd9MWbmAhTXPYKL.a3y9SGZNdS), !hjMnupQVVDlRZAYQJC.D35lls5iF(TkGxlh3CuVnrJFKZIh9.D35lls5iF(GZeA7834rWuxcAAP0En.D35lls5iF(this, GZeA7834rWuxcAAP0En.KIv3LwZjJa), TkGxlh3CuVnrJFKZIh9.BsP3mEDPkc), hjMnupQVVDlRZAYQJC.v423a5trvI), f3dfG03IBSc0rrgMAgN.CDK3UZdXnR);
		}
		if (RJdEUw97wnVnGsBRmDG.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(P_1, wq2usy8gNndpuTw5mR.Jgy9VSHVYB), iFZ5je3XFYKwkvcE5D.D35lls5iF(3976, iFZ5je3XFYKwkvcE5D.N06TeK0ao), StringComparison.OrdinalIgnoreCase, RJdEUw97wnVnGsBRmDG.y949cPsE49) || RJdEUw97wnVnGsBRmDG.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(P_1, wq2usy8gNndpuTw5mR.Jgy9VSHVYB), iFZ5je3XFYKwkvcE5D.D35lls5iF(3994, iFZ5je3XFYKwkvcE5D.N06TeK0ao), StringComparison.OrdinalIgnoreCase, RJdEUw97wnVnGsBRmDG.y949cPsE49))
		{
			f3dfG03IBSc0rrgMAgN.D35lls5iF(uIIaqd9MWbmAhTXPYKL.D35lls5iF(P_1, uIIaqd9MWbmAhTXPYKL.a3y9SGZNdS), !hjMnupQVVDlRZAYQJC.D35lls5iF(TkGxlh3CuVnrJFKZIh9.D35lls5iF(GZeA7834rWuxcAAP0En.D35lls5iF(this, GZeA7834rWuxcAAP0En.KIv3LwZjJa), TkGxlh3CuVnrJFKZIh9.BsP3mEDPkc), hjMnupQVVDlRZAYQJC.v423a5trvI), f3dfG03IBSc0rrgMAgN.BrQ3tUBA0n);
		}
	}

	private void hKi4Cxsopd(object P_0, MediaOpeningEventArgs P_1)
	{
		_003C_003Ec__DisplayClass29_0 CS_0024_003C_003E8__locals13 = new _003C_003Ec__DisplayClass29_0();
		CS_0024_003C_003E8__locals13.VWVZSMjUHJ = this;
		CS_0024_003C_003E8__locals13.heTZfHLxk6 = P_0 as MediaElement;
		AKwYZ1lE8mnNaTGlMo6.D35lls5iF(YQF0kW9goqSdXoWtJAF.D35lls5iF(P_1, YQF0kW9goqSdXoWtJAF.XRw9ikEf4n), TimeSpan.Zero, AKwYZ1lE8mnNaTGlMo6.IOXn9cTIlY);
		QnJnl7fVDKI4mA6voc.D35lls5iF(YQF0kW9goqSdXoWtJAF.D35lls5iF(P_1, YQF0kW9goqSdXoWtJAF.XRw9ikEf4n), S1a0wT9Ixre9OpDny8h.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(Pu8ZkM9Q72E1xo0KU8s.D35lls5iF(P_1, Pu8ZkM9Q72E1xo0KU8s.mf79X0XhAB), wq2usy8gNndpuTw5mR.wly9fwaPxr), iFZ5je3XFYKwkvcE5D.D35lls5iF(516, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO) || VMs7lU9URBMKdJRC1h1.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(Pu8ZkM9Q72E1xo0KU8s.D35lls5iF(P_1, Pu8ZkM9Q72E1xo0KU8s.mf79X0XhAB), wq2usy8gNndpuTw5mR.NVF92wcVcL), iFZ5je3XFYKwkvcE5D.D35lls5iF(546, iFZ5je3XFYKwkvcE5D.N06TeK0ao), VMs7lU9URBMKdJRC1h1.HFs9ZRW5q1), QnJnl7fVDKI4mA6voc.b6Y9jnPMS4);
		mAdJWQ9yhneCbEXlGMc.D35lls5iF(YQF0kW9goqSdXoWtJAF.D35lls5iF(P_1, YQF0kW9goqSdXoWtJAF.XRw9ikEf4n), 0.5, mAdJWQ9yhneCbEXlGMc.BP19qeiSg6);
		QnJnl7fVDKI4mA6voc.D35lls5iF(q1Gx2v9JbW9cOXEmWet.D35lls5iF(f9X4yOqxSP, q1Gx2v9JbW9cOXEmWet.adR9bl47sF), hjMnupQVVDlRZAYQJC.D35lls5iF(YQF0kW9goqSdXoWtJAF.D35lls5iF(P_1, YQF0kW9goqSdXoWtJAF.XRw9ikEf4n), hjMnupQVVDlRZAYQJC.xuq9WWJfIB) || RJdEUw97wnVnGsBRmDG.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(Pu8ZkM9Q72E1xo0KU8s.D35lls5iF(P_1, Pu8ZkM9Q72E1xo0KU8s.mf79X0XhAB), wq2usy8gNndpuTw5mR.NVF92wcVcL), iFZ5je3XFYKwkvcE5D.D35lls5iF(570, iFZ5je3XFYKwkvcE5D.N06TeK0ao), StringComparison.OrdinalIgnoreCase, RJdEUw97wnVnGsBRmDG.Omd951BO6P), QnJnl7fVDKI4mA6voc.xcM9zZ9GfC);
		vQKA0r9sJ1kArsIHc16.D35lls5iF(q1Gx2v9JbW9cOXEmWet.D35lls5iF(CS_0024_003C_003E8__locals13.heTZfHLxk6, q1Gx2v9JbW9cOXEmWet.adR9bl47sF), 0, vQKA0r9sJ1kArsIHc16.U5RDoantIq);
		if (xllcp23egxiMKQFcV8K.D35lls5iF(GZeA7834rWuxcAAP0En.D35lls5iF(this, GZeA7834rWuxcAAP0En.KIv3LwZjJa), xllcp23egxiMKQFcV8K.UyJ3GDGNGy) == PlaylistItemType.Movie)
		{
			Lya43GXaTW = m9MGZR7k2RmVqYXYS5.D35lls5iF(NRXQg219ahcEpkUqugy.D35lls5iF(kNkAAf1oS8EBBquLcPe.D35lls5iF(GZeA7834rWuxcAAP0En.D35lls5iF(this, GZeA7834rWuxcAAP0En.KIv3LwZjJa), kNkAAf1oS8EBBquLcPe.HUa1lHiUNn), NRXQg219ahcEpkUqugy.J4U1D5ws5N), m9MGZR7k2RmVqYXYS5.kIl3VviojT);
			SubtitleResponseDto subtitleResponseDto = mN4twN37Cb4EtEpQsEk.D35lls5iF(NRXQg219ahcEpkUqugy.D35lls5iF(kNkAAf1oS8EBBquLcPe.D35lls5iF(GZeA7834rWuxcAAP0En.D35lls5iF(this, GZeA7834rWuxcAAP0En.KIv3LwZjJa), kNkAAf1oS8EBBquLcPe.HUa1lHiUNn), NRXQg219ahcEpkUqugy.J4U1D5ws5N), mN4twN37Cb4EtEpQsEk.USv3cWeapG).LastOrDefault();
			if (subtitleResponseDto != null && !M6ZErPEr2LZyWYpa5O.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(subtitleResponseDto, wq2usy8gNndpuTw5mR.Kgp3MRM8cC), M6ZErPEr2LZyWYpa5O.rg89aHbgYh) && !M6ZErPEr2LZyWYpa5O.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(subtitleResponseDto, wq2usy8gNndpuTw5mR.Kgp3MRM8cC), M6ZErPEr2LZyWYpa5O.tZ53SRMKfw))
			{
				string apiRoute = UwSEfC4rh9eVlFenwI.D35lls5iF((subtitleResponseDto != null) ? wq2usy8gNndpuTw5mR.D35lls5iF(subtitleResponseDto, wq2usy8gNndpuTw5mR.AcR3KC2tMv) : null, "", UwSEfC4rh9eVlFenwI.J6G3NC9nSO);
				qni3xrDkAJ3vF35eMav.D35lls5iF(YQF0kW9goqSdXoWtJAF.D35lls5iF(P_1, YQF0kW9goqSdXoWtJAF.XRw9ikEf4n), d27jrd3uD0dgsTkvn8k.D35lls5iF(hjMnupQVVDlRZAYQJC.D35lls5iF(DBY4pBvuGh, hjMnupQVVDlRZAYQJC.YLV3Oa3St2), apiRoute, d27jrd3uD0dgsTkvn8k.fC53Pw5IkY), qni3xrDkAJ3vF35eMav.abln1mMUvb);
			}
		}
		CS_0024_003C_003E8__locals13.khhZKX7gw2 = nrSOHAD8YrC91Hd87Ly.D35lls5iF(YQF0kW9goqSdXoWtJAF.D35lls5iF(P_1, YQF0kW9goqSdXoWtJAF.XRw9ikEf4n), nrSOHAD8YrC91Hd87Ly.EaoDno9rGj);
		if (CS_0024_003C_003E8__locals13.khhZKX7gw2 == null)
		{
			return;
		}
		ODLiVRlRE2AwTHTxA2m.D35lls5iF(new AVHWDeviceType[3], (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, ODLiVRlRE2AwTHTxA2m.rwklk7wPqp);
		if (bATk1clKMSyO8g9EVbN.D35lls5iF(CS_0024_003C_003E8__locals13.khhZKX7gw2, bATk1clKMSyO8g9EVbN.CcVD3lb0hu) <= 30.0)
		{
			HardwareDeviceInfo hardwareDeviceInfo = MSyPQaDTrfJtr3GUW48.D35lls5iF(CS_0024_003C_003E8__locals13.khhZKX7gw2, MSyPQaDTrfJtr3GUW48.ESUD4s2tw8).FirstOrDefault((HardwareDeviceInfo d) => aMnygB67j3N3yuQbSMF.D35lls5iF(d, aMnygB67j3N3yuQbSMF.PKP6cQZX8R) == aMnygB67j3N3yuQbSMF.D35lls5iF(TkGxlh3CuVnrJFKZIh9.D35lls5iF(GZeA7834rWuxcAAP0En.D35lls5iF(CS_0024_003C_003E8__locals13.VWVZSMjUHJ, GZeA7834rWuxcAAP0En.KIv3LwZjJa), TkGxlh3CuVnrJFKZIh9.BsP3mEDPkc), aMnygB67j3N3yuQbSMF.hm1pIvah3g));
			OZFi5cDLea4g6MgMYOr.D35lls5iF(YQF0kW9goqSdXoWtJAF.D35lls5iF(P_1, YQF0kW9goqSdXoWtJAF.XRw9ikEf4n), hardwareDeviceInfo, OZFi5cDLea4g6MgMYOr.e4mDEqBveZ);
		}
		StringBuilder stringBuilder = new StringBuilder();
		if (hjMnupQVVDlRZAYQJC.D35lls5iF(CS_0024_003C_003E8__locals13.khhZKX7gw2, hjMnupQVVDlRZAYQJC.a2an8cXkZR))
		{
			Iqu9Z2D0u6duXqVdeBe.D35lls5iF(stringBuilder, iFZ5je3XFYKwkvcE5D.D35lls5iF(4024, iFZ5je3XFYKwkvcE5D.N06TeK0ao), Iqu9Z2D0u6duXqVdeBe.No5DrBqXtD);
		}
		if (m9MGZR7k2RmVqYXYS5.D35lls5iF(CS_0024_003C_003E8__locals13.khhZKX7gw2, m9MGZR7k2RmVqYXYS5.l8vDBfi6TL) > 1080)
		{
			Iqu9Z2D0u6duXqVdeBe.D35lls5iF(stringBuilder, iFZ5je3XFYKwkvcE5D.D35lls5iF(582, iFZ5je3XFYKwkvcE5D.N06TeK0ao), Iqu9Z2D0u6duXqVdeBe.No5DrBqXtD);
		}
		qni3xrDkAJ3vF35eMav.D35lls5iF(YQF0kW9goqSdXoWtJAF.D35lls5iF(P_1, YQF0kW9goqSdXoWtJAF.XRw9ikEf4n), slLC9nDGSMhIcv2FTUB.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(stringBuilder, wq2usy8gNndpuTw5mR.ajcDe8nffb), ',', slLC9nDGSMhIcv2FTUB.yv2DRs3jeV), qni3xrDkAJ3vF35eMav.dmJDvBNs4m);
		Dispatcher obj = bRAh8kDAgKIlehXIXku.D35lls5iF(CS_0024_003C_003E8__locals13.heTZfHLxk6, bRAh8kDAgKIlehXIXku.oESD6ce9jH);
		if (obj != null)
		{
			QDm1hrDpKcWfLbL64Vl.D35lls5iF(obj, delegate
			{
				K8DNce6twv9Np34xpPr.D35lls5iF(CS_0024_003C_003E8__locals13.heTZfHLxk6, uEUVCI48fycroqgRFqy.D35lls5iF(CS_0024_003C_003E8__locals13.khhZKX7gw2, uEUVCI48fycroqgRFqy.hx66UqOmg8) ? CaptionsChannel.CC1 : CaptionsChannel.CCP, K8DNce6twv9Np34xpPr.qtR6VreiE6);
			}, QDm1hrDpKcWfLbL64Vl.cxUDwIkrIx);
		}
	}

	protected void OnMediaOpened(object sender, MediaOpenedEventArgs e)
	{
		try
		{
			if (xllcp23egxiMKQFcV8K.D35lls5iF(GZeA7834rWuxcAAP0En.D35lls5iF(this, GZeA7834rWuxcAAP0En.KIv3LwZjJa), xllcp23egxiMKQFcV8K.UyJ3GDGNGy) == PlaylistItemType.Movie)
			{
				VideoPlayerPlaylistItem videoPlayerPlaylistItem = NRXQg219ahcEpkUqugy.D35lls5iF(kNkAAf1oS8EBBquLcPe.D35lls5iF(GZeA7834rWuxcAAP0En.D35lls5iF(this, GZeA7834rWuxcAAP0En.KIv3LwZjJa), kNkAAf1oS8EBBquLcPe.HUa1lHiUNn), NRXQg219ahcEpkUqugy.J4U1D5ws5N);
				Qw4DJ51mcF3L167FXXP.D35lls5iF(AppContainer.Resolve<IHistoryService>(), m9MGZR7k2RmVqYXYS5.D35lls5iF(videoPlayerPlaylistItem, m9MGZR7k2RmVqYXYS5.kIl3VviojT), HistoryType.Movie, Qw4DJ51mcF3L167FXXP.A2c1a9DBq6);
				if (mN4twN37Cb4EtEpQsEk.D35lls5iF(videoPlayerPlaylistItem, mN4twN37Cb4EtEpQsEk.USv3cWeapG) != null && mN4twN37Cb4EtEpQsEk.D35lls5iF(videoPlayerPlaylistItem, mN4twN37Cb4EtEpQsEk.USv3cWeapG).Any())
				{
					SubtitleResponseDto subtitleResponseDto = mN4twN37Cb4EtEpQsEk.D35lls5iF(videoPlayerPlaylistItem, mN4twN37Cb4EtEpQsEk.USv3cWeapG).LastOrDefault();
					vXHBYh3hTMsNFn2js2K.D35lls5iF(f9X4yOqxSP, (Po4t9wnrBA7594AVo65.D35lls5iF(subtitleResponseDto, Po4t9wnrBA7594AVo65.xcF3sUbHwS) == Language.Arabic) ? FlowDirection.RightToLeft : FlowDirection.LeftToRight, vXHBYh3hTMsNFn2js2K.I4m3xpnXs7);
				}
			}
		}
		catch
		{
		}
	}

	protected void OnMediaReady(object sender, EventArgs e)
	{
		if (xllcp23egxiMKQFcV8K.D35lls5iF(GZeA7834rWuxcAAP0En.D35lls5iF(this, GZeA7834rWuxcAAP0En.KIv3LwZjJa), xllcp23egxiMKQFcV8K.UyJ3GDGNGy) != PlaylistItemType.Movie)
		{
			return;
		}
		try
		{
			_003C_003Ec__DisplayClass31_0 CS_0024_003C_003E8__locals5 = new _003C_003Ec__DisplayClass31_0();
			CS_0024_003C_003E8__locals5.RCsZQAntbi = this;
			IClientDataStore clientDataStore = AppContainer.Resolve<IClientDataStore>();
			VideoPlayerPlaylistItem videoPlayerPlaylistItem = NRXQg219ahcEpkUqugy.D35lls5iF(kNkAAf1oS8EBBquLcPe.D35lls5iF(GZeA7834rWuxcAAP0En.D35lls5iF(this, GZeA7834rWuxcAAP0En.KIv3LwZjJa), kNkAAf1oS8EBBquLcPe.HUa1lHiUNn), NRXQg219ahcEpkUqugy.J4U1D5ws5N);
			CS_0024_003C_003E8__locals5.GtPZ8ia249 = M0bpFS3Y60ER3R6Ysry.D35lls5iF(clientDataStore, m9MGZR7k2RmVqYXYS5.D35lls5iF(videoPlayerPlaylistItem, m9MGZR7k2RmVqYXYS5.kIl3VviojT), M0bpFS3Y60ER3R6Ysry.dv63gEpjAp);
			if (CS_0024_003C_003E8__locals5.GtPZ8ia249 == null)
			{
				return;
			}
			GrowlInfo growlInfo = new GrowlInfo();
			qni3xrDkAJ3vF35eMav.D35lls5iF(growlInfo, iFZ5je3XFYKwkvcE5D.D35lls5iF(6962, iFZ5je3XFYKwkvcE5D.N06TeK0ao), qni3xrDkAJ3vF35eMav.uO13ijEghe);
			qni3xrDkAJ3vF35eMav.D35lls5iF(growlInfo, iFZ5je3XFYKwkvcE5D.D35lls5iF(7056, iFZ5je3XFYKwkvcE5D.N06TeK0ao), qni3xrDkAJ3vF35eMav.qyG3QmClWc);
			qni3xrDkAJ3vF35eMav.D35lls5iF(growlInfo, iFZ5je3XFYKwkvcE5D.D35lls5iF(7072, iFZ5je3XFYKwkvcE5D.N06TeK0ao), qni3xrDkAJ3vF35eMav.End3XMD82W);
			pMc99K3f9n18uQscAet.D35lls5iF(growlInfo, delegate(bool isConfirmed)
			{
				if (isConfirmed)
				{
					AKwYZ1lE8mnNaTGlMo6.D35lls5iF(CS_0024_003C_003E8__locals5.RCsZQAntbi.f9X4yOqxSP, aNJrrPl4soK5NDOndiN.D35lls5iF(bATk1clKMSyO8g9EVbN.D35lls5iF(CS_0024_003C_003E8__locals5.GtPZ8ia249, bATk1clKMSyO8g9EVbN.yiiEWvK63c), aNJrrPl4soK5NDOndiN.Ca9lahqtKS), AKwYZ1lE8mnNaTGlMo6.DvFpdwo5LV);
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
				xLO56JniGyickVjO1Ot.D35lls5iF(this, xLO56JniGyickVjO1Ot.ASWTDG7b0n);
			}, jVNDxp3z6q0wxScCRcS.yRPToClv04);
		}
		catch
		{
		}
	}

	private void YFC4Yo8KMf()
	{
		BL5g3hTlaZ1Y7krOIPW.D35lls5iF(10000, BL5g3hTlaZ1Y7krOIPW.q83T9Ahgr7);
		bRAh8kDAgKIlehXIXku.D35lls5iF(Jr0pTQlovwB9pdID1EB.D35lls5iF(Jr0pTQlovwB9pdID1EB.CxrllgXtD4), bRAh8kDAgKIlehXIXku.oESD6ce9jH).Invoke((Action)delegate
		{
			iEiFM8eVSwxJTPFVS0.D35lls5iF("", iEiFM8eVSwxJTPFVS0.vMYpaW66Nu);
		});
	}

	[AsyncStateMachine(typeof(_003COnMediaClosed_003Ed__33))]
	protected void OnMediaClosed(object sender, EventArgs e)
	{
		_003COnMediaClosed_003Ed__33 stateMachine = default(_003COnMediaClosed_003Ed__33);
		stateMachine._003C_003Et__builder = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[CompilerGenerated]
	private bool CiN4Ffn0xm(KeyValuePair<int, StreamInfo> P_0)
	{
		return Up3ObFDSJspBLFTGC8N.D35lls5iF(P_0.Value, Up3ObFDSJspBLFTGC8N.z70DKvMmSu) == (AVMediaType)PHh4i6gQWI;
	}

	[CompilerGenerated]
	private void BF446U9ety()
	{
		xLO56JniGyickVjO1Ot.D35lls5iF(this, xLO56JniGyickVjO1Ot.ASWTDG7b0n);
	}
}
