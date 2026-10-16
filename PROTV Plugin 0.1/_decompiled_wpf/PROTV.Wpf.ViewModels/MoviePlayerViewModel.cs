using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using PROTV.Abstractions.Apis;
using PROTV.Abstractions.Common;
using PROTV.Abstractions.DataTransferObjects;
using PROTV.DataAccess;
using PROTV.Wpf.Bootstrap;

namespace PROTV.Wpf.ViewModels;

public class MoviePlayerViewModel : FFMEBaseViewModel<MovieResponseDto>
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLoadAsync_003Ed__26 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MoviePlayerViewModel _003C_003E4__this;

		public MovieResponseDto movie;

		public MoviePalyerType type;

		public RentResponseDto data;

		private void MoveNext()
		{
			MoviePlayerViewModel moviePlayerViewModel = _003C_003E4__this;
			try
			{
				try
				{
					sNF3tFDxPmlUJ5w8Ixu.D35lls5iF(moviePlayerViewModel, movie, sNF3tFDxPmlUJ5w8Ixu.z1wIgOqQvV);
					LmIq9GIiE2B4nT1mWuu.D35lls5iF(moviePlayerViewModel, type, LmIq9GIiE2B4nT1mWuu.axKIQgnalK);
					vv5IXxIXvd4NjTx2tvS.D35lls5iF(moviePlayerViewModel, data, vv5IXxIXvd4NjTx2tvS.DBlIfuvRYE);
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
	private struct _003COnLoading_003Ed__27 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public MoviePlayerViewModel _003C_003E4__this;

		private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			MoviePlayerViewModel moviePlayerViewModel = _003C_003E4__this;
			try
			{
				_ = 2;
				try
				{
					ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter awaiter;
					switch (num)
					{
					default:
						if (eLYdi6EfurHf7Oowrq2.D35lls5iF(moviePlayerViewModel, eLYdi6EfurHf7Oowrq2.RSxEFLx1px) == MoviePalyerType.Movie)
						{
							string uriString = pnvE8rm9NRTK7Tblimu.D35lls5iF(new Uri(UwSEfC4rh9eVlFenwI.D35lls5iF(eVlRnEIaHT0dqvCx0Kx.D35lls5iF(mj3KqGafEtImrSw4deR.D35lls5iF(slilrfIFuElyqvoQjqM.D35lls5iF(moviePlayerViewModel, slilrfIFuElyqvoQjqM.PwRI2ctggj), mj3KqGafEtImrSw4deR.u9nIZ7kA1i).FirstOrDefault(), eVlRnEIaHT0dqvCx0Kx.yCiIjncSix), "", UwSEfC4rh9eVlFenwI.J6G3NC9nSO)), pnvE8rm9NRTK7Tblimu.fnLajxXY1u);
							awaiter = mchHD5pbvoLh6YJmlai.D35lls5iF(moviePlayerViewModel.MediaElement, new Uri(uriString), mchHD5pbvoLh6YJmlai.ahJpW0oay7).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_00eb;
						}
						if (eLYdi6EfurHf7Oowrq2.D35lls5iF(moviePlayerViewModel, eLYdi6EfurHf7Oowrq2.RSxEFLx1px) == MoviePalyerType.Trailer)
						{
							string uriString2 = pnvE8rm9NRTK7Tblimu.D35lls5iF(new Uri(UwSEfC4rh9eVlFenwI.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(TMNvN3DsY49dcntqfIs.D35lls5iF(moviePlayerViewModel, TMNvN3DsY49dcntqfIs.HI0E2CRiBi), wq2usy8gNndpuTw5mR.tP04ccQgjp), QQLie3eYkZwbFFm9Jjw.D35lls5iF(TMNvN3DsY49dcntqfIs.D35lls5iF(moviePlayerViewModel, TMNvN3DsY49dcntqfIs.HI0E2CRiBi), QQLie3eYkZwbFFm9Jjw.T8RwSgEfbh), UwSEfC4rh9eVlFenwI.J6G3NC9nSO)), pnvE8rm9NRTK7Tblimu.fnLajxXY1u);
							awaiter = mchHD5pbvoLh6YJmlai.D35lls5iF(moviePlayerViewModel.MediaElement, new Uri(uriString2), mchHD5pbvoLh6YJmlai.ahJpW0oay7).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = (_003C_003E1__state = 1);
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_01b9;
						}
						if (eLYdi6EfurHf7Oowrq2.D35lls5iF(moviePlayerViewModel, eLYdi6EfurHf7Oowrq2.RSxEFLx1px) == MoviePalyerType.Song)
						{
							string uriString3 = pnvE8rm9NRTK7Tblimu.D35lls5iF(new Uri(UwSEfC4rh9eVlFenwI.D35lls5iF(eVlRnEIaHT0dqvCx0Kx.D35lls5iF(OH0EWKIy4OchbJiTHgM.D35lls5iF(moviePlayerViewModel, OH0EWKIy4OchbJiTHgM.XRbIqBEIOo), eVlRnEIaHT0dqvCx0Kx.l1fIJKa3gR), pnvE8rm9NRTK7Tblimu.D35lls5iF(OH0EWKIy4OchbJiTHgM.D35lls5iF(moviePlayerViewModel, OH0EWKIy4OchbJiTHgM.XRbIqBEIOo), pnvE8rm9NRTK7Tblimu.PhoI06dPjC), UwSEfC4rh9eVlFenwI.J6G3NC9nSO)), pnvE8rm9NRTK7Tblimu.fnLajxXY1u);
							awaiter = mchHD5pbvoLh6YJmlai.D35lls5iF(moviePlayerViewModel.MediaElement, new Uri(uriString3), mchHD5pbvoLh6YJmlai.ahJpW0oay7).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = (_003C_003E1__state = 2);
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							break;
						}
						goto end_IL_001a;
					case 0:
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter);
						num = (_003C_003E1__state = -1);
						goto IL_00eb;
					case 1:
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter);
						num = (_003C_003E1__state = -1);
						goto IL_01b9;
					case 2:
						{
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default(ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter);
							num = (_003C_003E1__state = -1);
							break;
						}
						IL_00eb:
						awaiter.GetResult();
						goto end_IL_001a;
						IL_01b9:
						awaiter.GetResult();
						goto end_IL_001a;
					}
					awaiter.GetResult();
					end_IL_001a:;
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
	private struct _003COnOpenCommandExcuteAsync_003Ed__28 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		private void MoveNext()
		{
			try
			{
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
	private struct _003CLoadAsync_003Ed__30 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MoviePlayerViewModel _003C_003E4__this;

		public SongResponseDto arg;

		private void MoveNext()
		{
			MoviePlayerViewModel moviePlayerViewModel = _003C_003E4__this;
			try
			{
				try
				{
					LmIq9GIiE2B4nT1mWuu.D35lls5iF(moviePlayerViewModel, MoviePalyerType.Song, LmIq9GIiE2B4nT1mWuu.axKIQgnalK);
					cDSC0uIbRZV94d31QoA.D35lls5iF(moviePlayerViewModel, arg, cDSC0uIbRZV94d31QoA.YGsIWKk8vX);
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

	private readonly IMovieService QLPVNwfKKP;

	private MovieResponseDto yLmVMPUIWn;

	[CompilerGenerated]
	private MoviePalyerType B6HVCeXIY9;

	[CompilerGenerated]
	private RentResponseDto bkaVYlhP5b;

	[CompilerGenerated]
	private double K7KVFnrBvN;

	[CompilerGenerated]
	private double DMNV6qMVK7;

	[CompilerGenerated]
	private SongResponseDto eHmVsZ2Oju;

	public MovieResponseDto Movie
	{
		get
		{
			return yLmVMPUIWn;
		}
		set
		{
			SetProperty(ref yLmVMPUIWn, value, iFZ5je3XFYKwkvcE5D.D35lls5iF(11698, iFZ5je3XFYKwkvcE5D.N06TeK0ao));
		}
	}

	public MoviePalyerType MoviePalyerType
	{
		[CompilerGenerated]
		get
		{
			return B6HVCeXIY9;
		}
		[CompilerGenerated]
		set
		{
			B6HVCeXIY9 = value;
		}
	}

	public RentResponseDto MovieData
	{
		[CompilerGenerated]
		get
		{
			return bkaVYlhP5b;
		}
		[CompilerGenerated]
		private set
		{
			bkaVYlhP5b = value;
		}
	}

	public double TotalSeconds
	{
		[CompilerGenerated]
		get
		{
			return K7KVFnrBvN;
		}
		[CompilerGenerated]
		set
		{
			K7KVFnrBvN = value;
		}
	}

	public double Position
	{
		[CompilerGenerated]
		get
		{
			return DMNV6qMVK7;
		}
		[CompilerGenerated]
		set
		{
			DMNV6qMVK7 = value;
		}
	}

	public SongResponseDto Song
	{
		[CompilerGenerated]
		get
		{
			return eHmVsZ2Oju;
		}
		[CompilerGenerated]
		private set
		{
			eHmVsZ2Oju = value;
		}
	}

	public MoviePlayerViewModel()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector();
		QLPVNwfKKP = AppContainer.Resolve<IMovieService>();
		base.PlayerPlaylistViewModel = new PlayerPlaylistViewModel<MovieResponseDto>(this);
		base.Controller = new ControllerViewModel<MovieResponseDto>(this)
		{
			SeekBarVisibility = Visibility.Collapsed,
			PostionProgressVisibility = Visibility.Collapsed
		};
	}

	[AsyncStateMachine(typeof(_003CLoadAsync_003Ed__26))]
	public Task LoadAsync(MoviePalyerType type, MovieResponseDto movie, RentResponseDto data)
	{
		_003CLoadAsync_003Ed__26 stateMachine = default(_003CLoadAsync_003Ed__26);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine.type = type;
		stateMachine.movie = movie;
		stateMachine.data = data;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	[AsyncStateMachine(typeof(_003COnLoading_003Ed__27))]
	public override void OnLoading()
	{
		_003COnLoading_003Ed__27 stateMachine = default(_003COnLoading_003Ed__27);
		stateMachine._003C_003Et__builder = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003COnOpenCommandExcuteAsync_003Ed__28))]
	public override void OnOpenCommandExcuteAsync(MovieResponseDto dto = null)
	{
		_003COnOpenCommandExcuteAsync_003Ed__28 stateMachine = default(_003COnOpenCommandExcuteAsync_003Ed__28);
		stateMachine._003C_003Et__builder = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	public override void SaveMediaItem(MovieResponseDto episode = null)
	{
		if (eLYdi6EfurHf7Oowrq2.D35lls5iF(this, eLYdi6EfurHf7Oowrq2.RSxEFLx1px) != MoviePalyerType.Movie)
		{
			return;
		}
		IClientDataStore clientDataStore = AppContainer.Resolve<IClientDataStore>();
		MoviePosition moviePosition = new MoviePosition();
		if (base.MediaElement != null && XLgPbA36DhJ4A0tFJ41.D35lls5iF(base.MediaElement, XLgPbA36DhJ4A0tFJ41.tP43pEUL5Y).HasValue)
		{
			if (episode == null || m9MGZR7k2RmVqYXYS5.D35lls5iF(episode, m9MGZR7k2RmVqYXYS5.j871CQO7pP) == 0)
			{
				vQKA0r9sJ1kArsIHc16.D35lls5iF(moviePosition, m9MGZR7k2RmVqYXYS5.D35lls5iF(TMNvN3DsY49dcntqfIs.D35lls5iF(this, TMNvN3DsY49dcntqfIs.HI0E2CRiBi), m9MGZR7k2RmVqYXYS5.j871CQO7pP), vQKA0r9sJ1kArsIHc16.wsPEZMwIPh);
				mAdJWQ9yhneCbEXlGMc.D35lls5iF(moviePosition, bATk1clKMSyO8g9EVbN.D35lls5iF(this, bATk1clKMSyO8g9EVbN.AK6EjX6Rn4), mAdJWQ9yhneCbEXlGMc.MyaEyFFaD3);
				mAdJWQ9yhneCbEXlGMc.D35lls5iF(moviePosition, bATk1clKMSyO8g9EVbN.D35lls5iF(this, bATk1clKMSyO8g9EVbN.V93Eqltuch), mAdJWQ9yhneCbEXlGMc.ew5EJPXkP2);
			}
			else
			{
				vQKA0r9sJ1kArsIHc16.D35lls5iF(moviePosition, m9MGZR7k2RmVqYXYS5.D35lls5iF(episode, m9MGZR7k2RmVqYXYS5.j871CQO7pP), vQKA0r9sJ1kArsIHc16.wsPEZMwIPh);
				mAdJWQ9yhneCbEXlGMc.D35lls5iF(moviePosition, bATk1clKMSyO8g9EVbN.D35lls5iF(this, bATk1clKMSyO8g9EVbN.AK6EjX6Rn4), mAdJWQ9yhneCbEXlGMc.MyaEyFFaD3);
				mAdJWQ9yhneCbEXlGMc.D35lls5iF(moviePosition, bATk1clKMSyO8g9EVbN.D35lls5iF(this, bATk1clKMSyO8g9EVbN.V93Eqltuch), mAdJWQ9yhneCbEXlGMc.ew5EJPXkP2);
			}
			if (bATk1clKMSyO8g9EVbN.D35lls5iF(moviePosition, bATk1clKMSyO8g9EVbN.EXVEbRTNDs) - bATk1clKMSyO8g9EVbN.D35lls5iF(moviePosition, bATk1clKMSyO8g9EVbN.yiiEWvK63c) >= 5.0 && bATk1clKMSyO8g9EVbN.D35lls5iF(moviePosition, bATk1clKMSyO8g9EVbN.yiiEWvK63c) >= 5.0)
			{
				mAdJWQ9yhneCbEXlGMc.D35lls5iF(moviePosition, bATk1clKMSyO8g9EVbN.D35lls5iF(moviePosition, bATk1clKMSyO8g9EVbN.yiiEWvK63c) - 2.0, mAdJWQ9yhneCbEXlGMc.MyaEyFFaD3);
				id9FOtE5M6ovr3jBZuf.D35lls5iF(clientDataStore, moviePosition, id9FOtE5M6ovr3jBZuf.iU5EzJPaXm);
			}
			else if (episode == null || m9MGZR7k2RmVqYXYS5.D35lls5iF(episode, m9MGZR7k2RmVqYXYS5.j871CQO7pP) == 0)
			{
				ShJD1fBoTHqWZbnMAIM.D35lls5iF(clientDataStore, m9MGZR7k2RmVqYXYS5.D35lls5iF(TMNvN3DsY49dcntqfIs.D35lls5iF(this, TMNvN3DsY49dcntqfIs.HI0E2CRiBi), m9MGZR7k2RmVqYXYS5.j871CQO7pP), ShJD1fBoTHqWZbnMAIM.JTIBlcAfan);
			}
			else
			{
				ShJD1fBoTHqWZbnMAIM.D35lls5iF(clientDataStore, m9MGZR7k2RmVqYXYS5.D35lls5iF(episode, m9MGZR7k2RmVqYXYS5.j871CQO7pP), ShJD1fBoTHqWZbnMAIM.JTIBlcAfan);
			}
		}
	}

	[AsyncStateMachine(typeof(_003CLoadAsync_003Ed__30))]
	internal Task zD0V55BBui(SongResponseDto P_0)
	{
		_003CLoadAsync_003Ed__30 stateMachine = default(_003CLoadAsync_003Ed__30);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine.arg = P_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}
}
