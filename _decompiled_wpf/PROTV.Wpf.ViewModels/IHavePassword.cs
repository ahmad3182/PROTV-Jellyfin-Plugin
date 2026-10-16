using System.Security;

namespace PROTV.Wpf.ViewModels;

public interface IHavePassword
{
	SecureString SecurePassword { get; }
}
