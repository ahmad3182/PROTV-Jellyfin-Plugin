using System.Threading.Tasks;
using System.Windows.Input;

namespace PROTV.Abstractions.Helpers;

public interface IAsyncValueCommand<T> : ICommand
{
	ValueTask ExecuteAsync(T parameter);

	void RaiseCanExecuteChanged();
}
public interface IAsyncValueCommand : ICommand
{
	ValueTask ExecuteAsync();

	void RaiseCanExecuteChanged();
}
