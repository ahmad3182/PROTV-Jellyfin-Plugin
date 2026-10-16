using System;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using PROTV.Abstractions.Apis;
using PROTV.Abstractions.Common;
using PROTV.Abstractions.DataTransferObjects;
using Refit;

namespace PROTV.Abstractions.Services;

public class AuthService : IAuthService
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass12_0
	{
		public string bMv2NfWKR3;

		public _003C_003Ec__DisplayClass12_0()
		{
			uiiVNagWnDNnTWnFgq.IB3tMMvyI(uiiVNagWnDNnTWnFgq.JyKLgPcm8);
			base._002Ector();
		}

		internal Task<string> K6ghzJAvte()
		{
			return Task.FromResult(bMv2NfWKR3);
		}
	}

	private readonly IPTVApis K4PaNbs6t;

	private readonly IStoreContext SdbPhbd7X;

	public AuthService(IPTVApis iPTVApis, IStoreContext storeContext)
	{
		uiiVNagWnDNnTWnFgq.IB3tMMvyI(uiiVNagWnDNnTWnFgq.JyKLgPcm8);
		base._002Ector();
		K4PaNbs6t = iPTVApis;
		SdbPhbd7X = storeContext;
	}

	public async Task<Response<LoginResponseDto>> LoginAsync(string userName, string Password)
	{
		_ = 1;
		try
		{
			LoginApiRequest loginApiRequest = new LoginApiRequest();
			QV5Py2LOX8yx6ajM6nW.IB3tMMvyI(loginApiRequest, Password, QV5Py2LOX8yx6ajM6nW.WbfVZQZnfw);
			QV5Py2LOX8yx6ajM6nW.IB3tMMvyI(loginApiRequest, userName, QV5Py2LOX8yx6ajM6nW.JilVufhvRh);
			LoginApiRequest loginApiRequest2 = loginApiRequest;
			Response<LoginResponseDto> response = ((!TLD0W5K9yiTCdcMEKT.IB3tMMvyI(SdbPhbd7X, TLD0W5K9yiTCdcMEKT.nOQLzI2sZW)) ? (await RB8N4MVJgUIt0iNQUa9.IB3tMMvyI(Y73PWxV27aDmcW7uONE.IB3tMMvyI(K4PaNbs6t, Y73PWxV27aDmcW7uONE.GDoV7c7wrF), loginApiRequest2, BkFFwYmT10k6taWbxb.IB3tMMvyI(SdbPhbd7X, BkFFwYmT10k6taWbxb.eaYVeOKpaM), BkFFwYmT10k6taWbxb.IB3tMMvyI(SdbPhbd7X, BkFFwYmT10k6taWbxb.iVQV3ieJHU), BkFFwYmT10k6taWbxb.IB3tMMvyI(SdbPhbd7X, BkFFwYmT10k6taWbxb.puXVHnEaM2), BkFFwYmT10k6taWbxb.IB3tMMvyI(SdbPhbd7X, BkFFwYmT10k6taWbxb.XG9VQTtWKR), BkFFwYmT10k6taWbxb.IB3tMMvyI(SdbPhbd7X, BkFFwYmT10k6taWbxb.nRtVkmiU6T), BkFFwYmT10k6taWbxb.IB3tMMvyI(SdbPhbd7X, BkFFwYmT10k6taWbxb.g1yVW2F419), RB8N4MVJgUIt0iNQUa9.K35Vb8QX4V)) : (await RB8N4MVJgUIt0iNQUa9.IB3tMMvyI(Y73PWxV27aDmcW7uONE.IB3tMMvyI(K4PaNbs6t, Y73PWxV27aDmcW7uONE.TAxViq2iYl), loginApiRequest2, BkFFwYmT10k6taWbxb.IB3tMMvyI(SdbPhbd7X, BkFFwYmT10k6taWbxb.eaYVeOKpaM), BkFFwYmT10k6taWbxb.IB3tMMvyI(SdbPhbd7X, BkFFwYmT10k6taWbxb.iVQV3ieJHU), BkFFwYmT10k6taWbxb.IB3tMMvyI(SdbPhbd7X, BkFFwYmT10k6taWbxb.puXVHnEaM2), BkFFwYmT10k6taWbxb.IB3tMMvyI(SdbPhbd7X, BkFFwYmT10k6taWbxb.XG9VQTtWKR), BkFFwYmT10k6taWbxb.IB3tMMvyI(SdbPhbd7X, BkFFwYmT10k6taWbxb.nRtVkmiU6T), BkFFwYmT10k6taWbxb.IB3tMMvyI(SdbPhbd7X, BkFFwYmT10k6taWbxb.g1yVW2F419), RB8N4MVJgUIt0iNQUa9.K35Vb8QX4V)));
			if (response.Status)
			{
				if (LSFD6gVBu8gHym8MnFC.IB3tMMvyI(ITq2b4VacNCwVAUkUEM.IB3tMMvyI(j5ZLXJVYkZGn9Ioacdg.IB3tMMvyI(response.Data, j5ZLXJVYkZGn9Ioacdg.evuVDR4ItC), ITq2b4VacNCwVAUkUEM.oHDVPBeB3c), LSFD6gVBu8gHym8MnFC.kicV1nTk5G).Any())
				{
					RHAkZkVyRlGKyAFkZ9S.IB3tMMvyI(LSFD6gVBu8gHym8MnFC.IB3tMMvyI(ITq2b4VacNCwVAUkUEM.IB3tMMvyI(j5ZLXJVYkZGn9Ioacdg.IB3tMMvyI(response.Data, j5ZLXJVYkZGn9Ioacdg.evuVDR4ItC), ITq2b4VacNCwVAUkUEM.oHDVPBeB3c), LSFD6gVBu8gHym8MnFC.kicV1nTk5G).FirstOrDefault(), true, RHAkZkVyRlGKyAFkZ9S.Q3PVoJlRuL);
					RHAkZkVyRlGKyAFkZ9S.IB3tMMvyI(LSFD6gVBu8gHym8MnFC.IB3tMMvyI(ITq2b4VacNCwVAUkUEM.IB3tMMvyI(j5ZLXJVYkZGn9Ioacdg.IB3tMMvyI(response.Data, j5ZLXJVYkZGn9Ioacdg.evuVDR4ItC), ITq2b4VacNCwVAUkUEM.oHDVPBeB3c), LSFD6gVBu8gHym8MnFC.kicV1nTk5G).LastOrDefault(), true, RHAkZkVyRlGKyAFkZ9S.rVjV8AMlSh);
				}
				if (Sbg972VNPyZXdHhScEE.IB3tMMvyI(ITq2b4VacNCwVAUkUEM.IB3tMMvyI(j5ZLXJVYkZGn9Ioacdg.IB3tMMvyI(response.Data, j5ZLXJVYkZGn9Ioacdg.evuVDR4ItC), ITq2b4VacNCwVAUkUEM.oHDVPBeB3c), Sbg972VNPyZXdHhScEE.gH7VGjOXm0).Any())
				{
					RHAkZkVyRlGKyAFkZ9S.IB3tMMvyI(Sbg972VNPyZXdHhScEE.IB3tMMvyI(ITq2b4VacNCwVAUkUEM.IB3tMMvyI(j5ZLXJVYkZGn9Ioacdg.IB3tMMvyI(response.Data, j5ZLXJVYkZGn9Ioacdg.evuVDR4ItC), ITq2b4VacNCwVAUkUEM.oHDVPBeB3c), Sbg972VNPyZXdHhScEE.gH7VGjOXm0).FirstOrDefault(), true, RHAkZkVyRlGKyAFkZ9S.zB2VhuHPii);
					RHAkZkVyRlGKyAFkZ9S.IB3tMMvyI(Sbg972VNPyZXdHhScEE.IB3tMMvyI(ITq2b4VacNCwVAUkUEM.IB3tMMvyI(j5ZLXJVYkZGn9Ioacdg.IB3tMMvyI(response.Data, j5ZLXJVYkZGn9Ioacdg.evuVDR4ItC), ITq2b4VacNCwVAUkUEM.oHDVPBeB3c), Sbg972VNPyZXdHhScEE.gH7VGjOXm0).LastOrDefault(), true, RHAkZkVyRlGKyAFkZ9S.zJlVAKc0MB);
				}
				QV5Py2LOX8yx6ajM6nW.IB3tMMvyI(SdbPhbd7X, userName, QV5Py2LOX8yx6ajM6nW.UcuVshoK4Q);
				QV5Py2LOX8yx6ajM6nW.IB3tMMvyI(SdbPhbd7X, Password, QV5Py2LOX8yx6ajM6nW.ICuVxR6CtB);
				SerqGHSt45o8ybhbS9V.IB3tMMvyI(SdbPhbd7X, YslQcaVzVUGZyCXkm6i.IB3tMMvyI(response.Data, YslQcaVzVUGZyCXkm6i.nxVSwCg9IZ), SerqGHSt45o8ybhbS9V.TNTSgR9Wc0);
				rGuRMdSLgIUbKkdtW1N.IB3tMMvyI(SdbPhbd7X, j5ZLXJVYkZGn9Ioacdg.IB3tMMvyI(response.Data, j5ZLXJVYkZGn9Ioacdg.evuVDR4ItC), rGuRMdSLgIUbKkdtW1N.t1ISVAbAlA);
				NNEWAsSviRlRwSRsBFp.IB3tMMvyI(SdbPhbd7X, YCvJULSS8jRsghuUvXk.IB3tMMvyI(response.Data, YCvJULSS8jRsghuUvXk.PGISnBQrXp), NNEWAsSviRlRwSRsBFp.J4pSM8aKdq);
				QV5Py2LOX8yx6ajM6nW.IB3tMMvyI(SdbPhbd7X, BkFFwYmT10k6taWbxb.IB3tMMvyI(j5ZLXJVYkZGn9Ioacdg.IB3tMMvyI(response.Data, j5ZLXJVYkZGn9Ioacdg.evuVDR4ItC), BkFFwYmT10k6taWbxb.M4uS97fp6e), QV5Py2LOX8yx6ajM6nW.LOrSjnOYrO);
				QV5Py2LOX8yx6ajM6nW.IB3tMMvyI(SdbPhbd7X, BkFFwYmT10k6taWbxb.IB3tMMvyI(YslQcaVzVUGZyCXkm6i.IB3tMMvyI(response.Data, YslQcaVzVUGZyCXkm6i.nxVSwCg9IZ), BkFFwYmT10k6taWbxb.inySC44OKq), QV5Py2LOX8yx6ajM6nW.atkSIyvswN);
				try
				{
					IStoreContext sdbPhbd7X = SdbPhbd7X;
					DateTime dateTime = ix0AP1guMX2I0U7xh8u.IB3tMMvyI(ix0AP1guMX2I0U7xh8u.Bchg200s7j);
					string value;
					if (!(baRVYtSfN7aiQO1pJ2W.IB3tMMvyI(ref dateTime, baRVYtSfN7aiQO1pJ2W.kBoSUSpJ9n) <= P9KPPOS6nKmEh9KdOkP.IB3tMMvyI(YCvJULSS8jRsghuUvXk.IB3tMMvyI(SdbPhbd7X, YCvJULSS8jRsghuUvXk.H7WS5JcWxU), P9KPPOS6nKmEh9KdOkP.ClbSRfq0wP)))
					{
						dateTime = ix0AP1guMX2I0U7xh8u.IB3tMMvyI(ix0AP1guMX2I0U7xh8u.Bchg200s7j);
						int year = baRVYtSfN7aiQO1pJ2W.IB3tMMvyI(ref dateTime, baRVYtSfN7aiQO1pJ2W.OWGSdnGb1u);
						dateTime = ix0AP1guMX2I0U7xh8u.IB3tMMvyI(ix0AP1guMX2I0U7xh8u.Bchg200s7j);
						dateTime = new DateTime(year, baRVYtSfN7aiQO1pJ2W.IB3tMMvyI(ref dateTime, baRVYtSfN7aiQO1pJ2W.cHASlk2ON2), P9KPPOS6nKmEh9KdOkP.IB3tMMvyI(YCvJULSS8jRsghuUvXk.IB3tMMvyI(SdbPhbd7X, YCvJULSS8jRsghuUvXk.H7WS5JcWxU), P9KPPOS6nKmEh9KdOkP.ClbSRfq0wP).Value);
						dateTime = GVVUkGSmQ9yO0YNRmgh.IB3tMMvyI(ref dateTime, 1, GVVUkGSmQ9yO0YNRmgh.GQ0SpFQbrC);
						value = BYjHjqSc81nB8pmS54u.IB3tMMvyI(ref dateTime, q2no0WnPxDaipZawxT.IB3tMMvyI(5570, q2no0WnPxDaipZawxT.eV4vC1LZv), BYjHjqSc81nB8pmS54u.xmPSqR4Anb);
					}
					else
					{
						dateTime = ix0AP1guMX2I0U7xh8u.IB3tMMvyI(ix0AP1guMX2I0U7xh8u.Bchg200s7j);
						int year2 = baRVYtSfN7aiQO1pJ2W.IB3tMMvyI(ref dateTime, baRVYtSfN7aiQO1pJ2W.OWGSdnGb1u);
						dateTime = ix0AP1guMX2I0U7xh8u.IB3tMMvyI(ix0AP1guMX2I0U7xh8u.Bchg200s7j);
						dateTime = new DateTime(year2, baRVYtSfN7aiQO1pJ2W.IB3tMMvyI(ref dateTime, baRVYtSfN7aiQO1pJ2W.cHASlk2ON2), P9KPPOS6nKmEh9KdOkP.IB3tMMvyI(YCvJULSS8jRsghuUvXk.IB3tMMvyI(SdbPhbd7X, YCvJULSS8jRsghuUvXk.H7WS5JcWxU), P9KPPOS6nKmEh9KdOkP.ClbSRfq0wP).Value);
						value = BYjHjqSc81nB8pmS54u.IB3tMMvyI(ref dateTime, q2no0WnPxDaipZawxT.IB3tMMvyI(5570, q2no0WnPxDaipZawxT.eV4vC1LZv), BYjHjqSc81nB8pmS54u.xmPSqR4Anb);
					}
					QV5Py2LOX8yx6ajM6nW.IB3tMMvyI(sdbPhbd7X, value, QV5Py2LOX8yx6ajM6nW.yE1SOZOGuR);
				}
				catch
				{
					IStoreContext sdbPhbd7X2 = SdbPhbd7X;
					DateTime dateTime = ix0AP1guMX2I0U7xh8u.IB3tMMvyI(ix0AP1guMX2I0U7xh8u.Bchg200s7j);
					int year3 = baRVYtSfN7aiQO1pJ2W.IB3tMMvyI(ref dateTime, baRVYtSfN7aiQO1pJ2W.OWGSdnGb1u);
					dateTime = ix0AP1guMX2I0U7xh8u.IB3tMMvyI(ix0AP1guMX2I0U7xh8u.Bchg200s7j);
					dateTime = new DateTime(year3, baRVYtSfN7aiQO1pJ2W.IB3tMMvyI(ref dateTime, baRVYtSfN7aiQO1pJ2W.cHASlk2ON2), 1);
					dateTime = GVVUkGSmQ9yO0YNRmgh.IB3tMMvyI(ref dateTime, 1, GVVUkGSmQ9yO0YNRmgh.GQ0SpFQbrC);
					dateTime = sioZiESKNZf5OZChXVI.IB3tMMvyI(ref dateTime, -1.0, sioZiESKNZf5OZChXVI.AUASrrZSZ3);
					QV5Py2LOX8yx6ajM6nW.IB3tMMvyI(sdbPhbd7X2, BYjHjqSc81nB8pmS54u.IB3tMMvyI(ref dateTime, q2no0WnPxDaipZawxT.IB3tMMvyI(5570, q2no0WnPxDaipZawxT.eV4vC1LZv), BYjHjqSc81nB8pmS54u.xmPSqR4Anb), QV5Py2LOX8yx6ajM6nW.yE1SOZOGuR);
				}
				xbpXba64taw5VdWx0Y.IB3tMMvyI(this, xbpXba64taw5VdWx0Y.R3BSEyIeL9);
			}
			return response;
		}
		catch (Exception e)
		{
			throw new PROTVException(e);
		}
	}

	public async Task<Response<LoginResponseDto>> RefreshTokenAsync()
	{
		Response<LoginResponseDto> result = default(Response<LoginResponseDto>);
		object obj2;
		int num;
		try
		{
			Response<LoginResponseDto> response = ((!TLD0W5K9yiTCdcMEKT.IB3tMMvyI(SdbPhbd7X, TLD0W5K9yiTCdcMEKT.nOQLzI2sZW)) ? (await FJqEB7SXGnGasg1KSAN.IB3tMMvyI(Y73PWxV27aDmcW7uONE.IB3tMMvyI(K4PaNbs6t, Y73PWxV27aDmcW7uONE.GDoV7c7wrF), BkFFwYmT10k6taWbxb.IB3tMMvyI(SdbPhbd7X, BkFFwYmT10k6taWbxb.YQrS4XQZZ4), BkFFwYmT10k6taWbxb.IB3tMMvyI(SdbPhbd7X, BkFFwYmT10k6taWbxb.eaYVeOKpaM), BkFFwYmT10k6taWbxb.IB3tMMvyI(SdbPhbd7X, BkFFwYmT10k6taWbxb.iVQV3ieJHU), BkFFwYmT10k6taWbxb.IB3tMMvyI(SdbPhbd7X, BkFFwYmT10k6taWbxb.puXVHnEaM2), BkFFwYmT10k6taWbxb.IB3tMMvyI(SdbPhbd7X, BkFFwYmT10k6taWbxb.XG9VQTtWKR), BkFFwYmT10k6taWbxb.IB3tMMvyI(SdbPhbd7X, BkFFwYmT10k6taWbxb.nRtVkmiU6T), BkFFwYmT10k6taWbxb.IB3tMMvyI(SdbPhbd7X, BkFFwYmT10k6taWbxb.g1yVW2F419), FJqEB7SXGnGasg1KSAN.QCqSFqrv5j)) : (await FJqEB7SXGnGasg1KSAN.IB3tMMvyI(Y73PWxV27aDmcW7uONE.IB3tMMvyI(K4PaNbs6t, Y73PWxV27aDmcW7uONE.TAxViq2iYl), BkFFwYmT10k6taWbxb.IB3tMMvyI(SdbPhbd7X, BkFFwYmT10k6taWbxb.YQrS4XQZZ4), BkFFwYmT10k6taWbxb.IB3tMMvyI(SdbPhbd7X, BkFFwYmT10k6taWbxb.eaYVeOKpaM), BkFFwYmT10k6taWbxb.IB3tMMvyI(SdbPhbd7X, BkFFwYmT10k6taWbxb.iVQV3ieJHU), BkFFwYmT10k6taWbxb.IB3tMMvyI(SdbPhbd7X, BkFFwYmT10k6taWbxb.puXVHnEaM2), BkFFwYmT10k6taWbxb.IB3tMMvyI(SdbPhbd7X, BkFFwYmT10k6taWbxb.XG9VQTtWKR), BkFFwYmT10k6taWbxb.IB3tMMvyI(SdbPhbd7X, BkFFwYmT10k6taWbxb.nRtVkmiU6T), BkFFwYmT10k6taWbxb.IB3tMMvyI(SdbPhbd7X, BkFFwYmT10k6taWbxb.g1yVW2F419), FJqEB7SXGnGasg1KSAN.QCqSFqrv5j)));
			if (response.Status)
			{
				if (LSFD6gVBu8gHym8MnFC.IB3tMMvyI(ITq2b4VacNCwVAUkUEM.IB3tMMvyI(j5ZLXJVYkZGn9Ioacdg.IB3tMMvyI(response.Data, j5ZLXJVYkZGn9Ioacdg.evuVDR4ItC), ITq2b4VacNCwVAUkUEM.oHDVPBeB3c), LSFD6gVBu8gHym8MnFC.kicV1nTk5G).Any())
				{
					RHAkZkVyRlGKyAFkZ9S.IB3tMMvyI(LSFD6gVBu8gHym8MnFC.IB3tMMvyI(ITq2b4VacNCwVAUkUEM.IB3tMMvyI(j5ZLXJVYkZGn9Ioacdg.IB3tMMvyI(response.Data, j5ZLXJVYkZGn9Ioacdg.evuVDR4ItC), ITq2b4VacNCwVAUkUEM.oHDVPBeB3c), LSFD6gVBu8gHym8MnFC.kicV1nTk5G).FirstOrDefault(), true, RHAkZkVyRlGKyAFkZ9S.Q3PVoJlRuL);
					RHAkZkVyRlGKyAFkZ9S.IB3tMMvyI(LSFD6gVBu8gHym8MnFC.IB3tMMvyI(ITq2b4VacNCwVAUkUEM.IB3tMMvyI(j5ZLXJVYkZGn9Ioacdg.IB3tMMvyI(response.Data, j5ZLXJVYkZGn9Ioacdg.evuVDR4ItC), ITq2b4VacNCwVAUkUEM.oHDVPBeB3c), LSFD6gVBu8gHym8MnFC.kicV1nTk5G).LastOrDefault(), true, RHAkZkVyRlGKyAFkZ9S.rVjV8AMlSh);
				}
				if (Sbg972VNPyZXdHhScEE.IB3tMMvyI(ITq2b4VacNCwVAUkUEM.IB3tMMvyI(j5ZLXJVYkZGn9Ioacdg.IB3tMMvyI(response.Data, j5ZLXJVYkZGn9Ioacdg.evuVDR4ItC), ITq2b4VacNCwVAUkUEM.oHDVPBeB3c), Sbg972VNPyZXdHhScEE.gH7VGjOXm0).Any())
				{
					RHAkZkVyRlGKyAFkZ9S.IB3tMMvyI(Sbg972VNPyZXdHhScEE.IB3tMMvyI(ITq2b4VacNCwVAUkUEM.IB3tMMvyI(j5ZLXJVYkZGn9Ioacdg.IB3tMMvyI(response.Data, j5ZLXJVYkZGn9Ioacdg.evuVDR4ItC), ITq2b4VacNCwVAUkUEM.oHDVPBeB3c), Sbg972VNPyZXdHhScEE.gH7VGjOXm0).FirstOrDefault(), true, RHAkZkVyRlGKyAFkZ9S.zB2VhuHPii);
					RHAkZkVyRlGKyAFkZ9S.IB3tMMvyI(Sbg972VNPyZXdHhScEE.IB3tMMvyI(ITq2b4VacNCwVAUkUEM.IB3tMMvyI(j5ZLXJVYkZGn9Ioacdg.IB3tMMvyI(response.Data, j5ZLXJVYkZGn9Ioacdg.evuVDR4ItC), ITq2b4VacNCwVAUkUEM.oHDVPBeB3c), Sbg972VNPyZXdHhScEE.gH7VGjOXm0).LastOrDefault(), true, RHAkZkVyRlGKyAFkZ9S.zJlVAKc0MB);
				}
				SerqGHSt45o8ybhbS9V.IB3tMMvyI(SdbPhbd7X, YslQcaVzVUGZyCXkm6i.IB3tMMvyI(response.Data, YslQcaVzVUGZyCXkm6i.nxVSwCg9IZ), SerqGHSt45o8ybhbS9V.TNTSgR9Wc0);
				rGuRMdSLgIUbKkdtW1N.IB3tMMvyI(SdbPhbd7X, j5ZLXJVYkZGn9Ioacdg.IB3tMMvyI(response.Data, j5ZLXJVYkZGn9Ioacdg.evuVDR4ItC), rGuRMdSLgIUbKkdtW1N.t1ISVAbAlA);
				NNEWAsSviRlRwSRsBFp.IB3tMMvyI(SdbPhbd7X, YCvJULSS8jRsghuUvXk.IB3tMMvyI(response.Data, YCvJULSS8jRsghuUvXk.PGISnBQrXp), NNEWAsSviRlRwSRsBFp.J4pSM8aKdq);
				QV5Py2LOX8yx6ajM6nW.IB3tMMvyI(SdbPhbd7X, BkFFwYmT10k6taWbxb.IB3tMMvyI(j5ZLXJVYkZGn9Ioacdg.IB3tMMvyI(response.Data, j5ZLXJVYkZGn9Ioacdg.evuVDR4ItC), BkFFwYmT10k6taWbxb.M4uS97fp6e), QV5Py2LOX8yx6ajM6nW.LOrSjnOYrO);
				QV5Py2LOX8yx6ajM6nW.IB3tMMvyI(SdbPhbd7X, BkFFwYmT10k6taWbxb.IB3tMMvyI(YslQcaVzVUGZyCXkm6i.IB3tMMvyI(response.Data, YslQcaVzVUGZyCXkm6i.nxVSwCg9IZ), BkFFwYmT10k6taWbxb.inySC44OKq), QV5Py2LOX8yx6ajM6nW.atkSIyvswN);
				try
				{
					IStoreContext sdbPhbd7X = SdbPhbd7X;
					DateTime dateTime = ix0AP1guMX2I0U7xh8u.IB3tMMvyI(ix0AP1guMX2I0U7xh8u.Bchg200s7j);
					string value;
					if (!(baRVYtSfN7aiQO1pJ2W.IB3tMMvyI(ref dateTime, baRVYtSfN7aiQO1pJ2W.kBoSUSpJ9n) <= P9KPPOS6nKmEh9KdOkP.IB3tMMvyI(YCvJULSS8jRsghuUvXk.IB3tMMvyI(SdbPhbd7X, YCvJULSS8jRsghuUvXk.H7WS5JcWxU), P9KPPOS6nKmEh9KdOkP.ClbSRfq0wP)))
					{
						dateTime = ix0AP1guMX2I0U7xh8u.IB3tMMvyI(ix0AP1guMX2I0U7xh8u.Bchg200s7j);
						int year = baRVYtSfN7aiQO1pJ2W.IB3tMMvyI(ref dateTime, baRVYtSfN7aiQO1pJ2W.OWGSdnGb1u);
						dateTime = ix0AP1guMX2I0U7xh8u.IB3tMMvyI(ix0AP1guMX2I0U7xh8u.Bchg200s7j);
						dateTime = new DateTime(year, baRVYtSfN7aiQO1pJ2W.IB3tMMvyI(ref dateTime, baRVYtSfN7aiQO1pJ2W.cHASlk2ON2), P9KPPOS6nKmEh9KdOkP.IB3tMMvyI(YCvJULSS8jRsghuUvXk.IB3tMMvyI(SdbPhbd7X, YCvJULSS8jRsghuUvXk.H7WS5JcWxU), P9KPPOS6nKmEh9KdOkP.ClbSRfq0wP).Value);
						dateTime = GVVUkGSmQ9yO0YNRmgh.IB3tMMvyI(ref dateTime, 1, GVVUkGSmQ9yO0YNRmgh.GQ0SpFQbrC);
						value = BYjHjqSc81nB8pmS54u.IB3tMMvyI(ref dateTime, q2no0WnPxDaipZawxT.IB3tMMvyI(5570, q2no0WnPxDaipZawxT.eV4vC1LZv), BYjHjqSc81nB8pmS54u.xmPSqR4Anb);
					}
					else
					{
						dateTime = ix0AP1guMX2I0U7xh8u.IB3tMMvyI(ix0AP1guMX2I0U7xh8u.Bchg200s7j);
						int year2 = baRVYtSfN7aiQO1pJ2W.IB3tMMvyI(ref dateTime, baRVYtSfN7aiQO1pJ2W.OWGSdnGb1u);
						dateTime = ix0AP1guMX2I0U7xh8u.IB3tMMvyI(ix0AP1guMX2I0U7xh8u.Bchg200s7j);
						dateTime = new DateTime(year2, baRVYtSfN7aiQO1pJ2W.IB3tMMvyI(ref dateTime, baRVYtSfN7aiQO1pJ2W.cHASlk2ON2), P9KPPOS6nKmEh9KdOkP.IB3tMMvyI(YCvJULSS8jRsghuUvXk.IB3tMMvyI(SdbPhbd7X, YCvJULSS8jRsghuUvXk.H7WS5JcWxU), P9KPPOS6nKmEh9KdOkP.ClbSRfq0wP).Value);
						value = BYjHjqSc81nB8pmS54u.IB3tMMvyI(ref dateTime, q2no0WnPxDaipZawxT.IB3tMMvyI(5570, q2no0WnPxDaipZawxT.eV4vC1LZv), BYjHjqSc81nB8pmS54u.xmPSqR4Anb);
					}
					QV5Py2LOX8yx6ajM6nW.IB3tMMvyI(sdbPhbd7X, value, QV5Py2LOX8yx6ajM6nW.yE1SOZOGuR);
				}
				catch
				{
					IStoreContext sdbPhbd7X2 = SdbPhbd7X;
					DateTime dateTime = ix0AP1guMX2I0U7xh8u.IB3tMMvyI(ix0AP1guMX2I0U7xh8u.Bchg200s7j);
					int year3 = baRVYtSfN7aiQO1pJ2W.IB3tMMvyI(ref dateTime, baRVYtSfN7aiQO1pJ2W.OWGSdnGb1u);
					dateTime = ix0AP1guMX2I0U7xh8u.IB3tMMvyI(ix0AP1guMX2I0U7xh8u.Bchg200s7j);
					dateTime = new DateTime(year3, baRVYtSfN7aiQO1pJ2W.IB3tMMvyI(ref dateTime, baRVYtSfN7aiQO1pJ2W.cHASlk2ON2), 1);
					dateTime = GVVUkGSmQ9yO0YNRmgh.IB3tMMvyI(ref dateTime, 1, GVVUkGSmQ9yO0YNRmgh.GQ0SpFQbrC);
					dateTime = sioZiESKNZf5OZChXVI.IB3tMMvyI(ref dateTime, -1.0, sioZiESKNZf5OZChXVI.AUASrrZSZ3);
					QV5Py2LOX8yx6ajM6nW.IB3tMMvyI(sdbPhbd7X2, BYjHjqSc81nB8pmS54u.IB3tMMvyI(ref dateTime, q2no0WnPxDaipZawxT.IB3tMMvyI(5570, q2no0WnPxDaipZawxT.eV4vC1LZv), BYjHjqSc81nB8pmS54u.xmPSqR4Anb), QV5Py2LOX8yx6ajM6nW.yE1SOZOGuR);
				}
				xbpXba64taw5VdWx0Y.IB3tMMvyI(this, xbpXba64taw5VdWx0Y.R3BSEyIeL9);
			}
			result = response;
			return result;
		}
		catch (Exception ex)
		{
			obj2 = ex;
			num = 1;
		}
		if (num == 1)
		{
			Exception ex2 = (Exception)obj2;
			if (ex2 is ApiException ex3 && p9M72WLmtReo7EmEjUm.IB3tMMvyI(ex3, p9M72WLmtReo7EmEjUm.kmyLpEIVEN) != HttpStatusCode.BadGateway)
			{
				try
				{
					return await R60iMKSZFAdJGsOLPyX.IB3tMMvyI(this, BkFFwYmT10k6taWbxb.IB3tMMvyI(SdbPhbd7X, BkFFwYmT10k6taWbxb.nQtS0pIia2), BkFFwYmT10k6taWbxb.IB3tMMvyI(SdbPhbd7X, BkFFwYmT10k6taWbxb.ntMSTG0g4f), R60iMKSZFAdJGsOLPyX.ibLSukHW1V);
				}
				catch (Exception ex4)
				{
					throw ex4;
				}
			}
			throw ex2;
		}
		return result;
	}

	public async Task<Response<ClientResponseDto>> GetMeAsync()
	{
		bool tryAgain = true;
		while (tryAgain)
		{
			try
			{
				Response<ClientResponseDto> response = ((!TLD0W5K9yiTCdcMEKT.IB3tMMvyI(SdbPhbd7X, TLD0W5K9yiTCdcMEKT.nOQLzI2sZW)) ? (await VjEdiIS2EiBYeDS43Zw.IB3tMMvyI(Y73PWxV27aDmcW7uONE.IB3tMMvyI(K4PaNbs6t, Y73PWxV27aDmcW7uONE.GDoV7c7wrF), VjEdiIS2EiBYeDS43Zw.XlDSiBdgVP)) : (await VjEdiIS2EiBYeDS43Zw.IB3tMMvyI(Y73PWxV27aDmcW7uONE.IB3tMMvyI(K4PaNbs6t, Y73PWxV27aDmcW7uONE.TAxViq2iYl), VjEdiIS2EiBYeDS43Zw.XlDSiBdgVP)));
				if (response.Status)
				{
					NNEWAsSviRlRwSRsBFp.IB3tMMvyI(SdbPhbd7X, response.Data, NNEWAsSviRlRwSRsBFp.J4pSM8aKdq);
				}
				return response;
			}
			catch (Exception e)
			{
				PROTVException ex = new PROTVException(e);
				if (CDq5XOVSkTWxZo0hfQU.IB3tMMvyI(ex, CDq5XOVSkTWxZo0hfQU.wJ8Vnql80E) == ExceptionType.AuthorizationTokenInvalid)
				{
					try
					{
						await d81QmNVvT2C1ISNMQLb.IB3tMMvyI(this, d81QmNVvT2C1ISNMQLb.zodSelxwU8);
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

	public async Task<Response<LoginResponseDto>> GetProfileAsync()
	{
		bool tryAgain = true;
		while (tryAgain)
		{
			try
			{
				Response<LoginResponseDto> response = ((!TLD0W5K9yiTCdcMEKT.IB3tMMvyI(SdbPhbd7X, TLD0W5K9yiTCdcMEKT.nOQLzI2sZW)) ? (await d81QmNVvT2C1ISNMQLb.IB3tMMvyI(Y73PWxV27aDmcW7uONE.IB3tMMvyI(K4PaNbs6t, Y73PWxV27aDmcW7uONE.GDoV7c7wrF), d81QmNVvT2C1ISNMQLb.K2mS3CyPfB)) : (await d81QmNVvT2C1ISNMQLb.IB3tMMvyI(Y73PWxV27aDmcW7uONE.IB3tMMvyI(K4PaNbs6t, Y73PWxV27aDmcW7uONE.TAxViq2iYl), d81QmNVvT2C1ISNMQLb.K2mS3CyPfB)));
				if (response.Status)
				{
					SerqGHSt45o8ybhbS9V.IB3tMMvyI(SdbPhbd7X, YslQcaVzVUGZyCXkm6i.IB3tMMvyI(response.Data, YslQcaVzVUGZyCXkm6i.nxVSwCg9IZ), SerqGHSt45o8ybhbS9V.TNTSgR9Wc0);
					rGuRMdSLgIUbKkdtW1N.IB3tMMvyI(SdbPhbd7X, j5ZLXJVYkZGn9Ioacdg.IB3tMMvyI(response.Data, j5ZLXJVYkZGn9Ioacdg.evuVDR4ItC), rGuRMdSLgIUbKkdtW1N.t1ISVAbAlA);
					NNEWAsSviRlRwSRsBFp.IB3tMMvyI(SdbPhbd7X, YCvJULSS8jRsghuUvXk.IB3tMMvyI(response.Data, YCvJULSS8jRsghuUvXk.PGISnBQrXp), NNEWAsSviRlRwSRsBFp.J4pSM8aKdq);
					try
					{
						IStoreContext sdbPhbd7X = SdbPhbd7X;
						DateTime dateTime = ix0AP1guMX2I0U7xh8u.IB3tMMvyI(ix0AP1guMX2I0U7xh8u.Bchg200s7j);
						string value;
						if (!(baRVYtSfN7aiQO1pJ2W.IB3tMMvyI(ref dateTime, baRVYtSfN7aiQO1pJ2W.kBoSUSpJ9n) <= P9KPPOS6nKmEh9KdOkP.IB3tMMvyI(YCvJULSS8jRsghuUvXk.IB3tMMvyI(SdbPhbd7X, YCvJULSS8jRsghuUvXk.H7WS5JcWxU), P9KPPOS6nKmEh9KdOkP.ClbSRfq0wP)))
						{
							dateTime = ix0AP1guMX2I0U7xh8u.IB3tMMvyI(ix0AP1guMX2I0U7xh8u.Bchg200s7j);
							int year = baRVYtSfN7aiQO1pJ2W.IB3tMMvyI(ref dateTime, baRVYtSfN7aiQO1pJ2W.OWGSdnGb1u);
							dateTime = ix0AP1guMX2I0U7xh8u.IB3tMMvyI(ix0AP1guMX2I0U7xh8u.Bchg200s7j);
							dateTime = new DateTime(year, baRVYtSfN7aiQO1pJ2W.IB3tMMvyI(ref dateTime, baRVYtSfN7aiQO1pJ2W.cHASlk2ON2), P9KPPOS6nKmEh9KdOkP.IB3tMMvyI(YCvJULSS8jRsghuUvXk.IB3tMMvyI(SdbPhbd7X, YCvJULSS8jRsghuUvXk.H7WS5JcWxU), P9KPPOS6nKmEh9KdOkP.ClbSRfq0wP).Value);
							dateTime = GVVUkGSmQ9yO0YNRmgh.IB3tMMvyI(ref dateTime, 1, GVVUkGSmQ9yO0YNRmgh.GQ0SpFQbrC);
							value = BYjHjqSc81nB8pmS54u.IB3tMMvyI(ref dateTime, q2no0WnPxDaipZawxT.IB3tMMvyI(5570, q2no0WnPxDaipZawxT.eV4vC1LZv), BYjHjqSc81nB8pmS54u.xmPSqR4Anb);
						}
						else
						{
							dateTime = ix0AP1guMX2I0U7xh8u.IB3tMMvyI(ix0AP1guMX2I0U7xh8u.Bchg200s7j);
							int year2 = baRVYtSfN7aiQO1pJ2W.IB3tMMvyI(ref dateTime, baRVYtSfN7aiQO1pJ2W.OWGSdnGb1u);
							dateTime = ix0AP1guMX2I0U7xh8u.IB3tMMvyI(ix0AP1guMX2I0U7xh8u.Bchg200s7j);
							dateTime = new DateTime(year2, baRVYtSfN7aiQO1pJ2W.IB3tMMvyI(ref dateTime, baRVYtSfN7aiQO1pJ2W.cHASlk2ON2), P9KPPOS6nKmEh9KdOkP.IB3tMMvyI(YCvJULSS8jRsghuUvXk.IB3tMMvyI(SdbPhbd7X, YCvJULSS8jRsghuUvXk.H7WS5JcWxU), P9KPPOS6nKmEh9KdOkP.ClbSRfq0wP).Value);
							value = BYjHjqSc81nB8pmS54u.IB3tMMvyI(ref dateTime, q2no0WnPxDaipZawxT.IB3tMMvyI(5570, q2no0WnPxDaipZawxT.eV4vC1LZv), BYjHjqSc81nB8pmS54u.xmPSqR4Anb);
						}
						QV5Py2LOX8yx6ajM6nW.IB3tMMvyI(sdbPhbd7X, value, QV5Py2LOX8yx6ajM6nW.yE1SOZOGuR);
					}
					catch
					{
						IStoreContext sdbPhbd7X2 = SdbPhbd7X;
						DateTime dateTime = ix0AP1guMX2I0U7xh8u.IB3tMMvyI(ix0AP1guMX2I0U7xh8u.Bchg200s7j);
						int year3 = baRVYtSfN7aiQO1pJ2W.IB3tMMvyI(ref dateTime, baRVYtSfN7aiQO1pJ2W.OWGSdnGb1u);
						dateTime = ix0AP1guMX2I0U7xh8u.IB3tMMvyI(ix0AP1guMX2I0U7xh8u.Bchg200s7j);
						dateTime = new DateTime(year3, baRVYtSfN7aiQO1pJ2W.IB3tMMvyI(ref dateTime, baRVYtSfN7aiQO1pJ2W.cHASlk2ON2), 1);
						dateTime = GVVUkGSmQ9yO0YNRmgh.IB3tMMvyI(ref dateTime, 1, GVVUkGSmQ9yO0YNRmgh.GQ0SpFQbrC);
						dateTime = sioZiESKNZf5OZChXVI.IB3tMMvyI(ref dateTime, -1.0, sioZiESKNZf5OZChXVI.AUASrrZSZ3);
						QV5Py2LOX8yx6ajM6nW.IB3tMMvyI(sdbPhbd7X2, BYjHjqSc81nB8pmS54u.IB3tMMvyI(ref dateTime, q2no0WnPxDaipZawxT.IB3tMMvyI(5570, q2no0WnPxDaipZawxT.eV4vC1LZv), BYjHjqSc81nB8pmS54u.xmPSqR4Anb), QV5Py2LOX8yx6ajM6nW.yE1SOZOGuR);
					}
				}
				return response;
			}
			catch (Exception e)
			{
				PROTVException ex = new PROTVException(e);
				if (CDq5XOVSkTWxZo0hfQU.IB3tMMvyI(ex, CDq5XOVSkTWxZo0hfQU.wJ8Vnql80E) == ExceptionType.AuthorizationTokenInvalid)
				{
					try
					{
						await d81QmNVvT2C1ISNMQLb.IB3tMMvyI(this, d81QmNVvT2C1ISNMQLb.zodSelxwU8);
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

	public async Task<Response<PreferencesReponseDto>> GetPreferncesAsync()
	{
		bool tryAgain = true;
		while (tryAgain)
		{
			try
			{
				Response<PreferencesReponseDto> response = ((!TLD0W5K9yiTCdcMEKT.IB3tMMvyI(SdbPhbd7X, TLD0W5K9yiTCdcMEKT.nOQLzI2sZW)) ? (await hsUOxISH2xhLaj2yE2Q.IB3tMMvyI(Y73PWxV27aDmcW7uONE.IB3tMMvyI(K4PaNbs6t, Y73PWxV27aDmcW7uONE.GDoV7c7wrF), hsUOxISH2xhLaj2yE2Q.oMISQFKBwL)) : (await hsUOxISH2xhLaj2yE2Q.IB3tMMvyI(Y73PWxV27aDmcW7uONE.IB3tMMvyI(K4PaNbs6t, Y73PWxV27aDmcW7uONE.TAxViq2iYl), hsUOxISH2xhLaj2yE2Q.oMISQFKBwL)));
				if (response.Status)
				{
					UXBk8SSJhcoSWDk0ESW.IB3tMMvyI(SdbPhbd7X, nhRTdgSk0qHU57n2D49.IB3tMMvyI(response.Data, nhRTdgSk0qHU57n2D49.wYvSWUVmnr), UXBk8SSJhcoSWDk0ESW.jNXSbTXgNG);
					fDEcmmSDPWUaELtPx3g.IB3tMMvyI(SdbPhbd7X, fFfqkcS7hZHgKfR148s.IB3tMMvyI(response.Data, fFfqkcS7hZHgKfR148s.isMSYN9G1y), fDEcmmSDPWUaELtPx3g.iFnSa8Iml5);
				}
				return response;
			}
			catch (Exception e)
			{
				PROTVException ex = new PROTVException(e);
				if (CDq5XOVSkTWxZo0hfQU.IB3tMMvyI(ex, CDq5XOVSkTWxZo0hfQU.wJ8Vnql80E) == ExceptionType.AuthorizationTokenInvalid)
				{
					try
					{
						await d81QmNVvT2C1ISNMQLb.IB3tMMvyI(this, d81QmNVvT2C1ISNMQLb.zodSelxwU8);
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

	public async Task<string> GetRouterMACAddress()
	{
		try
		{
			PhysicalAddress physicalAddress = await AcWEBvnLMPVu0l9hIiI.IB3tMMvyI((from g in (from n in HWjlLUVlrdpOCWSaIC.IB3tMMvyI(HWjlLUVlrdpOCWSaIC.r2mSUkctn)
					where mCYYfQSPLERfeWhWbvl.IB3tMMvyI(n, mCYYfQSPLERfeWhWbvl.KEqSBPoTvD) == OperationalStatus.Up
					where PI6fZkS1rhF5GBVcVxv.IB3tMMvyI(n, PI6fZkS1rhF5GBVcVxv.kTlSygdHPj) != NetworkInterfaceType.Loopback
					select n).SelectMany(delegate(NetworkInterface n)
				{
					IPInterfaceProperties iPInterfaceProperties = bvkAruSoFSYpsAxQFR8.IB3tMMvyI(n, bvkAruSoFSYpsAxQFR8.YJrS8itvkU);
					return (iPInterfaceProperties == null) ? null : BKovS6SNZSrwcwBgenC.IB3tMMvyI(iPInterfaceProperties, BKovS6SNZSrwcwBgenC.O6DSGZYIyZ);
				})
				select (g == null) ? null : CqLWFiShYw1Uoa74ALQ.IB3tMMvyI(g, CqLWFiShYw1Uoa74ALQ.k1DSAuZeDy) into a
				where a != null && zKb1RRSsJQ5LMReeH89.IB3tMMvyI(a, zKb1RRSsJQ5LMReeH89.rirSxwydMu) == AddressFamily.InterNetwork
				select a).FirstOrDefault(), AcWEBvnLMPVu0l9hIiI.oXrnVYaO4D);
			return pMkOBqjbJPAJ3vF0Sv.IB3tMMvyI(q2no0WnPxDaipZawxT.IB3tMMvyI(0, q2no0WnPxDaipZawxT.eV4vC1LZv), ykpPc0MBrjmUF1B0kX.IB3tMMvyI(physicalAddress, ykpPc0MBrjmUF1B0kX.zuW93b0D3).Select(delegate(byte z)
			{
				byte b = z;
				return UoKxYJSzBLMkay11B6x.IB3tMMvyI(ref b, q2no0WnPxDaipZawxT.IB3tMMvyI(5594, q2no0WnPxDaipZawxT.eV4vC1LZv), UoKxYJSzBLMkay11B6x.JoRnwosINs);
			}).ToArray(), pMkOBqjbJPAJ3vF0Sv.iV3CNp7EK);
		}
		catch (Exception ex)
		{
			throw ex;
		}
	}

	public string GetDeviceMACAddress()
	{
		try
		{
			PhysicalAddress physicalAddress = (from nic in HWjlLUVlrdpOCWSaIC.IB3tMMvyI(HWjlLUVlrdpOCWSaIC.r2mSUkctn)
				where mCYYfQSPLERfeWhWbvl.IB3tMMvyI(nic, mCYYfQSPLERfeWhWbvl.KEqSBPoTvD) == OperationalStatus.Up && PI6fZkS1rhF5GBVcVxv.IB3tMMvyI(nic, PI6fZkS1rhF5GBVcVxv.kTlSygdHPj) != NetworkInterfaceType.Loopback
				select htK9iQntoUGSmiEmELX.IB3tMMvyI(nic, htK9iQntoUGSmiEmELX.vOCngZPxcy)).FirstOrDefault();
			return pMkOBqjbJPAJ3vF0Sv.IB3tMMvyI(q2no0WnPxDaipZawxT.IB3tMMvyI(0, q2no0WnPxDaipZawxT.eV4vC1LZv), ykpPc0MBrjmUF1B0kX.IB3tMMvyI(physicalAddress, ykpPc0MBrjmUF1B0kX.zuW93b0D3).Select(delegate(byte z)
			{
				byte b = z;
				return UoKxYJSzBLMkay11B6x.IB3tMMvyI(ref b, q2no0WnPxDaipZawxT.IB3tMMvyI(5594, q2no0WnPxDaipZawxT.eV4vC1LZv), UoKxYJSzBLMkay11B6x.JoRnwosINs);
			}).ToArray(), pMkOBqjbJPAJ3vF0Sv.iV3CNp7EK);
		}
		catch
		{
			return q2no0WnPxDaipZawxT.IB3tMMvyI(6, q2no0WnPxDaipZawxT.eV4vC1LZv);
		}
	}

	public async Task<string> GetDeviceIPAddress()
	{
		HttpClient client = new HttpClient();
		try
		{
			string ip = "";
			try
			{
				ip = BkFFwYmT10k6taWbxb.IB3tMMvyI(await E7KkQ5n9DySdGS5ZymA.IB3tMMvyI(pUG8kxnvawLauGsIJNq.IB3tMMvyI(await smp2cnnSStJaNQ4lhj7.IB3tMMvyI(client, q2no0WnPxDaipZawxT.IB3tMMvyI(5602, q2no0WnPxDaipZawxT.eV4vC1LZv), smp2cnnSStJaNQ4lhj7.K29nn5oDew), pUG8kxnvawLauGsIJNq.OainMJHwY0), E7KkQ5n9DySdGS5ZymA.ed3njPahaE), BkFFwYmT10k6taWbxb.HE8nC8nIQu);
			}
			catch
			{
			}
			return ip;
		}
		finally
		{
			if (client != null)
			{
				xbpXba64taw5VdWx0Y.IB3tMMvyI(client, xbpXba64taw5VdWx0Y.ONrEAGIJN);
			}
		}
	}

	public string GetDeviceModel()
	{
		try
		{
			ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(new SelectQuery(q2no0WnPxDaipZawxT.IB3tMMvyI(24, q2no0WnPxDaipZawxT.eV4vC1LZv)));
			try
			{
				ManagementObjectCollection.ManagementObjectEnumerator enumerator = seW6EqIRJ9igVUJmPc.IB3tMMvyI(managementObjectSearcher, seW6EqIRJ9igVUJmPc.eCYf9GZxa).GetEnumerator();
				try
				{
					while (TLD0W5K9yiTCdcMEKT.IB3tMMvyI(enumerator, TLD0W5K9yiTCdcMEKT.I9XrLvl5a))
					{
						ManagementObject obj = (ManagementObject)O5QR26UPvkAYy60j2G.IB3tMMvyI(enumerator, O5QR26UPvkAYy60j2G.I0c5xvx6X);
						xbpXba64taw5VdWx0Y.IB3tMMvyI(obj, xbpXba64taw5VdWx0Y.zA1RFJZG9);
						object obj2 = M4BHM9d2qHrNgWghts.IB3tMMvyI(obj, q2no0WnPxDaipZawxT.IB3tMMvyI(96, q2no0WnPxDaipZawxT.eV4vC1LZv), M4BHM9d2qHrNgWghts.pB1ljg4Fa);
						string text = ((obj2 != null) ? BkFFwYmT10k6taWbxb.IB3tMMvyI(obj2, BkFFwYmT10k6taWbxb.OyWpaipF5) : null);
						if (!kNn8wecEBg33G3F6YN.IB3tMMvyI(text, kNn8wecEBg33G3F6YN.xvCq7gQB7) && !kNn8wecEBg33G3F6YN.IB3tMMvyI(text, kNn8wecEBg33G3F6YN.MyWOsOGwM))
						{
							return text;
						}
					}
				}
				finally
				{
					if (enumerator != null)
					{
						xbpXba64taw5VdWx0Y.IB3tMMvyI(enumerator, xbpXba64taw5VdWx0Y.ONrEAGIJN);
					}
				}
			}
			finally
			{
				if (managementObjectSearcher != null)
				{
					xbpXba64taw5VdWx0Y.IB3tMMvyI(managementObjectSearcher, xbpXba64taw5VdWx0Y.ONrEAGIJN);
				}
			}
		}
		catch
		{
		}
		return q2no0WnPxDaipZawxT.IB3tMMvyI(6, q2no0WnPxDaipZawxT.eV4vC1LZv);
	}

	public void FixIPTVApis()
	{
		_003C_003Ec__DisplayClass12_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass12_0();
		string text = BkFFwYmT10k6taWbxb.IB3tMMvyI(SdbPhbd7X, BkFFwYmT10k6taWbxb.ChX4RA2rN);
		int num = mkoNOjXNUCV3vRaLLm.IB3tMMvyI(text, mkoNOjXNUCV3vRaLLm.UgOF2GA3s);
		int num2 = 7;
		int num3 = num - num2;
		CS_0024_003C_003E8__locals2.bMv2NfWKR3 = GyyT3s0SoNeJvQN2ji.IB3tMMvyI(text, num2, num3, GyyT3s0SoNeJvQN2ji.uw8TjMpsd);
		RefitSettings refitSettings = new RefitSettings();
		lAUUI6ZjJIcHNXfj4n.IB3tMMvyI(refitSettings, () => Task.FromResult(CS_0024_003C_003E8__locals2.bMv2NfWKR3), lAUUI6ZjJIcHNXfj4n.V1buZlicH);
		RefitSettings settings = refitSettings;
		IAuthApi value = RestService.For<IAuthApi>(Td2FIH2HbdCuQVQ5N1.IB3tMMvyI(Td2FIH2HbdCuQVQ5N1.ImXikm3lt), settings);
		IAuthApi value2 = RestService.For<IAuthApi>(Td2FIH2HbdCuQVQ5N1.IB3tMMvyI(Td2FIH2HbdCuQVQ5N1.oa2elnSP2), settings);
		IAppApi value3 = RestService.For<IAppApi>(Td2FIH2HbdCuQVQ5N1.IB3tMMvyI(Td2FIH2HbdCuQVQ5N1.ImXikm3lt), settings);
		IAppApi value4 = RestService.For<IAppApi>(Td2FIH2HbdCuQVQ5N1.IB3tMMvyI(Td2FIH2HbdCuQVQ5N1.oa2elnSP2), settings);
		IYoutubeApi value5 = RestService.For<IYoutubeApi>(Td2FIH2HbdCuQVQ5N1.IB3tMMvyI(Td2FIH2HbdCuQVQ5N1.ImXikm3lt), settings);
		IYoutubeApi value6 = RestService.For<IYoutubeApi>(Td2FIH2HbdCuQVQ5N1.IB3tMMvyI(Td2FIH2HbdCuQVQ5N1.oa2elnSP2), settings);
		IMusicApi value7 = RestService.For<IMusicApi>(Td2FIH2HbdCuQVQ5N1.IB3tMMvyI(Td2FIH2HbdCuQVQ5N1.ImXikm3lt), settings);
		IMusicApi value8 = RestService.For<IMusicApi>(Td2FIH2HbdCuQVQ5N1.IB3tMMvyI(Td2FIH2HbdCuQVQ5N1.oa2elnSP2), settings);
		IPeopleApi value9 = RestService.For<IPeopleApi>(Td2FIH2HbdCuQVQ5N1.IB3tMMvyI(Td2FIH2HbdCuQVQ5N1.ImXikm3lt), settings);
		IPeopleApi value10 = RestService.For<IPeopleApi>(Td2FIH2HbdCuQVQ5N1.IB3tMMvyI(Td2FIH2HbdCuQVQ5N1.oa2elnSP2), settings);
		IMovieApi value11 = RestService.For<IMovieApi>(Td2FIH2HbdCuQVQ5N1.IB3tMMvyI(Td2FIH2HbdCuQVQ5N1.ImXikm3lt), settings);
		IMovieApi value12 = RestService.For<IMovieApi>(Td2FIH2HbdCuQVQ5N1.IB3tMMvyI(Td2FIH2HbdCuQVQ5N1.oa2elnSP2), settings);
		ISeriesApi value13 = RestService.For<ISeriesApi>(Td2FIH2HbdCuQVQ5N1.IB3tMMvyI(Td2FIH2HbdCuQVQ5N1.ImXikm3lt), settings);
		ISeriesApi value14 = RestService.For<ISeriesApi>(Td2FIH2HbdCuQVQ5N1.IB3tMMvyI(Td2FIH2HbdCuQVQ5N1.oa2elnSP2), settings);
		ISeasonApi value15 = RestService.For<ISeasonApi>(Td2FIH2HbdCuQVQ5N1.IB3tMMvyI(Td2FIH2HbdCuQVQ5N1.ImXikm3lt), settings);
		ISeasonApi value16 = RestService.For<ISeasonApi>(Td2FIH2HbdCuQVQ5N1.IB3tMMvyI(Td2FIH2HbdCuQVQ5N1.oa2elnSP2), settings);
		IQuranApi value17 = RestService.For<IQuranApi>(Td2FIH2HbdCuQVQ5N1.IB3tMMvyI(Td2FIH2HbdCuQVQ5N1.ImXikm3lt), settings);
		IQuranApi value18 = RestService.For<IQuranApi>(Td2FIH2HbdCuQVQ5N1.IB3tMMvyI(Td2FIH2HbdCuQVQ5N1.oa2elnSP2), settings);
		ILiveApi value19 = RestService.For<ILiveApi>(Td2FIH2HbdCuQVQ5N1.IB3tMMvyI(Td2FIH2HbdCuQVQ5N1.ImXikm3lt), settings);
		ILiveApi value20 = RestService.For<ILiveApi>(Td2FIH2HbdCuQVQ5N1.IB3tMMvyI(Td2FIH2HbdCuQVQ5N1.oa2elnSP2), settings);
		IHistoryApi value21 = RestService.For<IHistoryApi>(Td2FIH2HbdCuQVQ5N1.IB3tMMvyI(Td2FIH2HbdCuQVQ5N1.ImXikm3lt), settings);
		IHistoryApi value22 = RestService.For<IHistoryApi>(Td2FIH2HbdCuQVQ5N1.IB3tMMvyI(Td2FIH2HbdCuQVQ5N1.oa2elnSP2), settings);
		IPlaylistApi value23 = RestService.For<IPlaylistApi>(Td2FIH2HbdCuQVQ5N1.IB3tMMvyI(Td2FIH2HbdCuQVQ5N1.ImXikm3lt), settings);
		IPlaylistApi value24 = RestService.For<IPlaylistApi>(Td2FIH2HbdCuQVQ5N1.IB3tMMvyI(Td2FIH2HbdCuQVQ5N1.oa2elnSP2), settings);
		CqNaZ73wOqZQ2sltKr.IB3tMMvyI(K4PaNbs6t, value2, CqNaZ73wOqZQ2sltKr.ktwHVWRBV);
		CqNaZ73wOqZQ2sltKr.IB3tMMvyI(K4PaNbs6t, value, CqNaZ73wOqZQ2sltKr.JZAQPMPqS);
		w9t44vksP3te1OTRlv.IB3tMMvyI(K4PaNbs6t, value4, w9t44vksP3te1OTRlv.w4nWPjE3f);
		w9t44vksP3te1OTRlv.IB3tMMvyI(K4PaNbs6t, value3, w9t44vksP3te1OTRlv.YN4JKZxjR);
		WsTCCjbs6dcbtuC8wi.IB3tMMvyI(K4PaNbs6t, value6, WsTCCjbs6dcbtuC8wi.sGa7F1SuM);
		WsTCCjbs6dcbtuC8wi.IB3tMMvyI(K4PaNbs6t, value5, WsTCCjbs6dcbtuC8wi.kujYhUoBT);
		J0ek8yD5gWN4YVtdkL.IB3tMMvyI(K4PaNbs6t, value8, J0ek8yD5gWN4YVtdkL.sSJaf6nIG);
		J0ek8yD5gWN4YVtdkL.IB3tMMvyI(K4PaNbs6t, value7, J0ek8yD5gWN4YVtdkL.GUFPX8Ns7);
		AAAR1ZBXC837VEySLH.IB3tMMvyI(K4PaNbs6t, value10, AAAR1ZBXC837VEySLH.q1v1oUTwu);
		AAAR1ZBXC837VEySLH.IB3tMMvyI(K4PaNbs6t, value9, AAAR1ZBXC837VEySLH.HwWyi9NSV);
		BF5m9no8nl21Nq2wdh.IB3tMMvyI(K4PaNbs6t, value12, BF5m9no8nl21Nq2wdh.Odb83qWJO);
		BF5m9no8nl21Nq2wdh.IB3tMMvyI(K4PaNbs6t, value11, BF5m9no8nl21Nq2wdh.sRfN1Mi5O);
		iiqXVtGHYpCwLAvwQ9.IB3tMMvyI(K4PaNbs6t, value14, iiqXVtGHYpCwLAvwQ9.DmfhBhjDW);
		iiqXVtGHYpCwLAvwQ9.IB3tMMvyI(K4PaNbs6t, value13, iiqXVtGHYpCwLAvwQ9.lQiAHOec1);
		ShPOhZsYDh5oO7mlci.IB3tMMvyI(K4PaNbs6t, value16, ShPOhZsYDh5oO7mlci.jhBxJW8VJ);
		ShPOhZsYDh5oO7mlci.IB3tMMvyI(K4PaNbs6t, value15, ShPOhZsYDh5oO7mlci.aAdzRFqD7);
		QWUoTVtwZsym0ZQpKTX.IB3tMMvyI(K4PaNbs6t, value18, QWUoTVtwZsym0ZQpKTX.cWuttJSBdf);
		QWUoTVtwZsym0ZQpKTX.IB3tMMvyI(K4PaNbs6t, value17, QWUoTVtwZsym0ZQpKTX.GNBtgeRV2U);
		hyaEIXtLaM6Og0G2KLi.IB3tMMvyI(K4PaNbs6t, value20, hyaEIXtLaM6Og0G2KLi.LwetVPb1mD);
		hyaEIXtLaM6Og0G2KLi.IB3tMMvyI(K4PaNbs6t, value19, hyaEIXtLaM6Og0G2KLi.lH6tSQpWSi);
		LGhRnjtnfLpAOevOHh0.IB3tMMvyI(K4PaNbs6t, value22, LGhRnjtnfLpAOevOHh0.mpTtvhN7KF);
		LGhRnjtnfLpAOevOHh0.IB3tMMvyI(K4PaNbs6t, value21, LGhRnjtnfLpAOevOHh0.LedtMqDsLc);
		NcN4qpt9Web9e6rCZ0c.IB3tMMvyI(K4PaNbs6t, value24, NcN4qpt9Web9e6rCZ0c.dpptjOCgpB);
		NcN4qpt9Web9e6rCZ0c.IB3tMMvyI(K4PaNbs6t, value23, NcN4qpt9Web9e6rCZ0c.uWmtCTsmdP);
	}
}
