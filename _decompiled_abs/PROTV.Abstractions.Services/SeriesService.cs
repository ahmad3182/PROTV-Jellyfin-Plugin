using System;
using System.Threading.Tasks;
using PROTV.Abstractions.Apis;
using PROTV.Abstractions.Common;
using PROTV.Abstractions.DataTransferObjects;
using PROTV.Abstractions.Search;

namespace PROTV.Abstractions.Services;

public class SeriesService : ISeriesService
{
	private readonly IAuthService P6s8NnD01;

	private readonly IStoreContext YGlEeKbPH;

	private readonly IPTVApis fXvYIWL8D;

	public SeriesService(IPTVApis iPTVApis, IAuthService authService, IStoreContext storeContext)
	{
		uiiVNagWnDNnTWnFgq.IB3tMMvyI(uiiVNagWnDNnTWnFgq.JyKLgPcm8);
		base._002Ector();
		P6s8NnD01 = authService;
		fXvYIWL8D = iPTVApis;
		YGlEeKbPH = storeContext;
	}

	public async Task<ResponseList<SeriesResponseDto>> GetSeriesAsync(ApiQuery<SeriesSearch, SeriesSort> query)
	{
		bool tryAgain = true;
		while (tryAgain)
		{
			try
			{
				return (!TLD0W5K9yiTCdcMEKT.IB3tMMvyI(YGlEeKbPH, TLD0W5K9yiTCdcMEKT.nOQLzI2sZW)) ? (await tnURPtvLlWeQVk7jWex.IB3tMMvyI(vU34Y1vtnCLHXvl1CEm.IB3tMMvyI(fXvYIWL8D, vU34Y1vtnCLHXvl1CEm.eqZvSnYyAa), query, tnURPtvLlWeQVk7jWex.YR2vVh7rlt)) : (await tnURPtvLlWeQVk7jWex.IB3tMMvyI(vU34Y1vtnCLHXvl1CEm.IB3tMMvyI(fXvYIWL8D, vU34Y1vtnCLHXvl1CEm.XWYvgOX5hT), query, tnURPtvLlWeQVk7jWex.YR2vVh7rlt));
			}
			catch (Exception e)
			{
				PROTVException ex = new PROTVException(e);
				if (CDq5XOVSkTWxZo0hfQU.IB3tMMvyI(ex, CDq5XOVSkTWxZo0hfQU.wJ8Vnql80E) == ExceptionType.AuthorizationTokenInvalid)
				{
					try
					{
						await d81QmNVvT2C1ISNMQLb.IB3tMMvyI(P6s8NnD01, d81QmNVvT2C1ISNMQLb.eQmVM4BpWn);
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

	public async Task<Response<SeriesResponseDto>> GetSeriesDetailsAsync(int Id)
	{
		bool tryAgain = true;
		while (tryAgain)
		{
			try
			{
				return (!TLD0W5K9yiTCdcMEKT.IB3tMMvyI(YGlEeKbPH, TLD0W5K9yiTCdcMEKT.nOQLzI2sZW)) ? (await sjgHu1vnniapH9AvgOL.IB3tMMvyI(vU34Y1vtnCLHXvl1CEm.IB3tMMvyI(fXvYIWL8D, vU34Y1vtnCLHXvl1CEm.eqZvSnYyAa), Id, sjgHu1vnniapH9AvgOL.pFkvv4cv4e)) : (await sjgHu1vnniapH9AvgOL.IB3tMMvyI(vU34Y1vtnCLHXvl1CEm.IB3tMMvyI(fXvYIWL8D, vU34Y1vtnCLHXvl1CEm.XWYvgOX5hT), Id, sjgHu1vnniapH9AvgOL.pFkvv4cv4e));
			}
			catch (Exception e)
			{
				PROTVException ex = new PROTVException(e);
				if (CDq5XOVSkTWxZo0hfQU.IB3tMMvyI(ex, CDq5XOVSkTWxZo0hfQU.wJ8Vnql80E) == ExceptionType.AuthorizationTokenInvalid)
				{
					try
					{
						await d81QmNVvT2C1ISNMQLb.IB3tMMvyI(P6s8NnD01, d81QmNVvT2C1ISNMQLb.eQmVM4BpWn);
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
