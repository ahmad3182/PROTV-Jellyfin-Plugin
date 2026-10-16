using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using inRDv5hipvrdZJqu59;

namespace PROTV.Abstractions.Helpers;

public class WeakEventManager<TEventArgs>
{
	private readonly Dictionary<string, List<LgCvidKs5MLkylhA8F>> hJO3UCUTU4;

	public void AddEventHandler(in EventHandler<TEventArgs> handler, [CallerMemberName] in string eventName = "")
	{
		if (kNn8wecEBg33G3F6YN.IB3tMMvyI(eventName, kNn8wecEBg33G3F6YN.xvCq7gQB7))
		{
			throw new ArgumentNullException(q2no0WnPxDaipZawxT.IB3tMMvyI(1808, q2no0WnPxDaipZawxT.eV4vC1LZv));
		}
		if (handler == null)
		{
			throw new ArgumentNullException(q2no0WnPxDaipZawxT.IB3tMMvyI(1790, q2no0WnPxDaipZawxT.eV4vC1LZv));
		}
		object handlerTarget = FRTtURgSPNZT4FC19XR.IB3tMMvyI(handler, FRTtURgSPNZT4FC19XR.s6PgUNc0Eh);
		MethodInfo methodInfo = dgEBhpg5gaLH7tbydA3.IB3tMMvyI(handler, dgEBhpg5gaLH7tbydA3.gOyg6aLacA);
		jf8Qm5gRJBjVacK4OWN.IB3tMMvyI(ref eventName, ref handlerTarget, ref methodInfo, ref hJO3UCUTU4, jf8Qm5gRJBjVacK4OWN.WpbgdBWqmI);
	}

	public void AddEventHandler(in Action<TEventArgs> action, [CallerMemberName] in string eventName = "")
	{
		if (kNn8wecEBg33G3F6YN.IB3tMMvyI(eventName, kNn8wecEBg33G3F6YN.xvCq7gQB7))
		{
			throw new ArgumentNullException(q2no0WnPxDaipZawxT.IB3tMMvyI(1808, q2no0WnPxDaipZawxT.eV4vC1LZv));
		}
		if (action == null)
		{
			throw new ArgumentNullException(q2no0WnPxDaipZawxT.IB3tMMvyI(1830, q2no0WnPxDaipZawxT.eV4vC1LZv));
		}
		object handlerTarget = FRTtURgSPNZT4FC19XR.IB3tMMvyI(action, FRTtURgSPNZT4FC19XR.s6PgUNc0Eh);
		MethodInfo methodInfo = dgEBhpg5gaLH7tbydA3.IB3tMMvyI(action, dgEBhpg5gaLH7tbydA3.gOyg6aLacA);
		jf8Qm5gRJBjVacK4OWN.IB3tMMvyI(ref eventName, ref handlerTarget, ref methodInfo, ref hJO3UCUTU4, jf8Qm5gRJBjVacK4OWN.WpbgdBWqmI);
	}

	public void RemoveEventHandler(in EventHandler<TEventArgs> handler, [CallerMemberName] in string eventName = "")
	{
		if (kNn8wecEBg33G3F6YN.IB3tMMvyI(eventName, kNn8wecEBg33G3F6YN.xvCq7gQB7))
		{
			throw new ArgumentNullException(q2no0WnPxDaipZawxT.IB3tMMvyI(1808, q2no0WnPxDaipZawxT.eV4vC1LZv));
		}
		if (handler == null)
		{
			throw new ArgumentNullException(q2no0WnPxDaipZawxT.IB3tMMvyI(1790, q2no0WnPxDaipZawxT.eV4vC1LZv));
		}
		object handlerTarget = FRTtURgSPNZT4FC19XR.IB3tMMvyI(handler, FRTtURgSPNZT4FC19XR.s6PgUNc0Eh);
		MemberInfo methodInfo = dgEBhpg5gaLH7tbydA3.IB3tMMvyI(handler, dgEBhpg5gaLH7tbydA3.gOyg6aLacA);
		gf7mKHgljbIgdtLpUKK.IB3tMMvyI(ref eventName, ref handlerTarget, ref methodInfo, ref hJO3UCUTU4, gf7mKHgljbIgdtLpUKK.gYEgmvmIRy);
	}

	public void RemoveEventHandler(in Action<TEventArgs> action, [CallerMemberName] in string eventName = "")
	{
		if (kNn8wecEBg33G3F6YN.IB3tMMvyI(eventName, kNn8wecEBg33G3F6YN.xvCq7gQB7))
		{
			throw new ArgumentNullException(q2no0WnPxDaipZawxT.IB3tMMvyI(1808, q2no0WnPxDaipZawxT.eV4vC1LZv));
		}
		if (action == null)
		{
			throw new ArgumentNullException(q2no0WnPxDaipZawxT.IB3tMMvyI(1830, q2no0WnPxDaipZawxT.eV4vC1LZv));
		}
		object handlerTarget = FRTtURgSPNZT4FC19XR.IB3tMMvyI(action, FRTtURgSPNZT4FC19XR.s6PgUNc0Eh);
		MemberInfo methodInfo = dgEBhpg5gaLH7tbydA3.IB3tMMvyI(action, dgEBhpg5gaLH7tbydA3.gOyg6aLacA);
		gf7mKHgljbIgdtLpUKK.IB3tMMvyI(ref eventName, ref handlerTarget, ref methodInfo, ref hJO3UCUTU4, gf7mKHgljbIgdtLpUKK.gYEgmvmIRy);
	}

