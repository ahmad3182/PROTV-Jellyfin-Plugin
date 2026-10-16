using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Input;
using FFmpeg.AutoGen;
using PROTV.Wpf.Helpers;
using Unosquare.FFME;

namespace PROTV.Wpf.ViewModels;

public class FFMEBaseViewModel<T> : BaseViewModel where T : new()
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass32_0
	{
		public int value;

		public FFMEBaseViewModel<T> _003C_003E4__this;

		public _003C_003Ec__DisplayClass32_0()
		{
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
			base._002Ector();
		}

		internal void RcMS1Vcuxf()
		{
			if (value == 0)
			{
				wV1i6CmPpOFoyWU06ru.D35lls5iF(_003C_003E4__this.MediaElement, 60.0, wV1i6CmPpOFoyWU06ru.OanmsOGBOd);
			}
			else if (value == 1)
			{
				wV1i6CmPpOFoyWU06ru.D35lls5iF(_003C_003E4__this.MediaElement, 50.0, wV1i6CmPpOFoyWU06ru.OanmsOGBOd);
			}
			else if (value == 2)
			{
				wV1i6CmPpOFoyWU06ru.D35lls5iF(_003C_003E4__this.MediaElement, 40.0, wV1i6CmPpOFoyWU06ru.OanmsOGBOd);
			}
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnCloseCommandExcuteAsync_003Ed__60 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public FFMEBaseViewModel<T> _003C_003E4__this;

		private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			FFMEBaseViewModel<T> fFMEBaseViewModel = _003C_003E4__this;
			try
			{
				ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_009a;
				}
				fFMEBaseViewModel.SaveMediaItem(default(T));
				if (fFMEBaseViewModel.MediaElement != null)
				{
					awaiter = wd2eJ2Asf3I9epXUKxU.D35lls5iF(fFMEBaseViewModel.MediaElement, wd2eJ2Asf3I9epXUKxU.GqxpmrsN1b).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_009a;
				}
				goto end_IL_0015;
				IL_009a:
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

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnStopCommandExcuteAsync_003Ed__61 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public FFMEBaseViewModel<T> _003C_003E4__this;

		private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			FFMEBaseViewModel<T> fFMEBaseViewModel = _003C_003E4__this;
			try
			{
				ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = wd2eJ2Asf3I9epXUKxU.D35lls5iF(fFMEBaseViewModel.MediaElement, wd2eJ2Asf3I9epXUKxU.jhVpJgmXpf).GetAwaiter();
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
	private struct _003COnPauseCommandExcuteAsync_003Ed__62 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public FFMEBaseViewModel<T> _003C_003E4__this;

		private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			FFMEBaseViewModel<T> fFMEBaseViewModel = _003C_003E4__this;
			try
			{
				ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = wd2eJ2Asf3I9epXUKxU.D35lls5iF(fFMEBaseViewModel.MediaElement, wd2eJ2Asf3I9epXUKxU.kl3mgXtXSD).GetAwaiter();
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
	private struct _003COnPlayCommandExcuteAsync_003Ed__63 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public FFMEBaseViewModel<T> _003C_003E4__this;

		private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			FFMEBaseViewModel<T> fFMEBaseViewModel = _003C_003E4__this;
			try
			{
				ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = wd2eJ2Asf3I9epXUKxU.D35lls5iF(fFMEBaseViewModel.MediaElement, wd2eJ2Asf3I9epXUKxU.fTCmiFqqnh).GetAwaiter();
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
	private struct _003C_003Cset_StreamHasBuffer_003Eb__20_0_003Ed : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public FFMEBaseViewModel<T> _003C_003E4__this;

		private Uri _003Csource_003E5__2;

		private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			FFMEBaseViewModel<T> fFMEBaseViewModel = _003C_003E4__this;
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
						goto IL_010e;
					}
					_003Csource_003E5__2 = TK02ZZpyDtWJtpJNIDU.D35lls5iF(fFMEBaseViewModel.MediaElement, TK02ZZpyDtWJtpJNIDU.U2upqVV7K1);
					awaiter = wd2eJ2Asf3I9epXUKxU.D35lls5iF(fFMEBaseViewModel.MediaElement, wd2eJ2Asf3I9epXUKxU.jhVpJgmXpf).GetAwaiter();
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
				awaiter = mchHD5pbvoLh6YJmlai.D35lls5iF(fFMEBaseViewModel.MediaElement, _003Csource_003E5__2, mchHD5pbvoLh6YJmlai.ahJpW0oay7).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					num = (_003C_003E1__state = 1);
					_003C_003Eu__1 = awaiter;
					_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
					return;
				}
				goto IL_010e;
				IL_010e:
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
	private struct _003C_003Cset_AVHWDeviceType_003Eb__35_0_003Ed : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public FFMEBaseViewModel<T> _003C_003E4__this;

		private Uri _003Csource_003E5__2;

		private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			FFMEBaseViewModel<T> fFMEBaseViewModel = _003C_003E4__this;
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
						goto IL_010e;
					}
					_003Csource_003E5__2 = TK02ZZpyDtWJtpJNIDU.D35lls5iF(fFMEBaseViewModel.MediaElement, TK02ZZpyDtWJtpJNIDU.U2upqVV7K1);
					awaiter = wd2eJ2Asf3I9epXUKxU.D35lls5iF(fFMEBaseViewModel.MediaElement, wd2eJ2Asf3I9epXUKxU.jhVpJgmXpf).GetAwaiter();
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
				awaiter = mchHD5pbvoLh6YJmlai.D35lls5iF(fFMEBaseViewModel.MediaElement, _003Csource_003E5__2, mchHD5pbvoLh6YJmlai.ahJpW0oay7).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					num = (_003C_003E1__state = 1);
					_003C_003Eu__1 = awaiter;
					_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
					return;
				}
				goto IL_010e;
				IL_010e:
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

	private MediaElement Ug4qXUZLU6;

	private bool c4fqRoKAWe;

	private bool h07qw428JD;

	private bool LeOqEybHS8;

	private bool Mfgq9MOqh7;

	private int gYDqebvhD7;

	private AVHWDeviceType ILCqOk7YZJ;

	private PlayerPlaylistViewModel<T> EW8qrGkZ8S;

	[CompilerGenerated]
	private ControllerViewModel<T> V3oqHlT8Ne;

	[CompilerGenerated]
	private ICommand MthqoIacr8;

	[CompilerGenerated]
	private ICommand wEPqgQsjTd;

	[CompilerGenerated]
	private ICommand bNLq1oUrFS;

	[CompilerGenerated]
	private ICommand whmqJ6pmhy;

	[CompilerGenerated]
	private ICommand TslqhKiCiv;

	public PlayerPlaylistViewModel<T> PlayerPlaylistViewModel
	{
		get
		{
			return EW8qrGkZ8S;
		}
		set
		{
			SetProperty(ref EW8qrGkZ8S, value, iFZ5je3XFYKwkvcE5D.D35lls5iF(11118, iFZ5je3XFYKwkvcE5D.N06TeK0ao));
		}
	}

	public MediaElement MediaElement
	{
		get
		{
			return Ug4qXUZLU6;
		}
		set
		{
			if (Ug4qXUZLU6 == null && value != null)
			{
				Ug4qXUZLU6 = value;
				Controller.OnApplicationLoaded();
				PlayerPlaylistViewModel.OnApplicationLoaded();
			}
			else
			{
				Ug4qXUZLU6 = value;
			}
			qni3xrDkAJ3vF35eMav.D35lls5iF(this, iFZ5je3XFYKwkvcE5D.D35lls5iF(10824, iFZ5je3XFYKwkvcE5D.N06TeK0ao), qni3xrDkAJ3vF35eMav.QN6DuDtCWO);
		}
	}

	public ControllerViewModel<T> Controller
	{
		[CompilerGenerated]
		get
		{
			return V3oqHlT8Ne;
		}
		[CompilerGenerated]
		set
		{
			V3oqHlT8Ne = value;
		}
	}

	public bool StreamHasBuffer
	{
		get
		{
			return Mfgq9MOqh7;
		}
		set
		{
			SetProperty(ref Mfgq9MOqh7, value, iFZ5je3XFYKwkvcE5D.D35lls5iF(8402, iFZ5je3XFYKwkvcE5D.N06TeK0ao), null, [AsyncStateMachine(typeof(FFMEBaseViewModel<>._003C_003Cset_StreamHasBuffer_003Eb__20_0_003Ed))] () =>
			{
				_003C_003Cset_StreamHasBuffer_003Eb__20_0_003Ed stateMachine = default(_003C_003Cset_StreamHasBuffer_003Eb__20_0_003Ed);
				stateMachine._003C_003Et__builder = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
				stateMachine._003C_003E4__this = this;
				stateMachine._003C_003E1__state = -1;
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
			});
		}
	}

	public bool IsPropertiesPanelOpen
	{
		get
		{
			return h07qw428JD;
		}
		set
		{
			h07qw428JD = value;
			qni3xrDkAJ3vF35eMav.D35lls5iF(this, iFZ5je3XFYKwkvcE5D.D35lls5iF(10852, iFZ5je3XFYKwkvcE5D.N06TeK0ao), qni3xrDkAJ3vF35eMav.QN6DuDtCWO);
		}
	}

	public bool IsSettingPanelOpen
	{
		get
		{
			return LeOqEybHS8;
		}
		set
		{
			LeOqEybHS8 = value;
			qni3xrDkAJ3vF35eMav.D35lls5iF(this, iFZ5je3XFYKwkvcE5D.D35lls5iF(10898, iFZ5je3XFYKwkvcE5D.N06TeK0ao), qni3xrDkAJ3vF35eMav.QN6DuDtCWO);
		}
	}

	public bool IsPlaylistPanelOpen
	{
		get
		{
			return c4fqRoKAWe;
		}
		set
		{
			c4fqRoKAWe = value;
			qni3xrDkAJ3vF35eMav.D35lls5iF(this, iFZ5je3XFYKwkvcE5D.D35lls5iF(10938, iFZ5je3XFYKwkvcE5D.N06TeK0ao), qni3xrDkAJ3vF35eMav.QN6DuDtCWO);
		}
	}

	public int FontSelectedindex
	{
		get
		{
			return gYDqebvhD7;
		}
		set
		{
			_003C_003Ec__DisplayClass32_0 CS_0024_003C_003E8__locals9 = new _003C_003Ec__DisplayClass32_0();
			CS_0024_003C_003E8__locals9.value = value;
			CS_0024_003C_003E8__locals9._003C_003E4__this = this;
			SetProperty(ref gYDqebvhD7, CS_0024_003C_003E8__locals9.value, iFZ5je3XFYKwkvcE5D.D35lls5iF(10980, iFZ5je3XFYKwkvcE5D.N06TeK0ao), null, delegate
			{
				if (CS_0024_003C_003E8__locals9.value == 0)
				{
					wV1i6CmPpOFoyWU06ru.D35lls5iF(CS_0024_003C_003E8__locals9._003C_003E4__this.MediaElement, 60.0, wV1i6CmPpOFoyWU06ru.OanmsOGBOd);
				}
				else if (CS_0024_003C_003E8__locals9.value == 1)
				{
					wV1i6CmPpOFoyWU06ru.D35lls5iF(CS_0024_003C_003E8__locals9._003C_003E4__this.MediaElement, 50.0, wV1i6CmPpOFoyWU06ru.OanmsOGBOd);
				}
				else if (CS_0024_003C_003E8__locals9.value == 2)
				{
					wV1i6CmPpOFoyWU06ru.D35lls5iF(CS_0024_003C_003E8__locals9._003C_003E4__this.MediaElement, 40.0, wV1i6CmPpOFoyWU06ru.OanmsOGBOd);
				}
			});
		}
	}

	public AVHWDeviceType AVHWDeviceType
	{
		get
		{
			return ILCqOk7YZJ;
		}
		set
		{
			SetProperty(ref ILCqOk7YZJ, value, iFZ5je3XFYKwkvcE5D.D35lls5iF(8436, iFZ5je3XFYKwkvcE5D.N06TeK0ao), null, [AsyncStateMachine(typeof(FFMEBaseViewModel<>._003C_003Cset_AVHWDeviceType_003Eb__35_0_003Ed))] () =>
			{
				_003C_003Cset_AVHWDeviceType_003Eb__35_0_003Ed stateMachine = default(_003C_003Cset_AVHWDeviceType_003Eb__35_0_003Ed);
				stateMachine._003C_003Et__builder = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
				stateMachine._003C_003E4__this = this;
				stateMachine._003C_003E1__state = -1;
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
			});
		}
	}

	public ICommand CloseCommand
	{
		[CompilerGenerated]
		get
		{
			return MthqoIacr8;
		}
		[CompilerGenerated]
		private set
		{
			MthqoIacr8 = value;
		}
	}

	public ICommand StopCommand
	{
		[CompilerGenerated]
		get
		{
			return wEPqgQsjTd;
		}
		[CompilerGenerated]
		private set
		{
			wEPqgQsjTd = value;
		}
	}

	public ICommand PauseCommand
	{
		[CompilerGenerated]
		get
		{
			return bNLq1oUrFS;
		}
		[CompilerGenerated]
		private set
		{
			bNLq1oUrFS = value;
		}
	}

	public ICommand PlayCommand
	{
		[CompilerGenerated]
		get
		{
			return whmqJ6pmhy;
		}
		[CompilerGenerated]
		private set
		{
			whmqJ6pmhy = value;
		}
	}

	public ICommand ChangeVideoHardwareDeviceCommand
	{
		[CompilerGenerated]
		get
		{
			return TslqhKiCiv;
		}
		[CompilerGenerated]
		private set
		{
			TslqhKiCiv = value;
		}
	}

	private void uXhqAG8a9L()
	{
		CloseCommand = new DelegateCommand(delegate
		{
			OnCloseCommandExcuteAsync();
		});
		StopCommand = new DelegateCommand(delegate
		{
			OnStopCommandExcuteAsync();
		});
		PauseCommand = new DelegateCommand(delegate
		{
			OnPauseCommandExcuteAsync();
		});
		PlayCommand = new DelegateCommand(delegate
		{
			OnPlayCommandExcuteAsync();
		});
		ChangeVideoHardwareDeviceCommand = new DelegateCommand(delegate(object P_0)
		{
			pPPqNO2uWj(P_0);
		});
	}

	private void pPPqNO2uWj(object P_0)
	{
		if (S1a0wT9Ixre9OpDny8h.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(P_0, wq2usy8gNndpuTw5mR.ajcDe8nffb), iFZ5je3XFYKwkvcE5D.D35lls5iF(11018, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO))
		{
			AVHWDeviceType = AVHWDeviceType.AV_HWDEVICE_TYPE_CUDA;
		}
		else if (S1a0wT9Ixre9OpDny8h.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(P_0, wq2usy8gNndpuTw5mR.ajcDe8nffb), iFZ5je3XFYKwkvcE5D.D35lls5iF(11034, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO))
		{
			AVHWDeviceType = AVHWDeviceType.AV_HWDEVICE_TYPE_DXVA2;
		}
		else if (S1a0wT9Ixre9OpDny8h.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(P_0, wq2usy8gNndpuTw5mR.ajcDe8nffb), iFZ5je3XFYKwkvcE5D.D35lls5iF(11054, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO))
		{
			AVHWDeviceType = AVHWDeviceType.AV_HWDEVICE_TYPE_D3D11VA;
		}
		else
		{
			AVHWDeviceType = AVHWDeviceType.AV_HWDEVICE_TYPE_NONE;
		}
	}

	public FFMEBaseViewModel()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector();
		uXhqAG8a9L();
		gYDqebvhD7 = 2;
	}

	public virtual void OnOpenCommandExcuteAsync(T obj)
	{
	}

	[AsyncStateMachine(typeof(FFMEBaseViewModel<>._003COnCloseCommandExcuteAsync_003Ed__60))]
	public void OnCloseCommandExcuteAsync()
	{
		_003COnCloseCommandExcuteAsync_003Ed__60 stateMachine = default(_003COnCloseCommandExcuteAsync_003Ed__60);
		stateMachine._003C_003Et__builder = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(FFMEBaseViewModel<>._003COnStopCommandExcuteAsync_003Ed__61))]
	public void OnStopCommandExcuteAsync()
	{
		_003COnStopCommandExcuteAsync_003Ed__61 stateMachine = default(_003COnStopCommandExcuteAsync_003Ed__61);
		stateMachine._003C_003Et__builder = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(FFMEBaseViewModel<>._003COnPauseCommandExcuteAsync_003Ed__62))]
	public void OnPauseCommandExcuteAsync()
	{
		_003COnPauseCommandExcuteAsync_003Ed__62 stateMachine = default(_003COnPauseCommandExcuteAsync_003Ed__62);
		stateMachine._003C_003Et__builder = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(FFMEBaseViewModel<>._003COnPlayCommandExcuteAsync_003Ed__63))]
	public void OnPlayCommandExcuteAsync()
	{
		_003COnPlayCommandExcuteAsync_003Ed__63 stateMachine = default(_003COnPlayCommandExcuteAsync_003Ed__63);
		stateMachine._003C_003Et__builder = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	public virtual void SaveMediaItem(T item)
	{
	}

	public override void Dispose()
	{
		OnCloseCommandExcuteAsync();
	}

	[CompilerGenerated]
	[AsyncStateMachine(typeof(FFMEBaseViewModel<>._003C_003Cset_StreamHasBuffer_003Eb__20_0_003Ed))]
	private void nMeqMEMfnq()
	{
		_003C_003Cset_StreamHasBuffer_003Eb__20_0_003Ed stateMachine = default(_003C_003Cset_StreamHasBuffer_003Eb__20_0_003Ed);
		stateMachine._003C_003Et__builder = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(FFMEBaseViewModel<>._003C_003Cset_AVHWDeviceType_003Eb__35_0_003Ed))]
	[CompilerGenerated]
	private void TcLqCotVKF()
	{
		_003C_003Cset_AVHWDeviceType_003Eb__35_0_003Ed stateMachine = default(_003C_003Cset_AVHWDeviceType_003Eb__35_0_003Ed);
		stateMachine._003C_003Et__builder = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[CompilerGenerated]
	private void TEuqYcK20k(object P_0)
	{
		OnCloseCommandExcuteAsync();
	}

	[CompilerGenerated]
	private void L9VqFF9Fbk(object P_0)
	{
		OnStopCommandExcuteAsync();
	}

	[CompilerGenerated]
	private void EMRq6cLtXk(object P_0)
	{
		OnPauseCommandExcuteAsync();
	}

	[CompilerGenerated]
	private void LZJqsvhACB(object P_0)
	{
		OnPlayCommandExcuteAsync();
	}

	[CompilerGenerated]
	private void khMqxM4Ywe(object P_0)
	{
		pPPqNO2uWj(P_0);
	}
}
