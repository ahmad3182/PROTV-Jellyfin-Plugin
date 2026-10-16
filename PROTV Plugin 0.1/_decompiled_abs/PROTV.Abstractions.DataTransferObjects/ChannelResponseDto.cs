using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using PROTV.Abstractions.Common;

namespace PROTV.Abstractions.DataTransferObjects;

public class ChannelResponseDto : INotifyPropertyChanged
{
	[CompilerGenerated]
	private int FL83Gy6lNK;

	[CompilerGenerated]
	private string j9l3ZpT2vW;

	[CompilerGenerated]
	private string nVl3pQKlMN;

	[CompilerGenerated]
	private string dJN39PuVR0;

	[CompilerGenerated]
	private string qZC3Ry5Z2v;

	[CompilerGenerated]
	private string D6i3ss0kFe;

	[CompilerGenerated]
	private int cSs3kv0FHW;

	[CompilerGenerated]
	private string CWM3o3X2NL;

	[CompilerGenerated]
	private string XO23K9mei6;

	[CompilerGenerated]
	private string wP63g3b1XN;

	[CompilerGenerated]
	private string KiW3W5wbmK;

	[CompilerGenerated]
	private int iec3fnZ63D;

	[CompilerGenerated]
	private ChannelType f4s3zwt12S;

	[CompilerGenerated]
	private MediaCost j2WyNAKlIo;

	[CompilerGenerated]
	private ChannelSource? njjyI2WQie;

	[CompilerGenerated]
	private Quality R6Dy3WANYo;

	[CompilerGenerated]
	private int F4cyyT7dBE;

	[CompilerGenerated]
	private int X8vyF2TdnV;

	[CompilerGenerated]
	private bool zscycuHRop;

	[CompilerGenerated]
	private bool OAoyaXoQpC;

	[CompilerGenerated]
	private bool X75yPaZ4Ym;

	[CompilerGenerated]
	private IEnumerable<CategoryResponseDto> nEVytBq7jl;

	[CompilerGenerated]
	private IEnumerable<int> FDmyjEQVLr;

	[CompilerGenerated]
	private PropertyChangedEventHandler I2uy5EhjHc;

	public int Id
	{
		[CompilerGenerated]
		get
		{
			return FL83Gy6lNK;
		}
		[CompilerGenerated]
		set
		{
			FL83Gy6lNK = value;
		}
	}

	public string TitleEn
	{
		[CompilerGenerated]
		get
		{
			return j9l3ZpT2vW;
		}
		[CompilerGenerated]
		set
		{
			j9l3ZpT2vW = value;
		}
	}

	public string TitleAr
	{
		[CompilerGenerated]
		get
		{
			return nVl3pQKlMN;
		}
		[CompilerGenerated]
		set
		{
			nVl3pQKlMN = value;
		}
	}

	public string DescriptionEn
	{
		[CompilerGenerated]
		get
		{
			return dJN39PuVR0;
		}
		[CompilerGenerated]
		set
		{
			dJN39PuVR0 = value;
		}
	}

	public string DescriptionAr
	{
		[CompilerGenerated]
		get
		{
			return qZC3Ry5Z2v;
		}
		[CompilerGenerated]
		set
		{
			qZC3Ry5Z2v = value;
		}
	}

	public string Logo
	{
		[CompilerGenerated]
		get
		{
			return D6i3ss0kFe;
		}
		[CompilerGenerated]
		set
		{
			D6i3ss0kFe = value;
		}
	}

	public int FixedNumber
	{
		[CompilerGenerated]
		get
		{
			return cSs3kv0FHW;
		}
		[CompilerGenerated]
		set
		{
			cSs3kv0FHW = value;
		}
	}

	public string LauncherURL
	{
		[CompilerGenerated]
		get
		{
			return CWM3o3X2NL;
		}
		[CompilerGenerated]
		set
		{
			CWM3o3X2NL = value;
		}
	}

	public string AndroidURL
	{
		[CompilerGenerated]
		get
		{
			return XO23K9mei6;
		}
		[CompilerGenerated]
		set
		{
			XO23K9mei6 = value;
		}
	}

	public string IOSURL
	{
		[CompilerGenerated]
		get
		{
			return wP63g3b1XN;
		}
		[CompilerGenerated]
		set
		{
			wP63g3b1XN = value;
		}
	}

