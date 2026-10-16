using System.Collections.Generic;
using System.Runtime.CompilerServices;
using PROTV.Abstractions.Common;
using PROTV.Abstractions.DataTransferObjects;

namespace PROTV.Wpf.ViewModels;

public class VideoPlayerPlaylistItem : BaseViewModel
{
	private int zbOBf4n5Mq;

	private bool SXZBKRwPYN;

	[CompilerGenerated]
	private PlaylistItemType V01Bk2dQgh;

	[CompilerGenerated]
	private string DvfB8OZ4O7;

	[CompilerGenerated]
	private int Q9DBQGNwiK;

	[CompilerGenerated]
	private string he3BndAKZx;

	[CompilerGenerated]
	private int f2EBbLNvZX;

	[CompilerGenerated]
	private string pV0B7nMaUx;

	[CompilerGenerated]
	private IEnumerable<SubtitleResponseDto> jqkB5500Ep;

	[CompilerGenerated]
	private int? MM0BuhWMVN;

	[CompilerGenerated]
	private MediaCost RtyBAoW7F1;

	[CompilerGenerated]
	private int ItmBN1c8Dn;

	[CompilerGenerated]
	private IEnumerable<EPGItemResponseDto> Y61BMYB6yF;

	[CompilerGenerated]
	private double Es7BCfULiY;

	public PlaylistItemType PlaylistItemType
	{
		[CompilerGenerated]
		get
		{
			return V01Bk2dQgh;
		}
		[CompilerGenerated]
		set
		{
			V01Bk2dQgh = value;
		}
	}

	public string ImageUrl
	{
		[CompilerGenerated]
		get
		{
			return DvfB8OZ4O7;
		}
		[CompilerGenerated]
		set
		{
			DvfB8OZ4O7 = value;
		}
	}

	public int Id
	{
		[CompilerGenerated]
		get
		{
			return Q9DBQGNwiK;
		}
		[CompilerGenerated]
		set
		{
			Q9DBQGNwiK = value;
		}
	}

	public string SourceUrl
	{
		[CompilerGenerated]
		get
		{
			return he3BndAKZx;
		}
		[CompilerGenerated]
		set
		{
			he3BndAKZx = value;
		}
	}

	public int Index
	{
		[CompilerGenerated]
		get
		{
			return f2EBbLNvZX;
		}
		[CompilerGenerated]
		set
		{
			f2EBbLNvZX = value;
		}
	}

	public string Password
	{
		[CompilerGenerated]
		get
		{
			return pV0B7nMaUx;
		}
		[CompilerGenerated]
		internal set
		{
			pV0B7nMaUx = value;
		}
	}

	public int Liked
	{
		get
		{
			return zbOBf4n5Mq;
		}
		set
		{
			SetProperty(ref zbOBf4n5Mq, value, iFZ5je3XFYKwkvcE5D.D35lls5iF(8340, iFZ5je3XFYKwkvcE5D.N06TeK0ao));
		}
	}

	public bool IsFavorite
	{
		get
		{
			return SXZBKRwPYN;
		}
		set
		{
			SetProperty(ref SXZBKRwPYN, value, iFZ5je3XFYKwkvcE5D.D35lls5iF(8354, iFZ5je3XFYKwkvcE5D.N06TeK0ao));
		}
	}

	public IEnumerable<SubtitleResponseDto> Subtitles
	{
		[CompilerGenerated]
		get
		{
			return jqkB5500Ep;
		}
		[CompilerGenerated]
		internal set
		{
			jqkB5500Ep = value;
		}
	}

	public int? ReleaseYear
	{
		[CompilerGenerated]
		get
		{
			return MM0BuhWMVN;
		}
		[CompilerGenerated]
		internal set
		{
			MM0BuhWMVN = value;
		}
	}

	public MediaCost MediaCost
	{
		[CompilerGenerated]
		get
		{
			return RtyBAoW7F1;
		}
		[CompilerGenerated]
		internal set
		{
			RtyBAoW7F1 = value;
		}
	}

	public int Price
	{
		[CompilerGenerated]
		get
		{
			return ItmBN1c8Dn;
		}
		[CompilerGenerated]
		internal set
		{
			ItmBN1c8Dn = value;
		}
	}

	public string IPrice
	{
		get
		{
			if (uN1DaxTm1XRIu0SSp7h.D35lls5iF(this, uN1DaxTm1XRIu0SSp7h.ERsTa0wiKI) != MediaCost.Free)
			{
				int num = m9MGZR7k2RmVqYXYS5.D35lls5iF(this, m9MGZR7k2RmVqYXYS5.E55TIHLjwQ);
				return UwSEfC4rh9eVlFenwI.D35lls5iF(E1oqfbTdQ1YrEeaxoPg.D35lls5iF(ref num, E1oqfbTdQ1YrEeaxoPg.beYTUkKTth), iFZ5je3XFYKwkvcE5D.D35lls5iF(8378, iFZ5je3XFYKwkvcE5D.N06TeK0ao), UwSEfC4rh9eVlFenwI.BPNLUJNA3);
			}
			return iFZ5je3XFYKwkvcE5D.D35lls5iF(8390, iFZ5je3XFYKwkvcE5D.N06TeK0ao);
		}
	}

	public IEnumerable<EPGItemResponseDto> EpgItems
	{
		[CompilerGenerated]
		get
		{
			return Y61BMYB6yF;
		}
		[CompilerGenerated]
		internal set
		{
			Y61BMYB6yF = value;
		}
	}

	public double HorizontalOffset
	{
		[CompilerGenerated]
		get
		{
			return Es7BCfULiY;
		}
		[CompilerGenerated]
		internal set
		{
			Es7BCfULiY = value;
		}
	}

	public VideoPlayerPlaylistItem()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector();
	}
}
