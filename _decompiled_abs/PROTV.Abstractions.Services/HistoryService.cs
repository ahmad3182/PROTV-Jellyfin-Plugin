using System;
using System.Threading.Tasks;
using PROTV.Abstractions.Apis;
using PROTV.Abstractions.Common;
using PROTV.Abstractions.DataTransferObjects;

namespace PROTV.Abstractions.Services;

public class HistoryService : IHistoryService
{
	private readonly IAuthService R7ctZ9H79;

	private readonly IStoreContext Ee8juy3oD;

	private readonly IPTVApis hRi556cJ0;

	public HistoryService(IPTVApis iPTVApis, IStoreContext storeContext, IAuthService authService)
	{
		uiiVNagWnDNnTWnFgq.IB3tMMvyI(uiiVNagWnDNnTWnFgq.JyKLgPcm8);
		base._002Ector();
		hRi556cJ0 = iPTVApis;
		Ee8juy3oD = storeContext;
		R7ctZ9H79 = authService;
	}

	public async Task<Response<string>> AddMediaToHistoryAsync(int Id, HistoryType history)
	{
		bool tryAgain = true;
		while (tryAgain)
		{
			try
			{
				Response<string> result;
				if (TLD0W5K9yiTCdcMEKT.IB3tMMvyI(Ee8juy3oD, TLD0W5K9yiTCdcMEKT.nOQLzI2sZW))
				{
					IHistoryApi historyApi = l4JqtjnIGYxflvkIiIi.IB3tMMvyI(hRi556cJ0, l4JqtjnIGYxflvkIiIi.G1Unfaj4wS);
					NewMediaToHistoryRequest newMediaToHistoryRequest = new NewMediaToHistoryRequest();
					MngdScnUR0KQAXDNSBq.IB3tMMvyI(newMediaToHistoryRequest, history, MngdScnUR0KQAXDNSBq.gBun5s0ZJS);
					GTWJ1Nn6Vm4L7wbejIm.IB3tMMvyI(newMediaToHistoryRequest, Id, GTWJ1Nn6Vm4L7wbejIm.zOEnRPbBhS);
					result = await m9sxU6ndovccBIHd8hy.IB3tMMvyI(historyApi, newMediaToHistoryRequest, m9sxU6ndovccBIHd8hy.PcInlJkdl1);
				}
				else
				{
					IHistoryApi historyApi2 = l4JqtjnIGYxflvkIiIi.IB3tMMvyI(hRi556cJ0, l4JqtjnIGYxflvkIiIi.AAtnm9NCN1);
					NewMediaToHistoryRequest newMediaToHistoryRequest2 = new NewMediaToHistoryRequest();
					MngdScnUR0KQAXDNSBq.IB3tMMvyI(newMediaToHistoryRequest2, history, MngdScnUR0KQAXDNSBq.gBun5s0ZJS);
					GTWJ1Nn6Vm4L7wbejIm.IB3tMMvyI(newMediaToHistoryRequest2, Id, GTWJ1Nn6Vm4L7wbejIm.zOEnRPbBhS);
					result = await m9sxU6ndovccBIHd8hy.IB3tMMvyI(historyApi2, newMediaToHistoryRequest2, m9sxU6ndovccBIHd8hy.PcInlJkdl1);
				}
				return result;
			}
			catch (Exception e)
			{
				PROTVException ex = new PROTVException(e);
				if (CDq5XOVSkTWxZo0hfQU.IB3tMMvyI(ex, CDq5XOVSkTWxZo0hfQU.wJ8Vnql80E) == ExceptionType.AuthorizationTokenInvalid)
				{
					try
					{
						await d81QmNVvT2C1ISNMQLb.IB3tMMvyI(R7ctZ9H79, d81QmNVvT2C1ISNMQLb.eQmVM4BpWn);
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
