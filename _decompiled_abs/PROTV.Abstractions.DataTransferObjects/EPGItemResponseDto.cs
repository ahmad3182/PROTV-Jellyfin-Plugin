using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;

namespace PROTV.Abstractions.DataTransferObjects;

public class EPGItemResponseDto : INotifyPropertyChanged
{
	[CompilerGenerated]
	private int qPkFqiObXo;

	[CompilerGenerated]
	private string A0CFSwXswk;

	[CompilerGenerated]
	private string bqTFb1ZKrh;

	[CompilerGenerated]
	private string HCgFesVHH3;

	[CompilerGenerated]
	private DateTime? CE0FJ5MC4j;

	[CompilerGenerated]
	private string mgOFQneVN2;

	[CompilerGenerated]
	private DateTime? gxgFL90f6j;

	[CompilerGenerated]
	private string yInF0w8oM3;

	[CompilerGenerated]
	private string dpEFTwJGW6;

	[CompilerGenerated]
	private PropertyChangedEventHandler uXeF6GhlnV;

	public int Id
	{
		[CompilerGenerated]
		get
		{
			return qPkFqiObXo;
		}
		[CompilerGenerated]
		set
		{
			qPkFqiObXo = value;
		}
	}

	public string Title
	{
		[CompilerGenerated]
		get
		{
			return A0CFSwXswk;
		}
		[CompilerGenerated]
		set
		{
			A0CFSwXswk = value;
		}
	}

	public string Description
	{
		[CompilerGenerated]
		get
		{
			return bqTFb1ZKrh;
		}
		[CompilerGenerated]
		set
		{
			bqTFb1ZKrh = value;
		}
	}

	public string Info
	{
		[CompilerGenerated]
		get
		{
			return HCgFesVHH3;
		}
		[CompilerGenerated]
		set
		{
			HCgFesVHH3 = value;
		}
	}

	public DateTime? Day
	{
		[CompilerGenerated]
		get
		{
			return CE0FJ5MC4j;
		}
		[CompilerGenerated]
		set
		{
			CE0FJ5MC4j = value;
		}
	}

	public string StartTime
	{
		[CompilerGenerated]
		get
		{
			return mgOFQneVN2;
		}
		[CompilerGenerated]
		set
		{
			mgOFQneVN2 = value;
		}
	}

	public DateTime? ShowTime
	{
		[CompilerGenerated]
		get
		{
			return gxgFL90f6j;
		}
		[CompilerGenerated]
		set
		{
			gxgFL90f6j = value;
		}
	}

	public string Duration
	{
		[CompilerGenerated]
		get
		{
			return yInF0w8oM3;
		}
		[CompilerGenerated]
		set
		{
			yInF0w8oM3 = value;
		}
	}

	public double RemainingTime
	{
		get
		{
			if (!Wh4ke5gTq3oBL6vPAY9.IB3tMMvyI(this, Wh4ke5gTq3oBL6vPAY9.NLigZZYooo).HasValue)
			{
				return 0.0;
			}
			TimeSpan timeSpan = eNENuxgit0CcV02LbwS.IB3tMMvyI(ix0AP1guMX2I0U7xh8u.IB3tMMvyI(ix0AP1guMX2I0U7xh8u.Bchg200s7j), Wh4ke5gTq3oBL6vPAY9.IB3tMMvyI(this, Wh4ke5gTq3oBL6vPAY9.NLigZZYooo).Value, eNENuxgit0CcV02LbwS.nEUgenrKKT);
			return gEJpTZg3htLRx4NJFro.IB3tMMvyI(ref timeSpan, gEJpTZg3htLRx4NJFro.LyugHc1GUl);
		}
	}

	public double Width => jgTMUXgkKb0g58mFqua.IB3tMMvyI(BkFFwYmT10k6taWbxb.IB3tMMvyI(this, BkFFwYmT10k6taWbxb.GrWgQ21KuH), jgTMUXgkKb0g58mFqua.n3ggWBx1lE) * 6.0;

	public string StartTimeRelevant
	{
		get
		{
			string text = BkFFwYmT10k6taWbxb.IB3tMMvyI(this, BkFFwYmT10k6taWbxb.oV6gJt1XhG);
			if (text == null)
			{
				return null;
			}
			return GyyT3s0SoNeJvQN2ji.IB3tMMvyI(text, 0, 5, GyyT3s0SoNeJvQN2ji.oiCgbD7jYv);
		}
	}

	public bool IsOn
	{
		get
		{
			if (!kNn8wecEBg33G3F6YN.IB3tMMvyI(BkFFwYmT10k6taWbxb.IB3tMMvyI(this, BkFFwYmT10k6taWbxb.oV6gJt1XhG), kNn8wecEBg33G3F6YN.xTKte64Wkh))
			{
				if (!(jgTMUXgkKb0g58mFqua.IB3tMMvyI(BkFFwYmT10k6taWbxb.IB3tMMvyI(this, BkFFwYmT10k6taWbxb.GrWgQ21KuH), jgTMUXgkKb0g58mFqua.n3ggWBx1lE) - n724Fkg73Z11QtckDYV.IB3tMMvyI(this, n724Fkg73Z11QtckDYV.Qc8gYavH0D) >= 0.0) || !(n724Fkg73Z11QtckDYV.IB3tMMvyI(this, n724Fkg73Z11QtckDYV.Qc8gYavH0D) > 0.0))
				{
					return false;
				}
				return true;
			}
			return false;
		}
	}

	public string Actors
	{
		[CompilerGenerated]
		get
		{
			return dpEFTwJGW6;
		}
		[CompilerGenerated]
		set
		{
			dpEFTwJGW6 = value;
		}
	}

	public event PropertyChangedEventHandler PropertyChanged
	{
		[CompilerGenerated]
		add
		{
			PropertyChangedEventHandler propertyChangedEventHandler = uXeF6GhlnV;
			PropertyChangedEventHandler propertyChangedEventHandler2;
			do
			{
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)RPEU3egXGZVvhTR6XmH.IB3tMMvyI(propertyChangedEventHandler2, value, RPEU3egXGZVvhTR6XmH.s2kgFOJ4Ul);
				propertyChangedEventHandler = Interlocked.CompareExchange(ref uXeF6GhlnV, value2, propertyChangedEventHandler2);
			}
			while ((object)propertyChangedEventHandler != propertyChangedEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			PropertyChangedEventHandler propertyChangedEventHandler = uXeF6GhlnV;
			PropertyChangedEventHandler propertyChangedEventHandler2;
			do
			{
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)RPEU3egXGZVvhTR6XmH.IB3tMMvyI(propertyChangedEventHandler2, value, RPEU3egXGZVvhTR6XmH.SMVg0oDlbE);
				propertyChangedEventHandler = Interlocked.CompareExchange(ref uXeF6GhlnV, value2, propertyChangedEventHandler2);
			}
			while ((object)propertyChangedEventHandler != propertyChangedEventHandler2);
		}
	}

	public virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
	{
		uXeF6GhlnV?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}

	public EPGItemResponseDto()
	{
		uiiVNagWnDNnTWnFgq.IB3tMMvyI(uiiVNagWnDNnTWnFgq.JyKLgPcm8);
		base._002Ector();
	}
}
