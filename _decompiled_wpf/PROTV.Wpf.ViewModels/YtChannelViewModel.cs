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
using System.Windows.Input;
using PROTV.Abstractions.Common;
using PROTV.Abstractions.DataTransferObjects;
using PROTV.Abstractions.Helpers;
using PROTV.Abstractions.Search;
using PROTV.Abstractions.Services;
using PROTV.Wpf.Bootstrap;

namespace PROTV.Wpf.ViewModels;

public class YtChannelViewModel : BaseViewModel
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass28_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct iqUK36j48FG3JxTERkh : IAsyncStateMachine
		{
			public int OMf5TEkH1I;

			public AsyncTaskMethodBuilder fC95Zo2h4w;

			public _003C_003Ec__DisplayClass28_0 Wth5tRO5Ks;

			private YtVideoPlayerViewModel zHe5SlbGAG;

			private Page uV15f6lH1o;

			private TaskAwaiter<ResponseList<YTVideoResponseDto>> zY15K7RUxP;

			private TaskAwaiter B285kLxYYH;

			private void MoveNext()
			{
				int num = OMf5TEkH1I;
				_003C_003Ec__DisplayClass28_0 obj = Wth5tRO5Ks;
				try
				{
					_ = 2;
					try
					{
						TaskAwaiter<ResponseList<YTVideoResponseDto>> awaiter2;
						TaskAwaiter awaiter;
						Page page;
						ResponseList<YTVideoResponseDto> result;
						ObservableCollection<YTVideoResponseDto> observableCollection;
						IEnumerator<YTVideoResponseDto> enumerator;
						switch (num)
						{
						default:
						{
							IYoutubeService ytC0ae2RMf = obj.N3KKNI68wJ.YtC0ae2RMf;
							ApiQuery<YTSearch, YTVideoSort> apiQuery = new ApiQuery<YTSearch, YTVideoSort>();
							YTSearch yTSearch = new YTSearch();
							wuXoja6xGA4YsTL6UdU.D35lls5iF(yTSearch, lVnioXU659dV87DBnh4.D35lls5iF(obj.h6uKMr3PJO, lVnioXU659dV87DBnh4.D9ccMUK7Kh), wuXoja6xGA4YsTL6UdU.kTgcS3VtCh);
							apiQuery.Search = yTSearch;
							apiQuery.Sort = YTVideoSort.Index;
							apiQuery.Order = SortOrder.Asc;
							apiQuery.Count = -1;
							awaiter2 = CCsbDQUN65g5h7XQhOJ.D35lls5iF(ytC0ae2RMf, apiQuery, CCsbDQUN65g5h7XQhOJ.VXMUOJY7xk).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num = (OMf5TEkH1I = 0);
								zY15K7RUxP = awaiter2;
								fC95Zo2h4w.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
							goto IL_00d7;
						}
						case 0:
							awaiter2 = zY15K7RUxP;
							zY15K7RUxP = default(TaskAwaiter<ResponseList<YTVideoResponseDto>>);
							num = (OMf5TEkH1I = -1);
							goto IL_00d7;
						case 1:
							awaiter = B285kLxYYH;
							B285kLxYYH = default(TaskAwaiter);
							num = (OMf5TEkH1I = -1);
							goto IL_01b6;
						case 2:
							{
								awaiter = B285kLxYYH;
								B285kLxYYH = default(TaskAwaiter);
								num = (OMf5TEkH1I = -1);
								break;
							}
							IL_01b6:
							oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
							page = new Page();
							KBhlAv9D2TgBJ1kkc0B.D35lls5iF(page, IyGDDwHBiPv8vfOFJDF.D35lls5iF(ApplicationPage.YoutubePlayer, zHe5SlbGAG, IyGDDwHBiPv8vfOFJDF.hivH0XYhaE), KBhlAv9D2TgBJ1kkc0B.fWUHrWO7Sa);
							qni3xrDkAJ3vF35eMav.D35lls5iF(page, EBgwuVHeVLDJVVfMaAk.D35lls5iF(ApplicationPage.YoutubePlayer, EBgwuVHeVLDJVVfMaAk.mtcHG3MEy3), qni3xrDkAJ3vF35eMav.Ra7HRFTvnD);
							uV15f6lH1o = page;
							awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(pvrKKy8Mk1kpdmIfp3A.D35lls5iF(5, pvrKKy8Mk1kpdmIfp3A.aVh8SPrFkE), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
							if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
							{
								num = (OMf5TEkH1I = 2);
								B285kLxYYH = awaiter;
								fC95Zo2h4w.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							break;
							IL_00d7:
							result = awaiter2.GetResult();
							zHe5SlbGAG = new YtVideoPlayerViewModel();
							observableCollection = new ObservableCollection<YTVideoResponseDto>();
							enumerator = result.Data.Result.GetEnumerator();
							try
							{
								while (hjMnupQVVDlRZAYQJC.D35lls5iF(enumerator, hjMnupQVVDlRZAYQJC.QV1TFwytOj))
								{
									YTVideoResponseDto current = enumerator.Current;
									observableCollection.Add(current);
								}
							}
							finally
							{
								if (num < 0 && enumerator != null)
								{
									xLO56JniGyickVjO1Ot.D35lls5iF(enumerator, xLO56JniGyickVjO1Ot.ydbT2bsoH4);
								}
							}
							awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(xAAOHZUbtAXo3rUUbhP.D35lls5iF(zHe5SlbGAG, observableCollection, xAAOHZUbtAXo3rUUbhP.UuZUWjAJBs), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
							if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
							{
								num = (OMf5TEkH1I = 1);
								B285kLxYYH = awaiter;
								fC95Zo2h4w.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_01b6;
						}
						oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
						GmMLaTD7kV8rq88ZFvR.D35lls5iF(Xlypb0Hnr2C3ydrYEdG.D35lls5iF(AppContainer.Resolve<HomeViewModel>(), Xlypb0Hnr2C3ydrYEdG.U3Z1IKMGuZ), uV15f6lH1o, GmMLaTD7kV8rq88ZFvR.iMJHkmaaRY);
						zHe5SlbGAG = null;
						uV15f6lH1o = null;
					}
					catch
					{
					}
				}
				catch (Exception ex)
				{
					OMf5TEkH1I = -2;
					NNK1eXA7fWQ87oSUty7.D35lls5iF(ref fC95Zo2h4w, ex, NNK1eXA7fWQ87oSUty7.G3EAcW9Om7);
					return;
				}
				OMf5TEkH1I = -2;
				meFicnAMHIVtdhf671p.D35lls5iF(ref fC95Zo2h4w, meFicnAMHIVtdhf671p.bsDASenQ5I);
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine P_0)
			{
				vxBFJcAKZoecNtbdqxt.D35lls5iF(ref fC95Zo2h4w, P_0, vxBFJcAKZoecNtbdqxt.tuxANdhu18);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine P_0)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(P_0);
			}
		}

		[StructLayout(LayoutKind.Auto)]
		private struct hFHMehjB4suZSYl7yxJ : IAsyncStateMachine
		{
			public int jCZ581k8WR;

			public AsyncVoidMethodBuilder u8X5QyfEC4;

			public _003C_003Ec__DisplayClass28_0 PTU5nNoWdB;

			private TaskAwaiter ONh5bPjIME;

			private void MoveNext()
			{
				int num = jCZ581k8WR;
				_003C_003Ec__DisplayClass28_0 CS_0024_003C_003E8__locals3 = PTU5nNoWdB;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(W7S2sip6SDieZFVsNbd.D35lls5iF(CS_0024_003C_003E8__locals3.N3KKNI68wJ, Expression.Lambda<Func<bool>>(OWBKr5pvc5MWsK1OMtR.D35lls5iF(o4bYL4peNeC2wWb8yjx.D35lls5iF(CS_0024_003C_003E8__locals3.N3KKNI68wJ, sjYxHO8OWlc6X80hFj7.D35lls5iF(typeof(YtChannelViewModel).TypeHandle, sjYxHO8OWlc6X80hFj7.uWZ8ugU7r5), o4bYL4peNeC2wWb8yjx.oVdpGKjy2x), (MethodInfo)f5q427pRQZnrEKPy4Ws.D35lls5iF((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, f5q427pRQZnrEKPy4Ws.Bo9pk3m4k7), OWBKr5pvc5MWsK1OMtR.fZIpAAdi1v), Array.Empty<ParameterExpression>()), [AsyncStateMachine(typeof(iqUK36j48FG3JxTERkh))] () =>
						{
							iqUK36j48FG3JxTERkh stateMachine = default(iqUK36j48FG3JxTERkh);
							stateMachine.fC95Zo2h4w = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
							stateMachine.Wth5tRO5Ks = CS_0024_003C_003E8__locals3;
							stateMachine.OMf5TEkH1I = -1;
							stateMachine.fC95Zo2h4w.Start(ref stateMachine);
							return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine.fC95Zo2h4w, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
						}, W7S2sip6SDieZFVsNbd.XWappgVyfh), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
						if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
						{
							num = (jCZ581k8WR = 0);
							ONh5bPjIME = awaiter;
							u8X5QyfEC4.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = ONh5bPjIME;
						ONh5bPjIME = default(TaskAwaiter);
						num = (jCZ581k8WR = -1);
					}
					oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
				}
				catch (Exception ex)
				{
					jCZ581k8WR = -2;
					N2XUglA3neBsnlZfRPQ.D35lls5iF(ref u8X5QyfEC4, ex, N2XUglA3neBsnlZfRPQ.l4pATRumoW);
					return;
				}
				jCZ581k8WR = -2;
				T4XmPoA4VNJJP1afcgL.D35lls5iF(ref u8X5QyfEC4, T4XmPoA4VNJJP1afcgL.TRyALZckCh);
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine P_0)
			{
				dHWo7jAEn6E4X7bsY4R.D35lls5iF(ref u8X5QyfEC4, P_0, dHWo7jAEn6E4X7bsY4R.z3hAB6UZ9o);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine P_0)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(P_0);
			}
		}

		public YtChannelViewModel N3KKNI68wJ;

		public YTPlaylisTResponseDto h6uKMr3PJO;

		public Func<Task> HEjKC04cFD;

		public _003C_003Ec__DisplayClass28_0()
		{
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
			base._002Ector();
		}

		[AsyncStateMachine(typeof(hFHMehjB4suZSYl7yxJ))]
		internal void BpGKuZqMT1()
		{
			hFHMehjB4suZSYl7yxJ stateMachine = default(hFHMehjB4suZSYl7yxJ);
			stateMachine.u8X5QyfEC4 = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
			stateMachine.PTU5nNoWdB = this;
			stateMachine.jCZ581k8WR = -1;
			stateMachine.u8X5QyfEC4.Start(ref stateMachine);
		}

		[AsyncStateMachine(typeof(iqUK36j48FG3JxTERkh))]
		internal Task F0BKAw2O5L()
		{
			iqUK36j48FG3JxTERkh stateMachine = default(iqUK36j48FG3JxTERkh);
			stateMachine.fC95Zo2h4w = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
			stateMachine.Wth5tRO5Ks = this;
			stateMachine.OMf5TEkH1I = -1;
			stateMachine.fC95Zo2h4w.Start(ref stateMachine);
			return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine.fC95Zo2h4w, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass31_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct S75fKYjDOLWKEY3RKIY : IAsyncStateMachine
		{
			public int XxL57NyeHm;

			public AsyncVoidMethodBuilder Ppb55NFuJr;

			public _003C_003Ec__DisplayClass31_0 HVO5uIf1LD;

			private YtVideoPlayerViewModel bw45ARpL6Q;

			private Page Xfg5Ny8sd5;

			private TaskAwaiter k3x5MbKPvW;

			private void MoveNext()
			{
				int num = XxL57NyeHm;
				_003C_003Ec__DisplayClass31_0 obj = HVO5uIf1LD;
				try
				{
					_ = 1;
					try
					{
						TaskAwaiter awaiter;
						if (num != 0)
						{
							if (num == 1)
							{
								awaiter = k3x5MbKPvW;
								k3x5MbKPvW = default(TaskAwaiter);
								num = (XxL57NyeHm = -1);
								goto IL_0154;
							}
							bw45ARpL6Q = new YtVideoPlayerViewModel();
							awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(hnVdJ7tlwwTQvJJ7Vha.D35lls5iF(bw45ARpL6Q, obj.lNwKFZkUmQ, hnVdJ7tlwwTQvJJ7Vha.oXrt9biorg), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
							if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
							{
								num = (XxL57NyeHm = 0);
								k3x5MbKPvW = awaiter;
								Ppb55NFuJr.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = k3x5MbKPvW;
							k3x5MbKPvW = default(TaskAwaiter);
							num = (XxL57NyeHm = -1);
						}
						oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
						Page page = new Page();
						KBhlAv9D2TgBJ1kkc0B.D35lls5iF(page, IyGDDwHBiPv8vfOFJDF.D35lls5iF(ApplicationPage.YoutubePlayer, bw45ARpL6Q, IyGDDwHBiPv8vfOFJDF.hivH0XYhaE), KBhlAv9D2TgBJ1kkc0B.fWUHrWO7Sa);
						qni3xrDkAJ3vF35eMav.D35lls5iF(page, EBgwuVHeVLDJVVfMaAk.D35lls5iF(ApplicationPage.YoutubePlayer, EBgwuVHeVLDJVVfMaAk.mtcHG3MEy3), qni3xrDkAJ3vF35eMav.Ra7HRFTvnD);
						Xfg5Ny8sd5 = page;
						awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(pvrKKy8Mk1kpdmIfp3A.D35lls5iF(5, pvrKKy8Mk1kpdmIfp3A.aVh8SPrFkE), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
						if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
						{
							num = (XxL57NyeHm = 1);
							k3x5MbKPvW = awaiter;
							Ppb55NFuJr.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_0154;
						IL_0154:
						oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
						GmMLaTD7kV8rq88ZFvR.D35lls5iF(Xlypb0Hnr2C3ydrYEdG.D35lls5iF(AppContainer.Resolve<HomeViewModel>(), Xlypb0Hnr2C3ydrYEdG.U3Z1IKMGuZ), Xfg5Ny8sd5, GmMLaTD7kV8rq88ZFvR.iMJHkmaaRY);
						bw45ARpL6Q = null;
						Xfg5Ny8sd5 = null;
					}
					catch
					{
					}
				}
				catch (Exception ex)
				{
					XxL57NyeHm = -2;
					N2XUglA3neBsnlZfRPQ.D35lls5iF(ref Ppb55NFuJr, ex, N2XUglA3neBsnlZfRPQ.l4pATRumoW);
					return;
				}
				XxL57NyeHm = -2;
				T4XmPoA4VNJJP1afcgL.D35lls5iF(ref Ppb55NFuJr, T4XmPoA4VNJJP1afcgL.TRyALZckCh);
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine P_0)
			{
				dHWo7jAEn6E4X7bsY4R.D35lls5iF(ref Ppb55NFuJr, P_0, dHWo7jAEn6E4X7bsY4R.z3hAB6UZ9o);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine P_0)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(P_0);
			}
		}

		public YTVideoResponseDto lNwKFZkUmQ;

		public _003C_003Ec__DisplayClass31_0()
		{
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
			base._002Ector();
		}

		[AsyncStateMachine(typeof(S75fKYjDOLWKEY3RKIY))]
		internal void T0SKYc1d9s()
		{
			S75fKYjDOLWKEY3RKIY stateMachine = default(S75fKYjDOLWKEY3RKIY);
			stateMachine.Ppb55NFuJr = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
			stateMachine.HVO5uIf1LD = this;
			stateMachine.XxL57NyeHm = -1;
			stateMachine.Ppb55NFuJr.Start(ref stateMachine);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnToggleSubscribeCommandExcute_003Ed__38 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public YtChannelViewModel _003C_003E4__this;

		private TaskAwaiter<bool> _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			YtChannelViewModel ytChannelViewModel = _003C_003E4__this;
			try
			{
				TaskAwaiter<bool> awaiter;
				if (num != 0)
				{
					awaiter = VbmtIFmnFwg9sqb4Jje.D35lls5iF(ytChannelViewModel.YtC0ae2RMf, lVnioXU659dV87DBnh4.D35lls5iF(UTafF6Uv3ZuXj8lB01O.D35lls5iF(ytChannelViewModel, UTafF6Uv3ZuXj8lB01O.fudUAXZj9H), lVnioXU659dV87DBnh4.e5HUphuY6U), VbmtIFmnFwg9sqb4Jje.VrEUwIrPIA).GetAwaiter();
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
					jPB9Q5LdIM9wsuWV1q7.D35lls5iF(UTafF6Uv3ZuXj8lB01O.D35lls5iF(ytChannelViewModel, UTafF6Uv3ZuXj8lB01O.fudUAXZj9H), !LsA6RHpKkbdnOn3fX60.D35lls5iF(UTafF6Uv3ZuXj8lB01O.D35lls5iF(ytChannelViewModel, UTafF6Uv3ZuXj8lB01O.fudUAXZj9H), LsA6RHpKkbdnOn3fX60.L6TUCQQP70), jPB9Q5LdIM9wsuWV1q7.BjpUmpIPZ1);
					m5sZxWmLHUhVHrJe8sC.D35lls5iF(UTafF6Uv3ZuXj8lB01O.D35lls5iF(ytChannelViewModel, UTafF6Uv3ZuXj8lB01O.fudUAXZj9H), iFZ5je3XFYKwkvcE5D.D35lls5iF(16620, iFZ5je3XFYKwkvcE5D.N06TeK0ao), m5sZxWmLHUhVHrJe8sC.rA9Uanhorr);
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
	private struct _003COnWatchLaterCommandExcute_003Ed__39 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public YtChannelViewModel _003C_003E4__this;

		public YTVideoResponseDto obj;

		private TaskAwaiter<bool> _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			YtChannelViewModel ytChannelViewModel = _003C_003E4__this;
			try
			{
				TaskAwaiter<bool> awaiter;
				if (num != 0)
				{
					awaiter = VbmtIFmnFwg9sqb4Jje.D35lls5iF(ytChannelViewModel.YtC0ae2RMf, m9MGZR7k2RmVqYXYS5.D35lls5iF(obj, m9MGZR7k2RmVqYXYS5.r6tnXN0WTV), VbmtIFmnFwg9sqb4Jje.i4xUIaDACp).GetAwaiter();
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
	private struct _003CLoadAsync_003Ed__40 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public YtChannelViewModel _003C_003E4__this;

		public int channelId;

		private ResponseList<YTVideoResponseDto> _003Cresult_003E5__2;

		private TaskAwaiter<YTChannelResponseDto> _003C_003Eu__1;

		private TaskAwaiter<ResponseList<YTVideoResponseDto>> _003C_003Eu__2;

		private IEnumerator<YTVideoResponseDto> _003C_003E7__wrap2;

		private YTVideoResponseDto _003Citem_003E5__4;

		private TaskAwaiter _003C_003Eu__3;

		private TaskAwaiter<List<YTPlaylisTResponseDto>> _003C_003Eu__4;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			YtChannelViewModel ytChannelViewModel = _003C_003E4__this;
			try
			{
				_ = 3;
				try
				{
					TaskAwaiter<YTChannelResponseDto> awaiter3;
					TaskAwaiter<ResponseList<YTVideoResponseDto>> awaiter2;
					TaskAwaiter<List<YTPlaylisTResponseDto>> awaiter;
					IYoutubeService ytC0ae2RMf;
					ApiQuery<YTSearch, GeneralSort> apiQuery;
					YTSearch yTSearch;
					YTChannelResponseDto result;
					ResponseList<YTVideoResponseDto> result2;
					switch (num)
					{
					default:
						awaiter3 = WsnspBUtrWmRdecXg4q.D35lls5iF(ytChannelViewModel.YtC0ae2RMf, channelId, WsnspBUtrWmRdecXg4q.At7UVUTeqb).GetAwaiter();
						if (!awaiter3.IsCompleted)
						{
							num = (_003C_003E1__state = 0);
							_003C_003Eu__1 = awaiter3;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
							return;
						}
						goto IL_009a;
					case 0:
						awaiter3 = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter<YTChannelResponseDto>);
						num = (_003C_003E1__state = -1);
						goto IL_009a;
					case 1:
						awaiter2 = _003C_003Eu__2;
						_003C_003Eu__2 = default(TaskAwaiter<ResponseList<YTVideoResponseDto>>);
						num = (_003C_003E1__state = -1);
						goto IL_0153;
					case 2:
						try
						{
							if (num != 2)
							{
								goto IL_024a;
							}
							TaskAwaiter awaiter4 = _003C_003Eu__3;
							_003C_003Eu__3 = default(TaskAwaiter);
							num = (_003C_003E1__state = -1);
							goto IL_0221;
							IL_0221:
							oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter4, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
							JlIYJZ0CldXxH4xu6mG.D35lls5iF(ytChannelViewModel, JlIYJZ0CldXxH4xu6mG.DdI0mGFTvr).Add(_003Citem_003E5__4);
							_003Citem_003E5__4 = null;
							goto IL_024a;
							IL_024a:
							if (hjMnupQVVDlRZAYQJC.D35lls5iF(_003C_003E7__wrap2, hjMnupQVVDlRZAYQJC.QV1TFwytOj))
							{
								_003Citem_003E5__4 = _003C_003E7__wrap2.Current;
								awaiter4 = QliBEUviwWqgtMcBndV.D35lls5iF(pvrKKy8Mk1kpdmIfp3A.D35lls5iF(2, pvrKKy8Mk1kpdmIfp3A.aVh8SPrFkE), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
								if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter4, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
								{
									num = (_003C_003E1__state = 2);
									_003C_003Eu__3 = awaiter4;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
									return;
								}
								goto IL_0221;
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
						vQKA0r9sJ1kArsIHc16.D35lls5iF(ytChannelViewModel, _003Cresult_003E5__2.Data.Total, vQKA0r9sJ1kArsIHc16.vYlUuNDYZP);
						goto IL_02ba;
					case 3:
						{
							awaiter = _003C_003Eu__4;
							_003C_003Eu__4 = default(TaskAwaiter<List<YTPlaylisTResponseDto>>);
							num = (_003C_003E1__state = -1);
							break;
						}
						IL_02ba:
						ytC0ae2RMf = ytChannelViewModel.YtC0ae2RMf;
						apiQuery = new ApiQuery<YTSearch, GeneralSort>();
						yTSearch = new YTSearch();
						wuXoja6xGA4YsTL6UdU.D35lls5iF(yTSearch, channelId, wuXoja6xGA4YsTL6UdU.Q2DUKEmlBL);
						apiQuery.Search = yTSearch;
						apiQuery.Count = -1;
						awaiter = DEbUGDUPfxc2ghthAEb.D35lls5iF(ytC0ae2RMf, apiQuery, DEbUGDUPfxc2ghthAEb.RYYUswTHCZ).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (_003C_003E1__state = 3);
							_003C_003Eu__4 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						break;
						IL_009a:
						result = awaiter3.GetResult();
						u4s0DZU7WbRdrbaHjVZ.D35lls5iF(ytChannelViewModel, result, u4s0DZU7WbRdrbaHjVZ.yvxUcRpIRD);
						wuXoja6xGA4YsTL6UdU.D35lls5iF(YUTYM9UMFn7SnnVoKxr.D35lls5iF(ytChannelViewModel, YUTYM9UMFn7SnnVoKxr.ANtUSXfAH3).Search, channelId, wuXoja6xGA4YsTL6UdU.Q2DUKEmlBL);
						YUTYM9UMFn7SnnVoKxr.D35lls5iF(ytChannelViewModel, YUTYM9UMFn7SnnVoKxr.ANtUSXfAH3).Page = 1;
						awaiter2 = CCsbDQUN65g5h7XQhOJ.D35lls5iF(ytChannelViewModel.YtC0ae2RMf, YUTYM9UMFn7SnnVoKxr.D35lls5iF(ytChannelViewModel, YUTYM9UMFn7SnnVoKxr.ANtUSXfAH3), CCsbDQUN65g5h7XQhOJ.VXMUOJY7xk).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = (_003C_003E1__state = 1);
							_003C_003Eu__2 = awaiter2;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						}
						goto IL_0153;
						IL_0153:
						result2 = awaiter2.GetResult();
						_003Cresult_003E5__2 = result2;
						if (_003Cresult_003E5__2 != null && _003Cresult_003E5__2.Status)
						{
							_003C_003E7__wrap2 = _003Cresult_003E5__2.Data.Result.GetEnumerator();
							goto case 2;
						}
						vQKA0r9sJ1kArsIHc16.D35lls5iF(ytChannelViewModel, 0, vQKA0r9sJ1kArsIHc16.vYlUuNDYZP);
						goto IL_02ba;
					}
					List<YTPlaylisTResponseDto> result3 = awaiter.GetResult();
					if (result3 != null)
					{
						yBZsGhUhgP7lr71Fofj.D35lls5iF(UTafF6Uv3ZuXj8lB01O.D35lls5iF(ytChannelViewModel, UTafF6Uv3ZuXj8lB01O.fudUAXZj9H), result3.ToList(), yBZsGhUhgP7lr71Fofj.GVhUxghr6E);
						m5sZxWmLHUhVHrJe8sC.D35lls5iF(UTafF6Uv3ZuXj8lB01O.D35lls5iF(ytChannelViewModel, UTafF6Uv3ZuXj8lB01O.fudUAXZj9H), iFZ5je3XFYKwkvcE5D.D35lls5iF(16644, iFZ5je3XFYKwkvcE5D.N06TeK0ao), m5sZxWmLHUhVHrJe8sC.rA9Uanhorr);
					}
					_003Cresult_003E5__2 = null;
				}
				catch
				{
					vQKA0r9sJ1kArsIHc16.D35lls5iF(ytChannelViewModel, 0, vQKA0r9sJ1kArsIHc16.vYlUuNDYZP);
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
	private struct _003COnFetchMoreDataCommandExcute_003Ed__48 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public YtChannelViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			YtChannelViewModel CS_0024_003C_003E8__locals3 = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(W7S2sip6SDieZFVsNbd.D35lls5iF(CS_0024_003C_003E8__locals3, Expression.Lambda<Func<bool>>(OWBKr5pvc5MWsK1OMtR.D35lls5iF(o4bYL4peNeC2wWb8yjx.D35lls5iF(CS_0024_003C_003E8__locals3, sjYxHO8OWlc6X80hFj7.D35lls5iF(typeof(YtChannelViewModel).TypeHandle, sjYxHO8OWlc6X80hFj7.uWZ8ugU7r5), o4bYL4peNeC2wWb8yjx.oVdpGKjy2x), (MethodInfo)f5q427pRQZnrEKPy4Ws.D35lls5iF((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, f5q427pRQZnrEKPy4Ws.Bo9pk3m4k7), OWBKr5pvc5MWsK1OMtR.fZIpAAdi1v), Array.Empty<ParameterExpression>()), [AsyncStateMachine(typeof(_003C_003COnFetchMoreDataCommandExcute_003Eb__48_1_003Ed))] () =>
					{
						_003C_003COnFetchMoreDataCommandExcute_003Eb__48_1_003Ed stateMachine = default(_003C_003COnFetchMoreDataCommandExcute_003Eb__48_1_003Ed);
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
	private struct _003C_003COnFetchMoreDataCommandExcute_003Eb__48_1_003Ed : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public YtChannelViewModel _003C_003E4__this;

		private ResponseList<YTVideoResponseDto> _003Cresult_003E5__2;

		private TaskAwaiter<ResponseList<YTVideoResponseDto>> _003C_003Eu__1;

		private IEnumerator<YTVideoResponseDto> _003C_003E7__wrap2;

		private YTVideoResponseDto _003Citem_003E5__4;

		private TaskAwaiter _003C_003Eu__2;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			YtChannelViewModel ytChannelViewModel = _003C_003E4__this;
			try
			{
				if ((uint)num <= 1u || JlIYJZ0CldXxH4xu6mG.D35lls5iF(ytChannelViewModel, JlIYJZ0CldXxH4xu6mG.DdI0mGFTvr).Count != lVnioXU659dV87DBnh4.D35lls5iF(ytChannelViewModel, lVnioXU659dV87DBnh4.JIiUYXGLUi))
				{
					try
					{
						TaskAwaiter<ResponseList<YTVideoResponseDto>> awaiter;
						if (num != 0)
						{
							if (num == 1)
							{
								goto IL_0119;
							}
							YUTYM9UMFn7SnnVoKxr.D35lls5iF(ytChannelViewModel, YUTYM9UMFn7SnnVoKxr.ANtUSXfAH3).Page++;
							awaiter = CCsbDQUN65g5h7XQhOJ.D35lls5iF(ytChannelViewModel.YtC0ae2RMf, YUTYM9UMFn7SnnVoKxr.D35lls5iF(ytChannelViewModel, YUTYM9UMFn7SnnVoKxr.ANtUSXfAH3), CCsbDQUN65g5h7XQhOJ.VXMUOJY7xk).GetAwaiter();
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
							_003C_003Eu__1 = default(TaskAwaiter<ResponseList<YTVideoResponseDto>>);
							num = (_003C_003E1__state = -1);
						}
						ResponseList<YTVideoResponseDto> result = awaiter.GetResult();
						_003Cresult_003E5__2 = result;
						if (_003Cresult_003E5__2 != null && _003Cresult_003E5__2.Status)
						{
							_003C_003E7__wrap2 = _003Cresult_003E5__2.Data.Result.GetEnumerator();
							goto IL_0119;
						}
						goto IL_0227;
						IL_0119:
						try
						{
							if (num != 1)
							{
								goto IL_01c8;
							}
							TaskAwaiter awaiter2 = _003C_003Eu__2;
							_003C_003Eu__2 = default(TaskAwaiter);
							num = (_003C_003E1__state = -1);
							goto IL_019f;
							IL_019f:
							oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter2, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
							JlIYJZ0CldXxH4xu6mG.D35lls5iF(ytChannelViewModel, JlIYJZ0CldXxH4xu6mG.DdI0mGFTvr).Add(_003Citem_003E5__4);
							_003Citem_003E5__4 = null;
							goto IL_01c8;
							IL_01c8:
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
								goto IL_019f;
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
						vQKA0r9sJ1kArsIHc16.D35lls5iF(ytChannelViewModel, _003Cresult_003E5__2.Data.Total, vQKA0r9sJ1kArsIHc16.vYlUuNDYZP);
						goto IL_0227;
						IL_0227:
						_003Cresult_003E5__2 = null;
					}
					catch
					{
					}
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

	[CompilerGenerated]
	private ObservableCollection<YTVideoResponseDto> Pgs0Wibinq;

	[CompilerGenerated]
	private ICommand fQn04kadL0;

	[CompilerGenerated]
	private ICommand vdI0BNH3nv;

	[CompilerGenerated]
	private ApiQuery<YTSearch, YTVideoSort> CMy0DnYso7;

	[CompilerGenerated]
	private ICommand sLD0dCY1nM;

	private YTPlaylisTResponseDto nZA0PQnJxF;

	private YTChannelResponseDto WE50qR3gEX;

	private YTVideoResponseDto AaC0IjjrH3;

	private int Y9C0VNPMfb;

	private readonly IYoutubeService YtC0ae2RMf;

	private int M1b0082f1s;

	public ObservableCollection<YTVideoResponseDto> Items
	{
		[CompilerGenerated]
		get
		{
			return Pgs0Wibinq;
		}
		[CompilerGenerated]
		set
		{
			Pgs0Wibinq = value;
		}
	}

	public YTChannelResponseDto YtChannel
	{
		get
		{
			return WE50qR3gEX;
		}
		set
		{
			SetProperty(ref WE50qR3gEX, value, iFZ5je3XFYKwkvcE5D.D35lls5iF(12330, iFZ5je3XFYKwkvcE5D.N06TeK0ao));
		}
	}

	public ICommand WatchLaterCommand
	{
		[CompilerGenerated]
		get
		{
			return fQn04kadL0;
		}
		[CompilerGenerated]
		set
		{
			fQn04kadL0 = value;
		}
	}

	public ICommand ToggleSubscribeCommand
	{
		[CompilerGenerated]
		get
		{
			return vdI0BNH3nv;
		}
		[CompilerGenerated]
		set
		{
			vdI0BNH3nv = value;
		}
	}

	public ApiQuery<YTSearch, YTVideoSort> Query
	{
		[CompilerGenerated]
		get
		{
			return CMy0DnYso7;
		}
		[CompilerGenerated]
		set
		{
			CMy0DnYso7 = value;
		}
	}

	public int TabSelectedindex
	{
		get
		{
			return Y9C0VNPMfb;
		}
		set
		{
			SetProperty(ref Y9C0VNPMfb, value, iFZ5je3XFYKwkvcE5D.D35lls5iF(8660, iFZ5je3XFYKwkvcE5D.N06TeK0ao));
		}
	}

	public ICommand FetchMoreDataCommand
	{
		[CompilerGenerated]
		get
		{
			return sLD0dCY1nM;
		}
		[CompilerGenerated]
		set
		{
			sLD0dCY1nM = value;
		}
	}

	public YTPlaylisTResponseDto SelectedPlaylist
	{
		get
		{
			return nZA0PQnJxF;
		}
		set
		{
			_003C_003Ec__DisplayClass28_0 CS_0024_003C_003E8__locals4 = new _003C_003Ec__DisplayClass28_0();
			CS_0024_003C_003E8__locals4.N3KKNI68wJ = this;
			CS_0024_003C_003E8__locals4.h6uKMr3PJO = value;
			SetProperty(ref nZA0PQnJxF, CS_0024_003C_003E8__locals4.h6uKMr3PJO, iFZ5je3XFYKwkvcE5D.D35lls5iF(12352, iFZ5je3XFYKwkvcE5D.N06TeK0ao), null, [AsyncStateMachine(typeof(_003C_003Ec__DisplayClass28_0.hFHMehjB4suZSYl7yxJ))] () =>
			{
				_003C_003Ec__DisplayClass28_0.hFHMehjB4suZSYl7yxJ stateMachine = default(_003C_003Ec__DisplayClass28_0.hFHMehjB4suZSYl7yxJ);
				stateMachine.u8X5QyfEC4 = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
				stateMachine.PTU5nNoWdB = CS_0024_003C_003E8__locals4;
				stateMachine.jCZ581k8WR = -1;
				stateMachine.u8X5QyfEC4.Start(ref stateMachine);
			});
		}
	}

	public YTVideoResponseDto SelectedVideo
	{
		get
		{
			return AaC0IjjrH3;
		}
		set
		{
			_003C_003Ec__DisplayClass31_0 CS_0024_003C_003E8__locals3 = new _003C_003Ec__DisplayClass31_0();
			CS_0024_003C_003E8__locals3.lNwKFZkUmQ = value;
			SetProperty(ref AaC0IjjrH3, CS_0024_003C_003E8__locals3.lNwKFZkUmQ, iFZ5je3XFYKwkvcE5D.D35lls5iF(12388, iFZ5je3XFYKwkvcE5D.N06TeK0ao), null, [AsyncStateMachine(typeof(_003C_003Ec__DisplayClass31_0.S75fKYjDOLWKEY3RKIY))] () =>
			{
				_003C_003Ec__DisplayClass31_0.S75fKYjDOLWKEY3RKIY stateMachine = default(_003C_003Ec__DisplayClass31_0.S75fKYjDOLWKEY3RKIY);
				stateMachine.Ppb55NFuJr = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
				stateMachine.HVO5uIf1LD = CS_0024_003C_003E8__locals3;
				stateMachine.XxL57NyeHm = -1;
				stateMachine.Ppb55NFuJr.Start(ref stateMachine);
			});
		}
	}

	public int WatchLaterCount
	{
		get
		{
			return M1b0082f1s;
		}
		set
		{
			SetProperty(ref M1b0082f1s, value, iFZ5je3XFYKwkvcE5D.D35lls5iF(12418, iFZ5je3XFYKwkvcE5D.N06TeK0ao));
		}
	}

	public YtChannelViewModel()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector();
		KFPqfXEA4bOmtrXTkLA.D35lls5iF(this, new AsyncCommand(WSd0jdDOZy), KFPqfXEA4bOmtrXTkLA.NRl0REDyTR);
		KFPqfXEA4bOmtrXTkLA.D35lls5iF(this, new AsyncCommand<YTVideoResponseDto>(yIe0cesdWw), KFPqfXEA4bOmtrXTkLA.h2P0kWBJTW);
		KFPqfXEA4bOmtrXTkLA.D35lls5iF(this, new AsyncCommand(bFpazijKoK), KFPqfXEA4bOmtrXTkLA.nV50vytxxs);
		GrZsQB0AMIG6FirGRJ9.D35lls5iF(this, new ObservableCollection<YTVideoResponseDto>(), GrZsQB0AMIG6FirGRJ9.Stf06kOQ9D);
		YtC0ae2RMf = AppContainer.Resolve<IYoutubeService>();
		RZf0CX0pnggYOrJ4nT7.D35lls5iF(this, new ApiQuery<YTSearch, YTVideoSort>
		{
			Search = new YTSearch()
		}, RZf0CX0pnggYOrJ4nT7.cVw0wIy8KX);
	}

	[AsyncStateMachine(typeof(_003COnToggleSubscribeCommandExcute_003Ed__38))]
	private Task bFpazijKoK()
	{
		_003COnToggleSubscribeCommandExcute_003Ed__38 stateMachine = default(_003COnToggleSubscribeCommandExcute_003Ed__38);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	[AsyncStateMachine(typeof(_003COnWatchLaterCommandExcute_003Ed__39))]
	private Task yIe0cesdWw(YTVideoResponseDto P_0)
	{
		_003COnWatchLaterCommandExcute_003Ed__39 stateMachine = default(_003COnWatchLaterCommandExcute_003Ed__39);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine.obj = P_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	[AsyncStateMachine(typeof(_003CLoadAsync_003Ed__40))]
	public Task LoadAsync(int channelId)
	{
		_003CLoadAsync_003Ed__40 stateMachine = default(_003CLoadAsync_003Ed__40);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine.channelId = channelId;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	public override void Dispose()
	{
	}

	public void Clean()
	{
		nZA0PQnJxF = null;
	}

	public void Clear()
	{
		Y9C0VNPMfb = 0;
		JlIYJZ0CldXxH4xu6mG.D35lls5iF(this, JlIYJZ0CldXxH4xu6mG.DdI0mGFTvr).Clear();
	}

	[AsyncStateMachine(typeof(_003COnFetchMoreDataCommandExcute_003Ed__48))]
	private Task WSd0jdDOZy()
	{
		_003COnFetchMoreDataCommandExcute_003Ed__48 stateMachine = default(_003COnFetchMoreDataCommandExcute_003Ed__48);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	[CompilerGenerated]
	[AsyncStateMachine(typeof(_003C_003COnFetchMoreDataCommandExcute_003Eb__48_1_003Ed))]
	private Task LPC0vWTJmf()
	{
		_003C_003COnFetchMoreDataCommandExcute_003Eb__48_1_003Ed stateMachine = default(_003C_003COnFetchMoreDataCommandExcute_003Eb__48_1_003Ed);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}
}
