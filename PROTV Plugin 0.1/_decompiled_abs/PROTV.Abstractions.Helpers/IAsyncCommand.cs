using System.Threading.Tasks;
using System.Windows.Input;

namespace PROTV.Abstractions.Helpers;

public interface IAsyncCommand<T> : ICommand
{
	Task ExecuteAsync(T parameter);

	void RaiseCanExecuteChanged();
}
public interface IAsyncCommand : ICommand
{
	Task ExecuteAsync();

	void RaiseCanExecuteChanged();
}
