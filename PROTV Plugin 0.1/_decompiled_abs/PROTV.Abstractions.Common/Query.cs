using System;
using System.Runtime.CompilerServices;

namespace PROTV.Abstractions.Common;

public class Query<S, E> where S : class, ISearch where E : struct, IConvertible
{
	[CompilerGenerated]
	private string yspld9FcBV;

	[CompilerGenerated]
	private int ck5lGSHHUU;

	[CompilerGenerated]
	private int rA4lZNo3oQ;

	[CompilerGenerated]
	private S qkAlpPecoc;

	[CompilerGenerated]
	private E AoIl9IKH42;

	[CompilerGenerated]
	private SortOrder kPglRHesPQ;

	public string Includes
	{
		[CompilerGenerated]
		get
		{
			return yspld9FcBV;
		}
		[CompilerGenerated]
		set
		{
			yspld9FcBV = value;
		}
	}

	public int Page
	{
		[CompilerGenerated]
		get
		{
			return ck5lGSHHUU;
		}
		[CompilerGenerated]
		set
		{
			ck5lGSHHUU = value;
		}
	}

	public int Count
	{
		[CompilerGenerated]
		get
		{
			return rA4lZNo3oQ;
		}
		[CompilerGenerated]
		set
		{
			rA4lZNo3oQ = value;
		}
	}

	public S Search
	{
		[CompilerGenerated]
		get
		{
			return qkAlpPecoc;
		}
		[CompilerGenerated]
		set
		{
			qkAlpPecoc = value;
		}
	}

	public E Sort
	{
		[CompilerGenerated]
		get
		{
			return AoIl9IKH42;
		}
		[CompilerGenerated]
		set
		{
			AoIl9IKH42 = value;
		}
	}

	public SortOrder Order
	{
		[CompilerGenerated]
		get
		{
			return kPglRHesPQ;
		}
		[CompilerGenerated]
		set
		{
			kPglRHesPQ = value;
		}
	}

	public Query()
	{
		uiiVNagWnDNnTWnFgq.IB3tMMvyI(uiiVNagWnDNnTWnFgq.JyKLgPcm8);
		base._002Ector();
		Page = 1;
		Count = 25;
		Order = SortOrder.Desc;
	}
}
