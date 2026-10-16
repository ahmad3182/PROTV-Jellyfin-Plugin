using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PROTV.Abstractions.Apis;
using PROTV.Abstractions.Common;
using PROTV.Abstractions.DataTransferObjects;
using PROTV.Abstractions.Search;

namespace PROTV.Abstractions.Services;

public class MusicService : IMusicService
{
	private readonly IAuthService qZAlSR38a;

	private readonly IStoreContext gYVhnlF8h;

	private readonly IPTVApis sti2Xi2KS;

	public MusicService(IPTVApis iPTVApis, IAuthService authService, IStoreContext storeContext)
	{
		uiiVNagWnDNnTWnFgq.IB3tMMvyI(uiiVNagWnDNnTWnFgq.JyKLgPcm8);
		base._002Ector();
		qZAlSR38a = authService;
		sti2Xi2KS = iPTVApis;
		gYVhnlF8h = storeContext;
	}

	public async Task<ResponseList<AlbumResponseDto>> GetAlbumListAsync(ApiQuery<AlbumSearch, GeneralSort> query)
	{
		bool tryAgain = true;
		while (tryAgain)
		{
			try
			{
				return (!TLD0W5K9yiTCdcMEKT.IB3tMMvyI(gYVhnlF8h, TLD0W5K9yiTCdcMEKT.nOQLzI2sZW)) ? (await ayMC34nql3GJIgorAH7.IB3tMMvyI(r9h0lFnpGGpOPPsrBsp.IB3tMMvyI(sti2Xi2KS, r9h0lFnpGGpOPPsrBsp.GFZnKlTBXC), query, ayMC34nql3GJIgorAH7.xpenO6uhiF)) : (await ayMC34nql3GJIgorAH7.IB3tMMvyI(r9h0lFnpGGpOPPsrBsp.IB3tMMvyI(sti2Xi2KS, r9h0lFnpGGpOPPsrBsp.OF4nckiWB2), query, ayMC34nql3GJIgorAH7.xpenO6uhiF));
			}
			catch (Exception e)
			{
				PROTVException ex = new PROTVException(e);
				if (CDq5XOVSkTWxZo0hfQU.IB3tMMvyI(ex, CDq5XOVSkTWxZo0hfQU.wJ8Vnql80E) == ExceptionType.AuthorizationTokenInvalid)
				{
					try
					{
						await d81QmNVvT2C1ISNMQLb.IB3tMMvyI(qZAlSR38a, d81QmNVvT2C1ISNMQLb.eQmVM4BpWn);
						tryAgain = true;
					}
					catch (Exception e2)
					{
						ex = new PROTVException(e2);
						throw ex;
					}
					continue;
				}
				throw ex;
			}
		}
		return null;
	}

	public async Task<AlbumResponseDto> GetAlbumAsync(int Id)
	{
		bool tryAgain = true;
		while (tryAgain)
		{
			tryAgain = false;
			try
			{
				Response<AlbumResponseDto> response = ((!TLD0W5K9yiTCdcMEKT.IB3tMMvyI(gYVhnlF8h, TLD0W5K9yiTCdcMEKT.nOQLzI2sZW)) ? (await SEHK9jnrZq7D10pWjLF.IB3tMMvyI(r9h0lFnpGGpOPPsrBsp.IB3tMMvyI(sti2Xi2KS, r9h0lFnpGGpOPPsrBsp.GFZnKlTBXC), Id, SEHK9jnrZq7D10pWjLF.iBYnE9vZxZ)) : (await SEHK9jnrZq7D10pWjLF.IB3tMMvyI(r9h0lFnpGGpOPPsrBsp.IB3tMMvyI(sti2Xi2KS, r9h0lFnpGGpOPPsrBsp.OF4nckiWB2), Id, SEHK9jnrZq7D10pWjLF.iBYnE9vZxZ)));
				if (response != null && response.Status)
				{
					return response.Data;
				}
			}
			catch (Exception e)
			{
				PROTVException ex = new PROTVException(e);
				if (CDq5XOVSkTWxZo0hfQU.IB3tMMvyI(ex, CDq5XOVSkTWxZo0hfQU.wJ8Vnql80E) == ExceptionType.AuthorizationTokenInvalid)
				{
					try
					{
						await d81QmNVvT2C1ISNMQLb.IB3tMMvyI(qZAlSR38a, d81QmNVvT2C1ISNMQLb.eQmVM4BpWn);
						tryAgain = true;
					}
					catch (Exception e2)
					{
						ex = new PROTVException(e2);
						throw ex;
					}
					continue;
				}
				throw ex;
			}
		}
		return null;
	}