	public string WebURL
	{
		[CompilerGenerated]
		get
		{
			return KiW3W5wbmK;
		}
		[CompilerGenerated]
		set
		{
			KiW3W5wbmK = value;
		}
	}

	public int AspCareId
	{
		[CompilerGenerated]
		get
		{
			return iec3fnZ63D;
		}
		[CompilerGenerated]
		set
		{
			iec3fnZ63D = value;
		}
	}

	public ChannelType ChannelType
	{
		[CompilerGenerated]
		get
		{
			return f4s3zwt12S;
		}
		[CompilerGenerated]
		set
		{
			f4s3zwt12S = value;
		}
	}

	public MediaCost ChannelCost
	{
		[CompilerGenerated]
		get
		{
			return j2WyNAKlIo;
		}
		[CompilerGenerated]
		set
		{
			j2WyNAKlIo = value;
		}
	}

	public ChannelSource? ChannelSource
	{
		[CompilerGenerated]
		get
		{
			return njjyI2WQie;
		}
		[CompilerGenerated]
		set
		{
			njjyI2WQie = value;
		}
	}

	public Quality Quality
	{
		[CompilerGenerated]
		get
		{
			return R6Dy3WANYo;
		}
		[CompilerGenerated]
		set
		{
			R6Dy3WANYo = value;
		}
	}

	public int FavoriteCount
	{
		[CompilerGenerated]
		get
		{
			return F4cyyT7dBE;
		}
		[CompilerGenerated]
		set
		{
			F4cyyT7dBE = value;
		}
	}

	public int WatchCount
	{
		[CompilerGenerated]
		get
		{
			return X8vyF2TdnV;
		}
		[CompilerGenerated]
		set
		{
			X8vyF2TdnV = value;
		}
	}

	public bool AlreadyWatched
	{
		[CompilerGenerated]
		get
		{
			return zscycuHRop;
		}
		[CompilerGenerated]
		set
		{
			zscycuHRop = value;
		}
	}

	public bool IsFavorite
	{
		[CompilerGenerated]
		get
		{
			return OAoyaXoQpC;
		}
		[CompilerGenerated]
		set
		{
			OAoyaXoQpC = value;
		}
	}

	public bool IsLocked
	{
		[CompilerGenerated]
		get
		{
			return X75yPaZ4Ym;
		}
		[CompilerGenerated]
		set
		{
			X75yPaZ4Ym = value;
		}
	}

	public IEnumerable<CategoryResponseDto> Categories
	{
		[CompilerGenerated]
		get
		{
			return nEVytBq7jl;
		}
		[CompilerGenerated]
		set
		{
			nEVytBq7jl = value;
		}
	}

	public IEnumerable<int> PlayLists
	{
		[CompilerGenerated]
		get
		{
			return FDmyjEQVLr;
		}
		[CompilerGenerated]
		set
		{
			FDmyjEQVLr = value;
		}
	}

	public event PropertyChangedEventHandler PropertyChanged
	{
		[CompilerGenerated]
		add
		{
			PropertyChangedEventHandler propertyChangedEventHandler = I2uy5EhjHc;
			PropertyChangedEventHandler propertyChangedEventHandler2;
			do
			{
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)RPEU3egXGZVvhTR6XmH.IB3tMMvyI(propertyChangedEventHandler2, value, RPEU3egXGZVvhTR6XmH.s2kgFOJ4Ul);
				propertyChangedEventHandler = Interlocked.CompareExchange(ref I2uy5EhjHc, value2, propertyChangedEventHandler2);
			}
			while ((object)propertyChangedEventHandler != propertyChangedEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			PropertyChangedEventHandler propertyChangedEventHandler = I2uy5EhjHc;
			PropertyChangedEventHandler propertyChangedEventHandler2;
			do
			{
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)RPEU3egXGZVvhTR6XmH.IB3tMMvyI(propertyChangedEventHandler2, value, RPEU3egXGZVvhTR6XmH.SMVg0oDlbE);
				propertyChangedEventHandler = Interlocked.CompareExchange(ref I2uy5EhjHc, value2, propertyChangedEventHandler2);
			}
			while ((object)propertyChangedEventHandler != propertyChangedEventHandler2);
		}
	}

	public virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
	{
		I2uy5EhjHc?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}

	public ChannelResponseDto()
	{
		uiiVNagWnDNnTWnFgq.IB3tMMvyI(uiiVNagWnDNnTWnFgq.JyKLgPcm8);
		base._002Ector();
	}
}
