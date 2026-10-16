using System;
using System.Collections;
using System.IO;
using System.IO.IsolatedStorage;
using PROTV.Abstractions.DataTransferObjects;
using PROTV.Abstractions.Services;
using PROTV.Wpf.Bootstrap;

namespace PROTV.Wpf.Helpers;

public static class ApplicationExtensions
{
	public static void LoadProperties(this App app)
	{
		IsolatedStorageFile isf = b8wiorGUTKL3LA4p4jJ.D35lls5iF(b8wiorGUTKL3LA4p4jJ.gaoGtKyH2G);
		try
		{
			IsolatedStorageFileStream isolatedStorageFileStream = new IsolatedStorageFileStream(iFZ5je3XFYKwkvcE5D.D35lls5iF(14606, iFZ5je3XFYKwkvcE5D.N06TeK0ao), FileMode.Open, isf);
			try
			{
				StreamReader streamReader = new StreamReader(isolatedStorageFileStream);
				try
				{
					while (!uEUVCI48fycroqgRFqy.D35lls5iF(streamReader, uEUVCI48fycroqgRFqy.eoDGKEhioX))
					{
						string[] array = Hf410BG7Hkr4aQBuji3.D35lls5iF(QQLie3eYkZwbFFm9Jjw.D35lls5iF(streamReader, QQLie3eYkZwbFFm9Jjw.oZaGVHBBIj), new char[1] { ',' }, Hf410BG7Hkr4aQBuji3.XISGcU0uYT);
						EyxbpBGMcaXD02sIi7w.D35lls5iF(xrWtp71MaQsXtvtrqkf.D35lls5iF(app, xrWtp71MaQsXtvtrqkf.fxR1SMKb5A), array[0], array[1], EyxbpBGMcaXD02sIi7w.z9EGSdF6KF);
					}
				}
				finally
				{
					if (streamReader != null)
					{
						xLO56JniGyickVjO1Ot.D35lls5iF(streamReader, xLO56JniGyickVjO1Ot.ydbT2bsoH4);
					}
				}
			}
			finally
			{
				if (isolatedStorageFileStream != null)
				{
					xLO56JniGyickVjO1Ot.D35lls5iF(isolatedStorageFileStream, xLO56JniGyickVjO1Ot.ydbT2bsoH4);
				}
			}
			if (!GmMLaTD7kV8rq88ZFvR.D35lls5iF(xrWtp71MaQsXtvtrqkf.D35lls5iF(app, xrWtp71MaQsXtvtrqkf.fxR1SMKb5A), iFZ5je3XFYKwkvcE5D.D35lls5iF(14642, iFZ5je3XFYKwkvcE5D.N06TeK0ao), GmMLaTD7kV8rq88ZFvR.VGG1KpDfXX))
			{
				EyxbpBGMcaXD02sIi7w.D35lls5iF(xrWtp71MaQsXtvtrqkf.D35lls5iF(app, xrWtp71MaQsXtvtrqkf.fxR1SMKb5A), iFZ5je3XFYKwkvcE5D.D35lls5iF(14642, iFZ5je3XFYKwkvcE5D.N06TeK0ao), AJWZAgGN6JsveNQ5b3f.D35lls5iF(AJWZAgGN6JsveNQ5b3f.m11GOl5vbN), EyxbpBGMcaXD02sIi7w.y9uGuhNJgc);
			}
		}
		catch
		{
			if (!GmMLaTD7kV8rq88ZFvR.D35lls5iF(xrWtp71MaQsXtvtrqkf.D35lls5iF(app, xrWtp71MaQsXtvtrqkf.fxR1SMKb5A), iFZ5je3XFYKwkvcE5D.D35lls5iF(14642, iFZ5je3XFYKwkvcE5D.N06TeK0ao), GmMLaTD7kV8rq88ZFvR.VGG1KpDfXX))
			{
				EyxbpBGMcaXD02sIi7w.D35lls5iF(xrWtp71MaQsXtvtrqkf.D35lls5iF(app, xrWtp71MaQsXtvtrqkf.fxR1SMKb5A), iFZ5je3XFYKwkvcE5D.D35lls5iF(14642, iFZ5je3XFYKwkvcE5D.N06TeK0ao), AJWZAgGN6JsveNQ5b3f.D35lls5iF(AJWZAgGN6JsveNQ5b3f.m11GOl5vbN), EyxbpBGMcaXD02sIi7w.y9uGuhNJgc);
			}
		}
	}

