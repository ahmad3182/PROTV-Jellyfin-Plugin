using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Input;
using PROTV.Abstractions.Apis;
using PROTV.Abstractions.Common;
using PROTV.Abstractions.DataTransferObjects;
using PROTV.Abstractions.Search;
using PROTV.Wpf.Bootstrap;
using PROTV.Wpf.ViewModels;

namespace PROTV.Wpf.Views;

public class MyListViewModel : BaseViewModel
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLoadAsync_003Ed__23 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MyListViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<ResponseList<MovieResponseDto>> _003C_003Eu__2;

		private IEnumerator<MovieResponseDto> _003C_003E7__wrap1;

		private MovieResponseDto _003Citem_003E5__3;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			MyListViewModel myListViewModel = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					if ((uint)(num - 1) <= 1u)
					{
						goto IL_0141;
					}
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(pvrKKy8Mk1kpdmIfp3A.D35lls5iF(300, pvrKKy8Mk1kpdmIfp3A.aVh8SPrFkE), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
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
				ea7QRb6syRyqquENsdu.D35lls5iF(myListViewModel, ea7QRb6syRyqquENsdu.yfd6hf7FM1).Clear();
				ApiQuery<MovieSearch, MovieSort> apiQuery = new ApiQuery<MovieSearch, MovieSort>
				{
					Search = new MovieSearch()
				};
				IMovieService movieService = AppContainer.Resolve<IMovieService>();
				apiQuery.Page = 1;
				apiQuery.Count = 25;
				apiQuery.Sort = MovieSort.ActivateDate;
				apiQuery.Order = SortOrder.Desc;
				wuXoja6xGA4YsTL6UdU.D35lls5iF(apiQuery.Search, null, wuXoja6xGA4YsTL6UdU.cAn6YY1406);
				wuXoja6xGA4YsTL6UdU.D35lls5iF(apiQuery.Search, null, wuXoja6xGA4YsTL6UdU.nfU6g7ujEw);
				hH6DVMBvgw3ANNRyBk6.D35lls5iF(apiQuery.Search, null, hH6DVMBvgw3ANNRyBk6.RRK6ishEFm);
				lASFo76QIUBEikAAsE9.D35lls5iF(apiQuery.Search, null, lASFo76QIUBEikAAsE9.UMA6X462Ew);
				goto IL_0141;
				IL_0141:
				try
				{
					TaskAwaiter<ResponseList<MovieResponseDto>> awaiter2;
					if (num != 1)
					{
						if (num == 2)
						{
							goto IL_01e3;
						}
						awaiter2 = uJ8tlJ6fZh5lIpltrW4.D35lls5iF(movieService, apiQuery, uJ8tlJ6fZh5lIpltrW4.XUv6FyAaBs).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = (_003C_003E1__state = 1);
							_003C_003Eu__2 = awaiter2;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						}
					}
					else
					{
						awaiter2 = _003C_003Eu__2;
						_003C_003Eu__2 = default(TaskAwaiter<ResponseList<MovieResponseDto>>);
						num = (_003C_003E1__state = -1);
					}
					ResponseList<MovieResponseDto> result = awaiter2.GetResult();
					if (result != null && result.Status)
					{
						_003C_003E7__wrap1 = result.Data.Result.GetEnumerator();
						goto IL_01e3;
					}
					goto end_IL_0141;
					IL_01e3:
					try
					{
						if (num != 2)
						{
							goto IL_0292;
						}
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter);
						num = (_003C_003E1__state = -1);
						goto IL_0269;
						IL_0269:
						oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
						ea7QRb6syRyqquENsdu.D35lls5iF(myListViewModel, ea7QRb6syRyqquENsdu.yfd6hf7FM1).Add(_003Citem_003E5__3);
						_003Citem_003E5__3 = null;
						goto IL_0292;
						IL_0292:
						if (hjMnupQVVDlRZAYQJC.D35lls5iF(_003C_003E7__wrap1, hjMnupQVVDlRZAYQJC.QV1TFwytOj))
						{
							_003Citem_003E5__3 = _003C_003E7__wrap1.Current;
							awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(pvrKKy8Mk1kpdmIfp3A.D35lls5iF(2, pvrKKy8Mk1kpdmIfp3A.aVh8SPrFkE), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
							if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
							{
								num = (_003C_003E1__state = 2);
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_0269;
						}
					}
					finally
					{
						if (num < 0 && _003C_003E7__wrap1 != null)
						{
							xLO56JniGyickVjO1Ot.D35lls5iF(_003C_003E7__wrap1, xLO56JniGyickVjO1Ot.ydbT2bsoH4);
						}
					}
					_003C_003E7__wrap1 = null;
					end_IL_0141:;
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
	private struct _003COnLoading_003Ed__24 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public MyListViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			MyListViewModel myListViewModel = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(CRMxYv82mIBQFuWGeba.D35lls5iF(myListViewModel, CRMxYv82mIBQFuWGeba.LkW62feTy1), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
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

	[CompilerGenerated]
	private ObservableCollection<MovieResponseDto> v9weEqFh8;

	[CompilerGenerated]
	private MovieResponseDto AEvOOqcXh;

	private bool pRQrXeheC;

	private MovieResponseDto dsSHZtuoq;

	[CompilerGenerated]
	private ICommand EGPoxB3v4;

	public ObservableCollection<MovieResponseDto> MovieList
	{
		[CompilerGenerated]
		get
		{
			return v9weEqFh8;
		}
		[CompilerGenerated]
		set
		{
			v9weEqFh8 = value;
		}
	}

	public bool LoadingIsRunning
	{
		get
		{
			return pRQrXeheC;
		}
		set
		{
			pRQrXeheC = value;
			qni3xrDkAJ3vF35eMav.D35lls5iF(this, iFZ5je3XFYKwkvcE5D.D35lls5iF(960, iFZ5je3XFYKwkvcE5D.N06TeK0ao), qni3xrDkAJ3vF35eMav.QN6DuDtCWO);
		}
	}

	public MovieResponseDto PreMovie
	{
		[CompilerGenerated]
		get
		{
			return AEvOOqcXh;
		}
		[CompilerGenerated]
		set
		{
			AEvOOqcXh = value;
		}
	}

	public MovieResponseDto SelectedMovie
	{
		get
		{
			return dsSHZtuoq;
		}
		set
		{
			if (dsSHZtuoq != value)
			{
				dsSHZtuoq = value;
				AJv70itXcdnxnNYjSQ.D35lls5iF(this, AJv70itXcdnxnNYjSQ.SrqDPDjOnV);
				qni3xrDkAJ3vF35eMav.D35lls5iF(this, iFZ5je3XFYKwkvcE5D.D35lls5iF(996, iFZ5je3XFYKwkvcE5D.N06TeK0ao), qni3xrDkAJ3vF35eMav.QN6DuDtCWO);
			}
		}
	}

	public ICommand PlayMovieCommand
	{
		[CompilerGenerated]
		get
		{
			return EGPoxB3v4;
		}
		[CompilerGenerated]
		set
		{
			EGPoxB3v4 = value;
		}
	}

	private void niXEeqxoN()
	{
	}

	private void cLq95qLuv()
	{
		sNF3tFDxPmlUJ5w8Ixu.D35lls5iF(this, TMNvN3DsY49dcntqfIs.D35lls5iF(this, TMNvN3DsY49dcntqfIs.YReDhjCwrj), sNF3tFDxPmlUJ5w8Ixu.e3GDYsApNl);
		qni3xrDkAJ3vF35eMav.D35lls5iF(this, iFZ5je3XFYKwkvcE5D.D35lls5iF(1026, iFZ5je3XFYKwkvcE5D.N06TeK0ao), qni3xrDkAJ3vF35eMav.QN6DuDtCWO);
		qni3xrDkAJ3vF35eMav.D35lls5iF(this, iFZ5je3XFYKwkvcE5D.D35lls5iF(1046, iFZ5je3XFYKwkvcE5D.N06TeK0ao), qni3xrDkAJ3vF35eMav.QN6DuDtCWO);
	}

	public MyListViewModel()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector();
		qb8eOQDg7MIaLGmcUoI.D35lls5iF(this, new ObservableCollection<MovieResponseDto>(), qb8eOQDg7MIaLGmcUoI.eJ2DiUiJ6k);
	}

	[AsyncStateMachine(typeof(_003CLoadAsync_003Ed__23))]
	public Task LoadAsync()
	{
		_003CLoadAsync_003Ed__23 stateMachine = default(_003CLoadAsync_003Ed__23);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	[AsyncStateMachine(typeof(_003COnLoading_003Ed__24))]
	public override void OnLoading()
	{
		_003COnLoading_003Ed__24 stateMachine = default(_003COnLoading_003Ed__24);
		stateMachine._003C_003Et__builder = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}
}
