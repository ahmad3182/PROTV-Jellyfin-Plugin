using System.Collections.Generic;
using System.Runtime.CompilerServices;
using PROTV.Abstractions.DataTransferObjects;

namespace PROTV.Wpf.ViewModels;

public class EntertainmentItemModel<T> : BaseViewModel where T : BaseMediaDto
{
	[CompilerGenerated]
	private List<MedaiListItemModel<T>> qyQBlsDZrI;

	[CompilerGenerated]
	private List<GalleryImageResponseDto> AxGBU10AMK;

	public List<MedaiListItemModel<T>> Items
	{
		[CompilerGenerated]
		get
		{
			return qyQBlsDZrI;
		}
		[CompilerGenerated]
		set
		{
			qyQBlsDZrI = value;
		}
	}

	public List<GalleryImageResponseDto> Gallaries
	{
		[CompilerGenerated]
		get
		{
			return AxGBU10AMK;
		}
		[CompilerGenerated]
		set
		{
			AxGBU10AMK = value;
		}
	}

	public EntertainmentItemModel()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector();
		Items = new List<MedaiListItemModel<T>>();
		Gallaries = new List<GalleryImageResponseDto>();
	}
}
