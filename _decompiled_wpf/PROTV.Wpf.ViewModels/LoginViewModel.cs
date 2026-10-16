using System;
using System.Collections;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading.Tasks;
using System.Windows.Input;
using PROTV.Abstractions.Common;
using PROTV.Abstractions.DataTransferObjects;
using PROTV.Abstractions.Helpers;
using PROTV.Abstractions.Services;
using PROTV.Wpf.Bootstrap;

namespace PROTV.Wpf.ViewModels;

public class LoginViewModel : BaseViewModel
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct W46IieTWrHUtGDt0ud : IAsyncStateMachine
		{
			public int tRP8p1ZCXQ;

			public AsyncTaskMethodBuilder ixa8iDjovG;

			public _003C_003Ec__DisplayClass14_0 hLH83hlYrS;

			private TaskAwaiter<Response<LoginResponseDto>> L1B8m0UK9K;

			private TaskAwaiter kOj8XFqCM2;

			private void MoveNext()
			{
				int num = tRP8p1ZCXQ;
				_003C_003Ec__DisplayClass14_0 obj = hLH83hlYrS;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0 && num == 1)
					{
						awaiter = kOj8XFqCM2;
						kOj8XFqCM2 = default(TaskAwaiter);
						num = (tRP8p1ZCXQ = -1);
						goto IL_0392;
					}
					try
					{
						TaskAwaiter<Response<LoginResponseDto>> awaiter2;
						if (num != 0)
						{
							IAuthService t6iD6DHeDi = obj.iRAt4co51B.T6iD6DHeDi;
							string text = eVlRnEIaHT0dqvCx0Kx.D35lls5iF(obj.iRAt4co51B, eVlRnEIaHT0dqvCx0Kx.F2h7ZIa1JG);
							SecureString secureString = WdEd4P1YqUyNUXB2roT.D35lls5iF(obj.JrwtBfDBji, WdEd4P1YqUyNUXB2roT.pZP7jUsSAx);
							awaiter2 = ObACkawWd8bljHnfOtb.D35lls5iF(t6iD6DHeDi, text, (secureString != null) ? VetgaZ7ysHGTXnNjIwg.D35lls5iF(secureString, VetgaZ7ysHGTXnNjIwg.Fyu7qWfhyV) : null, ObACkawWd8bljHnfOtb.FcIw5dI8mG).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num = (tRP8p1ZCXQ = 0);
								L1B8m0UK9K = awaiter2;
								ixa8iDjovG.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
						}
						else
						{
							awaiter2 = L1B8m0UK9K;
							L1B8m0UK9K = default(TaskAwaiter<Response<LoginResponseDto>>);
							num = (tRP8p1ZCXQ = -1);
						}
						Response<LoginResponseDto> result = awaiter2.GetResult();
						if (result != null)
						{
							if (result.Status)
							{
								goto IL_0121;
							}
							gsYNF433WqUIGma3CNX.D35lls5iF(result.Message, "", gsYNF433WqUIGma3CNX.MAY3Ti847u);
						}
					}
					catch (PROTVException ex)
					{
						gsYNF433WqUIGma3CNX.D35lls5iF(QQLie3eYkZwbFFm9Jjw.D35lls5iF(ex, QQLie3eYkZwbFFm9Jjw.vZdwjWiy78), "", gsYNF433WqUIGma3CNX.MAY3Ti847u);
					}
					goto end_IL_0015;
					IL_0121:
					if (LsA6RHpKkbdnOn3fX60.D35lls5iF(obj.iRAt4co51B, LsA6RHpKkbdnOn3fX60.Wir7JWbAJm))
					{
						if (GmMLaTD7kV8rq88ZFvR.D35lls5iF(xrWtp71MaQsXtvtrqkf.D35lls5iF(Jr0pTQlovwB9pdID1EB.D35lls5iF(Jr0pTQlovwB9pdID1EB.CxrllgXtD4), xrWtp71MaQsXtvtrqkf.fxR1SMKb5A), iFZ5je3XFYKwkvcE5D.D35lls5iF(1844, iFZ5je3XFYKwkvcE5D.N06TeK0ao), GmMLaTD7kV8rq88ZFvR.VGG1KpDfXX))
						{
							EyxbpBGMcaXD02sIi7w.D35lls5iF(xrWtp71MaQsXtvtrqkf.D35lls5iF(Jr0pTQlovwB9pdID1EB.D35lls5iF(Jr0pTQlovwB9pdID1EB.CxrllgXtD4), xrWtp71MaQsXtvtrqkf.fxR1SMKb5A), iFZ5je3XFYKwkvcE5D.D35lls5iF(1844, iFZ5je3XFYKwkvcE5D.N06TeK0ao), eVlRnEIaHT0dqvCx0Kx.D35lls5iF(obj.iRAt4co51B, eVlRnEIaHT0dqvCx0Kx.F2h7ZIa1JG), EyxbpBGMcaXD02sIi7w.z9EGSdF6KF);
						}
						else
						{
							EyxbpBGMcaXD02sIi7w.D35lls5iF(xrWtp71MaQsXtvtrqkf.D35lls5iF(Jr0pTQlovwB9pdID1EB.D35lls5iF(Jr0pTQlovwB9pdID1EB.CxrllgXtD4), xrWtp71MaQsXtvtrqkf.fxR1SMKb5A), iFZ5je3XFYKwkvcE5D.D35lls5iF(1844, iFZ5je3XFYKwkvcE5D.N06TeK0ao), eVlRnEIaHT0dqvCx0Kx.D35lls5iF(obj.iRAt4co51B, eVlRnEIaHT0dqvCx0Kx.F2h7ZIa1JG), EyxbpBGMcaXD02sIi7w.y9uGuhNJgc);
						}
						if (GmMLaTD7kV8rq88ZFvR.D35lls5iF(xrWtp71MaQsXtvtrqkf.D35lls5iF(Jr0pTQlovwB9pdID1EB.D35lls5iF(Jr0pTQlovwB9pdID1EB.CxrllgXtD4), xrWtp71MaQsXtvtrqkf.fxR1SMKb5A), iFZ5je3XFYKwkvcE5D.D35lls5iF(1858, iFZ5je3XFYKwkvcE5D.N06TeK0ao), GmMLaTD7kV8rq88ZFvR.VGG1KpDfXX))
						{
							IDictionary dictionary = xrWtp71MaQsXtvtrqkf.D35lls5iF(Jr0pTQlovwB9pdID1EB.D35lls5iF(Jr0pTQlovwB9pdID1EB.CxrllgXtD4), xrWtp71MaQsXtvtrqkf.fxR1SMKb5A);
							string text2 = iFZ5je3XFYKwkvcE5D.D35lls5iF(1858, iFZ5je3XFYKwkvcE5D.N06TeK0ao);
							SecureString secureString2 = WdEd4P1YqUyNUXB2roT.D35lls5iF(obj.JrwtBfDBji, WdEd4P1YqUyNUXB2roT.pZP7jUsSAx);
							EyxbpBGMcaXD02sIi7w.D35lls5iF(dictionary, text2, (secureString2 != null) ? VetgaZ7ysHGTXnNjIwg.D35lls5iF(secureString2, VetgaZ7ysHGTXnNjIwg.Fyu7qWfhyV) : null, EyxbpBGMcaXD02sIi7w.z9EGSdF6KF);
						}
						else
						{
							IDictionary dictionary2 = xrWtp71MaQsXtvtrqkf.D35lls5iF(Jr0pTQlovwB9pdID1EB.D35lls5iF(Jr0pTQlovwB9pdID1EB.CxrllgXtD4), xrWtp71MaQsXtvtrqkf.fxR1SMKb5A);
							string text3 = iFZ5je3XFYKwkvcE5D.D35lls5iF(1858, iFZ5je3XFYKwkvcE5D.N06TeK0ao);
							SecureString secureString3 = WdEd4P1YqUyNUXB2roT.D35lls5iF(obj.JrwtBfDBji, WdEd4P1YqUyNUXB2roT.pZP7jUsSAx);
							EyxbpBGMcaXD02sIi7w.D35lls5iF(dictionary2, text3, (secureString3 != null) ? VetgaZ7ysHGTXnNjIwg.D35lls5iF(secureString3, VetgaZ7ysHGTXnNjIwg.Fyu7qWfhyV) : null, EyxbpBGMcaXD02sIi7w.y9uGuhNJgc);
						}
					}
					else
					{
						KBhlAv9D2TgBJ1kkc0B.D35lls5iF(xrWtp71MaQsXtvtrqkf.D35lls5iF(Jr0pTQlovwB9pdID1EB.D35lls5iF(Jr0pTQlovwB9pdID1EB.CxrllgXtD4), xrWtp71MaQsXtvtrqkf.fxR1SMKb5A), iFZ5je3XFYKwkvcE5D.D35lls5iF(1844, iFZ5je3XFYKwkvcE5D.N06TeK0ao), KBhlAv9D2TgBJ1kkc0B.ele7Frmq0T);
						KBhlAv9D2TgBJ1kkc0B.D35lls5iF(xrWtp71MaQsXtvtrqkf.D35lls5iF(Jr0pTQlovwB9pdID1EB.D35lls5iF(Jr0pTQlovwB9pdID1EB.CxrllgXtD4), xrWtp71MaQsXtvtrqkf.fxR1SMKb5A), iFZ5je3XFYKwkvcE5D.D35lls5iF(1858, iFZ5je3XFYKwkvcE5D.N06TeK0ao), KBhlAv9D2TgBJ1kkc0B.ele7Frmq0T);
					}
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(jyFC5J7bWr1L3ErASCB.D35lls5iF(AppContainer.Resolve<MainViewModel>(), jyFC5J7bWr1L3ErASCB.fGC7WLlh27), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
					if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
					{
						num = (tRP8p1ZCXQ = 1);
						kOj8XFqCM2 = awaiter;
						ixa8iDjovG.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_0392;
					IL_0392:
					oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
					end_IL_0015:;
				}
				catch (Exception ex2)
				{
					tRP8p1ZCXQ = -2;
					NNK1eXA7fWQ87oSUty7.D35lls5iF(ref ixa8iDjovG, ex2, NNK1eXA7fWQ87oSUty7.G3EAcW9Om7);
					return;
				}
				tRP8p1ZCXQ = -2;
				meFicnAMHIVtdhf671p.D35lls5iF(ref ixa8iDjovG, meFicnAMHIVtdhf671p.bsDASenQ5I);
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine P_0)
			{
				vxBFJcAKZoecNtbdqxt.D35lls5iF(ref ixa8iDjovG, P_0, vxBFJcAKZoecNtbdqxt.tuxANdhu18);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine P_0)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(P_0);
			}
		}

		public LoginViewModel iRAt4co51B;

		public IHavePassword JrwtBfDBji;

		public _003C_003Ec__DisplayClass14_0()
		{
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
			base._002Ector();
		}

		[AsyncStateMachine(typeof(W46IieTWrHUtGDt0ud))]
		internal Task E2etW02G91()
		{
			W46IieTWrHUtGDt0ud stateMachine = default(W46IieTWrHUtGDt0ud);
			stateMachine.ixa8iDjovG = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
			stateMachine.hLH83hlYrS = this;
			stateMachine.tRP8p1ZCXQ = -1;
			stateMachine.ixa8iDjovG.Start(ref stateMachine);
			return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine.ixa8iDjovG, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLogInCommandExcute_003Ed__14 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public LoginViewModel _003C_003E4__this;

		public IHavePassword obj;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			LoginViewModel loginViewModel = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_0102;
				}
				_003C_003Ec__DisplayClass14_0 CS_0024_003C_003E8__locals3 = new _003C_003Ec__DisplayClass14_0();
				CS_0024_003C_003E8__locals3.iRAt4co51B = _003C_003E4__this;
				CS_0024_003C_003E8__locals3.JrwtBfDBji = obj;
				if (!hjMnupQVVDlRZAYQJC.D35lls5iF(loginViewModel, hjMnupQVVDlRZAYQJC.jJYTSHn9tB))
				{
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(W7S2sip6SDieZFVsNbd.D35lls5iF(loginViewModel, Expression.Lambda<Func<bool>>(OWBKr5pvc5MWsK1OMtR.D35lls5iF(o4bYL4peNeC2wWb8yjx.D35lls5iF(loginViewModel, sjYxHO8OWlc6X80hFj7.D35lls5iF(typeof(LoginViewModel).TypeHandle, sjYxHO8OWlc6X80hFj7.uWZ8ugU7r5), o4bYL4peNeC2wWb8yjx.oVdpGKjy2x), (MethodInfo)f5q427pRQZnrEKPy4Ws.D35lls5iF((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, f5q427pRQZnrEKPy4Ws.Bo9pk3m4k7), OWBKr5pvc5MWsK1OMtR.fZIpAAdi1v), Array.Empty<ParameterExpression>()), [AsyncStateMachine(typeof(_003C_003Ec__DisplayClass14_0.W46IieTWrHUtGDt0ud))] () =>
					{
						_003C_003Ec__DisplayClass14_0.W46IieTWrHUtGDt0ud stateMachine = default(_003C_003Ec__DisplayClass14_0.W46IieTWrHUtGDt0ud);
						stateMachine.ixa8iDjovG = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
						stateMachine.hLH83hlYrS = CS_0024_003C_003E8__locals3;
						stateMachine.tRP8p1ZCXQ = -1;
						stateMachine.ixa8iDjovG.Start(ref stateMachine);
						return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine.ixa8iDjovG, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
					}, W7S2sip6SDieZFVsNbd.XWappgVyfh), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
					if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_0102;
				}
				goto end_IL_0015;
				IL_0102:
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

	private bool FKKDF0XhLS;

	private readonly IAuthService T6iD6DHeDi;

	[CompilerGenerated]
	private string PHEDsPyW23;

	[CompilerGenerated]
	private ICommand lHlDxwZMAL;

	public string Email
	{
		[CompilerGenerated]
		get
		{
			return PHEDsPyW23;
		}
		[CompilerGenerated]
		set
		{
			PHEDsPyW23 = value;
		}
	}

	public bool IsRememberMe
	{
		get
		{
			return FKKDF0XhLS;
		}
		set
		{
			FKKDF0XhLS = value;
			qni3xrDkAJ3vF35eMav.D35lls5iF(this, iFZ5je3XFYKwkvcE5D.D35lls5iF(10034, iFZ5je3XFYKwkvcE5D.N06TeK0ao), qni3xrDkAJ3vF35eMav.QN6DuDtCWO);
		}
	}

	public ICommand LoginCommand
	{
		[CompilerGenerated]
		get
		{
			return lHlDxwZMAL;
		}
		[CompilerGenerated]
		set
		{
			lHlDxwZMAL = value;
		}
	}

	public LoginViewModel()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector();
		Q3OeRSTq6SNsAFQUUoG.D35lls5iF(this, new AsyncCommand<IHavePassword>(LogInCommandExcute), Q3OeRSTq6SNsAFQUUoG.zpE4mjkjqn);
		T6iD6DHeDi = AppContainer.Resolve<IAuthService>();
	}

	[AsyncStateMachine(typeof(_003CLogInCommandExcute_003Ed__14))]
	public Task LogInCommandExcute(IHavePassword obj)
	{
		_003CLogInCommandExcute_003Ed__14 stateMachine = default(_003CLogInCommandExcute_003Ed__14);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine.obj = obj;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}
}
