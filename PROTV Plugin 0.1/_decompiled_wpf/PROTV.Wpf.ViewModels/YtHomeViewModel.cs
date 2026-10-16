using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using PROTV.Abstractions.Common;
using PROTV.Abstractions.DataTransferObjects;
using PROTV.Abstractions.Helpers;
using PROTV.Abstractions.Services;
using PROTV.Wpf.Bootstrap;

namespace PROTV.Wpf.ViewModels;

public class YtHomeViewModel : BaseViewModel
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct nlhSFDjdI1OIRmbCQat : IAsyncStateMachine
		{
			public int xaE5C7hb9O;

			public AsyncVoidMethodBuilder WuQ5YqhIh6;

			public _003C_003Ec__DisplayClass14_0 qdH5FoLJwu;

			private YtVideoPlayerViewModel drX56s3yaw;

			private Page iPk5s4KiaY;

			private TaskAwaiter Jiu5xm4Tk1;

			private void MoveNext()
			{
				int num = xaE5C7hb9O;
				_003C_003Ec__DisplayClass14_0 obj = qdH5FoLJwu;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = Jiu5xm4Tk1;
							Jiu5xm4Tk1 = default(TaskAwaiter);
							num = (xaE5C7hb9O = -1);
							goto IL_014f;
						}
						drX56s3yaw = new YtVideoPlayerViewModel();
						awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(hnVdJ7tlwwTQvJJ7Vha.D35lls5iF(drX56s3yaw, obj.XXIKsP5xiU, hnVdJ7tlwwTQvJJ7Vha.oXrt9biorg), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
						if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
						{
							num = (xaE5C7hb9O = 0);
							Jiu5xm4Tk1 = awaiter;
							WuQ5YqhIh6.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = Jiu5xm4Tk1;
						Jiu5xm4Tk1 = default(TaskAwaiter);
						num = (xaE5C7hb9O = -1);
					}
					oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
					Page page = new Page();
					KBhlAv9D2TgBJ1kkc0B.D35lls5iF(page, IyGDDwHBiPv8vfOFJDF.D35lls5iF(ApplicationPage.YoutubePlayer, drX56s3yaw, IyGDDwHBiPv8vfOFJDF.hivH0XYhaE), KBhlAv9D2TgBJ1kkc0B.fWUHrWO7Sa);
					qni3xrDkAJ3vF35eMav.D35lls5iF(page, EBgwuVHeVLDJVVfMaAk.D35lls5iF(ApplicationPage.YoutubePlayer, EBgwuVHeVLDJVVfMaAk.mtcHG3MEy3), qni3xrDkAJ3vF35eMav.Ra7HRFTvnD);
					iPk5s4KiaY = page;
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(pvrKKy8Mk1kpdmIfp3A.D35lls5iF(5, pvrKKy8Mk1kpdmIfp3A.aVh8SPrFkE), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
					if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
					{
						num = (xaE5C7hb9O = 1);
						Jiu5xm4Tk1 = awaiter;
						WuQ5YqhIh6.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_014f;
					IL_014f:
					oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
					GmMLaTD7kV8rq88ZFvR.D35lls5iF(Xlypb0Hnr2C3ydrYEdG.D35lls5iF(obj.QnmKxMkRVo.Tqx081sfTf, Xlypb0Hnr2C3ydrYEdG.U3Z1IKMGuZ), iPk5s4KiaY, GmMLaTD7kV8rq88ZFvR.iMJHkmaaRY);
				}
				catch (Exception ex)
				{
					xaE5C7hb9O = -2;
					drX56s3yaw = null;
					iPk5s4KiaY = null;
					N2XUglA3neBsnlZfRPQ.D35lls5iF(ref WuQ5YqhIh6, ex, N2XUglA3neBsnlZfRPQ.l4pATRumoW);
					return;
				}
				xaE5C7hb9O = -2;
				drX56s3yaw = null;
				iPk5s4KiaY = null;
				T4XmPoA4VNJJP1afcgL.D35lls5iF(ref WuQ5YqhIh6, T4XmPoA4VNJJP1afcgL.TRyALZckCh);
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine P_0)
			{
				dHWo7jAEn6E4X7bsY4R.D35lls5iF(ref WuQ5YqhIh6, P_0, dHWo7jAEn6E4X7bsY4R.z3hAB6UZ9o);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine P_0)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(P_0);
			}
		}

		public YTVideoResponseDto XXIKsP5xiU;

		public YtHomeViewModel QnmKxMkRVo;

		public _003C_003Ec__DisplayClass14_0()
		{
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
			base._002Ector();
		}

		[AsyncStateMachine(typeof(nlhSFDjdI1OIRmbCQat))]
		internal void luxK617tMs()
		{
			nlhSFDjdI1OIRmbCQat stateMachine = default(nlhSFDjdI1OIRmbCQat);
			stateMachine.WuQ5YqhIh6 = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
			stateMachine.qdH5FoLJwu = this;
			stateMachine.xaE5C7hb9O = -1;
			stateMachine.WuQ5YqhIh6.Start(ref stateMachine);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnGoToChannelCommandExcute_003Ed__21 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public YtHomeViewModel _003C_003E4__this;

		public YTVideoResponseDto obj;

		private void MoveNext()
		{
			YtHomeViewModel ytHomeViewModel = _003C_003E4__this;
			try
			{
				vQKA0r9sJ1kArsIHc16.D35lls5iF(ytHomeViewModel.u0a0kSa5df, lVnioXU659dV87DBnh4.D35lls5iF(obj, lVnioXU659dV87DBnh4.xygUgLZL5h), vQKA0r9sJ1kArsIHc16.IogUiUt4Qi);
				m5sZxWmLHUhVHrJe8sC.D35lls5iF(ytHomeViewModel.u0a0kSa5df, iFZ5je3XFYKwkvcE5D.D35lls5iF(14394, iFZ5je3XFYKwkvcE5D.N06TeK0ao), m5sZxWmLHUhVHrJe8sC.DWQUQPjnyY);
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
	private struct _003COnWatchLaterCommandExcute_003Ed__22 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public YtHomeViewModel _003C_003E4__this;

		public YTVideoResponseDto obj;

		private TaskAwaiter<bool> _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			YtHomeViewModel ytHomeViewModel = _003C_003E4__this;
			try
			{
				TaskAwaiter<bool> awaiter;
				if (num != 0)
				{
					awaiter = VbmtIFmnFwg9sqb4Jje.D35lls5iF(ytHomeViewModel.MM50fJWhuF, m9MGZR7k2RmVqYXYS5.D35lls5iF(obj, m9MGZR7k2RmVqYXYS5.r6tnXN0WTV), VbmtIFmnFwg9sqb4Jje.i4xUIaDACp).GetAwaiter();
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
	private struct _003CLoadAsync_003Ed__23 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public YtHomeViewModel _003C_003E4__this;

		private bool _003CtryAgain_003E5__2;

		private object _003C_003E7__wrap2;

		private int _003C_003E7__wrap3;

		private TaskAwaiter<Response<YTHomePageResponseDto>> _003C_003Eu__1;

		private TaskAwaiter<bool> _003C_003Eu__2;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			YtHomeViewModel ytHomeViewModel = _003C_003E4__this;
			try
			{
				if (num == 0)
				{
					goto IL_004d;
				}
				if (num != 1)
				{
					DPIKBM0VjkZEfamh1w9.D35lls5iF(ytHomeViewModel, DPIKBM0VjkZEfamh1w9.nD607Wma2d).Clear();
					_003CtryAgain_003E5__2 = true;
					goto IL_02d9;
				}
				TaskAwaiter<bool> awaiter = _003C_003Eu__2;
				_003C_003Eu__2 = default(TaskAwaiter<bool>);
				num = (_003C_003E1__state = -1);
				goto IL_02b4;
				IL_02d2:
				_003C_003E7__wrap2 = null;
				goto IL_02d9;
				IL_02b4:
				if (awaiter.GetResult())
				{
					_003CtryAgain_003E5__2 = true;
					ytHomeViewModel.MM50fJWhuF = AppContainer.Resolve<IYoutubeService>();
				}
				goto IL_02d2;
				IL_004d:
				try
				{
					TaskAwaiter<Response<YTHomePageResponseDto>> awaiter2;
					if (num != 0)
					{
						awaiter2 = tSjF5fUXG3GtpeqyZjl.D35lls5iF(ytHomeViewModel.MM50fJWhuF, tSjF5fUXG3GtpeqyZjl.AgNUfOnBBj).GetAwaiter();
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
						_003C_003Eu__1 = default(TaskAwaiter<Response<YTHomePageResponseDto>>);
						num = (_003C_003E1__state = -1);
					}
					Response<YTHomePageResponseDto> result = awaiter2.GetResult();
					if (result != null && result.Status)
					{
						if (R8oVZNUFXmHMNyrRp4t.D35lls5iF(result.Data, R8oVZNUFXmHMNyrRp4t.wEiU2FLf18).Count() > 0)
						{
							ObservableCollection<YTPlaylisTResponseDto> observableCollection = DPIKBM0VjkZEfamh1w9.D35lls5iF(ytHomeViewModel, DPIKBM0VjkZEfamh1w9.nD607Wma2d);
							YTPlaylisTResponseDto yTPlaylisTResponseDto = new YTPlaylisTResponseDto();
							uRjvKHUZWaiotKwavc3.D35lls5iF(yTPlaylisTResponseDto, R8oVZNUFXmHMNyrRp4t.D35lls5iF(result.Data, R8oVZNUFXmHMNyrRp4t.wEiU2FLf18).ToList(), uRjvKHUZWaiotKwavc3.U70Ujkwo4Q);
							m5sZxWmLHUhVHrJe8sC.D35lls5iF(yTPlaylisTResponseDto, iFZ5je3XFYKwkvcE5D.D35lls5iF(16044, iFZ5je3XFYKwkvcE5D.N06TeK0ao), m5sZxWmLHUhVHrJe8sC.TPrUyH5SJo);
							observableCollection.Add(yTPlaylisTResponseDto);
						}
						if (R8oVZNUFXmHMNyrRp4t.D35lls5iF(result.Data, R8oVZNUFXmHMNyrRp4t.MuFUqtaZNe).Count() > 0)
						{
							ObservableCollection<YTPlaylisTResponseDto> observableCollection2 = DPIKBM0VjkZEfamh1w9.D35lls5iF(ytHomeViewModel, DPIKBM0VjkZEfamh1w9.nD607Wma2d);
							YTPlaylisTResponseDto yTPlaylisTResponseDto2 = new YTPlaylisTResponseDto();
							uRjvKHUZWaiotKwavc3.D35lls5iF(yTPlaylisTResponseDto2, R8oVZNUFXmHMNyrRp4t.D35lls5iF(result.Data, R8oVZNUFXmHMNyrRp4t.MuFUqtaZNe).ToList(), uRjvKHUZWaiotKwavc3.U70Ujkwo4Q);
							m5sZxWmLHUhVHrJe8sC.D35lls5iF(yTPlaylisTResponseDto2, iFZ5je3XFYKwkvcE5D.D35lls5iF(16666, iFZ5je3XFYKwkvcE5D.N06TeK0ao), m5sZxWmLHUhVHrJe8sC.TPrUyH5SJo);
							observableCollection2.Add(yTPlaylisTResponseDto2);
						}
						if (R8oVZNUFXmHMNyrRp4t.D35lls5iF(result.Data, R8oVZNUFXmHMNyrRp4t.oXGUJUMuXl).Count() > 0)
						{
							ObservableCollection<YTPlaylisTResponseDto> observableCollection3 = DPIKBM0VjkZEfamh1w9.D35lls5iF(ytHomeViewModel, DPIKBM0VjkZEfamh1w9.nD607Wma2d);
							YTPlaylisTResponseDto yTPlaylisTResponseDto3 = new YTPlaylisTResponseDto();
							uRjvKHUZWaiotKwavc3.D35lls5iF(yTPlaylisTResponseDto3, R8oVZNUFXmHMNyrRp4t.D35lls5iF(result.Data, R8oVZNUFXmHMNyrRp4t.oXGUJUMuXl).ToList(), uRjvKHUZWaiotKwavc3.U70Ujkwo4Q);
							m5sZxWmLHUhVHrJe8sC.D35lls5iF(yTPlaylisTResponseDto3, iFZ5je3XFYKwkvcE5D.D35lls5iF(16694, iFZ5je3XFYKwkvcE5D.N06TeK0ao), m5sZxWmLHUhVHrJe8sC.TPrUyH5SJo);
							observableCollection3.Add(yTPlaylisTResponseDto3);
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
						num = (_003C_003E1__state = 1);
						_003C_003Eu__2 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_02b4;
				}
				goto IL_02d2;
				IL_02d9:
				if (_003CtryAgain_003E5__2)
				{
					_003CtryAgain_003E5__2 = false;
					_003C_003E7__wrap3 = 0;
					goto IL_004d;
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

	[CompilerGenerated]
	private ICommand uf70ZrDcLI;

	[CompilerGenerated]
	private ICommand bMJ0toxZfJ;

	private YTVideoResponseDto eS30S6HmmQ;

	private IYoutubeService MM50fJWhuF;

	private ObservableCollection<YTPlaylisTResponseDto> CIY0Kvq2ag;

	private readonly YtViewModel u0a0kSa5df;

	private readonly HomeViewModel Tqx081sfTf;

	public ObservableCollection<YTPlaylisTResponseDto> Items
	{
		get
		{
			return CIY0Kvq2ag;
		}
		set
		{
			SetProperty(ref CIY0Kvq2ag, value, iFZ5je3XFYKwkvcE5D.D35lls5iF(12452, iFZ5je3XFYKwkvcE5D.N06TeK0ao));
		}
	}

	public ICommand WatchLaterCommand
	{
		[CompilerGenerated]
		get
		{
			return uf70ZrDcLI;
		}
		[CompilerGenerated]
		set
		{
			uf70ZrDcLI = value;
		}
	}

	public ICommand GoToChannelCommand
	{
		[CompilerGenerated]
		get
		{
			return bMJ0toxZfJ;
		}
		[CompilerGenerated]
		set
		{
			bMJ0toxZfJ = value;
		}
	}

	public YTVideoResponseDto SelectedItem
	{
		get
		{
			return eS30S6HmmQ;
		}
		set
		{
			_003C_003Ec__DisplayClass14_0 CS_0024_003C_003E8__locals4 = new _003C_003Ec__DisplayClass14_0();
			CS_0024_003C_003E8__locals4.XXIKsP5xiU = value;
			CS_0024_003C_003E8__locals4.QnmKxMkRVo = this;
			SetProperty(ref eS30S6HmmQ, CS_0024_003C_003E8__locals4.XXIKsP5xiU, iFZ5je3XFYKwkvcE5D.D35lls5iF(8274, iFZ5je3XFYKwkvcE5D.N06TeK0ao), null, [AsyncStateMachine(typeof(_003C_003Ec__DisplayClass14_0.nlhSFDjdI1OIRmbCQat))] () =>
			{
				_003C_003Ec__DisplayClass14_0.nlhSFDjdI1OIRmbCQat stateMachine = default(_003C_003Ec__DisplayClass14_0.nlhSFDjdI1OIRmbCQat);
				stateMachine.WuQ5YqhIh6 = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
				stateMachine.qdH5FoLJwu = CS_0024_003C_003E8__locals4;
				stateMachine.xaE5C7hb9O = -1;
				stateMachine.WuQ5YqhIh6.Start(ref stateMachine);
			});
		}
	}

	public YtHomeViewModel()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector();
		Tqx081sfTf = AppContainer.Resolve<HomeViewModel>();
		MM50fJWhuF = AppContainer.Resolve<IYoutubeService>();
		dRtGcV0aEUCCBmPiD9q.D35lls5iF(this, new ObservableCollection<YTPlaylisTResponseDto>(), dRtGcV0aEUCCBmPiD9q.Psl0IcST0K);
		xTrtsa0dGrEHfQorHlS.D35lls5iF(this, new AsyncCommand<YTVideoResponseDto>(cUn0T9o6VA), xTrtsa0dGrEHfQorHlS.IF40UkyTJX);
		xTrtsa0dGrEHfQorHlS.D35lls5iF(this, new AsyncCommand<YTVideoResponseDto>(Ekx0GIkqhF), xTrtsa0dGrEHfQorHlS.npP0th0eV2);
	}

	public YtHomeViewModel(YtViewModel youtubeViewModel)
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		this._002Ector();
		u0a0kSa5df = youtubeViewModel;
	}

	[AsyncStateMachine(typeof(_003COnGoToChannelCommandExcute_003Ed__21))]
	private Task Ekx0GIkqhF(YTVideoResponseDto P_0)
	{
		_003COnGoToChannelCommandExcute_003Ed__21 stateMachine = default(_003COnGoToChannelCommandExcute_003Ed__21);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine.obj = P_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	[AsyncStateMachine(typeof(_003COnWatchLaterCommandExcute_003Ed__22))]
	private Task cUn0T9o6VA(YTVideoResponseDto P_0)
	{
		_003COnWatchLaterCommandExcute_003Ed__22 stateMachine = default(_003COnWatchLaterCommandExcute_003Ed__22);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine.obj = P_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
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

	public override void Dispose()
	{
	}

	public void Clear()
	{
		DPIKBM0VjkZEfamh1w9.D35lls5iF(this, DPIKBM0VjkZEfamh1w9.nD607Wma2d)?.Clear();
	}
}
