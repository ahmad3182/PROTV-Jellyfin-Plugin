using System.Runtime.CompilerServices;

namespace PROTV.Wpf.ViewModels;

public abstract class AttachedViewModel<T> : BaseViewModel where T : new()
{
	[CompilerGenerated]
	private readonly FFMEBaseViewModel<T> medIcskKKG;

	public FFMEBaseViewModel<T> Root
	{
		[CompilerGenerated]
		get
		{
			return medIcskKKG;
		}
	}

	protected AttachedViewModel(FFMEBaseViewModel<T> root)
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector();
		medIcskKKG = root;
	}

	public virtual void OnApplicationLoaded()
	{
	}
}
