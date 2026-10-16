using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PROTV.Abstractions.Apis;
using PROTV.Abstractions.Common;
using PROTV.Abstractions.DataTransferObjects;
using PROTV.Abstractions.Search;

namespace PROTV.Abstractions.Services;

public class AppService : IAppService
{
	private IPTVApis gDLy3JWWb;

	private readonly IStoreContext PUAFmdQSd;

	private readonly IAuthService TJJcWlh2B;

	public AppService(IPTVApis iPTVApis, IStoreContext storeContext, IAuthService authService)
	{
		uiiVNagWnDNnTWnFgq.IB3tMMvyI(uiiVNagWnDNnTWnFgq.JyKLgPcm8);
		base._002Ector();
		gDLy3JWWb = iPTVApis;
		PUAFmdQSd = storeContext;
		TJJcWlh2B = authService;
	}

	public async Task<Response<ClientMessageResponseDto>> SendMessageAsync(ClientMessageRequest clientMessage)
	{
		bool tryAgain = true;
		while (tryAgain)
		{
			try
			{
				return (!TLD0W5K9yiTCdcMEKT.IB3tMMvyI(PUAFmdQSd, TLD0W5K9yiTCdcMEKT.nOQLzI2sZW)) ? (await gCLEaEVgdpsOAsTk65C.IB3tMMvyI(Wr0CyiVwgqkvfhrYgTB.IB3tMMvyI(gDLy3JWWb, Wr0CyiVwgqkvfhrYgTB.tJVVVwABlx), clientMessage, gCLEaEVgdpsOAsTk65C.aCgVLNRiaS)) : (await gCLEaEVgdpsOAsTk65C.IB3tMMvyI(Wr0CyiVwgqkvfhrYgTB.IB3tMMvyI(gDLy3JWWb, Wr0CyiVwgqkvfhrYgTB.PGpVtkeZKv), clientMessage, gCLEaEVgdpsOAsTk65C.aCgVLNRiaS));
			}
			catch (Exception e)
			{
				PROTVException ex = new PROTVException(e);
				if (CDq5XOVSkTWxZo0hfQU.IB3tMMvyI(ex, CDq5XOVSkTWxZo0hfQU.wJ8Vnql80E) == ExceptionType.AuthorizationTokenInvalid)
				{
					try
					{
						await d81QmNVvT2C1ISNMQLb.IB3tMMvyI(TJJcWlh2B, d81QmNVvT2C1ISNMQLb.eQmVM4BpWn);
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

	public async Task<Response<ClientRequestResponseDto>> SendRequestAsync(ClientRequestRequest clientRequest)
	{
		bool tryAgain = true;
		while (tryAgain)
		{
			try
			{
				return (!TLD0W5K9yiTCdcMEKT.IB3tMMvyI(PUAFmdQSd, TLD0W5K9yiTCdcMEKT.nOQLzI2sZW)) ? (await JMOkk5V9RfH0P7jFbIs.IB3tMMvyI(Wr0CyiVwgqkvfhrYgTB.IB3tMMvyI(gDLy3JWWb, Wr0CyiVwgqkvfhrYgTB.tJVVVwABlx), clientRequest, JMOkk5V9RfH0P7jFbIs.jYYVjVh9ai)) : (await JMOkk5V9RfH0P7jFbIs.IB3tMMvyI(Wr0CyiVwgqkvfhrYgTB.IB3tMMvyI(gDLy3JWWb, Wr0CyiVwgqkvfhrYgTB.PGpVtkeZKv), clientRequest, JMOkk5V9RfH0P7jFbIs.jYYVjVh9ai));
			}
			catch (Exception e)
			{
				PROTVException ex = new PROTVException(e);
				if (CDq5XOVSkTWxZo0hfQU.IB3tMMvyI(ex, CDq5XOVSkTWxZo0hfQU.wJ8Vnql80E) == ExceptionType.AuthorizationTokenInvalid)
				{
					try
					{
						await d81QmNVvT2C1ISNMQLb.IB3tMMvyI(TJJcWlh2B, d81QmNVvT2C1ISNMQLb.eQmVM4BpWn);
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

	public async Task<ResponseList<DeviceResponseDto>> GetDevicesAsync(ApiQuery<GeneralSearch, GeneralSort> query)
	{
		bool tryAgain = true;
		while (tryAgain)
		{
			try
			{
				return (!TLD0W5K9yiTCdcMEKT.IB3tMMvyI(PUAFmdQSd, TLD0W5K9yiTCdcMEKT.nOQLzI2sZW)) ? (await P9ys6NVCZfaKllCcicL.IB3tMMvyI(Wr0CyiVwgqkvfhrYgTB.IB3tMMvyI(gDLy3JWWb, Wr0CyiVwgqkvfhrYgTB.tJVVVwABlx), query, P9ys6NVCZfaKllCcicL.jI2VIpSaUy)) : (await P9ys6NVCZfaKllCcicL.IB3tMMvyI(Wr0CyiVwgqkvfhrYgTB.IB3tMMvyI(gDLy3JWWb, Wr0CyiVwgqkvfhrYgTB.PGpVtkeZKv), query, P9ys6NVCZfaKllCcicL.jI2VIpSaUy));
			}
			catch (Exception e)
			{
				PROTVException ex = new PROTVException(e);
				if (CDq5XOVSkTWxZo0hfQU.IB3tMMvyI(ex, CDq5XOVSkTWxZo0hfQU.wJ8Vnql80E) == ExceptionType.AuthorizationTokenInvalid)
				{
					try
					{
						await d81QmNVvT2C1ISNMQLb.IB3tMMvyI(TJJcWlh2B, d81QmNVvT2C1ISNMQLb.eQmVM4BpWn);
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

	public async Task<Response<DeviceResponseDto>> GetCurrentDeviceAsync()
	{
		bool tryAgain = true;
		while (tryAgain)
		{
			try
			{
				return (!TLD0W5K9yiTCdcMEKT.IB3tMMvyI(PUAFmdQSd, TLD0W5K9yiTCdcMEKT.nOQLzI2sZW)) ? (await NK3qQHVfTZ3qDiWfi3P.IB3tMMvyI(Wr0CyiVwgqkvfhrYgTB.IB3tMMvyI(gDLy3JWWb, Wr0CyiVwgqkvfhrYgTB.tJVVVwABlx), NK3qQHVfTZ3qDiWfi3P.fjUVUoBFBZ)) : (await NK3qQHVfTZ3qDiWfi3P.IB3tMMvyI(Wr0CyiVwgqkvfhrYgTB.IB3tMMvyI(gDLy3JWWb, Wr0CyiVwgqkvfhrYgTB.PGpVtkeZKv), NK3qQHVfTZ3qDiWfi3P.fjUVUoBFBZ));
			}
			catch (Exception e)
			{
				PROTVException ex = new PROTVException(e);
				if (CDq5XOVSkTWxZo0hfQU.IB3tMMvyI(ex, CDq5XOVSkTWxZo0hfQU.wJ8Vnql80E) == ExceptionType.AuthorizationTokenInvalid)
				{
					try
					{
						await d81QmNVvT2C1ISNMQLb.IB3tMMvyI(TJJcWlh2B, d81QmNVvT2C1ISNMQLb.eQmVM4BpWn);
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

	public async Task<Response<string>> TerminateDeviceAsync(string deviceId)
	{
		bool tryAgain = true;
		while (tryAgain)
		{
			try
			{
				return (!TLD0W5K9yiTCdcMEKT.IB3tMMvyI(PUAFmdQSd, TLD0W5K9yiTCdcMEKT.nOQLzI2sZW)) ? (await TB6owmV5pk6HcP1Ib8d.IB3tMMvyI(Wr0CyiVwgqkvfhrYgTB.IB3tMMvyI(gDLy3JWWb, Wr0CyiVwgqkvfhrYgTB.tJVVVwABlx), deviceId, TB6owmV5pk6HcP1Ib8d.HLCV6CuZQR)) : (await TB6owmV5pk6HcP1Ib8d.IB3tMMvyI(Wr0CyiVwgqkvfhrYgTB.IB3tMMvyI(gDLy3JWWb, Wr0CyiVwgqkvfhrYgTB.PGpVtkeZKv), deviceId, TB6owmV5pk6HcP1Ib8d.HLCV6CuZQR));
			}
			catch (Exception e)
			{
				PROTVException ex = new PROTVException(e);
				if (CDq5XOVSkTWxZo0hfQU.IB3tMMvyI(ex, CDq5XOVSkTWxZo0hfQU.wJ8Vnql80E) == ExceptionType.AuthorizationTokenInvalid)
				{
					try
					{
						await d81QmNVvT2C1ISNMQLb.IB3tMMvyI(TJJcWlh2B, d81QmNVvT2C1ISNMQLb.eQmVM4BpWn);
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

	public async Task<ResponseList<CityResponseDto>> GetCitiesAsync(ApiQuery<GeneralSearch, GeneralSort> query)
	{
		bool tryAgain = true;
		while (tryAgain)
		{
			try
			{
				return (!TLD0W5K9yiTCdcMEKT.IB3tMMvyI(PUAFmdQSd, TLD0W5K9yiTCdcMEKT.nOQLzI2sZW)) ? (await IVs7qbVRbvfk7aWTWEF.IB3tMMvyI(Wr0CyiVwgqkvfhrYgTB.IB3tMMvyI(gDLy3JWWb, Wr0CyiVwgqkvfhrYgTB.tJVVVwABlx), query, IVs7qbVRbvfk7aWTWEF.sgWVd2iAd7)) : (await IVs7qbVRbvfk7aWTWEF.IB3tMMvyI(Wr0CyiVwgqkvfhrYgTB.IB3tMMvyI(gDLy3JWWb, Wr0CyiVwgqkvfhrYgTB.PGpVtkeZKv), query, IVs7qbVRbvfk7aWTWEF.sgWVd2iAd7));
			}
			catch (Exception e)
			{
				PROTVException ex = new PROTVException(e);
				if (CDq5XOVSkTWxZo0hfQU.IB3tMMvyI(ex, CDq5XOVSkTWxZo0hfQU.wJ8Vnql80E) == ExceptionType.AuthorizationTokenInvalid)
				{
					try
					{
						await d81QmNVvT2C1ISNMQLb.IB3tMMvyI(TJJcWlh2B, d81QmNVvT2C1ISNMQLb.eQmVM4BpWn);
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

	public async Task<Response<WeatherResponseDto>> GetCityWeatherAsync(int Id)
	{
		bool tryAgain = true;
		while (tryAgain)
		{
			try
			{
				return (!TLD0W5K9yiTCdcMEKT.IB3tMMvyI(PUAFmdQSd, TLD0W5K9yiTCdcMEKT.nOQLzI2sZW)) ? (await TUF3yhVlAorF7Jfp4ZS.IB3tMMvyI(Wr0CyiVwgqkvfhrYgTB.IB3tMMvyI(gDLy3JWWb, Wr0CyiVwgqkvfhrYgTB.tJVVVwABlx), Id, TUF3yhVlAorF7Jfp4ZS.UguVmqqMYa)) : (await TUF3yhVlAorF7Jfp4ZS.IB3tMMvyI(Wr0CyiVwgqkvfhrYgTB.IB3tMMvyI(gDLy3JWWb, Wr0CyiVwgqkvfhrYgTB.PGpVtkeZKv), Id, TUF3yhVlAorF7Jfp4ZS.UguVmqqMYa));
			}
			catch (Exception e)
			{
				PROTVException ex = new PROTVException(e);
				if (CDq5XOVSkTWxZo0hfQU.IB3tMMvyI(ex, CDq5XOVSkTWxZo0hfQU.wJ8Vnql80E) == ExceptionType.AuthorizationTokenInvalid)
				{
					try
					{
						await d81QmNVvT2C1ISNMQLb.IB3tMMvyI(TJJcWlh2B, d81QmNVvT2C1ISNMQLb.eQmVM4BpWn);
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

	public async Task<Response<WeatherResponseDto>> GetWeatherAsync(string lan, string lon)
	{
		bool tryAgain = true;
		while (tryAgain)
		{
			try
			{
				return (!TLD0W5K9yiTCdcMEKT.IB3tMMvyI(PUAFmdQSd, TLD0W5K9yiTCdcMEKT.nOQLzI2sZW)) ? (await djP9aaVp91gZpBRwQVj.IB3tMMvyI(Wr0CyiVwgqkvfhrYgTB.IB3tMMvyI(gDLy3JWWb, Wr0CyiVwgqkvfhrYgTB.tJVVVwABlx), lon, lan, djP9aaVp91gZpBRwQVj.VjWVcXoVxZ)) : (await djP9aaVp91gZpBRwQVj.IB3tMMvyI(Wr0CyiVwgqkvfhrYgTB.IB3tMMvyI(gDLy3JWWb, Wr0CyiVwgqkvfhrYgTB.PGpVtkeZKv), lon, lan, djP9aaVp91gZpBRwQVj.VjWVcXoVxZ));
			}
			catch (Exception e)
			{
				PROTVException ex = new PROTVException(e);
				if (CDq5XOVSkTWxZo0hfQU.IB3tMMvyI(ex, CDq5XOVSkTWxZo0hfQU.wJ8Vnql80E) == ExceptionType.AuthorizationTokenInvalid)
				{
					try
					{
						await d81QmNVvT2C1ISNMQLb.IB3tMMvyI(TJJcWlh2B, d81QmNVvT2C1ISNMQLb.eQmVM4BpWn);
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

	public async Task<ResponseList<CategoryResponseDto>> GetCategoriesAsync(ApiQuery<CategorySearch, GeneralSort> query)
	{
		bool tryAgain = true;
		while (tryAgain)
		{
			try
			{
				return (!TLD0W5K9yiTCdcMEKT.IB3tMMvyI(PUAFmdQSd, TLD0W5K9yiTCdcMEKT.nOQLzI2sZW)) ? (await SmfThDVq2rH4QLHAF03.IB3tMMvyI(Wr0CyiVwgqkvfhrYgTB.IB3tMMvyI(gDLy3JWWb, Wr0CyiVwgqkvfhrYgTB.tJVVVwABlx), query, SmfThDVq2rH4QLHAF03.OhNVOLwWTH)) : (await SmfThDVq2rH4QLHAF03.IB3tMMvyI(Wr0CyiVwgqkvfhrYgTB.IB3tMMvyI(gDLy3JWWb, Wr0CyiVwgqkvfhrYgTB.PGpVtkeZKv), query, SmfThDVq2rH4QLHAF03.OhNVOLwWTH));
			}
			catch (Exception e)
			{
				PROTVException ex = new PROTVException(e);
				if (CDq5XOVSkTWxZo0hfQU.IB3tMMvyI(ex, CDq5XOVSkTWxZo0hfQU.wJ8Vnql80E) == ExceptionType.AuthorizationTokenInvalid)
				{
					try
					{
						await d81QmNVvT2C1ISNMQLb.IB3tMMvyI(TJJcWlh2B, d81QmNVvT2C1ISNMQLb.eQmVM4BpWn);
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

	public async Task<Response<List<LanguageResponseDto>>> GetLanguagesAsync()
	{
		bool tryAgain = true;
		while (tryAgain)
		{
			try
			{
				return (!TLD0W5K9yiTCdcMEKT.IB3tMMvyI(PUAFmdQSd, TLD0W5K9yiTCdcMEKT.nOQLzI2sZW)) ? (await ecigOwVKpTf1FRRvDeg.IB3tMMvyI(Wr0CyiVwgqkvfhrYgTB.IB3tMMvyI(gDLy3JWWb, Wr0CyiVwgqkvfhrYgTB.tJVVVwABlx), ecigOwVKpTf1FRRvDeg.UrGVrvd7qD)) : (await ecigOwVKpTf1FRRvDeg.IB3tMMvyI(Wr0CyiVwgqkvfhrYgTB.IB3tMMvyI(gDLy3JWWb, Wr0CyiVwgqkvfhrYgTB.PGpVtkeZKv), ecigOwVKpTf1FRRvDeg.UrGVrvd7qD));
			}
			catch (Exception e)
			{
				PROTVException ex = new PROTVException(e);
				if (CDq5XOVSkTWxZo0hfQU.IB3tMMvyI(ex, CDq5XOVSkTWxZo0hfQU.wJ8Vnql80E) == ExceptionType.AuthorizationTokenInvalid)
				{
					try
					{
						await d81QmNVvT2C1ISNMQLb.IB3tMMvyI(TJJcWlh2B, d81QmNVvT2C1ISNMQLb.eQmVM4BpWn);
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

	public async Task<Response<AppVersionResponseDto>> GetLatestVersionAsync()
	{
		bool tryAgain = true;
		while (tryAgain)
		{
			try
			{
				return (!TLD0W5K9yiTCdcMEKT.IB3tMMvyI(PUAFmdQSd, TLD0W5K9yiTCdcMEKT.nOQLzI2sZW)) ? (await x8QRwqVEL6m3XmgiuHZ.IB3tMMvyI(Wr0CyiVwgqkvfhrYgTB.IB3tMMvyI(gDLy3JWWb, Wr0CyiVwgqkvfhrYgTB.tJVVVwABlx), x8QRwqVEL6m3XmgiuHZ.swsV4BJemt)) : (await x8QRwqVEL6m3XmgiuHZ.IB3tMMvyI(Wr0CyiVwgqkvfhrYgTB.IB3tMMvyI(gDLy3JWWb, Wr0CyiVwgqkvfhrYgTB.PGpVtkeZKv), x8QRwqVEL6m3XmgiuHZ.swsV4BJemt));
			}
			catch (Exception e)
			{
				PROTVException ex = new PROTVException(e);
				if (CDq5XOVSkTWxZo0hfQU.IB3tMMvyI(ex, CDq5XOVSkTWxZo0hfQU.wJ8Vnql80E) == ExceptionType.AuthorizationTokenInvalid)
				{
					try
					{
						await d81QmNVvT2C1ISNMQLb.IB3tMMvyI(TJJcWlh2B, d81QmNVvT2C1ISNMQLb.eQmVM4BpWn);
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

	public async Task<ResponseList<GalleryImageResponseDto>> GetGalleryImagesAsync(ApiQuery<GallerySearch, GeneralSort> query)
	{
		bool tryAgain = true;
		while (tryAgain)
		{
			try
			{
				return (!TLD0W5K9yiTCdcMEKT.IB3tMMvyI(PUAFmdQSd, TLD0W5K9yiTCdcMEKT.nOQLzI2sZW)) ? (await REe2syVXHaPvDCi7fMW.IB3tMMvyI(Wr0CyiVwgqkvfhrYgTB.IB3tMMvyI(gDLy3JWWb, Wr0CyiVwgqkvfhrYgTB.tJVVVwABlx), query, REe2syVXHaPvDCi7fMW.n8iVF7pqpK)) : (await REe2syVXHaPvDCi7fMW.IB3tMMvyI(Wr0CyiVwgqkvfhrYgTB.IB3tMMvyI(gDLy3JWWb, Wr0CyiVwgqkvfhrYgTB.PGpVtkeZKv), query, REe2syVXHaPvDCi7fMW.n8iVF7pqpK));
			}
			catch (Exception e)
			{
				PROTVException ex = new PROTVException(e);
				if (CDq5XOVSkTWxZo0hfQU.IB3tMMvyI(ex, CDq5XOVSkTWxZo0hfQU.wJ8Vnql80E) == ExceptionType.AuthorizationTokenInvalid)
				{
					try
					{
						await d81QmNVvT2C1ISNMQLb.IB3tMMvyI(TJJcWlh2B, d81QmNVvT2C1ISNMQLb.eQmVM4BpWn);
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

	public async Task<Response<EntertainmentResponseDto>> GetEntertainmentAsync()
	{
		bool tryAgain = true;
		while (tryAgain)
		{
			try
			{
				return (!TLD0W5K9yiTCdcMEKT.IB3tMMvyI(PUAFmdQSd, TLD0W5K9yiTCdcMEKT.nOQLzI2sZW)) ? (await ehZdhxV0sXrVa2flndu.IB3tMMvyI(Wr0CyiVwgqkvfhrYgTB.IB3tMMvyI(gDLy3JWWb, Wr0CyiVwgqkvfhrYgTB.tJVVVwABlx), ehZdhxV0sXrVa2flndu.jbjVTbtvva)) : (await ehZdhxV0sXrVa2flndu.IB3tMMvyI(Wr0CyiVwgqkvfhrYgTB.IB3tMMvyI(gDLy3JWWb, Wr0CyiVwgqkvfhrYgTB.PGpVtkeZKv), ehZdhxV0sXrVa2flndu.jbjVTbtvva));
			}
			catch (Exception e)
			{
				PROTVException ex = new PROTVException(e);
				if (CDq5XOVSkTWxZo0hfQU.IB3tMMvyI(ex, CDq5XOVSkTWxZo0hfQU.wJ8Vnql80E) == ExceptionType.AuthorizationTokenInvalid)
				{
					try
					{
						await d81QmNVvT2C1ISNMQLb.IB3tMMvyI(TJJcWlh2B, d81QmNVvT2C1ISNMQLb.eQmVM4BpWn);
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
