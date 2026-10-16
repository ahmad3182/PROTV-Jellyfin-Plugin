using System;
using System.Threading.Tasks;
using PROTV.Abstractions.Common;
using PROTV.Abstractions.DataTransferObjects;
using PROTV.Abstractions.Search;
using PROTV.Abstractions.Services;

namespace PROTV.Abstractions.Apis;

public class QuranService : IQuranService
{
	private readonly IAuthService lAlh0sXoGQ;

	private readonly IStoreContext dyUhTxknb2;

	private readonly IPTVApis vD9h6prs0n;

	public QuranService(IPTVApis iPTVApis, IAuthService authService, IStoreContext storeContext)
	{
		uiiVNagWnDNnTWnFgq.IB3tMMvyI(uiiVNagWnDNnTWnFgq.JyKLgPcm8);
		base._002Ector();
		lAlh0sXoGQ = authService;
		vD9h6prs0n = iPTVApis;
		dyUhTxknb2 = storeContext;
	}

	public async Task<ResponseList<SurahResponseDto>> GetSurahsAsync(ApiQuery<GeneralSearch, GeneralSort> query)
	{
		bool tryAgain = true;
		while (tryAgain)
		{
			try
			{
				return (!TLD0W5K9yiTCdcMEKT.IB3tMMvyI(dyUhTxknb2, TLD0W5K9yiTCdcMEKT.nOQLzI2sZW)) ? (await VqqIsQMDEXq41yC6rh9.IB3tMMvyI(F5BWtgM7l2JDmCK2doY.IB3tMMvyI(vD9h6prs0n, F5BWtgM7l2JDmCK2doY.eBGMPpaJX9), query, VqqIsQMDEXq41yC6rh9.wQuMaOu9vU)) : (await VqqIsQMDEXq41yC6rh9.IB3tMMvyI(F5BWtgM7l2JDmCK2doY.IB3tMMvyI(vD9h6prs0n, F5BWtgM7l2JDmCK2doY.vtbMYdDWEh), query, VqqIsQMDEXq41yC6rh9.wQuMaOu9vU));
			}
			catch (Exception e)
			{
				PROTVException ex = new PROTVException(e);
				if (CDq5XOVSkTWxZo0hfQU.IB3tMMvyI(ex, CDq5XOVSkTWxZo0hfQU.wJ8Vnql80E) == ExceptionType.AuthorizationTokenInvalid)
				{
					try
					{
						await d81QmNVvT2C1ISNMQLb.IB3tMMvyI(lAlh0sXoGQ, d81QmNVvT2C1ISNMQLb.eQmVM4BpWn);
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

	public async Task<ResponseList<RecitatorResponseDto>> GetRecitatorsAsync(ApiQuery<GeneralSearch, GeneralSort> query)
	{
		bool tryAgain = true;
		while (tryAgain)
		{
			try
			{
				return (!TLD0W5K9yiTCdcMEKT.IB3tMMvyI(dyUhTxknb2, TLD0W5K9yiTCdcMEKT.nOQLzI2sZW)) ? (await GahFQxMBFkTyF0Fhsbg.IB3tMMvyI(F5BWtgM7l2JDmCK2doY.IB3tMMvyI(vD9h6prs0n, F5BWtgM7l2JDmCK2doY.eBGMPpaJX9), query, GahFQxMBFkTyF0Fhsbg.fk3M18Shey)) : (await GahFQxMBFkTyF0Fhsbg.IB3tMMvyI(F5BWtgM7l2JDmCK2doY.IB3tMMvyI(vD9h6prs0n, F5BWtgM7l2JDmCK2doY.vtbMYdDWEh), query, GahFQxMBFkTyF0Fhsbg.fk3M18Shey));
			}
			catch (Exception e)
			{
				PROTVException ex = new PROTVException(e);
				if (CDq5XOVSkTWxZo0hfQU.IB3tMMvyI(ex, CDq5XOVSkTWxZo0hfQU.wJ8Vnql80E) == ExceptionType.AuthorizationTokenInvalid)
				{
					try
					{
						await d81QmNVvT2C1ISNMQLb.IB3tMMvyI(lAlh0sXoGQ, d81QmNVvT2C1ISNMQLb.eQmVM4BpWn);
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

	public async Task<Response<RecitatorResponseDto>> GetRecitatorAsync(int Id)
	{
		bool tryAgain = true;
		while (tryAgain)
		{
			try
			{
				return (!TLD0W5K9yiTCdcMEKT.IB3tMMvyI(dyUhTxknb2, TLD0W5K9yiTCdcMEKT.nOQLzI2sZW)) ? (await ACswq4MyrTaJxiFBTib.IB3tMMvyI(F5BWtgM7l2JDmCK2doY.IB3tMMvyI(vD9h6prs0n, F5BWtgM7l2JDmCK2doY.eBGMPpaJX9), Id, ACswq4MyrTaJxiFBTib.hKuMoglIdf)) : (await ACswq4MyrTaJxiFBTib.IB3tMMvyI(F5BWtgM7l2JDmCK2doY.IB3tMMvyI(vD9h6prs0n, F5BWtgM7l2JDmCK2doY.vtbMYdDWEh), Id, ACswq4MyrTaJxiFBTib.hKuMoglIdf));
			}
			catch (Exception e)
			{
				PROTVException ex = new PROTVException(e);
				if (CDq5XOVSkTWxZo0hfQU.IB3tMMvyI(ex, CDq5XOVSkTWxZo0hfQU.wJ8Vnql80E) == ExceptionType.AuthorizationTokenInvalid)
				{
					try
					{
						await d81QmNVvT2C1ISNMQLb.IB3tMMvyI(lAlh0sXoGQ, d81QmNVvT2C1ISNMQLb.eQmVM4BpWn);
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

	public async Task<Response<SurahResponseDto>> GetSurahAsync(int Id)
	{
		bool tryAgain = true;
		while (tryAgain)
		{
			try
			{
				return (!TLD0W5K9yiTCdcMEKT.IB3tMMvyI(dyUhTxknb2, TLD0W5K9yiTCdcMEKT.nOQLzI2sZW)) ? (await vCYp5PM80xkLyUi9KI7.IB3tMMvyI(F5BWtgM7l2JDmCK2doY.IB3tMMvyI(vD9h6prs0n, F5BWtgM7l2JDmCK2doY.eBGMPpaJX9), Id, vCYp5PM80xkLyUi9KI7.n97MNn30dO)) : (await vCYp5PM80xkLyUi9KI7.IB3tMMvyI(F5BWtgM7l2JDmCK2doY.IB3tMMvyI(vD9h6prs0n, F5BWtgM7l2JDmCK2doY.vtbMYdDWEh), Id, vCYp5PM80xkLyUi9KI7.n97MNn30dO));
			}
			catch (Exception e)
			{
				PROTVException ex = new PROTVException(e);
				if (CDq5XOVSkTWxZo0hfQU.IB3tMMvyI(ex, CDq5XOVSkTWxZo0hfQU.wJ8Vnql80E) == ExceptionType.AuthorizationTokenInvalid)
				{
					try
					{
						await d81QmNVvT2C1ISNMQLb.IB3tMMvyI(lAlh0sXoGQ, d81QmNVvT2C1ISNMQLb.eQmVM4BpWn);
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
