using System.Collections.Generic;
using System.Windows;

namespace PROTV.Wpf.Helpers;

public class VisualTreeAdapter : ILinqTree<DependencyObject>
{
	private DependencyObject q6TGeLLYdh;

	public DependencyObject Parent => Ay3UURGqrswmtonfScR.D35lls5iF(q6TGeLLYdh, Ay3UURGqrswmtonfScR.hMlGJudNiF);

	public VisualTreeAdapter(DependencyObject item)
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector();
		q6TGeLLYdh = item;
	}

	public IEnumerable<DependencyObject> Children()
	{
		int childrenCount = T9sNieeduAumIbMO43W.D35lls5iF(q6TGeLLYdh, T9sNieeduAumIbMO43W.YeDeUK3q8R);
		for (int i = 0; i < childrenCount; i++)
		{
			yield return tJmv7Vet2tiZMCree4E.D35lls5iF(q6TGeLLYdh, i, tJmv7Vet2tiZMCree4E.RWfeVmUdAF);
		}
	}
}
