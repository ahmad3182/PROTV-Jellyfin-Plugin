using System;
using System.Collections.Generic;
using System.Reflection;
using PROTV.Abstractions.Helpers;
using inRDv5hipvrdZJqu59;

namespace heinxS4ZmrAWGNhRqx;

internal static class IEMqEwEho8l1pnGjBP
{
	internal static void ruS3yl1PBN(in string eventName, in object? handlerTarget, in MethodInfo? methodInfo, in Dictionary<string, List<LgCvidKs5MLkylhA8F>> eventHandlers)
	{
		if (!eventHandlers.TryGetValue(eventName, out var value) || value == null)
		{
			value = new List<LgCvidKs5MLkylhA8F>();
			eventHandlers.Add(eventName, value);
		}
		if (handlerTarget == null)
		{
			value.Add(new LgCvidKs5MLkylhA8F((WeakReference)null, in methodInfo));
		}
		else
		{
			value.Add(new LgCvidKs5MLkylhA8F(new WeakReference(handlerTarget), in methodInfo));
		}
	}

	internal static void Ug93F9D0oo(in string eventName, in object? handlerTarget, in MemberInfo? methodInfo, in Dictionary<string, List<LgCvidKs5MLkylhA8F>> eventHandlers)
	{
		if (!eventHandlers.TryGetValue(eventName, out var value) || value == null)
		{
			return;
		}
		for (int num = value.Count; num > 0; num--)
		{
			LgCvidKs5MLkylhA8F item = value[num - 1];
			WeakReference weakReference = lR2QDhgLbWOBEr77Bvd.IB3tMMvyI(ref item, lR2QDhgLbWOBEr77Bvd.jZ7gV9widi);
			if (((weakReference != null) ? FRTtURgSPNZT4FC19XR.IB3tMMvyI(weakReference, FRTtURgSPNZT4FC19XR.rXkgnZOYKi) : null) == handlerTarget)
			{
				string text = BkFFwYmT10k6taWbxb.IB3tMMvyI(HMTNe7gvGxc49fQL8JC.IB3tMMvyI(ref item, HMTNe7gvGxc49fQL8JC.Sp3gMBluaD), BkFFwYmT10k6taWbxb.BkCg9DqdP9);
				MemberInfo? obj = methodInfo;
				if (!rEApJjgjnlE70Sxl9bu.IB3tMMvyI(text, ((object)obj != null) ? BkFFwYmT10k6taWbxb.IB3tMMvyI(obj, BkFFwYmT10k6taWbxb.BkCg9DqdP9) : null, rEApJjgjnlE70Sxl9bu.JIZgCnsPB2))
				{
					value.Remove(item);
					break;
				}
			}
		}
	}

	internal static void vg63cRnguw(in string eventName, in object? sender, in object? eventArgs, in Dictionary<string, List<LgCvidKs5MLkylhA8F>> eventHandlers)
	{
		List<Tuple<object, MethodInfo>> toRaise = default(List<Tuple<object, MethodInfo>>);
		iQsoaIgIyXcDV6qyqqN.IB3tMMvyI(ref eventName, ref eventHandlers, ref toRaise, iQsoaIgIyXcDV6qyqqN.SEHgfNF68V);
		for (int i = 0; i < toRaise.Count; i++)
		{
			try
			{
				Tuple<object, MethodInfo> tuple = toRaise[i];
				tuple.Item2.Invoke(tuple.Item1, new object[2] { sender, eventArgs });
			}
			catch (TargetParameterCountException targetParameterCountException)
			{
				throw new InvalidHandleEventException(q2no0WnPxDaipZawxT.IB3tMMvyI(514, q2no0WnPxDaipZawxT.eV4vC1LZv), targetParameterCountException);
			}
		}
	}

	internal static void Y0K3ao7YNb(in string eventName, in object? actionEventArgs, in Dictionary<string, List<LgCvidKs5MLkylhA8F>> eventHandlers)
	{
		List<Tuple<object, MethodInfo>> toRaise = default(List<Tuple<object, MethodInfo>>);
		iQsoaIgIyXcDV6qyqqN.IB3tMMvyI(ref eventName, ref eventHandlers, ref toRaise, iQsoaIgIyXcDV6qyqqN.SEHgfNF68V);
		for (int i = 0; i < toRaise.Count; i++)
		{
			try
			{
				Tuple<object, MethodInfo> tuple = toRaise[i];
				tuple.Item2.Invoke(tuple.Item1, new object[1] { actionEventArgs });
			}
			catch (TargetParameterCountException targetParameterCountException)
			{
				throw new InvalidHandleEventException(q2no0WnPxDaipZawxT.IB3tMMvyI(896, q2no0WnPxDaipZawxT.eV4vC1LZv), targetParameterCountException);
			}
		}
	}

	internal static void x3F3PvNevV(in string eventName, in Dictionary<string, List<LgCvidKs5MLkylhA8F>> eventHandlers)
	{
		List<Tuple<object, MethodInfo>> toRaise = default(List<Tuple<object, MethodInfo>>);
		iQsoaIgIyXcDV6qyqqN.IB3tMMvyI(ref eventName, ref eventHandlers, ref toRaise, iQsoaIgIyXcDV6qyqqN.SEHgfNF68V);
		for (int i = 0; i < toRaise.Count; i++)
		{
			try
			{
				Tuple<object, MethodInfo> tuple = toRaise[i];
				tuple.Item2.Invoke(tuple.Item1, null);
			}
			catch (TargetParameterCountException targetParameterCountException)
			{
				throw new InvalidHandleEventException(q2no0WnPxDaipZawxT.IB3tMMvyI(1322, q2no0WnPxDaipZawxT.eV4vC1LZv), targetParameterCountException);
			}
		}
	}

	private static void ofY3tv8fbl(in string eventName, in Dictionary<string, List<LgCvidKs5MLkylhA8F>> eventHandlers, out List<Tuple<object?, MethodInfo>> toRaise)
	{
		List<LgCvidKs5MLkylhA8F> list = new List<LgCvidKs5MLkylhA8F>();
		toRaise = new List<Tuple<object, MethodInfo>>();
		if (!eventHandlers.TryGetValue(eventName, out var value) || value == null)
		{
			return;
		}
		for (int i = 0; i < value.Count; i++)
		{
			LgCvidKs5MLkylhA8F item = value[i];
			if (lR2QDhgLbWOBEr77Bvd.IB3tMMvyI(ref item, lR2QDhgLbWOBEr77Bvd.jZ7gV9widi) == null)
			{
				toRaise.Add(Tuple.Create<object, MethodInfo>(null, HMTNe7gvGxc49fQL8JC.IB3tMMvyI(ref item, HMTNe7gvGxc49fQL8JC.Sp3gMBluaD)));
				continue;
			}
			WeakReference weakReference = lR2QDhgLbWOBEr77Bvd.IB3tMMvyI(ref item, lR2QDhgLbWOBEr77Bvd.jZ7gV9widi);
			object obj = ((weakReference != null) ? FRTtURgSPNZT4FC19XR.IB3tMMvyI(weakReference, FRTtURgSPNZT4FC19XR.rXkgnZOYKi) : null);
			if (obj == null)
			{
				list.Add(item);
			}
			else
			{
				toRaise.Add(Tuple.Create(obj, HMTNe7gvGxc49fQL8JC.IB3tMMvyI(ref item, HMTNe7gvGxc49fQL8JC.Sp3gMBluaD)));
			}
		}
		for (int j = 0; j < list.Count; j++)
		{
			LgCvidKs5MLkylhA8F item2 = list[j];
			value.Remove(item2);
		}
	}
}
