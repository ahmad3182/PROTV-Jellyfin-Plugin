using System.Windows;
using System.Windows.Controls;
using PROTV.Abstractions.Common;
using PROTV.Abstractions.DataTransferObjects;

namespace PROTV.Wpf.Helpers;

public class MedaiItemDataTemplateSelector : DataTemplateSelector
{
	public override DataTemplate SelectTemplate(object item, DependencyObject container)
	{
		if (container is FrameworkElement frameworkElement && item != null && item is BaseMediaDto baseMediaDto)
		{
			return UOCWOF1pc2UOe4PjABW.D35lls5iF(baseMediaDto, UOCWOF1pc2UOe4PjABW.TuV1w2E8GR) switch
			{
				MediaType.Movie => auEPOZ1NWYKXdU711jq.D35lls5iF(frameworkElement, iFZ5je3XFYKwkvcE5D.D35lls5iF(14946, iFZ5je3XFYKwkvcE5D.N06TeK0ao), auEPOZ1NWYKXdU711jq.eslkoZcu5U) as DataTemplate, 
				MediaType.Series => auEPOZ1NWYKXdU711jq.D35lls5iF(frameworkElement, iFZ5je3XFYKwkvcE5D.D35lls5iF(14984, iFZ5je3XFYKwkvcE5D.N06TeK0ao), auEPOZ1NWYKXdU711jq.eslkoZcu5U) as DataTemplate, 
				MediaType.Season => auEPOZ1NWYKXdU711jq.D35lls5iF(frameworkElement, iFZ5je3XFYKwkvcE5D.D35lls5iF(15024, iFZ5je3XFYKwkvcE5D.N06TeK0ao), auEPOZ1NWYKXdU711jq.eslkoZcu5U) as DataTemplate, 
				MediaType.Episode => auEPOZ1NWYKXdU711jq.D35lls5iF(frameworkElement, iFZ5je3XFYKwkvcE5D.D35lls5iF(15064, iFZ5je3XFYKwkvcE5D.N06TeK0ao), auEPOZ1NWYKXdU711jq.eslkoZcu5U) as DataTemplate, 
				MediaType.Person => auEPOZ1NWYKXdU711jq.D35lls5iF(frameworkElement, iFZ5je3XFYKwkvcE5D.D35lls5iF(15106, iFZ5je3XFYKwkvcE5D.N06TeK0ao), auEPOZ1NWYKXdU711jq.eslkoZcu5U) as DataTemplate, 
				MediaType.Album => auEPOZ1NWYKXdU711jq.D35lls5iF(frameworkElement, iFZ5je3XFYKwkvcE5D.D35lls5iF(15146, iFZ5je3XFYKwkvcE5D.N06TeK0ao), auEPOZ1NWYKXdU711jq.eslkoZcu5U) as DataTemplate, 
				MediaType.Song => auEPOZ1NWYKXdU711jq.D35lls5iF(frameworkElement, iFZ5je3XFYKwkvcE5D.D35lls5iF(15184, iFZ5je3XFYKwkvcE5D.N06TeK0ao), auEPOZ1NWYKXdU711jq.eslkoZcu5U) as DataTemplate, 
				_ => null, 
			};
		}
		return null;
	}

	public MedaiItemDataTemplateSelector()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector();
	}
}
