using System;
using System.CodeDom.Compiler;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using HandyControl.Controls;
using PROTV.Wpf.ViewModels;

namespace PROTV.Wpf.Views;

public class EntertainmentCenterView : BasePage<EntertainmentCenterViewModel>, IComponentConnector, IStyleConnector
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CItems_CollectionChanged_003Ed__2 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public EntertainmentCenterView _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			EntertainmentCenterView entertainmentCenterView = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(pvrKKy8Mk1kpdmIfp3A.D35lls5iF(250, pvrKKy8Mk1kpdmIfp3A.aVh8SPrFkE), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
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
				Carousel carouselView = entertainmentCenterView.CarouselView;
				int num2 = WJbFtI6AObf2rNffLCy.D35lls5iF(carouselView, WJbFtI6AObf2rNffLCy.t77p8ZAHhg);
				vQKA0r9sJ1kArsIHc16.D35lls5iF(carouselView, num2 + 1, vQKA0r9sJ1kArsIHc16.uTUpnUacbr);
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

	internal EntertainmentCenterView EnterPage;

	internal System.Windows.Controls.ScrollViewer scroll;

	internal Carousel CarouselView;

	private bool Gd3jcB0LNx;

	public EntertainmentCenterView()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector();
		AJv70itXcdnxnNYjSQ.D35lls5iF(this, AJv70itXcdnxnNYjSQ.pJDDWJFWDm);
	}

	public EntertainmentCenterView(EntertainmentCenterViewModel specificViewModel)
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector(specificViewModel);
		AJv70itXcdnxnNYjSQ.D35lls5iF(this, AJv70itXcdnxnNYjSQ.pJDDWJFWDm);
		if (specificViewModel != null)
		{
			dq7UbsD57OHoHSoEhwE.D35lls5iF(specificViewModel, dq7UbsD57OHoHSoEhwE.uCFDzCuFlB).CollectionChanged += P4O2VQ7wp;
		}
		else
		{
			dq7UbsD57OHoHSoEhwE.D35lls5iF(base.ViewModel, dq7UbsD57OHoHSoEhwE.uCFDzCuFlB).CollectionChanged += P4O2VQ7wp;
		}
	}

	[AsyncStateMachine(typeof(_003CItems_CollectionChanged_003Ed__2))]
	private void P4O2VQ7wp(object P_0, NotifyCollectionChangedEventArgs P_1)
	{
		_003CItems_CollectionChanged_003Ed__2 stateMachine = default(_003CItems_CollectionChanged_003Ed__2);
		stateMachine._003C_003Et__builder = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void MAKzpk79M(object P_0, MouseWheelEventArgs P_1)
	{
		mAdJWQ9yhneCbEXlGMc.D35lls5iF(scroll, bATk1clKMSyO8g9EVbN.D35lls5iF(scroll, bATk1clKMSyO8g9EVbN.HMvHoGcjPR) - (double)m9MGZR7k2RmVqYXYS5.D35lls5iF(P_1, m9MGZR7k2RmVqYXYS5.BoXHlIwNQk), mAdJWQ9yhneCbEXlGMc.OCfH9YuRTt);
	}

	[GeneratedCode("PresentationBuildTasks", "5.0.4.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!Gd3jcB0LNx)
		{
			Gd3jcB0LNx = true;
			Uri uri = new Uri(iFZ5je3XFYKwkvcE5D.D35lls5iF(1188, iFZ5je3XFYKwkvcE5D.N06TeK0ao), UriKind.Relative);
			TUdx26d4l5VwJTvopv.D35lls5iF(this, uri, TUdx26d4l5VwJTvopv.W3oUN4AKb);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "5.0.4.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		case 1:
			EnterPage = (EntertainmentCenterView)target;
			break;
		case 2:
			scroll = (System.Windows.Controls.ScrollViewer)target;
			break;
		case 3:
			CarouselView = (Carousel)target;
			break;
		case 4:
			W73HvvHD4Ka6B2vKd4e.D35lls5iF((ListBox)target, MAKzpk79M, W73HvvHD4Ka6B2vKd4e.MIbHH5Gk3A);
			break;
		case 5:
			W73HvvHD4Ka6B2vKd4e.D35lls5iF((ListView)target, MAKzpk79M, W73HvvHD4Ka6B2vKd4e.MIbHH5Gk3A);
			break;
		default:
			Gd3jcB0LNx = true;
			break;
		}
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "5.0.4.0")]
	void IStyleConnector.Connect(int connectionId, object target)
	{
		if (connectionId == 6)
		{
			W73HvvHD4Ka6B2vKd4e.D35lls5iF((ListView)target, MAKzpk79M, W73HvvHD4Ka6B2vKd4e.MIbHH5Gk3A);
		}
	}
}
