using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Animation;
using PROTV.Abstractions.Common;

namespace PROTV.Wpf.Helpers;

public static class FrameworkElementAnimationExtension
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSlideAndFadeInAsync_003Ed__0 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public AnimationSlideIndirection direction;

		public float seconds;

		public int size;

		public FrameworkElement element;

		public bool keepMargin;

		public bool firstLoad;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					Storyboard storyboard = new Storyboard();
					switch (direction)
					{
					case AnimationSlideIndirection.Left:
						sx9jcf0Y1lAXYcpYk79.D35lls5iF(storyboard, seconds, (size == 0) ? bATk1clKMSyO8g9EVbN.D35lls5iF(element, bATk1clKMSyO8g9EVbN.LZ5naZ8G19) : ((double)size), 1f, keepMargin, false, sx9jcf0Y1lAXYcpYk79.wol0ghbuc0);
						break;
					case AnimationSlideIndirection.Right:
						sx9jcf0Y1lAXYcpYk79.D35lls5iF(storyboard, seconds, (size == 0) ? bATk1clKMSyO8g9EVbN.D35lls5iF(element, bATk1clKMSyO8g9EVbN.LZ5naZ8G19) : ((double)size), 1f, keepMargin, false, sx9jcf0Y1lAXYcpYk79.pGm0i9hCe8);
						break;
					case AnimationSlideIndirection.Top:
						sJZ0V80QK3DS9yN8icy.D35lls5iF(storyboard, seconds, (size == 0) ? bATk1clKMSyO8g9EVbN.D35lls5iF(element, bATk1clKMSyO8g9EVbN.jUBnILD6KS) : ((double)size), 1f, keepMargin, sJZ0V80QK3DS9yN8icy.h6P0XGEHXG);
						break;
					case AnimationSlideIndirection.Bottom:
						sJZ0V80QK3DS9yN8icy.D35lls5iF(storyboard, seconds, (size == 0) ? bATk1clKMSyO8g9EVbN.D35lls5iF(element, bATk1clKMSyO8g9EVbN.jUBnILD6KS) : ((double)size), 1f, keepMargin, sJZ0V80QK3DS9yN8icy.CaD0feJd7N);
						break;
					}
					kyr0fE0hTCyylrkpq9Z.D35lls5iF(storyboard, seconds, false, false, kyr0fE0hTCyylrkpq9Z.WnZ0xvBHIc);
					aeQ4vq0P83DRDfY02Le.D35lls5iF(storyboard, element, aeQ4vq0P83DRDfY02Le.mKA0sMDqHl);
					if ((seconds != 0f) | firstLoad)
					{
						YQ4csVD2gHt33yWHvSL.D35lls5iF(element, Visibility.Visible, YQ4csVD2gHt33yWHvSL.xX51WbqrR2);
					}
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(pvrKKy8Mk1kpdmIfp3A.D35lls5iF((int)(seconds * 1000f), pvrKKy8Mk1kpdmIfp3A.aVh8SPrFkE), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
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

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSlideAndFadeOutAsync_003Ed__1 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public AnimationSlideIndirection direction;

		public float seconds;

		public int size;

		public FrameworkElement element;

		public bool keepMargin;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					Storyboard storyboard = new Storyboard();
					switch (direction)
					{
					case AnimationSlideIndirection.Left:
						sx9jcf0Y1lAXYcpYk79.D35lls5iF(storyboard, seconds, (size == 0) ? bATk1clKMSyO8g9EVbN.D35lls5iF(element, bATk1clKMSyO8g9EVbN.LZ5naZ8G19) : ((double)size), 1f, keepMargin, false, sx9jcf0Y1lAXYcpYk79.XPp0FZKTsZ);
						break;
					case AnimationSlideIndirection.Right:
						sx9jcf0Y1lAXYcpYk79.D35lls5iF(storyboard, seconds, (size == 0) ? bATk1clKMSyO8g9EVbN.D35lls5iF(element, bATk1clKMSyO8g9EVbN.LZ5naZ8G19) : ((double)size), 1f, keepMargin, false, sx9jcf0Y1lAXYcpYk79.A7002vSnyF);
						break;
					case AnimationSlideIndirection.Top:
						sJZ0V80QK3DS9yN8icy.D35lls5iF(storyboard, seconds, (size == 0) ? bATk1clKMSyO8g9EVbN.D35lls5iF(element, bATk1clKMSyO8g9EVbN.jUBnILD6KS) : ((double)size), 1f, keepMargin, sJZ0V80QK3DS9yN8icy.Yga0ZGGsfS);
						break;
					case AnimationSlideIndirection.Bottom:
						sJZ0V80QK3DS9yN8icy.D35lls5iF(storyboard, seconds, (size == 0) ? bATk1clKMSyO8g9EVbN.D35lls5iF(element, bATk1clKMSyO8g9EVbN.jUBnILD6KS) : ((double)size), 1f, keepMargin, sJZ0V80QK3DS9yN8icy.VBr0jK2CGf);
						break;
					}
					UEsjE50OZWbxvA0hany.D35lls5iF(storyboard, seconds, false, UEsjE50OZWbxvA0hany.Ny50u8jYik);
					aeQ4vq0P83DRDfY02Le.D35lls5iF(storyboard, element, aeQ4vq0P83DRDfY02Le.mKA0sMDqHl);
					if (seconds != 0f)
					{
						YQ4csVD2gHt33yWHvSL.D35lls5iF(element, Visibility.Visible, YQ4csVD2gHt33yWHvSL.xX51WbqrR2);
					}
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(pvrKKy8Mk1kpdmIfp3A.D35lls5iF((int)(seconds * 1000f), pvrKKy8Mk1kpdmIfp3A.aVh8SPrFkE), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
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
				if (bATk1clKMSyO8g9EVbN.D35lls5iF(element, bATk1clKMSyO8g9EVbN.PH9lNJgLuW) == 0.0)
				{
					YQ4csVD2gHt33yWHvSL.D35lls5iF(element, Visibility.Collapsed, YQ4csVD2gHt33yWHvSL.xX51WbqrR2);
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
	private struct _003CFadeOutAsync_003Ed__2 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public float seconds;

		public FrameworkElement element;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					Storyboard storyboard = new Storyboard();
					UEsjE50OZWbxvA0hany.D35lls5iF(storyboard, seconds, false, UEsjE50OZWbxvA0hany.Ny50u8jYik);
					aeQ4vq0P83DRDfY02Le.D35lls5iF(storyboard, element, aeQ4vq0P83DRDfY02Le.mKA0sMDqHl);
					if (seconds != 0f)
					{
						YQ4csVD2gHt33yWHvSL.D35lls5iF(element, Visibility.Visible, YQ4csVD2gHt33yWHvSL.xX51WbqrR2);
					}
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(pvrKKy8Mk1kpdmIfp3A.D35lls5iF((int)(seconds * 1000f), pvrKKy8Mk1kpdmIfp3A.aVh8SPrFkE), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
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
				YQ4csVD2gHt33yWHvSL.D35lls5iF(element, Visibility.Collapsed, YQ4csVD2gHt33yWHvSL.xX51WbqrR2);
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
	private struct _003CFadeInAsync_003Ed__3 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public float seconds;

		public FrameworkElement element;

		public bool firstLoad;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					Storyboard storyboard = new Storyboard();
					kyr0fE0hTCyylrkpq9Z.D35lls5iF(storyboard, seconds, true, false, kyr0fE0hTCyylrkpq9Z.WnZ0xvBHIc);
					aeQ4vq0P83DRDfY02Le.D35lls5iF(storyboard, element, aeQ4vq0P83DRDfY02Le.mKA0sMDqHl);
					if ((seconds != 0f) | firstLoad)
					{
						YQ4csVD2gHt33yWHvSL.D35lls5iF(element, Visibility.Visible, YQ4csVD2gHt33yWHvSL.xX51WbqrR2);
					}
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(pvrKKy8Mk1kpdmIfp3A.D35lls5iF((int)(seconds * 1000f), pvrKKy8Mk1kpdmIfp3A.aVh8SPrFkE), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
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

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CResizeMenuToMaxAsync_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public float seconds;

		public FrameworkElement element;

		public double size;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					Storyboard storyboard = new Storyboard();
					buMMEVt00PQJ5WCtwxP.D35lls5iF(storyboard, seconds, bATk1clKMSyO8g9EVbN.D35lls5iF(element, bATk1clKMSyO8g9EVbN.Ylg6bMXAm1), size, buMMEVt00PQJ5WCtwxP.V5btrqoykL);
					aeQ4vq0P83DRDfY02Le.D35lls5iF(storyboard, element, aeQ4vq0P83DRDfY02Le.mKA0sMDqHl);
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(pvrKKy8Mk1kpdmIfp3A.D35lls5iF((int)(seconds * 1000f), pvrKKy8Mk1kpdmIfp3A.aVh8SPrFkE), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
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

	[AsyncStateMachine(typeof(_003CSlideAndFadeInAsync_003Ed__0))]
	public static Task SlideAndFadeInAsync(this FrameworkElement element, AnimationSlideIndirection direction, bool firstLoad, float seconds = 0.3f, bool keepMargin = true, int size = 0)
	{
		_003CSlideAndFadeInAsync_003Ed__0 stateMachine = default(_003CSlideAndFadeInAsync_003Ed__0);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine.element = element;
		stateMachine.direction = direction;
		stateMachine.firstLoad = firstLoad;
		stateMachine.seconds = seconds;
		stateMachine.keepMargin = keepMargin;
		stateMachine.size = size;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	[AsyncStateMachine(typeof(_003CSlideAndFadeOutAsync_003Ed__1))]
	public static Task SlideAndFadeOutAsync(this FrameworkElement element, AnimationSlideIndirection direction, float seconds = 0.3f, bool keepMargin = true, int size = 0)
	{
		_003CSlideAndFadeOutAsync_003Ed__1 stateMachine = default(_003CSlideAndFadeOutAsync_003Ed__1);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine.element = element;
		stateMachine.direction = direction;
		stateMachine.seconds = seconds;
		stateMachine.keepMargin = keepMargin;
		stateMachine.size = size;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	[AsyncStateMachine(typeof(_003CFadeOutAsync_003Ed__2))]
	public static Task FadeOutAsync(this FrameworkElement element, float seconds = 0.3f, bool keepMargin = true)
	{
		_003CFadeOutAsync_003Ed__2 stateMachine = default(_003CFadeOutAsync_003Ed__2);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine.element = element;
		stateMachine.seconds = seconds;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	[AsyncStateMachine(typeof(_003CFadeInAsync_003Ed__3))]
	public static Task FadeInAsync(this FrameworkElement element, bool firstLoad, float seconds = 0.3f, bool keepMargin = true)
	{
		_003CFadeInAsync_003Ed__3 stateMachine = default(_003CFadeInAsync_003Ed__3);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine.element = element;
		stateMachine.firstLoad = firstLoad;
		stateMachine.seconds = seconds;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	public static void FadeOut(this FrameworkElement element, float seconds = 0.3f)
	{
		Storyboard storyboard = new Storyboard();
		UEsjE50OZWbxvA0hany.D35lls5iF(storyboard, seconds, true, UEsjE50OZWbxvA0hany.Ny50u8jYik);
		aeQ4vq0P83DRDfY02Le.D35lls5iF(storyboard, element, aeQ4vq0P83DRDfY02Le.mKA0sMDqHl);
		if (seconds != 0f)
		{
			YQ4csVD2gHt33yWHvSL.D35lls5iF(element, Visibility.Visible, YQ4csVD2gHt33yWHvSL.xX51WbqrR2);
		}
	}

	public static void FadeIn(this FrameworkElement element, float seconds = 0.3f)
	{
		Storyboard storyboard = new Storyboard();
		kyr0fE0hTCyylrkpq9Z.D35lls5iF(storyboard, seconds, true, true, kyr0fE0hTCyylrkpq9Z.WnZ0xvBHIc);
		aeQ4vq0P83DRDfY02Le.D35lls5iF(storyboard, element, aeQ4vq0P83DRDfY02Le.mKA0sMDqHl);
	}

	public static void SlideAndFadeIn(this FrameworkElement element, AnimationSlideIndirection direction, bool firstLoad, float seconds = 0.3f, bool keepMargin = true, int size = 0, bool fadein = true)
	{
		Storyboard storyboard = new Storyboard();
		switch (direction)
		{
		case AnimationSlideIndirection.Left:
			sx9jcf0Y1lAXYcpYk79.D35lls5iF(storyboard, seconds, (size == 0) ? bATk1clKMSyO8g9EVbN.D35lls5iF(element, bATk1clKMSyO8g9EVbN.LZ5naZ8G19) : ((double)size), 1f, keepMargin, true, sx9jcf0Y1lAXYcpYk79.wol0ghbuc0);
			break;
		case AnimationSlideIndirection.Right:
			sx9jcf0Y1lAXYcpYk79.D35lls5iF(storyboard, seconds, (size == 0) ? bATk1clKMSyO8g9EVbN.D35lls5iF(element, bATk1clKMSyO8g9EVbN.LZ5naZ8G19) : ((double)size), 1f, keepMargin, true, sx9jcf0Y1lAXYcpYk79.pGm0i9hCe8);
			break;
		case AnimationSlideIndirection.Top:
			sJZ0V80QK3DS9yN8icy.D35lls5iF(storyboard, seconds, (size == 0) ? bATk1clKMSyO8g9EVbN.D35lls5iF(element, bATk1clKMSyO8g9EVbN.jUBnILD6KS) : ((double)size), 1f, keepMargin, sJZ0V80QK3DS9yN8icy.h6P0XGEHXG);
			break;
		case AnimationSlideIndirection.Bottom:
			sJZ0V80QK3DS9yN8icy.D35lls5iF(storyboard, seconds, (size == 0) ? bATk1clKMSyO8g9EVbN.D35lls5iF(element, bATk1clKMSyO8g9EVbN.jUBnILD6KS) : ((double)size), 1f, keepMargin, sJZ0V80QK3DS9yN8icy.CaD0feJd7N);
			break;
		}
		if (fadein)
		{
			kyr0fE0hTCyylrkpq9Z.D35lls5iF(storyboard, seconds, false, true, kyr0fE0hTCyylrkpq9Z.WnZ0xvBHIc);
		}
		aeQ4vq0P83DRDfY02Le.D35lls5iF(storyboard, element, aeQ4vq0P83DRDfY02Le.mKA0sMDqHl);
		if ((seconds != 0f) | firstLoad)
		{
			YQ4csVD2gHt33yWHvSL.D35lls5iF(element, Visibility.Visible, YQ4csVD2gHt33yWHvSL.xX51WbqrR2);
		}
	}

	public static void SlideAndFadeOut(this FrameworkElement element, AnimationSlideIndirection direction, float seconds = 0.3f, bool keepMargin = true, int size = 0, bool fadeout = true)
	{
		Storyboard storyboard = new Storyboard();
		switch (direction)
		{
		case AnimationSlideIndirection.Left:
			sx9jcf0Y1lAXYcpYk79.D35lls5iF(storyboard, seconds, (size == 0) ? bATk1clKMSyO8g9EVbN.D35lls5iF(element, bATk1clKMSyO8g9EVbN.LZ5naZ8G19) : ((double)size), 1f, keepMargin, true, sx9jcf0Y1lAXYcpYk79.XPp0FZKTsZ);
			break;
		case AnimationSlideIndirection.Right:
			sx9jcf0Y1lAXYcpYk79.D35lls5iF(storyboard, seconds, (size == 0) ? bATk1clKMSyO8g9EVbN.D35lls5iF(element, bATk1clKMSyO8g9EVbN.LZ5naZ8G19) : ((double)size), 1f, keepMargin, true, sx9jcf0Y1lAXYcpYk79.A7002vSnyF);
			break;
		case AnimationSlideIndirection.Top:
			sJZ0V80QK3DS9yN8icy.D35lls5iF(storyboard, seconds, (size == 0) ? bATk1clKMSyO8g9EVbN.D35lls5iF(element, bATk1clKMSyO8g9EVbN.jUBnILD6KS) : ((double)size), 1f, keepMargin, sJZ0V80QK3DS9yN8icy.Yga0ZGGsfS);
			break;
		case AnimationSlideIndirection.Bottom:
			sJZ0V80QK3DS9yN8icy.D35lls5iF(storyboard, seconds, (size == 0) ? bATk1clKMSyO8g9EVbN.D35lls5iF(element, bATk1clKMSyO8g9EVbN.jUBnILD6KS) : ((double)size), 1f, keepMargin, sJZ0V80QK3DS9yN8icy.VBr0jK2CGf);
			break;
		}
		if (fadeout)
		{
			UEsjE50OZWbxvA0hany.D35lls5iF(storyboard, seconds, false, UEsjE50OZWbxvA0hany.Ny50u8jYik);
		}
		aeQ4vq0P83DRDfY02Le.D35lls5iF(storyboard, element, aeQ4vq0P83DRDfY02Le.mKA0sMDqHl);
		if (seconds != 0f)
		{
			YQ4csVD2gHt33yWHvSL.D35lls5iF(element, Visibility.Visible, YQ4csVD2gHt33yWHvSL.xX51WbqrR2);
		}
	}

	[AsyncStateMachine(typeof(_003CResizeMenuToMaxAsync_003Ed__8))]
	public static Task ResizeMenuToMaxAsync(this FrameworkElement element, float seconds = 0.4f, bool keepMargin = true, double size = 0.0)
	{
		_003CResizeMenuToMaxAsync_003Ed__8 stateMachine = default(_003CResizeMenuToMaxAsync_003Ed__8);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine.element = element;
		stateMachine.seconds = seconds;
		stateMachine.size = size;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}
}
