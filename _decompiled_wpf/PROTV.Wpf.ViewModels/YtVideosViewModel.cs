using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using PROTV.Abstractions.Common;
using PROTV.Abstractions.DataTransferObjects;
using PROTV.Abstractions.Helpers;
using PROTV.Abstractions.Search;
using PROTV.Abstractions.Services;
using PROTV.Wpf.Bootstrap;

namespace PROTV.Wpf.ViewModels;

public class YtVideosViewModel : BaseListViewModel<YTVideoResponseDto, ApiQuery<YTSearch, YTVideoSort>>
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass12_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct rUfQsbjPhKJe2or9sGs : IAsyncStateMachine
		{
			public int Qli5y1x53t;

			public AsyncVoidMethodBuilder Bqx5pu5Pmc;

			public _003C_003Ec__DisplayClass12_0 dRv5iQh94h;

			private ResponseList<YTVideoResponseDto> opv53bcstW;

			private TaskAwaiter<ResponseList<YTVideoResponseDto>> Akx5mRjFbN;

			private IEnumerator<YTVideoResponseDto> UCi5XsbB9X;

			private YTVideoResponseDto WcB5RfByLX;

			private TaskAwaiter FUL5wtTZG0;

			private void MoveNext()
			{
				int num = Qli5y1x53t;
				_003C_003Ec__DisplayClass12_0 obj = dRv5iQh94h;
				try
				{
					if ((uint)num > 1u)
					{
						obj.XWPKpALYnK.Items.Clear();
					}
					try
					{
						TaskAwaiter<ResponseList<YTVideoResponseDto>> awaiter;
						if (num != 0)
						{
							if (num == 1)
							{
								goto IL_0118;
							}
							obj.XWPKpALYnK.SearchQuery.Page = 1;
							obj.XWPKpALYnK.SearchQuery.Order = obj.WO4KicwRVA;
							awaiter = CCsbDQUN65g5h7XQhOJ.D35lls5iF(obj.XWPKpALYnK.Tav0A4reVK, obj.XWPKpALYnK.SearchQuery, CCsbDQUN65g5h7XQhOJ.VXMUOJY7xk).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = (Qli5y1x53t = 0);
								Akx5mRjFbN = awaiter;
								Bqx5pu5Pmc.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = Akx5mRjFbN;
							Akx5mRjFbN = default(TaskAwaiter<ResponseList<YTVideoResponseDto>>);
							num = (Qli5y1x53t = -1);
						}
						ResponseList<YTVideoResponseDto> result = awaiter.GetResult();
						opv53bcstW = result;
						if (opv53bcstW != null && opv53bcstW.Status)
						{
							UCi5XsbB9X = opv53bcstW.Data.Result.GetEnumerator();
							goto IL_0118;
						}
						obj.XWPKpALYnK.TotalCount = 0;
						goto IL_026d;
						IL_026d:
						opv53bcstW = null;
						goto end_IL_002d;
						IL_0118:
						try
						{
							if (num != 1)
							{
								goto IL_01c7;
							}
							TaskAwaiter awaiter2 = FUL5wtTZG0;
							FUL5wtTZG0 = default(TaskAwaiter);
							num = (Qli5y1x53t = -1);
							goto IL_019e;
							IL_019e:
							oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter2, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
							obj.XWPKpALYnK.Items.Add(WcB5RfByLX);
							WcB5RfByLX = null;
							goto IL_01c7;
							IL_01c7:
							if (hjMnupQVVDlRZAYQJC.D35lls5iF(UCi5XsbB9X, hjMnupQVVDlRZAYQJC.QV1TFwytOj))
							{
								WcB5RfByLX = UCi5XsbB9X.Current;
								awaiter2 = QliBEUviwWqgtMcBndV.D35lls5iF(pvrKKy8Mk1kpdmIfp3A.D35lls5iF(2, pvrKKy8Mk1kpdmIfp3A.aVh8SPrFkE), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
								if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter2, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
								{
									num = (Qli5y1x53t = 1);
									FUL5wtTZG0 = awaiter2;
									Bqx5pu5Pmc.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									return;
								}
								goto IL_019e;
							}
						}
						finally
						{
							if (num < 0 && UCi5XsbB9X != null)
							{
								xLO56JniGyickVjO1Ot.D35lls5iF(UCi5XsbB9X, xLO56JniGyickVjO1Ot.ydbT2bsoH4);
							}
						}
						UCi5XsbB9X = null;
						obj.XWPKpALYnK.CurrentPage = opv53bcstW.Data.CurrentPage;
						obj.XWPKpALYnK.PageCount = opv53bcstW.Data.PageCount;
						obj.XWPKpALYnK.TotalCount = opv53bcstW.Data.Total;
						goto IL_026d;
						end_IL_002d:;
					}
					catch
					{
						obj.XWPKpALYnK.TotalCount = 0;
					}
				}
				catch (Exception ex)
				{
					Qli5y1x53t = -2;
					N2XUglA3neBsnlZfRPQ.D35lls5iF(ref Bqx5pu5Pmc, ex, N2XUglA3neBsnlZfRPQ.l4pATRumoW);
					return;
				}
				Qli5y1x53t = -2;
				T4XmPoA4VNJJP1afcgL.D35lls5iF(ref Bqx5pu5Pmc, T4XmPoA4VNJJP1afcgL.TRyALZckCh);
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine P_0)
			{
				dHWo7jAEn6E4X7bsY4R.D35lls5iF(ref Bqx5pu5Pmc, P_0, dHWo7jAEn6E4X7bsY4R.z3hAB6UZ9o);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine P_0)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(P_0);
			}
		}

		public YtVideosViewModel XWPKpALYnK;

		public SortOrder WO4KicwRVA;

		public _003C_003Ec__DisplayClass12_0()
		{
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
			base._002Ector();
		}

		[AsyncStateMachine(typeof(rUfQsbjPhKJe2or9sGs))]
		internal void VqCKyclZQx()
		{
			rUfQsbjPhKJe2or9sGs stateMachine = default(rUfQsbjPhKJe2or9sGs);
			stateMachine.Bqx5pu5Pmc = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
			stateMachine.dRv5iQh94h = this;
			stateMachine.Qli5y1x53t = -1;
			stateMachine.Bqx5pu5Pmc.Start(ref stateMachine);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass15_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct M5569VjqT6LkTpGFWbv : IAsyncStateMachine
		{
			public int DfC5EudnFp;

			public AsyncVoidMethodBuilder FIf59n9Zcb;

			public _003C_003Ec__DisplayClass15_0 iAW5el1bga;

			private ResponseList<YTVideoResponseDto> iOw5OD4DUg;

			private TaskAwaiter<ResponseList<YTVideoResponseDto>> hqB5roLhNl;

			private IEnumerator<YTVideoResponseDto> nsc5HBdWCe;

			private YTVideoResponseDto LRP5oLvoKt;

			private TaskAwaiter mcm5gyuuhb;

			private void MoveNext()
			{
				int num = DfC5EudnFp;
				_003C_003Ec__DisplayClass15_0 obj = iAW5el1bga;
				try
				{
					if ((uint)num > 1u)
					{
						obj.kJJKmQT05Y.Items.Clear();
					}
					try
					{
						TaskAwaiter<ResponseList<YTVideoResponseDto>> awaiter;
						if (num != 0)
						{
							if (num == 1)
							{
								goto IL_0118;
							}
							obj.kJJKmQT05Y.SearchQuery.Page = 1;
							obj.kJJKmQT05Y.SearchQuery.Sort = obj.WxpKX58RVu;
							awaiter = CCsbDQUN65g5h7XQhOJ.D35lls5iF(obj.kJJKmQT05Y.Tav0A4reVK, obj.kJJKmQT05Y.SearchQuery, CCsbDQUN65g5h7XQhOJ.VXMUOJY7xk).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = (DfC5EudnFp = 0);
								hqB5roLhNl = awaiter;
								FIf59n9Zcb.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = hqB5roLhNl;
							hqB5roLhNl = default(TaskAwaiter<ResponseList<YTVideoResponseDto>>);
							num = (DfC5EudnFp = -1);
						}
						ResponseList<YTVideoResponseDto> result = awaiter.GetResult();
						iOw5OD4DUg = result;
						if (iOw5OD4DUg != null && iOw5OD4DUg.Status)
						{
							nsc5HBdWCe = iOw5OD4DUg.Data.Result.GetEnumerator();
							goto IL_0118;
						}
						obj.kJJKmQT05Y.TotalCount = 0;
						goto IL_026d;
						IL_026d:
						iOw5OD4DUg = null;
						goto end_IL_002d;
						IL_0118:
						try
						{
							if (num != 1)
							{
								goto IL_01c7;
							}
							TaskAwaiter awaiter2 = mcm5gyuuhb;
							mcm5gyuuhb = default(TaskAwaiter);
							num = (DfC5EudnFp = -1);
							goto IL_019e;
							IL_019e:
							oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter2, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
							obj.kJJKmQT05Y.Items.Add(LRP5oLvoKt);
							LRP5oLvoKt = null;
							goto IL_01c7;
							IL_01c7:
							if (hjMnupQVVDlRZAYQJC.D35lls5iF(nsc5HBdWCe, hjMnupQVVDlRZAYQJC.QV1TFwytOj))
							{
								LRP5oLvoKt = nsc5HBdWCe.Current;
								awaiter2 = QliBEUviwWqgtMcBndV.D35lls5iF(pvrKKy8Mk1kpdmIfp3A.D35lls5iF(2, pvrKKy8Mk1kpdmIfp3A.aVh8SPrFkE), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
								if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter2, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
								{
									num = (DfC5EudnFp = 1);
									mcm5gyuuhb = awaiter2;
									FIf59n9Zcb.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									return;
								}
								goto IL_019e;
							}
						}
						finally
						{
							if (num < 0 && nsc5HBdWCe != null)
							{
								xLO56JniGyickVjO1Ot.D35lls5iF(nsc5HBdWCe, xLO56JniGyickVjO1Ot.ydbT2bsoH4);
							}
						}
						nsc5HBdWCe = null;
						obj.kJJKmQT05Y.CurrentPage = iOw5OD4DUg.Data.CurrentPage;
						obj.kJJKmQT05Y.PageCount = iOw5OD4DUg.Data.PageCount;
						obj.kJJKmQT05Y.TotalCount = iOw5OD4DUg.Data.Total;
						goto IL_026d;
						end_IL_002d:;
					}
					catch
					{
						obj.kJJKmQT05Y.TotalCount = 0;
					}
				}
				catch (Exception ex)
				{
					DfC5EudnFp = -2;
					N2XUglA3neBsnlZfRPQ.D35lls5iF(ref FIf59n9Zcb, ex, N2XUglA3neBsnlZfRPQ.l4pATRumoW);
					return;
				}
				DfC5EudnFp = -2;
				T4XmPoA4VNJJP1afcgL.D35lls5iF(ref FIf59n9Zcb, T4XmPoA4VNJJP1afcgL.TRyALZckCh);
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine P_0)
			{
				dHWo7jAEn6E4X7bsY4R.D35lls5iF(ref FIf59n9Zcb, P_0, dHWo7jAEn6E4X7bsY4R.z3hAB6UZ9o);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine P_0)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(P_0);
			}
		}

		public YtVideosViewModel kJJKmQT05Y;

		public YTVideoSort WxpKX58RVu;

		public _003C_003Ec__DisplayClass15_0()
		{
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
			base._002Ector();
		}

		[AsyncStateMachine(typeof(M5569VjqT6LkTpGFWbv))]
		internal void vSHK30dQUa()
		{
			M5569VjqT6LkTpGFWbv stateMachine = default(M5569VjqT6LkTpGFWbv);
			stateMachine.FIf59n9Zcb = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
			stateMachine.iAW5el1bga = this;
			stateMachine.DfC5EudnFp = -1;
			stateMachine.FIf59n9Zcb.Start(ref stateMachine);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnPlayAllCommandExcute_003Ed__36 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public YtVideosViewModel _003C_003E4__this;

		private YtVideoPlayerViewModel _003CviewModel_003E5__2;

		private Page _003Cpage_003E5__3;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			YtVideosViewModel ytVideosViewModel = _003C_003E4__this;
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
						goto IL_014f;
					}
					_003CviewModel_003E5__2 = new YtVideoPlayerViewModel();
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(xAAOHZUbtAXo3rUUbhP.D35lls5iF(_003CviewModel_003E5__2, ytVideosViewModel.Items, xAAOHZUbtAXo3rUUbhP.UuZUWjAJBs), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
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
				KBhlAv9D2TgBJ1kkc0B.D35lls5iF(page, IyGDDwHBiPv8vfOFJDF.D35lls5iF(ApplicationPage.YoutubePlayer, _003CviewModel_003E5__2, IyGDDwHBiPv8vfOFJDF.hivH0XYhaE), KBhlAv9D2TgBJ1kkc0B.fWUHrWO7Sa);
				qni3xrDkAJ3vF35eMav.D35lls5iF(page, EBgwuVHeVLDJVVfMaAk.D35lls5iF(ApplicationPage.YoutubePlayer, EBgwuVHeVLDJVVfMaAk.mtcHG3MEy3), qni3xrDkAJ3vF35eMav.Ra7HRFTvnD);
				_003Cpage_003E5__3 = page;
				awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(pvrKKy8Mk1kpdmIfp3A.D35lls5iF(5, pvrKKy8Mk1kpdmIfp3A.aVh8SPrFkE), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
				if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
				{
					num = (_003C_003E1__state = 1);
					_003C_003Eu__1 = awaiter;
					_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
					return;
				}
				goto IL_014f;
				IL_014f:
				oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
				GmMLaTD7kV8rq88ZFvR.D35lls5iF(Xlypb0Hnr2C3ydrYEdG.D35lls5iF(ytVideosViewModel.dkB0FvWnpC, Xlypb0Hnr2C3ydrYEdG.U3Z1IKMGuZ), _003Cpage_003E5__3, GmMLaTD7kV8rq88ZFvR.iMJHkmaaRY);
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
	private struct _003CLoadVideos_003Ed__38 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public YtVideosViewModel _003C_003E4__this;

		private bool _003CtryAgain_003E5__2;

		private object _003C_003E7__wrap2;

		private int _003C_003E7__wrap3;

		private ResponseList<YTVideoResponseDto> _003Cresult_003E5__5;

		private TaskAwaiter<ResponseList<YTVideoResponseDto>> _003C_003Eu__1;

		private IEnumerator<YTVideoResponseDto> _003C_003E7__wrap5;

		private YTVideoResponseDto _003Citem_003E5__7;

		private TaskAwaiter _003C_003Eu__2;

		private TaskAwaiter<bool> _003C_003Eu__3;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			YtVideosViewModel ytVideosViewModel = _003C_003E4__this;
			try
			{
				if ((uint)num <= 1u)
				{
					goto IL_008c;
				}
				if (num != 2)
				{
					ytVideosViewModel.Items.Clear();
					ytVideosViewModel.SearchQuery.Page = 1;
					ytVideosViewModel.SearchQuery.Count = 25;
					ytVideosViewModel.SearchQuery.Order = SortOrder.Desc;
					lASFo76QIUBEikAAsE9.D35lls5iF(ytVideosViewModel.SearchQuery.Search, null, lASFo76QIUBEikAAsE9.UMA6X462Ew);
					_003CtryAgain_003E5__2 = true;
					goto IL_03a9;
				}
				TaskAwaiter<bool> awaiter = _003C_003Eu__3;
				_003C_003Eu__3 = default(TaskAwaiter<bool>);
				num = (_003C_003E1__state = -1);
				goto IL_0378;
				IL_03a2:
				_003C_003E7__wrap2 = null;
				goto IL_03a9;
				IL_0378:
				if (awaiter.GetResult())
				{
					_003CtryAgain_003E5__2 = true;
					ytVideosViewModel.Tav0A4reVK = AppContainer.Resolve<IYoutubeService>();
				}
				goto IL_03a2;
				IL_008c:
				try
				{
					TaskAwaiter<ResponseList<YTVideoResponseDto>> awaiter2;
					if (num != 0)
					{
						if (num == 1)
						{
							goto IL_0149;
						}
						awaiter2 = CCsbDQUN65g5h7XQhOJ.D35lls5iF(ytVideosViewModel.Tav0A4reVK, ytVideosViewModel.SearchQuery, CCsbDQUN65g5h7XQhOJ.VXMUOJY7xk).GetAwaiter();
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
						_003C_003Eu__1 = default(TaskAwaiter<ResponseList<YTVideoResponseDto>>);
						num = (_003C_003E1__state = -1);
					}
					ResponseList<YTVideoResponseDto> result = awaiter2.GetResult();
					_003Cresult_003E5__5 = result;
					if (_003Cresult_003E5__5 != null && _003Cresult_003E5__5.Status)
					{
						_003C_003E7__wrap5 = _003Cresult_003E5__5.Data.Result.GetEnumerator();
						goto IL_0149;
					}
					ytVideosViewModel.TotalCount = 0;
					goto IL_02c8;
					IL_02c8:
					_003Cresult_003E5__5 = null;
					goto end_IL_008c;
					IL_0149:
					try
					{
						if (num != 1)
						{
							goto IL_01f3;
						}
						TaskAwaiter awaiter3 = _003C_003Eu__2;
						_003C_003Eu__2 = default(TaskAwaiter);
						num = (_003C_003E1__state = -1);
						goto IL_01cf;
						IL_01cf:
						oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter3, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
						ytVideosViewModel.Items.Add(_003Citem_003E5__7);
						_003Citem_003E5__7 = null;
						goto IL_01f3;
						IL_01f3:
						if (hjMnupQVVDlRZAYQJC.D35lls5iF(_003C_003E7__wrap5, hjMnupQVVDlRZAYQJC.QV1TFwytOj))
						{
							_003Citem_003E5__7 = _003C_003E7__wrap5.Current;
							awaiter3 = QliBEUviwWqgtMcBndV.D35lls5iF(pvrKKy8Mk1kpdmIfp3A.D35lls5iF(2, pvrKKy8Mk1kpdmIfp3A.aVh8SPrFkE), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
							if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter3, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
							{
								num = (_003C_003E1__state = 1);
								_003C_003Eu__2 = awaiter3;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
								return;
							}
							goto IL_01cf;
						}
					}
					finally
					{
						if (num < 0 && _003C_003E7__wrap5 != null)
						{
							xLO56JniGyickVjO1Ot.D35lls5iF(_003C_003E7__wrap5, xLO56JniGyickVjO1Ot.ydbT2bsoH4);
						}
					}
					_003C_003E7__wrap5 = null;
					ytVideosViewModel.CurrentPage = _003Cresult_003E5__5.Data.CurrentPage;
					ytVideosViewModel.PageCount = _003Cresult_003E5__5.Data.PageCount;
					ytVideosViewModel.TotalCount = _003Cresult_003E5__5.Data.Total;
					YTVideoResponseDto? yTVideoResponseDto = ytVideosViewModel.Items.FirstOrDefault();
					m5sZxWmLHUhVHrJe8sC.D35lls5iF(ytVideosViewModel, ((yTVideoResponseDto != null) ? eVlRnEIaHT0dqvCx0Kx.D35lls5iF(yTVideoResponseDto, eVlRnEIaHT0dqvCx0Kx.P81U5Aadqg) : null) ?? iFZ5je3XFYKwkvcE5D.D35lls5iF(16718, iFZ5je3XFYKwkvcE5D.N06TeK0ao), m5sZxWmLHUhVHrJe8sC.z3kUzDyywp);
					goto IL_02c8;
					end_IL_008c:;
				}
				catch (PROTVException ex)
				{
					_003C_003E7__wrap2 = ex;
					_003C_003E7__wrap3 = 1;
				}
				int num2 = _003C_003E7__wrap3;
				if (num2 == 1)
				{
					if (TNckS5wtLfB2Lk9dYP8.D35lls5iF((PROTVException)_003C_003E7__wrap2, TNckS5wtLfB2Lk9dYP8.oGkwV3iq3t) == ExceptionType.AuthorizationTokenInvalid)
					{
						awaiter = bAA7Sxw7vZsvusOmDea.D35lls5iF(AppContainer.Resolve<MainViewModel>(), bAA7Sxw7vZsvusOmDea.gytwc9U7r5).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (_003C_003E1__state = 2);
							_003C_003Eu__3 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_0378;
					}
					ytVideosViewModel.TotalCount = 0;
				}
				goto IL_03a2;
				IL_03a9:
				if (_003CtryAgain_003E5__2)
				{
					_003CtryAgain_003E5__2 = false;
					_003C_003E7__wrap3 = 0;
					goto IL_008c;
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
	private struct _003COnFetchMoreDataCommand_003Ed__40 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public YtVideosViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			YtVideosViewModel ytVideosViewModel = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_009d;
				}
				if (ytVideosViewModel.CurrentPage < ytVideosViewModel.TotalCount && !hjMnupQVVDlRZAYQJC.D35lls5iF(ytVideosViewModel, hjMnupQVVDlRZAYQJC.jJYTSHn9tB))
				{
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(ytVideosViewModel.AddMoreItems(), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
					if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_009d;
				}
				goto end_IL_0015;
				IL_009d:
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
	private struct _003COnGotoChannelsListExcute_003Ed__41 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public YtVideosViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			YtVideosViewModel ytVideosViewModel = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(pvrKKy8Mk1kpdmIfp3A.D35lls5iF(1, pvrKKy8Mk1kpdmIfp3A.aVh8SPrFkE), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
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
				m5sZxWmLHUhVHrJe8sC.D35lls5iF(ytVideosViewModel.FJP0CPgNe4, iFZ5je3XFYKwkvcE5D.D35lls5iF(14442, iFZ5je3XFYKwkvcE5D.N06TeK0ao), m5sZxWmLHUhVHrJe8sC.DWQUQPjnyY);
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
	private struct _003COnGoToChannelCommandExcute_003Ed__42 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public YtVideosViewModel _003C_003E4__this;

		public YTVideoResponseDto obj;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			YtVideosViewModel ytVideosViewModel = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(pvrKKy8Mk1kpdmIfp3A.D35lls5iF(1, pvrKKy8Mk1kpdmIfp3A.aVh8SPrFkE), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
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
				vQKA0r9sJ1kArsIHc16.D35lls5iF(ytVideosViewModel.FJP0CPgNe4, lVnioXU659dV87DBnh4.D35lls5iF(obj, lVnioXU659dV87DBnh4.xygUgLZL5h), vQKA0r9sJ1kArsIHc16.IogUiUt4Qi);
				m5sZxWmLHUhVHrJe8sC.D35lls5iF(ytVideosViewModel.FJP0CPgNe4, iFZ5je3XFYKwkvcE5D.D35lls5iF(14394, iFZ5je3XFYKwkvcE5D.N06TeK0ao), m5sZxWmLHUhVHrJe8sC.DWQUQPjnyY);
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
	private struct _003COnWatchLaterCommandExcute_003Ed__43 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public YtVideosViewModel _003C_003E4__this;

		public YTVideoResponseDto obj;

		private TaskAwaiter<bool> _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			YtVideosViewModel ytVideosViewModel = _003C_003E4__this;
			try
			{
				TaskAwaiter<bool> awaiter;
				if (num != 0)
				{
					awaiter = VbmtIFmnFwg9sqb4Jje.D35lls5iF(ytVideosViewModel.Tav0A4reVK, m9MGZR7k2RmVqYXYS5.D35lls5iF(obj, m9MGZR7k2RmVqYXYS5.r6tnXN0WTV), VbmtIFmnFwg9sqb4Jje.i4xUIaDACp).GetAwaiter();
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
					if (LsA6RHpKkbdnOn3fX60.D35lls5iF(obj, LsA6RHpKkbdnOn3fX60.xX0UdhGXeO) && S1a0wT9Ixre9OpDny8h.D35lls5iF(eVlRnEIaHT0dqvCx0Kx.D35lls5iF(ytVideosViewModel.FJP0CPgNe4, eVlRnEIaHT0dqvCx0Kx.bTbtoUYxPU), iFZ5je3XFYKwkvcE5D.D35lls5iF(14368, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO))
					{
						ytVideosViewModel.Items.Remove(obj);
					}
					jPB9Q5LdIM9wsuWV1q7.D35lls5iF(obj, !LsA6RHpKkbdnOn3fX60.D35lls5iF(obj, LsA6RHpKkbdnOn3fX60.xX0UdhGXeO), jPB9Q5LdIM9wsuWV1q7.vSrUUVAWG1);
					m5sZxWmLHUhVHrJe8sC.D35lls5iF(obj, iFZ5je3XFYKwkvcE5D.D35lls5iF(14214, iFZ5je3XFYKwkvcE5D.N06TeK0ao), m5sZxWmLHUhVHrJe8sC.d7tdmFAOdw);
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

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CAddMoreItems_003Ed__45 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public YtVideosViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			YtVideosViewModel CS_0024_003C_003E8__locals5 = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_00ea;
				}
				if (CS_0024_003C_003E8__locals5.TotalCount > CS_0024_003C_003E8__locals5.Items.Count)
				{
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(W7S2sip6SDieZFVsNbd.D35lls5iF(CS_0024_003C_003E8__locals5, Expression.Lambda<Func<bool>>(OWBKr5pvc5MWsK1OMtR.D35lls5iF(o4bYL4peNeC2wWb8yjx.D35lls5iF(CS_0024_003C_003E8__locals5, sjYxHO8OWlc6X80hFj7.D35lls5iF(typeof(YtVideosViewModel).TypeHandle, sjYxHO8OWlc6X80hFj7.uWZ8ugU7r5), o4bYL4peNeC2wWb8yjx.oVdpGKjy2x), (MethodInfo)f5q427pRQZnrEKPy4Ws.D35lls5iF((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, f5q427pRQZnrEKPy4Ws.Bo9pk3m4k7), OWBKr5pvc5MWsK1OMtR.fZIpAAdi1v), Array.Empty<ParameterExpression>()), [AsyncStateMachine(typeof(_003C_003CAddMoreItems_003Eb__45_1_003Ed))] () =>
					{
						_003C_003CAddMoreItems_003Eb__45_1_003Ed stateMachine = default(_003C_003CAddMoreItems_003Eb__45_1_003Ed);
						stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
						stateMachine._003C_003E4__this = CS_0024_003C_003E8__locals5;
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
					goto IL_00ea;
				}
				goto end_IL_0015;
				IL_00ea:
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
	private struct _003CGoToPage_003Ed__46 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public YTVideoResponseDto model;

		public YtVideosViewModel _003C_003E4__this;

		private YtVideoPlayerViewModel _003CviewModel_003E5__2;

		private Page _003Cpage_003E5__3;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			YtVideosViewModel ytVideosViewModel = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_00b4;
				}
				if (num == 1)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_0165;
				}
				if (m9MGZR7k2RmVqYXYS5.D35lls5iF(model, m9MGZR7k2RmVqYXYS5.r6tnXN0WTV) > 0)
				{
					_003CviewModel_003E5__2 = new YtVideoPlayerViewModel();
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(hnVdJ7tlwwTQvJJ7Vha.D35lls5iF(_003CviewModel_003E5__2, model, hnVdJ7tlwwTQvJJ7Vha.oXrt9biorg), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
					if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_00b4;
				}
				goto end_IL_0015;
				IL_0165:
				oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
				GmMLaTD7kV8rq88ZFvR.D35lls5iF(Xlypb0Hnr2C3ydrYEdG.D35lls5iF(ytVideosViewModel.dkB0FvWnpC, Xlypb0Hnr2C3ydrYEdG.U3Z1IKMGuZ), _003Cpage_003E5__3, GmMLaTD7kV8rq88ZFvR.iMJHkmaaRY);
				_003CviewModel_003E5__2 = null;
				_003Cpage_003E5__3 = null;
				goto end_IL_0015;
				IL_00b4:
				oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
				Page page = new Page();
				KBhlAv9D2TgBJ1kkc0B.D35lls5iF(page, IyGDDwHBiPv8vfOFJDF.D35lls5iF(ApplicationPage.YoutubePlayer, _003CviewModel_003E5__2, IyGDDwHBiPv8vfOFJDF.hivH0XYhaE), KBhlAv9D2TgBJ1kkc0B.fWUHrWO7Sa);
				qni3xrDkAJ3vF35eMav.D35lls5iF(page, EBgwuVHeVLDJVVfMaAk.D35lls5iF(ApplicationPage.YoutubePlayer, EBgwuVHeVLDJVVfMaAk.mtcHG3MEy3), qni3xrDkAJ3vF35eMav.Ra7HRFTvnD);
				_003Cpage_003E5__3 = page;
				awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(pvrKKy8Mk1kpdmIfp3A.D35lls5iF(5, pvrKKy8Mk1kpdmIfp3A.aVh8SPrFkE), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
				if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
				{
					num = (_003C_003E1__state = 1);
					_003C_003Eu__1 = awaiter;
					_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
					return;
				}
				goto IL_0165;
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
	private struct _003CLoadAsync_003Ed__48 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public YtVideosViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			YtVideosViewModel CS_0024_003C_003E8__locals3 = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(W7S2sip6SDieZFVsNbd.D35lls5iF(CS_0024_003C_003E8__locals3, Expression.Lambda<Func<bool>>(OWBKr5pvc5MWsK1OMtR.D35lls5iF(o4bYL4peNeC2wWb8yjx.D35lls5iF(CS_0024_003C_003E8__locals3, sjYxHO8OWlc6X80hFj7.D35lls5iF(typeof(YtVideosViewModel).TypeHandle, sjYxHO8OWlc6X80hFj7.uWZ8ugU7r5), o4bYL4peNeC2wWb8yjx.oVdpGKjy2x), (MethodInfo)f5q427pRQZnrEKPy4Ws.D35lls5iF((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, f5q427pRQZnrEKPy4Ws.Bo9pk3m4k7), OWBKr5pvc5MWsK1OMtR.fZIpAAdi1v), Array.Empty<ParameterExpression>()), [AsyncStateMachine(typeof(_003C_003CLoadAsync_003Eb__48_1_003Ed))] () =>
					{
						_003C_003CLoadAsync_003Eb__48_1_003Ed stateMachine = default(_003C_003CLoadAsync_003Eb__48_1_003Ed);
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
	private struct _003C_003CAddMoreItems_003Eb__45_1_003Ed : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public YtVideosViewModel _003C_003E4__this;

		private bool _003CtryAgain_003E5__2;

		private object _003C_003E7__wrap2;

		private int _003C_003E7__wrap3;

		private ResponseList<YTVideoResponseDto> _003Cresult_003E5__5;

		private TaskAwaiter<ResponseList<YTVideoResponseDto>> _003C_003Eu__1;

		private IEnumerator<YTVideoResponseDto> _003C_003E7__wrap5;

		private YTVideoResponseDto _003Citem_003E5__7;

		private TaskAwaiter _003C_003Eu__2;

		private TaskAwaiter<bool> _003C_003Eu__3;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			YtVideosViewModel ytVideosViewModel = _003C_003E4__this;
			try
			{
				if ((uint)num <= 1u)
				{
					goto IL_0053;
				}
				if (num != 2)
				{
					ytVideosViewModel.SearchQuery.Page++;
					_003CtryAgain_003E5__2 = true;
					goto IL_0347;
				}
				TaskAwaiter<bool> awaiter = _003C_003Eu__3;
				_003C_003Eu__3 = default(TaskAwaiter<bool>);
				num = (_003C_003E1__state = -1);
				goto IL_0308;
				IL_0340:
				_003C_003E7__wrap2 = null;
				goto IL_0347;
				IL_0308:
				if (awaiter.GetResult())
				{
					_003CtryAgain_003E5__2 = true;
					ytVideosViewModel.Tav0A4reVK = AppContainer.Resolve<IYoutubeService>();
				}
				goto IL_0340;
				IL_0053:
				try
				{
					TaskAwaiter<ResponseList<YTVideoResponseDto>> awaiter2;
					if (num != 0)
					{
						if (num == 1)
						{
							goto IL_0110;
						}
						awaiter2 = CCsbDQUN65g5h7XQhOJ.D35lls5iF(ytVideosViewModel.Tav0A4reVK, ytVideosViewModel.SearchQuery, CCsbDQUN65g5h7XQhOJ.VXMUOJY7xk).GetAwaiter();
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
						_003C_003Eu__1 = default(TaskAwaiter<ResponseList<YTVideoResponseDto>>);
						num = (_003C_003E1__state = -1);
					}
					ResponseList<YTVideoResponseDto> result = awaiter2.GetResult();
					_003Cresult_003E5__5 = result;
					if (_003Cresult_003E5__5 != null && _003Cresult_003E5__5.Status)
					{
						_003C_003E7__wrap5 = _003Cresult_003E5__5.Data.Result.GetEnumerator();
						goto IL_0110;
					}
					ytVideosViewModel.SearchQuery.Page--;
					goto IL_025a;
					IL_025a:
					_003Cresult_003E5__5 = null;
					goto end_IL_0053;
					IL_0110:
					try
					{
						if (num != 1)
						{
							goto IL_01ba;
						}
						TaskAwaiter awaiter3 = _003C_003Eu__2;
						_003C_003Eu__2 = default(TaskAwaiter);
						num = (_003C_003E1__state = -1);
						goto IL_0196;
						IL_0196:
						oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter3, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
						ytVideosViewModel.Items.Add(_003Citem_003E5__7);
						_003Citem_003E5__7 = null;
						goto IL_01ba;
						IL_01ba:
						if (hjMnupQVVDlRZAYQJC.D35lls5iF(_003C_003E7__wrap5, hjMnupQVVDlRZAYQJC.QV1TFwytOj))
						{
							_003Citem_003E5__7 = _003C_003E7__wrap5.Current;
							awaiter3 = QliBEUviwWqgtMcBndV.D35lls5iF(pvrKKy8Mk1kpdmIfp3A.D35lls5iF(2, pvrKKy8Mk1kpdmIfp3A.aVh8SPrFkE), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
							if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter3, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
							{
								num = (_003C_003E1__state = 1);
								_003C_003Eu__2 = awaiter3;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
								return;
							}
							goto IL_0196;
						}
					}
					finally
					{
						if (num < 0 && _003C_003E7__wrap5 != null)
						{
							xLO56JniGyickVjO1Ot.D35lls5iF(_003C_003E7__wrap5, xLO56JniGyickVjO1Ot.ydbT2bsoH4);
						}
					}
					_003C_003E7__wrap5 = null;
					ytVideosViewModel.CurrentPage = _003Cresult_003E5__5.Data.CurrentPage;
					ytVideosViewModel.PageCount = _003Cresult_003E5__5.Data.PageCount;
					ytVideosViewModel.TotalCount = _003Cresult_003E5__5.Data.Total;
					goto IL_025a;
					end_IL_0053:;
				}
				catch (PROTVException ex)
				{
					_003C_003E7__wrap2 = ex;
					_003C_003E7__wrap3 = 1;
				}
				int num2 = _003C_003E7__wrap3;
				if (num2 == 1)
				{
					if (TNckS5wtLfB2Lk9dYP8.D35lls5iF((PROTVException)_003C_003E7__wrap2, TNckS5wtLfB2Lk9dYP8.oGkwV3iq3t) == ExceptionType.AuthorizationTokenInvalid)
					{
						awaiter = bAA7Sxw7vZsvusOmDea.D35lls5iF(AppContainer.Resolve<MainViewModel>(), bAA7Sxw7vZsvusOmDea.gytwc9U7r5).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (_003C_003E1__state = 2);
							_003C_003Eu__3 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_0308;
					}
					ytVideosViewModel.SearchQuery.Page--;
				}
				goto IL_0340;
				IL_0347:
				if (_003CtryAgain_003E5__2)
				{
					_003CtryAgain_003E5__2 = false;
					_003C_003E7__wrap3 = 0;
					goto IL_0053;
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
	private struct _003C_003CLoadAsync_003Eb__48_1_003Ed : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public YtVideosViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			YtVideosViewModel ytVideosViewModel = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(VrVteFCs0OCGBTVr1mZ.D35lls5iF(new Task[1] { OYihPsCZ1OyLa5m4TD0.D35lls5iF(ytVideosViewModel, OYihPsCZ1OyLa5m4TD0.evrtDDPja8) }, VrVteFCs0OCGBTVr1mZ.qNlChUR2Cs), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
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

	private IYoutubeService Tav0A4reVK;

	private SortOrder YK30NFsiQw;

	private YTVideoSort rkm0MYHySl;

	private readonly YtViewModel FJP0CPgNe4;

	private string syE0YFJIke;

	private readonly HomeViewModel dkB0FvWnpC;

	[CompilerGenerated]
	private List<LanguageResponseDto> dVw06L2ObF;

	[CompilerGenerated]
	private ICommand HJT0styEQ0;

	[CompilerGenerated]
	private ICommand HEN0xuipSy;

	[CompilerGenerated]
	private ICommand dph0yRs6Vb;

	[CompilerGenerated]
	private ICommand QD80p7wDvZ;

	public List<LanguageResponseDto> Languages
	{
		[CompilerGenerated]
		get
		{
			return dVw06L2ObF;
		}
		[CompilerGenerated]
		set
		{
			dVw06L2ObF = value;
		}
	}

	public SortOrder SelectedOrder
	{
		get
		{
			return YK30NFsiQw;
		}
		set
		{
			_003C_003Ec__DisplayClass12_0 CS_0024_003C_003E8__locals4 = new _003C_003Ec__DisplayClass12_0();
			CS_0024_003C_003E8__locals4.XWPKpALYnK = this;
			CS_0024_003C_003E8__locals4.WO4KicwRVA = value;
			SetProperty(ref YK30NFsiQw, CS_0024_003C_003E8__locals4.WO4KicwRVA, iFZ5je3XFYKwkvcE5D.D35lls5iF(8208, iFZ5je3XFYKwkvcE5D.N06TeK0ao), null, [AsyncStateMachine(typeof(_003C_003Ec__DisplayClass12_0.rUfQsbjPhKJe2or9sGs))] () =>
			{
				_003C_003Ec__DisplayClass12_0.rUfQsbjPhKJe2or9sGs stateMachine = default(_003C_003Ec__DisplayClass12_0.rUfQsbjPhKJe2or9sGs);
				stateMachine.Bqx5pu5Pmc = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
				stateMachine.dRv5iQh94h = CS_0024_003C_003E8__locals4;
				stateMachine.Qli5y1x53t = -1;
				stateMachine.Bqx5pu5Pmc.Start(ref stateMachine);
			});
		}
	}

	public YTVideoSort SelectedSort
	{
		get
		{
			return rkm0MYHySl;
		}
		set
		{
			_003C_003Ec__DisplayClass15_0 CS_0024_003C_003E8__locals4 = new _003C_003Ec__DisplayClass15_0();
			CS_0024_003C_003E8__locals4.kJJKmQT05Y = this;
			CS_0024_003C_003E8__locals4.WxpKX58RVu = value;
			SetProperty(ref rkm0MYHySl, CS_0024_003C_003E8__locals4.WxpKX58RVu, iFZ5je3XFYKwkvcE5D.D35lls5iF(10222, iFZ5je3XFYKwkvcE5D.N06TeK0ao), null, [AsyncStateMachine(typeof(_003C_003Ec__DisplayClass15_0.M5569VjqT6LkTpGFWbv))] () =>
			{
				_003C_003Ec__DisplayClass15_0.M5569VjqT6LkTpGFWbv stateMachine = default(_003C_003Ec__DisplayClass15_0.M5569VjqT6LkTpGFWbv);
				stateMachine.FIf59n9Zcb = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
				stateMachine.iAW5el1bga = CS_0024_003C_003E8__locals4;
				stateMachine.DfC5EudnFp = -1;
				stateMachine.FIf59n9Zcb.Start(ref stateMachine);
			});
		}
	}

	public ICommand GoToChannelCommand
	{
		[CompilerGenerated]
		get
		{
			return HJT0styEQ0;
		}
		[CompilerGenerated]
		set
		{
			HJT0styEQ0 = value;
		}
	}

	public ICommand WatchLaterCommand
	{
		[CompilerGenerated]
		get
		{
			return HEN0xuipSy;
		}
		[CompilerGenerated]
		set
		{
			HEN0xuipSy = value;
		}
	}

	public ICommand GotoChannelsList
	{
		[CompilerGenerated]
		get
		{
			return dph0yRs6Vb;
		}
		[CompilerGenerated]
		set
		{
			dph0yRs6Vb = value;
		}
	}

	public string Poster
	{
		get
		{
			return syE0YFJIke;
		}
		set
		{
			SetProperty(ref syE0YFJIke, value, iFZ5je3XFYKwkvcE5D.D35lls5iF(1046, iFZ5je3XFYKwkvcE5D.N06TeK0ao));
		}
	}

	public ICommand PlayAllCommand
	{
		[CompilerGenerated]
		get
		{
			return QD80p7wDvZ;
		}
		[CompilerGenerated]
		set
		{
			QD80p7wDvZ = value;
		}
	}

	public YtVideosViewModel()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		YK30NFsiQw = SortOrder.Desc;
		rkm0MYHySl = YTVideoSort.ActivateDate;
		base._002Ector();
		dkB0FvWnpC = AppContainer.Resolve<HomeViewModel>();
		Tav0A4reVK = AppContainer.Resolve<IYoutubeService>();
		base.FetchMoreDataCommand = new AsyncCommand(OnFetchMoreDataCommand);
		xTrtsa0dGrEHfQorHlS.D35lls5iF(this, new AsyncCommand(PWF0nWLUgH), xTrtsa0dGrEHfQorHlS.Uie0cy2aH3);
		base.SearchQuery = new ApiQuery<YTSearch, YTVideoSort>
		{
			Count = 25,
			Search = new YTSearch()
		};
		xTrtsa0dGrEHfQorHlS.D35lls5iF(this, new AsyncCommand<YTVideoResponseDto>(IEd07yHXPf), xTrtsa0dGrEHfQorHlS.gP20MCabHh);
		xTrtsa0dGrEHfQorHlS.D35lls5iF(this, new AsyncCommand<YTVideoResponseDto>(ueY0bHnWFo), xTrtsa0dGrEHfQorHlS.wcS0SA05kQ);
		xTrtsa0dGrEHfQorHlS.D35lls5iF(this, new AsyncCommand(eFM0QdeRjA), xTrtsa0dGrEHfQorHlS.qOT0KL912Z);
	}

	[AsyncStateMachine(typeof(_003COnPlayAllCommandExcute_003Ed__36))]
	private Task eFM0QdeRjA()
	{
		_003COnPlayAllCommandExcute_003Ed__36 stateMachine = default(_003COnPlayAllCommandExcute_003Ed__36);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	public YtVideosViewModel(YtViewModel youtubeViewModel)
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		this._002Ector();
		FJP0CPgNe4 = youtubeViewModel;
	}

	[AsyncStateMachine(typeof(_003CLoadVideos_003Ed__38))]
	public Task LoadVideos()
	{
		_003CLoadVideos_003Ed__38 stateMachine = default(_003CLoadVideos_003Ed__38);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	public void Clear()
	{
		_selectedItem = null;
		qni3xrDkAJ3vF35eMav.D35lls5iF(this, iFZ5je3XFYKwkvcE5D.D35lls5iF(8274, iFZ5je3XFYKwkvcE5D.N06TeK0ao), qni3xrDkAJ3vF35eMav.QN6DuDtCWO);
	}

	[AsyncStateMachine(typeof(_003COnFetchMoreDataCommand_003Ed__40))]
	protected Task OnFetchMoreDataCommand()
	{
		_003COnFetchMoreDataCommand_003Ed__40 stateMachine = default(_003COnFetchMoreDataCommand_003Ed__40);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	[AsyncStateMachine(typeof(_003COnGotoChannelsListExcute_003Ed__41))]
	private Task PWF0nWLUgH()
	{
		_003COnGotoChannelsListExcute_003Ed__41 stateMachine = default(_003COnGotoChannelsListExcute_003Ed__41);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	[AsyncStateMachine(typeof(_003COnGoToChannelCommandExcute_003Ed__42))]
	private Task ueY0bHnWFo(YTVideoResponseDto P_0)
	{
		_003COnGoToChannelCommandExcute_003Ed__42 stateMachine = default(_003COnGoToChannelCommandExcute_003Ed__42);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine.obj = P_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	[AsyncStateMachine(typeof(_003COnWatchLaterCommandExcute_003Ed__43))]
	private Task IEd07yHXPf(YTVideoResponseDto P_0)
	{
		_003COnWatchLaterCommandExcute_003Ed__43 stateMachine = default(_003COnWatchLaterCommandExcute_003Ed__43);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine.obj = P_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	public override void Dispose()
	{
		base.Items.Clear();
	}

	[AsyncStateMachine(typeof(_003CAddMoreItems_003Ed__45))]
	public override Task AddMoreItems()
	{
		_003CAddMoreItems_003Ed__45 stateMachine = default(_003CAddMoreItems_003Ed__45);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	[AsyncStateMachine(typeof(_003CGoToPage_003Ed__46))]
	public override Task GoToPage(YTVideoResponseDto model)
	{
		_003CGoToPage_003Ed__46 stateMachine = default(_003CGoToPage_003Ed__46);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine.model = model;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	public override void OnLoading()
	{
		fp757nBYjo8889efKFJ.D35lls5iF(this, fp757nBYjo8889efKFJ.gKO0NDTfrh);
		if (!base.Items.Any())
		{
			Task task = LoadAsync();
			Action<Exception> action = null;
			bool flag = false;
			gBlEqv8jRKikCj2DMZp.D35lls5iF(task, ref action, ref flag, gBlEqv8jRKikCj2DMZp.pSp8ymt8Mu);
		}
	}

	[AsyncStateMachine(typeof(_003CLoadAsync_003Ed__48))]
	public override Task LoadAsync()
	{
		_003CLoadAsync_003Ed__48 stateMachine = default(_003CLoadAsync_003Ed__48);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	[AsyncStateMachine(typeof(_003C_003CAddMoreItems_003Eb__45_1_003Ed))]
	[CompilerGenerated]
	private Task FoX05chC9p()
	{
		_003C_003CAddMoreItems_003Eb__45_1_003Ed stateMachine = default(_003C_003CAddMoreItems_003Eb__45_1_003Ed);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	[AsyncStateMachine(typeof(_003C_003CLoadAsync_003Eb__48_1_003Ed))]
	[CompilerGenerated]
	private Task x3w0uA4WGb()
	{
		_003C_003CLoadAsync_003Eb__48_1_003Ed stateMachine = default(_003C_003CLoadAsync_003Eb__48_1_003Ed);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}
}
