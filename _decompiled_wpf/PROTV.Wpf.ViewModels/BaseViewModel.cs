using System;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using PROTV.Abstractions.Helpers;

namespace PROTV.Wpf.ViewModels;

public class BaseViewModel : ObservableObject
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRunCommand_003Ed__13 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Expression<Func<bool>> updatingFlag;

		public Func<Task> action;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			try
			{
				if (num == 0)
				{
					goto IL_0036;
				}
				if (!updatingFlag.GetPropertyValue())
				{
					updatingFlag.SetPropertyValue(value: true);
					goto IL_0036;
				}
				goto end_IL_000e;
				IL_0036:
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(action(), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
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
				}
				finally
				{
					if (num < 0)
					{
						updatingFlag.SetPropertyValue(value: false);
					}
				}
				end_IL_000e:;
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

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CWaitAndRunCommand_003Ed__14 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Expression<Func<bool>> updatingFlag;

		public Func<Task> action;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			try
			{
				if (num != 0)
				{
					if (num != 1)
					{
						goto IL_0092;
					}
					goto IL_00af;
				}
				TaskAwaiter awaiter = _003C_003Eu__1;
				_003C_003Eu__1 = default(TaskAwaiter);
				num = (_003C_003E1__state = -1);
				goto IL_0086;
				IL_0086:
				oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
				goto IL_0092;
				IL_00af:
				try
				{
					if (num != 1)
					{
						awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(action(), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
						if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
						{
							num = (_003C_003E1__state = 1);
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
				}
				finally
				{
					if (num < 0)
					{
						updatingFlag.SetPropertyValue(value: false);
					}
				}
				goto end_IL_000e;
				IL_0092:
				if (updatingFlag.GetPropertyValue())
				{
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(pvrKKy8Mk1kpdmIfp3A.D35lls5iF(5, pvrKKy8Mk1kpdmIfp3A.aVh8SPrFkE), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
					if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_0086;
				}
				updatingFlag.SetPropertyValue(value: true);
				goto IL_00af;
				end_IL_000e:;
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

	private bool LDABEogwDG;

	private string vtjB9OAVt8;

	public bool IsBusy
	{
		get
		{
			return LDABEogwDG;
		}
		set
		{
			SetProperty(ref LDABEogwDG, value, iFZ5je3XFYKwkvcE5D.D35lls5iF(8578, iFZ5je3XFYKwkvcE5D.N06TeK0ao), null, delegate
			{
				qni3xrDkAJ3vF35eMav.D35lls5iF(this, iFZ5je3XFYKwkvcE5D.D35lls5iF(8608, iFZ5je3XFYKwkvcE5D.N06TeK0ao), qni3xrDkAJ3vF35eMav.QN6DuDtCWO);
			});
		}
	}

	public string Title
	{
		get
		{
			return vtjB9OAVt8;
		}
		set
		{
			SetProperty(ref vtjB9OAVt8, value, iFZ5je3XFYKwkvcE5D.D35lls5iF(8594, iFZ5je3XFYKwkvcE5D.N06TeK0ao));
		}
	}

	public bool IsNotBusy => !hjMnupQVVDlRZAYQJC.D35lls5iF(this, hjMnupQVVDlRZAYQJC.jJYTSHn9tB);

	public BaseViewModel()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		vtjB9OAVt8 = string.Empty;
		base._002Ector();
	}

	public virtual void OnLoading()
	{
	}

	public virtual void OnUnLoading()
	{
	}

	[AsyncStateMachine(typeof(_003CRunCommand_003Ed__13))]
	protected Task RunCommand(Expression<Func<bool>> updatingFlag, Func<Task> action)
	{
		_003CRunCommand_003Ed__13 stateMachine = default(_003CRunCommand_003Ed__13);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine.updatingFlag = updatingFlag;
		stateMachine.action = action;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	[AsyncStateMachine(typeof(_003CWaitAndRunCommand_003Ed__14))]
	protected Task WaitAndRunCommand(Expression<Func<bool>> updatingFlag, Func<Task> action)
	{
		_003CWaitAndRunCommand_003Ed__14 stateMachine = default(_003CWaitAndRunCommand_003Ed__14);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine.updatingFlag = updatingFlag;
		stateMachine.action = action;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	[CompilerGenerated]
	private void UaDBwKupf6()
	{
		qni3xrDkAJ3vF35eMav.D35lls5iF(this, iFZ5je3XFYKwkvcE5D.D35lls5iF(8608, iFZ5je3XFYKwkvcE5D.N06TeK0ao), qni3xrDkAJ3vF35eMav.QN6DuDtCWO);
	}
}
