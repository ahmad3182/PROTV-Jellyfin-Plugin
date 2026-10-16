using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using PROTV.Abstractions.Common;
using PROTV.Abstractions.DataTransferObjects;
using Unosquare.FFME;

namespace PROTV.Wpf.ViewModels;

public class VideoPlayerPlaylist : BaseVideoPlayerViewModel
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass36_0
	{
		public VideoPlayerPlaylist jmtZsvWJti;

		public VideoPlayerPlaylistItem pSsZxWoFL4;

		public _003C_003Ec__DisplayClass36_0()
		{
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
			base._002Ector();
		}

		internal void C1VZ6uo7l2()
		{
			BbUsgb1HAFAD1uIhrpH.D35lls5iF(GZeA7834rWuxcAAP0En.D35lls5iF(jmtZsvWJti, GZeA7834rWuxcAAP0En.lEyTHiAe9F), pSsZxWoFL4, BbUsgb1HAFAD1uIhrpH.NMM11NbRt6);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass41_0
	{
		public VideoPlayerPlaylist mpAZp3XEJ6;

		public MediaElement QiRZijCDWX;

		public _003C_003Ec__DisplayClass41_0()
		{
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
			base._002Ector();
		}

		internal void SoEZywHUMS()
		{
			jPB9Q5LdIM9wsuWV1q7.D35lls5iF(mpAZp3XEJ6, !LsA6RHpKkbdnOn3fX60.D35lls5iF(QiRZijCDWX, LsA6RHpKkbdnOn3fX60.Lw6piG3FQv), jPB9Q5LdIM9wsuWV1q7.GZTpZp7xIV);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003C_003Cset_SelectedChannelSort_003Eb__27_0_003Ed : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public VideoPlayerPlaylist _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			VideoPlayerPlaylist videoPlayerPlaylist = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(kxYFveE4H3pBXluJ1GJ.D35lls5iF(GZeA7834rWuxcAAP0En.D35lls5iF(videoPlayerPlaylist, GZeA7834rWuxcAAP0En.lEyTHiAe9F), false, kxYFveE4H3pBXluJ1GJ.TADpjOOPUg), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
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

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003C_003Cset_SelectedOrder_003Eb__30_0_003Ed : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public VideoPlayerPlaylist _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			VideoPlayerPlaylist videoPlayerPlaylist = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(kxYFveE4H3pBXluJ1GJ.D35lls5iF(GZeA7834rWuxcAAP0En.D35lls5iF(videoPlayerPlaylist, GZeA7834rWuxcAAP0En.lEyTHiAe9F), false, kxYFveE4H3pBXluJ1GJ.TADpjOOPUg), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
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

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003C_003Cset_SelectedCategory_003Eb__33_0_003Ed : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public VideoPlayerPlaylist _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			VideoPlayerPlaylist videoPlayerPlaylist = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(kxYFveE4H3pBXluJ1GJ.D35lls5iF(GZeA7834rWuxcAAP0En.D35lls5iF(videoPlayerPlaylist, GZeA7834rWuxcAAP0En.lEyTHiAe9F), false, kxYFveE4H3pBXluJ1GJ.TADpjOOPUg), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
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

	private ChannelSort ssQBvEwYii;

	private CategoryResponseDto va7BW1CGnT;

	private SortOrder g87B4XcPLa;

	private bool dkOBBWNDcb;

	private VideoPlayerPlaylistItem o1wBD4dFxk;

	[CompilerGenerated]
	private List<SortOrder> P3xBdjP9yZ;

	[CompilerGenerated]
	private List<ChannelSort> ILIBPI65TR;

	[CompilerGenerated]
	private ObservableCollection<VideoPlayerPlaylistItem> gf3BqwFy7Q;

	[CompilerGenerated]
	private List<VideoPlayerPlaylistItem> JmYBIeXDCK;

	[CompilerGenerated]
	private List<CategoryResponseDto> mePBVdw36N;

	public List<SortOrder> OrderItems
	{
		[CompilerGenerated]
		get
		{
			return P3xBdjP9yZ;
		}
		[CompilerGenerated]
		set
		{
			P3xBdjP9yZ = value;
		}
	}

	public List<ChannelSort> SortItems
	{
		[CompilerGenerated]
		get
		{
			return ILIBPI65TR;
		}
		[CompilerGenerated]
		set
		{
			ILIBPI65TR = value;
		}
	}

	public ObservableCollection<VideoPlayerPlaylistItem> Items
	{
		[CompilerGenerated]
		get
		{
			return gf3BqwFy7Q;
		}
		[CompilerGenerated]
		set
		{
			gf3BqwFy7Q = value;
		}
	}

	public List<VideoPlayerPlaylistItem> EpgItems
	{
		[CompilerGenerated]
		get
		{
			return JmYBIeXDCK;
		}
		[CompilerGenerated]
		set
		{
			JmYBIeXDCK = value;
		}
	}

	public List<CategoryResponseDto> Categories
	{
		[CompilerGenerated]
		get
		{
			return mePBVdw36N;
		}
		[CompilerGenerated]
		set
		{
			mePBVdw36N = value;
		}
	}

	public ChannelSort SelectedChannelSort
	{
		get
		{
			return ssQBvEwYii;
		}
		set
		{
			SetProperty(ref ssQBvEwYii, value, iFZ5je3XFYKwkvcE5D.D35lls5iF(8166, iFZ5je3XFYKwkvcE5D.N06TeK0ao), null, [AsyncStateMachine(typeof(_003C_003Cset_SelectedChannelSort_003Eb__27_0_003Ed))] () =>
			{
				_003C_003Cset_SelectedChannelSort_003Eb__27_0_003Ed stateMachine = default(_003C_003Cset_SelectedChannelSort_003Eb__27_0_003Ed);
				stateMachine._003C_003Et__builder = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
				stateMachine._003C_003E4__this = this;
				stateMachine._003C_003E1__state = -1;
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
			});
		}
	}

	public SortOrder SelectedOrder
	{
		get
		{
			return g87B4XcPLa;
		}
		set
		{
			SetProperty(ref g87B4XcPLa, value, iFZ5je3XFYKwkvcE5D.D35lls5iF(8208, iFZ5je3XFYKwkvcE5D.N06TeK0ao), null, [AsyncStateMachine(typeof(_003C_003Cset_SelectedOrder_003Eb__30_0_003Ed))] () =>
			{
				_003C_003Cset_SelectedOrder_003Eb__30_0_003Ed stateMachine = default(_003C_003Cset_SelectedOrder_003Eb__30_0_003Ed);
				stateMachine._003C_003Et__builder = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
				stateMachine._003C_003E4__this = this;
				stateMachine._003C_003E1__state = -1;
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
			});
		}
	}

	public CategoryResponseDto SelectedCategory
	{
		get
		{
			return va7BW1CGnT;
		}
		set
		{
			SetProperty(ref va7BW1CGnT, value, iFZ5je3XFYKwkvcE5D.D35lls5iF(8238, iFZ5je3XFYKwkvcE5D.N06TeK0ao), null, [AsyncStateMachine(typeof(_003C_003Cset_SelectedCategory_003Eb__33_0_003Ed))] () =>
			{
				_003C_003Cset_SelectedCategory_003Eb__33_0_003Ed stateMachine = default(_003C_003Cset_SelectedCategory_003Eb__33_0_003Ed);
				stateMachine._003C_003Et__builder = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
				stateMachine._003C_003E4__this = this;
				stateMachine._003C_003E1__state = -1;
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
			});
		}
	}

	public VideoPlayerPlaylistItem SelectedItem
	{
		get
		{
			return o1wBD4dFxk;
		}
		set
		{
			_003C_003Ec__DisplayClass36_0 CS_0024_003C_003E8__locals5 = new _003C_003Ec__DisplayClass36_0();
			CS_0024_003C_003E8__locals5.jmtZsvWJti = this;
			CS_0024_003C_003E8__locals5.pSsZxWoFL4 = value;
			SetProperty(ref o1wBD4dFxk, CS_0024_003C_003E8__locals5.pSsZxWoFL4, iFZ5je3XFYKwkvcE5D.D35lls5iF(8274, iFZ5je3XFYKwkvcE5D.N06TeK0ao), null, delegate
			{
				BbUsgb1HAFAD1uIhrpH.D35lls5iF(GZeA7834rWuxcAAP0En.D35lls5iF(CS_0024_003C_003E8__locals5.jmtZsvWJti, GZeA7834rWuxcAAP0En.lEyTHiAe9F), CS_0024_003C_003E8__locals5.pSsZxWoFL4, BbUsgb1HAFAD1uIhrpH.NMM11NbRt6);
			});
		}
	}

	public bool IsPlaylistEnabled
	{
		get
		{
			return dkOBBWNDcb;
		}
		set
		{
			SetProperty(ref dkOBBWNDcb, value, iFZ5je3XFYKwkvcE5D.D35lls5iF(8302, iFZ5je3XFYKwkvcE5D.N06TeK0ao));
		}
	}

	public VideoPlayerPlaylist(VideoPlayerViewModel root)
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		dkOBBWNDcb = true;
		base._002Ector(root);
		g87B4XcPLa = SortOrder.Asc;
		ssQBvEwYii = ChannelSort.Number;
		gJ6gKZTeY7mmAUBnpmH.D35lls5iF(this, new List<ChannelSort>
		{
			ChannelSort.Name,
			ChannelSort.Number
		}, gJ6gKZTeY7mmAUBnpmH.uv1TGsc9pl);
		DlVmjNTRaTpEdNDM6pX.D35lls5iF(this, new List<SortOrder>
		{
			SortOrder.Asc,
			SortOrder.Desc
		}, DlVmjNTRaTpEdNDM6pX.qvTTkJCYH2);
		z0w6LFTvEe4oPH5EA04.D35lls5iF(this, new ObservableCollection<VideoPlayerPlaylistItem>(), z0w6LFTvEe4oPH5EA04.dvPTA9ypb1);
		fbCfXAT6sNT7gTw1IjA.D35lls5iF(this, new List<CategoryResponseDto>(), fbCfXAT6sNT7gTw1IjA.mloTp7dOJ9);
		E0xSFiTwLZJ7JNh4RGk.D35lls5iF(this, new List<VideoPlayerPlaylistItem>(), E0xSFiTwLZJ7JNh4RGk.ssDTC8cbY6);
	}

	public override void OnApplicationLoaded()
	{
		_003C_003Ec__DisplayClass41_0 CS_0024_003C_003E8__locals5 = new _003C_003Ec__DisplayClass41_0();
		CS_0024_003C_003E8__locals5.mpAZp3XEJ6 = this;
		CS_0024_003C_003E8__locals5.QiRZijCDWX = srgd79T1FovS2Zr1sHa.D35lls5iF(GZeA7834rWuxcAAP0En.D35lls5iF(this, GZeA7834rWuxcAAP0En.lEyTHiAe9F), srgd79T1FovS2Zr1sHa.ssHT8Bxex8);
		v0XVuPTnBNWT9uCXcZe.D35lls5iF(delegate
		{
			jPB9Q5LdIM9wsuWV1q7.D35lls5iF(CS_0024_003C_003E8__locals5.mpAZp3XEJ6, !LsA6RHpKkbdnOn3fX60.D35lls5iF(CS_0024_003C_003E8__locals5.QiRZijCDWX, LsA6RHpKkbdnOn3fX60.Lw6piG3FQv), jPB9Q5LdIM9wsuWV1q7.GZTpZp7xIV);
		}, CS_0024_003C_003E8__locals5.QiRZijCDWX, new string[1] { iFZ5je3XFYKwkvcE5D.D35lls5iF(7996, iFZ5je3XFYKwkvcE5D.N06TeK0ao) }, v0XVuPTnBNWT9uCXcZe.MYgT36wkiL);
	}

	[CompilerGenerated]
	[AsyncStateMachine(typeof(_003C_003Cset_SelectedChannelSort_003Eb__27_0_003Ed))]
	private void vl64zRgXNY()
	{
		_003C_003Cset_SelectedChannelSort_003Eb__27_0_003Ed stateMachine = default(_003C_003Cset_SelectedChannelSort_003Eb__27_0_003Ed);
		stateMachine._003C_003Et__builder = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003C_003Cset_SelectedOrder_003Eb__30_0_003Ed))]
	[CompilerGenerated]
	private void pxRBcPZMwK()
	{
		_003C_003Cset_SelectedOrder_003Eb__30_0_003Ed stateMachine = default(_003C_003Cset_SelectedOrder_003Eb__30_0_003Ed);
		stateMachine._003C_003Et__builder = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003C_003Cset_SelectedCategory_003Eb__33_0_003Ed))]
	[CompilerGenerated]
	private void LsoBjamK9d()
	{
		_003C_003Cset_SelectedCategory_003Eb__33_0_003Ed stateMachine = default(_003C_003Cset_SelectedCategory_003Eb__33_0_003Ed);
		stateMachine._003C_003Et__builder = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}
}
