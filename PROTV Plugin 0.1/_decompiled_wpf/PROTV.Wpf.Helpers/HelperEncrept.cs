using System;
using System.IO;
using System.Security.Cryptography;

namespace PROTV.Wpf.Helpers;

public class HelperEncrept
{
	private static readonly byte[] n15GXF610S;

	private static readonly string EgSGRGcl5g;

	private static readonly string F5VGwZYJPZ;

	private static readonly int Count;

	public static string EncryptAndEncode(string raw, string AllPASSWORD)
	{
		AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider();
		try
		{
			AllPASSWORD = UwSEfC4rh9eVlFenwI.D35lls5iF(EgSGRGcl5g, AllPASSWORD, UwSEfC4rh9eVlFenwI.BPNLUJNA3);
			ICryptoTransform cryptoTransform = zj1b2sRrRKqXfF0rcjh.D35lls5iF(aesCryptoServiceProvider, true, AllPASSWORD, zj1b2sRrRKqXfF0rcjh.G6vReqxfGJ);
			byte[] array = SYvbnKRk055cWnMx4YQ.D35lls5iF(sjFeCoRGct57rx6qqsq.D35lls5iF(sjFeCoRGct57rx6qqsq.m74RRhQ7CQ), raw, SYvbnKRk055cWnMx4YQ.pKRRvagSTI);
			return eUH8NORpR5UuRRQKq9L.D35lls5iF(pWrglvRAFWdEtwYacKn.D35lls5iF(cryptoTransform, array, 0, array.Length, pWrglvRAFWdEtwYacKn.mVwR6gIxQE), eUH8NORpR5UuRRQKq9L.DltRw7jd5Z);
		}
		finally
		{
			if (aesCryptoServiceProvider != null)
			{
				xLO56JniGyickVjO1Ot.D35lls5iF(aesCryptoServiceProvider, xLO56JniGyickVjO1Ot.ydbT2bsoH4);
			}
		}
	}

	public static string DecodeAndDecrypt(string encrypted, string AllPASSWORD)
	{
		AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider();
		try
		{
			AllPASSWORD = UwSEfC4rh9eVlFenwI.D35lls5iF(EgSGRGcl5g, AllPASSWORD, UwSEfC4rh9eVlFenwI.BPNLUJNA3);
			ICryptoTransform cryptoTransform = zj1b2sRrRKqXfF0rcjh.D35lls5iF(aesCryptoServiceProvider, false, AllPASSWORD, zj1b2sRrRKqXfF0rcjh.G6vReqxfGJ);
			byte[] array = YpZO39RCs2YAiWpqcqU.D35lls5iF(encrypted, YpZO39RCs2YAiWpqcqU.XjWRmLHYfa);
			byte[] array2 = pWrglvRAFWdEtwYacKn.D35lls5iF(cryptoTransform, array, 0, array.Length, pWrglvRAFWdEtwYacKn.mVwR6gIxQE);
			return pPftbKRatUfMFLXTkKi.D35lls5iF(sjFeCoRGct57rx6qqsq.D35lls5iF(sjFeCoRGct57rx6qqsq.m74RRhQ7CQ), array2, pPftbKRatUfMFLXTkKi.eqNRIuawad);
		}
		finally
		{
			if (aesCryptoServiceProvider != null)
			{
				xLO56JniGyickVjO1Ot.D35lls5iF(aesCryptoServiceProvider, xLO56JniGyickVjO1Ot.ydbT2bsoH4);
			}
		}
	}

	private static ICryptoTransform tqtGmK2VSY(AesCryptoServiceProvider P_0, bool P_1, string P_2)
	{
		vktYr6Rdob1AYwsJnve.D35lls5iF(P_0, CipherMode.CBC, vktYr6Rdob1AYwsJnve.qVeRUq7PPo);
		rV0VXhRtjjgeDkoimG0.D35lls5iF(P_0, PaddingMode.PKCS7, rV0VXhRtjjgeDkoimG0.rVVRVfY4mg);
		byte[] array = vVd6i3R7Z7LxSQ8TAQl.D35lls5iF(new Rfc2898DeriveBytes(SYvbnKRk055cWnMx4YQ.D35lls5iF(sjFeCoRGct57rx6qqsq.D35lls5iF(sjFeCoRGct57rx6qqsq.m74RRhQ7CQ), P_2, SYvbnKRk055cWnMx4YQ.pKRRvagSTI), SYvbnKRk055cWnMx4YQ.D35lls5iF(sjFeCoRGct57rx6qqsq.D35lls5iF(sjFeCoRGct57rx6qqsq.m74RRhQ7CQ), F5VGwZYJPZ, SYvbnKRk055cWnMx4YQ.pKRRvagSTI), Count), 16, vVd6i3R7Z7LxSQ8TAQl.Y1vRcHF80X);
		CJINIjRMMuX7RwXOnHY.D35lls5iF(P_0, n15GXF610S, CJINIjRMMuX7RwXOnHY.I7MRSoHoU7);
		CJINIjRMMuX7RwXOnHY.D35lls5iF(P_0, array, CJINIjRMMuX7RwXOnHY.oG2RKIIsIX);
		if (P_1)
		{
			return Dq3MQBRNnCV9AgfDnOc.D35lls5iF(P_0, Dq3MQBRNnCV9AgfDnOc.j8ERO8JJiv);
		}
		return Dq3MQBRNnCV9AgfDnOc.D35lls5iF(P_0, Dq3MQBRNnCV9AgfDnOc.h6kRuWCGZy);
	}

