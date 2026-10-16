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
using PROTV.Wpf.Bootstrap;

namespace PROTV.Wpf.ViewModels;

public class ArtistsViewModel : BaseListViewModel<PersonResponseDto, ApiQuery<PeopleSearch, GeneralSort>>
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct ERuQTGuB9eu698O4OV : IAsyncStateMachine
		{
			public int bDDQNsPIM6;

			public AsyncVoidMethodBuilder sX2QMCoJ8M;

			public _003C_003Ec__DisplayClass14_0 eJ1QCaYxQC;

			private bool VZHQYhJ4eN;

			private object XOPQFdyOUP;

			private int G7NQ6c1Vxf;

			private ResponseList<PersonResponseDto> tXrQsOX4AT;

			private TaskAwaiter<ResponseList<PersonResponseDto>> KAJQxPdGic;

			private IEnumerator<PersonResponseDto> OqrQyefPfr;

			private PersonResponseDto h9rQpVHV9X;

			private TaskAwaiter PxlQiO4BdO;

			private TaskAwaiter<bool> w8rQ3jfvN1;

			private void MoveNext()
			{
				int num = bDDQNsPIM6;
				_003C_003Ec__DisplayClass14_0 obj = eJ1QCaYxQC;
				try
				{
					if ((uint)num <= 1u)
					{
						goto IL_004e;
					}
					if (num != 2)
					{
						obj.RPUtX3dR7W.Items.Clear();
						VZHQYhJ4eN = true;
						goto IL_053d;
					}
					TaskAwaiter<bool> awaiter = w8rQ3jfvN1;
					w8rQ3jfvN1 = default(TaskAwaiter<bool>);
					num = (bDDQNsPIM6 = -1);
					goto IL_0502;
					IL_0536:
					XOPQFdyOUP = null;
					goto IL_053d;
					IL_0502:
					if (awaiter.GetResult())
					{
						VZHQYhJ4eN = true;
						obj.RPUtX3dR7W.pAhdQXwaKX = AppContainer.Resolve<IPeopleService>();
					}
					goto IL_0536;
					IL_004e:
					try
					{
						TaskAwaiter<ResponseList<PersonResponseDto>> awaiter2;
						if (num != 0)
						{
							if (num == 1)
							{
								goto IL_02fd;
							}
							obj.RPUtX3dR7W.SearchQuery.Page = 1;
							if (S1a0wT9Ixre9OpDny8h.D35lls5iF(eVlRnEIaHT0dqvCx0Kx.D35lls5iF(obj.iU8tRBxEsG, eVlRnEIaHT0dqvCx0Kx.fa575yQKq4), iFZ5je3XFYKwkvcE5D.D35lls5iF(17100, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO))
							{
								lASFo76QIUBEikAAsE9.D35lls5iF(obj.RPUtX3dR7W.SearchQuery.Search, Language.English, lASFo76QIUBEikAAsE9.UMA6X462Ew);
							}
							if (S1a0wT9Ixre9OpDny8h.D35lls5iF(eVlRnEIaHT0dqvCx0Kx.D35lls5iF(obj.iU8tRBxEsG, eVlRnEIaHT0dqvCx0Kx.fa575yQKq4), iFZ5je3XFYKwkvcE5D.D35lls5iF(17118, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO))
							{
								lASFo76QIUBEikAAsE9.D35lls5iF(obj.RPUtX3dR7W.SearchQuery.Search, Language.Arabic, lASFo76QIUBEikAAsE9.UMA6X462Ew);
							}
							if (S1a0wT9Ixre9OpDny8h.D35lls5iF(eVlRnEIaHT0dqvCx0Kx.D35lls5iF(obj.iU8tRBxEsG, eVlRnEIaHT0dqvCx0Kx.fa575yQKq4), iFZ5je3XFYKwkvcE5D.D35lls5iF(17134, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO))
							{
								lASFo76QIUBEikAAsE9.D35lls5iF(obj.RPUtX3dR7W.SearchQuery.Search, Language.Other, lASFo76QIUBEikAAsE9.UMA6X462Ew);
							}
							if (S1a0wT9Ixre9OpDny8h.D35lls5iF(eVlRnEIaHT0dqvCx0Kx.D35lls5iF(obj.iU8tRBxEsG, eVlRnEIaHT0dqvCx0Kx.fa575yQKq4), iFZ5je3XFYKwkvcE5D.D35lls5iF(17148, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO))
							{
								lASFo76QIUBEikAAsE9.D35lls5iF(obj.RPUtX3dR7W.SearchQuery.Search, Language.Turkish, lASFo76QIUBEikAAsE9.UMA6X462Ew);
							}
							if (S1a0wT9Ixre9OpDny8h.D35lls5iF(eVlRnEIaHT0dqvCx0Kx.D35lls5iF(obj.iU8tRBxEsG, eVlRnEIaHT0dqvCx0Kx.fa575yQKq4), iFZ5je3XFYKwkvcE5D.D35lls5iF(17166, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO))
							{
								lASFo76QIUBEikAAsE9.D35lls5iF(obj.RPUtX3dR7W.SearchQuery.Search, Language.Japanese, lASFo76QIUBEikAAsE9.UMA6X462Ew);
							}
							if (S1a0wT9Ixre9OpDny8h.D35lls5iF(eVlRnEIaHT0dqvCx0Kx.D35lls5iF(obj.iU8tRBxEsG, eVlRnEIaHT0dqvCx0Kx.fa575yQKq4), iFZ5je3XFYKwkvcE5D.D35lls5iF(16162, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO))
							{
								lASFo76QIUBEikAAsE9.D35lls5iF(obj.RPUtX3dR7W.SearchQuery.Search, null, lASFo76QIUBEikAAsE9.UMA6X462Ew);
							}
							awaiter2 = qt8YmPCXo6eMDhSrxfM.D35lls5iF(obj.RPUtX3dR7W.pAhdQXwaKX, obj.RPUtX3dR7W.SearchQuery, qt8YmPCXo6eMDhSrxfM.VxbCfJkjnS).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num = (bDDQNsPIM6 = 0);
								KAJQxPdGic = awaiter2;
								sX2QMCoJ8M.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
						}
						else
						{
							awaiter2 = KAJQxPdGic;
							KAJQxPdGic = default(TaskAwaiter<ResponseList<PersonResponseDto>>);
							num = (bDDQNsPIM6 = -1);
						}
						ResponseList<PersonResponseDto> result = awaiter2.GetResult();
						tXrQsOX4AT = result;
						if (tXrQsOX4AT != null && tXrQsOX4AT.Status)
						{
							OqrQyefPfr = tXrQsOX4AT.Data.Result.GetEnumerator();
							goto IL_02fd;
						}
						obj.RPUtX3dR7W.TotalCount = 0;
						goto IL_0452;
						IL_0452:
						tXrQsOX4AT = null;
						goto end_IL_004e;
						IL_02fd:
						try
						{
							if (num != 1)
							{
								goto IL_03ac;
							}
							TaskAwaiter awaiter3 = PxlQiO4BdO;
							PxlQiO4BdO = default(TaskAwaiter);
							num = (bDDQNsPIM6 = -1);
							goto IL_0383;
							IL_0383:
							oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter3, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
							obj.RPUtX3dR7W.Items.Add(h9rQpVHV9X);
							h9rQpVHV9X = null;
							goto IL_03ac;
							IL_03ac:
							if (hjMnupQVVDlRZAYQJC.D35lls5iF(OqrQyefPfr, hjMnupQVVDlRZAYQJC.QV1TFwytOj))
							{
								h9rQpVHV9X = OqrQyefPfr.Current;
								awaiter3 = QliBEUviwWqgtMcBndV.D35lls5iF(pvrKKy8Mk1kpdmIfp3A.D35lls5iF(2, pvrKKy8Mk1kpdmIfp3A.aVh8SPrFkE), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
								if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter3, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
								{
									num = (bDDQNsPIM6 = 1);
									PxlQiO4BdO = awaiter3;
									sX2QMCoJ8M.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
									return;
								}
								goto IL_0383;
							}
						}
						finally
						{
							if (num < 0 && OqrQyefPfr != null)
							{
								xLO56JniGyickVjO1Ot.D35lls5iF(OqrQyefPfr, xLO56JniGyickVjO1Ot.ydbT2bsoH4);
							}
						}
						OqrQyefPfr = null;
						obj.RPUtX3dR7W.CurrentPage = tXrQsOX4AT.Data.CurrentPage;
						obj.RPUtX3dR7W.PageCount = tXrQsOX4AT.Data.PageCount;
						obj.RPUtX3dR7W.TotalCount = tXrQsOX4AT.Data.Total;
						goto IL_0452;
						end_IL_004e:;
					}
					catch (PROTVException xOPQFdyOUP)
					{
						XOPQFdyOUP = xOPQFdyOUP;
						G7NQ6c1Vxf = 1;
					}
					int num2 = G7NQ6c1Vxf;
					if (num2 == 1)
					{
						if (TNckS5wtLfB2Lk9dYP8.D35lls5iF((PROTVException)XOPQFdyOUP, TNckS5wtLfB2Lk9dYP8.oGkwV3iq3t) == ExceptionType.AuthorizationTokenInvalid)
						{
							awaiter = bAA7Sxw7vZsvusOmDea.D35lls5iF(AppContainer.Resolve<MainViewModel>(), bAA7Sxw7vZsvusOmDea.gytwc9U7r5).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = (bDDQNsPIM6 = 2);
								w8rQ3jfvN1 = awaiter;
								sX2QMCoJ8M.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_0502;
						}
						obj.RPUtX3dR7W.TotalCount = 0;
					}
					goto IL_0536;
					IL_053d:
					if (VZHQYhJ4eN)
					{
						VZHQYhJ4eN = false;
						G7NQ6c1Vxf = 0;
						goto IL_004e;
					}
				}
				catch (Exception ex)
				{
					bDDQNsPIM6 = -2;
					N2XUglA3neBsnlZfRPQ.D35lls5iF(ref sX2QMCoJ8M, ex, N2XUglA3neBsnlZfRPQ.l4pATRumoW);
					return;
				}
				bDDQNsPIM6 = -2;
				T4XmPoA4VNJJP1afcgL.D35lls5iF(ref sX2QMCoJ8M, T4XmPoA4VNJJP1afcgL.TRyALZckCh);
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine P_0)
			{
				dHWo7jAEn6E4X7bsY4R.D35lls5iF(ref sX2QMCoJ8M, P_0, dHWo7jAEn6E4X7bsY4R.z3hAB6UZ9o);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine P_0)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(P_0);
			}
		}

		public ArtistsViewModel RPUtX3dR7W;

		public LanguageResponseDto iU8tRBxEsG;

		public _003C_003Ec__DisplayClass14_0()
		{
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
			base._002Ector();
		}

		[AsyncStateMachine(typeof(ERuQTGuB9eu698O4OV))]
		internal void vR3tm7RouP()
		{
			ERuQTGuB9eu698O4OV stateMachine = default(ERuQTGuB9eu698O4OV);
			stateMachine.sX2QMCoJ8M = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
			stateMachine.eJ1QCaYxQC = this;
			stateMachine.bDDQNsPIM6 = -1;
			stateMachine.sX2QMCoJ8M.Start(ref stateMachine);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass17_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct t7wpEAAKpk79Myd3B0 : IAsyncStateMachine
		{
			public int Bj0Qm8KW4A;

			public AsyncVoidMethodBuilder Hi5QXg2fnQ;

			public _003C_003Ec__DisplayClass17_0 z7lQRFHqFK;

			private ResponseList<PersonResponseDto> Y7dQwCq8EO;

			private TaskAwaiter<ResponseList<PersonResponseDto>> R7eQEFjqh4;

			private IEnumerator<PersonResponseDto> J1vQ9Ouq0H;

			private PersonResponseDto rptQebcSUi;

			private TaskAwaiter KNbQOMr5a4;

			private void MoveNext()
			{
				int num = Bj0Qm8KW4A;
				_003C_003Ec__DisplayClass17_0 obj = z7lQRFHqFK;
				try
				{
					if ((uint)num > 1u)
					{
						obj.axitEnlmkX.Items.Clear();
					}
					try
					{
						TaskAwaiter<ResponseList<PersonResponseDto>> awaiter;
						if (num != 0)
						{
							if (num == 1)
							{
								goto IL_0118;
							}
							obj.axitEnlmkX.SearchQuery.Page = 1;
							obj.axitEnlmkX.SearchQuery.Order = obj.PTlt9gYbky;
							awaiter = qt8YmPCXo6eMDhSrxfM.D35lls5iF(obj.axitEnlmkX.pAhdQXwaKX, obj.axitEnlmkX.SearchQuery, qt8YmPCXo6eMDhSrxfM.VxbCfJkjnS).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = (Bj0Qm8KW4A = 0);
								R7eQEFjqh4 = awaiter;
								Hi5QXg2fnQ.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = R7eQEFjqh4;
							R7eQEFjqh4 = default(TaskAwaiter<ResponseList<PersonResponseDto>>);
							num = (Bj0Qm8KW4A = -1);
						}
						ResponseList<PersonResponseDto> result = awaiter.GetResult();
						Y7dQwCq8EO = result;
						if (Y7dQwCq8EO != null && Y7dQwCq8EO.Status)
						{
							J1vQ9Ouq0H = Y7dQwCq8EO.Data.Result.GetEnumerator();
							goto IL_0118;
						}
						obj.axitEnlmkX.TotalCount = 0;
						goto IL_026d;
						IL_026d:
						Y7dQwCq8EO = null;
						goto end_IL_002d;
						IL_0118:
						try
						{
							if (num != 1)
							{
								goto IL_01c7;
							}
							TaskAwaiter awaiter2 = KNbQOMr5a4;
							KNbQOMr5a4 = default(TaskAwaiter);
							num = (Bj0Qm8KW4A = -1);
							goto IL_019e;
							IL_019e:
							oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter2, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
							obj.axitEnlmkX.Items.Add(rptQebcSUi);
							rptQebcSUi = null;
							goto IL_01c7;
							IL_01c7:
							if (hjMnupQVVDlRZAYQJC.D35lls5iF(J1vQ9Ouq0H, hjMnupQVVDlRZAYQJC.QV1TFwytOj))
							{
								rptQebcSUi = J1vQ9Ouq0H.Current;
								awaiter2 = QliBEUviwWqgtMcBndV.D35lls5iF(pvrKKy8Mk1kpdmIfp3A.D35lls5iF(2, pvrKKy8Mk1kpdmIfp3A.aVh8SPrFkE), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
								if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter2, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
								{
									num = (Bj0Qm8KW4A = 1);
									KNbQOMr5a4 = awaiter2;
									Hi5QXg2fnQ.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									return;
								}
								goto IL_019e;
							}
						}
						finally
						{
							if (num < 0 && J1vQ9Ouq0H != null)
							{
								xLO56JniGyickVjO1Ot.D35lls5iF(J1vQ9Ouq0H, xLO56JniGyickVjO1Ot.ydbT2bsoH4);
							}
						}
						J1vQ9Ouq0H = null;
						obj.axitEnlmkX.CurrentPage = Y7dQwCq8EO.Data.CurrentPage;
						obj.axitEnlmkX.PageCount = Y7dQwCq8EO.Data.PageCount;
						obj.axitEnlmkX.TotalCount = Y7dQwCq8EO.Data.Total;
						goto IL_026d;
						end_IL_002d:;
					}
					catch
					{
						obj.axitEnlmkX.TotalCount = 0;
					}
				}
				catch (Exception ex)
				{
					Bj0Qm8KW4A = -2;
					N2XUglA3neBsnlZfRPQ.D35lls5iF(ref Hi5QXg2fnQ, ex, N2XUglA3neBsnlZfRPQ.l4pATRumoW);
					return;
				}
				Bj0Qm8KW4A = -2;
				T4XmPoA4VNJJP1afcgL.D35lls5iF(ref Hi5QXg2fnQ, T4XmPoA4VNJJP1afcgL.TRyALZckCh);
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine P_0)
			{
				dHWo7jAEn6E4X7bsY4R.D35lls5iF(ref Hi5QXg2fnQ, P_0, dHWo7jAEn6E4X7bsY4R.z3hAB6UZ9o);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine P_0)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(P_0);
			}
		}

		public ArtistsViewModel axitEnlmkX;

		public SortOrder PTlt9gYbky;

		public _003C_003Ec__DisplayClass17_0()
		{
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
			base._002Ector();
		}

		[AsyncStateMachine(typeof(t7wpEAAKpk79Myd3B0))]
		internal void d1JtwFXSDg()
		{
			t7wpEAAKpk79Myd3B0 stateMachine = default(t7wpEAAKpk79Myd3B0);
			stateMachine.Hi5QXg2fnQ = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
			stateMachine.z7lQRFHqFK = this;
			stateMachine.Bj0Qm8KW4A = -1;
			stateMachine.Hi5QXg2fnQ.Start(ref stateMachine);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass20_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct XNxiN9NwNHCvMgqn5i : IAsyncStateMachine
		{
			public int K9DQrS3CFd;

			public AsyncVoidMethodBuilder dYcQH8p0BF;

			public _003C_003Ec__DisplayClass20_0 yDiQoNILna;

			private ResponseList<PersonResponseDto> UCTQgBtgZP;

			private TaskAwaiter<ResponseList<PersonResponseDto>> jGaQ1EVFiV;

			private IEnumerator<PersonResponseDto> AHLQJi6Qs2;

			private PersonResponseDto rvpQhiG5Rr;

			private TaskAwaiter rfwQl7dV5C;

			private void MoveNext()
			{
				int num = K9DQrS3CFd;
				_003C_003Ec__DisplayClass20_0 obj = yDiQoNILna;
				try
				{
					if ((uint)num > 1u)
					{
						obj.z5ktOJirm1.Items.Clear();
					}
					try
					{
						TaskAwaiter<ResponseList<PersonResponseDto>> awaiter;
						if (num != 0)
						{
							if (num == 1)
							{
								goto IL_0118;
							}
							obj.z5ktOJirm1.SearchQuery.Page = 1;
							obj.z5ktOJirm1.SearchQuery.Sort = obj.QF6trPrCYo;
							awaiter = qt8YmPCXo6eMDhSrxfM.D35lls5iF(obj.z5ktOJirm1.pAhdQXwaKX, obj.z5ktOJirm1.SearchQuery, qt8YmPCXo6eMDhSrxfM.VxbCfJkjnS).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = (K9DQrS3CFd = 0);
								jGaQ1EVFiV = awaiter;
								dYcQH8p0BF.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = jGaQ1EVFiV;
							jGaQ1EVFiV = default(TaskAwaiter<ResponseList<PersonResponseDto>>);
							num = (K9DQrS3CFd = -1);
						}
						ResponseList<PersonResponseDto> result = awaiter.GetResult();
						UCTQgBtgZP = result;
						if (UCTQgBtgZP != null && UCTQgBtgZP.Status)
						{
							AHLQJi6Qs2 = UCTQgBtgZP.Data.Result.GetEnumerator();
							goto IL_0118;
						}
						obj.z5ktOJirm1.TotalCount = 0;
						goto IL_026d;
						IL_026d:
						UCTQgBtgZP = null;
						goto end_IL_002d;
						IL_0118:
						try
						{
							if (num != 1)
							{
								goto IL_01c7;
							}
							TaskAwaiter awaiter2 = rfwQl7dV5C;
							rfwQl7dV5C = default(TaskAwaiter);
							num = (K9DQrS3CFd = -1);
							goto IL_019e;
							IL_019e:
							oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter2, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
							obj.z5ktOJirm1.Items.Add(rvpQhiG5Rr);
							rvpQhiG5Rr = null;
							goto IL_01c7;
							IL_01c7:
							if (hjMnupQVVDlRZAYQJC.D35lls5iF(AHLQJi6Qs2, hjMnupQVVDlRZAYQJC.QV1TFwytOj))
							{
								rvpQhiG5Rr = AHLQJi6Qs2.Current;
								awaiter2 = QliBEUviwWqgtMcBndV.D35lls5iF(pvrKKy8Mk1kpdmIfp3A.D35lls5iF(2, pvrKKy8Mk1kpdmIfp3A.aVh8SPrFkE), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
								if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter2, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
								{
									num = (K9DQrS3CFd = 1);
									rfwQl7dV5C = awaiter2;
									dYcQH8p0BF.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									return;
								}
								goto IL_019e;
							}
						}
						finally
						{
							if (num < 0 && AHLQJi6Qs2 != null)
							{
								xLO56JniGyickVjO1Ot.D35lls5iF(AHLQJi6Qs2, xLO56JniGyickVjO1Ot.ydbT2bsoH4);
							}
						}
						AHLQJi6Qs2 = null;
						obj.z5ktOJirm1.CurrentPage = UCTQgBtgZP.Data.CurrentPage;
						obj.z5ktOJirm1.PageCount = UCTQgBtgZP.Data.PageCount;
						obj.z5ktOJirm1.TotalCount = UCTQgBtgZP.Data.Total;
						goto IL_026d;
						end_IL_002d:;
					}
					catch
					{
						obj.z5ktOJirm1.TotalCount = 0;
					}
				}
				catch (Exception ex)
				{
					K9DQrS3CFd = -2;
					N2XUglA3neBsnlZfRPQ.D35lls5iF(ref dYcQH8p0BF, ex, N2XUglA3neBsnlZfRPQ.l4pATRumoW);
					return;
				}
				K9DQrS3CFd = -2;
				T4XmPoA4VNJJP1afcgL.D35lls5iF(ref dYcQH8p0BF, T4XmPoA4VNJJP1afcgL.TRyALZckCh);
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine P_0)
			{
				dHWo7jAEn6E4X7bsY4R.D35lls5iF(ref dYcQH8p0BF, P_0, dHWo7jAEn6E4X7bsY4R.z3hAB6UZ9o);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine P_0)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(P_0);
			}
		}

		public ArtistsViewModel z5ktOJirm1;

		public GeneralSort QF6trPrCYo;

		public _003C_003Ec__DisplayClass20_0()
		{
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
			base._002Ector();
		}

		[AsyncStateMachine(typeof(XNxiN9NwNHCvMgqn5i))]
		internal void ASrte9fxaU()
		{
			XNxiN9NwNHCvMgqn5i stateMachine = default(XNxiN9NwNHCvMgqn5i);
			stateMachine.dYcQH8p0BF = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
			stateMachine.yDiQoNILna = this;
			stateMachine.K9DQrS3CFd = -1;
			stateMachine.dYcQH8p0BF.Start(ref stateMachine);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLoadArtist_003Ed__22 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ArtistsViewModel _003C_003E4__this;

		private bool _003CtryAgain_003E5__2;

		private object _003C_003E7__wrap2;

		private int _003C_003E7__wrap3;

		private ResponseList<PersonResponseDto> _003Cresult_003E5__5;

		private TaskAwaiter<ResponseList<PersonResponseDto>> _003C_003Eu__1;

		private IEnumerator<PersonResponseDto> _003C_003E7__wrap5;

		private PersonResponseDto _003Citem_003E5__7;

		private TaskAwaiter _003C_003Eu__2;

		private TaskAwaiter<bool> _003C_003Eu__3;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ArtistsViewModel artistsViewModel = _003C_003E4__this;
			try
			{
				if ((uint)num <= 1u)
				{
					goto IL_00b4;
				}
				if (num != 2)
				{
					artistsViewModel.Items.Clear();
					artistsViewModel.SearchQuery.Page = 1;
					artistsViewModel.SearchQuery.Count = 25;
					artistsViewModel.SearchQuery.Sort = GeneralSort.ActivateDate;
					artistsViewModel.SearchQuery.Order = SortOrder.Desc;
					jBX0HFL8MaG35apulAr.D35lls5iF(artistsViewModel.SearchQuery.Search, PersonType.Singer, jBX0HFL8MaG35apulAr.WYuLn9C2gR);
					wuXoja6xGA4YsTL6UdU.D35lls5iF(artistsViewModel.SearchQuery.Search, null, wuXoja6xGA4YsTL6UdU.CZiCQR3VK3);
					_003CtryAgain_003E5__2 = true;
					goto IL_038e;
				}
				TaskAwaiter<bool> awaiter = _003C_003Eu__3;
				_003C_003Eu__3 = default(TaskAwaiter<bool>);
				num = (_003C_003E1__state = -1);
				goto IL_035d;
				IL_0387:
				_003C_003E7__wrap2 = null;
				goto IL_038e;
				IL_035d:
				if (awaiter.GetResult())
				{
					_003CtryAgain_003E5__2 = true;
					artistsViewModel.pAhdQXwaKX = AppContainer.Resolve<IPeopleService>();
				}
				goto IL_0387;
				IL_00b4:
				try
				{
					TaskAwaiter<ResponseList<PersonResponseDto>> awaiter2;
					if (num != 0)
					{
						if (num == 1)
						{
							goto IL_0171;
						}
						awaiter2 = qt8YmPCXo6eMDhSrxfM.D35lls5iF(artistsViewModel.pAhdQXwaKX, artistsViewModel.SearchQuery, qt8YmPCXo6eMDhSrxfM.VxbCfJkjnS).GetAwaiter();
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
						_003C_003Eu__1 = default(TaskAwaiter<ResponseList<PersonResponseDto>>);
						num = (_003C_003E1__state = -1);
					}
					ResponseList<PersonResponseDto> result = awaiter2.GetResult();
					_003Cresult_003E5__5 = result;
					if (_003Cresult_003E5__5 != null && _003Cresult_003E5__5.Status)
					{
						_003C_003E7__wrap5 = _003Cresult_003E5__5.Data.Result.GetEnumerator();
						goto IL_0171;
					}
					artistsViewModel.TotalCount = 0;
					goto IL_02ad;
					IL_02ad:
					_003Cresult_003E5__5 = null;
					goto end_IL_00b4;
					IL_0171:
					try
					{
						if (num != 1)
						{
							goto IL_021b;
						}
						TaskAwaiter awaiter3 = _003C_003Eu__2;
						_003C_003Eu__2 = default(TaskAwaiter);
						num = (_003C_003E1__state = -1);
						goto IL_01f7;
						IL_01f7:
						oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter3, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
						artistsViewModel.Items.Add(_003Citem_003E5__7);
						_003Citem_003E5__7 = null;
						goto IL_021b;
						IL_021b:
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
							goto IL_01f7;
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
					artistsViewModel.CurrentPage = _003Cresult_003E5__5.Data.CurrentPage;
					artistsViewModel.PageCount = _003Cresult_003E5__5.Data.PageCount;
					artistsViewModel.TotalCount = _003Cresult_003E5__5.Data.Total;
					goto IL_02ad;
					end_IL_00b4:;
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
						goto IL_035d;
					}
					artistsViewModel.TotalCount = 0;
				}
				goto IL_0387;
				IL_038e:
				if (_003CtryAgain_003E5__2)
				{
					_003CtryAgain_003E5__2 = false;
					_003C_003E7__wrap3 = 0;
					goto IL_00b4;
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
	private struct _003COnFetchMoreDataCommand_003Ed__24 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ArtistsViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ArtistsViewModel artistsViewModel = _003C_003E4__this;
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
				if (artistsViewModel.CurrentPage < artistsViewModel.TotalCount && !hjMnupQVVDlRZAYQJC.D35lls5iF(artistsViewModel, hjMnupQVVDlRZAYQJC.jJYTSHn9tB))
				{
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(artistsViewModel.AddMoreItems(), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
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
	private struct _003CAddMoreItems_003Ed__26 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ArtistsViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ArtistsViewModel CS_0024_003C_003E8__locals5 = _003C_003E4__this;
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
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(W7S2sip6SDieZFVsNbd.D35lls5iF(CS_0024_003C_003E8__locals5, Expression.Lambda<Func<bool>>(OWBKr5pvc5MWsK1OMtR.D35lls5iF(o4bYL4peNeC2wWb8yjx.D35lls5iF(CS_0024_003C_003E8__locals5, sjYxHO8OWlc6X80hFj7.D35lls5iF(typeof(ArtistsViewModel).TypeHandle, sjYxHO8OWlc6X80hFj7.uWZ8ugU7r5), o4bYL4peNeC2wWb8yjx.oVdpGKjy2x), (MethodInfo)f5q427pRQZnrEKPy4Ws.D35lls5iF((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, f5q427pRQZnrEKPy4Ws.Bo9pk3m4k7), OWBKr5pvc5MWsK1OMtR.fZIpAAdi1v), Array.Empty<ParameterExpression>()), [AsyncStateMachine(typeof(_003C_003CAddMoreItems_003Eb__26_1_003Ed))] () =>
					{
						_003C_003CAddMoreItems_003Eb__26_1_003Ed stateMachine = default(_003C_003CAddMoreItems_003Eb__26_1_003Ed);
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
	private struct _003CGoToPage_003Ed__27 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public PersonResponseDto model;

		private HomeViewModel _003ChomeViewModel_003E5__2;

		private Page _003Cpage_003E5__3;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
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
				PersonResponseDto personResponseDto = model;
				if (personResponseDto != null && WJbFtI6AObf2rNffLCy.D35lls5iF(personResponseDto, WJbFtI6AObf2rNffLCy.GuJCFyBU1U) > 0)
				{
					_003ChomeViewModel_003E5__2 = Sp7dKWL9ZfBld4JOkGo.D35lls5iF(AppContainer.Resolve<MainViewModel>(), Sp7dKWL9ZfBld4JOkGo.QpWwMTMAhO) as HomeViewModel;
					ArtistItemViewModel viewModel = new ArtistItemViewModel(model);
					Page page = new Page();
					KBhlAv9D2TgBJ1kkc0B.D35lls5iF(page, IyGDDwHBiPv8vfOFJDF.D35lls5iF(ApplicationPage.ArtistDetailsView, viewModel, IyGDDwHBiPv8vfOFJDF.hivH0XYhaE), KBhlAv9D2TgBJ1kkc0B.fWUHrWO7Sa);
					qni3xrDkAJ3vF35eMav.D35lls5iF(page, QQLie3eYkZwbFFm9Jjw.D35lls5iF(model, QQLie3eYkZwbFFm9Jjw.EREC2qxa87), qni3xrDkAJ3vF35eMav.Ra7HRFTvnD);
					_003Cpage_003E5__3 = page;
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(pvrKKy8Mk1kpdmIfp3A.D35lls5iF(5, pvrKKy8Mk1kpdmIfp3A.aVh8SPrFkE), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
					if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_0103;
				}
				goto end_IL_000e;
				IL_0103:
				oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
				GmMLaTD7kV8rq88ZFvR.D35lls5iF(Xlypb0Hnr2C3ydrYEdG.D35lls5iF(_003ChomeViewModel_003E5__2, Xlypb0Hnr2C3ydrYEdG.U3Z1IKMGuZ), _003Cpage_003E5__3, GmMLaTD7kV8rq88ZFvR.iMJHkmaaRY);
				_003ChomeViewModel_003E5__2 = null;
				_003Cpage_003E5__3 = null;
				end_IL_000e:;
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
	private struct _003CLoadAsync_003Ed__29 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ArtistsViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ArtistsViewModel CS_0024_003C_003E8__locals3 = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(W7S2sip6SDieZFVsNbd.D35lls5iF(CS_0024_003C_003E8__locals3, Expression.Lambda<Func<bool>>(OWBKr5pvc5MWsK1OMtR.D35lls5iF(o4bYL4peNeC2wWb8yjx.D35lls5iF(CS_0024_003C_003E8__locals3, sjYxHO8OWlc6X80hFj7.D35lls5iF(typeof(ArtistsViewModel).TypeHandle, sjYxHO8OWlc6X80hFj7.uWZ8ugU7r5), o4bYL4peNeC2wWb8yjx.oVdpGKjy2x), (MethodInfo)f5q427pRQZnrEKPy4Ws.D35lls5iF((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, f5q427pRQZnrEKPy4Ws.Bo9pk3m4k7), OWBKr5pvc5MWsK1OMtR.fZIpAAdi1v), Array.Empty<ParameterExpression>()), [AsyncStateMachine(typeof(_003C_003CLoadAsync_003Eb__29_1_003Ed))] () =>
					{
						_003C_003CLoadAsync_003Eb__29_1_003Ed stateMachine = default(_003C_003CLoadAsync_003Eb__29_1_003Ed);
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
	private struct _003C_003CAddMoreItems_003Eb__26_1_003Ed : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ArtistsViewModel _003C_003E4__this;

		private bool _003CtryAgain_003E5__2;

		private object _003C_003E7__wrap2;

		private int _003C_003E7__wrap3;

		private ResponseList<PersonResponseDto> _003Cresult_003E5__5;

		private TaskAwaiter<ResponseList<PersonResponseDto>> _003C_003Eu__1;

		private IEnumerator<PersonResponseDto> _003C_003E7__wrap5;

		private PersonResponseDto _003Citem_003E5__7;

		private TaskAwaiter _003C_003Eu__2;

		private TaskAwaiter<bool> _003C_003Eu__3;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ArtistsViewModel artistsViewModel = _003C_003E4__this;
			try
			{
				if ((uint)num <= 1u)
				{
					goto IL_0053;
				}
				if (num != 2)
				{
					artistsViewModel.SearchQuery.Page++;
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
					artistsViewModel.pAhdQXwaKX = AppContainer.Resolve<IPeopleService>();
				}
				goto IL_0340;
				IL_0053:
				try
				{
					TaskAwaiter<ResponseList<PersonResponseDto>> awaiter2;
					if (num != 0)
					{
						if (num == 1)
						{
							goto IL_0110;
						}
						awaiter2 = qt8YmPCXo6eMDhSrxfM.D35lls5iF(artistsViewModel.pAhdQXwaKX, artistsViewModel.SearchQuery, qt8YmPCXo6eMDhSrxfM.VxbCfJkjnS).GetAwaiter();
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
						_003C_003Eu__1 = default(TaskAwaiter<ResponseList<PersonResponseDto>>);
						num = (_003C_003E1__state = -1);
					}
					ResponseList<PersonResponseDto> result = awaiter2.GetResult();
					_003Cresult_003E5__5 = result;
					if (_003Cresult_003E5__5 != null && _003Cresult_003E5__5.Status)
					{
						_003C_003E7__wrap5 = _003Cresult_003E5__5.Data.Result.GetEnumerator();
						goto IL_0110;
					}
					artistsViewModel.SearchQuery.Page--;
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
						artistsViewModel.Items.Add(_003Citem_003E5__7);
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
					artistsViewModel.CurrentPage = _003Cresult_003E5__5.Data.CurrentPage;
					artistsViewModel.PageCount = _003Cresult_003E5__5.Data.PageCount;
					artistsViewModel.TotalCount = _003Cresult_003E5__5.Data.Total;
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
					artistsViewModel.SearchQuery.Page--;
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
	private struct _003C_003CLoadAsync_003Eb__29_1_003Ed : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ArtistsViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ArtistsViewModel artistsViewModel = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(VrVteFCs0OCGBTVr1mZ.D35lls5iF(new Task[1] { OYihPsCZ1OyLa5m4TD0.D35lls5iF(artistsViewModel, OYihPsCZ1OyLa5m4TD0.x7QCj16W2X) }, VrVteFCs0OCGBTVr1mZ.qNlChUR2Cs), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
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

	private IPeopleService pAhdQXwaKX;

	private LanguageResponseDto fUvdnZuBfG;

	private SortOrder CT5dbUqFgx;

	private GeneralSort D8pd7oFeC2;

	[CompilerGenerated]
	private List<LanguageResponseDto> kd5d5TVoCl;

	[CompilerGenerated]
	private List<GeneralSort> J5pdu5sQBR;

	public List<LanguageResponseDto> Languages
	{
		[CompilerGenerated]
		get
		{
			return kd5d5TVoCl;
		}
		[CompilerGenerated]
		set
		{
			kd5d5TVoCl = value;
		}
	}

	public List<GeneralSort> SortItems
	{
		[CompilerGenerated]
		get
		{
			return J5pdu5sQBR;
		}
		[CompilerGenerated]
		set
		{
			J5pdu5sQBR = value;
		}
	}

	public LanguageResponseDto SelectedLanguage
	{
		get
		{
			return fUvdnZuBfG;
		}
		set
		{
			_003C_003Ec__DisplayClass14_0 CS_0024_003C_003E8__locals4 = new _003C_003Ec__DisplayClass14_0();
			CS_0024_003C_003E8__locals4.RPUtX3dR7W = this;
			CS_0024_003C_003E8__locals4.iU8tRBxEsG = value;
			SetProperty(ref fUvdnZuBfG, CS_0024_003C_003E8__locals4.iU8tRBxEsG, iFZ5je3XFYKwkvcE5D.D35lls5iF(10186, iFZ5je3XFYKwkvcE5D.N06TeK0ao), null, [AsyncStateMachine(typeof(_003C_003Ec__DisplayClass14_0.ERuQTGuB9eu698O4OV))] () =>
			{
				_003C_003Ec__DisplayClass14_0.ERuQTGuB9eu698O4OV stateMachine = default(_003C_003Ec__DisplayClass14_0.ERuQTGuB9eu698O4OV);
				stateMachine.sX2QMCoJ8M = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
				stateMachine.eJ1QCaYxQC = CS_0024_003C_003E8__locals4;
				stateMachine.bDDQNsPIM6 = -1;
				stateMachine.sX2QMCoJ8M.Start(ref stateMachine);
			});
		}
	}

	public SortOrder SelectedOrder
	{
		get
		{
			return CT5dbUqFgx;
		}
		set
		{
			_003C_003Ec__DisplayClass17_0 CS_0024_003C_003E8__locals4 = new _003C_003Ec__DisplayClass17_0();
			CS_0024_003C_003E8__locals4.axitEnlmkX = this;
			CS_0024_003C_003E8__locals4.PTlt9gYbky = value;
			SetProperty(ref CT5dbUqFgx, CS_0024_003C_003E8__locals4.PTlt9gYbky, iFZ5je3XFYKwkvcE5D.D35lls5iF(8208, iFZ5je3XFYKwkvcE5D.N06TeK0ao), null, [AsyncStateMachine(typeof(_003C_003Ec__DisplayClass17_0.t7wpEAAKpk79Myd3B0))] () =>
			{
				_003C_003Ec__DisplayClass17_0.t7wpEAAKpk79Myd3B0 stateMachine = default(_003C_003Ec__DisplayClass17_0.t7wpEAAKpk79Myd3B0);
				stateMachine.Hi5QXg2fnQ = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
				stateMachine.z7lQRFHqFK = CS_0024_003C_003E8__locals4;
				stateMachine.Bj0Qm8KW4A = -1;
				stateMachine.Hi5QXg2fnQ.Start(ref stateMachine);
			});
		}
	}

	public GeneralSort SelectedSort
	{
		get
		{
			return D8pd7oFeC2;
		}
		set
		{
			_003C_003Ec__DisplayClass20_0 CS_0024_003C_003E8__locals4 = new _003C_003Ec__DisplayClass20_0();
			CS_0024_003C_003E8__locals4.z5ktOJirm1 = this;
			CS_0024_003C_003E8__locals4.QF6trPrCYo = value;
			SetProperty(ref D8pd7oFeC2, CS_0024_003C_003E8__locals4.QF6trPrCYo, iFZ5je3XFYKwkvcE5D.D35lls5iF(10222, iFZ5je3XFYKwkvcE5D.N06TeK0ao), null, [AsyncStateMachine(typeof(_003C_003Ec__DisplayClass20_0.XNxiN9NwNHCvMgqn5i))] () =>
			{
				_003C_003Ec__DisplayClass20_0.XNxiN9NwNHCvMgqn5i stateMachine = default(_003C_003Ec__DisplayClass20_0.XNxiN9NwNHCvMgqn5i);
				stateMachine.dYcQH8p0BF = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
				stateMachine.yDiQoNILna = CS_0024_003C_003E8__locals4;
				stateMachine.K9DQrS3CFd = -1;
				stateMachine.dYcQH8p0BF.Start(ref stateMachine);
			});
		}
	}

	public ArtistsViewModel()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		CT5dbUqFgx = SortOrder.Desc;
		D8pd7oFeC2 = GeneralSort.ActivateDate;
		base._002Ector();
		base.TotalCount = -1;
		pAhdQXwaKX = AppContainer.Resolve<IPeopleService>();
		base.FetchMoreDataCommand = new AsyncCommand(OnFetchMoreDataCommand);
		ApiQuery<PeopleSearch, GeneralSort> obj = new ApiQuery<PeopleSearch, GeneralSort>
		{
			Count = 25
		};
		PeopleSearch peopleSearch = new PeopleSearch();
		jBX0HFL8MaG35apulAr.D35lls5iF(peopleSearch, PersonType.Singer, jBX0HFL8MaG35apulAr.WYuLn9C2gR);
		obj.Search = peopleSearch;
		base.SearchQuery = obj;
		TZKoniL3skJOMFjZKk4.D35lls5iF(this, new List<GeneralSort>
		{
			GeneralSort.Name,
			GeneralSort.Rating,
			GeneralSort.ReleaseYear,
			GeneralSort.ActivateDate,
			GeneralSort.Hottness,
			GeneralSort.Popularity
		}, TZKoniL3skJOMFjZKk4.rBiLTHqkPo);
	}

	[AsyncStateMachine(typeof(_003CLoadArtist_003Ed__22))]
	public Task LoadArtist()
	{
		_003CLoadArtist_003Ed__22 stateMachine = default(_003CLoadArtist_003Ed__22);
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

	[AsyncStateMachine(typeof(_003COnFetchMoreDataCommand_003Ed__24))]
	protected Task OnFetchMoreDataCommand()
	{
		_003COnFetchMoreDataCommand_003Ed__24 stateMachine = default(_003COnFetchMoreDataCommand_003Ed__24);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	public override void Dispose()
	{
		base.Items.Clear();
		b3QyiYL4pm5cgsTYbRX.D35lls5iF(this, b3QyiYL4pm5cgsTYbRX.h83LLTyfWR);
	}

	[AsyncStateMachine(typeof(_003CAddMoreItems_003Ed__26))]
	public override Task AddMoreItems()
	{
		_003CAddMoreItems_003Ed__26 stateMachine = default(_003CAddMoreItems_003Ed__26);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	[AsyncStateMachine(typeof(_003CGoToPage_003Ed__27))]
	public override Task GoToPage(PersonResponseDto model)
	{
		_003CGoToPage_003Ed__27 stateMachine = default(_003CGoToPage_003Ed__27);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
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

	[AsyncStateMachine(typeof(_003CLoadAsync_003Ed__29))]
	public override Task LoadAsync()
	{
		_003CLoadAsync_003Ed__29 stateMachine = default(_003CLoadAsync_003Ed__29);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	[CompilerGenerated]
	[AsyncStateMachine(typeof(_003C_003CAddMoreItems_003Eb__26_1_003Ed))]
	private Task NJndk7Af4b()
	{
		_003C_003CAddMoreItems_003Eb__26_1_003Ed stateMachine = default(_003C_003CAddMoreItems_003Eb__26_1_003Ed);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	[CompilerGenerated]
	[AsyncStateMachine(typeof(_003C_003CLoadAsync_003Eb__29_1_003Ed))]
	private Task xked8nPTQL()
	{
		_003C_003CLoadAsync_003Eb__29_1_003Ed stateMachine = default(_003C_003CLoadAsync_003Eb__29_1_003Ed);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}
}
