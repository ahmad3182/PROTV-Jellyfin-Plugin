using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using PROTV.Abstractions.Apis;
using PROTV.Abstractions.Common;
using PROTV.Abstractions.DataTransferObjects;
using PROTV.Abstractions.Search;
using PROTV.Abstractions.Services;
using PROTV.DataAccess;
using PROTV.Wpf.Bootstrap;

namespace PROTV.Wpf.ViewModels;

public class SereisPlayerViewModel : FFMEBaseViewModel<EpisodeResponseDto>
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLoadAsync_003Ed__31 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public SereisPlayerViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			SereisPlayerViewModel CS_0024_003C_003E8__locals3 = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(W7S2sip6SDieZFVsNbd.D35lls5iF(CS_0024_003C_003E8__locals3, Expression.Lambda<Func<bool>>(OWBKr5pvc5MWsK1OMtR.D35lls5iF(o4bYL4peNeC2wWb8yjx.D35lls5iF(CS_0024_003C_003E8__locals3, sjYxHO8OWlc6X80hFj7.D35lls5iF(typeof(SereisPlayerViewModel).TypeHandle, sjYxHO8OWlc6X80hFj7.uWZ8ugU7r5), o4bYL4peNeC2wWb8yjx.oVdpGKjy2x), (MethodInfo)f5q427pRQZnrEKPy4Ws.D35lls5iF((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, f5q427pRQZnrEKPy4Ws.Bo9pk3m4k7), OWBKr5pvc5MWsK1OMtR.fZIpAAdi1v), Array.Empty<ParameterExpression>()), [AsyncStateMachine(typeof(_003C_003CLoadAsync_003Eb__31_1_003Ed))] () =>
					{
						_003C_003CLoadAsync_003Eb__31_1_003Ed stateMachine = default(_003C_003CLoadAsync_003Eb__31_1_003Ed);
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

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass33_0
	{
		public SereisPlayerViewModel egafuFt5OA;

		public EpisodeResponseDto CpufAY7KLS;

		public _003C_003Ec__DisplayClass33_0()
		{
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
			base._002Ector();
		}

		internal bool z09f5die1u(bool isConfirmed)
		{
			if (isConfirmed)
			{
				Task task = JN3OuGI5IJVx228kDoI.D35lls5iF(egafuFt5OA, CpufAY7KLS, JN3OuGI5IJVx228kDoI.IiIIzeG1nU);
				Action<Exception> action = null;
				bool flag = false;
				gBlEqv8jRKikCj2DMZp.D35lls5iF(task, ref action, ref flag, gBlEqv8jRKikCj2DMZp.pSp8ymt8Mu);
			}
			return true;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnOpenCommandExcuteAsync_003Ed__33 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public SereisPlayerViewModel _003C_003E4__this;

		public EpisodeResponseDto obj;

		private TaskAwaiter<Response<EpisodeResponseDto>> _003C_003Eu__1;

		private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter _003C_003Eu__2;

		private TaskAwaiter _003C_003Eu__3;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			SereisPlayerViewModel sereisPlayerViewModel = _003C_003E4__this;
			try
			{
				_003C_003Ec__DisplayClass33_0 obj = default(_003C_003Ec__DisplayClass33_0);
				if ((uint)num > 7u)
				{
					obj = new _003C_003Ec__DisplayClass33_0();
					obj.egafuFt5OA = _003C_003E4__this;
					obj.CpufAY7KLS = this.obj;
				}
				try
				{
					TaskAwaiter<Response<EpisodeResponseDto>> awaiter3;
					TaskAwaiter awaiter2;
					ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter awaiter;
					Response<EpisodeResponseDto> result;
					string uriString;
					Response<EpisodeResponseDto> result2;
					string uriString2;
					switch (num)
					{
					default:
					{
						if (slilrfIFuElyqvoQjqM.D35lls5iF(obj.CpufAY7KLS, slilrfIFuElyqvoQjqM.IHxdodh1Vs) != null)
						{
							awaiter3 = ajgL3fdlsvX2Ok2IeL0.D35lls5iF(sereisPlayerViewModel.GW1VocjvU2, m9MGZR7k2RmVqYXYS5.D35lls5iF(obj.CpufAY7KLS, m9MGZR7k2RmVqYXYS5.j871CQO7pP), ajgL3fdlsvX2Ok2IeL0.ajvd9Mg9PJ).GetAwaiter();
							if (!awaiter3.IsCompleted)
							{
								num = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter3;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
								return;
							}
							goto IL_00ea;
						}
						if (uN1DaxTm1XRIu0SSp7h.D35lls5iF(obj.CpufAY7KLS, uN1DaxTm1XRIu0SSp7h.qvednFgrpv) != MediaCost.Paid)
						{
							awaiter3 = ajgL3fdlsvX2Ok2IeL0.D35lls5iF(sereisPlayerViewModel.GW1VocjvU2, m9MGZR7k2RmVqYXYS5.D35lls5iF(obj.CpufAY7KLS, m9MGZR7k2RmVqYXYS5.j871CQO7pP), ajgL3fdlsvX2Ok2IeL0.ajvd9Mg9PJ).GetAwaiter();
							if (!awaiter3.IsCompleted)
							{
								num = (_003C_003E1__state = 4);
								_003C_003Eu__1 = awaiter3;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
								return;
							}
							goto IL_0443;
						}
						string[] obj2 = new string[5]
						{
							iFZ5je3XFYKwkvcE5D.D35lls5iF(16076, iFZ5je3XFYKwkvcE5D.N06TeK0ao),
							QQLie3eYkZwbFFm9Jjw.D35lls5iF(wFALqDnBsAqnd0Cclwg.D35lls5iF(sereisPlayerViewModel, wFALqDnBsAqnd0Cclwg.o0ad3Nri0R), QQLie3eYkZwbFFm9Jjw.D7uwK6SQ7w),
							iFZ5je3XFYKwkvcE5D.D35lls5iF(16140, iFZ5je3XFYKwkvcE5D.N06TeK0ao),
							null,
							null
						};
						int num2 = WJbFtI6AObf2rNffLCy.D35lls5iF(obj.CpufAY7KLS, WJbFtI6AObf2rNffLCy.nAEdTgTc0d);
						obj2[3] = E1oqfbTdQ1YrEeaxoPg.D35lls5iF(ref num2, E1oqfbTdQ1YrEeaxoPg.beYTUkKTth);
						obj2[4] = iFZ5je3XFYKwkvcE5D.D35lls5iF(16154, iFZ5je3XFYKwkvcE5D.N06TeK0ao);
						aOsAijCTnvLPVytuecl.D35lls5iF(EKUvcf6BZG4YrVDIJu7.D35lls5iF(obj2, EKUvcf6BZG4YrVDIJu7.lI660m0xwr), obj.z09f5die1u, "", aOsAijCTnvLPVytuecl.Qt4C45JP4A);
						goto end_IL_003b;
					}
					case 0:
						awaiter3 = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter<Response<EpisodeResponseDto>>);
						num = (_003C_003E1__state = -1);
						goto IL_00ea;
					case 1:
						awaiter = _003C_003Eu__2;
						_003C_003Eu__2 = default(ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter);
						num = (_003C_003E1__state = -1);
						goto IL_0224;
					case 2:
						awaiter2 = _003C_003Eu__3;
						_003C_003Eu__3 = default(TaskAwaiter);
						num = (_003C_003E1__state = -1);
						goto IL_0299;
					case 3:
						awaiter = _003C_003Eu__2;
						_003C_003Eu__2 = default(ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter);
						num = (_003C_003E1__state = -1);
						goto IL_030d;
					case 4:
						awaiter3 = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter<Response<EpisodeResponseDto>>);
						num = (_003C_003E1__state = -1);
						goto IL_0443;
					case 5:
						awaiter = _003C_003Eu__2;
						_003C_003Eu__2 = default(ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter);
						num = (_003C_003E1__state = -1);
						goto IL_054b;
					case 6:
						awaiter2 = _003C_003Eu__3;
						_003C_003Eu__3 = default(TaskAwaiter);
						num = (_003C_003E1__state = -1);
						goto IL_05c0;
					case 7:
						{
							awaiter = _003C_003Eu__2;
							_003C_003Eu__2 = default(ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter);
							num = (_003C_003E1__state = -1);
							break;
						}
						IL_05c0:
						oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter2, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
						awaiter = wd2eJ2Asf3I9epXUKxU.D35lls5iF(sereisPlayerViewModel.MediaElement, wd2eJ2Asf3I9epXUKxU.fTCmiFqqnh).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (_003C_003E1__state = 7);
							_003C_003Eu__2 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						break;
						IL_054b:
						awaiter.GetResult();
						awaiter2 = QliBEUviwWqgtMcBndV.D35lls5iF(pvrKKy8Mk1kpdmIfp3A.D35lls5iF(500, pvrKKy8Mk1kpdmIfp3A.aVh8SPrFkE), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
						if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter2, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
						{
							num = (_003C_003E1__state = 6);
							_003C_003Eu__3 = awaiter2;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						}
						goto IL_05c0;
						IL_00ea:
						result = awaiter3.GetResult();
						HwHG7ZaQ7c45wMQBnlK.D35lls5iF(sereisPlayerViewModel.PlayerPlaylistViewModel.SelectedItem, mN4twN37Cb4EtEpQsEk.D35lls5iF(result.Data, mN4twN37Cb4EtEpQsEk.zsxR158YYO), HwHG7ZaQ7c45wMQBnlK.pS3dDVmr4K);
						nDNQZEd1sCkKlmROARx.D35lls5iF(sereisPlayerViewModel.PlayerPlaylistViewModel.SelectedItem, mj3KqGafEtImrSw4deR.D35lls5iF(result.Data, mj3KqGafEtImrSw4deR.EjpdHitntL), nDNQZEd1sCkKlmROARx.bnNd8OW2Gf);
						uriString = pnvE8rm9NRTK7Tblimu.D35lls5iF(new Uri(UwSEfC4rh9eVlFenwI.D35lls5iF(eVlRnEIaHT0dqvCx0Kx.D35lls5iF(mj3KqGafEtImrSw4deR.D35lls5iF(sereisPlayerViewModel.PlayerPlaylistViewModel.SelectedItem, mj3KqGafEtImrSw4deR.EjpdHitntL).FirstOrDefault(), eVlRnEIaHT0dqvCx0Kx.yCiIjncSix) ?? eVlRnEIaHT0dqvCx0Kx.D35lls5iF(mj3KqGafEtImrSw4deR.D35lls5iF(slilrfIFuElyqvoQjqM.D35lls5iF(sereisPlayerViewModel.PlayerPlaylistViewModel.SelectedItem, slilrfIFuElyqvoQjqM.IHxdodh1Vs), mj3KqGafEtImrSw4deR.u9nIZ7kA1i).FirstOrDefault(), eVlRnEIaHT0dqvCx0Kx.yCiIjncSix), "", UwSEfC4rh9eVlFenwI.J6G3NC9nSO)), pnvE8rm9NRTK7Tblimu.fnLajxXY1u);
						awaiter = mchHD5pbvoLh6YJmlai.D35lls5iF(sereisPlayerViewModel.MediaElement, new Uri(uriString), mchHD5pbvoLh6YJmlai.ahJpW0oay7).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (_003C_003E1__state = 1);
							_003C_003Eu__2 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_0224;
						IL_030d:
						awaiter.GetResult();
						goto end_IL_003b;
						IL_0299:
						oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter2, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
						awaiter = wd2eJ2Asf3I9epXUKxU.D35lls5iF(sereisPlayerViewModel.MediaElement, wd2eJ2Asf3I9epXUKxU.fTCmiFqqnh).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (_003C_003E1__state = 3);
							_003C_003Eu__2 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_030d;
						IL_0443:
						result2 = awaiter3.GetResult();
						HwHG7ZaQ7c45wMQBnlK.D35lls5iF(sereisPlayerViewModel.PlayerPlaylistViewModel.SelectedItem, mN4twN37Cb4EtEpQsEk.D35lls5iF(result2.Data, mN4twN37Cb4EtEpQsEk.zsxR158YYO), HwHG7ZaQ7c45wMQBnlK.pS3dDVmr4K);
						nDNQZEd1sCkKlmROARx.D35lls5iF(sereisPlayerViewModel.PlayerPlaylistViewModel.SelectedItem, mj3KqGafEtImrSw4deR.D35lls5iF(result2.Data, mj3KqGafEtImrSw4deR.EjpdHitntL), nDNQZEd1sCkKlmROARx.bnNd8OW2Gf);
						uriString2 = pnvE8rm9NRTK7Tblimu.D35lls5iF(new Uri(UwSEfC4rh9eVlFenwI.D35lls5iF(eVlRnEIaHT0dqvCx0Kx.D35lls5iF(mj3KqGafEtImrSw4deR.D35lls5iF(sereisPlayerViewModel.PlayerPlaylistViewModel.SelectedItem, mj3KqGafEtImrSw4deR.EjpdHitntL).FirstOrDefault(), eVlRnEIaHT0dqvCx0Kx.yCiIjncSix), "", UwSEfC4rh9eVlFenwI.J6G3NC9nSO)), pnvE8rm9NRTK7Tblimu.fnLajxXY1u);
						awaiter = mchHD5pbvoLh6YJmlai.D35lls5iF(sereisPlayerViewModel.MediaElement, new Uri(uriString2), mchHD5pbvoLh6YJmlai.ahJpW0oay7).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (_003C_003E1__state = 5);
							_003C_003Eu__2 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_054b;
						IL_0224:
						awaiter.GetResult();
						awaiter2 = QliBEUviwWqgtMcBndV.D35lls5iF(pvrKKy8Mk1kpdmIfp3A.D35lls5iF(500, pvrKKy8Mk1kpdmIfp3A.aVh8SPrFkE), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
						if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter2, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
						{
							num = (_003C_003E1__state = 2);
							_003C_003Eu__3 = awaiter2;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						}
						goto IL_0299;
					}
					awaiter.GetResult();
					end_IL_003b:;
				}
				catch (Exception)
				{
				}
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
	private struct _003CRentEpisode_003Ed__34 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public SereisPlayerViewModel _003C_003E4__this;

		public EpisodeResponseDto episode;

		private bool _003CtryAgain_003E5__2;

		private object _003C_003E7__wrap2;

		private int _003C_003E7__wrap3;

		private TaskAwaiter<Response<RentResponseDto>> _003C_003Eu__1;

		private TaskAwaiter<Response<EpisodeResponseDto>> _003C_003Eu__2;

		private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter _003C_003Eu__3;

		private TaskAwaiter<bool> _003C_003Eu__4;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			SereisPlayerViewModel sereisPlayerViewModel = _003C_003E4__this;
			try
			{
				if ((uint)num <= 2u)
				{
					goto IL_003e;
				}
				if (num != 3)
				{
					_003CtryAgain_003E5__2 = true;
					goto IL_035b;
				}
				TaskAwaiter<bool> awaiter = _003C_003Eu__4;
				_003C_003Eu__4 = default(TaskAwaiter<bool>);
				num = (_003C_003E1__state = -1);
				goto IL_0300;
				IL_0354:
				_003C_003E7__wrap2 = null;
				goto IL_035b;
				IL_0300:
				if (awaiter.GetResult())
				{
					_003CtryAgain_003E5__2 = true;
					sereisPlayerViewModel.GW1VocjvU2 = AppContainer.Resolve<ISeasonService>();
					sereisPlayerViewModel.EnNVRunKmQ = AppContainer.Resolve<IStoreContext>();
					sereisPlayerViewModel.cN3VHyZnLE = AppContainer.Resolve<ISeriesService>();
				}
				goto IL_0354;
				IL_003e:
				try
				{
					TaskAwaiter<Response<RentResponseDto>> awaiter4;
					TaskAwaiter<Response<EpisodeResponseDto>> awaiter3;
					ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter awaiter2;
					Response<EpisodeResponseDto> result;
					string uriString;
					Response<RentResponseDto> result2;
					switch (num)
					{
					default:
						awaiter4 = sYW4HcCLj53QDe4wG8O.D35lls5iF(sereisPlayerViewModel.GW1VocjvU2, m9MGZR7k2RmVqYXYS5.D35lls5iF(episode, m9MGZR7k2RmVqYXYS5.j871CQO7pP), sYW4HcCLj53QDe4wG8O.T89d4kTn0P).GetAwaiter();
						if (!awaiter4.IsCompleted)
						{
							num = (_003C_003E1__state = 0);
							_003C_003Eu__1 = awaiter4;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
							return;
						}
						goto IL_00c1;
					case 0:
						awaiter4 = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter<Response<RentResponseDto>>);
						num = (_003C_003E1__state = -1);
						goto IL_00c1;
					case 1:
						awaiter3 = _003C_003Eu__2;
						_003C_003Eu__2 = default(TaskAwaiter<Response<EpisodeResponseDto>>);
						num = (_003C_003E1__state = -1);
						goto IL_0164;
					case 2:
						{
							awaiter2 = _003C_003Eu__3;
							_003C_003Eu__3 = default(ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter);
							num = (_003C_003E1__state = -1);
							break;
						}
						IL_0164:
						result = awaiter3.GetResult();
						HwHG7ZaQ7c45wMQBnlK.D35lls5iF(sereisPlayerViewModel.PlayerPlaylistViewModel.SelectedItem, mN4twN37Cb4EtEpQsEk.D35lls5iF(result.Data, mN4twN37Cb4EtEpQsEk.zsxR158YYO), HwHG7ZaQ7c45wMQBnlK.pS3dDVmr4K);
						uriString = pnvE8rm9NRTK7Tblimu.D35lls5iF(new Uri(UwSEfC4rh9eVlFenwI.D35lls5iF(eVlRnEIaHT0dqvCx0Kx.D35lls5iF(mj3KqGafEtImrSw4deR.D35lls5iF(slilrfIFuElyqvoQjqM.D35lls5iF(episode, slilrfIFuElyqvoQjqM.IHxdodh1Vs), mj3KqGafEtImrSw4deR.u9nIZ7kA1i).FirstOrDefault(), eVlRnEIaHT0dqvCx0Kx.yCiIjncSix), "", UwSEfC4rh9eVlFenwI.J6G3NC9nSO)), pnvE8rm9NRTK7Tblimu.fnLajxXY1u);
						awaiter2 = mchHD5pbvoLh6YJmlai.D35lls5iF(sereisPlayerViewModel.MediaElement, new Uri(uriString), mchHD5pbvoLh6YJmlai.ahJpW0oay7).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = (_003C_003E1__state = 2);
							_003C_003Eu__3 = awaiter2;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						}
						break;
						IL_00c1:
						result2 = awaiter4.GetResult();
						if (result2 != null && result2.Status)
						{
							vv5IXxIXvd4NjTx2tvS.D35lls5iF(episode, result2.Data, vv5IXxIXvd4NjTx2tvS.J9OdLCly4v);
							awaiter3 = ajgL3fdlsvX2Ok2IeL0.D35lls5iF(sereisPlayerViewModel.GW1VocjvU2, m9MGZR7k2RmVqYXYS5.D35lls5iF(episode, m9MGZR7k2RmVqYXYS5.j871CQO7pP), ajgL3fdlsvX2Ok2IeL0.ajvd9Mg9PJ).GetAwaiter();
							if (!awaiter3.IsCompleted)
							{
								num = (_003C_003E1__state = 1);
								_003C_003Eu__2 = awaiter3;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
								return;
							}
							goto IL_0164;
						}
						goto end_IL_003e;
					}
					awaiter2.GetResult();
					end_IL_003e:;
				}
				catch (PROTVException ex)
				{
					_003C_003E7__wrap2 = ex;
					_003C_003E7__wrap3 = 1;
				}
				int num2 = _003C_003E7__wrap3;
				if (num2 == 1)
				{
					PROTVException ex2 = (PROTVException)_003C_003E7__wrap2;
					if (TNckS5wtLfB2Lk9dYP8.D35lls5iF(ex2, TNckS5wtLfB2Lk9dYP8.oGkwV3iq3t) == ExceptionType.AuthorizationTokenInvalid)
					{
						awaiter = bAA7Sxw7vZsvusOmDea.D35lls5iF(AppContainer.Resolve<MainViewModel>(), bAA7Sxw7vZsvusOmDea.gytwc9U7r5).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (_003C_003E1__state = 3);
							_003C_003Eu__4 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_0300;
					}
					gsYNF433WqUIGma3CNX.D35lls5iF(QQLie3eYkZwbFFm9Jjw.D35lls5iF(ex2, QQLie3eYkZwbFFm9Jjw.vZdwjWiy78), "", gsYNF433WqUIGma3CNX.MAY3Ti847u);
				}
				goto IL_0354;
				IL_035b:
				if (_003CtryAgain_003E5__2)
				{
					_003CtryAgain_003E5__2 = false;
					_003C_003E7__wrap3 = 0;
					goto IL_003e;
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
	private struct _003C_003CLoadAsync_003Eb__31_1_003Ed : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public SereisPlayerViewModel _003C_003E4__this;

		private bool _003CtryAgain_003E5__2;

		private object _003C_003E7__wrap2;

		private int _003C_003E7__wrap3;

		private TaskAwaiter<Response<SeasonResponseDto>> _003C_003Eu__1;

		private TaskAwaiter<Response<SeriesResponseDto>> _003C_003Eu__2;

		private TaskAwaiter<ResponseList<EpisodeResponseDto>> _003C_003Eu__3;

		private TaskAwaiter<bool> _003C_003Eu__4;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			SereisPlayerViewModel CS_0024_003C_003E8__locals25 = _003C_003E4__this;
			try
			{
				if ((uint)num <= 2u)
				{
					goto IL_003e;
				}
				if (num != 3)
				{
					_003CtryAgain_003E5__2 = true;
					goto IL_0448;
				}
				TaskAwaiter<bool> awaiter = _003C_003Eu__4;
				_003C_003Eu__4 = default(TaskAwaiter<bool>);
				num = (_003C_003E1__state = -1);
				goto IL_040d;
				IL_0441:
				_003C_003E7__wrap2 = null;
				goto IL_0448;
				IL_040d:
				if (awaiter.GetResult())
				{
					_003CtryAgain_003E5__2 = true;
					CS_0024_003C_003E8__locals25.GW1VocjvU2 = AppContainer.Resolve<ISeasonService>();
					CS_0024_003C_003E8__locals25.EnNVRunKmQ = AppContainer.Resolve<IStoreContext>();
					CS_0024_003C_003E8__locals25.cN3VHyZnLE = AppContainer.Resolve<ISeriesService>();
				}
				goto IL_0441;
				IL_003e:
				try
				{
					TaskAwaiter<Response<SeasonResponseDto>> awaiter4;
					TaskAwaiter<Response<SeriesResponseDto>> awaiter3;
					TaskAwaiter<ResponseList<EpisodeResponseDto>> awaiter2;
					ISeasonService gW1VocjvU;
					ApiQuery<SeriesSearch, SeriesSort> apiQuery;
					SeriesSearch seriesSearch;
					Response<SeriesResponseDto> result;
					Response<SeasonResponseDto> result2;
					switch (num)
					{
					default:
						if (CS_0024_003C_003E8__locals25.oUHVg7YDoL != null)
						{
							awaiter4 = iKOxbndBxAauEpxcAg3.D35lls5iF(CS_0024_003C_003E8__locals25.GW1VocjvU2, WJbFtI6AObf2rNffLCy.D35lls5iF(CS_0024_003C_003E8__locals25.oUHVg7YDoL, WJbFtI6AObf2rNffLCy.ln3dEU8qV4), iKOxbndBxAauEpxcAg3.GDFd04bD1W).GetAwaiter();
							if (!awaiter4.IsCompleted)
							{
								num = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter4;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
								return;
							}
							goto IL_00cf;
						}
						goto IL_01ab;
					case 0:
						awaiter4 = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter<Response<SeasonResponseDto>>);
						num = (_003C_003E1__state = -1);
						goto IL_00cf;
					case 1:
						awaiter3 = _003C_003Eu__2;
						_003C_003Eu__2 = default(TaskAwaiter<Response<SeriesResponseDto>>);
						num = (_003C_003E1__state = -1);
						goto IL_015c;
					case 2:
						{
							awaiter2 = _003C_003Eu__3;
							_003C_003Eu__3 = default(TaskAwaiter<ResponseList<EpisodeResponseDto>>);
							num = (_003C_003E1__state = -1);
							break;
						}
						IL_01ab:
						gW1VocjvU = CS_0024_003C_003E8__locals25.GW1VocjvU2;
						apiQuery = new ApiQuery<SeriesSearch, SeriesSort>();
						seriesSearch = new SeriesSearch();
						wuXoja6xGA4YsTL6UdU.D35lls5iF(seriesSearch, m9MGZR7k2RmVqYXYS5.D35lls5iF(VAFQRsBLuCrswPTaruv.D35lls5iF(CS_0024_003C_003E8__locals25, VAFQRsBLuCrswPTaruv.OqPBEVMAfU), m9MGZR7k2RmVqYXYS5.j871CQO7pP), wuXoja6xGA4YsTL6UdU.TlUdRWKUyC);
						apiQuery.Search = seriesSearch;
						apiQuery.Count = -1;
						apiQuery.Sort = SeriesSort.Index;
						apiQuery.Order = SortOrder.Asc;
						awaiter2 = Hq6KPLdkBfHppWOifxV.D35lls5iF(gW1VocjvU, apiQuery, Hq6KPLdkBfHppWOifxV.wMgdv0gLrD).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = (_003C_003E1__state = 2);
							_003C_003Eu__3 = awaiter2;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						}
						break;
						IL_015c:
						result = awaiter3.GetResult();
						uHGYs3B9JpKth46xJKm.D35lls5iF(CS_0024_003C_003E8__locals25, result.Data, uHGYs3B9JpKth46xJKm.mB5BDBJk2t);
						qni3xrDkAJ3vF35eMav.D35lls5iF(CS_0024_003C_003E8__locals25, iFZ5je3XFYKwkvcE5D.D35lls5iF(16604, iFZ5je3XFYKwkvcE5D.N06TeK0ao), qni3xrDkAJ3vF35eMav.QN6DuDtCWO);
						qni3xrDkAJ3vF35eMav.D35lls5iF(CS_0024_003C_003E8__locals25, iFZ5je3XFYKwkvcE5D.D35lls5iF(9308, iFZ5je3XFYKwkvcE5D.N06TeK0ao), qni3xrDkAJ3vF35eMav.QN6DuDtCWO);
						goto IL_01ab;
						IL_00cf:
						result2 = awaiter4.GetResult();
						kuM3EQBH0UbvDtfO5X1.D35lls5iF(CS_0024_003C_003E8__locals25, result2.Data, kuM3EQBH0UbvDtfO5X1.uBwB1YwKkv);
						awaiter3 = GbNEqHdeg9aWJg16yF1.D35lls5iF(CS_0024_003C_003E8__locals25.cN3VHyZnLE, WJbFtI6AObf2rNffLCy.D35lls5iF(CS_0024_003C_003E8__locals25.oUHVg7YDoL, WJbFtI6AObf2rNffLCy.MNVdrIL81G), GbNEqHdeg9aWJg16yF1.hgAdGSyKHE).GetAwaiter();
						if (!awaiter3.IsCompleted)
						{
							num = (_003C_003E1__state = 1);
							_003C_003Eu__2 = awaiter3;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
							return;
						}
						goto IL_015c;
					}
					ResponseList<EpisodeResponseDto> result3 = awaiter2.GetResult();
					if (result3 != null && result3.Status)
					{
						IEnumerator<EpisodeResponseDto> enumerator = result3.Data.Result.GetEnumerator();
						try
						{
							while (hjMnupQVVDlRZAYQJC.D35lls5iF(enumerator, hjMnupQVVDlRZAYQJC.QV1TFwytOj))
							{
								EpisodeResponseDto current = enumerator.Current;
								CS_0024_003C_003E8__locals25.PlayerPlaylistViewModel.Items.Add(current);
							}
						}
						finally
						{
							if (num < 0 && enumerator != null)
							{
								xLO56JniGyickVjO1Ot.D35lls5iF(enumerator, xLO56JniGyickVjO1Ot.ydbT2bsoH4);
							}
						}
						if (CS_0024_003C_003E8__locals25.oUHVg7YDoL != null)
						{
							CS_0024_003C_003E8__locals25.PlayerPlaylistViewModel.SelectedItem = CS_0024_003C_003E8__locals25.PlayerPlaylistViewModel.Items.FirstOrDefault((EpisodeResponseDto P_0) => m9MGZR7k2RmVqYXYS5.D35lls5iF(P_0, m9MGZR7k2RmVqYXYS5.j871CQO7pP) == m9MGZR7k2RmVqYXYS5.D35lls5iF(CS_0024_003C_003E8__locals25.oUHVg7YDoL, m9MGZR7k2RmVqYXYS5.j871CQO7pP));
						}
						else if (C2LTiMBaSHbBnlQYfUZ.D35lls5iF(CS_0024_003C_003E8__locals25, C2LTiMBaSHbBnlQYfUZ.hs5BIHThy2) != null)
						{
							CS_0024_003C_003E8__locals25.PlayerPlaylistViewModel.SelectedItem = CS_0024_003C_003E8__locals25.PlayerPlaylistViewModel.Items.FirstOrDefault((EpisodeResponseDto P_0) => m9MGZR7k2RmVqYXYS5.D35lls5iF(P_0, m9MGZR7k2RmVqYXYS5.j871CQO7pP) == m9MGZR7k2RmVqYXYS5.D35lls5iF(C2LTiMBaSHbBnlQYfUZ.D35lls5iF(CS_0024_003C_003E8__locals25, C2LTiMBaSHbBnlQYfUZ.hs5BIHThy2), m9MGZR7k2RmVqYXYS5.j871CQO7pP));
						}
						else
						{
							CS_0024_003C_003E8__locals25.PlayerPlaylistViewModel.SelectedItem = CS_0024_003C_003E8__locals25.PlayerPlaylistViewModel.Items.FirstOrDefault();
						}
					}
				}
				catch (PROTVException ex)
				{
					_003C_003E7__wrap2 = ex;
					_003C_003E7__wrap3 = 1;
				}
				int num2 = _003C_003E7__wrap3;
				if (num2 == 1 && TNckS5wtLfB2Lk9dYP8.D35lls5iF((PROTVException)_003C_003E7__wrap2, TNckS5wtLfB2Lk9dYP8.oGkwV3iq3t) == ExceptionType.AuthorizationTokenInvalid)
				{
					awaiter = bAA7Sxw7vZsvusOmDea.D35lls5iF(AppContainer.Resolve<MainViewModel>(), bAA7Sxw7vZsvusOmDea.gytwc9U7r5).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_003C_003E1__state = 3);
						_003C_003Eu__4 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_040d;
				}
				goto IL_0441;
				IL_0448:
				if (_003CtryAgain_003E5__2)
				{
					_003CtryAgain_003E5__2 = false;
					_003C_003E7__wrap3 = 0;
					goto IL_003e;
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

	private IStoreContext EnNVRunKmQ;

	[CompilerGenerated]
	private SeriesResponseDto LDMVwkIr3a;

	[CompilerGenerated]
	private SeasonResponseDto islVEZ81vO;

	[CompilerGenerated]
	private EpisodeResponseDto zauV9UGQSD;

	[CompilerGenerated]
	private double UvBVeJb4Dv;

	[CompilerGenerated]
	private double yuMVOkZYja;

	[CompilerGenerated]
	private int JYaVrJ4X1A;

	private ISeriesService cN3VHyZnLE;

	private ISeasonService GW1VocjvU2;

	private EpisodeResponseDto oUHVg7YDoL;

	public SeriesResponseDto Series
	{
		[CompilerGenerated]
		get
		{
			return LDMVwkIr3a;
		}
		[CompilerGenerated]
		set
		{
			LDMVwkIr3a = value;
		}
	}

	public SeasonResponseDto Season
	{
		[CompilerGenerated]
		get
		{
			return islVEZ81vO;
		}
		[CompilerGenerated]
		set
		{
			islVEZ81vO = value;
		}
	}

	public EpisodeResponseDto Episode
	{
		[CompilerGenerated]
		get
		{
			return zauV9UGQSD;
		}
		[CompilerGenerated]
		set
		{
			zauV9UGQSD = value;
		}
	}

	public double Position
	{
		[CompilerGenerated]
		get
		{
			return UvBVeJb4Dv;
		}
		[CompilerGenerated]
		internal set
		{
			UvBVeJb4Dv = value;
		}
	}

	public double TotalSeconds
	{
		[CompilerGenerated]
		get
		{
			return yuMVOkZYja;
		}
		[CompilerGenerated]
		internal set
		{
			yuMVOkZYja = value;
		}
	}

	public int EpisodeId
	{
		[CompilerGenerated]
		get
		{
			return JYaVrJ4X1A;
		}
		[CompilerGenerated]
		internal set
		{
			JYaVrJ4X1A = value;
		}
	}

	public SereisPlayerViewModel()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector();
		cN3VHyZnLE = AppContainer.Resolve<ISeriesService>();
		GW1VocjvU2 = AppContainer.Resolve<ISeasonService>();
		EnNVRunKmQ = AppContainer.Resolve<IStoreContext>();
		base.PlayerPlaylistViewModel = new PlayerPlaylistViewModel<EpisodeResponseDto>(this);
		base.Controller = new ControllerViewModel<EpisodeResponseDto>(this)
		{
			SeekBarVisibility = Visibility.Visible,
			PostionProgressVisibility = Visibility.Visible
		};
	}

	public SereisPlayerViewModel(SeriesResponseDto series, SeasonResponseDto season, EpisodeResponseDto data)
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector();
		cN3VHyZnLE = AppContainer.Resolve<ISeriesService>();
		GW1VocjvU2 = AppContainer.Resolve<ISeasonService>();
		EnNVRunKmQ = AppContainer.Resolve<IStoreContext>();
		uHGYs3B9JpKth46xJKm.D35lls5iF(this, series, uHGYs3B9JpKth46xJKm.mB5BDBJk2t);
		kuM3EQBH0UbvDtfO5X1.D35lls5iF(this, season, kuM3EQBH0UbvDtfO5X1.uBwB1YwKkv);
		JSDi1RB8gXJHWZOYZlk.D35lls5iF(this, data, JSDi1RB8gXJHWZOYZlk.mIgBnO8k2G);
		base.PlayerPlaylistViewModel = new PlayerPlaylistViewModel<EpisodeResponseDto>(this);
		base.Controller = new ControllerViewModel<EpisodeResponseDto>(this)
		{
			SeekBarVisibility = Visibility.Visible,
			PostionProgressVisibility = Visibility.Visible
		};
	}

	public SereisPlayerViewModel(EpisodeResponseDto model)
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector();
		cN3VHyZnLE = AppContainer.Resolve<ISeriesService>();
		GW1VocjvU2 = AppContainer.Resolve<ISeasonService>();
		EnNVRunKmQ = AppContainer.Resolve<IStoreContext>();
		base.PlayerPlaylistViewModel = new PlayerPlaylistViewModel<EpisodeResponseDto>(this);
		base.Controller = new ControllerViewModel<EpisodeResponseDto>(this)
		{
			SeekBarVisibility = Visibility.Visible,
			PostionProgressVisibility = Visibility.Visible
		};
		oUHVg7YDoL = model;
	}

	[AsyncStateMachine(typeof(_003CLoadAsync_003Ed__31))]
	public Task LoadAsync()
	{
		_003CLoadAsync_003Ed__31 stateMachine = default(_003CLoadAsync_003Ed__31);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	public override void OnLoading()
	{
		if (!base.PlayerPlaylistViewModel.Items.Any())
		{
			Task task = CRMxYv82mIBQFuWGeba.D35lls5iF(this, CRMxYv82mIBQFuWGeba.gU5B3V1E85);
			Action<Exception> action = null;
			bool flag = false;
			gBlEqv8jRKikCj2DMZp.D35lls5iF(task, ref action, ref flag, gBlEqv8jRKikCj2DMZp.pSp8ymt8Mu);
		}
	}

	[AsyncStateMachine(typeof(_003COnOpenCommandExcuteAsync_003Ed__33))]
	public override void OnOpenCommandExcuteAsync(EpisodeResponseDto obj)
	{
		_003COnOpenCommandExcuteAsync_003Ed__33 stateMachine = default(_003COnOpenCommandExcuteAsync_003Ed__33);
		stateMachine._003C_003Et__builder = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
		stateMachine._003C_003E4__this = this;
		stateMachine.obj = obj;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003CRentEpisode_003Ed__34))]
	private Task MuRVxcQh9O(EpisodeResponseDto P_0)
	{
		_003CRentEpisode_003Ed__34 stateMachine = default(_003CRentEpisode_003Ed__34);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine.episode = P_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	public override void SaveMediaItem(EpisodeResponseDto episode = null)
	{
		IClientDataStore clientDataStore = AppContainer.Resolve<IClientDataStore>();
		SeriesPosition seriesPosition = new SeriesPosition();
		if (base.MediaElement != null && XLgPbA36DhJ4A0tFJ41.D35lls5iF(base.MediaElement, XLgPbA36DhJ4A0tFJ41.tP43pEUL5Y).HasValue)
		{
			if (episode == null || m9MGZR7k2RmVqYXYS5.D35lls5iF(episode, m9MGZR7k2RmVqYXYS5.j871CQO7pP) == 0)
			{
				vQKA0r9sJ1kArsIHc16.D35lls5iF(seriesPosition, m9MGZR7k2RmVqYXYS5.D35lls5iF(this, m9MGZR7k2RmVqYXYS5.O4RBTpcxES), vQKA0r9sJ1kArsIHc16.lGLB4G5oin);
				vQKA0r9sJ1kArsIHc16.D35lls5iF(seriesPosition, m9MGZR7k2RmVqYXYS5.D35lls5iF(VAFQRsBLuCrswPTaruv.D35lls5iF(this, VAFQRsBLuCrswPTaruv.OqPBEVMAfU), m9MGZR7k2RmVqYXYS5.j871CQO7pP), vQKA0r9sJ1kArsIHc16.sk3BBPr8ec);
				mAdJWQ9yhneCbEXlGMc.D35lls5iF(seriesPosition, bATk1clKMSyO8g9EVbN.D35lls5iF(this, bATk1clKMSyO8g9EVbN.fntB05QBEy), mAdJWQ9yhneCbEXlGMc.Wx1Br216LF);
				mAdJWQ9yhneCbEXlGMc.D35lls5iF(seriesPosition, bATk1clKMSyO8g9EVbN.D35lls5iF(this, bATk1clKMSyO8g9EVbN.yV4BeqtFyP), mAdJWQ9yhneCbEXlGMc.lH0BGiZXte);
				DateTime dateTime = BvlWxPl1hnvXiXiwcCq.D35lls5iF(BvlWxPl1hnvXiXiwcCq.YfD1XHDES3);
				hH6DVMBvgw3ANNRyBk6.D35lls5iF(seriesPosition, fNOtTvBRlJl1wiCtiT0.D35lls5iF(ref dateTime, fNOtTvBRlJl1wiCtiT0.vheBkNUNof), hH6DVMBvgw3ANNRyBk6.bcwBAjveny);
			}
			else
			{
				vQKA0r9sJ1kArsIHc16.D35lls5iF(seriesPosition, m9MGZR7k2RmVqYXYS5.D35lls5iF(episode, m9MGZR7k2RmVqYXYS5.j871CQO7pP), vQKA0r9sJ1kArsIHc16.lGLB4G5oin);
				vQKA0r9sJ1kArsIHc16.D35lls5iF(seriesPosition, m9MGZR7k2RmVqYXYS5.D35lls5iF(VAFQRsBLuCrswPTaruv.D35lls5iF(this, VAFQRsBLuCrswPTaruv.OqPBEVMAfU), m9MGZR7k2RmVqYXYS5.j871CQO7pP), vQKA0r9sJ1kArsIHc16.sk3BBPr8ec);
				mAdJWQ9yhneCbEXlGMc.D35lls5iF(seriesPosition, bATk1clKMSyO8g9EVbN.D35lls5iF(this, bATk1clKMSyO8g9EVbN.fntB05QBEy), mAdJWQ9yhneCbEXlGMc.Wx1Br216LF);
				mAdJWQ9yhneCbEXlGMc.D35lls5iF(seriesPosition, bATk1clKMSyO8g9EVbN.D35lls5iF(this, bATk1clKMSyO8g9EVbN.yV4BeqtFyP), mAdJWQ9yhneCbEXlGMc.lH0BGiZXte);
				DateTime dateTime = BvlWxPl1hnvXiXiwcCq.D35lls5iF(BvlWxPl1hnvXiXiwcCq.YfD1XHDES3);
				hH6DVMBvgw3ANNRyBk6.D35lls5iF(seriesPosition, fNOtTvBRlJl1wiCtiT0.D35lls5iF(ref dateTime, fNOtTvBRlJl1wiCtiT0.vheBkNUNof), hH6DVMBvgw3ANNRyBk6.bcwBAjveny);
			}
			if (bATk1clKMSyO8g9EVbN.D35lls5iF(seriesPosition, bATk1clKMSyO8g9EVbN.Ra2B6jGYDB) - bATk1clKMSyO8g9EVbN.D35lls5iF(seriesPosition, bATk1clKMSyO8g9EVbN.sSHBpJLQZw) >= 5.0 && bATk1clKMSyO8g9EVbN.D35lls5iF(seriesPosition, bATk1clKMSyO8g9EVbN.sSHBpJLQZw) >= 5.0)
			{
				mAdJWQ9yhneCbEXlGMc.D35lls5iF(seriesPosition, bATk1clKMSyO8g9EVbN.D35lls5iF(seriesPosition, bATk1clKMSyO8g9EVbN.sSHBpJLQZw) - 2.0, mAdJWQ9yhneCbEXlGMc.Wx1Br216LF);
				PR3dsWBw6quxkTnnudj.D35lls5iF(clientDataStore, seriesPosition, PR3dsWBw6quxkTnnudj.FlJBCYs2rB);
			}
			else if (episode == null || m9MGZR7k2RmVqYXYS5.D35lls5iF(episode, m9MGZR7k2RmVqYXYS5.j871CQO7pP) == 0)
			{
				ShJD1fBoTHqWZbnMAIM.D35lls5iF(clientDataStore, m9MGZR7k2RmVqYXYS5.D35lls5iF(this, m9MGZR7k2RmVqYXYS5.O4RBTpcxES), ShJD1fBoTHqWZbnMAIM.nT6BmQNo6F);
			}
			else
			{
				ShJD1fBoTHqWZbnMAIM.D35lls5iF(clientDataStore, m9MGZR7k2RmVqYXYS5.D35lls5iF(episode, m9MGZR7k2RmVqYXYS5.j871CQO7pP), ShJD1fBoTHqWZbnMAIM.nT6BmQNo6F);
			}
		}
	}

	[AsyncStateMachine(typeof(_003C_003CLoadAsync_003Eb__31_1_003Ed))]
	[CompilerGenerated]
	private Task b6KVyI9u0I()
	{
		_003C_003CLoadAsync_003Eb__31_1_003Ed stateMachine = default(_003C_003CLoadAsync_003Eb__31_1_003Ed);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	[CompilerGenerated]
	private bool NkHVpjJisE(EpisodeResponseDto P_0)
	{
		return m9MGZR7k2RmVqYXYS5.D35lls5iF(P_0, m9MGZR7k2RmVqYXYS5.j871CQO7pP) == m9MGZR7k2RmVqYXYS5.D35lls5iF(oUHVg7YDoL, m9MGZR7k2RmVqYXYS5.j871CQO7pP);
	}

	[CompilerGenerated]
	private bool csTVi4OCZl(EpisodeResponseDto P_0)
	{
		return m9MGZR7k2RmVqYXYS5.D35lls5iF(P_0, m9MGZR7k2RmVqYXYS5.j871CQO7pP) == m9MGZR7k2RmVqYXYS5.D35lls5iF(C2LTiMBaSHbBnlQYfUZ.D35lls5iF(this, C2LTiMBaSHbBnlQYfUZ.hs5BIHThy2), m9MGZR7k2RmVqYXYS5.j871CQO7pP);
	}
}
