using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PROTV.Wpf.Helpers;

public static class FileCache
{
	public enum CacheMode
	{
		WinINet,
		Dedicated
	}

	private static readonly Dictionary<string, bool> SflGpYDYhc;

	[CompilerGenerated]
	private static string uQqGitb0wa;

	[CompilerGenerated]
	private static CacheMode QKPG3My90s;

	public static string AppCacheDirectory
	{
		[CompilerGenerated]
		get
		{
			return uQqGitb0wa;
		}
		[CompilerGenerated]
		set
		{
			uQqGitb0wa = value;
		}
	}

	public static CacheMode AppCacheMode
	{
		[CompilerGenerated]
		get
		{
			return QKPG3My90s;
		}
		[CompilerGenerated]
		set
		{
			QKPG3My90s = value;
		}
	}

	static FileCache()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		SflGpYDYhc = new Dictionary<string, bool>();
		iEiFM8eVSwxJTPFVS0.D35lls5iF(sydk2oeOgdj2VAxhwQj.D35lls5iF(iFZ5je3XFYKwkvcE5D.D35lls5iF(14716, iFZ5je3XFYKwkvcE5D.N06TeK0ao), Environment.GetFolderPath(Environment.SpecialFolder.Personal), QQLie3eYkZwbFFm9Jjw.D35lls5iF(uoE9NyRTDnK1XbF0YaK.D35lls5iF(uoE9NyRTDnK1XbF0YaK.tlsR4ubuiJ), QQLie3eYkZwbFFm9Jjw.GjsRLagEOd), sydk2oeOgdj2VAxhwQj.fAWeuB9Bfq), iEiFM8eVSwxJTPFVS0.J2pREUF8Jq);
		rJUfBlRBevMkxNuOeLy.D35lls5iF(CacheMode.Dedicated, rJUfBlRBevMkxNuOeLy.GZVR0fXwlR);
	}

	public static async Task<MemoryStream> HitAsync(string url)
	{
		if (!M6ZErPEr2LZyWYpa5O.D35lls5iF(CrrEFrkdve0aLZsgajd.D35lls5iF(CrrEFrkdve0aLZsgajd.Bh7t2mUBvr), M6ZErPEr2LZyWYpa5O.vqqBpLiOe))
		{
			gM00OS0Iir9SCS8q6P.D35lls5iF(CrrEFrkdve0aLZsgajd.D35lls5iF(CrrEFrkdve0aLZsgajd.Bh7t2mUBvr), gM00OS0Iir9SCS8q6P.RKarZUs3s);
		}
		Uri uri = new Uri(url);
		StringBuilder stringBuilder = new StringBuilder();
		SHA1Managed sHA1Managed = new SHA1Managed();
		try
		{
			string text = wq2usy8gNndpuTw5mR.D35lls5iF(uri, wq2usy8gNndpuTw5mR.ajcDe8nffb);
			byte[] array = tIHAy8tZoOn1lQJdcWg.D35lls5iF(sHA1Managed, SYvbnKRk055cWnMx4YQ.D35lls5iF(sjFeCoRGct57rx6qqsq.D35lls5iF(sjFeCoRGct57rx6qqsq.m74RRhQ7CQ), text, SYvbnKRk055cWnMx4YQ.pKRRvagSTI), tIHAy8tZoOn1lQJdcWg.tnrtjfvflj);
			Iqu9Z2D0u6duXqVdeBe.D35lls5iF(stringBuilder, eVlRnEIaHT0dqvCx0Kx.D35lls5iF(qkk1pmaqjfrxm6HMLRO.D35lls5iF(eUH8NORpR5UuRRQKq9L.D35lls5iF(array, eUH8NORpR5UuRRQKq9L.JPRty5kvIN), iFZ5je3XFYKwkvcE5D.D35lls5iF(16976, iFZ5je3XFYKwkvcE5D.N06TeK0ao), "", qkk1pmaqjfrxm6HMLRO.FEAaJveLhR), eVlRnEIaHT0dqvCx0Kx.PLmIIMWEZ7), Iqu9Z2D0u6duXqVdeBe.No5DrBqXtD);
			if (M6ZErPEr2LZyWYpa5O.D35lls5iF(text, M6ZErPEr2LZyWYpa5O.HmqtqrKflj))
			{
				Iqu9Z2D0u6duXqVdeBe.D35lls5iF(stringBuilder, vr2NVdDHkMwed7KwMIr.D35lls5iF(text, vr2NVdDHkMwed7KwMIr.ou8tJiRXfE), Iqu9Z2D0u6duXqVdeBe.No5DrBqXtD);
			}
		}
		finally
		{
			if (sHA1Managed != null)
			{
				xLO56JniGyickVjO1Ot.D35lls5iF(sHA1Managed, xLO56JniGyickVjO1Ot.ydbT2bsoH4);
			}
		}
		string fileName = wq2usy8gNndpuTw5mR.D35lls5iF(stringBuilder, wq2usy8gNndpuTw5mR.ajcDe8nffb);
		string localFile = sydk2oeOgdj2VAxhwQj.D35lls5iF(iFZ5je3XFYKwkvcE5D.D35lls5iF(16982, iFZ5je3XFYKwkvcE5D.N06TeK0ao), CrrEFrkdve0aLZsgajd.D35lls5iF(CrrEFrkdve0aLZsgajd.Bh7t2mUBvr), fileName, sydk2oeOgdj2VAxhwQj.fAWeuB9Bfq);
		MemoryStream memoryStream = new MemoryStream();
		M6ZErPEr2LZyWYpa5O.D35lls5iF(localFile, M6ZErPEr2LZyWYpa5O.WPpnHj4Wcq);
		if (!SflGpYDYhc.ContainsKey(fileName) && M6ZErPEr2LZyWYpa5O.D35lls5iF(localFile, M6ZErPEr2LZyWYpa5O.WPpnHj4Wcq))
		{
			return new MemoryStream(await d6NZrBtbA8aVOeBIPT4.D35lls5iF(localFile, default(CancellationToken), d6NZrBtbA8aVOeBIPT4.l39tWgyNtc));
		}
		try
		{
			WebRequest webRequest = ACq5Wlt5pUqZUDhYp7k.D35lls5iF(uri, ACq5Wlt5pUqZUDhYp7k.jBctz5KZmo);
			vQKA0r9sJ1kArsIHc16.D35lls5iF(webRequest, 30000, vQKA0r9sJ1kArsIHc16.tCcVonT6rB);
			Stream responseStream = OKeoxmVDZqaoQR1uZZO.D35lls5iF(await gbYCnkVlgq3VbxPD8IF.D35lls5iF(webRequest, gbYCnkVlgq3VbxPD8IF.xBWV9IGVKg), OKeoxmVDZqaoQR1uZZO.NmtVHg1wyl);
			if (responseStream == null)
			{
				return null;
			}
			Stream stream = responseStream;
			try
			{
				byte[] bytebuffer = new byte[4096];
				int bytesRead;
				TaskAwaiter taskAwaiter2 = default(TaskAwaiter);
				do
				{
					bytesRead = await sedW2DV1NXpPWCplRfn.D35lls5iF(responseStream, bytebuffer, 0, 4096, sedW2DV1NXpPWCplRfn.o29V8bVxMF);
					TaskAwaiter taskAwaiter = QliBEUviwWqgtMcBndV.D35lls5iF(dRsk3fVn1g1LM7EcDAW.D35lls5iF(memoryStream, bytebuffer, 0, bytesRead, dRsk3fVn1g1LM7EcDAW.FogV3lopIg), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
					if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref taskAwaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
					{
						await taskAwaiter;
						taskAwaiter = taskAwaiter2;
						taskAwaiter2 = default(TaskAwaiter);
					}
					oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref taskAwaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
				}
				while (bytesRead > 0);
				if (!SflGpYDYhc.ContainsKey(fileName))
				{
					SflGpYDYhc[fileName] = true;
					TaskAwaiter taskAwaiter = QliBEUviwWqgtMcBndV.D35lls5iF(cGcAwRV4sfuZyHM7eFf.D35lls5iF(localFile, NaFm6SRgM2ttOuFVF8H.D35lls5iF(memoryStream, NaFm6SRgM2ttOuFVF8H.lC6VTbYZSr), default(CancellationToken), cGcAwRV4sfuZyHM7eFf.dW1VLI6UTu), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
					if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref taskAwaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
					{
						await taskAwaiter;
						taskAwaiter = taskAwaiter2;
					}
					oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref taskAwaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
				}
				SflGpYDYhc.Remove(fileName);
			}
			finally
			{
				if (stream != null)
				{
					xLO56JniGyickVjO1Ot.D35lls5iF(stream, xLO56JniGyickVjO1Ot.ydbT2bsoH4);
				}
			}
			jBZIB9VEKrTDdPZV9Eu.D35lls5iF(memoryStream, 0L, SeekOrigin.Begin, jBZIB9VEKrTDdPZV9Eu.K6tVB4OBXG);
			return memoryStream;
		}
		catch (WebException)
		{
			return null;
		}
		catch
		{
			return null;
		}
	}
}
