using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using PROTV.Abstractions.Common;
using PROTV.Abstractions.DataTransferObjects;
using PROTV.Abstractions.Search;
using PROTV.Abstractions.Services;
using PROTV.Wpf.Bootstrap;

namespace PROTV.Wpf.ViewModels;

public class EntertainmentCenterViewModel : BaseViewModel
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		public EntertainmentCenterViewModel nViZRWfYW4;

		public int m8CZwW1mnf;

		public _003C_003Ec__DisplayClass14_0()
		{
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
			base._002Ector();
		}

		internal void N3tZXx4ZAB()
		{
			HPaY7v4ahrafKGaWtLI.D35lls5iF(nViZRWfYW4, dq7UbsD57OHoHSoEhwE.D35lls5iF(nViZRWfYW4, dq7UbsD57OHoHSoEhwE.yQ4TXBJq07).ElementAt(m8CZwW1mnf), HPaY7v4ahrafKGaWtLI.Uepp5LbtED);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLoadAsync_003Ed__18 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public EntertainmentCenterViewModel _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			EntertainmentCenterViewModel CS_0024_003C_003E8__locals3 = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(W7S2sip6SDieZFVsNbd.D35lls5iF(CS_0024_003C_003E8__locals3, Expression.Lambda<Func<bool>>(OWBKr5pvc5MWsK1OMtR.D35lls5iF(o4bYL4peNeC2wWb8yjx.D35lls5iF(CS_0024_003C_003E8__locals3, sjYxHO8OWlc6X80hFj7.D35lls5iF(typeof(EntertainmentCenterViewModel).TypeHandle, sjYxHO8OWlc6X80hFj7.uWZ8ugU7r5), o4bYL4peNeC2wWb8yjx.oVdpGKjy2x), (MethodInfo)f5q427pRQZnrEKPy4Ws.D35lls5iF((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, f5q427pRQZnrEKPy4Ws.Bo9pk3m4k7), OWBKr5pvc5MWsK1OMtR.fZIpAAdi1v), Array.Empty<ParameterExpression>()), [AsyncStateMachine(typeof(_003C_003CLoadAsync_003Eb__18_1_003Ed))] () =>
					{
						_003C_003CLoadAsync_003Eb__18_1_003Ed stateMachine = default(_003C_003CLoadAsync_003Eb__18_1_003Ed);
						stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
						stateMachine._003C_003E4__this = CS_0024_003C_003E8__locals3;
						stateMachine._003C_003E1__state = -1;
						stateMachine._003C_003Et__builder.Start(ref stateMachine);
						return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
					}, W7S2sip6SDieZFVsNbd.XWappgVyfh), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
					if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
				}
				oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
			}
			catch (Exception ex)
			{
				_003C_003E1__state = -2;
				NNK1eXA7fWQ87oSUty7.D35lls5iF(ref _003C_003Et__builder, ex, NNK1eXA7fWQ87oSUty7.G3EAcW9Om7);
				return;
			}
			_003C_003E1__state = -2;
			meFicnAMHIVtdhf671p.D35lls5iF(ref _003C_003Et__builder, meFicnAMHIVtdhf671p.bsDASenQ5I);
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			vxBFJcAKZoecNtbdqxt.D35lls5iF(ref _003C_003Et__builder, stateMachine, vxBFJcAKZoecNtbdqxt.tuxANdhu18);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003C_003CLoadAsync_003Eb__18_1_003Ed : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public EntertainmentCenterViewModel _003C_003E4__this;

		private bool _003CtryAgain_003E5__2;

		private IStoreContext _003C_storeContext_003E5__3;

		private object _003C_003E7__wrap3;

		private int _003C_003E7__wrap4;

		private TaskAwaiter<ResponseList<GalleryImageResponseDto>> _003C_003Eu__1;

		private TaskAwaiter<Response<EntertainmentResponseDto>> _003C_003Eu__2;

		private TaskAwaiter<bool> _003C_003Eu__3;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			EntertainmentCenterViewModel entertainmentCenterViewModel = _003C_003E4__this;
			try
			{
				if ((uint)num <= 1u)
				{
					goto IL_0049;
				}
				if (num != 2)
				{
					_003CtryAgain_003E5__2 = true;
					goto IL_0a6f;
				}
				TaskAwaiter<bool> awaiter = _003C_003Eu__3;
				_003C_003Eu__3 = default(TaskAwaiter<bool>);
				num = (_003C_003E1__state = -1);
				goto IL_0a43;
				IL_0a61:
				_003C_003E7__wrap3 = null;
				_003C_storeContext_003E5__3 = null;
				goto IL_0a6f;
				IL_0a43:
				if (awaiter.GetResult())
				{
					_003CtryAgain_003E5__2 = true;
					entertainmentCenterViewModel._appService = AppContainer.Resolve<IAppService>();
				}
				goto IL_0a61;
				IL_0049:
				try
				{
					TaskAwaiter<Response<EntertainmentResponseDto>> awaiter2;
					TaskAwaiter<ResponseList<GalleryImageResponseDto>> awaiter3;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter2 = _003C_003Eu__2;
							_003C_003Eu__2 = default(TaskAwaiter<Response<EntertainmentResponseDto>>);
							num = (_003C_003E1__state = -1);
							goto IL_0210;
						}
						awaiter3 = L7J5wopzJsyIjy9272A.D35lls5iF(entertainmentCenterViewModel._appService, new ApiQuery<GallerySearch, GeneralSort>
						{
							Sort = GeneralSort.Index,
							Order = SortOrder.Asc
						}, L7J5wopzJsyIjy9272A.GyiwovQTJu).GetAwaiter();
						if (!awaiter3.IsCompleted)
						{
							num = (_003C_003E1__state = 0);
							_003C_003Eu__1 = awaiter3;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
							return;
						}
					}
					else
					{
						awaiter3 = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter<ResponseList<GalleryImageResponseDto>>);
						num = (_003C_003E1__state = -1);
					}
					ResponseList<GalleryImageResponseDto> result = awaiter3.GetResult();
					if (result.Status && result.Data.Total > 0)
					{
						HPmIsuTiopiGV1wvMTE.D35lls5iF(entertainmentCenterViewModel, new ObservableCollection<ImageSource>(), HPmIsuTiopiGV1wvMTE.GqWTQKyWJY);
						IEnumerator<GalleryImageResponseDto> enumerator = result.Data.Result.GetEnumerator();
						try
						{
							while (hjMnupQVVDlRZAYQJC.D35lls5iF(enumerator, hjMnupQVVDlRZAYQJC.QV1TFwytOj))
							{
								GalleryImageResponseDto current = enumerator.Current;
								kPA5yOwlWEeGDt70k4y.D35lls5iF(entertainmentCenterViewModel, kPA5yOwlWEeGDt70k4y.Oujw9knq86).Add(new BitmapImage(new Uri(d27jrd3uD0dgsTkvn8k.D35lls5iF(hjMnupQVVDlRZAYQJC.D35lls5iF(_003C_storeContext_003E5__3, hjMnupQVVDlRZAYQJC.YLV3Oa3St2), QQLie3eYkZwbFFm9Jjw.D35lls5iF(current, QQLie3eYkZwbFFm9Jjw.rHPwDZLkMh), d27jrd3uD0dgsTkvn8k.fC53Pw5IkY))));
							}
						}
						finally
						{
							if (num < 0 && enumerator != null)
							{
								xLO56JniGyickVjO1Ot.D35lls5iF(enumerator, xLO56JniGyickVjO1Ot.ydbT2bsoH4);
							}
						}
						qni3xrDkAJ3vF35eMav.D35lls5iF(entertainmentCenterViewModel, iFZ5je3XFYKwkvcE5D.D35lls5iF(16010, iFZ5je3XFYKwkvcE5D.N06TeK0ao), qni3xrDkAJ3vF35eMav.QN6DuDtCWO);
					}
					awaiter2 = JLc1G3wHVpobgQUHDlc.D35lls5iF(entertainmentCenterViewModel._appService, JLc1G3wHVpobgQUHDlc.KpNw1Lh4ha).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						num = (_003C_003E1__state = 1);
						_003C_003Eu__2 = awaiter2;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
						return;
					}
					goto IL_0210;
					IL_0210:
					Response<EntertainmentResponseDto> result2 = awaiter2.GetResult();
					if (result2.Status)
					{
						EntertainmentItemModel<BaseMediaDto> entertainmentItemModel = new EntertainmentItemModel<BaseMediaDto>();
						hH6DVMBvgw3ANNRyBk6.D35lls5iF(entertainmentItemModel, iFZ5je3XFYKwkvcE5D.D35lls5iF(9234, iFZ5je3XFYKwkvcE5D.N06TeK0ao), hH6DVMBvgw3ANNRyBk6.s1Vw8Fi0h8);
						EntertainmentItemModel<BaseMediaDto> entertainmentItemModel2 = entertainmentItemModel;
						if (S3n1TpwTXpOVKULbndH.D35lls5iF(zQa2yuwnhv2P9jeZSon.D35lls5iF(result2.Data, zQa2yuwnhv2P9jeZSon.RJ3w3WZXJf), S3n1TpwTXpOVKULbndH.AKGw4X5EnP) != null && S3n1TpwTXpOVKULbndH.D35lls5iF(zQa2yuwnhv2P9jeZSon.D35lls5iF(result2.Data, zQa2yuwnhv2P9jeZSon.RJ3w3WZXJf), S3n1TpwTXpOVKULbndH.AKGw4X5EnP).Any())
						{
							MedaiListItemModel<BaseMediaDto> item = new MedaiListItemModel<BaseMediaDto>(iFZ5je3XFYKwkvcE5D.D35lls5iF(16026, iFZ5je3XFYKwkvcE5D.N06TeK0ao))
							{
								Items = S3n1TpwTXpOVKULbndH.D35lls5iF(zQa2yuwnhv2P9jeZSon.D35lls5iF(result2.Data, zQa2yuwnhv2P9jeZSon.RJ3w3WZXJf), S3n1TpwTXpOVKULbndH.AKGw4X5EnP).ToList()
							};
							entertainmentItemModel2.Items.Add(item);
						}
						if (S3n1TpwTXpOVKULbndH.D35lls5iF(zQa2yuwnhv2P9jeZSon.D35lls5iF(result2.Data, zQa2yuwnhv2P9jeZSon.RJ3w3WZXJf), S3n1TpwTXpOVKULbndH.WPLwLvl3Q9) != null && S3n1TpwTXpOVKULbndH.D35lls5iF(zQa2yuwnhv2P9jeZSon.D35lls5iF(result2.Data, zQa2yuwnhv2P9jeZSon.RJ3w3WZXJf), S3n1TpwTXpOVKULbndH.WPLwLvl3Q9).Any())
						{
							MedaiListItemModel<BaseMediaDto> item2 = new MedaiListItemModel<BaseMediaDto>(iFZ5je3XFYKwkvcE5D.D35lls5iF(16044, iFZ5je3XFYKwkvcE5D.N06TeK0ao))
							{
								Items = S3n1TpwTXpOVKULbndH.D35lls5iF(zQa2yuwnhv2P9jeZSon.D35lls5iF(result2.Data, zQa2yuwnhv2P9jeZSon.RJ3w3WZXJf), S3n1TpwTXpOVKULbndH.WPLwLvl3Q9).ToList()
							};
							entertainmentItemModel2.Items.Add(item2);
						}
						if (S3n1TpwTXpOVKULbndH.D35lls5iF(zQa2yuwnhv2P9jeZSon.D35lls5iF(result2.Data, zQa2yuwnhv2P9jeZSon.RJ3w3WZXJf), S3n1TpwTXpOVKULbndH.MrXwESJaSE) != null && S3n1TpwTXpOVKULbndH.D35lls5iF(zQa2yuwnhv2P9jeZSon.D35lls5iF(result2.Data, zQa2yuwnhv2P9jeZSon.RJ3w3WZXJf), S3n1TpwTXpOVKULbndH.MrXwESJaSE).Any())
						{
							MedaiListItemModel<BaseMediaDto> item3 = new MedaiListItemModel<BaseMediaDto>(iFZ5je3XFYKwkvcE5D.D35lls5iF(13290, iFZ5je3XFYKwkvcE5D.N06TeK0ao))
							{
								Items = S3n1TpwTXpOVKULbndH.D35lls5iF(zQa2yuwnhv2P9jeZSon.D35lls5iF(result2.Data, zQa2yuwnhv2P9jeZSon.RJ3w3WZXJf), S3n1TpwTXpOVKULbndH.MrXwESJaSE).ToList()
							};
							entertainmentItemModel2.Items.Add(item3);
						}
						dq7UbsD57OHoHSoEhwE.D35lls5iF(entertainmentCenterViewModel, dq7UbsD57OHoHSoEhwE.yQ4TXBJq07).Add(entertainmentItemModel2);
						EntertainmentItemModel<BaseMediaDto> entertainmentItemModel3 = new EntertainmentItemModel<BaseMediaDto>();
						hH6DVMBvgw3ANNRyBk6.D35lls5iF(entertainmentItemModel3, iFZ5je3XFYKwkvcE5D.D35lls5iF(9308, iFZ5je3XFYKwkvcE5D.N06TeK0ao), hH6DVMBvgw3ANNRyBk6.s1Vw8Fi0h8);
						EntertainmentItemModel<BaseMediaDto> entertainmentItemModel4 = entertainmentItemModel3;
						if (YSuLOTwrQd4DCj824wQ.D35lls5iF(PcVCENwB5AbceHbRuAb.D35lls5iF(result2.Data, PcVCENwB5AbceHbRuAb.Y2Tw0xpkTc), YSuLOTwrQd4DCj824wQ.v0dweLWjWX) != null && YSuLOTwrQd4DCj824wQ.D35lls5iF(PcVCENwB5AbceHbRuAb.D35lls5iF(result2.Data, PcVCENwB5AbceHbRuAb.Y2Tw0xpkTc), YSuLOTwrQd4DCj824wQ.v0dweLWjWX).Any())
						{
							MedaiListItemModel<BaseMediaDto> item4 = new MedaiListItemModel<BaseMediaDto>(iFZ5je3XFYKwkvcE5D.D35lls5iF(16026, iFZ5je3XFYKwkvcE5D.N06TeK0ao))
							{
								Items = YSuLOTwrQd4DCj824wQ.D35lls5iF(PcVCENwB5AbceHbRuAb.D35lls5iF(result2.Data, PcVCENwB5AbceHbRuAb.Y2Tw0xpkTc), YSuLOTwrQd4DCj824wQ.v0dweLWjWX).ToList()
							};
							entertainmentItemModel4.Items.Add(item4);
						}
						if (EsDqfwwGITYotk69RLd.D35lls5iF(PcVCENwB5AbceHbRuAb.D35lls5iF(result2.Data, PcVCENwB5AbceHbRuAb.Y2Tw0xpkTc), EsDqfwwGITYotk69RLd.CRuwRO58u6) != null && EsDqfwwGITYotk69RLd.D35lls5iF(PcVCENwB5AbceHbRuAb.D35lls5iF(result2.Data, PcVCENwB5AbceHbRuAb.Y2Tw0xpkTc), EsDqfwwGITYotk69RLd.CRuwRO58u6).Any())
						{
							MedaiListItemModel<BaseMediaDto> item5 = new MedaiListItemModel<BaseMediaDto>(iFZ5je3XFYKwkvcE5D.D35lls5iF(16044, iFZ5je3XFYKwkvcE5D.N06TeK0ao))
							{
								Items = EsDqfwwGITYotk69RLd.D35lls5iF(PcVCENwB5AbceHbRuAb.D35lls5iF(result2.Data, PcVCENwB5AbceHbRuAb.Y2Tw0xpkTc), EsDqfwwGITYotk69RLd.CRuwRO58u6).ToList()
							};
							entertainmentItemModel4.Items.Add(item5);
						}
						if (EsDqfwwGITYotk69RLd.D35lls5iF(PcVCENwB5AbceHbRuAb.D35lls5iF(result2.Data, PcVCENwB5AbceHbRuAb.Y2Tw0xpkTc), EsDqfwwGITYotk69RLd.vLAwke5vie) != null && EsDqfwwGITYotk69RLd.D35lls5iF(PcVCENwB5AbceHbRuAb.D35lls5iF(result2.Data, PcVCENwB5AbceHbRuAb.Y2Tw0xpkTc), EsDqfwwGITYotk69RLd.vLAwke5vie).Any())
						{
							MedaiListItemModel<BaseMediaDto> item6 = new MedaiListItemModel<BaseMediaDto>(iFZ5je3XFYKwkvcE5D.D35lls5iF(13290, iFZ5je3XFYKwkvcE5D.N06TeK0ao))
							{
								Items = EsDqfwwGITYotk69RLd.D35lls5iF(PcVCENwB5AbceHbRuAb.D35lls5iF(result2.Data, PcVCENwB5AbceHbRuAb.Y2Tw0xpkTc), EsDqfwwGITYotk69RLd.vLAwke5vie).ToList()
							};
							entertainmentItemModel4.Items.Add(item6);
						}
						dq7UbsD57OHoHSoEhwE.D35lls5iF(entertainmentCenterViewModel, dq7UbsD57OHoHSoEhwE.yQ4TXBJq07).Add(entertainmentItemModel4);
						EntertainmentItemModel<BaseMediaDto> entertainmentItemModel5 = new EntertainmentItemModel<BaseMediaDto>();
						hH6DVMBvgw3ANNRyBk6.D35lls5iF(entertainmentItemModel5, iFZ5je3XFYKwkvcE5D.D35lls5iF(9382, iFZ5je3XFYKwkvcE5D.N06TeK0ao), hH6DVMBvgw3ANNRyBk6.s1Vw8Fi0h8);
						EntertainmentItemModel<BaseMediaDto> entertainmentItemModel6 = entertainmentItemModel5;
						if (OrADwVw6Sphy184UcA0.D35lls5iF(zDJHngwv12L0Eyln562.D35lls5iF(result2.Data, zDJHngwv12L0Eyln562.cJ1wAvsSrL), OrADwVw6Sphy184UcA0.TAwwpmEewk) != null && OrADwVw6Sphy184UcA0.D35lls5iF(zDJHngwv12L0Eyln562.D35lls5iF(result2.Data, zDJHngwv12L0Eyln562.cJ1wAvsSrL), OrADwVw6Sphy184UcA0.TAwwpmEewk).Any())
						{
							MedaiListItemModel<BaseMediaDto> item7 = new MedaiListItemModel<BaseMediaDto>(iFZ5je3XFYKwkvcE5D.D35lls5iF(16026, iFZ5je3XFYKwkvcE5D.N06TeK0ao))
							{
								Items = OrADwVw6Sphy184UcA0.D35lls5iF(zDJHngwv12L0Eyln562.D35lls5iF(result2.Data, zDJHngwv12L0Eyln562.cJ1wAvsSrL), OrADwVw6Sphy184UcA0.TAwwpmEewk).ToList()
							};
							entertainmentItemModel6.Items.Add(item7);
						}
						if (OrADwVw6Sphy184UcA0.D35lls5iF(zDJHngwv12L0Eyln562.D35lls5iF(result2.Data, zDJHngwv12L0Eyln562.cJ1wAvsSrL), OrADwVw6Sphy184UcA0.WBiww9Z9MQ) != null && OrADwVw6Sphy184UcA0.D35lls5iF(zDJHngwv12L0Eyln562.D35lls5iF(result2.Data, zDJHngwv12L0Eyln562.cJ1wAvsSrL), OrADwVw6Sphy184UcA0.WBiww9Z9MQ).Any())
						{
							MedaiListItemModel<BaseMediaDto> item8 = new MedaiListItemModel<BaseMediaDto>(iFZ5je3XFYKwkvcE5D.D35lls5iF(16044, iFZ5je3XFYKwkvcE5D.N06TeK0ao))
							{
								Items = OrADwVw6Sphy184UcA0.D35lls5iF(zDJHngwv12L0Eyln562.D35lls5iF(result2.Data, zDJHngwv12L0Eyln562.cJ1wAvsSrL), OrADwVw6Sphy184UcA0.WBiww9Z9MQ).ToList()
							};
							entertainmentItemModel6.Items.Add(item8);
						}
						if (OrADwVw6Sphy184UcA0.D35lls5iF(zDJHngwv12L0Eyln562.D35lls5iF(result2.Data, zDJHngwv12L0Eyln562.cJ1wAvsSrL), OrADwVw6Sphy184UcA0.P4FwCowu5o) != null && OrADwVw6Sphy184UcA0.D35lls5iF(zDJHngwv12L0Eyln562.D35lls5iF(result2.Data, zDJHngwv12L0Eyln562.cJ1wAvsSrL), OrADwVw6Sphy184UcA0.P4FwCowu5o).Any())
						{
							MedaiListItemModel<BaseMediaDto> item9 = new MedaiListItemModel<BaseMediaDto>(iFZ5je3XFYKwkvcE5D.D35lls5iF(13290, iFZ5je3XFYKwkvcE5D.N06TeK0ao))
							{
								Items = OrADwVw6Sphy184UcA0.D35lls5iF(zDJHngwv12L0Eyln562.D35lls5iF(result2.Data, zDJHngwv12L0Eyln562.cJ1wAvsSrL), OrADwVw6Sphy184UcA0.P4FwCowu5o).ToList()
							};
							entertainmentItemModel6.Items.Add(item9);
						}
						dq7UbsD57OHoHSoEhwE.D35lls5iF(entertainmentCenterViewModel, dq7UbsD57OHoHSoEhwE.yQ4TXBJq07).Add(entertainmentItemModel6);
						EntertainmentItemModel<BaseMediaDto> entertainmentItemModel7 = new EntertainmentItemModel<BaseMediaDto>();
						hH6DVMBvgw3ANNRyBk6.D35lls5iF(entertainmentItemModel7, iFZ5je3XFYKwkvcE5D.D35lls5iF(9452, iFZ5je3XFYKwkvcE5D.N06TeK0ao), hH6DVMBvgw3ANNRyBk6.s1Vw8Fi0h8);
						EntertainmentItemModel<BaseMediaDto> entertainmentItemModel8 = entertainmentItemModel7;
						if (YSuLOTwrQd4DCj824wQ.D35lls5iF(SLKrKOwmUdID52BliMm.D35lls5iF(result2.Data, SLKrKOwmUdID52BliMm.BmWwatmA1y), YSuLOTwrQd4DCj824wQ.sh7wI4Gmwg) != null && YSuLOTwrQd4DCj824wQ.D35lls5iF(SLKrKOwmUdID52BliMm.D35lls5iF(result2.Data, SLKrKOwmUdID52BliMm.BmWwatmA1y), YSuLOTwrQd4DCj824wQ.sh7wI4Gmwg).Any())
						{
							MedaiListItemModel<BaseMediaDto> item10 = new MedaiListItemModel<BaseMediaDto>(iFZ5je3XFYKwkvcE5D.D35lls5iF(16026, iFZ5je3XFYKwkvcE5D.N06TeK0ao))
							{
								Items = YSuLOTwrQd4DCj824wQ.D35lls5iF(SLKrKOwmUdID52BliMm.D35lls5iF(result2.Data, SLKrKOwmUdID52BliMm.BmWwatmA1y), YSuLOTwrQd4DCj824wQ.sh7wI4Gmwg).ToList()
							};
							entertainmentItemModel8.Items.Add(item10);
						}
						if (EsDqfwwGITYotk69RLd.D35lls5iF(SLKrKOwmUdID52BliMm.D35lls5iF(result2.Data, SLKrKOwmUdID52BliMm.BmWwatmA1y), EsDqfwwGITYotk69RLd.XYMwdX8tHS) != null && EsDqfwwGITYotk69RLd.D35lls5iF(SLKrKOwmUdID52BliMm.D35lls5iF(result2.Data, SLKrKOwmUdID52BliMm.BmWwatmA1y), EsDqfwwGITYotk69RLd.XYMwdX8tHS).Any())
						{
							MedaiListItemModel<BaseMediaDto> item11 = new MedaiListItemModel<BaseMediaDto>(iFZ5je3XFYKwkvcE5D.D35lls5iF(16044, iFZ5je3XFYKwkvcE5D.N06TeK0ao))
							{
								Items = EsDqfwwGITYotk69RLd.D35lls5iF(SLKrKOwmUdID52BliMm.D35lls5iF(result2.Data, SLKrKOwmUdID52BliMm.BmWwatmA1y), EsDqfwwGITYotk69RLd.XYMwdX8tHS).ToList()
							};
							entertainmentItemModel8.Items.Add(item11);
						}
						if (EsDqfwwGITYotk69RLd.D35lls5iF(SLKrKOwmUdID52BliMm.D35lls5iF(result2.Data, SLKrKOwmUdID52BliMm.BmWwatmA1y), EsDqfwwGITYotk69RLd.x0KwUgAbnc) != null && EsDqfwwGITYotk69RLd.D35lls5iF(SLKrKOwmUdID52BliMm.D35lls5iF(result2.Data, SLKrKOwmUdID52BliMm.BmWwatmA1y), EsDqfwwGITYotk69RLd.x0KwUgAbnc).Any())
						{
							MedaiListItemModel<BaseMediaDto> item12 = new MedaiListItemModel<BaseMediaDto>(iFZ5je3XFYKwkvcE5D.D35lls5iF(13290, iFZ5je3XFYKwkvcE5D.N06TeK0ao))
							{
								Items = EsDqfwwGITYotk69RLd.D35lls5iF(SLKrKOwmUdID52BliMm.D35lls5iF(result2.Data, SLKrKOwmUdID52BliMm.BmWwatmA1y), EsDqfwwGITYotk69RLd.x0KwUgAbnc).ToList()
							};
							entertainmentItemModel8.Items.Add(item12);
						}
						dq7UbsD57OHoHSoEhwE.D35lls5iF(entertainmentCenterViewModel, dq7UbsD57OHoHSoEhwE.yQ4TXBJq07).Add(entertainmentItemModel8);
					}
					HPaY7v4ahrafKGaWtLI.D35lls5iF(entertainmentCenterViewModel, dq7UbsD57OHoHSoEhwE.D35lls5iF(entertainmentCenterViewModel, dq7UbsD57OHoHSoEhwE.yQ4TXBJq07).FirstOrDefault(), HPaY7v4ahrafKGaWtLI.Uepp5LbtED);
				}
				catch (PROTVException ex)
				{
					_003C_003E7__wrap3 = ex;
					_003C_003E7__wrap4 = 1;
				}
				int num2 = _003C_003E7__wrap4;
				if (num2 == 1 && TNckS5wtLfB2Lk9dYP8.D35lls5iF((PROTVException)_003C_003E7__wrap3, TNckS5wtLfB2Lk9dYP8.oGkwV3iq3t) == ExceptionType.AuthorizationTokenInvalid)
				{
					awaiter = bAA7Sxw7vZsvusOmDea.D35lls5iF(AppContainer.Resolve<MainViewModel>(), bAA7Sxw7vZsvusOmDea.gytwc9U7r5).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_003C_003E1__state = 2);
						_003C_003Eu__3 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_0a43;
				}
				goto IL_0a61;
				IL_0a6f:
				if (_003CtryAgain_003E5__2)
				{
					_003C_storeContext_003E5__3 = AppContainer.Resolve<IStoreContext>();
					_003CtryAgain_003E5__2 = false;
					_003C_003E7__wrap4 = 0;
					goto IL_0049;
				}
			}
			catch (Exception ex2)
			{
				_003C_003E1__state = -2;
				NNK1eXA7fWQ87oSUty7.D35lls5iF(ref _003C_003Et__builder, ex2, NNK1eXA7fWQ87oSUty7.G3EAcW9Om7);
				return;
			}
			_003C_003E1__state = -2;
			meFicnAMHIVtdhf671p.D35lls5iF(ref _003C_003Et__builder, meFicnAMHIVtdhf671p.bsDASenQ5I);
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			vxBFJcAKZoecNtbdqxt.D35lls5iF(ref _003C_003Et__builder, stateMachine, vxBFJcAKZoecNtbdqxt.tuxANdhu18);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	public IAppService _appService;

	[CompilerGenerated]
	private ObservableCollection<ImageSource> GI9BgmbhC2;

	[CompilerGenerated]
	private ObservableCollection<EntertainmentItemModel<BaseMediaDto>> TS4B16y8rv;

	private BaseViewModel YrVBJAjxt9;

	private int RbUBhPLbfb;

	public BaseViewModel SelectedModel
	{
		get
		{
			return YrVBJAjxt9;
		}
		set
		{
			SetProperty(ref YrVBJAjxt9, value, iFZ5je3XFYKwkvcE5D.D35lls5iF(8630, iFZ5je3XFYKwkvcE5D.N06TeK0ao));
		}
	}

	public ObservableCollection<ImageSource> Images
	{
		[CompilerGenerated]
		get
		{
			return GI9BgmbhC2;
		}
		[CompilerGenerated]
		set
		{
			GI9BgmbhC2 = value;
		}
	}

	public ObservableCollection<EntertainmentItemModel<BaseMediaDto>> Items
	{
		[CompilerGenerated]
		get
		{
			return TS4B16y8rv;
		}
		[CompilerGenerated]
		set
		{
			TS4B16y8rv = value;
		}
	}

	public int TabSelectedindex
	{
		get
		{
			return RbUBhPLbfb;
		}
		set
		{
			_003C_003Ec__DisplayClass14_0 CS_0024_003C_003E8__locals6 = new _003C_003Ec__DisplayClass14_0();
			CS_0024_003C_003E8__locals6.nViZRWfYW4 = this;
			CS_0024_003C_003E8__locals6.m8CZwW1mnf = value;
			SetProperty(ref RbUBhPLbfb, CS_0024_003C_003E8__locals6.m8CZwW1mnf, iFZ5je3XFYKwkvcE5D.D35lls5iF(8660, iFZ5je3XFYKwkvcE5D.N06TeK0ao), null, delegate
			{
				HPaY7v4ahrafKGaWtLI.D35lls5iF(CS_0024_003C_003E8__locals6.nViZRWfYW4, dq7UbsD57OHoHSoEhwE.D35lls5iF(CS_0024_003C_003E8__locals6.nViZRWfYW4, dq7UbsD57OHoHSoEhwE.yQ4TXBJq07).ElementAt(CS_0024_003C_003E8__locals6.m8CZwW1mnf), HPaY7v4ahrafKGaWtLI.Uepp5LbtED);
			});
		}
	}

	public EntertainmentCenterViewModel()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector();
		_appService = AppContainer.Resolve<IAppService>();
		QWBkOQTYftMQp4Ronu0.D35lls5iF(this, new ObservableCollection<EntertainmentItemModel<BaseMediaDto>>(), QWBkOQTYftMQp4Ronu0.y6ITgrtWTp);
		HPmIsuTiopiGV1wvMTE.D35lls5iF(this, new ObservableCollection<ImageSource>(), HPmIsuTiopiGV1wvMTE.GqWTQKyWJY);
	}

	[AsyncStateMachine(typeof(_003CLoadAsync_003Ed__18))]
	public Task LoadAsync()
	{
		_003CLoadAsync_003Ed__18 stateMachine = default(_003CLoadAsync_003Ed__18);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	public override void Dispose()
	{
	}

	public void Clear()
	{
	}

	public override void OnLoading()
	{
		if (!dq7UbsD57OHoHSoEhwE.D35lls5iF(this, dq7UbsD57OHoHSoEhwE.yQ4TXBJq07).Any())
		{
			Task task = CRMxYv82mIBQFuWGeba.D35lls5iF(this, CRMxYv82mIBQFuWGeba.B7yTfHt290);
			Action<Exception> action = null;
			bool flag = false;
			gBlEqv8jRKikCj2DMZp.D35lls5iF(task, ref action, ref flag, gBlEqv8jRKikCj2DMZp.pSp8ymt8Mu);
			return;
		}
		IEnumerator<MedaiListItemModel<BaseMediaDto>> enumerator = dq7UbsD57OHoHSoEhwE.D35lls5iF(this, dq7UbsD57OHoHSoEhwE.yQ4TXBJq07).SelectMany((EntertainmentItemModel<BaseMediaDto> x) => x.Items).GetEnumerator();
		try
		{
			while (hjMnupQVVDlRZAYQJC.D35lls5iF(enumerator, hjMnupQVVDlRZAYQJC.QV1TFwytOj))
			{
				enumerator.Current.Clear();
			}
		}
		finally
		{
			if (enumerator != null)
			{
				xLO56JniGyickVjO1Ot.D35lls5iF(enumerator, xLO56JniGyickVjO1Ot.ydbT2bsoH4);
			}
		}
	}

	[AsyncStateMachine(typeof(_003C_003CLoadAsync_003Eb__18_1_003Ed))]
	[CompilerGenerated]
	private Task AvFBovG12D()
	{
		_003C_003CLoadAsync_003Eb__18_1_003Ed stateMachine = default(_003C_003CLoadAsync_003Eb__18_1_003Ed);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}
}
