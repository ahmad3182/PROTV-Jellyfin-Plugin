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
using PROTV.Abstractions.Apis;
using PROTV.Abstractions.Common;
using PROTV.Abstractions.DataTransferObjects;
using PROTV.Abstractions.Helpers;
using PROTV.Abstractions.Search;
using PROTV.Abstractions.Services;
using PROTV.Wpf.Bootstrap;

namespace PROTV.Wpf.ViewModels;

public class SeriesViewModel : BaseListViewModel<BaseMediaDto, ApiQuery<SeriesSearch, SeriesSort>>
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass34_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct LVCea4oXkfqfEiycwX : IAsyncStateMachine
		{
			public int wJH7BU5smD;

			public AsyncTaskMethodBuilder Ryy7DYjAZk;

			public _003C_003Ec__DisplayClass34_0 awM7diXKS8;

			private bool fcY7P18ERr;

			private object EUw7qKiqUK;

			private int BCr7IERGXC;

			private ResponseList<SeriesResponseDto> T1K7VWjwsr;

			private TaskAwaiter<ResponseList<SeriesResponseDto>> kwm7aXevrr;

			private IEnumerator<SeriesResponseDto> Fp470YNDER;

			private SeriesResponseDto YNF7GQUOV4;

			private TaskAwaiter bnn7TRYgjA;

			private ResponseList<SeasonResponseDto> vGk7ZRZj2P;

			private TaskAwaiter<ResponseList<SeasonResponseDto>> qn17tNHgob;

			private IEnumerator<SeasonResponseDto> H1Z7S5Sa19;

			private SeasonResponseDto pPL7fbqVdq;

			private ResponseList<EpisodeResponseDto> J9P7Kr54jf;

			private TaskAwaiter<ResponseList<EpisodeResponseDto>> qyY7k8xyUa;

			private IEnumerator<EpisodeResponseDto> nne78a6Bg1;

			private EpisodeResponseDto tKk7QiCccD;

			private TaskAwaiter<bool> Gan7nDAQ0n;

			private void MoveNext()
			{
				int num = wJH7BU5smD;
				_003C_003Ec__DisplayClass34_0 obj = awM7diXKS8;
				try
				{
					if ((uint)num <= 5u)
					{
						goto IL_004e;
					}
					if (num != 6)
					{
						obj.nDMf9Ljtj0.Items.Clear();
						fcY7P18ERr = true;
						goto IL_0816;
					}
					TaskAwaiter<bool> awaiter = Gan7nDAQ0n;
					Gan7nDAQ0n = default(TaskAwaiter<bool>);
					num = (wJH7BU5smD = -1);
					goto IL_07bb;
					IL_080f:
					EUw7qKiqUK = null;
					goto IL_0816;
					IL_07bb:
					if (awaiter.GetResult())
					{
						fcY7P18ERr = true;
						obj.nDMf9Ljtj0.vK9abeU58K = AppContainer.Resolve<ISeasonService>();
						obj.nDMf9Ljtj0.WgDanli7IP = AppContainer.Resolve<ISeriesService>();
						obj.nDMf9Ljtj0.DIqa7pr8rs = AppContainer.Resolve<IAppService>();
					}
					goto IL_080f;
					IL_004e:
					try
					{
						TaskAwaiter<ResponseList<SeriesResponseDto>> awaiter4;
						TaskAwaiter<ResponseList<SeasonResponseDto>> awaiter3;
						TaskAwaiter<ResponseList<EpisodeResponseDto>> awaiter2;
						ResponseList<EpisodeResponseDto> result;
						ResponseList<SeriesResponseDto> result2;
						ResponseList<SeasonResponseDto> result3;
						switch (num)
						{
						default:
							obj.nDMf9Ljtj0.SearchQuery.Page = 1;
							if (S1a0wT9Ixre9OpDny8h.D35lls5iF(obj.NZwfesextp, iFZ5je3XFYKwkvcE5D.D35lls5iF(9308, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO))
							{
								awaiter4 = sOOWwvU8coSrQjpWhkn.D35lls5iF(obj.nDMf9Ljtj0.WgDanli7IP, obj.nDMf9Ljtj0.SearchQuery, sOOWwvU8coSrQjpWhkn.dhvUnAYI7l).GetAwaiter();
								if (!awaiter4.IsCompleted)
								{
									num = (wJH7BU5smD = 0);
									kwm7aXevrr = awaiter4;
									Ryy7DYjAZk.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
									return;
								}
								goto IL_0112;
							}
							if (S1a0wT9Ixre9OpDny8h.D35lls5iF(obj.NZwfesextp, iFZ5je3XFYKwkvcE5D.D35lls5iF(11816, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO))
							{
								awaiter3 = J4LLFpU3bE9nxch3s5K.D35lls5iF(obj.nDMf9Ljtj0.vK9abeU58K, obj.nDMf9Ljtj0.SearchQuery, J4LLFpU3bE9nxch3s5K.qYMUTsJ76u).GetAwaiter();
								if (!awaiter3.IsCompleted)
								{
									num = (wJH7BU5smD = 2);
									qn17tNHgob = awaiter3;
									Ryy7DYjAZk.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
									return;
								}
								goto IL_0351;
							}
							awaiter2 = Hq6KPLdkBfHppWOifxV.D35lls5iF(obj.nDMf9Ljtj0.vK9abeU58K, obj.nDMf9Ljtj0.SearchQuery, Hq6KPLdkBfHppWOifxV.wMgdv0gLrD).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num = (wJH7BU5smD = 4);
								qyY7k8xyUa = awaiter2;
								Ryy7DYjAZk.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
							goto IL_056e;
						case 0:
							awaiter4 = kwm7aXevrr;
							kwm7aXevrr = default(TaskAwaiter<ResponseList<SeriesResponseDto>>);
							num = (wJH7BU5smD = -1);
							goto IL_0112;
						case 1:
							try
							{
								if (num != 1)
								{
									goto IL_0207;
								}
								TaskAwaiter awaiter5 = bnn7TRYgjA;
								bnn7TRYgjA = default(TaskAwaiter);
								num = (wJH7BU5smD = -1);
								goto IL_01de;
								IL_01de:
								oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter5, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
								obj.nDMf9Ljtj0.Items.Add(YNF7GQUOV4);
								YNF7GQUOV4 = null;
								goto IL_0207;
								IL_0207:
								if (hjMnupQVVDlRZAYQJC.D35lls5iF(Fp470YNDER, hjMnupQVVDlRZAYQJC.QV1TFwytOj))
								{
									YNF7GQUOV4 = Fp470YNDER.Current;
									awaiter5 = QliBEUviwWqgtMcBndV.D35lls5iF(pvrKKy8Mk1kpdmIfp3A.D35lls5iF(2, pvrKKy8Mk1kpdmIfp3A.aVh8SPrFkE), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
									if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter5, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
									{
										num = (wJH7BU5smD = 1);
										bnn7TRYgjA = awaiter5;
										Ryy7DYjAZk.AwaitUnsafeOnCompleted(ref awaiter5, ref this);
										return;
									}
									goto IL_01de;
								}
							}
							finally
							{
								if (num < 0 && Fp470YNDER != null)
								{
									xLO56JniGyickVjO1Ot.D35lls5iF(Fp470YNDER, xLO56JniGyickVjO1Ot.ydbT2bsoH4);
								}
							}
							Fp470YNDER = null;
							obj.nDMf9Ljtj0.CurrentPage = T1K7VWjwsr.Data.CurrentPage;
							obj.nDMf9Ljtj0.PageCount = T1K7VWjwsr.Data.PageCount;
							obj.nDMf9Ljtj0.TotalCount = T1K7VWjwsr.Data.Total;
							goto IL_02ad;
						case 2:
							awaiter3 = qn17tNHgob;
							qn17tNHgob = default(TaskAwaiter<ResponseList<SeasonResponseDto>>);
							num = (wJH7BU5smD = -1);
							goto IL_0351;
						case 3:
							try
							{
								if (num != 3)
								{
									goto IL_0448;
								}
								TaskAwaiter awaiter5 = bnn7TRYgjA;
								bnn7TRYgjA = default(TaskAwaiter);
								num = (wJH7BU5smD = -1);
								goto IL_041f;
								IL_041f:
								oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter5, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
								obj.nDMf9Ljtj0.Items.Add(pPL7fbqVdq);
								pPL7fbqVdq = null;
								goto IL_0448;
								IL_0448:
								if (hjMnupQVVDlRZAYQJC.D35lls5iF(H1Z7S5Sa19, hjMnupQVVDlRZAYQJC.QV1TFwytOj))
								{
									pPL7fbqVdq = H1Z7S5Sa19.Current;
									awaiter5 = QliBEUviwWqgtMcBndV.D35lls5iF(pvrKKy8Mk1kpdmIfp3A.D35lls5iF(2, pvrKKy8Mk1kpdmIfp3A.aVh8SPrFkE), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
									if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter5, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
									{
										num = (wJH7BU5smD = 3);
										bnn7TRYgjA = awaiter5;
										Ryy7DYjAZk.AwaitUnsafeOnCompleted(ref awaiter5, ref this);
										return;
									}
									goto IL_041f;
								}
							}
							finally
							{
								if (num < 0 && H1Z7S5Sa19 != null)
								{
									xLO56JniGyickVjO1Ot.D35lls5iF(H1Z7S5Sa19, xLO56JniGyickVjO1Ot.ydbT2bsoH4);
								}
							}
							H1Z7S5Sa19 = null;
							obj.nDMf9Ljtj0.CurrentPage = vGk7ZRZj2P.Data.CurrentPage;
							obj.nDMf9Ljtj0.PageCount = vGk7ZRZj2P.Data.PageCount;
							obj.nDMf9Ljtj0.TotalCount = vGk7ZRZj2P.Data.Total;
							goto IL_04ee;
						case 4:
							awaiter2 = qyY7k8xyUa;
							qyY7k8xyUa = default(TaskAwaiter<ResponseList<EpisodeResponseDto>>);
							num = (wJH7BU5smD = -1);
							goto IL_056e;
						case 5:
							{
								try
								{
									if (num != 5)
									{
										goto IL_0665;
									}
									TaskAwaiter awaiter5 = bnn7TRYgjA;
									bnn7TRYgjA = default(TaskAwaiter);
									num = (wJH7BU5smD = -1);
									goto IL_063c;
									IL_063c:
									oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter5, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
									obj.nDMf9Ljtj0.Items.Add(tKk7QiCccD);
									tKk7QiCccD = null;
									goto IL_0665;
									IL_0665:
									if (hjMnupQVVDlRZAYQJC.D35lls5iF(nne78a6Bg1, hjMnupQVVDlRZAYQJC.QV1TFwytOj))
									{
										tKk7QiCccD = nne78a6Bg1.Current;
										awaiter5 = QliBEUviwWqgtMcBndV.D35lls5iF(pvrKKy8Mk1kpdmIfp3A.D35lls5iF(2, pvrKKy8Mk1kpdmIfp3A.aVh8SPrFkE), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
										if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter5, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
										{
											num = (wJH7BU5smD = 5);
											bnn7TRYgjA = awaiter5;
											Ryy7DYjAZk.AwaitUnsafeOnCompleted(ref awaiter5, ref this);
											return;
										}
										goto IL_063c;
									}
								}
								finally
								{
									if (num < 0 && nne78a6Bg1 != null)
									{
										xLO56JniGyickVjO1Ot.D35lls5iF(nne78a6Bg1, xLO56JniGyickVjO1Ot.ydbT2bsoH4);
									}
								}
								nne78a6Bg1 = null;
								obj.nDMf9Ljtj0.CurrentPage = J9P7Kr54jf.Data.CurrentPage;
								obj.nDMf9Ljtj0.PageCount = J9P7Kr54jf.Data.PageCount;
								obj.nDMf9Ljtj0.TotalCount = J9P7Kr54jf.Data.Total;
								break;
							}
							IL_02ad:
							T1K7VWjwsr = null;
							goto end_IL_004e;
							IL_056e:
							result = awaiter2.GetResult();
							J9P7Kr54jf = result;
							if (J9P7Kr54jf != null && J9P7Kr54jf.Status)
							{
								nne78a6Bg1 = J9P7Kr54jf.Data.Result.GetEnumerator();
								goto case 5;
							}
							obj.nDMf9Ljtj0.TotalCount = 0;
							break;
							IL_0112:
							result2 = awaiter4.GetResult();
							T1K7VWjwsr = result2;
							if (T1K7VWjwsr != null && T1K7VWjwsr.Status)
							{
								Fp470YNDER = T1K7VWjwsr.Data.Result.GetEnumerator();
								goto case 1;
							}
							obj.nDMf9Ljtj0.TotalCount = 0;
							goto IL_02ad;
							IL_0351:
							result3 = awaiter3.GetResult();
							vGk7ZRZj2P = result3;
							if (vGk7ZRZj2P != null && vGk7ZRZj2P.Status)
							{
								H1Z7S5Sa19 = vGk7ZRZj2P.Data.Result.GetEnumerator();
								goto case 3;
							}
							obj.nDMf9Ljtj0.TotalCount = 0;
							goto IL_04ee;
							IL_04ee:
							vGk7ZRZj2P = null;
							goto end_IL_004e;
						}
						J9P7Kr54jf = null;
						end_IL_004e:;
					}
					catch (PROTVException eUw7qKiqUK)
					{
						EUw7qKiqUK = eUw7qKiqUK;
						BCr7IERGXC = 1;
					}
					int num2 = BCr7IERGXC;
					if (num2 == 1)
					{
						if (TNckS5wtLfB2Lk9dYP8.D35lls5iF((PROTVException)EUw7qKiqUK, TNckS5wtLfB2Lk9dYP8.oGkwV3iq3t) == ExceptionType.AuthorizationTokenInvalid)
						{
							awaiter = bAA7Sxw7vZsvusOmDea.D35lls5iF(AppContainer.Resolve<MainViewModel>(), bAA7Sxw7vZsvusOmDea.gytwc9U7r5).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = (wJH7BU5smD = 6);
								Gan7nDAQ0n = awaiter;
								Ryy7DYjAZk.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_07bb;
						}
						obj.nDMf9Ljtj0.TotalCount = 0;
					}
					goto IL_080f;
					IL_0816:
					if (fcY7P18ERr)
					{
						fcY7P18ERr = false;
						BCr7IERGXC = 0;
						goto IL_004e;
					}
				}
				catch (Exception ex)
				{
					wJH7BU5smD = -2;
					NNK1eXA7fWQ87oSUty7.D35lls5iF(ref Ryy7DYjAZk, ex, NNK1eXA7fWQ87oSUty7.G3EAcW9Om7);
					return;
				}
				wJH7BU5smD = -2;
				meFicnAMHIVtdhf671p.D35lls5iF(ref Ryy7DYjAZk, meFicnAMHIVtdhf671p.bsDASenQ5I);
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine P_0)
			{
				vxBFJcAKZoecNtbdqxt.D35lls5iF(ref Ryy7DYjAZk, P_0, vxBFJcAKZoecNtbdqxt.tuxANdhu18);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine P_0)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(P_0);
			}
		}

		[StructLayout(LayoutKind.Auto)]
		private struct YRf4n7grvTWJBIumWC : IAsyncStateMachine
		{
			public int zjN7bAVBuE;

			public AsyncVoidMethodBuilder npN77FkA8Y;

			public _003C_003Ec__DisplayClass34_0 owt75qZpYF;

			private TaskAwaiter MDC7uAEX3f;

			private void MoveNext()
			{
				int num = zjN7bAVBuE;
				_003C_003Ec__DisplayClass34_0 CS_0024_003C_003E8__locals3 = owt75qZpYF;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(W7S2sip6SDieZFVsNbd.D35lls5iF(CS_0024_003C_003E8__locals3.nDMf9Ljtj0, Expression.Lambda<Func<bool>>(OWBKr5pvc5MWsK1OMtR.D35lls5iF(o4bYL4peNeC2wWb8yjx.D35lls5iF(CS_0024_003C_003E8__locals3.nDMf9Ljtj0, sjYxHO8OWlc6X80hFj7.D35lls5iF(typeof(SeriesViewModel).TypeHandle, sjYxHO8OWlc6X80hFj7.uWZ8ugU7r5), o4bYL4peNeC2wWb8yjx.oVdpGKjy2x), (MethodInfo)f5q427pRQZnrEKPy4Ws.D35lls5iF((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, f5q427pRQZnrEKPy4Ws.Bo9pk3m4k7), OWBKr5pvc5MWsK1OMtR.fZIpAAdi1v), Array.Empty<ParameterExpression>()), [AsyncStateMachine(typeof(LVCea4oXkfqfEiycwX))] () =>
						{
							LVCea4oXkfqfEiycwX stateMachine = default(LVCea4oXkfqfEiycwX);
							stateMachine.Ryy7DYjAZk = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
							stateMachine.awM7diXKS8 = CS_0024_003C_003E8__locals3;
							stateMachine.wJH7BU5smD = -1;
							stateMachine.Ryy7DYjAZk.Start(ref stateMachine);
							return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine.Ryy7DYjAZk, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
						}, W7S2sip6SDieZFVsNbd.XWappgVyfh), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
						if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
						{
							num = (zjN7bAVBuE = 0);
							MDC7uAEX3f = awaiter;
							npN77FkA8Y.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = MDC7uAEX3f;
						MDC7uAEX3f = default(TaskAwaiter);
						num = (zjN7bAVBuE = -1);
					}
					oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
				}
				catch (Exception ex)
				{
					zjN7bAVBuE = -2;
					N2XUglA3neBsnlZfRPQ.D35lls5iF(ref npN77FkA8Y, ex, N2XUglA3neBsnlZfRPQ.l4pATRumoW);
					return;
				}
				zjN7bAVBuE = -2;
				T4XmPoA4VNJJP1afcgL.D35lls5iF(ref npN77FkA8Y, T4XmPoA4VNJJP1afcgL.TRyALZckCh);
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine P_0)
			{
				dHWo7jAEn6E4X7bsY4R.D35lls5iF(ref npN77FkA8Y, P_0, dHWo7jAEn6E4X7bsY4R.z3hAB6UZ9o);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine P_0)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(P_0);
			}
		}

		public SeriesViewModel nDMf9Ljtj0;

		public string NZwfesextp;

		public Func<Task> hWcfODGGg7;

		public _003C_003Ec__DisplayClass34_0()
		{
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
			base._002Ector();
		}

		[AsyncStateMachine(typeof(YRf4n7grvTWJBIumWC))]
		internal void RlXfwlvY0N()
		{
			YRf4n7grvTWJBIumWC stateMachine = default(YRf4n7grvTWJBIumWC);
			stateMachine.npN77FkA8Y = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
			stateMachine.owt75qZpYF = this;
			stateMachine.zjN7bAVBuE = -1;
			stateMachine.npN77FkA8Y.Start(ref stateMachine);
		}

		[AsyncStateMachine(typeof(LVCea4oXkfqfEiycwX))]
		internal Task FsYfED59lO()
		{
			LVCea4oXkfqfEiycwX stateMachine = default(LVCea4oXkfqfEiycwX);
			stateMachine.Ryy7DYjAZk = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
			stateMachine.awM7diXKS8 = this;
			stateMachine.wJH7BU5smD = -1;
			stateMachine.Ryy7DYjAZk.Start(ref stateMachine);
			return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine.Ryy7DYjAZk, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass37_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct R5eteu1j1QBBrAiv4T : IAsyncStateMachine
		{
			public int spL7AoQcRZ;

			public AsyncTaskMethodBuilder jsk7NOa7q8;

			public _003C_003Ec__DisplayClass37_0 pxQ7Mq4h3k;

			private TaskAwaiter qxJ7CLQN92;

			private void MoveNext()
			{
				int num = spL7AoQcRZ;
				_003C_003Ec__DisplayClass37_0 obj = pxQ7Mq4h3k;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						obj.xHWfoSIlMe.Items.Clear();
						obj.xHWfoSIlMe.SearchQuery.Page = 1;
						if (S1a0wT9Ixre9OpDny8h.D35lls5iF(eVlRnEIaHT0dqvCx0Kx.D35lls5iF(obj.sdEfgWStD0, eVlRnEIaHT0dqvCx0Kx.fa575yQKq4), iFZ5je3XFYKwkvcE5D.D35lls5iF(17100, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO))
						{
							lASFo76QIUBEikAAsE9.D35lls5iF(obj.xHWfoSIlMe.SearchQuery.Search, Language.English, lASFo76QIUBEikAAsE9.UMA6X462Ew);
						}
						if (S1a0wT9Ixre9OpDny8h.D35lls5iF(eVlRnEIaHT0dqvCx0Kx.D35lls5iF(obj.sdEfgWStD0, eVlRnEIaHT0dqvCx0Kx.fa575yQKq4), iFZ5je3XFYKwkvcE5D.D35lls5iF(17118, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO))
						{
							lASFo76QIUBEikAAsE9.D35lls5iF(obj.xHWfoSIlMe.SearchQuery.Search, Language.Arabic, lASFo76QIUBEikAAsE9.UMA6X462Ew);
						}
						if (S1a0wT9Ixre9OpDny8h.D35lls5iF(eVlRnEIaHT0dqvCx0Kx.D35lls5iF(obj.sdEfgWStD0, eVlRnEIaHT0dqvCx0Kx.fa575yQKq4), iFZ5je3XFYKwkvcE5D.D35lls5iF(17134, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO))
						{
							lASFo76QIUBEikAAsE9.D35lls5iF(obj.xHWfoSIlMe.SearchQuery.Search, Language.Other, lASFo76QIUBEikAAsE9.UMA6X462Ew);
						}
						if (S1a0wT9Ixre9OpDny8h.D35lls5iF(eVlRnEIaHT0dqvCx0Kx.D35lls5iF(obj.sdEfgWStD0, eVlRnEIaHT0dqvCx0Kx.fa575yQKq4), iFZ5je3XFYKwkvcE5D.D35lls5iF(17148, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO))
						{
							lASFo76QIUBEikAAsE9.D35lls5iF(obj.xHWfoSIlMe.SearchQuery.Search, Language.Turkish, lASFo76QIUBEikAAsE9.UMA6X462Ew);
						}
						if (S1a0wT9Ixre9OpDny8h.D35lls5iF(eVlRnEIaHT0dqvCx0Kx.D35lls5iF(obj.sdEfgWStD0, eVlRnEIaHT0dqvCx0Kx.fa575yQKq4), iFZ5je3XFYKwkvcE5D.D35lls5iF(17166, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO))
						{
							lASFo76QIUBEikAAsE9.D35lls5iF(obj.xHWfoSIlMe.SearchQuery.Search, Language.Japanese, lASFo76QIUBEikAAsE9.UMA6X462Ew);
						}
						if (S1a0wT9Ixre9OpDny8h.D35lls5iF(eVlRnEIaHT0dqvCx0Kx.D35lls5iF(obj.sdEfgWStD0, eVlRnEIaHT0dqvCx0Kx.fa575yQKq4), iFZ5je3XFYKwkvcE5D.D35lls5iF(16162, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO))
						{
							lASFo76QIUBEikAAsE9.D35lls5iF(obj.xHWfoSIlMe.SearchQuery.Search, null, lASFo76QIUBEikAAsE9.UMA6X462Ew);
						}
						awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(OYihPsCZ1OyLa5m4TD0.D35lls5iF(obj.xHWfoSIlMe, OYihPsCZ1OyLa5m4TD0.bixU9bJWok), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
						if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
						{
							num = (spL7AoQcRZ = 0);
							qxJ7CLQN92 = awaiter;
							jsk7NOa7q8.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = qxJ7CLQN92;
						qxJ7CLQN92 = default(TaskAwaiter);
						num = (spL7AoQcRZ = -1);
					}
					oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
				}
				catch (Exception ex)
				{
					spL7AoQcRZ = -2;
					NNK1eXA7fWQ87oSUty7.D35lls5iF(ref jsk7NOa7q8, ex, NNK1eXA7fWQ87oSUty7.G3EAcW9Om7);
					return;
				}
				spL7AoQcRZ = -2;
				meFicnAMHIVtdhf671p.D35lls5iF(ref jsk7NOa7q8, meFicnAMHIVtdhf671p.bsDASenQ5I);
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine P_0)
			{
				vxBFJcAKZoecNtbdqxt.D35lls5iF(ref jsk7NOa7q8, P_0, vxBFJcAKZoecNtbdqxt.tuxANdhu18);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine P_0)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(P_0);
			}
		}

		[StructLayout(LayoutKind.Auto)]
		private struct HL4SVaJEsW5ORd8dqo : IAsyncStateMachine
		{
			public int H357YuI4xd;

			public AsyncVoidMethodBuilder LbR7FEiX7v;

			public _003C_003Ec__DisplayClass37_0 zI676kFCyL;

			private TaskAwaiter ycg7slMPws;

			private void MoveNext()
			{
				int num = H357YuI4xd;
				_003C_003Ec__DisplayClass37_0 CS_0024_003C_003E8__locals3 = zI676kFCyL;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(W7S2sip6SDieZFVsNbd.D35lls5iF(CS_0024_003C_003E8__locals3.xHWfoSIlMe, Expression.Lambda<Func<bool>>(OWBKr5pvc5MWsK1OMtR.D35lls5iF(o4bYL4peNeC2wWb8yjx.D35lls5iF(CS_0024_003C_003E8__locals3.xHWfoSIlMe, sjYxHO8OWlc6X80hFj7.D35lls5iF(typeof(SeriesViewModel).TypeHandle, sjYxHO8OWlc6X80hFj7.uWZ8ugU7r5), o4bYL4peNeC2wWb8yjx.oVdpGKjy2x), (MethodInfo)f5q427pRQZnrEKPy4Ws.D35lls5iF((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, f5q427pRQZnrEKPy4Ws.Bo9pk3m4k7), OWBKr5pvc5MWsK1OMtR.fZIpAAdi1v), Array.Empty<ParameterExpression>()), [AsyncStateMachine(typeof(R5eteu1j1QBBrAiv4T))] () =>
						{
							R5eteu1j1QBBrAiv4T stateMachine = default(R5eteu1j1QBBrAiv4T);
							stateMachine.jsk7NOa7q8 = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
							stateMachine.pxQ7Mq4h3k = CS_0024_003C_003E8__locals3;
							stateMachine.spL7AoQcRZ = -1;
							stateMachine.jsk7NOa7q8.Start(ref stateMachine);
							return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine.jsk7NOa7q8, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
						}, W7S2sip6SDieZFVsNbd.XWappgVyfh), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
						if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
						{
							num = (H357YuI4xd = 0);
							ycg7slMPws = awaiter;
							LbR7FEiX7v.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = ycg7slMPws;
						ycg7slMPws = default(TaskAwaiter);
						num = (H357YuI4xd = -1);
					}
					oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
				}
				catch (Exception ex)
				{
					H357YuI4xd = -2;
					N2XUglA3neBsnlZfRPQ.D35lls5iF(ref LbR7FEiX7v, ex, N2XUglA3neBsnlZfRPQ.l4pATRumoW);
					return;
				}
				H357YuI4xd = -2;
				T4XmPoA4VNJJP1afcgL.D35lls5iF(ref LbR7FEiX7v, T4XmPoA4VNJJP1afcgL.TRyALZckCh);
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine P_0)
			{
				dHWo7jAEn6E4X7bsY4R.D35lls5iF(ref LbR7FEiX7v, P_0, dHWo7jAEn6E4X7bsY4R.z3hAB6UZ9o);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine P_0)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(P_0);
			}
		}

		public SeriesViewModel xHWfoSIlMe;

		public LanguageResponseDto sdEfgWStD0;

		public Func<Task> GtEf1VcNDA;

		public _003C_003Ec__DisplayClass37_0()
		{
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
			base._002Ector();
		}

		[AsyncStateMachine(typeof(HL4SVaJEsW5ORd8dqo))]
		internal void AJLfrwZeyv()
		{
			HL4SVaJEsW5ORd8dqo stateMachine = default(HL4SVaJEsW5ORd8dqo);
			stateMachine.LbR7FEiX7v = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
			stateMachine.zI676kFCyL = this;
			stateMachine.H357YuI4xd = -1;
			stateMachine.LbR7FEiX7v.Start(ref stateMachine);
		}

		[AsyncStateMachine(typeof(R5eteu1j1QBBrAiv4T))]
		internal Task WP2fHvXdIM()
		{
			R5eteu1j1QBBrAiv4T stateMachine = default(R5eteu1j1QBBrAiv4T);
			stateMachine.jsk7NOa7q8 = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
			stateMachine.pxQ7Mq4h3k = this;
			stateMachine.spL7AoQcRZ = -1;
			stateMachine.jsk7NOa7q8.Start(ref stateMachine);
			return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine.jsk7NOa7q8, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass40_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct q8DjvchBjUrxL93Aj9 : IAsyncStateMachine
		{
			public int jlY7xDNqdP;

			public AsyncTaskMethodBuilder cXC7yDKoya;

			public _003C_003Ec__DisplayClass40_0 L6g7pZyHGP;

			private TaskAwaiter JOl7iO5Xh0;

			private void MoveNext()
			{
				int num = jlY7xDNqdP;
				_003C_003Ec__DisplayClass40_0 obj = L6g7pZyHGP;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						obj.ek8flNpo4n.Items.Clear();
						obj.ek8flNpo4n.SearchQuery.Page = 1;
						obj.ek8flNpo4n.SearchQuery.Order = obj.JaNfUQkJss;
						awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(OYihPsCZ1OyLa5m4TD0.D35lls5iF(obj.ek8flNpo4n, OYihPsCZ1OyLa5m4TD0.bixU9bJWok), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
						if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
						{
							num = (jlY7xDNqdP = 0);
							JOl7iO5Xh0 = awaiter;
							cXC7yDKoya.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = JOl7iO5Xh0;
						JOl7iO5Xh0 = default(TaskAwaiter);
						num = (jlY7xDNqdP = -1);
					}
					oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
				}
				catch (Exception ex)
				{
					jlY7xDNqdP = -2;
					NNK1eXA7fWQ87oSUty7.D35lls5iF(ref cXC7yDKoya, ex, NNK1eXA7fWQ87oSUty7.G3EAcW9Om7);
					return;
				}
				jlY7xDNqdP = -2;
				meFicnAMHIVtdhf671p.D35lls5iF(ref cXC7yDKoya, meFicnAMHIVtdhf671p.bsDASenQ5I);
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine P_0)
			{
				vxBFJcAKZoecNtbdqxt.D35lls5iF(ref cXC7yDKoya, P_0, vxBFJcAKZoecNtbdqxt.tuxANdhu18);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine P_0)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(P_0);
			}
		}

		[StructLayout(LayoutKind.Auto)]
		private struct uMntyHl2Lw9S3qmq19 : IAsyncStateMachine
		{
			public int wfr735n1NY;

			public AsyncVoidMethodBuilder E0T7m8q4PU;

			public _003C_003Ec__DisplayClass40_0 mfF7Xc7GZD;

			private TaskAwaiter aDC7RWsyjI;

			private void MoveNext()
			{
				int num = wfr735n1NY;
				_003C_003Ec__DisplayClass40_0 CS_0024_003C_003E8__locals3 = mfF7Xc7GZD;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(W7S2sip6SDieZFVsNbd.D35lls5iF(CS_0024_003C_003E8__locals3.ek8flNpo4n, Expression.Lambda<Func<bool>>(OWBKr5pvc5MWsK1OMtR.D35lls5iF(o4bYL4peNeC2wWb8yjx.D35lls5iF(CS_0024_003C_003E8__locals3.ek8flNpo4n, sjYxHO8OWlc6X80hFj7.D35lls5iF(typeof(SeriesViewModel).TypeHandle, sjYxHO8OWlc6X80hFj7.uWZ8ugU7r5), o4bYL4peNeC2wWb8yjx.oVdpGKjy2x), (MethodInfo)f5q427pRQZnrEKPy4Ws.D35lls5iF((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, f5q427pRQZnrEKPy4Ws.Bo9pk3m4k7), OWBKr5pvc5MWsK1OMtR.fZIpAAdi1v), Array.Empty<ParameterExpression>()), [AsyncStateMachine(typeof(q8DjvchBjUrxL93Aj9))] () =>
						{
							q8DjvchBjUrxL93Aj9 stateMachine = default(q8DjvchBjUrxL93Aj9);
							stateMachine.cXC7yDKoya = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
							stateMachine.L6g7pZyHGP = CS_0024_003C_003E8__locals3;
							stateMachine.jlY7xDNqdP = -1;
							stateMachine.cXC7yDKoya.Start(ref stateMachine);
							return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine.cXC7yDKoya, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
						}, W7S2sip6SDieZFVsNbd.XWappgVyfh), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
						if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
						{
							num = (wfr735n1NY = 0);
							aDC7RWsyjI = awaiter;
							E0T7m8q4PU.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = aDC7RWsyjI;
						aDC7RWsyjI = default(TaskAwaiter);
						num = (wfr735n1NY = -1);
					}
					oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
				}
				catch (Exception ex)
				{
					wfr735n1NY = -2;
					N2XUglA3neBsnlZfRPQ.D35lls5iF(ref E0T7m8q4PU, ex, N2XUglA3neBsnlZfRPQ.l4pATRumoW);
					return;
				}
				wfr735n1NY = -2;
				T4XmPoA4VNJJP1afcgL.D35lls5iF(ref E0T7m8q4PU, T4XmPoA4VNJJP1afcgL.TRyALZckCh);
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine P_0)
			{
				dHWo7jAEn6E4X7bsY4R.D35lls5iF(ref E0T7m8q4PU, P_0, dHWo7jAEn6E4X7bsY4R.z3hAB6UZ9o);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine P_0)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(P_0);
			}
		}

		public SeriesViewModel ek8flNpo4n;

		public SortOrder JaNfUQkJss;

		public Func<Task> bqgfLLYCQQ;

		public _003C_003Ec__DisplayClass40_0()
		{
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
			base._002Ector();
		}

		[AsyncStateMachine(typeof(uMntyHl2Lw9S3qmq19))]
		internal void vbQfJsqrQJ()
		{
			uMntyHl2Lw9S3qmq19 stateMachine = default(uMntyHl2Lw9S3qmq19);
			stateMachine.E0T7m8q4PU = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
			stateMachine.mfF7Xc7GZD = this;
			stateMachine.wfr735n1NY = -1;
			stateMachine.E0T7m8q4PU.Start(ref stateMachine);
		}

		[AsyncStateMachine(typeof(q8DjvchBjUrxL93Aj9))]
		internal Task ms5fhDGLcj()
		{
			q8DjvchBjUrxL93Aj9 stateMachine = default(q8DjvchBjUrxL93Aj9);
			stateMachine.cXC7yDKoya = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
			stateMachine.L6g7pZyHGP = this;
			stateMachine.jlY7xDNqdP = -1;
			stateMachine.cXC7yDKoya.Start(ref stateMachine);
			return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine.cXC7yDKoya, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass43_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct gBPBqeUOCwVkqZinof : IAsyncStateMachine
		{
			public int jAT7wtJCfc;

			public AsyncTaskMethodBuilder BN37EkRcXM;

			public _003C_003Ec__DisplayClass43_0 CL779kYnVJ;

			private TaskAwaiter KZo7eB8Wc1;

			private void MoveNext()
			{
				int num = jAT7wtJCfc;
				_003C_003Ec__DisplayClass43_0 obj = CL779kYnVJ;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						obj.g7hKcBeKIe.Items.Clear();
						obj.g7hKcBeKIe.SearchQuery.Page = 1;
						obj.g7hKcBeKIe.SearchQuery.Sort = obj.jPQKjV0Btm;
						awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(OYihPsCZ1OyLa5m4TD0.D35lls5iF(obj.g7hKcBeKIe, OYihPsCZ1OyLa5m4TD0.bixU9bJWok), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
						if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
						{
							num = (jAT7wtJCfc = 0);
							KZo7eB8Wc1 = awaiter;
							BN37EkRcXM.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = KZo7eB8Wc1;
						KZo7eB8Wc1 = default(TaskAwaiter);
						num = (jAT7wtJCfc = -1);
					}
					oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
				}
				catch (Exception ex)
				{
					jAT7wtJCfc = -2;
					NNK1eXA7fWQ87oSUty7.D35lls5iF(ref BN37EkRcXM, ex, NNK1eXA7fWQ87oSUty7.G3EAcW9Om7);
					return;
				}
				jAT7wtJCfc = -2;
				meFicnAMHIVtdhf671p.D35lls5iF(ref BN37EkRcXM, meFicnAMHIVtdhf671p.bsDASenQ5I);
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine P_0)
			{
				vxBFJcAKZoecNtbdqxt.D35lls5iF(ref BN37EkRcXM, P_0, vxBFJcAKZoecNtbdqxt.tuxANdhu18);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine P_0)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(P_0);
			}
		}

		[StructLayout(LayoutKind.Auto)]
		private struct SQF0tYLRcFxWNMFlve : IAsyncStateMachine
		{
			public int mUO7OjmEyR;

			public AsyncVoidMethodBuilder ohm7rgsGZj;

			public _003C_003Ec__DisplayClass43_0 msX7HANlD9;

			private TaskAwaiter hX77o1Zhnr;

			private void MoveNext()
			{
				int num = mUO7OjmEyR;
				_003C_003Ec__DisplayClass43_0 CS_0024_003C_003E8__locals3 = msX7HANlD9;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(W7S2sip6SDieZFVsNbd.D35lls5iF(CS_0024_003C_003E8__locals3.g7hKcBeKIe, Expression.Lambda<Func<bool>>(OWBKr5pvc5MWsK1OMtR.D35lls5iF(o4bYL4peNeC2wWb8yjx.D35lls5iF(CS_0024_003C_003E8__locals3.g7hKcBeKIe, sjYxHO8OWlc6X80hFj7.D35lls5iF(typeof(SeriesViewModel).TypeHandle, sjYxHO8OWlc6X80hFj7.uWZ8ugU7r5), o4bYL4peNeC2wWb8yjx.oVdpGKjy2x), (MethodInfo)f5q427pRQZnrEKPy4Ws.D35lls5iF((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, f5q427pRQZnrEKPy4Ws.Bo9pk3m4k7), OWBKr5pvc5MWsK1OMtR.fZIpAAdi1v), Array.Empty<ParameterExpression>()), [AsyncStateMachine(typeof(gBPBqeUOCwVkqZinof))] () =>
						{
							gBPBqeUOCwVkqZinof stateMachine = default(gBPBqeUOCwVkqZinof);
							stateMachine.BN37EkRcXM = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
							stateMachine.CL779kYnVJ = CS_0024_003C_003E8__locals3;
							stateMachine.jAT7wtJCfc = -1;
							stateMachine.BN37EkRcXM.Start(ref stateMachine);
							return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine.BN37EkRcXM, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
						}, W7S2sip6SDieZFVsNbd.XWappgVyfh), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
						if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
						{
							num = (mUO7OjmEyR = 0);
							hX77o1Zhnr = awaiter;
							ohm7rgsGZj.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = hX77o1Zhnr;
						hX77o1Zhnr = default(TaskAwaiter);
						num = (mUO7OjmEyR = -1);
					}
					oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
				}
				catch (Exception ex)
				{
					mUO7OjmEyR = -2;
					N2XUglA3neBsnlZfRPQ.D35lls5iF(ref ohm7rgsGZj, ex, N2XUglA3neBsnlZfRPQ.l4pATRumoW);
					return;
				}
				mUO7OjmEyR = -2;
				T4XmPoA4VNJJP1afcgL.D35lls5iF(ref ohm7rgsGZj, T4XmPoA4VNJJP1afcgL.TRyALZckCh);
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine P_0)
			{
				dHWo7jAEn6E4X7bsY4R.D35lls5iF(ref ohm7rgsGZj, P_0, dHWo7jAEn6E4X7bsY4R.z3hAB6UZ9o);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine P_0)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(P_0);
			}
		}

		public SeriesViewModel g7hKcBeKIe;

		public SeriesSort jPQKjV0Btm;

		public Func<Task> g8VKv5uByW;

		public _003C_003Ec__DisplayClass43_0()
		{
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
			base._002Ector();
		}

		[AsyncStateMachine(typeof(SQF0tYLRcFxWNMFlve))]
		internal void aJRf2es0kw()
		{
			SQF0tYLRcFxWNMFlve stateMachine = default(SQF0tYLRcFxWNMFlve);
			stateMachine.ohm7rgsGZj = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
			stateMachine.msX7HANlD9 = this;
			stateMachine.mUO7OjmEyR = -1;
			stateMachine.ohm7rgsGZj.Start(ref stateMachine);
		}

		[AsyncStateMachine(typeof(gBPBqeUOCwVkqZinof))]
		internal Task d0AfzJqTa4()
		{
			gBPBqeUOCwVkqZinof stateMachine = default(gBPBqeUOCwVkqZinof);
			stateMachine.BN37EkRcXM = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
			stateMachine.CL779kYnVJ = this;
			stateMachine.jAT7wtJCfc = -1;
			stateMachine.BN37EkRcXM.Start(ref stateMachine);
			return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine.BN37EkRcXM, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass46_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct HCWAVj2gWS8W0oIJHm : IAsyncStateMachine
		{
			public int YLa7gxEbFD;

			public AsyncTaskMethodBuilder g1U71EnxtO;

			public _003C_003Ec__DisplayClass46_0 c0X7J8RQCI;

			private TaskAwaiter Scj7hM53Zb;

			private void MoveNext()
			{
				int num = YLa7gxEbFD;
				_003C_003Ec__DisplayClass46_0 obj = c0X7J8RQCI;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						obj.k1NKBm6RVS.Items.Clear();
						obj.k1NKBm6RVS.SearchQuery.Page = 1;
						wuXoja6xGA4YsTL6UdU.D35lls5iF(obj.k1NKBm6RVS.SearchQuery.Search, V4VMaWmQYRpUqEIxujB.D35lls5iF(obj.mE1KDv8Y1N, V4VMaWmQYRpUqEIxujB.ppX7zHXVPj), wuXoja6xGA4YsTL6UdU.TqYUDRHIBK);
						awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(OYihPsCZ1OyLa5m4TD0.D35lls5iF(obj.k1NKBm6RVS, OYihPsCZ1OyLa5m4TD0.bixU9bJWok), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
						if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
						{
							num = (YLa7gxEbFD = 0);
							Scj7hM53Zb = awaiter;
							g1U71EnxtO.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = Scj7hM53Zb;
						Scj7hM53Zb = default(TaskAwaiter);
						num = (YLa7gxEbFD = -1);
					}
					oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
				}
				catch (Exception ex)
				{
					YLa7gxEbFD = -2;
					NNK1eXA7fWQ87oSUty7.D35lls5iF(ref g1U71EnxtO, ex, NNK1eXA7fWQ87oSUty7.G3EAcW9Om7);
					return;
				}
				YLa7gxEbFD = -2;
				meFicnAMHIVtdhf671p.D35lls5iF(ref g1U71EnxtO, meFicnAMHIVtdhf671p.bsDASenQ5I);
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine P_0)
			{
				vxBFJcAKZoecNtbdqxt.D35lls5iF(ref g1U71EnxtO, P_0, vxBFJcAKZoecNtbdqxt.tuxANdhu18);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine P_0)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(P_0);
			}
		}

		[StructLayout(LayoutKind.Auto)]
		private struct t1ayyHzyaDnrDguvSI : IAsyncStateMachine
		{
			public int rDQ7l5uMZy;

			public AsyncVoidMethodBuilder Eox7UAcRQq;

			public _003C_003Ec__DisplayClass46_0 NBa7LpMcHt;

			private TaskAwaiter vWX727yUAx;

			private void MoveNext()
			{
				int num = rDQ7l5uMZy;
				_003C_003Ec__DisplayClass46_0 CS_0024_003C_003E8__locals3 = NBa7LpMcHt;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(W7S2sip6SDieZFVsNbd.D35lls5iF(CS_0024_003C_003E8__locals3.k1NKBm6RVS, Expression.Lambda<Func<bool>>(OWBKr5pvc5MWsK1OMtR.D35lls5iF(o4bYL4peNeC2wWb8yjx.D35lls5iF(CS_0024_003C_003E8__locals3.k1NKBm6RVS, sjYxHO8OWlc6X80hFj7.D35lls5iF(typeof(SeriesViewModel).TypeHandle, sjYxHO8OWlc6X80hFj7.uWZ8ugU7r5), o4bYL4peNeC2wWb8yjx.oVdpGKjy2x), (MethodInfo)f5q427pRQZnrEKPy4Ws.D35lls5iF((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, f5q427pRQZnrEKPy4Ws.Bo9pk3m4k7), OWBKr5pvc5MWsK1OMtR.fZIpAAdi1v), Array.Empty<ParameterExpression>()), [AsyncStateMachine(typeof(HCWAVj2gWS8W0oIJHm))] () =>
						{
							HCWAVj2gWS8W0oIJHm stateMachine = default(HCWAVj2gWS8W0oIJHm);
							stateMachine.g1U71EnxtO = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
							stateMachine.c0X7J8RQCI = CS_0024_003C_003E8__locals3;
							stateMachine.YLa7gxEbFD = -1;
							stateMachine.g1U71EnxtO.Start(ref stateMachine);
							return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine.g1U71EnxtO, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
						}, W7S2sip6SDieZFVsNbd.XWappgVyfh), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
						if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
						{
							num = (rDQ7l5uMZy = 0);
							vWX727yUAx = awaiter;
							Eox7UAcRQq.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = vWX727yUAx;
						vWX727yUAx = default(TaskAwaiter);
						num = (rDQ7l5uMZy = -1);
					}
					oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
				}
				catch (Exception ex)
				{
					rDQ7l5uMZy = -2;
					N2XUglA3neBsnlZfRPQ.D35lls5iF(ref Eox7UAcRQq, ex, N2XUglA3neBsnlZfRPQ.l4pATRumoW);
					return;
				}
				rDQ7l5uMZy = -2;
				T4XmPoA4VNJJP1afcgL.D35lls5iF(ref Eox7UAcRQq, T4XmPoA4VNJJP1afcgL.TRyALZckCh);
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine P_0)
			{
				dHWo7jAEn6E4X7bsY4R.D35lls5iF(ref Eox7UAcRQq, P_0, dHWo7jAEn6E4X7bsY4R.z3hAB6UZ9o);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine P_0)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(P_0);
			}
		}

		public SeriesViewModel k1NKBm6RVS;

		public CategoryResponseDto mE1KDv8Y1N;

		public Func<Task> ePwKdM8kLf;

		public _003C_003Ec__DisplayClass46_0()
		{
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
			base._002Ector();
		}

		[AsyncStateMachine(typeof(t1ayyHzyaDnrDguvSI))]
		internal void elwKWCakME()
		{
			t1ayyHzyaDnrDguvSI stateMachine = default(t1ayyHzyaDnrDguvSI);
			stateMachine.Eox7UAcRQq = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
			stateMachine.NBa7LpMcHt = this;
			stateMachine.rDQ7l5uMZy = -1;
			stateMachine.Eox7UAcRQq.Start(ref stateMachine);
		}

		[AsyncStateMachine(typeof(HCWAVj2gWS8W0oIJHm))]
		internal Task t1rK4ucHAJ()
		{
			HCWAVj2gWS8W0oIJHm stateMachine = default(HCWAVj2gWS8W0oIJHm);
			stateMachine.g1U71EnxtO = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
			stateMachine.c0X7J8RQCI = this;
			stateMachine.YLa7gxEbFD = -1;
			stateMachine.g1U71EnxtO.Start(ref stateMachine);
			return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine.g1U71EnxtO, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass49_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct nXQKGwjciTbYrF9Jgdf : IAsyncStateMachine
		{
			public int da17zW1xne;

			public AsyncTaskMethodBuilder jOI5ccS3RX;

			public _003C_003Ec__DisplayClass49_0 C2d5jsoX9q;

			private TaskAwaiter jBd5vlqYqa;

			private void MoveNext()
			{
				int num = da17zW1xne;
				_003C_003Ec__DisplayClass49_0 obj = C2d5jsoX9q;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						obj.EeOKIRVEU1.Items.Clear();
						obj.EeOKIRVEU1.SearchQuery.Page = 1;
						if (S1a0wT9Ixre9OpDny8h.D35lls5iF(obj.Yl6KVM9wkY, iFZ5je3XFYKwkvcE5D.D35lls5iF(8566, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO))
						{
							wuXoja6xGA4YsTL6UdU.D35lls5iF(obj.EeOKIRVEU1.SearchQuery.Search, null, wuXoja6xGA4YsTL6UdU.BYhUHIB7NB);
						}
						else
						{
							wuXoja6xGA4YsTL6UdU.D35lls5iF(obj.EeOKIRVEU1.SearchQuery.Search, arHqIuLQE32UGutIac7.D35lls5iF(obj.Yl6KVM9wkY, arHqIuLQE32UGutIac7.Fa2LXljLFk), wuXoja6xGA4YsTL6UdU.BYhUHIB7NB);
						}
						awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(OYihPsCZ1OyLa5m4TD0.D35lls5iF(obj.EeOKIRVEU1, OYihPsCZ1OyLa5m4TD0.bixU9bJWok), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
						if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
						{
							num = (da17zW1xne = 0);
							jBd5vlqYqa = awaiter;
							jOI5ccS3RX.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = jBd5vlqYqa;
						jBd5vlqYqa = default(TaskAwaiter);
						num = (da17zW1xne = -1);
					}
					oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
				}
				catch (Exception ex)
				{
					da17zW1xne = -2;
					NNK1eXA7fWQ87oSUty7.D35lls5iF(ref jOI5ccS3RX, ex, NNK1eXA7fWQ87oSUty7.G3EAcW9Om7);
					return;
				}
				da17zW1xne = -2;
				meFicnAMHIVtdhf671p.D35lls5iF(ref jOI5ccS3RX, meFicnAMHIVtdhf671p.bsDASenQ5I);
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine P_0)
			{
				vxBFJcAKZoecNtbdqxt.D35lls5iF(ref jOI5ccS3RX, P_0, vxBFJcAKZoecNtbdqxt.tuxANdhu18);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine P_0)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(P_0);
			}
		}

		[StructLayout(LayoutKind.Auto)]
		private struct PY5HD7jj9qDhuyTeeug : IAsyncStateMachine
		{
			public int os85WdoOJj;

			public AsyncVoidMethodBuilder B0P54eIkXy;

			public _003C_003Ec__DisplayClass49_0 LP75BVk9Wx;

			private TaskAwaiter lxD5DPvK2W;

			private void MoveNext()
			{
				int num = os85WdoOJj;
				_003C_003Ec__DisplayClass49_0 CS_0024_003C_003E8__locals3 = LP75BVk9Wx;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(W7S2sip6SDieZFVsNbd.D35lls5iF(CS_0024_003C_003E8__locals3.EeOKIRVEU1, Expression.Lambda<Func<bool>>(OWBKr5pvc5MWsK1OMtR.D35lls5iF(o4bYL4peNeC2wWb8yjx.D35lls5iF(CS_0024_003C_003E8__locals3.EeOKIRVEU1, sjYxHO8OWlc6X80hFj7.D35lls5iF(typeof(SeriesViewModel).TypeHandle, sjYxHO8OWlc6X80hFj7.uWZ8ugU7r5), o4bYL4peNeC2wWb8yjx.oVdpGKjy2x), (MethodInfo)f5q427pRQZnrEKPy4Ws.D35lls5iF((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, f5q427pRQZnrEKPy4Ws.Bo9pk3m4k7), OWBKr5pvc5MWsK1OMtR.fZIpAAdi1v), Array.Empty<ParameterExpression>()), [AsyncStateMachine(typeof(nXQKGwjciTbYrF9Jgdf))] () =>
						{
							nXQKGwjciTbYrF9Jgdf stateMachine = default(nXQKGwjciTbYrF9Jgdf);
							stateMachine.jOI5ccS3RX = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
							stateMachine.C2d5jsoX9q = CS_0024_003C_003E8__locals3;
							stateMachine.da17zW1xne = -1;
							stateMachine.jOI5ccS3RX.Start(ref stateMachine);
							return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine.jOI5ccS3RX, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
						}, W7S2sip6SDieZFVsNbd.XWappgVyfh), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
						if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
						{
							num = (os85WdoOJj = 0);
							lxD5DPvK2W = awaiter;
							B0P54eIkXy.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = lxD5DPvK2W;
						lxD5DPvK2W = default(TaskAwaiter);
						num = (os85WdoOJj = -1);
					}
					oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
				}
				catch (Exception ex)
				{
					os85WdoOJj = -2;
					N2XUglA3neBsnlZfRPQ.D35lls5iF(ref B0P54eIkXy, ex, N2XUglA3neBsnlZfRPQ.l4pATRumoW);
					return;
				}
				os85WdoOJj = -2;
				T4XmPoA4VNJJP1afcgL.D35lls5iF(ref B0P54eIkXy, T4XmPoA4VNJJP1afcgL.TRyALZckCh);
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine P_0)
			{
				dHWo7jAEn6E4X7bsY4R.D35lls5iF(ref B0P54eIkXy, P_0, dHWo7jAEn6E4X7bsY4R.z3hAB6UZ9o);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine P_0)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(P_0);
			}
		}

		public SeriesViewModel EeOKIRVEU1;

		public string Yl6KVM9wkY;

		public Func<Task> CqMKaqCS1M;

		public _003C_003Ec__DisplayClass49_0()
		{
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
			base._002Ector();
		}

		[AsyncStateMachine(typeof(PY5HD7jj9qDhuyTeeug))]
		internal void kkVKPiDwSb()
		{
			PY5HD7jj9qDhuyTeeug stateMachine = default(PY5HD7jj9qDhuyTeeug);
			stateMachine.B0P54eIkXy = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
			stateMachine.LP75BVk9Wx = this;
			stateMachine.os85WdoOJj = -1;
			stateMachine.B0P54eIkXy.Start(ref stateMachine);
		}

		[AsyncStateMachine(typeof(nXQKGwjciTbYrF9Jgdf))]
		internal Task jYOKqKZmg7()
		{
			nXQKGwjciTbYrF9Jgdf stateMachine = default(nXQKGwjciTbYrF9Jgdf);
			stateMachine.jOI5ccS3RX = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
			stateMachine.C2d5jsoX9q = this;
			stateMachine.da17zW1xne = -1;
			stateMachine.jOI5ccS3RX.Start(ref stateMachine);
			return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine.jOI5ccS3RX, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLoadCategories_003Ed__51 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public SeriesViewModel _003C_003E4__this;

		private bool _003CtryAgain_003E5__2;

		private object _003C_003E7__wrap2;

		private int _003C_003E7__wrap3;

		private TaskAwaiter<ResponseList<CategoryResponseDto>> _003C_003Eu__1;

		private TaskAwaiter<bool> _003C_003Eu__2;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			SeriesViewModel seriesViewModel = _003C_003E4__this;
			try
			{
				if (num == 0)
				{
					goto IL_003d;
				}
				if (num != 1)
				{
					_003CtryAgain_003E5__2 = true;
					goto IL_0289;
				}
				TaskAwaiter<bool> awaiter = _003C_003Eu__2;
				_003C_003Eu__2 = default(TaskAwaiter<bool>);
				num = (_003C_003E1__state = -1);
				goto IL_024e;
				IL_0282:
				_003C_003E7__wrap2 = null;
				goto IL_0289;
				IL_024e:
				if (awaiter.GetResult())
				{
					_003CtryAgain_003E5__2 = true;
					seriesViewModel.vK9abeU58K = AppContainer.Resolve<ISeasonService>();
					seriesViewModel.WgDanli7IP = AppContainer.Resolve<ISeriesService>();
					seriesViewModel.DIqa7pr8rs = AppContainer.Resolve<IAppService>();
				}
				goto IL_0282;
				IL_003d:
				try
				{
					TaskAwaiter<ResponseList<CategoryResponseDto>> awaiter2;
					if (num != 0)
					{
						IAppService dIqa7pr8rs = seriesViewModel.DIqa7pr8rs;
						ApiQuery<CategorySearch, GeneralSort> obj = new ApiQuery<CategorySearch, GeneralSort>
						{
							Count = -1,
							Sort = GeneralSort.Name
						};
						CategorySearch categorySearch = new CategorySearch();
						PDE695CGbWQ6wS7etBU.D35lls5iF(categorySearch, (spq0gOreqjTFyeVY1nd.D35lls5iF(seriesViewModel.SearchQuery.Search, spq0gOreqjTFyeVY1nd.qoErGd9J4A) != SeriesType.Show) ? CategoryType.Series : CategoryType.Show, PDE695CGbWQ6wS7etBU.rt7CRxAZ59);
						obj.Search = categorySearch;
						obj.Order = SortOrder.Asc;
						awaiter2 = GEHLO0CkuIP8aA9CV10.D35lls5iF(dIqa7pr8rs, obj, GEHLO0CkuIP8aA9CV10.AXeCvbp3sh).GetAwaiter();
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
						_003C_003Eu__1 = default(TaskAwaiter<ResponseList<CategoryResponseDto>>);
						num = (_003C_003E1__state = -1);
					}
					ResponseList<CategoryResponseDto> result = awaiter2.GetResult();
					if (result != null && result.Status)
					{
						fbCfXAT6sNT7gTw1IjA.D35lls5iF(seriesViewModel, result.Data.Result.ToList(), fbCfXAT6sNT7gTw1IjA.eM9dWdmYlA);
						List<CategoryResponseDto> list = hB8t9uC6c022dNynAqg.D35lls5iF(seriesViewModel, hB8t9uC6c022dNynAqg.d9gd59YwiQ);
						CategoryResponseDto categoryResponseDto = new CategoryResponseDto();
						wuXoja6xGA4YsTL6UdU.D35lls5iF(categoryResponseDto, null, wuXoja6xGA4YsTL6UdU.LxQCwZHHRC);
						hH6DVMBvgw3ANNRyBk6.D35lls5iF(categoryResponseDto, iFZ5je3XFYKwkvcE5D.D35lls5iF(16162, iFZ5je3XFYKwkvcE5D.N06TeK0ao), hH6DVMBvgw3ANNRyBk6.HifCCinobp);
						list.Insert(0, categoryResponseDto);
						qni3xrDkAJ3vF35eMav.D35lls5iF(seriesViewModel, iFZ5je3XFYKwkvcE5D.D35lls5iF(16172, iFZ5je3XFYKwkvcE5D.N06TeK0ao), qni3xrDkAJ3vF35eMav.QN6DuDtCWO);
					}
				}
				catch (PROTVException ex)
				{
					_003C_003E7__wrap2 = ex;
					_003C_003E7__wrap3 = 1;
				}
				int num2 = _003C_003E7__wrap3;
				if (num2 == 1 && TNckS5wtLfB2Lk9dYP8.D35lls5iF((PROTVException)_003C_003E7__wrap2, TNckS5wtLfB2Lk9dYP8.oGkwV3iq3t) == ExceptionType.AuthorizationTokenInvalid)
				{
					awaiter = bAA7Sxw7vZsvusOmDea.D35lls5iF(AppContainer.Resolve<MainViewModel>(), bAA7Sxw7vZsvusOmDea.gytwc9U7r5).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_003C_003E1__state = 1);
						_003C_003Eu__2 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_024e;
				}
				goto IL_0282;
				IL_0289:
				if (_003CtryAgain_003E5__2)
				{
					_003CtryAgain_003E5__2 = false;
					_003C_003E7__wrap3 = 0;
					goto IL_003d;
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
	private struct _003CLoadLanguages_003Ed__52 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public SeriesViewModel _003C_003E4__this;

		private bool _003CtryAgain_003E5__2;

		private object _003C_003E7__wrap2;

		private int _003C_003E7__wrap3;

		private TaskAwaiter<Response<List<LanguageResponseDto>>> _003C_003Eu__1;

		private TaskAwaiter<bool> _003C_003Eu__2;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			SeriesViewModel seriesViewModel = _003C_003E4__this;
			try
			{
				if (num == 0)
				{
					goto IL_003d;
				}
				if (num != 1)
				{
					_003CtryAgain_003E5__2 = true;
					goto IL_01fc;
				}
				TaskAwaiter<bool> awaiter = _003C_003Eu__2;
				_003C_003Eu__2 = default(TaskAwaiter<bool>);
				num = (_003C_003E1__state = -1);
				goto IL_01c1;
				IL_01f5:
				_003C_003E7__wrap2 = null;
				goto IL_01fc;
				IL_01c1:
				if (awaiter.GetResult())
				{
					_003CtryAgain_003E5__2 = true;
					seriesViewModel.vK9abeU58K = AppContainer.Resolve<ISeasonService>();
					seriesViewModel.WgDanli7IP = AppContainer.Resolve<ISeriesService>();
					seriesViewModel.DIqa7pr8rs = AppContainer.Resolve<IAppService>();
				}
				goto IL_01f5;
				IL_003d:
				try
				{
					TaskAwaiter<Response<List<LanguageResponseDto>>> awaiter2;
					if (num != 0)
					{
						awaiter2 = JpDxOxCmce3lXyrJfoD.D35lls5iF(seriesViewModel.DIqa7pr8rs, JpDxOxCmce3lXyrJfoD.e1qCaQE3F1).GetAwaiter();
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
						_003C_003Eu__1 = default(TaskAwaiter<Response<List<LanguageResponseDto>>>);
						num = (_003C_003E1__state = -1);
					}
					Response<List<LanguageResponseDto>> result = awaiter2.GetResult();
					if (result != null && result.Status)
					{
						CLLqb8CIn0YcxaJaY92.D35lls5iF(seriesViewModel, result.Data, CLLqb8CIn0YcxaJaY92.PwGdzG7ww2);
						List<LanguageResponseDto> list = C7l25jCU6VYRwoJcihE.D35lls5iF(seriesViewModel, C7l25jCU6VYRwoJcihE.owFUon0cMc);
						LanguageResponseDto languageResponseDto = new LanguageResponseDto();
						hH6DVMBvgw3ANNRyBk6.D35lls5iF(languageResponseDto, iFZ5je3XFYKwkvcE5D.D35lls5iF(16162, iFZ5je3XFYKwkvcE5D.N06TeK0ao), hH6DVMBvgw3ANNRyBk6.XuyCVW7uIV);
						list.Insert(0, languageResponseDto);
						qni3xrDkAJ3vF35eMav.D35lls5iF(seriesViewModel, iFZ5je3XFYKwkvcE5D.D35lls5iF(16196, iFZ5je3XFYKwkvcE5D.N06TeK0ao), qni3xrDkAJ3vF35eMav.QN6DuDtCWO);
					}
				}
				catch (PROTVException ex)
				{
					_003C_003E7__wrap2 = ex;
					_003C_003E7__wrap3 = 1;
				}
				int num2 = _003C_003E7__wrap3;
				if (num2 == 1 && TNckS5wtLfB2Lk9dYP8.D35lls5iF((PROTVException)_003C_003E7__wrap2, TNckS5wtLfB2Lk9dYP8.oGkwV3iq3t) == ExceptionType.AuthorizationTokenInvalid)
				{
					awaiter = bAA7Sxw7vZsvusOmDea.D35lls5iF(AppContainer.Resolve<MainViewModel>(), bAA7Sxw7vZsvusOmDea.gytwc9U7r5).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_003C_003E1__state = 1);
						_003C_003Eu__2 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_01c1;
				}
				goto IL_01f5;
				IL_01fc:
				if (_003CtryAgain_003E5__2)
				{
					_003CtryAgain_003E5__2 = false;
					_003C_003E7__wrap3 = 0;
					goto IL_003d;
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
	private struct _003CLoadSerieAfterSearch_003Ed__53 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public SeriesViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			SeriesViewModel seriesViewModel = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					seriesViewModel.Items.Clear();
					seriesViewModel.SearchQuery.Page = 1;
					seriesViewModel.SearchQuery.Count = 25;
					hH6DVMBvgw3ANNRyBk6.D35lls5iF(seriesViewModel.SearchQuery.Search, eVlRnEIaHT0dqvCx0Kx.D35lls5iF(seriesViewModel, eVlRnEIaHT0dqvCx0Kx.IlqUlEvhVP), hH6DVMBvgw3ANNRyBk6.RRK6ishEFm);
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(OYihPsCZ1OyLa5m4TD0.D35lls5iF(seriesViewModel, OYihPsCZ1OyLa5m4TD0.bixU9bJWok), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
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
	private struct _003CLoadSeries_003Ed__54 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public SeriesViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			SeriesViewModel seriesViewModel = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					seriesViewModel.Items.Clear();
					seriesViewModel.SearchQuery.Page = 1;
					seriesViewModel.SearchQuery.Count = 25;
					seriesViewModel.SearchQuery.Sort = SeriesSort.ActivateDate;
					seriesViewModel.SearchQuery.Order = SortOrder.Desc;
					wuXoja6xGA4YsTL6UdU.D35lls5iF(seriesViewModel.SearchQuery.Search, null, wuXoja6xGA4YsTL6UdU.TqYUDRHIBK);
					wuXoja6xGA4YsTL6UdU.D35lls5iF(seriesViewModel.SearchQuery.Search, null, wuXoja6xGA4YsTL6UdU.BYhUHIB7NB);
					hH6DVMBvgw3ANNRyBk6.D35lls5iF(seriesViewModel.SearchQuery.Search, null, hH6DVMBvgw3ANNRyBk6.RRK6ishEFm);
					lASFo76QIUBEikAAsE9.D35lls5iF(seriesViewModel.SearchQuery.Search, null, lASFo76QIUBEikAAsE9.UMA6X462Ew);
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(OYihPsCZ1OyLa5m4TD0.D35lls5iF(seriesViewModel, OYihPsCZ1OyLa5m4TD0.bixU9bJWok), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
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
	private struct _003COnFetchMoreDataCommand_003Ed__56 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public SeriesViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			SeriesViewModel seriesViewModel = _003C_003E4__this;
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
				if (seriesViewModel.CurrentPage < seriesViewModel.TotalCount && !hjMnupQVVDlRZAYQJC.D35lls5iF(seriesViewModel, hjMnupQVVDlRZAYQJC.jJYTSHn9tB))
				{
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(seriesViewModel.AddMoreItems(), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
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
	private struct _003CAddMoreItems_003Ed__58 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public SeriesViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			SeriesViewModel CS_0024_003C_003E8__locals5 = _003C_003E4__this;
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
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(W7S2sip6SDieZFVsNbd.D35lls5iF(CS_0024_003C_003E8__locals5, Expression.Lambda<Func<bool>>(OWBKr5pvc5MWsK1OMtR.D35lls5iF(o4bYL4peNeC2wWb8yjx.D35lls5iF(CS_0024_003C_003E8__locals5, sjYxHO8OWlc6X80hFj7.D35lls5iF(typeof(SeriesViewModel).TypeHandle, sjYxHO8OWlc6X80hFj7.uWZ8ugU7r5), o4bYL4peNeC2wWb8yjx.oVdpGKjy2x), (MethodInfo)f5q427pRQZnrEKPy4Ws.D35lls5iF((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, f5q427pRQZnrEKPy4Ws.Bo9pk3m4k7), OWBKr5pvc5MWsK1OMtR.fZIpAAdi1v), Array.Empty<ParameterExpression>()), [AsyncStateMachine(typeof(_003C_003CAddMoreItems_003Eb__58_1_003Ed))] () =>
					{
						_003C_003CAddMoreItems_003Eb__58_1_003Ed stateMachine = default(_003C_003CAddMoreItems_003Eb__58_1_003Ed);
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
	private struct _003CGoToPage_003Ed__59 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public BaseMediaDto model;

		public SeriesViewModel _003C_003E4__this;

		private HomeViewModel _003ChomeViewModel_003E5__2;

		private Page _003Cpage_003E5__3;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			SeriesViewModel seriesViewModel = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				switch (num)
				{
				default:
					if (m9MGZR7k2RmVqYXYS5.D35lls5iF(model, m9MGZR7k2RmVqYXYS5.j871CQO7pP) > 0 && UOCWOF1pc2UOe4PjABW.D35lls5iF(model, UOCWOF1pc2UOe4PjABW.TuV1w2E8GR) == MediaType.Series)
					{
						_003ChomeViewModel_003E5__2 = Sp7dKWL9ZfBld4JOkGo.D35lls5iF(AppContainer.Resolve<MainViewModel>(), Sp7dKWL9ZfBld4JOkGo.QpWwMTMAhO) as HomeViewModel;
						SeriesItemViewModel viewModel = new SeriesItemViewModel(model as SeriesResponseDto);
						Page page = new Page();
						KBhlAv9D2TgBJ1kkc0B.D35lls5iF(page, IyGDDwHBiPv8vfOFJDF.D35lls5iF(ApplicationPage.SeriesDetailsPage, viewModel, IyGDDwHBiPv8vfOFJDF.hivH0XYhaE), KBhlAv9D2TgBJ1kkc0B.fWUHrWO7Sa);
						qni3xrDkAJ3vF35eMav.D35lls5iF(page, QQLie3eYkZwbFFm9Jjw.D35lls5iF(model as SeriesResponseDto, QQLie3eYkZwbFFm9Jjw.D7uwK6SQ7w), qni3xrDkAJ3vF35eMav.Ra7HRFTvnD);
						_003Cpage_003E5__3 = page;
						awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(pvrKKy8Mk1kpdmIfp3A.D35lls5iF(5, pvrKKy8Mk1kpdmIfp3A.aVh8SPrFkE), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
						if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
						{
							num = (_003C_003E1__state = 0);
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_0127;
					}
					if (m9MGZR7k2RmVqYXYS5.D35lls5iF(model, m9MGZR7k2RmVqYXYS5.j871CQO7pP) > 0 && UOCWOF1pc2UOe4PjABW.D35lls5iF(model, UOCWOF1pc2UOe4PjABW.TuV1w2E8GR) == MediaType.Season)
					{
						_003ChomeViewModel_003E5__2 = Sp7dKWL9ZfBld4JOkGo.D35lls5iF(AppContainer.Resolve<MainViewModel>(), Sp7dKWL9ZfBld4JOkGo.QpWwMTMAhO) as HomeViewModel;
						SeriesItemViewModel viewModel2 = new SeriesItemViewModel(model as SeasonResponseDto);
						Page page2 = new Page();
						KBhlAv9D2TgBJ1kkc0B.D35lls5iF(page2, IyGDDwHBiPv8vfOFJDF.D35lls5iF(ApplicationPage.SeriesDetailsPage, viewModel2, IyGDDwHBiPv8vfOFJDF.hivH0XYhaE), KBhlAv9D2TgBJ1kkc0B.fWUHrWO7Sa);
						qni3xrDkAJ3vF35eMav.D35lls5iF(page2, eVlRnEIaHT0dqvCx0Kx.D35lls5iF(model as SeasonResponseDto, eVlRnEIaHT0dqvCx0Kx.eTUU1nC6Mb), qni3xrDkAJ3vF35eMav.Ra7HRFTvnD);
						_003Cpage_003E5__3 = page2;
						awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(pvrKKy8Mk1kpdmIfp3A.D35lls5iF(5, pvrKKy8Mk1kpdmIfp3A.aVh8SPrFkE), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
						if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
						{
							num = (_003C_003E1__state = 1);
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_0269;
					}
					if (m9MGZR7k2RmVqYXYS5.D35lls5iF(model, m9MGZR7k2RmVqYXYS5.j871CQO7pP) > 0 && UOCWOF1pc2UOe4PjABW.D35lls5iF(model, UOCWOF1pc2UOe4PjABW.TuV1w2E8GR) == MediaType.Episode)
					{
						Sp7dKWL9ZfBld4JOkGo.D35lls5iF(AppContainer.Resolve<MainViewModel>(), Sp7dKWL9ZfBld4JOkGo.QpWwMTMAhO);
						SereisPlayerViewModel viewModel3 = new SereisPlayerViewModel(model as EpisodeResponseDto);
						Page page3 = new Page();
						KBhlAv9D2TgBJ1kkc0B.D35lls5iF(page3, IyGDDwHBiPv8vfOFJDF.D35lls5iF(ApplicationPage.ShowSeriesPage, viewModel3, IyGDDwHBiPv8vfOFJDF.hivH0XYhaE), KBhlAv9D2TgBJ1kkc0B.fWUHrWO7Sa);
						qni3xrDkAJ3vF35eMav.D35lls5iF(page3, EBgwuVHeVLDJVVfMaAk.D35lls5iF(ApplicationPage.ShowSeriesPage, EBgwuVHeVLDJVVfMaAk.mtcHG3MEy3), qni3xrDkAJ3vF35eMav.Ra7HRFTvnD);
						_003Cpage_003E5__3 = page3;
						awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(pvrKKy8Mk1kpdmIfp3A.D35lls5iF(5, pvrKKy8Mk1kpdmIfp3A.aVh8SPrFkE), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
						if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
						{
							num = (_003C_003E1__state = 2);
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						break;
					}
					goto end_IL_0015;
				case 0:
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_0127;
				case 1:
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_0269;
				case 2:
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter);
						num = (_003C_003E1__state = -1);
						break;
					}
					IL_0127:
					oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
					GmMLaTD7kV8rq88ZFvR.D35lls5iF(Xlypb0Hnr2C3ydrYEdG.D35lls5iF(_003ChomeViewModel_003E5__2, Xlypb0Hnr2C3ydrYEdG.U3Z1IKMGuZ), _003Cpage_003E5__3, GmMLaTD7kV8rq88ZFvR.iMJHkmaaRY);
					_003ChomeViewModel_003E5__2 = null;
					_003Cpage_003E5__3 = null;
					goto end_IL_0015;
					IL_0269:
					oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
					GmMLaTD7kV8rq88ZFvR.D35lls5iF(Xlypb0Hnr2C3ydrYEdG.D35lls5iF(_003ChomeViewModel_003E5__2, Xlypb0Hnr2C3ydrYEdG.U3Z1IKMGuZ), _003Cpage_003E5__3, GmMLaTD7kV8rq88ZFvR.iMJHkmaaRY);
					_003ChomeViewModel_003E5__2 = null;
					_003Cpage_003E5__3 = null;
					goto end_IL_0015;
				}
				oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
				GmMLaTD7kV8rq88ZFvR.D35lls5iF(Xlypb0Hnr2C3ydrYEdG.D35lls5iF(seriesViewModel.l9xauh2ary, Xlypb0Hnr2C3ydrYEdG.U3Z1IKMGuZ), _003Cpage_003E5__3, GmMLaTD7kV8rq88ZFvR.iMJHkmaaRY);
				_003Cpage_003E5__3 = null;
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
	private struct _003CLoadAsync_003Ed__61 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public SeriesViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			SeriesViewModel CS_0024_003C_003E8__locals3 = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(W7S2sip6SDieZFVsNbd.D35lls5iF(CS_0024_003C_003E8__locals3, Expression.Lambda<Func<bool>>(OWBKr5pvc5MWsK1OMtR.D35lls5iF(o4bYL4peNeC2wWb8yjx.D35lls5iF(CS_0024_003C_003E8__locals3, sjYxHO8OWlc6X80hFj7.D35lls5iF(typeof(SeriesViewModel).TypeHandle, sjYxHO8OWlc6X80hFj7.uWZ8ugU7r5), o4bYL4peNeC2wWb8yjx.oVdpGKjy2x), (MethodInfo)f5q427pRQZnrEKPy4Ws.D35lls5iF((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, f5q427pRQZnrEKPy4Ws.Bo9pk3m4k7), OWBKr5pvc5MWsK1OMtR.fZIpAAdi1v), Array.Empty<ParameterExpression>()), [AsyncStateMachine(typeof(_003C_003CLoadAsync_003Eb__61_1_003Ed))] () =>
					{
						_003C_003CLoadAsync_003Eb__61_1_003Ed stateMachine = default(_003C_003CLoadAsync_003Eb__61_1_003Ed);
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
	private struct _003CAddItems_003Ed__62 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public SeriesViewModel _003C_003E4__this;

		private object _003C_003E7__wrap1;

		private int _003C_003E7__wrap2;

		private ResponseList<SeriesResponseDto> _003Cresult_003E5__4;

		private TaskAwaiter<ResponseList<SeriesResponseDto>> _003C_003Eu__1;

		private IEnumerator<SeriesResponseDto> _003C_003E7__wrap4;

		private SeriesResponseDto _003Citem_003E5__6;

		private TaskAwaiter _003C_003Eu__2;

		private ResponseList<SeasonResponseDto> _003Cresult_003E5__7;

		private TaskAwaiter<ResponseList<SeasonResponseDto>> _003C_003Eu__3;

		private IEnumerator<SeasonResponseDto> _003C_003E7__wrap7;

		private SeasonResponseDto _003Citem_003E5__9;

		private ResponseList<EpisodeResponseDto> _003Cresult_003E5__10;

		private TaskAwaiter<ResponseList<EpisodeResponseDto>> _003C_003Eu__4;

		private IEnumerator<EpisodeResponseDto> _003C_003E7__wrap10;

		private EpisodeResponseDto _003Citem_003E5__12;

		private TaskAwaiter<bool> _003C_003Eu__5;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			SeriesViewModel seriesViewModel = _003C_003E4__this;
			try
			{
				TaskAwaiter<bool> awaiter;
				if ((uint)num > 5u)
				{
					if (num == 6)
					{
						awaiter = _003C_003Eu__5;
						_003C_003Eu__5 = default(TaskAwaiter<bool>);
						num = (_003C_003E1__state = -1);
						goto IL_07a2;
					}
					_003C_003E7__wrap2 = 0;
				}
				try
				{
					TaskAwaiter<ResponseList<SeriesResponseDto>> awaiter4;
					TaskAwaiter<ResponseList<SeasonResponseDto>> awaiter3;
					TaskAwaiter<ResponseList<EpisodeResponseDto>> awaiter2;
					ResponseList<SeriesResponseDto> result;
					ResponseList<EpisodeResponseDto> result2;
					ResponseList<SeasonResponseDto> result3;
					switch (num)
					{
					default:
						if (S1a0wT9Ixre9OpDny8h.D35lls5iF(seriesViewModel.dtNa6Rjod9, iFZ5je3XFYKwkvcE5D.D35lls5iF(9308, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO))
						{
							awaiter4 = sOOWwvU8coSrQjpWhkn.D35lls5iF(seriesViewModel.WgDanli7IP, seriesViewModel.SearchQuery, sOOWwvU8coSrQjpWhkn.dhvUnAYI7l).GetAwaiter();
							if (!awaiter4.IsCompleted)
							{
								num = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter4;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
								return;
							}
							goto IL_00d4;
						}
						if (S1a0wT9Ixre9OpDny8h.D35lls5iF(seriesViewModel.dtNa6Rjod9, iFZ5je3XFYKwkvcE5D.D35lls5iF(11816, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO))
						{
							awaiter3 = J4LLFpU3bE9nxch3s5K.D35lls5iF(seriesViewModel.vK9abeU58K, seriesViewModel.SearchQuery, J4LLFpU3bE9nxch3s5K.qYMUTsJ76u).GetAwaiter();
							if (!awaiter3.IsCompleted)
							{
								num = (_003C_003E1__state = 2);
								_003C_003Eu__3 = awaiter3;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
								return;
							}
							goto IL_031c;
						}
						awaiter2 = Hq6KPLdkBfHppWOifxV.D35lls5iF(seriesViewModel.vK9abeU58K, seriesViewModel.SearchQuery, Hq6KPLdkBfHppWOifxV.wMgdv0gLrD).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = (_003C_003E1__state = 4);
							_003C_003Eu__4 = awaiter2;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						}
						goto IL_0542;
					case 0:
						awaiter4 = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter<ResponseList<SeriesResponseDto>>);
						num = (_003C_003E1__state = -1);
						goto IL_00d4;
					case 1:
						try
						{
							if (num != 1)
							{
								goto IL_01c4;
							}
							TaskAwaiter awaiter5 = _003C_003Eu__2;
							_003C_003Eu__2 = default(TaskAwaiter);
							num = (_003C_003E1__state = -1);
							goto IL_01a0;
							IL_01a0:
							oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter5, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
							seriesViewModel.Items.Add(_003Citem_003E5__6);
							_003Citem_003E5__6 = null;
							goto IL_01c4;
							IL_01c4:
							if (hjMnupQVVDlRZAYQJC.D35lls5iF(_003C_003E7__wrap4, hjMnupQVVDlRZAYQJC.QV1TFwytOj))
							{
								_003Citem_003E5__6 = _003C_003E7__wrap4.Current;
								awaiter5 = QliBEUviwWqgtMcBndV.D35lls5iF(pvrKKy8Mk1kpdmIfp3A.D35lls5iF(2, pvrKKy8Mk1kpdmIfp3A.aVh8SPrFkE), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
								if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter5, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
								{
									num = (_003C_003E1__state = 1);
									_003C_003Eu__2 = awaiter5;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter5, ref this);
									return;
								}
								goto IL_01a0;
							}
						}
						finally
						{
							if (num < 0 && _003C_003E7__wrap4 != null)
							{
								xLO56JniGyickVjO1Ot.D35lls5iF(_003C_003E7__wrap4, xLO56JniGyickVjO1Ot.ydbT2bsoH4);
							}
						}
						_003C_003E7__wrap4 = null;
						seriesViewModel.CurrentPage = _003Cresult_003E5__4.Data.CurrentPage;
						seriesViewModel.PageCount = _003Cresult_003E5__4.Data.PageCount;
						seriesViewModel.TotalCount = _003Cresult_003E5__4.Data.Total;
						goto IL_0282;
					case 2:
						awaiter3 = _003C_003Eu__3;
						_003C_003Eu__3 = default(TaskAwaiter<ResponseList<SeasonResponseDto>>);
						num = (_003C_003E1__state = -1);
						goto IL_031c;
					case 3:
						try
						{
							if (num != 3)
							{
								goto IL_040e;
							}
							TaskAwaiter awaiter5 = _003C_003Eu__2;
							_003C_003Eu__2 = default(TaskAwaiter);
							num = (_003C_003E1__state = -1);
							goto IL_03ea;
							IL_03ea:
							oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter5, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
							seriesViewModel.Items.Add(_003Citem_003E5__9);
							_003Citem_003E5__9 = null;
							goto IL_040e;
							IL_040e:
							if (hjMnupQVVDlRZAYQJC.D35lls5iF(_003C_003E7__wrap7, hjMnupQVVDlRZAYQJC.QV1TFwytOj))
							{
								_003Citem_003E5__9 = _003C_003E7__wrap7.Current;
								awaiter5 = QliBEUviwWqgtMcBndV.D35lls5iF(pvrKKy8Mk1kpdmIfp3A.D35lls5iF(2, pvrKKy8Mk1kpdmIfp3A.aVh8SPrFkE), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
								if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter5, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
								{
									num = (_003C_003E1__state = 3);
									_003C_003Eu__2 = awaiter5;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter5, ref this);
									return;
								}
								goto IL_03ea;
							}
						}
						finally
						{
							if (num < 0 && _003C_003E7__wrap7 != null)
							{
								xLO56JniGyickVjO1Ot.D35lls5iF(_003C_003E7__wrap7, xLO56JniGyickVjO1Ot.ydbT2bsoH4);
							}
						}
						_003C_003E7__wrap7 = null;
						seriesViewModel.CurrentPage = _003Cresult_003E5__7.Data.CurrentPage;
						seriesViewModel.PageCount = _003Cresult_003E5__7.Data.PageCount;
						seriesViewModel.TotalCount = _003Cresult_003E5__7.Data.Total;
						goto IL_04cc;
					case 4:
						awaiter2 = _003C_003Eu__4;
						_003C_003Eu__4 = default(TaskAwaiter<ResponseList<EpisodeResponseDto>>);
						num = (_003C_003E1__state = -1);
						goto IL_0542;
					case 5:
						{
							try
							{
								if (num != 5)
								{
									goto IL_0634;
								}
								TaskAwaiter awaiter5 = _003C_003Eu__2;
								_003C_003Eu__2 = default(TaskAwaiter);
								num = (_003C_003E1__state = -1);
								goto IL_0610;
								IL_0610:
								oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter5, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
								seriesViewModel.Items.Add(_003Citem_003E5__12);
								_003Citem_003E5__12 = null;
								goto IL_0634;
								IL_0634:
								if (hjMnupQVVDlRZAYQJC.D35lls5iF(_003C_003E7__wrap10, hjMnupQVVDlRZAYQJC.QV1TFwytOj))
								{
									_003Citem_003E5__12 = _003C_003E7__wrap10.Current;
									awaiter5 = QliBEUviwWqgtMcBndV.D35lls5iF(pvrKKy8Mk1kpdmIfp3A.D35lls5iF(2, pvrKKy8Mk1kpdmIfp3A.aVh8SPrFkE), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
									if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter5, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
									{
										num = (_003C_003E1__state = 5);
										_003C_003Eu__2 = awaiter5;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter5, ref this);
										return;
									}
									goto IL_0610;
								}
							}
							finally
							{
								if (num < 0 && _003C_003E7__wrap10 != null)
								{
									xLO56JniGyickVjO1Ot.D35lls5iF(_003C_003E7__wrap10, xLO56JniGyickVjO1Ot.ydbT2bsoH4);
								}
							}
							_003C_003E7__wrap10 = null;
							seriesViewModel.CurrentPage = _003Cresult_003E5__10.Data.CurrentPage;
							seriesViewModel.PageCount = _003Cresult_003E5__10.Data.PageCount;
							seriesViewModel.TotalCount = _003Cresult_003E5__10.Data.Total;
							break;
						}
						IL_0282:
						_003Cresult_003E5__4 = null;
						goto end_IL_002b;
						IL_00d4:
						result = awaiter4.GetResult();
						_003Cresult_003E5__4 = result;
						if (_003Cresult_003E5__4 != null && _003Cresult_003E5__4.Status)
						{
							_003C_003E7__wrap4 = _003Cresult_003E5__4.Data.Result.GetEnumerator();
							goto case 1;
						}
						if (seriesViewModel.Items.Count == 0)
						{
							seriesViewModel.TotalCount = 0;
						}
						else
						{
							seriesViewModel.SearchQuery.Page--;
						}
						goto IL_0282;
						IL_0542:
						result2 = awaiter2.GetResult();
						_003Cresult_003E5__10 = result2;
						if (_003Cresult_003E5__10 != null && _003Cresult_003E5__10.Status)
						{
							_003C_003E7__wrap10 = _003Cresult_003E5__10.Data.Result.GetEnumerator();
							goto case 5;
						}
						if (seriesViewModel.Items.Count == 0)
						{
							seriesViewModel.TotalCount = 0;
						}
						else
						{
							seriesViewModel.SearchQuery.Page--;
						}
						break;
						IL_031c:
						result3 = awaiter3.GetResult();
						_003Cresult_003E5__7 = result3;
						if (_003Cresult_003E5__7 != null && _003Cresult_003E5__7.Status)
						{
							_003C_003E7__wrap7 = _003Cresult_003E5__7.Data.Result.GetEnumerator();
							goto case 3;
						}
						if (seriesViewModel.Items.Count == 0)
						{
							seriesViewModel.TotalCount = 0;
						}
						else
						{
							seriesViewModel.SearchQuery.Page--;
						}
						goto IL_04cc;
						IL_04cc:
						_003Cresult_003E5__7 = null;
						goto end_IL_002b;
					}
					_003Cresult_003E5__10 = null;
					end_IL_002b:;
				}
				catch (PROTVException ex)
				{
					_003C_003E7__wrap1 = ex;
					_003C_003E7__wrap2 = 1;
				}
				int num2 = _003C_003E7__wrap2;
				if (num2 == 1)
				{
					if (TNckS5wtLfB2Lk9dYP8.D35lls5iF((PROTVException)_003C_003E7__wrap1, TNckS5wtLfB2Lk9dYP8.oGkwV3iq3t) == ExceptionType.AuthorizationTokenInvalid)
					{
						awaiter = bAA7Sxw7vZsvusOmDea.D35lls5iF(AppContainer.Resolve<MainViewModel>(), bAA7Sxw7vZsvusOmDea.gytwc9U7r5).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (_003C_003E1__state = 6);
							_003C_003Eu__5 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_07a2;
					}
					if (seriesViewModel.Items.Count == 0)
					{
						seriesViewModel.TotalCount = 0;
					}
					else
					{
						seriesViewModel.SearchQuery.Page--;
					}
				}
				goto IL_0807;
				IL_07a2:
				if (awaiter.GetResult())
				{
					seriesViewModel.vK9abeU58K = AppContainer.Resolve<ISeasonService>();
					seriesViewModel.WgDanli7IP = AppContainer.Resolve<ISeriesService>();
					seriesViewModel.DIqa7pr8rs = AppContainer.Resolve<IAppService>();
				}
				goto IL_0807;
				IL_0807:
				_003C_003E7__wrap1 = null;
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
	private struct _003C_003CAddMoreItems_003Eb__58_1_003Ed : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public SeriesViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			SeriesViewModel seriesViewModel = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					seriesViewModel.SearchQuery.Page++;
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(OYihPsCZ1OyLa5m4TD0.D35lls5iF(seriesViewModel, OYihPsCZ1OyLa5m4TD0.bixU9bJWok), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
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
	private struct _003C_003CLoadAsync_003Eb__61_1_003Ed : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public SeriesViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			SeriesViewModel seriesViewModel = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(VrVteFCs0OCGBTVr1mZ.D35lls5iF(new Task[3]
					{
						OYihPsCZ1OyLa5m4TD0.D35lls5iF(seriesViewModel, OYihPsCZ1OyLa5m4TD0.L8rU4d79hZ),
						OYihPsCZ1OyLa5m4TD0.D35lls5iF(seriesViewModel, OYihPsCZ1OyLa5m4TD0.qpWULrATcs),
						OYihPsCZ1OyLa5m4TD0.D35lls5iF(seriesViewModel, OYihPsCZ1OyLa5m4TD0.qi2UElFqjO)
					}, VrVteFCs0OCGBTVr1mZ.qNlChUR2Cs), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
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

	private ISeriesService WgDanli7IP;

	private ISeasonService vK9abeU58K;

	private IAppService DIqa7pr8rs;

	private readonly MainViewModel q9ia5ZC5i7;

	private readonly HomeViewModel l9xauh2ary;

	private readonly IStoreContext k9OaANRZRO;

	private LanguageResponseDto lYJaNFNfnv;

	private SortOrder pK5aMB2tE9;

	private SeriesSort kpeaCZqiCA;

	private CategoryResponseDto F2saYsSvJG;

	private string rtxaFAnSFY;

	private string dtNa6Rjod9;

	[CompilerGenerated]
	private string lGcaswFbZZ;

	[CompilerGenerated]
	private List<LanguageResponseDto> hoUaxYj42f;

	[CompilerGenerated]
	private List<string> yOpayUqhcS;

	[CompilerGenerated]
	private List<SeriesSort> yiqapfhYTW;

	[CompilerGenerated]
	private List<CategoryResponseDto> tg2aih1Kvg;

	public string Search
	{
		[CompilerGenerated]
		get
		{
			return lGcaswFbZZ;
		}
		[CompilerGenerated]
		internal set
		{
			lGcaswFbZZ = value;
		}
	}

	public List<LanguageResponseDto> Languages
	{
		[CompilerGenerated]
		get
		{
			return hoUaxYj42f;
		}
		[CompilerGenerated]
		set
		{
			hoUaxYj42f = value;
		}
	}

	public List<string> Groups
	{
		[CompilerGenerated]
		get
		{
			return yOpayUqhcS;
		}
		[CompilerGenerated]
		set
		{
			yOpayUqhcS = value;
		}
	}

	public List<SeriesSort> SortItems
	{
		[CompilerGenerated]
		get
		{
			return yiqapfhYTW;
		}
		[CompilerGenerated]
		set
		{
			yiqapfhYTW = value;
		}
	}

	public List<CategoryResponseDto> Categories
	{
		[CompilerGenerated]
		get
		{
			return tg2aih1Kvg;
		}
		[CompilerGenerated]
		set
		{
			tg2aih1Kvg = value;
		}
	}

	public string SelectedGroup
	{
		get
		{
			return dtNa6Rjod9;
		}
		set
		{
			_003C_003Ec__DisplayClass34_0 CS_0024_003C_003E8__locals4 = new _003C_003Ec__DisplayClass34_0();
			CS_0024_003C_003E8__locals4.nDMf9Ljtj0 = this;
			CS_0024_003C_003E8__locals4.NZwfesextp = value;
			SetProperty(ref dtNa6Rjod9, CS_0024_003C_003E8__locals4.NZwfesextp, iFZ5je3XFYKwkvcE5D.D35lls5iF(11786, iFZ5je3XFYKwkvcE5D.N06TeK0ao), null, [AsyncStateMachine(typeof(_003C_003Ec__DisplayClass34_0.YRf4n7grvTWJBIumWC))] () =>
			{
				_003C_003Ec__DisplayClass34_0.YRf4n7grvTWJBIumWC stateMachine = default(_003C_003Ec__DisplayClass34_0.YRf4n7grvTWJBIumWC);
				stateMachine.npN77FkA8Y = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
				stateMachine.owt75qZpYF = CS_0024_003C_003E8__locals4;
				stateMachine.zjN7bAVBuE = -1;
				stateMachine.npN77FkA8Y.Start(ref stateMachine);
			});
		}
	}

	public LanguageResponseDto SelectedLanguage
	{
		get
		{
			return lYJaNFNfnv;
		}
		set
		{
			_003C_003Ec__DisplayClass37_0 CS_0024_003C_003E8__locals4 = new _003C_003Ec__DisplayClass37_0();
			CS_0024_003C_003E8__locals4.xHWfoSIlMe = this;
			CS_0024_003C_003E8__locals4.sdEfgWStD0 = value;
			SetProperty(ref lYJaNFNfnv, CS_0024_003C_003E8__locals4.sdEfgWStD0, iFZ5je3XFYKwkvcE5D.D35lls5iF(10186, iFZ5je3XFYKwkvcE5D.N06TeK0ao), null, [AsyncStateMachine(typeof(_003C_003Ec__DisplayClass37_0.HL4SVaJEsW5ORd8dqo))] () =>
			{
				_003C_003Ec__DisplayClass37_0.HL4SVaJEsW5ORd8dqo stateMachine = default(_003C_003Ec__DisplayClass37_0.HL4SVaJEsW5ORd8dqo);
				stateMachine.LbR7FEiX7v = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
				stateMachine.zI676kFCyL = CS_0024_003C_003E8__locals4;
				stateMachine.H357YuI4xd = -1;
				stateMachine.LbR7FEiX7v.Start(ref stateMachine);
			});
		}
	}

	public SortOrder SelectedOrder
	{
		get
		{
			return pK5aMB2tE9;
		}
		set
		{
			_003C_003Ec__DisplayClass40_0 CS_0024_003C_003E8__locals4 = new _003C_003Ec__DisplayClass40_0();
			CS_0024_003C_003E8__locals4.ek8flNpo4n = this;
			CS_0024_003C_003E8__locals4.JaNfUQkJss = value;
			SetProperty(ref pK5aMB2tE9, CS_0024_003C_003E8__locals4.JaNfUQkJss, iFZ5je3XFYKwkvcE5D.D35lls5iF(8208, iFZ5je3XFYKwkvcE5D.N06TeK0ao), null, [AsyncStateMachine(typeof(_003C_003Ec__DisplayClass40_0.uMntyHl2Lw9S3qmq19))] () =>
			{
				_003C_003Ec__DisplayClass40_0.uMntyHl2Lw9S3qmq19 stateMachine = default(_003C_003Ec__DisplayClass40_0.uMntyHl2Lw9S3qmq19);
				stateMachine.E0T7m8q4PU = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
				stateMachine.mfF7Xc7GZD = CS_0024_003C_003E8__locals4;
				stateMachine.wfr735n1NY = -1;
				stateMachine.E0T7m8q4PU.Start(ref stateMachine);
			});
		}
	}

	public SeriesSort SelectedSort
	{
		get
		{
			return kpeaCZqiCA;
		}
		set
		{
			_003C_003Ec__DisplayClass43_0 CS_0024_003C_003E8__locals4 = new _003C_003Ec__DisplayClass43_0();
			CS_0024_003C_003E8__locals4.g7hKcBeKIe = this;
			CS_0024_003C_003E8__locals4.jPQKjV0Btm = value;
			SetProperty(ref kpeaCZqiCA, CS_0024_003C_003E8__locals4.jPQKjV0Btm, iFZ5je3XFYKwkvcE5D.D35lls5iF(10222, iFZ5je3XFYKwkvcE5D.N06TeK0ao), null, [AsyncStateMachine(typeof(_003C_003Ec__DisplayClass43_0.SQF0tYLRcFxWNMFlve))] () =>
			{
				_003C_003Ec__DisplayClass43_0.SQF0tYLRcFxWNMFlve stateMachine = default(_003C_003Ec__DisplayClass43_0.SQF0tYLRcFxWNMFlve);
				stateMachine.ohm7rgsGZj = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
				stateMachine.msX7HANlD9 = CS_0024_003C_003E8__locals4;
				stateMachine.mUO7OjmEyR = -1;
				stateMachine.ohm7rgsGZj.Start(ref stateMachine);
			});
		}
	}

	public CategoryResponseDto SelectedCategory
	{
		get
		{
			return F2saYsSvJG;
		}
		set
		{
			_003C_003Ec__DisplayClass46_0 CS_0024_003C_003E8__locals4 = new _003C_003Ec__DisplayClass46_0();
			CS_0024_003C_003E8__locals4.k1NKBm6RVS = this;
			CS_0024_003C_003E8__locals4.mE1KDv8Y1N = value;
			SetProperty(ref F2saYsSvJG, CS_0024_003C_003E8__locals4.mE1KDv8Y1N, iFZ5je3XFYKwkvcE5D.D35lls5iF(8238, iFZ5je3XFYKwkvcE5D.N06TeK0ao), null, [AsyncStateMachine(typeof(_003C_003Ec__DisplayClass46_0.t1ayyHzyaDnrDguvSI))] () =>
			{
				_003C_003Ec__DisplayClass46_0.t1ayyHzyaDnrDguvSI stateMachine = default(_003C_003Ec__DisplayClass46_0.t1ayyHzyaDnrDguvSI);
				stateMachine.Eox7UAcRQq = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
				stateMachine.NBa7LpMcHt = CS_0024_003C_003E8__locals4;
				stateMachine.rDQ7l5uMZy = -1;
				stateMachine.Eox7UAcRQq.Start(ref stateMachine);
			});
		}
	}

	public string SelectedYear
	{
		get
		{
			return rtxaFAnSFY;
		}
		set
		{
			_003C_003Ec__DisplayClass49_0 CS_0024_003C_003E8__locals4 = new _003C_003Ec__DisplayClass49_0();
			CS_0024_003C_003E8__locals4.EeOKIRVEU1 = this;
			CS_0024_003C_003E8__locals4.Yl6KVM9wkY = value;
			SetProperty(ref rtxaFAnSFY, CS_0024_003C_003E8__locals4.Yl6KVM9wkY, iFZ5je3XFYKwkvcE5D.D35lls5iF(10250, iFZ5je3XFYKwkvcE5D.N06TeK0ao), null, [AsyncStateMachine(typeof(_003C_003Ec__DisplayClass49_0.PY5HD7jj9qDhuyTeeug))] () =>
			{
				_003C_003Ec__DisplayClass49_0.PY5HD7jj9qDhuyTeeug stateMachine = default(_003C_003Ec__DisplayClass49_0.PY5HD7jj9qDhuyTeeug);
				stateMachine.B0P54eIkXy = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
				stateMachine.LP75BVk9Wx = CS_0024_003C_003E8__locals4;
				stateMachine.os85WdoOJj = -1;
				stateMachine.B0P54eIkXy.Start(ref stateMachine);
			});
		}
	}

	public SeriesViewModel()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		pK5aMB2tE9 = SortOrder.Desc;
		kpeaCZqiCA = SeriesSort.ActivateDate;
		base._002Ector();
		base.TotalCount = -1;
		vK9abeU58K = AppContainer.Resolve<ISeasonService>();
		WgDanli7IP = AppContainer.Resolve<ISeriesService>();
		DIqa7pr8rs = AppContainer.Resolve<IAppService>();
		base.FetchMoreDataCommand = new AsyncCommand(OnFetchMoreDataCommand);
		base.SearchQuery = new ApiQuery<SeriesSearch, SeriesSort>
		{
			Count = 25,
			Search = new SeriesSearch()
		};
		PUSTmvBQQaHyP1hBraf.D35lls5iF(this, new List<string>
		{
			iFZ5je3XFYKwkvcE5D.D35lls5iF(9308, iFZ5je3XFYKwkvcE5D.N06TeK0ao),
			iFZ5je3XFYKwkvcE5D.D35lls5iF(11816, iFZ5je3XFYKwkvcE5D.N06TeK0ao),
			iFZ5je3XFYKwkvcE5D.D35lls5iF(11834, iFZ5je3XFYKwkvcE5D.N06TeK0ao)
		}, PUSTmvBQQaHyP1hBraf.cr2BX72dgv);
		dtNa6Rjod9 = iFZ5je3XFYKwkvcE5D.D35lls5iF(9308, iFZ5je3XFYKwkvcE5D.N06TeK0ao);
		TNXbhQBfhZafkuQJQQM.D35lls5iF(this, new List<SeriesSort>
		{
			SeriesSort.ActivateDate,
			SeriesSort.Name,
			SeriesSort.Hot,
			SeriesSort.Rating,
			SeriesSort.ReleaseYear,
			SeriesSort.Random
		}, TNXbhQBfhZafkuQJQQM.Ru2BFIwFs9);
		kpeaCZqiCA = SeriesSort.ActivateDate;
		k9OaANRZRO = AppContainer.Resolve<IStoreContext>();
		q9ia5ZC5i7 = AppContainer.Resolve<MainViewModel>();
		l9xauh2ary = AppContainer.Resolve<HomeViewModel>();
		k4IUkxBqFbUVfJSYVp8.D35lls5iF(base.SearchQuery.Search, (Ls4UvyBjyH8eI5XR23L.D35lls5iF(f05iTNB2hFTedWuOZlS.D35lls5iF(l9xauh2ary, f05iTNB2hFTedWuOZlS.jtEBZA2fNY), Ls4UvyBjyH8eI5XR23L.O8uByT0POb) != ApplicationPage.ShowPage) ? SeriesType.Series : SeriesType.Show, k4IUkxBqFbUVfJSYVp8.FLGBJGBdba);
	}

	[AsyncStateMachine(typeof(_003CLoadCategories_003Ed__51))]
	public Task LoadCategories()
	{
		_003CLoadCategories_003Ed__51 stateMachine = default(_003CLoadCategories_003Ed__51);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	[AsyncStateMachine(typeof(_003CLoadLanguages_003Ed__52))]
	public Task LoadLanguages()
	{
		_003CLoadLanguages_003Ed__52 stateMachine = default(_003CLoadLanguages_003Ed__52);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	[AsyncStateMachine(typeof(_003CLoadSerieAfterSearch_003Ed__53))]
	public Task LoadSerieAfterSearch()
	{
		_003CLoadSerieAfterSearch_003Ed__53 stateMachine = default(_003CLoadSerieAfterSearch_003Ed__53);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	[AsyncStateMachine(typeof(_003CLoadSeries_003Ed__54))]
	public Task LoadSeries()
	{
		_003CLoadSeries_003Ed__54 stateMachine = default(_003CLoadSeries_003Ed__54);
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

	[AsyncStateMachine(typeof(_003COnFetchMoreDataCommand_003Ed__56))]
	protected Task OnFetchMoreDataCommand()
	{
		_003COnFetchMoreDataCommand_003Ed__56 stateMachine = default(_003COnFetchMoreDataCommand_003Ed__56);
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

	[AsyncStateMachine(typeof(_003CAddMoreItems_003Ed__58))]
	public override Task AddMoreItems()
	{
		_003CAddMoreItems_003Ed__58 stateMachine = default(_003CAddMoreItems_003Ed__58);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	[AsyncStateMachine(typeof(_003CGoToPage_003Ed__59))]
	public override Task GoToPage(BaseMediaDto model)
	{
		_003CGoToPage_003Ed__59 stateMachine = default(_003CGoToPage_003Ed__59);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine.model = model;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	public override void OnLoading()
	{
		fp757nBYjo8889efKFJ.D35lls5iF(this, fp757nBYjo8889efKFJ.Y7bBb82MAs);
		if (!base.Items.Any())
		{
			Task task = LoadAsync();
			Action<Exception> action = null;
			bool flag = false;
			gBlEqv8jRKikCj2DMZp.D35lls5iF(task, ref action, ref flag, gBlEqv8jRKikCj2DMZp.pSp8ymt8Mu);
		}
	}

	[AsyncStateMachine(typeof(_003CLoadAsync_003Ed__61))]
	public override Task LoadAsync()
	{
		_003CLoadAsync_003Ed__61 stateMachine = default(_003CLoadAsync_003Ed__61);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	[AsyncStateMachine(typeof(_003CAddItems_003Ed__62))]
	private Task bdUaKn3ire()
	{
		_003CAddItems_003Ed__62 stateMachine = default(_003CAddItems_003Ed__62);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	[CompilerGenerated]
	[AsyncStateMachine(typeof(_003C_003CAddMoreItems_003Eb__58_1_003Ed))]
	private Task nZQakSxDgi()
	{
		_003C_003CAddMoreItems_003Eb__58_1_003Ed stateMachine = default(_003C_003CAddMoreItems_003Eb__58_1_003Ed);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	[AsyncStateMachine(typeof(_003C_003CLoadAsync_003Eb__61_1_003Ed))]
	[CompilerGenerated]
	private Task zSRa8wBCUl()
	{
		_003C_003CLoadAsync_003Eb__61_1_003Ed stateMachine = default(_003C_003CLoadAsync_003Eb__61_1_003Ed);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}
}
