using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using PROTV.Abstractions.Common;
using PROTV.Abstractions.DataTransferObjects;
using PROTV.Abstractions.Helpers;
using PROTV.Abstractions.Search;
using PROTV.Abstractions.Services;
using PROTV.Wpf.Bootstrap;

namespace PROTV.Wpf.ViewModels;

public class YtChannelsViewModel : BaseListViewModel<YTChannelResponseDto, ApiQuery<YTSearch, YTChannelSort>>
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass10_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct G9sCVOjafDGOtEhbQko : IAsyncStateMachine
		{
			public int MCXuP6rGb6;

			public AsyncVoidMethodBuilder kkLuqPxpbr;

			public _003C_003Ec__DisplayClass10_0 avBuIUegoj;

			private ResponseList<YTChannelResponseDto> QVCuVD42oX;

			private TaskAwaiter<ResponseList<YTChannelResponseDto>> n8buayhcWF;

			private IEnumerator<YTChannelResponseDto> i5ru0m3tIQ;

			private YTChannelResponseDto sGjuGRyGUr;

			private TaskAwaiter mpAuTCSwYq;

			private void MoveNext()
			{
				int num = MCXuP6rGb6;
				_003C_003Ec__DisplayClass10_0 obj = avBuIUegoj;
				try
				{
					if ((uint)num > 1u)
					{
						obj.vNRKHremy4.Items.Clear();
					}
					try
					{
						TaskAwaiter<ResponseList<YTChannelResponseDto>> awaiter;
						if (num != 0)
						{
							if (num == 1)
							{
								goto IL_0118;
							}
							obj.vNRKHremy4.SearchQuery.Page = 1;
							obj.vNRKHremy4.SearchQuery.Order = obj.ufjKoQD9lb;
							awaiter = qGwsZbtTVvWLnxcqCuC.D35lls5iF(obj.vNRKHremy4.sC50rN4D2x, obj.vNRKHremy4.SearchQuery, qGwsZbtTVvWLnxcqCuC.PjIt4ch00E).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = (MCXuP6rGb6 = 0);
								n8buayhcWF = awaiter;
								kkLuqPxpbr.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = n8buayhcWF;
							n8buayhcWF = default(TaskAwaiter<ResponseList<YTChannelResponseDto>>);
							num = (MCXuP6rGb6 = -1);
						}
						ResponseList<YTChannelResponseDto> result = awaiter.GetResult();
						QVCuVD42oX = result;
						if (QVCuVD42oX != null && QVCuVD42oX.Status)
						{
							i5ru0m3tIQ = QVCuVD42oX.Data.Result.GetEnumerator();
							goto IL_0118;
						}
						obj.vNRKHremy4.TotalCount = 0;
						goto IL_026d;
						IL_026d:
						QVCuVD42oX = null;
						goto end_IL_002d;
						IL_0118:
						try
						{
							if (num != 1)
							{
								goto IL_01c7;
							}
							TaskAwaiter awaiter2 = mpAuTCSwYq;
							mpAuTCSwYq = default(TaskAwaiter);
							num = (MCXuP6rGb6 = -1);
							goto IL_019e;
							IL_019e:
							oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter2, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
							obj.vNRKHremy4.Items.Add(sGjuGRyGUr);
							sGjuGRyGUr = null;
							goto IL_01c7;
							IL_01c7:
							if (hjMnupQVVDlRZAYQJC.D35lls5iF(i5ru0m3tIQ, hjMnupQVVDlRZAYQJC.QV1TFwytOj))
							{
								sGjuGRyGUr = i5ru0m3tIQ.Current;
								awaiter2 = QliBEUviwWqgtMcBndV.D35lls5iF(pvrKKy8Mk1kpdmIfp3A.D35lls5iF(2, pvrKKy8Mk1kpdmIfp3A.aVh8SPrFkE), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
								if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter2, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
								{
									num = (MCXuP6rGb6 = 1);
									mpAuTCSwYq = awaiter2;
									kkLuqPxpbr.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									return;
								}
								goto IL_019e;
							}
						}
						finally
						{
							if (num < 0 && i5ru0m3tIQ != null)
							{
								xLO56JniGyickVjO1Ot.D35lls5iF(i5ru0m3tIQ, xLO56JniGyickVjO1Ot.ydbT2bsoH4);
							}
						}
						i5ru0m3tIQ = null;
						obj.vNRKHremy4.CurrentPage = QVCuVD42oX.Data.CurrentPage;
						obj.vNRKHremy4.PageCount = QVCuVD42oX.Data.PageCount;
						obj.vNRKHremy4.TotalCount = QVCuVD42oX.Data.Total;
						goto IL_026d;
						end_IL_002d:;
					}
					catch
					{
						obj.vNRKHremy4.TotalCount = 0;
					}
				}
				catch (Exception ex)
				{
					MCXuP6rGb6 = -2;
					N2XUglA3neBsnlZfRPQ.D35lls5iF(ref kkLuqPxpbr, ex, N2XUglA3neBsnlZfRPQ.l4pATRumoW);
					return;
				}
				MCXuP6rGb6 = -2;
				T4XmPoA4VNJJP1afcgL.D35lls5iF(ref kkLuqPxpbr, T4XmPoA4VNJJP1afcgL.TRyALZckCh);
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine P_0)
			{
				dHWo7jAEn6E4X7bsY4R.D35lls5iF(ref kkLuqPxpbr, P_0, dHWo7jAEn6E4X7bsY4R.z3hAB6UZ9o);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine P_0)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(P_0);
			}
		}

		public YtChannelsViewModel vNRKHremy4;

		public SortOrder ufjKoQD9lb;

		public _003C_003Ec__DisplayClass10_0()
		{
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
			base._002Ector();
		}

		[AsyncStateMachine(typeof(G9sCVOjafDGOtEhbQko))]
		internal void tWcKrxf20L()
		{
			G9sCVOjafDGOtEhbQko stateMachine = default(G9sCVOjafDGOtEhbQko);
			stateMachine.kkLuqPxpbr = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
			stateMachine.avBuIUegoj = this;
			stateMachine.MCXuP6rGb6 = -1;
			stateMachine.kkLuqPxpbr.Start(ref stateMachine);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass13_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct qX8lysj04duo7Gq1iF6 : IAsyncStateMachine
		{
			public int uMPuZ4XdPV;

			public AsyncVoidMethodBuilder O2outOuDRF;

			public _003C_003Ec__DisplayClass13_0 itjuSu4JoH;

			private ResponseList<YTChannelResponseDto> YjHufWEEqT;

			private TaskAwaiter<ResponseList<YTChannelResponseDto>> xpAuKg2pwR;

			private IEnumerator<YTChannelResponseDto> w4iukDlR9n;

			private YTChannelResponseDto Jvcu8ECKdT;

			private TaskAwaiter T5huQJRxEq;

			private void MoveNext()
			{
				int num = uMPuZ4XdPV;
				_003C_003Ec__DisplayClass13_0 obj = itjuSu4JoH;
				try
				{
					if ((uint)num > 1u)
					{
						obj.zxjK1MgFVD.Items.Clear();
					}
					try
					{
						TaskAwaiter<ResponseList<YTChannelResponseDto>> awaiter;
						if (num != 0)
						{
							if (num == 1)
							{
								goto IL_0118;
							}
							obj.zxjK1MgFVD.SearchQuery.Page = 1;
							obj.zxjK1MgFVD.SearchQuery.Sort = obj.WUhKJ4GqCJ;
							awaiter = qGwsZbtTVvWLnxcqCuC.D35lls5iF(obj.zxjK1MgFVD.sC50rN4D2x, obj.zxjK1MgFVD.SearchQuery, qGwsZbtTVvWLnxcqCuC.PjIt4ch00E).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = (uMPuZ4XdPV = 0);
								xpAuKg2pwR = awaiter;
								O2outOuDRF.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = xpAuKg2pwR;
							xpAuKg2pwR = default(TaskAwaiter<ResponseList<YTChannelResponseDto>>);
							num = (uMPuZ4XdPV = -1);
						}
						ResponseList<YTChannelResponseDto> result = awaiter.GetResult();
						YjHufWEEqT = result;
						if (YjHufWEEqT != null && YjHufWEEqT.Status)
						{
							w4iukDlR9n = YjHufWEEqT.Data.Result.GetEnumerator();
							goto IL_0118;
						}
						obj.zxjK1MgFVD.TotalCount = 0;
						goto IL_026d;
						IL_026d:
						YjHufWEEqT = null;
						goto end_IL_002d;
						IL_0118:
						try
						{
							if (num != 1)
							{
								goto IL_01c7;
							}
							TaskAwaiter awaiter2 = T5huQJRxEq;
							T5huQJRxEq = default(TaskAwaiter);
							num = (uMPuZ4XdPV = -1);
							goto IL_019e;
							IL_019e:
							oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter2, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
							obj.zxjK1MgFVD.Items.Add(Jvcu8ECKdT);
							Jvcu8ECKdT = null;
							goto IL_01c7;
							IL_01c7:
							if (hjMnupQVVDlRZAYQJC.D35lls5iF(w4iukDlR9n, hjMnupQVVDlRZAYQJC.QV1TFwytOj))
							{
								Jvcu8ECKdT = w4iukDlR9n.Current;
								awaiter2 = QliBEUviwWqgtMcBndV.D35lls5iF(pvrKKy8Mk1kpdmIfp3A.D35lls5iF(2, pvrKKy8Mk1kpdmIfp3A.aVh8SPrFkE), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
								if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter2, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
								{
									num = (uMPuZ4XdPV = 1);
									T5huQJRxEq = awaiter2;
									O2outOuDRF.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									return;
								}
								goto IL_019e;
							}
						}
						finally
						{
							if (num < 0 && w4iukDlR9n != null)
							{
								xLO56JniGyickVjO1Ot.D35lls5iF(w4iukDlR9n, xLO56JniGyickVjO1Ot.ydbT2bsoH4);
							}
						}
						w4iukDlR9n = null;
						obj.zxjK1MgFVD.CurrentPage = YjHufWEEqT.Data.CurrentPage;
						obj.zxjK1MgFVD.PageCount = YjHufWEEqT.Data.PageCount;
						obj.zxjK1MgFVD.TotalCount = YjHufWEEqT.Data.Total;
						goto IL_026d;
						end_IL_002d:;
					}
					catch
					{
						obj.zxjK1MgFVD.TotalCount = 0;
					}
				}
				catch (Exception ex)
				{
					uMPuZ4XdPV = -2;
					N2XUglA3neBsnlZfRPQ.D35lls5iF(ref O2outOuDRF, ex, N2XUglA3neBsnlZfRPQ.l4pATRumoW);
					return;
				}
				uMPuZ4XdPV = -2;
				T4XmPoA4VNJJP1afcgL.D35lls5iF(ref O2outOuDRF, T4XmPoA4VNJJP1afcgL.TRyALZckCh);
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine P_0)
			{
				dHWo7jAEn6E4X7bsY4R.D35lls5iF(ref O2outOuDRF, P_0, dHWo7jAEn6E4X7bsY4R.z3hAB6UZ9o);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine P_0)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(P_0);
			}
		}

		public YtChannelsViewModel zxjK1MgFVD;

		public YTChannelSort WUhKJ4GqCJ;

		public _003C_003Ec__DisplayClass13_0()
		{
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
			base._002Ector();
		}

		[AsyncStateMachine(typeof(qX8lysj04duo7Gq1iF6))]
		internal void SBhKg3QKCR()
		{
			qX8lysj04duo7Gq1iF6 stateMachine = default(qX8lysj04duo7Gq1iF6);
			stateMachine.O2outOuDRF = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
			stateMachine.itjuSu4JoH = this;
			stateMachine.uMPuZ4XdPV = -1;
			stateMachine.O2outOuDRF.Start(ref stateMachine);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLoadVideos_003Ed__16 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public YtChannelsViewModel _003C_003E4__this;

		private ResponseList<YTChannelResponseDto> _003Cresult_003E5__2;

		private TaskAwaiter<ResponseList<YTChannelResponseDto>> _003C_003Eu__1;

		private IEnumerator<YTChannelResponseDto> _003C_003E7__wrap2;

		private YTChannelResponseDto _003Citem_003E5__4;

		private TaskAwaiter _003C_003Eu__2;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			YtChannelsViewModel ytChannelsViewModel = _003C_003E4__this;
			try
			{
				if ((uint)num > 1u)
				{
					ytChannelsViewModel.Items.Clear();
					ytChannelsViewModel.SearchQuery.Page = 1;
					ytChannelsViewModel.SearchQuery.Count = 25;
					ytChannelsViewModel.SearchQuery.Order = SortOrder.Desc;
					lASFo76QIUBEikAAsE9.D35lls5iF(ytChannelsViewModel.SearchQuery.Search, null, lASFo76QIUBEikAAsE9.UMA6X462Ew);
				}
				try
				{
					TaskAwaiter<ResponseList<YTChannelResponseDto>> awaiter;
					if (num != 0)
					{
						if (num == 1)
						{
							goto IL_0128;
						}
						awaiter = qGwsZbtTVvWLnxcqCuC.D35lls5iF(ytChannelsViewModel.sC50rN4D2x, ytChannelsViewModel.SearchQuery, qGwsZbtTVvWLnxcqCuC.PjIt4ch00E).GetAwaiter();
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
						_003C_003Eu__1 = default(TaskAwaiter<ResponseList<YTChannelResponseDto>>);
						num = (_003C_003E1__state = -1);
					}
					ResponseList<YTChannelResponseDto> result = awaiter.GetResult();
					_003Cresult_003E5__2 = result;
					if (_003Cresult_003E5__2 != null && _003Cresult_003E5__2.Status)
					{
						_003C_003E7__wrap2 = _003Cresult_003E5__2.Data.Result.GetEnumerator();
						goto IL_0128;
					}
					ytChannelsViewModel.TotalCount = 0;
					goto IL_0264;
					IL_0264:
					_003Cresult_003E5__2 = null;
					goto end_IL_006b;
					IL_0128:
					try
					{
						if (num != 1)
						{
							goto IL_01d2;
						}
						TaskAwaiter awaiter2 = _003C_003Eu__2;
						_003C_003Eu__2 = default(TaskAwaiter);
						num = (_003C_003E1__state = -1);
						goto IL_01ae;
						IL_01ae:
						oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter2, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
						ytChannelsViewModel.Items.Add(_003Citem_003E5__4);
						_003Citem_003E5__4 = null;
						goto IL_01d2;
						IL_01d2:
						if (hjMnupQVVDlRZAYQJC.D35lls5iF(_003C_003E7__wrap2, hjMnupQVVDlRZAYQJC.QV1TFwytOj))
						{
							_003Citem_003E5__4 = _003C_003E7__wrap2.Current;
							awaiter2 = QliBEUviwWqgtMcBndV.D35lls5iF(pvrKKy8Mk1kpdmIfp3A.D35lls5iF(2, pvrKKy8Mk1kpdmIfp3A.aVh8SPrFkE), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
							if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter2, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
							{
								num = (_003C_003E1__state = 1);
								_003C_003Eu__2 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
							goto IL_01ae;
						}
					}
					finally
					{
						if (num < 0 && _003C_003E7__wrap2 != null)
						{
							xLO56JniGyickVjO1Ot.D35lls5iF(_003C_003E7__wrap2, xLO56JniGyickVjO1Ot.ydbT2bsoH4);
						}
					}
					_003C_003E7__wrap2 = null;
					ytChannelsViewModel.CurrentPage = _003Cresult_003E5__2.Data.CurrentPage;
					ytChannelsViewModel.PageCount = _003Cresult_003E5__2.Data.PageCount;
					ytChannelsViewModel.TotalCount = _003Cresult_003E5__2.Data.Total;
					goto IL_0264;
					end_IL_006b:;
				}
				catch
				{
					ytChannelsViewModel.TotalCount = 0;
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
	private struct _003COnFetchMoreDataCommand_003Ed__18 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public YtChannelsViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			YtChannelsViewModel ytChannelsViewModel = _003C_003E4__this;
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
				if (ytChannelsViewModel.CurrentPage < ytChannelsViewModel.TotalCount && !hjMnupQVVDlRZAYQJC.D35lls5iF(ytChannelsViewModel, hjMnupQVVDlRZAYQJC.jJYTSHn9tB))
				{
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(ytChannelsViewModel.AddMoreItems(), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
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
	private struct _003CAddMoreItems_003Ed__20 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public YtChannelsViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			YtChannelsViewModel CS_0024_003C_003E8__locals5 = _003C_003E4__this;
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
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(W7S2sip6SDieZFVsNbd.D35lls5iF(CS_0024_003C_003E8__locals5, Expression.Lambda<Func<bool>>(OWBKr5pvc5MWsK1OMtR.D35lls5iF(o4bYL4peNeC2wWb8yjx.D35lls5iF(CS_0024_003C_003E8__locals5, sjYxHO8OWlc6X80hFj7.D35lls5iF(typeof(YtChannelsViewModel).TypeHandle, sjYxHO8OWlc6X80hFj7.uWZ8ugU7r5), o4bYL4peNeC2wWb8yjx.oVdpGKjy2x), (MethodInfo)f5q427pRQZnrEKPy4Ws.D35lls5iF((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, f5q427pRQZnrEKPy4Ws.Bo9pk3m4k7), OWBKr5pvc5MWsK1OMtR.fZIpAAdi1v), Array.Empty<ParameterExpression>()), [AsyncStateMachine(typeof(_003C_003CAddMoreItems_003Eb__20_1_003Ed))] () =>
					{
						_003C_003CAddMoreItems_003Eb__20_1_003Ed stateMachine = default(_003C_003CAddMoreItems_003Eb__20_1_003Ed);
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
	private struct _003CGoToPage_003Ed__21 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public YTChannelResponseDto model;

		public YtChannelsViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			YtChannelsViewModel ytChannelsViewModel = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_0097;
				}
				if (lVnioXU659dV87DBnh4.D35lls5iF(model, lVnioXU659dV87DBnh4.e5HUphuY6U) > 0)
				{
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(pvrKKy8Mk1kpdmIfp3A.D35lls5iF(5, pvrKKy8Mk1kpdmIfp3A.aVh8SPrFkE), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
					if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_0097;
				}
				goto end_IL_0015;
				IL_0097:
				oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
				vQKA0r9sJ1kArsIHc16.D35lls5iF(ytChannelsViewModel.wCn0gD2rVU, lVnioXU659dV87DBnh4.D35lls5iF(model, lVnioXU659dV87DBnh4.e5HUphuY6U), vQKA0r9sJ1kArsIHc16.IogUiUt4Qi);
				m5sZxWmLHUhVHrJe8sC.D35lls5iF(ytChannelsViewModel.wCn0gD2rVU, iFZ5je3XFYKwkvcE5D.D35lls5iF(14394, iFZ5je3XFYKwkvcE5D.N06TeK0ao), m5sZxWmLHUhVHrJe8sC.DWQUQPjnyY);
				YIm9yctLBn23GQIH06k.D35lls5iF(ytChannelsViewModel, YIm9yctLBn23GQIH06k.prNtEsx9qI);
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
	private struct _003CLoadAsync_003Ed__23 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public YtChannelsViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			YtChannelsViewModel CS_0024_003C_003E8__locals3 = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(W7S2sip6SDieZFVsNbd.D35lls5iF(CS_0024_003C_003E8__locals3, Expression.Lambda<Func<bool>>(OWBKr5pvc5MWsK1OMtR.D35lls5iF(o4bYL4peNeC2wWb8yjx.D35lls5iF(CS_0024_003C_003E8__locals3, sjYxHO8OWlc6X80hFj7.D35lls5iF(typeof(YtChannelsViewModel).TypeHandle, sjYxHO8OWlc6X80hFj7.uWZ8ugU7r5), o4bYL4peNeC2wWb8yjx.oVdpGKjy2x), (MethodInfo)f5q427pRQZnrEKPy4Ws.D35lls5iF((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, f5q427pRQZnrEKPy4Ws.Bo9pk3m4k7), OWBKr5pvc5MWsK1OMtR.fZIpAAdi1v), Array.Empty<ParameterExpression>()), [AsyncStateMachine(typeof(_003C_003CLoadAsync_003Eb__23_1_003Ed))] () =>
					{
						_003C_003CLoadAsync_003Eb__23_1_003Ed stateMachine = default(_003C_003CLoadAsync_003Eb__23_1_003Ed);
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
	private struct _003C_003CAddMoreItems_003Eb__20_1_003Ed : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public YtChannelsViewModel _003C_003E4__this;

		private ResponseList<YTChannelResponseDto> _003Cresult_003E5__2;

		private TaskAwaiter<ResponseList<YTChannelResponseDto>> _003C_003Eu__1;

		private IEnumerator<YTChannelResponseDto> _003C_003E7__wrap2;

		private YTChannelResponseDto _003Citem_003E5__4;

		private TaskAwaiter _003C_003Eu__2;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			YtChannelsViewModel ytChannelsViewModel = _003C_003E4__this;
			try
			{
				if ((uint)num > 1u)
				{
					ytChannelsViewModel.SearchQuery.Page++;
				}
				try
				{
					TaskAwaiter<ResponseList<YTChannelResponseDto>> awaiter;
					if (num != 0)
					{
						if (num == 1)
						{
							goto IL_00ef;
						}
						awaiter = qGwsZbtTVvWLnxcqCuC.D35lls5iF(ytChannelsViewModel.sC50rN4D2x, ytChannelsViewModel.SearchQuery, qGwsZbtTVvWLnxcqCuC.PjIt4ch00E).GetAwaiter();
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
						_003C_003Eu__1 = default(TaskAwaiter<ResponseList<YTChannelResponseDto>>);
						num = (_003C_003E1__state = -1);
					}
					ResponseList<YTChannelResponseDto> result = awaiter.GetResult();
					_003Cresult_003E5__2 = result;
					if (_003Cresult_003E5__2 != null && _003Cresult_003E5__2.Status)
					{
						_003C_003E7__wrap2 = _003Cresult_003E5__2.Data.Result.GetEnumerator();
						goto IL_00ef;
					}
					ytChannelsViewModel.SearchQuery.Page--;
					goto IL_0239;
					IL_0239:
					_003Cresult_003E5__2 = null;
					goto end_IL_0032;
					IL_00ef:
					try
					{
						if (num != 1)
						{
							goto IL_0199;
						}
						TaskAwaiter awaiter2 = _003C_003Eu__2;
						_003C_003Eu__2 = default(TaskAwaiter);
						num = (_003C_003E1__state = -1);
						goto IL_0175;
						IL_0175:
						oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter2, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
						ytChannelsViewModel.Items.Add(_003Citem_003E5__4);
						_003Citem_003E5__4 = null;
						goto IL_0199;
						IL_0199:
						if (hjMnupQVVDlRZAYQJC.D35lls5iF(_003C_003E7__wrap2, hjMnupQVVDlRZAYQJC.QV1TFwytOj))
						{
							_003Citem_003E5__4 = _003C_003E7__wrap2.Current;
							awaiter2 = QliBEUviwWqgtMcBndV.D35lls5iF(pvrKKy8Mk1kpdmIfp3A.D35lls5iF(2, pvrKKy8Mk1kpdmIfp3A.aVh8SPrFkE), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
							if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter2, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
							{
								num = (_003C_003E1__state = 1);
								_003C_003Eu__2 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
							goto IL_0175;
						}
					}
					finally
					{
						if (num < 0 && _003C_003E7__wrap2 != null)
						{
							xLO56JniGyickVjO1Ot.D35lls5iF(_003C_003E7__wrap2, xLO56JniGyickVjO1Ot.ydbT2bsoH4);
						}
					}
					_003C_003E7__wrap2 = null;
					ytChannelsViewModel.CurrentPage = _003Cresult_003E5__2.Data.CurrentPage;
					ytChannelsViewModel.PageCount = _003Cresult_003E5__2.Data.PageCount;
					ytChannelsViewModel.TotalCount = _003Cresult_003E5__2.Data.Total;
					goto IL_0239;
					end_IL_0032:;
				}
				catch
				{
					ytChannelsViewModel.SearchQuery.Page--;
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
	private struct _003C_003CLoadAsync_003Eb__23_1_003Ed : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public YtChannelsViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			YtChannelsViewModel ytChannelsViewModel = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(VrVteFCs0OCGBTVr1mZ.D35lls5iF(new Task[1] { OYihPsCZ1OyLa5m4TD0.D35lls5iF(ytChannelsViewModel, OYihPsCZ1OyLa5m4TD0.voitBvYklW) }, VrVteFCs0OCGBTVr1mZ.qNlChUR2Cs), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
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

	private readonly IYoutubeService sC50rN4D2x;

	private SortOrder rNw0Hedb77;

	private YTChannelSort PrQ0oZE6pQ;

	private readonly YtViewModel wCn0gD2rVU;

	[CompilerGenerated]
	private List<LanguageResponseDto> KIH017owcL;

	public List<LanguageResponseDto> Languages
	{
		[CompilerGenerated]
		get
		{
			return KIH017owcL;
		}
		[CompilerGenerated]
		set
		{
			KIH017owcL = value;
		}
	}

	public SortOrder SelectedOrder
	{
		get
		{
			return rNw0Hedb77;
		}
		set
		{
			_003C_003Ec__DisplayClass10_0 CS_0024_003C_003E8__locals4 = new _003C_003Ec__DisplayClass10_0();
			CS_0024_003C_003E8__locals4.vNRKHremy4 = this;
			CS_0024_003C_003E8__locals4.ufjKoQD9lb = value;
			SetProperty(ref rNw0Hedb77, CS_0024_003C_003E8__locals4.ufjKoQD9lb, iFZ5je3XFYKwkvcE5D.D35lls5iF(8208, iFZ5je3XFYKwkvcE5D.N06TeK0ao), null, [AsyncStateMachine(typeof(_003C_003Ec__DisplayClass10_0.G9sCVOjafDGOtEhbQko))] () =>
			{
				_003C_003Ec__DisplayClass10_0.G9sCVOjafDGOtEhbQko stateMachine = default(_003C_003Ec__DisplayClass10_0.G9sCVOjafDGOtEhbQko);
				stateMachine.kkLuqPxpbr = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
				stateMachine.avBuIUegoj = CS_0024_003C_003E8__locals4;
				stateMachine.MCXuP6rGb6 = -1;
				stateMachine.kkLuqPxpbr.Start(ref stateMachine);
			});
		}
	}

	public YTChannelSort SelectedSort
	{
		get
		{
			return PrQ0oZE6pQ;
		}
		set
		{
			_003C_003Ec__DisplayClass13_0 CS_0024_003C_003E8__locals4 = new _003C_003Ec__DisplayClass13_0();
			CS_0024_003C_003E8__locals4.zxjK1MgFVD = this;
			CS_0024_003C_003E8__locals4.WUhKJ4GqCJ = value;
			SetProperty(ref PrQ0oZE6pQ, CS_0024_003C_003E8__locals4.WUhKJ4GqCJ, iFZ5je3XFYKwkvcE5D.D35lls5iF(10222, iFZ5je3XFYKwkvcE5D.N06TeK0ao), null, [AsyncStateMachine(typeof(_003C_003Ec__DisplayClass13_0.qX8lysj04duo7Gq1iF6))] () =>
			{
				_003C_003Ec__DisplayClass13_0.qX8lysj04duo7Gq1iF6 stateMachine = default(_003C_003Ec__DisplayClass13_0.qX8lysj04duo7Gq1iF6);
				stateMachine.O2outOuDRF = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
				stateMachine.itjuSu4JoH = CS_0024_003C_003E8__locals4;
				stateMachine.uMPuZ4XdPV = -1;
				stateMachine.O2outOuDRF.Start(ref stateMachine);
			});
		}
	}

	public YtChannelsViewModel()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		rNw0Hedb77 = SortOrder.Desc;
		PrQ0oZE6pQ = YTChannelSort.ActivateDate;
		base._002Ector();
		sC50rN4D2x = AppContainer.Resolve<IYoutubeService>();
		base.FetchMoreDataCommand = new AsyncCommand(OnFetchMoreDataCommand);
		base.SearchQuery = new ApiQuery<YTSearch, YTChannelSort>
		{
			Count = 25,
			Search = new YTSearch()
		};
	}

	public YtChannelsViewModel(YtViewModel youtubeViewModel)
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		this._002Ector();
		wCn0gD2rVU = youtubeViewModel;
	}

	[AsyncStateMachine(typeof(_003CLoadVideos_003Ed__16))]
	public Task LoadVideos()
	{
		_003CLoadVideos_003Ed__16 stateMachine = default(_003CLoadVideos_003Ed__16);
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

	[AsyncStateMachine(typeof(_003COnFetchMoreDataCommand_003Ed__18))]
	protected Task OnFetchMoreDataCommand()
	{
		_003COnFetchMoreDataCommand_003Ed__18 stateMachine = default(_003COnFetchMoreDataCommand_003Ed__18);
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

	[AsyncStateMachine(typeof(_003CAddMoreItems_003Ed__20))]
	public override Task AddMoreItems()
	{
		_003CAddMoreItems_003Ed__20 stateMachine = default(_003CAddMoreItems_003Ed__20);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	[AsyncStateMachine(typeof(_003CGoToPage_003Ed__21))]
	public override Task GoToPage(YTChannelResponseDto model)
	{
		_003CGoToPage_003Ed__21 stateMachine = default(_003CGoToPage_003Ed__21);
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

	[AsyncStateMachine(typeof(_003CLoadAsync_003Ed__23))]
	public override Task LoadAsync()
	{
		_003CLoadAsync_003Ed__23 stateMachine = default(_003CLoadAsync_003Ed__23);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	[CompilerGenerated]
	[AsyncStateMachine(typeof(_003C_003CAddMoreItems_003Eb__20_1_003Ed))]
	private Task qL40eaeMSv()
	{
		_003C_003CAddMoreItems_003Eb__20_1_003Ed stateMachine = default(_003C_003CAddMoreItems_003Eb__20_1_003Ed);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	[CompilerGenerated]
	[AsyncStateMachine(typeof(_003C_003CLoadAsync_003Eb__23_1_003Ed))]
	private Task jsh0OHWVmu()
	{
		_003C_003CLoadAsync_003Eb__23_1_003Ed stateMachine = default(_003C_003CLoadAsync_003Eb__23_1_003Ed);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}
}
