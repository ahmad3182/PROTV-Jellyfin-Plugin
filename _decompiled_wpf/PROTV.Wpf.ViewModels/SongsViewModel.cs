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
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using PROTV.Abstractions.Apis;
using PROTV.Abstractions.Common;
using PROTV.Abstractions.DataTransferObjects;
using PROTV.Abstractions.Helpers;
using PROTV.Abstractions.Search;
using PROTV.Abstractions.Services;
using PROTV.Wpf.Bootstrap;
using PROTV.Wpf.Helpers;
using PROTV.Wpf.Views;

namespace PROTV.Wpf.ViewModels;

public class SongsViewModel : BaseListViewModel<SongResponseDto, ApiQuery<SongSearch, SongSort>>
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass28_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct Pc3uEkMTLnRTjoPG9I : IAsyncStateMachine
		{
			public int SaeQUPEPZ5;

			public AsyncVoidMethodBuilder f30QLjIFU3;

			public _003C_003Ec__DisplayClass28_0 JCYQ2Fmesw;

			private bool EA7QzLqDSk;

			private object VvkncobJMx;

			private int V2Onjnplnf;

			private ResponseList<SongResponseDto> AUtnvTHH6t;

			private TaskAwaiter<ResponseList<SongResponseDto>> hxlnWkhBUx;

			private IEnumerator<SongResponseDto> y9an4ZXqKH;

			private SongResponseDto KpVnBSVETr;

			private TaskAwaiter yaknDEIB06;

			private TaskAwaiter<bool> bUxndhWZUM;

			private void MoveNext()
			{
				int num = SaeQUPEPZ5;
				_003C_003Ec__DisplayClass28_0 obj = JCYQ2Fmesw;
				try
				{
					if ((uint)num <= 1u)
					{
						goto IL_004e;
					}
					if (num != 2)
					{
						obj.SZ4toDjgxF.Items.Clear();
						EA7QzLqDSk = true;
						goto IL_054d;
					}
					TaskAwaiter<bool> awaiter = bUxndhWZUM;
					bUxndhWZUM = default(TaskAwaiter<bool>);
					num = (SaeQUPEPZ5 = -1);
					goto IL_0502;
					IL_0546:
					VvkncobJMx = null;
					goto IL_054d;
					IL_0502:
					if (awaiter.GetResult())
					{
						EA7QzLqDSk = true;
						obj.SZ4toDjgxF.GB6drHVFOO = AppContainer.Resolve<IMusicService>();
					}
					goto IL_0546;
					IL_004e:
					try
					{
						TaskAwaiter<ResponseList<SongResponseDto>> awaiter2;
						if (num != 0)
						{
							if (num == 1)
							{
								goto IL_02fd;
							}
							obj.SZ4toDjgxF.SearchQuery.Page = 1;
							if (S1a0wT9Ixre9OpDny8h.D35lls5iF(eVlRnEIaHT0dqvCx0Kx.D35lls5iF(obj.eTCtgedrYM, eVlRnEIaHT0dqvCx0Kx.fa575yQKq4), iFZ5je3XFYKwkvcE5D.D35lls5iF(17100, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO))
							{
								lASFo76QIUBEikAAsE9.D35lls5iF(obj.SZ4toDjgxF.SearchQuery.Search, Language.English, lASFo76QIUBEikAAsE9.UMA6X462Ew);
							}
							if (S1a0wT9Ixre9OpDny8h.D35lls5iF(eVlRnEIaHT0dqvCx0Kx.D35lls5iF(obj.eTCtgedrYM, eVlRnEIaHT0dqvCx0Kx.fa575yQKq4), iFZ5je3XFYKwkvcE5D.D35lls5iF(17118, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO))
							{
								lASFo76QIUBEikAAsE9.D35lls5iF(obj.SZ4toDjgxF.SearchQuery.Search, Language.Arabic, lASFo76QIUBEikAAsE9.UMA6X462Ew);
							}
							if (S1a0wT9Ixre9OpDny8h.D35lls5iF(eVlRnEIaHT0dqvCx0Kx.D35lls5iF(obj.eTCtgedrYM, eVlRnEIaHT0dqvCx0Kx.fa575yQKq4), iFZ5je3XFYKwkvcE5D.D35lls5iF(17134, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO))
							{
								lASFo76QIUBEikAAsE9.D35lls5iF(obj.SZ4toDjgxF.SearchQuery.Search, Language.Other, lASFo76QIUBEikAAsE9.UMA6X462Ew);
							}
							if (S1a0wT9Ixre9OpDny8h.D35lls5iF(eVlRnEIaHT0dqvCx0Kx.D35lls5iF(obj.eTCtgedrYM, eVlRnEIaHT0dqvCx0Kx.fa575yQKq4), iFZ5je3XFYKwkvcE5D.D35lls5iF(17148, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO))
							{
								lASFo76QIUBEikAAsE9.D35lls5iF(obj.SZ4toDjgxF.SearchQuery.Search, Language.Turkish, lASFo76QIUBEikAAsE9.UMA6X462Ew);
							}
							if (S1a0wT9Ixre9OpDny8h.D35lls5iF(eVlRnEIaHT0dqvCx0Kx.D35lls5iF(obj.eTCtgedrYM, eVlRnEIaHT0dqvCx0Kx.fa575yQKq4), iFZ5je3XFYKwkvcE5D.D35lls5iF(17166, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO))
							{
								lASFo76QIUBEikAAsE9.D35lls5iF(obj.SZ4toDjgxF.SearchQuery.Search, Language.Japanese, lASFo76QIUBEikAAsE9.UMA6X462Ew);
							}
							if (S1a0wT9Ixre9OpDny8h.D35lls5iF(eVlRnEIaHT0dqvCx0Kx.D35lls5iF(obj.eTCtgedrYM, eVlRnEIaHT0dqvCx0Kx.fa575yQKq4), iFZ5je3XFYKwkvcE5D.D35lls5iF(16162, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO))
							{
								lASFo76QIUBEikAAsE9.D35lls5iF(obj.SZ4toDjgxF.SearchQuery.Search, null, lASFo76QIUBEikAAsE9.UMA6X462Ew);
							}
							awaiter2 = minABoCzdK7QB6vVIpY.D35lls5iF(obj.SZ4toDjgxF.GB6drHVFOO, obj.SZ4toDjgxF.SearchQuery, minABoCzdK7QB6vVIpY.JfsmoVshEs).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num = (SaeQUPEPZ5 = 0);
								hxlnWkhBUx = awaiter2;
								f30QLjIFU3.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
						}
						else
						{
							awaiter2 = hxlnWkhBUx;
							hxlnWkhBUx = default(TaskAwaiter<ResponseList<SongResponseDto>>);
							num = (SaeQUPEPZ5 = -1);
						}
						ResponseList<SongResponseDto> result = awaiter2.GetResult();
						AUtnvTHH6t = result;
						if (AUtnvTHH6t != null && AUtnvTHH6t.Status)
						{
							y9an4ZXqKH = AUtnvTHH6t.Data.Result.GetEnumerator();
							goto IL_02fd;
						}
						obj.SZ4toDjgxF.TotalCount = 0;
						goto IL_0452;
						IL_0452:
						AUtnvTHH6t = null;
						goto end_IL_004e;
						IL_02fd:
						try
						{
							if (num != 1)
							{
								goto IL_03ac;
							}
							TaskAwaiter awaiter3 = yaknDEIB06;
							yaknDEIB06 = default(TaskAwaiter);
							num = (SaeQUPEPZ5 = -1);
							goto IL_0383;
							IL_0383:
							oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter3, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
							obj.SZ4toDjgxF.Items.Add(KpVnBSVETr);
							KpVnBSVETr = null;
							goto IL_03ac;
							IL_03ac:
							if (hjMnupQVVDlRZAYQJC.D35lls5iF(y9an4ZXqKH, hjMnupQVVDlRZAYQJC.QV1TFwytOj))
							{
								KpVnBSVETr = y9an4ZXqKH.Current;
								awaiter3 = QliBEUviwWqgtMcBndV.D35lls5iF(pvrKKy8Mk1kpdmIfp3A.D35lls5iF(2, pvrKKy8Mk1kpdmIfp3A.aVh8SPrFkE), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
								if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter3, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
								{
									num = (SaeQUPEPZ5 = 1);
									yaknDEIB06 = awaiter3;
									f30QLjIFU3.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
									return;
								}
								goto IL_0383;
							}
						}
						finally
						{
							if (num < 0 && y9an4ZXqKH != null)
							{
								xLO56JniGyickVjO1Ot.D35lls5iF(y9an4ZXqKH, xLO56JniGyickVjO1Ot.ydbT2bsoH4);
							}
						}
						y9an4ZXqKH = null;
						obj.SZ4toDjgxF.CurrentPage = AUtnvTHH6t.Data.CurrentPage;
						obj.SZ4toDjgxF.PageCount = AUtnvTHH6t.Data.PageCount;
						obj.SZ4toDjgxF.TotalCount = AUtnvTHH6t.Data.Total;
						goto IL_0452;
						end_IL_004e:;
					}
					catch (PROTVException vvkncobJMx)
					{
						VvkncobJMx = vvkncobJMx;
						V2Onjnplnf = 1;
					}
					int num2 = V2Onjnplnf;
					if (num2 == 1)
					{
						if (TNckS5wtLfB2Lk9dYP8.D35lls5iF((PROTVException)VvkncobJMx, TNckS5wtLfB2Lk9dYP8.oGkwV3iq3t) == ExceptionType.AuthorizationTokenInvalid)
						{
							awaiter = bAA7Sxw7vZsvusOmDea.D35lls5iF(AppContainer.Resolve<MainViewModel>(), bAA7Sxw7vZsvusOmDea.gytwc9U7r5).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = (SaeQUPEPZ5 = 2);
								bUxndhWZUM = awaiter;
								f30QLjIFU3.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_0502;
						}
						obj.SZ4toDjgxF.SearchQuery.Page--;
					}
					goto IL_0546;
					IL_054d:
					if (EA7QzLqDSk)
					{
						EA7QzLqDSk = false;
						V2Onjnplnf = 0;
						goto IL_004e;
					}
				}
				catch (Exception ex)
				{
					SaeQUPEPZ5 = -2;
					N2XUglA3neBsnlZfRPQ.D35lls5iF(ref f30QLjIFU3, ex, N2XUglA3neBsnlZfRPQ.l4pATRumoW);
					return;
				}
				SaeQUPEPZ5 = -2;
				T4XmPoA4VNJJP1afcgL.D35lls5iF(ref f30QLjIFU3, T4XmPoA4VNJJP1afcgL.TRyALZckCh);
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine P_0)
			{
				dHWo7jAEn6E4X7bsY4R.D35lls5iF(ref f30QLjIFU3, P_0, dHWo7jAEn6E4X7bsY4R.z3hAB6UZ9o);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine P_0)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(P_0);
			}
		}

		public SongsViewModel SZ4toDjgxF;

		public LanguageResponseDto eTCtgedrYM;

		public _003C_003Ec__DisplayClass28_0()
		{
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
			base._002Ector();
		}

		[AsyncStateMachine(typeof(Pc3uEkMTLnRTjoPG9I))]
		internal void dt6tHL1K48()
		{
			Pc3uEkMTLnRTjoPG9I stateMachine = default(Pc3uEkMTLnRTjoPG9I);
			stateMachine.f30QLjIFU3 = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
			stateMachine.JCYQ2Fmesw = this;
			stateMachine.SaeQUPEPZ5 = -1;
			stateMachine.f30QLjIFU3.Start(ref stateMachine);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass31_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct nUkMeRCx1Vxna9Tdr7 : IAsyncStateMachine
		{
			public int hjJnP9OBsE;

			public AsyncVoidMethodBuilder Yernqq3dGP;

			public _003C_003Ec__DisplayClass31_0 QpBnIAK5Ig;

			private bool ajNnVbMOnx;

			private object yVgnauKjpy;

			private int twGn04m7YE;

			private ResponseList<SongResponseDto> FISnGPtEbh;

			private TaskAwaiter<ResponseList<SongResponseDto>> rjvnTlk8E8;

			private IEnumerator<SongResponseDto> X9ynZpo1j8;

			private SongResponseDto mGyntfk4Pp;

			private TaskAwaiter YL8nSxCxKl;

			private TaskAwaiter<bool> RIJnfuS90e;

			private void MoveNext()
			{
				int num = hjJnP9OBsE;
				_003C_003Ec__DisplayClass31_0 obj = QpBnIAK5Ig;
				try
				{
					if ((uint)num <= 1u)
					{
						goto IL_004e;
					}
					if (num != 2)
					{
						obj.Gr5tJnPwYx.Items.Clear();
						ajNnVbMOnx = true;
						goto IL_0379;
					}
					TaskAwaiter<bool> awaiter = RIJnfuS90e;
					RIJnfuS90e = default(TaskAwaiter<bool>);
					num = (hjJnP9OBsE = -1);
					goto IL_033e;
					IL_0372:
					yVgnauKjpy = null;
					goto IL_0379;
					IL_033e:
					if (awaiter.GetResult())
					{
						ajNnVbMOnx = true;
						obj.Gr5tJnPwYx.GB6drHVFOO = AppContainer.Resolve<IMusicService>();
					}
					goto IL_0372;
					IL_004e:
					try
					{
						TaskAwaiter<ResponseList<SongResponseDto>> awaiter2;
						if (num != 0)
						{
							if (num == 1)
							{
								goto IL_0139;
							}
							obj.Gr5tJnPwYx.SearchQuery.Page = 1;
							obj.Gr5tJnPwYx.SearchQuery.Order = obj.EEtthL8V9k;
							awaiter2 = minABoCzdK7QB6vVIpY.D35lls5iF(obj.Gr5tJnPwYx.GB6drHVFOO, obj.Gr5tJnPwYx.SearchQuery, minABoCzdK7QB6vVIpY.JfsmoVshEs).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num = (hjJnP9OBsE = 0);
								rjvnTlk8E8 = awaiter2;
								Yernqq3dGP.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
						}
						else
						{
							awaiter2 = rjvnTlk8E8;
							rjvnTlk8E8 = default(TaskAwaiter<ResponseList<SongResponseDto>>);
							num = (hjJnP9OBsE = -1);
						}
						ResponseList<SongResponseDto> result = awaiter2.GetResult();
						FISnGPtEbh = result;
						if (FISnGPtEbh != null && FISnGPtEbh.Status)
						{
							X9ynZpo1j8 = FISnGPtEbh.Data.Result.GetEnumerator();
							goto IL_0139;
						}
						obj.Gr5tJnPwYx.TotalCount = 0;
						goto IL_028e;
						IL_028e:
						FISnGPtEbh = null;
						goto end_IL_004e;
						IL_0139:
						try
						{
							if (num != 1)
							{
								goto IL_01e8;
							}
							TaskAwaiter awaiter3 = YL8nSxCxKl;
							YL8nSxCxKl = default(TaskAwaiter);
							num = (hjJnP9OBsE = -1);
							goto IL_01bf;
							IL_01bf:
							oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter3, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
							obj.Gr5tJnPwYx.Items.Add(mGyntfk4Pp);
							mGyntfk4Pp = null;
							goto IL_01e8;
							IL_01e8:
							if (hjMnupQVVDlRZAYQJC.D35lls5iF(X9ynZpo1j8, hjMnupQVVDlRZAYQJC.QV1TFwytOj))
							{
								mGyntfk4Pp = X9ynZpo1j8.Current;
								awaiter3 = QliBEUviwWqgtMcBndV.D35lls5iF(pvrKKy8Mk1kpdmIfp3A.D35lls5iF(2, pvrKKy8Mk1kpdmIfp3A.aVh8SPrFkE), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
								if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter3, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
								{
									num = (hjJnP9OBsE = 1);
									YL8nSxCxKl = awaiter3;
									Yernqq3dGP.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
									return;
								}
								goto IL_01bf;
							}
						}
						finally
						{
							if (num < 0 && X9ynZpo1j8 != null)
							{
								xLO56JniGyickVjO1Ot.D35lls5iF(X9ynZpo1j8, xLO56JniGyickVjO1Ot.ydbT2bsoH4);
							}
						}
						X9ynZpo1j8 = null;
						obj.Gr5tJnPwYx.CurrentPage = FISnGPtEbh.Data.CurrentPage;
						obj.Gr5tJnPwYx.PageCount = FISnGPtEbh.Data.PageCount;
						obj.Gr5tJnPwYx.TotalCount = FISnGPtEbh.Data.Total;
						goto IL_028e;
						end_IL_004e:;
					}
					catch (PROTVException ex)
					{
						yVgnauKjpy = ex;
						twGn04m7YE = 1;
					}
					int num2 = twGn04m7YE;
					if (num2 == 1)
					{
						if (TNckS5wtLfB2Lk9dYP8.D35lls5iF((PROTVException)yVgnauKjpy, TNckS5wtLfB2Lk9dYP8.oGkwV3iq3t) == ExceptionType.AuthorizationTokenInvalid)
						{
							awaiter = bAA7Sxw7vZsvusOmDea.D35lls5iF(AppContainer.Resolve<MainViewModel>(), bAA7Sxw7vZsvusOmDea.gytwc9U7r5).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = (hjJnP9OBsE = 2);
								RIJnfuS90e = awaiter;
								Yernqq3dGP.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_033e;
						}
						obj.Gr5tJnPwYx.TotalCount = 0;
					}
					goto IL_0372;
					IL_0379:
					if (ajNnVbMOnx)
					{
						ajNnVbMOnx = false;
						twGn04m7YE = 0;
						goto IL_004e;
					}
				}
				catch (Exception ex2)
				{
					hjJnP9OBsE = -2;
					N2XUglA3neBsnlZfRPQ.D35lls5iF(ref Yernqq3dGP, ex2, N2XUglA3neBsnlZfRPQ.l4pATRumoW);
					return;
				}
				hjJnP9OBsE = -2;
				T4XmPoA4VNJJP1afcgL.D35lls5iF(ref Yernqq3dGP, T4XmPoA4VNJJP1afcgL.TRyALZckCh);
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine P_0)
			{
				dHWo7jAEn6E4X7bsY4R.D35lls5iF(ref Yernqq3dGP, P_0, dHWo7jAEn6E4X7bsY4R.z3hAB6UZ9o);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine P_0)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(P_0);
			}
		}

		public SongsViewModel Gr5tJnPwYx;

		public SortOrder EEtthL8V9k;

		public _003C_003Ec__DisplayClass31_0()
		{
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
			base._002Ector();
		}

		[AsyncStateMachine(typeof(nUkMeRCx1Vxna9Tdr7))]
		internal void Mtgt1CBh2F()
		{
			nUkMeRCx1Vxna9Tdr7 stateMachine = default(nUkMeRCx1Vxna9Tdr7);
			stateMachine.Yernqq3dGP = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
			stateMachine.QpBnIAK5Ig = this;
			stateMachine.hjJnP9OBsE = -1;
			stateMachine.Yernqq3dGP.Start(ref stateMachine);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass34_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct op08mPYDGOjaTt6HfN : IAsyncStateMachine
		{
			public int R3JnKxtFTJ;

			public AsyncVoidMethodBuilder ENwnk8jKWF;

			public _003C_003Ec__DisplayClass34_0 njxn8ao7SL;

			private ResponseList<SongResponseDto> M4ynQMBmMp;

			private TaskAwaiter<ResponseList<SongResponseDto>> sKInnTpSJk;

			private IEnumerator<SongResponseDto> JsLnbP3FfN;

			private SongResponseDto TWmn7F5Ir6;

			private TaskAwaiter dKZn5Yvkta;

			private void MoveNext()
			{
				int num = R3JnKxtFTJ;
				_003C_003Ec__DisplayClass34_0 obj = njxn8ao7SL;
				try
				{
					if ((uint)num > 1u)
					{
						obj.tmltURSoPm.Items.Clear();
					}
					try
					{
						TaskAwaiter<ResponseList<SongResponseDto>> awaiter;
						if (num != 0)
						{
							if (num == 1)
							{
								goto IL_0118;
							}
							obj.tmltURSoPm.SearchQuery.Page = 1;
							obj.tmltURSoPm.SearchQuery.Sort = obj.Hr9tL9EJnQ;
							awaiter = minABoCzdK7QB6vVIpY.D35lls5iF(obj.tmltURSoPm.GB6drHVFOO, obj.tmltURSoPm.SearchQuery, minABoCzdK7QB6vVIpY.JfsmoVshEs).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = (R3JnKxtFTJ = 0);
								sKInnTpSJk = awaiter;
								ENwnk8jKWF.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = sKInnTpSJk;
							sKInnTpSJk = default(TaskAwaiter<ResponseList<SongResponseDto>>);
							num = (R3JnKxtFTJ = -1);
						}
						ResponseList<SongResponseDto> result = awaiter.GetResult();
						M4ynQMBmMp = result;
						if (M4ynQMBmMp != null && M4ynQMBmMp.Status)
						{
							JsLnbP3FfN = M4ynQMBmMp.Data.Result.GetEnumerator();
							goto IL_0118;
						}
						obj.tmltURSoPm.TotalCount = 0;
						goto IL_026d;
						IL_026d:
						M4ynQMBmMp = null;
						goto end_IL_002d;
						IL_0118:
						try
						{
							if (num != 1)
							{
								goto IL_01c7;
							}
							TaskAwaiter awaiter2 = dKZn5Yvkta;
							dKZn5Yvkta = default(TaskAwaiter);
							num = (R3JnKxtFTJ = -1);
							goto IL_019e;
							IL_019e:
							oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter2, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
							obj.tmltURSoPm.Items.Add(TWmn7F5Ir6);
							TWmn7F5Ir6 = null;
							goto IL_01c7;
							IL_01c7:
							if (hjMnupQVVDlRZAYQJC.D35lls5iF(JsLnbP3FfN, hjMnupQVVDlRZAYQJC.QV1TFwytOj))
							{
								TWmn7F5Ir6 = JsLnbP3FfN.Current;
								awaiter2 = QliBEUviwWqgtMcBndV.D35lls5iF(pvrKKy8Mk1kpdmIfp3A.D35lls5iF(2, pvrKKy8Mk1kpdmIfp3A.aVh8SPrFkE), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
								if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter2, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
								{
									num = (R3JnKxtFTJ = 1);
									dKZn5Yvkta = awaiter2;
									ENwnk8jKWF.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									return;
								}
								goto IL_019e;
							}
						}
						finally
						{
							if (num < 0 && JsLnbP3FfN != null)
							{
								xLO56JniGyickVjO1Ot.D35lls5iF(JsLnbP3FfN, xLO56JniGyickVjO1Ot.ydbT2bsoH4);
							}
						}
						JsLnbP3FfN = null;
						obj.tmltURSoPm.CurrentPage = M4ynQMBmMp.Data.CurrentPage;
						obj.tmltURSoPm.PageCount = M4ynQMBmMp.Data.PageCount;
						obj.tmltURSoPm.TotalCount = M4ynQMBmMp.Data.Total;
						goto IL_026d;
						end_IL_002d:;
					}
					catch
					{
						obj.tmltURSoPm.TotalCount = 0;
					}
				}
				catch (Exception ex)
				{
					R3JnKxtFTJ = -2;
					N2XUglA3neBsnlZfRPQ.D35lls5iF(ref ENwnk8jKWF, ex, N2XUglA3neBsnlZfRPQ.l4pATRumoW);
					return;
				}
				R3JnKxtFTJ = -2;
				T4XmPoA4VNJJP1afcgL.D35lls5iF(ref ENwnk8jKWF, T4XmPoA4VNJJP1afcgL.TRyALZckCh);
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine P_0)
			{
				dHWo7jAEn6E4X7bsY4R.D35lls5iF(ref ENwnk8jKWF, P_0, dHWo7jAEn6E4X7bsY4R.z3hAB6UZ9o);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine P_0)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(P_0);
			}
		}

		public SongsViewModel tmltURSoPm;

		public SongSort Hr9tL9EJnQ;

		public _003C_003Ec__DisplayClass34_0()
		{
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
			base._002Ector();
		}

		[AsyncStateMachine(typeof(op08mPYDGOjaTt6HfN))]
		internal void iJZtlqdm8P()
		{
			op08mPYDGOjaTt6HfN stateMachine = default(op08mPYDGOjaTt6HfN);
			stateMachine.ENwnk8jKWF = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
			stateMachine.njxn8ao7SL = this;
			stateMachine.R3JnKxtFTJ = -1;
			stateMachine.ENwnk8jKWF.Start(ref stateMachine);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnOpenArtitViewCommandExcute_003Ed__77 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public SongResponseDto arg;

		public SongsViewModel _003C_003E4__this;

		private HomeViewModel _003ChomeViewModel_003E5__2;

		private Page _003Cpage_003E5__3;

		private TaskAwaiter<Response<PersonResponseDto>> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			SongsViewModel songsViewModel = _003C_003E4__this;
			try
			{
				_ = 1;
				try
				{
					TaskAwaiter<Response<PersonResponseDto>> awaiter;
					if (num == 0)
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter<Response<PersonResponseDto>>);
						num = (_003C_003E1__state = -1);
						goto IL_00d7;
					}
					TaskAwaiter awaiter2;
					if (num == 1)
					{
						awaiter2 = _003C_003Eu__2;
						_003C_003Eu__2 = default(TaskAwaiter);
						num = (_003C_003E1__state = -1);
						goto IL_0190;
					}
					SongResponseDto songResponseDto = arg;
					if (songResponseDto != null && WJbFtI6AObf2rNffLCy.D35lls5iF(songResponseDto, WJbFtI6AObf2rNffLCy.GuJCFyBU1U) > 0)
					{
						_003ChomeViewModel_003E5__2 = Sp7dKWL9ZfBld4JOkGo.D35lls5iF(AppContainer.Resolve<MainViewModel>(), Sp7dKWL9ZfBld4JOkGo.QpWwMTMAhO) as HomeViewModel;
						awaiter = YTt9tICqHERcu3erllh.D35lls5iF(songsViewModel.K5LdHi2kQ0, WJbFtI6AObf2rNffLCy.D35lls5iF(arg, WJbFtI6AObf2rNffLCy.GlFCyeQqCh), YTt9tICqHERcu3erllh.sCjCJXY9fD).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (_003C_003E1__state = 0);
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_00d7;
					}
					goto end_IL_001a;
					IL_00d7:
					ArtistItemViewModel viewModel = new ArtistItemViewModel(awaiter.GetResult().Data);
					Page page = new Page();
					KBhlAv9D2TgBJ1kkc0B.D35lls5iF(page, IyGDDwHBiPv8vfOFJDF.D35lls5iF(ApplicationPage.ArtistDetailsView, viewModel, IyGDDwHBiPv8vfOFJDF.hivH0XYhaE), KBhlAv9D2TgBJ1kkc0B.fWUHrWO7Sa);
					qni3xrDkAJ3vF35eMav.D35lls5iF(page, QQLie3eYkZwbFFm9Jjw.D35lls5iF(arg, QQLie3eYkZwbFFm9Jjw.iBTCbal3Fb), qni3xrDkAJ3vF35eMav.Ra7HRFTvnD);
					_003Cpage_003E5__3 = page;
					awaiter2 = QliBEUviwWqgtMcBndV.D35lls5iF(pvrKKy8Mk1kpdmIfp3A.D35lls5iF(5, pvrKKy8Mk1kpdmIfp3A.aVh8SPrFkE), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
					if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter2, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
					{
						num = (_003C_003E1__state = 1);
						_003C_003Eu__2 = awaiter2;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
						return;
					}
					goto IL_0190;
					IL_0190:
					oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter2, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
					GmMLaTD7kV8rq88ZFvR.D35lls5iF(Xlypb0Hnr2C3ydrYEdG.D35lls5iF(_003ChomeViewModel_003E5__2, Xlypb0Hnr2C3ydrYEdG.U3Z1IKMGuZ), _003Cpage_003E5__3, GmMLaTD7kV8rq88ZFvR.iMJHkmaaRY);
					_003ChomeViewModel_003E5__2 = null;
					_003Cpage_003E5__3 = null;
					end_IL_001a:;
				}
				catch
				{
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
	private struct _003CLoadSongs_003Ed__78 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public SongsViewModel _003C_003E4__this;

		private bool _003CtryAgain_003E5__2;

		private object _003C_003E7__wrap2;

		private int _003C_003E7__wrap3;

		private TaskAwaiter<ResponseList<PlaylistResponseDto<SongResponseDto>>> _003C_003Eu__1;

		private TaskAwaiter<bool> _003C_003Eu__2;

		private ResponseList<SongResponseDto> _003Cresult_003E5__5;

		private TaskAwaiter<ResponseList<SongResponseDto>> _003C_003Eu__3;

		private IEnumerator<SongResponseDto> _003C_003E7__wrap5;

		private SongResponseDto _003Citem_003E5__7;

		private TaskAwaiter _003C_003Eu__4;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			SongsViewModel songsViewModel = _003C_003E4__this;
			try
			{
				TaskAwaiter<bool> awaiter;
				switch (num)
				{
				default:
					VE9MZyCWf6UTEJGXB95.D35lls5iF(songsViewModel, VE9MZyCWf6UTEJGXB95.vsmC5Dku7R).Clear();
					songsViewModel.Items.Clear();
					songsViewModel.SearchQuery.Page = 1;
					songsViewModel.SearchQuery.Count = 25;
					songsViewModel.SearchQuery.Sort = SongSort.Hot;
					songsViewModel.SearchQuery.Order = SortOrder.Desc;
					_003CtryAgain_003E5__2 = true;
					goto IL_02ca;
				case 0:
				{
					try
					{
						TaskAwaiter<ResponseList<PlaylistResponseDto<SongResponseDto>>> awaiter4;
						if (num != 0)
						{
							IPlaylistService n5idOdIihM = songsViewModel.N5idOdIihM;
							ApiQuery<PlaylistSearch, GeneralSort> apiQuery = new ApiQuery<PlaylistSearch, GeneralSort>();
							PlaylistSearch playlistSearch = new PlaylistSearch();
							GqB3rILSV2vbfc09aIP.D35lls5iF(playlistSearch, PlaylistType.Song, GqB3rILSV2vbfc09aIP.OU4LK1g7N1);
							apiQuery.Search = playlistSearch;
							apiQuery.Count = -1;
							awaiter4 = n5idOdIihM.GetPlaylistsAsync<SongResponseDto>(apiQuery).GetAwaiter();
							if (!awaiter4.IsCompleted)
							{
								num = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter4;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
								return;
							}
						}
						else
						{
							awaiter4 = _003C_003Eu__1;
							_003C_003Eu__1 = default(TaskAwaiter<ResponseList<PlaylistResponseDto<SongResponseDto>>>);
							num = (_003C_003E1__state = -1);
						}
						ResponseList<PlaylistResponseDto<SongResponseDto>> result2 = awaiter4.GetResult();
						if (result2 != null && result2.Status)
						{
							IEnumerator<PlaylistResponseDto<SongResponseDto>> enumerator = result2.Data.Result.GetEnumerator();
							try
							{
								while (hjMnupQVVDlRZAYQJC.D35lls5iF(enumerator, hjMnupQVVDlRZAYQJC.QV1TFwytOj))
								{
									PlaylistResponseDto<SongResponseDto> current = enumerator.Current;
									PlayListItemModel<SongResponseDto> playListItemModel = new PlayListItemModel<SongResponseDto>
									{
										PlayList = current,
										IsChecked = false
									};
									if (playListItemModel.Poster == null)
									{
										playListItemModel.Poster = new BitmapImage(new Uri(iFZ5je3XFYKwkvcE5D.D35lls5iF(16218, iFZ5je3XFYKwkvcE5D.N06TeK0ao)));
									}
									else
									{
										playListItemModel.Poster = new BitmapImage(new Uri(current.Poster));
									}
									VE9MZyCWf6UTEJGXB95.D35lls5iF(songsViewModel, VE9MZyCWf6UTEJGXB95.vsmC5Dku7R).Add(playListItemModel);
								}
							}
							finally
							{
								if (num < 0 && enumerator != null)
								{
									xLO56JniGyickVjO1Ot.D35lls5iF(enumerator, xLO56JniGyickVjO1Ot.ydbT2bsoH4);
								}
							}
						}
					}
					catch (PROTVException ex2)
					{
						_003C_003E7__wrap2 = ex2;
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
						goto IL_02a5;
					}
					goto IL_02c3;
				}
				case 1:
					awaiter = _003C_003Eu__2;
					_003C_003Eu__2 = default(TaskAwaiter<bool>);
					num = (_003C_003E1__state = -1);
					goto IL_02a5;
				case 2:
				case 3:
				{
					try
					{
						TaskAwaiter<ResponseList<SongResponseDto>> awaiter2;
						if (num != 2)
						{
							if (num == 3)
							{
								goto IL_03b0;
							}
							awaiter2 = minABoCzdK7QB6vVIpY.D35lls5iF(songsViewModel.GB6drHVFOO, songsViewModel.SearchQuery, minABoCzdK7QB6vVIpY.JfsmoVshEs).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num = (_003C_003E1__state = 2);
								_003C_003Eu__3 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
						}
						else
						{
							awaiter2 = _003C_003Eu__3;
							_003C_003Eu__3 = default(TaskAwaiter<ResponseList<SongResponseDto>>);
							num = (_003C_003E1__state = -1);
						}
						ResponseList<SongResponseDto> result = awaiter2.GetResult();
						_003Cresult_003E5__5 = result;
						if (_003Cresult_003E5__5 != null && _003Cresult_003E5__5.Status)
						{
							_003C_003E7__wrap5 = _003Cresult_003E5__5.Data.Result.GetEnumerator();
							goto IL_03b0;
						}
						songsViewModel.TotalCount = 0;
						goto IL_04ec;
						IL_04ec:
						_003Cresult_003E5__5 = null;
						goto end_IL_02f0;
						IL_03b0:
						try
						{
							if (num != 3)
							{
								goto IL_045a;
							}
							TaskAwaiter awaiter3 = _003C_003Eu__4;
							_003C_003Eu__4 = default(TaskAwaiter);
							num = (_003C_003E1__state = -1);
							goto IL_0436;
							IL_0436:
							oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter3, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
							songsViewModel.Items.Add(_003Citem_003E5__7);
							_003Citem_003E5__7 = null;
							goto IL_045a;
							IL_045a:
							if (hjMnupQVVDlRZAYQJC.D35lls5iF(_003C_003E7__wrap5, hjMnupQVVDlRZAYQJC.QV1TFwytOj))
							{
								_003Citem_003E5__7 = _003C_003E7__wrap5.Current;
								awaiter3 = QliBEUviwWqgtMcBndV.D35lls5iF(pvrKKy8Mk1kpdmIfp3A.D35lls5iF(2, pvrKKy8Mk1kpdmIfp3A.aVh8SPrFkE), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
								if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter3, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
								{
									num = (_003C_003E1__state = 3);
									_003C_003Eu__4 = awaiter3;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
									return;
								}
								goto IL_0436;
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
						songsViewModel.CurrentPage = _003Cresult_003E5__5.Data.CurrentPage;
						songsViewModel.PageCount = _003Cresult_003E5__5.Data.PageCount;
						songsViewModel.TotalCount = _003Cresult_003E5__5.Data.Total;
						goto IL_04ec;
						end_IL_02f0:;
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
								num = (_003C_003E1__state = 4);
								_003C_003Eu__2 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_059c;
						}
						songsViewModel.TotalCount = 0;
					}
					goto IL_05c6;
				}
				case 4:
					{
						awaiter = _003C_003Eu__2;
						_003C_003Eu__2 = default(TaskAwaiter<bool>);
						num = (_003C_003E1__state = -1);
						goto IL_059c;
					}
					IL_02ca:
					if (_003CtryAgain_003E5__2)
					{
						_003CtryAgain_003E5__2 = false;
						_003C_003E7__wrap3 = 0;
						goto case 0;
					}
					_003CtryAgain_003E5__2 = true;
					goto IL_05cd;
					IL_02a5:
					if (awaiter.GetResult())
					{
						_003CtryAgain_003E5__2 = true;
						songsViewModel.GB6drHVFOO = AppContainer.Resolve<IMusicService>();
					}
					goto IL_02c3;
					IL_05cd:
					if (_003CtryAgain_003E5__2)
					{
						_003CtryAgain_003E5__2 = false;
						_003C_003E7__wrap3 = 0;
						goto case 2;
					}
					break;
					IL_02c3:
					_003C_003E7__wrap2 = null;
					goto IL_02ca;
					IL_05c6:
					_003C_003E7__wrap2 = null;
					goto IL_05cd;
					IL_059c:
					if (awaiter.GetResult())
					{
						_003CtryAgain_003E5__2 = true;
						songsViewModel.GB6drHVFOO = AppContainer.Resolve<IMusicService>();
					}
					goto IL_05c6;
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
	private struct _003COnFetchMoreDataCommand_003Ed__81 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public SongsViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			SongsViewModel songsViewModel = _003C_003E4__this;
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
				if (songsViewModel.CurrentPage < songsViewModel.TotalCount && !hjMnupQVVDlRZAYQJC.D35lls5iF(songsViewModel, hjMnupQVVDlRZAYQJC.jJYTSHn9tB))
				{
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(songsViewModel.AddMoreItems(), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
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
	private struct _003COnCreatePlayListCommandExcuteException_003Ed__82 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public Exception ex;

		public SongsViewModel _003C_003E4__this;

		private TaskAwaiter<bool> _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			SongsViewModel songsViewModel = _003C_003E4__this;
			try
			{
				TaskAwaiter<bool> awaiter;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<bool>);
					num = (_003C_003E1__state = -1);
					goto IL_009e;
				}
				if (this.ex is PROTVException ex)
				{
					if (TNckS5wtLfB2Lk9dYP8.D35lls5iF(ex, TNckS5wtLfB2Lk9dYP8.oGkwV3iq3t) == ExceptionType.AuthorizationTokenInvalid)
					{
						awaiter = bAA7Sxw7vZsvusOmDea.D35lls5iF(AppContainer.Resolve<MainViewModel>(), bAA7Sxw7vZsvusOmDea.gytwc9U7r5).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (_003C_003E1__state = 0);
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_009e;
					}
					gsYNF433WqUIGma3CNX.D35lls5iF(QQLie3eYkZwbFFm9Jjw.D35lls5iF(ex, QQLie3eYkZwbFFm9Jjw.vZdwjWiy78), "", gsYNF433WqUIGma3CNX.gB4ml1oyVl);
				}
				goto end_IL_0015;
				IL_009e:
				if (awaiter.GetResult())
				{
					songsViewModel.GB6drHVFOO = AppContainer.Resolve<IMusicService>();
					songsViewModel.N5idOdIihM = AppContainer.Resolve<IPlaylistService>();
				}
				end_IL_0015:;
			}
			catch (Exception ex2)
			{
				_003C_003E1__state = -2;
				N2XUglA3neBsnlZfRPQ.D35lls5iF(ref _003C_003Et__builder, ex2, N2XUglA3neBsnlZfRPQ.l4pATRumoW);
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
	private struct _003COnCreatePlayListCommandExcute_003Ed__83 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public SongsViewModel _003C_003E4__this;

		private TaskAwaiter<Response<PlaylistResponseDto<SongResponseDto>>> _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			SongsViewModel songsViewModel = _003C_003E4__this;
			try
			{
				TaskAwaiter<Response<PlaylistResponseDto<SongResponseDto>>> awaiter;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<Response<PlaylistResponseDto<SongResponseDto>>>);
					num = (_003C_003E1__state = -1);
					goto IL_009c;
				}
				if (!M6ZErPEr2LZyWYpa5O.D35lls5iF(pnvE8rm9NRTK7Tblimu.D35lls5iF(songsViewModel, pnvE8rm9NRTK7Tblimu.JiXmDxRY5v), M6ZErPEr2LZyWYpa5O.rg89aHbgYh))
				{
					awaiter = songsViewModel.N5idOdIihM.CreatePlaylisAsyncAsync<SongResponseDto>(pnvE8rm9NRTK7Tblimu.D35lls5iF(songsViewModel, pnvE8rm9NRTK7Tblimu.JiXmDxRY5v)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_009c;
				}
				goto end_IL_0015;
				IL_009c:
				Response<PlaylistResponseDto<SongResponseDto>> result = awaiter.GetResult();
				if (result != null && result.Status)
				{
					VE9MZyCWf6UTEJGXB95.D35lls5iF(songsViewModel, VE9MZyCWf6UTEJGXB95.vsmC5Dku7R).Add(new PlayListItemModel<SongResponseDto>
					{
						PlayList = result.Data,
						HhGPenc8f1 = false,
						Poster = new BitmapImage(new Uri(iFZ5je3XFYKwkvcE5D.D35lls5iF(16218, iFZ5je3XFYKwkvcE5D.N06TeK0ao)))
					});
					qni3xrDkAJ3vF35eMav.D35lls5iF(songsViewModel, "", qni3xrDkAJ3vF35eMav.WukLtApWjl);
					qni3xrDkAJ3vF35eMav.D35lls5iF(songsViewModel, iFZ5je3XFYKwkvcE5D.D35lls5iF(10480, iFZ5je3XFYKwkvcE5D.N06TeK0ao), qni3xrDkAJ3vF35eMav.QN6DuDtCWO);
				}
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
	private struct _003COnOpenPlayListCommandExcute_003Ed__85 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public SongsViewModel _003C_003E4__this;

		public SongResponseDto arg;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			SongsViewModel songsViewModel = _003C_003E4__this;
			try
			{
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(pvrKKy8Mk1kpdmIfp3A.D35lls5iF(10, pvrKKy8Mk1kpdmIfp3A.aVh8SPrFkE), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
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
					IEnumerator<PlayListItemModel<SongResponseDto>> enumerator = VE9MZyCWf6UTEJGXB95.D35lls5iF(songsViewModel, VE9MZyCWf6UTEJGXB95.vsmC5Dku7R).GetEnumerator();
					try
					{
						while (hjMnupQVVDlRZAYQJC.D35lls5iF(enumerator, hjMnupQVVDlRZAYQJC.QV1TFwytOj))
						{
							PlayListItemModel<SongResponseDto> current = enumerator.Current;
							current.MediaId = m9MGZR7k2RmVqYXYS5.D35lls5iF(arg, m9MGZR7k2RmVqYXYS5.j871CQO7pP);
							current.Media = arg;
							current.HhGPenc8f1 = S2TLVumHJ5aeKRPsMnq.D35lls5iF(arg, S2TLVumHJ5aeKRPsMnq.lkSm1NMjdP).Contains(current.PlayList.Id);
							hH6DVMBvgw3ANNRyBk6.D35lls5iF(current, iFZ5je3XFYKwkvcE5D.D35lls5iF(10648, iFZ5je3XFYKwkvcE5D.N06TeK0ao), hH6DVMBvgw3ANNRyBk6.hT7m8gyOr4);
						}
					}
					finally
					{
						if (num < 0 && enumerator != null)
						{
							xLO56JniGyickVjO1Ot.D35lls5iF(enumerator, xLO56JniGyickVjO1Ot.ydbT2bsoH4);
						}
					}
					jPB9Q5LdIM9wsuWV1q7.D35lls5iF(songsViewModel, true, jPB9Q5LdIM9wsuWV1q7.jt6LUQJ4wl);
					qni3xrDkAJ3vF35eMav.D35lls5iF(songsViewModel, "", qni3xrDkAJ3vF35eMav.WukLtApWjl);
				}
				catch (Exception)
				{
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
	private struct _003COnPlaySongCommandExcute_003Ed__86 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public SongResponseDto arg;

		public SongsViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			SongsViewModel songsViewModel = _003C_003E4__this;
			try
			{
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(mBZRZ5wNhC66q1qy0dy.D35lls5iF(MI3oOiHCZASyM6ERRUP.D35lls5iF(AppContainer.Resolve<HomeViewModel>(), MI3oOiHCZASyM6ERRUP.h0JHmOSEFB), arg, songsViewModel.Items.ToList(), mBZRZ5wNhC66q1qy0dy.X1gwOhFcpv), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
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
				catch (Exception)
				{
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
	private struct _003COnAddToFavoriteCommandExcute_003Ed__87 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public SongsViewModel _003C_003E4__this;

		public SongResponseDto dto;

		private TaskAwaiter<bool> _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			SongsViewModel songsViewModel = _003C_003E4__this;
			try
			{
				try
				{
					TaskAwaiter<bool> awaiter;
					if (num != 0)
					{
						awaiter = VbmtIFmnFwg9sqb4Jje.D35lls5iF(songsViewModel.GB6drHVFOO, m9MGZR7k2RmVqYXYS5.D35lls5iF(dto, m9MGZR7k2RmVqYXYS5.j871CQO7pP), VbmtIFmnFwg9sqb4Jje.rrhm3meLB5).GetAwaiter();
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
						jPB9Q5LdIM9wsuWV1q7.D35lls5iF(dto, !LsA6RHpKkbdnOn3fX60.D35lls5iF(dto, LsA6RHpKkbdnOn3fX60.wngmTuQiAX), jPB9Q5LdIM9wsuWV1q7.k7sm4salMA);
						m5sZxWmLHUhVHrJe8sC.D35lls5iF(dto, iFZ5je3XFYKwkvcE5D.D35lls5iF(8354, iFZ5je3XFYKwkvcE5D.N06TeK0ao), m5sZxWmLHUhVHrJe8sC.XfqmEkDdBV);
					}
				}
				catch (Exception)
				{
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
	private struct _003CAddMoreItems_003Ed__89 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public SongsViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			SongsViewModel CS_0024_003C_003E8__locals5 = _003C_003E4__this;
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
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(W7S2sip6SDieZFVsNbd.D35lls5iF(CS_0024_003C_003E8__locals5, Expression.Lambda<Func<bool>>(OWBKr5pvc5MWsK1OMtR.D35lls5iF(o4bYL4peNeC2wWb8yjx.D35lls5iF(CS_0024_003C_003E8__locals5, sjYxHO8OWlc6X80hFj7.D35lls5iF(typeof(SongsViewModel).TypeHandle, sjYxHO8OWlc6X80hFj7.uWZ8ugU7r5), o4bYL4peNeC2wWb8yjx.oVdpGKjy2x), (MethodInfo)f5q427pRQZnrEKPy4Ws.D35lls5iF((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, f5q427pRQZnrEKPy4Ws.Bo9pk3m4k7), OWBKr5pvc5MWsK1OMtR.fZIpAAdi1v), Array.Empty<ParameterExpression>()), [AsyncStateMachine(typeof(_003C_003CAddMoreItems_003Eb__89_1_003Ed))] () =>
					{
						_003C_003CAddMoreItems_003Eb__89_1_003Ed stateMachine = default(_003C_003CAddMoreItems_003Eb__89_1_003Ed);
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
	private struct _003CGoToPage_003Ed__90 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public SongsViewModel _003C_003E4__this;

		private void MoveNext()
		{
			SongsViewModel songsViewModel = _003C_003E4__this;
			try
			{
				PopupAdorner naEdlUS2fa = songsViewModel.NaEdlUS2fa;
				if (naEdlUS2fa != null)
				{
					EcRAvP4y5i6535dlslT.D35lls5iF(naEdlUS2fa, EcRAvP4y5i6535dlslT.zPRLpVOtVj);
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
	private struct _003CLoadAsync_003Ed__92 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public SongsViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			SongsViewModel CS_0024_003C_003E8__locals3 = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(W7S2sip6SDieZFVsNbd.D35lls5iF(CS_0024_003C_003E8__locals3, Expression.Lambda<Func<bool>>(OWBKr5pvc5MWsK1OMtR.D35lls5iF(o4bYL4peNeC2wWb8yjx.D35lls5iF(CS_0024_003C_003E8__locals3, sjYxHO8OWlc6X80hFj7.D35lls5iF(typeof(SongsViewModel).TypeHandle, sjYxHO8OWlc6X80hFj7.uWZ8ugU7r5), o4bYL4peNeC2wWb8yjx.oVdpGKjy2x), (MethodInfo)f5q427pRQZnrEKPy4Ws.D35lls5iF((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, f5q427pRQZnrEKPy4Ws.Bo9pk3m4k7), OWBKr5pvc5MWsK1OMtR.fZIpAAdi1v), Array.Empty<ParameterExpression>()), [AsyncStateMachine(typeof(_003C_003CLoadAsync_003Eb__92_1_003Ed))] () =>
					{
						_003C_003CLoadAsync_003Eb__92_1_003Ed stateMachine = default(_003C_003CLoadAsync_003Eb__92_1_003Ed);
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
	private struct _003C_003CAddMoreItems_003Eb__89_1_003Ed : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public SongsViewModel _003C_003E4__this;

		private ResponseList<SongResponseDto> _003Cresult_003E5__2;

		private TaskAwaiter<ResponseList<SongResponseDto>> _003C_003Eu__1;

		private IEnumerator<SongResponseDto> _003C_003E7__wrap2;

		private SongResponseDto _003Citem_003E5__4;

		private TaskAwaiter _003C_003Eu__2;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			SongsViewModel songsViewModel = _003C_003E4__this;
			try
			{
				if ((uint)num > 1u)
				{
					songsViewModel.SearchQuery.Page++;
				}
				try
				{
					TaskAwaiter<ResponseList<SongResponseDto>> awaiter;
					if (num != 0)
					{
						if (num == 1)
						{
							goto IL_00ef;
						}
						awaiter = minABoCzdK7QB6vVIpY.D35lls5iF(songsViewModel.GB6drHVFOO, songsViewModel.SearchQuery, minABoCzdK7QB6vVIpY.JfsmoVshEs).GetAwaiter();
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
						_003C_003Eu__1 = default(TaskAwaiter<ResponseList<SongResponseDto>>);
						num = (_003C_003E1__state = -1);
					}
					ResponseList<SongResponseDto> result = awaiter.GetResult();
					_003Cresult_003E5__2 = result;
					if (_003Cresult_003E5__2 != null && _003Cresult_003E5__2.Status)
					{
						_003C_003E7__wrap2 = _003Cresult_003E5__2.Data.Result.GetEnumerator();
						goto IL_00ef;
					}
					songsViewModel.SearchQuery.Page--;
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
						songsViewModel.Items.Add(_003Citem_003E5__4);
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
					songsViewModel.CurrentPage = _003Cresult_003E5__2.Data.CurrentPage;
					songsViewModel.PageCount = _003Cresult_003E5__2.Data.PageCount;
					songsViewModel.TotalCount = _003Cresult_003E5__2.Data.Total;
					goto IL_0239;
					end_IL_0032:;
				}
				catch
				{
					songsViewModel.SearchQuery.Page--;
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
	private struct _003C_003CLoadAsync_003Eb__92_1_003Ed : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public SongsViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			SongsViewModel songsViewModel = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(VrVteFCs0OCGBTVr1mZ.D35lls5iF(new Task[1] { OYihPsCZ1OyLa5m4TD0.D35lls5iF(songsViewModel, OYihPsCZ1OyLa5m4TD0.s5WmB9ykbT) }, VrVteFCs0OCGBTVr1mZ.qNlChUR2Cs), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
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

	private bool fpqdEFIoZ5;

	private bool uEud947N4j;

	private bool nBSdeQU4sm;

	private IPlaylistService N5idOdIihM;

	private IMusicService GB6drHVFOO;

	private IPeopleService K5LdHi2kQ0;

	private LanguageResponseDto g52doKFM7U;

	private SortOrder YbsdgpMSxo;

	private SongSort kdVd1EYHAy;

	private ObservableCollection<PlayListItemModel<SongResponseDto>> kLUdJBXZ1q;

	private string PMBdh4TZpl;

	private PopupAdorner NaEdlUS2fa;

	[CompilerGenerated]
	private List<LanguageResponseDto> AD9dUBoGyB;

	[CompilerGenerated]
	private List<SongSort> AiedL2t3nY;

	[CompilerGenerated]
	private ICommand iDsd2kI2O8;

	[CompilerGenerated]
	private ICommand k74dzTm7Du;

	[CompilerGenerated]
	private ICommand zRfPcQQKtf;

	[CompilerGenerated]
	private ICommand HrGPjrQlMq;

	[CompilerGenerated]
	private ICommand VVlPv8cYdN;

	[CompilerGenerated]
	private ICommand g0DPWJE62K;

	[CompilerGenerated]
	private ICommand jYfP4OVQPh;

	[CompilerGenerated]
	private ListBox MJDPBkXNU3;

	public bool IsLoading
	{
		get
		{
			return fpqdEFIoZ5;
		}
		set
		{
			SetProperty(ref fpqdEFIoZ5, value, iFZ5je3XFYKwkvcE5D.D35lls5iF(10458, iFZ5je3XFYKwkvcE5D.N06TeK0ao));
		}
	}

	public ObservableCollection<PlayListItemModel<SongResponseDto>> PlayLists
	{
		get
		{
			return kLUdJBXZ1q;
		}
		set
		{
			SetProperty(ref kLUdJBXZ1q, value, iFZ5je3XFYKwkvcE5D.D35lls5iF(10480, iFZ5je3XFYKwkvcE5D.N06TeK0ao));
		}
	}

	public List<LanguageResponseDto> Languages
	{
		[CompilerGenerated]
		get
		{
			return AD9dUBoGyB;
		}
		[CompilerGenerated]
		set
		{
			AD9dUBoGyB = value;
		}
	}

	public List<SongSort> SortItems
	{
		[CompilerGenerated]
		get
		{
			return AiedL2t3nY;
		}
		[CompilerGenerated]
		set
		{
			AiedL2t3nY = value;
		}
	}

	public LanguageResponseDto SelectedLanguage
	{
		get
		{
			return g52doKFM7U;
		}
		set
		{
			_003C_003Ec__DisplayClass28_0 CS_0024_003C_003E8__locals4 = new _003C_003Ec__DisplayClass28_0();
			CS_0024_003C_003E8__locals4.SZ4toDjgxF = this;
			CS_0024_003C_003E8__locals4.eTCtgedrYM = value;
			SetProperty(ref g52doKFM7U, CS_0024_003C_003E8__locals4.eTCtgedrYM, iFZ5je3XFYKwkvcE5D.D35lls5iF(10186, iFZ5je3XFYKwkvcE5D.N06TeK0ao), null, [AsyncStateMachine(typeof(_003C_003Ec__DisplayClass28_0.Pc3uEkMTLnRTjoPG9I))] () =>
			{
				_003C_003Ec__DisplayClass28_0.Pc3uEkMTLnRTjoPG9I stateMachine = default(_003C_003Ec__DisplayClass28_0.Pc3uEkMTLnRTjoPG9I);
				stateMachine.f30QLjIFU3 = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
				stateMachine.JCYQ2Fmesw = CS_0024_003C_003E8__locals4;
				stateMachine.SaeQUPEPZ5 = -1;
				stateMachine.f30QLjIFU3.Start(ref stateMachine);
			});
		}
	}

	public SortOrder SelectedOrder
	{
		get
		{
			return YbsdgpMSxo;
		}
		set
		{
			_003C_003Ec__DisplayClass31_0 CS_0024_003C_003E8__locals4 = new _003C_003Ec__DisplayClass31_0();
			CS_0024_003C_003E8__locals4.Gr5tJnPwYx = this;
			CS_0024_003C_003E8__locals4.EEtthL8V9k = value;
			SetProperty(ref YbsdgpMSxo, CS_0024_003C_003E8__locals4.EEtthL8V9k, iFZ5je3XFYKwkvcE5D.D35lls5iF(8208, iFZ5je3XFYKwkvcE5D.N06TeK0ao), null, [AsyncStateMachine(typeof(_003C_003Ec__DisplayClass31_0.nUkMeRCx1Vxna9Tdr7))] () =>
			{
				_003C_003Ec__DisplayClass31_0.nUkMeRCx1Vxna9Tdr7 stateMachine = default(_003C_003Ec__DisplayClass31_0.nUkMeRCx1Vxna9Tdr7);
				stateMachine.Yernqq3dGP = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
				stateMachine.QpBnIAK5Ig = CS_0024_003C_003E8__locals4;
				stateMachine.hjJnP9OBsE = -1;
				stateMachine.Yernqq3dGP.Start(ref stateMachine);
			});
		}
	}

	public SongSort SelectedSort
	{
		get
		{
			return kdVd1EYHAy;
		}
		set
		{
			_003C_003Ec__DisplayClass34_0 CS_0024_003C_003E8__locals4 = new _003C_003Ec__DisplayClass34_0();
			CS_0024_003C_003E8__locals4.tmltURSoPm = this;
			CS_0024_003C_003E8__locals4.Hr9tL9EJnQ = value;
			SetProperty(ref kdVd1EYHAy, CS_0024_003C_003E8__locals4.Hr9tL9EJnQ, iFZ5je3XFYKwkvcE5D.D35lls5iF(10222, iFZ5je3XFYKwkvcE5D.N06TeK0ao), null, [AsyncStateMachine(typeof(_003C_003Ec__DisplayClass34_0.op08mPYDGOjaTt6HfN))] () =>
			{
				_003C_003Ec__DisplayClass34_0.op08mPYDGOjaTt6HfN stateMachine = default(_003C_003Ec__DisplayClass34_0.op08mPYDGOjaTt6HfN);
				stateMachine.ENwnk8jKWF = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
				stateMachine.njxn8ao7SL = CS_0024_003C_003E8__locals4;
				stateMachine.R3JnKxtFTJ = -1;
				stateMachine.ENwnk8jKWF.Start(ref stateMachine);
			});
		}
	}

	public ICommand AddToFavorite
	{
		[CompilerGenerated]
		get
		{
			return iDsd2kI2O8;
		}
		[CompilerGenerated]
		set
		{
			iDsd2kI2O8 = value;
		}
	}

	public ICommand PlaySongCommand
	{
		[CompilerGenerated]
		get
		{
			return k74dzTm7Du;
		}
		[CompilerGenerated]
		set
		{
			k74dzTm7Du = value;
		}
	}

	public ICommand OpenPlayListCommand
	{
		[CompilerGenerated]
		get
		{
			return zRfPcQQKtf;
		}
		[CompilerGenerated]
		set
		{
			zRfPcQQKtf = value;
		}
	}

	public ICommand ClosePlayListCommand
	{
		[CompilerGenerated]
		get
		{
			return HrGPjrQlMq;
		}
		[CompilerGenerated]
		private set
		{
			HrGPjrQlMq = value;
		}
	}

	public ICommand CreatePlayListCommand
	{
		[CompilerGenerated]
		get
		{
			return VVlPv8cYdN;
		}
		[CompilerGenerated]
		private set
		{
			VVlPv8cYdN = value;
		}
	}

	public ICommand OpenMusicMoreInfoCommand
	{
		[CompilerGenerated]
		get
		{
			return g0DPWJE62K;
		}
		[CompilerGenerated]
		private set
		{
			g0DPWJE62K = value;
		}
	}

	public ICommand OpenArtitViewCommand
	{
		[CompilerGenerated]
		get
		{
			return jYfP4OVQPh;
		}
		[CompilerGenerated]
		private set
		{
			jYfP4OVQPh = value;
		}
	}

	public bool PlayListVisiblity
	{
		get
		{
			return uEud947N4j;
		}
		set
		{
			SetProperty(ref uEud947N4j, value, iFZ5je3XFYKwkvcE5D.D35lls5iF(10502, iFZ5je3XFYKwkvcE5D.N06TeK0ao));
		}
	}

	public bool SongInfoVisbility
	{
		get
		{
			return nBSdeQU4sm;
		}
		set
		{
			SetProperty(ref nBSdeQU4sm, value, iFZ5je3XFYKwkvcE5D.D35lls5iF(10540, iFZ5je3XFYKwkvcE5D.N06TeK0ao));
		}
	}

	public string NewPlaylistName
	{
		get
		{
			return PMBdh4TZpl;
		}
		set
		{
			SetProperty(ref PMBdh4TZpl, value, iFZ5je3XFYKwkvcE5D.D35lls5iF(10578, iFZ5je3XFYKwkvcE5D.N06TeK0ao));
		}
	}

	public ListBox SongsListView
	{
		[CompilerGenerated]
		get
		{
			return MJDPBkXNU3;
		}
		[CompilerGenerated]
		internal set
		{
			MJDPBkXNU3 = value;
		}
	}

	public SongsViewModel()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		YbsdgpMSxo = SortOrder.Desc;
		kdVd1EYHAy = SongSort.Hot;
		base._002Ector();
		QHWghGLE86eZIeyQchT.D35lls5iF(this, new ObservableCollection<PlayListItemModel<SongResponseDto>>(), QHWghGLE86eZIeyQchT.gdVLBGxAxE);
		base.TotalCount = -1;
		GB6drHVFOO = AppContainer.Resolve<IMusicService>();
		K5LdHi2kQ0 = AppContainer.Resolve<IPeopleService>();
		N5idOdIihM = AppContainer.Resolve<IPlaylistService>();
		base.FetchMoreDataCommand = new AsyncCommand(OnFetchMoreDataCommand);
		Q3OeRSTq6SNsAFQUUoG.D35lls5iF(this, new AsyncCommand<SongResponseDto>(wR5dsFXNqS), Q3OeRSTq6SNsAFQUUoG.lyDL0bdcjn);
		Q3OeRSTq6SNsAFQUUoG.D35lls5iF(this, new AsyncCommand<SongResponseDto>(TW3dFEw1JL), Q3OeRSTq6SNsAFQUUoG.ESDLrBCsBg);
		Q3OeRSTq6SNsAFQUUoG.D35lls5iF(this, new DelegateCommand(delegate
		{
			EcRAvP4y5i6535dlslT.D35lls5iF(this, EcRAvP4y5i6535dlslT.g4JLVLXjAq);
		}), Q3OeRSTq6SNsAFQUUoG.h4eLeZRtxB);
		Q3OeRSTq6SNsAFQUUoG.D35lls5iF(this, new AsyncCommand(N4SdCO2SHM, null, APDdMKmT4h), Q3OeRSTq6SNsAFQUUoG.arALGFNBJ3);
		Q3OeRSTq6SNsAFQUUoG.D35lls5iF(this, new AsyncCommand<SongResponseDto>(T0pd6K55ht), Q3OeRSTq6SNsAFQUUoG.Ov5LRjXjsm);
		base.SearchQuery = new ApiQuery<SongSearch, SongSort>
		{
			Count = 25,
			Search = new SongSearch(),
			Sort = SongSort.Hot
		};
		vZXYgvLk8FcpJ1WwQy6.D35lls5iF(this, new List<SongSort>
		{
			SongSort.Name,
			SongSort.WatchCount,
			SongSort.ReleaseYear,
			SongSort.ActivateDate,
			SongSort.Hot
		}, vZXYgvLk8FcpJ1WwQy6.zfuLvWMoyS);
		Q3OeRSTq6SNsAFQUUoG.D35lls5iF(this, new DelegateCommand(delegate(object P_0)
		{
			KBhlAv9D2TgBJ1kkc0B.D35lls5iF(this, P_0, KBhlAv9D2TgBJ1kkc0B.ATqL7dGdKl);
		}), Q3OeRSTq6SNsAFQUUoG.Cu4LA29ib3);
		Q3OeRSTq6SNsAFQUUoG.D35lls5iF(this, new AsyncCommand<SongResponseDto>(xSJdAUI7qy), Q3OeRSTq6SNsAFQUUoG.bdCL6WCSw5);
	}

	[AsyncStateMachine(typeof(_003COnOpenArtitViewCommandExcute_003Ed__77))]
	private Task xSJdAUI7qy(SongResponseDto P_0)
	{
		_003COnOpenArtitViewCommandExcute_003Ed__77 stateMachine = default(_003COnOpenArtitViewCommandExcute_003Ed__77);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine.arg = P_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	[AsyncStateMachine(typeof(_003CLoadSongs_003Ed__78))]
	public Task LoadSongs()
	{
		_003CLoadSongs_003Ed__78 stateMachine = default(_003CLoadSongs_003Ed__78);
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

	private void QkFdNhngth(object P_0)
	{
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (P_0 is SongResponseDto songResponseDto)
		{
			PopupAdorner naEdlUS2fa = NaEdlUS2fa;
			if (naEdlUS2fa != null)
			{
				EcRAvP4y5i6535dlslT.D35lls5iF(naEdlUS2fa, EcRAvP4y5i6535dlslT.zPRLpVOtVj);
			}
			SongInfoView songInfoView = new SongInfoView();
			KBhlAv9D2TgBJ1kkc0B.D35lls5iF(songInfoView, songResponseDto, KBhlAv9D2TgBJ1kkc0B.Rl6Lwm818f);
			SongInfoView content = songInfoView;
			if (k4QmcH8D3DQM6cKOKge.D35lls5iF(Avn84T8ocVcbIlJ2Y1e.D35lls5iF(YIjmNNLCwE8d0SdZyPp.D35lls5iF(this, YIjmNNLCwE8d0SdZyPp.wUXLmaeCo6), Avn84T8ocVcbIlJ2Y1e.Wrp8lMdWHg), base.Items.IndexOf(songResponseDto), k4QmcH8D3DQM6cKOKge.iTE8H1djYB) is ListBoxItem adornedElement)
			{
				PopupAdorner popupAdorner = new PopupAdorner(adornedElement, content, new Vector(-2.0, 168.0));
				EcRAvP4y5i6535dlslT.D35lls5iF(popupAdorner, EcRAvP4y5i6535dlslT.eDULaAYhC3);
				QnJnl7fVDKI4mA6voc.D35lls5iF(this, true, QnJnl7fVDKI4mA6voc.i4mLId7H9P);
				NaEdlUS2fa = popupAdorner;
			}
		}
	}

	[AsyncStateMachine(typeof(_003COnFetchMoreDataCommand_003Ed__81))]
	protected Task OnFetchMoreDataCommand()
	{
		_003COnFetchMoreDataCommand_003Ed__81 stateMachine = default(_003COnFetchMoreDataCommand_003Ed__81);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	[AsyncStateMachine(typeof(_003COnCreatePlayListCommandExcuteException_003Ed__82))]
	private void APDdMKmT4h(Exception P_0)
	{
		_003COnCreatePlayListCommandExcuteException_003Ed__82 stateMachine = default(_003COnCreatePlayListCommandExcuteException_003Ed__82);
		stateMachine._003C_003Et__builder = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
		stateMachine._003C_003E4__this = this;
		stateMachine.ex = P_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003COnCreatePlayListCommandExcute_003Ed__83))]
	private Task N4SdCO2SHM()
	{
		_003COnCreatePlayListCommandExcute_003Ed__83 stateMachine = default(_003COnCreatePlayListCommandExcute_003Ed__83);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	private void stqdYNVKWm()
	{
		jPB9Q5LdIM9wsuWV1q7.D35lls5iF(this, false, jPB9Q5LdIM9wsuWV1q7.jt6LUQJ4wl);
		qni3xrDkAJ3vF35eMav.D35lls5iF(this, "", qni3xrDkAJ3vF35eMav.WukLtApWjl);
	}

	[AsyncStateMachine(typeof(_003COnOpenPlayListCommandExcute_003Ed__85))]
	private Task TW3dFEw1JL(SongResponseDto P_0)
	{
		_003COnOpenPlayListCommandExcute_003Ed__85 stateMachine = default(_003COnOpenPlayListCommandExcute_003Ed__85);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine.arg = P_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	[AsyncStateMachine(typeof(_003COnPlaySongCommandExcute_003Ed__86))]
	private Task T0pd6K55ht(SongResponseDto P_0)
	{
		_003COnPlaySongCommandExcute_003Ed__86 stateMachine = default(_003COnPlaySongCommandExcute_003Ed__86);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine.arg = P_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	[AsyncStateMachine(typeof(_003COnAddToFavoriteCommandExcute_003Ed__87))]
	private Task wR5dsFXNqS(SongResponseDto P_0)
	{
		_003COnAddToFavoriteCommandExcute_003Ed__87 stateMachine = default(_003COnAddToFavoriteCommandExcute_003Ed__87);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine.dto = P_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	public override void Dispose()
	{
		base.Items.Clear();
	}

	[AsyncStateMachine(typeof(_003CAddMoreItems_003Ed__89))]
	public override Task AddMoreItems()
	{
		_003CAddMoreItems_003Ed__89 stateMachine = default(_003CAddMoreItems_003Ed__89);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	[AsyncStateMachine(typeof(_003CGoToPage_003Ed__90))]
	public override Task GoToPage(SongResponseDto model)
	{
		_003CGoToPage_003Ed__90 stateMachine = default(_003CGoToPage_003Ed__90);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
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

	[AsyncStateMachine(typeof(_003CLoadAsync_003Ed__92))]
	public override Task LoadAsync()
	{
		_003CLoadAsync_003Ed__92 stateMachine = default(_003CLoadAsync_003Ed__92);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	[CompilerGenerated]
	private void T3LdxYOAxk(object P_0)
	{
		EcRAvP4y5i6535dlslT.D35lls5iF(this, EcRAvP4y5i6535dlslT.g4JLVLXjAq);
	}

	[CompilerGenerated]
	private void UgRdyaxDOW(object P_0)
	{
		KBhlAv9D2TgBJ1kkc0B.D35lls5iF(this, P_0, KBhlAv9D2TgBJ1kkc0B.ATqL7dGdKl);
	}

	[AsyncStateMachine(typeof(_003C_003CAddMoreItems_003Eb__89_1_003Ed))]
	[CompilerGenerated]
	private Task F9UdpRnpG9()
	{
		_003C_003CAddMoreItems_003Eb__89_1_003Ed stateMachine = default(_003C_003CAddMoreItems_003Eb__89_1_003Ed);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	[CompilerGenerated]
	[AsyncStateMachine(typeof(_003C_003CLoadAsync_003Eb__92_1_003Ed))]
	private Task bR4diYU0Ka()
	{
		_003C_003CLoadAsync_003Eb__92_1_003Ed stateMachine = default(_003C_003CLoadAsync_003Eb__92_1_003Ed);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}
}
