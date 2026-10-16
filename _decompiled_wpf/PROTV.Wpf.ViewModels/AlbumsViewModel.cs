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
using PROTV.Wpf.Views;

namespace PROTV.Wpf.ViewModels;

public class AlbumsViewModel : BaseListViewModel<AlbumResponseDto, ApiQuery<AlbumSearch, GeneralSort>>
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass18_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct U6amlkFlqHJ2XBZjuu : IAsyncStateMachine
		{
			public int rcJnuTi6Kd;

			public AsyncVoidMethodBuilder AfknAKwVsV;

			public _003C_003Ec__DisplayClass18_0 L9xnNJ52N0;

			private ResponseList<AlbumResponseDto> EU9nMCjyD3;

			private TaskAwaiter<ResponseList<AlbumResponseDto>> qe4nCt36rX;

			private IEnumerator<AlbumResponseDto> buXnYbAUDq;

			private AlbumResponseDto L9DnF0CoVc;

			private TaskAwaiter Nosn6v2aEH;

			private void MoveNext()
			{
				int num = rcJnuTi6Kd;
				_003C_003Ec__DisplayClass18_0 obj = L9xnNJ52N0;
				try
				{
					if ((uint)num > 1u)
					{
						obj.rX0tzX4T6A.Items.Clear();
					}
					try
					{
						TaskAwaiter<ResponseList<AlbumResponseDto>> awaiter;
						if (num != 0)
						{
							if (num == 1)
							{
								goto IL_02dc;
							}
							obj.rX0tzX4T6A.SearchQuery.Page = 1;
							if (S1a0wT9Ixre9OpDny8h.D35lls5iF(eVlRnEIaHT0dqvCx0Kx.D35lls5iF(obj.weVSc3yYwG, eVlRnEIaHT0dqvCx0Kx.fa575yQKq4), iFZ5je3XFYKwkvcE5D.D35lls5iF(17100, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO))
							{
								lASFo76QIUBEikAAsE9.D35lls5iF(obj.rX0tzX4T6A.SearchQuery.Search, Language.English, lASFo76QIUBEikAAsE9.UMA6X462Ew);
							}
							if (S1a0wT9Ixre9OpDny8h.D35lls5iF(eVlRnEIaHT0dqvCx0Kx.D35lls5iF(obj.weVSc3yYwG, eVlRnEIaHT0dqvCx0Kx.fa575yQKq4), iFZ5je3XFYKwkvcE5D.D35lls5iF(17118, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO))
							{
								lASFo76QIUBEikAAsE9.D35lls5iF(obj.rX0tzX4T6A.SearchQuery.Search, Language.Arabic, lASFo76QIUBEikAAsE9.UMA6X462Ew);
							}
							if (S1a0wT9Ixre9OpDny8h.D35lls5iF(eVlRnEIaHT0dqvCx0Kx.D35lls5iF(obj.weVSc3yYwG, eVlRnEIaHT0dqvCx0Kx.fa575yQKq4), iFZ5je3XFYKwkvcE5D.D35lls5iF(17134, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO))
							{
								lASFo76QIUBEikAAsE9.D35lls5iF(obj.rX0tzX4T6A.SearchQuery.Search, Language.Other, lASFo76QIUBEikAAsE9.UMA6X462Ew);
							}
							if (S1a0wT9Ixre9OpDny8h.D35lls5iF(eVlRnEIaHT0dqvCx0Kx.D35lls5iF(obj.weVSc3yYwG, eVlRnEIaHT0dqvCx0Kx.fa575yQKq4), iFZ5je3XFYKwkvcE5D.D35lls5iF(17148, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO))
							{
								lASFo76QIUBEikAAsE9.D35lls5iF(obj.rX0tzX4T6A.SearchQuery.Search, Language.Turkish, lASFo76QIUBEikAAsE9.UMA6X462Ew);
							}
							if (S1a0wT9Ixre9OpDny8h.D35lls5iF(eVlRnEIaHT0dqvCx0Kx.D35lls5iF(obj.weVSc3yYwG, eVlRnEIaHT0dqvCx0Kx.fa575yQKq4), iFZ5je3XFYKwkvcE5D.D35lls5iF(17166, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO))
							{
								lASFo76QIUBEikAAsE9.D35lls5iF(obj.rX0tzX4T6A.SearchQuery.Search, Language.Japanese, lASFo76QIUBEikAAsE9.UMA6X462Ew);
							}
							if (S1a0wT9Ixre9OpDny8h.D35lls5iF(eVlRnEIaHT0dqvCx0Kx.D35lls5iF(obj.weVSc3yYwG, eVlRnEIaHT0dqvCx0Kx.fa575yQKq4), iFZ5je3XFYKwkvcE5D.D35lls5iF(16162, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO))
							{
								lASFo76QIUBEikAAsE9.D35lls5iF(obj.rX0tzX4T6A.SearchQuery.Search, null, lASFo76QIUBEikAAsE9.UMA6X462Ew);
							}
							awaiter = mDcRsUm0AcZTH9WQKpJ.D35lls5iF(obj.rX0tzX4T6A.fvQPqF86Ce, obj.rX0tzX4T6A.SearchQuery, mDcRsUm0AcZTH9WQKpJ.OxQmrL4qwZ).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = (rcJnuTi6Kd = 0);
								qe4nCt36rX = awaiter;
								AfknAKwVsV.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = qe4nCt36rX;
							qe4nCt36rX = default(TaskAwaiter<ResponseList<AlbumResponseDto>>);
							num = (rcJnuTi6Kd = -1);
						}
						ResponseList<AlbumResponseDto> result = awaiter.GetResult();
						EU9nMCjyD3 = result;
						if (EU9nMCjyD3 != null && EU9nMCjyD3.Status)
						{
							buXnYbAUDq = EU9nMCjyD3.Data.Result.GetEnumerator();
							goto IL_02dc;
						}
						obj.rX0tzX4T6A.TotalCount = 0;
						goto IL_0431;
						IL_0431:
						EU9nMCjyD3 = null;
						goto end_IL_002d;
						IL_02dc:
						try
						{
							if (num != 1)
							{
								goto IL_038b;
							}
							TaskAwaiter awaiter2 = Nosn6v2aEH;
							Nosn6v2aEH = default(TaskAwaiter);
							num = (rcJnuTi6Kd = -1);
							goto IL_0362;
							IL_0362:
							oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter2, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
							obj.rX0tzX4T6A.Items.Add(L9DnF0CoVc);
							L9DnF0CoVc = null;
							goto IL_038b;
							IL_038b:
							if (hjMnupQVVDlRZAYQJC.D35lls5iF(buXnYbAUDq, hjMnupQVVDlRZAYQJC.QV1TFwytOj))
							{
								L9DnF0CoVc = buXnYbAUDq.Current;
								awaiter2 = QliBEUviwWqgtMcBndV.D35lls5iF(pvrKKy8Mk1kpdmIfp3A.D35lls5iF(2, pvrKKy8Mk1kpdmIfp3A.aVh8SPrFkE), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
								if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter2, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
								{
									num = (rcJnuTi6Kd = 1);
									Nosn6v2aEH = awaiter2;
									AfknAKwVsV.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									return;
								}
								goto IL_0362;
							}
						}
						finally
						{
							if (num < 0 && buXnYbAUDq != null)
							{
								xLO56JniGyickVjO1Ot.D35lls5iF(buXnYbAUDq, xLO56JniGyickVjO1Ot.ydbT2bsoH4);
							}
						}
						buXnYbAUDq = null;
						obj.rX0tzX4T6A.CurrentPage = EU9nMCjyD3.Data.CurrentPage;
						obj.rX0tzX4T6A.PageCount = EU9nMCjyD3.Data.PageCount;
						obj.rX0tzX4T6A.TotalCount = EU9nMCjyD3.Data.Total;
						goto IL_0431;
						end_IL_002d:;
					}
					catch
					{
						obj.rX0tzX4T6A.TotalCount = 0;
					}
				}
				catch (Exception ex)
				{
					rcJnuTi6Kd = -2;
					N2XUglA3neBsnlZfRPQ.D35lls5iF(ref AfknAKwVsV, ex, N2XUglA3neBsnlZfRPQ.l4pATRumoW);
					return;
				}
				rcJnuTi6Kd = -2;
				T4XmPoA4VNJJP1afcgL.D35lls5iF(ref AfknAKwVsV, T4XmPoA4VNJJP1afcgL.TRyALZckCh);
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine P_0)
			{
				dHWo7jAEn6E4X7bsY4R.D35lls5iF(ref AfknAKwVsV, P_0, dHWo7jAEn6E4X7bsY4R.z3hAB6UZ9o);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine P_0)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(P_0);
			}
		}

		public AlbumsViewModel rX0tzX4T6A;

		public LanguageResponseDto weVSc3yYwG;

		public _003C_003Ec__DisplayClass18_0()
		{
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
			base._002Ector();
		}

		[AsyncStateMachine(typeof(U6amlkFlqHJ2XBZjuu))]
		internal void Eevt2BntpB()
		{
			U6amlkFlqHJ2XBZjuu stateMachine = default(U6amlkFlqHJ2XBZjuu);
			stateMachine.AfknAKwVsV = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
			stateMachine.L9xnNJ52N0 = this;
			stateMachine.rcJnuTi6Kd = -1;
			stateMachine.AfknAKwVsV.Start(ref stateMachine);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass21_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct sY2xp36dy46B7QLcow : IAsyncStateMachine
		{
			public int mXMns56wLV;

			public AsyncVoidMethodBuilder fwhnxvBYFs;

			public _003C_003Ec__DisplayClass21_0 cllnyeWErl;

			private ResponseList<AlbumResponseDto> eU2npHPYkY;

			private TaskAwaiter<ResponseList<AlbumResponseDto>> ifTniU568a;

			private IEnumerator<AlbumResponseDto> pk7n3BMbUA;

			private AlbumResponseDto OCSnmtMjO9;

			private TaskAwaiter N7pnXSOtxR;

			private void MoveNext()
			{
				int num = mXMns56wLV;
				_003C_003Ec__DisplayClass21_0 obj = cllnyeWErl;
				try
				{
					if ((uint)num > 1u)
					{
						obj.LDGSvnhcRN.Items.Clear();
					}
					try
					{
						TaskAwaiter<ResponseList<AlbumResponseDto>> awaiter;
						if (num != 0)
						{
							if (num == 1)
							{
								goto IL_0118;
							}
							obj.LDGSvnhcRN.SearchQuery.Page = 1;
							obj.LDGSvnhcRN.SearchQuery.Order = obj.xKESW7Im9s;
							awaiter = mDcRsUm0AcZTH9WQKpJ.D35lls5iF(obj.LDGSvnhcRN.fvQPqF86Ce, obj.LDGSvnhcRN.SearchQuery, mDcRsUm0AcZTH9WQKpJ.OxQmrL4qwZ).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = (mXMns56wLV = 0);
								ifTniU568a = awaiter;
								fwhnxvBYFs.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = ifTniU568a;
							ifTniU568a = default(TaskAwaiter<ResponseList<AlbumResponseDto>>);
							num = (mXMns56wLV = -1);
						}
						ResponseList<AlbumResponseDto> result = awaiter.GetResult();
						eU2npHPYkY = result;
						if (eU2npHPYkY != null && eU2npHPYkY.Status)
						{
							pk7n3BMbUA = eU2npHPYkY.Data.Result.GetEnumerator();
							goto IL_0118;
						}
						obj.LDGSvnhcRN.TotalCount = 0;
						goto IL_026d;
						IL_026d:
						eU2npHPYkY = null;
						goto end_IL_002d;
						IL_0118:
						try
						{
							if (num != 1)
							{
								goto IL_01c7;
							}
							TaskAwaiter awaiter2 = N7pnXSOtxR;
							N7pnXSOtxR = default(TaskAwaiter);
							num = (mXMns56wLV = -1);
							goto IL_019e;
							IL_019e:
							oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter2, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
							obj.LDGSvnhcRN.Items.Add(OCSnmtMjO9);
							OCSnmtMjO9 = null;
							goto IL_01c7;
							IL_01c7:
							if (hjMnupQVVDlRZAYQJC.D35lls5iF(pk7n3BMbUA, hjMnupQVVDlRZAYQJC.QV1TFwytOj))
							{
								OCSnmtMjO9 = pk7n3BMbUA.Current;
								awaiter2 = QliBEUviwWqgtMcBndV.D35lls5iF(pvrKKy8Mk1kpdmIfp3A.D35lls5iF(2, pvrKKy8Mk1kpdmIfp3A.aVh8SPrFkE), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
								if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter2, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
								{
									num = (mXMns56wLV = 1);
									N7pnXSOtxR = awaiter2;
									fwhnxvBYFs.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									return;
								}
								goto IL_019e;
							}
						}
						finally
						{
							if (num < 0 && pk7n3BMbUA != null)
							{
								xLO56JniGyickVjO1Ot.D35lls5iF(pk7n3BMbUA, xLO56JniGyickVjO1Ot.ydbT2bsoH4);
							}
						}
						pk7n3BMbUA = null;
						obj.LDGSvnhcRN.CurrentPage = eU2npHPYkY.Data.CurrentPage;
						obj.LDGSvnhcRN.PageCount = eU2npHPYkY.Data.PageCount;
						obj.LDGSvnhcRN.TotalCount = eU2npHPYkY.Data.Total;
						goto IL_026d;
						end_IL_002d:;
					}
					catch
					{
						obj.LDGSvnhcRN.TotalCount = 0;
					}
				}
				catch (Exception ex)
				{
					mXMns56wLV = -2;
					N2XUglA3neBsnlZfRPQ.D35lls5iF(ref fwhnxvBYFs, ex, N2XUglA3neBsnlZfRPQ.l4pATRumoW);
					return;
				}
				mXMns56wLV = -2;
				T4XmPoA4VNJJP1afcgL.D35lls5iF(ref fwhnxvBYFs, T4XmPoA4VNJJP1afcgL.TRyALZckCh);
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine P_0)
			{
				dHWo7jAEn6E4X7bsY4R.D35lls5iF(ref fwhnxvBYFs, P_0, dHWo7jAEn6E4X7bsY4R.z3hAB6UZ9o);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine P_0)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(P_0);
			}
		}

		public AlbumsViewModel LDGSvnhcRN;

		public SortOrder xKESW7Im9s;

		public _003C_003Ec__DisplayClass21_0()
		{
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
			base._002Ector();
		}

		[AsyncStateMachine(typeof(sY2xp36dy46B7QLcow))]
		internal void PIZSjm213D()
		{
			sY2xp36dy46B7QLcow stateMachine = default(sY2xp36dy46B7QLcow);
			stateMachine.fwhnxvBYFs = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
			stateMachine.cllnyeWErl = this;
			stateMachine.mXMns56wLV = -1;
			stateMachine.fwhnxvBYFs.Start(ref stateMachine);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass24_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct CBgZN6sLSXkET01iDl : IAsyncStateMachine
		{
			public int SSBnRUZbyh;

			public AsyncVoidMethodBuilder KKKnwfDEaA;

			public _003C_003Ec__DisplayClass24_0 iqinE9EsNH;

			private ResponseList<AlbumResponseDto> j3Bn9wJWNm;

			private TaskAwaiter<ResponseList<AlbumResponseDto>> bdenecn2qo;

			private IEnumerator<AlbumResponseDto> te0nOK9DAL;

			private AlbumResponseDto v1nnrU4Ut8;

			private TaskAwaiter UFvnHgqUIM;

			private void MoveNext()
			{
				int num = SSBnRUZbyh;
				_003C_003Ec__DisplayClass24_0 obj = iqinE9EsNH;
				try
				{
					if ((uint)num > 1u)
					{
						obj.bBGSBRLwPY.Items.Clear();
					}
					try
					{
						TaskAwaiter<ResponseList<AlbumResponseDto>> awaiter;
						if (num != 0)
						{
							if (num == 1)
							{
								goto IL_0118;
							}
							obj.bBGSBRLwPY.SearchQuery.Page = 1;
							obj.bBGSBRLwPY.SearchQuery.Sort = obj.GKdSD5TnXg;
							awaiter = mDcRsUm0AcZTH9WQKpJ.D35lls5iF(obj.bBGSBRLwPY.fvQPqF86Ce, obj.bBGSBRLwPY.SearchQuery, mDcRsUm0AcZTH9WQKpJ.OxQmrL4qwZ).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = (SSBnRUZbyh = 0);
								bdenecn2qo = awaiter;
								KKKnwfDEaA.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = bdenecn2qo;
							bdenecn2qo = default(TaskAwaiter<ResponseList<AlbumResponseDto>>);
							num = (SSBnRUZbyh = -1);
						}
						ResponseList<AlbumResponseDto> result = awaiter.GetResult();
						j3Bn9wJWNm = result;
						if (j3Bn9wJWNm != null && j3Bn9wJWNm.Status)
						{
							te0nOK9DAL = j3Bn9wJWNm.Data.Result.GetEnumerator();
							goto IL_0118;
						}
						obj.bBGSBRLwPY.TotalCount = 0;
						goto IL_026d;
						IL_026d:
						j3Bn9wJWNm = null;
						goto end_IL_002d;
						IL_0118:
						try
						{
							if (num != 1)
							{
								goto IL_01c7;
							}
							TaskAwaiter awaiter2 = UFvnHgqUIM;
							UFvnHgqUIM = default(TaskAwaiter);
							num = (SSBnRUZbyh = -1);
							goto IL_019e;
							IL_019e:
							oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter2, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
							obj.bBGSBRLwPY.Items.Add(v1nnrU4Ut8);
							v1nnrU4Ut8 = null;
							goto IL_01c7;
							IL_01c7:
							if (hjMnupQVVDlRZAYQJC.D35lls5iF(te0nOK9DAL, hjMnupQVVDlRZAYQJC.QV1TFwytOj))
							{
								v1nnrU4Ut8 = te0nOK9DAL.Current;
								awaiter2 = QliBEUviwWqgtMcBndV.D35lls5iF(pvrKKy8Mk1kpdmIfp3A.D35lls5iF(2, pvrKKy8Mk1kpdmIfp3A.aVh8SPrFkE), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
								if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter2, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
								{
									num = (SSBnRUZbyh = 1);
									UFvnHgqUIM = awaiter2;
									KKKnwfDEaA.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									return;
								}
								goto IL_019e;
							}
						}
						finally
						{
							if (num < 0 && te0nOK9DAL != null)
							{
								xLO56JniGyickVjO1Ot.D35lls5iF(te0nOK9DAL, xLO56JniGyickVjO1Ot.ydbT2bsoH4);
							}
						}
						te0nOK9DAL = null;
						obj.bBGSBRLwPY.CurrentPage = j3Bn9wJWNm.Data.CurrentPage;
						obj.bBGSBRLwPY.PageCount = j3Bn9wJWNm.Data.PageCount;
						obj.bBGSBRLwPY.TotalCount = j3Bn9wJWNm.Data.Total;
						goto IL_026d;
						end_IL_002d:;
					}
					catch
					{
						obj.bBGSBRLwPY.TotalCount = 0;
					}
				}
				catch (Exception ex)
				{
					SSBnRUZbyh = -2;
					N2XUglA3neBsnlZfRPQ.D35lls5iF(ref KKKnwfDEaA, ex, N2XUglA3neBsnlZfRPQ.l4pATRumoW);
					return;
				}
				SSBnRUZbyh = -2;
				T4XmPoA4VNJJP1afcgL.D35lls5iF(ref KKKnwfDEaA, T4XmPoA4VNJJP1afcgL.TRyALZckCh);
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine P_0)
			{
				dHWo7jAEn6E4X7bsY4R.D35lls5iF(ref KKKnwfDEaA, P_0, dHWo7jAEn6E4X7bsY4R.z3hAB6UZ9o);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine P_0)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(P_0);
			}
		}

		public AlbumsViewModel bBGSBRLwPY;

		public GeneralSort GKdSD5TnXg;

		public _003C_003Ec__DisplayClass24_0()
		{
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
			base._002Ector();
		}

		[AsyncStateMachine(typeof(CBgZN6sLSXkET01iDl))]
		internal void P8oS4oLn6w()
		{
			CBgZN6sLSXkET01iDl stateMachine = default(CBgZN6sLSXkET01iDl);
			stateMachine.KKKnwfDEaA = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
			stateMachine.iqinE9EsNH = this;
			stateMachine.SSBnRUZbyh = -1;
			stateMachine.KKKnwfDEaA.Start(ref stateMachine);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLoadAlbums_003Ed__26 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public AlbumsViewModel _003C_003E4__this;

		private ResponseList<AlbumResponseDto> _003Cresult_003E5__2;

		private TaskAwaiter<ResponseList<AlbumResponseDto>> _003C_003Eu__1;

		private IEnumerator<AlbumResponseDto> _003C_003E7__wrap2;

		private AlbumResponseDto _003Citem_003E5__4;

		private TaskAwaiter _003C_003Eu__2;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			AlbumsViewModel albumsViewModel = _003C_003E4__this;
			try
			{
				if ((uint)num > 1u)
				{
					albumsViewModel.Items.Clear();
					albumsViewModel.SearchQuery.Page = 1;
					albumsViewModel.SearchQuery.Count = 25;
					albumsViewModel.SearchQuery.Sort = GeneralSort.ActivateDate;
					albumsViewModel.SearchQuery.Order = SortOrder.Desc;
					lASFo76QIUBEikAAsE9.D35lls5iF(albumsViewModel.SearchQuery.Search, null, lASFo76QIUBEikAAsE9.UMA6X462Ew);
				}
				try
				{
					TaskAwaiter<ResponseList<AlbumResponseDto>> awaiter;
					if (num != 0)
					{
						if (num == 1)
						{
							goto IL_0135;
						}
						awaiter = mDcRsUm0AcZTH9WQKpJ.D35lls5iF(albumsViewModel.fvQPqF86Ce, albumsViewModel.SearchQuery, mDcRsUm0AcZTH9WQKpJ.OxQmrL4qwZ).GetAwaiter();
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
						_003C_003Eu__1 = default(TaskAwaiter<ResponseList<AlbumResponseDto>>);
						num = (_003C_003E1__state = -1);
					}
					ResponseList<AlbumResponseDto> result = awaiter.GetResult();
					_003Cresult_003E5__2 = result;
					if (_003Cresult_003E5__2 != null && _003Cresult_003E5__2.Status)
					{
						_003C_003E7__wrap2 = _003Cresult_003E5__2.Data.Result.GetEnumerator();
						goto IL_0135;
					}
					albumsViewModel.TotalCount = 0;
					goto IL_0271;
					IL_0271:
					_003Cresult_003E5__2 = null;
					goto end_IL_0078;
					IL_0135:
					try
					{
						if (num != 1)
						{
							goto IL_01df;
						}
						TaskAwaiter awaiter2 = _003C_003Eu__2;
						_003C_003Eu__2 = default(TaskAwaiter);
						num = (_003C_003E1__state = -1);
						goto IL_01bb;
						IL_01bb:
						oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter2, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
						albumsViewModel.Items.Add(_003Citem_003E5__4);
						_003Citem_003E5__4 = null;
						goto IL_01df;
						IL_01df:
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
							goto IL_01bb;
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
					albumsViewModel.CurrentPage = _003Cresult_003E5__2.Data.CurrentPage;
					albumsViewModel.PageCount = _003Cresult_003E5__2.Data.PageCount;
					albumsViewModel.TotalCount = _003Cresult_003E5__2.Data.Total;
					goto IL_0271;
					end_IL_0078:;
				}
				catch (Exception)
				{
					albumsViewModel.TotalCount = 0;
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
	private struct _003COnFetchMoreDataCommand_003Ed__28 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public AlbumsViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			AlbumsViewModel albumsViewModel = _003C_003E4__this;
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
				if (albumsViewModel.CurrentPage < albumsViewModel.TotalCount && !hjMnupQVVDlRZAYQJC.D35lls5iF(albumsViewModel, hjMnupQVVDlRZAYQJC.jJYTSHn9tB))
				{
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(albumsViewModel.AddMoreItems(), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
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
	private struct _003CAddMoreItems_003Ed__30 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public AlbumsViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			AlbumsViewModel CS_0024_003C_003E8__locals5 = _003C_003E4__this;
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
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(W7S2sip6SDieZFVsNbd.D35lls5iF(CS_0024_003C_003E8__locals5, Expression.Lambda<Func<bool>>(OWBKr5pvc5MWsK1OMtR.D35lls5iF(o4bYL4peNeC2wWb8yjx.D35lls5iF(CS_0024_003C_003E8__locals5, sjYxHO8OWlc6X80hFj7.D35lls5iF(typeof(AlbumsViewModel).TypeHandle, sjYxHO8OWlc6X80hFj7.uWZ8ugU7r5), o4bYL4peNeC2wWb8yjx.oVdpGKjy2x), (MethodInfo)f5q427pRQZnrEKPy4Ws.D35lls5iF((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, f5q427pRQZnrEKPy4Ws.Bo9pk3m4k7), OWBKr5pvc5MWsK1OMtR.fZIpAAdi1v), Array.Empty<ParameterExpression>()), [AsyncStateMachine(typeof(_003C_003CAddMoreItems_003Eb__30_1_003Ed))] () =>
					{
						_003C_003CAddMoreItems_003Eb__30_1_003Ed stateMachine = default(_003C_003CAddMoreItems_003Eb__30_1_003Ed);
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
	private sealed class _003C_003Ec__DisplayClass31_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct H5MSWDx8APccqb5cR5 : IAsyncStateMachine
		{
			public int bRTnoV7Onv;

			public AsyncTaskMethodBuilder ORjngX9rkE;

			public _003C_003Ec__DisplayClass31_0 tAHn1V3bV7;

			private HomeViewModel kAOnJxOWGD;

			private MainPlayerViewModel OGnnhSPAeo;

			private TaskAwaiter nB3nlylHMy;

			private void MoveNext()
			{
				int num = bRTnoV7Onv;
				_003C_003Ec__DisplayClass31_0 obj = tAHn1V3bV7;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						kAOnJxOWGD = Sp7dKWL9ZfBld4JOkGo.D35lls5iF(AppContainer.Resolve<MainViewModel>(), Sp7dKWL9ZfBld4JOkGo.QpWwMTMAhO) as HomeViewModel;
						OGnnhSPAeo = MI3oOiHCZASyM6ERRUP.D35lls5iF(kAOnJxOWGD, MI3oOiHCZASyM6ERRUP.h0JHmOSEFB);
						awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(LoKHJec9qUyy294NoZ5.D35lls5iF(OGnnhSPAeo, MusicType.Album, m9MGZR7k2RmVqYXYS5.D35lls5iF(obj.PBvSqDh0ph, m9MGZR7k2RmVqYXYS5.j871CQO7pP), pnvE8rm9NRTK7Tblimu.D35lls5iF(obj.PBvSqDh0ph, pnvE8rm9NRTK7Tblimu.DQ6IGCcPAn), V4VMaWmQYRpUqEIxujB.D35lls5iF(obj.PBvSqDh0ph, V4VMaWmQYRpUqEIxujB.cEiclwJvUW), null, null, LoKHJec9qUyy294NoZ5.FXGcDq3bhE), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
						if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
						{
							num = (bRTnoV7Onv = 0);
							nB3nlylHMy = awaiter;
							ORjngX9rkE.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = nB3nlylHMy;
						nB3nlylHMy = default(TaskAwaiter);
						num = (bRTnoV7Onv = -1);
					}
					oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
					Page page = new Page();
					KBhlAv9D2TgBJ1kkc0B.D35lls5iF(page, IyGDDwHBiPv8vfOFJDF.D35lls5iF(ApplicationPage.PlayListDetailsView, OGnnhSPAeo, IyGDDwHBiPv8vfOFJDF.hivH0XYhaE), KBhlAv9D2TgBJ1kkc0B.fWUHrWO7Sa);
					qni3xrDkAJ3vF35eMav.D35lls5iF(page, EBgwuVHeVLDJVVfMaAk.D35lls5iF(ApplicationPage.PlayListDetailsView, EBgwuVHeVLDJVVfMaAk.mtcHG3MEy3), qni3xrDkAJ3vF35eMav.Ra7HRFTvnD);
					Page page2 = page;
					GmMLaTD7kV8rq88ZFvR.D35lls5iF(Xlypb0Hnr2C3ydrYEdG.D35lls5iF(kAOnJxOWGD, Xlypb0Hnr2C3ydrYEdG.U3Z1IKMGuZ), page2, GmMLaTD7kV8rq88ZFvR.iMJHkmaaRY);
				}
				catch (Exception ex)
				{
					bRTnoV7Onv = -2;
					kAOnJxOWGD = null;
					OGnnhSPAeo = null;
					NNK1eXA7fWQ87oSUty7.D35lls5iF(ref ORjngX9rkE, ex, NNK1eXA7fWQ87oSUty7.G3EAcW9Om7);
					return;
				}
				bRTnoV7Onv = -2;
				kAOnJxOWGD = null;
				OGnnhSPAeo = null;
				meFicnAMHIVtdhf671p.D35lls5iF(ref ORjngX9rkE, meFicnAMHIVtdhf671p.bsDASenQ5I);
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine P_0)
			{
				vxBFJcAKZoecNtbdqxt.D35lls5iF(ref ORjngX9rkE, P_0, vxBFJcAKZoecNtbdqxt.tuxANdhu18);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine P_0)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(P_0);
			}
		}

		public AlbumsViewModel DJUSPFdtZi;

		public AlbumResponseDto PBvSqDh0ph;

		public _003C_003Ec__DisplayClass31_0()
		{
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
			base._002Ector();
		}

		[AsyncStateMachine(typeof(H5MSWDx8APccqb5cR5))]
		internal Task pT4SdDsR1V()
		{
			H5MSWDx8APccqb5cR5 stateMachine = default(H5MSWDx8APccqb5cR5);
			stateMachine.ORjngX9rkE = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
			stateMachine.tAHn1V3bV7 = this;
			stateMachine.bRTnoV7Onv = -1;
			stateMachine.ORjngX9rkE.Start(ref stateMachine);
			return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine.ORjngX9rkE, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGoToPage_003Ed__31 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public AlbumsViewModel _003C_003E4__this;

		public AlbumResponseDto model;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			AlbumsViewModel albumsViewModel = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_0103;
				}
				_003C_003Ec__DisplayClass31_0 CS_0024_003C_003E8__locals4 = new _003C_003Ec__DisplayClass31_0();
				CS_0024_003C_003E8__locals4.DJUSPFdtZi = _003C_003E4__this;
				CS_0024_003C_003E8__locals4.PBvSqDh0ph = model;
				if (m9MGZR7k2RmVqYXYS5.D35lls5iF(CS_0024_003C_003E8__locals4.PBvSqDh0ph, m9MGZR7k2RmVqYXYS5.j871CQO7pP) > 0)
				{
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(W7S2sip6SDieZFVsNbd.D35lls5iF(albumsViewModel, Expression.Lambda<Func<bool>>(OWBKr5pvc5MWsK1OMtR.D35lls5iF(o4bYL4peNeC2wWb8yjx.D35lls5iF(albumsViewModel, sjYxHO8OWlc6X80hFj7.D35lls5iF(typeof(AlbumsViewModel).TypeHandle, sjYxHO8OWlc6X80hFj7.uWZ8ugU7r5), o4bYL4peNeC2wWb8yjx.oVdpGKjy2x), (MethodInfo)f5q427pRQZnrEKPy4Ws.D35lls5iF((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, f5q427pRQZnrEKPy4Ws.Bo9pk3m4k7), OWBKr5pvc5MWsK1OMtR.fZIpAAdi1v), Array.Empty<ParameterExpression>()), [AsyncStateMachine(typeof(_003C_003Ec__DisplayClass31_0.H5MSWDx8APccqb5cR5))] () =>
					{
						_003C_003Ec__DisplayClass31_0.H5MSWDx8APccqb5cR5 stateMachine = default(_003C_003Ec__DisplayClass31_0.H5MSWDx8APccqb5cR5);
						stateMachine.ORjngX9rkE = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
						stateMachine.tAHn1V3bV7 = CS_0024_003C_003E8__locals4;
						stateMachine.bRTnoV7Onv = -1;
						stateMachine.ORjngX9rkE.Start(ref stateMachine);
						return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine.ORjngX9rkE, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
					}, W7S2sip6SDieZFVsNbd.XWappgVyfh), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
					if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_0103;
				}
				goto end_IL_0015;
				IL_0103:
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
	private struct _003CLoadAsync_003Ed__33 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public AlbumsViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			AlbumsViewModel CS_0024_003C_003E8__locals3 = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(W7S2sip6SDieZFVsNbd.D35lls5iF(CS_0024_003C_003E8__locals3, Expression.Lambda<Func<bool>>(OWBKr5pvc5MWsK1OMtR.D35lls5iF(o4bYL4peNeC2wWb8yjx.D35lls5iF(CS_0024_003C_003E8__locals3, sjYxHO8OWlc6X80hFj7.D35lls5iF(typeof(AlbumsViewModel).TypeHandle, sjYxHO8OWlc6X80hFj7.uWZ8ugU7r5), o4bYL4peNeC2wWb8yjx.oVdpGKjy2x), (MethodInfo)f5q427pRQZnrEKPy4Ws.D35lls5iF((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, f5q427pRQZnrEKPy4Ws.Bo9pk3m4k7), OWBKr5pvc5MWsK1OMtR.fZIpAAdi1v), Array.Empty<ParameterExpression>()), [AsyncStateMachine(typeof(_003C_003CLoadAsync_003Eb__33_1_003Ed))] () =>
					{
						_003C_003CLoadAsync_003Eb__33_1_003Ed stateMachine = default(_003C_003CLoadAsync_003Eb__33_1_003Ed);
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
	private struct _003C_003CAddMoreItems_003Eb__30_1_003Ed : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public AlbumsViewModel _003C_003E4__this;

		private ResponseList<AlbumResponseDto> _003Cresult_003E5__2;

		private TaskAwaiter<ResponseList<AlbumResponseDto>> _003C_003Eu__1;

		private IEnumerator<AlbumResponseDto> _003C_003E7__wrap2;

		private AlbumResponseDto _003Citem_003E5__4;

		private TaskAwaiter _003C_003Eu__2;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			AlbumsViewModel albumsViewModel = _003C_003E4__this;
			try
			{
				if ((uint)num > 1u)
				{
					albumsViewModel.SearchQuery.Page++;
				}
				try
				{
					TaskAwaiter<ResponseList<AlbumResponseDto>> awaiter;
					if (num != 0)
					{
						if (num == 1)
						{
							goto IL_00ef;
						}
						awaiter = mDcRsUm0AcZTH9WQKpJ.D35lls5iF(albumsViewModel.fvQPqF86Ce, albumsViewModel.SearchQuery, mDcRsUm0AcZTH9WQKpJ.OxQmrL4qwZ).GetAwaiter();
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
						_003C_003Eu__1 = default(TaskAwaiter<ResponseList<AlbumResponseDto>>);
						num = (_003C_003E1__state = -1);
					}
					ResponseList<AlbumResponseDto> result = awaiter.GetResult();
					_003Cresult_003E5__2 = result;
					if (_003Cresult_003E5__2 != null && _003Cresult_003E5__2.Status)
					{
						_003C_003E7__wrap2 = _003Cresult_003E5__2.Data.Result.GetEnumerator();
						goto IL_00ef;
					}
					albumsViewModel.SearchQuery.Page--;
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
						albumsViewModel.Items.Add(_003Citem_003E5__4);
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
					albumsViewModel.CurrentPage = _003Cresult_003E5__2.Data.CurrentPage;
					albumsViewModel.PageCount = _003Cresult_003E5__2.Data.PageCount;
					albumsViewModel.TotalCount = _003Cresult_003E5__2.Data.Total;
					goto IL_0239;
					end_IL_0032:;
				}
				catch
				{
					albumsViewModel.SearchQuery.Page--;
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
	private struct _003C_003CLoadAsync_003Eb__33_1_003Ed : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public AlbumsViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			AlbumsViewModel albumsViewModel = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(VrVteFCs0OCGBTVr1mZ.D35lls5iF(new Task[1] { OYihPsCZ1OyLa5m4TD0.D35lls5iF(albumsViewModel, OYihPsCZ1OyLa5m4TD0.HTYmetaNaD) }, VrVteFCs0OCGBTVr1mZ.qNlChUR2Cs), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
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

	private bool feSPPqAnjw;

	private readonly IMusicService fvQPqF86Ce;

	private LanguageResponseDto BgbPI2AHbW;

	private SortOrder WQDPVBYZ5n;

	private GeneralSort rnIPa3d81E;

	[CompilerGenerated]
	private List<LanguageResponseDto> he2P0QEHBK;

	[CompilerGenerated]
	private List<GeneralSort> iDhPGTaGc4;

	public bool IsLoading
	{
		get
		{
			return feSPPqAnjw;
		}
		set
		{
			SetProperty(ref feSPPqAnjw, value, iFZ5je3XFYKwkvcE5D.D35lls5iF(10458, iFZ5je3XFYKwkvcE5D.N06TeK0ao));
		}
	}

	public List<LanguageResponseDto> Languages
	{
		[CompilerGenerated]
		get
		{
			return he2P0QEHBK;
		}
		[CompilerGenerated]
		set
		{
			he2P0QEHBK = value;
		}
	}

	public List<GeneralSort> SortItems
	{
		[CompilerGenerated]
		get
		{
			return iDhPGTaGc4;
		}
		[CompilerGenerated]
		set
		{
			iDhPGTaGc4 = value;
		}
	}

	public LanguageResponseDto SelectedLanguage
	{
		get
		{
			return BgbPI2AHbW;
		}
		set
		{
			_003C_003Ec__DisplayClass18_0 CS_0024_003C_003E8__locals4 = new _003C_003Ec__DisplayClass18_0();
			CS_0024_003C_003E8__locals4.rX0tzX4T6A = this;
			CS_0024_003C_003E8__locals4.weVSc3yYwG = value;
			SetProperty(ref BgbPI2AHbW, CS_0024_003C_003E8__locals4.weVSc3yYwG, iFZ5je3XFYKwkvcE5D.D35lls5iF(10186, iFZ5je3XFYKwkvcE5D.N06TeK0ao), null, [AsyncStateMachine(typeof(_003C_003Ec__DisplayClass18_0.U6amlkFlqHJ2XBZjuu))] () =>
			{
				_003C_003Ec__DisplayClass18_0.U6amlkFlqHJ2XBZjuu stateMachine = default(_003C_003Ec__DisplayClass18_0.U6amlkFlqHJ2XBZjuu);
				stateMachine.AfknAKwVsV = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
				stateMachine.L9xnNJ52N0 = CS_0024_003C_003E8__locals4;
				stateMachine.rcJnuTi6Kd = -1;
				stateMachine.AfknAKwVsV.Start(ref stateMachine);
			});
		}
	}

	public SortOrder SelectedOrder
	{
		get
		{
			return WQDPVBYZ5n;
		}
		set
		{
			_003C_003Ec__DisplayClass21_0 CS_0024_003C_003E8__locals4 = new _003C_003Ec__DisplayClass21_0();
			CS_0024_003C_003E8__locals4.LDGSvnhcRN = this;
			CS_0024_003C_003E8__locals4.xKESW7Im9s = value;
			SetProperty(ref WQDPVBYZ5n, CS_0024_003C_003E8__locals4.xKESW7Im9s, iFZ5je3XFYKwkvcE5D.D35lls5iF(8208, iFZ5je3XFYKwkvcE5D.N06TeK0ao), null, [AsyncStateMachine(typeof(_003C_003Ec__DisplayClass21_0.sY2xp36dy46B7QLcow))] () =>
			{
				_003C_003Ec__DisplayClass21_0.sY2xp36dy46B7QLcow stateMachine = default(_003C_003Ec__DisplayClass21_0.sY2xp36dy46B7QLcow);
				stateMachine.fwhnxvBYFs = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
				stateMachine.cllnyeWErl = CS_0024_003C_003E8__locals4;
				stateMachine.mXMns56wLV = -1;
				stateMachine.fwhnxvBYFs.Start(ref stateMachine);
			});
		}
	}

	public GeneralSort SelectedSort
	{
		get
		{
			return rnIPa3d81E;
		}
		set
		{
			_003C_003Ec__DisplayClass24_0 CS_0024_003C_003E8__locals4 = new _003C_003Ec__DisplayClass24_0();
			CS_0024_003C_003E8__locals4.bBGSBRLwPY = this;
			CS_0024_003C_003E8__locals4.GKdSD5TnXg = value;
			SetProperty(ref rnIPa3d81E, CS_0024_003C_003E8__locals4.GKdSD5TnXg, iFZ5je3XFYKwkvcE5D.D35lls5iF(10222, iFZ5je3XFYKwkvcE5D.N06TeK0ao), null, [AsyncStateMachine(typeof(_003C_003Ec__DisplayClass24_0.CBgZN6sLSXkET01iDl))] () =>
			{
				_003C_003Ec__DisplayClass24_0.CBgZN6sLSXkET01iDl stateMachine = default(_003C_003Ec__DisplayClass24_0.CBgZN6sLSXkET01iDl);
				stateMachine.KKKnwfDEaA = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
				stateMachine.iqinE9EsNH = CS_0024_003C_003E8__locals4;
				stateMachine.SSBnRUZbyh = -1;
				stateMachine.KKKnwfDEaA.Start(ref stateMachine);
			});
		}
	}

	public AlbumsViewModel()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		WQDPVBYZ5n = SortOrder.Desc;
		rnIPa3d81E = GeneralSort.ActivateDate;
		base._002Ector();
		base.TotalCount = -1;
		fvQPqF86Ce = AppContainer.Resolve<IMusicService>();
		base.FetchMoreDataCommand = new AsyncCommand(OnFetchMoreDataCommand);
		base.SearchQuery = new ApiQuery<AlbumSearch, GeneralSort>
		{
			Count = 25,
			Search = new AlbumSearch()
		};
		TZKoniL3skJOMFjZKk4.D35lls5iF(this, new List<GeneralSort>
		{
			GeneralSort.Name,
			GeneralSort.Rating,
			GeneralSort.ReleaseYear,
			GeneralSort.ActivateDate,
			GeneralSort.Hottness,
			GeneralSort.Popularity
		}, TZKoniL3skJOMFjZKk4.I2XLcNuk44);
	}

	[AsyncStateMachine(typeof(_003CLoadAlbums_003Ed__26))]
	public Task LoadAlbums()
	{
		_003CLoadAlbums_003Ed__26 stateMachine = default(_003CLoadAlbums_003Ed__26);
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

	[AsyncStateMachine(typeof(_003COnFetchMoreDataCommand_003Ed__28))]
	protected Task OnFetchMoreDataCommand()
	{
		_003COnFetchMoreDataCommand_003Ed__28 stateMachine = default(_003COnFetchMoreDataCommand_003Ed__28);
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

	[AsyncStateMachine(typeof(_003CAddMoreItems_003Ed__30))]
	public override Task AddMoreItems()
	{
		_003CAddMoreItems_003Ed__30 stateMachine = default(_003CAddMoreItems_003Ed__30);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	[AsyncStateMachine(typeof(_003CGoToPage_003Ed__31))]
	public override Task GoToPage(AlbumResponseDto model)
	{
		_003CGoToPage_003Ed__31 stateMachine = default(_003CGoToPage_003Ed__31);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine.model = model;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	public override void OnLoading()
	{
		EcRAvP4y5i6535dlslT.D35lls5iF(this, EcRAvP4y5i6535dlslT.vdQLMsx2Q8);
		if (!base.Items.Any())
		{
			Task task = LoadAsync();
			Action<Exception> action = null;
			bool flag = false;
			gBlEqv8jRKikCj2DMZp.D35lls5iF(task, ref action, ref flag, gBlEqv8jRKikCj2DMZp.pSp8ymt8Mu);
		}
	}

	[AsyncStateMachine(typeof(_003CLoadAsync_003Ed__33))]
	public override Task LoadAsync()
	{
		_003CLoadAsync_003Ed__33 stateMachine = default(_003CLoadAsync_003Ed__33);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	[CompilerGenerated]
	[AsyncStateMachine(typeof(_003C_003CAddMoreItems_003Eb__30_1_003Ed))]
	private Task S0YPDw4Rru()
	{
		_003C_003CAddMoreItems_003Eb__30_1_003Ed stateMachine = default(_003C_003CAddMoreItems_003Eb__30_1_003Ed);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	[AsyncStateMachine(typeof(_003C_003CLoadAsync_003Eb__33_1_003Ed))]
	[CompilerGenerated]
	private Task L7PPddgPo5()
	{
		_003C_003CLoadAsync_003Eb__33_1_003Ed stateMachine = default(_003C_003CLoadAsync_003Eb__33_1_003Ed);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}
}
