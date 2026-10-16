using System.Runtime.CompilerServices;
using System.Windows;
using HandyControl.Controls;
using PROTV.Abstractions.DataTransferObjects;
using PROTV.Abstractions.Services;
using PROTV.Wpf.Bootstrap;
using Unosquare.FFME;
using Unosquare.FFME.Common;

namespace PROTV.Wpf.ViewModels;

public class ControllerViewModel<T> : AttachedViewModel<T> where T : new()
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass36_0
	{
		public bool value;

		public _003C_003Ec__DisplayClass36_0()
		{
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
			base._002Ector();
		}

		internal void hNySldvH2e()
		{
			QnJnl7fVDKI4mA6voc.D35lls5iF(VqWOinl9PO0jF3BJej0.D35lls5iF(Jr0pTQlovwB9pdID1EB.D35lls5iF(Jr0pTQlovwB9pdID1EB.CxrllgXtD4), VqWOinl9PO0jF3BJej0.XwJlDOAaeh) as HandyControl.Controls.Window, value, QnJnl7fVDKI4mA6voc.rhqn3tRO5f);
			QnJnl7fVDKI4mA6voc.D35lls5iF(AppContainer.Resolve<HomeViewModel>(), !value, QnJnl7fVDKI4mA6voc.vjRHOd6ZiQ);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass77_0
	{
		public ControllerViewModel<T> _003C_003E4__this;

		public MediaElement m;

		public _003C_003Ec__DisplayClass77_0()
		{
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
			base._002Ector();
		}

		internal void jBgSUrI6Lr()
		{
			_003C_003E4__this.IsMediaOpenVisibility = ((!hjMnupQVVDlRZAYQJC.D35lls5iF(m, hjMnupQVVDlRZAYQJC.duTlSYqJTf)) ? Visibility.Hidden : Visibility.Visible);
		}

		internal void C1rSL1FNLX()
		{
			_003C_003E4__this.ClosedCaptionsVisibility = ((!LsA6RHpKkbdnOn3fX60.D35lls5iF(m, LsA6RHpKkbdnOn3fX60.Nk3ab8ya50)) ? Visibility.Hidden : Visibility.Visible);
		}

		internal void k0bS2PmNwD()
		{
			_003C_003E4__this.AudioControlVisibility = ((!LsA6RHpKkbdnOn3fX60.D35lls5iF(m, LsA6RHpKkbdnOn3fX60.yuFpuMhtBi)) ? Visibility.Hidden : Visibility.Visible);
			_003C_003E4__this.IsAudioControlEnabled = LsA6RHpKkbdnOn3fX60.D35lls5iF(m, LsA6RHpKkbdnOn3fX60.yuFpuMhtBi);
		}

		internal void BopSzjSFGQ()
		{
			_003C_003E4__this.PauseButtonVisibility = ((!LsA6RHpKkbdnOn3fX60.D35lls5iF(m, LsA6RHpKkbdnOn3fX60.i1SpNIKWjy) || !uEUVCI48fycroqgRFqy.D35lls5iF(m, uEUVCI48fycroqgRFqy.RIVAOZeovq)) ? Visibility.Collapsed : Visibility.Visible);
		}

		internal void e7RfcESkZ4()
		{
			_003C_003E4__this.PlayButtonVisibility = ((!hjMnupQVVDlRZAYQJC.D35lls5iF(m, hjMnupQVVDlRZAYQJC.duTlSYqJTf) || uEUVCI48fycroqgRFqy.D35lls5iF(m, uEUVCI48fycroqgRFqy.RIVAOZeovq) || LsA6RHpKkbdnOn3fX60.D35lls5iF(m, LsA6RHpKkbdnOn3fX60.CRbphs2AS6) || LsA6RHpKkbdnOn3fX60.D35lls5iF(m, LsA6RHpKkbdnOn3fX60.tNPpxOexD7) || LsA6RHpKkbdnOn3fX60.D35lls5iF(m, LsA6RHpKkbdnOn3fX60.g8dpYy0Qdx)) ? Visibility.Collapsed : Visibility.Visible);
		}

		internal void qrYfjx3a9B()
		{
			_003C_003E4__this.StopButtonVisibility = ((!hjMnupQVVDlRZAYQJC.D35lls5iF(m, hjMnupQVVDlRZAYQJC.duTlSYqJTf) || LsA6RHpKkbdnOn3fX60.D35lls5iF(m, LsA6RHpKkbdnOn3fX60.g8dpYy0Qdx) || LsA6RHpKkbdnOn3fX60.D35lls5iF(m, LsA6RHpKkbdnOn3fX60.tNPpxOexD7) || (!LsA6RHpKkbdnOn3fX60.D35lls5iF(m, LsA6RHpKkbdnOn3fX60.CRbphs2AS6) && (!uEUVCI48fycroqgRFqy.D35lls5iF(m, uEUVCI48fycroqgRFqy.N8bpMvV7Dk) || mVvtS7EIHM1vMqAX3i0.D35lls5iF(m, mVvtS7EIHM1vMqAX3i0.r6FaWiwE4Q) == MediaPlaybackState.Stop))) ? Visibility.Hidden : Visibility.Visible);
		}

		internal void yAefvkG07D()
		{
			_003C_003E4__this.CloseButtonVisibility = ((!hjMnupQVVDlRZAYQJC.D35lls5iF(m, hjMnupQVVDlRZAYQJC.duTlSYqJTf) && !LsA6RHpKkbdnOn3fX60.D35lls5iF(m, LsA6RHpKkbdnOn3fX60.Lw6piG3FQv)) ? Visibility.Hidden : Visibility.Visible);
		}

		internal void RBufWanlRj()
		{
			_003C_003E4__this.SeekBarVisibility = ((!uEUVCI48fycroqgRFqy.D35lls5iF(m, uEUVCI48fycroqgRFqy.N8bpMvV7Dk)) ? Visibility.Hidden : Visibility.Visible);
		}

		internal void HqZf46FDn6()
		{
			_003C_003E4__this.BufferingProgressVisibility = ((!LsA6RHpKkbdnOn3fX60.D35lls5iF(m, LsA6RHpKkbdnOn3fX60.Lw6piG3FQv) && (!LsA6RHpKkbdnOn3fX60.D35lls5iF(m, LsA6RHpKkbdnOn3fX60.me6pQKk0mn) || !(bATk1clKMSyO8g9EVbN.D35lls5iF(m, bATk1clKMSyO8g9EVbN.sMSpXlAoY0) < 0.95))) ? Visibility.Hidden : Visibility.Visible);
		}

		internal void wv5fBhJqR2()
		{
			_003C_003E4__this.DownloadProgressVisibility = ((!hjMnupQVVDlRZAYQJC.D35lls5iF(m, hjMnupQVVDlRZAYQJC.duTlSYqJTf) || LsA6RHpKkbdnOn3fX60.D35lls5iF(m, LsA6RHpKkbdnOn3fX60.CRbphs2AS6) || ((!(Rfe4g0pfhM1nR3u94hp.D35lls5iF(m, Rfe4g0pfhM1nR3u94hp.OBQpFX7hNJ) > 0.0) || !(Rfe4g0pfhM1nR3u94hp.D35lls5iF(m, Rfe4g0pfhM1nR3u94hp.OBQpFX7hNJ) < 0.95)) && !LsA6RHpKkbdnOn3fX60.D35lls5iF(m, LsA6RHpKkbdnOn3fX60.pZXp20CoRT))) ? Visibility.Hidden : Visibility.Visible);
		}

		internal void UOdfDMrbsK()
		{
			_003C_003E4__this.OpenButtonVisibility = ((LsA6RHpKkbdnOn3fX60.D35lls5iF(m, LsA6RHpKkbdnOn3fX60.Lw6piG3FQv) || _003C_003E4__this.OpenButtonVisibility == Visibility.Collapsed) ? ((LsA6RHpKkbdnOn3fX60.D35lls5iF(m, LsA6RHpKkbdnOn3fX60.Lw6piG3FQv) && _003C_003E4__this.OpenButtonVisibility != Visibility.Collapsed) ? Visibility.Hidden : Visibility.Collapsed) : Visibility.Visible);
		}

		internal void X4qfdqEebD()
		{
			_003C_003E4__this.IsSpeedRatioEnabled = !LsA6RHpKkbdnOn3fX60.D35lls5iF(m, LsA6RHpKkbdnOn3fX60.Lw6piG3FQv);
		}
	}

	private Visibility S4AIjD0iFt;

	private bool enJIvVDDa3;

	private bool KwpIWvcbVh;

	private bool MZCI4Lqerk;

	private Visibility nYeIBRqYoO;

	private Visibility kAmIDeTx7q;

	private Visibility SP9IdQdUF1;

	private Visibility U0RIPKbMxq;

	private Visibility BvgIqlnBLN;

	private Visibility NhWIIKvv9I;

	private Visibility CkJIVntNs4;

	private Visibility DtyIabt1PJ;

	private Visibility cKGI0iWvOo;

	private Visibility d9TIG9d6ch;

	private Visibility VPgITP3BgA;

	private Visibility iI6IZleGJ2;

	private Visibility GDnItM0P5s;

	private Visibility Uo4IS3dLZf;

	private Visibility KaCIfFufaP;

	public Visibility OpenSettingPanelVisibility
	{
		get
		{
			return KaCIfFufaP;
		}
		set
		{
			SetProperty(ref KaCIfFufaP, value, iFZ5je3XFYKwkvcE5D.D35lls5iF(7574, iFZ5je3XFYKwkvcE5D.N06TeK0ao));
		}
	}

	public Visibility OpenPropertiesPanelVisibility
	{
		get
		{
			return nYeIBRqYoO;
		}
		set
		{
			SetProperty(ref nYeIBRqYoO, value, iFZ5je3XFYKwkvcE5D.D35lls5iF(7630, iFZ5je3XFYKwkvcE5D.N06TeK0ao));
		}
	}

	public Visibility TextSizeButtonVisibility
	{
		get
		{
			return Uo4IS3dLZf;
		}
		set
		{
			SetProperty(ref Uo4IS3dLZf, value, iFZ5je3XFYKwkvcE5D.D35lls5iF(7692, iFZ5je3XFYKwkvcE5D.N06TeK0ao));
		}
	}

	public Visibility IsMediaOpenVisibility
	{
		get
		{
			return S4AIjD0iFt;
		}
		set
		{
			SetProperty(ref S4AIjD0iFt, value, iFZ5je3XFYKwkvcE5D.D35lls5iF(7302, iFZ5je3XFYKwkvcE5D.N06TeK0ao));
		}
	}

	public Visibility LikeButtonVisibility
	{
		get
		{
			return GDnItM0P5s;
		}
		set
		{
			SetProperty(ref GDnItM0P5s, value, iFZ5je3XFYKwkvcE5D.D35lls5iF(7438, iFZ5je3XFYKwkvcE5D.N06TeK0ao));
		}
	}

	public bool Isfullscreen
	{
		get
		{
			return MZCI4Lqerk;
		}
		set
		{
			_003C_003Ec__DisplayClass36_0 CS_0024_003C_003E8__locals4 = new _003C_003Ec__DisplayClass36_0();
			CS_0024_003C_003E8__locals4.value = value;
			SetProperty(ref MZCI4Lqerk, CS_0024_003C_003E8__locals4.value, iFZ5je3XFYKwkvcE5D.D35lls5iF(7744, iFZ5je3XFYKwkvcE5D.N06TeK0ao), null, delegate
			{
				QnJnl7fVDKI4mA6voc.D35lls5iF(VqWOinl9PO0jF3BJej0.D35lls5iF(Jr0pTQlovwB9pdID1EB.D35lls5iF(Jr0pTQlovwB9pdID1EB.CxrllgXtD4), VqWOinl9PO0jF3BJej0.XwJlDOAaeh) as HandyControl.Controls.Window, CS_0024_003C_003E8__locals4.value, QnJnl7fVDKI4mA6voc.rhqn3tRO5f);
				QnJnl7fVDKI4mA6voc.D35lls5iF(AppContainer.Resolve<HomeViewModel>(), !CS_0024_003C_003E8__locals4.value, QnJnl7fVDKI4mA6voc.vjRHOd6ZiQ);
			});
		}
	}

	public bool IsAudioControlEnabled
	{
		get
		{
			return enJIvVDDa3;
		}
		set
		{
			SetProperty(ref enJIvVDDa3, value, iFZ5je3XFYKwkvcE5D.D35lls5iF(7772, iFZ5je3XFYKwkvcE5D.N06TeK0ao));
		}
	}

	public Visibility ClosedCaptionsVisibility
	{
		get
		{
			return kAmIDeTx7q;
		}
		set
		{
			SetProperty(ref kAmIDeTx7q, value, iFZ5je3XFYKwkvcE5D.D35lls5iF(11168, iFZ5je3XFYKwkvcE5D.N06TeK0ao));
		}
	}

	public bool IsSpeedRatioEnabled
	{
		get
		{
			return KwpIWvcbVh;
		}
		set
		{
			SetProperty(ref KwpIWvcbVh, value, iFZ5je3XFYKwkvcE5D.D35lls5iF(11220, iFZ5je3XFYKwkvcE5D.N06TeK0ao));
		}
	}

	public Visibility AudioControlVisibility
	{
		get
		{
			return SP9IdQdUF1;
		}
		set
		{
			SetProperty(ref SP9IdQdUF1, value, iFZ5je3XFYKwkvcE5D.D35lls5iF(7526, iFZ5je3XFYKwkvcE5D.N06TeK0ao));
		}
	}

	public Visibility PauseButtonVisibility
	{
		get
		{
			return U0RIPKbMxq;
		}
		set
		{
			SetProperty(ref U0RIPKbMxq, value, iFZ5je3XFYKwkvcE5D.D35lls5iF(7348, iFZ5je3XFYKwkvcE5D.N06TeK0ao));
		}
	}

	public Visibility PlayButtonVisibility
	{
		get
		{
			return BvgIqlnBLN;
		}
		set
		{
			SetProperty(ref BvgIqlnBLN, value, iFZ5je3XFYKwkvcE5D.D35lls5iF(7394, iFZ5je3XFYKwkvcE5D.N06TeK0ao));
		}
	}

	public Visibility StopButtonVisibility
	{
		get
		{
			return NhWIIKvv9I;
		}
		set
		{
			SetProperty(ref NhWIIKvv9I, value, iFZ5je3XFYKwkvcE5D.D35lls5iF(11262, iFZ5je3XFYKwkvcE5D.N06TeK0ao));
		}
	}

	public Visibility CloseButtonVisibility
	{
		get
		{
			return CkJIVntNs4;
		}
		set
		{
			SetProperty(ref CkJIVntNs4, value, iFZ5je3XFYKwkvcE5D.D35lls5iF(11306, iFZ5je3XFYKwkvcE5D.N06TeK0ao));
		}
	}

	public Visibility OpenButtonVisibility
	{
		get
		{
			return DtyIabt1PJ;
		}
		set
		{
			SetProperty(ref DtyIabt1PJ, value, iFZ5je3XFYKwkvcE5D.D35lls5iF(7482, iFZ5je3XFYKwkvcE5D.N06TeK0ao));
		}
	}

	public Visibility SeekBarVisibility
	{
		get
		{
			return cKGI0iWvOo;
		}
		set
		{
			SetProperty(ref cKGI0iWvOo, value, iFZ5je3XFYKwkvcE5D.D35lls5iF(7096, iFZ5je3XFYKwkvcE5D.N06TeK0ao));
		}
	}

	public Visibility BufferingProgressVisibility
	{
		get
		{
			return d9TIG9d6ch;
		}
		set
		{
			SetProperty(ref d9TIG9d6ch, value, iFZ5je3XFYKwkvcE5D.D35lls5iF(7134, iFZ5je3XFYKwkvcE5D.N06TeK0ao));
		}
	}

	public Visibility DownloadProgressVisibility
	{
		get
		{
			return iI6IZleGJ2;
		}
		set
		{
			SetProperty(ref iI6IZleGJ2, value, iFZ5je3XFYKwkvcE5D.D35lls5iF(7192, iFZ5je3XFYKwkvcE5D.N06TeK0ao));
		}
	}

	public Visibility PostionProgressVisibility
	{
		get
		{
			return VPgITP3BgA;
		}
		set
		{
			SetProperty(ref VPgITP3BgA, value, iFZ5je3XFYKwkvcE5D.D35lls5iF(7248, iFZ5je3XFYKwkvcE5D.N06TeK0ao));
		}
	}

	public ControllerViewModel(FFMEBaseViewModel<T> root)
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		enJIvVDDa3 = true;
		KwpIWvcbVh = true;
		nYeIBRqYoO = Visibility.Collapsed;
		GDnItM0P5s = Visibility.Collapsed;
		Uo4IS3dLZf = Visibility.Collapsed;
		KaCIfFufaP = Visibility.Collapsed;
		base._002Ector(root);
		IStoreContext storeContext = AppContainer.Resolve<IStoreContext>();
		bool? obj;
		if (storeContext == null)
		{
			obj = null;
		}
		else
		{
			ClientResponseDto clientResponseDto = uDRo1NTTfYDM7pYeNXf.D35lls5iF(storeContext, uDRo1NTTfYDM7pYeNXf.vmET4kj87M);
			obj = ((clientResponseDto != null) ? new bool?(uEUVCI48fycroqgRFqy.D35lls5iF(clientResponseDto, uEUVCI48fycroqgRFqy.IgbEGsCbv8)) : ((bool?)null));
		}
		bool? flag = obj;
		OpenPropertiesPanelVisibility = ((flag != true) ? Visibility.Collapsed : Visibility.Visible);
	}

	public override void OnApplicationLoaded()
	{
		_003C_003Ec__DisplayClass77_0 CS_0024_003C_003E8__locals60 = new _003C_003Ec__DisplayClass77_0();
		CS_0024_003C_003E8__locals60._003C_003E4__this = this;
		CS_0024_003C_003E8__locals60.m = base.Root.MediaElement;
		v0XVuPTnBNWT9uCXcZe.D35lls5iF(delegate
		{
			CS_0024_003C_003E8__locals60._003C_003E4__this.IsMediaOpenVisibility = ((!hjMnupQVVDlRZAYQJC.D35lls5iF(CS_0024_003C_003E8__locals60.m, hjMnupQVVDlRZAYQJC.duTlSYqJTf)) ? Visibility.Hidden : Visibility.Visible);
		}, CS_0024_003C_003E8__locals60.m, new string[1] { iFZ5je3XFYKwkvcE5D.D35lls5iF(7818, iFZ5je3XFYKwkvcE5D.N06TeK0ao) }, v0XVuPTnBNWT9uCXcZe.MYgT36wkiL);
		v0XVuPTnBNWT9uCXcZe.D35lls5iF(delegate
		{
			CS_0024_003C_003E8__locals60._003C_003E4__this.ClosedCaptionsVisibility = ((!LsA6RHpKkbdnOn3fX60.D35lls5iF(CS_0024_003C_003E8__locals60.m, LsA6RHpKkbdnOn3fX60.Nk3ab8ya50)) ? Visibility.Hidden : Visibility.Visible);
		}, CS_0024_003C_003E8__locals60.m, new string[1] { iFZ5je3XFYKwkvcE5D.D35lls5iF(11352, iFZ5je3XFYKwkvcE5D.N06TeK0ao) }, v0XVuPTnBNWT9uCXcZe.MYgT36wkiL);
		v0XVuPTnBNWT9uCXcZe.D35lls5iF(delegate
		{
			CS_0024_003C_003E8__locals60._003C_003E4__this.AudioControlVisibility = ((!LsA6RHpKkbdnOn3fX60.D35lls5iF(CS_0024_003C_003E8__locals60.m, LsA6RHpKkbdnOn3fX60.yuFpuMhtBi)) ? Visibility.Hidden : Visibility.Visible);
			CS_0024_003C_003E8__locals60._003C_003E4__this.IsAudioControlEnabled = LsA6RHpKkbdnOn3fX60.D35lls5iF(CS_0024_003C_003E8__locals60.m, LsA6RHpKkbdnOn3fX60.yuFpuMhtBi);
		}, CS_0024_003C_003E8__locals60.m, new string[1] { iFZ5je3XFYKwkvcE5D.D35lls5iF(7900, iFZ5je3XFYKwkvcE5D.N06TeK0ao) }, v0XVuPTnBNWT9uCXcZe.MYgT36wkiL);
		v0XVuPTnBNWT9uCXcZe.D35lls5iF(delegate
		{
			CS_0024_003C_003E8__locals60._003C_003E4__this.PauseButtonVisibility = ((!LsA6RHpKkbdnOn3fX60.D35lls5iF(CS_0024_003C_003E8__locals60.m, LsA6RHpKkbdnOn3fX60.i1SpNIKWjy) || !uEUVCI48fycroqgRFqy.D35lls5iF(CS_0024_003C_003E8__locals60.m, uEUVCI48fycroqgRFqy.RIVAOZeovq)) ? Visibility.Collapsed : Visibility.Visible);
		}, CS_0024_003C_003E8__locals60.m, new string[2]
		{
			iFZ5je3XFYKwkvcE5D.D35lls5iF(7858, iFZ5je3XFYKwkvcE5D.N06TeK0ao),
			iFZ5je3XFYKwkvcE5D.D35lls5iF(7878, iFZ5je3XFYKwkvcE5D.N06TeK0ao)
		}, v0XVuPTnBNWT9uCXcZe.MYgT36wkiL);
		v0XVuPTnBNWT9uCXcZe.D35lls5iF(delegate
		{
			CS_0024_003C_003E8__locals60._003C_003E4__this.PlayButtonVisibility = ((!hjMnupQVVDlRZAYQJC.D35lls5iF(CS_0024_003C_003E8__locals60.m, hjMnupQVVDlRZAYQJC.duTlSYqJTf) || uEUVCI48fycroqgRFqy.D35lls5iF(CS_0024_003C_003E8__locals60.m, uEUVCI48fycroqgRFqy.RIVAOZeovq) || LsA6RHpKkbdnOn3fX60.D35lls5iF(CS_0024_003C_003E8__locals60.m, LsA6RHpKkbdnOn3fX60.CRbphs2AS6) || LsA6RHpKkbdnOn3fX60.D35lls5iF(CS_0024_003C_003E8__locals60.m, LsA6RHpKkbdnOn3fX60.tNPpxOexD7) || LsA6RHpKkbdnOn3fX60.D35lls5iF(CS_0024_003C_003E8__locals60.m, LsA6RHpKkbdnOn3fX60.g8dpYy0Qdx)) ? Visibility.Collapsed : Visibility.Visible);
		}, CS_0024_003C_003E8__locals60.m, new string[5]
		{
			iFZ5je3XFYKwkvcE5D.D35lls5iF(7818, iFZ5je3XFYKwkvcE5D.N06TeK0ao),
			iFZ5je3XFYKwkvcE5D.D35lls5iF(7878, iFZ5je3XFYKwkvcE5D.N06TeK0ao),
			iFZ5je3XFYKwkvcE5D.D35lls5iF(7920, iFZ5je3XFYKwkvcE5D.N06TeK0ao),
			iFZ5je3XFYKwkvcE5D.D35lls5iF(7950, iFZ5je3XFYKwkvcE5D.N06TeK0ao),
			iFZ5je3XFYKwkvcE5D.D35lls5iF(7972, iFZ5je3XFYKwkvcE5D.N06TeK0ao)
		}, v0XVuPTnBNWT9uCXcZe.MYgT36wkiL);
		v0XVuPTnBNWT9uCXcZe.D35lls5iF(delegate
		{
			CS_0024_003C_003E8__locals60._003C_003E4__this.StopButtonVisibility = ((!hjMnupQVVDlRZAYQJC.D35lls5iF(CS_0024_003C_003E8__locals60.m, hjMnupQVVDlRZAYQJC.duTlSYqJTf) || LsA6RHpKkbdnOn3fX60.D35lls5iF(CS_0024_003C_003E8__locals60.m, LsA6RHpKkbdnOn3fX60.g8dpYy0Qdx) || LsA6RHpKkbdnOn3fX60.D35lls5iF(CS_0024_003C_003E8__locals60.m, LsA6RHpKkbdnOn3fX60.tNPpxOexD7) || (!LsA6RHpKkbdnOn3fX60.D35lls5iF(CS_0024_003C_003E8__locals60.m, LsA6RHpKkbdnOn3fX60.CRbphs2AS6) && (!uEUVCI48fycroqgRFqy.D35lls5iF(CS_0024_003C_003E8__locals60.m, uEUVCI48fycroqgRFqy.N8bpMvV7Dk) || mVvtS7EIHM1vMqAX3i0.D35lls5iF(CS_0024_003C_003E8__locals60.m, mVvtS7EIHM1vMqAX3i0.r6FaWiwE4Q) == MediaPlaybackState.Stop))) ? Visibility.Hidden : Visibility.Visible);
		}, CS_0024_003C_003E8__locals60.m, new string[6]
		{
			iFZ5je3XFYKwkvcE5D.D35lls5iF(7818, iFZ5je3XFYKwkvcE5D.N06TeK0ao),
			iFZ5je3XFYKwkvcE5D.D35lls5iF(7920, iFZ5je3XFYKwkvcE5D.N06TeK0ao),
			iFZ5je3XFYKwkvcE5D.D35lls5iF(7834, iFZ5je3XFYKwkvcE5D.N06TeK0ao),
			iFZ5je3XFYKwkvcE5D.D35lls5iF(11390, iFZ5je3XFYKwkvcE5D.N06TeK0ao),
			iFZ5je3XFYKwkvcE5D.D35lls5iF(7972, iFZ5je3XFYKwkvcE5D.N06TeK0ao),
			iFZ5je3XFYKwkvcE5D.D35lls5iF(7950, iFZ5je3XFYKwkvcE5D.N06TeK0ao)
		}, v0XVuPTnBNWT9uCXcZe.MYgT36wkiL);
		v0XVuPTnBNWT9uCXcZe.D35lls5iF(delegate
		{
			CS_0024_003C_003E8__locals60._003C_003E4__this.CloseButtonVisibility = ((!hjMnupQVVDlRZAYQJC.D35lls5iF(CS_0024_003C_003E8__locals60.m, hjMnupQVVDlRZAYQJC.duTlSYqJTf) && !LsA6RHpKkbdnOn3fX60.D35lls5iF(CS_0024_003C_003E8__locals60.m, LsA6RHpKkbdnOn3fX60.Lw6piG3FQv)) ? Visibility.Hidden : Visibility.Visible);
		}, CS_0024_003C_003E8__locals60.m, new string[2]
		{
			iFZ5je3XFYKwkvcE5D.D35lls5iF(7818, iFZ5je3XFYKwkvcE5D.N06TeK0ao),
			iFZ5je3XFYKwkvcE5D.D35lls5iF(7996, iFZ5je3XFYKwkvcE5D.N06TeK0ao)
		}, v0XVuPTnBNWT9uCXcZe.MYgT36wkiL);
		v0XVuPTnBNWT9uCXcZe.D35lls5iF(delegate
		{
			CS_0024_003C_003E8__locals60._003C_003E4__this.SeekBarVisibility = ((!uEUVCI48fycroqgRFqy.D35lls5iF(CS_0024_003C_003E8__locals60.m, uEUVCI48fycroqgRFqy.N8bpMvV7Dk)) ? Visibility.Hidden : Visibility.Visible);
		}, CS_0024_003C_003E8__locals60.m, new string[1] { iFZ5je3XFYKwkvcE5D.D35lls5iF(7834, iFZ5je3XFYKwkvcE5D.N06TeK0ao) }, v0XVuPTnBNWT9uCXcZe.MYgT36wkiL);
		if (hjMnupQVVDlRZAYQJC.D35lls5iF(uDRo1NTTfYDM7pYeNXf.D35lls5iF(AppContainer.Resolve<IStoreContext>(), uDRo1NTTfYDM7pYeNXf.vmET4kj87M), hjMnupQVVDlRZAYQJC.sYSTLUCNxp))
		{
			v0XVuPTnBNWT9uCXcZe.D35lls5iF(delegate
			{
				CS_0024_003C_003E8__locals60._003C_003E4__this.BufferingProgressVisibility = ((!LsA6RHpKkbdnOn3fX60.D35lls5iF(CS_0024_003C_003E8__locals60.m, LsA6RHpKkbdnOn3fX60.Lw6piG3FQv) && (!LsA6RHpKkbdnOn3fX60.D35lls5iF(CS_0024_003C_003E8__locals60.m, LsA6RHpKkbdnOn3fX60.me6pQKk0mn) || !(bATk1clKMSyO8g9EVbN.D35lls5iF(CS_0024_003C_003E8__locals60.m, bATk1clKMSyO8g9EVbN.sMSpXlAoY0) < 0.95))) ? Visibility.Hidden : Visibility.Visible);
			}, CS_0024_003C_003E8__locals60.m, new string[4]
			{
				iFZ5je3XFYKwkvcE5D.D35lls5iF(7996, iFZ5je3XFYKwkvcE5D.N06TeK0ao),
				iFZ5je3XFYKwkvcE5D.D35lls5iF(8018, iFZ5je3XFYKwkvcE5D.N06TeK0ao),
				iFZ5je3XFYKwkvcE5D.D35lls5iF(8044, iFZ5je3XFYKwkvcE5D.N06TeK0ao),
				iFZ5je3XFYKwkvcE5D.D35lls5iF(8082, iFZ5je3XFYKwkvcE5D.N06TeK0ao)
			}, v0XVuPTnBNWT9uCXcZe.MYgT36wkiL);
			v0XVuPTnBNWT9uCXcZe.D35lls5iF(delegate
			{
				CS_0024_003C_003E8__locals60._003C_003E4__this.DownloadProgressVisibility = ((!hjMnupQVVDlRZAYQJC.D35lls5iF(CS_0024_003C_003E8__locals60.m, hjMnupQVVDlRZAYQJC.duTlSYqJTf) || LsA6RHpKkbdnOn3fX60.D35lls5iF(CS_0024_003C_003E8__locals60.m, LsA6RHpKkbdnOn3fX60.CRbphs2AS6) || ((!(Rfe4g0pfhM1nR3u94hp.D35lls5iF(CS_0024_003C_003E8__locals60.m, Rfe4g0pfhM1nR3u94hp.OBQpFX7hNJ) > 0.0) || !(Rfe4g0pfhM1nR3u94hp.D35lls5iF(CS_0024_003C_003E8__locals60.m, Rfe4g0pfhM1nR3u94hp.OBQpFX7hNJ) < 0.95)) && !LsA6RHpKkbdnOn3fX60.D35lls5iF(CS_0024_003C_003E8__locals60.m, LsA6RHpKkbdnOn3fX60.pZXp20CoRT))) ? Visibility.Hidden : Visibility.Visible);
			}, CS_0024_003C_003E8__locals60.m, new string[4]
			{
				iFZ5je3XFYKwkvcE5D.D35lls5iF(7818, iFZ5je3XFYKwkvcE5D.N06TeK0ao),
				iFZ5je3XFYKwkvcE5D.D35lls5iF(7920, iFZ5je3XFYKwkvcE5D.N06TeK0ao),
				iFZ5je3XFYKwkvcE5D.D35lls5iF(8102, iFZ5je3XFYKwkvcE5D.N06TeK0ao),
				iFZ5je3XFYKwkvcE5D.D35lls5iF(8138, iFZ5je3XFYKwkvcE5D.N06TeK0ao)
			}, v0XVuPTnBNWT9uCXcZe.MYgT36wkiL);
		}
		else
		{
			BufferingProgressVisibility = Visibility.Hidden;
			DownloadProgressVisibility = Visibility.Hidden;
		}
		v0XVuPTnBNWT9uCXcZe.D35lls5iF(delegate
		{
			CS_0024_003C_003E8__locals60._003C_003E4__this.OpenButtonVisibility = ((LsA6RHpKkbdnOn3fX60.D35lls5iF(CS_0024_003C_003E8__locals60.m, LsA6RHpKkbdnOn3fX60.Lw6piG3FQv) || CS_0024_003C_003E8__locals60._003C_003E4__this.OpenButtonVisibility == Visibility.Collapsed) ? ((LsA6RHpKkbdnOn3fX60.D35lls5iF(CS_0024_003C_003E8__locals60.m, LsA6RHpKkbdnOn3fX60.Lw6piG3FQv) && CS_0024_003C_003E8__locals60._003C_003E4__this.OpenButtonVisibility != Visibility.Collapsed) ? Visibility.Hidden : Visibility.Collapsed) : Visibility.Visible);
		}, CS_0024_003C_003E8__locals60.m, new string[1] { iFZ5je3XFYKwkvcE5D.D35lls5iF(7996, iFZ5je3XFYKwkvcE5D.N06TeK0ao) }, v0XVuPTnBNWT9uCXcZe.MYgT36wkiL);
		v0XVuPTnBNWT9uCXcZe.D35lls5iF(delegate
		{
			CS_0024_003C_003E8__locals60._003C_003E4__this.IsSpeedRatioEnabled = !LsA6RHpKkbdnOn3fX60.D35lls5iF(CS_0024_003C_003E8__locals60.m, LsA6RHpKkbdnOn3fX60.Lw6piG3FQv);
		}, CS_0024_003C_003E8__locals60.m, new string[2]
		{
			iFZ5je3XFYKwkvcE5D.D35lls5iF(7818, iFZ5je3XFYKwkvcE5D.N06TeK0ao),
			iFZ5je3XFYKwkvcE5D.D35lls5iF(7834, iFZ5je3XFYKwkvcE5D.N06TeK0ao)
		}, v0XVuPTnBNWT9uCXcZe.MYgT36wkiL);
	}
}
