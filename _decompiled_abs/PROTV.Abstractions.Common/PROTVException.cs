using System;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using PROTV.Abstractions.DataTransferObjects;
using Refit;

namespace PROTV.Abstractions.Common;

public class PROTVException : Exception
{
	[CompilerGenerated]
	private ExceptionType UKMlMkfkoD;

	[CompilerGenerated]
	private string lx7lxMuqDe;

	[CompilerGenerated]
	private AppVersionResponseDto ipBlVQ2SEm;

	public ExceptionType ExceptionType
	{
		[CompilerGenerated]
		get
		{
			return UKMlMkfkoD;
		}
		[CompilerGenerated]
		set
		{
			UKMlMkfkoD = value;
		}
	}

	public string ExceptionMessage
	{
		[CompilerGenerated]
		get
		{
			return lx7lxMuqDe;
		}
		[CompilerGenerated]
		set
		{
			lx7lxMuqDe = value;
		}
	}

	public AppVersionResponseDto LastAppVersion
	{
		[CompilerGenerated]
		get
		{
			return ipBlVQ2SEm;
		}
		[CompilerGenerated]
		set
		{
			ipBlVQ2SEm = value;
		}
	}

	public PROTVException(string message)
	{
		uiiVNagWnDNnTWnFgq.IB3tMMvyI(uiiVNagWnDNnTWnFgq.JyKLgPcm8);
		base._002Ector(message);
	}

