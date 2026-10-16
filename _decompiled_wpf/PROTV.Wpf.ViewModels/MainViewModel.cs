using System;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using PROTV.Abstractions.Common;
using PROTV.Abstractions.DataTransferObjects;
using PROTV.Abstractions.Services;
using PROTV.Wpf.Bootstrap;
using Refit;

namespace PROTV.Wpf.ViewModels;

public class MainViewModel : BaseViewModel
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CHandleLoginInBackgroundAsync_003Ed__19 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MainViewModel _003C_003E4__this;

		private TaskAwaiter<Response<LoginResponseDto>> _003C_003Eu__1;

		private TaskAwaiter<Response<PreferencesReponseDto>> _003C_003Eu__2;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			MainViewModel mainViewModel = _003C_003E4__this;
			try
			{
				_ = 1;
				try
				{
					TaskAwaiter<Response<PreferencesReponseDto>> awaiter;
					TaskAwaiter<Response<LoginResponseDto>> awaiter2;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = _003C_003Eu__2;
							_003C_003Eu__2 = default(TaskAwaiter<Response<PreferencesReponseDto>>);
							num = (_003C_003E1__state = -1);
							goto IL_0110;
						}
						awaiter2 = yxskx0pwLjG9rEc00mH.D35lls5iF(mainViewModel.ouWD3GYTV7, yxskx0pwLjG9rEc00mH.tVepC2VmMj).GetAwaiter();
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
						_003C_003Eu__1 = default(TaskAwaiter<Response<LoginResponseDto>>);
						num = (_003C_003E1__state = -1);
					}
					awaiter2.GetResult();
					mainViewModel.ouWD3GYTV7 = AppContainer.Resolve<IAuthService>();
					mainViewModel.M1VDm6qmIt = AppContainer.Resolve<IStoreContext>();
					AppContainer.Resolve<IAppService>();
					awaiter = nq6YXtwi8K8GrFsyRqR.D35lls5iF(mainViewModel.ouWD3GYTV7, nq6YXtwi8K8GrFsyRqR.bQHwQHDhdC).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_003C_003E1__state = 1);
						_003C_003Eu__2 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_0110;
					IL_0110:
					Response<PreferencesReponseDto> result = awaiter.GetResult();
					if (result.Status)
					{
						hH6DVMBvgw3ANNRyBk6.D35lls5iF(mainViewModel, d27jrd3uD0dgsTkvn8k.D35lls5iF(hjMnupQVVDlRZAYQJC.D35lls5iF(mainViewModel.M1VDm6qmIt, hjMnupQVVDlRZAYQJC.YLV3Oa3St2), QQLie3eYkZwbFFm9Jjw.D35lls5iF(P1dNdd4vZAyspU1imjK.D35lls5iF(result.Data, P1dNdd4vZAyspU1imjK.KhxwXY4Kd1), QQLie3eYkZwbFFm9Jjw.SdOwf2j5M1), d27jrd3uD0dgsTkvn8k.fC53Pw5IkY), hH6DVMBvgw3ANNRyBk6.AkWwFifAe3);
						TVpHI5w25Coc6cqCLM9.D35lls5iF(mainViewModel, ApplicationPage.Home, AppContainer.Resolve<HomeViewModel>(), TVpHI5w25Coc6cqCLM9.rEXwZFS3Hr);
					}
					else
					{
						gsYNF433WqUIGma3CNX.D35lls5iF(result.Message, "", gsYNF433WqUIGma3CNX.Ei5AVGtpvG);
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
	private struct _003CHandleSuccessfulLoginAsync_003Ed__20 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MainViewModel _003C_003E4__this;

		private TaskAwaiter<Response<PreferencesReponseDto>> _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			MainViewModel mainViewModel = _003C_003E4__this;
			try
			{
				try
				{
					TaskAwaiter<Response<PreferencesReponseDto>> awaiter;
					if (num != 0)
					{
						YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.UX2vYQhS88);
						mainViewModel.ouWD3GYTV7 = AppContainer.Resolve<IAuthService>();
						mainViewModel.M1VDm6qmIt = AppContainer.Resolve<IStoreContext>();
						AppContainer.Resolve<IAppService>();
						awaiter = nq6YXtwi8K8GrFsyRqR.D35lls5iF(mainViewModel.ouWD3GYTV7, nq6YXtwi8K8GrFsyRqR.bQHwQHDhdC).GetAwaiter();
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
						_003C_003Eu__1 = default(TaskAwaiter<Response<PreferencesReponseDto>>);
						num = (_003C_003E1__state = -1);
					}
					Response<PreferencesReponseDto> result = awaiter.GetResult();
					if (result.Status)
					{
						hH6DVMBvgw3ANNRyBk6.D35lls5iF(mainViewModel, d27jrd3uD0dgsTkvn8k.D35lls5iF(hjMnupQVVDlRZAYQJC.D35lls5iF(mainViewModel.M1VDm6qmIt, hjMnupQVVDlRZAYQJC.YLV3Oa3St2), QQLie3eYkZwbFFm9Jjw.D35lls5iF(P1dNdd4vZAyspU1imjK.D35lls5iF(result.Data, P1dNdd4vZAyspU1imjK.KhxwXY4Kd1), QQLie3eYkZwbFFm9Jjw.SdOwf2j5M1), d27jrd3uD0dgsTkvn8k.fC53Pw5IkY), hH6DVMBvgw3ANNRyBk6.AkWwFifAe3);
						TVpHI5w25Coc6cqCLM9.D35lls5iF(mainViewModel, ApplicationPage.Home, AppContainer.Resolve<HomeViewModel>(), TVpHI5w25Coc6cqCLM9.rEXwZFS3Hr);
					}
					else
					{
						gsYNF433WqUIGma3CNX.D35lls5iF(result.Message, "", gsYNF433WqUIGma3CNX.Ei5AVGtpvG);
					}
				}
				catch (PROTVException ex)
				{
					gsYNF433WqUIGma3CNX.D35lls5iF(QQLie3eYkZwbFFm9Jjw.D35lls5iF(ex, QQLie3eYkZwbFFm9Jjw.vZdwjWiy78), "", gsYNF433WqUIGma3CNX.Ei5AVGtpvG);
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

	private object PyKDpv6IRa;

	private string lI0Dip8BAe;

	private IAuthService ouWD3GYTV7;

	private IStoreContext M1VDm6qmIt;

	[CompilerGenerated]
	private ApplicationPage qGRDXogb5M;

	[CompilerGenerated]
	private BaseViewModel akyDR2XyFZ;

	public string BackgroundImage
	{
		get
		{
			return lI0Dip8BAe;
		}
		set
		{
			SetProperty(ref lI0Dip8BAe, value, iFZ5je3XFYKwkvcE5D.D35lls5iF(10062, iFZ5je3XFYKwkvcE5D.N06TeK0ao));
		}
	}

	public ApplicationPage CurrentPage
	{
		[CompilerGenerated]
		get
		{
			return qGRDXogb5M;
		}
		[CompilerGenerated]
		private set
		{
			qGRDXogb5M = value;
		}
	}

	public BaseViewModel CurrentPageViewModel
	{
		[CompilerGenerated]
		get
		{
			return akyDR2XyFZ;
		}
		[CompilerGenerated]
		set
		{
			akyDR2XyFZ = value;
		}
	}

	public object SubContent
	{
		get
		{
			return PyKDpv6IRa;
		}
		set
		{
			SetProperty(ref PyKDpv6IRa, value, iFZ5je3XFYKwkvcE5D.D35lls5iF(10096, iFZ5je3XFYKwkvcE5D.N06TeK0ao));
		}
	}

	public MainViewModel()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector();
		ouWD3GYTV7 = AppContainer.Resolve<IAuthService>();
		M1VDm6qmIt = AppContainer.Resolve<IStoreContext>();
	}

	[AsyncStateMachine(typeof(_003CHandleLoginInBackgroundAsync_003Ed__19))]
	public Task HandleLoginInBackgroundAsync()
	{
		_003CHandleLoginInBackgroundAsync_003Ed__19 stateMachine = default(_003CHandleLoginInBackgroundAsync_003Ed__19);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	[AsyncStateMachine(typeof(_003CHandleSuccessfulLoginAsync_003Ed__20))]
	public Task HandleSuccessfulLoginAsync()
	{
		_003CHandleSuccessfulLoginAsync_003Ed__20 stateMachine = default(_003CHandleSuccessfulLoginAsync_003Ed__20);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	public void GoToPage(ApplicationPage page, BaseViewModel viewModel = null)
	{
		HPaY7v4ahrafKGaWtLI.D35lls5iF(this, viewModel, HPaY7v4ahrafKGaWtLI.gKK4IL927p);
		qni3xrDkAJ3vF35eMav.D35lls5iF(this, iFZ5je3XFYKwkvcE5D.D35lls5iF(10120, iFZ5je3XFYKwkvcE5D.N06TeK0ao), qni3xrDkAJ3vF35eMav.QN6DuDtCWO);
		vQwwBH4ByM2YpSoWyIi.D35lls5iF(this, page, vQwwBH4ByM2YpSoWyIi.sCP4dlfbIy);
		qni3xrDkAJ3vF35eMav.D35lls5iF(this, iFZ5je3XFYKwkvcE5D.D35lls5iF(8494, iFZ5je3XFYKwkvcE5D.N06TeK0ao), qni3xrDkAJ3vF35eMav.QN6DuDtCWO);
	}

	internal async Task<bool> RefreshToken()
	{
		if (hjMnupQVVDlRZAYQJC.D35lls5iF(this, hjMnupQVVDlRZAYQJC.jJYTSHn9tB))
		{
			return false;
		}
		bool result = default(bool);
		object obj;
		int num;
		try
		{
			jPB9Q5LdIM9wsuWV1q7.D35lls5iF(this, true, jPB9Q5LdIM9wsuWV1q7.aFkwy5eHeO);
			await yxskx0pwLjG9rEc00mH.D35lls5iF(ouWD3GYTV7, yxskx0pwLjG9rEc00mH.tVepC2VmMj);
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.UX2vYQhS88);
			jPB9Q5LdIM9wsuWV1q7.D35lls5iF(this, false, jPB9Q5LdIM9wsuWV1q7.aFkwy5eHeO);
			result = true;
			return result;
		}
		catch (Exception ex)
		{
			obj = ex;
			num = 1;
		}
		if (num != 1)
		{
			return result;
		}
		if ((Exception)obj is ApiException ex2)
		{
			if (rHFZfHwqDgKaUI0M9eK.D35lls5iF(ex2, rHFZfHwqDgKaUI0M9eK.feqwJlSeYT) == HttpStatusCode.BadGateway)
			{
				jPB9Q5LdIM9wsuWV1q7.D35lls5iF(this, false, jPB9Q5LdIM9wsuWV1q7.aFkwy5eHeO);
				return false;
			}
			bool result2 = await bAA7Sxw7vZsvusOmDea.D35lls5iF(this, bAA7Sxw7vZsvusOmDea.BDNwbci909);
			jPB9Q5LdIM9wsuWV1q7.D35lls5iF(this, false, jPB9Q5LdIM9wsuWV1q7.aFkwy5eHeO);
			return result2;
		}
		jPB9Q5LdIM9wsuWV1q7.D35lls5iF(this, false, jPB9Q5LdIM9wsuWV1q7.aFkwy5eHeO);
		return false;
	}

	public async Task<bool> LogInInBackground()
	{
		string text = "";
		string text2 = "";
		if (GmMLaTD7kV8rq88ZFvR.D35lls5iF(xrWtp71MaQsXtvtrqkf.D35lls5iF(Jr0pTQlovwB9pdID1EB.D35lls5iF(Jr0pTQlovwB9pdID1EB.CxrllgXtD4), xrWtp71MaQsXtvtrqkf.fxR1SMKb5A), iFZ5je3XFYKwkvcE5D.D35lls5iF(1844, iFZ5je3XFYKwkvcE5D.N06TeK0ao), GmMLaTD7kV8rq88ZFvR.VGG1KpDfXX))
		{
			text = wq2usy8gNndpuTw5mR.D35lls5iF(auEPOZ1NWYKXdU711jq.D35lls5iF(xrWtp71MaQsXtvtrqkf.D35lls5iF(Jr0pTQlovwB9pdID1EB.D35lls5iF(Jr0pTQlovwB9pdID1EB.CxrllgXtD4), xrWtp71MaQsXtvtrqkf.fxR1SMKb5A), iFZ5je3XFYKwkvcE5D.D35lls5iF(1844, iFZ5je3XFYKwkvcE5D.N06TeK0ao), auEPOZ1NWYKXdU711jq.Y1J1OKa53W), wq2usy8gNndpuTw5mR.ajcDe8nffb);
		}
		if (GmMLaTD7kV8rq88ZFvR.D35lls5iF(xrWtp71MaQsXtvtrqkf.D35lls5iF(Jr0pTQlovwB9pdID1EB.D35lls5iF(Jr0pTQlovwB9pdID1EB.CxrllgXtD4), xrWtp71MaQsXtvtrqkf.fxR1SMKb5A), iFZ5je3XFYKwkvcE5D.D35lls5iF(1858, iFZ5je3XFYKwkvcE5D.N06TeK0ao), GmMLaTD7kV8rq88ZFvR.VGG1KpDfXX))
		{
			text2 = wq2usy8gNndpuTw5mR.D35lls5iF(auEPOZ1NWYKXdU711jq.D35lls5iF(xrWtp71MaQsXtvtrqkf.D35lls5iF(Jr0pTQlovwB9pdID1EB.D35lls5iF(Jr0pTQlovwB9pdID1EB.CxrllgXtD4), xrWtp71MaQsXtvtrqkf.fxR1SMKb5A), iFZ5je3XFYKwkvcE5D.D35lls5iF(1858, iFZ5je3XFYKwkvcE5D.N06TeK0ao), auEPOZ1NWYKXdU711jq.Y1J1OKa53W), wq2usy8gNndpuTw5mR.ajcDe8nffb);
		}
		try
		{
			Response<LoginResponseDto> response = await ObACkawWd8bljHnfOtb.D35lls5iF(ouWD3GYTV7, text, text2, ObACkawWd8bljHnfOtb.FcIw5dI8mG);
			if (response == null)
			{
				return false;
			}
			if (!response.Status)
			{
				gsYNF433WqUIGma3CNX.D35lls5iF(response.Message, "", gsYNF433WqUIGma3CNX.MAY3Ti847u);
				return false;
			}
		}
		catch (Exception)
		{
			vQwwBH4ByM2YpSoWyIi.D35lls5iF(this, ApplicationPage.Login, vQwwBH4ByM2YpSoWyIi.sCP4dlfbIy);
			qni3xrDkAJ3vF35eMav.D35lls5iF(this, iFZ5je3XFYKwkvcE5D.D35lls5iF(8494, iFZ5je3XFYKwkvcE5D.N06TeK0ao), qni3xrDkAJ3vF35eMav.QN6DuDtCWO);
			return false;
		}
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.UX2vYQhS88);
		ouWD3GYTV7 = AppContainer.Resolve<IAuthService>();
		M1VDm6qmIt = AppContainer.Resolve<IStoreContext>();
		return true;
	}
}
