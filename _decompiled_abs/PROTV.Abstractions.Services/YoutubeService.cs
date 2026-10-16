using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PROTV.Abstractions.Apis;
using PROTV.Abstractions.Common;
using PROTV.Abstractions.DataTransferObjects;
using PROTV.Abstractions.Search;

namespace PROTV.Abstractions.Services;

public class YoutubeService : IYoutubeService
{
	private readonly IAuthService j6A6VCgY6;

	private readonly IStoreContext pvm7lY8st;

	private readonly IPTVApis gsbnniGnj;

	public YoutubeService(IPTVApis iPTVApis, IAuthService authService, IStoreContext storeContext)
	{
		uiiVNagWnDNnTWnFgq.IB3tMMvyI(uiiVNagWnDNnTWnFgq.JyKLgPcm8);
		base._002Ector();
		j6A6VCgY6 = authService;
		gsbnniGnj = iPTVApis;
		pvm7lY8st = storeContext;
	}

	public async Task<Response<YTHomePageResponseDto>> GetHomePageVideosAsync()
	{
		bool tryAgain = true;
		while (tryAgain)
		{
			try
			{
				return (!TLD0W5K9yiTCdcMEKT.IB3tMMvyI(pvm7lY8st, TLD0W5K9yiTCdcMEKT.nOQLzI2sZW)) ? (await fjUyNovjpFHVD1BaXcu.IB3tMMvyI(Uq1omsvMYymaMpojb2s.IB3tMMvyI(gsbnniGnj, Uq1omsvMYymaMpojb2s.sbdvItFyTM), fjUyNovjpFHVD1BaXcu.ocpvC4Acc8)) : (await fjUyNovjpFHVD1BaXcu.IB3tMMvyI(Uq1omsvMYymaMpojb2s.IB3tMMvyI(gsbnniGnj, Uq1omsvMYymaMpojb2s.eA9v9roX5g), fjUyNovjpFHVD1BaXcu.ocpvC4Acc8));
			}
			catch (Exception e)
			{
				PROTVException ex = new PROTVException(e);
				if (CDq5XOVSkTWxZo0hfQU.IB3tMMvyI(ex, CDq5XOVSkTWxZo0hfQU.wJ8Vnql80E) == ExceptionType.AuthorizationTokenInvalid)
				{
					try
					{
						await d81QmNVvT2C1ISNMQLb.IB3tMMvyI(j6A6VCgY6, d81QmNVvT2C1ISNMQLb.eQmVM4BpWn);
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

	public async Task<ResponseList<YTVideoResponseDto>> GetVideoListAsync(ApiQuery<YTSearch, YTVideoSort> query)
	{
		bool tryAgain = true;
		while (tryAgain)
		{
			try
			{
				return (!TLD0W5K9yiTCdcMEKT.IB3tMMvyI(pvm7lY8st, TLD0W5K9yiTCdcMEKT.nOQLzI2sZW)) ? (await n2CSncvfxx40k9B8xBJ.IB3tMMvyI(Uq1omsvMYymaMpojb2s.IB3tMMvyI(gsbnniGnj, Uq1omsvMYymaMpojb2s.sbdvItFyTM), query, n2CSncvfxx40k9B8xBJ.k15vUn8kRW)) : (await n2CSncvfxx40k9B8xBJ.IB3tMMvyI(Uq1omsvMYymaMpojb2s.IB3tMMvyI(gsbnniGnj, Uq1omsvMYymaMpojb2s.eA9v9roX5g), query, n2CSncvfxx40k9B8xBJ.k15vUn8kRW));
			}
			catch (Exception e)
			{
				PROTVException ex = new PROTVException(e);
				if (CDq5XOVSkTWxZo0hfQU.IB3tMMvyI(ex, CDq5XOVSkTWxZo0hfQU.wJ8Vnql80E) == ExceptionType.AuthorizationTokenInvalid)
				{
					try
					{
						await d81QmNVvT2C1ISNMQLb.IB3tMMvyI(j6A6VCgY6, d81QmNVvT2C1ISNMQLb.eQmVM4BpWn);
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

	public async Task<YTVideoResponseDto> GetVideoAsync(int Id)
	{
		bool tryAgain = true;
		while (tryAgain)
		{
			tryAgain = false;
			try
			{
				Response<YTVideoResponseDto> response = ((!TLD0W5K9yiTCdcMEKT.IB3tMMvyI(pvm7lY8st, TLD0W5K9yiTCdcMEKT.nOQLzI2sZW)) ? (await l0Fcscv5mEimOFFnf6n.IB3tMMvyI(Uq1omsvMYymaMpojb2s.IB3tMMvyI(gsbnniGnj, Uq1omsvMYymaMpojb2s.sbdvItFyTM), Id, l0Fcscv5mEimOFFnf6n.nJKv6W58Pj)) : (await l0Fcscv5mEimOFFnf6n.IB3tMMvyI(Uq1omsvMYymaMpojb2s.IB3tMMvyI(gsbnniGnj, Uq1omsvMYymaMpojb2s.eA9v9roX5g), Id, l0Fcscv5mEimOFFnf6n.nJKv6W58Pj)));
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
						await d81QmNVvT2C1ISNMQLb.IB3tMMvyI(j6A6VCgY6, d81QmNVvT2C1ISNMQLb.eQmVM4BpWn);
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

	public async Task<bool> ToggleWatchLaterAsync(int Id)
	{
		bool tryAgain = true;
		while (tryAgain)
		{
			tryAgain = false;
			try
			{
				Response<bool> response = ((!TLD0W5K9yiTCdcMEKT.IB3tMMvyI(pvm7lY8st, TLD0W5K9yiTCdcMEKT.nOQLzI2sZW)) ? (await b02guvnWlaMhfHYgQIF.IB3tMMvyI(Uq1omsvMYymaMpojb2s.IB3tMMvyI(gsbnniGnj, Uq1omsvMYymaMpojb2s.sbdvItFyTM), Id, b02guvnWlaMhfHYgQIF.ArbvRMKokD)) : (await b02guvnWlaMhfHYgQIF.IB3tMMvyI(Uq1omsvMYymaMpojb2s.IB3tMMvyI(gsbnniGnj, Uq1omsvMYymaMpojb2s.eA9v9roX5g), Id, b02guvnWlaMhfHYgQIF.ArbvRMKokD)));
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
						await d81QmNVvT2C1ISNMQLb.IB3tMMvyI(j6A6VCgY6, d81QmNVvT2C1ISNMQLb.eQmVM4BpWn);
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

	public async Task<int?> ReactYoutubeVideoAsync(int Id, int like)
	{
		bool tryAgain = true;
		while (tryAgain)
		{
			tryAgain = false;
			try
			{
				Response<YTReactionResponseDto> response;
				if (TLD0W5K9yiTCdcMEKT.IB3tMMvyI(pvm7lY8st, TLD0W5K9yiTCdcMEKT.nOQLzI2sZW))
				{
					IYoutubeApi youtubeApi = Uq1omsvMYymaMpojb2s.IB3tMMvyI(gsbnniGnj, Uq1omsvMYymaMpojb2s.eA9v9roX5g);
					ReactYtVideoRequest reactYtVideoRequest = new ReactYtVideoRequest();
					GTWJ1Nn6Vm4L7wbejIm.IB3tMMvyI(reactYtVideoRequest, like, GTWJ1Nn6Vm4L7wbejIm.alZvd3O3B1);
					GTWJ1Nn6Vm4L7wbejIm.IB3tMMvyI(reactYtVideoRequest, Id, GTWJ1Nn6Vm4L7wbejIm.xOWvlIxNvp);
					response = await x29dsnvmXhuGehUFxbg.IB3tMMvyI(youtubeApi, reactYtVideoRequest, x29dsnvmXhuGehUFxbg.yCXvpvVwkh);
				}
				else
				{
					IYoutubeApi youtubeApi2 = Uq1omsvMYymaMpojb2s.IB3tMMvyI(gsbnniGnj, Uq1omsvMYymaMpojb2s.eA9v9roX5g);
					ReactYtVideoRequest reactYtVideoRequest2 = new ReactYtVideoRequest();
					GTWJ1Nn6Vm4L7wbejIm.IB3tMMvyI(reactYtVideoRequest2, like, GTWJ1Nn6Vm4L7wbejIm.alZvd3O3B1);
					GTWJ1Nn6Vm4L7wbejIm.IB3tMMvyI(reactYtVideoRequest2, Id, GTWJ1Nn6Vm4L7wbejIm.xOWvlIxNvp);
					response = await x29dsnvmXhuGehUFxbg.IB3tMMvyI(youtubeApi2, reactYtVideoRequest2, x29dsnvmXhuGehUFxbg.yCXvpvVwkh);
				}
				if (response != null && response.Status)
				{
					return mkoNOjXNUCV3vRaLLm.IB3tMMvyI(response.Data, mkoNOjXNUCV3vRaLLm.QPQvcBAkhf);
				}
			}
			catch (Exception e)
			{
				PROTVException ex = new PROTVException(e);
				if (CDq5XOVSkTWxZo0hfQU.IB3tMMvyI(ex, CDq5XOVSkTWxZo0hfQU.wJ8Vnql80E) == ExceptionType.AuthorizationTokenInvalid)
				{
					try
					{
						await d81QmNVvT2C1ISNMQLb.IB3tMMvyI(j6A6VCgY6, d81QmNVvT2C1ISNMQLb.eQmVM4BpWn);
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

	public async Task<List<YTPlaylisTResponseDto>> GetPlaylistListAsync(ApiQuery<YTSearch, GeneralSort> query)
	{
		bool tryAgain = true;
		while (tryAgain)
		{
			tryAgain = false;
			try
			{
				ResponseList<YTPlaylisTResponseDto> responseList = ((!TLD0W5K9yiTCdcMEKT.IB3tMMvyI(pvm7lY8st, TLD0W5K9yiTCdcMEKT.nOQLzI2sZW)) ? (await qy0d9DvqhT1G74uYrxt.IB3tMMvyI(Uq1omsvMYymaMpojb2s.IB3tMMvyI(gsbnniGnj, Uq1omsvMYymaMpojb2s.sbdvItFyTM), query, qy0d9DvqhT1G74uYrxt.r0KvOOWUHC)) : (await qy0d9DvqhT1G74uYrxt.IB3tMMvyI(Uq1omsvMYymaMpojb2s.IB3tMMvyI(gsbnniGnj, Uq1omsvMYymaMpojb2s.eA9v9roX5g), query, qy0d9DvqhT1G74uYrxt.r0KvOOWUHC)));
				if (responseList != null && responseList.Status)
				{
					return responseList.Data.Result.ToList();
				}
			}
			catch (Exception e)
			{
				PROTVException ex = new PROTVException(e);
				if (CDq5XOVSkTWxZo0hfQU.IB3tMMvyI(ex, CDq5XOVSkTWxZo0hfQU.wJ8Vnql80E) == ExceptionType.AuthorizationTokenInvalid)
				{
					try
					{
						await d81QmNVvT2C1ISNMQLb.IB3tMMvyI(j6A6VCgY6, d81QmNVvT2C1ISNMQLb.eQmVM4BpWn);
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

	public async Task<YTPlaylisTResponseDto> GetPlaylistAsync(int Id)
	{
		bool tryAgain = true;
		while (tryAgain)
		{
			tryAgain = false;
			try
			{
				Response<YTPlaylisTResponseDto> response = ((!TLD0W5K9yiTCdcMEKT.IB3tMMvyI(pvm7lY8st, TLD0W5K9yiTCdcMEKT.nOQLzI2sZW)) ? (await fDsrDnvKhqDIIIdascT.IB3tMMvyI(Uq1omsvMYymaMpojb2s.IB3tMMvyI(gsbnniGnj, Uq1omsvMYymaMpojb2s.sbdvItFyTM), Id, fDsrDnvKhqDIIIdascT.QumvrxCMtC)) : (await fDsrDnvKhqDIIIdascT.IB3tMMvyI(Uq1omsvMYymaMpojb2s.IB3tMMvyI(gsbnniGnj, Uq1omsvMYymaMpojb2s.eA9v9roX5g), Id, fDsrDnvKhqDIIIdascT.QumvrxCMtC)));
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
						await d81QmNVvT2C1ISNMQLb.IB3tMMvyI(j6A6VCgY6, d81QmNVvT2C1ISNMQLb.eQmVM4BpWn);
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

	public async Task<ResponseList<YTChannelResponseDto>> GetChannelListAsync(ApiQuery<YTSearch, YTChannelSort> query)
	{
		bool tryAgain = true;
		while (tryAgain)
		{
			try
			{
				return (!TLD0W5K9yiTCdcMEKT.IB3tMMvyI(pvm7lY8st, TLD0W5K9yiTCdcMEKT.nOQLzI2sZW)) ? (await FA7raVvEccmw1Nk1427.IB3tMMvyI(Uq1omsvMYymaMpojb2s.IB3tMMvyI(gsbnniGnj, Uq1omsvMYymaMpojb2s.sbdvItFyTM), query, FA7raVvEccmw1Nk1427.S5Iv4atSUX)) : (await FA7raVvEccmw1Nk1427.IB3tMMvyI(Uq1omsvMYymaMpojb2s.IB3tMMvyI(gsbnniGnj, Uq1omsvMYymaMpojb2s.eA9v9roX5g), query, FA7raVvEccmw1Nk1427.S5Iv4atSUX));
			}
			catch (Exception e)
			{
				PROTVException ex = new PROTVException(e);
				if (CDq5XOVSkTWxZo0hfQU.IB3tMMvyI(ex, CDq5XOVSkTWxZo0hfQU.wJ8Vnql80E) == ExceptionType.AuthorizationTokenInvalid)
				{
					try
					{
						await d81QmNVvT2C1ISNMQLb.IB3tMMvyI(j6A6VCgY6, d81QmNVvT2C1ISNMQLb.eQmVM4BpWn);
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

	public async Task<YTChannelResponseDto> GetChannelAsync(int Id)
	{
		bool tryAgain = true;
		while (tryAgain)
		{
			tryAgain = false;
			try
			{
				Response<YTChannelResponseDto> response = ((!TLD0W5K9yiTCdcMEKT.IB3tMMvyI(pvm7lY8st, TLD0W5K9yiTCdcMEKT.nOQLzI2sZW)) ? (await vCyQgKvXKOKccbDKrQu.IB3tMMvyI(Uq1omsvMYymaMpojb2s.IB3tMMvyI(gsbnniGnj, Uq1omsvMYymaMpojb2s.sbdvItFyTM), Id, vCyQgKvXKOKccbDKrQu.wdmvFP5PUy)) : (await vCyQgKvXKOKccbDKrQu.IB3tMMvyI(Uq1omsvMYymaMpojb2s.IB3tMMvyI(gsbnniGnj, Uq1omsvMYymaMpojb2s.eA9v9roX5g), Id, vCyQgKvXKOKccbDKrQu.wdmvFP5PUy)));
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
						await d81QmNVvT2C1ISNMQLb.IB3tMMvyI(j6A6VCgY6, d81QmNVvT2C1ISNMQLb.eQmVM4BpWn);
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

	public async Task<bool> ToggleSubscribeChannelAsync(int Id)
	{
		bool tryAgain = true;
		while (tryAgain)
		{
			tryAgain = false;
			try
			{
				Response<bool> response = ((!TLD0W5K9yiTCdcMEKT.IB3tMMvyI(pvm7lY8st, TLD0W5K9yiTCdcMEKT.nOQLzI2sZW)) ? (await b02guvnWlaMhfHYgQIF.IB3tMMvyI(Uq1omsvMYymaMpojb2s.IB3tMMvyI(gsbnniGnj, Uq1omsvMYymaMpojb2s.sbdvItFyTM), Id, b02guvnWlaMhfHYgQIF.PYxv0YcXey)) : (await b02guvnWlaMhfHYgQIF.IB3tMMvyI(Uq1omsvMYymaMpojb2s.IB3tMMvyI(gsbnniGnj, Uq1omsvMYymaMpojb2s.eA9v9roX5g), Id, b02guvnWlaMhfHYgQIF.PYxv0YcXey)));
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
						await d81QmNVvT2C1ISNMQLb.IB3tMMvyI(j6A6VCgY6, d81QmNVvT2C1ISNMQLb.eQmVM4BpWn);
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

	public async Task<bool> AddVideoToHistoryAsync(int Id)
	{
		bool tryAgain = true;
		while (tryAgain)
		{
			tryAgain = false;
			try
			{
				Response<YTHistoryResponseDto> response;
				if (TLD0W5K9yiTCdcMEKT.IB3tMMvyI(pvm7lY8st, TLD0W5K9yiTCdcMEKT.nOQLzI2sZW))
				{
					IYoutubeApi youtubeApi = Uq1omsvMYymaMpojb2s.IB3tMMvyI(gsbnniGnj, Uq1omsvMYymaMpojb2s.eA9v9roX5g);
					YTHistoryRequest yTHistoryRequest = new YTHistoryRequest();
					GTWJ1Nn6Vm4L7wbejIm.IB3tMMvyI(yTHistoryRequest, 0, GTWJ1Nn6Vm4L7wbejIm.duVvTgV3Sn);
					GTWJ1Nn6Vm4L7wbejIm.IB3tMMvyI(yTHistoryRequest, Id, GTWJ1Nn6Vm4L7wbejIm.jwCvZPZyhx);
					response = await mo8tJhvuF4Qn8NlCm0s.IB3tMMvyI(youtubeApi, yTHistoryRequest, mo8tJhvuF4Qn8NlCm0s.Hq7v2o6aA6);
				}
				else
				{
					IYoutubeApi youtubeApi2 = Uq1omsvMYymaMpojb2s.IB3tMMvyI(gsbnniGnj, Uq1omsvMYymaMpojb2s.eA9v9roX5g);
					YTHistoryRequest yTHistoryRequest2 = new YTHistoryRequest();
					GTWJ1Nn6Vm4L7wbejIm.IB3tMMvyI(yTHistoryRequest2, 0, GTWJ1Nn6Vm4L7wbejIm.duVvTgV3Sn);
					GTWJ1Nn6Vm4L7wbejIm.IB3tMMvyI(yTHistoryRequest2, Id, GTWJ1Nn6Vm4L7wbejIm.jwCvZPZyhx);
					response = await mo8tJhvuF4Qn8NlCm0s.IB3tMMvyI(youtubeApi2, yTHistoryRequest2, mo8tJhvuF4Qn8NlCm0s.Hq7v2o6aA6);
				}
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
						await d81QmNVvT2C1ISNMQLb.IB3tMMvyI(j6A6VCgY6, d81QmNVvT2C1ISNMQLb.eQmVM4BpWn);
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

	public async Task<ResponseList<YTHistoryResponseDto>> GetVideoHistoryAsync(ApiQuery<YTSearch, GeneralSort> query)
	{
		bool tryAgain = true;
		while (tryAgain)
		{
			try
			{
				return (!TLD0W5K9yiTCdcMEKT.IB3tMMvyI(pvm7lY8st, TLD0W5K9yiTCdcMEKT.nOQLzI2sZW)) ? (await dD65iWvin1OTerTjMyF.IB3tMMvyI(Uq1omsvMYymaMpojb2s.IB3tMMvyI(gsbnniGnj, Uq1omsvMYymaMpojb2s.sbdvItFyTM), query, dD65iWvin1OTerTjMyF.kwRvebUMYf)) : (await dD65iWvin1OTerTjMyF.IB3tMMvyI(Uq1omsvMYymaMpojb2s.IB3tMMvyI(gsbnniGnj, Uq1omsvMYymaMpojb2s.eA9v9roX5g), query, dD65iWvin1OTerTjMyF.kwRvebUMYf));
			}
			catch (Exception e)
			{
				PROTVException ex = new PROTVException(e);
				if (CDq5XOVSkTWxZo0hfQU.IB3tMMvyI(ex, CDq5XOVSkTWxZo0hfQU.wJ8Vnql80E) == ExceptionType.AuthorizationTokenInvalid)
				{
					try
					{
						await d81QmNVvT2C1ISNMQLb.IB3tMMvyI(j6A6VCgY6, d81QmNVvT2C1ISNMQLb.eQmVM4BpWn);
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

	public async Task<bool> DeleteVideoFromHistoryAsync(int Id)
	{
		bool tryAgain = true;
		while (tryAgain)
		{
			tryAgain = false;
			try
			{
				Response<string> response = ((!TLD0W5K9yiTCdcMEKT.IB3tMMvyI(pvm7lY8st, TLD0W5K9yiTCdcMEKT.nOQLzI2sZW)) ? (await ELQHsfnbG5PanCPaDkO.IB3tMMvyI(Uq1omsvMYymaMpojb2s.IB3tMMvyI(gsbnniGnj, Uq1omsvMYymaMpojb2s.eA9v9roX5g), Id, ELQHsfnbG5PanCPaDkO.VJVv3dRAWn)) : (await ELQHsfnbG5PanCPaDkO.IB3tMMvyI(Uq1omsvMYymaMpojb2s.IB3tMMvyI(gsbnniGnj, Uq1omsvMYymaMpojb2s.eA9v9roX5g), Id, ELQHsfnbG5PanCPaDkO.VJVv3dRAWn)));
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
						await d81QmNVvT2C1ISNMQLb.IB3tMMvyI(j6A6VCgY6, d81QmNVvT2C1ISNMQLb.eQmVM4BpWn);
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

	public async Task<bool> ClearHistoryAsync()
	{
		bool tryAgain = true;
		while (tryAgain)
		{
			tryAgain = false;
			try
			{
				Response<string> response = ((!TLD0W5K9yiTCdcMEKT.IB3tMMvyI(pvm7lY8st, TLD0W5K9yiTCdcMEKT.nOQLzI2sZW)) ? (await nRbcstvHvN7OVeN7HYJ.IB3tMMvyI(Uq1omsvMYymaMpojb2s.IB3tMMvyI(gsbnniGnj, Uq1omsvMYymaMpojb2s.eA9v9roX5g), nRbcstvHvN7OVeN7HYJ.vLCvQxFsco)) : (await nRbcstvHvN7OVeN7HYJ.IB3tMMvyI(Uq1omsvMYymaMpojb2s.IB3tMMvyI(gsbnniGnj, Uq1omsvMYymaMpojb2s.eA9v9roX5g), nRbcstvHvN7OVeN7HYJ.vLCvQxFsco)));
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
						await d81QmNVvT2C1ISNMQLb.IB3tMMvyI(j6A6VCgY6, d81QmNVvT2C1ISNMQLb.eQmVM4BpWn);
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
}
