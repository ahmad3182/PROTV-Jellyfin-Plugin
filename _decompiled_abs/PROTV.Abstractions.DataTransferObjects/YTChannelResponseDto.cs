using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;

namespace PROTV.Abstractions.DataTransferObjects;

public class YTChannelResponseDto : INotifyPropertyChanged
{
	[CompilerGenerated]
	private int vZW5x7pJGQ;

	[CompilerGenerated]
	private string qvv5VBrNIK;

	[CompilerGenerated]
	private string XKX5dpG6hu;

	[CompilerGenerated]
	private string Edy5GBEq67;

	[CompilerGenerated]
	private string vTD5ZjqvDD;

	[CompilerGenerated]
	private decimal t1B5poGaMD;

	[CompilerGenerated]
	private decimal et959YsT5P;

	[CompilerGenerated]
	private decimal WH85R5Or8c;

	[CompilerGenerated]
	private List<YTPlaylisTResponseDto> zOq5sCXYpE;

	[CompilerGenerated]
	private long VVO5khlInS;

	[CompilerGenerated]
	private bool iOe5okT1kM;

	[CompilerGenerated]
	private decimal s7K5KRMnbX;

	[CompilerGenerated]
	private decimal bVA5g6K83E;

	[CompilerGenerated]
	private PropertyChangedEventHandler UZB5WgJ7BD;

	public int Id
	{
		[CompilerGenerated]
		get
		{
			return vZW5x7pJGQ;
		}
		[CompilerGenerated]
		set
		{
			vZW5x7pJGQ = value;
		}
	}

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return qvv5VBrNIK;
		}
		[CompilerGenerated]
		set
		{
			qvv5VBrNIK = value;
		}
	}

	public string Poster
	{
		[CompilerGenerated]
		get
		{
			return XKX5dpG6hu;
		}
		[CompilerGenerated]
		set
		{
			XKX5dpG6hu = value;
		}
	}

	public string DescriptionEn
	{
		[CompilerGenerated]
		get
		{
			return Edy5GBEq67;
		}
		[CompilerGenerated]
		set
		{
			Edy5GBEq67 = value;
		}
	}

	public string DescriptionAr
	{
		[CompilerGenerated]
		get
		{
			return vTD5ZjqvDD;
		}
		[CompilerGenerated]
		set
		{
			vTD5ZjqvDD = value;
		}
	}

	public decimal WatchCount
	{
		[CompilerGenerated]
		get
		{
			return t1B5poGaMD;
		}
		[CompilerGenerated]
		set
		{
			t1B5poGaMD = value;
		}
	}

	public decimal LikeCount
	{
		[CompilerGenerated]
		get
		{
			return et959YsT5P;
		}
		[CompilerGenerated]
		set
		{
			et959YsT5P = value;
		}
	}

	public decimal DislikeCount
	{
		[CompilerGenerated]
		get
		{
			return WH85R5Or8c;
		}
		[CompilerGenerated]
		set
		{
			WH85R5Or8c = value;
		}
	}

	public List<YTPlaylisTResponseDto> Playlists
	{
		[CompilerGenerated]
		get
		{
			return zOq5sCXYpE;
		}
		[CompilerGenerated]
		set
		{
			zOq5sCXYpE = value;
		}
	}

	public long SubscribeCount
	{
		[CompilerGenerated]
		get
		{
			return VVO5khlInS;
		}
		[CompilerGenerated]
		set
		{
			VVO5khlInS = value;
		}
	}

	public bool Subscribed
	{
		[CompilerGenerated]
		get
		{
			return iOe5okT1kM;
		}
		[CompilerGenerated]
		set
		{
			iOe5okT1kM = value;
		}
	}

	public decimal PlaylistCount
	{
		[CompilerGenerated]
		get
		{
			return s7K5KRMnbX;
		}
		[CompilerGenerated]
		set
		{
			s7K5KRMnbX = value;
		}
	}

	public decimal VideoCount
	{
		[CompilerGenerated]
		get
		{
			return bVA5g6K83E;
		}
		[CompilerGenerated]
		set
		{
			bVA5g6K83E = value;
		}
	}

	public event PropertyChangedEventHandler PropertyChanged
	{
		[CompilerGenerated]
		add
		{
			PropertyChangedEventHandler propertyChangedEventHandler = UZB5WgJ7BD;
			PropertyChangedEventHandler propertyChangedEventHandler2;
			do
			{
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)RPEU3egXGZVvhTR6XmH.IB3tMMvyI(propertyChangedEventHandler2, value, RPEU3egXGZVvhTR6XmH.s2kgFOJ4Ul);
				propertyChangedEventHandler = Interlocked.CompareExchange(ref UZB5WgJ7BD, value2, propertyChangedEventHandler2);
			}
			while ((object)propertyChangedEventHandler != propertyChangedEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			PropertyChangedEventHandler propertyChangedEventHandler = UZB5WgJ7BD;
			PropertyChangedEventHandler propertyChangedEventHandler2;
			do
			{
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)RPEU3egXGZVvhTR6XmH.IB3tMMvyI(propertyChangedEventHandler2, value, RPEU3egXGZVvhTR6XmH.SMVg0oDlbE);
				propertyChangedEventHandler = Interlocked.CompareExchange(ref UZB5WgJ7BD, value2, propertyChangedEventHandler2);
			}
			while ((object)propertyChangedEventHandler != propertyChangedEventHandler2);
		}
	}

	public virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
	{
		UZB5WgJ7BD?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}

	public YTChannelResponseDto()
	{
		uiiVNagWnDNnTWnFgq.IB3tMMvyI(uiiVNagWnDNnTWnFgq.JyKLgPcm8);
		base._002Ector();
	}
}
