using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using PROTV.Abstractions.Common;
using PROTV.Wpf.Bootstrap;
using PROTV.Wpf.ViewModels;

namespace PROTV.Wpf.Views;

public class BasePage : UserControl, IDisposable
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBasePage_Loaded_003Ed__21 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public BasePage _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			BasePage basePage = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_00ba;
				}
				if (num != 1)
				{
					if (uEUVCI48fycroqgRFqy.D35lls5iF(basePage, uEUVCI48fycroqgRFqy.Rf16ZA7FXr))
					{
						if (RAspAbuaTQFU0nSRiQ.D35lls5iF(basePage, RAspAbuaTQFU0nSRiQ.TRKDqmX9Pw) is BaseViewModel baseViewModel)
						{
							fp757nBYjo8889efKFJ.D35lls5iF(baseViewModel, fp757nBYjo8889efKFJ.F0E6jGL5bj);
						}
						awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(CRMxYv82mIBQFuWGeba.D35lls5iF(basePage, CRMxYv82mIBQFuWGeba.xW56yXX4mT), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
						if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
						{
							num = (_003C_003E1__state = 0);
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_00ba;
					}
					if (RAspAbuaTQFU0nSRiQ.D35lls5iF(basePage, RAspAbuaTQFU0nSRiQ.TRKDqmX9Pw) is BaseViewModel baseViewModel2)
					{
						AJv70itXcdnxnNYjSQ.D35lls5iF(baseViewModel2, AJv70itXcdnxnNYjSQ.YkS91HZ8IQ);
					}
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(CRMxYv82mIBQFuWGeba.D35lls5iF(basePage, CRMxYv82mIBQFuWGeba.J4g6qtnlqm), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
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
				goto end_IL_0015;
				IL_00ba:
				oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
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
	private struct _003CAnimateInAsync_003Ed__22 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public BasePage _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			BasePage basePage = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				switch (num)
				{
				default:
					if (dtDeqlDfH1PXL3NGG1r.D35lls5iF(basePage, dtDeqlDfH1PXL3NGG1r.SULDFbLtd3) != PageAnimation.None)
					{
						switch (dtDeqlDfH1PXL3NGG1r.D35lls5iF(basePage, dtDeqlDfH1PXL3NGG1r.SULDFbLtd3))
						{
						case PageAnimation.SlideAndFadeInFromRight:
							goto IL_0081;
						case PageAnimation.SlideAndFadeInFromBottom:
							goto IL_0125;
						case PageAnimation.SlideAndFadeInFromLeft:
							goto IL_01a9;
						case PageAnimation.SlideAndFadeInFromTop:
							goto IL_024d;
						case PageAnimation.FadeIn:
							goto IL_02d1;
						case PageAnimation.SlideAndFadeOutToRight:
						case PageAnimation.SlideAndFadeOutToLeft:
						case PageAnimation.SlideAndFadeOutToBottom:
						case PageAnimation.SlideAndFadeOutToTop:
							break;
						}
					}
					goto end_IL_0015;
				case 0:
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_0114;
				case 1:
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_0198;
				case 2:
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_023c;
				case 3:
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_02c0;
				case 4:
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter);
						num = (_003C_003E1__state = -1);
						break;
					}
					IL_0125:
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(fuQ9Ir6zwUAo8YXEge8.D35lls5iF(basePage, false, p4mfse87pettnXd8Scc.D35lls5iF(basePage, p4mfse87pettnXd8Scc.Slc6JkFpAm), true, fuQ9Ir6zwUAo8YXEge8.tgNpox5gq0), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
					if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
					{
						num = (_003C_003E1__state = 1);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_0198;
					IL_02d1:
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(fuQ9Ir6zwUAo8YXEge8.D35lls5iF(basePage, false, p4mfse87pettnXd8Scc.D35lls5iF(basePage, p4mfse87pettnXd8Scc.Slc6JkFpAm), true, fuQ9Ir6zwUAo8YXEge8.tgNpox5gq0), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
					if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
					{
						num = (_003C_003E1__state = 4);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					break;
					IL_0114:
					oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
					goto end_IL_0015;
					IL_024d:
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(fuQ9Ir6zwUAo8YXEge8.D35lls5iF(basePage, false, p4mfse87pettnXd8Scc.D35lls5iF(basePage, p4mfse87pettnXd8Scc.Slc6JkFpAm), true, fuQ9Ir6zwUAo8YXEge8.tgNpox5gq0), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
					if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
					{
						num = (_003C_003E1__state = 3);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_02c0;
					IL_0198:
					oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
					goto end_IL_0015;
					IL_02c0:
					oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
					goto end_IL_0015;
					IL_01a9:
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(nqKDCw6Wcer9HVcd1nw.D35lls5iF(basePage, AnimationSlideIndirection.Left, false, p4mfse87pettnXd8Scc.D35lls5iF(basePage, p4mfse87pettnXd8Scc.Slc6JkFpAm), true, (int)bATk1clKMSyO8g9EVbN.D35lls5iF(VqWOinl9PO0jF3BJej0.D35lls5iF(Jr0pTQlovwB9pdID1EB.D35lls5iF(Jr0pTQlovwB9pdID1EB.CxrllgXtD4), VqWOinl9PO0jF3BJej0.XwJlDOAaeh), bATk1clKMSyO8g9EVbN.Ylg6bMXAm1), nqKDCw6Wcer9HVcd1nw.VxX65LAkt7), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
					if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
					{
						num = (_003C_003E1__state = 2);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_023c;
					IL_0081:
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(nqKDCw6Wcer9HVcd1nw.D35lls5iF(basePage, AnimationSlideIndirection.Right, false, p4mfse87pettnXd8Scc.D35lls5iF(basePage, p4mfse87pettnXd8Scc.Slc6JkFpAm), true, (int)bATk1clKMSyO8g9EVbN.D35lls5iF(VqWOinl9PO0jF3BJej0.D35lls5iF(Jr0pTQlovwB9pdID1EB.D35lls5iF(Jr0pTQlovwB9pdID1EB.CxrllgXtD4), VqWOinl9PO0jF3BJej0.XwJlDOAaeh), bATk1clKMSyO8g9EVbN.Ylg6bMXAm1), nqKDCw6Wcer9HVcd1nw.VxX65LAkt7), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
					if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_0114;
					IL_023c:
					oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
					goto end_IL_0015;
				}
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

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CAnimateOutAsync_003Ed__23 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public BasePage _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			BasePage basePage = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				switch (num)
				{
				default:
					if (dtDeqlDfH1PXL3NGG1r.D35lls5iF(basePage, dtDeqlDfH1PXL3NGG1r.WZ8plxVka7) != PageAnimation.None)
					{
						switch (dtDeqlDfH1PXL3NGG1r.D35lls5iF(basePage, dtDeqlDfH1PXL3NGG1r.WZ8plxVka7))
						{
						case PageAnimation.SlideAndFadeOutToLeft:
							goto IL_0075;
						case PageAnimation.SlideAndFadeOutToRight:
							goto IL_00fa;
						case PageAnimation.SlideAndFadeOutToBottom:
							goto IL_017f;
						case PageAnimation.SlideAndFadeOutToTop:
							goto IL_0204;
						case PageAnimation.FadeOut:
							goto IL_0289;
						case PageAnimation.FadeIn:
							break;
						}
					}
					goto end_IL_0015;
				case 0:
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_00e9;
				case 1:
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_016e;
				case 2:
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_01f3;
				case 3:
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_0278;
				case 4:
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter);
						num = (_003C_003E1__state = -1);
						break;
					}
					IL_00fa:
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(vbpmTmp9vGUHFrWxrrb.D35lls5iF(basePage, AnimationSlideIndirection.Right, p4mfse87pettnXd8Scc.D35lls5iF(basePage, p4mfse87pettnXd8Scc.Slc6JkFpAm), true, 0, vbpmTmp9vGUHFrWxrrb.jxXpDCEjjK), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
					if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
					{
						num = (_003C_003E1__state = 1);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_016e;
					IL_0289:
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(d40o3VpHtVn5DYOINnq.D35lls5iF(basePage, p4mfse87pettnXd8Scc.D35lls5iF(basePage, p4mfse87pettnXd8Scc.Slc6JkFpAm), true, d40o3VpHtVn5DYOINnq.fdZp1TjgiU), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
					if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
					{
						num = (_003C_003E1__state = 4);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					break;
					IL_00e9:
					oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
					goto end_IL_0015;
					IL_0204:
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(vbpmTmp9vGUHFrWxrrb.D35lls5iF(basePage, AnimationSlideIndirection.Top, p4mfse87pettnXd8Scc.D35lls5iF(basePage, p4mfse87pettnXd8Scc.Slc6JkFpAm), true, 0, vbpmTmp9vGUHFrWxrrb.jxXpDCEjjK), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
					if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
					{
						num = (_003C_003E1__state = 3);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_0278;
					IL_016e:
					oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
					goto end_IL_0015;
					IL_0278:
					oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
					goto end_IL_0015;
					IL_017f:
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(vbpmTmp9vGUHFrWxrrb.D35lls5iF(basePage, AnimationSlideIndirection.Bottom, p4mfse87pettnXd8Scc.D35lls5iF(basePage, p4mfse87pettnXd8Scc.Slc6JkFpAm), true, 0, vbpmTmp9vGUHFrWxrrb.jxXpDCEjjK), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
					if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
					{
						num = (_003C_003E1__state = 2);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_01f3;
					IL_0075:
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(vbpmTmp9vGUHFrWxrrb.D35lls5iF(basePage, AnimationSlideIndirection.Left, p4mfse87pettnXd8Scc.D35lls5iF(basePage, p4mfse87pettnXd8Scc.Slc6JkFpAm), true, 0, vbpmTmp9vGUHFrWxrrb.jxXpDCEjjK), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
					if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_00e9;
					IL_01f3:
					oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
					goto end_IL_0015;
				}
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

	private object QFu1k8usE;

	[CompilerGenerated]
	private PageAnimation cZTJCkJcQ;

	[CompilerGenerated]
	private PageAnimation AkEh5DSRh;

	[CompilerGenerated]
	private float aWFlFvOa1;

	[CompilerGenerated]
	private bool lmTUsRuQT;

	public PageAnimation PageLoadAnimation
	{
		[CompilerGenerated]
		get
		{
			return cZTJCkJcQ;
		}
		[CompilerGenerated]
		set
		{
			cZTJCkJcQ = value;
		}
	}

	public PageAnimation PageUnloadAnimation
	{
		[CompilerGenerated]
		get
		{
			return AkEh5DSRh;
		}
		[CompilerGenerated]
		set
		{
			AkEh5DSRh = value;
		}
	}

	public float SlideSeconds
	{
		[CompilerGenerated]
		get
		{
			return aWFlFvOa1;
		}
		[CompilerGenerated]
		set
		{
			aWFlFvOa1 = value;
		}
	}

	public bool ShouldAnimateOut
	{
		[CompilerGenerated]
		get
		{
			return lmTUsRuQT;
		}
		[CompilerGenerated]
		set
		{
			lmTUsRuQT = value;
		}
	}

	public object ViewModelObject
	{
		get
		{
			return QFu1k8usE;
		}
		set
		{
			if (QFu1k8usE != value && value != null)
			{
				QFu1k8usE = value;
				KBhlAv9D2TgBJ1kkc0B.D35lls5iF(this, QFu1k8usE, KBhlAv9D2TgBJ1kkc0B.rHR9H7nUZq);
			}
		}
	}

	public BasePage()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		cZTJCkJcQ = PageAnimation.SlideAndFadeInFromTop;
		AkEh5DSRh = PageAnimation.FadeOut;
		aWFlFvOa1 = 0.3f;
		base._002Ector();
		if (!NfqIK2DQYVx3Ia0xnE6.D35lls5iF((DependencyObject)(object)this, NfqIK2DQYVx3Ia0xnE6.KwoDX3Gtuv))
		{
			if (dtDeqlDfH1PXL3NGG1r.D35lls5iF(this, dtDeqlDfH1PXL3NGG1r.SULDFbLtd3) != PageAnimation.None)
			{
				YQ4csVD2gHt33yWHvSL.D35lls5iF(this, Visibility.Collapsed, YQ4csVD2gHt33yWHvSL.v4NDZZNJ5S);
			}
			dp97HSDjYOMxMALpn4D.D35lls5iF(this, tVlgAj05m, dp97HSDjYOMxMALpn4D.vtODyN5sav);
		}
	}

	[AsyncStateMachine(typeof(_003CBasePage_Loaded_003Ed__21))]
	private void tVlgAj05m(object P_0, RoutedEventArgs P_1)
	{
		_003CBasePage_Loaded_003Ed__21 stateMachine = default(_003CBasePage_Loaded_003Ed__21);
		stateMachine._003C_003Et__builder = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003CAnimateInAsync_003Ed__22))]
	public Task AnimateInAsync()
	{
		_003CAnimateInAsync_003Ed__22 stateMachine = default(_003CAnimateInAsync_003Ed__22);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	[AsyncStateMachine(typeof(_003CAnimateOutAsync_003Ed__23))]
	public Task AnimateOutAsync()
	{
		_003CAnimateOutAsync_003Ed__23 stateMachine = default(_003CAnimateOutAsync_003Ed__23);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	public virtual void Dispose()
	{
	}
}
public class BasePage<VM> : BasePage where VM : BaseViewModel, new()
{
	public VM ViewModel
	{
		get
		{
			return (VM)RAspAbuaTQFU0nSRiQ.D35lls5iF(this, RAspAbuaTQFU0nSRiQ.TRKDqmX9Pw);
		}
		set
		{
			KBhlAv9D2TgBJ1kkc0B.D35lls5iF(this, value, KBhlAv9D2TgBJ1kkc0B.GS0DJEbPnP);
		}
	}

	public BasePage()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector();
		if (NfqIK2DQYVx3Ia0xnE6.D35lls5iF((DependencyObject)(object)this, NfqIK2DQYVx3Ia0xnE6.KwoDX3Gtuv))
		{
			ViewModel = new VM();
		}
		else
		{
			ViewModel = AppContainer.Resolve<VM>() ?? new VM();
		}
	}

	public BasePage(VM specificViewModel = null)
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector();
		if (specificViewModel != null)
		{
			ViewModel = specificViewModel;
		}
		else if (NfqIK2DQYVx3Ia0xnE6.D35lls5iF((DependencyObject)(object)this, NfqIK2DQYVx3Ia0xnE6.KwoDX3Gtuv))
		{
			ViewModel = new VM();
		}
		else
		{
			ViewModel = AppContainer.Resolve<VM>() ?? new VM();
		}
	}
}
