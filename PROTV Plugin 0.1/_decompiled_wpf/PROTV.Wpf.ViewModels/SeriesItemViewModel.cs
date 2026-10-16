using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
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
using PROTV.Abstractions.Services;
using PROTV.Wpf.Bootstrap;

namespace PROTV.Wpf.ViewModels;

public class SeriesItemViewModel : BaseViewModel
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass35_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct CedTG2OSdghXIawPVM : IAsyncStateMachine
		{
			public int gOnb9RMkZV;

			public AsyncTaskMethodBuilder DwbbeoYcaH;

			public _003C_003Ec__DisplayClass35_0 UCObOwXgd8;

			private bool CBVbrqUnwT;

			private object wgNbHuL8Qk;

			private int nXEbo36ucl;

			private Response<SeasonResponseDto> VhJbgVkDqR;

			private TaskAwaiter<Response<SeasonResponseDto>> wC2b1ghpBy;

			private TaskAwaiter<MemoryStream> VvDbJxs7ma;

			private TaskAwaiter YUhbhgZ39y;

			private TaskAwaiter<bool> WlfblqMxK4;

			private void MoveNext()
			{
				int num = gOnb9RMkZV;
				_003C_003Ec__DisplayClass35_0 obj = UCObOwXgd8;
				try
				{
					if ((uint)num <= 2u)
					{
						goto IL_003e;
					}
					if (num != 3)
					{
						CBVbrqUnwT = true;
						goto IL_04e4;
					}
					TaskAwaiter<bool> awaiter = WlfblqMxK4;
					WlfblqMxK4 = default(TaskAwaiter<bool>);
					num = (gOnb9RMkZV = -1);
					goto IL_049a;
					IL_04dd:
					wgNbHuL8Qk = null;
					goto IL_04e4;
					IL_049a:
					if (awaiter.GetResult())
					{
						CBVbrqUnwT = true;
						obj.wd0fCKk266.rhQa0ywLtV = AppContainer.Resolve<ISeasonService>();
						obj.wd0fCKk266.gZGaGcnByj = AppContainer.Resolve<IStoreContext>();
						obj.wd0fCKk266.WMnaa39CtC = AppContainer.Resolve<ISeriesService>();
					}
					goto IL_04dd;
					IL_003e:
					try
					{
						TaskAwaiter<Response<SeasonResponseDto>> awaiter4;
						TaskAwaiter<MemoryStream> awaiter3;
						TaskAwaiter awaiter2;
						Response<SeasonResponseDto> result;
						switch (num)
						{
						default:
							zj2IKfdqNVuexnancIZ.D35lls5iF(obj.wd0fCKk266, zj2IKfdqNVuexnancIZ.R4mdJ2iYdw).Clear();
							awaiter4 = iKOxbndBxAauEpxcAg3.D35lls5iF(obj.wd0fCKk266.rhQa0ywLtV, m9MGZR7k2RmVqYXYS5.D35lls5iF(obj.U8VfYvdWOq, m9MGZR7k2RmVqYXYS5.j871CQO7pP), iKOxbndBxAauEpxcAg3.GDFd04bD1W).GetAwaiter();
							if (!awaiter4.IsCompleted)
							{
								num = (gOnb9RMkZV = 0);
								wC2b1ghpBy = awaiter4;
								DwbbeoYcaH.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
								return;
							}
							goto IL_00db;
						case 0:
							awaiter4 = wC2b1ghpBy;
							wC2b1ghpBy = default(TaskAwaiter<Response<SeasonResponseDto>>);
							num = (gOnb9RMkZV = -1);
							goto IL_00db;
						case 1:
							awaiter3 = VvDbJxs7ma;
							VvDbJxs7ma = default(TaskAwaiter<MemoryStream>);
							num = (gOnb9RMkZV = -1);
							goto IL_02b3;
						case 2:
							{
								awaiter2 = YUhbhgZ39y;
								YUhbhgZ39y = default(TaskAwaiter);
								num = (gOnb9RMkZV = -1);
								goto IL_0325;
							}
							IL_02b3:
							awaiter3.GetResult();
							awaiter2 = QliBEUviwWqgtMcBndV.D35lls5iF(pvrKKy8Mk1kpdmIfp3A.D35lls5iF(100, pvrKKy8Mk1kpdmIfp3A.aVh8SPrFkE), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
							if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter2, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
							{
								num = (gOnb9RMkZV = 2);
								YUhbhgZ39y = awaiter2;
								DwbbeoYcaH.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
							goto IL_0325;
							IL_00db:
							result = awaiter4.GetResult();
							VhJbgVkDqR = result;
							if (VhJbgVkDqR == null || !VhJbgVkDqR.Status)
							{
								break;
							}
							if (M6ZErPEr2LZyWYpa5O.D35lls5iF(eVlRnEIaHT0dqvCx0Kx.D35lls5iF(VhJbgVkDqR.Data, eVlRnEIaHT0dqvCx0Kx.mSLdQXCldH), M6ZErPEr2LZyWYpa5O.WjpdPX71fL))
							{
								m5sZxWmLHUhVHrJe8sC.D35lls5iF(VhJbgVkDqR.Data, eVlRnEIaHT0dqvCx0Kx.D35lls5iF(wFALqDnBsAqnd0Cclwg.D35lls5iF(obj.wd0fCKk266, wFALqDnBsAqnd0Cclwg.LrIdSQNxJo), eVlRnEIaHT0dqvCx0Kx.hELdsUSdUE), m5sZxWmLHUhVHrJe8sC.S9UdhavmLH);
							}
							if (M6ZErPEr2LZyWYpa5O.D35lls5iF(eVlRnEIaHT0dqvCx0Kx.D35lls5iF(VhJbgVkDqR.Data, eVlRnEIaHT0dqvCx0Kx.DV5dunh45e), M6ZErPEr2LZyWYpa5O.WjpdPX71fL))
							{
								m5sZxWmLHUhVHrJe8sC.D35lls5iF(VhJbgVkDqR.Data, eVlRnEIaHT0dqvCx0Kx.D35lls5iF(wFALqDnBsAqnd0Cclwg.D35lls5iF(obj.wd0fCKk266, wFALqDnBsAqnd0Cclwg.LrIdSQNxJo), eVlRnEIaHT0dqvCx0Kx.P6FdxJWL53), m5sZxWmLHUhVHrJe8sC.HKSdYBPqDJ);
							}
							if (Rfe4g0pfhM1nR3u94hp.D35lls5iF(VhJbgVkDqR.Data, Rfe4g0pfhM1nR3u94hp.RYhdX5THtq) == 0.0)
							{
								Tr7S4tmbD38LrEkLtjT.D35lls5iF(VhJbgVkDqR.Data, Rfe4g0pfhM1nR3u94hp.D35lls5iF(wFALqDnBsAqnd0Cclwg.D35lls5iF(obj.wd0fCKk266, wFALqDnBsAqnd0Cclwg.LrIdSQNxJo), Rfe4g0pfhM1nR3u94hp.cYKdfMn4lg), Tr7S4tmbD38LrEkLtjT.pnjdFIovZO);
							}
							if (!M6ZErPEr2LZyWYpa5O.D35lls5iF(eVlRnEIaHT0dqvCx0Kx.D35lls5iF(VhJbgVkDqR.Data, eVlRnEIaHT0dqvCx0Kx.SpEd2Oc18V), M6ZErPEr2LZyWYpa5O.WjpdPX71fL))
							{
								awaiter3 = SJd7PJdZd6ObcySHIoO.D35lls5iF(d27jrd3uD0dgsTkvn8k.D35lls5iF(hjMnupQVVDlRZAYQJC.D35lls5iF(obj.wd0fCKk266.gZGaGcnByj, hjMnupQVVDlRZAYQJC.YLV3Oa3St2), eVlRnEIaHT0dqvCx0Kx.D35lls5iF(VhJbgVkDqR.Data, eVlRnEIaHT0dqvCx0Kx.SpEd2Oc18V), d27jrd3uD0dgsTkvn8k.fC53Pw5IkY), SJd7PJdZd6ObcySHIoO.dCfdjKg5IF).GetAwaiter();
								if (!awaiter3.IsCompleted)
								{
									num = (gOnb9RMkZV = 1);
									VvDbJxs7ma = awaiter3;
									DwbbeoYcaH.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
									return;
								}
								goto IL_02b3;
							}
							goto IL_0331;
							IL_0325:
							oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter2, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
							goto IL_0331;
							IL_0331:
							kuM3EQBH0UbvDtfO5X1.D35lls5iF(obj.wd0fCKk266, VhJbgVkDqR.Data, kuM3EQBH0UbvDtfO5X1.SE9dyLp2Ik);
							break;
						}
						IEnumerator<EpisodeResponseDto> enumerator = (from x in YSuLOTwrQd4DCj824wQ.D35lls5iF(VAFQRsBLuCrswPTaruv.D35lls5iF(obj.wd0fCKk266, VAFQRsBLuCrswPTaruv.JwBdK6ZfaJ), YSuLOTwrQd4DCj824wQ.QA3dbsllVb)
							orderby WJbFtI6AObf2rNffLCy.D35lls5iF(x, WJbFtI6AObf2rNffLCy.eOGdcSctuq)
							select x).GetEnumerator();
						try
						{
							while (hjMnupQVVDlRZAYQJC.D35lls5iF(enumerator, hjMnupQVVDlRZAYQJC.QV1TFwytOj))
							{
								EpisodeResponseDto current = enumerator.Current;
								zj2IKfdqNVuexnancIZ.D35lls5iF(obj.wd0fCKk266, zj2IKfdqNVuexnancIZ.R4mdJ2iYdw).Add(current);
							}
						}
						finally
						{
							if (num < 0 && enumerator != null)
							{
								xLO56JniGyickVjO1Ot.D35lls5iF(enumerator, xLO56JniGyickVjO1Ot.ydbT2bsoH4);
							}
						}
						VhJbgVkDqR = null;
					}
					catch (PROTVException ex)
					{
						wgNbHuL8Qk = ex;
						nXEbo36ucl = 1;
					}
					int num2 = nXEbo36ucl;
					if (num2 == 1 && TNckS5wtLfB2Lk9dYP8.D35lls5iF((PROTVException)wgNbHuL8Qk, TNckS5wtLfB2Lk9dYP8.oGkwV3iq3t) == ExceptionType.AuthorizationTokenInvalid)
					{
						awaiter = bAA7Sxw7vZsvusOmDea.D35lls5iF(AppContainer.Resolve<MainViewModel>(), bAA7Sxw7vZsvusOmDea.gytwc9U7r5).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (gOnb9RMkZV = 3);
							WlfblqMxK4 = awaiter;
							DwbbeoYcaH.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_049a;
					}
					goto IL_04dd;
					IL_04e4:
					if (CBVbrqUnwT)
					{
						CBVbrqUnwT = false;
						nXEbo36ucl = 0;
						goto IL_003e;
					}
				}
				catch (Exception ex2)
				{
					gOnb9RMkZV = -2;
					NNK1eXA7fWQ87oSUty7.D35lls5iF(ref DwbbeoYcaH, ex2, NNK1eXA7fWQ87oSUty7.G3EAcW9Om7);
					return;
				}
				gOnb9RMkZV = -2;
				meFicnAMHIVtdhf671p.D35lls5iF(ref DwbbeoYcaH, meFicnAMHIVtdhf671p.bsDASenQ5I);
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine P_0)
			{
				vxBFJcAKZoecNtbdqxt.D35lls5iF(ref DwbbeoYcaH, P_0, vxBFJcAKZoecNtbdqxt.tuxANdhu18);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine P_0)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(P_0);
			}
		}

		[StructLayout(LayoutKind.Auto)]
		private struct HUVuJkrRle0QdyNXQm : IAsyncStateMachine
		{
			public int zx9bU6pOfG;

			public AsyncVoidMethodBuilder zjxbLGqGdQ;

			public _003C_003Ec__DisplayClass35_0 B9Fb2ORLKw;

			private TaskAwaiter WFxbz9PIRg;

			private void MoveNext()
			{
				int num = zx9bU6pOfG;
				_003C_003Ec__DisplayClass35_0 CS_0024_003C_003E8__locals3 = B9Fb2ORLKw;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(W7S2sip6SDieZFVsNbd.D35lls5iF(CS_0024_003C_003E8__locals3.wd0fCKk266, Expression.Lambda<Func<bool>>(OWBKr5pvc5MWsK1OMtR.D35lls5iF(o4bYL4peNeC2wWb8yjx.D35lls5iF(CS_0024_003C_003E8__locals3.wd0fCKk266, sjYxHO8OWlc6X80hFj7.D35lls5iF(typeof(SeriesItemViewModel).TypeHandle, sjYxHO8OWlc6X80hFj7.uWZ8ugU7r5), o4bYL4peNeC2wWb8yjx.oVdpGKjy2x), (MethodInfo)f5q427pRQZnrEKPy4Ws.D35lls5iF((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, f5q427pRQZnrEKPy4Ws.Bo9pk3m4k7), OWBKr5pvc5MWsK1OMtR.fZIpAAdi1v), Array.Empty<ParameterExpression>()), [AsyncStateMachine(typeof(CedTG2OSdghXIawPVM))] () =>
						{
							CedTG2OSdghXIawPVM stateMachine = default(CedTG2OSdghXIawPVM);
							stateMachine.DwbbeoYcaH = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
							stateMachine.UCObOwXgd8 = CS_0024_003C_003E8__locals3;
							stateMachine.gOnb9RMkZV = -1;
							stateMachine.DwbbeoYcaH.Start(ref stateMachine);
							return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine.DwbbeoYcaH, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
						}, W7S2sip6SDieZFVsNbd.XWappgVyfh), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
						if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
						{
							num = (zx9bU6pOfG = 0);
							WFxbz9PIRg = awaiter;
							zjxbLGqGdQ.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = WFxbz9PIRg;
						WFxbz9PIRg = default(TaskAwaiter);
						num = (zx9bU6pOfG = -1);
					}
					oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
				}
				catch (Exception ex)
				{
					zx9bU6pOfG = -2;
					N2XUglA3neBsnlZfRPQ.D35lls5iF(ref zjxbLGqGdQ, ex, N2XUglA3neBsnlZfRPQ.l4pATRumoW);
					return;
				}
				zx9bU6pOfG = -2;
				T4XmPoA4VNJJP1afcgL.D35lls5iF(ref zjxbLGqGdQ, T4XmPoA4VNJJP1afcgL.TRyALZckCh);
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine P_0)
			{
				dHWo7jAEn6E4X7bsY4R.D35lls5iF(ref zjxbLGqGdQ, P_0, dHWo7jAEn6E4X7bsY4R.z3hAB6UZ9o);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine P_0)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(P_0);
			}
		}

		public SeriesItemViewModel wd0fCKk266;

		public SeasonResponseDto U8VfYvdWOq;

		public Func<Task> tY9fFbE4aB;

		public _003C_003Ec__DisplayClass35_0()
		{
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
			base._002Ector();
		}

		[AsyncStateMachine(typeof(HUVuJkrRle0QdyNXQm))]
		internal void oJ5fNcBnh1()
		{
			HUVuJkrRle0QdyNXQm stateMachine = default(HUVuJkrRle0QdyNXQm);
			stateMachine.zjxbLGqGdQ = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
			stateMachine.B9Fb2ORLKw = this;
			stateMachine.zx9bU6pOfG = -1;
			stateMachine.zjxbLGqGdQ.Start(ref stateMachine);
		}

		[AsyncStateMachine(typeof(CedTG2OSdghXIawPVM))]
		internal Task hFyfMf4jgx()
		{
			CedTG2OSdghXIawPVM stateMachine = default(CedTG2OSdghXIawPVM);
			stateMachine.DwbbeoYcaH = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
			stateMachine.UCObOwXgd8 = this;
			stateMachine.gOnb9RMkZV = -1;
			stateMachine.DwbbeoYcaH.Start(ref stateMachine);
			return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine.DwbbeoYcaH, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass39_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct rr5OcOHXbD4xpEOrFm : IAsyncStateMachine
		{
			public int MuA7c9IUoh;

			public AsyncTaskMethodBuilder wGA7jbsESd;

			public _003C_003Ec__DisplayClass39_0 tlm7vSS5pM;

			private Page Nlm7Ws6PFo;

			private TaskAwaiter CtE74stZLJ;

			private void MoveNext()
			{
				int num = MuA7c9IUoh;
				_003C_003Ec__DisplayClass39_0 CS_0024_003C_003E8__locals14 = tlm7vSS5pM;
				try
				{
					TaskAwaiter awaiter;
					if (num == 0)
					{
						awaiter = CtE74stZLJ;
						CtE74stZLJ = default(TaskAwaiter);
						num = (MuA7c9IUoh = -1);
						goto IL_0119;
					}
					if (num == 1)
					{
						awaiter = CtE74stZLJ;
						CtE74stZLJ = default(TaskAwaiter);
						num = (MuA7c9IUoh = -1);
						goto IL_02e1;
					}
					if (uN1DaxTm1XRIu0SSp7h.D35lls5iF(CS_0024_003C_003E8__locals14.QjDfXjh7U3, uN1DaxTm1XRIu0SSp7h.qvednFgrpv) != MediaCost.Paid)
					{
						SereisPlayerViewModel viewModel = new SereisPlayerViewModel(wFALqDnBsAqnd0Cclwg.D35lls5iF(CS_0024_003C_003E8__locals14.WNrfmTuaDH, wFALqDnBsAqnd0Cclwg.LrIdSQNxJo), VAFQRsBLuCrswPTaruv.D35lls5iF(CS_0024_003C_003E8__locals14.WNrfmTuaDH, VAFQRsBLuCrswPTaruv.JwBdK6ZfaJ), CS_0024_003C_003E8__locals14.QjDfXjh7U3);
						Page page = new Page();
						KBhlAv9D2TgBJ1kkc0B.D35lls5iF(page, IyGDDwHBiPv8vfOFJDF.D35lls5iF(ApplicationPage.ShowSeriesPage, viewModel, IyGDDwHBiPv8vfOFJDF.hivH0XYhaE), KBhlAv9D2TgBJ1kkc0B.fWUHrWO7Sa);
						qni3xrDkAJ3vF35eMav.D35lls5iF(page, EBgwuVHeVLDJVVfMaAk.D35lls5iF(ApplicationPage.ShowSeriesPage, EBgwuVHeVLDJVVfMaAk.mtcHG3MEy3), qni3xrDkAJ3vF35eMav.Ra7HRFTvnD);
						Nlm7Ws6PFo = page;
						awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(pvrKKy8Mk1kpdmIfp3A.D35lls5iF(5, pvrKKy8Mk1kpdmIfp3A.aVh8SPrFkE), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
						if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
						{
							num = (MuA7c9IUoh = 1);
							CtE74stZLJ = awaiter;
							wGA7jbsESd.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_02e1;
					}
					if (slilrfIFuElyqvoQjqM.D35lls5iF(CS_0024_003C_003E8__locals14.QjDfXjh7U3, slilrfIFuElyqvoQjqM.IHxdodh1Vs) != null)
					{
						SereisPlayerViewModel viewModel2 = new SereisPlayerViewModel(wFALqDnBsAqnd0Cclwg.D35lls5iF(CS_0024_003C_003E8__locals14.WNrfmTuaDH, wFALqDnBsAqnd0Cclwg.LrIdSQNxJo), VAFQRsBLuCrswPTaruv.D35lls5iF(CS_0024_003C_003E8__locals14.WNrfmTuaDH, VAFQRsBLuCrswPTaruv.JwBdK6ZfaJ), CS_0024_003C_003E8__locals14.QjDfXjh7U3);
						Page page2 = new Page();
						KBhlAv9D2TgBJ1kkc0B.D35lls5iF(page2, IyGDDwHBiPv8vfOFJDF.D35lls5iF(ApplicationPage.ShowSeriesPage, viewModel2, IyGDDwHBiPv8vfOFJDF.hivH0XYhaE), KBhlAv9D2TgBJ1kkc0B.fWUHrWO7Sa);
						qni3xrDkAJ3vF35eMav.D35lls5iF(page2, EBgwuVHeVLDJVVfMaAk.D35lls5iF(ApplicationPage.ShowSeriesPage, EBgwuVHeVLDJVVfMaAk.mtcHG3MEy3), qni3xrDkAJ3vF35eMav.Ra7HRFTvnD);
						Nlm7Ws6PFo = page2;
						awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(pvrKKy8Mk1kpdmIfp3A.D35lls5iF(5, pvrKKy8Mk1kpdmIfp3A.aVh8SPrFkE), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
						if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
						{
							num = (MuA7c9IUoh = 0);
							CtE74stZLJ = awaiter;
							wGA7jbsESd.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_0119;
					}
					string[] obj = new string[5]
					{
						iFZ5je3XFYKwkvcE5D.D35lls5iF(16076, iFZ5je3XFYKwkvcE5D.N06TeK0ao),
						QQLie3eYkZwbFFm9Jjw.D35lls5iF(wFALqDnBsAqnd0Cclwg.D35lls5iF(CS_0024_003C_003E8__locals14.WNrfmTuaDH, wFALqDnBsAqnd0Cclwg.LrIdSQNxJo), QQLie3eYkZwbFFm9Jjw.D7uwK6SQ7w),
						iFZ5je3XFYKwkvcE5D.D35lls5iF(16140, iFZ5je3XFYKwkvcE5D.N06TeK0ao),
						null,
						null
					};
					int num2 = WJbFtI6AObf2rNffLCy.D35lls5iF(CS_0024_003C_003E8__locals14.QjDfXjh7U3, WJbFtI6AObf2rNffLCy.nAEdTgTc0d);
					obj[3] = E1oqfbTdQ1YrEeaxoPg.D35lls5iF(ref num2, E1oqfbTdQ1YrEeaxoPg.beYTUkKTth);
					obj[4] = iFZ5je3XFYKwkvcE5D.D35lls5iF(16154, iFZ5je3XFYKwkvcE5D.N06TeK0ao);
					aOsAijCTnvLPVytuecl.D35lls5iF(EKUvcf6BZG4YrVDIJu7.D35lls5iF(obj, EKUvcf6BZG4YrVDIJu7.lI660m0xwr), delegate(bool isConfirmed)
					{
						if (isConfirmed)
						{
							Task task = JN3OuGI5IJVx228kDoI.D35lls5iF(CS_0024_003C_003E8__locals14.WNrfmTuaDH, CS_0024_003C_003E8__locals14.QjDfXjh7U3, JN3OuGI5IJVx228kDoI.rRRdMiOh32);
							Action<Exception> action = null;
							bool flag = false;
							gBlEqv8jRKikCj2DMZp.D35lls5iF(task, ref action, ref flag, gBlEqv8jRKikCj2DMZp.pSp8ymt8Mu);
						}
						return true;
					}, "", aOsAijCTnvLPVytuecl.Qt4C45JP4A);
					goto end_IL_0015;
					IL_0119:
					oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
					GmMLaTD7kV8rq88ZFvR.D35lls5iF(Xlypb0Hnr2C3ydrYEdG.D35lls5iF(CS_0024_003C_003E8__locals14.WNrfmTuaDH.CgfaTmXYfb, Xlypb0Hnr2C3ydrYEdG.U3Z1IKMGuZ), Nlm7Ws6PFo, GmMLaTD7kV8rq88ZFvR.iMJHkmaaRY);
					Nlm7Ws6PFo = null;
					goto end_IL_0015;
					IL_02e1:
					oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
					GmMLaTD7kV8rq88ZFvR.D35lls5iF(Xlypb0Hnr2C3ydrYEdG.D35lls5iF(CS_0024_003C_003E8__locals14.WNrfmTuaDH.CgfaTmXYfb, Xlypb0Hnr2C3ydrYEdG.U3Z1IKMGuZ), Nlm7Ws6PFo, GmMLaTD7kV8rq88ZFvR.iMJHkmaaRY);
					Nlm7Ws6PFo = null;
					end_IL_0015:;
				}
				catch (Exception ex)
				{
					MuA7c9IUoh = -2;
					NNK1eXA7fWQ87oSUty7.D35lls5iF(ref wGA7jbsESd, ex, NNK1eXA7fWQ87oSUty7.G3EAcW9Om7);
					return;
				}
				MuA7c9IUoh = -2;
				meFicnAMHIVtdhf671p.D35lls5iF(ref wGA7jbsESd, meFicnAMHIVtdhf671p.bsDASenQ5I);
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine P_0)
			{
				vxBFJcAKZoecNtbdqxt.D35lls5iF(ref wGA7jbsESd, P_0, vxBFJcAKZoecNtbdqxt.tuxANdhu18);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine P_0)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(P_0);
			}
		}

		public SeriesItemViewModel WNrfmTuaDH;

		public EpisodeResponseDto QjDfXjh7U3;

		public Func<bool, bool> BRifRvcqVt;

		public _003C_003Ec__DisplayClass39_0()
		{
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
			base._002Ector();
		}

		[AsyncStateMachine(typeof(rr5OcOHXbD4xpEOrFm))]
		internal Task jxGfi2uPTT()
		{
			rr5OcOHXbD4xpEOrFm stateMachine = default(rr5OcOHXbD4xpEOrFm);
			stateMachine.wGA7jbsESd = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
			stateMachine.tlm7vSS5pM = this;
			stateMachine.MuA7c9IUoh = -1;
			stateMachine.wGA7jbsESd.Start(ref stateMachine);
			return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine.wGA7jbsESd, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
		}

		internal bool JaGf3hYssm(bool isConfirmed)
		{
			if (isConfirmed)
			{
				Task task = JN3OuGI5IJVx228kDoI.D35lls5iF(WNrfmTuaDH, QjDfXjh7U3, JN3OuGI5IJVx228kDoI.rRRdMiOh32);
				Action<Exception> action = null;
				bool flag = false;
				gBlEqv8jRKikCj2DMZp.D35lls5iF(task, ref action, ref flag, gBlEqv8jRKikCj2DMZp.pSp8ymt8Mu);
			}
			return true;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnPlayOrRentMovieCommandExcute_003Ed__39 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public SeriesItemViewModel _003C_003E4__this;

		public EpisodeResponseDto episode;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			SeriesItemViewModel seriesItemViewModel = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					_003C_003Ec__DisplayClass39_0 CS_0024_003C_003E8__locals3 = new _003C_003Ec__DisplayClass39_0();
					CS_0024_003C_003E8__locals3.WNrfmTuaDH = _003C_003E4__this;
					CS_0024_003C_003E8__locals3.QjDfXjh7U3 = episode;
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(W7S2sip6SDieZFVsNbd.D35lls5iF(seriesItemViewModel, Expression.Lambda<Func<bool>>(OWBKr5pvc5MWsK1OMtR.D35lls5iF(o4bYL4peNeC2wWb8yjx.D35lls5iF(seriesItemViewModel, sjYxHO8OWlc6X80hFj7.D35lls5iF(typeof(SeriesItemViewModel).TypeHandle, sjYxHO8OWlc6X80hFj7.uWZ8ugU7r5), o4bYL4peNeC2wWb8yjx.oVdpGKjy2x), (MethodInfo)f5q427pRQZnrEKPy4Ws.D35lls5iF((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, f5q427pRQZnrEKPy4Ws.Bo9pk3m4k7), OWBKr5pvc5MWsK1OMtR.fZIpAAdi1v), Array.Empty<ParameterExpression>()), [AsyncStateMachine(typeof(_003C_003Ec__DisplayClass39_0.rr5OcOHXbD4xpEOrFm))] () =>
					{
						_003C_003Ec__DisplayClass39_0.rr5OcOHXbD4xpEOrFm stateMachine = default(_003C_003Ec__DisplayClass39_0.rr5OcOHXbD4xpEOrFm);
						stateMachine.wGA7jbsESd = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
						stateMachine.tlm7vSS5pM = CS_0024_003C_003E8__locals3;
						stateMachine.MuA7c9IUoh = -1;
						stateMachine.wGA7jbsESd.Start(ref stateMachine);
						return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine.wGA7jbsESd, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
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
	private struct _003CRentEpisode_003Ed__40 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public EpisodeResponseDto episode;

		public SeriesItemViewModel _003C_003E4__this;

		private bool _003CtryAgain_003E5__2;

		private object _003C_003E7__wrap2;

		private int _003C_003E7__wrap3;

		private Page _003Cpage_003E5__5;

		private TaskAwaiter<Response<RentResponseDto>> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		private TaskAwaiter<bool> _003C_003Eu__3;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			SeriesItemViewModel seriesItemViewModel = _003C_003E4__this;
			try
			{
				if ((uint)num <= 1u)
				{
					goto IL_003e;
				}
				if (num != 2)
				{
					_003CtryAgain_003E5__2 = true;
					goto IL_0304;
				}
				TaskAwaiter<bool> awaiter = _003C_003Eu__3;
				_003C_003Eu__3 = default(TaskAwaiter<bool>);
				num = (_003C_003E1__state = -1);
				goto IL_02a9;
				IL_02fd:
				_003C_003E7__wrap2 = null;
				goto IL_0304;
				IL_02a9:
				if (awaiter.GetResult())
				{
					_003CtryAgain_003E5__2 = true;
					seriesItemViewModel.rhQa0ywLtV = AppContainer.Resolve<ISeasonService>();
					seriesItemViewModel.gZGaGcnByj = AppContainer.Resolve<IStoreContext>();
					seriesItemViewModel.WMnaa39CtC = AppContainer.Resolve<ISeriesService>();
				}
				goto IL_02fd;
				IL_003e:
				try
				{
					TaskAwaiter awaiter2;
					TaskAwaiter<Response<RentResponseDto>> awaiter3;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter2 = _003C_003Eu__2;
							_003C_003Eu__2 = default(TaskAwaiter);
							num = (_003C_003E1__state = -1);
							goto IL_01c8;
						}
						if (slilrfIFuElyqvoQjqM.D35lls5iF(episode, slilrfIFuElyqvoQjqM.IHxdodh1Vs) != null)
						{
							goto IL_0103;
						}
						awaiter3 = sYW4HcCLj53QDe4wG8O.D35lls5iF(seriesItemViewModel.rhQa0ywLtV, m9MGZR7k2RmVqYXYS5.D35lls5iF(episode, m9MGZR7k2RmVqYXYS5.j871CQO7pP), sYW4HcCLj53QDe4wG8O.T89d4kTn0P).GetAwaiter();
						if (!awaiter3.IsCompleted)
						{
							num = (_003C_003E1__state = 0);
							_003C_003Eu__1 = awaiter3;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
							return;
						}
					}
					else
					{
						awaiter3 = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter<Response<RentResponseDto>>);
						num = (_003C_003E1__state = -1);
					}
					Response<RentResponseDto> result = awaiter3.GetResult();
					if (result != null && result.Status)
					{
						vv5IXxIXvd4NjTx2tvS.D35lls5iF(episode, result.Data, vv5IXxIXvd4NjTx2tvS.J9OdLCly4v);
					}
					goto IL_0103;
					IL_0103:
					SereisPlayerViewModel viewModel = new SereisPlayerViewModel(wFALqDnBsAqnd0Cclwg.D35lls5iF(seriesItemViewModel, wFALqDnBsAqnd0Cclwg.LrIdSQNxJo), VAFQRsBLuCrswPTaruv.D35lls5iF(seriesItemViewModel, VAFQRsBLuCrswPTaruv.JwBdK6ZfaJ), episode);
					Page page = new Page();
					KBhlAv9D2TgBJ1kkc0B.D35lls5iF(page, IyGDDwHBiPv8vfOFJDF.D35lls5iF(ApplicationPage.ShowSeriesPage, viewModel, IyGDDwHBiPv8vfOFJDF.hivH0XYhaE), KBhlAv9D2TgBJ1kkc0B.fWUHrWO7Sa);
					qni3xrDkAJ3vF35eMav.D35lls5iF(page, EBgwuVHeVLDJVVfMaAk.D35lls5iF(ApplicationPage.ShowSeriesPage, EBgwuVHeVLDJVVfMaAk.mtcHG3MEy3), qni3xrDkAJ3vF35eMav.Ra7HRFTvnD);
					_003Cpage_003E5__5 = page;
					awaiter2 = QliBEUviwWqgtMcBndV.D35lls5iF(pvrKKy8Mk1kpdmIfp3A.D35lls5iF(5, pvrKKy8Mk1kpdmIfp3A.aVh8SPrFkE), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
					if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter2, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
					{
						num = (_003C_003E1__state = 1);
						_003C_003Eu__2 = awaiter2;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
						return;
					}
					goto IL_01c8;
					IL_01c8:
					oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter2, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
					GmMLaTD7kV8rq88ZFvR.D35lls5iF(Xlypb0Hnr2C3ydrYEdG.D35lls5iF(seriesItemViewModel.CgfaTmXYfb, Xlypb0Hnr2C3ydrYEdG.U3Z1IKMGuZ), _003Cpage_003E5__5, GmMLaTD7kV8rq88ZFvR.iMJHkmaaRY);
					_003Cpage_003E5__5 = null;
				}
				catch (PROTVException ex)
				{
					_003C_003E7__wrap2 = ex;
					_003C_003E7__wrap3 = 1;
				}
				int num2 = _003C_003E7__wrap3;
				if (num2 == 1)
				{
					PROTVException ex2 = (PROTVException)_003C_003E7__wrap2;
					if (TNckS5wtLfB2Lk9dYP8.D35lls5iF(ex2, TNckS5wtLfB2Lk9dYP8.oGkwV3iq3t) == ExceptionType.AuthorizationTokenInvalid)
					{
						awaiter = bAA7Sxw7vZsvusOmDea.D35lls5iF(AppContainer.Resolve<MainViewModel>(), bAA7Sxw7vZsvusOmDea.gytwc9U7r5).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (_003C_003E1__state = 2);
							_003C_003Eu__3 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_02a9;
					}
					gsYNF433WqUIGma3CNX.D35lls5iF(QQLie3eYkZwbFFm9Jjw.D35lls5iF(ex2, QQLie3eYkZwbFFm9Jjw.vZdwjWiy78), "", gsYNF433WqUIGma3CNX.MAY3Ti847u);
				}
				goto IL_02fd;
				IL_0304:
				if (_003CtryAgain_003E5__2)
				{
					_003CtryAgain_003E5__2 = false;
					_003C_003E7__wrap3 = 0;
					goto IL_003e;
				}
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

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLoadAsync_003Ed__41 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public SeriesItemViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			SeriesItemViewModel CS_0024_003C_003E8__locals3 = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(W7S2sip6SDieZFVsNbd.D35lls5iF(CS_0024_003C_003E8__locals3, Expression.Lambda<Func<bool>>(OWBKr5pvc5MWsK1OMtR.D35lls5iF(o4bYL4peNeC2wWb8yjx.D35lls5iF(CS_0024_003C_003E8__locals3, sjYxHO8OWlc6X80hFj7.D35lls5iF(typeof(SeriesItemViewModel).TypeHandle, sjYxHO8OWlc6X80hFj7.uWZ8ugU7r5), o4bYL4peNeC2wWb8yjx.oVdpGKjy2x), (MethodInfo)f5q427pRQZnrEKPy4Ws.D35lls5iF((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, f5q427pRQZnrEKPy4Ws.Bo9pk3m4k7), OWBKr5pvc5MWsK1OMtR.fZIpAAdi1v), Array.Empty<ParameterExpression>()), [AsyncStateMachine(typeof(_003C_003CLoadAsync_003Eb__41_1_003Ed))] () =>
					{
						_003C_003CLoadAsync_003Eb__41_1_003Ed stateMachine = default(_003C_003CLoadAsync_003Eb__41_1_003Ed);
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
	private struct _003C_003CLoadAsync_003Eb__41_1_003Ed : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public SeriesItemViewModel _003C_003E4__this;

		private bool _003CtryAgain_003E5__2;

		private object _003C_003E7__wrap2;

		private int _003C_003E7__wrap3;

		private TaskAwaiter<Response<SeriesResponseDto>> _003C_003Eu__1;

		private Response<SeasonResponseDto> _003Cseasonx_003E5__5;

		private TaskAwaiter<Response<SeasonResponseDto>> _003C_003Eu__2;

		private TaskAwaiter<MemoryStream> _003C_003Eu__3;

		private TaskAwaiter _003C_003Eu__4;

		private TaskAwaiter<bool> _003C_003Eu__5;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			SeriesItemViewModel CS_0024_003C_003E8__locals28 = _003C_003E4__this;
			try
			{
				if ((uint)num <= 3u)
				{
					goto IL_003e;
				}
				if (num != 4)
				{
					_003CtryAgain_003E5__2 = true;
					goto IL_06b0;
				}
				TaskAwaiter<bool> awaiter = _003C_003Eu__5;
				_003C_003Eu__5 = default(TaskAwaiter<bool>);
				num = (_003C_003E1__state = -1);
				goto IL_0675;
				IL_06a9:
				_003C_003E7__wrap2 = null;
				goto IL_06b0;
				IL_0675:
				if (awaiter.GetResult())
				{
					_003CtryAgain_003E5__2 = true;
					CS_0024_003C_003E8__locals28.rhQa0ywLtV = AppContainer.Resolve<ISeasonService>();
					CS_0024_003C_003E8__locals28.gZGaGcnByj = AppContainer.Resolve<IStoreContext>();
					CS_0024_003C_003E8__locals28.WMnaa39CtC = AppContainer.Resolve<ISeriesService>();
				}
				goto IL_06a9;
				IL_003e:
				try
				{
					TaskAwaiter<Response<SeriesResponseDto>> awaiter5;
					TaskAwaiter<Response<SeasonResponseDto>> awaiter4;
					TaskAwaiter<MemoryStream> awaiter3;
					TaskAwaiter awaiter2;
					Response<SeriesResponseDto> result;
					IEnumerator<SeasonResponseDto> enumerator;
					Response<SeasonResponseDto> result2;
					switch (num)
					{
					default:
						DJvIicBs9HfhG4UlWP8.D35lls5iF(CS_0024_003C_003E8__locals28, DJvIicBs9HfhG4UlWP8.cfGBhmG0OU).Clear();
						awaiter5 = GbNEqHdeg9aWJg16yF1.D35lls5iF(CS_0024_003C_003E8__locals28.WMnaa39CtC, m9MGZR7k2RmVqYXYS5.D35lls5iF(wFALqDnBsAqnd0Cclwg.D35lls5iF(CS_0024_003C_003E8__locals28, wFALqDnBsAqnd0Cclwg.LrIdSQNxJo), m9MGZR7k2RmVqYXYS5.j871CQO7pP), GbNEqHdeg9aWJg16yF1.hgAdGSyKHE).GetAwaiter();
						if (!awaiter5.IsCompleted)
						{
							num = (_003C_003E1__state = 0);
							_003C_003Eu__1 = awaiter5;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter5, ref this);
							return;
						}
						goto IL_00da;
					case 0:
						awaiter5 = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter<Response<SeriesResponseDto>>);
						num = (_003C_003E1__state = -1);
						goto IL_00da;
					case 1:
						awaiter4 = _003C_003Eu__2;
						_003C_003Eu__2 = default(TaskAwaiter<Response<SeasonResponseDto>>);
						num = (_003C_003E1__state = -1);
						goto IL_02c7;
					case 2:
						awaiter3 = _003C_003Eu__3;
						_003C_003Eu__3 = default(TaskAwaiter<MemoryStream>);
						num = (_003C_003E1__state = -1);
						goto IL_048d;
					case 3:
						{
							awaiter2 = _003C_003Eu__4;
							_003C_003Eu__4 = default(TaskAwaiter);
							num = (_003C_003E1__state = -1);
							goto IL_04ff;
						}
						IL_048d:
						awaiter3.GetResult();
						awaiter2 = QliBEUviwWqgtMcBndV.D35lls5iF(pvrKKy8Mk1kpdmIfp3A.D35lls5iF(100, pvrKKy8Mk1kpdmIfp3A.aVh8SPrFkE), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
						if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter2, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
						{
							num = (_003C_003E1__state = 3);
							_003C_003Eu__4 = awaiter2;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						}
						goto IL_04ff;
						IL_00da:
						result = awaiter5.GetResult();
						uHGYs3B9JpKth46xJKm.D35lls5iF(CS_0024_003C_003E8__locals28, result.Data, uHGYs3B9JpKth46xJKm.kFEB7qjXJ1);
						qni3xrDkAJ3vF35eMav.D35lls5iF(CS_0024_003C_003E8__locals28, iFZ5je3XFYKwkvcE5D.D35lls5iF(9308, iFZ5je3XFYKwkvcE5D.N06TeK0ao), qni3xrDkAJ3vF35eMav.QN6DuDtCWO);
						enumerator = U3lLMPdNPjmKkVUm6Oo.D35lls5iF(wFALqDnBsAqnd0Cclwg.D35lls5iF(CS_0024_003C_003E8__locals28, wFALqDnBsAqnd0Cclwg.LrIdSQNxJo), U3lLMPdNPjmKkVUm6Oo.eYFdOuGPV8).GetEnumerator();
						try
						{
							while (hjMnupQVVDlRZAYQJC.D35lls5iF(enumerator, hjMnupQVVDlRZAYQJC.QV1TFwytOj))
							{
								SeasonResponseDto current = enumerator.Current;
								if (M6ZErPEr2LZyWYpa5O.D35lls5iF(eVlRnEIaHT0dqvCx0Kx.D35lls5iF(current, eVlRnEIaHT0dqvCx0Kx.DV5dunh45e), M6ZErPEr2LZyWYpa5O.WjpdPX71fL))
								{
									m5sZxWmLHUhVHrJe8sC.D35lls5iF(current, eVlRnEIaHT0dqvCx0Kx.D35lls5iF(wFALqDnBsAqnd0Cclwg.D35lls5iF(CS_0024_003C_003E8__locals28, wFALqDnBsAqnd0Cclwg.LrIdSQNxJo), eVlRnEIaHT0dqvCx0Kx.hELdsUSdUE), m5sZxWmLHUhVHrJe8sC.S9UdhavmLH);
								}
								if (M6ZErPEr2LZyWYpa5O.D35lls5iF(eVlRnEIaHT0dqvCx0Kx.D35lls5iF(current, eVlRnEIaHT0dqvCx0Kx.DV5dunh45e), M6ZErPEr2LZyWYpa5O.WjpdPX71fL))
								{
									m5sZxWmLHUhVHrJe8sC.D35lls5iF(current, eVlRnEIaHT0dqvCx0Kx.D35lls5iF(wFALqDnBsAqnd0Cclwg.D35lls5iF(CS_0024_003C_003E8__locals28, wFALqDnBsAqnd0Cclwg.LrIdSQNxJo), eVlRnEIaHT0dqvCx0Kx.P6FdxJWL53), m5sZxWmLHUhVHrJe8sC.HKSdYBPqDJ);
								}
								DJvIicBs9HfhG4UlWP8.D35lls5iF(CS_0024_003C_003E8__locals28, DJvIicBs9HfhG4UlWP8.cfGBhmG0OU).Add(current);
							}
						}
						finally
						{
							if (num < 0 && enumerator != null)
							{
								xLO56JniGyickVjO1Ot.D35lls5iF(enumerator, xLO56JniGyickVjO1Ot.ydbT2bsoH4);
							}
						}
						kuM3EQBH0UbvDtfO5X1.D35lls5iF(CS_0024_003C_003E8__locals28, (m9MGZR7k2RmVqYXYS5.D35lls5iF(CS_0024_003C_003E8__locals28, m9MGZR7k2RmVqYXYS5.pDgBi9dwyi) == 0) ? DJvIicBs9HfhG4UlWP8.D35lls5iF(CS_0024_003C_003E8__locals28, DJvIicBs9HfhG4UlWP8.cfGBhmG0OU).FirstOrDefault() : DJvIicBs9HfhG4UlWP8.D35lls5iF(CS_0024_003C_003E8__locals28, DJvIicBs9HfhG4UlWP8.cfGBhmG0OU).FirstOrDefault((SeasonResponseDto P_0) => m9MGZR7k2RmVqYXYS5.D35lls5iF(P_0, m9MGZR7k2RmVqYXYS5.jmBBPkMUq4) == m9MGZR7k2RmVqYXYS5.D35lls5iF(CS_0024_003C_003E8__locals28, m9MGZR7k2RmVqYXYS5.pDgBi9dwyi)), kuM3EQBH0UbvDtfO5X1.GsDdg3XcOQ);
						if (VAFQRsBLuCrswPTaruv.D35lls5iF(CS_0024_003C_003E8__locals28, VAFQRsBLuCrswPTaruv.nPddifE3K1) != null)
						{
							awaiter4 = iKOxbndBxAauEpxcAg3.D35lls5iF(CS_0024_003C_003E8__locals28.rhQa0ywLtV, m9MGZR7k2RmVqYXYS5.D35lls5iF(VAFQRsBLuCrswPTaruv.D35lls5iF(CS_0024_003C_003E8__locals28, VAFQRsBLuCrswPTaruv.nPddifE3K1), m9MGZR7k2RmVqYXYS5.j871CQO7pP), iKOxbndBxAauEpxcAg3.GDFd04bD1W).GetAwaiter();
							if (!awaiter4.IsCompleted)
							{
								num = (_003C_003E1__state = 1);
								_003C_003Eu__2 = awaiter4;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
								return;
							}
							goto IL_02c7;
						}
						goto end_IL_003e;
						IL_050b:
						kuM3EQBH0UbvDtfO5X1.D35lls5iF(CS_0024_003C_003E8__locals28, _003Cseasonx_003E5__5.Data, kuM3EQBH0UbvDtfO5X1.SE9dyLp2Ik);
						break;
						IL_02c7:
						result2 = awaiter4.GetResult();
						_003Cseasonx_003E5__5 = result2;
						if (_003Cseasonx_003E5__5 == null || !_003Cseasonx_003E5__5.Status)
						{
							break;
						}
						if (M6ZErPEr2LZyWYpa5O.D35lls5iF(eVlRnEIaHT0dqvCx0Kx.D35lls5iF(_003Cseasonx_003E5__5.Data, eVlRnEIaHT0dqvCx0Kx.mSLdQXCldH), M6ZErPEr2LZyWYpa5O.WjpdPX71fL))
						{
							m5sZxWmLHUhVHrJe8sC.D35lls5iF(_003Cseasonx_003E5__5.Data, eVlRnEIaHT0dqvCx0Kx.D35lls5iF(wFALqDnBsAqnd0Cclwg.D35lls5iF(CS_0024_003C_003E8__locals28, wFALqDnBsAqnd0Cclwg.LrIdSQNxJo), eVlRnEIaHT0dqvCx0Kx.hELdsUSdUE), m5sZxWmLHUhVHrJe8sC.S9UdhavmLH);
						}
						if (M6ZErPEr2LZyWYpa5O.D35lls5iF(eVlRnEIaHT0dqvCx0Kx.D35lls5iF(_003Cseasonx_003E5__5.Data, eVlRnEIaHT0dqvCx0Kx.DV5dunh45e), M6ZErPEr2LZyWYpa5O.WjpdPX71fL))
						{
							m5sZxWmLHUhVHrJe8sC.D35lls5iF(_003Cseasonx_003E5__5.Data, eVlRnEIaHT0dqvCx0Kx.D35lls5iF(wFALqDnBsAqnd0Cclwg.D35lls5iF(CS_0024_003C_003E8__locals28, wFALqDnBsAqnd0Cclwg.LrIdSQNxJo), eVlRnEIaHT0dqvCx0Kx.P6FdxJWL53), m5sZxWmLHUhVHrJe8sC.HKSdYBPqDJ);
						}
						if (Rfe4g0pfhM1nR3u94hp.D35lls5iF(_003Cseasonx_003E5__5.Data, Rfe4g0pfhM1nR3u94hp.RYhdX5THtq) == 0.0)
						{
							Tr7S4tmbD38LrEkLtjT.D35lls5iF(_003Cseasonx_003E5__5.Data, Rfe4g0pfhM1nR3u94hp.D35lls5iF(wFALqDnBsAqnd0Cclwg.D35lls5iF(CS_0024_003C_003E8__locals28, wFALqDnBsAqnd0Cclwg.LrIdSQNxJo), Rfe4g0pfhM1nR3u94hp.cYKdfMn4lg), Tr7S4tmbD38LrEkLtjT.pnjdFIovZO);
						}
						if (!M6ZErPEr2LZyWYpa5O.D35lls5iF(eVlRnEIaHT0dqvCx0Kx.D35lls5iF(_003Cseasonx_003E5__5.Data, eVlRnEIaHT0dqvCx0Kx.SpEd2Oc18V), M6ZErPEr2LZyWYpa5O.WjpdPX71fL))
						{
							awaiter3 = SJd7PJdZd6ObcySHIoO.D35lls5iF(d27jrd3uD0dgsTkvn8k.D35lls5iF(hjMnupQVVDlRZAYQJC.D35lls5iF(CS_0024_003C_003E8__locals28.gZGaGcnByj, hjMnupQVVDlRZAYQJC.YLV3Oa3St2), eVlRnEIaHT0dqvCx0Kx.D35lls5iF(_003Cseasonx_003E5__5.Data, eVlRnEIaHT0dqvCx0Kx.SpEd2Oc18V), d27jrd3uD0dgsTkvn8k.fC53Pw5IkY), SJd7PJdZd6ObcySHIoO.dCfdjKg5IF).GetAwaiter();
							if (!awaiter3.IsCompleted)
							{
								num = (_003C_003E1__state = 2);
								_003C_003Eu__3 = awaiter3;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
								return;
							}
							goto IL_048d;
						}
						goto IL_050b;
						IL_04ff:
						oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter2, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
						goto IL_050b;
					}
					zj2IKfdqNVuexnancIZ.D35lls5iF(CS_0024_003C_003E8__locals28, zj2IKfdqNVuexnancIZ.R4mdJ2iYdw).Clear();
					IEnumerator<EpisodeResponseDto> enumerator2 = (from x in YSuLOTwrQd4DCj824wQ.D35lls5iF(VAFQRsBLuCrswPTaruv.D35lls5iF(CS_0024_003C_003E8__locals28, VAFQRsBLuCrswPTaruv.JwBdK6ZfaJ), YSuLOTwrQd4DCj824wQ.QA3dbsllVb)
						orderby WJbFtI6AObf2rNffLCy.D35lls5iF(x, WJbFtI6AObf2rNffLCy.eOGdcSctuq)
						select x).GetEnumerator();
					try
					{
						while (hjMnupQVVDlRZAYQJC.D35lls5iF(enumerator2, hjMnupQVVDlRZAYQJC.QV1TFwytOj))
						{
							EpisodeResponseDto current2 = enumerator2.Current;
							zj2IKfdqNVuexnancIZ.D35lls5iF(CS_0024_003C_003E8__locals28, zj2IKfdqNVuexnancIZ.R4mdJ2iYdw).Add(current2);
						}
					}
					finally
					{
						if (num < 0 && enumerator2 != null)
						{
							xLO56JniGyickVjO1Ot.D35lls5iF(enumerator2, xLO56JniGyickVjO1Ot.ydbT2bsoH4);
						}
					}
					_003Cseasonx_003E5__5 = null;
					end_IL_003e:;
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
						num = (_003C_003E1__state = 4);
						_003C_003Eu__5 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_0675;
				}
				goto IL_06a9;
				IL_06b0:
				if (_003CtryAgain_003E5__2)
				{
					_003CtryAgain_003E5__2 = false;
					_003C_003E7__wrap3 = 0;
					goto IL_003e;
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

	private bool wjKadJ6t24;

	[CompilerGenerated]
	private ICommand NrxaPLTlul;

	private SeasonResponseDto FLbaqBljZU;

	[CompilerGenerated]
	private SeriesResponseDto SpaaIYTASA;

	[CompilerGenerated]
	private readonly int FOiaVf69Pv;

	private ISeriesService WMnaa39CtC;

	private ISeasonService rhQa0ywLtV;

	private IStoreContext gZGaGcnByj;

	private readonly HomeViewModel CgfaTmXYfb;

	[CompilerGenerated]
	private ObservableCollection<SeasonResponseDto> Li1aZeegkT;

	[CompilerGenerated]
	private ObservableCollection<EpisodeResponseDto> G0watfXQnr;

	private MainViewModel W2YaSnU0fP;

	private SeasonResponseDto mwQaf2BU2C;

	public bool IsRenting
	{
		get
		{
			return wjKadJ6t24;
		}
		set
		{
			wjKadJ6t24 = value;
			qni3xrDkAJ3vF35eMav.D35lls5iF(this, iFZ5je3XFYKwkvcE5D.D35lls5iF(10164, iFZ5je3XFYKwkvcE5D.N06TeK0ao), qni3xrDkAJ3vF35eMav.QN6DuDtCWO);
		}
	}

	public ICommand PlayOrRentMovieCommand
	{
		[CompilerGenerated]
		get
		{
			return NrxaPLTlul;
		}
		[CompilerGenerated]
		set
		{
			NrxaPLTlul = value;
		}
	}

	public SeasonResponseDto ViewSeason
	{
		get
		{
			return FLbaqBljZU;
		}
		set
		{
			SetProperty(ref FLbaqBljZU, value, iFZ5je3XFYKwkvcE5D.D35lls5iF(11730, iFZ5je3XFYKwkvcE5D.N06TeK0ao));
		}
	}

	public SeriesResponseDto Series
	{
		[CompilerGenerated]
		get
		{
			return SpaaIYTASA;
		}
		[CompilerGenerated]
		set
		{
			SpaaIYTASA = value;
		}
	}

	public int SelectedIndex
	{
		[CompilerGenerated]
		get
		{
			return FOiaVf69Pv;
		}
	}

	public ObservableCollection<SeasonResponseDto> Seasons
	{
		[CompilerGenerated]
		get
		{
			return Li1aZeegkT;
		}
		[CompilerGenerated]
		set
		{
			Li1aZeegkT = value;
		}
	}

	public ObservableCollection<EpisodeResponseDto> Episodes
	{
		[CompilerGenerated]
		get
		{
			return G0watfXQnr;
		}
		[CompilerGenerated]
		set
		{
			G0watfXQnr = value;
		}
	}

	public SeasonResponseDto SelectedSeason
	{
		get
		{
			return mwQaf2BU2C;
		}
		set
		{
			_003C_003Ec__DisplayClass35_0 CS_0024_003C_003E8__locals4 = new _003C_003Ec__DisplayClass35_0();
			CS_0024_003C_003E8__locals4.wd0fCKk266 = this;
			CS_0024_003C_003E8__locals4.U8VfYvdWOq = value;
			SetProperty(ref mwQaf2BU2C, CS_0024_003C_003E8__locals4.U8VfYvdWOq, iFZ5je3XFYKwkvcE5D.D35lls5iF(11754, iFZ5je3XFYKwkvcE5D.N06TeK0ao), null, [AsyncStateMachine(typeof(_003C_003Ec__DisplayClass35_0.HUVuJkrRle0QdyNXQm))] () =>
			{
				_003C_003Ec__DisplayClass35_0.HUVuJkrRle0QdyNXQm stateMachine = default(_003C_003Ec__DisplayClass35_0.HUVuJkrRle0QdyNXQm);
				stateMachine.zjxbLGqGdQ = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
				stateMachine.B9Fb2ORLKw = CS_0024_003C_003E8__locals4;
				stateMachine.zx9bU6pOfG = -1;
				stateMachine.zjxbLGqGdQ.Start(ref stateMachine);
			});
		}
	}

	public SeriesItemViewModel(SeriesResponseDto series)
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		this._002Ector();
		uHGYs3B9JpKth46xJKm.D35lls5iF(this, series, uHGYs3B9JpKth46xJKm.kFEB7qjXJ1);
	}

	public SeriesItemViewModel()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector();
		WMnaa39CtC = AppContainer.Resolve<ISeriesService>();
		rhQa0ywLtV = AppContainer.Resolve<ISeasonService>();
		gZGaGcnByj = AppContainer.Resolve<IStoreContext>();
		CgfaTmXYfb = AppContainer.Resolve<HomeViewModel>();
		faNm7BBciUiSZG7LG7S.D35lls5iF(this, new ObservableCollection<SeasonResponseDto>(), faNm7BBciUiSZG7LG7S.IGtBMjtJvr);
		ytLKwMBSdNhS61pdo7W.D35lls5iF(this, new ObservableCollection<EpisodeResponseDto>(), ytLKwMBSdNhS61pdo7W.FOPBK8fyyO);
		W2YaSnU0fP = AppContainer.Resolve<MainViewModel>();
		KFPqfXEA4bOmtrXTkLA.D35lls5iF(this, new AsyncCommand<EpisodeResponseDto>(OLlaWT5rSG), KFPqfXEA4bOmtrXTkLA.alrBNchc8v);
	}

	public SeriesItemViewModel(SeasonResponseDto season)
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		this._002Ector();
		SeriesResponseDto seriesResponseDto = new SeriesResponseDto();
		vQKA0r9sJ1kArsIHc16.D35lls5iF(seriesResponseDto, m9MGZR7k2RmVqYXYS5.D35lls5iF(season, m9MGZR7k2RmVqYXYS5.dsdBOvWm9O), vQKA0r9sJ1kArsIHc16.g5gBuJfp1j);
		uHGYs3B9JpKth46xJKm.D35lls5iF(this, seriesResponseDto, uHGYs3B9JpKth46xJKm.kFEB7qjXJ1);
		FOiaVf69Pv = m9MGZR7k2RmVqYXYS5.D35lls5iF(season, m9MGZR7k2RmVqYXYS5.jmBBPkMUq4);
	}

	[AsyncStateMachine(typeof(_003COnPlayOrRentMovieCommandExcute_003Ed__39))]
	private Task OLlaWT5rSG(EpisodeResponseDto P_0)
	{
		_003COnPlayOrRentMovieCommandExcute_003Ed__39 stateMachine = default(_003COnPlayOrRentMovieCommandExcute_003Ed__39);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine.episode = P_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	[AsyncStateMachine(typeof(_003CRentEpisode_003Ed__40))]
	private Task jBta44J4La(EpisodeResponseDto P_0)
	{
		_003CRentEpisode_003Ed__40 stateMachine = default(_003CRentEpisode_003Ed__40);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine.episode = P_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	[AsyncStateMachine(typeof(_003CLoadAsync_003Ed__41))]
	public Task LoadAsync()
	{
		_003CLoadAsync_003Ed__41 stateMachine = default(_003CLoadAsync_003Ed__41);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	public override void OnLoading()
	{
		if (DJvIicBs9HfhG4UlWP8.D35lls5iF(this, DJvIicBs9HfhG4UlWP8.cfGBhmG0OU).Count == 0)
		{
			Task task = CRMxYv82mIBQFuWGeba.D35lls5iF(this, CRMxYv82mIBQFuWGeba.GPiBxsuSVL);
			Action<Exception> action = null;
			bool flag = false;
			gBlEqv8jRKikCj2DMZp.D35lls5iF(task, ref action, ref flag, gBlEqv8jRKikCj2DMZp.pSp8ymt8Mu);
		}
	}

	public override void OnUnLoading()
	{
		fp757nBYjo8889efKFJ.D35lls5iF(this, fp757nBYjo8889efKFJ.lw2BgSX3u2);
	}

	[CompilerGenerated]
	[AsyncStateMachine(typeof(_003C_003CLoadAsync_003Eb__41_1_003Ed))]
	private Task rCQaBwTxtR()
	{
		_003C_003CLoadAsync_003Eb__41_1_003Ed stateMachine = default(_003C_003CLoadAsync_003Eb__41_1_003Ed);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	[CompilerGenerated]
	private bool sooaDrTK4u(SeasonResponseDto P_0)
	{
		return m9MGZR7k2RmVqYXYS5.D35lls5iF(P_0, m9MGZR7k2RmVqYXYS5.jmBBPkMUq4) == m9MGZR7k2RmVqYXYS5.D35lls5iF(this, m9MGZR7k2RmVqYXYS5.pDgBi9dwyi);
	}
}
