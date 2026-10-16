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
using PROTV.Abstractions.Apis;
using PROTV.Abstractions.Common;
using PROTV.Abstractions.DataTransferObjects;
using PROTV.Abstractions.Helpers;
using PROTV.Abstractions.Search;
using PROTV.Abstractions.Services;
using PROTV.Wpf.Bootstrap;

namespace PROTV.Wpf.ViewModels;

public class MoviesViewModel : BaseListViewModel<MovieResponseDto, ApiQuery<MovieSearch, MovieSort>>
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass25_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct XPSwemZtTLUn9rG0iY : IAsyncStateMachine
		{
			public int RJm8R1p4yl;

			public AsyncTaskMethodBuilder gjF8wHIQ3G;

			public _003C_003Ec__DisplayClass25_0 wyt8EPC8H5;

			private TaskAwaiter OsN89ch5W6;

			private void MoveNext()
			{
				int num = RJm8R1p4yl;
				_003C_003Ec__DisplayClass25_0 obj = wyt8EPC8H5;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						obj.QJ1tItR0GT.Items.Clear();
						obj.QJ1tItR0GT.SearchQuery.Page = 1;
						if (S1a0wT9Ixre9OpDny8h.D35lls5iF(eVlRnEIaHT0dqvCx0Kx.D35lls5iF(obj.wjttVNn4wP, eVlRnEIaHT0dqvCx0Kx.fa575yQKq4), iFZ5je3XFYKwkvcE5D.D35lls5iF(17100, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO))
						{
							lASFo76QIUBEikAAsE9.D35lls5iF(obj.QJ1tItR0GT.SearchQuery.Search, Language.English, lASFo76QIUBEikAAsE9.UMA6X462Ew);
						}
						if (S1a0wT9Ixre9OpDny8h.D35lls5iF(eVlRnEIaHT0dqvCx0Kx.D35lls5iF(obj.wjttVNn4wP, eVlRnEIaHT0dqvCx0Kx.fa575yQKq4), iFZ5je3XFYKwkvcE5D.D35lls5iF(17118, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO))
						{
							lASFo76QIUBEikAAsE9.D35lls5iF(obj.QJ1tItR0GT.SearchQuery.Search, Language.Arabic, lASFo76QIUBEikAAsE9.UMA6X462Ew);
						}
						if (S1a0wT9Ixre9OpDny8h.D35lls5iF(eVlRnEIaHT0dqvCx0Kx.D35lls5iF(obj.wjttVNn4wP, eVlRnEIaHT0dqvCx0Kx.fa575yQKq4), iFZ5je3XFYKwkvcE5D.D35lls5iF(17134, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO))
						{
							lASFo76QIUBEikAAsE9.D35lls5iF(obj.QJ1tItR0GT.SearchQuery.Search, Language.Other, lASFo76QIUBEikAAsE9.UMA6X462Ew);
						}
						if (S1a0wT9Ixre9OpDny8h.D35lls5iF(eVlRnEIaHT0dqvCx0Kx.D35lls5iF(obj.wjttVNn4wP, eVlRnEIaHT0dqvCx0Kx.fa575yQKq4), iFZ5je3XFYKwkvcE5D.D35lls5iF(17148, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO))
						{
							lASFo76QIUBEikAAsE9.D35lls5iF(obj.QJ1tItR0GT.SearchQuery.Search, Language.Turkish, lASFo76QIUBEikAAsE9.UMA6X462Ew);
						}
						if (S1a0wT9Ixre9OpDny8h.D35lls5iF(eVlRnEIaHT0dqvCx0Kx.D35lls5iF(obj.wjttVNn4wP, eVlRnEIaHT0dqvCx0Kx.fa575yQKq4), iFZ5je3XFYKwkvcE5D.D35lls5iF(17166, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO))
						{
							lASFo76QIUBEikAAsE9.D35lls5iF(obj.QJ1tItR0GT.SearchQuery.Search, Language.Japanese, lASFo76QIUBEikAAsE9.UMA6X462Ew);
						}
						if (S1a0wT9Ixre9OpDny8h.D35lls5iF(eVlRnEIaHT0dqvCx0Kx.D35lls5iF(obj.wjttVNn4wP, eVlRnEIaHT0dqvCx0Kx.fa575yQKq4), iFZ5je3XFYKwkvcE5D.D35lls5iF(16162, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO))
						{
							lASFo76QIUBEikAAsE9.D35lls5iF(obj.QJ1tItR0GT.SearchQuery.Search, null, lASFo76QIUBEikAAsE9.UMA6X462Ew);
						}
						awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(CRMxYv82mIBQFuWGeba.D35lls5iF(obj.QJ1tItR0GT, CRMxYv82mIBQFuWGeba.ISkC7tB7Fr), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
						if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
						{
							num = (RJm8R1p4yl = 0);
							OsN89ch5W6 = awaiter;
							gjF8wHIQ3G.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = OsN89ch5W6;
						OsN89ch5W6 = default(TaskAwaiter);
						num = (RJm8R1p4yl = -1);
					}
					oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
				}
				catch (Exception ex)
				{
					RJm8R1p4yl = -2;
					NNK1eXA7fWQ87oSUty7.D35lls5iF(ref gjF8wHIQ3G, ex, NNK1eXA7fWQ87oSUty7.G3EAcW9Om7);
					return;
				}
				RJm8R1p4yl = -2;
				meFicnAMHIVtdhf671p.D35lls5iF(ref gjF8wHIQ3G, meFicnAMHIVtdhf671p.bsDASenQ5I);
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine P_0)
			{
				vxBFJcAKZoecNtbdqxt.D35lls5iF(ref gjF8wHIQ3G, P_0, vxBFJcAKZoecNtbdqxt.tuxANdhu18);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine P_0)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(P_0);
			}
		}

		[StructLayout(LayoutKind.Auto)]
		private struct XbxntstoclTJiuvlca : IAsyncStateMachine
		{
			public int nw18eqJQg5;

			public AsyncVoidMethodBuilder Sap8OFQ0IN;

			public _003C_003Ec__DisplayClass25_0 apI8rOpnjx;

			private TaskAwaiter ke68Hwnq9l;

			private void MoveNext()
			{
				int num = nw18eqJQg5;
				_003C_003Ec__DisplayClass25_0 CS_0024_003C_003E8__locals3 = apI8rOpnjx;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(W7S2sip6SDieZFVsNbd.D35lls5iF(CS_0024_003C_003E8__locals3.QJ1tItR0GT, Expression.Lambda<Func<bool>>(OWBKr5pvc5MWsK1OMtR.D35lls5iF(o4bYL4peNeC2wWb8yjx.D35lls5iF(CS_0024_003C_003E8__locals3.QJ1tItR0GT, sjYxHO8OWlc6X80hFj7.D35lls5iF(typeof(MoviesViewModel).TypeHandle, sjYxHO8OWlc6X80hFj7.uWZ8ugU7r5), o4bYL4peNeC2wWb8yjx.oVdpGKjy2x), (MethodInfo)f5q427pRQZnrEKPy4Ws.D35lls5iF((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, f5q427pRQZnrEKPy4Ws.Bo9pk3m4k7), OWBKr5pvc5MWsK1OMtR.fZIpAAdi1v), Array.Empty<ParameterExpression>()), [AsyncStateMachine(typeof(XPSwemZtTLUn9rG0iY))] () =>
						{
							XPSwemZtTLUn9rG0iY stateMachine = default(XPSwemZtTLUn9rG0iY);
							stateMachine.gjF8wHIQ3G = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
							stateMachine.wyt8EPC8H5 = CS_0024_003C_003E8__locals3;
							stateMachine.RJm8R1p4yl = -1;
							stateMachine.gjF8wHIQ3G.Start(ref stateMachine);
							return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine.gjF8wHIQ3G, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
						}, W7S2sip6SDieZFVsNbd.XWappgVyfh), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
						if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
						{
							num = (nw18eqJQg5 = 0);
							ke68Hwnq9l = awaiter;
							Sap8OFQ0IN.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = ke68Hwnq9l;
						ke68Hwnq9l = default(TaskAwaiter);
						num = (nw18eqJQg5 = -1);
					}
					oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
				}
				catch (Exception ex)
				{
					nw18eqJQg5 = -2;
					N2XUglA3neBsnlZfRPQ.D35lls5iF(ref Sap8OFQ0IN, ex, N2XUglA3neBsnlZfRPQ.l4pATRumoW);
					return;
				}
				nw18eqJQg5 = -2;
				T4XmPoA4VNJJP1afcgL.D35lls5iF(ref Sap8OFQ0IN, T4XmPoA4VNJJP1afcgL.TRyALZckCh);
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine P_0)
			{
				dHWo7jAEn6E4X7bsY4R.D35lls5iF(ref Sap8OFQ0IN, P_0, dHWo7jAEn6E4X7bsY4R.z3hAB6UZ9o);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine P_0)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(P_0);
			}
		}

		public MoviesViewModel QJ1tItR0GT;

		public LanguageResponseDto wjttVNn4wP;

		public Func<Task> I4WtavrK9p;

		public _003C_003Ec__DisplayClass25_0()
		{
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
			base._002Ector();
		}

		[AsyncStateMachine(typeof(XbxntstoclTJiuvlca))]
		internal void YMItPM7MB0()
		{
			XbxntstoclTJiuvlca stateMachine = default(XbxntstoclTJiuvlca);
			stateMachine.Sap8OFQ0IN = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
			stateMachine.apI8rOpnjx = this;
			stateMachine.nw18eqJQg5 = -1;
			stateMachine.Sap8OFQ0IN.Start(ref stateMachine);
		}

		[AsyncStateMachine(typeof(XPSwemZtTLUn9rG0iY))]
		internal Task LdPtqAL17T()
		{
			XPSwemZtTLUn9rG0iY stateMachine = default(XPSwemZtTLUn9rG0iY);
			stateMachine.gjF8wHIQ3G = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
			stateMachine.wyt8EPC8H5 = this;
			stateMachine.RJm8R1p4yl = -1;
			stateMachine.gjF8wHIQ3G.Start(ref stateMachine);
			return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine.gjF8wHIQ3G, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass28_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct FO9jkIS839nVAheAdv : IAsyncStateMachine
		{
			public int ck08oigMX2;

			public AsyncTaskMethodBuilder HWG8g8FQD5;

			public _003C_003Ec__DisplayClass28_0 ni281bhruE;

			private TaskAwaiter UyK8JhAPv9;

			private void MoveNext()
			{
				int num = ck08oigMX2;
				_003C_003Ec__DisplayClass28_0 obj = ni281bhruE;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						obj.IaYtTNGKF5.Items.Clear();
						obj.IaYtTNGKF5.SearchQuery.Page = 1;
						obj.IaYtTNGKF5.SearchQuery.Order = obj.t5EtZcYVBx;
						awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(CRMxYv82mIBQFuWGeba.D35lls5iF(obj.IaYtTNGKF5, CRMxYv82mIBQFuWGeba.ISkC7tB7Fr), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
						if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
						{
							num = (ck08oigMX2 = 0);
							UyK8JhAPv9 = awaiter;
							HWG8g8FQD5.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = UyK8JhAPv9;
						UyK8JhAPv9 = default(TaskAwaiter);
						num = (ck08oigMX2 = -1);
					}
					oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
				}
				catch (Exception ex)
				{
					ck08oigMX2 = -2;
					NNK1eXA7fWQ87oSUty7.D35lls5iF(ref HWG8g8FQD5, ex, NNK1eXA7fWQ87oSUty7.G3EAcW9Om7);
					return;
				}
				ck08oigMX2 = -2;
				meFicnAMHIVtdhf671p.D35lls5iF(ref HWG8g8FQD5, meFicnAMHIVtdhf671p.bsDASenQ5I);
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine P_0)
			{
				vxBFJcAKZoecNtbdqxt.D35lls5iF(ref HWG8g8FQD5, P_0, vxBFJcAKZoecNtbdqxt.tuxANdhu18);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine P_0)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(P_0);
			}
		}

		[StructLayout(LayoutKind.Auto)]
		private struct fe65iWfGmsYLPk38yq : IAsyncStateMachine
		{
			public int e818hBOvqn;

			public AsyncVoidMethodBuilder Ar68l3UFhy;

			public _003C_003Ec__DisplayClass28_0 B7d8UBnoOY;

			private TaskAwaiter YsN8LfxBQ0;

			private void MoveNext()
			{
				int num = e818hBOvqn;
				_003C_003Ec__DisplayClass28_0 CS_0024_003C_003E8__locals3 = B7d8UBnoOY;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(W7S2sip6SDieZFVsNbd.D35lls5iF(CS_0024_003C_003E8__locals3.IaYtTNGKF5, Expression.Lambda<Func<bool>>(OWBKr5pvc5MWsK1OMtR.D35lls5iF(o4bYL4peNeC2wWb8yjx.D35lls5iF(CS_0024_003C_003E8__locals3.IaYtTNGKF5, sjYxHO8OWlc6X80hFj7.D35lls5iF(typeof(MoviesViewModel).TypeHandle, sjYxHO8OWlc6X80hFj7.uWZ8ugU7r5), o4bYL4peNeC2wWb8yjx.oVdpGKjy2x), (MethodInfo)f5q427pRQZnrEKPy4Ws.D35lls5iF((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, f5q427pRQZnrEKPy4Ws.Bo9pk3m4k7), OWBKr5pvc5MWsK1OMtR.fZIpAAdi1v), Array.Empty<ParameterExpression>()), [AsyncStateMachine(typeof(FO9jkIS839nVAheAdv))] () =>
						{
							FO9jkIS839nVAheAdv stateMachine = default(FO9jkIS839nVAheAdv);
							stateMachine.HWG8g8FQD5 = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
							stateMachine.ni281bhruE = CS_0024_003C_003E8__locals3;
							stateMachine.ck08oigMX2 = -1;
							stateMachine.HWG8g8FQD5.Start(ref stateMachine);
							return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine.HWG8g8FQD5, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
						}, W7S2sip6SDieZFVsNbd.XWappgVyfh), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
						if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
						{
							num = (e818hBOvqn = 0);
							YsN8LfxBQ0 = awaiter;
							Ar68l3UFhy.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = YsN8LfxBQ0;
						YsN8LfxBQ0 = default(TaskAwaiter);
						num = (e818hBOvqn = -1);
					}
					oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
				}
				catch (Exception ex)
				{
					e818hBOvqn = -2;
					N2XUglA3neBsnlZfRPQ.D35lls5iF(ref Ar68l3UFhy, ex, N2XUglA3neBsnlZfRPQ.l4pATRumoW);
					return;
				}
				e818hBOvqn = -2;
				T4XmPoA4VNJJP1afcgL.D35lls5iF(ref Ar68l3UFhy, T4XmPoA4VNJJP1afcgL.TRyALZckCh);
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine P_0)
			{
				dHWo7jAEn6E4X7bsY4R.D35lls5iF(ref Ar68l3UFhy, P_0, dHWo7jAEn6E4X7bsY4R.z3hAB6UZ9o);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine P_0)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(P_0);
			}
		}

		public MoviesViewModel IaYtTNGKF5;

		public SortOrder t5EtZcYVBx;

		public Func<Task> qO3ttA9Glf;

		public _003C_003Ec__DisplayClass28_0()
		{
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
			base._002Ector();
		}

		[AsyncStateMachine(typeof(fe65iWfGmsYLPk38yq))]
		internal void Ao3t0AefiV()
		{
			fe65iWfGmsYLPk38yq stateMachine = default(fe65iWfGmsYLPk38yq);
			stateMachine.Ar68l3UFhy = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
			stateMachine.B7d8UBnoOY = this;
			stateMachine.e818hBOvqn = -1;
			stateMachine.Ar68l3UFhy.Start(ref stateMachine);
		}

		[AsyncStateMachine(typeof(FO9jkIS839nVAheAdv))]
		internal Task PYbtGnu1AZ()
		{
			FO9jkIS839nVAheAdv stateMachine = default(FO9jkIS839nVAheAdv);
			stateMachine.HWG8g8FQD5 = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
			stateMachine.ni281bhruE = this;
			stateMachine.ck08oigMX2 = -1;
			stateMachine.HWG8g8FQD5.Start(ref stateMachine);
			return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine.HWG8g8FQD5, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass31_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct Om9OIlKrjIAd14MLwg : IAsyncStateMachine
		{
			public int YPG82Jy7oB;

			public AsyncTaskMethodBuilder sSb8z5JJJL;

			public _003C_003Ec__DisplayClass31_0 wIkQci1GcJ;

			private TaskAwaiter MmEQjb1A5n;

			private void MoveNext()
			{
				int num = YPG82Jy7oB;
				_003C_003Ec__DisplayClass31_0 obj = wIkQci1GcJ;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						obj.bJ4tKMNGIF.Items.Clear();
						obj.bJ4tKMNGIF.SearchQuery.Page = 1;
						obj.bJ4tKMNGIF.SearchQuery.Sort = obj.KwntkUGGTd;
						awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(CRMxYv82mIBQFuWGeba.D35lls5iF(obj.bJ4tKMNGIF, CRMxYv82mIBQFuWGeba.ISkC7tB7Fr), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
						if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
						{
							num = (YPG82Jy7oB = 0);
							MmEQjb1A5n = awaiter;
							sSb8z5JJJL.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = MmEQjb1A5n;
						MmEQjb1A5n = default(TaskAwaiter);
						num = (YPG82Jy7oB = -1);
					}
					oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
				}
				catch (Exception ex)
				{
					YPG82Jy7oB = -2;
					NNK1eXA7fWQ87oSUty7.D35lls5iF(ref sSb8z5JJJL, ex, NNK1eXA7fWQ87oSUty7.G3EAcW9Om7);
					return;
				}
				YPG82Jy7oB = -2;
				meFicnAMHIVtdhf671p.D35lls5iF(ref sSb8z5JJJL, meFicnAMHIVtdhf671p.bsDASenQ5I);
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine P_0)
			{
				vxBFJcAKZoecNtbdqxt.D35lls5iF(ref sSb8z5JJJL, P_0, vxBFJcAKZoecNtbdqxt.tuxANdhu18);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine P_0)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(P_0);
			}
		}

		[StructLayout(LayoutKind.Auto)]
		private struct xLQKO5kZSgPRpKsspq : IAsyncStateMachine
		{
			public int uSfQv5Aobl;

			public AsyncVoidMethodBuilder pHSQWBJhdb;

			public _003C_003Ec__DisplayClass31_0 HTxQ4jJv4i;

			private TaskAwaiter sobQBOB2qt;

			private void MoveNext()
			{
				int num = uSfQv5Aobl;
				_003C_003Ec__DisplayClass31_0 CS_0024_003C_003E8__locals3 = HTxQ4jJv4i;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(W7S2sip6SDieZFVsNbd.D35lls5iF(CS_0024_003C_003E8__locals3.bJ4tKMNGIF, Expression.Lambda<Func<bool>>(OWBKr5pvc5MWsK1OMtR.D35lls5iF(o4bYL4peNeC2wWb8yjx.D35lls5iF(CS_0024_003C_003E8__locals3.bJ4tKMNGIF, sjYxHO8OWlc6X80hFj7.D35lls5iF(typeof(MoviesViewModel).TypeHandle, sjYxHO8OWlc6X80hFj7.uWZ8ugU7r5), o4bYL4peNeC2wWb8yjx.oVdpGKjy2x), (MethodInfo)f5q427pRQZnrEKPy4Ws.D35lls5iF((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, f5q427pRQZnrEKPy4Ws.Bo9pk3m4k7), OWBKr5pvc5MWsK1OMtR.fZIpAAdi1v), Array.Empty<ParameterExpression>()), [AsyncStateMachine(typeof(Om9OIlKrjIAd14MLwg))] () =>
						{
							Om9OIlKrjIAd14MLwg stateMachine = default(Om9OIlKrjIAd14MLwg);
							stateMachine.sSb8z5JJJL = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
							stateMachine.wIkQci1GcJ = CS_0024_003C_003E8__locals3;
							stateMachine.YPG82Jy7oB = -1;
							stateMachine.sSb8z5JJJL.Start(ref stateMachine);
							return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine.sSb8z5JJJL, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
						}, W7S2sip6SDieZFVsNbd.XWappgVyfh), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
						if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
						{
							num = (uSfQv5Aobl = 0);
							sobQBOB2qt = awaiter;
							pHSQWBJhdb.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = sobQBOB2qt;
						sobQBOB2qt = default(TaskAwaiter);
						num = (uSfQv5Aobl = -1);
					}
					oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
				}
				catch (Exception ex)
				{
					uSfQv5Aobl = -2;
					N2XUglA3neBsnlZfRPQ.D35lls5iF(ref pHSQWBJhdb, ex, N2XUglA3neBsnlZfRPQ.l4pATRumoW);
					return;
				}
				uSfQv5Aobl = -2;
				T4XmPoA4VNJJP1afcgL.D35lls5iF(ref pHSQWBJhdb, T4XmPoA4VNJJP1afcgL.TRyALZckCh);
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine P_0)
			{
				dHWo7jAEn6E4X7bsY4R.D35lls5iF(ref pHSQWBJhdb, P_0, dHWo7jAEn6E4X7bsY4R.z3hAB6UZ9o);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine P_0)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(P_0);
			}
		}

		public MoviesViewModel bJ4tKMNGIF;

		public MovieSort KwntkUGGTd;

		public Func<Task> sPKt8PNIoa;

		public _003C_003Ec__DisplayClass31_0()
		{
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
			base._002Ector();
		}

		[AsyncStateMachine(typeof(xLQKO5kZSgPRpKsspq))]
		internal void fcHtSCNgRm()
		{
			xLQKO5kZSgPRpKsspq stateMachine = default(xLQKO5kZSgPRpKsspq);
			stateMachine.pHSQWBJhdb = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
			stateMachine.HTxQ4jJv4i = this;
			stateMachine.uSfQv5Aobl = -1;
			stateMachine.pHSQWBJhdb.Start(ref stateMachine);
		}

		[AsyncStateMachine(typeof(Om9OIlKrjIAd14MLwg))]
		internal Task B6NtfeBZKQ()
		{
			Om9OIlKrjIAd14MLwg stateMachine = default(Om9OIlKrjIAd14MLwg);
			stateMachine.sSb8z5JJJL = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
			stateMachine.wIkQci1GcJ = this;
			stateMachine.YPG82Jy7oB = -1;
			stateMachine.sSb8z5JJJL.Start(ref stateMachine);
			return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine.sSb8z5JJJL, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass34_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct xwLTiX8eqxoNvLq5qL : IAsyncStateMachine
		{
			public int tQoQDU4CD2;

			public AsyncTaskMethodBuilder naqQdNZVUI;

			public _003C_003Ec__DisplayClass34_0 M8JQPDFMaX;

			private TaskAwaiter PNuQq1yKaU;

			private void MoveNext()
			{
				int num = tQoQDU4CD2;
				_003C_003Ec__DisplayClass34_0 obj = M8JQPDFMaX;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						obj.e7WtbYrGW0.Items.Clear();
						obj.e7WtbYrGW0.SearchQuery.Page = 1;
						wuXoja6xGA4YsTL6UdU.D35lls5iF(obj.e7WtbYrGW0.SearchQuery.Search, V4VMaWmQYRpUqEIxujB.D35lls5iF(obj.cGJt7c4b0C, V4VMaWmQYRpUqEIxujB.ppX7zHXVPj), wuXoja6xGA4YsTL6UdU.cAn6YY1406);
						awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(CRMxYv82mIBQFuWGeba.D35lls5iF(obj.e7WtbYrGW0, CRMxYv82mIBQFuWGeba.ISkC7tB7Fr), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
						if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
						{
							num = (tQoQDU4CD2 = 0);
							PNuQq1yKaU = awaiter;
							naqQdNZVUI.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = PNuQq1yKaU;
						PNuQq1yKaU = default(TaskAwaiter);
						num = (tQoQDU4CD2 = -1);
					}
					oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
				}
				catch (Exception ex)
				{
					tQoQDU4CD2 = -2;
					NNK1eXA7fWQ87oSUty7.D35lls5iF(ref naqQdNZVUI, ex, NNK1eXA7fWQ87oSUty7.G3EAcW9Om7);
					return;
				}
				tQoQDU4CD2 = -2;
				meFicnAMHIVtdhf671p.D35lls5iF(ref naqQdNZVUI, meFicnAMHIVtdhf671p.bsDASenQ5I);
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine P_0)
			{
				vxBFJcAKZoecNtbdqxt.D35lls5iF(ref naqQdNZVUI, P_0, vxBFJcAKZoecNtbdqxt.tuxANdhu18);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine P_0)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(P_0);
			}
		}

		[StructLayout(LayoutKind.Auto)]
		private struct xvb9wEQqFh8CEvOqcX : IAsyncStateMachine
		{
			public int s4VQIZMOe6;

			public AsyncVoidMethodBuilder LiXQVbD0MG;

			public _003C_003Ec__DisplayClass34_0 SRHQaQnkLX;

			private TaskAwaiter dDNQ0t1LKc;

			private void MoveNext()
			{
				int num = s4VQIZMOe6;
				_003C_003Ec__DisplayClass34_0 CS_0024_003C_003E8__locals3 = SRHQaQnkLX;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(W7S2sip6SDieZFVsNbd.D35lls5iF(CS_0024_003C_003E8__locals3.e7WtbYrGW0, Expression.Lambda<Func<bool>>(OWBKr5pvc5MWsK1OMtR.D35lls5iF(o4bYL4peNeC2wWb8yjx.D35lls5iF(CS_0024_003C_003E8__locals3.e7WtbYrGW0, sjYxHO8OWlc6X80hFj7.D35lls5iF(typeof(MoviesViewModel).TypeHandle, sjYxHO8OWlc6X80hFj7.uWZ8ugU7r5), o4bYL4peNeC2wWb8yjx.oVdpGKjy2x), (MethodInfo)f5q427pRQZnrEKPy4Ws.D35lls5iF((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, f5q427pRQZnrEKPy4Ws.Bo9pk3m4k7), OWBKr5pvc5MWsK1OMtR.fZIpAAdi1v), Array.Empty<ParameterExpression>()), [AsyncStateMachine(typeof(xwLTiX8eqxoNvLq5qL))] () =>
						{
							xwLTiX8eqxoNvLq5qL stateMachine = default(xwLTiX8eqxoNvLq5qL);
							stateMachine.naqQdNZVUI = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
							stateMachine.M8JQPDFMaX = CS_0024_003C_003E8__locals3;
							stateMachine.tQoQDU4CD2 = -1;
							stateMachine.naqQdNZVUI.Start(ref stateMachine);
							return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine.naqQdNZVUI, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
						}, W7S2sip6SDieZFVsNbd.XWappgVyfh), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
						if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
						{
							num = (s4VQIZMOe6 = 0);
							dDNQ0t1LKc = awaiter;
							LiXQVbD0MG.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = dDNQ0t1LKc;
						dDNQ0t1LKc = default(TaskAwaiter);
						num = (s4VQIZMOe6 = -1);
					}
					oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
				}
				catch (Exception ex)
				{
					s4VQIZMOe6 = -2;
					N2XUglA3neBsnlZfRPQ.D35lls5iF(ref LiXQVbD0MG, ex, N2XUglA3neBsnlZfRPQ.l4pATRumoW);
					return;
				}
				s4VQIZMOe6 = -2;
				T4XmPoA4VNJJP1afcgL.D35lls5iF(ref LiXQVbD0MG, T4XmPoA4VNJJP1afcgL.TRyALZckCh);
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine P_0)
			{
				dHWo7jAEn6E4X7bsY4R.D35lls5iF(ref LiXQVbD0MG, P_0, dHWo7jAEn6E4X7bsY4R.z3hAB6UZ9o);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine P_0)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(P_0);
			}
		}

		public MoviesViewModel e7WtbYrGW0;

		public CategoryResponseDto cGJt7c4b0C;

		public Func<Task> xWst5Ktouq;

		public _003C_003Ec__DisplayClass34_0()
		{
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
			base._002Ector();
		}

		[AsyncStateMachine(typeof(xvb9wEQqFh8CEvOqcX))]
		internal void GustQnSeE7()
		{
			xvb9wEQqFh8CEvOqcX stateMachine = default(xvb9wEQqFh8CEvOqcX);
			stateMachine.LiXQVbD0MG = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
			stateMachine.SRHQaQnkLX = this;
			stateMachine.s4VQIZMOe6 = -1;
			stateMachine.LiXQVbD0MG.Start(ref stateMachine);
		}

		[AsyncStateMachine(typeof(xwLTiX8eqxoNvLq5qL))]
		internal Task sIltnkWACt()
		{
			xwLTiX8eqxoNvLq5qL stateMachine = default(xwLTiX8eqxoNvLq5qL);
			stateMachine.naqQdNZVUI = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
			stateMachine.M8JQPDFMaX = this;
			stateMachine.tQoQDU4CD2 = -1;
			stateMachine.naqQdNZVUI.Start(ref stateMachine);
			return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine.naqQdNZVUI, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass37_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct VSRQXenheC4sSZtuoq : IAsyncStateMachine
		{
			public int xpWQGTd3Lc;

			public AsyncTaskMethodBuilder C8nQTMvOnj;

			public _003C_003Ec__DisplayClass37_0 AdxQZxaluM;

			private TaskAwaiter geRQtT7b2I;

			private void MoveNext()
			{
				int num = xpWQGTd3Lc;
				_003C_003Ec__DisplayClass37_0 obj = AdxQZxaluM;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						obj.WQgtNwTURj.Items.Clear();
						obj.WQgtNwTURj.SearchQuery.Page = 1;
						if (S1a0wT9Ixre9OpDny8h.D35lls5iF(obj.phqtMetOce, iFZ5je3XFYKwkvcE5D.D35lls5iF(8566, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO))
						{
							wuXoja6xGA4YsTL6UdU.D35lls5iF(obj.WQgtNwTURj.SearchQuery.Search, null, wuXoja6xGA4YsTL6UdU.nfU6g7ujEw);
						}
						else
						{
							wuXoja6xGA4YsTL6UdU.D35lls5iF(obj.WQgtNwTURj.SearchQuery.Search, arHqIuLQE32UGutIac7.D35lls5iF(obj.phqtMetOce, arHqIuLQE32UGutIac7.Fa2LXljLFk), wuXoja6xGA4YsTL6UdU.nfU6g7ujEw);
						}
						awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(CRMxYv82mIBQFuWGeba.D35lls5iF(obj.WQgtNwTURj, CRMxYv82mIBQFuWGeba.ISkC7tB7Fr), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
						if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
						{
							num = (xpWQGTd3Lc = 0);
							geRQtT7b2I = awaiter;
							C8nQTMvOnj.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = geRQtT7b2I;
						geRQtT7b2I = default(TaskAwaiter);
						num = (xpWQGTd3Lc = -1);
					}
					oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
				}
				catch (Exception ex)
				{
					xpWQGTd3Lc = -2;
					NNK1eXA7fWQ87oSUty7.D35lls5iF(ref C8nQTMvOnj, ex, NNK1eXA7fWQ87oSUty7.G3EAcW9Om7);
					return;
				}
				xpWQGTd3Lc = -2;
				meFicnAMHIVtdhf671p.D35lls5iF(ref C8nQTMvOnj, meFicnAMHIVtdhf671p.bsDASenQ5I);
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine P_0)
			{
				vxBFJcAKZoecNtbdqxt.D35lls5iF(ref C8nQTMvOnj, P_0, vxBFJcAKZoecNtbdqxt.tuxANdhu18);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine P_0)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(P_0);
			}
		}

		[StructLayout(LayoutKind.Auto)]
		private struct EGPxB3bv4QVlAj05mr : IAsyncStateMachine
		{
			public int VRQQSYWVRs;

			public AsyncVoidMethodBuilder gjUQflsgGS;

			public _003C_003Ec__DisplayClass37_0 GpKQKfgnBV;

			private TaskAwaiter W6lQkgc1ku;

			private void MoveNext()
			{
				int num = VRQQSYWVRs;
				_003C_003Ec__DisplayClass37_0 CS_0024_003C_003E8__locals3 = GpKQKfgnBV;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(W7S2sip6SDieZFVsNbd.D35lls5iF(CS_0024_003C_003E8__locals3.WQgtNwTURj, Expression.Lambda<Func<bool>>(OWBKr5pvc5MWsK1OMtR.D35lls5iF(o4bYL4peNeC2wWb8yjx.D35lls5iF(CS_0024_003C_003E8__locals3.WQgtNwTURj, sjYxHO8OWlc6X80hFj7.D35lls5iF(typeof(MoviesViewModel).TypeHandle, sjYxHO8OWlc6X80hFj7.uWZ8ugU7r5), o4bYL4peNeC2wWb8yjx.oVdpGKjy2x), (MethodInfo)f5q427pRQZnrEKPy4Ws.D35lls5iF((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, f5q427pRQZnrEKPy4Ws.Bo9pk3m4k7), OWBKr5pvc5MWsK1OMtR.fZIpAAdi1v), Array.Empty<ParameterExpression>()), [AsyncStateMachine(typeof(VSRQXenheC4sSZtuoq))] () =>
						{
							VSRQXenheC4sSZtuoq stateMachine = default(VSRQXenheC4sSZtuoq);
							stateMachine.C8nQTMvOnj = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
							stateMachine.AdxQZxaluM = CS_0024_003C_003E8__locals3;
							stateMachine.xpWQGTd3Lc = -1;
							stateMachine.C8nQTMvOnj.Start(ref stateMachine);
							return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine.C8nQTMvOnj, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
						}, W7S2sip6SDieZFVsNbd.XWappgVyfh), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
						if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
						{
							num = (VRQQSYWVRs = 0);
							W6lQkgc1ku = awaiter;
							gjUQflsgGS.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = W6lQkgc1ku;
						W6lQkgc1ku = default(TaskAwaiter);
						num = (VRQQSYWVRs = -1);
					}
					oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
				}
				catch (Exception ex)
				{
					VRQQSYWVRs = -2;
					N2XUglA3neBsnlZfRPQ.D35lls5iF(ref gjUQflsgGS, ex, N2XUglA3neBsnlZfRPQ.l4pATRumoW);
					return;
				}
				VRQQSYWVRs = -2;
				T4XmPoA4VNJJP1afcgL.D35lls5iF(ref gjUQflsgGS, T4XmPoA4VNJJP1afcgL.TRyALZckCh);
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine P_0)
			{
				dHWo7jAEn6E4X7bsY4R.D35lls5iF(ref gjUQflsgGS, P_0, dHWo7jAEn6E4X7bsY4R.z3hAB6UZ9o);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine P_0)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(P_0);
			}
		}

		public MoviesViewModel WQgtNwTURj;

		public string phqtMetOce;

		public Func<Task> IHXtCsHv9i;

		public _003C_003Ec__DisplayClass37_0()
		{
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
			base._002Ector();
		}

		[AsyncStateMachine(typeof(EGPxB3bv4QVlAj05mr))]
		internal void D8UtuCReZg()
		{
			EGPxB3bv4QVlAj05mr stateMachine = default(EGPxB3bv4QVlAj05mr);
			stateMachine.gjUQflsgGS = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
			stateMachine.GpKQKfgnBV = this;
			stateMachine.VRQQSYWVRs = -1;
			stateMachine.gjUQflsgGS.Start(ref stateMachine);
		}

		[AsyncStateMachine(typeof(VSRQXenheC4sSZtuoq))]
		internal Task zvZtAN8Epa()
		{
			VSRQXenheC4sSZtuoq stateMachine = default(VSRQXenheC4sSZtuoq);
			stateMachine.C8nQTMvOnj = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
			stateMachine.AdxQZxaluM = this;
			stateMachine.xpWQGTd3Lc = -1;
			stateMachine.C8nQTMvOnj.Start(ref stateMachine);
			return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine.C8nQTMvOnj, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLoadCategories_003Ed__43 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MoviesViewModel _003C_003E4__this;

		private object _003C_003E7__wrap1;

		private int _003C_003E7__wrap2;

		private TaskAwaiter<ResponseList<CategoryResponseDto>> _003C_003Eu__1;

		private TaskAwaiter<bool> _003C_003Eu__2;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			MoviesViewModel moviesViewModel = _003C_003E4__this;
			try
			{
				TaskAwaiter<bool> awaiter;
				if (num != 0)
				{
					if (num == 1)
					{
						awaiter = _003C_003Eu__2;
						_003C_003Eu__2 = default(TaskAwaiter<bool>);
						num = (_003C_003E1__state = -1);
						goto IL_0203;
					}
					_003C_003E7__wrap2 = 0;
				}
				try
				{
					TaskAwaiter<ResponseList<CategoryResponseDto>> awaiter2;
					if (num != 0)
					{
						IAppService q9mdckuSg = moviesViewModel.Q9mdckuSg8;
						ApiQuery<CategorySearch, GeneralSort> obj = new ApiQuery<CategorySearch, GeneralSort>
						{
							Count = -1,
							Sort = GeneralSort.Name
						};
						CategorySearch categorySearch = new CategorySearch();
						PDE695CGbWQ6wS7etBU.D35lls5iF(categorySearch, CategoryType.Movie, PDE695CGbWQ6wS7etBU.rt7CRxAZ59);
						obj.Search = categorySearch;
						obj.Order = SortOrder.Asc;
						awaiter2 = GEHLO0CkuIP8aA9CV10.D35lls5iF(q9mdckuSg, obj, GEHLO0CkuIP8aA9CV10.AXeCvbp3sh).GetAwaiter();
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
						fbCfXAT6sNT7gTw1IjA.D35lls5iF(moviesViewModel, result.Data.Result.ToList(), fbCfXAT6sNT7gTw1IjA.M4UCAPHvcL);
						List<CategoryResponseDto> list = hB8t9uC6c022dNynAqg.D35lls5iF(moviesViewModel, hB8t9uC6c022dNynAqg.n1xCprT7JL);
						CategoryResponseDto categoryResponseDto = new CategoryResponseDto();
						wuXoja6xGA4YsTL6UdU.D35lls5iF(categoryResponseDto, null, wuXoja6xGA4YsTL6UdU.LxQCwZHHRC);
						hH6DVMBvgw3ANNRyBk6.D35lls5iF(categoryResponseDto, iFZ5je3XFYKwkvcE5D.D35lls5iF(16162, iFZ5je3XFYKwkvcE5D.N06TeK0ao), hH6DVMBvgw3ANNRyBk6.HifCCinobp);
						list.Insert(0, categoryResponseDto);
						qni3xrDkAJ3vF35eMav.D35lls5iF(moviesViewModel, iFZ5je3XFYKwkvcE5D.D35lls5iF(16172, iFZ5je3XFYKwkvcE5D.N06TeK0ao), qni3xrDkAJ3vF35eMav.QN6DuDtCWO);
					}
				}
				catch (PROTVException ex)
				{
					_003C_003E7__wrap1 = ex;
					_003C_003E7__wrap2 = 1;
				}
				int num2 = _003C_003E7__wrap2;
				if (num2 == 1 && TNckS5wtLfB2Lk9dYP8.D35lls5iF((PROTVException)_003C_003E7__wrap1, TNckS5wtLfB2Lk9dYP8.oGkwV3iq3t) == ExceptionType.AuthorizationTokenInvalid)
				{
					awaiter = bAA7Sxw7vZsvusOmDea.D35lls5iF(AppContainer.Resolve<MainViewModel>(), bAA7Sxw7vZsvusOmDea.gytwc9U7r5).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_003C_003E1__state = 1);
						_003C_003Eu__2 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_0203;
				}
				goto IL_0225;
				IL_0225:
				_003C_003E7__wrap1 = null;
				goto end_IL_0015;
				IL_0203:
				if (awaiter.GetResult())
				{
					moviesViewModel.jFvDzZv6v1 = AppContainer.Resolve<IMovieService>();
					moviesViewModel.Q9mdckuSg8 = AppContainer.Resolve<IAppService>();
				}
				goto IL_0225;
				end_IL_0015:;
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
	private struct _003CLoadLanguages_003Ed__44 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MoviesViewModel _003C_003E4__this;

		private object _003C_003E7__wrap1;

		private int _003C_003E7__wrap2;

		private TaskAwaiter<Response<List<LanguageResponseDto>>> _003C_003Eu__1;

		private TaskAwaiter<bool> _003C_003Eu__2;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			MoviesViewModel moviesViewModel = _003C_003E4__this;
			try
			{
				TaskAwaiter<bool> awaiter;
				if (num != 0)
				{
					if (num == 1)
					{
						awaiter = _003C_003Eu__2;
						_003C_003Eu__2 = default(TaskAwaiter<bool>);
						num = (_003C_003E1__state = -1);
						goto IL_01ae;
					}
					_003C_003E7__wrap2 = 0;
				}
				try
				{
					TaskAwaiter<Response<List<LanguageResponseDto>>> awaiter2;
					if (num != 0)
					{
						awaiter2 = JpDxOxCmce3lXyrJfoD.D35lls5iF(moviesViewModel.Q9mdckuSg8, JpDxOxCmce3lXyrJfoD.e1qCaQE3F1).GetAwaiter();
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
						CLLqb8CIn0YcxaJaY92.D35lls5iF(moviesViewModel, result.Data, CLLqb8CIn0YcxaJaY92.H0fCduZAKU);
						List<LanguageResponseDto> list = C7l25jCU6VYRwoJcihE.D35lls5iF(moviesViewModel, C7l25jCU6VYRwoJcihE.nhPCtpjMCN);
						LanguageResponseDto languageResponseDto = new LanguageResponseDto();
						hH6DVMBvgw3ANNRyBk6.D35lls5iF(languageResponseDto, iFZ5je3XFYKwkvcE5D.D35lls5iF(16162, iFZ5je3XFYKwkvcE5D.N06TeK0ao), hH6DVMBvgw3ANNRyBk6.XuyCVW7uIV);
						list.Insert(0, languageResponseDto);
						qni3xrDkAJ3vF35eMav.D35lls5iF(moviesViewModel, iFZ5je3XFYKwkvcE5D.D35lls5iF(16196, iFZ5je3XFYKwkvcE5D.N06TeK0ao), qni3xrDkAJ3vF35eMav.QN6DuDtCWO);
					}
				}
				catch (PROTVException ex)
				{
					_003C_003E7__wrap1 = ex;
					_003C_003E7__wrap2 = 1;
				}
				int num2 = _003C_003E7__wrap2;
				if (num2 == 1 && TNckS5wtLfB2Lk9dYP8.D35lls5iF((PROTVException)_003C_003E7__wrap1, TNckS5wtLfB2Lk9dYP8.oGkwV3iq3t) == ExceptionType.AuthorizationTokenInvalid)
				{
					awaiter = bAA7Sxw7vZsvusOmDea.D35lls5iF(AppContainer.Resolve<MainViewModel>(), bAA7Sxw7vZsvusOmDea.gytwc9U7r5).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_003C_003E1__state = 1);
						_003C_003Eu__2 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_01ae;
				}
				goto IL_01d0;
				IL_01d0:
				_003C_003E7__wrap1 = null;
				goto end_IL_0015;
				IL_01ae:
				if (awaiter.GetResult())
				{
					moviesViewModel.jFvDzZv6v1 = AppContainer.Resolve<IMovieService>();
					moviesViewModel.Q9mdckuSg8 = AppContainer.Resolve<IAppService>();
				}
				goto IL_01d0;
				end_IL_0015:;
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
	private struct _003CLoadMovies_003Ed__45 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MoviesViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			MoviesViewModel moviesViewModel = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					moviesViewModel.Items.Clear();
					moviesViewModel.SearchQuery.Page = 1;
					moviesViewModel.SearchQuery.Count = 25;
					moviesViewModel.SearchQuery.Sort = MovieSort.ActivateDate;
					moviesViewModel.SearchQuery.Order = SortOrder.Desc;
					wuXoja6xGA4YsTL6UdU.D35lls5iF(moviesViewModel.SearchQuery.Search, null, wuXoja6xGA4YsTL6UdU.cAn6YY1406);
					wuXoja6xGA4YsTL6UdU.D35lls5iF(moviesViewModel.SearchQuery.Search, null, wuXoja6xGA4YsTL6UdU.nfU6g7ujEw);
					hH6DVMBvgw3ANNRyBk6.D35lls5iF(moviesViewModel.SearchQuery.Search, null, hH6DVMBvgw3ANNRyBk6.RRK6ishEFm);
					lASFo76QIUBEikAAsE9.D35lls5iF(moviesViewModel.SearchQuery.Search, null, lASFo76QIUBEikAAsE9.UMA6X462Ew);
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(CRMxYv82mIBQFuWGeba.D35lls5iF(moviesViewModel, CRMxYv82mIBQFuWGeba.ISkC7tB7Fr), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
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
	private struct _003CLoadMoviesAfterSearch_003Ed__47 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MoviesViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			MoviesViewModel moviesViewModel = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					moviesViewModel.Items.Clear();
					moviesViewModel.SearchQuery.Page = 1;
					moviesViewModel.SearchQuery.Count = 25;
					hH6DVMBvgw3ANNRyBk6.D35lls5iF(moviesViewModel.SearchQuery.Search, QQLie3eYkZwbFFm9Jjw.D35lls5iF(moviesViewModel, QQLie3eYkZwbFFm9Jjw.Xv1CcQ7mTb), hH6DVMBvgw3ANNRyBk6.RRK6ishEFm);
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(CRMxYv82mIBQFuWGeba.D35lls5iF(moviesViewModel, CRMxYv82mIBQFuWGeba.ISkC7tB7Fr), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
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
	private struct _003COnFetchMoreDataCommand_003Ed__48 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MoviesViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			MoviesViewModel moviesViewModel = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_00a2;
				}
				if (moviesViewModel.CurrentPage < moviesViewModel.Items.Count && !hjMnupQVVDlRZAYQJC.D35lls5iF(moviesViewModel, hjMnupQVVDlRZAYQJC.jJYTSHn9tB))
				{
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(moviesViewModel.AddMoreItems(), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
					if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_00a2;
				}
				goto end_IL_0015;
				IL_00a2:
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
	private struct _003CAddMoreItems_003Ed__50 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MoviesViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			MoviesViewModel CS_0024_003C_003E8__locals3 = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(W7S2sip6SDieZFVsNbd.D35lls5iF(CS_0024_003C_003E8__locals3, Expression.Lambda<Func<bool>>(OWBKr5pvc5MWsK1OMtR.D35lls5iF(o4bYL4peNeC2wWb8yjx.D35lls5iF(CS_0024_003C_003E8__locals3, sjYxHO8OWlc6X80hFj7.D35lls5iF(typeof(MoviesViewModel).TypeHandle, sjYxHO8OWlc6X80hFj7.uWZ8ugU7r5), o4bYL4peNeC2wWb8yjx.oVdpGKjy2x), (MethodInfo)f5q427pRQZnrEKPy4Ws.D35lls5iF((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, f5q427pRQZnrEKPy4Ws.Bo9pk3m4k7), OWBKr5pvc5MWsK1OMtR.fZIpAAdi1v), Array.Empty<ParameterExpression>()), [AsyncStateMachine(typeof(_003C_003CAddMoreItems_003Eb__50_1_003Ed))] () =>
					{
						_003C_003CAddMoreItems_003Eb__50_1_003Ed stateMachine = default(_003C_003CAddMoreItems_003Eb__50_1_003Ed);
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
	private struct _003CGoToPage_003Ed__51 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MovieResponseDto model;

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
					goto IL_00f4;
				}
				if (m9MGZR7k2RmVqYXYS5.D35lls5iF(model, m9MGZR7k2RmVqYXYS5.j871CQO7pP) > 0)
				{
					_003ChomeViewModel_003E5__2 = Sp7dKWL9ZfBld4JOkGo.D35lls5iF(AppContainer.Resolve<MainViewModel>(), Sp7dKWL9ZfBld4JOkGo.QpWwMTMAhO) as HomeViewModel;
					MovieItemViewModel viewModel = new MovieItemViewModel(model);
					Page page = new Page();
					KBhlAv9D2TgBJ1kkc0B.D35lls5iF(page, IyGDDwHBiPv8vfOFJDF.D35lls5iF(ApplicationPage.MovieDetailsPage, viewModel, IyGDDwHBiPv8vfOFJDF.hivH0XYhaE), KBhlAv9D2TgBJ1kkc0B.fWUHrWO7Sa);
					qni3xrDkAJ3vF35eMav.D35lls5iF(page, QQLie3eYkZwbFFm9Jjw.D35lls5iF(model, QQLie3eYkZwbFFm9Jjw.T8RwSgEfbh), qni3xrDkAJ3vF35eMav.Ra7HRFTvnD);
					_003Cpage_003E5__3 = page;
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(pvrKKy8Mk1kpdmIfp3A.D35lls5iF(5, pvrKKy8Mk1kpdmIfp3A.aVh8SPrFkE), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
					if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_00f4;
				}
				goto end_IL_000e;
				IL_00f4:
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
	private struct _003CLoadAsync_003Ed__53 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MoviesViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			MoviesViewModel CS_0024_003C_003E8__locals3 = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(W7S2sip6SDieZFVsNbd.D35lls5iF(CS_0024_003C_003E8__locals3, Expression.Lambda<Func<bool>>(OWBKr5pvc5MWsK1OMtR.D35lls5iF(o4bYL4peNeC2wWb8yjx.D35lls5iF(CS_0024_003C_003E8__locals3, sjYxHO8OWlc6X80hFj7.D35lls5iF(typeof(MoviesViewModel).TypeHandle, sjYxHO8OWlc6X80hFj7.uWZ8ugU7r5), o4bYL4peNeC2wWb8yjx.oVdpGKjy2x), (MethodInfo)f5q427pRQZnrEKPy4Ws.D35lls5iF((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, f5q427pRQZnrEKPy4Ws.Bo9pk3m4k7), OWBKr5pvc5MWsK1OMtR.fZIpAAdi1v), Array.Empty<ParameterExpression>()), [AsyncStateMachine(typeof(_003C_003CLoadAsync_003Eb__53_1_003Ed))] () =>
					{
						_003C_003CLoadAsync_003Eb__53_1_003Ed stateMachine = default(_003C_003CLoadAsync_003Eb__53_1_003Ed);
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
	private struct _003COnAddToFavoriteCommandExcute_003Ed__54 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MoviesViewModel _003C_003E4__this;

		public MovieResponseDto arg;

		private TaskAwaiter<Response<bool>> _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			MoviesViewModel moviesViewModel = _003C_003E4__this;
			try
			{
				try
				{
					TaskAwaiter<Response<bool>> awaiter;
					if (num != 0)
					{
						awaiter = VhWvkQCMZdHLs55TvEh.D35lls5iF(moviesViewModel.jFvDzZv6v1, m9MGZR7k2RmVqYXYS5.D35lls5iF(arg, m9MGZR7k2RmVqYXYS5.j871CQO7pP), VhWvkQCMZdHLs55TvEh.g7BCSZyjeL).GetAwaiter();
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
						_003C_003Eu__1 = default(TaskAwaiter<Response<bool>>);
						num = (_003C_003E1__state = -1);
					}
					Response<bool> result = awaiter.GetResult();
					if (result != null && result.Status)
					{
						jPB9Q5LdIM9wsuWV1q7.D35lls5iF(arg, result.Data, jPB9Q5LdIM9wsuWV1q7.Xd3CKJmPoy);
						hH6DVMBvgw3ANNRyBk6.D35lls5iF(arg, iFZ5je3XFYKwkvcE5D.D35lls5iF(8354, iFZ5je3XFYKwkvcE5D.N06TeK0ao), hH6DVMBvgw3ANNRyBk6.zQVCN18Aqk);
					}
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
	private struct _003CAddMovies_003Ed__55 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MoviesViewModel _003C_003E4__this;

		private object _003C_003E7__wrap1;

		private int _003C_003E7__wrap2;

		private ResponseList<MovieResponseDto> _003Cresult_003E5__4;

		private TaskAwaiter<ResponseList<MovieResponseDto>> _003C_003Eu__1;

		private IEnumerator<MovieResponseDto> _003C_003E7__wrap4;

		private MovieResponseDto _003Citem_003E5__6;

		private TaskAwaiter _003C_003Eu__2;

		private TaskAwaiter<bool> _003C_003Eu__3;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			MoviesViewModel moviesViewModel = _003C_003E4__this;
			try
			{
				TaskAwaiter<bool> awaiter;
				if ((uint)num > 1u)
				{
					if (num == 2)
					{
						awaiter = _003C_003Eu__3;
						_003C_003Eu__3 = default(TaskAwaiter<bool>);
						num = (_003C_003E1__state = -1);
						goto IL_02d2;
					}
					_003C_003E7__wrap2 = 0;
				}
				try
				{
					TaskAwaiter<ResponseList<MovieResponseDto>> awaiter2;
					if (num != 0)
					{
						if (num == 1)
						{
							goto IL_00e5;
						}
						awaiter2 = uJ8tlJ6fZh5lIpltrW4.D35lls5iF(moviesViewModel.jFvDzZv6v1, moviesViewModel.SearchQuery, uJ8tlJ6fZh5lIpltrW4.XUv6FyAaBs).GetAwaiter();
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
						_003C_003Eu__1 = default(TaskAwaiter<ResponseList<MovieResponseDto>>);
						num = (_003C_003E1__state = -1);
					}
					ResponseList<MovieResponseDto> result = awaiter2.GetResult();
					_003Cresult_003E5__4 = result;
					if (_003Cresult_003E5__4 != null && _003Cresult_003E5__4.Status)
					{
						_003C_003E7__wrap4 = _003Cresult_003E5__4.Data.Result.GetEnumerator();
						goto IL_00e5;
					}
					moviesViewModel.TotalCount = 0;
					goto IL_0222;
					IL_0222:
					_003Cresult_003E5__4 = null;
					goto end_IL_002b;
					IL_00e5:
					try
					{
						if (num != 1)
						{
							goto IL_0190;
						}
						TaskAwaiter awaiter3 = _003C_003Eu__2;
						_003C_003Eu__2 = default(TaskAwaiter);
						num = (_003C_003E1__state = -1);
						goto IL_016c;
						IL_016c:
						oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter3, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
						moviesViewModel.Items.Add(_003Citem_003E5__6);
						_003Citem_003E5__6 = null;
						goto IL_0190;
						IL_0190:
						if (hjMnupQVVDlRZAYQJC.D35lls5iF(_003C_003E7__wrap4, hjMnupQVVDlRZAYQJC.QV1TFwytOj))
						{
							_003Citem_003E5__6 = _003C_003E7__wrap4.Current;
							awaiter3 = QliBEUviwWqgtMcBndV.D35lls5iF(pvrKKy8Mk1kpdmIfp3A.D35lls5iF(10, pvrKKy8Mk1kpdmIfp3A.aVh8SPrFkE), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
							if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter3, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
							{
								num = (_003C_003E1__state = 1);
								_003C_003Eu__2 = awaiter3;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
								return;
							}
							goto IL_016c;
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
					moviesViewModel.CurrentPage = _003Cresult_003E5__4.Data.CurrentPage;
					moviesViewModel.PageCount = _003Cresult_003E5__4.Data.PageCount;
					moviesViewModel.TotalCount = _003Cresult_003E5__4.Data.Total;
					goto IL_0222;
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
							num = (_003C_003E1__state = 2);
							_003C_003Eu__3 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_02d2;
					}
					moviesViewModel.TotalCount = 0;
				}
				goto IL_0300;
				IL_0300:
				_003C_003E7__wrap1 = null;
				goto end_IL_0015;
				IL_02d2:
				if (awaiter.GetResult())
				{
					moviesViewModel.jFvDzZv6v1 = AppContainer.Resolve<IMovieService>();
					moviesViewModel.Q9mdckuSg8 = AppContainer.Resolve<IAppService>();
				}
				goto IL_0300;
				end_IL_0015:;
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
	private struct _003C_003CAddMoreItems_003Eb__50_1_003Ed : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MoviesViewModel _003C_003E4__this;

		private object _003C_003E7__wrap1;

		private int _003C_003E7__wrap2;

		private ResponseList<MovieResponseDto> _003Cresult_003E5__4;

		private TaskAwaiter<ResponseList<MovieResponseDto>> _003C_003Eu__1;

		private IEnumerator<MovieResponseDto> _003C_003E7__wrap4;

		private MovieResponseDto _003Citem_003E5__6;

		private TaskAwaiter _003C_003Eu__2;

		private TaskAwaiter<bool> _003C_003Eu__3;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			MoviesViewModel moviesViewModel = _003C_003E4__this;
			try
			{
				TaskAwaiter<bool> awaiter;
				if ((uint)num > 1u)
				{
					if (num == 2)
					{
						awaiter = _003C_003Eu__3;
						_003C_003Eu__3 = default(TaskAwaiter<bool>);
						num = (_003C_003E1__state = -1);
						goto IL_02f6;
					}
					moviesViewModel.SearchQuery.Page++;
					_003C_003E7__wrap2 = 0;
				}
				try
				{
					TaskAwaiter<ResponseList<MovieResponseDto>> awaiter2;
					if (num != 0)
					{
						if (num == 1)
						{
							goto IL_00fd;
						}
						awaiter2 = uJ8tlJ6fZh5lIpltrW4.D35lls5iF(moviesViewModel.jFvDzZv6v1, moviesViewModel.SearchQuery, uJ8tlJ6fZh5lIpltrW4.XUv6FyAaBs).GetAwaiter();
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
						_003C_003Eu__1 = default(TaskAwaiter<ResponseList<MovieResponseDto>>);
						num = (_003C_003E1__state = -1);
					}
					ResponseList<MovieResponseDto> result = awaiter2.GetResult();
					_003Cresult_003E5__4 = result;
					if (_003Cresult_003E5__4 != null && _003Cresult_003E5__4.Status)
					{
						_003C_003E7__wrap4 = _003Cresult_003E5__4.Data.Result.GetEnumerator();
						goto IL_00fd;
					}
					moviesViewModel.SearchQuery.Page--;
					goto IL_0248;
					IL_0248:
					_003Cresult_003E5__4 = null;
					goto end_IL_0040;
					IL_00fd:
					try
					{
						if (num != 1)
						{
							goto IL_01a8;
						}
						TaskAwaiter awaiter3 = _003C_003Eu__2;
						_003C_003Eu__2 = default(TaskAwaiter);
						num = (_003C_003E1__state = -1);
						goto IL_0184;
						IL_0184:
						oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter3, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
						moviesViewModel.Items.Add(_003Citem_003E5__6);
						_003Citem_003E5__6 = null;
						goto IL_01a8;
						IL_01a8:
						if (hjMnupQVVDlRZAYQJC.D35lls5iF(_003C_003E7__wrap4, hjMnupQVVDlRZAYQJC.QV1TFwytOj))
						{
							_003Citem_003E5__6 = _003C_003E7__wrap4.Current;
							awaiter3 = QliBEUviwWqgtMcBndV.D35lls5iF(pvrKKy8Mk1kpdmIfp3A.D35lls5iF(10, pvrKKy8Mk1kpdmIfp3A.aVh8SPrFkE), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
							if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter3, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
							{
								num = (_003C_003E1__state = 1);
								_003C_003Eu__2 = awaiter3;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
								return;
							}
							goto IL_0184;
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
					moviesViewModel.CurrentPage = _003Cresult_003E5__4.Data.CurrentPage;
					moviesViewModel.PageCount = _003Cresult_003E5__4.Data.PageCount;
					moviesViewModel.TotalCount = _003Cresult_003E5__4.Data.Total;
					goto IL_0248;
					end_IL_0040:;
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
							num = (_003C_003E1__state = 2);
							_003C_003Eu__3 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_02f6;
					}
					moviesViewModel.SearchQuery.Page--;
				}
				goto IL_0332;
				IL_0332:
				_003C_003E7__wrap1 = null;
				goto end_IL_0015;
				IL_02f6:
				if (awaiter.GetResult())
				{
					moviesViewModel.jFvDzZv6v1 = AppContainer.Resolve<IMovieService>();
					moviesViewModel.Q9mdckuSg8 = AppContainer.Resolve<IAppService>();
				}
				goto IL_0332;
				end_IL_0015:;
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
	private struct _003C_003CLoadAsync_003Eb__53_1_003Ed : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MoviesViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			MoviesViewModel moviesViewModel = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(VrVteFCs0OCGBTVr1mZ.D35lls5iF(new Task[3]
					{
						CRMxYv82mIBQFuWGeba.D35lls5iF(moviesViewModel, CRMxYv82mIBQFuWGeba.hahCOTiuML),
						CRMxYv82mIBQFuWGeba.D35lls5iF(moviesViewModel, CRMxYv82mIBQFuWGeba.pwkCusXkoc),
						CRMxYv82mIBQFuWGeba.D35lls5iF(moviesViewModel, CRMxYv82mIBQFuWGeba.rj3CP32y1s)
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

	private IMovieService jFvDzZv6v1;

	private IAppService Q9mdckuSg8;

	private LanguageResponseDto VZRdjDxTo4;

	private SortOrder y8UdvHw9x7;

	private MovieSort fRZdWywwky;

	private CategoryResponseDto oVjd4DYExA;

	private string xA6dB3J6MY;

	[CompilerGenerated]
	private string cwBdD4kXFO;

	[CompilerGenerated]
	private List<LanguageResponseDto> NYaddZYUaD;

	[CompilerGenerated]
	private List<MovieSort> GlgdPZgq1w;

	[CompilerGenerated]
	private List<CategoryResponseDto> jOjdqlclFf;

	[CompilerGenerated]
	private ICommand rWEdITg2tC;

	public string Search
	{
		[CompilerGenerated]
		get
		{
			return cwBdD4kXFO;
		}
		[CompilerGenerated]
		set
		{
			cwBdD4kXFO = value;
		}
	}

	public List<LanguageResponseDto> Languages
	{
		[CompilerGenerated]
		get
		{
			return NYaddZYUaD;
		}
		[CompilerGenerated]
		set
		{
			NYaddZYUaD = value;
		}
	}

	public List<MovieSort> SortItems
	{
		[CompilerGenerated]
		get
		{
			return GlgdPZgq1w;
		}
		[CompilerGenerated]
		set
		{
			GlgdPZgq1w = value;
		}
	}

	public List<CategoryResponseDto> Categories
	{
		[CompilerGenerated]
		get
		{
			return jOjdqlclFf;
		}
		[CompilerGenerated]
		set
		{
			jOjdqlclFf = value;
		}
	}

	public LanguageResponseDto SelectedLanguage
	{
		get
		{
			return VZRdjDxTo4;
		}
		set
		{
			_003C_003Ec__DisplayClass25_0 CS_0024_003C_003E8__locals4 = new _003C_003Ec__DisplayClass25_0();
			CS_0024_003C_003E8__locals4.QJ1tItR0GT = this;
			CS_0024_003C_003E8__locals4.wjttVNn4wP = value;
			SetProperty(ref VZRdjDxTo4, CS_0024_003C_003E8__locals4.wjttVNn4wP, iFZ5je3XFYKwkvcE5D.D35lls5iF(10186, iFZ5je3XFYKwkvcE5D.N06TeK0ao), null, [AsyncStateMachine(typeof(_003C_003Ec__DisplayClass25_0.XbxntstoclTJiuvlca))] () =>
			{
				_003C_003Ec__DisplayClass25_0.XbxntstoclTJiuvlca stateMachine = default(_003C_003Ec__DisplayClass25_0.XbxntstoclTJiuvlca);
				stateMachine.Sap8OFQ0IN = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
				stateMachine.apI8rOpnjx = CS_0024_003C_003E8__locals4;
				stateMachine.nw18eqJQg5 = -1;
				stateMachine.Sap8OFQ0IN.Start(ref stateMachine);
			});
		}
	}

	public SortOrder SelectedOrder
	{
		get
		{
			return y8UdvHw9x7;
		}
		set
		{
			_003C_003Ec__DisplayClass28_0 CS_0024_003C_003E8__locals4 = new _003C_003Ec__DisplayClass28_0();
			CS_0024_003C_003E8__locals4.IaYtTNGKF5 = this;
			CS_0024_003C_003E8__locals4.t5EtZcYVBx = value;
			SetProperty(ref y8UdvHw9x7, CS_0024_003C_003E8__locals4.t5EtZcYVBx, iFZ5je3XFYKwkvcE5D.D35lls5iF(8208, iFZ5je3XFYKwkvcE5D.N06TeK0ao), null, [AsyncStateMachine(typeof(_003C_003Ec__DisplayClass28_0.fe65iWfGmsYLPk38yq))] () =>
			{
				_003C_003Ec__DisplayClass28_0.fe65iWfGmsYLPk38yq stateMachine = default(_003C_003Ec__DisplayClass28_0.fe65iWfGmsYLPk38yq);
				stateMachine.Ar68l3UFhy = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
				stateMachine.B7d8UBnoOY = CS_0024_003C_003E8__locals4;
				stateMachine.e818hBOvqn = -1;
				stateMachine.Ar68l3UFhy.Start(ref stateMachine);
			});
		}
	}

	public MovieSort SelectedSort
	{
		get
		{
			return fRZdWywwky;
		}
		set
		{
			_003C_003Ec__DisplayClass31_0 CS_0024_003C_003E8__locals4 = new _003C_003Ec__DisplayClass31_0();
			CS_0024_003C_003E8__locals4.bJ4tKMNGIF = this;
			CS_0024_003C_003E8__locals4.KwntkUGGTd = value;
			SetProperty(ref fRZdWywwky, CS_0024_003C_003E8__locals4.KwntkUGGTd, iFZ5je3XFYKwkvcE5D.D35lls5iF(10222, iFZ5je3XFYKwkvcE5D.N06TeK0ao), null, [AsyncStateMachine(typeof(_003C_003Ec__DisplayClass31_0.xLQKO5kZSgPRpKsspq))] () =>
			{
				_003C_003Ec__DisplayClass31_0.xLQKO5kZSgPRpKsspq stateMachine = default(_003C_003Ec__DisplayClass31_0.xLQKO5kZSgPRpKsspq);
				stateMachine.pHSQWBJhdb = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
				stateMachine.HTxQ4jJv4i = CS_0024_003C_003E8__locals4;
				stateMachine.uSfQv5Aobl = -1;
				stateMachine.pHSQWBJhdb.Start(ref stateMachine);
			});
		}
	}

	public CategoryResponseDto SelectedCategory
	{
		get
		{
			return oVjd4DYExA;
		}
		set
		{
			_003C_003Ec__DisplayClass34_0 CS_0024_003C_003E8__locals4 = new _003C_003Ec__DisplayClass34_0();
			CS_0024_003C_003E8__locals4.e7WtbYrGW0 = this;
			CS_0024_003C_003E8__locals4.cGJt7c4b0C = value;
			SetProperty(ref oVjd4DYExA, CS_0024_003C_003E8__locals4.cGJt7c4b0C, iFZ5je3XFYKwkvcE5D.D35lls5iF(8238, iFZ5je3XFYKwkvcE5D.N06TeK0ao), null, [AsyncStateMachine(typeof(_003C_003Ec__DisplayClass34_0.xvb9wEQqFh8CEvOqcX))] () =>
			{
				_003C_003Ec__DisplayClass34_0.xvb9wEQqFh8CEvOqcX stateMachine = default(_003C_003Ec__DisplayClass34_0.xvb9wEQqFh8CEvOqcX);
				stateMachine.LiXQVbD0MG = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
				stateMachine.SRHQaQnkLX = CS_0024_003C_003E8__locals4;
				stateMachine.s4VQIZMOe6 = -1;
				stateMachine.LiXQVbD0MG.Start(ref stateMachine);
			});
		}
	}

	public string SelectedYear
	{
		get
		{
			return xA6dB3J6MY;
		}
		set
		{
			_003C_003Ec__DisplayClass37_0 CS_0024_003C_003E8__locals4 = new _003C_003Ec__DisplayClass37_0();
			CS_0024_003C_003E8__locals4.WQgtNwTURj = this;
			CS_0024_003C_003E8__locals4.phqtMetOce = value;
			SetProperty(ref xA6dB3J6MY, CS_0024_003C_003E8__locals4.phqtMetOce, iFZ5je3XFYKwkvcE5D.D35lls5iF(10250, iFZ5je3XFYKwkvcE5D.N06TeK0ao), null, [AsyncStateMachine(typeof(_003C_003Ec__DisplayClass37_0.EGPxB3bv4QVlAj05mr))] () =>
			{
				_003C_003Ec__DisplayClass37_0.EGPxB3bv4QVlAj05mr stateMachine = default(_003C_003Ec__DisplayClass37_0.EGPxB3bv4QVlAj05mr);
				stateMachine.gjUQflsgGS = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
				stateMachine.GpKQKfgnBV = CS_0024_003C_003E8__locals4;
				stateMachine.VRQQSYWVRs = -1;
				stateMachine.gjUQflsgGS.Start(ref stateMachine);
			});
		}
	}

	public ICommand AddToFavoriteCommand
	{
		[CompilerGenerated]
		get
		{
			return rWEdITg2tC;
		}
		[CompilerGenerated]
		set
		{
			rWEdITg2tC = value;
		}
	}

	public MoviesViewModel()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		y8UdvHw9x7 = SortOrder.Desc;
		fRZdWywwky = MovieSort.ActivateDate;
		base._002Ector();
		jFvDzZv6v1 = AppContainer.Resolve<IMovieService>();
		Q9mdckuSg8 = AppContainer.Resolve<IAppService>();
		base.FetchMoreDataCommand = new AsyncCommand(OnFetchMoreDataCommand);
		base.SearchQuery = new ApiQuery<MovieSearch, MovieSort>
		{
			Count = 25,
			Search = new MovieSearch()
		};
		vHeUMF4NGkVoEBjY3MQ.D35lls5iF(this, new List<MovieSort>
		{
			MovieSort.ActivateDate,
			MovieSort.Name,
			MovieSort.Hot,
			MovieSort.Rating,
			MovieSort.ReleaseYear,
			MovieSort.WatchCount,
			MovieSort.Random
		}, vHeUMF4NGkVoEBjY3MQ.V3r4O4Q2vi);
		base.TotalCount = -1;
		Q3OeRSTq6SNsAFQUUoG.D35lls5iF(this, new AsyncCommand<MovieResponseDto>(t2FDlhWsTl), Q3OeRSTq6SNsAFQUUoG.fsJ4uahKpV);
	}

	[AsyncStateMachine(typeof(_003CLoadCategories_003Ed__43))]
	public Task LoadCategories()
	{
		_003CLoadCategories_003Ed__43 stateMachine = default(_003CLoadCategories_003Ed__43);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	[AsyncStateMachine(typeof(_003CLoadLanguages_003Ed__44))]
	public Task LoadLanguages()
	{
		_003CLoadLanguages_003Ed__44 stateMachine = default(_003CLoadLanguages_003Ed__44);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	[AsyncStateMachine(typeof(_003CLoadMovies_003Ed__45))]
	public Task LoadMovies()
	{
		_003CLoadMovies_003Ed__45 stateMachine = default(_003CLoadMovies_003Ed__45);
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

	[AsyncStateMachine(typeof(_003CLoadMoviesAfterSearch_003Ed__47))]
	public Task LoadMoviesAfterSearch()
	{
		_003CLoadMoviesAfterSearch_003Ed__47 stateMachine = default(_003CLoadMoviesAfterSearch_003Ed__47);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	[AsyncStateMachine(typeof(_003COnFetchMoreDataCommand_003Ed__48))]
	protected Task OnFetchMoreDataCommand()
	{
		_003COnFetchMoreDataCommand_003Ed__48 stateMachine = default(_003COnFetchMoreDataCommand_003Ed__48);
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

	[AsyncStateMachine(typeof(_003CAddMoreItems_003Ed__50))]
	public override Task AddMoreItems()
	{
		_003CAddMoreItems_003Ed__50 stateMachine = default(_003CAddMoreItems_003Ed__50);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	[AsyncStateMachine(typeof(_003CGoToPage_003Ed__51))]
	public override Task GoToPage(MovieResponseDto model)
	{
		_003CGoToPage_003Ed__51 stateMachine = default(_003CGoToPage_003Ed__51);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine.model = model;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	public override void OnLoading()
	{
		xLO56JniGyickVjO1Ot.D35lls5iF(this, xLO56JniGyickVjO1Ot.gxH4PZWM7e);
		if (!base.Items.Any())
		{
			Task task = LoadAsync();
			Action<Exception> action = null;
			bool flag = false;
			gBlEqv8jRKikCj2DMZp.D35lls5iF(task, ref action, ref flag, gBlEqv8jRKikCj2DMZp.pSp8ymt8Mu);
		}
	}

	[AsyncStateMachine(typeof(_003CLoadAsync_003Ed__53))]
	public override Task LoadAsync()
	{
		_003CLoadAsync_003Ed__53 stateMachine = default(_003CLoadAsync_003Ed__53);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	[AsyncStateMachine(typeof(_003COnAddToFavoriteCommandExcute_003Ed__54))]
	private Task t2FDlhWsTl(MovieResponseDto P_0)
	{
		_003COnAddToFavoriteCommandExcute_003Ed__54 stateMachine = default(_003COnAddToFavoriteCommandExcute_003Ed__54);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine.arg = P_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	[AsyncStateMachine(typeof(_003CAddMovies_003Ed__55))]
	private Task RVhDUS2Umj()
	{
		_003CAddMovies_003Ed__55 stateMachine = default(_003CAddMovies_003Ed__55);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	[CompilerGenerated]
	[AsyncStateMachine(typeof(_003C_003CAddMoreItems_003Eb__50_1_003Ed))]
	private Task Ml2DLxT41y()
	{
		_003C_003CAddMoreItems_003Eb__50_1_003Ed stateMachine = default(_003C_003CAddMoreItems_003Eb__50_1_003Ed);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	[AsyncStateMachine(typeof(_003C_003CLoadAsync_003Eb__53_1_003Ed))]
	[CompilerGenerated]
	private Task ThED2Fp9uO()
	{
		_003C_003CLoadAsync_003Eb__53_1_003Ed stateMachine = default(_003C_003CLoadAsync_003Eb__53_1_003Ed);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}
}
