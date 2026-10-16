using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using PROTV.Abstractions.Common;
using PROTV.Abstractions.DataTransferObjects;
using PROTV.Abstractions.Services;
using PROTV.Wpf.Bootstrap;
using PROTV.Wpf.Helpers;

namespace PROTV.Wpf.ViewModels;

public class YtVideoPlayerViewModel : FFMEBaseViewModel<YTVideoResponseDto>
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnDisLikeCommandExcute_003Ed__22 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public YtVideoPlayerViewModel _003C_003E4__this;

		private TaskAwaiter<int?> _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			YtVideoPlayerViewModel ytVideoPlayerViewModel = _003C_003E4__this;
			try
			{
				TaskAwaiter<int?> awaiter;
				switch (num)
				{
				default:
					if (zm1PNqdAIM7CQPxuoML.D35lls5iF(ytVideoPlayerViewModel.PlayerPlaylistViewModel.SelectedItem, zm1PNqdAIM7CQPxuoML.h3rd6c4fxg).HasValue && zm1PNqdAIM7CQPxuoML.D35lls5iF(ytVideoPlayerViewModel.PlayerPlaylistViewModel.SelectedItem, zm1PNqdAIM7CQPxuoML.h3rd6c4fxg).Value)
					{
						awaiter = aGuh8edpsif8FT1xsFb.D35lls5iF(ytVideoPlayerViewModel.QUeVLXPJEd, m9MGZR7k2RmVqYXYS5.D35lls5iF(ytVideoPlayerViewModel.PlayerPlaylistViewModel.SelectedItem, m9MGZR7k2RmVqYXYS5.r6tnXN0WTV), -1, aGuh8edpsif8FT1xsFb.PeTdwg3gdP).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (_003C_003E1__state = 0);
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_00e2;
					}
					if (zm1PNqdAIM7CQPxuoML.D35lls5iF(ytVideoPlayerViewModel.PlayerPlaylistViewModel.SelectedItem, zm1PNqdAIM7CQPxuoML.h3rd6c4fxg).HasValue)
					{
						awaiter = aGuh8edpsif8FT1xsFb.D35lls5iF(ytVideoPlayerViewModel.QUeVLXPJEd, m9MGZR7k2RmVqYXYS5.D35lls5iF(ytVideoPlayerViewModel.PlayerPlaylistViewModel.SelectedItem, m9MGZR7k2RmVqYXYS5.r6tnXN0WTV), 0, aGuh8edpsif8FT1xsFb.PeTdwg3gdP).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (_003C_003E1__state = 1);
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_01a3;
					}
					awaiter = aGuh8edpsif8FT1xsFb.D35lls5iF(ytVideoPlayerViewModel.QUeVLXPJEd, m9MGZR7k2RmVqYXYS5.D35lls5iF(ytVideoPlayerViewModel.PlayerPlaylistViewModel.SelectedItem, m9MGZR7k2RmVqYXYS5.r6tnXN0WTV), -1, aGuh8edpsif8FT1xsFb.PeTdwg3gdP).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_003C_003E1__state = 2);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_0245;
				case 0:
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<int?>);
					num = (_003C_003E1__state = -1);
					goto IL_00e2;
				case 1:
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<int?>);
					num = (_003C_003E1__state = -1);
					goto IL_01a3;
				case 2:
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter<int?>);
						num = (_003C_003E1__state = -1);
						goto IL_0245;
					}
					IL_00e2:
					awaiter.GetResult();
					vDQO3v1hqDY2TXHP9L4.D35lls5iF(ytVideoPlayerViewModel.PlayerPlaylistViewModel.SelectedItem, false, vDQO3v1hqDY2TXHP9L4.u9XdCAIynv);
					break;
					IL_01a3:
					awaiter.GetResult();
					vDQO3v1hqDY2TXHP9L4.D35lls5iF(ytVideoPlayerViewModel.PlayerPlaylistViewModel.SelectedItem, null, vDQO3v1hqDY2TXHP9L4.u9XdCAIynv);
					break;
					IL_0245:
					awaiter.GetResult();
					vDQO3v1hqDY2TXHP9L4.D35lls5iF(ytVideoPlayerViewModel.PlayerPlaylistViewModel.SelectedItem, false, vDQO3v1hqDY2TXHP9L4.u9XdCAIynv);
					break;
				}
				m5sZxWmLHUhVHrJe8sC.D35lls5iF(ytVideoPlayerViewModel.PlayerPlaylistViewModel.SelectedItem, iFZ5je3XFYKwkvcE5D.D35lls5iF(8340, iFZ5je3XFYKwkvcE5D.N06TeK0ao), m5sZxWmLHUhVHrJe8sC.d7tdmFAOdw);
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
	private struct _003COnLikeCommandExcute_003Ed__23 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public YtVideoPlayerViewModel _003C_003E4__this;

		private TaskAwaiter<int?> _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			YtVideoPlayerViewModel ytVideoPlayerViewModel = _003C_003E4__this;
			try
			{
				TaskAwaiter<int?> awaiter;
				switch (num)
				{
				default:
					if (zm1PNqdAIM7CQPxuoML.D35lls5iF(ytVideoPlayerViewModel.PlayerPlaylistViewModel.SelectedItem, zm1PNqdAIM7CQPxuoML.h3rd6c4fxg).HasValue && zm1PNqdAIM7CQPxuoML.D35lls5iF(ytVideoPlayerViewModel.PlayerPlaylistViewModel.SelectedItem, zm1PNqdAIM7CQPxuoML.h3rd6c4fxg).Value)
					{
						awaiter = aGuh8edpsif8FT1xsFb.D35lls5iF(ytVideoPlayerViewModel.QUeVLXPJEd, m9MGZR7k2RmVqYXYS5.D35lls5iF(ytVideoPlayerViewModel.PlayerPlaylistViewModel.SelectedItem, m9MGZR7k2RmVqYXYS5.r6tnXN0WTV), 0, aGuh8edpsif8FT1xsFb.PeTdwg3gdP).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (_003C_003E1__state = 0);
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_00e2;
					}
					if (zm1PNqdAIM7CQPxuoML.D35lls5iF(ytVideoPlayerViewModel.PlayerPlaylistViewModel.SelectedItem, zm1PNqdAIM7CQPxuoML.h3rd6c4fxg).HasValue)
					{
						awaiter = aGuh8edpsif8FT1xsFb.D35lls5iF(ytVideoPlayerViewModel.QUeVLXPJEd, m9MGZR7k2RmVqYXYS5.D35lls5iF(ytVideoPlayerViewModel.PlayerPlaylistViewModel.SelectedItem, m9MGZR7k2RmVqYXYS5.r6tnXN0WTV), 1, aGuh8edpsif8FT1xsFb.PeTdwg3gdP).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (_003C_003E1__state = 1);
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_01a6;
					}
					awaiter = aGuh8edpsif8FT1xsFb.D35lls5iF(ytVideoPlayerViewModel.QUeVLXPJEd, m9MGZR7k2RmVqYXYS5.D35lls5iF(ytVideoPlayerViewModel.PlayerPlaylistViewModel.SelectedItem, m9MGZR7k2RmVqYXYS5.r6tnXN0WTV), 1, aGuh8edpsif8FT1xsFb.PeTdwg3gdP).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_003C_003E1__state = 2);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_0245;
				case 0:
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<int?>);
					num = (_003C_003E1__state = -1);
					goto IL_00e2;
				case 1:
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<int?>);
					num = (_003C_003E1__state = -1);
					goto IL_01a6;
				case 2:
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter<int?>);
						num = (_003C_003E1__state = -1);
						goto IL_0245;
					}
					IL_00e2:
					awaiter.GetResult();
					vDQO3v1hqDY2TXHP9L4.D35lls5iF(ytVideoPlayerViewModel.PlayerPlaylistViewModel.SelectedItem, null, vDQO3v1hqDY2TXHP9L4.u9XdCAIynv);
					break;
					IL_01a6:
					awaiter.GetResult();
					vDQO3v1hqDY2TXHP9L4.D35lls5iF(ytVideoPlayerViewModel.PlayerPlaylistViewModel.SelectedItem, true, vDQO3v1hqDY2TXHP9L4.u9XdCAIynv);
					break;
					IL_0245:
					awaiter.GetResult();
					vDQO3v1hqDY2TXHP9L4.D35lls5iF(ytVideoPlayerViewModel.PlayerPlaylistViewModel.SelectedItem, true, vDQO3v1hqDY2TXHP9L4.u9XdCAIynv);
					break;
				}
				m5sZxWmLHUhVHrJe8sC.D35lls5iF(ytVideoPlayerViewModel.PlayerPlaylistViewModel.SelectedItem, iFZ5je3XFYKwkvcE5D.D35lls5iF(8340, iFZ5je3XFYKwkvcE5D.N06TeK0ao), m5sZxWmLHUhVHrJe8sC.d7tdmFAOdw);
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
	private struct _003CLoadAsync_003Ed__24 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public YtVideoPlayerViewModel _003C_003E4__this;

		public YTVideoResponseDto value;

		private void MoveNext()
		{
			YtVideoPlayerViewModel ytVideoPlayerViewModel = _003C_003E4__this;
			try
			{
				try
				{
					VC3XekdaC3rWFueGAhC.D35lls5iF(ytVideoPlayerViewModel, value, VC3XekdaC3rWFueGAhC.MUJdIngVFg);
					ytVideoPlayerViewModel.PlayerPlaylistViewModel.SelectedItem = value;
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
	private struct _003COnLoading_003Ed__25 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public YtVideoPlayerViewModel _003C_003E4__this;

		private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<bool> _003C_003Eu__2;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			YtVideoPlayerViewModel ytVideoPlayerViewModel = _003C_003E4__this;
			try
			{
				_ = 1;
				try
				{
					TaskAwaiter<bool> awaiter;
					ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter awaiter2;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = _003C_003Eu__2;
							_003C_003Eu__2 = default(TaskAwaiter<bool>);
							num = (_003C_003E1__state = -1);
							goto IL_0157;
						}
						string uriString = pnvE8rm9NRTK7Tblimu.D35lls5iF(new Uri(UwSEfC4rh9eVlFenwI.D35lls5iF(eVlRnEIaHT0dqvCx0Kx.D35lls5iF(a43SdLdd33nIFQF9vuC.D35lls5iF(ytVideoPlayerViewModel, a43SdLdd33nIFQF9vuC.X50dUJZNax), eVlRnEIaHT0dqvCx0Kx.JpMdtctq6o), eVlRnEIaHT0dqvCx0Kx.D35lls5iF(a43SdLdd33nIFQF9vuC.D35lls5iF(ytVideoPlayerViewModel, a43SdLdd33nIFQF9vuC.X50dUJZNax), eVlRnEIaHT0dqvCx0Kx.SgIdVItmwr), UwSEfC4rh9eVlFenwI.J6G3NC9nSO)), pnvE8rm9NRTK7Tblimu.fnLajxXY1u);
						awaiter2 = mchHD5pbvoLh6YJmlai.D35lls5iF(ytVideoPlayerViewModel.MediaElement, new Uri(uriString), mchHD5pbvoLh6YJmlai.ahJpW0oay7).GetAwaiter();
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
						_003C_003Eu__1 = default(ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter);
						num = (_003C_003E1__state = -1);
					}
					awaiter2.GetResult();
					awaiter = VbmtIFmnFwg9sqb4Jje.D35lls5iF(ytVideoPlayerViewModel.QUeVLXPJEd, m9MGZR7k2RmVqYXYS5.D35lls5iF(a43SdLdd33nIFQF9vuC.D35lls5iF(ytVideoPlayerViewModel, a43SdLdd33nIFQF9vuC.X50dUJZNax), m9MGZR7k2RmVqYXYS5.r6tnXN0WTV), VbmtIFmnFwg9sqb4Jje.h6bd7fwU7k).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_003C_003E1__state = 1);
						_003C_003Eu__2 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_0157;
					IL_0157:
					awaiter.GetResult();
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
	private struct _003COnOpenCommandExcuteAsync_003Ed__26 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public YTVideoResponseDto obj;

		public YtVideoPlayerViewModel _003C_003E4__this;

		private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<bool> _003C_003Eu__2;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			YtVideoPlayerViewModel ytVideoPlayerViewModel = _003C_003E4__this;
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
						goto IL_00d7;
					}
					TaskAwaiter<bool> awaiter2;
					if (num == 1)
					{
						awaiter2 = _003C_003Eu__2;
						_003C_003Eu__2 = default(TaskAwaiter<bool>);
						num = (_003C_003E1__state = -1);
						goto IL_0153;
					}
					string uriString = pnvE8rm9NRTK7Tblimu.D35lls5iF(new Uri(UwSEfC4rh9eVlFenwI.D35lls5iF(eVlRnEIaHT0dqvCx0Kx.D35lls5iF(obj, eVlRnEIaHT0dqvCx0Kx.JpMdtctq6o), eVlRnEIaHT0dqvCx0Kx.D35lls5iF(obj, eVlRnEIaHT0dqvCx0Kx.SgIdVItmwr), UwSEfC4rh9eVlFenwI.J6G3NC9nSO)), pnvE8rm9NRTK7Tblimu.fnLajxXY1u);
					if (ytVideoPlayerViewModel.MediaElement != null)
					{
						awaiter = mchHD5pbvoLh6YJmlai.D35lls5iF(ytVideoPlayerViewModel.MediaElement, new Uri(uriString), mchHD5pbvoLh6YJmlai.ahJpW0oay7).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (_003C_003E1__state = 0);
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_00d7;
					}
					goto end_IL_001a;
					IL_0153:
					awaiter2.GetResult();
					goto end_IL_001a;
					IL_00d7:
					awaiter.GetResult();
					awaiter2 = VbmtIFmnFwg9sqb4Jje.D35lls5iF(ytVideoPlayerViewModel.QUeVLXPJEd, m9MGZR7k2RmVqYXYS5.D35lls5iF(obj, m9MGZR7k2RmVqYXYS5.r6tnXN0WTV), VbmtIFmnFwg9sqb4Jje.h6bd7fwU7k).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						num = (_003C_003E1__state = 1);
						_003C_003Eu__2 = awaiter2;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
						return;
					}
					goto IL_0153;
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
	private struct _003CLoadAsync_003Ed__27 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public YtVideoPlayerViewModel _003C_003E4__this;

		public ObservableCollection<YTVideoResponseDto> lists;

		private void MoveNext()
		{
			YtVideoPlayerViewModel ytVideoPlayerViewModel = _003C_003E4__this;
			try
			{
				try
				{
					VC3XekdaC3rWFueGAhC.D35lls5iF(ytVideoPlayerViewModel, lists.FirstOrDefault(), VC3XekdaC3rWFueGAhC.MUJdIngVFg);
					ytVideoPlayerViewModel.PlayerPlaylistViewModel.SelectedItem = a43SdLdd33nIFQF9vuC.D35lls5iF(ytVideoPlayerViewModel, a43SdLdd33nIFQF9vuC.X50dUJZNax);
					ytVideoPlayerViewModel.PlayerPlaylistViewModel.Items = lists;
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

	private readonly IYoutubeService QUeVLXPJEd;

	private YTVideoResponseDto zGOV2orPbr;

	[CompilerGenerated]
	private MoviePalyerType rIPVzF59Cx;

	[CompilerGenerated]
	private RentResponseDto rbVacGQyJe;

	[CompilerGenerated]
	private ICommand sE8ajCr87Z;

	[CompilerGenerated]
	private ICommand ok6avWiAdZ;

	public YTVideoResponseDto YTVideo
	{
		get
		{
			return zGOV2orPbr;
		}
		set
		{
			SetProperty(ref zGOV2orPbr, value, iFZ5je3XFYKwkvcE5D.D35lls5iF(11712, iFZ5je3XFYKwkvcE5D.N06TeK0ao));
		}
	}

	public MoviePalyerType MoviePalyerType
	{
		[CompilerGenerated]
		get
		{
			return rIPVzF59Cx;
		}
		[CompilerGenerated]
		set
		{
			rIPVzF59Cx = value;
		}
	}

	public RentResponseDto MovieData
	{
		[CompilerGenerated]
		get
		{
			return rbVacGQyJe;
		}
		[CompilerGenerated]
		private set
		{
			rbVacGQyJe = value;
		}
	}

	public ICommand LikeCommand
	{
		[CompilerGenerated]
		get
		{
			return sE8ajCr87Z;
		}
		[CompilerGenerated]
		set
		{
			sE8ajCr87Z = value;
		}
	}

	public ICommand DisLikeCommand
	{
		[CompilerGenerated]
		get
		{
			return ok6avWiAdZ;
		}
		[CompilerGenerated]
		set
		{
			ok6avWiAdZ = value;
		}
	}

	public YtVideoPlayerViewModel()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector();
		QUeVLXPJEd = AppContainer.Resolve<IYoutubeService>();
		base.PlayerPlaylistViewModel = new PlayerPlaylistViewModel<YTVideoResponseDto>(this);
		base.Controller = new ControllerViewModel<YTVideoResponseDto>(this)
		{
			SeekBarVisibility = Visibility.Collapsed,
			PostionProgressVisibility = Visibility.Collapsed
		};
		KFPqfXEA4bOmtrXTkLA.D35lls5iF(this, new DelegateCommand(delegate
		{
			EcRAvP4y5i6535dlslT.D35lls5iF(this, EcRAvP4y5i6535dlslT.BbOBt8dfJ0);
		}), KFPqfXEA4bOmtrXTkLA.dvNBdfu6vu);
		KFPqfXEA4bOmtrXTkLA.D35lls5iF(this, new DelegateCommand(delegate
		{
			EcRAvP4y5i6535dlslT.D35lls5iF(this, EcRAvP4y5i6535dlslT.MAOBVBQS2M);
		}), KFPqfXEA4bOmtrXTkLA.uCdBU9KqJZ);
	}

	[AsyncStateMachine(typeof(_003COnDisLikeCommandExcute_003Ed__22))]
	private void LjbV1HZBcC()
	{
		_003COnDisLikeCommandExcute_003Ed__22 stateMachine = default(_003COnDisLikeCommandExcute_003Ed__22);
		stateMachine._003C_003Et__builder = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003COnLikeCommandExcute_003Ed__23))]
	private void o0iVJnVaR2()
	{
		_003COnLikeCommandExcute_003Ed__23 stateMachine = default(_003COnLikeCommandExcute_003Ed__23);
		stateMachine._003C_003Et__builder = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003CLoadAsync_003Ed__24))]
	public Task LoadAsync(YTVideoResponseDto value)
	{
		_003CLoadAsync_003Ed__24 stateMachine = default(_003CLoadAsync_003Ed__24);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine.value = value;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	[AsyncStateMachine(typeof(_003COnLoading_003Ed__25))]
	public override void OnLoading()
	{
		_003COnLoading_003Ed__25 stateMachine = default(_003COnLoading_003Ed__25);
		stateMachine._003C_003Et__builder = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003COnOpenCommandExcuteAsync_003Ed__26))]
	public override void OnOpenCommandExcuteAsync(YTVideoResponseDto obj)
	{
		_003COnOpenCommandExcuteAsync_003Ed__26 stateMachine = default(_003COnOpenCommandExcuteAsync_003Ed__26);
		stateMachine._003C_003Et__builder = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
		stateMachine._003C_003E4__this = this;
		stateMachine.obj = obj;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003CLoadAsync_003Ed__27))]
	public Task LoadAsync(ObservableCollection<YTVideoResponseDto> lists)
	{
		_003CLoadAsync_003Ed__27 stateMachine = default(_003CLoadAsync_003Ed__27);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine.lists = lists;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	[CompilerGenerated]
	private void zByVhvxcDe(object P_0)
	{
		EcRAvP4y5i6535dlslT.D35lls5iF(this, EcRAvP4y5i6535dlslT.BbOBt8dfJ0);
	}

	[CompilerGenerated]
	private void boTVlTD7cg(object P_0)
	{
		EcRAvP4y5i6535dlslT.D35lls5iF(this, EcRAvP4y5i6535dlslT.MAOBVBQS2M);
	}
}
