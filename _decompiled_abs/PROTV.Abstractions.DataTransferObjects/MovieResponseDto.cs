using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using PROTV.Abstractions.Common;

namespace PROTV.Abstractions.DataTransferObjects;

public class MovieResponseDto : BaseMediaDto, INotifyPropertyChanged
{
	[CompilerGenerated]
	private int Dgycp8NUjs;

	[CompilerGenerated]
	private string twUc9LYNCs;

	[CompilerGenerated]
	private string hqdcRGe3qU;

	[CompilerGenerated]
	private string eUlcs7WDtG;

	[CompilerGenerated]
	private int? peNckbfK7s;

	[CompilerGenerated]
	private string dVBco4cPLh;

	[CompilerGenerated]
	private string yvUcK41ywO;

	[CompilerGenerated]
	private string HIScgUhBHV;

	[CompilerGenerated]
	private string E6ZcWKum0m;

	[CompilerGenerated]
	private string AvicfgnF2t;

	[CompilerGenerated]
	private bool WtsczuQCaQ;

	[CompilerGenerated]
	private MediaCost QKcaNX3kRn;

	[CompilerGenerated]
	private Status kUUaIdQ0mE;

	[CompilerGenerated]
	private bool iHva3NgptN;

	[CompilerGenerated]
	private double FB9aygHkiZ;

	[CompilerGenerated]
	private double ptUaFeoyVe;

	[CompilerGenerated]
	private int FMmacY7aRF;

	[CompilerGenerated]
	private double A4paa3Ivji;

	[CompilerGenerated]
	private string iCJaPaxalv;

	[CompilerGenerated]
	private string OIdatoPsAB;

	[CompilerGenerated]
	private int MT3ajWR0hp;

	[CompilerGenerated]
	private int mdfa5pF2ZE;

	[CompilerGenerated]
	private int zCEal7EE9D;

	[CompilerGenerated]
	private int JLiahAhAcj;

	[CompilerGenerated]
	private string gRsa2SH6qb;

	[CompilerGenerated]
	private Language jaaaBmaGRO;

	[CompilerGenerated]
	private LanguageAr RqgaUkZTYH;

	[CompilerGenerated]
	private bool DZma1hTh0U;

	[CompilerGenerated]
	private bool iZWa8Y8BvL;

	[CompilerGenerated]
	private double UwqaEZeNC5;

	[CompilerGenerated]
	private bool FxBaY5kOt8;

	[CompilerGenerated]
	private double OwSaDiQbwy;

	[CompilerGenerated]
	private RentResponseDto y0ja4anqRx;

	[CompilerGenerated]
	private RateResponseDto nVuaidmocI;

	[CompilerGenerated]
	private IEnumerable<LinkResponseDto> aCpaO61vW9;

	[CompilerGenerated]
	private IEnumerable<SubtitleResponseDto> GMKartp9fO;

	[CompilerGenerated]
	private IEnumerable<CategoryResponseDto> v5maHaUgHR;

	[CompilerGenerated]
	private IEnumerable<int> IFIavensvj;

	[CompilerGenerated]
	private List<PersonResponseDto> cyLaAb3ZYP;

	[CompilerGenerated]
	private PropertyChangedEventHandler Kf6auMWqtL;

	public int Index
	{
		[CompilerGenerated]
		get
		{
			return Dgycp8NUjs;
		}
		[CompilerGenerated]
		set
		{
			Dgycp8NUjs = value;
		}
	}

	public string Title
	{
		[CompilerGenerated]
		get
		{
			return twUc9LYNCs;
		}
		[CompilerGenerated]
		set
		{
			twUc9LYNCs = value;
		}
	}

	public string SecondaryTitle
	{
		[CompilerGenerated]
		get
		{
			return hqdcRGe3qU;
		}
		[CompilerGenerated]
		set
		{
			hqdcRGe3qU = value;
		}
	}

	public string Duration
	{
		[CompilerGenerated]
		get
		{
			return eUlcs7WDtG;
		}
		[CompilerGenerated]
		set
		{
			eUlcs7WDtG = value;
		}
	}

	public int? ReleaseYear
	{
		[CompilerGenerated]
		get
		{
			return peNckbfK7s;
		}
		[CompilerGenerated]
		set
		{
			peNckbfK7s = value;
		}
	}

