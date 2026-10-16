using System.Collections.Generic;

namespace PROTV.Wpf.Helpers;

public interface ILinqTree<T>
{
	T Parent { get; }

	IEnumerable<T> Children();
}
