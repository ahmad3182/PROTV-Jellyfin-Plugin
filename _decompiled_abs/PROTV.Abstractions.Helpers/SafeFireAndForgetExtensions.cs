using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace PROTV.Abstractions.Helpers;

public static class SafeFireAndForgetExtensions
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CHandleSafeFireAndForget_003Ed__13<TException> : IAsyncStateMachine where TException : Exception
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ValueTask valueTask;

		public bool continueOnCapturedContext;

		public Action<TException> onException;

		private ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			try
			{
				try
				{
					ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = tn7XKOvBvfWambpkgMH.IB3tMMvyI(ref valueTask, continueOnCapturedContext, tn7XKOvBvfWambpkgMH.IAHv1CUsdA).GetAwaiter();
						if (!tLXsKuvytIDiUDHuE8u.IB3tMMvyI(ref awaiter, tLXsKuvytIDiUDHuE8u.hF1vokUC10))
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
						_003C_003Eu__1 = default(ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter);
						num = (_003C_003E1__state = -1);
					}
					jOXjKbv8Y7dPAWYXC27.IB3tMMvyI(ref awaiter, jOXjKbv8Y7dPAWYXC27.bEHvNZbdkt);
				}
				catch (TException exception) when (LHx3IV5smF != null || onException != null)
				{
					yKI3NJ8Aro(in exception, in onException);
					if (akO33kqXVF)
					{
						throw;
					}
				}
			}
			catch (Exception ex)
			{
				_003C_003E1__state = -2;
				anciwYvGByWjaPfaSme.IB3tMMvyI(ref _003C_003Et__builder, ex, anciwYvGByWjaPfaSme.eC5vh8TMo5);
				return;
			}
			_003C_003E1__state = -2;
			NIV3VTvAeDrEhZ7KTvj.IB3tMMvyI(ref _003C_003Et__builder, NIV3VTvAeDrEhZ7KTvj.cK2vsmglm1);
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			Unw5bFvxwWo77ob06gG.IB3tMMvyI(ref _003C_003Et__builder, stateMachine, Unw5bFvxwWo77ob06gG.pu1vzRbpYU);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CHandleSafeFireAndForget_003Ed__14<TException> : IAsyncStateMachine where TException : Exception
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public Task task;

		public bool continueOnCapturedContext;

		public Action<TException> onException;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			try
			{
				try
				{
					ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = gZf6f6MwPcX4vsnWxhh.IB3tMMvyI(task, continueOnCapturedContext, gZf6f6MwPcX4vsnWxhh.LsiMtx7BR5).GetAwaiter();
						if (!ue5MQ0MgRUixMa0i7Ed.IB3tMMvyI(ref awaiter, ue5MQ0MgRUixMa0i7Ed.lnoMLeGQZX))
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
						_003C_003Eu__1 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
						num = (_003C_003E1__state = -1);
					}
					p9Q8lDMVl28ikQpS68J.IB3tMMvyI(ref awaiter, p9Q8lDMVl28ikQpS68J.CDVMSfRE75);
				}
				catch (TException exception) when (LHx3IV5smF != null || onException != null)
				{
					yKI3NJ8Aro(in exception, in onException);
					if (akO33kqXVF)
					{
						throw;
					}
				}
			}
			catch (Exception ex)
			{
				_003C_003E1__state = -2;
				anciwYvGByWjaPfaSme.IB3tMMvyI(ref _003C_003Et__builder, ex, anciwYvGByWjaPfaSme.eC5vh8TMo5);
				return;
			}
			_003C_003E1__state = -2;
			NIV3VTvAeDrEhZ7KTvj.IB3tMMvyI(ref _003C_003Et__builder, NIV3VTvAeDrEhZ7KTvj.cK2vsmglm1);
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			Unw5bFvxwWo77ob06gG.IB3tMMvyI(ref _003C_003Et__builder, stateMachine, Unw5bFvxwWo77ob06gG.pu1vzRbpYU);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	private static Action<Exception>? LHx3IV5smF;

	private static bool akO33kqXVF;

	public static void SafeFireAndForget(this ValueTask task, in Action<Exception>? onException = null, in bool continueOnCapturedContext = false)
	{
		kKhIfjep77(task, continueOnCapturedContext, onException);
	}

	public static void SafeFireAndForget<TException>(this ValueTask task, in Action<TException>? onException = null, in bool continueOnCapturedContext = false) where TException : Exception
	{
		kKhIfjep77(task, continueOnCapturedContext, onException);
	}

	public static void SafeFireAndForget(this Task task, in Action<Exception>? onException = null, in bool continueOnCapturedContext = false)
	{
		U56IzjKUuW(task, continueOnCapturedContext, onException);
	}

	public static void SafeFireAndForget<TException>(this Task task, in Action<TException>? onException = null, in bool continueOnCapturedContext = false) where TException : Exception
	{
		U56IzjKUuW(task, continueOnCapturedContext, onException);
	}

	[Obsolete("Use SafeFireAndForget(Action<Exception> onException, bool continueOnCapturedContext)")]
	public static void SafeFireAndForget(this ValueTask task, in bool continueOnCapturedContext, in Action<Exception>? onException)
	{
		kKhIfjep77(task, continueOnCapturedContext, onException);
	}

	[Obsolete("Use SafeFireAndForget<TException>(Action<TException> onException, bool continueOnCapturedContext)")]
	public static void SafeFireAndForget<TException>(this ValueTask task, in bool continueOnCapturedContext, in Action<TException>? onException) where TException : Exception
	{
		kKhIfjep77(task, continueOnCapturedContext, onException);
	}

	[Obsolete("Use SafeFireAndForget(Action<Exception> onException, bool continueOnCapturedContext)")]
	public static void SafeFireAndForget(this Task task, in bool continueOnCapturedContext, in Action<Exception>? onException)
	{
		U56IzjKUuW(task, continueOnCapturedContext, onException);
	}

	[Obsolete("Use SafeFireAndForget<TException>(Action<TException> onException, bool continueOnCapturedContext)")]
	public static void SafeFireAndForget<TException>(this Task task, in bool continueOnCapturedContext, in Action<TException>? onException) where TException : Exception
	{
		U56IzjKUuW(task, continueOnCapturedContext, onException);
	}

	public static void Initialize(in bool shouldAlwaysRethrowException = false)
	{
		akO33kqXVF = shouldAlwaysRethrowException;
	}

	public static void RemoveDefaultExceptionHandling()
	{
		LHx3IV5smF = null;
	}

	public static void SetDefaultExceptionHandling(in Action<Exception> onException)
	{
		if (onException == null)
		{
			throw new ArgumentNullException(q2no0WnPxDaipZawxT.IB3tMMvyI(448, q2no0WnPxDaipZawxT.eV4vC1LZv), VM8DfntskmEkKcjRStC.IB3tMMvyI(q2no0WnPxDaipZawxT.IB3tMMvyI(474, q2no0WnPxDaipZawxT.eV4vC1LZv), onException, VM8DfntskmEkKcjRStC.gM4txVms5B));
		}
		LHx3IV5smF = onException;
	}

	[AsyncStateMachine(typeof(_003CHandleSafeFireAndForget_003Ed__13<>))]
	private static void kKhIfjep77<XeJNulPE1Ns9jknx3g>(ValueTask P_0, bool P_1, Action<XeJNulPE1Ns9jknx3g>? onException) where XeJNulPE1Ns9jknx3g : Exception
	{
		_003CHandleSafeFireAndForget_003Ed__13<XeJNulPE1Ns9jknx3g> stateMachine = default(_003CHandleSafeFireAndForget_003Ed__13<XeJNulPE1Ns9jknx3g>);
		stateMachine._003C_003Et__builder = LtrZOBgtDQu4ZiGsfCS.IB3tMMvyI(LtrZOBgtDQu4ZiGsfCS.MK5ggjQiHZ);
		stateMachine.valueTask = P_0;
		stateMachine.continueOnCapturedContext = P_1;
		stateMachine.onException = onException;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003CHandleSafeFireAndForget_003Ed__14<>))]
	private static void U56IzjKUuW<btEIgCan2LRNOYTYkE>(Task P_0, bool P_1, Action<btEIgCan2LRNOYTYkE>? onException) where btEIgCan2LRNOYTYkE : Exception
	{
		_003CHandleSafeFireAndForget_003Ed__14<btEIgCan2LRNOYTYkE> stateMachine = default(_003CHandleSafeFireAndForget_003Ed__14<btEIgCan2LRNOYTYkE>);
		stateMachine._003C_003Et__builder = LtrZOBgtDQu4ZiGsfCS.IB3tMMvyI(LtrZOBgtDQu4ZiGsfCS.MK5ggjQiHZ);
		stateMachine.task = P_0;
		stateMachine.continueOnCapturedContext = P_1;
		stateMachine.onException = onException;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private static void yKI3NJ8Aro<e6gUyEHZbBXJlUBjqS>(in e6gUyEHZbBXJlUBjqS exception, in Action<e6gUyEHZbBXJlUBjqS>? onException) where e6gUyEHZbBXJlUBjqS : Exception
	{
		LHx3IV5smF?.Invoke(exception);
		onException?.Invoke(exception);
	}
}