	public async Task<ResponseList<SongResponseDto>> GetSongsListAsync(ApiQuery<SongSearch, SongSort> query)
	{
		bool tryAgain = true;
		while (tryAgain)
		{
			try
			{
				return (!TLD0W5K9yiTCdcMEKT.IB3tMMvyI(gYVhnlF8h, TLD0W5K9yiTCdcMEKT.nOQLzI2sZW)) ? (await htQL5mn42HIf89ONbyk.IB3tMMvyI(r9h0lFnpGGpOPPsrBsp.IB3tMMvyI(sti2Xi2KS, r9h0lFnpGGpOPPsrBsp.GFZnKlTBXC), query, htQL5mn42HIf89ONbyk.rfPnXcwgUh)) : (await htQL5mn42HIf89ONbyk.IB3tMMvyI(r9h0lFnpGGpOPPsrBsp.IB3tMMvyI(sti2Xi2KS, r9h0lFnpGGpOPPsrBsp.OF4nckiWB2), query, htQL5mn42HIf89ONbyk.rfPnXcwgUh));
			}
			catch (Exception e)
			{
				PROTVException ex = new PROTVException(e);
				if (CDq5XOVSkTWxZo0hfQU.IB3tMMvyI(ex, CDq5XOVSkTWxZo0hfQU.wJ8Vnql80E) == ExceptionType.AuthorizationTokenInvalid)
				{
					try
					{
						await d81QmNVvT2C1ISNMQLb.IB3tMMvyI(qZAlSR38a, d81QmNVvT2C1ISNMQLb.eQmVM4BpWn);
						tryAgain = true;
					}
					catch (Exception e2)
					{
						ex = new PROTVException(e2);
						throw ex;
					}
					continue;
				}
				throw ex;
			}
		}
		return null;
	}

	public async Task<SongResponseDto> GetSongAsync(int Id)
	{
		bool tryAgain = true;
		while (tryAgain)
		{
			tryAgain = false;
			try
			{
				Response<SongResponseDto> response = ((!TLD0W5K9yiTCdcMEKT.IB3tMMvyI(gYVhnlF8h, TLD0W5K9yiTCdcMEKT.nOQLzI2sZW)) ? (await fY8qFfnF367KxaVxdeo.IB3tMMvyI(r9h0lFnpGGpOPPsrBsp.IB3tMMvyI(sti2Xi2KS, r9h0lFnpGGpOPPsrBsp.GFZnKlTBXC), Id, fY8qFfnF367KxaVxdeo.iAHn09upJm)) : (await fY8qFfnF367KxaVxdeo.IB3tMMvyI(r9h0lFnpGGpOPPsrBsp.IB3tMMvyI(sti2Xi2KS, r9h0lFnpGGpOPPsrBsp.OF4nckiWB2), Id, fY8qFfnF367KxaVxdeo.iAHn09upJm)));
				if (response != null && response.Status)
				{
					return response.Data;
				}
			}
			catch (Exception e)
			{
				PROTVException ex = new PROTVException(e);
				if (CDq5XOVSkTWxZo0hfQU.IB3tMMvyI(ex, CDq5XOVSkTWxZo0hfQU.wJ8Vnql80E) == ExceptionType.AuthorizationTokenInvalid)
				{
					try
					{
						await d81QmNVvT2C1ISNMQLb.IB3tMMvyI(qZAlSR38a, d81QmNVvT2C1ISNMQLb.eQmVM4BpWn);
						tryAgain = true;
					}
					catch (Exception e2)
					{
						ex = new PROTVException(e2);
						throw ex;
					}
					continue;
				}
				throw ex;
			}
		}
		return null;
	}

