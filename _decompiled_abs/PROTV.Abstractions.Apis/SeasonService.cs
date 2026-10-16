using System;
using System.Threading.Tasks;
using PROTV.Abstractions.Common;
using PROTV.Abstractions.DataTransferObjects;
using PROTV.Abstractions.Search;
using PROTV.Abstractions.Services;

namespace PROTV.Abstractions.Apis;

public class SeasonService : ISeasonService
{
	private readonly IAuthService Mw2h7K1i3D;

	private readonly IStoreContext ItehnBtSqg;

	private readonly IPTVApis gmChCWxW4d;

	public SeasonService(IPTVApis iPTVApis, IAuthService authService, IStoreContext storeContext)
	{
		uiiVNagWnDNnTWnFgq.IB3tMMvyI(uiiVNagWnDNnTWnFgq.JyKLgPcm8);
		base._002Ector();
		Mw2h7K1i3D = authService;
		gmChCWxW4d = iPTVApis;
		ItehnBtSqg = storeContext;
	}

	public async Task<ResponseList<SeasonResponseDto>> GetSeasonsAsync(ApiQuery<SeriesSearch, SeriesSort> query)
	{
		bool tryAgain = true;
		while (tryAgain)
		{
			try
			{
				return (!TLD0W5K9yiTCdcMEKT.IB3tMMvyI(ItehnBtSqg, TLD0W5K9yiTCdcMEKT.nOQLzI2sZW)) ? (await LcedahMA0wRZ0d2KT7Y.IB3tMMvyI(fxOGJFMGNXKxXta45mI.IB3tMMvyI(gmChCWxW4d, fxOGJFMGNXKxXta45mI.RHRMxc0uc5), query, LcedahMA0wRZ0d2KT7Y.PIUMsybrN9)) : (await LcedahMA0wRZ0d2KT7Y.IB3tMMvyI(fxOGJFMGNXKxXta45mI.IB3tMMvyI(gmChCWxW4d, fxOGJFMGNXKxXta45mI.tEDMhI0vNa), query, LcedahMA0wRZ0d2KT7Y.PIUMsybrN9));
			}
			catch (Exception e)
			{
				PROTVException ex = new PROTVException(e);
				if (CDq5XOVSkTWxZo0hfQU.IB3tMMvyI(ex, CDq5XOVSkTWxZo0hfQU.wJ8Vnql80E) == ExceptionType.AuthorizationTokenInvalid)
				{
					try
					{
						await d81QmNVvT2C1ISNMQLb.IB3tMMvyI(Mw2h7K1i3D, d81QmNVvT2C1ISNMQLb.eQmVM4BpWn);
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

	public async Task<Response<SeasonResponseDto>> GetSeasonAsync(int Id)
	{
		bool tryAgain = true;
		while (tryAgain)
		{
			try
			{
				return (!TLD0W5K9yiTCdcMEKT.IB3tMMvyI(ItehnBtSqg, TLD0W5K9yiTCdcMEKT.nOQLzI2sZW)) ? (await ztoBlQMzQGS5TtS9Sfd.IB3tMMvyI(fxOGJFMGNXKxXta45mI.IB3tMMvyI(gmChCWxW4d, fxOGJFMGNXKxXta45mI.RHRMxc0uc5), Id, ztoBlQMzQGS5TtS9Sfd.DlK9wNt0Gb)) : (await ztoBlQMzQGS5TtS9Sfd.IB3tMMvyI(fxOGJFMGNXKxXta45mI.IB3tMMvyI(gmChCWxW4d, fxOGJFMGNXKxXta45mI.tEDMhI0vNa), Id, ztoBlQMzQGS5TtS9Sfd.DlK9wNt0Gb));
			}
			catch (Exception e)
			{
				PROTVException ex = new PROTVException(e);
				if (CDq5XOVSkTWxZo0hfQU.IB3tMMvyI(ex, CDq5XOVSkTWxZo0hfQU.wJ8Vnql80E) == ExceptionType.AuthorizationTokenInvalid)
				{
					try
					{
						await d81QmNVvT2C1ISNMQLb.IB3tMMvyI(Mw2h7K1i3D, d81QmNVvT2C1ISNMQLb.eQmVM4BpWn);
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

	public async Task<ResponseList<EpisodeResponseDto>> GetEpisodesAsync(ApiQuery<SeriesSearch, SeriesSort> query)
	{
		bool tryAgain = true;
		while (tryAgain)
		{
			try
			{
				return (!TLD0W5K9yiTCdcMEKT.IB3tMMvyI(ItehnBtSqg, TLD0W5K9yiTCdcMEKT.nOQLzI2sZW)) ? (await iTZsYr9tkHw8kNCW18T.IB3tMMvyI(fxOGJFMGNXKxXta45mI.IB3tMMvyI(gmChCWxW4d, fxOGJFMGNXKxXta45mI.RHRMxc0uc5), query, iTZsYr9tkHw8kNCW18T.VCY9gtOUMM)) : (await iTZsYr9tkHw8kNCW18T.IB3tMMvyI(fxOGJFMGNXKxXta45mI.IB3tMMvyI(gmChCWxW4d, fxOGJFMGNXKxXta45mI.tEDMhI0vNa), query, iTZsYr9tkHw8kNCW18T.VCY9gtOUMM));
			}
			catch (Exception e)
			{
				PROTVException ex = new PROTVException(e);
				if (CDq5XOVSkTWxZo0hfQU.IB3tMMvyI(ex, CDq5XOVSkTWxZo0hfQU.wJ8Vnql80E) == ExceptionType.AuthorizationTokenInvalid)
				{
					try
					{
						await d81QmNVvT2C1ISNMQLb.IB3tMMvyI(Mw2h7K1i3D, d81QmNVvT2C1ISNMQLb.eQmVM4BpWn);
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

	public async Task<Response<EpisodeResponseDto>> GetEpisodeAsync(int Id)
	{
		bool tryAgain = true;
		while (tryAgain)
		{
			try
			{
				return (!TLD0W5K9yiTCdcMEKT.IB3tMMvyI(ItehnBtSqg, TLD0W5K9yiTCdcMEKT.nOQLzI2sZW)) ? (await k2CVA99Lo1OEuOJAMOh.IB3tMMvyI(fxOGJFMGNXKxXta45mI.IB3tMMvyI(gmChCWxW4d, fxOGJFMGNXKxXta45mI.RHRMxc0uc5), Id, k2CVA99Lo1OEuOJAMOh.JiE9V1PJxW)) : (await k2CVA99Lo1OEuOJAMOh.IB3tMMvyI(fxOGJFMGNXKxXta45mI.IB3tMMvyI(gmChCWxW4d, fxOGJFMGNXKxXta45mI.tEDMhI0vNa), Id, k2CVA99Lo1OEuOJAMOh.JiE9V1PJxW));
			}
			catch (Exception e)
			{
				PROTVException ex = new PROTVException(e);
				if (CDq5XOVSkTWxZo0hfQU.IB3tMMvyI(ex, CDq5XOVSkTWxZo0hfQU.wJ8Vnql80E) == ExceptionType.AuthorizationTokenInvalid)
				{
					try
					{
						await d81QmNVvT2C1ISNMQLb.IB3tMMvyI(Mw2h7K1i3D, d81QmNVvT2C1ISNMQLb.eQmVM4BpWn);
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

	public async Task<Response<RentResponseDto>> RentEpisodeAsync(int Id)
	{
		bool tryAgain = true;
		while (tryAgain)
		{
			try
			{
				return (!TLD0W5K9yiTCdcMEKT.IB3tMMvyI(ItehnBtSqg, TLD0W5K9yiTCdcMEKT.nOQLzI2sZW)) ? (await V4tbvwMZZ77Y0plOpiB.IB3tMMvyI(fxOGJFMGNXKxXta45mI.IB3tMMvyI(gmChCWxW4d, fxOGJFMGNXKxXta45mI.RHRMxc0uc5), Id, V4tbvwMZZ77Y0plOpiB.IuV9SJCkFG)) : (await V4tbvwMZZ77Y0plOpiB.IB3tMMvyI(fxOGJFMGNXKxXta45mI.IB3tMMvyI(gmChCWxW4d, fxOGJFMGNXKxXta45mI.tEDMhI0vNa), Id, V4tbvwMZZ77Y0plOpiB.IuV9SJCkFG));
			}
			catch (Exception e)
			{
				PROTVException ex = new PROTVException(e);
				if (CDq5XOVSkTWxZo0hfQU.IB3tMMvyI(ex, CDq5XOVSkTWxZo0hfQU.wJ8Vnql80E) == ExceptionType.AuthorizationTokenInvalid)
				{
					try
					{
						await d81QmNVvT2C1ISNMQLb.IB3tMMvyI(Mw2h7K1i3D, d81QmNVvT2C1ISNMQLb.eQmVM4BpWn);
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
