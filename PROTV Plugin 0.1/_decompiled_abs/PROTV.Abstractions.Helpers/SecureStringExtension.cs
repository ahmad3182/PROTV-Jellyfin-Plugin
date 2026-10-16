using System;
using System.Security;

namespace PROTV.Abstractions.Helpers;

public static class SecureStringExtension
{
	public static string UnSecure(this SecureString secureString)
	{
		if (secureString == null)
		{
			return string.Empty;
		}
		IntPtr intPtr = IntPtr.Zero;
		try
		{
			intPtr = QIxsgLt0ywjyGjpCRfS.IB3tMMvyI(secureString, QIxsgLt0ywjyGjpCRfS.jmttTcwhj6);
			return yKnJqutZcrTnNmL4CAB.IB3tMMvyI(intPtr, yKnJqutZcrTnNmL4CAB.Eeutu4SFAe);
		}
		finally
		{
			SNf7rmt2R4xQiSqWlWK.IB3tMMvyI(intPtr, SNf7rmt2R4xQiSqWlWK.i8tti7pVpB);
		}
	}
}
