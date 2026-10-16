using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PROTV.Abstractions.Common;
using PROTV.Abstractions.DataTransferObjects;
using PROTV.Abstractions.Search;
using PROTV.Abstractions.Services;

namespace PROTV.Abstractions.Apis;

public class MovieService : IMovieService
{
	private readonly IStoreContext jdChSJQb2h;

	private readonly IAuthService tLjhb0uPR9;

	private readonly IPTVApis coehe6KvPF;

	public MovieService(IPTVApis iPTVApis, IStoreContext storeContext, IAuthService authService)
	{
		uiiVNagWnDNnTWnFgq.IB3tMMvyI(uiiVNagWnDNnTWnFgq.JyKLgPcm8);
		base._002Ector();
		coehe6KvPF = iPTVApis;
		jdChSJQb2h = storeContext;
		tLjhb0uPR9 = authService;
	}

	public async Task<ResponseList<MovieResponseDto>> GetMoviesAsync(ApiQuery<MovieSearch, MovieSort> query)
	{
		bool tryAgain = true;
		while (tryAgain)
		{
			try
			{
				return (!TLD0W5K9yiTCdcMEKT.IB3tMMvyI(jdChSJQb2h, TLD0W5K9yiTCdcMEKT.nOQLzI2sZW)) ? (await TEWC9kM4t8mTxnKwPSw.IB3tMMvyI(piK3V9MrI5NtfwmkMvJ.IB3tMMvyI(coehe6KvPF, piK3V9MrI5NtfwmkMvJ.x6sMFHKrwY), query, TEWC9kM4t8mTxnKwPSw.gsBMXT8qKX)) : (await TEWC9kM4t8mTxnKwPSw.IB3tMMvyI(piK3V9MrI5NtfwmkMvJ.IB3tMMvyI(coehe6KvPF, piK3V9MrI5NtfwmkMvJ.hoBMERmbAk), query, TEWC9kM4t8mTxnKwPSw.gsBMXT8qKX));
			}
			catch (Exception e)
			{
				PROTVException ex = new PROTVException(e);
				if (CDq5XOVSkTWxZo0hfQU.IB3tMMvyI(ex, CDq5XOVSkTWxZo0hfQU.wJ8Vnql80E) == ExceptionType.AuthorizationTokenInvalid)
				{
					try
					{
						await d81QmNVvT2C1ISNMQLb.IB3tMMvyI(tLjhb0uPR9, d81QmNVvT2C1ISNMQLb.eQmVM4BpWn);
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

	public async Task<Response<MovieResponseDto>> GetMovieAsync(int Id)
	{
		bool tryAgain = true;
		while (tryAgain)
		{
			try
			{
				return (!TLD0W5K9yiTCdcMEKT.IB3tMMvyI(jdChSJQb2h, TLD0W5K9yiTCdcMEKT.nOQLzI2sZW)) ? (await d8BseOM0CGdHp6VSKaj.IB3tMMvyI(piK3V9MrI5NtfwmkMvJ.IB3tMMvyI(coehe6KvPF, piK3V9MrI5NtfwmkMvJ.x6sMFHKrwY), Id, d8BseOM0CGdHp6VSKaj.a6yMTSNJrq)) : (await d8BseOM0CGdHp6VSKaj.IB3tMMvyI(piK3V9MrI5NtfwmkMvJ.IB3tMMvyI(coehe6KvPF, piK3V9MrI5NtfwmkMvJ.hoBMERmbAk), Id, d8BseOM0CGdHp6VSKaj.a6yMTSNJrq));
			}
			catch (Exception e)
			{
				PROTVException ex = new PROTVException(e);
				if (CDq5XOVSkTWxZo0hfQU.IB3tMMvyI(ex, CDq5XOVSkTWxZo0hfQU.wJ8Vnql80E) == ExceptionType.AuthorizationTokenInvalid)
				{
					try
					{
						await d81QmNVvT2C1ISNMQLb.IB3tMMvyI(tLjhb0uPR9, d81QmNVvT2C1ISNMQLb.eQmVM4BpWn);
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

	public async Task<Response<RentResponseDto>> RentMovieAsync(int Id)
	{
		bool tryAgain = true;
		while (tryAgain)
		{
			try
			{
				return (!TLD0W5K9yiTCdcMEKT.IB3tMMvyI(jdChSJQb2h, TLD0W5K9yiTCdcMEKT.nOQLzI2sZW)) ? (await V4tbvwMZZ77Y0plOpiB.IB3tMMvyI(piK3V9MrI5NtfwmkMvJ.IB3tMMvyI(coehe6KvPF, piK3V9MrI5NtfwmkMvJ.x6sMFHKrwY), Id, V4tbvwMZZ77Y0plOpiB.V1LMuXrKuR)) : (await V4tbvwMZZ77Y0plOpiB.IB3tMMvyI(piK3V9MrI5NtfwmkMvJ.IB3tMMvyI(coehe6KvPF, piK3V9MrI5NtfwmkMvJ.hoBMERmbAk), Id, V4tbvwMZZ77Y0plOpiB.V1LMuXrKuR));
			}
			catch (Exception e)
			{
				PROTVException ex = new PROTVException(e);
				if (CDq5XOVSkTWxZo0hfQU.IB3tMMvyI(ex, CDq5XOVSkTWxZo0hfQU.wJ8Vnql80E) == ExceptionType.AuthorizationTokenInvalid)
				{
					try
					{
						await d81QmNVvT2C1ISNMQLb.IB3tMMvyI(tLjhb0uPR9, d81QmNVvT2C1ISNMQLb.eQmVM4BpWn);
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

	public async Task<Response<IEnumerable<MovieResponseDto>>> GetRelatedMovieAsync(int Id)
	{
		bool tryAgain = true;
		while (tryAgain)
		{
			try
			{
				return (!TLD0W5K9yiTCdcMEKT.IB3tMMvyI(jdChSJQb2h, TLD0W5K9yiTCdcMEKT.nOQLzI2sZW)) ? (await MTO0HEM2tIHKKQUC1lD.IB3tMMvyI(piK3V9MrI5NtfwmkMvJ.IB3tMMvyI(coehe6KvPF, piK3V9MrI5NtfwmkMvJ.x6sMFHKrwY), Id, MTO0HEM2tIHKKQUC1lD.xYPMiaStTK)) : (await MTO0HEM2tIHKKQUC1lD.IB3tMMvyI(piK3V9MrI5NtfwmkMvJ.IB3tMMvyI(coehe6KvPF, piK3V9MrI5NtfwmkMvJ.hoBMERmbAk), Id, MTO0HEM2tIHKKQUC1lD.xYPMiaStTK));
			}
			catch (Exception e)
			{
				PROTVException ex = new PROTVException(e);
				if (CDq5XOVSkTWxZo0hfQU.IB3tMMvyI(ex, CDq5XOVSkTWxZo0hfQU.wJ8Vnql80E) == ExceptionType.AuthorizationTokenInvalid)
				{
					try
					{
						await d81QmNVvT2C1ISNMQLb.IB3tMMvyI(tLjhb0uPR9, d81QmNVvT2C1ISNMQLb.eQmVM4BpWn);
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

	public async Task<Response<bool>> ToggleFavoritesAsync(int Id)
	{
		bool tryAgain = true;
		while (tryAgain)
		{
			try
			{
				return (!TLD0W5K9yiTCdcMEKT.IB3tMMvyI(jdChSJQb2h, TLD0W5K9yiTCdcMEKT.nOQLzI2sZW)) ? (await b02guvnWlaMhfHYgQIF.IB3tMMvyI(piK3V9MrI5NtfwmkMvJ.IB3tMMvyI(coehe6KvPF, piK3V9MrI5NtfwmkMvJ.x6sMFHKrwY), Id, b02guvnWlaMhfHYgQIF.F3cMexN8tn)) : (await b02guvnWlaMhfHYgQIF.IB3tMMvyI(piK3V9MrI5NtfwmkMvJ.IB3tMMvyI(coehe6KvPF, piK3V9MrI5NtfwmkMvJ.hoBMERmbAk), Id, b02guvnWlaMhfHYgQIF.F3cMexN8tn));
			}
			catch (Exception e)
			{
				PROTVException ex = new PROTVException(e);
				if (CDq5XOVSkTWxZo0hfQU.IB3tMMvyI(ex, CDq5XOVSkTWxZo0hfQU.wJ8Vnql80E) == ExceptionType.AuthorizationTokenInvalid)
				{
					try
					{
						await d81QmNVvT2C1ISNMQLb.IB3tMMvyI(tLjhb0uPR9, d81QmNVvT2C1ISNMQLb.eQmVM4BpWn);
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