	public async Task<List<SongResponseDto>> GetSongsFavoirteAsync(ApiQuery<GeneralSearch, GeneralSort> query)
	{
		List<SongResponseDto> Songs = new List<SongResponseDto>();
		bool tryAgain = true;
		while (tryAgain)
		{
			tryAgain = false;
			try
			{
				ResponseList<SongResponseDto> responseList = ((!TLD0W5K9yiTCdcMEKT.IB3tMMvyI(gYVhnlF8h, TLD0W5K9yiTCdcMEKT.nOQLzI2sZW)) ? (await X6GmwjnTW11HEvJuPuI.IB3tMMvyI(r9h0lFnpGGpOPPsrBsp.IB3tMMvyI(sti2Xi2KS, r9h0lFnpGGpOPPsrBsp.GFZnKlTBXC), query, X6GmwjnTW11HEvJuPuI.iAQnZKESBC)) : (await X6GmwjnTW11HEvJuPuI.IB3tMMvyI(r9h0lFnpGGpOPPsrBsp.IB3tMMvyI(sti2Xi2KS, r9h0lFnpGGpOPPsrBsp.OF4nckiWB2), query, X6GmwjnTW11HEvJuPuI.iAQnZKESBC)));
				if (responseList == null)
				{
					return Songs;
				}
				IEnumerator<SongResponseDto> enumerator = responseList.Data.Result.GetEnumerator();
				try
				{
					while (TLD0W5K9yiTCdcMEKT.IB3tMMvyI(enumerator, TLD0W5K9yiTCdcMEKT.QjJnkwxk4d))
					{
						SongResponseDto current = enumerator.Current;
						if (P9KPPOS6nKmEh9KdOkP.IB3tMMvyI(current, P9KPPOS6nKmEh9KdOkP.CMQnuhAlVk) == 0 || !P9KPPOS6nKmEh9KdOkP.IB3tMMvyI(current, P9KPPOS6nKmEh9KdOkP.CMQnuhAlVk).HasValue)
						{
							AlbumResponseDto albumResponseDto = K6tYRCn2grmskQEyyNJ.IB3tMMvyI(current, K6tYRCn2grmskQEyyNJ.SOMnirFMld);
							HrYujxn3w1d7dJHJ2us.IB3tMMvyI(current, (albumResponseDto != null) ? P9KPPOS6nKmEh9KdOkP.IB3tMMvyI(albumResponseDto, P9KPPOS6nKmEh9KdOkP.TIpne8FxkZ) : ((int?)null), HrYujxn3w1d7dJHJ2us.RiTnHeDbh2);
						}
						if (P9KPPOS6nKmEh9KdOkP.IB3tMMvyI(current, P9KPPOS6nKmEh9KdOkP.CMQnuhAlVk) == 0)
						{
							HrYujxn3w1d7dJHJ2us.IB3tMMvyI(current, null, HrYujxn3w1d7dJHJ2us.RiTnHeDbh2);
						}
						GTWJ1Nn6Vm4L7wbejIm.IB3tMMvyI(current, Songs.Count + 1, GTWJ1Nn6Vm4L7wbejIm.t90nQJuyjv);
						Songs.Add(current);
					}
				}
				finally
				{
					if (enumerator != null)
					{
						xbpXba64taw5VdWx0Y.IB3tMMvyI(enumerator, xbpXba64taw5VdWx0Y.ONrEAGIJN);
					}
				}
				return Songs;
			}
			catch (Exception e)
			{
				if (CDq5XOVSkTWxZo0hfQU.IB3tMMvyI(new PROTVException(e), CDq5XOVSkTWxZo0hfQU.wJ8Vnql80E) == ExceptionType.AuthorizationTokenInvalid)
				{
					try
					{
						await d81QmNVvT2C1ISNMQLb.IB3tMMvyI(qZAlSR38a, d81QmNVvT2C1ISNMQLb.eQmVM4BpWn);
						tryAgain = true;
					}
					catch (Exception e2)
					{
						new PROTVException(e2);
					}
				}
			}
		}
		return Songs;
	}

