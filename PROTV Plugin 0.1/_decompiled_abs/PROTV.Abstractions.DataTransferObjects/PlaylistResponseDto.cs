using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace PROTV.Abstractions.DataTransferObjects;

public class PlaylistResponseDto<T>
{
	[CompilerGenerated]
	private int TMMPmXDAxB;

	[CompilerGenerated]
	private string aQLPw2mFvI;

	[CompilerGenerated]
	private string LGMPML8QFH;

	[CompilerGenerated]
	private List<string> CkwPxeGkFV;

	[CompilerGenerated]
	private List<T> a9hPVFsbZV;

	public int Id
	{
		[CompilerGenerated]
		get
		{
			return TMMPmXDAxB;
		}
		[CompilerGenerated]
		set
		{
			TMMPmXDAxB = value;
		}
	}

	public string Title
	{
		[CompilerGenerated]
		get
		{
			return aQLPw2mFvI;
		}
		[CompilerGenerated]
		set
		{
			aQLPw2mFvI = value;
		}
	}

	public string ItemsCount
	{
		[CompilerGenerated]
		get
		{
			return LGMPML8QFH;
		}
		[CompilerGenerated]
		set
		{
			LGMPML8QFH = value;
		}
	}

	public List<string> Posters
	{
		[CompilerGenerated]
		get
		{
			return CkwPxeGkFV;
		}
		[CompilerGenerated]
		set
		{
			CkwPxeGkFV = value;
		}
	}

	public List<T> Items
	{
		[CompilerGenerated]
		get
		{
			return a9hPVFsbZV;
		}
		[CompilerGenerated]
		set
		{
			a9hPVFsbZV = value;
		}
	}

	public string Poster => Posters?.FirstOrDefault();

	public PlaylistResponseDto()
	{
		uiiVNagWnDNnTWnFgq.IB3tMMvyI(uiiVNagWnDNnTWnFgq.JyKLgPcm8);
		base._002Ector();
	}
}
