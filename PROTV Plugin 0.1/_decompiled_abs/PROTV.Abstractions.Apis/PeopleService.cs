using System;
using System.Threading.Tasks;
using PROTV.Abstractions.Common;
using PROTV.Abstractions.DataTransferObjects;
using PROTV.Abstractions.Search;
using PROTV.Abstractions.Services;

namespace PROTV.Abstractions.Apis;

public class PeopleService : IPeopleService
{
	private readonly IAuthService vhShJeltC6;

	private readonly IStoreContext PXwhQsHaiI;

	private readonly IPTVApis PV2hLHuV0d;

	public PeopleService(IPTVApis iPTVApis, IAuthService authService, IStoreContext storeContext)
	{
		uiiVNagWnDNnTWnFgq.IB3tMMvyI(uiiVNagWnDNnTWnFgq.JyKLgPcm8);
		base._002Ector();
		vhShJeltC6 = authService;
		PV2hLHuV0d = iPTVApis;
		PXwhQsHaiI = storeContext;
	}

	public async Task<ResponseList<PersonResponseDto>> GetPeopleAsync(ApiQuery<PeopleSearch, GeneralSort> query)
	{
		bool tryAgain = true;
		while (tryAgain)
		{
			try
			{
				return (!TLD0W5K9yiTCdcMEKT.IB3tMMvyI(PXwhQsHaiI, TLD0W5K9yiTCdcMEKT.nOQLzI2sZW)) ? (await FBVfHEMQy6RxvP6QsP1.IB3tMMvyI(QnpvF2M3rZ9PZUpOgVN.IB3tMMvyI(PV2hLHuV0d, QnpvF2M3rZ9PZUpOgVN.GfxMWLB2Z0), query, FBVfHEMQy6RxvP6QsP1.oZJMk2DQ8j)) : (await FBVfHEMQy6RxvP6QsP1.IB3tMMvyI(QnpvF2M3rZ9PZUpOgVN.IB3tMMvyI(PV2hLHuV0d, QnpvF2M3rZ9PZUpOgVN.jiUMHZhlFO), query, FBVfHEMQy6RxvP6QsP1.oZJMk2DQ8j));
			}
			catch (Exception e)
			{
				PROTVException ex = new PROTVException(e);
				if (CDq5XOVSkTWxZo0hfQU.IB3tMMvyI(ex, CDq5XOVSkTWxZo0hfQU.wJ8Vnql80E) == ExceptionType.AuthorizationTokenInvalid)
				{
					try
					{
						await d81QmNVvT2C1ISNMQLb.IB3tMMvyI(vhShJeltC6, d81QmNVvT2C1ISNMQLb.eQmVM4BpWn);
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

	public async Task<Response<PersonResponseDto>> GetPersonAsync(int Id)
	{
		bool tryAgain = true;
		while (tryAgain)
		{
			try
			{
				return (!TLD0W5K9yiTCdcMEKT.IB3tMMvyI(PXwhQsHaiI, TLD0W5K9yiTCdcMEKT.nOQLzI2sZW)) ? (await YdvyudMJTMebLLPkjse.IB3tMMvyI(QnpvF2M3rZ9PZUpOgVN.IB3tMMvyI(PV2hLHuV0d, QnpvF2M3rZ9PZUpOgVN.GfxMWLB2Z0), Id, YdvyudMJTMebLLPkjse.HipMbi0jwj)) : (await YdvyudMJTMebLLPkjse.IB3tMMvyI(QnpvF2M3rZ9PZUpOgVN.IB3tMMvyI(PV2hLHuV0d, QnpvF2M3rZ9PZUpOgVN.jiUMHZhlFO), Id, YdvyudMJTMebLLPkjse.HipMbi0jwj));
			}
			catch (Exception e)
			{
				PROTVException ex = new PROTVException(e);
				if (CDq5XOVSkTWxZo0hfQU.IB3tMMvyI(ex, CDq5XOVSkTWxZo0hfQU.wJ8Vnql80E) == ExceptionType.AuthorizationTokenInvalid)
				{
					try
					{
						await d81QmNVvT2C1ISNMQLb.IB3tMMvyI(vhShJeltC6, d81QmNVvT2C1ISNMQLb.eQmVM4BpWn);
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
