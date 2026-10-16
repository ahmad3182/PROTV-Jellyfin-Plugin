using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PROTV.Abstractions.Helpers;

public static class ReactiveExtensions
{
	internal sealed class gTdT0uAAck039inb04 : Dictionary<string, yc9dbm3ihLQmCWxl0J>
	{
		public gTdT0uAAck039inb04()
		{
			uiiVNagWnDNnTWnFgq.IB3tMMvyI(uiiVNagWnDNnTWnFgq.JyKLgPcm8);
			base._002Ector();
		}
	}

	internal sealed class yc9dbm3ihLQmCWxl0J : List<iwSU2Hc25blY0a28rx>
	{
		public yc9dbm3ihLQmCWxl0J()
		{
			uiiVNagWnDNnTWnFgq.IB3tMMvyI(uiiVNagWnDNnTWnFgq.JyKLgPcm8);
			base._002Ector(32);
		}
	}

	internal sealed class iwSU2Hc25blY0a28rx : WeakReference
	{
		public iwSU2Hc25blY0a28rx(Action P_0)
		{
			uiiVNagWnDNnTWnFgq.IB3tMMvyI(uiiVNagWnDNnTWnFgq.JyKLgPcm8);
			base._002Ector(P_0, trackResurrection: false);
		}

		[SpecialName]
		public Action EW92IsFNuR()
		{
			if (!TLD0W5K9yiTCdcMEKT.IB3tMMvyI(this, TLD0W5K9yiTCdcMEKT.EtkvkOVeLd))
			{
				return null;
			}
			return FRTtURgSPNZT4FC19XR.IB3tMMvyI(this, FRTtURgSPNZT4FC19XR.i0LvWGMJtg) as Action;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass3_0
	{
		public INotifyPropertyChanged xqk2F0Bu5h;

		public _003C_003Ec__DisplayClass3_0()
		{
			uiiVNagWnDNnTWnFgq.IB3tMMvyI(uiiVNagWnDNnTWnFgq.JyKLgPcm8);
			base._002Ector();
		}

		internal void TZW2ywG8Kt(object? s, PropertyChangedEventArgs e)
		{
			yc9dbm3ihLQmCWxl0J yc9dbm3ihLQmCWxl0J2 = new yc9dbm3ihLQmCWxl0J();
			yc9dbm3ihLQmCWxl0J yc9dbm3ihLQmCWxl0J3 = new yc9dbm3ihLQmCWxl0J();
			object jjXI02wm7I = ReactiveExtensions.jjXI02wm7I;
			bool flag = false;
			try
			{
				wIHM4WtK4Xa4JN6KfB9.IB3tMMvyI(jjXI02wm7I, ref flag, wIHM4WtK4Xa4JN6KfB9.UkDtr57VeZ);
				if (!Wg2ILAm11m[xqk2F0Bu5h].ContainsKey(BkFFwYmT10k6taWbxb.IB3tMMvyI(e, BkFFwYmT10k6taWbxb.kWYvJcFn6v)))
				{
					return;
				}
				yc9dbm3ihLQmCWxl0J3.AddRange(Wg2ILAm11m[xqk2F0Bu5h][BkFFwYmT10k6taWbxb.IB3tMMvyI(e, BkFFwYmT10k6taWbxb.kWYvJcFn6v)]);
			}
			finally
			{
				if (flag)
				{
					d9mY6HtE1aKY8OKoIgQ.IB3tMMvyI(jjXI02wm7I, d9mY6HtE1aKY8OKoIgQ.Uert412jGU);
				}
			}
			foreach (iwSU2Hc25blY0a28rx item in yc9dbm3ihLQmCWxl0J3)
			{
				if (!TLD0W5K9yiTCdcMEKT.IB3tMMvyI(item, TLD0W5K9yiTCdcMEKT.EtkvkOVeLd))
				{
					yc9dbm3ihLQmCWxl0J2.Add(item);
				}
				else
				{
					qtq64NvbUggVBXdEt6S.IB3tMMvyI(item, qtq64NvbUggVBXdEt6S.rulv7SqUHP)?.Invoke();
				}
			}
			if (yc9dbm3ihLQmCWxl0J2.Count == 0)
			{
				return;
			}
			jjXI02wm7I = ReactiveExtensions.jjXI02wm7I;
			flag = false;
			try
			{
				wIHM4WtK4Xa4JN6KfB9.IB3tMMvyI(jjXI02wm7I, ref flag, wIHM4WtK4Xa4JN6KfB9.UkDtr57VeZ);
				foreach (iwSU2Hc25blY0a28rx item2 in yc9dbm3ihLQmCWxl0J2)
				{
					Wg2ILAm11m[xqk2F0Bu5h][BkFFwYmT10k6taWbxb.IB3tMMvyI(e, BkFFwYmT10k6taWbxb.kWYvJcFn6v)].Remove(item2);
				}
			}
			finally
			{
				if (flag)
				{
					d9mY6HtE1aKY8OKoIgQ.IB3tMMvyI(jjXI02wm7I, d9mY6HtE1aKY8OKoIgQ.Uert412jGU);
				}
			}
		}
	}

	private static readonly Dictionary<INotifyPropertyChanged, gTdT0uAAck039inb04> Wg2ILAm11m;

	private static readonly object jjXI02wm7I;

	private static readonly Dictionary<Action, bool> TeSITlYTb1;

	public static void WhenChanged(this Action callback, INotifyPropertyChanged publisher, params string[] propertyNames)
	{
		_003C_003Ec__DisplayClass3_0 CS_0024_003C_003E8__locals10 = new _003C_003Ec__DisplayClass3_0();
		CS_0024_003C_003E8__locals10.xqk2F0Bu5h = publisher;
		bool flag = false;
		object obj = jjXI02wm7I;
		bool flag2 = false;
		try
		{
			wIHM4WtK4Xa4JN6KfB9.IB3tMMvyI(obj, ref flag2, wIHM4WtK4Xa4JN6KfB9.UkDtr57VeZ);
			if (!Wg2ILAm11m.ContainsKey(CS_0024_003C_003E8__locals10.xqk2F0Bu5h))
			{
				Wg2ILAm11m[CS_0024_003C_003E8__locals10.xqk2F0Bu5h] = new gTdT0uAAck039inb04();
				flag = true;
			}
			TeSITlYTb1[callback] = true;
			foreach (string key in propertyNames)
			{
				if (!Wg2ILAm11m[CS_0024_003C_003E8__locals10.xqk2F0Bu5h].ContainsKey(key))
				{
					Wg2ILAm11m[CS_0024_003C_003E8__locals10.xqk2F0Bu5h][key] = new yc9dbm3ihLQmCWxl0J();
				}
				Wg2ILAm11m[CS_0024_003C_003E8__locals10.xqk2F0Bu5h][key].Add(new iwSU2Hc25blY0a28rx(callback));
			}
		}
		finally
		{
			if (flag2)
			{
				d9mY6HtE1aKY8OKoIgQ.IB3tMMvyI(obj, d9mY6HtE1aKY8OKoIgQ.Uert412jGU);
			}
		}
		if (!flag)
		{
			return;
		}
		f9aYwhtXkwpYLdXqcyh.IB3tMMvyI(CS_0024_003C_003E8__locals10.xqk2F0Bu5h, delegate(object? s, PropertyChangedEventArgs e)
		{
			yc9dbm3ihLQmCWxl0J yc9dbm3ihLQmCWxl0J2 = new yc9dbm3ihLQmCWxl0J();
			yc9dbm3ihLQmCWxl0J yc9dbm3ihLQmCWxl0J3 = new yc9dbm3ihLQmCWxl0J();
			object obj2 = jjXI02wm7I;
			bool flag3 = false;
			try
			{
				wIHM4WtK4Xa4JN6KfB9.IB3tMMvyI(obj2, ref flag3, wIHM4WtK4Xa4JN6KfB9.UkDtr57VeZ);
				if (!Wg2ILAm11m[CS_0024_003C_003E8__locals10.xqk2F0Bu5h].ContainsKey(BkFFwYmT10k6taWbxb.IB3tMMvyI(e, BkFFwYmT10k6taWbxb.kWYvJcFn6v)))
				{
					return;
				}
				yc9dbm3ihLQmCWxl0J3.AddRange(Wg2ILAm11m[CS_0024_003C_003E8__locals10.xqk2F0Bu5h][BkFFwYmT10k6taWbxb.IB3tMMvyI(e, BkFFwYmT10k6taWbxb.kWYvJcFn6v)]);
			}
			finally
			{
				if (flag3)
				{
					d9mY6HtE1aKY8OKoIgQ.IB3tMMvyI(obj2, d9mY6HtE1aKY8OKoIgQ.Uert412jGU);
				}
			}
			foreach (iwSU2Hc25blY0a28rx item in yc9dbm3ihLQmCWxl0J3)
			{
				if (!TLD0W5K9yiTCdcMEKT.IB3tMMvyI(item, TLD0W5K9yiTCdcMEKT.EtkvkOVeLd))
				{
					yc9dbm3ihLQmCWxl0J2.Add(item);
				}
				else
				{
					qtq64NvbUggVBXdEt6S.IB3tMMvyI(item, qtq64NvbUggVBXdEt6S.rulv7SqUHP)?.Invoke();
				}
			}
			if (yc9dbm3ihLQmCWxl0J2.Count == 0)
			{
				return;
			}
			obj2 = jjXI02wm7I;
			flag3 = false;
			try
			{
				wIHM4WtK4Xa4JN6KfB9.IB3tMMvyI(obj2, ref flag3, wIHM4WtK4Xa4JN6KfB9.UkDtr57VeZ);
				foreach (iwSU2Hc25blY0a28rx item2 in yc9dbm3ihLQmCWxl0J2)
				{
					Wg2ILAm11m[CS_0024_003C_003E8__locals10.xqk2F0Bu5h][BkFFwYmT10k6taWbxb.IB3tMMvyI(e, BkFFwYmT10k6taWbxb.kWYvJcFn6v)].Remove(item2);
				}
			}
			finally
			{
				if (flag3)
				{
					d9mY6HtE1aKY8OKoIgQ.IB3tMMvyI(obj2, d9mY6HtE1aKY8OKoIgQ.Uert412jGU);
				}
			}
		}, f9aYwhtXkwpYLdXqcyh.BmrtFKqs4g);
	}

	static ReactiveExtensions()
	{
		uiiVNagWnDNnTWnFgq.IB3tMMvyI(uiiVNagWnDNnTWnFgq.JyKLgPcm8);
		Wg2ILAm11m = new Dictionary<INotifyPropertyChanged, gTdT0uAAck039inb04>();
		jjXI02wm7I = new object();
		TeSITlYTb1 = new Dictionary<Action, bool>();
	}
}