	public void HandleEvent(in object? sender, in TEventArgs eventArgs, in string eventName)
	{
		object eventArgs2 = eventArgs;
		d5ntpggpmFxCeeR4gHB.IB3tMMvyI(ref eventName, ref sender, ref eventArgs2, ref hJO3UCUTU4, d5ntpggpmFxCeeR4gHB.IhWgc29aNi);
	}

	public void HandleEvent(in TEventArgs eventArgs, in string eventName)
	{
		object actionEventArgs = eventArgs;
		sDEiZQgqcQC7QQo9aen.IB3tMMvyI(ref eventName, ref actionEventArgs, ref hJO3UCUTU4, sDEiZQgqcQC7QQo9aen.wqigOvNiMk);
	}

	public WeakEventManager()
	{
		uiiVNagWnDNnTWnFgq.IB3tMMvyI(uiiVNagWnDNnTWnFgq.JyKLgPcm8);
		hJO3UCUTU4 = new Dictionary<string, List<LgCvidKs5MLkylhA8F>>();
		base._002Ector();
	}
}
public class WeakEventManager
{
	private readonly Dictionary<string, List<LgCvidKs5MLkylhA8F>> J5331U25xM;

	public void AddEventHandler(in Delegate handler, [CallerMemberName] in string eventName = "")
	{
		if (kNn8wecEBg33G3F6YN.IB3tMMvyI(eventName, kNn8wecEBg33G3F6YN.xvCq7gQB7))
		{
			throw new ArgumentNullException(q2no0WnPxDaipZawxT.IB3tMMvyI(1808, q2no0WnPxDaipZawxT.eV4vC1LZv));
		}
		if ((object)handler == null)
		{
			throw new ArgumentNullException(q2no0WnPxDaipZawxT.IB3tMMvyI(1790, q2no0WnPxDaipZawxT.eV4vC1LZv));
		}
		object handlerTarget = FRTtURgSPNZT4FC19XR.IB3tMMvyI(handler, FRTtURgSPNZT4FC19XR.s6PgUNc0Eh);
		MethodInfo methodInfo = dgEBhpg5gaLH7tbydA3.IB3tMMvyI(handler, dgEBhpg5gaLH7tbydA3.gOyg6aLacA);
		jf8Qm5gRJBjVacK4OWN.IB3tMMvyI(ref eventName, ref handlerTarget, ref methodInfo, ref J5331U25xM, jf8Qm5gRJBjVacK4OWN.WpbgdBWqmI);
	}

	public void RemoveEventHandler(in Delegate handler, [CallerMemberName] in string eventName = "")
	{
		if (kNn8wecEBg33G3F6YN.IB3tMMvyI(eventName, kNn8wecEBg33G3F6YN.xvCq7gQB7))
		{
			throw new ArgumentNullException(q2no0WnPxDaipZawxT.IB3tMMvyI(1808, q2no0WnPxDaipZawxT.eV4vC1LZv));
		}
		if ((object)handler == null)
		{
			throw new ArgumentNullException(q2no0WnPxDaipZawxT.IB3tMMvyI(1790, q2no0WnPxDaipZawxT.eV4vC1LZv));
		}
		object handlerTarget = FRTtURgSPNZT4FC19XR.IB3tMMvyI(handler, FRTtURgSPNZT4FC19XR.s6PgUNc0Eh);
		MemberInfo methodInfo = dgEBhpg5gaLH7tbydA3.IB3tMMvyI(handler, dgEBhpg5gaLH7tbydA3.gOyg6aLacA);
		gf7mKHgljbIgdtLpUKK.IB3tMMvyI(ref eventName, ref handlerTarget, ref methodInfo, ref J5331U25xM, gf7mKHgljbIgdtLpUKK.gYEgmvmIRy);
	}

	public void HandleEvent(in object? sender, in object? eventArgs, in string eventName)
	{
		d5ntpggpmFxCeeR4gHB.IB3tMMvyI(ref eventName, ref sender, ref eventArgs, ref J5331U25xM, d5ntpggpmFxCeeR4gHB.IhWgc29aNi);
	}

	public void HandleEvent(in string eventName)
	{
		jeyisygKaAtLJZsv5vT.IB3tMMvyI(ref eventName, ref J5331U25xM, jeyisygKaAtLJZsv5vT.HgUgri6Oxm);
	}

	public WeakEventManager()
	{
		uiiVNagWnDNnTWnFgq.IB3tMMvyI(uiiVNagWnDNnTWnFgq.JyKLgPcm8);
		J5331U25xM = new Dictionary<string, List<LgCvidKs5MLkylhA8F>>();
		base._002Ector();
	}
}