	public string AudienceRating
	{
		[CompilerGenerated]
		get
		{
			return dVBco4cPLh;
		}
		[CompilerGenerated]
		set
		{
			dVBco4cPLh = value;
		}
	}

	public string AudienceRatingString
	{
		[CompilerGenerated]
		get
		{
			return yvUcK41ywO;
		}
		[CompilerGenerated]
		set
		{
			yvUcK41ywO = value;
		}
	}

	public string PlotEn
	{
		[CompilerGenerated]
		get
		{
			return HIScgUhBHV;
		}
		[CompilerGenerated]
		set
		{
			HIScgUhBHV = value;
		}
	}

	public string PlotAr
	{
		[CompilerGenerated]
		get
		{
			return E6ZcWKum0m;
		}
		[CompilerGenerated]
		set
		{
			E6ZcWKum0m = value;
		}
	}

	public string Poster
	{
		[CompilerGenerated]
		get
		{
			return AvicfgnF2t;
		}
		[CompilerGenerated]
		set
		{
			AvicfgnF2t = value;
		}
	}

	public bool HasImage
	{
		[CompilerGenerated]
		get
		{
			return WtsczuQCaQ;
		}
		[CompilerGenerated]
		set
		{
			WtsczuQCaQ = value;
		}
	}

	public MediaCost MediaCost
	{
		[CompilerGenerated]
		get
		{
			return QKcaNX3kRn;
		}
		[CompilerGenerated]
		set
		{
			QKcaNX3kRn = value;
		}
	}

	public Status Status
	{
		[CompilerGenerated]
		get
		{
			return kUUaIdQ0mE;
		}
		[CompilerGenerated]
		set
		{
			kUUaIdQ0mE = value;
		}
	}

	public string IPrice
	{
		get
		{
			if (eYwQnKgD1HRLMjK2OyA.IB3tMMvyI(this, eYwQnKgD1HRLMjK2OyA.o5DgG84aCE) != MediaCost.Free)
			{
				int num = mkoNOjXNUCV3vRaLLm.IB3tMMvyI(this, mkoNOjXNUCV3vRaLLm.nFlghkmNsu);
				return cZxW16g8FZkmsm9YjOw.IB3tMMvyI(mPkiSYgyV3x29Cypvus.IB3tMMvyI(ref num, mPkiSYgyV3x29Cypvus.zFggox63qe), q2no0WnPxDaipZawxT.IB3tMMvyI(1862, q2no0WnPxDaipZawxT.eV4vC1LZv), cZxW16g8FZkmsm9YjOw.gKPgNWjGlg);
			}
			return q2no0WnPxDaipZawxT.IB3tMMvyI(1874, q2no0WnPxDaipZawxT.eV4vC1LZv);
		}
	}

	public bool IsRented
	{
		get
		{
			if (eYwQnKgD1HRLMjK2OyA.IB3tMMvyI(this, eYwQnKgD1HRLMjK2OyA.o5DgG84aCE) != MediaCost.Free)
			{
				return tZZjQygPfkFKLlxA1RF.IB3tMMvyI(this, tZZjQygPfkFKLlxA1RF.uPugAf0CnG) != null;
			}
			return true;
		}
	}

	public bool IsHot
	{
		[CompilerGenerated]
		get
		{
			return iHva3NgptN;
		}
		[CompilerGenerated]
		set
		{
			iHva3NgptN = value;
		}
	}

	public bool IsTest => jdQLk0gsk6KRMaAeZL9.IB3tMMvyI(this, jdQLk0gsk6KRMaAeZL9.rvPgxxq922) == Status.Test;

	public string Director
	{
		get
		{
			PersonResponseDto? personResponseDto = putgHmgzcLDJP5f2g7K.IB3tMMvyI(this, putgHmgzcLDJP5f2g7K.fCyLwc5agK).FirstOrDefault((PersonResponseDto x) => A2JuKtMn2OA3OCCE8Om.IB3tMMvyI(x, A2JuKtMn2OA3OCCE8Om.vhEMvIKgwe) == PersonType.Director);
			if (personResponseDto == null)
			{
				return null;
			}
			return BkFFwYmT10k6taWbxb.IB3tMMvyI(personResponseDto, BkFFwYmT10k6taWbxb.gHsLt572GG);
		}
	}

	public string Genres => string.Join(',', from x in t328VXLgiPM9pC3ijxi.IB3tMMvyI(this, t328VXLgiPM9pC3ijxi.iTFLLYuwfY)
		select BkFFwYmT10k6taWbxb.IB3tMMvyI(x, BkFFwYmT10k6taWbxb.VdxMMUKXDC));

