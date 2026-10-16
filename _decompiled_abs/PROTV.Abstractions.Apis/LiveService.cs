using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PROTV.Abstractions.Common;
using PROTV.Abstractions.DataTransferObjects;
using PROTV.Abstractions.Search;
using PROTV.Abstractions.Services;

namespace PROTV.Abstractions.Apis;

public class LiveService : ILiveService
{
	private readonly IAuthService SLmhABKVA5;

	private readonly IPTVApis qR3huchdEk;

	private readonly IStoreContext FYlhqaidmb;

	public LiveService(IPTVApis iPTVApis, IStoreContext storeContext, IAuthService authService)
	{
		uiiVNagWnDNnTWnFgq.IB3tMMvyI(uiiVNagWnDNnTWnFgq.JyKLgPcm8);
		base._002Ector();
		qR3huchdEk = iPTVApis;
		SLmhABKVA5 = authService;
		FYlhqaidmb = storeContext;
	}

	public async Task<ResponseList<ChannelResponseDto>> GetChannelsAsync(ApiQuery<ChannelSearch, ChannelSort> query)
	{
		bool tryAgain = true;
		while (tryAgain)
		{
			try
			{
				return (!TLD0W5K9yiTCdcMEKT.IB3tMMvyI(FYlhqaidmb, TLD0W5K9yiTCdcMEKT.nOQLzI2sZW)) ? (await kKqlL6Mf374dX3cwvoD.IB3tMMvyI(QPngUiMCkm8i5RIKrW1.IB3tMMvyI(qR3huchdEk, QPngUiMCkm8i5RIKrW1.vQMM5AsOOJ), query, kKqlL6Mf374dX3cwvoD.pybMUnvFuZ)) : (await kKqlL6Mf374dX3cwvoD.IB3tMMvyI(QPngUiMCkm8i5RIKrW1.IB3tMMvyI(qR3huchdEk, QPngUiMCkm8i5RIKrW1.aurMIvDwEI), query, kKqlL6Mf374dX3cwvoD.pybMUnvFuZ));
			}
			catch (Exception e)
			{
				PROTVException ex = new PROTVException(e);
				if (CDq5XOVSkTWxZo0hfQU.IB3tMMvyI(ex, CDq5XOVSkTWxZo0hfQU.wJ8Vnql80E) == ExceptionType.AuthorizationTokenInvalid)
				{
					try
					{
						await d81QmNVvT2C1ISNMQLb.IB3tMMvyI(SLmhABKVA5, d81QmNVvT2C1ISNMQLb.eQmVM4BpWn);
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

	public async Task<ResponseList<ChannelResponseDto>> GetChannelFavoritesAAsync(ApiQuery<ChannelSearch, ChannelSort> query)
	{
		bool tryAgain = true;
		while (tryAgain)
		{
			try
			{
				return (!TLD0W5K9yiTCdcMEKT.IB3tMMvyI(FYlhqaidmb, TLD0W5K9yiTCdcMEKT.nOQLzI2sZW)) ? (await kKqlL6Mf374dX3cwvoD.IB3tMMvyI(QPngUiMCkm8i5RIKrW1.IB3tMMvyI(qR3huchdEk, QPngUiMCkm8i5RIKrW1.vQMM5AsOOJ), query, kKqlL6Mf374dX3cwvoD.dgtM6EFP09)) : (await kKqlL6Mf374dX3cwvoD.IB3tMMvyI(QPngUiMCkm8i5RIKrW1.IB3tMMvyI(qR3huchdEk, QPngUiMCkm8i5RIKrW1.aurMIvDwEI), query, kKqlL6Mf374dX3cwvoD.dgtM6EFP09));
			}
			catch (Exception e)
			{
				PROTVException ex = new PROTVException(e);
				if (CDq5XOVSkTWxZo0hfQU.IB3tMMvyI(ex, CDq5XOVSkTWxZo0hfQU.wJ8Vnql80E) == ExceptionType.AuthorizationTokenInvalid)
				{
					try
					{
						await d81QmNVvT2C1ISNMQLb.IB3tMMvyI(SLmhABKVA5, d81QmNVvT2C1ISNMQLb.eQmVM4BpWn);
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

	public async Task<Response<ChannelResponseDto>> GetChannelAsync(int Id)
	{
		bool tryAgain = true;
		while (tryAgain)
		{
			try
			{
				return (!TLD0W5K9yiTCdcMEKT.IB3tMMvyI(FYlhqaidmb, TLD0W5K9yiTCdcMEKT.nOQLzI2sZW)) ? (await djP0G4MRPlFjRZem4x8.IB3tMMvyI(QPngUiMCkm8i5RIKrW1.IB3tMMvyI(qR3huchdEk, QPngUiMCkm8i5RIKrW1.vQMM5AsOOJ), Id, djP0G4MRPlFjRZem4x8.APkMdqNP8A)) : (await djP0G4MRPlFjRZem4x8.IB3tMMvyI(QPngUiMCkm8i5RIKrW1.IB3tMMvyI(qR3huchdEk, QPngUiMCkm8i5RIKrW1.aurMIvDwEI), Id, djP0G4MRPlFjRZem4x8.APkMdqNP8A));
			}
			catch (Exception e)
			{
				PROTVException ex = new PROTVException(e);
				if (CDq5XOVSkTWxZo0hfQU.IB3tMMvyI(ex, CDq5XOVSkTWxZo0hfQU.wJ8Vnql80E) == ExceptionType.AuthorizationTokenInvalid)
				{
					try
					{
						await d81QmNVvT2C1ISNMQLb.IB3tMMvyI(SLmhABKVA5, d81QmNVvT2C1ISNMQLb.eQmVM4BpWn);
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

	public async Task<bool> ToggleChannelFavoriteAsync(int Id)
	{
		bool tryAgain = true;
		while (tryAgain)
		{
			tryAgain = false;
			try
			{
				Response<bool> response = ((!TLD0W5K9yiTCdcMEKT.IB3tMMvyI(FYlhqaidmb, TLD0W5K9yiTCdcMEKT.nOQLzI2sZW)) ? (await b02guvnWlaMhfHYgQIF.IB3tMMvyI(QPngUiMCkm8i5RIKrW1.IB3tMMvyI(qR3huchdEk, QPngUiMCkm8i5RIKrW1.vQMM5AsOOJ), Id, b02guvnWlaMhfHYgQIF.Fq0MlwTApy)) : (await b02guvnWlaMhfHYgQIF.IB3tMMvyI(QPngUiMCkm8i5RIKrW1.IB3tMMvyI(qR3huchdEk, QPngUiMCkm8i5RIKrW1.aurMIvDwEI), Id, b02guvnWlaMhfHYgQIF.Fq0MlwTApy)));
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
						await d81QmNVvT2C1ISNMQLb.IB3tMMvyI(SLmhABKVA5, d81QmNVvT2C1ISNMQLb.eQmVM4BpWn);
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

	public async Task<Response<IEnumerable<EPGChannelResponseDto>>> GetChannelEPGAsync(int Id)
	{
		bool tryAgain = true;
		while (tryAgain)
		{
			try
			{
				return (!TLD0W5K9yiTCdcMEKT.IB3tMMvyI(FYlhqaidmb, TLD0W5K9yiTCdcMEKT.nOQLzI2sZW)) ? (await CDM2SHMmUvxrJDbXRdQ.IB3tMMvyI(QPngUiMCkm8i5RIKrW1.IB3tMMvyI(qR3huchdEk, QPngUiMCkm8i5RIKrW1.vQMM5AsOOJ), Id, CDM2SHMmUvxrJDbXRdQ.c9nMpTqaNs)) : (await CDM2SHMmUvxrJDbXRdQ.IB3tMMvyI(QPngUiMCkm8i5RIKrW1.IB3tMMvyI(qR3huchdEk, QPngUiMCkm8i5RIKrW1.aurMIvDwEI), Id, CDM2SHMmUvxrJDbXRdQ.c9nMpTqaNs));
			}
			catch (Exception e)
			{
				PROTVException ex = new PROTVException(e);
				if (CDq5XOVSkTWxZo0hfQU.IB3tMMvyI(ex, CDq5XOVSkTWxZo0hfQU.wJ8Vnql80E) == ExceptionType.AuthorizationTokenInvalid)
				{
					try
					{
						await d81QmNVvT2C1ISNMQLb.IB3tMMvyI(SLmhABKVA5, d81QmNVvT2C1ISNMQLb.eQmVM4BpWn);
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

	public async Task<Response<IEnumerable<EPGChannelResponseDto>>> GetChannelsEPGAsync()
	{
		bool tryAgain = true;
		while (tryAgain)
		{
			try
			{
				return (!TLD0W5K9yiTCdcMEKT.IB3tMMvyI(FYlhqaidmb, TLD0W5K9yiTCdcMEKT.nOQLzI2sZW)) ? (await KKKB6VMcdnWgqFmcTtE.IB3tMMvyI(QPngUiMCkm8i5RIKrW1.IB3tMMvyI(qR3huchdEk, QPngUiMCkm8i5RIKrW1.vQMM5AsOOJ), new ApiQuery<ChannelSearch, ChannelSort>(), KKKB6VMcdnWgqFmcTtE.EaMMqwxQBd)) : (await KKKB6VMcdnWgqFmcTtE.IB3tMMvyI(QPngUiMCkm8i5RIKrW1.IB3tMMvyI(qR3huchdEk, QPngUiMCkm8i5RIKrW1.aurMIvDwEI), new ApiQuery<ChannelSearch, ChannelSort>(), KKKB6VMcdnWgqFmcTtE.EaMMqwxQBd));
			}
			catch (Exception e)
			{
				PROTVException ex = new PROTVException(e);
				if (CDq5XOVSkTWxZo0hfQU.IB3tMMvyI(ex, CDq5XOVSkTWxZo0hfQU.wJ8Vnql80E) == ExceptionType.AuthorizationTokenInvalid)
				{
					try
					{
						await d81QmNVvT2C1ISNMQLb.IB3tMMvyI(SLmhABKVA5, d81QmNVvT2C1ISNMQLb.eQmVM4BpWn);
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

	public async Task<Response<IEnumerable<EPGDataResponseDto>>> GetChannelsEPGsAsync()
	{
		bool tryAgain = true;
		while (tryAgain)
		{
			try
			{
				return (!TLD0W5K9yiTCdcMEKT.IB3tMMvyI(FYlhqaidmb, TLD0W5K9yiTCdcMEKT.nOQLzI2sZW)) ? (await xWHaoYMO1xhS5CeOFv6.IB3tMMvyI(QPngUiMCkm8i5RIKrW1.IB3tMMvyI(qR3huchdEk, QPngUiMCkm8i5RIKrW1.vQMM5AsOOJ), new ApiQuery<ChannelSearch, ChannelSort>(), xWHaoYMO1xhS5CeOFv6.SoqMK5tDxO)) : (await xWHaoYMO1xhS5CeOFv6.IB3tMMvyI(QPngUiMCkm8i5RIKrW1.IB3tMMvyI(qR3huchdEk, QPngUiMCkm8i5RIKrW1.aurMIvDwEI), new ApiQuery<ChannelSearch, ChannelSort>(), xWHaoYMO1xhS5CeOFv6.SoqMK5tDxO));
			}
			catch (Exception e)
			{
				PROTVException ex = new PROTVException(e);
				if (CDq5XOVSkTWxZo0hfQU.IB3tMMvyI(ex, CDq5XOVSkTWxZo0hfQU.wJ8Vnql80E) == ExceptionType.AuthorizationTokenInvalid)
				{
					try
					{
						await d81QmNVvT2C1ISNMQLb.IB3tMMvyI(SLmhABKVA5, d81QmNVvT2C1ISNMQLb.eQmVM4BpWn);
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