	public async Task<bool> ToggleSongFavoriteAsync(int Id)
	{
		bool tryAgain = true;
		while (tryAgain)
		{
			tryAgain = false;
			try
			{
				Response<bool> response = ((!TLD0W5K9yiTCdcMEKT.IB3tMMvyI(gYVhnlF8h, TLD0W5K9yiTCdcMEKT.nOQLzI2sZW)) ? (await b02guvnWlaMhfHYgQIF.IB3tMMvyI(r9h0lFnpGGpOPPsrBsp.IB3tMMvyI(sti2Xi2KS, r9h0lFnpGGpOPPsrBsp.GFZnKlTBXC), Id, b02guvnWlaMhfHYgQIF.sWXnJjWReQ)) : (await b02guvnWlaMhfHYgQIF.IB3tMMvyI(r9h0lFnpGGpOPPsrBsp.IB3tMMvyI(sti2Xi2KS, r9h0lFnpGGpOPPsrBsp.OF4nckiWB2), Id, b02guvnWlaMhfHYgQIF.sWXnJjWReQ)));
				if (response != null && response.Status)
				{
					return true;
				}
			}
			catch (Exception e)
			{
				PROTVException ex = new PROTVException(e);
				if (CDq5XOVSkTWxZo0hfQU.IB3tMMvyI(ex, CDq5XOVSkTWxZo0hfQU.wJ8Vnql80E) == ExceptionType.AuthorizationTokenInvalid)
				{
					try
					{
						await d81QmNVvT2C1ISNMQLb.IB3tMMvyI(qZAlSR38a, d81QmNVvT2C1ISNMQLb.eQmVM4BpWn);
						tryAgain = true;
					}
					catch (Exception e2)
					{
						ex = new PROTVException(e2);
						throw ex;
					}
					continue;
				}
				throw ex;
			}
		}
		return false;
	}

	public async Task<Response<string>> AddSongToWatchAsync(int Id)
	{
		bool tryAgain = true;
		while (tryAgain)
		{
			try
			{
				return (!TLD0W5K9yiTCdcMEKT.IB3tMMvyI(gYVhnlF8h, TLD0W5K9yiTCdcMEKT.nOQLzI2sZW)) ? (await ELQHsfnbG5PanCPaDkO.IB3tMMvyI(r9h0lFnpGGpOPPsrBsp.IB3tMMvyI(sti2Xi2KS, r9h0lFnpGGpOPPsrBsp.GFZnKlTBXC), Id, ELQHsfnbG5PanCPaDkO.kWEn7HxXFu)) : (await ELQHsfnbG5PanCPaDkO.IB3tMMvyI(r9h0lFnpGGpOPPsrBsp.IB3tMMvyI(sti2Xi2KS, r9h0lFnpGGpOPPsrBsp.OF4nckiWB2), Id, ELQHsfnbG5PanCPaDkO.kWEn7HxXFu));
			}
			catch (Exception e)
			{
				PROTVException ex = new PROTVException(e);
				if (CDq5XOVSkTWxZo0hfQU.IB3tMMvyI(ex, CDq5XOVSkTWxZo0hfQU.wJ8Vnql80E) == ExceptionType.AuthorizationTokenInvalid)
				{
					try
					{
						await d81QmNVvT2C1ISNMQLb.IB3tMMvyI(qZAlSR38a, d81QmNVvT2C1ISNMQLb.eQmVM4BpWn);
						tryAgain = true;
					}
					catch (Exception e2)
					{
						ex = new PROTVException(e2);
						throw ex;
					}
					continue;
				}
				throw ex;
			}
		}
		return null;
	}
}