	public static byte[] Encrypt(byte[] input)
	{
		string strPassword = iFZ5je3XFYKwkvcE5D.D35lls5iF(14748, iFZ5je3XFYKwkvcE5D.N06TeK0ao);
		byte[] array = new byte[4];
		ODLiVRlRE2AwTHTxA2m.D35lls5iF(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, ODLiVRlRE2AwTHTxA2m.rwklk7wPqp);
		PasswordDeriveBytes passwordDeriveBytes = new PasswordDeriveBytes(strPassword, array);
		MemoryStream memoryStream = new MemoryStream();
		Aes aes = new AesManaged();
		CJINIjRMMuX7RwXOnHY.D35lls5iF(aes, vVd6i3R7Z7LxSQ8TAQl.D35lls5iF(passwordDeriveBytes, m9MGZR7k2RmVqYXYS5.D35lls5iF(aes, m9MGZR7k2RmVqYXYS5.TlNRPvTiZq) / 8, vVd6i3R7Z7LxSQ8TAQl.Y1vRcHF80X), CJINIjRMMuX7RwXOnHY.oG2RKIIsIX);
		CJINIjRMMuX7RwXOnHY.D35lls5iF(aes, vVd6i3R7Z7LxSQ8TAQl.D35lls5iF(passwordDeriveBytes, m9MGZR7k2RmVqYXYS5.D35lls5iF(aes, m9MGZR7k2RmVqYXYS5.INtRsZd97N) / 8, vVd6i3R7Z7LxSQ8TAQl.Y1vRcHF80X), CJINIjRMMuX7RwXOnHY.I7MRSoHoU7);
		CryptoStream cryptoStream = new CryptoStream(memoryStream, Dq3MQBRNnCV9AgfDnOc.D35lls5iF(aes, Dq3MQBRNnCV9AgfDnOc.j8ERO8JJiv), CryptoStreamMode.Write);
		p97GSeRhlaODASYiQKx.D35lls5iF(cryptoStream, input, 0, input.Length, p97GSeRhlaODASYiQKx.hJHRxFH5pZ);
		fp757nBYjo8889efKFJ.D35lls5iF(cryptoStream, fp757nBYjo8889efKFJ.FtaRYuumDU);
		return NaFm6SRgM2ttOuFVF8H.D35lls5iF(memoryStream, NaFm6SRgM2ttOuFVF8H.G2SRivSDZ3);
	}

	public static byte[] Decrypt(byte[] input)
	{
		string strPassword = iFZ5je3XFYKwkvcE5D.D35lls5iF(14748, iFZ5je3XFYKwkvcE5D.N06TeK0ao);
		byte[] array = new byte[4];
		ODLiVRlRE2AwTHTxA2m.D35lls5iF(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, ODLiVRlRE2AwTHTxA2m.rwklk7wPqp);
		PasswordDeriveBytes passwordDeriveBytes = new PasswordDeriveBytes(strPassword, array);
		MemoryStream memoryStream = new MemoryStream();
		Aes aes = new AesManaged();
		CJINIjRMMuX7RwXOnHY.D35lls5iF(aes, vVd6i3R7Z7LxSQ8TAQl.D35lls5iF(passwordDeriveBytes, m9MGZR7k2RmVqYXYS5.D35lls5iF(aes, m9MGZR7k2RmVqYXYS5.TlNRPvTiZq) / 8, vVd6i3R7Z7LxSQ8TAQl.Y1vRcHF80X), CJINIjRMMuX7RwXOnHY.oG2RKIIsIX);
		CJINIjRMMuX7RwXOnHY.D35lls5iF(aes, vVd6i3R7Z7LxSQ8TAQl.D35lls5iF(passwordDeriveBytes, m9MGZR7k2RmVqYXYS5.D35lls5iF(aes, m9MGZR7k2RmVqYXYS5.INtRsZd97N) / 8, vVd6i3R7Z7LxSQ8TAQl.Y1vRcHF80X), CJINIjRMMuX7RwXOnHY.I7MRSoHoU7);
		CryptoStream cryptoStream = new CryptoStream(memoryStream, Dq3MQBRNnCV9AgfDnOc.D35lls5iF(aes, Dq3MQBRNnCV9AgfDnOc.h6kRuWCGZy), CryptoStreamMode.Write);
		p97GSeRhlaODASYiQKx.D35lls5iF(cryptoStream, input, 0, input.Length, p97GSeRhlaODASYiQKx.hJHRxFH5pZ);
		fp757nBYjo8889efKFJ.D35lls5iF(cryptoStream, fp757nBYjo8889efKFJ.FtaRYuumDU);
		return NaFm6SRgM2ttOuFVF8H.D35lls5iF(memoryStream, NaFm6SRgM2ttOuFVF8H.G2SRivSDZ3);
	}

	public HelperEncrept()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector();
	}

	static HelperEncrept()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		byte[] array = new byte[16];
		ODLiVRlRE2AwTHTxA2m.D35lls5iF(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, ODLiVRlRE2AwTHTxA2m.rwklk7wPqp);
		n15GXF610S = array;
		EgSGRGcl5g = iFZ5je3XFYKwkvcE5D.D35lls5iF(14774, iFZ5je3XFYKwkvcE5D.N06TeK0ao);
		F5VGwZYJPZ = iFZ5je3XFYKwkvcE5D.D35lls5iF(14808, iFZ5je3XFYKwkvcE5D.N06TeK0ao);
		Count = 64;
	}
}
