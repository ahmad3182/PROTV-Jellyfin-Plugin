using System.Runtime.CompilerServices;

namespace PROTV.Wpf.ViewModels;

public abstract class BaseVideoPlayerViewModel : BaseViewModel
{
	[CompilerGenerated]
	private readonly VideoPlayerViewModel OBL4ARlgh2;

	public VideoPlayerViewModel Root
	{
		[CompilerGenerated]
		get
		{
			return OBL4ARlgh2;
		}
	}

	protected BaseVideoPlayerViewModel(VideoPlayerViewModel root)
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector();
		OBL4ARlgh2 = root;
	}

	public virtual void OnApplicationLoaded()
	{
	}
}
