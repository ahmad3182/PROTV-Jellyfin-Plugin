using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using PROTV.Abstractions.Services;
using PROTV.DataAccess;
using PROTV.Wpf.Bootstrap;
using PROTV.Wpf.ViewModels;

namespace PROTV.Wpf;

public class App : Application
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnStartup_003Ed__2 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public App _003C_003E4__this;

		public StartupEventArgs e;

		private SplashScreen _003CsplashScreen_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f1: Expected O, but got Unknown
			int num = _003C_003E1__state;
			App app = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				MainViewModel mainViewModel;
				Application application;
				MainWindow mainWindow;
				switch (num)
				{
				default:
				{
					fcPWs4iKd = new Mutex(initiallyOwned: true, iFZ5je3XFYKwkvcE5D.D35lls5iF(15524, iFZ5je3XFYKwkvcE5D.N06TeK0ao), out var createdNew);
					if (createdNew)
					{
						_003CsplashScreen_003E5__2 = new SplashScreen(iFZ5je3XFYKwkvcE5D.D35lls5iF(15552, iFZ5je3XFYKwkvcE5D.N06TeK0ao));
						jPB9Q5LdIM9wsuWV1q7.D35lls5iF(_003CsplashScreen_003E5__2, false, jPB9Q5LdIM9wsuWV1q7.JXWvPPU7ib);
						iKEHMcMiYtn5aFJ5wg.D35lls5iF(app, e, iKEHMcMiYtn5aFJ5wg.CNPvsBmXrf);
						t7lQhEvhhjckeWqCn6q.D35lls5iF(app, ShutdownMode.OnMainWindowClose, t7lQhEvhhjckeWqCn6q.yVKvxIGwVr);
						YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.UX2vYQhS88);
						goto case 0;
					}
					Process process = uoE9NyRTDnK1XbF0YaK.D35lls5iF(uoE9NyRTDnK1XbF0YaK.tlsR4ubuiJ);
					Process[] array = eeh4Exv722NTebDO1nP.D35lls5iF(QQLie3eYkZwbFFm9Jjw.D35lls5iF(process, QQLie3eYkZwbFFm9Jjw.GjsRLagEOd), eeh4Exv722NTebDO1nP.OxQvc1mnDJ);
					foreach (Process process2 in array)
					{
						if (m9MGZR7k2RmVqYXYS5.D35lls5iF(process2, m9MGZR7k2RmVqYXYS5.AQ8vMVbdgy) != m9MGZR7k2RmVqYXYS5.D35lls5iF(process, m9MGZR7k2RmVqYXYS5.AQ8vMVbdgy))
						{
							Tt4XmWvNV69SPIa5Uen.D35lls5iF(Hwo9WvvS2l3n9OBJ1Wx.D35lls5iF(process2, Hwo9WvvS2l3n9OBJ1Wx.hWhvKuh6cp), Tt4XmWvNV69SPIa5Uen.JCkvODpnx6);
							break;
						}
					}
					fp757nBYjo8889efKFJ.D35lls5iF(app, fp757nBYjo8889efKFJ.EmUvuGCB6m);
					goto end_IL_0015;
				}
				case 0:
					try
					{
						if (num != 0)
						{
							awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(CRMxYv82mIBQFuWGeba.D35lls5iF(AppContainer.Resolve<IClientDataStore>(), CRMxYv82mIBQFuWGeba.ocdvgIMipN), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
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
					catch
					{
					}
					YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.yvGvZyHYZx);
					TIk8TmAGgM9Athjfkj.D35lls5iF(app, TIk8TmAGgM9Athjfkj.WpgvjgLpeu);
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(CRMxYv82mIBQFuWGeba.D35lls5iF(app, CRMxYv82mIBQFuWGeba.QIvvykQgTa), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
					if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
					{
						num = (_003C_003E1__state = 1);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_0232;
				case 1:
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_0232;
				case 2:
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_0421;
				case 3:
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter);
						num = (_003C_003E1__state = -1);
						break;
					}
					IL_0421:
					oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
					goto IL_042d;
					IL_0232:
					oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
					mainViewModel = AppContainer.Resolve<MainViewModel>();
					application = Jr0pTQlovwB9pdID1EB.D35lls5iF(Jr0pTQlovwB9pdID1EB.CxrllgXtD4);
					mainWindow = new MainWindow();
					KBhlAv9D2TgBJ1kkc0B.D35lls5iF(mainWindow, mainViewModel, KBhlAv9D2TgBJ1kkc0B.Rl6Lwm818f);
					JPkDoyvqO2UKRmJN6I1.D35lls5iF(application, mainWindow, JPkDoyvqO2UKRmJN6I1.NYCvJMvHnJ);
					if (GmMLaTD7kV8rq88ZFvR.D35lls5iF(xrWtp71MaQsXtvtrqkf.D35lls5iF(Jr0pTQlovwB9pdID1EB.D35lls5iF(Jr0pTQlovwB9pdID1EB.CxrllgXtD4), xrWtp71MaQsXtvtrqkf.fxR1SMKb5A), iFZ5je3XFYKwkvcE5D.D35lls5iF(14656, iFZ5je3XFYKwkvcE5D.N06TeK0ao), GmMLaTD7kV8rq88ZFvR.VGG1KpDfXX) && GmMLaTD7kV8rq88ZFvR.D35lls5iF(xrWtp71MaQsXtvtrqkf.D35lls5iF(Jr0pTQlovwB9pdID1EB.D35lls5iF(Jr0pTQlovwB9pdID1EB.CxrllgXtD4), xrWtp71MaQsXtvtrqkf.fxR1SMKb5A), iFZ5je3XFYKwkvcE5D.D35lls5iF(1844, iFZ5je3XFYKwkvcE5D.N06TeK0ao), GmMLaTD7kV8rq88ZFvR.VGG1KpDfXX))
					{
						IStoreContext storeContext = AppContainer.Resolve<IStoreContext>();
						hH6DVMBvgw3ANNRyBk6.D35lls5iF(storeContext, wq2usy8gNndpuTw5mR.D35lls5iF(auEPOZ1NWYKXdU711jq.D35lls5iF(xrWtp71MaQsXtvtrqkf.D35lls5iF(app, xrWtp71MaQsXtvtrqkf.NBkvbhjGJy), iFZ5je3XFYKwkvcE5D.D35lls5iF(14656, iFZ5je3XFYKwkvcE5D.N06TeK0ao), auEPOZ1NWYKXdU711jq.Y1J1OKa53W), wq2usy8gNndpuTw5mR.ajcDe8nffb), hH6DVMBvgw3ANNRyBk6.zaHvWPUjoF);
						hH6DVMBvgw3ANNRyBk6.D35lls5iF(storeContext, wq2usy8gNndpuTw5mR.D35lls5iF(auEPOZ1NWYKXdU711jq.D35lls5iF(xrWtp71MaQsXtvtrqkf.D35lls5iF(app, xrWtp71MaQsXtvtrqkf.NBkvbhjGJy), iFZ5je3XFYKwkvcE5D.D35lls5iF(14684, iFZ5je3XFYKwkvcE5D.N06TeK0ao), auEPOZ1NWYKXdU711jq.Y1J1OKa53W), wq2usy8gNndpuTw5mR.ajcDe8nffb), hH6DVMBvgw3ANNRyBk6.Bi5v53luLv);
						hH6DVMBvgw3ANNRyBk6.D35lls5iF(storeContext, wq2usy8gNndpuTw5mR.D35lls5iF(auEPOZ1NWYKXdU711jq.D35lls5iF(xrWtp71MaQsXtvtrqkf.D35lls5iF(app, xrWtp71MaQsXtvtrqkf.NBkvbhjGJy), iFZ5je3XFYKwkvcE5D.D35lls5iF(1844, iFZ5je3XFYKwkvcE5D.N06TeK0ao), auEPOZ1NWYKXdU711jq.Y1J1OKa53W), wq2usy8gNndpuTw5mR.ajcDe8nffb), hH6DVMBvgw3ANNRyBk6.B43vz2sbTw);
						hH6DVMBvgw3ANNRyBk6.D35lls5iF(storeContext, wq2usy8gNndpuTw5mR.D35lls5iF(auEPOZ1NWYKXdU711jq.D35lls5iF(xrWtp71MaQsXtvtrqkf.D35lls5iF(app, xrWtp71MaQsXtvtrqkf.NBkvbhjGJy), iFZ5je3XFYKwkvcE5D.D35lls5iF(1858, iFZ5je3XFYKwkvcE5D.N06TeK0ao), auEPOZ1NWYKXdU711jq.Y1J1OKa53W), wq2usy8gNndpuTw5mR.ajcDe8nffb), hH6DVMBvgw3ANNRyBk6.p6CAoGXAqh);
						awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(CRMxYv82mIBQFuWGeba.D35lls5iF(mainViewModel, CRMxYv82mIBQFuWGeba.Dm0Al1R2as), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
						if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
						{
							num = (_003C_003E1__state = 2);
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_0421;
					}
					goto IL_042d;
					IL_042d:
					AKwYZ1lE8mnNaTGlMo6.D35lls5iF(_003CsplashScreen_003E5__2, aNJrrPl4soK5NDOndiN.D35lls5iF(200.0, aNJrrPl4soK5NDOndiN.V5YlLGDQcw), AKwYZ1lE8mnNaTGlMo6.HOgA9ff5qY);
					fp757nBYjo8889efKFJ.D35lls5iF(VqWOinl9PO0jF3BJej0.D35lls5iF(Jr0pTQlovwB9pdID1EB.D35lls5iF(Jr0pTQlovwB9pdID1EB.CxrllgXtD4), VqWOinl9PO0jF3BJej0.XwJlDOAaeh), fp757nBYjo8889efKFJ.CF1ADwhKEr);
					chia4hAH2gbg2yOn9e6.D35lls5iF(VqWOinl9PO0jF3BJej0.D35lls5iF(Jr0pTQlovwB9pdID1EB.D35lls5iF(Jr0pTQlovwB9pdID1EB.CxrllgXtD4), VqWOinl9PO0jF3BJej0.XwJlDOAaeh), chia4hAH2gbg2yOn9e6.zcbA1G7a8C);
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(xvst7LA88CbscxBNUCX.D35lls5iF(xvst7LA88CbscxBNUCX.pUxAnRKpMT), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
					if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
					{
						num = (_003C_003E1__state = 3);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					break;
				}
				oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
				_003CsplashScreen_003E5__2 = null;
				end_IL_0015:;
			}
			catch (Exception ex)
			{
				_003C_003E1__state = -2;
				N2XUglA3neBsnlZfRPQ.D35lls5iF(ref _003C_003Et__builder, ex, N2XUglA3neBsnlZfRPQ.l4pATRumoW);
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
	private struct _003CApplicationSetupAsync_003Ed__4 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public App _003C_003E4__this;

		private IStoreContext _003C_store_003E5__2;

		private IAuthService _003C_auth_003E5__3;

		private IStoreContext _003C_003E7__wrap3;

		private TaskAwaiter<string> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			App app = _003C_003E4__this;
			try
			{
				_ = 2;
				try
				{
					TaskAwaiter<string> awaiter2;
					TaskAwaiter awaiter;
					string result;
					switch (num)
					{
					default:
					{
						_003C_store_003E5__2 = AppContainer.Resolve<IStoreContext>();
						_003C_auth_003E5__3 = AppContainer.Resolve<IAuthService>();
						IStoreContext storeContext = _003C_store_003E5__2;
						object obj = auEPOZ1NWYKXdU711jq.D35lls5iF(xrWtp71MaQsXtvtrqkf.D35lls5iF(app, xrWtp71MaQsXtvtrqkf.NBkvbhjGJy), iFZ5je3XFYKwkvcE5D.D35lls5iF(14642, iFZ5je3XFYKwkvcE5D.N06TeK0ao), auEPOZ1NWYKXdU711jq.Y1J1OKa53W);
						hH6DVMBvgw3ANNRyBk6.D35lls5iF(storeContext, (obj != null) ? wq2usy8gNndpuTw5mR.D35lls5iF(obj, wq2usy8gNndpuTw5mR.ajcDe8nffb) : null, hH6DVMBvgw3ANNRyBk6.EmsA0kPK7a);
						hH6DVMBvgw3ANNRyBk6.D35lls5iF(_003C_store_003E5__2, slLC9nDGSMhIcv2FTUB.D35lls5iF(slLC9nDGSMhIcv2FTUB.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(K8S9pv8QBPdFFp0gPX5.D35lls5iF(nv2QPs8gg241scgGIpo.D35lls5iF(SquFyS8xIGlsxnt0VYs.D35lls5iF(SquFyS8xIGlsxnt0VYs.EA8ArZXTnT), nv2QPs8gg241scgGIpo.z8Z8iE5sFO), K8S9pv8QBPdFFp0gPX5.Fmo8X7TAdd), wq2usy8gNndpuTw5mR.ajcDe8nffb), '0', slLC9nDGSMhIcv2FTUB.yv2DRs3jeV), '.', slLC9nDGSMhIcv2FTUB.yv2DRs3jeV), hH6DVMBvgw3ANNRyBk6.vP2Aeh8Y97);
						hH6DVMBvgw3ANNRyBk6.D35lls5iF(_003C_store_003E5__2, QQLie3eYkZwbFFm9Jjw.D35lls5iF(_003C_auth_003E5__3, QQLie3eYkZwbFFm9Jjw.qkTAGdJcjD), hH6DVMBvgw3ANNRyBk6.HAYAR2NT6d);
						_003C_003E7__wrap3 = _003C_store_003E5__2;
						awaiter2 = tLYAYDAkbfTSYv67SrI.D35lls5iF(_003C_auth_003E5__3, tLYAYDAkbfTSYv67SrI.IFdAvkWdmV).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = (_003C_003E1__state = 0);
							_003C_003Eu__1 = awaiter2;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						}
						goto IL_016a;
					}
					case 0:
						awaiter2 = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter<string>);
						num = (_003C_003E1__state = -1);
						goto IL_016a;
					case 1:
						awaiter2 = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter<string>);
						num = (_003C_003E1__state = -1);
						goto IL_01f7;
					case 2:
						{
							awaiter = _003C_003Eu__2;
							_003C_003Eu__2 = default(TaskAwaiter);
							num = (_003C_003E1__state = -1);
							break;
						}
						IL_01f7:
						result = awaiter2.GetResult();
						hH6DVMBvgw3ANNRyBk6.D35lls5iF(_003C_003E7__wrap3, result, hH6DVMBvgw3ANNRyBk6.mggApjTveB);
						_003C_003E7__wrap3 = null;
						hH6DVMBvgw3ANNRyBk6.D35lls5iF(_003C_store_003E5__2, QQLie3eYkZwbFFm9Jjw.D35lls5iF(_003C_auth_003E5__3, QQLie3eYkZwbFFm9Jjw.CHLAwxkwUA), hH6DVMBvgw3ANNRyBk6.ioTACqNIeY);
						awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(xvst7LA88CbscxBNUCX.D35lls5iF(xvst7LA88CbscxBNUCX.fm6AmQoqGx), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
						if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
						{
							num = (_003C_003E1__state = 2);
							_003C_003Eu__2 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						break;
						IL_016a:
						result = awaiter2.GetResult();
						hH6DVMBvgw3ANNRyBk6.D35lls5iF(_003C_003E7__wrap3, result, hH6DVMBvgw3ANNRyBk6.hbjAAK3r6e);
						_003C_003E7__wrap3 = null;
						_003C_003E7__wrap3 = _003C_store_003E5__2;
						awaiter2 = tLYAYDAkbfTSYv67SrI.D35lls5iF(_003C_auth_003E5__3, tLYAYDAkbfTSYv67SrI.FjZA6Cbp3D).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = (_003C_003E1__state = 1);
							_003C_003Eu__1 = awaiter2;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						}
						goto IL_01f7;
					}
					oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
					try
					{
						if (ptPuAcAI0sZNSIqXe3K.D35lls5iF(QQLie3eYkZwbFFm9Jjw.D35lls5iF(_003C_store_003E5__2, QQLie3eYkZwbFFm9Jjw.lkWAavnxv5), '2', ptPuAcAI0sZNSIqXe3K.QE1AdrFb7A))
						{
							G11lpCAU5cj2sr3ACLJ.D35lls5iF(iFZ5je3XFYKwkvcE5D.D35lls5iF(15610, iFZ5je3XFYKwkvcE5D.N06TeK0ao), SquFyS8xIGlsxnt0VYs.D35lls5iF(SquFyS8xIGlsxnt0VYs.tTB8YED5ib), G11lpCAU5cj2sr3ACLJ.KnTAtpBYX0);
						}
						else
						{
							G11lpCAU5cj2sr3ACLJ.D35lls5iF(iFZ5je3XFYKwkvcE5D.D35lls5iF(15694, iFZ5je3XFYKwkvcE5D.N06TeK0ao), SquFyS8xIGlsxnt0VYs.D35lls5iF(SquFyS8xIGlsxnt0VYs.tTB8YED5ib), G11lpCAU5cj2sr3ACLJ.KnTAtpBYX0);
						}
					}
					catch
					{
						gsYNF433WqUIGma3CNX.D35lls5iF(iFZ5je3XFYKwkvcE5D.D35lls5iF(15770, iFZ5je3XFYKwkvcE5D.N06TeK0ao), "", gsYNF433WqUIGma3CNX.Ei5AVGtpvG);
					}
					_003C_store_003E5__2 = null;
					_003C_auth_003E5__3 = null;
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

	private static Mutex fcPWs4iKd;

	private bool MDH4f75mr;

	public App()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector();
		string text = UwSEfC4rh9eVlFenwI.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(QZBG4pHdk7Bfu1D0LW.D35lls5iF(QZBG4pHdk7Bfu1D0LW.si21rmLRg), wq2usy8gNndpuTw5mR.qPvnrrLZr), iFZ5je3XFYKwkvcE5D.D35lls5iF(0, iFZ5je3XFYKwkvcE5D.N06TeK0ao), UwSEfC4rh9eVlFenwI.BPNLUJNA3);
		if (!M6ZErPEr2LZyWYpa5O.D35lls5iF(text, M6ZErPEr2LZyWYpa5O.vqqBpLiOe))
		{
			gM00OS0Iir9SCS8q6P.D35lls5iF(text, gM00OS0Iir9SCS8q6P.RKarZUs3s);
		}
		iEiFM8eVSwxJTPFVS0.D35lls5iF(text, iEiFM8eVSwxJTPFVS0.Ht8GeKaE7);
		iEiFM8eVSwxJTPFVS0.D35lls5iF(iFZ5je3XFYKwkvcE5D.D35lls5iF(14, iFZ5je3XFYKwkvcE5D.N06TeK0ao), iEiFM8eVSwxJTPFVS0.CjYRHhQXN);
	}

	[AsyncStateMachine(typeof(_003COnStartup_003Ed__2))]
	protected override void OnStartup(StartupEventArgs e)
	{
		_003COnStartup_003Ed__2 stateMachine = default(_003COnStartup_003Ed__2);
		stateMachine._003C_003Et__builder = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
		stateMachine._003C_003E4__this = this;
		stateMachine.e = e;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	protected override void OnExit(ExitEventArgs e)
	{
		TIk8TmAGgM9Athjfkj.D35lls5iF(this, TIk8TmAGgM9Athjfkj.nAR6vwiv5);
		xovI2FprmERhjf0cuk.D35lls5iF(this, e, xovI2FprmERhjf0cuk.eOnwh6pMn);
	}

	[AsyncStateMachine(typeof(_003CApplicationSetupAsync_003Ed__4))]
	private Task DQ2jyavt1()
	{
		_003CApplicationSetupAsync_003Ed__4 stateMachine = default(_003CApplicationSetupAsync_003Ed__4);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "5.0.4.0")]
	public void InitializeComponent()
	{
		if (!MDH4f75mr)
		{
			MDH4f75mr = true;
			Uri uri = new Uri(iFZ5je3XFYKwkvcE5D.D35lls5iF(32, iFZ5je3XFYKwkvcE5D.N06TeK0ao), UriKind.Relative);
			TUdx26d4l5VwJTvopv.D35lls5iF(this, uri, TUdx26d4l5VwJTvopv.W3oUN4AKb);
		}
	}

	[DebuggerNonUserCode]
	[STAThread]
	[GeneratedCode("PresentationBuildTasks", "5.0.4.0")]
	public static void Main()
	{
		App app = new App();
		AJv70itXcdnxnNYjSQ.D35lls5iF(app, AJv70itXcdnxnNYjSQ.qsvVj1B15);
		m9MGZR7k2RmVqYXYS5.D35lls5iF(app, m9MGZR7k2RmVqYXYS5.zQFcAPRRM);
	}

	[DebuggerHidden]
	[CompilerGenerated]
	private void wZAvS4jHd(StartupEventArgs P_0)
	{
		iKEHMcMiYtn5aFJ5wg.D35lls5iF(this, P_0, iKEHMcMiYtn5aFJ5wg.OVnSWkn5a);
	}
}
