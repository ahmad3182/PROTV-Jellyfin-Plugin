using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using PROTV.Abstractions.Common;
using PROTV.Abstractions.DataTransferObjects;
using PROTV.Abstractions.Search;
using PROTV.Abstractions.Services;
using PROTV.Wpf.Bootstrap;

namespace PROTV.Wpf.ViewModels;

public class MusicViewModel : BaseViewModel
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass21_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct Cuk8us7EvZTCkJcQMk : IAsyncStateMachine
		{
			public int bXtQ8VRJjF;

			public AsyncVoidMethodBuilder yeYQQljo4L;

			public _003C_003Ec__DisplayClass21_0 bklQnTSQJc;

			private TaskAwaiter NqmQbmMtDO;

			private void MoveNext()
			{
				int num = bXtQ8VRJjF;
				_003C_003Ec__DisplayClass21_0 obj = bklQnTSQJc;
				try
				{
					TaskAwaiter awaiter;
					HomeViewModel homeViewModel;
					SongSearch search;
					HomeViewModel homeViewModel2;
					PeopleSearch search2;
					HomeViewModel homeViewModel3;
					PlaylistSearch search3;
					switch (num)
					{
					default:
						vVrjdw73IXOSPm7hUTt.D35lls5iF(obj.qoCtxWy9sw, vVrjdw73IXOSPm7hUTt.cDSco07kxw);
						if (obj.PxdtyGHhUl == 0)
						{
							awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(dYjEE74JgcwklirUGbS.D35lls5iF(obj.qoCtxWy9sw, dYjEE74JgcwklirUGbS.mcV4bOXKdP).LoadAsync(), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
							if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
							{
								num = (bXtQ8VRJjF = 0);
								NqmQbmMtDO = awaiter;
								yeYQQljo4L.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_00b6;
						}
						if (obj.PxdtyGHhUl == 1)
						{
							awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(QRQY0D4ZAXiadEvDlxC.D35lls5iF(obj.qoCtxWy9sw, QRQY0D4ZAXiadEvDlxC.MJi4jRgZUY).LoadAsync(), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
							if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
							{
								num = (bXtQ8VRJjF = 1);
								NqmQbmMtDO = awaiter;
								yeYQQljo4L.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_01a3;
						}
						if (obj.PxdtyGHhUl == 2)
						{
							awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(EAYFcT45SkGYkIx9hLl.D35lls5iF(obj.qoCtxWy9sw, EAYFcT45SkGYkIx9hLl.WQv4zhZcir).LoadAsync(), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
							if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
							{
								num = (bXtQ8VRJjF = 2);
								NqmQbmMtDO = awaiter;
								yeYQQljo4L.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_0290;
						}
						if (obj.PxdtyGHhUl == 3)
						{
							awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(lZaMh14fefPS11redXv.D35lls5iF(obj.qoCtxWy9sw, lZaMh14fefPS11redXv.Jwb4FuY5HF).LoadAsync(), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
							if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
							{
								num = (bXtQ8VRJjF = 3);
								NqmQbmMtDO = awaiter;
								yeYQQljo4L.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							break;
						}
						goto end_IL_0015;
					case 0:
						awaiter = NqmQbmMtDO;
						NqmQbmMtDO = default(TaskAwaiter);
						num = (bXtQ8VRJjF = -1);
						goto IL_00b6;
					case 1:
						awaiter = NqmQbmMtDO;
						NqmQbmMtDO = default(TaskAwaiter);
						num = (bXtQ8VRJjF = -1);
						goto IL_01a3;
					case 2:
						awaiter = NqmQbmMtDO;
						NqmQbmMtDO = default(TaskAwaiter);
						num = (bXtQ8VRJjF = -1);
						goto IL_0290;
					case 3:
						{
							awaiter = NqmQbmMtDO;
							NqmQbmMtDO = default(TaskAwaiter);
							num = (bXtQ8VRJjF = -1);
							break;
						}
						IL_0290:
						oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
						HPaY7v4ahrafKGaWtLI.D35lls5iF(obj.qoCtxWy9sw, EAYFcT45SkGYkIx9hLl.D35lls5iF(obj.qoCtxWy9sw, EAYFcT45SkGYkIx9hLl.WQv4zhZcir), HPaY7v4ahrafKGaWtLI.dNQCg3eEIM);
						homeViewModel = AppContainer.Resolve<HomeViewModel>();
						search = EAYFcT45SkGYkIx9hLl.D35lls5iF(obj.qoCtxWy9sw, EAYFcT45SkGYkIx9hLl.WQv4zhZcir).SearchQuery.Search;
						qni3xrDkAJ3vF35eMav.D35lls5iF(homeViewModel, (search != null) ? wq2usy8gNndpuTw5mR.D35lls5iF(search, wq2usy8gNndpuTw5mR.I5WL12Wtoe) : null, qni3xrDkAJ3vF35eMav.T2S1GdgeU8);
						goto end_IL_0015;
						IL_01a3:
						oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
						HPaY7v4ahrafKGaWtLI.D35lls5iF(obj.qoCtxWy9sw, QRQY0D4ZAXiadEvDlxC.D35lls5iF(obj.qoCtxWy9sw, QRQY0D4ZAXiadEvDlxC.MJi4jRgZUY), HPaY7v4ahrafKGaWtLI.dNQCg3eEIM);
						homeViewModel2 = AppContainer.Resolve<HomeViewModel>();
						search2 = QRQY0D4ZAXiadEvDlxC.D35lls5iF(obj.qoCtxWy9sw, QRQY0D4ZAXiadEvDlxC.MJi4jRgZUY).SearchQuery.Search;
						qni3xrDkAJ3vF35eMav.D35lls5iF(homeViewModel2, (search2 != null) ? wq2usy8gNndpuTw5mR.D35lls5iF(search2, wq2usy8gNndpuTw5mR.I5WL12Wtoe) : null, qni3xrDkAJ3vF35eMav.T2S1GdgeU8);
						goto end_IL_0015;
						IL_00b6:
						oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
						HPaY7v4ahrafKGaWtLI.D35lls5iF(obj.qoCtxWy9sw, dYjEE74JgcwklirUGbS.D35lls5iF(obj.qoCtxWy9sw, dYjEE74JgcwklirUGbS.mcV4bOXKdP), HPaY7v4ahrafKGaWtLI.dNQCg3eEIM);
						homeViewModel3 = AppContainer.Resolve<HomeViewModel>();
						search3 = dYjEE74JgcwklirUGbS.D35lls5iF(obj.qoCtxWy9sw, dYjEE74JgcwklirUGbS.mcV4bOXKdP).SearchQuery.Search;
						qni3xrDkAJ3vF35eMav.D35lls5iF(homeViewModel3, (search3 != null) ? wq2usy8gNndpuTw5mR.D35lls5iF(search3, wq2usy8gNndpuTw5mR.I5WL12Wtoe) : null, qni3xrDkAJ3vF35eMav.T2S1GdgeU8);
						goto end_IL_0015;
					}
					oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
					HPaY7v4ahrafKGaWtLI.D35lls5iF(obj.qoCtxWy9sw, lZaMh14fefPS11redXv.D35lls5iF(obj.qoCtxWy9sw, lZaMh14fefPS11redXv.Jwb4FuY5HF), HPaY7v4ahrafKGaWtLI.dNQCg3eEIM);
					HomeViewModel homeViewModel4 = AppContainer.Resolve<HomeViewModel>();
					AlbumSearch search4 = lZaMh14fefPS11redXv.D35lls5iF(obj.qoCtxWy9sw, lZaMh14fefPS11redXv.Jwb4FuY5HF).SearchQuery.Search;
					qni3xrDkAJ3vF35eMav.D35lls5iF(homeViewModel4, (search4 != null) ? wq2usy8gNndpuTw5mR.D35lls5iF(search4, wq2usy8gNndpuTw5mR.I5WL12Wtoe) : null, qni3xrDkAJ3vF35eMav.T2S1GdgeU8);
					end_IL_0015:;
				}
				catch (Exception ex)
				{
					bXtQ8VRJjF = -2;
					N2XUglA3neBsnlZfRPQ.D35lls5iF(ref yeYQQljo4L, ex, N2XUglA3neBsnlZfRPQ.l4pATRumoW);
					return;
				}
				bXtQ8VRJjF = -2;
				T4XmPoA4VNJJP1afcgL.D35lls5iF(ref yeYQQljo4L, T4XmPoA4VNJJP1afcgL.TRyALZckCh);
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine P_0)
			{
				dHWo7jAEn6E4X7bsY4R.D35lls5iF(ref yeYQQljo4L, P_0, dHWo7jAEn6E4X7bsY4R.z3hAB6UZ9o);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine P_0)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(P_0);
			}
		}

		public MusicViewModel qoCtxWy9sw;

		public int PxdtyGHhUl;

		public _003C_003Ec__DisplayClass21_0()
		{
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
			base._002Ector();
		}

		[AsyncStateMachine(typeof(Cuk8us7EvZTCkJcQMk))]
		internal void G2Fts6jWiJ()
		{
			Cuk8us7EvZTCkJcQMk stateMachine = default(Cuk8us7EvZTCkJcQMk);
			stateMachine.yeYQQljo4L = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
			stateMachine.bklQnTSQJc = this;
			stateMachine.bXtQ8VRJjF = -1;
			stateMachine.yeYQQljo4L.Start(ref stateMachine);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass24_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct M5DSRh5jWFFvOa10mT : IAsyncStateMachine
		{
			public int GEOQ7whSxB;

			public AsyncVoidMethodBuilder nWcQ575Kqf;

			public _003C_003Ec__DisplayClass24_0 EJlQuGuJcD;

			private TaskAwaiter nvvQA0CgR8;

			private void MoveNext()
			{
				int num = GEOQ7whSxB;
				_003C_003Ec__DisplayClass24_0 obj = EJlQuGuJcD;
				try
				{
					TaskAwaiter awaiter;
					switch (num)
					{
					default:
						if (Sp7dKWL9ZfBld4JOkGo.D35lls5iF(obj.ER1tiqXSbR, Sp7dKWL9ZfBld4JOkGo.IHBLDqRE55) is SongsViewModel songsViewModel)
						{
							hH6DVMBvgw3ANNRyBk6.D35lls5iF(songsViewModel.SearchQuery.Search, obj.BVqt33IHPm, hH6DVMBvgw3ANNRyBk6.RRK6ishEFm);
							awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(songsViewModel.LoadAsync(), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
							if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
							{
								num = (GEOQ7whSxB = 0);
								nvvQA0CgR8 = awaiter;
								nWcQ575Kqf.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_00c6;
						}
						goto IL_00d2;
					case 0:
						awaiter = nvvQA0CgR8;
						nvvQA0CgR8 = default(TaskAwaiter);
						num = (GEOQ7whSxB = -1);
						goto IL_00c6;
					case 1:
						awaiter = nvvQA0CgR8;
						nvvQA0CgR8 = default(TaskAwaiter);
						num = (GEOQ7whSxB = -1);
						goto IL_016d;
					case 2:
						awaiter = nvvQA0CgR8;
						nvvQA0CgR8 = default(TaskAwaiter);
						num = (GEOQ7whSxB = -1);
						goto IL_0218;
					case 3:
						{
							awaiter = nvvQA0CgR8;
							nvvQA0CgR8 = default(TaskAwaiter);
							num = (GEOQ7whSxB = -1);
							break;
						}
						IL_016d:
						oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
						goto IL_0179;
						IL_0179:
						if (Sp7dKWL9ZfBld4JOkGo.D35lls5iF(obj.ER1tiqXSbR, Sp7dKWL9ZfBld4JOkGo.IHBLDqRE55) is AlbumsViewModel albumsViewModel)
						{
							hH6DVMBvgw3ANNRyBk6.D35lls5iF(albumsViewModel.SearchQuery.Search, obj.BVqt33IHPm, hH6DVMBvgw3ANNRyBk6.RRK6ishEFm);
							awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(albumsViewModel.LoadAsync(), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
							if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
							{
								num = (GEOQ7whSxB = 2);
								nvvQA0CgR8 = awaiter;
								nWcQ575Kqf.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_0218;
						}
						goto IL_0224;
						IL_00c6:
						oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
						goto IL_00d2;
						IL_00d2:
						if (Sp7dKWL9ZfBld4JOkGo.D35lls5iF(obj.ER1tiqXSbR, Sp7dKWL9ZfBld4JOkGo.IHBLDqRE55) is ArtistsViewModel artistsViewModel)
						{
							hH6DVMBvgw3ANNRyBk6.D35lls5iF(artistsViewModel.SearchQuery.Search, obj.BVqt33IHPm, hH6DVMBvgw3ANNRyBk6.RRK6ishEFm);
							awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(artistsViewModel.LoadAsync(), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
							if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
							{
								num = (GEOQ7whSxB = 1);
								nvvQA0CgR8 = awaiter;
								nWcQ575Kqf.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_016d;
						}
						goto IL_0179;
						IL_0218:
						oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
						goto IL_0224;
						IL_0224:
						if (Sp7dKWL9ZfBld4JOkGo.D35lls5iF(obj.ER1tiqXSbR, Sp7dKWL9ZfBld4JOkGo.IHBLDqRE55) is MusicPlaylistsViewModel musicPlaylistsViewModel)
						{
							hH6DVMBvgw3ANNRyBk6.D35lls5iF(musicPlaylistsViewModel.SearchQuery.Search, obj.BVqt33IHPm, hH6DVMBvgw3ANNRyBk6.RRK6ishEFm);
							awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(musicPlaylistsViewModel.LoadAsync(), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
							if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
							{
								num = (GEOQ7whSxB = 3);
								nvvQA0CgR8 = awaiter;
								nWcQ575Kqf.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							break;
						}
						goto end_IL_0015;
					}
					oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
					end_IL_0015:;
				}
				catch (Exception ex)
				{
					GEOQ7whSxB = -2;
					N2XUglA3neBsnlZfRPQ.D35lls5iF(ref nWcQ575Kqf, ex, N2XUglA3neBsnlZfRPQ.l4pATRumoW);
					return;
				}
				GEOQ7whSxB = -2;
				T4XmPoA4VNJJP1afcgL.D35lls5iF(ref nWcQ575Kqf, T4XmPoA4VNJJP1afcgL.TRyALZckCh);
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine P_0)
			{
				dHWo7jAEn6E4X7bsY4R.D35lls5iF(ref nWcQ575Kqf, P_0, dHWo7jAEn6E4X7bsY4R.z3hAB6UZ9o);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine P_0)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(P_0);
			}
		}

		public MusicViewModel ER1tiqXSbR;

		public string BVqt33IHPm;

		public _003C_003Ec__DisplayClass24_0()
		{
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
			base._002Ector();
		}

		[AsyncStateMachine(typeof(M5DSRh5jWFFvOa10mT))]
		internal void pKutpiV1rK()
		{
			M5DSRh5jWFFvOa10mT stateMachine = default(M5DSRh5jWFFvOa10mT);
			stateMachine.nWcQ575Kqf = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
			stateMachine.EJlQuGuJcD = this;
			stateMachine.GEOQ7whSxB = -1;
			stateMachine.nWcQ575Kqf.Start(ref stateMachine);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLoadLanguages_003Ed__34 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MusicViewModel _003C_003E4__this;

		private TaskAwaiter<Response<List<LanguageResponseDto>>> _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			MusicViewModel musicViewModel = _003C_003E4__this;
			try
			{
				try
				{
					TaskAwaiter<Response<List<LanguageResponseDto>>> awaiter;
					if (num != 0)
					{
						awaiter = JpDxOxCmce3lXyrJfoD.D35lls5iF(musicViewModel.yHRdG503gQ, JpDxOxCmce3lXyrJfoD.e1qCaQE3F1).GetAwaiter();
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
						_003C_003Eu__1 = default(TaskAwaiter<Response<List<LanguageResponseDto>>>);
						num = (_003C_003E1__state = -1);
					}
					Response<List<LanguageResponseDto>> result = awaiter.GetResult();
					if (result != null && result.Status)
					{
						CLLqb8CIn0YcxaJaY92.D35lls5iF(musicViewModel, result.Data, CLLqb8CIn0YcxaJaY92.iDmCxbq7xY);
						List<LanguageResponseDto> list = C7l25jCU6VYRwoJcihE.D35lls5iF(musicViewModel, C7l25jCU6VYRwoJcihE.kVuCY1Oan5);
						LanguageResponseDto languageResponseDto = new LanguageResponseDto();
						hH6DVMBvgw3ANNRyBk6.D35lls5iF(languageResponseDto, iFZ5je3XFYKwkvcE5D.D35lls5iF(16162, iFZ5je3XFYKwkvcE5D.N06TeK0ao), hH6DVMBvgw3ANNRyBk6.XuyCVW7uIV);
						list.Insert(0, languageResponseDto);
						qni3xrDkAJ3vF35eMav.D35lls5iF(musicViewModel, iFZ5je3XFYKwkvcE5D.D35lls5iF(16196, iFZ5je3XFYKwkvcE5D.N06TeK0ao), qni3xrDkAJ3vF35eMav.QN6DuDtCWO);
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
	private struct _003CLoadAsync_003Ed__38 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MusicViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			MusicViewModel CS_0024_003C_003E8__locals3 = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(W7S2sip6SDieZFVsNbd.D35lls5iF(CS_0024_003C_003E8__locals3, Expression.Lambda<Func<bool>>(OWBKr5pvc5MWsK1OMtR.D35lls5iF(o4bYL4peNeC2wWb8yjx.D35lls5iF(CS_0024_003C_003E8__locals3, sjYxHO8OWlc6X80hFj7.D35lls5iF(typeof(MusicViewModel).TypeHandle, sjYxHO8OWlc6X80hFj7.uWZ8ugU7r5), o4bYL4peNeC2wWb8yjx.oVdpGKjy2x), (MethodInfo)f5q427pRQZnrEKPy4Ws.D35lls5iF((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, f5q427pRQZnrEKPy4Ws.Bo9pk3m4k7), OWBKr5pvc5MWsK1OMtR.fZIpAAdi1v), Array.Empty<ParameterExpression>()), [AsyncStateMachine(typeof(_003C_003CLoadAsync_003Eb__38_1_003Ed))] () =>
					{
						_003C_003CLoadAsync_003Eb__38_1_003Ed stateMachine = default(_003C_003CLoadAsync_003Eb__38_1_003Ed);
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
	private struct _003C_003CLoadAsync_003Eb__38_1_003Ed : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MusicViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			MusicViewModel musicViewModel = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					HPaY7v4ahrafKGaWtLI.D35lls5iF(musicViewModel, lZaMh14fefPS11redXv.D35lls5iF(musicViewModel, lZaMh14fefPS11redXv.Jwb4FuY5HF), HPaY7v4ahrafKGaWtLI.dNQCg3eEIM);
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(VrVteFCs0OCGBTVr1mZ.D35lls5iF(new Task[2]
					{
						CRMxYv82mIBQFuWGeba.D35lls5iF(musicViewModel, CRMxYv82mIBQFuWGeba.owFCiHI2IK),
						lZaMh14fefPS11redXv.D35lls5iF(musicViewModel, lZaMh14fefPS11redXv.Jwb4FuY5HF).LoadAsync()
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

	[CompilerGenerated]
	private List<LanguageResponseDto> SU6dauPi6G;

	private BaseViewModel Okud0Qr92q;

	private readonly IAppService yHRdG503gQ;

	private MusicPlaylistsViewModel HHRdT9d1DU;

	private AlbumsViewModel LEldZdnoYd;

	private ArtistsViewModel e2Jdt9K7Va;

	private SongsViewModel zh4dSPVa0p;

	private int INAdfmK9cB;

	private string XWPdKdfh1K;

	public List<LanguageResponseDto> Languages
	{
		[CompilerGenerated]
		get
		{
			return SU6dauPi6G;
		}
		[CompilerGenerated]
		set
		{
			SU6dauPi6G = value;
		}
	}

	public BaseViewModel SelectedModel
	{
		get
		{
			return Okud0Qr92q;
		}
		set
		{
			SetProperty(ref Okud0Qr92q, value, iFZ5je3XFYKwkvcE5D.D35lls5iF(8630, iFZ5je3XFYKwkvcE5D.N06TeK0ao), null, delegate
			{
				AJv70itXcdnxnNYjSQ.D35lls5iF(AppContainer.Resolve<HomeViewModel>(), AJv70itXcdnxnNYjSQ.BiKHcjQZJT);
			});
		}
	}

	public MusicPlaylistsViewModel MyListMusicViewModel
	{
		get
		{
			return HHRdT9d1DU;
		}
		set
		{
			SetProperty(ref HHRdT9d1DU, value, iFZ5je3XFYKwkvcE5D.D35lls5iF(10278, iFZ5je3XFYKwkvcE5D.N06TeK0ao));
		}
	}

	public AlbumsViewModel AlbumsViewModel
	{
		get
		{
			return LEldZdnoYd;
		}
		set
		{
			SetProperty(ref LEldZdnoYd, value, iFZ5je3XFYKwkvcE5D.D35lls5iF(10322, iFZ5je3XFYKwkvcE5D.N06TeK0ao));
		}
	}

	public ArtistsViewModel ArtistsViewModel
	{
		get
		{
			return e2Jdt9K7Va;
		}
		set
		{
			SetProperty(ref e2Jdt9K7Va, value, iFZ5je3XFYKwkvcE5D.D35lls5iF(10356, iFZ5je3XFYKwkvcE5D.N06TeK0ao));
		}
	}

	public SongsViewModel SongsViewModel
	{
		get
		{
			return zh4dSPVa0p;
		}
		set
		{
			SetProperty(ref zh4dSPVa0p, value, iFZ5je3XFYKwkvcE5D.D35lls5iF(10392, iFZ5je3XFYKwkvcE5D.N06TeK0ao));
		}
	}

	public int TabSelectedindex
	{
		get
		{
			return INAdfmK9cB;
		}
		set
		{
			_003C_003Ec__DisplayClass21_0 CS_0024_003C_003E8__locals4 = new _003C_003Ec__DisplayClass21_0();
			CS_0024_003C_003E8__locals4.qoCtxWy9sw = this;
			CS_0024_003C_003E8__locals4.PxdtyGHhUl = value;
			SetProperty(ref INAdfmK9cB, CS_0024_003C_003E8__locals4.PxdtyGHhUl, iFZ5je3XFYKwkvcE5D.D35lls5iF(8660, iFZ5je3XFYKwkvcE5D.N06TeK0ao), null, [AsyncStateMachine(typeof(_003C_003Ec__DisplayClass21_0.Cuk8us7EvZTCkJcQMk))] () =>
			{
				_003C_003Ec__DisplayClass21_0.Cuk8us7EvZTCkJcQMk stateMachine = default(_003C_003Ec__DisplayClass21_0.Cuk8us7EvZTCkJcQMk);
				stateMachine.yeYQQljo4L = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
				stateMachine.bklQnTSQJc = CS_0024_003C_003E8__locals4;
				stateMachine.bXtQ8VRJjF = -1;
				stateMachine.yeYQQljo4L.Start(ref stateMachine);
			});
		}
	}

	public string MusicSearchText
	{
		get
		{
			return XWPdKdfh1K;
		}
		set
		{
			_003C_003Ec__DisplayClass24_0 CS_0024_003C_003E8__locals4 = new _003C_003Ec__DisplayClass24_0();
			CS_0024_003C_003E8__locals4.ER1tiqXSbR = this;
			CS_0024_003C_003E8__locals4.BVqt33IHPm = value;
			SetProperty(ref XWPdKdfh1K, CS_0024_003C_003E8__locals4.BVqt33IHPm, iFZ5je3XFYKwkvcE5D.D35lls5iF(10424, iFZ5je3XFYKwkvcE5D.N06TeK0ao), null, [AsyncStateMachine(typeof(_003C_003Ec__DisplayClass24_0.M5DSRh5jWFFvOa10mT))] () =>
			{
				_003C_003Ec__DisplayClass24_0.M5DSRh5jWFFvOa10mT stateMachine = default(_003C_003Ec__DisplayClass24_0.M5DSRh5jWFFvOa10mT);
				stateMachine.nWcQ575Kqf = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
				stateMachine.EJlQuGuJcD = CS_0024_003C_003E8__locals4;
				stateMachine.GEOQ7whSxB = -1;
				stateMachine.nWcQ575Kqf.Start(ref stateMachine);
			});
		}
	}

	public MusicViewModel()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		INAdfmK9cB = 1;
		base._002Ector();
		INAdfmK9cB = 3;
		yHRdG503gQ = AppContainer.Resolve<IAppService>();
		LMNIoE4s875HTR3DcR4.D35lls5iF(this, new MusicPlaylistsViewModel(), LMNIoE4s875HTR3DcR4.uMK4hCRFuN);
		HKE7UJ4xbnUj5k5PtH1.D35lls5iF(this, new AlbumsViewModel(), HKE7UJ4xbnUj5k5PtH1.tNX4YDBYFP);
		oAuWtx4gmNL7EtwZlIH.D35lls5iF(this, new ArtistsViewModel(), oAuWtx4gmNL7EtwZlIH.un04iS07XK);
		GrBaJ14QaNwKIGyvGKb.D35lls5iF(this, new SongsViewModel(), GrBaJ14QaNwKIGyvGKb.cN94XSAWtv);
	}

	[AsyncStateMachine(typeof(_003CLoadLanguages_003Ed__34))]
	public Task LoadLanguages()
	{
		_003CLoadLanguages_003Ed__34 stateMachine = default(_003CLoadLanguages_003Ed__34);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	public void Clear()
	{
		xLO56JniGyickVjO1Ot.D35lls5iF(lZaMh14fefPS11redXv.D35lls5iF(this, lZaMh14fefPS11redXv.Jwb4FuY5HF), xLO56JniGyickVjO1Ot.xJy42GSmho);
		EcRAvP4y5i6535dlslT.D35lls5iF(QRQY0D4ZAXiadEvDlxC.D35lls5iF(this, QRQY0D4ZAXiadEvDlxC.MJi4jRgZUY), EcRAvP4y5i6535dlslT.Nao4qGF2F6);
		EcRAvP4y5i6535dlslT.D35lls5iF(dYjEE74JgcwklirUGbS.D35lls5iF(this, dYjEE74JgcwklirUGbS.mcV4bOXKdP), EcRAvP4y5i6535dlslT.EJ54W2QoHg);
		EcRAvP4y5i6535dlslT.D35lls5iF(EAYFcT45SkGYkIx9hLl.D35lls5iF(this, EAYFcT45SkGYkIx9hLl.WQv4zhZcir), EcRAvP4y5i6535dlslT.KtxLo3m0Ku);
	}

	public void ClearAllItems()
	{
		lZaMh14fefPS11redXv.D35lls5iF(this, lZaMh14fefPS11redXv.Jwb4FuY5HF).Items.Clear();
		QRQY0D4ZAXiadEvDlxC.D35lls5iF(this, QRQY0D4ZAXiadEvDlxC.MJi4jRgZUY).Items.Clear();
		dYjEE74JgcwklirUGbS.D35lls5iF(this, dYjEE74JgcwklirUGbS.mcV4bOXKdP).Items.Clear();
		EAYFcT45SkGYkIx9hLl.D35lls5iF(this, EAYFcT45SkGYkIx9hLl.WQv4zhZcir).Items.Clear();
		lZaMh14fefPS11redXv.D35lls5iF(this, lZaMh14fefPS11redXv.Jwb4FuY5HF).CurrentPage = 1;
		QRQY0D4ZAXiadEvDlxC.D35lls5iF(this, QRQY0D4ZAXiadEvDlxC.MJi4jRgZUY).CurrentPage = 1;
		dYjEE74JgcwklirUGbS.D35lls5iF(this, dYjEE74JgcwklirUGbS.mcV4bOXKdP).CurrentPage = 1;
		EAYFcT45SkGYkIx9hLl.D35lls5iF(this, EAYFcT45SkGYkIx9hLl.WQv4zhZcir).CurrentPage = 1;
	}

	public override void OnLoading()
	{
		EcRAvP4y5i6535dlslT.D35lls5iF(this, EcRAvP4y5i6535dlslT.Ek2LlxqgvO);
		if (Sp7dKWL9ZfBld4JOkGo.D35lls5iF(this, Sp7dKWL9ZfBld4JOkGo.IHBLDqRE55) == null)
		{
			Task task = CRMxYv82mIBQFuWGeba.D35lls5iF(this, CRMxYv82mIBQFuWGeba.ilwLHaZpNL);
			Action<Exception> action = null;
			bool flag = false;
			gBlEqv8jRKikCj2DMZp.D35lls5iF(task, ref action, ref flag, gBlEqv8jRKikCj2DMZp.pSp8ymt8Mu);
		}
		else if (INAdfmK9cB == 0)
		{
			HomeViewModel homeViewModel = AppContainer.Resolve<HomeViewModel>();
			PlaylistSearch search = dYjEE74JgcwklirUGbS.D35lls5iF(this, dYjEE74JgcwklirUGbS.mcV4bOXKdP).SearchQuery.Search;
			qni3xrDkAJ3vF35eMav.D35lls5iF(homeViewModel, (search != null) ? wq2usy8gNndpuTw5mR.D35lls5iF(search, wq2usy8gNndpuTw5mR.I5WL12Wtoe) : null, qni3xrDkAJ3vF35eMav.T2S1GdgeU8);
		}
		else if (INAdfmK9cB == 1)
		{
			HomeViewModel homeViewModel2 = AppContainer.Resolve<HomeViewModel>();
			PeopleSearch search2 = QRQY0D4ZAXiadEvDlxC.D35lls5iF(this, QRQY0D4ZAXiadEvDlxC.MJi4jRgZUY).SearchQuery.Search;
			qni3xrDkAJ3vF35eMav.D35lls5iF(homeViewModel2, (search2 != null) ? wq2usy8gNndpuTw5mR.D35lls5iF(search2, wq2usy8gNndpuTw5mR.I5WL12Wtoe) : null, qni3xrDkAJ3vF35eMav.T2S1GdgeU8);
		}
		else if (INAdfmK9cB == 2)
		{
			HomeViewModel homeViewModel3 = AppContainer.Resolve<HomeViewModel>();
			SongSearch search3 = EAYFcT45SkGYkIx9hLl.D35lls5iF(this, EAYFcT45SkGYkIx9hLl.WQv4zhZcir).SearchQuery.Search;
			qni3xrDkAJ3vF35eMav.D35lls5iF(homeViewModel3, (search3 != null) ? wq2usy8gNndpuTw5mR.D35lls5iF(search3, wq2usy8gNndpuTw5mR.I5WL12Wtoe) : null, qni3xrDkAJ3vF35eMav.T2S1GdgeU8);
		}
		else if (INAdfmK9cB == 3)
		{
			HomeViewModel homeViewModel4 = AppContainer.Resolve<HomeViewModel>();
			AlbumSearch search4 = lZaMh14fefPS11redXv.D35lls5iF(this, lZaMh14fefPS11redXv.Jwb4FuY5HF).SearchQuery.Search;
			qni3xrDkAJ3vF35eMav.D35lls5iF(homeViewModel4, (search4 != null) ? wq2usy8gNndpuTw5mR.D35lls5iF(search4, wq2usy8gNndpuTw5mR.I5WL12Wtoe) : null, qni3xrDkAJ3vF35eMav.T2S1GdgeU8);
		}
	}

	[AsyncStateMachine(typeof(_003CLoadAsync_003Ed__38))]
	public Task LoadAsync()
	{
		_003CLoadAsync_003Ed__38 stateMachine = default(_003CLoadAsync_003Ed__38);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	[CompilerGenerated]
	[AsyncStateMachine(typeof(_003C_003CLoadAsync_003Eb__38_1_003Ed))]
	private Task RMsdVHjPS7()
	{
		_003C_003CLoadAsync_003Eb__38_1_003Ed stateMachine = default(_003C_003CLoadAsync_003Eb__38_1_003Ed);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}
}
