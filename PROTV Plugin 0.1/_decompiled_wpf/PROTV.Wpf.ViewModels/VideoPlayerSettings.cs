using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using FFmpeg.AutoGen;

namespace PROTV.Wpf.ViewModels;

public class VideoPlayerSettings : BaseVideoPlayerViewModel
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003C_003Cset_StreamHasBuffer_003Eb__4_0_003Ed : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public VideoPlayerSettings _003C_003E4__this;

		private Uri _003Csource_003E5__2;

		private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			VideoPlayerSettings videoPlayerSettings = _003C_003E4__this;
			try
			{
				ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter awaiter;
				if (num != 0)
				{
					if (num == 1)
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter);
						num = (_003C_003E1__state = -1);
						goto IL_013b;
					}
					_003Csource_003E5__2 = TK02ZZpyDtWJtpJNIDU.D35lls5iF(srgd79T1FovS2Zr1sHa.D35lls5iF(GZeA7834rWuxcAAP0En.D35lls5iF(videoPlayerSettings, GZeA7834rWuxcAAP0En.lEyTHiAe9F), srgd79T1FovS2Zr1sHa.ssHT8Bxex8), TK02ZZpyDtWJtpJNIDU.U2upqVV7K1);
					awaiter = wd2eJ2Asf3I9epXUKxU.D35lls5iF(srgd79T1FovS2Zr1sHa.D35lls5iF(GZeA7834rWuxcAAP0En.D35lls5iF(videoPlayerSettings, GZeA7834rWuxcAAP0En.lEyTHiAe9F), srgd79T1FovS2Zr1sHa.ssHT8Bxex8), wd2eJ2Asf3I9epXUKxU.jhVpJgmXpf).GetAwaiter();
					if (!awaiter.IsCompleted)
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
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter);
					num = (_003C_003E1__state = -1);
				}
				awaiter.GetResult();
				awaiter = mchHD5pbvoLh6YJmlai.D35lls5iF(srgd79T1FovS2Zr1sHa.D35lls5iF(GZeA7834rWuxcAAP0En.D35lls5iF(videoPlayerSettings, GZeA7834rWuxcAAP0En.lEyTHiAe9F), srgd79T1FovS2Zr1sHa.ssHT8Bxex8), _003Csource_003E5__2, mchHD5pbvoLh6YJmlai.ahJpW0oay7).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					num = (_003C_003E1__state = 1);
					_003C_003Eu__1 = awaiter;
					_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
					return;
				}
				goto IL_013b;
				IL_013b:
				awaiter.GetResult();
			}
			catch (Exception ex)
			{
				_003C_003E1__state = -2;
				_003Csource_003E5__2 = null;
				N2XUglA3neBsnlZfRPQ.D35lls5iF(ref _003C_003Et__builder, ex, N2XUglA3neBsnlZfRPQ.l4pATRumoW);
				return;
			}
			_003C_003E1__state = -2;
			_003Csource_003E5__2 = null;
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
	private struct _003C_003Cset_AVHWDeviceType_003Eb__7_0_003Ed : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public VideoPlayerSettings _003C_003E4__this;

		private Uri _003Csource_003E5__2;

		private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			VideoPlayerSettings videoPlayerSettings = _003C_003E4__this;
			try
			{
				ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter awaiter;
				if (num != 0)
				{
					if (num == 1)
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter);
						num = (_003C_003E1__state = -1);
						goto IL_013b;
					}
					_003Csource_003E5__2 = TK02ZZpyDtWJtpJNIDU.D35lls5iF(srgd79T1FovS2Zr1sHa.D35lls5iF(GZeA7834rWuxcAAP0En.D35lls5iF(videoPlayerSettings, GZeA7834rWuxcAAP0En.lEyTHiAe9F), srgd79T1FovS2Zr1sHa.ssHT8Bxex8), TK02ZZpyDtWJtpJNIDU.U2upqVV7K1);
					awaiter = wd2eJ2Asf3I9epXUKxU.D35lls5iF(srgd79T1FovS2Zr1sHa.D35lls5iF(GZeA7834rWuxcAAP0En.D35lls5iF(videoPlayerSettings, GZeA7834rWuxcAAP0En.lEyTHiAe9F), srgd79T1FovS2Zr1sHa.ssHT8Bxex8), wd2eJ2Asf3I9epXUKxU.jhVpJgmXpf).GetAwaiter();
					if (!awaiter.IsCompleted)
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
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter);
					num = (_003C_003E1__state = -1);
				}
				awaiter.GetResult();
				awaiter = mchHD5pbvoLh6YJmlai.D35lls5iF(srgd79T1FovS2Zr1sHa.D35lls5iF(GZeA7834rWuxcAAP0En.D35lls5iF(videoPlayerSettings, GZeA7834rWuxcAAP0En.lEyTHiAe9F), srgd79T1FovS2Zr1sHa.ssHT8Bxex8), _003Csource_003E5__2, mchHD5pbvoLh6YJmlai.ahJpW0oay7).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					num = (_003C_003E1__state = 1);
					_003C_003Eu__1 = awaiter;
					_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
					return;
				}
				goto IL_013b;
				IL_013b:
				awaiter.GetResult();
			}
			catch (Exception ex)
			{
				_003C_003E1__state = -2;
				_003Csource_003E5__2 = null;
				N2XUglA3neBsnlZfRPQ.D35lls5iF(ref _003C_003Et__builder, ex, N2XUglA3neBsnlZfRPQ.l4pATRumoW);
				return;
			}
			_003C_003E1__state = -2;
			_003Csource_003E5__2 = null;
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

	private bool CMCB6UpHIM;

	private AVHWDeviceType NZJBskob8c;

	public bool StreamHasBuffer
	{
		get
		{
			return CMCB6UpHIM;
		}
		set
		{
			SetProperty(ref CMCB6UpHIM, value, iFZ5je3XFYKwkvcE5D.D35lls5iF(8402, iFZ5je3XFYKwkvcE5D.N06TeK0ao), null, [AsyncStateMachine(typeof(_003C_003Cset_StreamHasBuffer_003Eb__4_0_003Ed))] () =>
			{
				_003C_003Cset_StreamHasBuffer_003Eb__4_0_003Ed stateMachine = default(_003C_003Cset_StreamHasBuffer_003Eb__4_0_003Ed);
				stateMachine._003C_003Et__builder = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
				stateMachine._003C_003E4__this = this;
				stateMachine._003C_003E1__state = -1;
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
			});
		}
	}

	public AVHWDeviceType AVHWDeviceType
	{
		get
		{
			return NZJBskob8c;
		}
		set
		{
			SetProperty(ref NZJBskob8c, value, iFZ5je3XFYKwkvcE5D.D35lls5iF(8436, iFZ5je3XFYKwkvcE5D.N06TeK0ao), null, [AsyncStateMachine(typeof(_003C_003Cset_AVHWDeviceType_003Eb__7_0_003Ed))] () =>
			{
				_003C_003Cset_AVHWDeviceType_003Eb__7_0_003Ed stateMachine = default(_003C_003Cset_AVHWDeviceType_003Eb__7_0_003Ed);
				stateMachine._003C_003Et__builder = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
				stateMachine._003C_003E4__this = this;
				stateMachine._003C_003E1__state = -1;
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
			});
		}
	}

	public VideoPlayerSettings(VideoPlayerViewModel root)
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector(root);
	}

	[CompilerGenerated]
	[AsyncStateMachine(typeof(_003C_003Cset_StreamHasBuffer_003Eb__4_0_003Ed))]
	private void dU7BYArVgD()
	{
		_003C_003Cset_StreamHasBuffer_003Eb__4_0_003Ed stateMachine = default(_003C_003Cset_StreamHasBuffer_003Eb__4_0_003Ed);
		stateMachine._003C_003Et__builder = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003C_003Cset_AVHWDeviceType_003Eb__7_0_003Ed))]
	[CompilerGenerated]
	private void AiHBFpeEBn()
	{
		_003C_003Cset_AVHWDeviceType_003Eb__7_0_003Ed stateMachine = default(_003C_003Cset_AVHWDeviceType_003Eb__7_0_003Ed);
		stateMachine._003C_003Et__builder = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}
}
