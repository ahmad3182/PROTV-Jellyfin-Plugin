using System;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using PROTV.Abstractions.Apis;
using PROTV.Abstractions.Common;
using PROTV.Abstractions.DataTransferObjects;
using PROTV.Abstractions.Helpers;
using PROTV.Wpf.Bootstrap;
using PROTV.Wpf.Helpers;

namespace PROTV.Wpf.ViewModels;

public class MovieItemViewModel : BaseViewModel
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnWatchTrailerCommandExcute_003Ed__21 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MovieItemViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			MovieItemViewModel CS_0024_003C_003E8__locals4 = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_00e4;
				}
				if (!LsA6RHpKkbdnOn3fX60.D35lls5iF(CS_0024_003C_003E8__locals4, LsA6RHpKkbdnOn3fX60.u9LwzIZ2P9))
				{
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(W7S2sip6SDieZFVsNbd.D35lls5iF(CS_0024_003C_003E8__locals4, Expression.Lambda<Func<bool>>(OWBKr5pvc5MWsK1OMtR.D35lls5iF(o4bYL4peNeC2wWb8yjx.D35lls5iF(CS_0024_003C_003E8__locals4, sjYxHO8OWlc6X80hFj7.D35lls5iF(typeof(MovieItemViewModel).TypeHandle, sjYxHO8OWlc6X80hFj7.uWZ8ugU7r5), o4bYL4peNeC2wWb8yjx.oVdpGKjy2x), (MethodInfo)f5q427pRQZnrEKPy4Ws.D35lls5iF((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, f5q427pRQZnrEKPy4Ws.Bo9pk3m4k7), OWBKr5pvc5MWsK1OMtR.fZIpAAdi1v), Array.Empty<ParameterExpression>()), [AsyncStateMachine(typeof(_003C_003COnWatchTrailerCommandExcute_003Eb__21_1_003Ed))] () =>
					{
						_003C_003COnWatchTrailerCommandExcute_003Eb__21_1_003Ed stateMachine = default(_003C_003COnWatchTrailerCommandExcute_003Eb__21_1_003Ed);
						stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
						stateMachine._003C_003E4__this = CS_0024_003C_003E8__locals4;
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
					goto IL_00e4;
				}
				goto end_IL_0015;
				IL_00e4:
				oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
				end_IL_0015:;
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
	private sealed class _003C_003Ec__DisplayClass22_0
	{
		public bool DcttdM7wl3;

		public _003C_003Ec__DisplayClass22_0()
		{
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
			base._002Ector();
		}

		internal bool JawtDdeJG6(bool isConfirmed)
		{
			if (!isConfirmed)
			{
				DcttdM7wl3 = false;
			}
			return true;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnPlayOrRentMovieCommandExcute_003Ed__22 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public MovieItemViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			MovieItemViewModel CS_0024_003C_003E8__locals3 = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(W7S2sip6SDieZFVsNbd.D35lls5iF(CS_0024_003C_003E8__locals3, Expression.Lambda<Func<bool>>(OWBKr5pvc5MWsK1OMtR.D35lls5iF(o4bYL4peNeC2wWb8yjx.D35lls5iF(CS_0024_003C_003E8__locals3, sjYxHO8OWlc6X80hFj7.D35lls5iF(typeof(MovieItemViewModel).TypeHandle, sjYxHO8OWlc6X80hFj7.uWZ8ugU7r5), o4bYL4peNeC2wWb8yjx.oVdpGKjy2x), (MethodInfo)f5q427pRQZnrEKPy4Ws.D35lls5iF((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, f5q427pRQZnrEKPy4Ws.Bo9pk3m4k7), OWBKr5pvc5MWsK1OMtR.fZIpAAdi1v), Array.Empty<ParameterExpression>()), [AsyncStateMachine(typeof(_003C_003COnPlayOrRentMovieCommandExcute_003Eb__22_1_003Ed))] () =>
					{
						_003C_003COnPlayOrRentMovieCommandExcute_003Eb__22_1_003Ed stateMachine = default(_003C_003COnPlayOrRentMovieCommandExcute_003Eb__22_1_003Ed);
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
	private struct _003CLoadAsync_003Ed__24 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MovieItemViewModel _003C_003E4__this;

		private object _003C_003E7__wrap1;

		private int _003C_003E7__wrap2;

		private TaskAwaiter<Response<MovieResponseDto>> _003C_003Eu__1;

		private TaskAwaiter<bool> _003C_003Eu__2;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			MovieItemViewModel movieItemViewModel = _003C_003E4__this;
			try
			{
				TaskAwaiter<bool> awaiter;
				if (num != 0)
				{
					if (num == 1)
					{
						awaiter = _003C_003Eu__2;
						_003C_003Eu__2 = default(TaskAwaiter<bool>);
						num = (_003C_003E1__state = -1);
						goto IL_01ac;
					}
					_003C_003E7__wrap2 = 0;
				}
				try
				{
					TaskAwaiter<Response<MovieResponseDto>> awaiter2;
					if (num != 0)
					{
						awaiter2 = a1dd23Co8uRUg80NYqF.D35lls5iF(movieItemViewModel.EA8DgcV92X, m9MGZR7k2RmVqYXYS5.D35lls5iF(TMNvN3DsY49dcntqfIs.D35lls5iF(movieItemViewModel, TMNvN3DsY49dcntqfIs.iVU47VBsyR), m9MGZR7k2RmVqYXYS5.j871CQO7pP), a1dd23Co8uRUg80NYqF.GhoClwhL5B).GetAwaiter();
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
						_003C_003Eu__1 = default(TaskAwaiter<Response<MovieResponseDto>>);
						num = (_003C_003E1__state = -1);
					}
					Response<MovieResponseDto> result = awaiter2.GetResult();
					if (TMNvN3DsY49dcntqfIs.D35lls5iF(movieItemViewModel, TMNvN3DsY49dcntqfIs.iVU47VBsyR) != null)
					{
						sNF3tFDxPmlUJ5w8Ixu.D35lls5iF(movieItemViewModel, result.Data, sNF3tFDxPmlUJ5w8Ixu.Swm4Uh77SI);
					}
					fp757nBYjo8889efKFJ.D35lls5iF((AsyncCommand)IMLt24C94kPYNS51A2t.D35lls5iF(movieItemViewModel, IMLt24C94kPYNS51A2t.XdbCDVsIWg), fp757nBYjo8889efKFJ.y6uCHZ9Lcu);
					qni3xrDkAJ3vF35eMav.D35lls5iF(movieItemViewModel, iFZ5je3XFYKwkvcE5D.D35lls5iF(11698, iFZ5je3XFYKwkvcE5D.N06TeK0ao), qni3xrDkAJ3vF35eMav.QN6DuDtCWO);
				}
				catch (PROTVException ex)
				{
					_003C_003E7__wrap1 = ex;
					_003C_003E7__wrap2 = 1;
				}
				int num2 = _003C_003E7__wrap2;
				if (num2 == 1 && TNckS5wtLfB2Lk9dYP8.D35lls5iF((PROTVException)_003C_003E7__wrap1, TNckS5wtLfB2Lk9dYP8.oGkwV3iq3t) == ExceptionType.AuthorizationTokenInvalid)
				{
					awaiter = bAA7Sxw7vZsvusOmDea.D35lls5iF(AppContainer.Resolve<MainViewModel>(), bAA7Sxw7vZsvusOmDea.gytwc9U7r5).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_003C_003E1__state = 1);
						_003C_003Eu__2 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_01ac;
				}
				goto IL_01c3;
				IL_01c3:
				_003C_003E7__wrap1 = null;
				goto end_IL_0015;
				IL_01ac:
				if (awaiter.GetResult())
				{
					movieItemViewModel.EA8DgcV92X = AppContainer.Resolve<IMovieService>();
				}
				goto IL_01c3;
				end_IL_0015:;
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
	private struct _003C_003COnWatchTrailerCommandExcute_003Eb__21_1_003Ed : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MovieItemViewModel _003C_003E4__this;

		private MoviePlayerViewModel _003CviewModel_003E5__2;

		private Page _003Cpage_003E5__3;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			MovieItemViewModel movieItemViewModel = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					if (num == 1)
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter);
						num = (_003C_003E1__state = -1);
						goto IL_0156;
					}
					_003CviewModel_003E5__2 = new MoviePlayerViewModel();
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(pc29LvC1MtrAHdoVicf.D35lls5iF(_003CviewModel_003E5__2, MoviePalyerType.Trailer, TMNvN3DsY49dcntqfIs.D35lls5iF(movieItemViewModel, TMNvN3DsY49dcntqfIs.iVU47VBsyR), null, pc29LvC1MtrAHdoVicf.qn5C8Y8bFt), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
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
				Page page = new Page();
				KBhlAv9D2TgBJ1kkc0B.D35lls5iF(page, IyGDDwHBiPv8vfOFJDF.D35lls5iF(ApplicationPage.ShowMoviePage, _003CviewModel_003E5__2, IyGDDwHBiPv8vfOFJDF.hivH0XYhaE), KBhlAv9D2TgBJ1kkc0B.fWUHrWO7Sa);
				qni3xrDkAJ3vF35eMav.D35lls5iF(page, EBgwuVHeVLDJVVfMaAk.D35lls5iF(ApplicationPage.ShowMoviePage, EBgwuVHeVLDJVVfMaAk.mtcHG3MEy3), qni3xrDkAJ3vF35eMav.Ra7HRFTvnD);
				_003Cpage_003E5__3 = page;
				awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(pvrKKy8Mk1kpdmIfp3A.D35lls5iF(5, pvrKKy8Mk1kpdmIfp3A.aVh8SPrFkE), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
				if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
				{
					num = (_003C_003E1__state = 1);
					_003C_003Eu__1 = awaiter;
					_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
					return;
				}
				goto IL_0156;
				IL_0156:
				oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
				GmMLaTD7kV8rq88ZFvR.D35lls5iF(Xlypb0Hnr2C3ydrYEdG.D35lls5iF(movieItemViewModel.uixD1FS4F0, Xlypb0Hnr2C3ydrYEdG.U3Z1IKMGuZ), _003Cpage_003E5__3, GmMLaTD7kV8rq88ZFvR.iMJHkmaaRY);
			}
			catch (Exception ex)
			{
				_003C_003E1__state = -2;
				_003CviewModel_003E5__2 = null;
				_003Cpage_003E5__3 = null;
				NNK1eXA7fWQ87oSUty7.D35lls5iF(ref _003C_003Et__builder, ex, NNK1eXA7fWQ87oSUty7.G3EAcW9Om7);
				return;
			}
			_003C_003E1__state = -2;
			_003CviewModel_003E5__2 = null;
			_003Cpage_003E5__3 = null;
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
	private struct _003C_003COnPlayOrRentMovieCommandExcute_003Eb__22_1_003Ed : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MovieItemViewModel _003C_003E4__this;

		private bool _003CtryAgain_003E5__2;

		private object _003C_003E7__wrap2;

		private int _003C_003E7__wrap3;

		private TaskAwaiter<Response<RentResponseDto>> _003C_003Eu__1;

		private VideoPlayerViewModel _003CviewModel_003E5__5;

		private Page _003Cpage_003E5__6;

		private TaskAwaiter _003C_003Eu__2;

		private TaskAwaiter<bool> _003C_003Eu__3;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			MovieItemViewModel movieItemViewModel = _003C_003E4__this;
			try
			{
				if ((uint)num <= 2u)
				{
					goto IL_010f;
				}
				TaskAwaiter<bool> awaiter;
				if (num == 3)
				{
					awaiter = _003C_003Eu__3;
					_003C_003Eu__3 = default(TaskAwaiter<bool>);
					num = (_003C_003E1__state = -1);
					goto IL_03e6;
				}
				_003C_003Ec__DisplayClass22_0 CS_0024_003C_003E8__locals3 = new _003C_003Ec__DisplayClass22_0();
				CS_0024_003C_003E8__locals3.DcttdM7wl3 = true;
				int num2;
				if (uN1DaxTm1XRIu0SSp7h.D35lls5iF(TMNvN3DsY49dcntqfIs.D35lls5iF(movieItemViewModel, TMNvN3DsY49dcntqfIs.iVU47VBsyR), uN1DaxTm1XRIu0SSp7h.r7aCnH9Gqo) == MediaCost.Paid)
				{
					string[] obj = new string[5]
					{
						iFZ5je3XFYKwkvcE5D.D35lls5iF(16076, iFZ5je3XFYKwkvcE5D.N06TeK0ao),
						QQLie3eYkZwbFFm9Jjw.D35lls5iF(TMNvN3DsY49dcntqfIs.D35lls5iF(movieItemViewModel, TMNvN3DsY49dcntqfIs.iVU47VBsyR), QQLie3eYkZwbFFm9Jjw.T8RwSgEfbh),
						iFZ5je3XFYKwkvcE5D.D35lls5iF(16140, iFZ5je3XFYKwkvcE5D.N06TeK0ao),
						null,
						null
					};
					num2 = WJbFtI6AObf2rNffLCy.D35lls5iF(TMNvN3DsY49dcntqfIs.D35lls5iF(movieItemViewModel, TMNvN3DsY49dcntqfIs.iVU47VBsyR), WJbFtI6AObf2rNffLCy.VKfC3dMTo1);
					obj[3] = E1oqfbTdQ1YrEeaxoPg.D35lls5iF(ref num2, E1oqfbTdQ1YrEeaxoPg.beYTUkKTth);
					obj[4] = iFZ5je3XFYKwkvcE5D.D35lls5iF(16154, iFZ5je3XFYKwkvcE5D.N06TeK0ao);
					aOsAijCTnvLPVytuecl.D35lls5iF(EKUvcf6BZG4YrVDIJu7.D35lls5iF(obj, EKUvcf6BZG4YrVDIJu7.lI660m0xwr), delegate(bool isConfirmed)
					{
						if (!isConfirmed)
						{
							CS_0024_003C_003E8__locals3.DcttdM7wl3 = false;
						}
						return true;
					}, "", aOsAijCTnvLPVytuecl.Qt4C45JP4A);
				}
				if (CS_0024_003C_003E8__locals3.DcttdM7wl3)
				{
					_003CtryAgain_003E5__2 = true;
					goto IL_042b;
				}
				goto end_IL_0015;
				IL_0424:
				_003C_003E7__wrap2 = null;
				goto IL_042b;
				IL_042b:
				if (_003CtryAgain_003E5__2)
				{
					_003CtryAgain_003E5__2 = false;
					_003C_003E7__wrap3 = 0;
					goto IL_010f;
				}
				goto end_IL_0015;
				IL_03e6:
				if (awaiter.GetResult())
				{
					_003CtryAgain_003E5__2 = true;
					movieItemViewModel.EA8DgcV92X = AppContainer.Resolve<IMovieService>();
				}
				goto IL_0424;
				IL_010f:
				try
				{
					TaskAwaiter<Response<RentResponseDto>> awaiter3;
					TaskAwaiter awaiter2;
					Page page;
					Response<RentResponseDto> result;
					switch (num)
					{
					default:
						awaiter3 = sYW4HcCLj53QDe4wG8O.D35lls5iF(movieItemViewModel.EA8DgcV92X, m9MGZR7k2RmVqYXYS5.D35lls5iF(TMNvN3DsY49dcntqfIs.D35lls5iF(movieItemViewModel, TMNvN3DsY49dcntqfIs.iVU47VBsyR), m9MGZR7k2RmVqYXYS5.j871CQO7pP), sYW4HcCLj53QDe4wG8O.UnSCEYLQ73).GetAwaiter();
						if (!awaiter3.IsCompleted)
						{
							num = (_003C_003E1__state = 0);
							_003C_003Eu__1 = awaiter3;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
							return;
						}
						goto IL_019a;
					case 0:
						awaiter3 = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter<Response<RentResponseDto>>);
						num = (_003C_003E1__state = -1);
						goto IL_019a;
					case 1:
						awaiter2 = _003C_003Eu__2;
						_003C_003Eu__2 = default(TaskAwaiter);
						num = (_003C_003E1__state = -1);
						goto IL_024d;
					case 2:
						{
							awaiter2 = _003C_003Eu__2;
							_003C_003Eu__2 = default(TaskAwaiter);
							num = (_003C_003E1__state = -1);
							break;
						}
						IL_024d:
						oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter2, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
						page = new Page();
						KBhlAv9D2TgBJ1kkc0B.D35lls5iF(page, IyGDDwHBiPv8vfOFJDF.D35lls5iF(ApplicationPage.TVShowPage, _003CviewModel_003E5__5, IyGDDwHBiPv8vfOFJDF.hivH0XYhaE), KBhlAv9D2TgBJ1kkc0B.fWUHrWO7Sa);
						qni3xrDkAJ3vF35eMav.D35lls5iF(page, EBgwuVHeVLDJVVfMaAk.D35lls5iF(ApplicationPage.ShowMoviePage, EBgwuVHeVLDJVVfMaAk.mtcHG3MEy3), qni3xrDkAJ3vF35eMav.Ra7HRFTvnD);
						_003Cpage_003E5__6 = page;
						awaiter2 = QliBEUviwWqgtMcBndV.D35lls5iF(pvrKKy8Mk1kpdmIfp3A.D35lls5iF(5, pvrKKy8Mk1kpdmIfp3A.aVh8SPrFkE), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
						if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter2, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
						{
							num = (_003C_003E1__state = 2);
							_003C_003Eu__2 = awaiter2;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						}
						break;
						IL_019a:
						result = awaiter3.GetResult();
						if (result != null && result.Status)
						{
							VideoPlayerViewModel videoPlayerViewModel = new VideoPlayerViewModel();
							CINH3eCBRcZO1fqc2r5.D35lls5iF(videoPlayerViewModel, PlaylistItemType.Movie, CINH3eCBRcZO1fqc2r5.DIIC09F8Td);
							_003CviewModel_003E5__5 = videoPlayerViewModel;
							awaiter2 = QliBEUviwWqgtMcBndV.D35lls5iF(TbDdBVCr1nbfTLRVA19.D35lls5iF(_003CviewModel_003E5__5, TMNvN3DsY49dcntqfIs.D35lls5iF(movieItemViewModel, TMNvN3DsY49dcntqfIs.iVU47VBsyR), result.Data, TbDdBVCr1nbfTLRVA19.QqcCexmYMF), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
							if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter2, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
							{
								num = (_003C_003E1__state = 1);
								_003C_003Eu__2 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
							goto IL_024d;
						}
						goto end_IL_010f;
					}
					oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter2, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
					GmMLaTD7kV8rq88ZFvR.D35lls5iF(Xlypb0Hnr2C3ydrYEdG.D35lls5iF(movieItemViewModel.uixD1FS4F0, Xlypb0Hnr2C3ydrYEdG.U3Z1IKMGuZ), _003Cpage_003E5__6, GmMLaTD7kV8rq88ZFvR.iMJHkmaaRY);
					_003CviewModel_003E5__5 = null;
					_003Cpage_003E5__6 = null;
					end_IL_010f:;
				}
				catch (PROTVException ex)
				{
					_003C_003E7__wrap2 = ex;
					_003C_003E7__wrap3 = 1;
				}
				num2 = _003C_003E7__wrap3;
				if (num2 == 1)
				{
					PROTVException ex2 = (PROTVException)_003C_003E7__wrap2;
					if (TNckS5wtLfB2Lk9dYP8.D35lls5iF(ex2, TNckS5wtLfB2Lk9dYP8.oGkwV3iq3t) == ExceptionType.AuthorizationTokenInvalid)
					{
						awaiter = bAA7Sxw7vZsvusOmDea.D35lls5iF(AppContainer.Resolve<MainViewModel>(), bAA7Sxw7vZsvusOmDea.gytwc9U7r5).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (_003C_003E1__state = 3);
							_003C_003Eu__3 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_03e6;
					}
					gsYNF433WqUIGma3CNX.D35lls5iF(QQLie3eYkZwbFFm9Jjw.D35lls5iF(ex2, QQLie3eYkZwbFFm9Jjw.vZdwjWiy78), "", gsYNF433WqUIGma3CNX.MAY3Ti847u);
				}
				goto IL_0424;
				end_IL_0015:;
			}
			catch (Exception ex3)
			{
				_003C_003E1__state = -2;
				NNK1eXA7fWQ87oSUty7.D35lls5iF(ref _003C_003Et__builder, ex3, NNK1eXA7fWQ87oSUty7.G3EAcW9Om7);
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
	private ICommand vm3DHct0bm;

	[CompilerGenerated]
	private ICommand nfhDoAqs8Q;

	private IMovieService EA8DgcV92X;

	private readonly HomeViewModel uixD1FS4F0;

	private bool OuaDJ7MgCL;

	[CompilerGenerated]
	private MovieResponseDto OF4DhRf8rM;

	public ICommand PlayOrRentMovieCommand
	{
		[CompilerGenerated]
		get
		{
			return vm3DHct0bm;
		}
		[CompilerGenerated]
		set
		{
			vm3DHct0bm = value;
		}
	}

	public ICommand WatchTrailerCommand
	{
		[CompilerGenerated]
		get
		{
			return nfhDoAqs8Q;
		}
		[CompilerGenerated]
		set
		{
			nfhDoAqs8Q = value;
		}
	}

	public bool IsRenting
	{
		get
		{
			return OuaDJ7MgCL;
		}
		set
		{
			OuaDJ7MgCL = value;
			qni3xrDkAJ3vF35eMav.D35lls5iF(this, iFZ5je3XFYKwkvcE5D.D35lls5iF(10164, iFZ5je3XFYKwkvcE5D.N06TeK0ao), qni3xrDkAJ3vF35eMav.QN6DuDtCWO);
		}
	}

	public MovieResponseDto Movie
	{
		[CompilerGenerated]
		get
		{
			return OF4DhRf8rM;
		}
		[CompilerGenerated]
		set
		{
			OF4DhRf8rM = value;
		}
	}

	public MovieItemViewModel(MovieResponseDto movie)
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		this._002Ector();
		sNF3tFDxPmlUJ5w8Ixu.D35lls5iF(this, movie, sNF3tFDxPmlUJ5w8Ixu.Swm4Uh77SI);
	}

	public MovieItemViewModel()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector();
		sNF3tFDxPmlUJ5w8Ixu.D35lls5iF(this, new MovieResponseDto(), sNF3tFDxPmlUJ5w8Ixu.Swm4Uh77SI);
		EA8DgcV92X = AppContainer.Resolve<IMovieService>();
		uixD1FS4F0 = AppContainer.Resolve<HomeViewModel>();
		Q3OeRSTq6SNsAFQUUoG.D35lls5iF(this, new DelegateCommand(delegate
		{
			xLO56JniGyickVjO1Ot.D35lls5iF(this, xLO56JniGyickVjO1Ot.f5Q4Kr2LTb);
		}), Q3OeRSTq6SNsAFQUUoG.Tbb4tqJK07);
		Q3OeRSTq6SNsAFQUUoG.D35lls5iF(this, new AsyncCommand(FaaDEnEDch, VlkDwxQShr), Q3OeRSTq6SNsAFQUUoG.xbZ4VKHHoY);
	}

	private bool VlkDwxQShr(object P_0)
	{
		return !M6ZErPEr2LZyWYpa5O.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(TMNvN3DsY49dcntqfIs.D35lls5iF(this, TMNvN3DsY49dcntqfIs.iVU47VBsyR), wq2usy8gNndpuTw5mR.tP04ccQgjp), M6ZErPEr2LZyWYpa5O.zgQ4MgoA99);
	}

	[AsyncStateMachine(typeof(_003COnWatchTrailerCommandExcute_003Ed__21))]
	private Task FaaDEnEDch()
	{
		_003COnWatchTrailerCommandExcute_003Ed__21 stateMachine = default(_003COnWatchTrailerCommandExcute_003Ed__21);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	[AsyncStateMachine(typeof(_003COnPlayOrRentMovieCommandExcute_003Ed__22))]
	private void PcwD9ngixu()
	{
		_003COnPlayOrRentMovieCommandExcute_003Ed__22 stateMachine = default(_003COnPlayOrRentMovieCommandExcute_003Ed__22);
		stateMachine._003C_003Et__builder = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	public override void OnLoading()
	{
		Task task = CRMxYv82mIBQFuWGeba.D35lls5iF(this, CRMxYv82mIBQFuWGeba.omY4SKOoD8);
		Action<Exception> action = null;
		bool flag = false;
		gBlEqv8jRKikCj2DMZp.D35lls5iF(task, ref action, ref flag, gBlEqv8jRKikCj2DMZp.pSp8ymt8Mu);
	}

	[AsyncStateMachine(typeof(_003CLoadAsync_003Ed__24))]
	public Task LoadAsync()
	{
		_003CLoadAsync_003Ed__24 stateMachine = default(_003CLoadAsync_003Ed__24);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	[CompilerGenerated]
	private void zcbDenM7SZ(object P_0)
	{
		xLO56JniGyickVjO1Ot.D35lls5iF(this, xLO56JniGyickVjO1Ot.f5Q4Kr2LTb);
	}

	[CompilerGenerated]
	[AsyncStateMachine(typeof(_003C_003COnWatchTrailerCommandExcute_003Eb__21_1_003Ed))]
	private Task eljDOo1CwC()
	{
		_003C_003COnWatchTrailerCommandExcute_003Eb__21_1_003Ed stateMachine = default(_003C_003COnWatchTrailerCommandExcute_003Eb__21_1_003Ed);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	[AsyncStateMachine(typeof(_003C_003COnPlayOrRentMovieCommandExcute_003Eb__22_1_003Ed))]
	[CompilerGenerated]
	private Task jbsDrZaUqq()
	{
		_003C_003COnPlayOrRentMovieCommandExcute_003Eb__22_1_003Ed stateMachine = default(_003C_003COnPlayOrRentMovieCommandExcute_003Eb__22_1_003Ed);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}
}