	public static void SaveProperties(this App app)
	{
		IsolatedStorageFile isf = b8wiorGUTKL3LA4p4jJ.D35lls5iF(b8wiorGUTKL3LA4p4jJ.gaoGtKyH2G);
		IsolatedStorageFileStream isolatedStorageFileStream = new IsolatedStorageFileStream(iFZ5je3XFYKwkvcE5D.D35lls5iF(14606, iFZ5je3XFYKwkvcE5D.N06TeK0ao), FileMode.Create, isf);
		try
		{
			StreamWriter streamWriter = new StreamWriter(isolatedStorageFileStream);
			try
			{
				IStoreContext storeContext = AppContainer.Resolve<IStoreContext>();
				if (storeContext != null && njcT1fGPykNUn2gtr9n.D35lls5iF(storeContext, njcT1fGPykNUn2gtr9n.lc5GsjGgnH) != null)
				{
					if (GmMLaTD7kV8rq88ZFvR.D35lls5iF(xrWtp71MaQsXtvtrqkf.D35lls5iF(app, xrWtp71MaQsXtvtrqkf.fxR1SMKb5A), iFZ5je3XFYKwkvcE5D.D35lls5iF(14656, iFZ5je3XFYKwkvcE5D.N06TeK0ao), GmMLaTD7kV8rq88ZFvR.VGG1KpDfXX))
					{
						IDictionary dictionary = xrWtp71MaQsXtvtrqkf.D35lls5iF(app, xrWtp71MaQsXtvtrqkf.fxR1SMKb5A);
						string text = iFZ5je3XFYKwkvcE5D.D35lls5iF(14656, iFZ5je3XFYKwkvcE5D.N06TeK0ao);
						DeviceResponseDto deviceResponseDto = njcT1fGPykNUn2gtr9n.D35lls5iF(storeContext, njcT1fGPykNUn2gtr9n.lc5GsjGgnH);
						EyxbpBGMcaXD02sIi7w.D35lls5iF(dictionary, text, (deviceResponseDto != null) ? QQLie3eYkZwbFFm9Jjw.D35lls5iF(deviceResponseDto, QQLie3eYkZwbFFm9Jjw.ksZGhCNgr4) : null, EyxbpBGMcaXD02sIi7w.z9EGSdF6KF);
					}
					else
					{
						IDictionary dictionary2 = xrWtp71MaQsXtvtrqkf.D35lls5iF(app, xrWtp71MaQsXtvtrqkf.fxR1SMKb5A);
						string text2 = iFZ5je3XFYKwkvcE5D.D35lls5iF(14656, iFZ5je3XFYKwkvcE5D.N06TeK0ao);
						DeviceResponseDto deviceResponseDto2 = njcT1fGPykNUn2gtr9n.D35lls5iF(storeContext, njcT1fGPykNUn2gtr9n.lc5GsjGgnH);
						EyxbpBGMcaXD02sIi7w.D35lls5iF(dictionary2, text2, (deviceResponseDto2 != null) ? QQLie3eYkZwbFFm9Jjw.D35lls5iF(deviceResponseDto2, QQLie3eYkZwbFFm9Jjw.ksZGhCNgr4) : null, EyxbpBGMcaXD02sIi7w.y9uGuhNJgc);
					}
					if (GmMLaTD7kV8rq88ZFvR.D35lls5iF(xrWtp71MaQsXtvtrqkf.D35lls5iF(app, xrWtp71MaQsXtvtrqkf.fxR1SMKb5A), iFZ5je3XFYKwkvcE5D.D35lls5iF(14684, iFZ5je3XFYKwkvcE5D.N06TeK0ao), GmMLaTD7kV8rq88ZFvR.VGG1KpDfXX))
					{
						IDictionary dictionary3 = xrWtp71MaQsXtvtrqkf.D35lls5iF(app, xrWtp71MaQsXtvtrqkf.fxR1SMKb5A);
						string text3 = iFZ5je3XFYKwkvcE5D.D35lls5iF(14684, iFZ5je3XFYKwkvcE5D.N06TeK0ao);
						ProfileResponseDto profileResponseDto = T6clNKGx2KMvSduOFef.D35lls5iF(storeContext, T6clNKGx2KMvSduOFef.oxqGYisO31);
						EyxbpBGMcaXD02sIi7w.D35lls5iF(dictionary3, text3, (profileResponseDto != null) ? QQLie3eYkZwbFFm9Jjw.D35lls5iF(profileResponseDto, QQLie3eYkZwbFFm9Jjw.RRvGgU2slF) : null, EyxbpBGMcaXD02sIi7w.z9EGSdF6KF);
					}
					else
					{
						IDictionary dictionary4 = xrWtp71MaQsXtvtrqkf.D35lls5iF(app, xrWtp71MaQsXtvtrqkf.fxR1SMKb5A);
						string text4 = iFZ5je3XFYKwkvcE5D.D35lls5iF(14684, iFZ5je3XFYKwkvcE5D.N06TeK0ao);
						ProfileResponseDto profileResponseDto2 = T6clNKGx2KMvSduOFef.D35lls5iF(storeContext, T6clNKGx2KMvSduOFef.oxqGYisO31);
						EyxbpBGMcaXD02sIi7w.D35lls5iF(dictionary4, text4, (profileResponseDto2 != null) ? QQLie3eYkZwbFFm9Jjw.D35lls5iF(profileResponseDto2, QQLie3eYkZwbFFm9Jjw.RRvGgU2slF) : null, EyxbpBGMcaXD02sIi7w.y9uGuhNJgc);
					}
				}
				IEnumerator enumerator = c1Go45GX5DeBbIijy8v.D35lls5iF(CCdOpYGiLRkkAFbBHge.D35lls5iF(xrWtp71MaQsXtvtrqkf.D35lls5iF(app, xrWtp71MaQsXtvtrqkf.fxR1SMKb5A), CCdOpYGiLRkkAFbBHge.i8KGQAccsn), c1Go45GX5DeBbIijy8v.DtMGfkQXkV);
				try
				{
					while (hjMnupQVVDlRZAYQJC.D35lls5iF(enumerator, hjMnupQVVDlRZAYQJC.QV1TFwytOj))
					{
						string text5 = (string)RAspAbuaTQFU0nSRiQ.D35lls5iF(enumerator, RAspAbuaTQFU0nSRiQ.h8QGFuG3WQ);
						R8atG1G2xeS5NclYGkH.D35lls5iF(streamWriter, iFZ5je3XFYKwkvcE5D.D35lls5iF(14698, iFZ5je3XFYKwkvcE5D.N06TeK0ao), text5, auEPOZ1NWYKXdU711jq.D35lls5iF(xrWtp71MaQsXtvtrqkf.D35lls5iF(app, xrWtp71MaQsXtvtrqkf.fxR1SMKb5A), text5, auEPOZ1NWYKXdU711jq.Y1J1OKa53W), R8atG1G2xeS5NclYGkH.bwyGZQ3nWZ);
					}
				}
				finally
				{
					if (enumerator is IDisposable disposable)
					{
						xLO56JniGyickVjO1Ot.D35lls5iF(disposable, xLO56JniGyickVjO1Ot.ydbT2bsoH4);
					}
				}
			}
			finally
			{
				if (streamWriter != null)
				{
					xLO56JniGyickVjO1Ot.D35lls5iF(streamWriter, xLO56JniGyickVjO1Ot.ydbT2bsoH4);
				}
			}
		}
		finally
		{
			if (isolatedStorageFileStream != null)
			{
				xLO56JniGyickVjO1Ot.D35lls5iF(isolatedStorageFileStream, xLO56JniGyickVjO1Ot.ydbT2bsoH4);
			}
		}
	}
}
