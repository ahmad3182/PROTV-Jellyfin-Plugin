using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;
using PROTV.Abstractions.Common;
using PROTV.Abstractions.DataTransferObjects;
using PROTV.Abstractions.Services;
using PROTV.Wpf.Bootstrap;
using PROTV.Wpf.ViewModels;
using Unosquare.FFME;

namespace PROTV.Wpf.Views;

public class PlaylistSongListView : BasePage<MainPlayerViewModel>, IComponentConnector
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCheckBox_Checked_003Ed__5 : IAsyncStateMachine
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
	private struct _003CFastBackword_Click_003Ed__6 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public PlaylistSongListView _003C_003E4__this;

		private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			PlaylistSongListView playlistSongListView = _003C_003E4__this;
			try
			{
				ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter awaiter;
				if (num != 0)
				{
					Unosquare.FFME.MediaElement mediaElement = playlistSongListView.npGv5FWbvi.MediaElement;
					TimeSpan timeSpan = moA0183RanLCkEiLXks.D35lls5iF(playlistSongListView.npGv5FWbvi.MediaElement, moA0183RanLCkEiLXks.K3o3krsS6B);
					awaiter = S4diFapBIedgOyA2ZLW.D35lls5iF(mediaElement, RNcc8WpL2E6ifDYKDA8.D35lls5iF(ref timeSpan, new TimeSpan(0, 0, -5), RNcc8WpL2E6ifDYKDA8.QFcpEbXGpB), S4diFapBIedgOyA2ZLW.tLrp0SHwhD).GetAwaiter();
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
	private struct _003CFastForward_Click_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public PlaylistSongListView _003C_003E4__this;

		private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			PlaylistSongListView playlistSongListView = _003C_003E4__this;
			try
			{
				ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter awaiter;
				if (num != 0)
				{
					if (num == 1)
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter);
						num = (_003C_003E1__state = -1);
						goto IL_0129;
					}
					Unosquare.FFME.MediaElement mediaElement = playlistSongListView.npGv5FWbvi.MediaElement;
					TimeSpan timeSpan = moA0183RanLCkEiLXks.D35lls5iF(playlistSongListView.npGv5FWbvi.MediaElement, moA0183RanLCkEiLXks.K3o3krsS6B);
					awaiter = S4diFapBIedgOyA2ZLW.D35lls5iF(mediaElement, RNcc8WpL2E6ifDYKDA8.D35lls5iF(ref timeSpan, new TimeSpan(0, 0, 10), RNcc8WpL2E6ifDYKDA8.QFcpEbXGpB), S4diFapBIedgOyA2ZLW.tLrp0SHwhD).GetAwaiter();
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
				awaiter = wd2eJ2Asf3I9epXUKxU.D35lls5iF(playlistSongListView.npGv5FWbvi.MediaElement, wd2eJ2Asf3I9epXUKxU.KSYAxc5OtD).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					num = (_003C_003E1__state = 1);
					_003C_003Eu__1 = awaiter;
					_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
					return;
				}
				goto IL_0129;
				IL_0129:
				awaiter.GetResult();
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
	private struct _003CCheckBox_Unchecked_003Ed__8 : IAsyncStateMachine
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
	private struct _003CButton_Click_5_003Ed__11 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public PlaylistSongListView _003C_003E4__this;

		private TaskAwaiter<Response<PlaylistResponseDto<SongResponseDto>>> _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			PlaylistSongListView playlistSongListView = _003C_003E4__this;
			try
			{
				try
				{
					TaskAwaiter<Response<PlaylistResponseDto<SongResponseDto>>> awaiter;
					if (num != 0)
					{
						awaiter = AppContainer.Resolve<IPlaylistService>().UpdatePlaylisAsyncAsync<SongResponseDto>(m9MGZR7k2RmVqYXYS5.D35lls5iF(playlistSongListView.npGv5FWbvi, m9MGZR7k2RmVqYXYS5.YPh8BUDSSw), wq2usy8gNndpuTw5mR.D35lls5iF(playlistSongListView.newtext, wq2usy8gNndpuTw5mR.iOM1s39R7S)).GetAwaiter();
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
						_003C_003Eu__1 = default(TaskAwaiter<Response<PlaylistResponseDto<SongResponseDto>>>);
						num = (_003C_003E1__state = -1);
					}
					awaiter.GetResult();
				}
				catch
				{
				}
				finally
				{
					if (num < 0)
					{
						YQ4csVD2gHt33yWHvSL.D35lls5iF(playlistSongListView.text, Visibility.Collapsed, YQ4csVD2gHt33yWHvSL.xX51WbqrR2);
					}
				}
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

	private MainPlayerViewModel npGv5FWbvi;

	private int QfWvuHhaET;

	internal Slider PositionSlider;

	internal Grid ControlsPanel;

	internal DockPanel LeftControls;

	internal Button SoundMenuButton_Click;

	internal ToggleButton MuteUnmuteButton;

	internal DockPanel RightControls;

	internal DockPanel CenterControls;

	internal Button editbutton;

	internal Button removebutton;

	internal ListBox list;

	internal Grid playlist;

	internal TextBox NewPlaylistName;

	internal Grid text;

	internal TextBox newtext;

	private bool jgnvAi6Ok9;

	public PlaylistSongListView()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector();
		tApScD14t76npcHoQ1x.D35lls5iF(this, tApScD14t76npcHoQ1x.erm8EnDOKW);
	}

	public PlaylistSongListView(MainPlayerViewModel specificViewModel)
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector(specificViewModel);
		tApScD14t76npcHoQ1x.D35lls5iF(this, tApScD14t76npcHoQ1x.erm8EnDOKW);
		npGv5FWbvi = specificViewModel;
		if (m9MGZR7k2RmVqYXYS5.D35lls5iF(npGv5FWbvi, m9MGZR7k2RmVqYXYS5.YPh8BUDSSw) == 0)
		{
			YQ4csVD2gHt33yWHvSL.D35lls5iF(editbutton, Visibility.Collapsed, YQ4csVD2gHt33yWHvSL.xX51WbqrR2);
			YQ4csVD2gHt33yWHvSL.D35lls5iF(removebutton, Visibility.Collapsed, YQ4csVD2gHt33yWHvSL.xX51WbqrR2);
		}
	}

	private void dsuvSZSYl7(object P_0, RoutedEventArgs P_1)
	{
		qni3xrDkAJ3vF35eMav.D35lls5iF(NewPlaylistName, "", qni3xrDkAJ3vF35eMav.nVo1urWcMH);
	}

	[AsyncStateMachine(typeof(_003CCheckBox_Checked_003Ed__5))]
	private void FxJvfg75fK(object P_0, RoutedEventArgs P_1)
	{
		_003CCheckBox_Checked_003Ed__5 stateMachine = default(_003CCheckBox_Checked_003Ed__5);
		stateMachine._003C_003Et__builder = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003CFastBackword_Click_003Ed__6))]
	private void COLvKWKEY3(object P_0, RoutedEventArgs P_1)
	{
		_003CFastBackword_Click_003Ed__6 stateMachine = default(_003CFastBackword_Click_003Ed__6);
		stateMachine._003C_003Et__builder = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003CFastForward_Click_003Ed__7))]
	private void LKIvkYZlhS(object P_0, RoutedEventArgs P_1)
	{
		_003CFastForward_Click_003Ed__7 stateMachine = default(_003CFastForward_Click_003Ed__7);
		stateMachine._003C_003Et__builder = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003CCheckBox_Unchecked_003Ed__8))]
	private void CDIv81OIRm(object P_0, RoutedEventArgs P_1)
	{
		_003CCheckBox_Unchecked_003Ed__8 stateMachine = default(_003CCheckBox_Unchecked_003Ed__8);
		stateMachine._003C_003Et__builder = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void vCQvQatkUf(object P_0, RoutedEventArgs P_1)
	{
		YQ4csVD2gHt33yWHvSL.D35lls5iF(text, Visibility.Collapsed, YQ4csVD2gHt33yWHvSL.xX51WbqrR2);
	}

	private void tsbvnhKJe2(object P_0, RoutedEventArgs P_1)
	{
		qni3xrDkAJ3vF35eMav.D35lls5iF(newtext, wq2usy8gNndpuTw5mR.D35lls5iF(npGv5FWbvi, wq2usy8gNndpuTw5mR.DeS80Xd2d6), qni3xrDkAJ3vF35eMav.nVo1urWcMH);
		YQ4csVD2gHt33yWHvSL.D35lls5iF(text, Visibility.Visible, YQ4csVD2gHt33yWHvSL.xX51WbqrR2);
		hjMnupQVVDlRZAYQJC.D35lls5iF(newtext, hjMnupQVVDlRZAYQJC.r6u8rCJ5Gy);
	}

	[AsyncStateMachine(typeof(_003CButton_Click_5_003Ed__11))]
	private void Rr9vbsGsE5(object P_0, RoutedEventArgs P_1)
	{
		_003CButton_Click_5_003Ed__11 stateMachine = default(_003CButton_Click_5_003Ed__11);
		stateMachine._003C_003Et__builder = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "5.0.4.0")]
	public void InitializeComponent()
	{
		if (!jgnvAi6Ok9)
		{
			jgnvAi6Ok9 = true;
			Uri uri = new Uri(iFZ5je3XFYKwkvcE5D.D35lls5iF(3068, iFZ5je3XFYKwkvcE5D.N06TeK0ao), UriKind.Relative);
			TUdx26d4l5VwJTvopv.D35lls5iF(this, uri, TUdx26d4l5VwJTvopv.W3oUN4AKb);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "5.0.4.0")]
	internal Delegate x69v7VT6Lk(Type P_0, string P_1)
	{
		return E6A9Xm2C8YsY6OX49j.D35lls5iF(P_0, this, P_1, E6A9Xm2C8YsY6OX49j.lecZDyFnW);
	}

	[GeneratedCode("PresentationBuildTasks", "5.0.4.0")]
	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		case 1:
			PositionSlider = (Slider)target;
			break;
		case 2:
			ControlsPanel = (Grid)target;
			break;
		case 3:
			LeftControls = (DockPanel)target;
			break;
		case 4:
			SoundMenuButton_Click = (Button)target;
			dp97HSDjYOMxMALpn4D.D35lls5iF(SoundMenuButton_Click, COLvKWKEY3, dp97HSDjYOMxMALpn4D.boI1UheDEc);
			break;
		case 5:
			MuteUnmuteButton = (ToggleButton)target;
			break;
		case 6:
			RightControls = (DockPanel)target;
			break;
		case 7:
			dp97HSDjYOMxMALpn4D.D35lls5iF((Button)target, LKIvkYZlhS, dp97HSDjYOMxMALpn4D.boI1UheDEc);
			break;
		case 8:
			CenterControls = (DockPanel)target;
			break;
		case 9:
			editbutton = (Button)target;
			dp97HSDjYOMxMALpn4D.D35lls5iF(editbutton, tsbvnhKJe2, dp97HSDjYOMxMALpn4D.boI1UheDEc);
			break;
		case 10:
			removebutton = (Button)target;
			break;
		case 11:
			list = (ListBox)target;
			break;
		case 12:
			playlist = (Grid)target;
			break;
		case 13:
			NewPlaylistName = (TextBox)target;
			break;
		case 14:
			text = (Grid)target;
			break;
		case 15:
			newtext = (TextBox)target;
			break;
		case 16:
			dp97HSDjYOMxMALpn4D.D35lls5iF((Button)target, Rr9vbsGsE5, dp97HSDjYOMxMALpn4D.boI1UheDEc);
			break;
		case 17:
			dp97HSDjYOMxMALpn4D.D35lls5iF((Button)target, vCQvQatkUf, dp97HSDjYOMxMALpn4D.boI1UheDEc);
			break;
		default:
			jgnvAi6Ok9 = true;
			break;
		}
	}
}
