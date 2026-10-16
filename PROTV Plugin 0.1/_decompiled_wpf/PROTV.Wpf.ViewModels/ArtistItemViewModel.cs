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
using PROTV.Abstractions.Common;
using PROTV.Abstractions.DataTransferObjects;
using PROTV.Abstractions.Search;
using PROTV.Abstractions.Services;
using PROTV.Wpf.Bootstrap;
using PROTV.Wpf.Views;

namespace PROTV.Wpf.ViewModels;

public class ArtistItemViewModel : BaseViewModel
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass15_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct P2j8tumYCOZq3pm8F6 : IAsyncStateMachine
		{
			public int D0gb5psZi6;

			public AsyncTaskMethodBuilder uglbuEvCwM;

			public _003C_003Ec__DisplayClass15_0 yCPbA3kEfT;

			private HomeViewModel b6wbN9UAMD;

			private MainPlayerViewModel aOIbMyQRVM;

			private TaskAwaiter da0bC9ob1C;

			private void MoveNext()
			{
				int num = D0gb5psZi6;
				_003C_003Ec__DisplayClass15_0 obj = yCPbA3kEfT;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						b6wbN9UAMD = Sp7dKWL9ZfBld4JOkGo.D35lls5iF(AppContainer.Resolve<MainViewModel>(), Sp7dKWL9ZfBld4JOkGo.QpWwMTMAhO) as HomeViewModel;
						aOIbMyQRVM = MI3oOiHCZASyM6ERRUP.D35lls5iF(b6wbN9UAMD, MI3oOiHCZASyM6ERRUP.h0JHmOSEFB);
						awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(LoKHJec9qUyy294NoZ5.D35lls5iF(aOIbMyQRVM, MusicType.Album, m9MGZR7k2RmVqYXYS5.D35lls5iF(obj.EjMSnKN5yh, m9MGZR7k2RmVqYXYS5.j871CQO7pP), pnvE8rm9NRTK7Tblimu.D35lls5iF(obj.EjMSnKN5yh, pnvE8rm9NRTK7Tblimu.DQ6IGCcPAn), V4VMaWmQYRpUqEIxujB.D35lls5iF(obj.EjMSnKN5yh, V4VMaWmQYRpUqEIxujB.cEiclwJvUW), null, null, LoKHJec9qUyy294NoZ5.FXGcDq3bhE), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
						if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
						{
							num = (D0gb5psZi6 = 0);
							da0bC9ob1C = awaiter;
							uglbuEvCwM.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = da0bC9ob1C;
						da0bC9ob1C = default(TaskAwaiter);
						num = (D0gb5psZi6 = -1);
					}
					oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
					Page page = new Page();
					KBhlAv9D2TgBJ1kkc0B.D35lls5iF(page, IyGDDwHBiPv8vfOFJDF.D35lls5iF(ApplicationPage.PlayListDetailsView, aOIbMyQRVM, IyGDDwHBiPv8vfOFJDF.hivH0XYhaE), KBhlAv9D2TgBJ1kkc0B.fWUHrWO7Sa);
					qni3xrDkAJ3vF35eMav.D35lls5iF(page, EBgwuVHeVLDJVVfMaAk.D35lls5iF(ApplicationPage.PlayListDetailsView, EBgwuVHeVLDJVVfMaAk.mtcHG3MEy3), qni3xrDkAJ3vF35eMav.Ra7HRFTvnD);
					Page page2 = page;
					GmMLaTD7kV8rq88ZFvR.D35lls5iF(Xlypb0Hnr2C3ydrYEdG.D35lls5iF(b6wbN9UAMD, Xlypb0Hnr2C3ydrYEdG.U3Z1IKMGuZ), page2, GmMLaTD7kV8rq88ZFvR.iMJHkmaaRY);
				}
				catch (Exception ex)
				{
					D0gb5psZi6 = -2;
					b6wbN9UAMD = null;
					aOIbMyQRVM = null;
					NNK1eXA7fWQ87oSUty7.D35lls5iF(ref uglbuEvCwM, ex, NNK1eXA7fWQ87oSUty7.G3EAcW9Om7);
					return;
				}
				D0gb5psZi6 = -2;
				b6wbN9UAMD = null;
				aOIbMyQRVM = null;
				meFicnAMHIVtdhf671p.D35lls5iF(ref uglbuEvCwM, meFicnAMHIVtdhf671p.bsDASenQ5I);
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine P_0)
			{
				vxBFJcAKZoecNtbdqxt.D35lls5iF(ref uglbuEvCwM, P_0, vxBFJcAKZoecNtbdqxt.tuxANdhu18);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine P_0)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(P_0);
			}
		}

		[StructLayout(LayoutKind.Auto)]
		private struct GZF58oXetCD4gQELfe : IAsyncStateMachine
		{
			public int XLcbYPwxd4;

			public AsyncVoidMethodBuilder RbibFtBgT6;

			public _003C_003Ec__DisplayClass15_0 A6fb6fWX4s;

			private TaskAwaiter onlbsKPXM9;

			private void MoveNext()
			{
				int num = XLcbYPwxd4;
				_003C_003Ec__DisplayClass15_0 CS_0024_003C_003E8__locals4 = A6fb6fWX4s;
				try
				{
					TaskAwaiter awaiter;
					if (num == 0)
					{
						awaiter = onlbsKPXM9;
						onlbsKPXM9 = default(TaskAwaiter);
						num = (XLcbYPwxd4 = -1);
						goto IL_00fa;
					}
					if (CS_0024_003C_003E8__locals4.EjMSnKN5yh != null)
					{
						awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(W7S2sip6SDieZFVsNbd.D35lls5iF(CS_0024_003C_003E8__locals4.bKMSbews9Q, Expression.Lambda<Func<bool>>(OWBKr5pvc5MWsK1OMtR.D35lls5iF(o4bYL4peNeC2wWb8yjx.D35lls5iF(CS_0024_003C_003E8__locals4.bKMSbews9Q, sjYxHO8OWlc6X80hFj7.D35lls5iF(typeof(ArtistItemViewModel).TypeHandle, sjYxHO8OWlc6X80hFj7.uWZ8ugU7r5), o4bYL4peNeC2wWb8yjx.oVdpGKjy2x), (MethodInfo)f5q427pRQZnrEKPy4Ws.D35lls5iF((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, f5q427pRQZnrEKPy4Ws.Bo9pk3m4k7), OWBKr5pvc5MWsK1OMtR.fZIpAAdi1v), Array.Empty<ParameterExpression>()), [AsyncStateMachine(typeof(P2j8tumYCOZq3pm8F6))] () =>
						{
							P2j8tumYCOZq3pm8F6 stateMachine = default(P2j8tumYCOZq3pm8F6);
							stateMachine.uglbuEvCwM = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
							stateMachine.yCPbA3kEfT = CS_0024_003C_003E8__locals4;
							stateMachine.D0gb5psZi6 = -1;
							stateMachine.uglbuEvCwM.Start(ref stateMachine);
							return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine.uglbuEvCwM, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
						}, W7S2sip6SDieZFVsNbd.XWappgVyfh), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
						if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
						{
							num = (XLcbYPwxd4 = 0);
							onlbsKPXM9 = awaiter;
							RbibFtBgT6.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_00fa;
					}
					goto end_IL_0015;
					IL_00fa:
					oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
					end_IL_0015:;
				}
				catch (Exception ex)
				{
					XLcbYPwxd4 = -2;
					N2XUglA3neBsnlZfRPQ.D35lls5iF(ref RbibFtBgT6, ex, N2XUglA3neBsnlZfRPQ.l4pATRumoW);
					return;
				}
				XLcbYPwxd4 = -2;
				T4XmPoA4VNJJP1afcgL.D35lls5iF(ref RbibFtBgT6, T4XmPoA4VNJJP1afcgL.TRyALZckCh);
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine P_0)
			{
				dHWo7jAEn6E4X7bsY4R.D35lls5iF(ref RbibFtBgT6, P_0, dHWo7jAEn6E4X7bsY4R.z3hAB6UZ9o);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine P_0)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(P_0);
			}
		}

		public AlbumResponseDto EjMSnKN5yh;

		public ArtistItemViewModel bKMSbews9Q;

		public Func<Task> z9JS7vNob9;

		public _003C_003Ec__DisplayClass15_0()
		{
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
			base._002Ector();
		}

		[AsyncStateMachine(typeof(GZF58oXetCD4gQELfe))]
		internal void Ca8S83JWZY()
		{
			GZF58oXetCD4gQELfe stateMachine = default(GZF58oXetCD4gQELfe);
			stateMachine.RbibFtBgT6 = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
			stateMachine.A6fb6fWX4s = this;
			stateMachine.XLcbYPwxd4 = -1;
			stateMachine.RbibFtBgT6.Start(ref stateMachine);
		}

		[AsyncStateMachine(typeof(P2j8tumYCOZq3pm8F6))]
		internal Task SETSQ8FuVP()
		{
			P2j8tumYCOZq3pm8F6 stateMachine = default(P2j8tumYCOZq3pm8F6);
			stateMachine.uglbuEvCwM = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
			stateMachine.yCPbA3kEfT = this;
			stateMachine.D0gb5psZi6 = -1;
			stateMachine.uglbuEvCwM.Start(ref stateMachine);
			return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine.uglbuEvCwM, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLoadAsync_003Ed__18 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ArtistItemViewModel _003C_003E4__this;

		private TaskAwaiter<ResponseList<AlbumResponseDto>> _003C_003Eu__1;

		private IEnumerator<AlbumResponseDto> _003C_003E7__wrap1;

		private AlbumResponseDto _003Citem_003E5__3;

		private TaskAwaiter _003C_003Eu__2;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ArtistItemViewModel artistItemViewModel = _003C_003E4__this;
			try
			{
				ApiQuery<AlbumSearch, GeneralSort> apiQuery2 = default(ApiQuery<AlbumSearch, GeneralSort>);
				if ((uint)num > 1u)
				{
					ApiQuery<AlbumSearch, GeneralSort> apiQuery = new ApiQuery<AlbumSearch, GeneralSort>();
					AlbumSearch albumSearch = new AlbumSearch();
					wuXoja6xGA4YsTL6UdU.D35lls5iF(albumSearch, m9MGZR7k2RmVqYXYS5.D35lls5iF(YB7MtsmAPEP4jmeVkvE.D35lls5iF(artistItemViewModel, YB7MtsmAPEP4jmeVkvE.hvbm6Z0fXR), m9MGZR7k2RmVqYXYS5.j871CQO7pP), wuXoja6xGA4YsTL6UdU.cZEmp8QQUQ);
					apiQuery.Search = albumSearch;
					apiQuery.Count = -1;
					apiQuery2 = apiQuery;
				}
				try
				{
					TaskAwaiter<ResponseList<AlbumResponseDto>> awaiter;
					if (num != 0)
					{
						if (num == 1)
						{
							goto IL_00fc;
						}
						awaiter = mDcRsUm0AcZTH9WQKpJ.D35lls5iF(artistItemViewModel.zCHPun7hsc, apiQuery2, mDcRsUm0AcZTH9WQKpJ.OxQmrL4qwZ).GetAwaiter();
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
						_003C_003Eu__1 = default(TaskAwaiter<ResponseList<AlbumResponseDto>>);
						num = (_003C_003E1__state = -1);
					}
					ResponseList<AlbumResponseDto> result = awaiter.GetResult();
					if (result != null && result.Status)
					{
						_003C_003E7__wrap1 = result.Data.Result.GetEnumerator();
						goto IL_00fc;
					}
					goto end_IL_005a;
					IL_00fc:
					try
					{
						if (num != 1)
						{
							goto IL_01ab;
						}
						TaskAwaiter awaiter2 = _003C_003Eu__2;
						_003C_003Eu__2 = default(TaskAwaiter);
						num = (_003C_003E1__state = -1);
						goto IL_0182;
						IL_0182:
						oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter2, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
						M5s2SDLxNQs9bMYcKO3.D35lls5iF(artistItemViewModel, M5s2SDLxNQs9bMYcKO3.lOYLYcghV4).Add(_003Citem_003E5__3);
						_003Citem_003E5__3 = null;
						goto IL_01ab;
						IL_01ab:
						if (hjMnupQVVDlRZAYQJC.D35lls5iF(_003C_003E7__wrap1, hjMnupQVVDlRZAYQJC.QV1TFwytOj))
						{
							_003Citem_003E5__3 = _003C_003E7__wrap1.Current;
							awaiter2 = QliBEUviwWqgtMcBndV.D35lls5iF(pvrKKy8Mk1kpdmIfp3A.D35lls5iF(2, pvrKKy8Mk1kpdmIfp3A.aVh8SPrFkE), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
							if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter2, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
							{
								num = (_003C_003E1__state = 1);
								_003C_003Eu__2 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
							goto IL_0182;
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
					end_IL_005a:;
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

	[CompilerGenerated]
	private ObservableCollection<AlbumResponseDto> b8QP78mk0J;

	[CompilerGenerated]
	private PersonResponseDto wlTP5RiIM6;

	private readonly IMusicService zCHPun7hsc;

	[CompilerGenerated]
	private readonly bool FqjPAY3Exv;

	private AlbumResponseDto wgxPN4hUfV;

	public ObservableCollection<AlbumResponseDto> Items
	{
		[CompilerGenerated]
		get
		{
			return b8QP78mk0J;
		}
		[CompilerGenerated]
		set
		{
			b8QP78mk0J = value;
		}
	}

	public PersonResponseDto Person
	{
		[CompilerGenerated]
		get
		{
			return wlTP5RiIM6;
		}
		[CompilerGenerated]
		set
		{
			wlTP5RiIM6 = value;
		}
	}

	public bool IsQuran
	{
		[CompilerGenerated]
		get
		{
			return FqjPAY3Exv;
		}
	}

	public AlbumResponseDto SelectedItem
	{
		get
		{
			return wgxPN4hUfV;
		}
		set
		{
			_003C_003Ec__DisplayClass15_0 CS_0024_003C_003E8__locals4 = new _003C_003Ec__DisplayClass15_0();
			CS_0024_003C_003E8__locals4.EjMSnKN5yh = value;
			CS_0024_003C_003E8__locals4.bKMSbews9Q = this;
			SetProperty(ref wgxPN4hUfV, CS_0024_003C_003E8__locals4.EjMSnKN5yh, iFZ5je3XFYKwkvcE5D.D35lls5iF(8274, iFZ5je3XFYKwkvcE5D.N06TeK0ao), null, [AsyncStateMachine(typeof(_003C_003Ec__DisplayClass15_0.GZF58oXetCD4gQELfe))] () =>
			{
				_003C_003Ec__DisplayClass15_0.GZF58oXetCD4gQELfe stateMachine = default(_003C_003Ec__DisplayClass15_0.GZF58oXetCD4gQELfe);
				stateMachine.RbibFtBgT6 = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
				stateMachine.A6fb6fWX4s = CS_0024_003C_003E8__locals4;
				stateMachine.XLcbYPwxd4 = -1;
				stateMachine.RbibFtBgT6.Start(ref stateMachine);
			});
		}
	}

	public ArtistItemViewModel(PersonResponseDto person)
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector();
		zCHPun7hsc = AppContainer.Resolve<IMusicService>();
		cYGis3LOVnKSSmLjKOF.D35lls5iF(this, person, cYGis3LOVnKSSmLjKOF.mZkLuTlwBX);
		FqjPAY3Exv = uEUVCI48fycroqgRFqy.D35lls5iF(this, uEUVCI48fycroqgRFqy.rdpLPNF1SA);
		lfJOd4LsykVOlE42407.D35lls5iF(this, new ObservableCollection<AlbumResponseDto>(), lfJOd4LsykVOlE42407.qZ4LhLsDY3);
		qni3xrDkAJ3vF35eMav.D35lls5iF(this, iFZ5je3XFYKwkvcE5D.D35lls5iF(10612, iFZ5je3XFYKwkvcE5D.N06TeK0ao), qni3xrDkAJ3vF35eMav.QN6DuDtCWO);
	}

	public ArtistItemViewModel()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector();
		cYGis3LOVnKSSmLjKOF.D35lls5iF(this, new PersonResponseDto(), cYGis3LOVnKSSmLjKOF.mZkLuTlwBX);
		lfJOd4LsykVOlE42407.D35lls5iF(this, new ObservableCollection<AlbumResponseDto>(), lfJOd4LsykVOlE42407.qZ4LhLsDY3);
	}

	[AsyncStateMachine(typeof(_003CLoadAsync_003Ed__18))]
	public Task LoadAsync()
	{
		_003CLoadAsync_003Ed__18 stateMachine = default(_003CLoadAsync_003Ed__18);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	public void Clear()
	{
		wgxPN4hUfV = null;
	}

	public override void OnLoading()
	{
		wgxPN4hUfV = null;
		qni3xrDkAJ3vF35eMav.D35lls5iF(this, iFZ5je3XFYKwkvcE5D.D35lls5iF(8274, iFZ5je3XFYKwkvcE5D.N06TeK0ao), qni3xrDkAJ3vF35eMav.QN6DuDtCWO);
		if (!M5s2SDLxNQs9bMYcKO3.D35lls5iF(this, M5s2SDLxNQs9bMYcKO3.lOYLYcghV4).Any())
		{
			Task task = CRMxYv82mIBQFuWGeba.D35lls5iF(this, CRMxYv82mIBQFuWGeba.Ii6Lgiy2b8);
			Action<Exception> action = null;
			bool flag = false;
			gBlEqv8jRKikCj2DMZp.D35lls5iF(task, ref action, ref flag, gBlEqv8jRKikCj2DMZp.pSp8ymt8Mu);
		}
	}
}
