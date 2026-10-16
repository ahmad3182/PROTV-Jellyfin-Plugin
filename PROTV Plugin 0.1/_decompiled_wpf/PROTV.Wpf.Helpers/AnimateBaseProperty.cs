using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;

namespace PROTV.Wpf.Helpers;

public abstract class AnimateBaseProperty<Parent> : BaseAttachedProperty<Parent, bool> where Parent : BaseAttachedProperty<Parent, bool>, new()
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass2_0
	{
		public DependencyObject sender;

		public FrameworkElement element;

		public KeyValuePair<WeakReference, bool> firstLoadReference;

		public AnimateBaseProperty<Parent> _003C_003E4__this;

		public object value;

		public Func<KeyValuePair<WeakReference, bool>, bool> _003C_003E9__3;

		public _003C_003Ec__DisplayClass2_0()
		{
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
			base._002Ector();
		}

		internal bool MCkKhNf7rH(KeyValuePair<WeakReference, bool> f)
		{
			return RAspAbuaTQFU0nSRiQ.D35lls5iF(f.Key, RAspAbuaTQFU0nSRiQ.FLntejAqTb) == sender;
		}

		internal bool RZZKl5FjjS(KeyValuePair<WeakReference, bool> f)
		{
			return RAspAbuaTQFU0nSRiQ.D35lls5iF(f.Key, RAspAbuaTQFU0nSRiQ.FLntejAqTb) == sender;
		}

		internal bool JqgKUS4bsQ(KeyValuePair<WeakReference, bool> f)
		{
			return RAspAbuaTQFU0nSRiQ.D35lls5iF(f.Key, RAspAbuaTQFU0nSRiQ.FLntejAqTb) == sender;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass2_1
	{
		[StructLayout(LayoutKind.Auto)]
		private struct Ch6xGAjGpd3e483GGsm : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public _003C_003Ec__DisplayClass2_1 _003C_003E4__this;

			private TaskAwaiter _003C_003Eu__1;

			private void MoveNext()
			{
				int num = _003C_003E1__state;
				_003C_003Ec__DisplayClass2_1 obj = _003C_003E4__this;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						dp97HSDjYOMxMALpn4D.D35lls5iF(obj.CS_0024_003C_003E8__locals1.element, obj.onLoaded, dp97HSDjYOMxMALpn4D.bI5rM9OU3O);
						awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(pvrKKy8Mk1kpdmIfp3A.D35lls5iF(5, pvrKKy8Mk1kpdmIfp3A.aVh8SPrFkE), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
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
					obj.CS_0024_003C_003E8__locals1.firstLoadReference = obj.CS_0024_003C_003E8__locals1._003C_003E4__this.mFirstLoadValue.FirstOrDefault((KeyValuePair<WeakReference, bool> f) => RAspAbuaTQFU0nSRiQ.D35lls5iF(f.Key, RAspAbuaTQFU0nSRiQ.FLntejAqTb) == obj.CS_0024_003C_003E8__locals1.sender);
					obj.CS_0024_003C_003E8__locals1._003C_003E4__this.DoAnimation(obj.CS_0024_003C_003E8__locals1.element, (obj.CS_0024_003C_003E8__locals1.firstLoadReference.Key != null) ? obj.CS_0024_003C_003E8__locals1.firstLoadReference.Value : ((bool)obj.CS_0024_003C_003E8__locals1.value), firstLoad: true);
					obj.CS_0024_003C_003E8__locals1._003C_003E4__this.mAlreadyLoaded[obj.weakReference] = true;
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
			private void SetStateMachine(IAsyncStateMachine P_0)
			{
				dHWo7jAEn6E4X7bsY4R.D35lls5iF(ref _003C_003Et__builder, P_0, dHWo7jAEn6E4X7bsY4R.z3hAB6UZ9o);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine P_0)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(P_0);
			}
		}

		public RoutedEventHandler onLoaded;

		public WeakReference weakReference;

		public _003C_003Ec__DisplayClass2_0 CS_0024_003C_003E8__locals1;

		public _003C_003Ec__DisplayClass2_1()
		{
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
			base._002Ector();
		}

		[AsyncStateMachine(typeof(AnimateBaseProperty<>._003C_003Ec__DisplayClass2_1.Ch6xGAjGpd3e483GGsm))]
		internal void GJbKLtuq89(object ss, RoutedEventArgs ee)
		{
			Ch6xGAjGpd3e483GGsm stateMachine = default(Ch6xGAjGpd3e483GGsm);
			stateMachine._003C_003Et__builder = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
			stateMachine._003C_003E4__this = this;
			stateMachine._003C_003E1__state = -1;
			stateMachine._003C_003Et__builder.Start(ref stateMachine);
		}
	}

	protected Dictionary<WeakReference, bool> mAlreadyLoaded;

	protected Dictionary<WeakReference, bool> mFirstLoadValue;

	public override void OnValueUpdated(DependencyObject sender, object value)
	{
		_003C_003Ec__DisplayClass2_0 CS_0024_003C_003E8__locals26 = new _003C_003Ec__DisplayClass2_0();
		CS_0024_003C_003E8__locals26.sender = sender;
		CS_0024_003C_003E8__locals26._003C_003E4__this = this;
		CS_0024_003C_003E8__locals26.value = value;
		if (!(CS_0024_003C_003E8__locals26.sender is FrameworkElement))
		{
			return;
		}
		CS_0024_003C_003E8__locals26.element = (FrameworkElement)(object)CS_0024_003C_003E8__locals26.sender;
		KeyValuePair<WeakReference, bool> keyValuePair = mAlreadyLoaded.FirstOrDefault((KeyValuePair<WeakReference, bool> f) => RAspAbuaTQFU0nSRiQ.D35lls5iF(f.Key, RAspAbuaTQFU0nSRiQ.FLntejAqTb) == CS_0024_003C_003E8__locals26.sender);
		CS_0024_003C_003E8__locals26.firstLoadReference = mFirstLoadValue.FirstOrDefault((KeyValuePair<WeakReference, bool> f) => RAspAbuaTQFU0nSRiQ.D35lls5iF(f.Key, RAspAbuaTQFU0nSRiQ.FLntejAqTb) == CS_0024_003C_003E8__locals26.sender);
		if ((bool)EmqD3J86gxqLokWBlHc.D35lls5iF(CS_0024_003C_003E8__locals26.sender, BaseAttachedProperty<Parent, bool>.ValueProperty, EmqD3J86gxqLokWBlHc.zno8ILg6BC) == (bool)CS_0024_003C_003E8__locals26.value && keyValuePair.Key != null)
		{
			return;
		}
		if (keyValuePair.Key == null)
		{
			_003C_003Ec__DisplayClass2_1 CS_0024_003C_003E8__locals27 = new _003C_003Ec__DisplayClass2_1();
			CS_0024_003C_003E8__locals27.CS_0024_003C_003E8__locals1 = CS_0024_003C_003E8__locals26;
			CS_0024_003C_003E8__locals27.weakReference = new WeakReference(CS_0024_003C_003E8__locals27.CS_0024_003C_003E8__locals1.sender);
			mAlreadyLoaded[CS_0024_003C_003E8__locals27.weakReference] = false;
			YQ4csVD2gHt33yWHvSL.D35lls5iF(CS_0024_003C_003E8__locals27.CS_0024_003C_003E8__locals1.element, Visibility.Hidden, YQ4csVD2gHt33yWHvSL.xX51WbqrR2);
			CS_0024_003C_003E8__locals27.onLoaded = null;
			CS_0024_003C_003E8__locals27.onLoaded = [AsyncStateMachine(typeof(AnimateBaseProperty<>._003C_003Ec__DisplayClass2_1.Ch6xGAjGpd3e483GGsm))] (object ss, RoutedEventArgs ee) =>
			{
				_003C_003Ec__DisplayClass2_1.Ch6xGAjGpd3e483GGsm stateMachine = default(_003C_003Ec__DisplayClass2_1.Ch6xGAjGpd3e483GGsm);
				stateMachine._003C_003Et__builder = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
				stateMachine._003C_003E4__this = CS_0024_003C_003E8__locals27;
				stateMachine._003C_003E1__state = -1;
				stateMachine._003C_003Et__builder.Start(ref stateMachine);
			};
			dp97HSDjYOMxMALpn4D.D35lls5iF(CS_0024_003C_003E8__locals27.CS_0024_003C_003E8__locals1.element, CS_0024_003C_003E8__locals27.onLoaded, dp97HSDjYOMxMALpn4D.gUprRPD5S8);
		}
		else if (!keyValuePair.Value)
		{
			mFirstLoadValue[new WeakReference(CS_0024_003C_003E8__locals26.sender)] = (bool)CS_0024_003C_003E8__locals26.value;
		}
		else
		{
			DoAnimation(CS_0024_003C_003E8__locals26.element, (bool)CS_0024_003C_003E8__locals26.value, firstLoad: false);
		}
	}

	protected virtual void DoAnimation(FrameworkElement element, bool value, bool firstLoad)
	{
	}

	protected AnimateBaseProperty()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		mAlreadyLoaded = new Dictionary<WeakReference, bool>();
		mFirstLoadValue = new Dictionary<WeakReference, bool>();
		base._002Ector();
	}
}
