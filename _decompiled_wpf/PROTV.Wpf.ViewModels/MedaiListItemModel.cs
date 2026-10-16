using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using PROTV.Abstractions.Common;
using PROTV.Abstractions.DataTransferObjects;
using PROTV.Abstractions.Helpers;
using PROTV.Wpf.Bootstrap;

namespace PROTV.Wpf.ViewModels;

public class MedaiListItemModel<T> : BaseViewModel where T : BaseMediaDto
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass10_0
	{
		public MedaiListItemModel<T> _003C_003E4__this;

		public T value;

		public _003C_003Ec__DisplayClass10_0()
		{
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
			base._002Ector();
		}

		internal void yEyZOcTVts()
		{
			_003C_003E4__this.e1BB2D8RVU(value);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnSelectedItemChange_003Ed__14 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public T value;

		public MedaiListItemModel<T> _003C_003E4__this;

		private HomeViewModel _003ChomeViewModel_003E5__2;

		private Page _003Cpage_003E5__3;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			MedaiListItemModel<T> medaiListItemModel = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				Page page;
				Page page2;
				BaseViewModel viewModel;
				Page page3;
				switch (num)
				{
				default:
					_003ChomeViewModel_003E5__2 = Sp7dKWL9ZfBld4JOkGo.D35lls5iF(AppContainer.Resolve<MainViewModel>(), Sp7dKWL9ZfBld4JOkGo.QpWwMTMAhO) as HomeViewModel;
					switch (UOCWOF1pc2UOe4PjABW.D35lls5iF(value, UOCWOF1pc2UOe4PjABW.TuV1w2E8GR))
					{
					case MediaType.Movie:
						goto IL_0082;
					case MediaType.Series:
						goto IL_017b;
					case MediaType.Song:
						goto IL_0274;
					case MediaType.Episode:
						goto IL_0317;
					case MediaType.Season:
					case MediaType.Person:
					case MediaType.Album:
						break;
					}
					goto end_IL_0015;
				case 0:
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_0149;
				case 1:
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_0242;
				case 2:
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_0306;
				case 3:
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter);
						num = (_003C_003E1__state = -1);
						break;
					}
					IL_0317:
					viewModel = new SereisPlayerViewModel(value as EpisodeResponseDto);
					page = new Page();
					KBhlAv9D2TgBJ1kkc0B.D35lls5iF(page, IyGDDwHBiPv8vfOFJDF.D35lls5iF(ApplicationPage.ShowSeriesPage, viewModel, IyGDDwHBiPv8vfOFJDF.hivH0XYhaE), KBhlAv9D2TgBJ1kkc0B.fWUHrWO7Sa);
					qni3xrDkAJ3vF35eMav.D35lls5iF(page, EBgwuVHeVLDJVVfMaAk.D35lls5iF(ApplicationPage.ShowSeriesPage, EBgwuVHeVLDJVVfMaAk.mtcHG3MEy3), qni3xrDkAJ3vF35eMav.Ra7HRFTvnD);
					_003Cpage_003E5__3 = page;
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(pvrKKy8Mk1kpdmIfp3A.D35lls5iF(5, pvrKKy8Mk1kpdmIfp3A.aVh8SPrFkE), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
					if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
					{
						num = (_003C_003E1__state = 3);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					break;
					IL_0242:
					oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
					GmMLaTD7kV8rq88ZFvR.D35lls5iF(Xlypb0Hnr2C3ydrYEdG.D35lls5iF(_003ChomeViewModel_003E5__2, Xlypb0Hnr2C3ydrYEdG.U3Z1IKMGuZ), _003Cpage_003E5__3, GmMLaTD7kV8rq88ZFvR.iMJHkmaaRY);
					goto end_IL_0015;
					IL_0274:
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(mBZRZ5wNhC66q1qy0dy.D35lls5iF(MI3oOiHCZASyM6ERRUP.D35lls5iF(AppContainer.Resolve<HomeViewModel>(), MI3oOiHCZASyM6ERRUP.h0JHmOSEFB), value as SongResponseDto, medaiListItemModel.Items as List<SongResponseDto>, mBZRZ5wNhC66q1qy0dy.X1gwOhFcpv), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
					if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
					{
						num = (_003C_003E1__state = 2);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_0306;
					IL_0082:
					viewModel = new MovieItemViewModel(value as MovieResponseDto);
					page2 = new Page();
					KBhlAv9D2TgBJ1kkc0B.D35lls5iF(page2, IyGDDwHBiPv8vfOFJDF.D35lls5iF(ApplicationPage.MovieDetailsPage, viewModel, IyGDDwHBiPv8vfOFJDF.hivH0XYhaE), KBhlAv9D2TgBJ1kkc0B.fWUHrWO7Sa);
					qni3xrDkAJ3vF35eMav.D35lls5iF(page2, QQLie3eYkZwbFFm9Jjw.D35lls5iF(value as MovieResponseDto, QQLie3eYkZwbFFm9Jjw.T8RwSgEfbh), qni3xrDkAJ3vF35eMav.Ra7HRFTvnD);
					_003Cpage_003E5__3 = page2;
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(pvrKKy8Mk1kpdmIfp3A.D35lls5iF(5, pvrKKy8Mk1kpdmIfp3A.aVh8SPrFkE), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
					if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_0149;
					IL_0306:
					oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
					goto end_IL_0015;
					IL_017b:
					viewModel = new SeriesItemViewModel(value as SeriesResponseDto);
					page3 = new Page();
					KBhlAv9D2TgBJ1kkc0B.D35lls5iF(page3, IyGDDwHBiPv8vfOFJDF.D35lls5iF(ApplicationPage.SeriesDetailsPage, viewModel, IyGDDwHBiPv8vfOFJDF.hivH0XYhaE), KBhlAv9D2TgBJ1kkc0B.fWUHrWO7Sa);
					qni3xrDkAJ3vF35eMav.D35lls5iF(page3, QQLie3eYkZwbFFm9Jjw.D35lls5iF(value as SeriesResponseDto, QQLie3eYkZwbFFm9Jjw.D7uwK6SQ7w), qni3xrDkAJ3vF35eMav.Ra7HRFTvnD);
					_003Cpage_003E5__3 = page3;
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(pvrKKy8Mk1kpdmIfp3A.D35lls5iF(5, pvrKKy8Mk1kpdmIfp3A.aVh8SPrFkE), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
					if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
					{
						num = (_003C_003E1__state = 1);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_0242;
					IL_0149:
					oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
					GmMLaTD7kV8rq88ZFvR.D35lls5iF(Xlypb0Hnr2C3ydrYEdG.D35lls5iF(_003ChomeViewModel_003E5__2, Xlypb0Hnr2C3ydrYEdG.U3Z1IKMGuZ), _003Cpage_003E5__3, GmMLaTD7kV8rq88ZFvR.iMJHkmaaRY);
					goto end_IL_0015;
				}
				oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
				GmMLaTD7kV8rq88ZFvR.D35lls5iF(Xlypb0Hnr2C3ydrYEdG.D35lls5iF(_003ChomeViewModel_003E5__2, Xlypb0Hnr2C3ydrYEdG.U3Z1IKMGuZ), _003Cpage_003E5__3, GmMLaTD7kV8rq88ZFvR.iMJHkmaaRY);
				end_IL_0015:;
			}
			catch (Exception ex)
			{
				_003C_003E1__state = -2;
				_003ChomeViewModel_003E5__2 = null;
				_003Cpage_003E5__3 = null;
				N2XUglA3neBsnlZfRPQ.D35lls5iF(ref _003C_003Et__builder, ex, N2XUglA3neBsnlZfRPQ.l4pATRumoW);
				return;
			}
			_003C_003E1__state = -2;
			_003ChomeViewModel_003E5__2 = null;
			_003Cpage_003E5__3 = null;
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
	private IEnumerable<T> d4vBzJoKMQ;

	[CompilerGenerated]
	private ICommand P3cDc2BCZf;

	private T cy1DjSCqJ7;

	public IEnumerable<T> Items
	{
		[CompilerGenerated]
		get
		{
			return d4vBzJoKMQ;
		}
		[CompilerGenerated]
		set
		{
			d4vBzJoKMQ = value;
		}
	}

	public ICommand GoToMoreItemsPage
	{
		[CompilerGenerated]
		get
		{
			return P3cDc2BCZf;
		}
		[CompilerGenerated]
		set
		{
			P3cDc2BCZf = value;
		}
	}

	public T SelectedItem
	{
		get
		{
			return cy1DjSCqJ7;
		}
		set
		{
			_003C_003Ec__DisplayClass10_0 CS_0024_003C_003E8__locals5 = new _003C_003Ec__DisplayClass10_0();
			CS_0024_003C_003E8__locals5._003C_003E4__this = this;
			CS_0024_003C_003E8__locals5.value = value;
			SetProperty(ref cy1DjSCqJ7, CS_0024_003C_003E8__locals5.value, iFZ5je3XFYKwkvcE5D.D35lls5iF(8274, iFZ5je3XFYKwkvcE5D.N06TeK0ao), null, delegate
			{
				CS_0024_003C_003E8__locals5._003C_003E4__this.e1BB2D8RVU(CS_0024_003C_003E8__locals5.value);
			});
		}
	}

	public MedaiListItemModel(string title)
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector();
		Items = new List<T>();
		GoToMoreItemsPage = new AsyncCommand(MsvBL1e5CM);
		qni3xrDkAJ3vF35eMav.D35lls5iF(this, title, qni3xrDkAJ3vF35eMav.MrYTZduNV7);
	}

	private Task MsvBL1e5CM()
	{
		throw new NotImplementedException();
	}

	[AsyncStateMachine(typeof(MedaiListItemModel<>._003COnSelectedItemChange_003Ed__14))]
	private void e1BB2D8RVU(T V02AwjWBF6ewDGsvUo)
	{
		_003COnSelectedItemChange_003Ed__14 stateMachine = default(_003COnSelectedItemChange_003Ed__14);
		stateMachine._003C_003Et__builder = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
		stateMachine._003C_003E4__this = this;
		stateMachine.value = V02AwjWBF6ewDGsvUo;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	internal void Clear()
	{
		cy1DjSCqJ7 = null;
		qni3xrDkAJ3vF35eMav.D35lls5iF(this, iFZ5je3XFYKwkvcE5D.D35lls5iF(8274, iFZ5je3XFYKwkvcE5D.N06TeK0ao), qni3xrDkAJ3vF35eMav.QN6DuDtCWO);
	}
}
