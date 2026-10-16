using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using PROTV.Abstractions.Common;

namespace PROTV.Abstractions.DataTransferObjects;

public class SongResponseDto : BaseMediaDto, INotifyPropertyChanged
{
	[CompilerGenerated]
	private int V5Kj88GlCy;

	[CompilerGenerated]
	private string P67jEShC5U;

	[CompilerGenerated]
	private string GA6jYw0DST;

	[CompilerGenerated]
	private string lWSjDZLWg0;

	[CompilerGenerated]
	private string fymj4d1ypM;

	[CompilerGenerated]
	private int? vSjjiabbRr;

	[CompilerGenerated]
	private string CKpjOgPfTr;

	[CompilerGenerated]
	private string vE3jr3SnmY;

	[CompilerGenerated]
	private string EW2jHPZNSB;

	[CompilerGenerated]
	private string cL4jv3hxk0;

	[CompilerGenerated]
	private string AiMjA7sKii;

	[CompilerGenerated]
	private string IVfju4XJIM;

	[CompilerGenerated]
	private bool vSsjqgptAJ;

	[CompilerGenerated]
	private int qmMjSPe4cS;

	[CompilerGenerated]
	private int rYMjbbt8n0;

	[CompilerGenerated]
	private int CcajeHHhQf;

	[CompilerGenerated]
	private string gPPjJC35Ik;

	[CompilerGenerated]
	private int gdwjQdVjxd;

	[CompilerGenerated]
	private AlbumResponseDto SSujLeJW9T;

	[CompilerGenerated]
	private string fotj06kkrw;

	[CompilerGenerated]
	private string aiSjTI6PV1;

	[CompilerGenerated]
	private Language DeHj6UCrjV;

	[CompilerGenerated]
	private LanguageAr JTRj7YEDF5;

	[CompilerGenerated]
	private bool AlMjn4rWOp;

	[CompilerGenerated]
	private bool jFbjCbadZw;

	[CompilerGenerated]
	private List<int> cy7jXMliVo;

	[CompilerGenerated]
	private PropertyChangedEventHandler i8Jjm5JHOA;

	public int Index
	{
		[CompilerGenerated]
		get
		{
			return V5Kj88GlCy;
		}
		[CompilerGenerated]
		set
		{
			V5Kj88GlCy = value;
		}
	}

	public string Title
	{
		[CompilerGenerated]
		get
		{
			return P67jEShC5U;
		}
		[CompilerGenerated]
		set
		{
			P67jEShC5U = value;
		}
	}

	public string SecondaryTitle
	{
		[CompilerGenerated]
		get
		{
			return GA6jYw0DST;
		}
		[CompilerGenerated]
		set
		{
			GA6jYw0DST = value;
		}
	}

	public string DescriptionEn
	{
		[CompilerGenerated]
		get
		{
			return lWSjDZLWg0;
		}
		[CompilerGenerated]
		set
		{
			lWSjDZLWg0 = value;
		}
	}

	public string DescriptionAr
	{
		[CompilerGenerated]
		get
		{
			return fymj4d1ypM;
		}
		[CompilerGenerated]
		set
		{
			fymj4d1ypM = value;
		}
	}

	public int? ReleaseYear
	{
		[CompilerGenerated]
		get
		{
			return vSjjiabbRr;
		}
		[CompilerGenerated]
		set
		{
			vSjjiabbRr = value;
		}
	}

	public string Poster
	{
		[CompilerGenerated]
		get
		{
			return CKpjOgPfTr;
		}
		[CompilerGenerated]
		set
		{
			CKpjOgPfTr = value;
		}
	}

	public string Duration
	{
		[CompilerGenerated]
		get
		{
			return vE3jr3SnmY;
		}
		[CompilerGenerated]
		set
		{
			vE3jr3SnmY = value;
		}
	}

	public string MP4URL
	{
		[CompilerGenerated]
		get
		{
			return EW2jHPZNSB;
		}
		[CompilerGenerated]
		set
		{
			EW2jHPZNSB = value;
		}
	}

	public string MP3URL
	{
		[CompilerGenerated]
		get
		{
			return cL4jv3hxk0;
		}
		[CompilerGenerated]
		set
		{
			cL4jv3hxk0 = value;
		}
	}

	public string PersonName
	{
		[CompilerGenerated]
		get
		{
			return AiMjA7sKii;
		}
		[CompilerGenerated]
		set
		{
			AiMjA7sKii = value;
		}
	}

	public string PersonSecondaryName
	{
		[CompilerGenerated]
		get
		{
			return IVfju4XJIM;
		}
		[CompilerGenerated]
		set
		{
			IVfju4XJIM = value;
		}
	}

