using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using PROTV.Abstractions.Apis;
using PROTV.Abstractions.Common;
using PROTV.Abstractions.DataTransferObjects;
using PROTV.Abstractions.Helpers;
using PROTV.Abstractions.Search;
using PROTV.Abstractions.Services;
using PROTV.Wpf.Bootstrap;

namespace PROTV.Wpf.ViewModels;

public class LivePlayerViewModel : FFMEBaseViewModel<ChannelResponseDto>
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnShowFavoritesExcute_003Ed__48 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public LivePlayerViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			LivePlayerViewModel CS_0024_003C_003E8__locals3 = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(W7S2sip6SDieZFVsNbd.D35lls5iF(CS_0024_003C_003E8__locals3, Expression.Lambda<Func<bool>>(OWBKr5pvc5MWsK1OMtR.D35lls5iF(o4bYL4peNeC2wWb8yjx.D35lls5iF(CS_0024_003C_003E8__locals3, sjYxHO8OWlc6X80hFj7.D35lls5iF(typeof(LivePlayerViewModel).TypeHandle, sjYxHO8OWlc6X80hFj7.uWZ8ugU7r5), o4bYL4peNeC2wWb8yjx.oVdpGKjy2x), (MethodInfo)f5q427pRQZnrEKPy4Ws.D35lls5iF((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, f5q427pRQZnrEKPy4Ws.Bo9pk3m4k7), OWBKr5pvc5MWsK1OMtR.fZIpAAdi1v), Array.Empty<ParameterExpression>()), [AsyncStateMachine(typeof(_003C_003COnShowFavoritesExcute_003Eb__48_1_003Ed))] () =>
					{
						_003C_003COnShowFavoritesExcute_003Eb__48_1_003Ed stateMachine = default(_003C_003COnShowFavoritesExcute_003Eb__48_1_003Ed);
						stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
						stateMachine._003C_003E4__this = CS_0024_003C_003E8__locals3;
						stateMachine._003C_003E1__state = -1;
						stateMachine._003C_003Et__builder.Start(ref stateMachine);
						return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
					}, W7S2sip6SDieZFVsNbd.XWappgVyfh), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
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
	private struct _003COnShowAllExcute_003Ed__49 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public LivePlayerViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			LivePlayerViewModel livePlayerViewModel = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					livePlayerViewModel.hSDICh57Nk = hB8t9uC6c022dNynAqg.D35lls5iF(livePlayerViewModel, hB8t9uC6c022dNynAqg.tELa5opkHb).FirstOrDefault();
					qni3xrDkAJ3vF35eMav.D35lls5iF(livePlayerViewModel, iFZ5je3XFYKwkvcE5D.D35lls5iF(8238, iFZ5je3XFYKwkvcE5D.N06TeK0ao), qni3xrDkAJ3vF35eMav.QN6DuDtCWO);
					m5sZxWmLHUhVHrJe8sC.D35lls5iF(livePlayerViewModel, "", m5sZxWmLHUhVHrJe8sC.qomaz5q0g8);
					AJv70itXcdnxnNYjSQ.D35lls5iF(AppContainer.Resolve<HomeViewModel>(), AJv70itXcdnxnNYjSQ.BiKHcjQZJT);
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(CRMxYv82mIBQFuWGeba.D35lls5iF(livePlayerViewModel, CRMxYv82mIBQFuWGeba.v0hECx54Pl), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
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
	private struct _003COnAddToFavoriteCommandExcute_003Ed__50 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public LivePlayerViewModel _003C_003E4__this;

		public ChannelResponseDto dto;

		private TaskAwaiter<bool> _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			LivePlayerViewModel livePlayerViewModel = _003C_003E4__this;
			try
			{
				TaskAwaiter<bool> awaiter;
				if (num != 0)
				{
					awaiter = VbmtIFmnFwg9sqb4Jje.D35lls5iF(livePlayerViewModel.VtkIAw02k2, WJbFtI6AObf2rNffLCy.D35lls5iF(dto, WJbFtI6AObf2rNffLCy.qCoaNOcwbA), VbmtIFmnFwg9sqb4Jje.TRymhqqh6j).GetAwaiter();
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
					_003C_003Eu__1 = default(TaskAwaiter<bool>);
					num = (_003C_003E1__state = -1);
				}
				if (awaiter.GetResult())
				{
					jPB9Q5LdIM9wsuWV1q7.D35lls5iF(dto, !LsA6RHpKkbdnOn3fX60.D35lls5iF(dto, LsA6RHpKkbdnOn3fX60.BpyauT9ebS), jPB9Q5LdIM9wsuWV1q7.CyqIo4QxKN);
					m5sZxWmLHUhVHrJe8sC.D35lls5iF(dto, iFZ5je3XFYKwkvcE5D.D35lls5iF(8354, iFZ5je3XFYKwkvcE5D.N06TeK0ao), m5sZxWmLHUhVHrJe8sC.DJlIlQXefy);
				}
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

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass51_0
	{
		public int e7efqUPN5p;

		public _003C_003Ec__DisplayClass51_0()
		{
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
			base._002Ector();
		}

		internal bool mu4fPO1pSM(ChannelResponseDto x)
		{
			return WJbFtI6AObf2rNffLCy.D35lls5iF(x, WJbFtI6AObf2rNffLCy.hyPacPXw9c) == e7efqUPN5p;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLoadAsync_003Ed__51 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public LivePlayerViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			LivePlayerViewModel CS_0024_003C_003E8__locals3 = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(W7S2sip6SDieZFVsNbd.D35lls5iF(CS_0024_003C_003E8__locals3, Expression.Lambda<Func<bool>>(OWBKr5pvc5MWsK1OMtR.D35lls5iF(o4bYL4peNeC2wWb8yjx.D35lls5iF(CS_0024_003C_003E8__locals3, sjYxHO8OWlc6X80hFj7.D35lls5iF(typeof(LivePlayerViewModel).TypeHandle, sjYxHO8OWlc6X80hFj7.uWZ8ugU7r5), o4bYL4peNeC2wWb8yjx.oVdpGKjy2x), (MethodInfo)f5q427pRQZnrEKPy4Ws.D35lls5iF((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, f5q427pRQZnrEKPy4Ws.Bo9pk3m4k7), OWBKr5pvc5MWsK1OMtR.fZIpAAdi1v), Array.Empty<ParameterExpression>()), [AsyncStateMachine(typeof(_003C_003CLoadAsync_003Eb__51_1_003Ed))] () =>
					{
						_003C_003CLoadAsync_003Eb__51_1_003Ed stateMachine = default(_003C_003CLoadAsync_003Eb__51_1_003Ed);
						stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
						stateMachine._003C_003E4__this = CS_0024_003C_003E8__locals3;
						stateMachine._003C_003E1__state = -1;
						stateMachine._003C_003Et__builder.Start(ref stateMachine);
						return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
					}, W7S2sip6SDieZFVsNbd.XWappgVyfh), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
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
	private struct _003COnOpenCommandExcuteAsync_003Ed__53 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ChannelResponseDto obj;

		public LivePlayerViewModel _003C_003E4__this;

		private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			LivePlayerViewModel livePlayerViewModel = _003C_003E4__this;
			try
			{
				if (num == 0 || this.obj != null)
				{
					try
					{
						ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter awaiter;
						if (num != 0)
						{
							if (GmMLaTD7kV8rq88ZFvR.D35lls5iF(xrWtp71MaQsXtvtrqkf.D35lls5iF(Jr0pTQlovwB9pdID1EB.D35lls5iF(Jr0pTQlovwB9pdID1EB.CxrllgXtD4), xrWtp71MaQsXtvtrqkf.fxR1SMKb5A), iFZ5je3XFYKwkvcE5D.D35lls5iF(16466, iFZ5je3XFYKwkvcE5D.N06TeK0ao), GmMLaTD7kV8rq88ZFvR.VGG1KpDfXX))
							{
								EyxbpBGMcaXD02sIi7w.D35lls5iF(xrWtp71MaQsXtvtrqkf.D35lls5iF(Jr0pTQlovwB9pdID1EB.D35lls5iF(Jr0pTQlovwB9pdID1EB.CxrllgXtD4), xrWtp71MaQsXtvtrqkf.fxR1SMKb5A), iFZ5je3XFYKwkvcE5D.D35lls5iF(16466, iFZ5je3XFYKwkvcE5D.N06TeK0ao), WJbFtI6AObf2rNffLCy.D35lls5iF(this.obj, WJbFtI6AObf2rNffLCy.hyPacPXw9c), EyxbpBGMcaXD02sIi7w.z9EGSdF6KF);
							}
							else
							{
								EyxbpBGMcaXD02sIi7w.D35lls5iF(xrWtp71MaQsXtvtrqkf.D35lls5iF(Jr0pTQlovwB9pdID1EB.D35lls5iF(Jr0pTQlovwB9pdID1EB.CxrllgXtD4), xrWtp71MaQsXtvtrqkf.fxR1SMKb5A), iFZ5je3XFYKwkvcE5D.D35lls5iF(16466, iFZ5je3XFYKwkvcE5D.N06TeK0ao), WJbFtI6AObf2rNffLCy.D35lls5iF(this.obj, WJbFtI6AObf2rNffLCy.hyPacPXw9c), EyxbpBGMcaXD02sIi7w.y9uGuhNJgc);
							}
							string uriString = pnvE8rm9NRTK7Tblimu.D35lls5iF(new Uri(UwSEfC4rh9eVlFenwI.D35lls5iF(pnvE8rm9NRTK7Tblimu.D35lls5iF(this.obj, pnvE8rm9NRTK7Tblimu.NX1aPvwpkZ), pnvE8rm9NRTK7Tblimu.D35lls5iF(this.obj, pnvE8rm9NRTK7Tblimu.rhPaSybJPG), UwSEfC4rh9eVlFenwI.J6G3NC9nSO)), pnvE8rm9NRTK7Tblimu.fnLajxXY1u);
							awaiter = mchHD5pbvoLh6YJmlai.D35lls5iF(livePlayerViewModel.MediaElement, new Uri(uriString), mchHD5pbvoLh6YJmlai.ahJpW0oay7).GetAwaiter();
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
					catch
					{
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

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003C_003Cset_SelectedSort_003Eb__36_0_003Ed : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public LivePlayerViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			LivePlayerViewModel livePlayerViewModel = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(CRMxYv82mIBQFuWGeba.D35lls5iF(livePlayerViewModel, CRMxYv82mIBQFuWGeba.v0hECx54Pl), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
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
	private struct _003C_003Cset_SelectedOrder_003Eb__39_0_003Ed : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public LivePlayerViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			LivePlayerViewModel livePlayerViewModel = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(CRMxYv82mIBQFuWGeba.D35lls5iF(livePlayerViewModel, CRMxYv82mIBQFuWGeba.v0hECx54Pl), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
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
	private struct _003C_003Cset_SelectedCategory_003Eb__46_0_003Ed : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public LivePlayerViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			LivePlayerViewModel livePlayerViewModel = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(CRMxYv82mIBQFuWGeba.D35lls5iF(livePlayerViewModel, CRMxYv82mIBQFuWGeba.v0hECx54Pl), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
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
	private struct _003C_003COnShowFavoritesExcute_003Eb__48_1_003Ed : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public LivePlayerViewModel _003C_003E4__this;

		private TaskAwaiter<ResponseList<ChannelResponseDto>> _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			LivePlayerViewModel livePlayerViewModel = _003C_003E4__this;
			try
			{
				try
				{
					TaskAwaiter<ResponseList<ChannelResponseDto>> awaiter;
					if (num != 0)
					{
						livePlayerViewModel.PlayerPlaylistViewModel.Items.Clear();
						int? num2 = null;
						if (npGiF9I90uLJYypm8ux.D35lls5iF(livePlayerViewModel, npGiF9I90uLJYypm8ux.MxWIDc6Kyu) == ChannelType.TV)
						{
							num2 = WJbFtI6AObf2rNffLCy.D35lls5iF(Yvn1Up49INfjZEB4hak.D35lls5iF(livePlayerViewModel.GolIu61GTb, Yvn1Up49INfjZEB4hak.BEo4DRQpp2), WJbFtI6AObf2rNffLCy.eWxIHAQe6d);
						}
						ILiveService vtkIAw02k = livePlayerViewModel.VtkIAw02k2;
						ApiQuery<ChannelSearch, ChannelSort> apiQuery = new ApiQuery<ChannelSearch, ChannelSort>();
						ChannelSearch channelSearch = new ChannelSearch();
						wuXoja6xGA4YsTL6UdU.D35lls5iF(channelSearch, num2, wuXoja6xGA4YsTL6UdU.gvea6e2Tqs);
						wxrXAGapPwbqHYAUjYV.D35lls5iF(channelSearch, npGiF9I90uLJYypm8ux.D35lls5iF(livePlayerViewModel, npGiF9I90uLJYypm8ux.MxWIDc6Kyu), wxrXAGapPwbqHYAUjYV.DpCawCviZ2);
						hH6DVMBvgw3ANNRyBk6.D35lls5iF(channelSearch, pnvE8rm9NRTK7Tblimu.D35lls5iF(livePlayerViewModel, pnvE8rm9NRTK7Tblimu.xDsI1UurfP), hH6DVMBvgw3ANNRyBk6.RRK6ishEFm);
						CategoryResponseDto categoryResponseDto = FiOhPVaCHXLXNUl5Yfo.D35lls5iF(livePlayerViewModel, FiOhPVaCHXLXNUl5Yfo.fdeI8Gb5di);
						wuXoja6xGA4YsTL6UdU.D35lls5iF(channelSearch, (categoryResponseDto != null) ? V4VMaWmQYRpUqEIxujB.D35lls5iF(categoryResponseDto, V4VMaWmQYRpUqEIxujB.rPoaaBpdTR) : ((int?)null), wuXoja6xGA4YsTL6UdU.QntaINmy9f);
						apiQuery.Search = channelSearch;
						apiQuery.Count = -1;
						apiQuery.Sort = J8Yr49ae48LPDydLJyE.D35lls5iF(livePlayerViewModel, J8Yr49ae48LPDydLJyE.BbkIn7KQ3v);
						apiQuery.Order = pM83UjaR84HYRVNsL5f.D35lls5iF(livePlayerViewModel, pM83UjaR84HYRVNsL5f.P3sI3qSZ3B);
						awaiter = DvNS3lad39MZYy86AET.D35lls5iF(vtkIAw02k, apiQuery, DvNS3lad39MZYy86AET.RB3IT9SbiO).GetAwaiter();
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
						_003C_003Eu__1 = default(TaskAwaiter<ResponseList<ChannelResponseDto>>);
						num = (_003C_003E1__state = -1);
					}
					ResponseList<ChannelResponseDto> result = awaiter.GetResult();
					if (result != null && result.Status)
					{
						IEnumerator<ChannelResponseDto> enumerator = result.Data.Result.GetEnumerator();
						try
						{
							while (hjMnupQVVDlRZAYQJC.D35lls5iF(enumerator, hjMnupQVVDlRZAYQJC.QV1TFwytOj))
							{
								ChannelResponseDto current = enumerator.Current;
								livePlayerViewModel.PlayerPlaylistViewModel.Items.Add(current);
							}
						}
						finally
						{
							if (num < 0 && enumerator != null)
							{
								xLO56JniGyickVjO1Ot.D35lls5iF(enumerator, xLO56JniGyickVjO1Ot.ydbT2bsoH4);
							}
						}
					}
				}
				catch (PROTVException)
				{
				}
			}
			catch (Exception ex2)
			{
				_003C_003E1__state = -2;
				NNK1eXA7fWQ87oSUty7.D35lls5iF(ref _003C_003Et__builder, ex2, NNK1eXA7fWQ87oSUty7.G3EAcW9Om7);
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
	private struct _003C_003CLoadAsync_003Eb__51_1_003Ed : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public LivePlayerViewModel _003C_003E4__this;

		private TaskAwaiter<ResponseList<ChannelResponseDto>> _003C_003Eu__1;

		private TaskAwaiter<ResponseList<CategoryResponseDto>> _003C_003Eu__2;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			LivePlayerViewModel livePlayerViewModel = _003C_003E4__this;
			try
			{
				_ = 1;
				try
				{
					TaskAwaiter<ResponseList<CategoryResponseDto>> awaiter;
					TaskAwaiter<ResponseList<ChannelResponseDto>> awaiter2;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = _003C_003Eu__2;
							_003C_003Eu__2 = default(TaskAwaiter<ResponseList<CategoryResponseDto>>);
							num = (_003C_003E1__state = -1);
							goto IL_0389;
						}
						livePlayerViewModel.PlayerPlaylistViewModel.Items.Clear();
						int? num2 = null;
						if (npGiF9I90uLJYypm8ux.D35lls5iF(livePlayerViewModel, npGiF9I90uLJYypm8ux.MxWIDc6Kyu) == ChannelType.TV)
						{
							num2 = WJbFtI6AObf2rNffLCy.D35lls5iF(Yvn1Up49INfjZEB4hak.D35lls5iF(livePlayerViewModel.GolIu61GTb, Yvn1Up49INfjZEB4hak.BEo4DRQpp2), WJbFtI6AObf2rNffLCy.eWxIHAQe6d);
						}
						ILiveService vtkIAw02k = livePlayerViewModel.VtkIAw02k2;
						ApiQuery<ChannelSearch, ChannelSort> apiQuery = new ApiQuery<ChannelSearch, ChannelSort>();
						ChannelSearch channelSearch = new ChannelSearch();
						wuXoja6xGA4YsTL6UdU.D35lls5iF(channelSearch, num2, wuXoja6xGA4YsTL6UdU.gvea6e2Tqs);
						wxrXAGapPwbqHYAUjYV.D35lls5iF(channelSearch, npGiF9I90uLJYypm8ux.D35lls5iF(livePlayerViewModel, npGiF9I90uLJYypm8ux.MxWIDc6Kyu), wxrXAGapPwbqHYAUjYV.DpCawCviZ2);
						hH6DVMBvgw3ANNRyBk6.D35lls5iF(channelSearch, pnvE8rm9NRTK7Tblimu.D35lls5iF(livePlayerViewModel, pnvE8rm9NRTK7Tblimu.xDsI1UurfP), hH6DVMBvgw3ANNRyBk6.RRK6ishEFm);
						CategoryResponseDto categoryResponseDto = FiOhPVaCHXLXNUl5Yfo.D35lls5iF(livePlayerViewModel, FiOhPVaCHXLXNUl5Yfo.fdeI8Gb5di);
						wuXoja6xGA4YsTL6UdU.D35lls5iF(channelSearch, (categoryResponseDto != null) ? V4VMaWmQYRpUqEIxujB.D35lls5iF(categoryResponseDto, V4VMaWmQYRpUqEIxujB.rPoaaBpdTR) : ((int?)null), wuXoja6xGA4YsTL6UdU.QntaINmy9f);
						apiQuery.Search = channelSearch;
						apiQuery.Count = -1;
						apiQuery.Sort = J8Yr49ae48LPDydLJyE.D35lls5iF(livePlayerViewModel, J8Yr49ae48LPDydLJyE.BbkIn7KQ3v);
						apiQuery.Order = pM83UjaR84HYRVNsL5f.D35lls5iF(livePlayerViewModel, pM83UjaR84HYRVNsL5f.P3sI3qSZ3B);
						awaiter2 = DvNS3lad39MZYy86AET.D35lls5iF(vtkIAw02k, apiQuery, DvNS3lad39MZYy86AET.cL8aU2Q10h).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = (_003C_003E1__state = 0);
							_003C_003Eu__1 = awaiter2;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						}
					}
					else
					{
						awaiter2 = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter<ResponseList<ChannelResponseDto>>);
						num = (_003C_003E1__state = -1);
					}
					ResponseList<ChannelResponseDto> result = awaiter2.GetResult();
					if (result != null && result.Status)
					{
						IEnumerator<ChannelResponseDto> enumerator = result.Data.Result.GetEnumerator();
						try
						{
							while (hjMnupQVVDlRZAYQJC.D35lls5iF(enumerator, hjMnupQVVDlRZAYQJC.QV1TFwytOj))
							{
								ChannelResponseDto current = enumerator.Current;
								livePlayerViewModel.PlayerPlaylistViewModel.Items.Add(current);
							}
						}
						finally
						{
							if (num < 0 && enumerator != null)
							{
								xLO56JniGyickVjO1Ot.D35lls5iF(enumerator, xLO56JniGyickVjO1Ot.ydbT2bsoH4);
							}
						}
						if (!uEUVCI48fycroqgRFqy.D35lls5iF(livePlayerViewModel.MediaElement, uEUVCI48fycroqgRFqy.RIVAOZeovq))
						{
							if (GmMLaTD7kV8rq88ZFvR.D35lls5iF(xrWtp71MaQsXtvtrqkf.D35lls5iF(Jr0pTQlovwB9pdID1EB.D35lls5iF(Jr0pTQlovwB9pdID1EB.CxrllgXtD4), xrWtp71MaQsXtvtrqkf.fxR1SMKb5A), iFZ5je3XFYKwkvcE5D.D35lls5iF(16466, iFZ5je3XFYKwkvcE5D.N06TeK0ao), GmMLaTD7kV8rq88ZFvR.VGG1KpDfXX))
							{
								_003C_003Ec__DisplayClass51_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass51_0();
								CS_0024_003C_003E8__locals2.e7efqUPN5p = arHqIuLQE32UGutIac7.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(auEPOZ1NWYKXdU711jq.D35lls5iF(xrWtp71MaQsXtvtrqkf.D35lls5iF(Jr0pTQlovwB9pdID1EB.D35lls5iF(Jr0pTQlovwB9pdID1EB.CxrllgXtD4), xrWtp71MaQsXtvtrqkf.fxR1SMKb5A), iFZ5je3XFYKwkvcE5D.D35lls5iF(16466, iFZ5je3XFYKwkvcE5D.N06TeK0ao), auEPOZ1NWYKXdU711jq.Y1J1OKa53W), wq2usy8gNndpuTw5mR.ajcDe8nffb), arHqIuLQE32UGutIac7.Fa2LXljLFk);
								livePlayerViewModel.PlayerPlaylistViewModel.SelectedItem = livePlayerViewModel.PlayerPlaylistViewModel.Items.FirstOrDefault((ChannelResponseDto x) => WJbFtI6AObf2rNffLCy.D35lls5iF(x, WJbFtI6AObf2rNffLCy.hyPacPXw9c) == CS_0024_003C_003E8__locals2.e7efqUPN5p);
							}
							else
							{
								livePlayerViewModel.PlayerPlaylistViewModel.SelectedItem = livePlayerViewModel.PlayerPlaylistViewModel.Items.FirstOrDefault();
							}
						}
					}
					if (hB8t9uC6c022dNynAqg.D35lls5iF(livePlayerViewModel, hB8t9uC6c022dNynAqg.tELa5opkHb).Count == 0)
					{
						IAppService niLINQfamm = livePlayerViewModel.NiLINQfamm;
						ApiQuery<CategorySearch, GeneralSort> obj = new ApiQuery<CategorySearch, GeneralSort>
						{
							Count = -1,
							Sort = GeneralSort.Name
						};
						CategorySearch categorySearch = new CategorySearch();
						PDE695CGbWQ6wS7etBU.D35lls5iF(categorySearch, CategoryType.Channel, PDE695CGbWQ6wS7etBU.rt7CRxAZ59);
						obj.Search = categorySearch;
						obj.Order = SortOrder.Asc;
						awaiter = GEHLO0CkuIP8aA9CV10.D35lls5iF(niLINQfamm, obj, GEHLO0CkuIP8aA9CV10.AXeCvbp3sh).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (_003C_003E1__state = 1);
							_003C_003Eu__2 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_0389;
					}
					goto end_IL_001a;
					IL_0389:
					ResponseList<CategoryResponseDto> result2 = awaiter.GetResult();
					if (result2 != null && result2.Status)
					{
						fbCfXAT6sNT7gTw1IjA.D35lls5iF(livePlayerViewModel, result2.Data.Result.ToList(), fbCfXAT6sNT7gTw1IjA.GFgEvKZGaq);
						qni3xrDkAJ3vF35eMav.D35lls5iF(livePlayerViewModel, iFZ5je3XFYKwkvcE5D.D35lls5iF(16172, iFZ5je3XFYKwkvcE5D.N06TeK0ao), qni3xrDkAJ3vF35eMav.QN6DuDtCWO);
					}
					end_IL_001a:;
				}
				catch (PROTVException)
				{
				}
			}
			catch (Exception ex2)
			{
				_003C_003E1__state = -2;
				NNK1eXA7fWQ87oSUty7.D35lls5iF(ref _003C_003Et__builder, ex2, NNK1eXA7fWQ87oSUty7.G3EAcW9Om7);
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

	private IStoreContext GolIu61GTb;

	private ILiveService VtkIAw02k2;

	private IAppService NiLINQfamm;

	private ChannelSort ed1IMT6Jxu;

	private CategoryResponseDto hSDICh57Nk;

	private SortOrder sBqIYXE0XJ;

	[CompilerGenerated]
	private List<ChannelSort> NbIIFPj8XL;

	[CompilerGenerated]
	private ChannelType dxbI66WyYH;

	[CompilerGenerated]
	private List<CategoryResponseDto> m8QIsmdYGd;

	[CompilerGenerated]
	private ICommand LPtIx7TB6R;

	[CompilerGenerated]
	private ICommand EWIIySlZC6;

	[CompilerGenerated]
	private ICommand FhZIpFe8Bk;

	[CompilerGenerated]
	private string aCBIiiUKeL;

	[CompilerGenerated]
	private List<SortOrder> Oj6I3QdwOt;

	public List<ChannelSort> SortItems
	{
		[CompilerGenerated]
		get
		{
			return NbIIFPj8XL;
		}
		[CompilerGenerated]
		set
		{
			NbIIFPj8XL = value;
		}
	}

	public ChannelType ChannelType
	{
		[CompilerGenerated]
		get
		{
			return dxbI66WyYH;
		}
		[CompilerGenerated]
		set
		{
			dxbI66WyYH = value;
		}
	}

	public List<CategoryResponseDto> Categories
	{
		[CompilerGenerated]
		get
		{
			return m8QIsmdYGd;
		}
		[CompilerGenerated]
		set
		{
			m8QIsmdYGd = value;
		}
	}

	public ICommand AddToFavorite
	{
		[CompilerGenerated]
		get
		{
			return LPtIx7TB6R;
		}
		[CompilerGenerated]
		set
		{
			LPtIx7TB6R = value;
		}
	}

	public ICommand ShowFavorites
	{
		[CompilerGenerated]
		get
		{
			return EWIIySlZC6;
		}
		[CompilerGenerated]
		set
		{
			EWIIySlZC6 = value;
		}
	}

	public ICommand ShowAll
	{
		[CompilerGenerated]
		get
		{
			return FhZIpFe8Bk;
		}
		[CompilerGenerated]
		set
		{
			FhZIpFe8Bk = value;
		}
	}

	public string Search
	{
		[CompilerGenerated]
		get
		{
			return aCBIiiUKeL;
		}
		[CompilerGenerated]
		set
		{
			aCBIiiUKeL = value;
		}
	}

	public ChannelSort SelectedSort
	{
		get
		{
			return ed1IMT6Jxu;
		}
		set
		{
			SetProperty(ref ed1IMT6Jxu, value, iFZ5je3XFYKwkvcE5D.D35lls5iF(10222, iFZ5je3XFYKwkvcE5D.N06TeK0ao), null, [AsyncStateMachine(typeof(_003C_003Cset_SelectedSort_003Eb__36_0_003Ed))] () =>
			{
				_003C_003Cset_SelectedSort_003Eb__36_0_003Ed stateMachine = default(_003C_003Cset_SelectedSort_003Eb__36_0_003Ed);
				stateMachine._003C_003Et__builder = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
				stateMachine._003C_003E4__this = this;
				stateMachine._003C_003E1__state = -1;
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
			});
		}
	}

	public SortOrder SelectedOrder
	{
		get
		{
			return sBqIYXE0XJ;
		}
		set
		{
			SetProperty(ref sBqIYXE0XJ, value, iFZ5je3XFYKwkvcE5D.D35lls5iF(8208, iFZ5je3XFYKwkvcE5D.N06TeK0ao), null, [AsyncStateMachine(typeof(_003C_003Cset_SelectedOrder_003Eb__39_0_003Ed))] () =>
			{
				_003C_003Cset_SelectedOrder_003Eb__39_0_003Ed stateMachine = default(_003C_003Cset_SelectedOrder_003Eb__39_0_003Ed);
				stateMachine._003C_003Et__builder = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
				stateMachine._003C_003E4__this = this;
				stateMachine._003C_003E1__state = -1;
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
			});
		}
	}

	public List<SortOrder> OrderItems
	{
		[CompilerGenerated]
		get
		{
			return Oj6I3QdwOt;
		}
		[CompilerGenerated]
		set
		{
			Oj6I3QdwOt = value;
		}
	}

	public CategoryResponseDto SelectedCategory
	{
		get
		{
			return hSDICh57Nk;
		}
		set
		{
			SetProperty(ref hSDICh57Nk, value, iFZ5je3XFYKwkvcE5D.D35lls5iF(8238, iFZ5je3XFYKwkvcE5D.N06TeK0ao), null, [AsyncStateMachine(typeof(_003C_003Cset_SelectedCategory_003Eb__46_0_003Ed))] () =>
			{
				_003C_003Cset_SelectedCategory_003Eb__46_0_003Ed stateMachine = default(_003C_003Cset_SelectedCategory_003Eb__46_0_003Ed);
				stateMachine._003C_003Et__builder = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
				stateMachine._003C_003E4__this = this;
				stateMachine._003C_003E1__state = -1;
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
			});
		}
	}

	public LivePlayerViewModel()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector();
		gJ6gKZTeY7mmAUBnpmH.D35lls5iF(this, new List<ChannelSort>
		{
			ChannelSort.Name,
			ChannelSort.Number
		}, gJ6gKZTeY7mmAUBnpmH.UFsERbtxsv);
		DlVmjNTRaTpEdNDM6pX.D35lls5iF(this, new List<SortOrder>
		{
			SortOrder.Asc,
			SortOrder.Desc
		}, DlVmjNTRaTpEdNDM6pX.D35Ek9jjD0);
		fbCfXAT6sNT7gTw1IjA.D35lls5iF(this, new List<CategoryResponseDto>(), fbCfXAT6sNT7gTw1IjA.GFgEvKZGaq);
		ed1IMT6Jxu = ChannelSort.Number;
		sBqIYXE0XJ = SortOrder.Asc;
		KFPqfXEA4bOmtrXTkLA.D35lls5iF(this, new AsyncCommand<ChannelResponseDto>(g89I83g1Yr), KFPqfXEA4bOmtrXTkLA.dLFE6iyGiI);
		KFPqfXEA4bOmtrXTkLA.D35lls5iF(this, new AsyncCommand(gxqIKqWfIU), KFPqfXEA4bOmtrXTkLA.TdqEpVt0Ro);
		KFPqfXEA4bOmtrXTkLA.D35lls5iF(this, new AsyncCommand(AjlIk2ayr6), KFPqfXEA4bOmtrXTkLA.JCEEw7LkUD);
		NiLINQfamm = AppContainer.Resolve<IAppService>();
		VtkIAw02k2 = AppContainer.Resolve<ILiveService>();
		GolIu61GTb = AppContainer.Resolve<IStoreContext>();
		base.PlayerPlaylistViewModel = new PlayerPlaylistViewModel<ChannelResponseDto>(this);
		base.Controller = new ControllerViewModel<ChannelResponseDto>(this)
		{
			SeekBarVisibility = Visibility.Collapsed,
			PostionProgressVisibility = Visibility.Collapsed,
			OpenSettingPanelVisibility = Visibility.Visible
		};
	}

	[AsyncStateMachine(typeof(_003COnShowFavoritesExcute_003Ed__48))]
	private Task gxqIKqWfIU()
	{
		_003COnShowFavoritesExcute_003Ed__48 stateMachine = default(_003COnShowFavoritesExcute_003Ed__48);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	[AsyncStateMachine(typeof(_003COnShowAllExcute_003Ed__49))]
	private Task AjlIk2ayr6()
	{
		_003COnShowAllExcute_003Ed__49 stateMachine = default(_003COnShowAllExcute_003Ed__49);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	[AsyncStateMachine(typeof(_003COnAddToFavoriteCommandExcute_003Ed__50))]
	private Task g89I83g1Yr(ChannelResponseDto P_0)
	{
		_003COnAddToFavoriteCommandExcute_003Ed__50 stateMachine = default(_003COnAddToFavoriteCommandExcute_003Ed__50);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine.dto = P_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	[AsyncStateMachine(typeof(_003CLoadAsync_003Ed__51))]
	public Task LoadAsync()
	{
		_003CLoadAsync_003Ed__51 stateMachine = default(_003CLoadAsync_003Ed__51);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	public override void OnLoading()
	{
		if (!base.PlayerPlaylistViewModel.Items.Any())
		{
			Task task = CRMxYv82mIBQFuWGeba.D35lls5iF(this, CRMxYv82mIBQFuWGeba.v0hECx54Pl);
			Action<Exception> action = null;
			bool flag = false;
			gBlEqv8jRKikCj2DMZp.D35lls5iF(task, ref action, ref flag, gBlEqv8jRKikCj2DMZp.pSp8ymt8Mu);
		}
	}

	[AsyncStateMachine(typeof(_003COnOpenCommandExcuteAsync_003Ed__53))]
	public override void OnOpenCommandExcuteAsync(ChannelResponseDto obj)
	{
		_003COnOpenCommandExcuteAsync_003Ed__53 stateMachine = default(_003COnOpenCommandExcuteAsync_003Ed__53);
		stateMachine._003C_003Et__builder = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
		stateMachine._003C_003E4__this = this;
		stateMachine.obj = obj;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003C_003Cset_SelectedSort_003Eb__36_0_003Ed))]
	[CompilerGenerated]
	private void Mw2IQMLVGK()
	{
		_003C_003Cset_SelectedSort_003Eb__36_0_003Ed stateMachine = default(_003C_003Cset_SelectedSort_003Eb__36_0_003Ed);
		stateMachine._003C_003Et__builder = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003C_003Cset_SelectedOrder_003Eb__39_0_003Ed))]
	[CompilerGenerated]
	private void gaWInAQji7()
	{
		_003C_003Cset_SelectedOrder_003Eb__39_0_003Ed stateMachine = default(_003C_003Cset_SelectedOrder_003Eb__39_0_003Ed);
		stateMachine._003C_003Et__builder = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003C_003Cset_SelectedCategory_003Eb__46_0_003Ed))]
	[CompilerGenerated]
	private void pb6IbHd4bs()
	{
		_003C_003Cset_SelectedCategory_003Eb__46_0_003Ed stateMachine = default(_003C_003Cset_SelectedCategory_003Eb__46_0_003Ed);
		stateMachine._003C_003Et__builder = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[CompilerGenerated]
	[AsyncStateMachine(typeof(_003C_003COnShowFavoritesExcute_003Eb__48_1_003Ed))]
	private Task MUYI7S7IA6()
	{
		_003C_003COnShowFavoritesExcute_003Eb__48_1_003Ed stateMachine = default(_003C_003COnShowFavoritesExcute_003Eb__48_1_003Ed);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	[CompilerGenerated]
	[AsyncStateMachine(typeof(_003C_003CLoadAsync_003Eb__51_1_003Ed))]
	private Task sXaI5WQdgt()
	{
		_003C_003CLoadAsync_003Eb__51_1_003Ed stateMachine = default(_003C_003CLoadAsync_003Eb__51_1_003Ed);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}
}