	public string Actors => J3CJMhLVJ89ZtSeR2sd.IB3tMMvyI(q2no0WnPxDaipZawxT.IB3tMMvyI(1886, q2no0WnPxDaipZawxT.eV4vC1LZv), from x in putgHmgzcLDJP5f2g7K.IB3tMMvyI(this, putgHmgzcLDJP5f2g7K.fCyLwc5agK)
		where A2JuKtMn2OA3OCCE8Om.IB3tMMvyI(x, A2JuKtMn2OA3OCCE8Om.vhEMvIKgwe) == PersonType.Actor
		select NvW2urM9Ym8IV8H6Y8I.IB3tMMvyI(x, NvW2urM9Ym8IV8H6Y8I.xwTMjOnvUB), J3CJMhLVJ89ZtSeR2sd.WTrLSt5MgN);

	public double IMDBScore
	{
		[CompilerGenerated]
		get
		{
			return FB9aygHkiZ;
		}
		[CompilerGenerated]
		set
		{
			FB9aygHkiZ = value;
		}
	}

	public double PROTVScore
	{
		[CompilerGenerated]
		get
		{
			return ptUaFeoyVe;
		}
		[CompilerGenerated]
		set
		{
			ptUaFeoyVe = value;
		}
	}

	public int PROTVScoreCount
	{
		[CompilerGenerated]
		get
		{
			return FMmacY7aRF;
		}
		[CompilerGenerated]
		set
		{
			FMmacY7aRF = value;
		}
	}

	public double PROTVTotalScore
	{
		[CompilerGenerated]
		get
		{
			return A4paa3Ivji;
		}
		[CompilerGenerated]
		set
		{
			A4paa3Ivji = value;
		}
	}

	public string IMDBLink
	{
		[CompilerGenerated]
		get
		{
			return iCJaPaxalv;
		}
		[CompilerGenerated]
		set
		{
			iCJaPaxalv = value;
		}
	}

	public string Tags
	{
		[CompilerGenerated]
		get
		{
			return OIdatoPsAB;
		}
		[CompilerGenerated]
		set
		{
			OIdatoPsAB = value;
		}
	}

	public int Price
	{
		[CompilerGenerated]
		get
		{
			return MT3ajWR0hp;
		}
		[CompilerGenerated]
		set
		{
			MT3ajWR0hp = value;
		}
	}

	public int FavoriteCount
	{
		[CompilerGenerated]
		get
		{
			return mdfa5pF2ZE;
		}
		[CompilerGenerated]
		set
		{
			mdfa5pF2ZE = value;
		}
	}

	public int WatchCount
	{
		[CompilerGenerated]
		get
		{
			return zCEal7EE9D;
		}
		[CompilerGenerated]
		set
		{
			zCEal7EE9D = value;
		}
	}

	public int RentCount
	{
		[CompilerGenerated]
		get
		{
			return JLiahAhAcj;
		}
		[CompilerGenerated]
		set
		{
			JLiahAhAcj = value;
		}
	}

	public string TrailerUrl
	{
		[CompilerGenerated]
		get
		{
			return gRsa2SH6qb;
		}
		[CompilerGenerated]
		set
		{
			gRsa2SH6qb = value;
		}
	}

	public Language Language
	{
		[CompilerGenerated]
		get
		{
			return jaaaBmaGRO;
		}
		[CompilerGenerated]
		set
		{
			jaaaBmaGRO = value;
		}
	}

	public LanguageAr LanguageAr
	{
		[CompilerGenerated]
		get
		{
			return RqgaUkZTYH;
		}
		[CompilerGenerated]
		set
		{
			RqgaUkZTYH = value;
		}
	}

	public bool AlreadyWatched
	{
		[CompilerGenerated]
		get
		{
			return DZma1hTh0U;
		}
		[CompilerGenerated]
		set
		{
			DZma1hTh0U = value;
		}
	}

	public bool IsFavorite
	{
		[CompilerGenerated]
		get
		{
			return iZWa8Y8BvL;
		}
		[CompilerGenerated]
		set
		{
			iZWa8Y8BvL = value;
		}
	}

	public double Hottness
	{
		[CompilerGenerated]
		get
		{
			return UwqaEZeNC5;
		}
		[CompilerGenerated]
		set
		{
			UwqaEZeNC5 = value;
		}
	}