	public PROTVException(Exception e)
	{
		uiiVNagWnDNnTWnFgq.IB3tMMvyI(uiiVNagWnDNnTWnFgq.JyKLgPcm8);
		base._002Ector();
		if (e is ApiException ex)
		{
			if (p9M72WLmtReo7EmEjUm.IB3tMMvyI(ex, p9M72WLmtReo7EmEjUm.kmyLpEIVEN) == HttpStatusCode.BadGateway)
			{
				cBRrURLc05Kd61yN0Vm.IB3tMMvyI(this, ExceptionType.NoInternet, cBRrURLc05Kd61yN0Vm.uqVLqSgBJf);
				QV5Py2LOX8yx6ajM6nW.IB3tMMvyI(this, q2no0WnPxDaipZawxT.IB3tMMvyI(2130, q2no0WnPxDaipZawxT.eV4vC1LZv), QV5Py2LOX8yx6ajM6nW.UN9LKXDiLi);
				MH806ELrdC5RbFM8cuj.IB3tMMvyI(this, null, MH806ELrdC5RbFM8cuj.igVLEBmIlE);
				return;
			}
			Response<AppVersionResponseDto> result = ex.GetContentAsAsync<Response<AppVersionResponseDto>>().GetAwaiter().GetResult();
			if (rEApJjgjnlE70Sxl9bu.IB3tMMvyI(result.MessageDev, q2no0WnPxDaipZawxT.IB3tMMvyI(2158, q2no0WnPxDaipZawxT.eV4vC1LZv), rEApJjgjnlE70Sxl9bu.IcLL4lj0Oh))
			{
				cBRrURLc05Kd61yN0Vm.IB3tMMvyI(this, ExceptionType.OldVersion, cBRrURLc05Kd61yN0Vm.uqVLqSgBJf);
				QV5Py2LOX8yx6ajM6nW.IB3tMMvyI(this, result.Message, QV5Py2LOX8yx6ajM6nW.UN9LKXDiLi);
				MH806ELrdC5RbFM8cuj.IB3tMMvyI(this, result.Data, MH806ELrdC5RbFM8cuj.igVLEBmIlE);
			}
			else if (rEApJjgjnlE70Sxl9bu.IB3tMMvyI(result.MessageDev, q2no0WnPxDaipZawxT.IB3tMMvyI(2186, q2no0WnPxDaipZawxT.eV4vC1LZv), rEApJjgjnlE70Sxl9bu.IcLL4lj0Oh))
			{
				cBRrURLc05Kd61yN0Vm.IB3tMMvyI(this, ExceptionType.LoginFaild, cBRrURLc05Kd61yN0Vm.uqVLqSgBJf);
				QV5Py2LOX8yx6ajM6nW.IB3tMMvyI(this, result.Message, QV5Py2LOX8yx6ajM6nW.UN9LKXDiLi);
				MH806ELrdC5RbFM8cuj.IB3tMMvyI(this, result.Data, MH806ELrdC5RbFM8cuj.igVLEBmIlE);
			}
			else if (rEApJjgjnlE70Sxl9bu.IB3tMMvyI(result.MessageDev, q2no0WnPxDaipZawxT.IB3tMMvyI(2214, q2no0WnPxDaipZawxT.eV4vC1LZv), rEApJjgjnlE70Sxl9bu.IcLL4lj0Oh))
			{
				cBRrURLc05Kd61yN0Vm.IB3tMMvyI(this, ExceptionType.AuthorizationTokenInvalid, cBRrURLc05Kd61yN0Vm.uqVLqSgBJf);
				QV5Py2LOX8yx6ajM6nW.IB3tMMvyI(this, result.Message, QV5Py2LOX8yx6ajM6nW.UN9LKXDiLi);
				MH806ELrdC5RbFM8cuj.IB3tMMvyI(this, result.Data, MH806ELrdC5RbFM8cuj.igVLEBmIlE);
			}
			else if (rEApJjgjnlE70Sxl9bu.IB3tMMvyI(result.MessageDev, q2no0WnPxDaipZawxT.IB3tMMvyI(2242, q2no0WnPxDaipZawxT.eV4vC1LZv), rEApJjgjnlE70Sxl9bu.IcLL4lj0Oh))
			{
				cBRrURLc05Kd61yN0Vm.IB3tMMvyI(this, ExceptionType.AlreadyExist, cBRrURLc05Kd61yN0Vm.uqVLqSgBJf);
				QV5Py2LOX8yx6ajM6nW.IB3tMMvyI(this, result.Message, QV5Py2LOX8yx6ajM6nW.UN9LKXDiLi);
				MH806ELrdC5RbFM8cuj.IB3tMMvyI(this, result.Data, MH806ELrdC5RbFM8cuj.igVLEBmIlE);
			}
			else if (rEApJjgjnlE70Sxl9bu.IB3tMMvyI(result.MessageDev, q2no0WnPxDaipZawxT.IB3tMMvyI(2270, q2no0WnPxDaipZawxT.eV4vC1LZv), rEApJjgjnlE70Sxl9bu.IcLL4lj0Oh))
			{
				cBRrURLc05Kd61yN0Vm.IB3tMMvyI(this, ExceptionType.InvalidInput, cBRrURLc05Kd61yN0Vm.uqVLqSgBJf);
				QV5Py2LOX8yx6ajM6nW.IB3tMMvyI(this, result.Message, QV5Py2LOX8yx6ajM6nW.UN9LKXDiLi);
				MH806ELrdC5RbFM8cuj.IB3tMMvyI(this, result.Data, MH806ELrdC5RbFM8cuj.igVLEBmIlE);
			}
			else if (rEApJjgjnlE70Sxl9bu.IB3tMMvyI(result.MessageDev, q2no0WnPxDaipZawxT.IB3tMMvyI(2298, q2no0WnPxDaipZawxT.eV4vC1LZv), rEApJjgjnlE70Sxl9bu.IcLL4lj0Oh))
			{
				cBRrURLc05Kd61yN0Vm.IB3tMMvyI(this, ExceptionType.Unknown, cBRrURLc05Kd61yN0Vm.uqVLqSgBJf);
				QV5Py2LOX8yx6ajM6nW.IB3tMMvyI(this, result.Message, QV5Py2LOX8yx6ajM6nW.UN9LKXDiLi);
				MH806ELrdC5RbFM8cuj.IB3tMMvyI(this, result.Data, MH806ELrdC5RbFM8cuj.igVLEBmIlE);
			}
			else
			{
				cBRrURLc05Kd61yN0Vm.IB3tMMvyI(this, ExceptionType.Unknown, cBRrURLc05Kd61yN0Vm.uqVLqSgBJf);
				QV5Py2LOX8yx6ajM6nW.IB3tMMvyI(this, result.Message, QV5Py2LOX8yx6ajM6nW.UN9LKXDiLi);
				MH806ELrdC5RbFM8cuj.IB3tMMvyI(this, result.Data, MH806ELrdC5RbFM8cuj.igVLEBmIlE);
			}
		}
		else if (e is HttpRequestException ex2)
		{
			if (JLicB9LXxFmNHHTqMTM.IB3tMMvyI(ex2, JLicB9LXxFmNHHTqMTM.CAhLFrTOVi) is SocketException ex3)
			{
				SocketError socketError = nsOM07L0RUB8JDdXIIG.IB3tMMvyI(ex3, nsOM07L0RUB8JDdXIIG.IVxLTlXPoJ);
				if (socketError <= SocketError.NotConnected)
				{
					if (socketError != SocketError.NetworkUnreachable)
					{
						_ = 10057;
						return;
					}
					cBRrURLc05Kd61yN0Vm.IB3tMMvyI(this, ExceptionType.NoNetwork, cBRrURLc05Kd61yN0Vm.uqVLqSgBJf);
					QV5Py2LOX8yx6ajM6nW.IB3tMMvyI(this, q2no0WnPxDaipZawxT.IB3tMMvyI(2528, q2no0WnPxDaipZawxT.eV4vC1LZv), QV5Py2LOX8yx6ajM6nW.UN9LKXDiLi);
					return;
				}
				switch (socketError)
				{
				default:
					_ = 11001;
					break;
				case SocketError.ConnectionRefused:
					cBRrURLc05Kd61yN0Vm.IB3tMMvyI(this, ExceptionType.NoNetwork, cBRrURLc05Kd61yN0Vm.uqVLqSgBJf);
					QV5Py2LOX8yx6ajM6nW.IB3tMMvyI(this, q2no0WnPxDaipZawxT.IB3tMMvyI(2334, q2no0WnPxDaipZawxT.eV4vC1LZv), QV5Py2LOX8yx6ajM6nW.UN9LKXDiLi);
					break;
				case (SocketError)10062:
				case (SocketError)10063:
				case SocketError.HostDown:
				case SocketError.HostUnreachable:
					break;
				}
			}
			else
			{
				cBRrURLc05Kd61yN0Vm.IB3tMMvyI(this, ExceptionType.NoInternet, cBRrURLc05Kd61yN0Vm.uqVLqSgBJf);
				QV5Py2LOX8yx6ajM6nW.IB3tMMvyI(this, q2no0WnPxDaipZawxT.IB3tMMvyI(2574, q2no0WnPxDaipZawxT.eV4vC1LZv), QV5Py2LOX8yx6ajM6nW.UN9LKXDiLi);
			}
		}
		else
		{
			cBRrURLc05Kd61yN0Vm.IB3tMMvyI(this, ExceptionType.Unknown, cBRrURLc05Kd61yN0Vm.uqVLqSgBJf);
			QV5Py2LOX8yx6ajM6nW.IB3tMMvyI(this, q2no0WnPxDaipZawxT.IB3tMMvyI(2130, q2no0WnPxDaipZawxT.eV4vC1LZv), QV5Py2LOX8yx6ajM6nW.UN9LKXDiLi);
		}
	}
}