	public bool HasImage
	{
		[CompilerGenerated]
		get
		{
			return vSsjqgptAJ;
		}
		[CompilerGenerated]
		set
		{
			vSsjqgptAJ = value;
		}
	}

	public int ArtistId
	{
		[CompilerGenerated]
		get
		{
			return qmMjSPe4cS;
		}
		[CompilerGenerated]
		set
		{
			qmMjSPe4cS = value;
		}
	}

	public int FavoriteCount
	{
		[CompilerGenerated]
		get
		{
			return rYMjbbt8n0;
		}
		[CompilerGenerated]
		set
		{
			rYMjbbt8n0 = value;
		}
	}

	public int WatchCount
	{
		[CompilerGenerated]
		get
		{
			return CcajeHHhQf;
		}
		[CompilerGenerated]
		set
		{
			CcajeHHhQf = value;
		}
	}

	public string watchCountAbbr
	{
		[CompilerGenerated]
		get
		{
			return gPPjJC35Ik;
		}
		[CompilerGenerated]
		set
		{
			gPPjJC35Ik = value;
		}
	}

	public int AlbumId
	{
		[CompilerGenerated]
		get
		{
			return gdwjQdVjxd;
		}
		[CompilerGenerated]
		set
		{
			gdwjQdVjxd = value;
		}
	}

	public AlbumResponseDto Album
	{
		[CompilerGenerated]
		get
		{
			return SSujLeJW9T;
		}
		[CompilerGenerated]
		set
		{
			SSujLeJW9T = value;
		}
	}

	public string CategoryTitleEn
	{
		[CompilerGenerated]
		get
		{
			return fotj06kkrw;
		}
		[CompilerGenerated]
		set
		{
			fotj06kkrw = value;
		}
	}

	public string CategoryTitleAr
	{
		[CompilerGenerated]
		get
		{
			return aiSjTI6PV1;
		}
		[CompilerGenerated]
		set
		{
			aiSjTI6PV1 = value;
		}
	}

	public Language Language
	{
		[CompilerGenerated]
		get
		{
			return DeHj6UCrjV;
		}
		[CompilerGenerated]
		set
		{
			DeHj6UCrjV = value;
		}
	}

	public LanguageAr LanguageAr
	{
		[CompilerGenerated]
		get
		{
			return JTRj7YEDF5;
		}
		[CompilerGenerated]
		set
		{
			JTRj7YEDF5 = value;
		}
	}

	public bool IsFavorite
	{
		[CompilerGenerated]
		get
		{
			return AlMjn4rWOp;
		}
		[CompilerGenerated]
		set
		{
			AlMjn4rWOp = value;
		}
	}

	public bool AlreadyWatched
	{
		[CompilerGenerated]
		get
		{
			return jFbjCbadZw;
		}
		[CompilerGenerated]
		set
		{
			jFbjCbadZw = value;
		}
	}

	public List<int> PlayListIds
	{
		[CompilerGenerated]
		get
		{
			return cy7jXMliVo;
		}
		[CompilerGenerated]
		set
		{
			cy7jXMliVo = value;
		}
	}

	public event PropertyChangedEventHandler PropertyChanged
	{
		[CompilerGenerated]
		add
		{
			PropertyChangedEventHandler propertyChangedEventHandler = i8Jjm5JHOA;
			PropertyChangedEventHandler propertyChangedEventHandler2;
			do
			{
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)RPEU3egXGZVvhTR6XmH.IB3tMMvyI(propertyChangedEventHandler2, value, RPEU3egXGZVvhTR6XmH.s2kgFOJ4Ul);
				propertyChangedEventHandler = Interlocked.CompareExchange(ref i8Jjm5JHOA, value2, propertyChangedEventHandler2);
			}
			while ((object)propertyChangedEventHandler != propertyChangedEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			PropertyChangedEventHandler propertyChangedEventHandler = i8Jjm5JHOA;
			PropertyChangedEventHandler propertyChangedEventHandler2;
			do
			{
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)RPEU3egXGZVvhTR6XmH.IB3tMMvyI(propertyChangedEventHandler2, value, RPEU3egXGZVvhTR6XmH.SMVg0oDlbE);
				propertyChangedEventHandler = Interlocked.CompareExchange(ref i8Jjm5JHOA, value2, propertyChangedEventHandler2);
			}
			while ((object)propertyChangedEventHandler != propertyChangedEventHandler2);
		}
	}

	public SongResponseDto()
	{
		uiiVNagWnDNnTWnFgq.IB3tMMvyI(uiiVNagWnDNnTWnFgq.JyKLgPcm8);
		base._002Ector();
		Q47M0hgElogUpLE5aKM.IB3tMMvyI(this, MediaType.Song, Q47M0hgElogUpLE5aKM.F7Hg4Cy634);
	}

	public virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
	{
		i8Jjm5JHOA?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}
}
