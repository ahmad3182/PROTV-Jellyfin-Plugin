using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Threading;
using FFmpeg.AutoGen;
using PROTV.Abstractions.DataTransferObjects;
using PROTV.Wpf.ViewModels;
using Unosquare.FFME;
using Unosquare.FFME.ClosedCaptions;
using Unosquare.FFME.Common;

namespace PROTV.Wpf.Views;

public class FFMEPlayerControl : UserControl, IComponentConnector
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass6_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct mp07y6VPybXpYS9Rto : IAsyncStateMachine
		{
			public int OLu8Q0pE7m;

			public AsyncVoidMethodBuilder z558nLbOQW;

			public _003C_003Ec__DisplayClass6_0 jfV8bia58g;

			private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter S7Y87PQcTG;

			private void MoveNext()
			{
				int num = OLu8Q0pE7m;
				_003C_003Ec__DisplayClass6_0 obj = jfV8bia58g;
				try
				{
					ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = wd2eJ2Asf3I9epXUKxU.D35lls5iF(obj.DTcTKUXPl5.Media, wd2eJ2Asf3I9epXUKxU.lWJ6M1uBV4).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (OLu8Q0pE7m = 0);
							S7Y87PQcTG = awaiter;
							z558nLbOQW.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = S7Y87PQcTG;
						S7Y87PQcTG = default(ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter);
						num = (OLu8Q0pE7m = -1);
					}
					awaiter.GetResult();
				}
				catch (Exception ex)
				{
					OLu8Q0pE7m = -2;
					N2XUglA3neBsnlZfRPQ.D35lls5iF(ref z558nLbOQW, ex, N2XUglA3neBsnlZfRPQ.l4pATRumoW);
					return;
				}
				OLu8Q0pE7m = -2;
				T4XmPoA4VNJJP1afcgL.D35lls5iF(ref z558nLbOQW, T4XmPoA4VNJJP1afcgL.TRyALZckCh);
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine P_0)
			{
				dHWo7jAEn6E4X7bsY4R.D35lls5iF(ref z558nLbOQW, P_0, dHWo7jAEn6E4X7bsY4R.z3hAB6UZ9o);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine P_0)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(P_0);
			}
		}

		public IntPtr qPUTBfcibB;

		public object T7hTDMWG29;

		public double CwETdtFdvB;

		public double fqbTPVkpq7;

		public Graphics PMwTqikaAc;

		public Bitmap U6mTIQBrCQ;

		public TimeSpan z1FTV47YY1;

		public TimeSpan sVrTa9dgRt;

		public Font wKcT0pQbU0;

		public Brush tqmTGepjh2;

		public PointF Sp3TTvNKZ3;

		public Pen p2HTZw7KDM;

		public Pen bM6TtYYHW6;

		public double[] pcPTSsvOfk;

		public double[] tJPTfkNty2;

		public FFMEPlayerControl DTcTKUXPl5;

		public _003C_003Ec__DisplayClass6_0()
		{
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
			base._002Ector();
		}

		internal void oN1TvYmpT3(object s, RenderingVideoEventArgs e)
		{
			if (gfMVqRAjEUY1XoHkUXS.D35lls5iF(qPUTBfcibB, Hwo9WvvS2l3n9OBJ1Wx.D35lls5iF(ibJZ1yAFaX0lCm5ygiC.D35lls5iF(e, ibJZ1yAFaX0lCm5ygiC.wWZA2RE9KS), Hwo9WvvS2l3n9OBJ1Wx.HohAZYbUpk), gfMVqRAjEUY1XoHkUXS.d8YAyYahGC))
			{
				object obj = T7hTDMWG29;
				bool flag = false;
				try
				{
					H8qYncGAaDP9dt5ZWqR.D35lls5iF(obj, ref flag, H8qYncGAaDP9dt5ZWqR.JNiG6q9lbH);
					CwETdtFdvB = 0.0;
					fqbTPVkpq7 = 0.0;
				}
				finally
				{
					if (flag)
					{
						b3QyiYL4pm5cgsTYbRX.D35lls5iF(obj, b3QyiYL4pm5cgsTYbRX.oTMGpd9H2u);
					}
				}
				Graphics graphics = PMwTqikaAc;
				if (graphics != null)
				{
					fp757nBYjo8889efKFJ.D35lls5iF(graphics, fp757nBYjo8889efKFJ.pROAqADTTW);
				}
				Bitmap bitmap = U6mTIQBrCQ;
				if (bitmap != null)
				{
					fp757nBYjo8889efKFJ.D35lls5iF(bitmap, fp757nBYjo8889efKFJ.eKcAJXGhfW);
				}
				U6mTIQBrCQ = Um6eZaAbOYRvSvrVmOj.D35lls5iF(ibJZ1yAFaX0lCm5ygiC.D35lls5iF(e, ibJZ1yAFaX0lCm5ygiC.wWZA2RE9KS), Um6eZaAbOYRvSvrVmOj.NUUAWtG6tE);
				qPUTBfcibB = Hwo9WvvS2l3n9OBJ1Wx.D35lls5iF(ibJZ1yAFaX0lCm5ygiC.D35lls5iF(e, ibJZ1yAFaX0lCm5ygiC.wWZA2RE9KS), Hwo9WvvS2l3n9OBJ1Wx.HohAZYbUpk);
				PMwTqikaAc = uI8GfFA5CLePANyg112.D35lls5iF(U6mTIQBrCQ, uI8GfFA5CLePANyg112.YxxAzd4gi5);
				Su6Aad6olbDJEqPkPoC.D35lls5iF(PMwTqikaAc, InterpolationMode.Default, Su6Aad6olbDJEqPkPoC.MPs6lLKqQy);
			}
			double num = 0.0;
			float num2 = 0f;
			float num3 = 0f;
			double num4 = 0.0;
			if (uEUVCI48fycroqgRFqy.D35lls5iF(hlCYmj693kZWXRWMw1g.D35lls5iF(e, hlCYmj693kZWXRWMw1g.ukT6D4OJOS), uEUVCI48fycroqgRFqy.FqF6H3v2ck))
			{
				object obj = T7hTDMWG29;
				bool flag = false;
				try
				{
					H8qYncGAaDP9dt5ZWqR.D35lls5iF(obj, ref flag, H8qYncGAaDP9dt5ZWqR.JNiG6q9lbH);
					long num5 = TDEZcS61pmK8cG66VjN.D35lls5iF(ref z1FTV47YY1, TDEZcS61pmK8cG66VjN.BGy68GUjct);
					TimeSpan timeSpan = moA0183RanLCkEiLXks.D35lls5iF(e, moA0183RanLCkEiLXks.Tm06nLgNuJ);
					timeSpan = SEiprnGHmVBJxvgPKIH.D35lls5iF(num5 - TDEZcS61pmK8cG66VjN.D35lls5iF(ref timeSpan, TDEZcS61pmK8cG66VjN.BGy68GUjct), SEiprnGHmVBJxvgPKIH.z8vG1iaB80);
					num = Ar1wWyeKiNmSEChFiZw.D35lls5iF(LUSRjplVkOtM7DbdDL3.D35lls5iF(ref timeSpan, LUSRjplVkOtM7DbdDL3.UWpl72ecwd), 0, Ar1wWyeKiNmSEChFiZw.clneNBmmgW);
					num2 = 5f + qIrPIG63pP3P6Lrfg5V.D35lls5iF(CwETdtFdvB, qIrPIG63pP3P6Lrfg5V.Ffd6TX6Vot) * 20f;
					num3 = 5f + qIrPIG63pP3P6Lrfg5V.D35lls5iF(fqbTPVkpq7, qIrPIG63pP3P6Lrfg5V.Ffd6TX6Vot) * 20f;
					num4 = LUSRjplVkOtM7DbdDL3.D35lls5iF(ref sVrTa9dgRt, LUSRjplVkOtM7DbdDL3.UWpl72ecwd);
				}
				finally
				{
					if (flag)
					{
						b3QyiYL4pm5cgsTYbRX.D35lls5iF(obj, b3QyiYL4pm5cgsTYbRX.oTMGpd9H2u);
					}
				}
			}
			Graphics graphics2 = PMwTqikaAc;
			if (graphics2 != null)
			{
				string[] array = new string[5];
				string text = iFZ5je3XFYKwkvcE5D.D35lls5iF(15784, iFZ5je3XFYKwkvcE5D.N06TeK0ao);
				TimeSpan timeSpan = moA0183RanLCkEiLXks.D35lls5iF(e, moA0183RanLCkEiLXks.m5u64Zu333);
				array[0] = T6EedHr0CxquZL0BWCa.D35lls5iF(text, LUSRjplVkOtM7DbdDL3.D35lls5iF(ref timeSpan, LUSRjplVkOtM7DbdDL3.LAf3veRADK), T6EedHr0CxquZL0BWCa.RU5rr1yw2Z);
				array[1] = T6EedHr0CxquZL0BWCa.D35lls5iF(iFZ5je3XFYKwkvcE5D.D35lls5iF(15824, iFZ5je3XFYKwkvcE5D.N06TeK0ao), CV4PJi6LR4KsuMQHWA7.D35lls5iF(e, CV4PJi6LR4KsuMQHWA7.N4O6EI7utB), T6EedHr0CxquZL0BWCa.RU5rr1yw2Z);
				array[2] = T6EedHr0CxquZL0BWCa.D35lls5iF(iFZ5je3XFYKwkvcE5D.D35lls5iF(15852, iFZ5je3XFYKwkvcE5D.N06TeK0ao), Ar1wWyeKiNmSEChFiZw.D35lls5iF(num, 0, Ar1wWyeKiNmSEChFiZw.clneNBmmgW), T6EedHr0CxquZL0BWCa.RU5rr1yw2Z);
				array[3] = T6EedHr0CxquZL0BWCa.D35lls5iF(iFZ5je3XFYKwkvcE5D.D35lls5iF(15910, iFZ5je3XFYKwkvcE5D.N06TeK0ao), Ar1wWyeKiNmSEChFiZw.D35lls5iF(num4, 0, Ar1wWyeKiNmSEChFiZw.clneNBmmgW), T6EedHr0CxquZL0BWCa.RU5rr1yw2Z);
				array[4] = iFZ5je3XFYKwkvcE5D.D35lls5iF(15968, iFZ5je3XFYKwkvcE5D.N06TeK0ao);
				fPGapv6rSqQduZCeqrW.D35lls5iF(graphics2, EKUvcf6BZG4YrVDIJu7.D35lls5iF(array, EKUvcf6BZG4YrVDIJu7.lI660m0xwr), wKcT0pQbU0, tqmTGepjh2, Sp3TTvNKZ3, fPGapv6rSqQduZCeqrW.zKh6ep0hPT);
			}
			Graphics graphics3 = PMwTqikaAc;
			if (graphics3 != null)
			{
				s7fodl6RfivC1kx9CD3.D35lls5iF(graphics3, p2HTZw7KDM, 36f, 101f * p4mfse87pettnXd8Scc.D35lls5iF(PMwTqikaAc, p4mfse87pettnXd8Scc.i166GrRYwZ) / 96f, 36f + num2, 101f * p4mfse87pettnXd8Scc.D35lls5iF(PMwTqikaAc, p4mfse87pettnXd8Scc.i166GrRYwZ) / 96f, s7fodl6RfivC1kx9CD3.YpI6kXZhe0);
			}
			Graphics graphics4 = PMwTqikaAc;
			if (graphics4 != null)
			{
				s7fodl6RfivC1kx9CD3.D35lls5iF(graphics4, bM6TtYYHW6, 36f, 122f * p4mfse87pettnXd8Scc.D35lls5iF(PMwTqikaAc, p4mfse87pettnXd8Scc.i166GrRYwZ) / 96f, 36f + num3, 122f * p4mfse87pettnXd8Scc.D35lls5iF(PMwTqikaAc, p4mfse87pettnXd8Scc.i166GrRYwZ) / 96f, s7fodl6RfivC1kx9CD3.YpI6kXZhe0);
			}
		}

		internal void jXATWGcOqV(object s, RenderingAudioEventArgs e)
		{
			if (!uEUVCI48fycroqgRFqy.D35lls5iF(hlCYmj693kZWXRWMw1g.D35lls5iF(e, hlCYmj693kZWXRWMw1g.ukT6D4OJOS), uEUVCI48fycroqgRFqy.lxg6vM9gWf))
			{
				return;
			}
			if (pcPTSsvOfk == null || pcPTSsvOfk.Length != WJbFtI6AObf2rNffLCy.D35lls5iF(e, WJbFtI6AObf2rNffLCy.IGf66dqP8E))
			{
				pcPTSsvOfk = new double[WJbFtI6AObf2rNffLCy.D35lls5iF(e, WJbFtI6AObf2rNffLCy.IGf66dqP8E)];
			}
			if (tJPTfkNty2 == null || tJPTfkNty2.Length != WJbFtI6AObf2rNffLCy.D35lls5iF(e, WJbFtI6AObf2rNffLCy.IGf66dqP8E))
			{
				tJPTfkNty2 = new double[WJbFtI6AObf2rNffLCy.D35lls5iF(e, WJbFtI6AObf2rNffLCy.IGf66dqP8E)];
			}
			bool flag = true;
			int num = 0;
			byte[] array = NaFm6SRgM2ttOuFVF8H.D35lls5iF(e, NaFm6SRgM2ttOuFVF8H.Oro6pMjdwV);
			for (int i = 0; i < WJbFtI6AObf2rNffLCy.D35lls5iF(e, WJbFtI6AObf2rNffLCy.IsW6aMAvaR); i += WJbFtI6AObf2rNffLCy.D35lls5iF(e, WJbFtI6AObf2rNffLCy.SOb6mV38U2) / 8)
			{
				double num2 = 100.0 * A7Y2lg6wdtN4T9QTiho.D35lls5iF(array, i, A7Y2lg6wdtN4T9QTiho.vWE6C4sr9L);
				if (flag)
				{
					pcPTSsvOfk[num] = num2;
				}
				else
				{
					tJPTfkNty2[num] = num2;
				}
				num += ((!flag) ? 1 : 0);
				flag = !flag;
			}
			object obj = T7hTDMWG29;
			bool flag2 = false;
			try
			{
				H8qYncGAaDP9dt5ZWqR.D35lls5iF(obj, ref flag2, H8qYncGAaDP9dt5ZWqR.JNiG6q9lbH);
				z1FTV47YY1 = moA0183RanLCkEiLXks.D35lls5iF(e, moA0183RanLCkEiLXks.Tm06nLgNuJ);
				sVrTa9dgRt = moA0183RanLCkEiLXks.D35lls5iF(e, moA0183RanLCkEiLXks.HFk6InYxhs);
				CwETdtFdvB = dcJjqelwgiZ4n97w1vs.D35lls5iF(1.0 / (double)pcPTSsvOfk.Length * pcPTSsvOfk.Sum((double n) => n), dcJjqelwgiZ4n97w1vs.zLN6dMSNo7);
				fqbTPVkpq7 = dcJjqelwgiZ4n97w1vs.D35lls5iF(1.0 / (double)tJPTfkNty2.Length * tJPTfkNty2.Sum((double n) => n), dcJjqelwgiZ4n97w1vs.zLN6dMSNo7);
			}
			finally
			{
				if (flag2)
				{
					b3QyiYL4pm5cgsTYbRX.D35lls5iF(obj, b3QyiYL4pm5cgsTYbRX.oTMGpd9H2u);
				}
			}
		}

		[AsyncStateMachine(typeof(mp07y6VPybXpYS9Rto))]
		internal void MKOT4vBp6V(object s, EventArgs e)
		{
			mp07y6VPybXpYS9Rto stateMachine = default(mp07y6VPybXpYS9Rto);
			stateMachine.z558nLbOQW = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
			stateMachine.jfV8bia58g = this;
			stateMachine.OLu8Q0pE7m = -1;
			stateMachine.z558nLbOQW.Start(ref stateMachine);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		public Unosquare.FFME.MediaElement CSGTMxcm1h;

		public StreamInfo PN2TC7nBN2;

		public _003C_003Ec__DisplayClass14_0()
		{
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
			base._002Ector();
		}

		internal void HKhTNyrDuO()
		{
			K8DNce6twv9Np34xpPr.D35lls5iF(CSGTMxcm1h, uEUVCI48fycroqgRFqy.D35lls5iF(PN2TC7nBN2, uEUVCI48fycroqgRFqy.hx66UqOmg8) ? CaptionsChannel.CC1 : CaptionsChannel.CCP, K8DNce6twv9Np34xpPr.qtR6VreiE6);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass14_1
	{
		public AVHWDeviceType qciTFfu5Ov;

		public _003C_003Ec__DisplayClass14_1()
		{
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
			base._002Ector();
		}

		internal bool YYnTY3wiWE(HardwareDeviceInfo d)
		{
			return aMnygB67j3N3yuQbSMF.D35lls5iF(d, aMnygB67j3N3yuQbSMF.PKP6cQZX8R) == qciTFfu5Ov;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnAudioDeviceStopped_003Ed__20 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public object sender;

		private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			try
			{
				ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_0085;
				}
				if (sender is Unosquare.FFME.MediaElement mediaElement)
				{
					awaiter = wd2eJ2Asf3I9epXUKxU.D35lls5iF(mediaElement, wd2eJ2Asf3I9epXUKxU.lWJ6M1uBV4).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_0085;
				}
				goto end_IL_000e;
				IL_0085:
				awaiter.GetResult();
				end_IL_000e:;
			}
			catch (Exception ex)
			{
				_003C_003E1__state = -2;
				N2XUglA3neBsnlZfRPQ.D35lls5iF(ref _003C_003Et__builder, ex, N2XUglA3neBsnlZfRPQ.l4pATRumoW);
				return;
			}
			_003C_003E1__state = -2;
			T4XmPoA4VNJJP1afcgL.D35lls5iF(ref _003C_003Et__builder, T4XmPoA4VNJJP1afcgL.TRyALZckCh);
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			dHWo7jAEn6E4X7bsY4R.D35lls5iF(ref _003C_003Et__builder, stateMachine, dHWo7jAEn6E4X7bsY4R.z3hAB6UZ9o);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnUserControlKeyDown_003Ed__21 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public KeyEventArgs e;

		public FFMEPlayerControl _003C_003E4__this;

		private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_006b: Invalid comparison between Unknown and I4
			//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0111: Unknown result type (might be due to invalid IL or missing references)
			//IL_0150: Unknown result type (might be due to invalid IL or missing references)
			//IL_0157: Invalid comparison between Unknown and I4
			//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01df: Invalid comparison between Unknown and I4
			//IL_0260: Unknown result type (might be due to invalid IL or missing references)
			//IL_0267: Invalid comparison between Unknown and I4
			//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a8: Invalid comparison between Unknown and I4
			int num = _003C_003E1__state;
			FFMEPlayerControl fFMEPlayerControl = _003C_003E4__this;
			try
			{
				ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_01c0;
				}
				if (num == 1)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_0248;
				}
				if (!(RAspAbuaTQFU0nSRiQ.D35lls5iF(e, RAspAbuaTQFU0nSRiQ.YRbPgco79) is TextBox))
				{
					yfy1wssmHv811G3r43.D35lls5iF((DependencyObject)(object)fFMEPlayerControl, true, yfy1wssmHv811G3r43.fw2hEbsAm);
					lpNmWGxSvw4A2wThUG.D35lls5iF((DependencyObject)(object)fFMEPlayerControl, fFMEPlayerControl, lpNmWGxSvw4A2wThUG.NYpYJBiHr);
					if ((int)X6dagBgIU5bQsE98LL.D35lls5iF(e, X6dagBgIU5bQsE98LL.dcKiqyPBj) == 50)
					{
						lhUOEJ6uOhY2TVo9HQv.D35lls5iF(fFMEPlayerControl.Media, (VkgK106SaE0lyTM0iEu.D35lls5iF(fFMEPlayerControl.Media, VkgK106SaE0lyTM0iEu.oTH6KhvPET) == p5s3FJHfrZC71uwBS7V.D35lls5iF(p5s3FJHfrZC71uwBS7V.j0F6NCjo6k)) ? p5s3FJHfrZC71uwBS7V.D35lls5iF(p5s3FJHfrZC71uwBS7V.KWM6OUxbGV) : p5s3FJHfrZC71uwBS7V.D35lls5iF(p5s3FJHfrZC71uwBS7V.j0F6NCjo6k), lhUOEJ6uOhY2TVo9HQv.SYx6PflhV0);
					}
					else if (Enumerable.Contains(Xbx6ntsoc, X6dagBgIU5bQsE98LL.D35lls5iF(e, X6dagBgIU5bQsE98LL.dcKiqyPBj)) && uEUVCI48fycroqgRFqy.D35lls5iF(fFMEPlayerControl.Media, uEUVCI48fycroqgRFqy.RIVAOZeovq))
					{
						fFMEPlayerControl.mmsiYLPk3.OnPauseCommandExcuteAsync();
					}
					else if (Enumerable.Contains(Xbx6ntsoc, X6dagBgIU5bQsE98LL.D35lls5iF(e, X6dagBgIU5bQsE98LL.dcKiqyPBj)) && !uEUVCI48fycroqgRFqy.D35lls5iF(fFMEPlayerControl.Media, uEUVCI48fycroqgRFqy.RIVAOZeovq))
					{
						fFMEPlayerControl.mmsiYLPk3.OnPlayCommandExcuteAsync();
					}
					else
					{
						if ((int)X6dagBgIU5bQsE98LL.D35lls5iF(e, X6dagBgIU5bQsE98LL.dcKiqyPBj) == 23)
						{
							awaiter = wd2eJ2Asf3I9epXUKxU.D35lls5iF(fFMEPlayerControl.Media, wd2eJ2Asf3I9epXUKxU.nHuAhAMFhD).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_01c0;
						}
						if ((int)X6dagBgIU5bQsE98LL.D35lls5iF(e, X6dagBgIU5bQsE98LL.dcKiqyPBj) == 25)
						{
							awaiter = wd2eJ2Asf3I9epXUKxU.D35lls5iF(fFMEPlayerControl.Media, wd2eJ2Asf3I9epXUKxU.KSYAxc5OtD).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = (_003C_003E1__state = 1);
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_0248;
						}
						if ((int)X6dagBgIU5bQsE98LL.D35lls5iF(e, X6dagBgIU5bQsE98LL.dcKiqyPBj) == 24)
						{
							Unosquare.FFME.MediaElement media = fFMEPlayerControl.Media;
							mAdJWQ9yhneCbEXlGMc.D35lls5iF(media, bATk1clKMSyO8g9EVbN.D35lls5iF(media, bATk1clKMSyO8g9EVbN.r4LAXMWUOq) + 0.05, mAdJWQ9yhneCbEXlGMc.QMBAfkYTl6);
						}
						else if ((int)X6dagBgIU5bQsE98LL.D35lls5iF(e, X6dagBgIU5bQsE98LL.dcKiqyPBj) == 26)
						{
							Unosquare.FFME.MediaElement media2 = fFMEPlayerControl.Media;
							mAdJWQ9yhneCbEXlGMc.D35lls5iF(media2, bATk1clKMSyO8g9EVbN.D35lls5iF(media2, bATk1clKMSyO8g9EVbN.r4LAXMWUOq) - 0.05, mAdJWQ9yhneCbEXlGMc.QMBAfkYTl6);
						}
					}
				}
				goto end_IL_0015;
				IL_01c0:
				awaiter.GetResult();
				goto end_IL_0015;
				IL_0248:
				awaiter.GetResult();
				end_IL_0015:;
			}
			catch (Exception ex)
			{
				_003C_003E1__state = -2;
				N2XUglA3neBsnlZfRPQ.D35lls5iF(ref _003C_003Et__builder, ex, N2XUglA3neBsnlZfRPQ.l4pATRumoW);
				return;
			}
			_003C_003E1__state = -2;
			T4XmPoA4VNJJP1afcgL.D35lls5iF(ref _003C_003Et__builder, T4XmPoA4VNJJP1afcgL.TRyALZckCh);
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			dHWo7jAEn6E4X7bsY4R.D35lls5iF(ref _003C_003Et__builder, stateMachine, dHWo7jAEn6E4X7bsY4R.z3hAB6UZ9o);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	private static readonly Key[] Xbx6ntsoc;

	private DateTime WTJsiuvlc;

	private Point kxOx9jkI8;

	private DispatcherTimer I9nyVAheA;

	private MediaType gvDpe65iW;

	private FFMEBaseViewModel<ChannelResponseDto> mmsiYLPk3;

	internal Grid Player;

	internal Unosquare.FFME.MediaElement Media;

	private bool syq3em9OI;

	private void KtonFttrZ()
	{
		_003C_003Ec__DisplayClass6_0 CS_0024_003C_003E8__locals62 = new _003C_003Ec__DisplayClass6_0();
		CS_0024_003C_003E8__locals62.DTcTKUXPl5 = this;
		if (!V5MooqlfITowrG9yf5v.D35lls5iF(V5MooqlfITowrG9yf5v.HwelFVtd23))
		{
			return;
		}
		CS_0024_003C_003E8__locals62.U6mTIQBrCQ = null;
		CS_0024_003C_003E8__locals62.PMwTqikaAc = null;
		CS_0024_003C_003E8__locals62.wKcT0pQbU0 = new Font(iFZ5je3XFYKwkvcE5D.D35lls5iF(314, iFZ5je3XFYKwkvcE5D.N06TeK0ao), 14f, System.Drawing.FontStyle.Bold);
		CS_0024_003C_003E8__locals62.tqmTGepjh2 = MXTIscl2pTnbkQaWJB6.D35lls5iF(MXTIscl2pTnbkQaWJB6.uAdlZJ87tC);
		CS_0024_003C_003E8__locals62.Sp3TTvNKZ3 = new PointF(12f, 8f);
		CS_0024_003C_003E8__locals62.qPUTBfcibB = IntPtr.Zero;
		CS_0024_003C_003E8__locals62.p2HTZw7KDM = new Pen(SQsNDPljLh3AO4oHom3.D35lls5iF(SQsNDPljLh3AO4oHom3.VgWly6KpGu), 12f);
		CS_0024_003C_003E8__locals62.bM6TtYYHW6 = new Pen(SQsNDPljLh3AO4oHom3.D35lls5iF(SQsNDPljLh3AO4oHom3.K3Wlq2uGj5), 12f);
		CS_0024_003C_003E8__locals62.z1FTV47YY1 = TimeSpan.Zero;
		CS_0024_003C_003E8__locals62.sVrTa9dgRt = TimeSpan.Zero;
		CS_0024_003C_003E8__locals62.T7hTDMWG29 = new object();
		CS_0024_003C_003E8__locals62.CwETdtFdvB = 0.0;
		CS_0024_003C_003E8__locals62.fqbTPVkpq7 = 0.0;
		CS_0024_003C_003E8__locals62.pcPTSsvOfk = null;
		CS_0024_003C_003E8__locals62.tJPTfkNty2 = null;
		D9UHNnlJxs3go6U8oNr.D35lls5iF(Media, delegate(object s, RenderingVideoEventArgs e)
		{
			if (gfMVqRAjEUY1XoHkUXS.D35lls5iF(CS_0024_003C_003E8__locals62.qPUTBfcibB, Hwo9WvvS2l3n9OBJ1Wx.D35lls5iF(ibJZ1yAFaX0lCm5ygiC.D35lls5iF(e, ibJZ1yAFaX0lCm5ygiC.wWZA2RE9KS), Hwo9WvvS2l3n9OBJ1Wx.HohAZYbUpk), gfMVqRAjEUY1XoHkUXS.d8YAyYahGC))
			{
				object obj = CS_0024_003C_003E8__locals62.T7hTDMWG29;
				bool flag = false;
				try
				{
					H8qYncGAaDP9dt5ZWqR.D35lls5iF(obj, ref flag, H8qYncGAaDP9dt5ZWqR.JNiG6q9lbH);
					CS_0024_003C_003E8__locals62.CwETdtFdvB = 0.0;
					CS_0024_003C_003E8__locals62.fqbTPVkpq7 = 0.0;
				}
				finally
				{
					if (flag)
					{
						b3QyiYL4pm5cgsTYbRX.D35lls5iF(obj, b3QyiYL4pm5cgsTYbRX.oTMGpd9H2u);
					}
				}
				Graphics graphics = CS_0024_003C_003E8__locals62.PMwTqikaAc;
				if (graphics != null)
				{
					fp757nBYjo8889efKFJ.D35lls5iF(graphics, fp757nBYjo8889efKFJ.pROAqADTTW);
				}
				Bitmap bitmap = CS_0024_003C_003E8__locals62.U6mTIQBrCQ;
				if (bitmap != null)
				{
					fp757nBYjo8889efKFJ.D35lls5iF(bitmap, fp757nBYjo8889efKFJ.eKcAJXGhfW);
				}
				CS_0024_003C_003E8__locals62.U6mTIQBrCQ = Um6eZaAbOYRvSvrVmOj.D35lls5iF(ibJZ1yAFaX0lCm5ygiC.D35lls5iF(e, ibJZ1yAFaX0lCm5ygiC.wWZA2RE9KS), Um6eZaAbOYRvSvrVmOj.NUUAWtG6tE);
				CS_0024_003C_003E8__locals62.qPUTBfcibB = Hwo9WvvS2l3n9OBJ1Wx.D35lls5iF(ibJZ1yAFaX0lCm5ygiC.D35lls5iF(e, ibJZ1yAFaX0lCm5ygiC.wWZA2RE9KS), Hwo9WvvS2l3n9OBJ1Wx.HohAZYbUpk);
				CS_0024_003C_003E8__locals62.PMwTqikaAc = uI8GfFA5CLePANyg112.D35lls5iF(CS_0024_003C_003E8__locals62.U6mTIQBrCQ, uI8GfFA5CLePANyg112.YxxAzd4gi5);
				Su6Aad6olbDJEqPkPoC.D35lls5iF(CS_0024_003C_003E8__locals62.PMwTqikaAc, InterpolationMode.Default, Su6Aad6olbDJEqPkPoC.MPs6lLKqQy);
			}
			double num = 0.0;
			float num2 = 0f;
			float num3 = 0f;
			double num4 = 0.0;
			if (uEUVCI48fycroqgRFqy.D35lls5iF(hlCYmj693kZWXRWMw1g.D35lls5iF(e, hlCYmj693kZWXRWMw1g.ukT6D4OJOS), uEUVCI48fycroqgRFqy.FqF6H3v2ck))
			{
				object obj = CS_0024_003C_003E8__locals62.T7hTDMWG29;
				bool flag = false;
				try
				{
					H8qYncGAaDP9dt5ZWqR.D35lls5iF(obj, ref flag, H8qYncGAaDP9dt5ZWqR.JNiG6q9lbH);
					long num5 = TDEZcS61pmK8cG66VjN.D35lls5iF(ref CS_0024_003C_003E8__locals62.z1FTV47YY1, TDEZcS61pmK8cG66VjN.BGy68GUjct);
					TimeSpan timeSpan = moA0183RanLCkEiLXks.D35lls5iF(e, moA0183RanLCkEiLXks.Tm06nLgNuJ);
					timeSpan = SEiprnGHmVBJxvgPKIH.D35lls5iF(num5 - TDEZcS61pmK8cG66VjN.D35lls5iF(ref timeSpan, TDEZcS61pmK8cG66VjN.BGy68GUjct), SEiprnGHmVBJxvgPKIH.z8vG1iaB80);
					num = Ar1wWyeKiNmSEChFiZw.D35lls5iF(LUSRjplVkOtM7DbdDL3.D35lls5iF(ref timeSpan, LUSRjplVkOtM7DbdDL3.UWpl72ecwd), 0, Ar1wWyeKiNmSEChFiZw.clneNBmmgW);
					num2 = 5f + qIrPIG63pP3P6Lrfg5V.D35lls5iF(CS_0024_003C_003E8__locals62.CwETdtFdvB, qIrPIG63pP3P6Lrfg5V.Ffd6TX6Vot) * 20f;
					num3 = 5f + qIrPIG63pP3P6Lrfg5V.D35lls5iF(CS_0024_003C_003E8__locals62.fqbTPVkpq7, qIrPIG63pP3P6Lrfg5V.Ffd6TX6Vot) * 20f;
					num4 = LUSRjplVkOtM7DbdDL3.D35lls5iF(ref CS_0024_003C_003E8__locals62.sVrTa9dgRt, LUSRjplVkOtM7DbdDL3.UWpl72ecwd);
				}
				finally
				{
					if (flag)
					{
						b3QyiYL4pm5cgsTYbRX.D35lls5iF(obj, b3QyiYL4pm5cgsTYbRX.oTMGpd9H2u);
					}
				}
			}
			Graphics graphics2 = CS_0024_003C_003E8__locals62.PMwTqikaAc;
			if (graphics2 != null)
			{
				string[] array = new string[5];
				string text = iFZ5je3XFYKwkvcE5D.D35lls5iF(15784, iFZ5je3XFYKwkvcE5D.N06TeK0ao);
				TimeSpan timeSpan = moA0183RanLCkEiLXks.D35lls5iF(e, moA0183RanLCkEiLXks.m5u64Zu333);
				array[0] = T6EedHr0CxquZL0BWCa.D35lls5iF(text, LUSRjplVkOtM7DbdDL3.D35lls5iF(ref timeSpan, LUSRjplVkOtM7DbdDL3.LAf3veRADK), T6EedHr0CxquZL0BWCa.RU5rr1yw2Z);
				array[1] = T6EedHr0CxquZL0BWCa.D35lls5iF(iFZ5je3XFYKwkvcE5D.D35lls5iF(15824, iFZ5je3XFYKwkvcE5D.N06TeK0ao), CV4PJi6LR4KsuMQHWA7.D35lls5iF(e, CV4PJi6LR4KsuMQHWA7.N4O6EI7utB), T6EedHr0CxquZL0BWCa.RU5rr1yw2Z);
				array[2] = T6EedHr0CxquZL0BWCa.D35lls5iF(iFZ5je3XFYKwkvcE5D.D35lls5iF(15852, iFZ5je3XFYKwkvcE5D.N06TeK0ao), Ar1wWyeKiNmSEChFiZw.D35lls5iF(num, 0, Ar1wWyeKiNmSEChFiZw.clneNBmmgW), T6EedHr0CxquZL0BWCa.RU5rr1yw2Z);
				array[3] = T6EedHr0CxquZL0BWCa.D35lls5iF(iFZ5je3XFYKwkvcE5D.D35lls5iF(15910, iFZ5je3XFYKwkvcE5D.N06TeK0ao), Ar1wWyeKiNmSEChFiZw.D35lls5iF(num4, 0, Ar1wWyeKiNmSEChFiZw.clneNBmmgW), T6EedHr0CxquZL0BWCa.RU5rr1yw2Z);
				array[4] = iFZ5je3XFYKwkvcE5D.D35lls5iF(15968, iFZ5je3XFYKwkvcE5D.N06TeK0ao);
				fPGapv6rSqQduZCeqrW.D35lls5iF(graphics2, EKUvcf6BZG4YrVDIJu7.D35lls5iF(array, EKUvcf6BZG4YrVDIJu7.lI660m0xwr), CS_0024_003C_003E8__locals62.wKcT0pQbU0, CS_0024_003C_003E8__locals62.tqmTGepjh2, CS_0024_003C_003E8__locals62.Sp3TTvNKZ3, fPGapv6rSqQduZCeqrW.zKh6ep0hPT);
			}
			Graphics graphics3 = CS_0024_003C_003E8__locals62.PMwTqikaAc;
			if (graphics3 != null)
			{
				s7fodl6RfivC1kx9CD3.D35lls5iF(graphics3, CS_0024_003C_003E8__locals62.p2HTZw7KDM, 36f, 101f * p4mfse87pettnXd8Scc.D35lls5iF(CS_0024_003C_003E8__locals62.PMwTqikaAc, p4mfse87pettnXd8Scc.i166GrRYwZ) / 96f, 36f + num2, 101f * p4mfse87pettnXd8Scc.D35lls5iF(CS_0024_003C_003E8__locals62.PMwTqikaAc, p4mfse87pettnXd8Scc.i166GrRYwZ) / 96f, s7fodl6RfivC1kx9CD3.YpI6kXZhe0);
			}
			Graphics graphics4 = CS_0024_003C_003E8__locals62.PMwTqikaAc;
			if (graphics4 != null)
			{
				s7fodl6RfivC1kx9CD3.D35lls5iF(graphics4, CS_0024_003C_003E8__locals62.bM6TtYYHW6, 36f, 122f * p4mfse87pettnXd8Scc.D35lls5iF(CS_0024_003C_003E8__locals62.PMwTqikaAc, p4mfse87pettnXd8Scc.i166GrRYwZ) / 96f, 36f + num3, 122f * p4mfse87pettnXd8Scc.D35lls5iF(CS_0024_003C_003E8__locals62.PMwTqikaAc, p4mfse87pettnXd8Scc.i166GrRYwZ) / 96f, s7fodl6RfivC1kx9CD3.YpI6kXZhe0);
			}
		}, D9UHNnlJxs3go6U8oNr.nCdlblPSl8);
		IVQxJBlWRnIQ33ExeCm.D35lls5iF(Media, delegate(object s, RenderingAudioEventArgs e)
		{
			if (!uEUVCI48fycroqgRFqy.D35lls5iF(hlCYmj693kZWXRWMw1g.D35lls5iF(e, hlCYmj693kZWXRWMw1g.ukT6D4OJOS), uEUVCI48fycroqgRFqy.lxg6vM9gWf))
			{
				return;
			}
			if (CS_0024_003C_003E8__locals62.pcPTSsvOfk == null || CS_0024_003C_003E8__locals62.pcPTSsvOfk.Length != WJbFtI6AObf2rNffLCy.D35lls5iF(e, WJbFtI6AObf2rNffLCy.IGf66dqP8E))
			{
				CS_0024_003C_003E8__locals62.pcPTSsvOfk = new double[WJbFtI6AObf2rNffLCy.D35lls5iF(e, WJbFtI6AObf2rNffLCy.IGf66dqP8E)];
			}
			if (CS_0024_003C_003E8__locals62.tJPTfkNty2 == null || CS_0024_003C_003E8__locals62.tJPTfkNty2.Length != WJbFtI6AObf2rNffLCy.D35lls5iF(e, WJbFtI6AObf2rNffLCy.IGf66dqP8E))
			{
				CS_0024_003C_003E8__locals62.tJPTfkNty2 = new double[WJbFtI6AObf2rNffLCy.D35lls5iF(e, WJbFtI6AObf2rNffLCy.IGf66dqP8E)];
			}
			bool flag = true;
			int num = 0;
			byte[] array = NaFm6SRgM2ttOuFVF8H.D35lls5iF(e, NaFm6SRgM2ttOuFVF8H.Oro6pMjdwV);
			for (int i = 0; i < WJbFtI6AObf2rNffLCy.D35lls5iF(e, WJbFtI6AObf2rNffLCy.IsW6aMAvaR); i += WJbFtI6AObf2rNffLCy.D35lls5iF(e, WJbFtI6AObf2rNffLCy.SOb6mV38U2) / 8)
			{
				double num2 = 100.0 * A7Y2lg6wdtN4T9QTiho.D35lls5iF(array, i, A7Y2lg6wdtN4T9QTiho.vWE6C4sr9L);
				if (flag)
				{
					CS_0024_003C_003E8__locals62.pcPTSsvOfk[num] = num2;
				}
				else
				{
					CS_0024_003C_003E8__locals62.tJPTfkNty2[num] = num2;
				}
				num += ((!flag) ? 1 : 0);
				flag = !flag;
			}
			object obj = CS_0024_003C_003E8__locals62.T7hTDMWG29;
			bool flag2 = false;
			try
			{
				H8qYncGAaDP9dt5ZWqR.D35lls5iF(obj, ref flag2, H8qYncGAaDP9dt5ZWqR.JNiG6q9lbH);
				CS_0024_003C_003E8__locals62.z1FTV47YY1 = moA0183RanLCkEiLXks.D35lls5iF(e, moA0183RanLCkEiLXks.Tm06nLgNuJ);
				CS_0024_003C_003E8__locals62.sVrTa9dgRt = moA0183RanLCkEiLXks.D35lls5iF(e, moA0183RanLCkEiLXks.HFk6InYxhs);
				CS_0024_003C_003E8__locals62.CwETdtFdvB = dcJjqelwgiZ4n97w1vs.D35lls5iF(1.0 / (double)CS_0024_003C_003E8__locals62.pcPTSsvOfk.Length * CS_0024_003C_003E8__locals62.pcPTSsvOfk.Sum((double n) => n), dcJjqelwgiZ4n97w1vs.zLN6dMSNo7);
				CS_0024_003C_003E8__locals62.fqbTPVkpq7 = dcJjqelwgiZ4n97w1vs.D35lls5iF(1.0 / (double)CS_0024_003C_003E8__locals62.tJPTfkNty2.Length * CS_0024_003C_003E8__locals62.tJPTfkNty2.Sum((double n) => n), dcJjqelwgiZ4n97w1vs.zLN6dMSNo7);
			}
			finally
			{
				if (flag2)
				{
					b3QyiYL4pm5cgsTYbRX.D35lls5iF(obj, b3QyiYL4pm5cgsTYbRX.oTMGpd9H2u);
				}
			}
		}, IVQxJBlWRnIQ33ExeCm.DZvl5PMEjl);
		L21qSXlzikkMg928VuN.D35lls5iF(Media, delegate
		{
		}, L21qSXlzikkMg928VuN.EV19o3tywA);
		ytk50glr3dmeojxPvdr.D35lls5iF(Media, [AsyncStateMachine(typeof(_003C_003Ec__DisplayClass6_0.mp07y6VPybXpYS9Rto))] (object s, EventArgs e) =>
		{
			_003C_003Ec__DisplayClass6_0.mp07y6VPybXpYS9Rto stateMachine = default(_003C_003Ec__DisplayClass6_0.mp07y6VPybXpYS9Rto);
			stateMachine.z558nLbOQW = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
			stateMachine.jfV8bia58g = CS_0024_003C_003E8__locals62;
			stateMachine.OLu8Q0pE7m = -1;
			stateMachine.z558nLbOQW.Start(ref stateMachine);
		}, ytk50glr3dmeojxPvdr.hxb9lGDlo9);
	}

	public FFMEPlayerControl()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		gvDpe65iW = MediaType.None;
		base._002Ector();
		AJv70itXcdnxnNYjSQ.D35lls5iF(this, AJv70itXcdnxnNYjSQ.TST99XaS9F);
		mmsiYLPk3 = new LivePlayerViewModel
		{
			MediaElement = Media
		};
		KBhlAv9D2TgBJ1kkc0B.D35lls5iF(this, mmsiYLPk3, KBhlAv9D2TgBJ1kkc0B.rHR9H7nUZq);
		AJv70itXcdnxnNYjSQ.D35lls5iF(mmsiYLPk3, AJv70itXcdnxnNYjSQ.YkS91HZ8IQ);
		AJv70itXcdnxnNYjSQ.D35lls5iF(this, AJv70itXcdnxnNYjSQ.kx098xkMnX);
		AJv70itXcdnxnNYjSQ.D35lls5iF(this, AJv70itXcdnxnNYjSQ.fnB9nZvhKJ);
	}

	private void NLjb7yPOb()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		//IL_007b: Expected O, but got Unknown
		WTJsiuvlc = BvlWxPl1hnvXiXiwcCq.D35lls5iF(BvlWxPl1hnvXiXiwcCq.EYWl8ivUIj);
		Av2eQglnElp5ZoM4x07.D35lls5iF(this, delegate(object P_0, MouseEventArgs P_1)
		{
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0090: Unknown result type (might be due to invalid IL or missing references)
			Point val2 = USqZXQlvmGLrody4O9t.D35lls5iF(P_1, this, USqZXQlvmGLrody4O9t.nH9lA1iUxt);
			if (dcJjqelwgiZ4n97w1vs.D35lls5iF(h9FJZ2l6apsXs25G7nL.D35lls5iF(ref val2, h9FJZ2l6apsXs25G7nL.Hhilp1Ei0F) - h9FJZ2l6apsXs25G7nL.D35lls5iF(ref kxOx9jkI8, h9FJZ2l6apsXs25G7nL.Hhilp1Ei0F), dcJjqelwgiZ4n97w1vs.jM2lCY9POn) > double.Epsilon || dcJjqelwgiZ4n97w1vs.D35lls5iF(h9FJZ2l6apsXs25G7nL.D35lls5iF(ref val2, h9FJZ2l6apsXs25G7nL.Rwnlm4hpqZ) - h9FJZ2l6apsXs25G7nL.D35lls5iF(ref kxOx9jkI8, h9FJZ2l6apsXs25G7nL.Rwnlm4hpqZ), dcJjqelwgiZ4n97w1vs.jM2lCY9POn) > double.Epsilon)
			{
				WTJsiuvlc = BvlWxPl1hnvXiXiwcCq.D35lls5iF(BvlWxPl1hnvXiXiwcCq.EYWl8ivUIj);
			}
			kxOx9jkI8 = val2;
		}, Av2eQglnElp5ZoM4x07.LUOl3dJrii);
		Av2eQglnElp5ZoM4x07.D35lls5iF(this, delegate
		{
			DateTime dateTime = BvlWxPl1hnvXiXiwcCq.D35lls5iF(BvlWxPl1hnvXiXiwcCq.EYWl8ivUIj);
			WTJsiuvlc = NfWVCQlIPmCreciYdpZ.D35lls5iF(ref dateTime, aNJrrPl4soK5NDOndiN.D35lls5iF(10.0, aNJrrPl4soK5NDOndiN.Ca9lahqtKS), NfWVCQlIPmCreciYdpZ.v3GldeXUtY);
		}, Av2eQglnElp5ZoM4x07.LdBlThdhVx);
		DispatcherTimer val = new DispatcherTimer((DispatcherPriority)4);
		AKwYZ1lE8mnNaTGlMo6.D35lls5iF((object)val, aNJrrPl4soK5NDOndiN.D35lls5iF(150.0, aNJrrPl4soK5NDOndiN.V5YlLGDQcw), AKwYZ1lE8mnNaTGlMo6.EaBlBG90pn);
		QnJnl7fVDKI4mA6voc.D35lls5iF((object)val, true, QnJnl7fVDKI4mA6voc.Jd4l02EqPh);
		I9nyVAheA = val;
		ytk50glr3dmeojxPvdr.D35lls5iF(I9nyVAheA, delegate
		{
			DateTime dateTime = BvlWxPl1hnvXiXiwcCq.D35lls5iF(BvlWxPl1hnvXiXiwcCq.EYWl8ivUIj);
			zDNlydlUqWxR09wbg1x.D35lls5iF(ref dateTime, WTJsiuvlc, zDNlydlUqWxR09wbg1x.kq0ltTVoZs);
		}, ytk50glr3dmeojxPvdr.Lgkle9IPtT);
		AJv70itXcdnxnNYjSQ.D35lls5iF(I9nyVAheA, AJv70itXcdnxnNYjSQ.JRYlG0QuuU);
	}

	private void Fqe7NnF7j()
	{
		bHOmLK93DudIdGBrb75.D35lls5iF(OnMediaFFmpegMessageLogged, bHOmLK93DudIdGBrb75.Fod9TIsSiB);
		PaIS6u94vkelmQi5rj0.D35lls5iF(Media, zKWNHyvU4, PaIS6u94vkelmQi5rj0.MEx9LXd1lc);
		i3gnNI9Eg29lNWhhmj9.D35lls5iF(Media, Iwp5twbHQ, i3gnNI9Eg29lNWhhmj9.x0y9BgXsjM);
		qIyXdQ90W8ud3wp2ybv.D35lls5iF(Media, IV2ua93iZ, qIyXdQ90W8ud3wp2ybv.G9b9r6c2Bl);
		XeTMat9eHdgUsPwyBUr.D35lls5iF(Media, OnMediaOpened, XeTMat9eHdgUsPwyBUr.xeJ9GY5CYT);
		ytk50glr3dmeojxPvdr.D35lls5iF(Media, OnMediaReady, ytk50glr3dmeojxPvdr.VLo9RbyDNh);
		ytk50glr3dmeojxPvdr.D35lls5iF(Media, OnMediaClosed, ytk50glr3dmeojxPvdr.KQE9kKpkPQ);
		qIyXdQ90W8ud3wp2ybv.D35lls5iF(Media, OnMediaChanging, qIyXdQ90W8ud3wp2ybv.BuQ9vYnSId);
		ytk50glr3dmeojxPvdr.D35lls5iF(Media, OnAudioDeviceStopped, ytk50glr3dmeojxPvdr.hxb9lGDlo9);
		XeTMat9eHdgUsPwyBUr.D35lls5iF(Media, OnMediaChanged, XeTMat9eHdgUsPwyBUr.fVH9ALNi6D);
		C0UEi896TGi2A8w1c4U.D35lls5iF(Media, OnMediaFailed, C0UEi896TGi2A8w1c4U.ta09pyJDvh);
	}

	protected void OnMediaMessageLogged(object sender, MediaLogMessageEventArgs e)
	{
		tGMrJE9wjDS38eXmODX.D35lls5iF(e, tGMrJE9wjDS38eXmODX.MmY9CRb1AT);
		_ = 4;
	}

	protected void OnMediaFFmpegMessageLogged(object sender, MediaLogMessageEventArgs e)
	{
		if ((tGMrJE9wjDS38eXmODX.D35lls5iF(e, tGMrJE9wjDS38eXmODX.MmY9CRb1AT) == MediaLogMessageType.Warning || tGMrJE9wjDS38eXmODX.D35lls5iF(e, tGMrJE9wjDS38eXmODX.MmY9CRb1AT) == MediaLogMessageType.Error) && (M6ZErPEr2LZyWYpa5O.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(e, wq2usy8gNndpuTw5mR.nlj9mLUBnu), M6ZErPEr2LZyWYpa5O.rg89aHbgYh) || !S1a0wT9Ixre9OpDny8h.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(e, wq2usy8gNndpuTw5mR.nlj9mLUBnu), iFZ5je3XFYKwkvcE5D.D35lls5iF(340, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.l249ddg9vO)) && M6ZErPEr2LZyWYpa5O.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(e, wq2usy8gNndpuTw5mR.nlj9mLUBnu), M6ZErPEr2LZyWYpa5O.rg89aHbgYh) && VMs7lU9URBMKdJRC1h1.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(e, wq2usy8gNndpuTw5mR.nlj9mLUBnu), iFZ5je3XFYKwkvcE5D.D35lls5iF(402, iFZ5je3XFYKwkvcE5D.N06TeK0ao), VMs7lU9URBMKdJRC1h1.p7T9tIfMiJ))
		{
			VMs7lU9URBMKdJRC1h1.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(e, wq2usy8gNndpuTw5mR.nlj9mLUBnu), iFZ5je3XFYKwkvcE5D.D35lls5iF(442, iFZ5je3XFYKwkvcE5D.N06TeK0ao), VMs7lU9URBMKdJRC1h1.p7T9tIfMiJ);
		}
	}

	protected void OnMediaFailed(object sender, MediaFailedEventArgs e)
	{
	}

	private void Iwp5twbHQ(object P_0, MediaInitializingEventArgs P_1)
	{
		if (RJdEUw97wnVnGsBRmDG.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(P_1, wq2usy8gNndpuTw5mR.Jgy9VSHVYB), iFZ5je3XFYKwkvcE5D.D35lls5iF(458, iFZ5je3XFYKwkvcE5D.N06TeK0ao), StringComparison.OrdinalIgnoreCase, RJdEUw97wnVnGsBRmDG.y949cPsE49))
		{
			dq1xgG9KNu7RfbYkGMV.D35lls5iF(uIIaqd9MWbmAhTXPYKL.D35lls5iF(P_1, uIIaqd9MWbmAhTXPYKL.a3y9SGZNdS), dq1xgG9KNu7RfbYkGMV.xWD9NR1CqV)[iFZ5je3XFYKwkvcE5D.D35lls5iF(474, iFZ5je3XFYKwkvcE5D.N06TeK0ao)] = iFZ5je3XFYKwkvcE5D.D35lls5iF(506, iFZ5je3XFYKwkvcE5D.N06TeK0ao);
			QnJnl7fVDKI4mA6voc.D35lls5iF(nXvH3V9ON1PquOtoxuq.D35lls5iF(uIIaqd9MWbmAhTXPYKL.D35lls5iF(P_1, uIIaqd9MWbmAhTXPYKL.a3y9SGZNdS), nXvH3V9ON1PquOtoxuq.g2g9uaXBwW), true, QnJnl7fVDKI4mA6voc.J0Z9Ppmjjt);
			vQKA0r9sJ1kArsIHc16.D35lls5iF(nXvH3V9ON1PquOtoxuq.D35lls5iF(uIIaqd9MWbmAhTXPYKL.D35lls5iF(P_1, uIIaqd9MWbmAhTXPYKL.a3y9SGZNdS), nXvH3V9ON1PquOtoxuq.g2g9uaXBwW), 8192, vQKA0r9sJ1kArsIHc16.km39hJJ5mo);
			AKwYZ1lE8mnNaTGlMo6.D35lls5iF(nXvH3V9ON1PquOtoxuq.D35lls5iF(uIIaqd9MWbmAhTXPYKL.D35lls5iF(P_1, uIIaqd9MWbmAhTXPYKL.a3y9SGZNdS), nXvH3V9ON1PquOtoxuq.g2g9uaXBwW), aNJrrPl4soK5NDOndiN.D35lls5iF(1.0, aNJrrPl4soK5NDOndiN.Ca9lahqtKS), AKwYZ1lE8mnNaTGlMo6.HSE9xIihv0);
			vQKA0r9sJ1kArsIHc16.D35lls5iF(nXvH3V9ON1PquOtoxuq.D35lls5iF(uIIaqd9MWbmAhTXPYKL.D35lls5iF(P_1, uIIaqd9MWbmAhTXPYKL.a3y9SGZNdS), nXvH3V9ON1PquOtoxuq.g2g9uaXBwW), 8192, vQKA0r9sJ1kArsIHc16.Ebr9YCG3u1);
		}
	}

	private void IV2ua93iZ(object P_0, MediaOpeningEventArgs P_1)
	{
		_003C_003Ec__DisplayClass14_0 CS_0024_003C_003E8__locals13 = new _003C_003Ec__DisplayClass14_0();
		CS_0024_003C_003E8__locals13.CSGTMxcm1h = P_0 as Unosquare.FFME.MediaElement;
		QnJnl7fVDKI4mA6voc.D35lls5iF(YQF0kW9goqSdXoWtJAF.D35lls5iF(P_1, YQF0kW9goqSdXoWtJAF.XRw9ikEf4n), S1a0wT9Ixre9OpDny8h.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(Pu8ZkM9Q72E1xo0KU8s.D35lls5iF(P_1, Pu8ZkM9Q72E1xo0KU8s.mf79X0XhAB), wq2usy8gNndpuTw5mR.wly9fwaPxr), iFZ5je3XFYKwkvcE5D.D35lls5iF(516, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO) || VMs7lU9URBMKdJRC1h1.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(Pu8ZkM9Q72E1xo0KU8s.D35lls5iF(P_1, Pu8ZkM9Q72E1xo0KU8s.mf79X0XhAB), wq2usy8gNndpuTw5mR.NVF92wcVcL), iFZ5je3XFYKwkvcE5D.D35lls5iF(546, iFZ5je3XFYKwkvcE5D.N06TeK0ao), VMs7lU9URBMKdJRC1h1.HFs9ZRW5q1), QnJnl7fVDKI4mA6voc.b6Y9jnPMS4);
		mAdJWQ9yhneCbEXlGMc.D35lls5iF(YQF0kW9goqSdXoWtJAF.D35lls5iF(P_1, YQF0kW9goqSdXoWtJAF.XRw9ikEf4n), S1a0wT9Ixre9OpDny8h.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(Pu8ZkM9Q72E1xo0KU8s.D35lls5iF(P_1, Pu8ZkM9Q72E1xo0KU8s.mf79X0XhAB), wq2usy8gNndpuTw5mR.wly9fwaPxr), iFZ5je3XFYKwkvcE5D.D35lls5iF(516, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO) ? 0.0 : 0.5, mAdJWQ9yhneCbEXlGMc.BP19qeiSg6);
		QnJnl7fVDKI4mA6voc.D35lls5iF(q1Gx2v9JbW9cOXEmWet.D35lls5iF(Media, q1Gx2v9JbW9cOXEmWet.adR9bl47sF), hjMnupQVVDlRZAYQJC.D35lls5iF(YQF0kW9goqSdXoWtJAF.D35lls5iF(P_1, YQF0kW9goqSdXoWtJAF.XRw9ikEf4n), hjMnupQVVDlRZAYQJC.xuq9WWJfIB) || RJdEUw97wnVnGsBRmDG.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(Pu8ZkM9Q72E1xo0KU8s.D35lls5iF(P_1, Pu8ZkM9Q72E1xo0KU8s.mf79X0XhAB), wq2usy8gNndpuTw5mR.NVF92wcVcL), iFZ5je3XFYKwkvcE5D.D35lls5iF(570, iFZ5je3XFYKwkvcE5D.N06TeK0ao), StringComparison.OrdinalIgnoreCase, RJdEUw97wnVnGsBRmDG.Omd951BO6P), QnJnl7fVDKI4mA6voc.xcM9zZ9GfC);
		vQKA0r9sJ1kArsIHc16.D35lls5iF(q1Gx2v9JbW9cOXEmWet.D35lls5iF(CS_0024_003C_003E8__locals13.CSGTMxcm1h, q1Gx2v9JbW9cOXEmWet.adR9bl47sF), 0, vQKA0r9sJ1kArsIHc16.U5RDoantIq);
		_ = string.Empty;
		try
		{
			Uri uri = new Uri(wq2usy8gNndpuTw5mR.D35lls5iF(Pu8ZkM9Q72E1xo0KU8s.D35lls5iF(P_1, Pu8ZkM9Q72E1xo0KU8s.mf79X0XhAB), wq2usy8gNndpuTw5mR.NVF92wcVcL));
			if (!hjMnupQVVDlRZAYQJC.D35lls5iF(uri, hjMnupQVVDlRZAYQJC.BPnDlBRbx2) && !hjMnupQVVDlRZAYQJC.D35lls5iF(uri, hjMnupQVVDlRZAYQJC.QNSD9EFv9p))
			{
				_ = string.Empty;
			}
			else
			{
				vr2NVdDHkMwed7KwMIr.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(uri, wq2usy8gNndpuTw5mR.xEYDDHV3gk), vr2NVdDHkMwed7KwMIr.a3qD1DVINi);
			}
		}
		catch
		{
		}
		CS_0024_003C_003E8__locals13.PN2TC7nBN2 = nrSOHAD8YrC91Hd87Ly.D35lls5iF(YQF0kW9goqSdXoWtJAF.D35lls5iF(P_1, YQF0kW9goqSdXoWtJAF.XRw9ikEf4n), nrSOHAD8YrC91Hd87Ly.EaoDno9rGj);
		if (CS_0024_003C_003E8__locals13.PN2TC7nBN2 == null)
		{
			return;
		}
		AVHWDeviceType[] array = new AVHWDeviceType[2]
		{
			AVHWDeviceType.AV_HWDEVICE_TYPE_DXVA2,
			AVHWDeviceType.AV_HWDEVICE_TYPE_D3D11VA
		};
		if (bATk1clKMSyO8g9EVbN.D35lls5iF(CS_0024_003C_003E8__locals13.PN2TC7nBN2, bATk1clKMSyO8g9EVbN.CcVD3lb0hu) <= 30.0)
		{
			AVHWDeviceType[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				_003C_003Ec__DisplayClass14_1 CS_0024_003C_003E8__locals11 = new _003C_003Ec__DisplayClass14_1();
				CS_0024_003C_003E8__locals11.qciTFfu5Ov = array2[i];
				if (MSyPQaDTrfJtr3GUW48.D35lls5iF(CS_0024_003C_003E8__locals13.PN2TC7nBN2, MSyPQaDTrfJtr3GUW48.ESUD4s2tw8).FirstOrDefault((HardwareDeviceInfo d) => aMnygB67j3N3yuQbSMF.D35lls5iF(d, aMnygB67j3N3yuQbSMF.PKP6cQZX8R) == CS_0024_003C_003E8__locals11.qciTFfu5Ov) != null)
				{
					OZFi5cDLea4g6MgMYOr.D35lls5iF(YQF0kW9goqSdXoWtJAF.D35lls5iF(P_1, YQF0kW9goqSdXoWtJAF.XRw9ikEf4n), null, OZFi5cDLea4g6MgMYOr.e4mDEqBveZ);
					break;
				}
			}
		}
		StringBuilder stringBuilder = new StringBuilder();
		if (m9MGZR7k2RmVqYXYS5.D35lls5iF(CS_0024_003C_003E8__locals13.PN2TC7nBN2, m9MGZR7k2RmVqYXYS5.l8vDBfi6TL) > 1080)
		{
			Iqu9Z2D0u6duXqVdeBe.D35lls5iF(stringBuilder, iFZ5je3XFYKwkvcE5D.D35lls5iF(582, iFZ5je3XFYKwkvcE5D.N06TeK0ao), Iqu9Z2D0u6duXqVdeBe.No5DrBqXtD);
		}
		qni3xrDkAJ3vF35eMav.D35lls5iF(YQF0kW9goqSdXoWtJAF.D35lls5iF(P_1, YQF0kW9goqSdXoWtJAF.XRw9ikEf4n), slLC9nDGSMhIcv2FTUB.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(stringBuilder, wq2usy8gNndpuTw5mR.ajcDe8nffb), ',', slLC9nDGSMhIcv2FTUB.yv2DRs3jeV), qni3xrDkAJ3vF35eMav.dmJDvBNs4m);
		Dispatcher obj2 = bRAh8kDAgKIlehXIXku.D35lls5iF(CS_0024_003C_003E8__locals13.CSGTMxcm1h, bRAh8kDAgKIlehXIXku.oESD6ce9jH);
		if (obj2 != null)
		{
			QDm1hrDpKcWfLbL64Vl.D35lls5iF(obj2, delegate
			{
				K8DNce6twv9Np34xpPr.D35lls5iF(CS_0024_003C_003E8__locals13.CSGTMxcm1h, uEUVCI48fycroqgRFqy.D35lls5iF(CS_0024_003C_003E8__locals13.PN2TC7nBN2, uEUVCI48fycroqgRFqy.hx66UqOmg8) ? CaptionsChannel.CC1 : CaptionsChannel.CCP, K8DNce6twv9Np34xpPr.qtR6VreiE6);
			}, QDm1hrDpKcWfLbL64Vl.cxUDwIkrIx);
		}
	}

	protected void OnMediaOpened(object sender, MediaOpenedEventArgs e)
	{
	}

	protected void OnMediaReady(object sender, EventArgs e)
	{
	}

	protected void OnMediaClosed(object sender, EventArgs e)
	{
	}

	protected void OnMediaChanging(object sender, MediaOpeningEventArgs e)
	{
		List<StreamInfo> list = (from x in YrCoj4DChUfyKXuSvMK.D35lls5iF(Pu8ZkM9Q72E1xo0KU8s.D35lls5iF(e, Pu8ZkM9Q72E1xo0KU8s.mf79X0XhAB), YrCoj4DChUfyKXuSvMK.osNDmFEjj6)
			where Up3ObFDSJspBLFTGC8N.D35lls5iF(x.Value, Up3ObFDSJspBLFTGC8N.z70DKvMmSu) == (AVMediaType)gvDpe65iW
			select x.Value).ToList();
		if (list.Count > 0)
		{
			if (gvDpe65iW != MediaType.Video)
			{
				list.Add(null);
			}
			int num;
			switch (gvDpe65iW)
			{
			default:
				return;
			case MediaType.Audio:
				num = list.IndexOf(nrSOHAD8YrC91Hd87Ly.D35lls5iF(YQF0kW9goqSdXoWtJAF.D35lls5iF(e, YQF0kW9goqSdXoWtJAF.XRw9ikEf4n), nrSOHAD8YrC91Hd87Ly.kQEDayfkOb));
				break;
			case MediaType.Video:
				num = list.IndexOf(nrSOHAD8YrC91Hd87Ly.D35lls5iF(YQF0kW9goqSdXoWtJAF.D35lls5iF(e, YQF0kW9goqSdXoWtJAF.XRw9ikEf4n), nrSOHAD8YrC91Hd87Ly.EaoDno9rGj));
				break;
			case MediaType.Subtitle:
				num = list.IndexOf(nrSOHAD8YrC91Hd87Ly.D35lls5iF(YQF0kW9goqSdXoWtJAF.D35lls5iF(e, YQF0kW9goqSdXoWtJAF.XRw9ikEf4n), nrSOHAD8YrC91Hd87Ly.h1MDIuPtG3));
				break;
			case (MediaType)2:
				return;
			}
			num++;
			if (num >= list.Count)
			{
				num = 0;
			}
			StreamInfo streamInfo = list[num];
			switch (gvDpe65iW)
			{
			case MediaType.Audio:
				zWVKfNDdAAWj4PIoemO.D35lls5iF(YQF0kW9goqSdXoWtJAF.D35lls5iF(e, YQF0kW9goqSdXoWtJAF.XRw9ikEf4n), streamInfo, zWVKfNDdAAWj4PIoemO.iUiDUFofUR);
				break;
			case MediaType.Video:
				zWVKfNDdAAWj4PIoemO.D35lls5iF(YQF0kW9goqSdXoWtJAF.D35lls5iF(e, YQF0kW9goqSdXoWtJAF.XRw9ikEf4n), streamInfo, zWVKfNDdAAWj4PIoemO.O8xDt8r9Nr);
				break;
			case MediaType.Subtitle:
				zWVKfNDdAAWj4PIoemO.D35lls5iF(YQF0kW9goqSdXoWtJAF.D35lls5iF(e, YQF0kW9goqSdXoWtJAF.XRw9ikEf4n), streamInfo, zWVKfNDdAAWj4PIoemO.gDnDVRIkpN);
				break;
			case (MediaType)2:
				break;
			}
		}
	}

	protected void OnMediaChanged(object sender, MediaOpenedEventArgs e)
	{
	}

	[AsyncStateMachine(typeof(_003COnAudioDeviceStopped_003Ed__20))]
	protected void OnAudioDeviceStopped(object sender, EventArgs e)
	{
		_003COnAudioDeviceStopped_003Ed__20 stateMachine = default(_003COnAudioDeviceStopped_003Ed__20);
		stateMachine._003C_003Et__builder = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
		stateMachine.sender = sender;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003COnUserControlKeyDown_003Ed__21))]
	private void rqUAT84Pp(object P_0, KeyEventArgs P_1)
	{
		_003COnUserControlKeyDown_003Ed__21 stateMachine = default(_003COnUserControlKeyDown_003Ed__21);
		stateMachine._003C_003Et__builder = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
		stateMachine._003C_003E4__this = this;
		stateMachine.e = P_1;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void zKWNHyvU4(object P_0, MouseButtonEventArgs P_1)
	{
		if (P_0 != null && GmMLaTD7kV8rq88ZFvR.D35lls5iF(P_0, Media, GmMLaTD7kV8rq88ZFvR.BQ5Dcmx5Pp))
		{
			QnJnl7fVDKI4mA6voc.D35lls5iF(P_1, true, QnJnl7fVDKI4mA6voc.WSpDMQcj8Y);
		}
	}

	protected void OnMediaPositionChanged(object sender, PositionChangedEventArgs e)
	{
	}

	protected void OnMediaStateChanged(object sender, MediaStateChangedEventArgs e)
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "5.0.4.0")]
	public void InitializeComponent()
	{
		if (!syq3em9OI)
		{
			syq3em9OI = true;
			Uri uri = new Uri(iFZ5je3XFYKwkvcE5D.D35lls5iF(614, iFZ5je3XFYKwkvcE5D.N06TeK0ao), UriKind.Relative);
			TUdx26d4l5VwJTvopv.D35lls5iF(this, uri, TUdx26d4l5VwJTvopv.W3oUN4AKb);
		}
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "5.0.4.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		case 1:
			Player = (Grid)target;
			break;
		case 2:
			Media = (Unosquare.FFME.MediaElement)target;
			break;
		default:
			syq3em9OI = true;
			break;
		}
	}

	static FFMEPlayerControl()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		Key[] array = new Key[3];
		ODLiVRlRE2AwTHTxA2m.D35lls5iF(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, ODLiVRlRE2AwTHTxA2m.rwklk7wPqp);
		Xbx6ntsoc = (Key[])(object)array;
	}

	[CompilerGenerated]
	private void DIiMeWrHU(object P_0, MouseEventArgs P_1)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		Point val = USqZXQlvmGLrody4O9t.D35lls5iF(P_1, this, USqZXQlvmGLrody4O9t.nH9lA1iUxt);
		if (dcJjqelwgiZ4n97w1vs.D35lls5iF(h9FJZ2l6apsXs25G7nL.D35lls5iF(ref val, h9FJZ2l6apsXs25G7nL.Hhilp1Ei0F) - h9FJZ2l6apsXs25G7nL.D35lls5iF(ref kxOx9jkI8, h9FJZ2l6apsXs25G7nL.Hhilp1Ei0F), dcJjqelwgiZ4n97w1vs.jM2lCY9POn) > double.Epsilon || dcJjqelwgiZ4n97w1vs.D35lls5iF(h9FJZ2l6apsXs25G7nL.D35lls5iF(ref val, h9FJZ2l6apsXs25G7nL.Rwnlm4hpqZ) - h9FJZ2l6apsXs25G7nL.D35lls5iF(ref kxOx9jkI8, h9FJZ2l6apsXs25G7nL.Rwnlm4hpqZ), dcJjqelwgiZ4n97w1vs.jM2lCY9POn) > double.Epsilon)
		{
			WTJsiuvlc = BvlWxPl1hnvXiXiwcCq.D35lls5iF(BvlWxPl1hnvXiXiwcCq.EYWl8ivUIj);
		}
		kxOx9jkI8 = val;
	}

	[CompilerGenerated]
	private void oGDCt0udL(object P_0, MouseEventArgs P_1)
	{
		DateTime dateTime = BvlWxPl1hnvXiXiwcCq.D35lls5iF(BvlWxPl1hnvXiXiwcCq.EYWl8ivUIj);
		WTJsiuvlc = NfWVCQlIPmCreciYdpZ.D35lls5iF(ref dateTime, aNJrrPl4soK5NDOndiN.D35lls5iF(10.0, aNJrrPl4soK5NDOndiN.Ca9lahqtKS), NfWVCQlIPmCreciYdpZ.v3GldeXUtY);
	}

	[CompilerGenerated]
	private void hSwYemtTL(object P_0, EventArgs P_1)
	{
		DateTime dateTime = BvlWxPl1hnvXiXiwcCq.D35lls5iF(BvlWxPl1hnvXiXiwcCq.EYWl8ivUIj);
		zDNlydlUqWxR09wbg1x.D35lls5iF(ref dateTime, WTJsiuvlc, zDNlydlUqWxR09wbg1x.kq0ltTVoZs);
	}

	[CompilerGenerated]
	private bool Xn9FrG0iY(KeyValuePair<int, StreamInfo> P_0)
	{
		return Up3ObFDSJspBLFTGC8N.D35lls5iF(P_0.Value, Up3ObFDSJspBLFTGC8N.z70DKvMmSu) == (AVMediaType)gvDpe65iW;
	}
}
