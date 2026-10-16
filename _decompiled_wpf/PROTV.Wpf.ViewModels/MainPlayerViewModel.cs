using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using HandyControl.Data;
using PROTV.Abstractions.Apis;
using PROTV.Abstractions.Common;
using PROTV.Abstractions.DataTransferObjects;
using PROTV.Abstractions.Helpers;
using PROTV.Abstractions.Search;
using PROTV.Abstractions.Services;
using PROTV.Wpf.Bootstrap;
using PROTV.Wpf.Helpers;
using PROTV.Wpf.Views;
using Unosquare.FFME;
using Unosquare.FFME.Common;

namespace PROTV.Wpf.ViewModels;

public class MainPlayerViewModel : FFMEBaseViewModel<BaseMediaDto>
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnCreatePlayListCommandExcute_003Ed__32 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public MainPlayerViewModel _003C_003E4__this;

		private object _003C_003E7__wrap1;

		private int _003C_003E7__wrap2;

		private TaskAwaiter<Response<PlaylistResponseDto<SongResponseDto>>> _003C_003Eu__1;

		private TaskAwaiter<bool> _003C_003Eu__2;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			MainPlayerViewModel mainPlayerViewModel = _003C_003E4__this;
			try
			{
				TaskAwaiter<bool> awaiter;
				if (num != 0)
				{
					if (num == 1)
					{
						awaiter = _003C_003Eu__2;
						_003C_003Eu__2 = default(TaskAwaiter<bool>);
						num = (_003C_003E1__state = -1);
						goto IL_0252;
					}
					_003C_003E7__wrap2 = 0;
				}
				try
				{
					TaskAwaiter<Response<PlaylistResponseDto<SongResponseDto>>> awaiter2;
					if (num == 0)
					{
						awaiter2 = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter<Response<PlaylistResponseDto<SongResponseDto>>>);
						num = (_003C_003E1__state = -1);
						goto IL_00b1;
					}
					if (!M6ZErPEr2LZyWYpa5O.D35lls5iF(pnvE8rm9NRTK7Tblimu.D35lls5iF(mainPlayerViewModel, pnvE8rm9NRTK7Tblimu.aHII4l9YZQ), M6ZErPEr2LZyWYpa5O.rg89aHbgYh))
					{
						awaiter2 = mainPlayerViewModel.lnwVIR2vlb.CreatePlaylisAsyncAsync<SongResponseDto>(pnvE8rm9NRTK7Tblimu.D35lls5iF(mainPlayerViewModel, pnvE8rm9NRTK7Tblimu.aHII4l9YZQ)).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = (_003C_003E1__state = 0);
							_003C_003Eu__1 = awaiter2;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						}
						goto IL_00b1;
					}
					goto end_IL_002a;
					IL_00b1:
					Response<PlaylistResponseDto<SongResponseDto>> result = awaiter2.GetResult();
					if (result != null && result.Status)
					{
						BaseMediaDto selectedItem = mainPlayerViewModel.PlayerPlaylistViewModel.SelectedItem;
						int? num2 = ((selectedItem != null) ? new int?(WJbFtI6AObf2rNffLCy.D35lls5iF(selectedItem, WJbFtI6AObf2rNffLCy.GuJCFyBU1U)) : ((int?)null));
						VE9MZyCWf6UTEJGXB95.D35lls5iF(mainPlayerViewModel, VE9MZyCWf6UTEJGXB95.DXkILSpvGm).Add(new PlayListItemModel<SongResponseDto>
						{
							PlayList = result.Data,
							HhGPenc8f1 = false,
							Poster = new BitmapImage(new Uri(iFZ5je3XFYKwkvcE5D.D35lls5iF(16218, iFZ5je3XFYKwkvcE5D.N06TeK0ao))),
							MediaId = num2.GetValueOrDefault(),
							Media = (mainPlayerViewModel.PlayerPlaylistViewModel.SelectedItem as SongResponseDto)
						});
						qni3xrDkAJ3vF35eMav.D35lls5iF(mainPlayerViewModel, iFZ5je3XFYKwkvcE5D.D35lls5iF(10480, iFZ5je3XFYKwkvcE5D.N06TeK0ao), qni3xrDkAJ3vF35eMav.QN6DuDtCWO);
						mainPlayerViewModel.WfhVVlpLV8 = "";
						qni3xrDkAJ3vF35eMav.D35lls5iF(mainPlayerViewModel, iFZ5je3XFYKwkvcE5D.D35lls5iF(10578, iFZ5je3XFYKwkvcE5D.N06TeK0ao), qni3xrDkAJ3vF35eMav.QN6DuDtCWO);
					}
					end_IL_002a:;
				}
				catch (PROTVException ex)
				{
					_003C_003E7__wrap1 = ex;
					_003C_003E7__wrap2 = 1;
				}
				int num3 = _003C_003E7__wrap2;
				if (num3 == 1)
				{
					PROTVException ex2 = (PROTVException)_003C_003E7__wrap1;
					if (TNckS5wtLfB2Lk9dYP8.D35lls5iF(ex2, TNckS5wtLfB2Lk9dYP8.oGkwV3iq3t) == ExceptionType.AuthorizationTokenInvalid)
					{
						awaiter = bAA7Sxw7vZsvusOmDea.D35lls5iF(AppContainer.Resolve<MainViewModel>(), bAA7Sxw7vZsvusOmDea.gytwc9U7r5).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (_003C_003E1__state = 1);
							_003C_003Eu__2 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_0252;
					}
					gsYNF433WqUIGma3CNX.D35lls5iF(QQLie3eYkZwbFFm9Jjw.D35lls5iF(ex2, QQLie3eYkZwbFFm9Jjw.vZdwjWiy78), "", gsYNF433WqUIGma3CNX.gB4ml1oyVl);
				}
				goto IL_0294;
				IL_0294:
				_003C_003E7__wrap1 = null;
				goto end_IL_0015;
				IL_0252:
				if (awaiter.GetResult())
				{
					mainPlayerViewModel.CPhVTEHOLq = AppContainer.Resolve<ILiveService>();
					mainPlayerViewModel.wAFVGZpTsR = AppContainer.Resolve<IStoreContext>();
				}
				goto IL_0294;
				end_IL_0015:;
			}
			catch (Exception ex3)
			{
				_003C_003E1__state = -2;
				N2XUglA3neBsnlZfRPQ.D35lls5iF(ref _003C_003Et__builder, ex3, N2XUglA3neBsnlZfRPQ.l4pATRumoW);
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
	private struct _003COnOpenPlayListCommandExcute_003Ed__34 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MainPlayerViewModel _003C_003E4__this;

		public SongResponseDto arg;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			MainPlayerViewModel mainPlayerViewModel = _003C_003E4__this;
			try
			{
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(pvrKKy8Mk1kpdmIfp3A.D35lls5iF(10, pvrKKy8Mk1kpdmIfp3A.aVh8SPrFkE), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
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
					IEnumerator<PlayListItemModel<SongResponseDto>> enumerator = VE9MZyCWf6UTEJGXB95.D35lls5iF(mainPlayerViewModel, VE9MZyCWf6UTEJGXB95.DXkILSpvGm).GetEnumerator();
					try
					{
						while (hjMnupQVVDlRZAYQJC.D35lls5iF(enumerator, hjMnupQVVDlRZAYQJC.QV1TFwytOj))
						{
							PlayListItemModel<SongResponseDto> current = enumerator.Current;
							current.MediaId = m9MGZR7k2RmVqYXYS5.D35lls5iF(arg, m9MGZR7k2RmVqYXYS5.j871CQO7pP);
							current.Media = arg;
							current.HhGPenc8f1 = S2TLVumHJ5aeKRPsMnq.D35lls5iF(arg, S2TLVumHJ5aeKRPsMnq.lkSm1NMjdP).Contains(current.PlayList.Id);
							hH6DVMBvgw3ANNRyBk6.D35lls5iF(current, iFZ5je3XFYKwkvcE5D.D35lls5iF(10648, iFZ5je3XFYKwkvcE5D.N06TeK0ao), hH6DVMBvgw3ANNRyBk6.hT7m8gyOr4);
						}
					}
					finally
					{
						if (num < 0 && enumerator != null)
						{
							xLO56JniGyickVjO1Ot.D35lls5iF(enumerator, xLO56JniGyickVjO1Ot.ydbT2bsoH4);
						}
					}
					jPB9Q5LdIM9wsuWV1q7.D35lls5iF(mainPlayerViewModel, true, jPB9Q5LdIM9wsuWV1q7.ayaEmChjMs);
					qni3xrDkAJ3vF35eMav.D35lls5iF(mainPlayerViewModel, "", qni3xrDkAJ3vF35eMav.AKQEatUluq);
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
	private struct _003COnAddToFavoriteCommandExcute_003Ed__35 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MainPlayerViewModel _003C_003E4__this;

		public SongResponseDto arg;

		private SongResponseDto _003Cdto_003E5__2;

		private TaskAwaiter<bool> _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			MainPlayerViewModel mainPlayerViewModel = _003C_003E4__this;
			try
			{
				try
				{
					TaskAwaiter<bool> awaiter;
					if (num == 0)
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter<bool>);
						num = (_003C_003E1__state = -1);
						goto IL_00d7;
					}
					if (UOCWOF1pc2UOe4PjABW.D35lls5iF(I7R9FpHuQv8JsJPdFiv.D35lls5iF(mainPlayerViewModel, I7R9FpHuQv8JsJPdFiv.PTqHPF39pv), UOCWOF1pc2UOe4PjABW.TuV1w2E8GR) == PROTV.Abstractions.Common.MediaType.Song)
					{
						_003Cdto_003E5__2 = arg;
						if (arg == null)
						{
							_003Cdto_003E5__2 = I7R9FpHuQv8JsJPdFiv.D35lls5iF(mainPlayerViewModel, I7R9FpHuQv8JsJPdFiv.PTqHPF39pv) as SongResponseDto;
						}
						awaiter = VbmtIFmnFwg9sqb4Jje.D35lls5iF(mainPlayerViewModel.NBaVaCuxib, m9MGZR7k2RmVqYXYS5.D35lls5iF(_003Cdto_003E5__2, m9MGZR7k2RmVqYXYS5.j871CQO7pP), VbmtIFmnFwg9sqb4Jje.rrhm3meLB5).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (_003C_003E1__state = 0);
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_00d7;
					}
					goto end_IL_0018;
					IL_00d7:
					if (awaiter.GetResult())
					{
						jPB9Q5LdIM9wsuWV1q7.D35lls5iF(_003Cdto_003E5__2, !LsA6RHpKkbdnOn3fX60.D35lls5iF(_003Cdto_003E5__2, LsA6RHpKkbdnOn3fX60.wngmTuQiAX), jPB9Q5LdIM9wsuWV1q7.k7sm4salMA);
						m5sZxWmLHUhVHrJe8sC.D35lls5iF(_003Cdto_003E5__2, iFZ5je3XFYKwkvcE5D.D35lls5iF(8354, iFZ5je3XFYKwkvcE5D.N06TeK0ao), m5sZxWmLHUhVHrJe8sC.XfqmEkDdBV);
					}
					_003Cdto_003E5__2 = null;
					end_IL_0018:;
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
	private struct _003COnPlayNextCommandExcute_003Ed__36 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public MainPlayerViewModel _003C_003E4__this;

		private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			MainPlayerViewModel CS_0024_003C_003E8__locals33 = _003C_003E4__this;
			try
			{
				_ = 5;
				try
				{
					TaskAwaiter awaiter2;
					ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter awaiter;
					switch (num)
					{
					default:
					{
						BaseMediaDto item = CS_0024_003C_003E8__locals33.PlayerPlaylistViewModel.ViewItems.FirstOrDefault((BaseMediaDto P_0) => m9MGZR7k2RmVqYXYS5.D35lls5iF(P_0, m9MGZR7k2RmVqYXYS5.j871CQO7pP) == m9MGZR7k2RmVqYXYS5.D35lls5iF(I7R9FpHuQv8JsJPdFiv.D35lls5iF(CS_0024_003C_003E8__locals33, I7R9FpHuQv8JsJPdFiv.PTqHPF39pv), m9MGZR7k2RmVqYXYS5.j871CQO7pP));
						int num2 = CS_0024_003C_003E8__locals33.PlayerPlaylistViewModel.ViewItems.IndexOf(item);
						num2++;
						if (num2 == CS_0024_003C_003E8__locals33.PlayerPlaylistViewModel.ViewItems.Count)
						{
							num2 = 0;
						}
						TWDbV1IEhKw9PkLfweg.D35lls5iF(CS_0024_003C_003E8__locals33, CS_0024_003C_003E8__locals33.PlayerPlaylistViewModel.ViewItems.ElementAt(num2), TWDbV1IEhKw9PkLfweg.VXjIBNJQ0G);
						CS_0024_003C_003E8__locals33.PlayerPlaylistViewModel.SelectedItem = I7R9FpHuQv8JsJPdFiv.D35lls5iF(CS_0024_003C_003E8__locals33, I7R9FpHuQv8JsJPdFiv.PTqHPF39pv);
						if (UOCWOF1pc2UOe4PjABW.D35lls5iF(I7R9FpHuQv8JsJPdFiv.D35lls5iF(CS_0024_003C_003E8__locals33, I7R9FpHuQv8JsJPdFiv.PTqHPF39pv), UOCWOF1pc2UOe4PjABW.TuV1w2E8GR) == PROTV.Abstractions.Common.MediaType.Song)
						{
							qni3xrDkAJ3vF35eMav.D35lls5iF(CS_0024_003C_003E8__locals33, pnvE8rm9NRTK7Tblimu.D35lls5iF(I7R9FpHuQv8JsJPdFiv.D35lls5iF(CS_0024_003C_003E8__locals33, I7R9FpHuQv8JsJPdFiv.PTqHPF39pv) as SongResponseDto, pnvE8rm9NRTK7Tblimu.PhoI06dPjC), qni3xrDkAJ3vF35eMav.MrYTZduNV7);
							m5sZxWmLHUhVHrJe8sC.D35lls5iF(CS_0024_003C_003E8__locals33, pnvE8rm9NRTK7Tblimu.D35lls5iF(XTpI9xIr95A1TWYSWp4.D35lls5iF(I7R9FpHuQv8JsJPdFiv.D35lls5iF(CS_0024_003C_003E8__locals33, I7R9FpHuQv8JsJPdFiv.PTqHPF39pv) as SongResponseDto, XTpI9xIr95A1TWYSWp4.pgVIepITG2), pnvE8rm9NRTK7Tblimu.DQ6IGCcPAn), m5sZxWmLHUhVHrJe8sC.A0PIR9gpvB);
							m5sZxWmLHUhVHrJe8sC.D35lls5iF(CS_0024_003C_003E8__locals33, QQLie3eYkZwbFFm9Jjw.D35lls5iF(I7R9FpHuQv8JsJPdFiv.D35lls5iF(CS_0024_003C_003E8__locals33, I7R9FpHuQv8JsJPdFiv.PTqHPF39pv) as SongResponseDto, QQLie3eYkZwbFFm9Jjw.iBTCbal3Fb), m5sZxWmLHUhVHrJe8sC.mbEIkNfVnX);
							string uriString = pnvE8rm9NRTK7Tblimu.D35lls5iF(new Uri(UwSEfC4rh9eVlFenwI.D35lls5iF(pnvE8rm9NRTK7Tblimu.D35lls5iF(I7R9FpHuQv8JsJPdFiv.D35lls5iF(CS_0024_003C_003E8__locals33, I7R9FpHuQv8JsJPdFiv.PTqHPF39pv) as SongResponseDto, pnvE8rm9NRTK7Tblimu.hj8IvJoMM8), pnvE8rm9NRTK7Tblimu.D35lls5iF(I7R9FpHuQv8JsJPdFiv.D35lls5iF(CS_0024_003C_003E8__locals33, I7R9FpHuQv8JsJPdFiv.PTqHPF39pv) as SongResponseDto, pnvE8rm9NRTK7Tblimu.PhoI06dPjC), UwSEfC4rh9eVlFenwI.J6G3NC9nSO)), pnvE8rm9NRTK7Tblimu.fnLajxXY1u);
							awaiter = mchHD5pbvoLh6YJmlai.D35lls5iF(CS_0024_003C_003E8__locals33.MediaElement, new Uri(uriString), mchHD5pbvoLh6YJmlai.ahJpW0oay7).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_0207;
						}
						if (UOCWOF1pc2UOe4PjABW.D35lls5iF(I7R9FpHuQv8JsJPdFiv.D35lls5iF(CS_0024_003C_003E8__locals33, I7R9FpHuQv8JsJPdFiv.PTqHPF39pv), UOCWOF1pc2UOe4PjABW.TuV1w2E8GR) == PROTV.Abstractions.Common.MediaType.Surah)
						{
							qni3xrDkAJ3vF35eMav.D35lls5iF(CS_0024_003C_003E8__locals33, pnvE8rm9NRTK7Tblimu.D35lls5iF(I7R9FpHuQv8JsJPdFiv.D35lls5iF(CS_0024_003C_003E8__locals33, I7R9FpHuQv8JsJPdFiv.PTqHPF39pv) as SurahResponseDto, pnvE8rm9NRTK7Tblimu.wDhI64eA24), qni3xrDkAJ3vF35eMav.MrYTZduNV7);
							m5sZxWmLHUhVHrJe8sC.D35lls5iF(CS_0024_003C_003E8__locals33, iFZ5je3XFYKwkvcE5D.D35lls5iF(16524, iFZ5je3XFYKwkvcE5D.N06TeK0ao), m5sZxWmLHUhVHrJe8sC.A0PIR9gpvB);
							m5sZxWmLHUhVHrJe8sC.D35lls5iF(CS_0024_003C_003E8__locals33, pnvE8rm9NRTK7Tblimu.D35lls5iF(I7R9FpHuQv8JsJPdFiv.D35lls5iF(CS_0024_003C_003E8__locals33, I7R9FpHuQv8JsJPdFiv.PTqHPF39pv) as SurahResponseDto, pnvE8rm9NRTK7Tblimu.RAsIp8mtjp), m5sZxWmLHUhVHrJe8sC.mbEIkNfVnX);
							string uriString2 = pnvE8rm9NRTK7Tblimu.D35lls5iF(new Uri(UwSEfC4rh9eVlFenwI.D35lls5iF(pnvE8rm9NRTK7Tblimu.D35lls5iF(I7R9FpHuQv8JsJPdFiv.D35lls5iF(CS_0024_003C_003E8__locals33, I7R9FpHuQv8JsJPdFiv.PTqHPF39pv) as SurahResponseDto, pnvE8rm9NRTK7Tblimu.sQAIwpljS8), pnvE8rm9NRTK7Tblimu.D35lls5iF(I7R9FpHuQv8JsJPdFiv.D35lls5iF(CS_0024_003C_003E8__locals33, I7R9FpHuQv8JsJPdFiv.PTqHPF39pv) as SurahResponseDto, pnvE8rm9NRTK7Tblimu.wDhI64eA24), UwSEfC4rh9eVlFenwI.J6G3NC9nSO)), pnvE8rm9NRTK7Tblimu.fnLajxXY1u);
							awaiter = mchHD5pbvoLh6YJmlai.D35lls5iF(CS_0024_003C_003E8__locals33.MediaElement, new Uri(uriString2), mchHD5pbvoLh6YJmlai.ahJpW0oay7).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = (_003C_003E1__state = 3);
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_0460;
						}
						goto end_IL_001a;
					}
					case 0:
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter);
						num = (_003C_003E1__state = -1);
						goto IL_0207;
					case 1:
						awaiter2 = _003C_003Eu__2;
						_003C_003Eu__2 = default(TaskAwaiter);
						num = (_003C_003E1__state = -1);
						goto IL_027c;
					case 2:
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter);
						num = (_003C_003E1__state = -1);
						goto IL_02f0;
					case 3:
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter);
						num = (_003C_003E1__state = -1);
						goto IL_0460;
					case 4:
						awaiter2 = _003C_003Eu__2;
						_003C_003Eu__2 = default(TaskAwaiter);
						num = (_003C_003E1__state = -1);
						goto IL_04d5;
					case 5:
						{
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default(ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter);
							num = (_003C_003E1__state = -1);
							break;
						}
						IL_027c:
						oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter2, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
						awaiter = wd2eJ2Asf3I9epXUKxU.D35lls5iF(CS_0024_003C_003E8__locals33.MediaElement, wd2eJ2Asf3I9epXUKxU.fTCmiFqqnh).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (_003C_003E1__state = 2);
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_02f0;
						IL_02f0:
						awaiter.GetResult();
						if (!LsA6RHpKkbdnOn3fX60.D35lls5iF(CS_0024_003C_003E8__locals33.J8GVZpf7GE, LsA6RHpKkbdnOn3fX60.kZiIAOQZKm))
						{
							QnJnl7fVDKI4mA6voc.D35lls5iF(CS_0024_003C_003E8__locals33.J8GVZpf7GE, true, QnJnl7fVDKI4mA6voc.dUxHsdI86U);
						}
						goto end_IL_001a;
						IL_0460:
						awaiter.GetResult();
						awaiter2 = QliBEUviwWqgtMcBndV.D35lls5iF(pvrKKy8Mk1kpdmIfp3A.D35lls5iF(500, pvrKKy8Mk1kpdmIfp3A.aVh8SPrFkE), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
						if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter2, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
						{
							num = (_003C_003E1__state = 4);
							_003C_003Eu__2 = awaiter2;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						}
						goto IL_04d5;
						IL_04d5:
						oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter2, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
						awaiter = wd2eJ2Asf3I9epXUKxU.D35lls5iF(CS_0024_003C_003E8__locals33.MediaElement, wd2eJ2Asf3I9epXUKxU.fTCmiFqqnh).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (_003C_003E1__state = 5);
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						break;
						IL_0207:
						awaiter.GetResult();
						awaiter2 = QliBEUviwWqgtMcBndV.D35lls5iF(pvrKKy8Mk1kpdmIfp3A.D35lls5iF(500, pvrKKy8Mk1kpdmIfp3A.aVh8SPrFkE), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
						if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter2, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
						{
							num = (_003C_003E1__state = 1);
							_003C_003Eu__2 = awaiter2;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						}
						goto IL_027c;
					}
					awaiter.GetResult();
					if (!LsA6RHpKkbdnOn3fX60.D35lls5iF(CS_0024_003C_003E8__locals33.J8GVZpf7GE, LsA6RHpKkbdnOn3fX60.kZiIAOQZKm))
					{
						QnJnl7fVDKI4mA6voc.D35lls5iF(CS_0024_003C_003E8__locals33.J8GVZpf7GE, true, QnJnl7fVDKI4mA6voc.dUxHsdI86U);
					}
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
	private struct _003COnPlayPreviousCommandExcute_003Ed__37 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public MainPlayerViewModel _003C_003E4__this;

		private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			MainPlayerViewModel CS_0024_003C_003E8__locals31 = _003C_003E4__this;
			try
			{
				_ = 1;
				try
				{
					ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter awaiter;
					if (num == 0)
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter);
						num = (_003C_003E1__state = -1);
						goto IL_01f8;
					}
					if (num == 1)
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter);
						num = (_003C_003E1__state = -1);
						goto IL_0368;
					}
					BaseMediaDto item = CS_0024_003C_003E8__locals31.PlayerPlaylistViewModel.ViewItems.FirstOrDefault((BaseMediaDto P_0) => m9MGZR7k2RmVqYXYS5.D35lls5iF(P_0, m9MGZR7k2RmVqYXYS5.j871CQO7pP) == m9MGZR7k2RmVqYXYS5.D35lls5iF(I7R9FpHuQv8JsJPdFiv.D35lls5iF(CS_0024_003C_003E8__locals31, I7R9FpHuQv8JsJPdFiv.PTqHPF39pv), m9MGZR7k2RmVqYXYS5.j871CQO7pP));
					int num2 = CS_0024_003C_003E8__locals31.PlayerPlaylistViewModel.ViewItems.IndexOf(item);
					num2--;
					if (num2 == -1)
					{
						num2 = CS_0024_003C_003E8__locals31.PlayerPlaylistViewModel.ViewItems.Count - 1;
					}
					TWDbV1IEhKw9PkLfweg.D35lls5iF(CS_0024_003C_003E8__locals31, CS_0024_003C_003E8__locals31.PlayerPlaylistViewModel.ViewItems.ElementAt(num2), TWDbV1IEhKw9PkLfweg.VXjIBNJQ0G);
					CS_0024_003C_003E8__locals31.PlayerPlaylistViewModel.SelectedItem = I7R9FpHuQv8JsJPdFiv.D35lls5iF(CS_0024_003C_003E8__locals31, I7R9FpHuQv8JsJPdFiv.PTqHPF39pv);
					if (UOCWOF1pc2UOe4PjABW.D35lls5iF(I7R9FpHuQv8JsJPdFiv.D35lls5iF(CS_0024_003C_003E8__locals31, I7R9FpHuQv8JsJPdFiv.PTqHPF39pv), UOCWOF1pc2UOe4PjABW.TuV1w2E8GR) == PROTV.Abstractions.Common.MediaType.Song)
					{
						qni3xrDkAJ3vF35eMav.D35lls5iF(CS_0024_003C_003E8__locals31, pnvE8rm9NRTK7Tblimu.D35lls5iF(I7R9FpHuQv8JsJPdFiv.D35lls5iF(CS_0024_003C_003E8__locals31, I7R9FpHuQv8JsJPdFiv.PTqHPF39pv) as SongResponseDto, pnvE8rm9NRTK7Tblimu.PhoI06dPjC), qni3xrDkAJ3vF35eMav.MrYTZduNV7);
						m5sZxWmLHUhVHrJe8sC.D35lls5iF(CS_0024_003C_003E8__locals31, pnvE8rm9NRTK7Tblimu.D35lls5iF(XTpI9xIr95A1TWYSWp4.D35lls5iF(I7R9FpHuQv8JsJPdFiv.D35lls5iF(CS_0024_003C_003E8__locals31, I7R9FpHuQv8JsJPdFiv.PTqHPF39pv) as SongResponseDto, XTpI9xIr95A1TWYSWp4.pgVIepITG2), pnvE8rm9NRTK7Tblimu.DQ6IGCcPAn), m5sZxWmLHUhVHrJe8sC.A0PIR9gpvB);
						m5sZxWmLHUhVHrJe8sC.D35lls5iF(CS_0024_003C_003E8__locals31, QQLie3eYkZwbFFm9Jjw.D35lls5iF(I7R9FpHuQv8JsJPdFiv.D35lls5iF(CS_0024_003C_003E8__locals31, I7R9FpHuQv8JsJPdFiv.PTqHPF39pv) as SongResponseDto, QQLie3eYkZwbFFm9Jjw.iBTCbal3Fb), m5sZxWmLHUhVHrJe8sC.mbEIkNfVnX);
						string uriString = pnvE8rm9NRTK7Tblimu.D35lls5iF(new Uri(UwSEfC4rh9eVlFenwI.D35lls5iF(pnvE8rm9NRTK7Tblimu.D35lls5iF(I7R9FpHuQv8JsJPdFiv.D35lls5iF(CS_0024_003C_003E8__locals31, I7R9FpHuQv8JsJPdFiv.PTqHPF39pv) as SongResponseDto, pnvE8rm9NRTK7Tblimu.hj8IvJoMM8), pnvE8rm9NRTK7Tblimu.D35lls5iF(I7R9FpHuQv8JsJPdFiv.D35lls5iF(CS_0024_003C_003E8__locals31, I7R9FpHuQv8JsJPdFiv.PTqHPF39pv) as SongResponseDto, pnvE8rm9NRTK7Tblimu.PhoI06dPjC), UwSEfC4rh9eVlFenwI.J6G3NC9nSO)), pnvE8rm9NRTK7Tblimu.fnLajxXY1u);
						awaiter = mchHD5pbvoLh6YJmlai.D35lls5iF(CS_0024_003C_003E8__locals31.MediaElement, new Uri(uriString), mchHD5pbvoLh6YJmlai.ahJpW0oay7).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (_003C_003E1__state = 0);
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_01f8;
					}
					if (UOCWOF1pc2UOe4PjABW.D35lls5iF(I7R9FpHuQv8JsJPdFiv.D35lls5iF(CS_0024_003C_003E8__locals31, I7R9FpHuQv8JsJPdFiv.PTqHPF39pv), UOCWOF1pc2UOe4PjABW.TuV1w2E8GR) == PROTV.Abstractions.Common.MediaType.Surah)
					{
						qni3xrDkAJ3vF35eMav.D35lls5iF(CS_0024_003C_003E8__locals31, pnvE8rm9NRTK7Tblimu.D35lls5iF(I7R9FpHuQv8JsJPdFiv.D35lls5iF(CS_0024_003C_003E8__locals31, I7R9FpHuQv8JsJPdFiv.PTqHPF39pv) as SurahResponseDto, pnvE8rm9NRTK7Tblimu.wDhI64eA24), qni3xrDkAJ3vF35eMav.MrYTZduNV7);
						m5sZxWmLHUhVHrJe8sC.D35lls5iF(CS_0024_003C_003E8__locals31, iFZ5je3XFYKwkvcE5D.D35lls5iF(16524, iFZ5je3XFYKwkvcE5D.N06TeK0ao), m5sZxWmLHUhVHrJe8sC.A0PIR9gpvB);
						m5sZxWmLHUhVHrJe8sC.D35lls5iF(CS_0024_003C_003E8__locals31, pnvE8rm9NRTK7Tblimu.D35lls5iF(I7R9FpHuQv8JsJPdFiv.D35lls5iF(CS_0024_003C_003E8__locals31, I7R9FpHuQv8JsJPdFiv.PTqHPF39pv) as SurahResponseDto, pnvE8rm9NRTK7Tblimu.RAsIp8mtjp), m5sZxWmLHUhVHrJe8sC.mbEIkNfVnX);
						string uriString2 = pnvE8rm9NRTK7Tblimu.D35lls5iF(new Uri(UwSEfC4rh9eVlFenwI.D35lls5iF(pnvE8rm9NRTK7Tblimu.D35lls5iF(I7R9FpHuQv8JsJPdFiv.D35lls5iF(CS_0024_003C_003E8__locals31, I7R9FpHuQv8JsJPdFiv.PTqHPF39pv) as SurahResponseDto, pnvE8rm9NRTK7Tblimu.sQAIwpljS8), pnvE8rm9NRTK7Tblimu.D35lls5iF(I7R9FpHuQv8JsJPdFiv.D35lls5iF(CS_0024_003C_003E8__locals31, I7R9FpHuQv8JsJPdFiv.PTqHPF39pv) as SurahResponseDto, pnvE8rm9NRTK7Tblimu.wDhI64eA24), UwSEfC4rh9eVlFenwI.J6G3NC9nSO)), pnvE8rm9NRTK7Tblimu.fnLajxXY1u);
						awaiter = mchHD5pbvoLh6YJmlai.D35lls5iF(CS_0024_003C_003E8__locals31.MediaElement, new Uri(uriString2), mchHD5pbvoLh6YJmlai.ahJpW0oay7).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (_003C_003E1__state = 1);
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_0368;
					}
					goto end_IL_001a;
					IL_0368:
					awaiter.GetResult();
					if (!LsA6RHpKkbdnOn3fX60.D35lls5iF(CS_0024_003C_003E8__locals31.J8GVZpf7GE, LsA6RHpKkbdnOn3fX60.kZiIAOQZKm))
					{
						QnJnl7fVDKI4mA6voc.D35lls5iF(CS_0024_003C_003E8__locals31.J8GVZpf7GE, true, QnJnl7fVDKI4mA6voc.dUxHsdI86U);
					}
					goto end_IL_001a;
					IL_01f8:
					awaiter.GetResult();
					if (!LsA6RHpKkbdnOn3fX60.D35lls5iF(CS_0024_003C_003E8__locals31.J8GVZpf7GE, LsA6RHpKkbdnOn3fX60.kZiIAOQZKm))
					{
						QnJnl7fVDKI4mA6voc.D35lls5iF(CS_0024_003C_003E8__locals31.J8GVZpf7GE, true, QnJnl7fVDKI4mA6voc.dUxHsdI86U);
					}
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
	private struct _003COnPlayVideoCommandExcuteAsync_003Ed__39 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public SongResponseDto arg;

		public MainPlayerViewModel _003C_003E4__this;

		private MoviePlayerViewModel _003CviewModel_003E5__2;

		private Page _003Cpage_003E5__3;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			MainPlayerViewModel mainPlayerViewModel = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					if (num == 1)
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter);
						num = (_003C_003E1__state = -1);
						goto IL_0152;
					}
					_003CviewModel_003E5__2 = new MoviePlayerViewModel();
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(hycsw7ICI3aHmkAkvSt.D35lls5iF(_003CviewModel_003E5__2, arg, hycsw7ICI3aHmkAkvSt.cF3ImmGaKa), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
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
				Page page = new Page();
				KBhlAv9D2TgBJ1kkc0B.D35lls5iF(page, IyGDDwHBiPv8vfOFJDF.D35lls5iF(ApplicationPage.ShowMoviePage, _003CviewModel_003E5__2, IyGDDwHBiPv8vfOFJDF.hivH0XYhaE), KBhlAv9D2TgBJ1kkc0B.fWUHrWO7Sa);
				qni3xrDkAJ3vF35eMav.D35lls5iF(page, iFZ5je3XFYKwkvcE5D.D35lls5iF(16554, iFZ5je3XFYKwkvcE5D.N06TeK0ao), qni3xrDkAJ3vF35eMav.Ra7HRFTvnD);
				_003Cpage_003E5__3 = page;
				awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(pvrKKy8Mk1kpdmIfp3A.D35lls5iF(5, pvrKKy8Mk1kpdmIfp3A.aVh8SPrFkE), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
				if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
				{
					num = (_003C_003E1__state = 1);
					_003C_003Eu__1 = awaiter;
					_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
					return;
				}
				goto IL_0152;
				IL_0152:
				oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
				GmMLaTD7kV8rq88ZFvR.D35lls5iF(Xlypb0Hnr2C3ydrYEdG.D35lls5iF(mainPlayerViewModel.J8GVZpf7GE, Xlypb0Hnr2C3ydrYEdG.U3Z1IKMGuZ), _003Cpage_003E5__3, GmMLaTD7kV8rq88ZFvR.iMJHkmaaRY);
			}
			catch (Exception ex)
			{
				_003C_003E1__state = -2;
				_003CviewModel_003E5__2 = null;
				_003Cpage_003E5__3 = null;
				NNK1eXA7fWQ87oSUty7.D35lls5iF(ref _003C_003Et__builder, ex, NNK1eXA7fWQ87oSUty7.G3EAcW9Om7);
				return;
			}
			_003C_003E1__state = -2;
			_003CviewModel_003E5__2 = null;
			_003Cpage_003E5__3 = null;
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
	private sealed class _003C_003Ec__DisplayClass76_0
	{
		public bool Y3PfVj8xdT;

		public MainPlayerViewModel atkfaLrj36;

		public _003C_003Ec__DisplayClass76_0()
		{
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
			base._002Ector();
		}

		internal void nodfIJNMeM()
		{
			if (Y3PfVj8xdT)
			{
				atkfaLrj36.PlayerPlaylistViewModel.ViewItems = atkfaLrj36.PlayerPlaylistViewModel.RandomizItems;
			}
			else
			{
				atkfaLrj36.PlayerPlaylistViewModel.ViewItems = atkfaLrj36.PlayerPlaylistViewModel.Items;
			}
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass79_0
	{
		public MainPlayerViewModel fXUfGlNqs6;

		public string fZsfTPelF7;

		public _003C_003Ec__DisplayClass79_0()
		{
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
			base._002Ector();
		}

		internal void Lesf0Ph5na()
		{
			fXUfGlNqs6.PlayerPlaylistViewModel.Items.Clear();
			IEnumerator<BaseMediaDto> enumerator = fXUfGlNqs6.PlayerPlaylistViewModel.ViewItems.GetEnumerator();
			try
			{
				while (hjMnupQVVDlRZAYQJC.D35lls5iF(enumerator, hjMnupQVVDlRZAYQJC.QV1TFwytOj))
				{
					BaseMediaDto current = enumerator.Current;
					string text = eVlRnEIaHT0dqvCx0Kx.D35lls5iF(pnvE8rm9NRTK7Tblimu.D35lls5iF(current as SongResponseDto, pnvE8rm9NRTK7Tblimu.PhoI06dPjC), eVlRnEIaHT0dqvCx0Kx.PLmIIMWEZ7);
					string text2 = fZsfTPelF7;
					if (VMs7lU9URBMKdJRC1h1.D35lls5iF(text, (text2 != null) ? eVlRnEIaHT0dqvCx0Kx.D35lls5iF(text2, eVlRnEIaHT0dqvCx0Kx.rluIdyZWI1) : null, VMs7lU9URBMKdJRC1h1.p7T9tIfMiJ))
					{
						fXUfGlNqs6.PlayerPlaylistViewModel.Items.Add(current);
					}
				}
			}
			finally
			{
				if (enumerator != null)
				{
					xLO56JniGyickVjO1Ot.D35lls5iF(enumerator, xLO56JniGyickVjO1Ot.ydbT2bsoH4);
				}
			}
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLoadPlayLists_003Ed__105 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MainPlayerViewModel _003C_003E4__this;

		private TaskAwaiter<ResponseList<PlaylistResponseDto<SongResponseDto>>> _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			MainPlayerViewModel mainPlayerViewModel = _003C_003E4__this;
			try
			{
				try
				{
					TaskAwaiter<ResponseList<PlaylistResponseDto<SongResponseDto>>> awaiter;
					if (num != 0)
					{
						VE9MZyCWf6UTEJGXB95.D35lls5iF(mainPlayerViewModel, VE9MZyCWf6UTEJGXB95.DXkILSpvGm).Clear();
						IPlaylistService lnwVIR2vlb = mainPlayerViewModel.lnwVIR2vlb;
						ApiQuery<PlaylistSearch, GeneralSort> apiQuery = new ApiQuery<PlaylistSearch, GeneralSort>();
						PlaylistSearch playlistSearch = new PlaylistSearch();
						GqB3rILSV2vbfc09aIP.D35lls5iF(playlistSearch, PlaylistType.Song, GqB3rILSV2vbfc09aIP.OU4LK1g7N1);
						apiQuery.Search = playlistSearch;
						apiQuery.Count = -1;
						awaiter = lnwVIR2vlb.GetPlaylistsAsync<SongResponseDto>(apiQuery).GetAwaiter();
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
						_003C_003Eu__1 = default(TaskAwaiter<ResponseList<PlaylistResponseDto<SongResponseDto>>>);
						num = (_003C_003E1__state = -1);
					}
					ResponseList<PlaylistResponseDto<SongResponseDto>> result = awaiter.GetResult();
					if (result != null && result.Status)
					{
						IEnumerator<PlaylistResponseDto<SongResponseDto>> enumerator = result.Data.Result.GetEnumerator();
						try
						{
							while (hjMnupQVVDlRZAYQJC.D35lls5iF(enumerator, hjMnupQVVDlRZAYQJC.QV1TFwytOj))
							{
								PlaylistResponseDto<SongResponseDto> current = enumerator.Current;
								PlayListItemModel<SongResponseDto> playListItemModel = new PlayListItemModel<SongResponseDto>
								{
									PlayList = current,
									IsChecked = false
								};
								if (playListItemModel.Poster == null)
								{
									playListItemModel.Poster = new BitmapImage(new Uri(iFZ5je3XFYKwkvcE5D.D35lls5iF(16218, iFZ5je3XFYKwkvcE5D.N06TeK0ao)));
								}
								else
								{
									playListItemModel.Poster = new BitmapImage(new Uri(current.Poster));
								}
								VE9MZyCWf6UTEJGXB95.D35lls5iF(mainPlayerViewModel, VE9MZyCWf6UTEJGXB95.DXkILSpvGm).Add(playListItemModel);
							}
						}
						finally
						{
							if (num < 0 && enumerator != null)
							{
								xLO56JniGyickVjO1Ot.D35lls5iF(enumerator, xLO56JniGyickVjO1Ot.ydbT2bsoH4);
							}
						}
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
	private struct _003COnOpenCommandExcuteAsync_003Ed__107 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public MainPlayerViewModel _003C_003E4__this;

		public BaseMediaDto obj;

		private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			MainPlayerViewModel mainPlayerViewModel = _003C_003E4__this;
			try
			{
				try
				{
					ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter awaiter;
					if (num == 0)
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter);
						num = (_003C_003E1__state = -1);
						goto IL_014a;
					}
					if (m9MGZR7k2RmVqYXYS5.D35lls5iF(I7R9FpHuQv8JsJPdFiv.D35lls5iF(mainPlayerViewModel, I7R9FpHuQv8JsJPdFiv.PTqHPF39pv), m9MGZR7k2RmVqYXYS5.j871CQO7pP) != m9MGZR7k2RmVqYXYS5.D35lls5iF(obj, m9MGZR7k2RmVqYXYS5.j871CQO7pP))
					{
						SongResponseDto songResponseDto = obj as SongResponseDto;
						TWDbV1IEhKw9PkLfweg.D35lls5iF(mainPlayerViewModel, songResponseDto, TWDbV1IEhKw9PkLfweg.VXjIBNJQ0G);
						qni3xrDkAJ3vF35eMav.D35lls5iF(mainPlayerViewModel, pnvE8rm9NRTK7Tblimu.D35lls5iF(songResponseDto, pnvE8rm9NRTK7Tblimu.PhoI06dPjC), qni3xrDkAJ3vF35eMav.MrYTZduNV7);
						m5sZxWmLHUhVHrJe8sC.D35lls5iF(mainPlayerViewModel, pnvE8rm9NRTK7Tblimu.D35lls5iF(XTpI9xIr95A1TWYSWp4.D35lls5iF(songResponseDto, XTpI9xIr95A1TWYSWp4.pgVIepITG2), pnvE8rm9NRTK7Tblimu.DQ6IGCcPAn), m5sZxWmLHUhVHrJe8sC.A0PIR9gpvB);
						m5sZxWmLHUhVHrJe8sC.D35lls5iF(mainPlayerViewModel, QQLie3eYkZwbFFm9Jjw.D35lls5iF(songResponseDto, QQLie3eYkZwbFFm9Jjw.iBTCbal3Fb), m5sZxWmLHUhVHrJe8sC.mbEIkNfVnX);
						string uriString = pnvE8rm9NRTK7Tblimu.D35lls5iF(new Uri(UwSEfC4rh9eVlFenwI.D35lls5iF(pnvE8rm9NRTK7Tblimu.D35lls5iF(songResponseDto, pnvE8rm9NRTK7Tblimu.hj8IvJoMM8), pnvE8rm9NRTK7Tblimu.D35lls5iF(songResponseDto, pnvE8rm9NRTK7Tblimu.PhoI06dPjC), UwSEfC4rh9eVlFenwI.J6G3NC9nSO)), pnvE8rm9NRTK7Tblimu.fnLajxXY1u);
						awaiter = mchHD5pbvoLh6YJmlai.D35lls5iF(mainPlayerViewModel.MediaElement, new Uri(uriString), mchHD5pbvoLh6YJmlai.ahJpW0oay7).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (_003C_003E1__state = 0);
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_014a;
					}
					goto end_IL_0018;
					IL_014a:
					awaiter.GetResult();
					end_IL_0018:;
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
	private struct _003CPlayeSong_003Ed__108 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MainPlayerViewModel _003C_003E4__this;

		public SongResponseDto arg;

		public List<SongResponseDto> lists;

		private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			MainPlayerViewModel mainPlayerViewModel = _003C_003E4__this;
			try
			{
				try
				{
					ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter awaiter;
					if (num != 0)
					{
						TWDbV1IEhKw9PkLfweg.D35lls5iF(mainPlayerViewModel, arg, TWDbV1IEhKw9PkLfweg.VXjIBNJQ0G);
						qni3xrDkAJ3vF35eMav.D35lls5iF(mainPlayerViewModel, pnvE8rm9NRTK7Tblimu.D35lls5iF(arg, pnvE8rm9NRTK7Tblimu.PhoI06dPjC), qni3xrDkAJ3vF35eMav.MrYTZduNV7);
						m5sZxWmLHUhVHrJe8sC.D35lls5iF(mainPlayerViewModel, pnvE8rm9NRTK7Tblimu.D35lls5iF(XTpI9xIr95A1TWYSWp4.D35lls5iF(arg, XTpI9xIr95A1TWYSWp4.pgVIepITG2), pnvE8rm9NRTK7Tblimu.DQ6IGCcPAn), m5sZxWmLHUhVHrJe8sC.A0PIR9gpvB);
						m5sZxWmLHUhVHrJe8sC.D35lls5iF(mainPlayerViewModel, QQLie3eYkZwbFFm9Jjw.D35lls5iF(arg, QQLie3eYkZwbFFm9Jjw.iBTCbal3Fb), m5sZxWmLHUhVHrJe8sC.mbEIkNfVnX);
						mainPlayerViewModel.PlayerPlaylistViewModel.Items = new ObservableCollection<BaseMediaDto>();
						mainPlayerViewModel.PlayerPlaylistViewModel.RandomizItems = new ObservableCollection<BaseMediaDto>();
						mainPlayerViewModel.PlayerPlaylistViewModel.SelectedItem = I7R9FpHuQv8JsJPdFiv.D35lls5iF(mainPlayerViewModel, I7R9FpHuQv8JsJPdFiv.PTqHPF39pv);
						List<SongResponseDto>.Enumerator enumerator = lists.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								SongResponseDto current = enumerator.Current;
								mainPlayerViewModel.PlayerPlaylistViewModel.Items.Add(current);
							}
						}
						finally
						{
							if (num < 0)
							{
								((IDisposable)enumerator/*cast due to constrained. prefix*/).Dispose();
							}
						}
						IEnumerator<SongResponseDto> enumerator2 = lists.OrderBy((SongResponseDto x) => AJWZAgGN6JsveNQ5b3f.D35lls5iF(AJWZAgGN6JsveNQ5b3f.m11GOl5vbN)).GetEnumerator();
						try
						{
							while (hjMnupQVVDlRZAYQJC.D35lls5iF(enumerator2, hjMnupQVVDlRZAYQJC.QV1TFwytOj))
							{
								SongResponseDto current2 = enumerator2.Current;
								mainPlayerViewModel.PlayerPlaylistViewModel.RandomizItems.Add(current2);
							}
						}
						finally
						{
							if (num < 0 && enumerator2 != null)
							{
								xLO56JniGyickVjO1Ot.D35lls5iF(enumerator2, xLO56JniGyickVjO1Ot.ydbT2bsoH4);
							}
						}
						mainPlayerViewModel.PlayerPlaylistViewModel.ViewItems = mainPlayerViewModel.PlayerPlaylistViewModel.Items;
						string uriString = pnvE8rm9NRTK7Tblimu.D35lls5iF(new Uri(UwSEfC4rh9eVlFenwI.D35lls5iF(pnvE8rm9NRTK7Tblimu.D35lls5iF(arg, pnvE8rm9NRTK7Tblimu.hj8IvJoMM8), pnvE8rm9NRTK7Tblimu.D35lls5iF(arg, pnvE8rm9NRTK7Tblimu.PhoI06dPjC), UwSEfC4rh9eVlFenwI.J6G3NC9nSO)), pnvE8rm9NRTK7Tblimu.fnLajxXY1u);
						awaiter = mchHD5pbvoLh6YJmlai.D35lls5iF(mainPlayerViewModel.MediaElement, new Uri(uriString), mchHD5pbvoLh6YJmlai.ahJpW0oay7).GetAwaiter();
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
						_003C_003Eu__1 = default(ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter);
						num = (_003C_003E1__state = -1);
					}
					awaiter.GetResult();
					if (!LsA6RHpKkbdnOn3fX60.D35lls5iF(mainPlayerViewModel.J8GVZpf7GE, LsA6RHpKkbdnOn3fX60.kZiIAOQZKm))
					{
						QnJnl7fVDKI4mA6voc.D35lls5iF(mainPlayerViewModel.J8GVZpf7GE, true, QnJnl7fVDKI4mA6voc.dUxHsdI86U);
					}
					jPB9Q5LdIM9wsuWV1q7.D35lls5iF(mainPlayerViewModel, true, jPB9Q5LdIM9wsuWV1q7.anPIU0otUh);
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
	private struct _003CPlayeSurah_003Ed__109 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MainPlayerViewModel _003C_003E4__this;

		public SurahResponseDto arg;

		public List<SurahResponseDto> lists;

		private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			MainPlayerViewModel mainPlayerViewModel = _003C_003E4__this;
			try
			{
				try
				{
					ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter awaiter;
					if (num != 0)
					{
						TWDbV1IEhKw9PkLfweg.D35lls5iF(mainPlayerViewModel, arg, TWDbV1IEhKw9PkLfweg.VXjIBNJQ0G);
						qni3xrDkAJ3vF35eMav.D35lls5iF(mainPlayerViewModel, pnvE8rm9NRTK7Tblimu.D35lls5iF(arg, pnvE8rm9NRTK7Tblimu.wDhI64eA24), qni3xrDkAJ3vF35eMav.MrYTZduNV7);
						m5sZxWmLHUhVHrJe8sC.D35lls5iF(mainPlayerViewModel, iFZ5je3XFYKwkvcE5D.D35lls5iF(16524, iFZ5je3XFYKwkvcE5D.N06TeK0ao), m5sZxWmLHUhVHrJe8sC.A0PIR9gpvB);
						m5sZxWmLHUhVHrJe8sC.D35lls5iF(mainPlayerViewModel, pnvE8rm9NRTK7Tblimu.D35lls5iF(arg, pnvE8rm9NRTK7Tblimu.RAsIp8mtjp), m5sZxWmLHUhVHrJe8sC.mbEIkNfVnX);
						mainPlayerViewModel.PlayerPlaylistViewModel.Items = new ObservableCollection<BaseMediaDto>();
						mainPlayerViewModel.PlayerPlaylistViewModel.SelectedItem = I7R9FpHuQv8JsJPdFiv.D35lls5iF(mainPlayerViewModel, I7R9FpHuQv8JsJPdFiv.PTqHPF39pv);
						List<SurahResponseDto>.Enumerator enumerator = lists.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								SurahResponseDto current = enumerator.Current;
								mainPlayerViewModel.PlayerPlaylistViewModel.Items.Add(current);
							}
						}
						finally
						{
							if (num < 0)
							{
								((IDisposable)enumerator/*cast due to constrained. prefix*/).Dispose();
							}
						}
						mainPlayerViewModel.PlayerPlaylistViewModel.ViewItems = mainPlayerViewModel.PlayerPlaylistViewModel.Items;
						string uriString = pnvE8rm9NRTK7Tblimu.D35lls5iF(new Uri(UwSEfC4rh9eVlFenwI.D35lls5iF(pnvE8rm9NRTK7Tblimu.D35lls5iF(arg, pnvE8rm9NRTK7Tblimu.sQAIwpljS8), pnvE8rm9NRTK7Tblimu.D35lls5iF(arg, pnvE8rm9NRTK7Tblimu.wDhI64eA24), UwSEfC4rh9eVlFenwI.J6G3NC9nSO)), pnvE8rm9NRTK7Tblimu.fnLajxXY1u);
						awaiter = mchHD5pbvoLh6YJmlai.D35lls5iF(mainPlayerViewModel.MediaElement, new Uri(uriString), mchHD5pbvoLh6YJmlai.ahJpW0oay7).GetAwaiter();
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
						_003C_003Eu__1 = default(ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter);
						num = (_003C_003E1__state = -1);
					}
					awaiter.GetResult();
					if (!LsA6RHpKkbdnOn3fX60.D35lls5iF(mainPlayerViewModel.J8GVZpf7GE, LsA6RHpKkbdnOn3fX60.kZiIAOQZKm))
					{
						QnJnl7fVDKI4mA6voc.D35lls5iF(mainPlayerViewModel.J8GVZpf7GE, true, QnJnl7fVDKI4mA6voc.dUxHsdI86U);
					}
					jPB9Q5LdIM9wsuWV1q7.D35lls5iF(mainPlayerViewModel, false, jPB9Q5LdIM9wsuWV1q7.anPIU0otUh);
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
	private struct _003CLoadMusic_003Ed__110 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MainPlayerViewModel _003C_003E4__this;

		public string title;

		public int mediaId;

		public int? year;

		public MusicType musicType;

		private TaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<ResponseList<SongResponseDto>> _003C_003Eu__2;

		private int _003Ci_003E5__2;

		private TaskAwaiter<List<SongResponseDto>> _003C_003Eu__3;

		private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter _003C_003Eu__4;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			MainPlayerViewModel mainPlayerViewModel = _003C_003E4__this;
			try
			{
				_ = 4;
				try
				{
					TaskAwaiter awaiter4;
					TaskAwaiter<List<SongResponseDto>> awaiter3;
					TaskAwaiter<ResponseList<SongResponseDto>> awaiter2;
					ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter awaiter;
					ResponseList<SongResponseDto> result;
					List<SongResponseDto> result2;
					List<SongResponseDto>.Enumerator enumerator2;
					string uriString;
					ResponseList<SongResponseDto> result3;
					int num2;
					IEnumerator<SongResponseDto> enumerator;
					switch (num)
					{
					default:
						m5sZxWmLHUhVHrJe8sC.D35lls5iF(mainPlayerViewModel, title, m5sZxWmLHUhVHrJe8sC.d11ItBE073);
						vQKA0r9sJ1kArsIHc16.D35lls5iF(mainPlayerViewModel, mediaId, vQKA0r9sJ1kArsIHc16.mXZIVPAjVb);
						qni3xrDkAJ3vF35eMav.D35lls5iF(mainPlayerViewModel, title, qni3xrDkAJ3vF35eMav.MrYTZduNV7);
						wuXoja6xGA4YsTL6UdU.D35lls5iF(mainPlayerViewModel, year, wuXoja6xGA4YsTL6UdU.XXiI7EqBOv);
						Y200XfIcvNmpHvo8LMM.D35lls5iF(mainPlayerViewModel, musicType, Y200XfIcvNmpHvo8LMM.mUkIM8en7Q);
						qni3xrDkAJ3vF35eMav.D35lls5iF(mainPlayerViewModel, iFZ5je3XFYKwkvcE5D.D35lls5iF(8566, iFZ5je3XFYKwkvcE5D.N06TeK0ao), qni3xrDkAJ3vF35eMav.QN6DuDtCWO);
						qni3xrDkAJ3vF35eMav.D35lls5iF(mainPlayerViewModel, iFZ5je3XFYKwkvcE5D.D35lls5iF(16582, iFZ5je3XFYKwkvcE5D.N06TeK0ao), qni3xrDkAJ3vF35eMav.QN6DuDtCWO);
						awaiter4 = QliBEUviwWqgtMcBndV.D35lls5iF(OYihPsCZ1OyLa5m4TD0.D35lls5iF(mainPlayerViewModel, OYihPsCZ1OyLa5m4TD0.cT2IS5xxZl), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
						if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter4, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
						{
							num = (_003C_003E1__state = 0);
							_003C_003Eu__1 = awaiter4;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
							return;
						}
						goto IL_0123;
					case 0:
						awaiter4 = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter);
						num = (_003C_003E1__state = -1);
						goto IL_0123;
					case 1:
						awaiter2 = _003C_003Eu__2;
						_003C_003Eu__2 = default(TaskAwaiter<ResponseList<SongResponseDto>>);
						num = (_003C_003E1__state = -1);
						goto IL_022d;
					case 2:
						awaiter3 = _003C_003Eu__3;
						_003C_003Eu__3 = default(TaskAwaiter<List<SongResponseDto>>);
						num = (_003C_003E1__state = -1);
						goto IL_0430;
					case 3:
						awaiter2 = _003C_003Eu__2;
						_003C_003Eu__2 = default(TaskAwaiter<ResponseList<SongResponseDto>>);
						num = (_003C_003E1__state = -1);
						goto IL_0653;
					case 4:
						{
							awaiter = _003C_003Eu__4;
							_003C_003Eu__4 = default(ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter);
							num = (_003C_003E1__state = -1);
							break;
						}
						IL_0653:
						result = awaiter2.GetResult();
						enumerator = result.Data.Result.GetEnumerator();
						try
						{
							while (hjMnupQVVDlRZAYQJC.D35lls5iF(enumerator, hjMnupQVVDlRZAYQJC.QV1TFwytOj))
							{
								SongResponseDto current = enumerator.Current;
								vQKA0r9sJ1kArsIHc16.D35lls5iF(current, _003Ci_003E5__2, vQKA0r9sJ1kArsIHc16.aneIhRWuoa);
								mainPlayerViewModel.PlayerPlaylistViewModel.Items.Add(current);
								_003Ci_003E5__2++;
							}
						}
						finally
						{
							if (num < 0 && enumerator != null)
							{
								xLO56JniGyickVjO1Ot.D35lls5iF(enumerator, xLO56JniGyickVjO1Ot.ydbT2bsoH4);
							}
						}
						enumerator = result.Data.Result.OrderBy((SongResponseDto x) => AJWZAgGN6JsveNQ5b3f.D35lls5iF(AJWZAgGN6JsveNQ5b3f.m11GOl5vbN)).GetEnumerator();
						try
						{
							while (hjMnupQVVDlRZAYQJC.D35lls5iF(enumerator, hjMnupQVVDlRZAYQJC.QV1TFwytOj))
							{
								SongResponseDto current2 = enumerator.Current;
								mainPlayerViewModel.PlayerPlaylistViewModel.RandomizItems.Add(current2);
							}
						}
						finally
						{
							if (num < 0 && enumerator != null)
							{
								xLO56JniGyickVjO1Ot.D35lls5iF(enumerator, xLO56JniGyickVjO1Ot.ydbT2bsoH4);
							}
						}
						mainPlayerViewModel.PlayerPlaylistViewModel.ViewItems = mainPlayerViewModel.PlayerPlaylistViewModel.Items;
						TWDbV1IEhKw9PkLfweg.D35lls5iF(mainPlayerViewModel, mainPlayerViewModel.PlayerPlaylistViewModel.ViewItems.FirstOrDefault(), TWDbV1IEhKw9PkLfweg.VXjIBNJQ0G);
						mainPlayerViewModel.PlayerPlaylistViewModel.SelectedItem = mainPlayerViewModel.PlayerPlaylistViewModel.ViewItems.FirstOrDefault();
						goto IL_07bb;
						IL_0123:
						oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter4, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
						mainPlayerViewModel.PlayerPlaylistViewModel.Items.Clear();
						mainPlayerViewModel.PlayerPlaylistViewModel.RandomizItems.Clear();
						if (RwJ2RhIKklkVqOlD6ZY.D35lls5iF(mainPlayerViewModel, RwJ2RhIKklkVqOlD6ZY.i16INZUMpH) == MusicType.Album)
						{
							WtB81JIOL6SEa4MokDo.D35lls5iF(mainPlayerViewModel, WtB81JIOL6SEa4MokDo.RB9Iub51Kt).Count = -1;
							wuXoja6xGA4YsTL6UdU.D35lls5iF(WtB81JIOL6SEa4MokDo.D35lls5iF(mainPlayerViewModel, WtB81JIOL6SEa4MokDo.RB9Iub51Kt).Search, m9MGZR7k2RmVqYXYS5.D35lls5iF(mainPlayerViewModel, m9MGZR7k2RmVqYXYS5.vThEs7vEk0), wuXoja6xGA4YsTL6UdU.dxsIPiAZ9F);
							wuXoja6xGA4YsTL6UdU.D35lls5iF(WtB81JIOL6SEa4MokDo.D35lls5iF(mainPlayerViewModel, WtB81JIOL6SEa4MokDo.RB9Iub51Kt).Search, null, wuXoja6xGA4YsTL6UdU.bYQIsJ0MxO);
							awaiter2 = minABoCzdK7QB6vVIpY.D35lls5iF(mainPlayerViewModel.NBaVaCuxib, WtB81JIOL6SEa4MokDo.D35lls5iF(mainPlayerViewModel, WtB81JIOL6SEa4MokDo.RB9Iub51Kt), minABoCzdK7QB6vVIpY.JfsmoVshEs).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num = (_003C_003E1__state = 1);
								_003C_003Eu__2 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
							goto IL_022d;
						}
						if (RwJ2RhIKklkVqOlD6ZY.D35lls5iF(mainPlayerViewModel, RwJ2RhIKklkVqOlD6ZY.i16INZUMpH) == MusicType.Playlist)
						{
							if (m9MGZR7k2RmVqYXYS5.D35lls5iF(mainPlayerViewModel, m9MGZR7k2RmVqYXYS5.vThEs7vEk0) == 0)
							{
								_003Ci_003E5__2 = 1;
								awaiter3 = rfs22oIx62BcGju6oX9.D35lls5iF(mainPlayerViewModel.NBaVaCuxib, new ApiQuery<GeneralSearch, GeneralSort>
								{
									Search = new GeneralSearch(),
									Count = -1
								}, rfs22oIx62BcGju6oX9.HM9IYAB96A).GetAwaiter();
								if (!awaiter3.IsCompleted)
								{
									num = (_003C_003E1__state = 2);
									_003C_003Eu__3 = awaiter3;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
									return;
								}
								goto IL_0430;
							}
							WtB81JIOL6SEa4MokDo.D35lls5iF(mainPlayerViewModel, WtB81JIOL6SEa4MokDo.RB9Iub51Kt).Count = -1;
							wuXoja6xGA4YsTL6UdU.D35lls5iF(WtB81JIOL6SEa4MokDo.D35lls5iF(mainPlayerViewModel, WtB81JIOL6SEa4MokDo.RB9Iub51Kt).Search, m9MGZR7k2RmVqYXYS5.D35lls5iF(mainPlayerViewModel, m9MGZR7k2RmVqYXYS5.vThEs7vEk0), wuXoja6xGA4YsTL6UdU.bYQIsJ0MxO);
							wuXoja6xGA4YsTL6UdU.D35lls5iF(WtB81JIOL6SEa4MokDo.D35lls5iF(mainPlayerViewModel, WtB81JIOL6SEa4MokDo.RB9Iub51Kt).Search, null, wuXoja6xGA4YsTL6UdU.dxsIPiAZ9F);
							_003Ci_003E5__2 = 1;
							awaiter2 = minABoCzdK7QB6vVIpY.D35lls5iF(mainPlayerViewModel.NBaVaCuxib, WtB81JIOL6SEa4MokDo.D35lls5iF(mainPlayerViewModel, WtB81JIOL6SEa4MokDo.RB9Iub51Kt), minABoCzdK7QB6vVIpY.JfsmoVshEs).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num = (_003C_003E1__state = 3);
								_003C_003Eu__2 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
							goto IL_0653;
						}
						goto IL_07bb;
						IL_0430:
						result2 = awaiter3.GetResult();
						enumerator2 = result2.GetEnumerator();
						try
						{
							while (enumerator2.MoveNext())
							{
								SongResponseDto current3 = enumerator2.Current;
								vQKA0r9sJ1kArsIHc16.D35lls5iF(current3, _003Ci_003E5__2, vQKA0r9sJ1kArsIHc16.aneIhRWuoa);
								mainPlayerViewModel.PlayerPlaylistViewModel.Items.Add(current3);
								_003Ci_003E5__2++;
							}
						}
						finally
						{
							if (num < 0)
							{
								((IDisposable)enumerator2/*cast due to constrained. prefix*/).Dispose();
							}
						}
						enumerator = result2.OrderBy((SongResponseDto x) => AJWZAgGN6JsveNQ5b3f.D35lls5iF(AJWZAgGN6JsveNQ5b3f.m11GOl5vbN)).GetEnumerator();
						try
						{
							while (hjMnupQVVDlRZAYQJC.D35lls5iF(enumerator, hjMnupQVVDlRZAYQJC.QV1TFwytOj))
							{
								SongResponseDto current4 = enumerator.Current;
								mainPlayerViewModel.PlayerPlaylistViewModel.RandomizItems.Add(current4);
							}
						}
						finally
						{
							if (num < 0 && enumerator != null)
							{
								xLO56JniGyickVjO1Ot.D35lls5iF(enumerator, xLO56JniGyickVjO1Ot.ydbT2bsoH4);
							}
						}
						mainPlayerViewModel.PlayerPlaylistViewModel.ViewItems = mainPlayerViewModel.PlayerPlaylistViewModel.Items;
						TWDbV1IEhKw9PkLfweg.D35lls5iF(mainPlayerViewModel, mainPlayerViewModel.PlayerPlaylistViewModel.ViewItems.FirstOrDefault(), TWDbV1IEhKw9PkLfweg.VXjIBNJQ0G);
						mainPlayerViewModel.PlayerPlaylistViewModel.SelectedItem = mainPlayerViewModel.PlayerPlaylistViewModel.ViewItems.FirstOrDefault();
						goto IL_07bb;
						IL_07bb:
						qni3xrDkAJ3vF35eMav.D35lls5iF(mainPlayerViewModel, pnvE8rm9NRTK7Tblimu.D35lls5iF(mainPlayerViewModel.PlayerPlaylistViewModel.SelectedItem as SongResponseDto, pnvE8rm9NRTK7Tblimu.PhoI06dPjC), qni3xrDkAJ3vF35eMav.MrYTZduNV7);
						m5sZxWmLHUhVHrJe8sC.D35lls5iF(mainPlayerViewModel, pnvE8rm9NRTK7Tblimu.D35lls5iF(XTpI9xIr95A1TWYSWp4.D35lls5iF(mainPlayerViewModel.PlayerPlaylistViewModel.SelectedItem as SongResponseDto, XTpI9xIr95A1TWYSWp4.pgVIepITG2), pnvE8rm9NRTK7Tblimu.DQ6IGCcPAn), m5sZxWmLHUhVHrJe8sC.A0PIR9gpvB);
						m5sZxWmLHUhVHrJe8sC.D35lls5iF(mainPlayerViewModel, QQLie3eYkZwbFFm9Jjw.D35lls5iF(mainPlayerViewModel.PlayerPlaylistViewModel.SelectedItem as SongResponseDto, QQLie3eYkZwbFFm9Jjw.iBTCbal3Fb), m5sZxWmLHUhVHrJe8sC.mbEIkNfVnX);
						uriString = pnvE8rm9NRTK7Tblimu.D35lls5iF(new Uri(UwSEfC4rh9eVlFenwI.D35lls5iF(pnvE8rm9NRTK7Tblimu.D35lls5iF(mainPlayerViewModel.PlayerPlaylistViewModel.SelectedItem as SongResponseDto, pnvE8rm9NRTK7Tblimu.hj8IvJoMM8), pnvE8rm9NRTK7Tblimu.D35lls5iF(mainPlayerViewModel.PlayerPlaylistViewModel.SelectedItem as SongResponseDto, pnvE8rm9NRTK7Tblimu.PhoI06dPjC), UwSEfC4rh9eVlFenwI.J6G3NC9nSO)), pnvE8rm9NRTK7Tblimu.fnLajxXY1u);
						awaiter = mchHD5pbvoLh6YJmlai.D35lls5iF(mainPlayerViewModel.MediaElement, new Uri(uriString), mchHD5pbvoLh6YJmlai.ahJpW0oay7).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (_003C_003E1__state = 4);
							_003C_003Eu__4 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						break;
						IL_022d:
						result3 = awaiter2.GetResult();
						num2 = 1;
						enumerator = result3.Data.Result.GetEnumerator();
						try
						{
							while (hjMnupQVVDlRZAYQJC.D35lls5iF(enumerator, hjMnupQVVDlRZAYQJC.QV1TFwytOj))
							{
								SongResponseDto current5 = enumerator.Current;
								vQKA0r9sJ1kArsIHc16.D35lls5iF(current5, num2, vQKA0r9sJ1kArsIHc16.aneIhRWuoa);
								mainPlayerViewModel.PlayerPlaylistViewModel.Items.Add(current5);
								num2++;
							}
						}
						finally
						{
							if (num < 0 && enumerator != null)
							{
								xLO56JniGyickVjO1Ot.D35lls5iF(enumerator, xLO56JniGyickVjO1Ot.ydbT2bsoH4);
							}
						}
						enumerator = result3.Data.Result.OrderBy((SongResponseDto x) => AJWZAgGN6JsveNQ5b3f.D35lls5iF(AJWZAgGN6JsveNQ5b3f.m11GOl5vbN)).GetEnumerator();
						try
						{
							while (hjMnupQVVDlRZAYQJC.D35lls5iF(enumerator, hjMnupQVVDlRZAYQJC.QV1TFwytOj))
							{
								SongResponseDto current6 = enumerator.Current;
								mainPlayerViewModel.PlayerPlaylistViewModel.RandomizItems.Add(current6);
							}
						}
						finally
						{
							if (num < 0 && enumerator != null)
							{
								xLO56JniGyickVjO1Ot.D35lls5iF(enumerator, xLO56JniGyickVjO1Ot.ydbT2bsoH4);
							}
						}
						mainPlayerViewModel.PlayerPlaylistViewModel.ViewItems = mainPlayerViewModel.PlayerPlaylistViewModel.Items;
						TWDbV1IEhKw9PkLfweg.D35lls5iF(mainPlayerViewModel, mainPlayerViewModel.PlayerPlaylistViewModel.ViewItems.FirstOrDefault(), TWDbV1IEhKw9PkLfweg.VXjIBNJQ0G);
						mainPlayerViewModel.PlayerPlaylistViewModel.SelectedItem = mainPlayerViewModel.PlayerPlaylistViewModel.ViewItems.FirstOrDefault();
						goto IL_07bb;
					}
					awaiter.GetResult();
					if (!LsA6RHpKkbdnOn3fX60.D35lls5iF(mainPlayerViewModel.J8GVZpf7GE, LsA6RHpKkbdnOn3fX60.kZiIAOQZKm))
					{
						QnJnl7fVDKI4mA6voc.D35lls5iF(mainPlayerViewModel.J8GVZpf7GE, true, QnJnl7fVDKI4mA6voc.dUxHsdI86U);
					}
					jPB9Q5LdIM9wsuWV1q7.D35lls5iF(mainPlayerViewModel, true, jPB9Q5LdIM9wsuWV1q7.anPIU0otUh);
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
	private ICommand B7qVjH87C2;

	[CompilerGenerated]
	private ICommand UH7Vv6BejP;

	[CompilerGenerated]
	private ICommand lAUVW9xPOi;

	[CompilerGenerated]
	private ICommand qqAV4t1s0Y;

	[CompilerGenerated]
	private ICommand ataVBJId47;

	[CompilerGenerated]
	private ICommand GcJVDoomBg;

	[CompilerGenerated]
	private ICommand ekxVd6ebtU;

	[CompilerGenerated]
	private ICommand C7KVPkedGh;

	private bool uMmVqs26oK;

	private readonly IPlaylistService lnwVIR2vlb;

	private string WfhVVlpLV8;

	private readonly IMusicService NBaVaCuxib;

	private ObservableCollection<PlayListItemModel<SongResponseDto>> mX2V0maVJs;

	private IStoreContext wAFVGZpTsR;

	private ILiveService CPhVTEHOLq;

	private readonly HomeViewModel J8GVZpf7GE;

	private BaseMediaDto TAeVt94GjT;

	private string ooCVSvpUPT;

	private string wZxVf6fLM9;

	private string BYWVKifOcU;

	public bool _isRandomizingMediaEnabled;

	private string Mk6VkZ91Q6;

	private bool WodV8sJuB4;

	[CompilerGenerated]
	private int J57VQokxDn;

	[CompilerGenerated]
	private int? WfYVnU1otD;

	[CompilerGenerated]
	private MusicType mwiVbBChO6;

	[CompilerGenerated]
	private ApiQuery<SongSearch, SongSort> wa6V7u8smp;

	public ICommand AddToFavorite
	{
		[CompilerGenerated]
		get
		{
			return B7qVjH87C2;
		}
		[CompilerGenerated]
		set
		{
			B7qVjH87C2 = value;
		}
	}

	public ICommand PlayNextCommand
	{
		[CompilerGenerated]
		get
		{
			return UH7Vv6BejP;
		}
		[CompilerGenerated]
		private set
		{
			UH7Vv6BejP = value;
		}
	}

	public ICommand PlayPreviousCommand
	{
		[CompilerGenerated]
		get
		{
			return lAUVW9xPOi;
		}
		[CompilerGenerated]
		private set
		{
			lAUVW9xPOi = value;
		}
	}

	public ICommand OpenPlayListCommand
	{
		[CompilerGenerated]
		get
		{
			return qqAV4t1s0Y;
		}
		[CompilerGenerated]
		set
		{
			qqAV4t1s0Y = value;
		}
	}

	public ICommand ClosePlayListCommand
	{
		[CompilerGenerated]
		get
		{
			return ataVBJId47;
		}
		[CompilerGenerated]
		private set
		{
			ataVBJId47 = value;
		}
	}

	public ICommand CreatePlayListCommand
	{
		[CompilerGenerated]
		get
		{
			return GcJVDoomBg;
		}
		[CompilerGenerated]
		private set
		{
			GcJVDoomBg = value;
		}
	}

	public ICommand RemovePlaylistCommand
	{
		[CompilerGenerated]
		get
		{
			return ekxVd6ebtU;
		}
		[CompilerGenerated]
		set
		{
			ekxVd6ebtU = value;
		}
	}

	public ICommand PlayVideoCommand
	{
		[CompilerGenerated]
		get
		{
			return C7KVPkedGh;
		}
		[CompilerGenerated]
		set
		{
			C7KVPkedGh = value;
		}
	}

	public int MediaId
	{
		[CompilerGenerated]
		get
		{
			return J57VQokxDn;
		}
		[CompilerGenerated]
		set
		{
			J57VQokxDn = value;
		}
	}

	public int? Year
	{
		[CompilerGenerated]
		get
		{
			return WfYVnU1otD;
		}
		[CompilerGenerated]
		set
		{
			WfYVnU1otD = value;
		}
	}

	public MusicType MusicType
	{
		[CompilerGenerated]
		get
		{
			return mwiVbBChO6;
		}
		[CompilerGenerated]
		set
		{
			mwiVbBChO6 = value;
		}
	}

	public ApiQuery<SongSearch, SongSort> Query
	{
		[CompilerGenerated]
		get
		{
			return wa6V7u8smp;
		}
		[CompilerGenerated]
		set
		{
			wa6V7u8smp = value;
		}
	}

	public bool IsLoopingMediaEnabled
	{
		get
		{
			Unosquare.FFME.MediaElement mediaElement = base.MediaElement;
			if (mediaElement == null)
			{
				return false;
			}
			return mVvtS7EIHM1vMqAX3i0.D35lls5iF(mediaElement, mVvtS7EIHM1vMqAX3i0.W0xEdQomBN) == MediaPlaybackState.Play;
		}
		set
		{
			Unosquare.FFME.MediaElement mediaElement = base.MediaElement;
			if (mediaElement != null)
			{
				bd2g87HjdsPQhE4qXsh.D35lls5iF(mediaElement, value ? MediaPlaybackState.Play : MediaPlaybackState.Pause, bd2g87HjdsPQhE4qXsh.xhpEUAKKJ0);
				qni3xrDkAJ3vF35eMav.D35lls5iF(this, iFZ5je3XFYKwkvcE5D.D35lls5iF(11462, iFZ5je3XFYKwkvcE5D.N06TeK0ao), qni3xrDkAJ3vF35eMav.QN6DuDtCWO);
			}
		}
	}

	public bool IsRandomizingMediaEnabled
	{
		get
		{
			return _isRandomizingMediaEnabled;
		}
		set
		{
			_003C_003Ec__DisplayClass76_0 CS_0024_003C_003E8__locals8 = new _003C_003Ec__DisplayClass76_0();
			CS_0024_003C_003E8__locals8.Y3PfVj8xdT = value;
			CS_0024_003C_003E8__locals8.atkfaLrj36 = this;
			SetProperty(ref _isRandomizingMediaEnabled, CS_0024_003C_003E8__locals8.Y3PfVj8xdT, iFZ5je3XFYKwkvcE5D.D35lls5iF(11508, iFZ5je3XFYKwkvcE5D.N06TeK0ao), null, delegate
			{
				if (CS_0024_003C_003E8__locals8.Y3PfVj8xdT)
				{
					CS_0024_003C_003E8__locals8.atkfaLrj36.PlayerPlaylistViewModel.ViewItems = CS_0024_003C_003E8__locals8.atkfaLrj36.PlayerPlaylistViewModel.RandomizItems;
				}
				else
				{
					CS_0024_003C_003E8__locals8.atkfaLrj36.PlayerPlaylistViewModel.ViewItems = CS_0024_003C_003E8__locals8.atkfaLrj36.PlayerPlaylistViewModel.Items;
				}
			});
		}
	}

	public string SearchText
	{
		get
		{
			return Mk6VkZ91Q6;
		}
		set
		{
			_003C_003Ec__DisplayClass79_0 CS_0024_003C_003E8__locals7 = new _003C_003Ec__DisplayClass79_0();
			CS_0024_003C_003E8__locals7.fXUfGlNqs6 = this;
			CS_0024_003C_003E8__locals7.fZsfTPelF7 = value;
			SetProperty(ref Mk6VkZ91Q6, CS_0024_003C_003E8__locals7.fZsfTPelF7, iFZ5je3XFYKwkvcE5D.D35lls5iF(8892, iFZ5je3XFYKwkvcE5D.N06TeK0ao), null, delegate
			{
				CS_0024_003C_003E8__locals7.fXUfGlNqs6.PlayerPlaylistViewModel.Items.Clear();
				IEnumerator<BaseMediaDto> enumerator = CS_0024_003C_003E8__locals7.fXUfGlNqs6.PlayerPlaylistViewModel.ViewItems.GetEnumerator();
				try
				{
					while (hjMnupQVVDlRZAYQJC.D35lls5iF(enumerator, hjMnupQVVDlRZAYQJC.QV1TFwytOj))
					{
						BaseMediaDto current = enumerator.Current;
						string text = eVlRnEIaHT0dqvCx0Kx.D35lls5iF(pnvE8rm9NRTK7Tblimu.D35lls5iF(current as SongResponseDto, pnvE8rm9NRTK7Tblimu.PhoI06dPjC), eVlRnEIaHT0dqvCx0Kx.PLmIIMWEZ7);
						string text2 = CS_0024_003C_003E8__locals7.fZsfTPelF7;
						if (VMs7lU9URBMKdJRC1h1.D35lls5iF(text, (text2 != null) ? eVlRnEIaHT0dqvCx0Kx.D35lls5iF(text2, eVlRnEIaHT0dqvCx0Kx.rluIdyZWI1) : null, VMs7lU9URBMKdJRC1h1.p7T9tIfMiJ))
						{
							CS_0024_003C_003E8__locals7.fXUfGlNqs6.PlayerPlaylistViewModel.Items.Add(current);
						}
					}
				}
				finally
				{
					if (enumerator != null)
					{
						xLO56JniGyickVjO1Ot.D35lls5iF(enumerator, xLO56JniGyickVjO1Ot.ydbT2bsoH4);
					}
				}
			});
		}
	}

	public string PlaylistName
	{
		get
		{
			return wZxVf6fLM9;
		}
		set
		{
			SetProperty(ref wZxVf6fLM9, value, iFZ5je3XFYKwkvcE5D.D35lls5iF(11562, iFZ5je3XFYKwkvcE5D.N06TeK0ao));
		}
	}

	public string RealPlaylistName
	{
		get
		{
			return BYWVKifOcU;
		}
		set
		{
			SetProperty(ref BYWVKifOcU, value, iFZ5je3XFYKwkvcE5D.D35lls5iF(11590, iFZ5je3XFYKwkvcE5D.N06TeK0ao));
		}
	}

	public string PersonName
	{
		get
		{
			return ooCVSvpUPT;
		}
		set
		{
			SetProperty(ref ooCVSvpUPT, value, iFZ5je3XFYKwkvcE5D.D35lls5iF(11626, iFZ5je3XFYKwkvcE5D.N06TeK0ao));
		}
	}

	public BaseMediaDto Media
	{
		get
		{
			return TAeVt94GjT;
		}
		set
		{
			SetProperty(ref TAeVt94GjT, value, iFZ5je3XFYKwkvcE5D.D35lls5iF(10702, iFZ5je3XFYKwkvcE5D.N06TeK0ao));
		}
	}

	public bool ShowFavoriteVisibility
	{
		get
		{
			return WodV8sJuB4;
		}
		set
		{
			SetProperty(ref WodV8sJuB4, value, iFZ5je3XFYKwkvcE5D.D35lls5iF(11650, iFZ5je3XFYKwkvcE5D.N06TeK0ao));
		}
	}

	public ObservableCollection<PlayListItemModel<SongResponseDto>> PlayLists
	{
		get
		{
			return mX2V0maVJs;
		}
		set
		{
			SetProperty(ref mX2V0maVJs, value, iFZ5je3XFYKwkvcE5D.D35lls5iF(10480, iFZ5je3XFYKwkvcE5D.N06TeK0ao));
		}
	}

	public bool PlayListVisiblity
	{
		get
		{
			return uMmVqs26oK;
		}
		set
		{
			SetProperty(ref uMmVqs26oK, value, iFZ5je3XFYKwkvcE5D.D35lls5iF(10502, iFZ5je3XFYKwkvcE5D.N06TeK0ao), null, [AsyncStateMachine(typeof(_003C_003Ec.RvQ4w9esrvBTXm1UXW))] () =>
			{
				_003C_003Ec.RvQ4w9esrvBTXm1UXW stateMachine = default(_003C_003Ec.RvQ4w9esrvBTXm1UXW);
				stateMachine.EdubEh3gai = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
				stateMachine.jkYbwL4Ury = -1;
				stateMachine.EdubEh3gai.Start(ref stateMachine);
			});
		}
	}

	public string NewPlaylistName
	{
		get
		{
			return WfhVVlpLV8;
		}
		set
		{
			SetProperty(ref WfhVVlpLV8, value, iFZ5je3XFYKwkvcE5D.D35lls5iF(10578, iFZ5je3XFYKwkvcE5D.N06TeK0ao));
		}
	}

	[AsyncStateMachine(typeof(_003COnCreatePlayListCommandExcute_003Ed__32))]
	private void JtXImMsvqR()
	{
		_003COnCreatePlayListCommandExcute_003Ed__32 stateMachine = default(_003COnCreatePlayListCommandExcute_003Ed__32);
		stateMachine._003C_003Et__builder = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void bSHIXTI28V()
	{
		jPB9Q5LdIM9wsuWV1q7.D35lls5iF(this, false, jPB9Q5LdIM9wsuWV1q7.ayaEmChjMs);
		qni3xrDkAJ3vF35eMav.D35lls5iF(this, "", qni3xrDkAJ3vF35eMav.AKQEatUluq);
	}

	[AsyncStateMachine(typeof(_003COnOpenPlayListCommandExcute_003Ed__34))]
	private Task d7EIR5NwLd(SongResponseDto P_0)
	{
		_003COnOpenPlayListCommandExcute_003Ed__34 stateMachine = default(_003COnOpenPlayListCommandExcute_003Ed__34);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine.arg = P_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	[AsyncStateMachine(typeof(_003COnAddToFavoriteCommandExcute_003Ed__35))]
	private Task yrTIw1VXDd(SongResponseDto P_0)
	{
		_003COnAddToFavoriteCommandExcute_003Ed__35 stateMachine = default(_003COnAddToFavoriteCommandExcute_003Ed__35);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine.arg = P_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	[AsyncStateMachine(typeof(_003COnPlayNextCommandExcute_003Ed__36))]
	internal void mB4IE3mGF3()
	{
		_003COnPlayNextCommandExcute_003Ed__36 stateMachine = default(_003COnPlayNextCommandExcute_003Ed__36);
		stateMachine._003C_003Et__builder = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003COnPlayPreviousCommandExcute_003Ed__37))]
	internal void HAGI9lgL0J()
	{
		_003COnPlayPreviousCommandExcute_003Ed__37 stateMachine = default(_003COnPlayPreviousCommandExcute_003Ed__37);
		stateMachine._003C_003Et__builder = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void wBIIeBi59d()
	{
		GrowlInfo growlInfo = new GrowlInfo();
		qni3xrDkAJ3vF35eMav.D35lls5iF(growlInfo, iFZ5je3XFYKwkvcE5D.D35lls5iF(11414, iFZ5je3XFYKwkvcE5D.N06TeK0ao), qni3xrDkAJ3vF35eMav.uO13ijEghe);
		qni3xrDkAJ3vF35eMav.D35lls5iF(growlInfo, iFZ5je3XFYKwkvcE5D.D35lls5iF(11444, iFZ5je3XFYKwkvcE5D.N06TeK0ao), qni3xrDkAJ3vF35eMav.qyG3QmClWc);
		qni3xrDkAJ3vF35eMav.D35lls5iF(growlInfo, iFZ5je3XFYKwkvcE5D.D35lls5iF(11454, iFZ5je3XFYKwkvcE5D.N06TeK0ao), qni3xrDkAJ3vF35eMav.End3XMD82W);
		pMc99K3f9n18uQscAet.D35lls5iF(growlInfo, delegate(bool P_0)
		{
			try
			{
				if (P_0)
				{
					Task<Response<string>> task = kX9fLZEhK7aolYVmO4m.D35lls5iF(lnwVIR2vlb, m9MGZR7k2RmVqYXYS5.D35lls5iF(this, m9MGZR7k2RmVqYXYS5.vThEs7vEk0), kX9fLZEhK7aolYVmO4m.c4rEx9Zogg);
					Action<Exception> action = null;
					bool flag = false;
					gBlEqv8jRKikCj2DMZp.D35lls5iF(task, ref action, ref flag, gBlEqv8jRKikCj2DMZp.pSp8ymt8Mu);
				}
			}
			catch
			{
			}
			return true;
		}, pMc99K3f9n18uQscAet.Hkt3F19C5f);
		vQKA0r9sJ1kArsIHc16.D35lls5iF(growlInfo, 1, vQKA0r9sJ1kArsIHc16.J2H32QZip9);
		N6BDbM3ZCKImRHES6LV.D35lls5iF(growlInfo, InfoType.Ask, N6BDbM3ZCKImRHES6LV.PMC3j7Ampb);
		QnJnl7fVDKI4mA6voc.D35lls5iF(growlInfo, false, QnJnl7fVDKI4mA6voc.lro3y5Gpy2);
		QnJnl7fVDKI4mA6voc.D35lls5iF(growlInfo, false, QnJnl7fVDKI4mA6voc.Fhs3qEKDES);
		NMRVYn3JvZav0metctL.D35lls5iF(growlInfo, NMRVYn3JvZav0metctL.ARG3bx3kOw);
	}

	[AsyncStateMachine(typeof(_003COnPlayVideoCommandExcuteAsync_003Ed__39))]
	private Task RfNIOTPXVM(SongResponseDto P_0)
	{
		_003COnPlayVideoCommandExcuteAsync_003Ed__39 stateMachine = default(_003COnPlayVideoCommandExcuteAsync_003Ed__39);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine.arg = P_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	public MainPlayerViewModel()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector();
		KFPqfXEA4bOmtrXTkLA.D35lls5iF(this, new DelegateCommand(delegate
		{
			EcRAvP4y5i6535dlslT.D35lls5iF(this, EcRAvP4y5i6535dlslT.GvsEYNBxfQ);
		}), KFPqfXEA4bOmtrXTkLA.fdHEt2V9tb);
		KFPqfXEA4bOmtrXTkLA.D35lls5iF(this, new DelegateCommand(delegate
		{
			EcRAvP4y5i6535dlslT.D35lls5iF(this, EcRAvP4y5i6535dlslT.Tl7Egb6dv6);
		}), KFPqfXEA4bOmtrXTkLA.lMCEVbPbAV);
		KFPqfXEA4bOmtrXTkLA.D35lls5iF(this, new AsyncCommand<SongResponseDto>(yrTIw1VXDd), KFPqfXEA4bOmtrXTkLA.e1yE7M3YtX);
		KFPqfXEA4bOmtrXTkLA.D35lls5iF(this, new AsyncCommand<SongResponseDto>(d7EIR5NwLd), KFPqfXEA4bOmtrXTkLA.dCmEcZj1uk);
		KFPqfXEA4bOmtrXTkLA.D35lls5iF(this, new DelegateCommand(delegate
		{
			EcRAvP4y5i6535dlslT.D35lls5iF(this, EcRAvP4y5i6535dlslT.sBHEiTS7nt);
		}), KFPqfXEA4bOmtrXTkLA.k2yEMPYYFB);
		KFPqfXEA4bOmtrXTkLA.D35lls5iF(this, new DelegateCommand(delegate
		{
			EcRAvP4y5i6535dlslT.D35lls5iF(this, EcRAvP4y5i6535dlslT.Nx7EQMasj9);
		}), KFPqfXEA4bOmtrXTkLA.h87ES4Xvmc);
		KFPqfXEA4bOmtrXTkLA.D35lls5iF(this, new DelegateCommand(delegate
		{
			EcRAvP4y5i6535dlslT.D35lls5iF(this, EcRAvP4y5i6535dlslT.uELEX4FByB);
		}), KFPqfXEA4bOmtrXTkLA.uVKEK7PUdm);
		KFPqfXEA4bOmtrXTkLA.D35lls5iF(this, new AsyncCommand<SongResponseDto>(RfNIOTPXVM), KFPqfXEA4bOmtrXTkLA.erPENWJx6q);
		CqgXtaEOmR1351SjAZ4.D35lls5iF(this, new ApiQuery<SongSearch, SongSort>
		{
			Search = new SongSearch()
		}, CqgXtaEOmR1351SjAZ4.wMcEuE5nNK);
		QHWghGLE86eZIeyQchT.D35lls5iF(this, new ObservableCollection<PlayListItemModel<SongResponseDto>>(), QHWghGLE86eZIeyQchT.dGpEPim9Q7);
		CPhVTEHOLq = AppContainer.Resolve<ILiveService>();
		wAFVGZpTsR = AppContainer.Resolve<IStoreContext>();
		NBaVaCuxib = AppContainer.Resolve<IMusicService>();
		lnwVIR2vlb = AppContainer.Resolve<IPlaylistService>();
		J8GVZpf7GE = AppContainer.Resolve<HomeViewModel>();
		base.PlayerPlaylistViewModel = new PlayerPlaylistViewModel<BaseMediaDto>(this);
		base.Controller = new ControllerViewModel<BaseMediaDto>(this)
		{
			SeekBarVisibility = Visibility.Collapsed,
			PostionProgressVisibility = Visibility.Collapsed
		};
	}

	[AsyncStateMachine(typeof(_003CLoadPlayLists_003Ed__105))]
	public Task LoadPlayLists()
	{
		_003CLoadPlayLists_003Ed__105 stateMachine = default(_003CLoadPlayLists_003Ed__105);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	public override void OnLoading()
	{
	}

	[AsyncStateMachine(typeof(_003COnOpenCommandExcuteAsync_003Ed__107))]
	public override void OnOpenCommandExcuteAsync(BaseMediaDto obj)
	{
		_003COnOpenCommandExcuteAsync_003Ed__107 stateMachine = default(_003COnOpenCommandExcuteAsync_003Ed__107);
		stateMachine._003C_003Et__builder = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
		stateMachine._003C_003E4__this = this;
		stateMachine.obj = obj;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003CPlayeSong_003Ed__108))]
	public Task PlayeSong(SongResponseDto arg, List<SongResponseDto> lists)
	{
		_003CPlayeSong_003Ed__108 stateMachine = default(_003CPlayeSong_003Ed__108);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine.arg = arg;
		stateMachine.lists = lists;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	[AsyncStateMachine(typeof(_003CPlayeSurah_003Ed__109))]
	internal Task ROBIr9vS82(SurahResponseDto P_0, List<SurahResponseDto> P_1)
	{
		_003CPlayeSurah_003Ed__109 stateMachine = default(_003CPlayeSurah_003Ed__109);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine.arg = P_0;
		stateMachine.lists = P_1;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	[AsyncStateMachine(typeof(_003CLoadMusic_003Ed__110))]
	public Task LoadMusic(MusicType musicType, int mediaId, string title, int? year, SongResponseDto song = null, ObservableCollection<SongResponseDto> items = null)
	{
		_003CLoadMusic_003Ed__110 stateMachine = default(_003CLoadMusic_003Ed__110);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine.musicType = musicType;
		stateMachine.mediaId = mediaId;
		stateMachine.title = title;
		stateMachine.year = year;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	[CompilerGenerated]
	private bool X6HIHdWkdI(BaseMediaDto P_0)
	{
		return m9MGZR7k2RmVqYXYS5.D35lls5iF(P_0, m9MGZR7k2RmVqYXYS5.j871CQO7pP) == m9MGZR7k2RmVqYXYS5.D35lls5iF(I7R9FpHuQv8JsJPdFiv.D35lls5iF(this, I7R9FpHuQv8JsJPdFiv.PTqHPF39pv), m9MGZR7k2RmVqYXYS5.j871CQO7pP);
	}

	[CompilerGenerated]
	private bool UMBIoYdVeP(BaseMediaDto P_0)
	{
		return m9MGZR7k2RmVqYXYS5.D35lls5iF(P_0, m9MGZR7k2RmVqYXYS5.j871CQO7pP) == m9MGZR7k2RmVqYXYS5.D35lls5iF(I7R9FpHuQv8JsJPdFiv.D35lls5iF(this, I7R9FpHuQv8JsJPdFiv.PTqHPF39pv), m9MGZR7k2RmVqYXYS5.j871CQO7pP);
	}

	[CompilerGenerated]
	private bool GdgIgxrGbU(bool P_0)
	{
		try
		{
			if (P_0)
			{
				Task<Response<string>> task = kX9fLZEhK7aolYVmO4m.D35lls5iF(lnwVIR2vlb, m9MGZR7k2RmVqYXYS5.D35lls5iF(this, m9MGZR7k2RmVqYXYS5.vThEs7vEk0), kX9fLZEhK7aolYVmO4m.c4rEx9Zogg);
				Action<Exception> action = null;
				bool flag = false;
				gBlEqv8jRKikCj2DMZp.D35lls5iF(task, ref action, ref flag, gBlEqv8jRKikCj2DMZp.pSp8ymt8Mu);
			}
		}
		catch
		{
		}
		return true;
	}

	[CompilerGenerated]
	private void f4xI1JQs1e(object P_0)
	{
		EcRAvP4y5i6535dlslT.D35lls5iF(this, EcRAvP4y5i6535dlslT.GvsEYNBxfQ);
	}

	[CompilerGenerated]
	private void YLrIJe64Sa(object P_0)
	{
		EcRAvP4y5i6535dlslT.D35lls5iF(this, EcRAvP4y5i6535dlslT.Tl7Egb6dv6);
	}

	[CompilerGenerated]
	private void BEKIhPfIxC(object P_0)
	{
		EcRAvP4y5i6535dlslT.D35lls5iF(this, EcRAvP4y5i6535dlslT.sBHEiTS7nt);
	}

	[CompilerGenerated]
	private void NdhIl30CVG(object P_0)
	{
		EcRAvP4y5i6535dlslT.D35lls5iF(this, EcRAvP4y5i6535dlslT.Nx7EQMasj9);
	}

	[CompilerGenerated]
	private void Sn2IUMXxQP(object P_0)
	{
		EcRAvP4y5i6535dlslT.D35lls5iF(this, EcRAvP4y5i6535dlslT.uELEX4FByB);
	}
}
