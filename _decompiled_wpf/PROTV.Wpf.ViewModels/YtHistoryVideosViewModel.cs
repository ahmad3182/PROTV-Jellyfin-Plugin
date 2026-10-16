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
using PROTV.Abstractions.Common;
using PROTV.Abstractions.DataTransferObjects;
using PROTV.Abstractions.Helpers;
using PROTV.Abstractions.Search;
using PROTV.Abstractions.Services;
using PROTV.Wpf.Bootstrap;

namespace PROTV.Wpf.ViewModels;

public class YtHistoryVideosViewModel : BaseListViewModel<YTHistoryResponseDto, ApiQuery<YTSearch, GeneralSort>>
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass11_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct HrfWHhjIaETIgni6Ok9 : IAsyncStateMachine
		{
			public int cL751isxtt;

			public AsyncVoidMethodBuilder VKo5J58kfL;

			public _003C_003Ec__DisplayClass11_0 kfD5hpo35V;

			private ResponseList<YTHistoryResponseDto> ck65l2iHOc;

			private TaskAwaiter<ResponseList<YTHistoryResponseDto>> WiJ5UTe4Ik;

			private IEnumerator<YTHistoryResponseDto> hdb5LqvYt7;

			private YTHistoryResponseDto vEr52G4QsV;

			private TaskAwaiter NlW5zCJAA2;

			private void MoveNext()
			{
				int num = cL751isxtt;
				_003C_003Ec__DisplayClass11_0 obj = kfD5hpo35V;
				try
				{
					if ((uint)num > 1u)
					{
						obj.sLkKw75El0.Items.Clear();
					}
					try
					{
						TaskAwaiter<ResponseList<YTHistoryResponseDto>> awaiter;
						if (num != 0)
						{
							if (num == 1)
							{
								goto IL_0118;
							}
							obj.sLkKw75El0.SearchQuery.Page = 1;
							obj.sLkKw75El0.SearchQuery.Order = obj.a1OKEp7MSf;
							awaiter = pAJBH9tHvLcCNSRcx41.D35lls5iF(obj.sLkKw75El0.vmO0X1G1n4, obj.sLkKw75El0.SearchQuery, pAJBH9tHvLcCNSRcx41.vRAt109fhA).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = (cL751isxtt = 0);
								WiJ5UTe4Ik = awaiter;
								VKo5J58kfL.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = WiJ5UTe4Ik;
							WiJ5UTe4Ik = default(TaskAwaiter<ResponseList<YTHistoryResponseDto>>);
							num = (cL751isxtt = -1);
						}
						ResponseList<YTHistoryResponseDto> result = awaiter.GetResult();
						ck65l2iHOc = result;
						if (ck65l2iHOc != null && ck65l2iHOc.Status)
						{
							hdb5LqvYt7 = ck65l2iHOc.Data.Result.GetEnumerator();
							goto IL_0118;
						}
						obj.sLkKw75El0.TotalCount = 0;
						goto IL_026d;
						IL_026d:
						ck65l2iHOc = null;
						goto end_IL_002d;
						IL_0118:
						try
						{
							if (num != 1)
							{
								goto IL_01c7;
							}
							TaskAwaiter awaiter2 = NlW5zCJAA2;
							NlW5zCJAA2 = default(TaskAwaiter);
							num = (cL751isxtt = -1);
							goto IL_019e;
							IL_019e:
							oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter2, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
							obj.sLkKw75El0.Items.Add(vEr52G4QsV);
							vEr52G4QsV = null;
							goto IL_01c7;
							IL_01c7:
							if (hjMnupQVVDlRZAYQJC.D35lls5iF(hdb5LqvYt7, hjMnupQVVDlRZAYQJC.QV1TFwytOj))
							{
								vEr52G4QsV = hdb5LqvYt7.Current;
								awaiter2 = QliBEUviwWqgtMcBndV.D35lls5iF(pvrKKy8Mk1kpdmIfp3A.D35lls5iF(2, pvrKKy8Mk1kpdmIfp3A.aVh8SPrFkE), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
								if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter2, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
								{
									num = (cL751isxtt = 1);
									NlW5zCJAA2 = awaiter2;
									VKo5J58kfL.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									return;
								}
								goto IL_019e;
							}
						}
						finally
						{
							if (num < 0 && hdb5LqvYt7 != null)
							{
								xLO56JniGyickVjO1Ot.D35lls5iF(hdb5LqvYt7, xLO56JniGyickVjO1Ot.ydbT2bsoH4);
							}
						}
						hdb5LqvYt7 = null;
						obj.sLkKw75El0.CurrentPage = ck65l2iHOc.Data.CurrentPage;
						obj.sLkKw75El0.PageCount = ck65l2iHOc.Data.PageCount;
						obj.sLkKw75El0.TotalCount = ck65l2iHOc.Data.Total;
						goto IL_026d;
						end_IL_002d:;
					}
					catch
					{
						obj.sLkKw75El0.TotalCount = 0;
					}
				}
				catch (Exception ex)
				{
					cL751isxtt = -2;
					N2XUglA3neBsnlZfRPQ.D35lls5iF(ref VKo5J58kfL, ex, N2XUglA3neBsnlZfRPQ.l4pATRumoW);
					return;
				}
				cL751isxtt = -2;
				T4XmPoA4VNJJP1afcgL.D35lls5iF(ref VKo5J58kfL, T4XmPoA4VNJJP1afcgL.TRyALZckCh);
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine P_0)
			{
				dHWo7jAEn6E4X7bsY4R.D35lls5iF(ref VKo5J58kfL, P_0, dHWo7jAEn6E4X7bsY4R.z3hAB6UZ9o);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine P_0)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(P_0);
			}
		}

		public YtHistoryVideosViewModel sLkKw75El0;

		public SortOrder a1OKEp7MSf;

		public _003C_003Ec__DisplayClass11_0()
		{
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
			base._002Ector();
		}

		[AsyncStateMachine(typeof(HrfWHhjIaETIgni6Ok9))]
		internal void EJwKR7Aerl()
		{
			HrfWHhjIaETIgni6Ok9 stateMachine = default(HrfWHhjIaETIgni6Ok9);
			stateMachine.VKo5J58kfL = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
			stateMachine.kfD5hpo35V = this;
			stateMachine.cL751isxtt = -1;
			stateMachine.VKo5J58kfL.Start(ref stateMachine);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct moMuvYjVtpjtQDrXjhl : IAsyncStateMachine
		{
			public int lHBucNjNnR;

			public AsyncVoidMethodBuilder iq1ujTb9FZ;

			public _003C_003Ec__DisplayClass14_0 wrEuv5daDG;

			private ResponseList<YTHistoryResponseDto> ADruWrHSpu;

			private TaskAwaiter<ResponseList<YTHistoryResponseDto>> Y3Hu4es2a9;

			private IEnumerator<YTHistoryResponseDto> tDVuB5y344;

			private YTHistoryResponseDto gnquDLZZwX;

			private TaskAwaiter nkeudJ7Zet;

			private void MoveNext()
			{
				int num = lHBucNjNnR;
				_003C_003Ec__DisplayClass14_0 obj = wrEuv5daDG;
				try
				{
					if ((uint)num > 1u)
					{
						obj.Y0oKe4eKM8.Items.Clear();
					}
					try
					{
						TaskAwaiter<ResponseList<YTHistoryResponseDto>> awaiter;
						if (num != 0)
						{
							if (num == 1)
							{
								goto IL_0118;
							}
							obj.Y0oKe4eKM8.SearchQuery.Page = 1;
							obj.Y0oKe4eKM8.SearchQuery.Sort = obj.a7MKOTHmnS;
							awaiter = pAJBH9tHvLcCNSRcx41.D35lls5iF(obj.Y0oKe4eKM8.vmO0X1G1n4, obj.Y0oKe4eKM8.SearchQuery, pAJBH9tHvLcCNSRcx41.vRAt109fhA).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = (lHBucNjNnR = 0);
								Y3Hu4es2a9 = awaiter;
								iq1ujTb9FZ.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = Y3Hu4es2a9;
							Y3Hu4es2a9 = default(TaskAwaiter<ResponseList<YTHistoryResponseDto>>);
							num = (lHBucNjNnR = -1);
						}
						ResponseList<YTHistoryResponseDto> result = awaiter.GetResult();
						ADruWrHSpu = result;
						if (ADruWrHSpu != null && ADruWrHSpu.Status)
						{
							tDVuB5y344 = ADruWrHSpu.Data.Result.GetEnumerator();
							goto IL_0118;
						}
						obj.Y0oKe4eKM8.TotalCount = 0;
						goto IL_026d;
						IL_026d:
						ADruWrHSpu = null;
						goto end_IL_002d;
						IL_0118:
						try
						{
							if (num != 1)
							{
								goto IL_01c7;
							}
							TaskAwaiter awaiter2 = nkeudJ7Zet;
							nkeudJ7Zet = default(TaskAwaiter);
							num = (lHBucNjNnR = -1);
							goto IL_019e;
							IL_019e:
							oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter2, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
							obj.Y0oKe4eKM8.Items.Add(gnquDLZZwX);
							gnquDLZZwX = null;
							goto IL_01c7;
							IL_01c7:
							if (hjMnupQVVDlRZAYQJC.D35lls5iF(tDVuB5y344, hjMnupQVVDlRZAYQJC.QV1TFwytOj))
							{
								gnquDLZZwX = tDVuB5y344.Current;
								awaiter2 = QliBEUviwWqgtMcBndV.D35lls5iF(pvrKKy8Mk1kpdmIfp3A.D35lls5iF(2, pvrKKy8Mk1kpdmIfp3A.aVh8SPrFkE), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
								if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter2, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
								{
									num = (lHBucNjNnR = 1);
									nkeudJ7Zet = awaiter2;
									iq1ujTb9FZ.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									return;
								}
								goto IL_019e;
							}
						}
						finally
						{
							if (num < 0 && tDVuB5y344 != null)
							{
								xLO56JniGyickVjO1Ot.D35lls5iF(tDVuB5y344, xLO56JniGyickVjO1Ot.ydbT2bsoH4);
							}
						}
						tDVuB5y344 = null;
						obj.Y0oKe4eKM8.CurrentPage = ADruWrHSpu.Data.CurrentPage;
						obj.Y0oKe4eKM8.PageCount = ADruWrHSpu.Data.PageCount;
						obj.Y0oKe4eKM8.TotalCount = ADruWrHSpu.Data.Total;
						goto IL_026d;
						end_IL_002d:;
					}
					catch
					{
						obj.Y0oKe4eKM8.TotalCount = 0;
					}
				}
				catch (Exception ex)
				{
					lHBucNjNnR = -2;
					N2XUglA3neBsnlZfRPQ.D35lls5iF(ref iq1ujTb9FZ, ex, N2XUglA3neBsnlZfRPQ.l4pATRumoW);
					return;
				}
				lHBucNjNnR = -2;
				T4XmPoA4VNJJP1afcgL.D35lls5iF(ref iq1ujTb9FZ, T4XmPoA4VNJJP1afcgL.TRyALZckCh);
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine P_0)
			{
				dHWo7jAEn6E4X7bsY4R.D35lls5iF(ref iq1ujTb9FZ, P_0, dHWo7jAEn6E4X7bsY4R.z3hAB6UZ9o);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine P_0)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(P_0);
			}
		}

		public YtHistoryVideosViewModel Y0oKe4eKM8;

		public GeneralSort a7MKOTHmnS;

		public _003C_003Ec__DisplayClass14_0()
		{
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
			base._002Ector();
		}

		[AsyncStateMachine(typeof(moMuvYjVtpjtQDrXjhl))]
		internal void AXpK9QdeVd()
		{
			moMuvYjVtpjtQDrXjhl stateMachine = default(moMuvYjVtpjtQDrXjhl);
			stateMachine.iq1ujTb9FZ = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
			stateMachine.wrEuv5daDG = this;
			stateMachine.lHBucNjNnR = -1;
			stateMachine.iq1ujTb9FZ.Start(ref stateMachine);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLoadVideos_003Ed__17 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public YtHistoryVideosViewModel _003C_003E4__this;

		private bool _003CtryAgain_003E5__2;

		private object _003C_003E7__wrap2;

		private int _003C_003E7__wrap3;

		private ResponseList<YTHistoryResponseDto> _003Cresult_003E5__5;

		private TaskAwaiter<ResponseList<YTHistoryResponseDto>> _003C_003Eu__1;

		private IEnumerator<YTHistoryResponseDto> _003C_003E7__wrap5;

		private YTHistoryResponseDto _003Citem_003E5__7;

		private TaskAwaiter _003C_003Eu__2;

		private TaskAwaiter<bool> _003C_003Eu__3;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			YtHistoryVideosViewModel ytHistoryVideosViewModel = _003C_003E4__this;
			try
			{
				if ((uint)num <= 1u)
				{
					goto IL_008c;
				}
				if (num != 2)
				{
					ytHistoryVideosViewModel.Items.Clear();
					ytHistoryVideosViewModel.SearchQuery.Page = 1;
					ytHistoryVideosViewModel.SearchQuery.Count = 25;
					ytHistoryVideosViewModel.SearchQuery.Order = SortOrder.Desc;
					lASFo76QIUBEikAAsE9.D35lls5iF(ytHistoryVideosViewModel.SearchQuery.Search, null, lASFo76QIUBEikAAsE9.UMA6X462Ew);
					_003CtryAgain_003E5__2 = true;
					goto IL_0366;
				}
				TaskAwaiter<bool> awaiter = _003C_003Eu__3;
				_003C_003Eu__3 = default(TaskAwaiter<bool>);
				num = (_003C_003E1__state = -1);
				goto IL_0335;
				IL_035f:
				_003C_003E7__wrap2 = null;
				goto IL_0366;
				IL_0335:
				if (awaiter.GetResult())
				{
					_003CtryAgain_003E5__2 = true;
					ytHistoryVideosViewModel.vmO0X1G1n4 = AppContainer.Resolve<IYoutubeService>();
				}
				goto IL_035f;
				IL_008c:
				try
				{
					TaskAwaiter<ResponseList<YTHistoryResponseDto>> awaiter2;
					if (num != 0)
					{
						if (num == 1)
						{
							goto IL_0149;
						}
						awaiter2 = pAJBH9tHvLcCNSRcx41.D35lls5iF(ytHistoryVideosViewModel.vmO0X1G1n4, ytHistoryVideosViewModel.SearchQuery, pAJBH9tHvLcCNSRcx41.vRAt109fhA).GetAwaiter();
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
						_003C_003Eu__1 = default(TaskAwaiter<ResponseList<YTHistoryResponseDto>>);
						num = (_003C_003E1__state = -1);
					}
					ResponseList<YTHistoryResponseDto> result = awaiter2.GetResult();
					_003Cresult_003E5__5 = result;
					if (_003Cresult_003E5__5 != null && _003Cresult_003E5__5.Status)
					{
						_003C_003E7__wrap5 = _003Cresult_003E5__5.Data.Result.GetEnumerator();
						goto IL_0149;
					}
					ytHistoryVideosViewModel.TotalCount = 0;
					goto IL_0285;
					IL_0285:
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
						ytHistoryVideosViewModel.Items.Add(_003Citem_003E5__7);
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
					ytHistoryVideosViewModel.CurrentPage = _003Cresult_003E5__5.Data.CurrentPage;
					ytHistoryVideosViewModel.PageCount = _003Cresult_003E5__5.Data.PageCount;
					ytHistoryVideosViewModel.TotalCount = _003Cresult_003E5__5.Data.Total;
					goto IL_0285;
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
						goto IL_0335;
					}
					ytHistoryVideosViewModel.TotalCount = 0;
				}
				goto IL_035f;
				IL_0366:
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
	private struct _003COnFetchMoreDataCommand_003Ed__19 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public YtHistoryVideosViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			YtHistoryVideosViewModel ytHistoryVideosViewModel = _003C_003E4__this;
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
				if (ytHistoryVideosViewModel.CurrentPage < ytHistoryVideosViewModel.TotalCount && !hjMnupQVVDlRZAYQJC.D35lls5iF(ytHistoryVideosViewModel, hjMnupQVVDlRZAYQJC.jJYTSHn9tB))
				{
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(ytHistoryVideosViewModel.AddMoreItems(), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
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
	private struct _003CAddMoreItems_003Ed__21 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public YtHistoryVideosViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			YtHistoryVideosViewModel CS_0024_003C_003E8__locals5 = _003C_003E4__this;
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
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(W7S2sip6SDieZFVsNbd.D35lls5iF(CS_0024_003C_003E8__locals5, Expression.Lambda<Func<bool>>(OWBKr5pvc5MWsK1OMtR.D35lls5iF(o4bYL4peNeC2wWb8yjx.D35lls5iF(CS_0024_003C_003E8__locals5, sjYxHO8OWlc6X80hFj7.D35lls5iF(typeof(YtHistoryVideosViewModel).TypeHandle, sjYxHO8OWlc6X80hFj7.uWZ8ugU7r5), o4bYL4peNeC2wWb8yjx.oVdpGKjy2x), (MethodInfo)f5q427pRQZnrEKPy4Ws.D35lls5iF((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, f5q427pRQZnrEKPy4Ws.Bo9pk3m4k7), OWBKr5pvc5MWsK1OMtR.fZIpAAdi1v), Array.Empty<ParameterExpression>()), [AsyncStateMachine(typeof(_003C_003CAddMoreItems_003Eb__21_1_003Ed))] () =>
					{
						_003C_003CAddMoreItems_003Eb__21_1_003Ed stateMachine = default(_003C_003CAddMoreItems_003Eb__21_1_003Ed);
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
	private struct _003CGoToPage_003Ed__22 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public YTHistoryResponseDto model;

		public YtHistoryVideosViewModel _003C_003E4__this;

		private YtVideoPlayerViewModel _003CviewModel_003E5__2;

		private Page _003Cpage_003E5__3;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			YtHistoryVideosViewModel ytHistoryVideosViewModel = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_00be;
				}
				if (num == 1)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_016f;
				}
				if (lVnioXU659dV87DBnh4.D35lls5iF(model, lVnioXU659dV87DBnh4.fqit88j1aw) > 0)
				{
					_003CviewModel_003E5__2 = new YtVideoPlayerViewModel();
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(hnVdJ7tlwwTQvJJ7Vha.D35lls5iF(_003CviewModel_003E5__2, a43SdLdd33nIFQF9vuC.D35lls5iF(model, a43SdLdd33nIFQF9vuC.kk5tnGmXSP), hnVdJ7tlwwTQvJJ7Vha.oXrt9biorg), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
					if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_00be;
				}
				goto end_IL_0015;
				IL_016f:
				oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
				GmMLaTD7kV8rq88ZFvR.D35lls5iF(Xlypb0Hnr2C3ydrYEdG.D35lls5iF(ytHistoryVideosViewModel.aGt0mEMmXG, Xlypb0Hnr2C3ydrYEdG.U3Z1IKMGuZ), _003Cpage_003E5__3, GmMLaTD7kV8rq88ZFvR.iMJHkmaaRY);
				_003CviewModel_003E5__2 = null;
				_003Cpage_003E5__3 = null;
				goto end_IL_0015;
				IL_00be:
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
				goto IL_016f;
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
	private struct _003CLoadAsync_003Ed__24 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public YtHistoryVideosViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			YtHistoryVideosViewModel CS_0024_003C_003E8__locals3 = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(W7S2sip6SDieZFVsNbd.D35lls5iF(CS_0024_003C_003E8__locals3, Expression.Lambda<Func<bool>>(OWBKr5pvc5MWsK1OMtR.D35lls5iF(o4bYL4peNeC2wWb8yjx.D35lls5iF(CS_0024_003C_003E8__locals3, sjYxHO8OWlc6X80hFj7.D35lls5iF(typeof(YtHistoryVideosViewModel).TypeHandle, sjYxHO8OWlc6X80hFj7.uWZ8ugU7r5), o4bYL4peNeC2wWb8yjx.oVdpGKjy2x), (MethodInfo)f5q427pRQZnrEKPy4Ws.D35lls5iF((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, f5q427pRQZnrEKPy4Ws.Bo9pk3m4k7), OWBKr5pvc5MWsK1OMtR.fZIpAAdi1v), Array.Empty<ParameterExpression>()), [AsyncStateMachine(typeof(_003C_003CLoadAsync_003Eb__24_1_003Ed))] () =>
					{
						_003C_003CLoadAsync_003Eb__24_1_003Ed stateMachine = default(_003C_003CLoadAsync_003Eb__24_1_003Ed);
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
	private struct _003C_003CAddMoreItems_003Eb__21_1_003Ed : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public YtHistoryVideosViewModel _003C_003E4__this;

		private bool _003CtryAgain_003E5__2;

		private object _003C_003E7__wrap2;

		private int _003C_003E7__wrap3;

		private ResponseList<YTHistoryResponseDto> _003Cresult_003E5__5;

		private TaskAwaiter<ResponseList<YTHistoryResponseDto>> _003C_003Eu__1;

		private IEnumerator<YTHistoryResponseDto> _003C_003E7__wrap5;

		private YTHistoryResponseDto _003Citem_003E5__7;

		private TaskAwaiter _003C_003Eu__2;

		private TaskAwaiter<bool> _003C_003Eu__3;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			YtHistoryVideosViewModel ytHistoryVideosViewModel = _003C_003E4__this;
			try
			{
				if ((uint)num <= 1u)
				{
					goto IL_0053;
				}
				if (num != 2)
				{
					ytHistoryVideosViewModel.SearchQuery.Page++;
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
					ytHistoryVideosViewModel.vmO0X1G1n4 = AppContainer.Resolve<IYoutubeService>();
				}
				goto IL_0340;
				IL_0053:
				try
				{
					TaskAwaiter<ResponseList<YTHistoryResponseDto>> awaiter2;
					if (num != 0)
					{
						if (num == 1)
						{
							goto IL_0110;
						}
						awaiter2 = pAJBH9tHvLcCNSRcx41.D35lls5iF(ytHistoryVideosViewModel.vmO0X1G1n4, ytHistoryVideosViewModel.SearchQuery, pAJBH9tHvLcCNSRcx41.vRAt109fhA).GetAwaiter();
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
						_003C_003Eu__1 = default(TaskAwaiter<ResponseList<YTHistoryResponseDto>>);
						num = (_003C_003E1__state = -1);
					}
					ResponseList<YTHistoryResponseDto> result = awaiter2.GetResult();
					_003Cresult_003E5__5 = result;
					if (_003Cresult_003E5__5 != null && _003Cresult_003E5__5.Status)
					{
						_003C_003E7__wrap5 = _003Cresult_003E5__5.Data.Result.GetEnumerator();
						goto IL_0110;
					}
					ytHistoryVideosViewModel.SearchQuery.Page--;
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
						ytHistoryVideosViewModel.Items.Add(_003Citem_003E5__7);
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
					ytHistoryVideosViewModel.CurrentPage = _003Cresult_003E5__5.Data.CurrentPage;
					ytHistoryVideosViewModel.PageCount = _003Cresult_003E5__5.Data.PageCount;
					ytHistoryVideosViewModel.TotalCount = _003Cresult_003E5__5.Data.Total;
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
					ytHistoryVideosViewModel.SearchQuery.Page--;
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
	private struct _003C_003CLoadAsync_003Eb__24_1_003Ed : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public YtHistoryVideosViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			YtHistoryVideosViewModel ytHistoryVideosViewModel = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(VrVteFCs0OCGBTVr1mZ.D35lls5iF(new Task[1] { OYihPsCZ1OyLa5m4TD0.D35lls5iF(ytHistoryVideosViewModel, OYihPsCZ1OyLa5m4TD0.Rv1t3XZlBm) }, VrVteFCs0OCGBTVr1mZ.qNlChUR2Cs), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
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

	private readonly HomeViewModel aGt0mEMmXG;

	private IYoutubeService vmO0X1G1n4;

	private SortOrder YmA0RWkDK1;

	private GeneralSort nyh0wynX9K;

	private readonly YtViewModel L8w0EyYXx5;

	[CompilerGenerated]
	private List<LanguageResponseDto> DQb09wM2Cg;

	public List<LanguageResponseDto> Languages
	{
		[CompilerGenerated]
		get
		{
			return DQb09wM2Cg;
		}
		[CompilerGenerated]
		set
		{
			DQb09wM2Cg = value;
		}
	}

	public SortOrder SelectedOrder
	{
		get
		{
			return YmA0RWkDK1;
		}
		set
		{
			_003C_003Ec__DisplayClass11_0 CS_0024_003C_003E8__locals4 = new _003C_003Ec__DisplayClass11_0();
			CS_0024_003C_003E8__locals4.sLkKw75El0 = this;
			CS_0024_003C_003E8__locals4.a1OKEp7MSf = value;
			SetProperty(ref YmA0RWkDK1, CS_0024_003C_003E8__locals4.a1OKEp7MSf, iFZ5je3XFYKwkvcE5D.D35lls5iF(8208, iFZ5je3XFYKwkvcE5D.N06TeK0ao), null, [AsyncStateMachine(typeof(_003C_003Ec__DisplayClass11_0.HrfWHhjIaETIgni6Ok9))] () =>
			{
				_003C_003Ec__DisplayClass11_0.HrfWHhjIaETIgni6Ok9 stateMachine = default(_003C_003Ec__DisplayClass11_0.HrfWHhjIaETIgni6Ok9);
				stateMachine.VKo5J58kfL = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
				stateMachine.kfD5hpo35V = CS_0024_003C_003E8__locals4;
				stateMachine.cL751isxtt = -1;
				stateMachine.VKo5J58kfL.Start(ref stateMachine);
			});
		}
	}

	public GeneralSort SelectedSort
	{
		get
		{
			return nyh0wynX9K;
		}
		set
		{
			_003C_003Ec__DisplayClass14_0 CS_0024_003C_003E8__locals4 = new _003C_003Ec__DisplayClass14_0();
			CS_0024_003C_003E8__locals4.Y0oKe4eKM8 = this;
			CS_0024_003C_003E8__locals4.a7MKOTHmnS = value;
			SetProperty(ref nyh0wynX9K, CS_0024_003C_003E8__locals4.a7MKOTHmnS, iFZ5je3XFYKwkvcE5D.D35lls5iF(10222, iFZ5je3XFYKwkvcE5D.N06TeK0ao), null, [AsyncStateMachine(typeof(_003C_003Ec__DisplayClass14_0.moMuvYjVtpjtQDrXjhl))] () =>
			{
				_003C_003Ec__DisplayClass14_0.moMuvYjVtpjtQDrXjhl stateMachine = default(_003C_003Ec__DisplayClass14_0.moMuvYjVtpjtQDrXjhl);
				stateMachine.iq1ujTb9FZ = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
				stateMachine.wrEuv5daDG = CS_0024_003C_003E8__locals4;
				stateMachine.lHBucNjNnR = -1;
				stateMachine.iq1ujTb9FZ.Start(ref stateMachine);
			});
		}
	}

	public YtHistoryVideosViewModel()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		YmA0RWkDK1 = SortOrder.Desc;
		nyh0wynX9K = GeneralSort.ActivateDate;
		base._002Ector();
		vmO0X1G1n4 = AppContainer.Resolve<IYoutubeService>();
		base.FetchMoreDataCommand = new AsyncCommand(OnFetchMoreDataCommand);
		base.SearchQuery = new ApiQuery<YTSearch, GeneralSort>
		{
			Count = 25,
			Search = new YTSearch()
		};
		aGt0mEMmXG = AppContainer.Resolve<HomeViewModel>();
	}

	public YtHistoryVideosViewModel(YtViewModel youtubeViewModel)
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		this._002Ector();
		L8w0EyYXx5 = youtubeViewModel;
	}

	[AsyncStateMachine(typeof(_003CLoadVideos_003Ed__17))]
	public Task LoadVideos()
	{
		_003CLoadVideos_003Ed__17 stateMachine = default(_003CLoadVideos_003Ed__17);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	public void Clear()
	{
		base.SelectedItem = new YTHistoryResponseDto();
	}

	[AsyncStateMachine(typeof(_003COnFetchMoreDataCommand_003Ed__19))]
	protected Task OnFetchMoreDataCommand()
	{
		_003COnFetchMoreDataCommand_003Ed__19 stateMachine = default(_003COnFetchMoreDataCommand_003Ed__19);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	public override void Dispose()
	{
		base.Items.Clear();
	}

	[AsyncStateMachine(typeof(_003CAddMoreItems_003Ed__21))]
	public override Task AddMoreItems()
	{
		_003CAddMoreItems_003Ed__21 stateMachine = default(_003CAddMoreItems_003Ed__21);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	[AsyncStateMachine(typeof(_003CGoToPage_003Ed__22))]
	public override Task GoToPage(YTHistoryResponseDto model)
	{
		_003CGoToPage_003Ed__22 stateMachine = default(_003CGoToPage_003Ed__22);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine.model = model;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	public override void OnLoading()
	{
		if (!base.Items.Any())
		{
			Task task = LoadAsync();
			Action<Exception> action = null;
			bool flag = false;
			gBlEqv8jRKikCj2DMZp.D35lls5iF(task, ref action, ref flag, gBlEqv8jRKikCj2DMZp.pSp8ymt8Mu);
		}
	}

	[AsyncStateMachine(typeof(_003CLoadAsync_003Ed__24))]
	public override Task LoadAsync()
	{
		_003CLoadAsync_003Ed__24 stateMachine = default(_003CLoadAsync_003Ed__24);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	[AsyncStateMachine(typeof(_003C_003CAddMoreItems_003Eb__21_1_003Ed))]
	[CompilerGenerated]
	private Task Mke0iGXxVu()
	{
		_003C_003CAddMoreItems_003Eb__21_1_003Ed stateMachine = default(_003C_003CAddMoreItems_003Eb__21_1_003Ed);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	[CompilerGenerated]
	[AsyncStateMachine(typeof(_003C_003CLoadAsync_003Eb__24_1_003Ed))]
	private Task UeQ03daClp()
	{
		_003C_003CLoadAsync_003Eb__24_1_003Ed stateMachine = default(_003C_003CLoadAsync_003Eb__24_1_003Ed);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}
}
