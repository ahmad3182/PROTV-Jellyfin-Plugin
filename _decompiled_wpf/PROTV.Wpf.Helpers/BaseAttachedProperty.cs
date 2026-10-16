using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;

namespace PROTV.Wpf.Helpers;

public abstract class BaseAttachedProperty<Parent, Property> where Parent : new()
{
	[CompilerGenerated]
	private Action<DependencyObject, DependencyPropertyChangedEventArgs> vEk0Lm4Fum;

	[CompilerGenerated]
	private Action<DependencyObject, object> gc302979jZ;

	[CompilerGenerated]
	private static Parent LvU0zpbiq6;

	public static readonly DependencyProperty ValueProperty;

	public static Parent Instance
	{
		[CompilerGenerated]
		get
		{
			return LvU0zpbiq6;
		}
		[CompilerGenerated]
		private set
		{
			LvU0zpbiq6 = value;
		}
	}

	public event Action<DependencyObject, DependencyPropertyChangedEventArgs> ValueChanged
	{
		[CompilerGenerated]
		add
		{
			Action<DependencyObject, DependencyPropertyChangedEventArgs> action = vEk0Lm4Fum;
			Action<DependencyObject, DependencyPropertyChangedEventArgs> action2;
			do
			{
				action2 = action;
				Action<DependencyObject, DependencyPropertyChangedEventArgs> value2 = (Action<DependencyObject, DependencyPropertyChangedEventArgs>)YN50h3TKBBEbtvEUKm0.D35lls5iF(action2, value, YN50h3TKBBEbtvEUKm0.UVSTNPSpmU);
				action = Interlocked.CompareExchange(ref vEk0Lm4Fum, value2, action2);
			}
			while ((object)action != action2);
		}
		[CompilerGenerated]
		remove
		{
			Action<DependencyObject, DependencyPropertyChangedEventArgs> action = vEk0Lm4Fum;
			Action<DependencyObject, DependencyPropertyChangedEventArgs> action2;
			do
			{
				action2 = action;
				Action<DependencyObject, DependencyPropertyChangedEventArgs> value2 = (Action<DependencyObject, DependencyPropertyChangedEventArgs>)YN50h3TKBBEbtvEUKm0.D35lls5iF(action2, value, YN50h3TKBBEbtvEUKm0.cNqTORCAOn);
				action = Interlocked.CompareExchange(ref vEk0Lm4Fum, value2, action2);
			}
			while ((object)action != action2);
		}
	}

	public event Action<DependencyObject, object> ValueUpdated
	{
		[CompilerGenerated]
		add
		{
			Action<DependencyObject, object> action = gc302979jZ;
			Action<DependencyObject, object> action2;
			do
			{
				action2 = action;
				Action<DependencyObject, object> value2 = (Action<DependencyObject, object>)YN50h3TKBBEbtvEUKm0.D35lls5iF(action2, value, YN50h3TKBBEbtvEUKm0.UVSTNPSpmU);
				action = Interlocked.CompareExchange(ref gc302979jZ, value2, action2);
			}
			while ((object)action != action2);
		}
		[CompilerGenerated]
		remove
		{
			Action<DependencyObject, object> action = gc302979jZ;
			Action<DependencyObject, object> action2;
			do
			{
				action2 = action;
				Action<DependencyObject, object> value2 = (Action<DependencyObject, object>)YN50h3TKBBEbtvEUKm0.D35lls5iF(action2, value, YN50h3TKBBEbtvEUKm0.cNqTORCAOn);
				action = Interlocked.CompareExchange(ref gc302979jZ, value2, action2);
			}
			while ((object)action != action2);
		}
	}

	private static void Jbq0hhnbNj(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		(Instance as BaseAttachedProperty<Parent, Property>)?.OnValueChanged(P_0, P_1);
		(Instance as BaseAttachedProperty<Parent, Property>)?.vEk0Lm4Fum(P_0, P_1);
	}

	private static object acU0loVT6f(DependencyObject P_0, object P_1)
	{
		(Instance as BaseAttachedProperty<Parent, Property>)?.OnValueUpdated(P_0, P_1);
		(Instance as BaseAttachedProperty<Parent, Property>)?.gc302979jZ(P_0, P_1);
		return P_1;
	}

	public static Property GetValue(DependencyObject d)
	{
		return (Property)EmqD3J86gxqLokWBlHc.D35lls5iF(d, ValueProperty, EmqD3J86gxqLokWBlHc.zno8ILg6BC);
	}

	public static void SetValue(DependencyObject d, Property value)
	{
		jsMkaY8wkGDPQeJiaWA.D35lls5iF(d, ValueProperty, value, jsMkaY8wkGDPQeJiaWA.ffyrmsSweV);
	}

	public virtual void OnValueChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
	{
	}

	public virtual void OnValueUpdated(DependencyObject sender, object value)
	{
	}

	protected BaseAttachedProperty()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		vEk0Lm4Fum = delegate
		{
		};
		gc302979jZ = delegate
		{
		};
		base._002Ector();
	}

	static BaseAttachedProperty()
	{
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0073: Expected O, but got Unknown
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		LvU0zpbiq6 = new Parent();
		ValueProperty = BrQfd88PXGwGWbvCv5M.D35lls5iF(iFZ5je3XFYKwkvcE5D.D35lls5iF(12764, iFZ5je3XFYKwkvcE5D.N06TeK0ao), sjYxHO8OWlc6X80hFj7.D35lls5iF(typeof(Property).TypeHandle, sjYxHO8OWlc6X80hFj7.uWZ8ugU7r5), sjYxHO8OWlc6X80hFj7.D35lls5iF(typeof(BaseAttachedProperty<Parent, Property>).TypeHandle, sjYxHO8OWlc6X80hFj7.uWZ8ugU7r5), (PropertyMetadata)(object)new UIPropertyMetadata(default(Property), new PropertyChangedCallback(Jbq0hhnbNj), new CoerceValueCallback(acU0loVT6f)), BrQfd88PXGwGWbvCv5M.oV7raoV9pQ);
	}
}