	public bool IsNew
	{
		[CompilerGenerated]
		get
		{
			return FxBaY5kOt8;
		}
		[CompilerGenerated]
		set
		{
			FxBaY5kOt8 = value;
		}
	}

	public double IMDBPopularity
	{
		[CompilerGenerated]
		get
		{
			return OwSaDiQbwy;
		}
		[CompilerGenerated]
		set
		{
			OwSaDiQbwy = value;
		}
	}

	public RentResponseDto Rent
	{
		[CompilerGenerated]
		get
		{
			return y0ja4anqRx;
		}
		[CompilerGenerated]
		set
		{
			y0ja4anqRx = value;
		}
	}

	public RateResponseDto Rate
	{
		[CompilerGenerated]
		get
		{
			return nVuaidmocI;
		}
		[CompilerGenerated]
		set
		{
			nVuaidmocI = value;
		}
	}

	public IEnumerable<LinkResponseDto> MovieLinks
	{
		[CompilerGenerated]
		get
		{
			return aCpaO61vW9;
		}
		[CompilerGenerated]
		set
		{
			aCpaO61vW9 = value;
		}
	}

	public IEnumerable<SubtitleResponseDto> Subtitles
	{
		[CompilerGenerated]
		get
		{
			return GMKartp9fO;
		}
		[CompilerGenerated]
		set
		{
			GMKartp9fO = value;
		}
	}

	public IEnumerable<CategoryResponseDto> Categories
	{
		[CompilerGenerated]
		get
		{
			return v5maHaUgHR;
		}
		[CompilerGenerated]
		set
		{
			v5maHaUgHR = value;
		}
	}

	public IEnumerable<int> PlayLists
	{
		[CompilerGenerated]
		get
		{
			return IFIavensvj;
		}
		[CompilerGenerated]
		set
		{
			IFIavensvj = value;
		}
	}

	public List<PersonResponseDto> Persons
	{
		[CompilerGenerated]
		get
		{
			return cyLaAb3ZYP;
		}
		[CompilerGenerated]
		set
		{
			cyLaAb3ZYP = value;
		}
	}

	public event PropertyChangedEventHandler PropertyChanged
	{
		[CompilerGenerated]
		add
		{
			PropertyChangedEventHandler propertyChangedEventHandler = Kf6auMWqtL;
			PropertyChangedEventHandler propertyChangedEventHandler2;
			do
			{
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)RPEU3egXGZVvhTR6XmH.IB3tMMvyI(propertyChangedEventHandler2, value, RPEU3egXGZVvhTR6XmH.s2kgFOJ4Ul);
				propertyChangedEventHandler = Interlocked.CompareExchange(ref Kf6auMWqtL, value2, propertyChangedEventHandler2);
			}
			while ((object)propertyChangedEventHandler != propertyChangedEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			PropertyChangedEventHandler propertyChangedEventHandler = Kf6auMWqtL;
			PropertyChangedEventHandler propertyChangedEventHandler2;
			do
			{
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)RPEU3egXGZVvhTR6XmH.IB3tMMvyI(propertyChangedEventHandler2, value, RPEU3egXGZVvhTR6XmH.SMVg0oDlbE);
				propertyChangedEventHandler = Interlocked.CompareExchange(ref Kf6auMWqtL, value2, propertyChangedEventHandler2);
			}
			while ((object)propertyChangedEventHandler != propertyChangedEventHandler2);
		}
	}

	public MovieResponseDto()
	{
		uiiVNagWnDNnTWnFgq.IB3tMMvyI(uiiVNagWnDNnTWnFgq.JyKLgPcm8);
		base._002Ector();
		Q47M0hgElogUpLE5aKM.IB3tMMvyI(this, MediaType.Movie, Q47M0hgElogUpLE5aKM.F7Hg4Cy634);
	}

	public virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
	{
		Kf6auMWqtL?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}

	public override bool Equals(object obj)
	{
		if (obj is MovieResponseDto movieResponseDto)
		{
			return mkoNOjXNUCV3vRaLLm.IB3tMMvyI(this, mkoNOjXNUCV3vRaLLm.bYELn2G4XC) == mkoNOjXNUCV3vRaLLm.IB3tMMvyI(movieResponseDto, mkoNOjXNUCV3vRaLLm.SbwLvyaW7b);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
