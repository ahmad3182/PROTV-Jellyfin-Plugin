using System.Windows;
using System.Windows.Controls;
using PROTV.Wpf.ViewModels;

namespace PROTV.Wpf.Helpers;

public class LiveItemDataTemplateSelector : DataTemplateSelector
{
	public override DataTemplate SelectTemplate(object item, DependencyObject container)
	{
		if (container is FrameworkElement frameworkElement && item != null && item is VideoPlayerPlaylistItem videoPlayerPlaylistItem)
		{
			return xllcp23egxiMKQFcV8K.D35lls5iF(videoPlayerPlaylistItem, xllcp23egxiMKQFcV8K.w8jklxyeAB) switch
			{
				PlaylistItemType.TvChannel => auEPOZ1NWYKXdU711jq.D35lls5iF(frameworkElement, iFZ5je3XFYKwkvcE5D.D35lls5iF(15220, iFZ5je3XFYKwkvcE5D.N06TeK0ao), auEPOZ1NWYKXdU711jq.eslkoZcu5U) as DataTemplate, 
				PlaylistItemType.Movie => auEPOZ1NWYKXdU711jq.D35lls5iF(frameworkElement, iFZ5je3XFYKwkvcE5D.D35lls5iF(15270, iFZ5je3XFYKwkvcE5D.N06TeK0ao), auEPOZ1NWYKXdU711jq.eslkoZcu5U) as DataTemplate, 
				_ => null, 
			};
		}
		return null;
	}

	public LiveItemDataTemplateSelector()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector();
	}
}
