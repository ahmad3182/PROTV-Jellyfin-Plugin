using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using PROTV.Wpf.Views;

namespace PROTV.Wpf.ViewModels;

public class MusicPlaylistsViewModel : BaseListViewModel<PlaylistResponseDto<SongResponseDto>, ApiQuery<PlaylistSearch, GeneralSort>>
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass20_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct y7L8I2y3q6bSq9aNAE : IAsyncStateMachine
		{
			public int wcXnUIu4HR;

			public AsyncVoidMethodBuilder Ki5nLcxtSX;

			public _003C_003Ec__DisplayClass20_0 Fd4n2ugoLB;

			private ResponseList<PlaylistResponseDto<SongResponseDto>> sTRnzQg0SE;

			private TaskAwaiter<ResponseList<PlaylistResponseDto<SongResponseDto>>> mS6bcWeLTD;

			private IEnumerator<PlaylistResponseDto<SongResponseDto>> Uq9bjcfRN7;

			private PlaylistResponseDto<SongResponseDto> RFHbvyKPjF;

			private TaskAwaiter OejbWUIXTl;

			private void MoveNext()
			{
				int num = wcXnUIu4HR;
				_003C_003Ec__DisplayClass20_0 obj = Fd4n2ugoLB;
				try
				{
					if ((uint)num > 1u)
					{
						obj.vFMSVWC3Qq.Items.Clear();
					}
					try
					{
						TaskAwaiter<ResponseList<PlaylistResponseDto<SongResponseDto>>> awaiter;
						if (num != 0)
						{
							if (num == 1)
							{
								goto IL_0283;
							}
							obj.vFMSVWC3Qq.SearchQuery.Page = 1;
							if (S1a0wT9Ixre9OpDny8h.D35lls5iF(eVlRnEIaHT0dqvCx0Kx.D35lls5iF(obj.SgFSa2YvuR, eVlRnEIaHT0dqvCx0Kx.fa575yQKq4), iFZ5je3XFYKwkvcE5D.D35lls5iF(17100, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO))
							{
								lASFo76QIUBEikAAsE9.D35lls5iF(obj.vFMSVWC3Qq.SearchQuery.Search, Language.English, lASFo76QIUBEikAAsE9.UMA6X462Ew);
							}
							if (S1a0wT9Ixre9OpDny8h.D35lls5iF(eVlRnEIaHT0dqvCx0Kx.D35lls5iF(obj.SgFSa2YvuR, eVlRnEIaHT0dqvCx0Kx.fa575yQKq4), iFZ5je3XFYKwkvcE5D.D35lls5iF(17118, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO))
							{
								lASFo76QIUBEikAAsE9.D35lls5iF(obj.vFMSVWC3Qq.SearchQuery.Search, Language.Arabic, lASFo76QIUBEikAAsE9.UMA6X462Ew);
							}
							if (S1a0wT9Ixre9OpDny8h.D35lls5iF(eVlRnEIaHT0dqvCx0Kx.D35lls5iF(obj.SgFSa2YvuR, eVlRnEIaHT0dqvCx0Kx.fa575yQKq4), iFZ5je3XFYKwkvcE5D.D35lls5iF(17134, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO))
							{
								lASFo76QIUBEikAAsE9.D35lls5iF(obj.vFMSVWC3Qq.SearchQuery.Search, Language.Other, lASFo76QIUBEikAAsE9.UMA6X462Ew);
							}
							if (S1a0wT9Ixre9OpDny8h.D35lls5iF(eVlRnEIaHT0dqvCx0Kx.D35lls5iF(obj.SgFSa2YvuR, eVlRnEIaHT0dqvCx0Kx.fa575yQKq4), iFZ5je3XFYKwkvcE5D.D35lls5iF(17148, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO))
							{
								lASFo76QIUBEikAAsE9.D35lls5iF(obj.vFMSVWC3Qq.SearchQuery.Search, Language.Turkish, lASFo76QIUBEikAAsE9.UMA6X462Ew);
							}
							if (S1a0wT9Ixre9OpDny8h.D35lls5iF(eVlRnEIaHT0dqvCx0Kx.D35lls5iF(obj.SgFSa2YvuR, eVlRnEIaHT0dqvCx0Kx.fa575yQKq4), iFZ5je3XFYKwkvcE5D.D35lls5iF(17166, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO))
							{
								lASFo76QIUBEikAAsE9.D35lls5iF(obj.vFMSVWC3Qq.SearchQuery.Search, Language.Japanese, lASFo76QIUBEikAAsE9.UMA6X462Ew);
							}
							awaiter = obj.vFMSVWC3Qq.JikPS7bn9q.GetPlaylistsAsync<SongResponseDto>(obj.vFMSVWC3Qq.SearchQuery).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = (wcXnUIu4HR = 0);
								mS6bcWeLTD = awaiter;
								Ki5nLcxtSX.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = mS6bcWeLTD;
							mS6bcWeLTD = default(TaskAwaiter<ResponseList<PlaylistResponseDto<SongResponseDto>>>);
							num = (wcXnUIu4HR = -1);
						}
						ResponseList<PlaylistResponseDto<SongResponseDto>> result = awaiter.GetResult();
						sTRnzQg0SE = result;
						if (sTRnzQg0SE != null && sTRnzQg0SE.Status)
						{
							Uq9bjcfRN7 = sTRnzQg0SE.Data.Result.GetEnumerator();
							goto IL_0283;
						}
						obj.vFMSVWC3Qq.TotalCount = 0;
						goto IL_03d8;
						IL_03d8:
						sTRnzQg0SE = null;
						goto end_IL_002d;
						IL_0283:
						try
						{
							if (num != 1)
							{
								goto IL_0332;
							}
							TaskAwaiter awaiter2 = OejbWUIXTl;
							OejbWUIXTl = default(TaskAwaiter);
							num = (wcXnUIu4HR = -1);
							goto IL_0309;
							IL_0309:
							oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter2, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
							obj.vFMSVWC3Qq.Items.Add(RFHbvyKPjF);
							RFHbvyKPjF = null;
							goto IL_0332;
							IL_0332:
							if (hjMnupQVVDlRZAYQJC.D35lls5iF(Uq9bjcfRN7, hjMnupQVVDlRZAYQJC.QV1TFwytOj))
							{
								RFHbvyKPjF = Uq9bjcfRN7.Current;
								awaiter2 = QliBEUviwWqgtMcBndV.D35lls5iF(pvrKKy8Mk1kpdmIfp3A.D35lls5iF(2, pvrKKy8Mk1kpdmIfp3A.aVh8SPrFkE), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
								if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter2, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
								{
									num = (wcXnUIu4HR = 1);
									OejbWUIXTl = awaiter2;
									Ki5nLcxtSX.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									return;
								}
								goto IL_0309;
							}
						}
						finally
						{
							if (num < 0 && Uq9bjcfRN7 != null)
							{
								xLO56JniGyickVjO1Ot.D35lls5iF(Uq9bjcfRN7, xLO56JniGyickVjO1Ot.ydbT2bsoH4);
							}
						}
						Uq9bjcfRN7 = null;
						obj.vFMSVWC3Qq.CurrentPage = sTRnzQg0SE.Data.CurrentPage;
						obj.vFMSVWC3Qq.PageCount = sTRnzQg0SE.Data.PageCount;
						obj.vFMSVWC3Qq.TotalCount = sTRnzQg0SE.Data.Total;
						goto IL_03d8;
						end_IL_002d:;
					}
					catch
					{
						obj.vFMSVWC3Qq.TotalCount = 0;
					}
				}
				catch (Exception ex)
				{
					wcXnUIu4HR = -2;
					N2XUglA3neBsnlZfRPQ.D35lls5iF(ref Ki5nLcxtSX, ex, N2XUglA3neBsnlZfRPQ.l4pATRumoW);
					return;
				}
				wcXnUIu4HR = -2;
				T4XmPoA4VNJJP1afcgL.D35lls5iF(ref Ki5nLcxtSX, T4XmPoA4VNJJP1afcgL.TRyALZckCh);
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine P_0)
			{
				dHWo7jAEn6E4X7bsY4R.D35lls5iF(ref Ki5nLcxtSX, P_0, dHWo7jAEn6E4X7bsY4R.z3hAB6UZ9o);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine P_0)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(P_0);
			}
		}

		public MusicPlaylistsViewModel vFMSVWC3Qq;

		public LanguageResponseDto SgFSa2YvuR;

		public _003C_003Ec__DisplayClass20_0()
		{
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
			base._002Ector();
		}

		[AsyncStateMachine(typeof(y7L8I2y3q6bSq9aNAE))]
		internal void RuhSI5NokD()
		{
			y7L8I2y3q6bSq9aNAE stateMachine = default(y7L8I2y3q6bSq9aNAE);
			stateMachine.Ki5nLcxtSX = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
			stateMachine.Fd4n2ugoLB = this;
			stateMachine.wcXnUIu4HR = -1;
			stateMachine.Ki5nLcxtSX.Start(ref stateMachine);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass23_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct VvrJOkpBROTJFCvE5S : IAsyncStateMachine
		{
			public int jBHb4RXwZ8;

			public AsyncVoidMethodBuilder L0JbBOxwkZ;

			public _003C_003Ec__DisplayClass23_0 aCbbD8WIOs;

			private ResponseList<PlaylistResponseDto<SongResponseDto>> EPibdQjAed;

			private TaskAwaiter<ResponseList<PlaylistResponseDto<SongResponseDto>>> er2bP6iFy2;

			private IEnumerator<PlaylistResponseDto<SongResponseDto>> UoJbqr4CdK;

			private PlaylistResponseDto<SongResponseDto> PQybIAHv99;

			private TaskAwaiter W5cbVWL5ha;

			private void MoveNext()
			{
				int num = jBHb4RXwZ8;
				_003C_003Ec__DisplayClass23_0 obj = aCbbD8WIOs;
				try
				{
					if ((uint)num > 1u)
					{
						obj.NIASGmsSPc.Items.Clear();
					}
					try
					{
						TaskAwaiter<ResponseList<PlaylistResponseDto<SongResponseDto>>> awaiter;
						if (num != 0)
						{
							if (num == 1)
							{
								goto IL_0113;
							}
							obj.NIASGmsSPc.SearchQuery.Page = 1;
							obj.NIASGmsSPc.SearchQuery.Order = obj.fDfSTHkeoe;
							awaiter = obj.NIASGmsSPc.JikPS7bn9q.GetPlaylistsAsync<SongResponseDto>(obj.NIASGmsSPc.SearchQuery).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = (jBHb4RXwZ8 = 0);
								er2bP6iFy2 = awaiter;
								L0JbBOxwkZ.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = er2bP6iFy2;
							er2bP6iFy2 = default(TaskAwaiter<ResponseList<PlaylistResponseDto<SongResponseDto>>>);
							num = (jBHb4RXwZ8 = -1);
						}
						ResponseList<PlaylistResponseDto<SongResponseDto>> result = awaiter.GetResult();
						EPibdQjAed = result;
						if (EPibdQjAed != null && EPibdQjAed.Status)
						{
							UoJbqr4CdK = EPibdQjAed.Data.Result.GetEnumerator();
							goto IL_0113;
						}
						obj.NIASGmsSPc.TotalCount = 0;
						goto IL_0268;
						IL_0268:
						EPibdQjAed = null;
						goto end_IL_002d;
						IL_0113:
						try
						{
							if (num != 1)
							{
								goto IL_01c2;
							}
							TaskAwaiter awaiter2 = W5cbVWL5ha;
							W5cbVWL5ha = default(TaskAwaiter);
							num = (jBHb4RXwZ8 = -1);
							goto IL_0199;
							IL_0199:
							oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter2, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
							obj.NIASGmsSPc.Items.Add(PQybIAHv99);
							PQybIAHv99 = null;
							goto IL_01c2;
							IL_01c2:
							if (hjMnupQVVDlRZAYQJC.D35lls5iF(UoJbqr4CdK, hjMnupQVVDlRZAYQJC.QV1TFwytOj))
							{
								PQybIAHv99 = UoJbqr4CdK.Current;
								awaiter2 = QliBEUviwWqgtMcBndV.D35lls5iF(pvrKKy8Mk1kpdmIfp3A.D35lls5iF(2, pvrKKy8Mk1kpdmIfp3A.aVh8SPrFkE), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
								if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter2, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
								{
									num = (jBHb4RXwZ8 = 1);
									W5cbVWL5ha = awaiter2;
									L0JbBOxwkZ.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									return;
								}
								goto IL_0199;
							}
						}
						finally
						{
							if (num < 0 && UoJbqr4CdK != null)
							{
								xLO56JniGyickVjO1Ot.D35lls5iF(UoJbqr4CdK, xLO56JniGyickVjO1Ot.ydbT2bsoH4);
							}
						}
						UoJbqr4CdK = null;
						obj.NIASGmsSPc.CurrentPage = EPibdQjAed.Data.CurrentPage;
						obj.NIASGmsSPc.PageCount = EPibdQjAed.Data.PageCount;
						obj.NIASGmsSPc.TotalCount = EPibdQjAed.Data.Total;
						goto IL_0268;
						end_IL_002d:;
					}
					catch
					{
						obj.NIASGmsSPc.TotalCount = 0;
					}
				}
				catch (Exception ex)
				{
					jBHb4RXwZ8 = -2;
					N2XUglA3neBsnlZfRPQ.D35lls5iF(ref L0JbBOxwkZ, ex, N2XUglA3neBsnlZfRPQ.l4pATRumoW);
					return;
				}
				jBHb4RXwZ8 = -2;
				T4XmPoA4VNJJP1afcgL.D35lls5iF(ref L0JbBOxwkZ, T4XmPoA4VNJJP1afcgL.TRyALZckCh);
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine P_0)
			{
				dHWo7jAEn6E4X7bsY4R.D35lls5iF(ref L0JbBOxwkZ, P_0, dHWo7jAEn6E4X7bsY4R.z3hAB6UZ9o);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine P_0)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(P_0);
			}
		}

		public MusicPlaylistsViewModel NIASGmsSPc;

		public SortOrder fDfSTHkeoe;

		public _003C_003Ec__DisplayClass23_0()
		{
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
			base._002Ector();
		}

		[AsyncStateMachine(typeof(VvrJOkpBROTJFCvE5S))]
		internal void SboS0MwG89()
		{
			VvrJOkpBROTJFCvE5S stateMachine = default(VvrJOkpBROTJFCvE5S);
			stateMachine.L0JbBOxwkZ = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
			stateMachine.aCbbD8WIOs = this;
			stateMachine.jBHb4RXwZ8 = -1;
			stateMachine.L0JbBOxwkZ.Start(ref stateMachine);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass26_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct N4udkJiIVvHZbeZZLy : IAsyncStateMachine
		{
			public int zx9bam2oxy;

			public AsyncVoidMethodBuilder ytEb08MoRJ;

			public _003C_003Ec__DisplayClass26_0 hL1bGMQkTl;

			private ResponseList<PlaylistResponseDto<SongResponseDto>> EpjbTgoV7L;

			private TaskAwaiter<ResponseList<PlaylistResponseDto<SongResponseDto>>> TfSbZH5ooo;

			private IEnumerator<PlaylistResponseDto<SongResponseDto>> Da4btKbSsg;

			private PlaylistResponseDto<SongResponseDto> iaebStygN4;

			private TaskAwaiter xmDbfJoiPO;

			private void MoveNext()
			{
				int num = zx9bam2oxy;
				_003C_003Ec__DisplayClass26_0 obj = hL1bGMQkTl;
				try
				{
					if ((uint)num > 1u)
					{
						obj.n58StMGvou.Items.Clear();
					}
					try
					{
						TaskAwaiter<ResponseList<PlaylistResponseDto<SongResponseDto>>> awaiter;
						if (num != 0)
						{
							if (num == 1)
							{
								goto IL_0113;
							}
							obj.n58StMGvou.SearchQuery.Page = 1;
							obj.n58StMGvou.SearchQuery.Sort = obj.JYTSS5AJi2;
							awaiter = obj.n58StMGvou.JikPS7bn9q.GetPlaylistsAsync<SongResponseDto>(obj.n58StMGvou.SearchQuery).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = (zx9bam2oxy = 0);
								TfSbZH5ooo = awaiter;
								ytEb08MoRJ.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = TfSbZH5ooo;
							TfSbZH5ooo = default(TaskAwaiter<ResponseList<PlaylistResponseDto<SongResponseDto>>>);
							num = (zx9bam2oxy = -1);
						}
						ResponseList<PlaylistResponseDto<SongResponseDto>> result = awaiter.GetResult();
						EpjbTgoV7L = result;
						if (EpjbTgoV7L != null && EpjbTgoV7L.Status)
						{
							Da4btKbSsg = EpjbTgoV7L.Data.Result.GetEnumerator();
							goto IL_0113;
						}
						obj.n58StMGvou.TotalCount = 0;
						goto IL_0268;
						IL_0268:
						EpjbTgoV7L = null;
						goto end_IL_002d;
						IL_0113:
						try
						{
							if (num != 1)
							{
								goto IL_01c2;
							}
							TaskAwaiter awaiter2 = xmDbfJoiPO;
							xmDbfJoiPO = default(TaskAwaiter);
							num = (zx9bam2oxy = -1);
							goto IL_0199;
							IL_0199:
							oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter2, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
							obj.n58StMGvou.Items.Add(iaebStygN4);
							iaebStygN4 = null;
							goto IL_01c2;
							IL_01c2:
							if (hjMnupQVVDlRZAYQJC.D35lls5iF(Da4btKbSsg, hjMnupQVVDlRZAYQJC.QV1TFwytOj))
							{
								iaebStygN4 = Da4btKbSsg.Current;
								awaiter2 = QliBEUviwWqgtMcBndV.D35lls5iF(pvrKKy8Mk1kpdmIfp3A.D35lls5iF(2, pvrKKy8Mk1kpdmIfp3A.aVh8SPrFkE), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
								if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter2, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
								{
									num = (zx9bam2oxy = 1);
									xmDbfJoiPO = awaiter2;
									ytEb08MoRJ.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									return;
								}
								goto IL_0199;
							}
						}
						finally
						{
							if (num < 0 && Da4btKbSsg != null)
							{
								xLO56JniGyickVjO1Ot.D35lls5iF(Da4btKbSsg, xLO56JniGyickVjO1Ot.ydbT2bsoH4);
							}
						}
						Da4btKbSsg = null;
						obj.n58StMGvou.CurrentPage = EpjbTgoV7L.Data.CurrentPage;
						obj.n58StMGvou.PageCount = EpjbTgoV7L.Data.PageCount;
						obj.n58StMGvou.TotalCount = EpjbTgoV7L.Data.Total;
						goto IL_0268;
						end_IL_002d:;
					}
					catch
					{
						obj.n58StMGvou.TotalCount = 0;
					}
				}
				catch (Exception ex)
				{
					zx9bam2oxy = -2;
					N2XUglA3neBsnlZfRPQ.D35lls5iF(ref ytEb08MoRJ, ex, N2XUglA3neBsnlZfRPQ.l4pATRumoW);
					return;
				}
				zx9bam2oxy = -2;
				T4XmPoA4VNJJP1afcgL.D35lls5iF(ref ytEb08MoRJ, T4XmPoA4VNJJP1afcgL.TRyALZckCh);
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine P_0)
			{
				dHWo7jAEn6E4X7bsY4R.D35lls5iF(ref ytEb08MoRJ, P_0, dHWo7jAEn6E4X7bsY4R.z3hAB6UZ9o);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine P_0)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(P_0);
			}
		}

		public MusicPlaylistsViewModel n58StMGvou;

		public GeneralSort JYTSS5AJi2;

		public _003C_003Ec__DisplayClass26_0()
		{
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
			base._002Ector();
		}

		[AsyncStateMachine(typeof(N4udkJiIVvHZbeZZLy))]
		internal void JvqSZeQNhw()
		{
			N4udkJiIVvHZbeZZLy stateMachine = default(N4udkJiIVvHZbeZZLy);
			stateMachine.ytEb08MoRJ = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
			stateMachine.hL1bGMQkTl = this;
			stateMachine.zx9bam2oxy = -1;
			stateMachine.ytEb08MoRJ.Start(ref stateMachine);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLoadAlbums_003Ed__28 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MusicPlaylistsViewModel _003C_003E4__this;

		private ResponseList<PlaylistResponseDto<SongResponseDto>> _003Cresult_003E5__2;

		private TaskAwaiter<Response<ClientResponseDto>> _003C_003Eu__1;

		private TaskAwaiter<ResponseList<PlaylistResponseDto<SongResponseDto>>> _003C_003Eu__2;

		private IEnumerator<PlaylistResponseDto<SongResponseDto>> _003C_003E7__wrap2;

		private PlaylistResponseDto<SongResponseDto> _003Citem_003E5__4;

		private TaskAwaiter _003C_003Eu__3;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			MusicPlaylistsViewModel musicPlaylistsViewModel = _003C_003E4__this;
			try
			{
				if ((uint)num > 2u)
				{
					musicPlaylistsViewModel.Items.Clear();
					musicPlaylistsViewModel.SearchQuery.Page = 1;
					musicPlaylistsViewModel.SearchQuery.Count = 25;
					musicPlaylistsViewModel.SearchQuery.Sort = GeneralSort.ActivateDate;
					musicPlaylistsViewModel.SearchQuery.Order = SortOrder.Desc;
				}
				try
				{
					TaskAwaiter<Response<ClientResponseDto>> awaiter2;
					TaskAwaiter<ResponseList<PlaylistResponseDto<SongResponseDto>>> awaiter;
					ResponseList<PlaylistResponseDto<SongResponseDto>> result;
					ObservableCollection<PlaylistResponseDto<SongResponseDto>> items;
					PlaylistResponseDto<SongResponseDto> playlistResponseDto;
					int num2;
					switch (num)
					{
					default:
						awaiter2 = SqjjUvmGqDMwa2QvHVC.D35lls5iF(AppContainer.Resolve<IAuthService>(), SqjjUvmGqDMwa2QvHVC.VDcmRueweU).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = (_003C_003E1__state = 0);
							_003C_003Eu__1 = awaiter2;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						}
						goto IL_00cc;
					case 0:
						awaiter2 = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter<Response<ClientResponseDto>>);
						num = (_003C_003E1__state = -1);
						goto IL_00cc;
					case 1:
						awaiter = _003C_003Eu__2;
						_003C_003Eu__2 = default(TaskAwaiter<ResponseList<PlaylistResponseDto<SongResponseDto>>>);
						num = (_003C_003E1__state = -1);
						goto IL_019d;
					case 2:
						{
							try
							{
								if (num != 2)
								{
									goto IL_028f;
								}
								TaskAwaiter awaiter3 = _003C_003Eu__3;
								_003C_003Eu__3 = default(TaskAwaiter);
								num = (_003C_003E1__state = -1);
								goto IL_026b;
								IL_026b:
								oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter3, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
								musicPlaylistsViewModel.Items.Add(_003Citem_003E5__4);
								_003Citem_003E5__4 = null;
								goto IL_028f;
								IL_028f:
								if (hjMnupQVVDlRZAYQJC.D35lls5iF(_003C_003E7__wrap2, hjMnupQVVDlRZAYQJC.QV1TFwytOj))
								{
									_003Citem_003E5__4 = _003C_003E7__wrap2.Current;
									awaiter3 = QliBEUviwWqgtMcBndV.D35lls5iF(pvrKKy8Mk1kpdmIfp3A.D35lls5iF(2, pvrKKy8Mk1kpdmIfp3A.aVh8SPrFkE), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
									if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter3, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
									{
										num = (_003C_003E1__state = 2);
										_003C_003Eu__3 = awaiter3;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
										return;
									}
									goto IL_026b;
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
							musicPlaylistsViewModel.CurrentPage = _003Cresult_003E5__2.Data.CurrentPage;
							musicPlaylistsViewModel.PageCount = _003Cresult_003E5__2.Data.PageCount;
							musicPlaylistsViewModel.TotalCount = _003Cresult_003E5__2.Data.Total;
							break;
						}
						IL_019d:
						result = awaiter.GetResult();
						_003Cresult_003E5__2 = result;
						if (_003Cresult_003E5__2 != null && _003Cresult_003E5__2.Status)
						{
							_003C_003E7__wrap2 = _003Cresult_003E5__2.Data.Result.GetEnumerator();
							goto case 2;
						}
						musicPlaylistsViewModel.TotalCount = musicPlaylistsViewModel.Items.Count;
						break;
						IL_00cc:
						awaiter2.GetResult();
						items = musicPlaylistsViewModel.Items;
						playlistResponseDto = new PlaylistResponseDto<SongResponseDto>();
						num2 = WJbFtI6AObf2rNffLCy.D35lls5iF(uDRo1NTTfYDM7pYeNXf.D35lls5iF(musicPlaylistsViewModel.fyJPKj3dYT, uDRo1NTTfYDM7pYeNXf.vmET4kj87M), WJbFtI6AObf2rNffLCy.LFdmkjXPlQ);
						playlistResponseDto.ItemsCount = E1oqfbTdQ1YrEeaxoPg.D35lls5iF(ref num2, E1oqfbTdQ1YrEeaxoPg.beYTUkKTth);
						playlistResponseDto.Id = 0;
						playlistResponseDto.Items = new List<SongResponseDto>();
						playlistResponseDto.Title = iFZ5je3XFYKwkvcE5D.D35lls5iF(16398, iFZ5je3XFYKwkvcE5D.N06TeK0ao);
						items.Add(playlistResponseDto);
						awaiter = musicPlaylistsViewModel.JikPS7bn9q.GetPlaylistsAsync<SongResponseDto>(musicPlaylistsViewModel.SearchQuery).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (_003C_003E1__state = 1);
							_003C_003Eu__2 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_019d;
					}
					_003Cresult_003E5__2 = null;
				}
				catch
				{
					musicPlaylistsViewModel.TotalCount = musicPlaylistsViewModel.Items.Count;
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
	private struct _003COnFetchMoreDataCommand_003Ed__30 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MusicPlaylistsViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			MusicPlaylistsViewModel musicPlaylistsViewModel = _003C_003E4__this;
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
				if (musicPlaylistsViewModel.CurrentPage < musicPlaylistsViewModel.TotalCount && !hjMnupQVVDlRZAYQJC.D35lls5iF(musicPlaylistsViewModel, hjMnupQVVDlRZAYQJC.jJYTSHn9tB))
				{
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(musicPlaylistsViewModel.AddMoreItems(), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
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
	private struct _003CAddMoreItems_003Ed__32 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MusicPlaylistsViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			MusicPlaylistsViewModel CS_0024_003C_003E8__locals5 = _003C_003E4__this;
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
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(W7S2sip6SDieZFVsNbd.D35lls5iF(CS_0024_003C_003E8__locals5, Expression.Lambda<Func<bool>>(OWBKr5pvc5MWsK1OMtR.D35lls5iF(o4bYL4peNeC2wWb8yjx.D35lls5iF(CS_0024_003C_003E8__locals5, sjYxHO8OWlc6X80hFj7.D35lls5iF(typeof(MusicPlaylistsViewModel).TypeHandle, sjYxHO8OWlc6X80hFj7.uWZ8ugU7r5), o4bYL4peNeC2wWb8yjx.oVdpGKjy2x), (MethodInfo)f5q427pRQZnrEKPy4Ws.D35lls5iF((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, f5q427pRQZnrEKPy4Ws.Bo9pk3m4k7), OWBKr5pvc5MWsK1OMtR.fZIpAAdi1v), Array.Empty<ParameterExpression>()), [AsyncStateMachine(typeof(_003C_003CAddMoreItems_003Eb__32_1_003Ed))] () =>
					{
						_003C_003CAddMoreItems_003Eb__32_1_003Ed stateMachine = default(_003C_003CAddMoreItems_003Eb__32_1_003Ed);
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

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass33_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct qF14DJ3gT4pGGnEofA : IAsyncStateMachine
		{
			public int e6KbKG8fnM;

			public AsyncTaskMethodBuilder bPUbkNIGdF;

			public _003C_003Ec__DisplayClass33_0 fP4b8JfNAl;

			private HomeViewModel hGXbQAYLDo;

			private MainPlayerViewModel AbbbnLsbms;

			private Page DWPbbL9XxN;

			private TaskAwaiter Y8Xb7lFhx7;

			private void MoveNext()
			{
				int num = e6KbKG8fnM;
				_003C_003Ec__DisplayClass33_0 obj = fP4b8JfNAl;
				try
				{
					TaskAwaiter awaiter;
					if (num == 0)
					{
						awaiter = Y8Xb7lFhx7;
						Y8Xb7lFhx7 = default(TaskAwaiter);
						num = (e6KbKG8fnM = -1);
						goto IL_0108;
					}
					if (num == 1)
					{
						awaiter = Y8Xb7lFhx7;
						Y8Xb7lFhx7 = default(TaskAwaiter);
						num = (e6KbKG8fnM = -1);
						goto IL_01b9;
					}
					if (S1a0wT9Ixre9OpDny8h.D35lls5iF(obj.SuSSk5WI13.ItemsCount, iFZ5je3XFYKwkvcE5D.D35lls5iF(13996, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.oE0cHwnL2d))
					{
						hGXbQAYLDo = Sp7dKWL9ZfBld4JOkGo.D35lls5iF(AppContainer.Resolve<MainViewModel>(), Sp7dKWL9ZfBld4JOkGo.QpWwMTMAhO) as HomeViewModel;
						AbbbnLsbms = MI3oOiHCZASyM6ERRUP.D35lls5iF(hGXbQAYLDo, MI3oOiHCZASyM6ERRUP.h0JHmOSEFB);
						awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(LoKHJec9qUyy294NoZ5.D35lls5iF(AbbbnLsbms, MusicType.Playlist, obj.SuSSk5WI13.Id, obj.SuSSk5WI13.Title, null, null, null, LoKHJec9qUyy294NoZ5.FXGcDq3bhE), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
						if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
						{
							num = (e6KbKG8fnM = 0);
							Y8Xb7lFhx7 = awaiter;
							bPUbkNIGdF.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_0108;
					}
					gsYNF433WqUIGma3CNX.D35lls5iF(iFZ5je3XFYKwkvcE5D.D35lls5iF(17186, iFZ5je3XFYKwkvcE5D.N06TeK0ao), "", gsYNF433WqUIGma3CNX.wsZc1wF5Qh);
					goto end_IL_0015;
					IL_01b9:
					oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
					GmMLaTD7kV8rq88ZFvR.D35lls5iF(Xlypb0Hnr2C3ydrYEdG.D35lls5iF(hGXbQAYLDo, Xlypb0Hnr2C3ydrYEdG.U3Z1IKMGuZ), DWPbbL9XxN, GmMLaTD7kV8rq88ZFvR.iMJHkmaaRY);
					hGXbQAYLDo = null;
					AbbbnLsbms = null;
					DWPbbL9XxN = null;
					goto end_IL_0015;
					IL_0108:
					oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
					Page page = new Page();
					KBhlAv9D2TgBJ1kkc0B.D35lls5iF(page, IyGDDwHBiPv8vfOFJDF.D35lls5iF(ApplicationPage.PlayListDetailsView, AbbbnLsbms, IyGDDwHBiPv8vfOFJDF.hivH0XYhaE), KBhlAv9D2TgBJ1kkc0B.fWUHrWO7Sa);
					qni3xrDkAJ3vF35eMav.D35lls5iF(page, EBgwuVHeVLDJVVfMaAk.D35lls5iF(ApplicationPage.PlayListDetailsView, EBgwuVHeVLDJVVfMaAk.mtcHG3MEy3), qni3xrDkAJ3vF35eMav.Ra7HRFTvnD);
					DWPbbL9XxN = page;
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(pvrKKy8Mk1kpdmIfp3A.D35lls5iF(5, pvrKKy8Mk1kpdmIfp3A.aVh8SPrFkE), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
					if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
					{
						num = (e6KbKG8fnM = 1);
						Y8Xb7lFhx7 = awaiter;
						bPUbkNIGdF.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_01b9;
					end_IL_0015:;
				}
				catch (Exception ex)
				{
					e6KbKG8fnM = -2;
					NNK1eXA7fWQ87oSUty7.D35lls5iF(ref bPUbkNIGdF, ex, NNK1eXA7fWQ87oSUty7.G3EAcW9Om7);
					return;
				}
				e6KbKG8fnM = -2;
				meFicnAMHIVtdhf671p.D35lls5iF(ref bPUbkNIGdF, meFicnAMHIVtdhf671p.bsDASenQ5I);
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine P_0)
			{
				vxBFJcAKZoecNtbdqxt.D35lls5iF(ref bPUbkNIGdF, P_0, vxBFJcAKZoecNtbdqxt.tuxANdhu18);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine P_0)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(P_0);
			}
		}

		public MusicPlaylistsViewModel aolSK4ZpW9;

		public PlaylistResponseDto<SongResponseDto> SuSSk5WI13;

		public _003C_003Ec__DisplayClass33_0()
		{
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
			base._002Ector();
		}

		[AsyncStateMachine(typeof(qF14DJ3gT4pGGnEofA))]
		internal Task lfqSfQmUNb()
		{
			qF14DJ3gT4pGGnEofA stateMachine = default(qF14DJ3gT4pGGnEofA);
			stateMachine.bPUbkNIGdF = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
			stateMachine.fP4b8JfNAl = this;
			stateMachine.e6KbKG8fnM = -1;
			stateMachine.bPUbkNIGdF.Start(ref stateMachine);
			return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine.bPUbkNIGdF, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGoToPage_003Ed__33 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MusicPlaylistsViewModel _003C_003E4__this;

		public PlaylistResponseDto<SongResponseDto> model;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			MusicPlaylistsViewModel musicPlaylistsViewModel = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					_003C_003Ec__DisplayClass33_0 CS_0024_003C_003E8__locals3 = new _003C_003Ec__DisplayClass33_0();
					CS_0024_003C_003E8__locals3.aolSK4ZpW9 = _003C_003E4__this;
					CS_0024_003C_003E8__locals3.SuSSk5WI13 = model;
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(W7S2sip6SDieZFVsNbd.D35lls5iF(musicPlaylistsViewModel, Expression.Lambda<Func<bool>>(OWBKr5pvc5MWsK1OMtR.D35lls5iF(o4bYL4peNeC2wWb8yjx.D35lls5iF(musicPlaylistsViewModel, sjYxHO8OWlc6X80hFj7.D35lls5iF(typeof(MusicPlaylistsViewModel).TypeHandle, sjYxHO8OWlc6X80hFj7.uWZ8ugU7r5), o4bYL4peNeC2wWb8yjx.oVdpGKjy2x), (MethodInfo)f5q427pRQZnrEKPy4Ws.D35lls5iF((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, f5q427pRQZnrEKPy4Ws.Bo9pk3m4k7), OWBKr5pvc5MWsK1OMtR.fZIpAAdi1v), Array.Empty<ParameterExpression>()), [AsyncStateMachine(typeof(_003C_003Ec__DisplayClass33_0.qF14DJ3gT4pGGnEofA))] () =>
					{
						_003C_003Ec__DisplayClass33_0.qF14DJ3gT4pGGnEofA stateMachine = default(_003C_003Ec__DisplayClass33_0.qF14DJ3gT4pGGnEofA);
						stateMachine.bPUbkNIGdF = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
						stateMachine.fP4b8JfNAl = CS_0024_003C_003E8__locals3;
						stateMachine.e6KbKG8fnM = -1;
						stateMachine.bPUbkNIGdF.Start(ref stateMachine);
						return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine.bPUbkNIGdF, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
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
	private struct _003CLoadAsync_003Ed__35 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MusicPlaylistsViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			MusicPlaylistsViewModel CS_0024_003C_003E8__locals3 = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(W7S2sip6SDieZFVsNbd.D35lls5iF(CS_0024_003C_003E8__locals3, Expression.Lambda<Func<bool>>(OWBKr5pvc5MWsK1OMtR.D35lls5iF(o4bYL4peNeC2wWb8yjx.D35lls5iF(CS_0024_003C_003E8__locals3, sjYxHO8OWlc6X80hFj7.D35lls5iF(typeof(MusicPlaylistsViewModel).TypeHandle, sjYxHO8OWlc6X80hFj7.uWZ8ugU7r5), o4bYL4peNeC2wWb8yjx.oVdpGKjy2x), (MethodInfo)f5q427pRQZnrEKPy4Ws.D35lls5iF((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, f5q427pRQZnrEKPy4Ws.Bo9pk3m4k7), OWBKr5pvc5MWsK1OMtR.fZIpAAdi1v), Array.Empty<ParameterExpression>()), [AsyncStateMachine(typeof(_003C_003CLoadAsync_003Eb__35_1_003Ed))] () =>
					{
						_003C_003CLoadAsync_003Eb__35_1_003Ed stateMachine = default(_003C_003CLoadAsync_003Eb__35_1_003Ed);
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
	private struct _003C_003CAddMoreItems_003Eb__32_1_003Ed : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MusicPlaylistsViewModel _003C_003E4__this;

		private ResponseList<PlaylistResponseDto<SongResponseDto>> _003Cresult_003E5__2;

		private TaskAwaiter<ResponseList<PlaylistResponseDto<SongResponseDto>>> _003C_003Eu__1;

		private IEnumerator<PlaylistResponseDto<SongResponseDto>> _003C_003E7__wrap2;

		private PlaylistResponseDto<SongResponseDto> _003Citem_003E5__4;

		private TaskAwaiter _003C_003Eu__2;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			MusicPlaylistsViewModel musicPlaylistsViewModel = _003C_003E4__this;
			try
			{
				if ((uint)num > 1u)
				{
					musicPlaylistsViewModel.SearchQuery.Page++;
				}
				try
				{
					TaskAwaiter<ResponseList<PlaylistResponseDto<SongResponseDto>>> awaiter;
					if (num != 0)
					{
						if (num == 1)
						{
							goto IL_00ea;
						}
						awaiter = musicPlaylistsViewModel.JikPS7bn9q.GetPlaylistsAsync<SongResponseDto>(musicPlaylistsViewModel.SearchQuery).GetAwaiter();
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
						_003C_003Eu__1 = default(TaskAwaiter<ResponseList<PlaylistResponseDto<SongResponseDto>>>);
						num = (_003C_003E1__state = -1);
					}
					ResponseList<PlaylistResponseDto<SongResponseDto>> result = awaiter.GetResult();
					_003Cresult_003E5__2 = result;
					if (_003Cresult_003E5__2 != null && _003Cresult_003E5__2.Status)
					{
						_003C_003E7__wrap2 = _003Cresult_003E5__2.Data.Result.GetEnumerator();
						goto IL_00ea;
					}
					musicPlaylistsViewModel.SearchQuery.Page--;
					goto IL_0234;
					IL_0234:
					_003Cresult_003E5__2 = null;
					goto end_IL_0032;
					IL_00ea:
					try
					{
						if (num != 1)
						{
							goto IL_0194;
						}
						TaskAwaiter awaiter2 = _003C_003Eu__2;
						_003C_003Eu__2 = default(TaskAwaiter);
						num = (_003C_003E1__state = -1);
						goto IL_0170;
						IL_0170:
						oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter2, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
						musicPlaylistsViewModel.Items.Add(_003Citem_003E5__4);
						_003Citem_003E5__4 = null;
						goto IL_0194;
						IL_0194:
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
							goto IL_0170;
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
					musicPlaylistsViewModel.CurrentPage = _003Cresult_003E5__2.Data.CurrentPage;
					musicPlaylistsViewModel.PageCount = _003Cresult_003E5__2.Data.PageCount;
					musicPlaylistsViewModel.TotalCount = _003Cresult_003E5__2.Data.Total;
					goto IL_0234;
					end_IL_0032:;
				}
				catch
				{
					musicPlaylistsViewModel.SearchQuery.Page--;
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
	private struct _003C_003CLoadAsync_003Eb__35_1_003Ed : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MusicPlaylistsViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			MusicPlaylistsViewModel musicPlaylistsViewModel = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(VrVteFCs0OCGBTVr1mZ.D35lls5iF(new Task[1] { OYihPsCZ1OyLa5m4TD0.D35lls5iF(musicPlaylistsViewModel, OYihPsCZ1OyLa5m4TD0.J7bmvT9IBI) }, VrVteFCs0OCGBTVr1mZ.qNlChUR2Cs), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
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

	private bool QJGPt6mIkm;

	private readonly IPlaylistService JikPS7bn9q;

	private readonly IMusicService JxfPfvPWbv;

	private readonly IStoreContext fyJPKj3dYT;

	private LanguageResponseDto fqhPk438sw;

	private SortOrder BYsP8TqpHb;

	private GeneralSort O3TPQCOkbA;

	[CompilerGenerated]
	private List<LanguageResponseDto> ErYPnmlwKi;

	[CompilerGenerated]
	private List<GeneralSort> muZPbiNNp6;

	public bool IsLoading
	{
		get
		{
			return QJGPt6mIkm;
		}
		set
		{
			SetProperty(ref QJGPt6mIkm, value, iFZ5je3XFYKwkvcE5D.D35lls5iF(10458, iFZ5je3XFYKwkvcE5D.N06TeK0ao));
		}
	}

	public List<LanguageResponseDto> Languages
	{
		[CompilerGenerated]
		get
		{
			return ErYPnmlwKi;
		}
		[CompilerGenerated]
		set
		{
			ErYPnmlwKi = value;
		}
	}

	public List<GeneralSort> SortItems
	{
		[CompilerGenerated]
		get
		{
			return muZPbiNNp6;
		}
		[CompilerGenerated]
		set
		{
			muZPbiNNp6 = value;
		}
	}

	public LanguageResponseDto SelectedLanguage
	{
		get
		{
			return fqhPk438sw;
		}
		set
		{
			_003C_003Ec__DisplayClass20_0 CS_0024_003C_003E8__locals4 = new _003C_003Ec__DisplayClass20_0();
			CS_0024_003C_003E8__locals4.vFMSVWC3Qq = this;
			CS_0024_003C_003E8__locals4.SgFSa2YvuR = value;
			SetProperty(ref fqhPk438sw, CS_0024_003C_003E8__locals4.SgFSa2YvuR, iFZ5je3XFYKwkvcE5D.D35lls5iF(10186, iFZ5je3XFYKwkvcE5D.N06TeK0ao), null, [AsyncStateMachine(typeof(_003C_003Ec__DisplayClass20_0.y7L8I2y3q6bSq9aNAE))] () =>
			{
				_003C_003Ec__DisplayClass20_0.y7L8I2y3q6bSq9aNAE stateMachine = default(_003C_003Ec__DisplayClass20_0.y7L8I2y3q6bSq9aNAE);
				stateMachine.Ki5nLcxtSX = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
				stateMachine.Fd4n2ugoLB = CS_0024_003C_003E8__locals4;
				stateMachine.wcXnUIu4HR = -1;
				stateMachine.Ki5nLcxtSX.Start(ref stateMachine);
			});
		}
	}

	public SortOrder SelectedOrder
	{
		get
		{
			return BYsP8TqpHb;
		}
		set
		{
			_003C_003Ec__DisplayClass23_0 CS_0024_003C_003E8__locals4 = new _003C_003Ec__DisplayClass23_0();
			CS_0024_003C_003E8__locals4.NIASGmsSPc = this;
			CS_0024_003C_003E8__locals4.fDfSTHkeoe = value;
			SetProperty(ref BYsP8TqpHb, CS_0024_003C_003E8__locals4.fDfSTHkeoe, iFZ5je3XFYKwkvcE5D.D35lls5iF(8208, iFZ5je3XFYKwkvcE5D.N06TeK0ao), null, [AsyncStateMachine(typeof(_003C_003Ec__DisplayClass23_0.VvrJOkpBROTJFCvE5S))] () =>
			{
				_003C_003Ec__DisplayClass23_0.VvrJOkpBROTJFCvE5S stateMachine = default(_003C_003Ec__DisplayClass23_0.VvrJOkpBROTJFCvE5S);
				stateMachine.L0JbBOxwkZ = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
				stateMachine.aCbbD8WIOs = CS_0024_003C_003E8__locals4;
				stateMachine.jBHb4RXwZ8 = -1;
				stateMachine.L0JbBOxwkZ.Start(ref stateMachine);
			});
		}
	}

	public GeneralSort SelectedSort
	{
		get
		{
			return O3TPQCOkbA;
		}
		set
		{
			_003C_003Ec__DisplayClass26_0 CS_0024_003C_003E8__locals4 = new _003C_003Ec__DisplayClass26_0();
			CS_0024_003C_003E8__locals4.n58StMGvou = this;
			CS_0024_003C_003E8__locals4.JYTSS5AJi2 = value;
			SetProperty(ref O3TPQCOkbA, CS_0024_003C_003E8__locals4.JYTSS5AJi2, iFZ5je3XFYKwkvcE5D.D35lls5iF(10222, iFZ5je3XFYKwkvcE5D.N06TeK0ao), null, [AsyncStateMachine(typeof(_003C_003Ec__DisplayClass26_0.N4udkJiIVvHZbeZZLy))] () =>
			{
				_003C_003Ec__DisplayClass26_0.N4udkJiIVvHZbeZZLy stateMachine = default(_003C_003Ec__DisplayClass26_0.N4udkJiIVvHZbeZZLy);
				stateMachine.ytEb08MoRJ = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
				stateMachine.hL1bGMQkTl = CS_0024_003C_003E8__locals4;
				stateMachine.zx9bam2oxy = -1;
				stateMachine.ytEb08MoRJ.Start(ref stateMachine);
			});
		}
	}

	public MusicPlaylistsViewModel()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		BYsP8TqpHb = SortOrder.Desc;
		O3TPQCOkbA = GeneralSort.ActivateDate;
		base._002Ector();
		base.TotalCount = -1;
		JikPS7bn9q = AppContainer.Resolve<IPlaylistService>();
		JxfPfvPWbv = AppContainer.Resolve<IMusicService>();
		fyJPKj3dYT = AppContainer.Resolve<IStoreContext>();
		base.FetchMoreDataCommand = new AsyncCommand(OnFetchMoreDataCommand);
		ApiQuery<PlaylistSearch, GeneralSort> obj = new ApiQuery<PlaylistSearch, GeneralSort>
		{
			Count = 25
		};
		PlaylistSearch playlistSearch = new PlaylistSearch();
		GqB3rILSV2vbfc09aIP.D35lls5iF(playlistSearch, PlaylistType.Song, GqB3rILSV2vbfc09aIP.OU4LK1g7N1);
		obj.Search = playlistSearch;
		base.SearchQuery = obj;
		TZKoniL3skJOMFjZKk4.D35lls5iF(this, new List<GeneralSort>
		{
			GeneralSort.Name,
			GeneralSort.Rating,
			GeneralSort.ReleaseYear,
			GeneralSort.ActivateDate,
			GeneralSort.Hottness,
			GeneralSort.Popularity
		}, TZKoniL3skJOMFjZKk4.b63LNBH51y);
	}

	[AsyncStateMachine(typeof(_003CLoadAlbums_003Ed__28))]
	public Task LoadAlbums()
	{
		_003CLoadAlbums_003Ed__28 stateMachine = default(_003CLoadAlbums_003Ed__28);
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

	[AsyncStateMachine(typeof(_003COnFetchMoreDataCommand_003Ed__30))]
	protected Task OnFetchMoreDataCommand()
	{
		_003COnFetchMoreDataCommand_003Ed__30 stateMachine = default(_003COnFetchMoreDataCommand_003Ed__30);
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

	[AsyncStateMachine(typeof(_003CAddMoreItems_003Ed__32))]
	public override Task AddMoreItems()
	{
		_003CAddMoreItems_003Ed__32 stateMachine = default(_003CAddMoreItems_003Ed__32);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	[AsyncStateMachine(typeof(_003CGoToPage_003Ed__33))]
	public override Task GoToPage(PlaylistResponseDto<SongResponseDto> model)
	{
		_003CGoToPage_003Ed__33 stateMachine = default(_003CGoToPage_003Ed__33);
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

	[AsyncStateMachine(typeof(_003CLoadAsync_003Ed__35))]
	public override Task LoadAsync()
	{
		_003CLoadAsync_003Ed__35 stateMachine = default(_003CLoadAsync_003Ed__35);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	[CompilerGenerated]
	[AsyncStateMachine(typeof(_003C_003CAddMoreItems_003Eb__32_1_003Ed))]
	private Task PWhPTcDHUT()
	{
		_003C_003CAddMoreItems_003Eb__32_1_003Ed stateMachine = default(_003C_003CAddMoreItems_003Eb__32_1_003Ed);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	[CompilerGenerated]
	[AsyncStateMachine(typeof(_003C_003CLoadAsync_003Eb__35_1_003Ed))]
	private Task bPQPZhl3JT()
	{
		_003C_003CLoadAsync_003Eb__35_1_003Ed stateMachine = default(_003C_003CLoadAsync_003Eb__35_1_003Ed);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}
}
