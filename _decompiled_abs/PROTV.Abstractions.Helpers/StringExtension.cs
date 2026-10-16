using System.Net.NetworkInformation;
using System.Threading.Tasks;

namespace PROTV.Abstractions.Helpers;

public static class StringExtension
{
	public static bool IsNullOrEmpty(this string content)
	{
		return kNn8wecEBg33G3F6YN.IB3tMMvyI(content, kNn8wecEBg33G3F6YN.xTKte64Wkh);
	}

	public static bool IsNullOrWhiteSpace(this string content)
	{
		return kNn8wecEBg33G3F6YN.IB3tMMvyI(content, kNn8wecEBg33G3F6YN.OsAt3IVXo2);
	}

	public static async Task<bool> Ping(this string ip)
	{
		try
		{
			if (xOwIlNvaDIZWphE5ix0.IB3tMMvyI(await rgi9gkvYWgxflY0Dm8a.IB3tMMvyI(new Ping(), ip, rgi9gkvYWgxflY0Dm8a.bM0vDLDBX5), xOwIlNvaDIZWphE5ix0.zRevPRUSJv) == IPStatus.Success)
			{
				return true;
			}
			return false;
		}
		catch
		{
			return false;
		}
	}
}
