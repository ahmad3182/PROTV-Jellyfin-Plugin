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
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;
using FFmpeg.AutoGen;
using PROTV.Abstractions.Apis;
using PROTV.Abstractions.Common;
using PROTV.Abstractions.DataTransferObjects;
using PROTV.Abstractions.Helpers;
using PROTV.Abstractions.Search;
using PROTV.Abstractions.Services;
using PROTV.Wpf.Bootstrap;
using PROTV.Wpf.Helpers;
using Unosquare.FFME;

namespace PROTV.Wpf.ViewModels;

public class VideoPlayerViewModel : BaseViewModel
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass27_0
	{
		public MediaElement sAUSAysyAW;

		public VideoPlayerViewModel pygSN49AJ9;

		public _003C_003Ec__DisplayClass27_0()
		{
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
			base._002Ector();
		}

		internal void cG5SuiVlr9()
		{
			if (sAUSAysyAW != null)
			{
				fp757nBYjo8889efKFJ.D35lls5iF(cdbdBC3E9OhMyh2CjfD.D35lls5iF(pygSN49AJ9, cdbdBC3E9OhMyh2CjfD.BKrmNFK3ok), fp757nBYjo8889efKFJ.we7mOKxb1S);
				fp757nBYjo8889efKFJ.D35lls5iF(kNkAAf1oS8EBBquLcPe.D35lls5iF(pygSN49AJ9, kNkAAf1oS8EBBquLcPe.DYxEH8uI3e), fp757nBYjo8889efKFJ.we7mOKxb1S);
			}
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass39_0
	{
		public int y0QSChxjXe;

		public VideoPlayerViewModel IJySYmxEBQ;

		public _003C_003Ec__DisplayClass39_0()
		{
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
			base._002Ector();
		}

		internal void xUFSM1nYP4()
		{
			if (y0QSChxjXe == 0)
			{
				wV1i6CmPpOFoyWU06ru.D35lls5iF(srgd79T1FovS2Zr1sHa.D35lls5iF(IJySYmxEBQ, srgd79T1FovS2Zr1sHa.R5ZmucJ4Yd), 60.0, wV1i6CmPpOFoyWU06ru.OanmsOGBOd);
			}
			else if (y0QSChxjXe == 1)
			{
				wV1i6CmPpOFoyWU06ru.D35lls5iF(srgd79T1FovS2Zr1sHa.D35lls5iF(IJySYmxEBQ, srgd79T1FovS2Zr1sHa.R5ZmucJ4Yd), 50.0, wV1i6CmPpOFoyWU06ru.OanmsOGBOd);
			}
			else if (y0QSChxjXe == 2)
			{
				wV1i6CmPpOFoyWU06ru.D35lls5iF(srgd79T1FovS2Zr1sHa.D35lls5iF(IJySYmxEBQ, srgd79T1FovS2Zr1sHa.R5ZmucJ4Yd), 40.0, wV1i6CmPpOFoyWU06ru.OanmsOGBOd);
			}
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnAddToFavoriteCommandExcute_003Ed__70 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public VideoPlayerPlaylistItem dto;

		public VideoPlayerViewModel _003C_003E4__this;

		private TaskAwaiter<bool> _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			VideoPlayerViewModel videoPlayerViewModel = _003C_003E4__this;
			try
			{
				TaskAwaiter<bool> awaiter;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<bool>);
					num = (_003C_003E1__state = -1);
					goto IL_00a1;
				}
				if (xllcp23egxiMKQFcV8K.D35lls5iF(dto, xllcp23egxiMKQFcV8K.w8jklxyeAB) == PlaylistItemType.TvChannel)
				{
					awaiter = VbmtIFmnFwg9sqb4Jje.D35lls5iF(videoPlayerViewModel.qvxqT7isTw, m9MGZR7k2RmVqYXYS5.D35lls5iF(dto, m9MGZR7k2RmVqYXYS5.kIl3VviojT), VbmtIFmnFwg9sqb4Jje.TRymhqqh6j).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_00a1;
				}
				goto end_IL_0015;
				IL_00a1:
				if (awaiter.GetResult())
				{
					jPB9Q5LdIM9wsuWV1q7.D35lls5iF(dto, !LsA6RHpKkbdnOn3fX60.D35lls5iF(dto, LsA6RHpKkbdnOn3fX60.uYfmxO93Cq), jPB9Q5LdIM9wsuWV1q7.zBkmYAib5p);
					hH6DVMBvgw3ANNRyBk6.D35lls5iF(dto, iFZ5je3XFYKwkvcE5D.D35lls5iF(8354, iFZ5je3XFYKwkvcE5D.N06TeK0ao), hH6DVMBvgw3ANNRyBk6.hT7m8gyOr4);
				}
				end_IL_0015:;
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
	private struct _003COnPauseCommandExcuteAsync_003Ed__73 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public VideoPlayerViewModel _003C_003E4__this;

		private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			VideoPlayerViewModel videoPlayerViewModel = _003C_003E4__this;
			try
			{
				ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = wd2eJ2Asf3I9epXUKxU.D35lls5iF(srgd79T1FovS2Zr1sHa.D35lls5iF(videoPlayerViewModel, srgd79T1FovS2Zr1sHa.R5ZmucJ4Yd), wd2eJ2Asf3I9epXUKxU.kl3mgXtXSD).GetAwaiter();
					if (!awaiter.IsCompleted)
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
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter);
					num = (_003C_003E1__state = -1);
				}
				awaiter.GetResult();
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
	private struct _003COnPlayCommandExcuteAsync_003Ed__74 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public VideoPlayerViewModel _003C_003E4__this;

		private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			VideoPlayerViewModel videoPlayerViewModel = _003C_003E4__this;
			try
			{
				ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = wd2eJ2Asf3I9epXUKxU.D35lls5iF(srgd79T1FovS2Zr1sHa.D35lls5iF(videoPlayerViewModel, srgd79T1FovS2Zr1sHa.R5ZmucJ4Yd), wd2eJ2Asf3I9epXUKxU.fTCmiFqqnh).GetAwaiter();
					if (!awaiter.IsCompleted)
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
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter);
					num = (_003C_003E1__state = -1);
				}
				awaiter.GetResult();
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

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass77_0
	{
		public VideoPlayerPlaylistItem PdeS6tJI69;

		public _003C_003Ec__DisplayClass77_0()
		{
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
			base._002Ector();
		}

		internal bool KTySF3hWJ1(EPGDataResponseDto x)
		{
			return V4VMaWmQYRpUqEIxujB.D35lls5iF(x, V4VMaWmQYRpUqEIxujB.cLOmX6xaXW) == m9MGZR7k2RmVqYXYS5.D35lls5iF(PdeS6tJI69, m9MGZR7k2RmVqYXYS5.kIl3VviojT);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLoadEpgItems_003Ed__77 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public VideoPlayerViewModel _003C_003E4__this;

		private TaskAwaiter<Response<IEnumerable<EPGDataResponseDto>>> _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_039e: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ba: Expected O, but got Unknown
			//IL_03ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_03cd: Expected O, but got Unknown
			//IL_03d7: Expected O, but got Unknown
			int num = _003C_003E1__state;
			VideoPlayerViewModel videoPlayerViewModel = _003C_003E4__this;
			try
			{
				try
				{
					TaskAwaiter<Response<IEnumerable<EPGDataResponseDto>>> awaiter;
					if (num != 0)
					{
						awaiter = fc9NjbmF5e5BbX8AmJw.D35lls5iF(videoPlayerViewModel.qvxqT7isTw, fc9NjbmF5e5BbX8AmJw.cixm2myJNP).GetAwaiter();
						if (!awaiter.IsCompleted)
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
						_003C_003Eu__1 = default(TaskAwaiter<Response<IEnumerable<EPGDataResponseDto>>>);
						num = (_003C_003E1__state = -1);
					}
					Response<IEnumerable<EPGDataResponseDto>> result = awaiter.GetResult();
					DateTime? dateTime = result.Data.SelectMany((EPGDataResponseDto x) => LHX2RPEniIXFwofTA3i.D35lls5iF(x, LHX2RPEniIXFwofTA3i.WNomfWJvj8)).Min((EPGItemResponseDto x) => jyJOWlG4c4VgR6hR3yW.D35lls5iF(x, jyJOWlG4c4VgR6hR3yW.qZyGLhG8Kh));
					IEnumerator<VideoPlayerPlaylistItem> enumerator = gWjDbdmZEDgXehC8R2t.D35lls5iF(kNkAAf1oS8EBBquLcPe.D35lls5iF(videoPlayerViewModel, kNkAAf1oS8EBBquLcPe.DYxEH8uI3e), gWjDbdmZEDgXehC8R2t.MxkmjO1vRD).GetEnumerator();
					try
					{
						while (hjMnupQVVDlRZAYQJC.D35lls5iF(enumerator, hjMnupQVVDlRZAYQJC.QV1TFwytOj))
						{
							_003C_003Ec__DisplayClass77_0 CS_0024_003C_003E8__locals4 = new _003C_003Ec__DisplayClass77_0();
							CS_0024_003C_003E8__locals4.PdeS6tJI69 = enumerator.Current;
							VideoPlayerPlaylistItem videoPlayerPlaylistItem = CS_0024_003C_003E8__locals4.PdeS6tJI69;
							DateTime dateTime2 = BvlWxPl1hnvXiXiwcCq.D35lls5iF(BvlWxPl1hnvXiXiwcCq.YfD1XHDES3);
							DateTime? dateTime3 = dateTime;
							TimeSpan value = (dateTime3.HasValue ? new TimeSpan?(uu1sUimyKl0GDfryf0O.D35lls5iF(dateTime2, dateTime3.GetValueOrDefault(), uu1sUimyKl0GDfryf0O.YoBmqSdJwK)) : ((TimeSpan?)null)).Value;
							Tr7S4tmbD38LrEkLtjT.D35lls5iF(videoPlayerPlaylistItem, LUSRjplVkOtM7DbdDL3.D35lls5iF(ref value, LUSRjplVkOtM7DbdDL3.xe6mJX62BG) * 5.0, Tr7S4tmbD38LrEkLtjT.EhgmWqSTGj);
							object obj;
							if (result == null)
							{
								obj = null;
							}
							else
							{
								IEnumerable<EPGDataResponseDto> data = result.Data;
								if (data == null)
								{
									obj = null;
								}
								else
								{
									EPGDataResponseDto? ePGDataResponseDto = data.FirstOrDefault((EPGDataResponseDto x) => V4VMaWmQYRpUqEIxujB.D35lls5iF(x, V4VMaWmQYRpUqEIxujB.cLOmX6xaXW) == m9MGZR7k2RmVqYXYS5.D35lls5iF(CS_0024_003C_003E8__locals4.PdeS6tJI69, m9MGZR7k2RmVqYXYS5.kIl3VviojT));
									obj = ((ePGDataResponseDto != null) ? LHX2RPEniIXFwofTA3i.D35lls5iF(ePGDataResponseDto, LHX2RPEniIXFwofTA3i.VAum5ifuHM).ToList() : null);
								}
							}
							List<EPGItemResponseDto> list = (List<EPGItemResponseDto>)obj;
							TimeSpan? obj2;
							if (list == null)
							{
								obj2 = null;
							}
							else
							{
								EPGItemResponseDto? ePGItemResponseDto = list.FirstOrDefault();
								dateTime3 = ((ePGItemResponseDto != null) ? jyJOWlG4c4VgR6hR3yW.D35lls5iF(ePGItemResponseDto, jyJOWlG4c4VgR6hR3yW.DyomzXwP5d) : ((DateTime?)null));
								DateTime? dateTime4 = dateTime;
								obj2 = ((dateTime3.HasValue & dateTime4.HasValue) ? new TimeSpan?(uu1sUimyKl0GDfryf0O.D35lls5iF(dateTime3.GetValueOrDefault(), dateTime4.GetValueOrDefault(), uu1sUimyKl0GDfryf0O.YoBmqSdJwK)) : ((TimeSpan?)null));
							}
							TimeSpan? timeSpan = obj2;
							if (timeSpan.HasValue)
							{
								value = timeSpan.Value;
								if (LUSRjplVkOtM7DbdDL3.D35lls5iF(ref value, LUSRjplVkOtM7DbdDL3.xe6mJX62BG) > 0.0)
								{
									EPGItemResponseDto ePGItemResponseDto2 = new EPGItemResponseDto();
									value = timeSpan.Value;
									double num2 = LUSRjplVkOtM7DbdDL3.D35lls5iF(ref value, LUSRjplVkOtM7DbdDL3.xe6mJX62BG);
									m5sZxWmLHUhVHrJe8sC.D35lls5iF(ePGItemResponseDto2, zOGWnuaoi2gLClDRe9i.D35lls5iF(ref num2, zOGWnuaoi2gLClDRe9i.fhvalsUXPo), m5sZxWmLHUhVHrJe8sC.O9xa9eC4ig);
									m5sZxWmLHUhVHrJe8sC.D35lls5iF(ePGItemResponseDto2, iFZ5je3XFYKwkvcE5D.D35lls5iF(16418, iFZ5je3XFYKwkvcE5D.N06TeK0ao), m5sZxWmLHUhVHrJe8sC.MBraDwBswm);
									list.Insert(0, ePGItemResponseDto2);
								}
							}
							XqU6jmaH2O51KjVhnev.D35lls5iF(CS_0024_003C_003E8__locals4.PdeS6tJI69, list, XqU6jmaH2O51KjVhnev.mGqa1mh31l);
						}
					}
					finally
					{
						if (num < 0 && enumerator != null)
						{
							xLO56JniGyickVjO1Ot.D35lls5iF(enumerator, xLO56JniGyickVjO1Ot.ydbT2bsoH4);
						}
					}
					E0xSFiTwLZJ7JNh4RGk.D35lls5iF(kNkAAf1oS8EBBquLcPe.D35lls5iF(videoPlayerViewModel, kNkAAf1oS8EBBquLcPe.DYxEH8uI3e), (from x in gWjDbdmZEDgXehC8R2t.D35lls5iF(kNkAAf1oS8EBBquLcPe.D35lls5iF(videoPlayerViewModel, kNkAAf1oS8EBBquLcPe.DYxEH8uI3e), gWjDbdmZEDgXehC8R2t.MxkmjO1vRD)
						where LHX2RPEniIXFwofTA3i.D35lls5iF(x, LHX2RPEniIXFwofTA3i.bTJE37Tn8Y) != null && LHX2RPEniIXFwofTA3i.D35lls5iF(x, LHX2RPEniIXFwofTA3i.bTJE37Tn8Y).Count() > 0
						select x).ToList(), E0xSFiTwLZJ7JNh4RGk.JT1a800lFY);
					hH6DVMBvgw3ANNRyBk6.D35lls5iF(kNkAAf1oS8EBBquLcPe.D35lls5iF(videoPlayerViewModel, kNkAAf1oS8EBBquLcPe.DYxEH8uI3e), iFZ5je3XFYKwkvcE5D.D35lls5iF(16446, iFZ5je3XFYKwkvcE5D.N06TeK0ao), hH6DVMBvgw3ANNRyBk6.hT7m8gyOr4);
					DispatcherTimer val = new DispatcherTimer();
					ytk50glr3dmeojxPvdr.D35lls5iF((object)val, videoPlayerViewModel.xyJPUBSxjn, ytk50glr3dmeojxPvdr.Lgkle9IPtT);
					AKwYZ1lE8mnNaTGlMo6.D35lls5iF((object)val, new TimeSpan(0, 1, 0), AKwYZ1lE8mnNaTGlMo6.EaBlBG90pn);
					AJv70itXcdnxnNYjSQ.D35lls5iF((object)val, AJv70itXcdnxnNYjSQ.JRYlG0QuuU);
				}
				catch
				{
				}
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
	private struct _003CLoadTvCategoriesItems_003Ed__78 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public VideoPlayerViewModel _003C_003E4__this;

		private TaskAwaiter<ResponseList<CategoryResponseDto>> _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			VideoPlayerViewModel videoPlayerViewModel = _003C_003E4__this;
			try
			{
				try
				{
					TaskAwaiter<ResponseList<CategoryResponseDto>> awaiter;
					if (num != 0)
					{
						IAppService xBYq0igajR = videoPlayerViewModel.xBYq0igajR;
						ApiQuery<CategorySearch, GeneralSort> obj = new ApiQuery<CategorySearch, GeneralSort>
						{
							Count = -1,
							Sort = GeneralSort.Name
						};
						CategorySearch categorySearch = new CategorySearch();
						PDE695CGbWQ6wS7etBU.D35lls5iF(categorySearch, CategoryType.Channel, PDE695CGbWQ6wS7etBU.rt7CRxAZ59);
						obj.Search = categorySearch;
						obj.Order = SortOrder.Asc;
						awaiter = GEHLO0CkuIP8aA9CV10.D35lls5iF(xBYq0igajR, obj, GEHLO0CkuIP8aA9CV10.AXeCvbp3sh).GetAwaiter();
						if (!awaiter.IsCompleted)
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
						_003C_003Eu__1 = default(TaskAwaiter<ResponseList<CategoryResponseDto>>);
						num = (_003C_003E1__state = -1);
					}
					ResponseList<CategoryResponseDto> result = awaiter.GetResult();
					if (result != null && result.Status)
					{
						fbCfXAT6sNT7gTw1IjA.D35lls5iF(kNkAAf1oS8EBBquLcPe.D35lls5iF(videoPlayerViewModel, kNkAAf1oS8EBBquLcPe.DYxEH8uI3e), result.Data.Result.ToList(), fbCfXAT6sNT7gTw1IjA.RhaanHFkeP);
						wuXoja6xGA4YsTL6UdU.D35lls5iF(hB8t9uC6c022dNynAqg.D35lls5iF(kNkAAf1oS8EBBquLcPe.D35lls5iF(videoPlayerViewModel, kNkAAf1oS8EBBquLcPe.DYxEH8uI3e), hB8t9uC6c022dNynAqg.lBMa3M77a0).FirstOrDefault(), null, wuXoja6xGA4YsTL6UdU.LxQCwZHHRC);
						hH6DVMBvgw3ANNRyBk6.D35lls5iF(kNkAAf1oS8EBBquLcPe.D35lls5iF(videoPlayerViewModel, kNkAAf1oS8EBBquLcPe.DYxEH8uI3e), iFZ5je3XFYKwkvcE5D.D35lls5iF(16172, iFZ5je3XFYKwkvcE5D.N06TeK0ao), hH6DVMBvgw3ANNRyBk6.hT7m8gyOr4);
					}
				}
				catch
				{
				}
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
	private struct _003CLoadConfiguration_003Ed__79 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public VideoPlayerViewModel _003C_003E4__this;

		public bool StartPlaying;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			VideoPlayerViewModel videoPlayerViewModel = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_012b;
				}
				PlaylistItemType playlistItemType = xllcp23egxiMKQFcV8K.D35lls5iF(videoPlayerViewModel, xllcp23egxiMKQFcV8K.b8PaT9Ox48);
				if (playlistItemType == PlaylistItemType.TvChannel)
				{
					gWjDbdmZEDgXehC8R2t.D35lls5iF(kNkAAf1oS8EBBquLcPe.D35lls5iF(videoPlayerViewModel, kNkAAf1oS8EBBquLcPe.DYxEH8uI3e), gWjDbdmZEDgXehC8R2t.MxkmjO1vRD).Clear();
					YQ4csVD2gHt33yWHvSL.D35lls5iF(cdbdBC3E9OhMyh2CjfD.D35lls5iF(videoPlayerViewModel, cdbdBC3E9OhMyh2CjfD.BKrmNFK3ok), Visibility.Collapsed, YQ4csVD2gHt33yWHvSL.C0qa4aRNlg);
					YQ4csVD2gHt33yWHvSL.D35lls5iF(cdbdBC3E9OhMyh2CjfD.D35lls5iF(videoPlayerViewModel, cdbdBC3E9OhMyh2CjfD.BKrmNFK3ok), Visibility.Collapsed, YQ4csVD2gHt33yWHvSL.nahaLtfpCi);
					if (hB8t9uC6c022dNynAqg.D35lls5iF(kNkAAf1oS8EBBquLcPe.D35lls5iF(videoPlayerViewModel, kNkAAf1oS8EBBquLcPe.DYxEH8uI3e), hB8t9uC6c022dNynAqg.lBMa3M77a0).Count == 0)
					{
						Task task = OYihPsCZ1OyLa5m4TD0.D35lls5iF(videoPlayerViewModel, OYihPsCZ1OyLa5m4TD0.antaEl8tGB);
						Action<Exception> action = null;
						bool flag = false;
						gBlEqv8jRKikCj2DMZp.D35lls5iF(task, ref action, ref flag, gBlEqv8jRKikCj2DMZp.pSp8ymt8Mu);
					}
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(kxYFveE4H3pBXluJ1GJ.D35lls5iF(videoPlayerViewModel, StartPlaying, kxYFveE4H3pBXluJ1GJ.X89aBIby5k), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
					if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_012b;
				}
				if (playlistItemType == PlaylistItemType.Movie)
				{
					YQ4csVD2gHt33yWHvSL.D35lls5iF(cdbdBC3E9OhMyh2CjfD.D35lls5iF(videoPlayerViewModel, cdbdBC3E9OhMyh2CjfD.BKrmNFK3ok), Visibility.Visible, YQ4csVD2gHt33yWHvSL.C0qa4aRNlg);
					YQ4csVD2gHt33yWHvSL.D35lls5iF(cdbdBC3E9OhMyh2CjfD.D35lls5iF(videoPlayerViewModel, cdbdBC3E9OhMyh2CjfD.BKrmNFK3ok), Visibility.Visible, YQ4csVD2gHt33yWHvSL.nahaLtfpCi);
					BbUsgb1HAFAD1uIhrpH.D35lls5iF(kNkAAf1oS8EBBquLcPe.D35lls5iF(videoPlayerViewModel, kNkAAf1oS8EBBquLcPe.DYxEH8uI3e), gWjDbdmZEDgXehC8R2t.D35lls5iF(kNkAAf1oS8EBBquLcPe.D35lls5iF(videoPlayerViewModel, kNkAAf1oS8EBBquLcPe.DYxEH8uI3e), gWjDbdmZEDgXehC8R2t.MxkmjO1vRD).FirstOrDefault(), BbUsgb1HAFAD1uIhrpH.Wuta09rJva);
				}
				goto end_IL_0015;
				IL_012b:
				oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
				end_IL_0015:;
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

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass80_0
	{
		public int SHpSRus4d0;

		public _003C_003Ec__DisplayClass80_0()
		{
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
			base._002Ector();
		}

		internal bool cB4SXdJUn9(VideoPlayerPlaylistItem x)
		{
			return WJbFtI6AObf2rNffLCy.D35lls5iF(x, WJbFtI6AObf2rNffLCy.T4uarxKlBV) == SHpSRus4d0;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLoadTvChannels_003Ed__80 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public VideoPlayerViewModel _003C_003E4__this;

		public bool StartPlaying;

		private TaskAwaiter<ResponseList<ChannelResponseDto>> _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			VideoPlayerViewModel videoPlayerViewModel = _003C_003E4__this;
			try
			{
				try
				{
					TaskAwaiter<ResponseList<ChannelResponseDto>> awaiter;
					if (num != 0)
					{
						ApiQuery<ChannelSearch, ChannelSort> apiQuery = new ApiQuery<ChannelSearch, ChannelSort>
						{
							Count = -1,
							Sort = J8Yr49ae48LPDydLJyE.D35lls5iF(kNkAAf1oS8EBBquLcPe.D35lls5iF(videoPlayerViewModel, kNkAAf1oS8EBBquLcPe.DYxEH8uI3e), J8Yr49ae48LPDydLJyE.d2vaGpVsvX),
							Order = pM83UjaR84HYRVNsL5f.D35lls5iF(kNkAAf1oS8EBBquLcPe.D35lls5iF(videoPlayerViewModel, kNkAAf1oS8EBBquLcPe.DYxEH8uI3e), pM83UjaR84HYRVNsL5f.D9KakQF51x)
						};
						ChannelSearch channelSearch = new ChannelSearch();
						hH6DVMBvgw3ANNRyBk6.D35lls5iF(channelSearch, pnvE8rm9NRTK7Tblimu.D35lls5iF(videoPlayerViewModel, pnvE8rm9NRTK7Tblimu.hEHavxAsjL), hH6DVMBvgw3ANNRyBk6.RRK6ishEFm);
						PackageReponseDto packageReponseDto = Yvn1Up49INfjZEB4hak.D35lls5iF(videoPlayerViewModel.e2dqZVRJ2Z, Yvn1Up49INfjZEB4hak.BEo4DRQpp2);
						wuXoja6xGA4YsTL6UdU.D35lls5iF(channelSearch, (packageReponseDto != null) ? new int?(WJbFtI6AObf2rNffLCy.D35lls5iF(packageReponseDto, WJbFtI6AObf2rNffLCy.frUaAm9Kci)) : ((int?)null), wuXoja6xGA4YsTL6UdU.gvea6e2Tqs);
						wxrXAGapPwbqHYAUjYV.D35lls5iF(channelSearch, ChannelType.TV, wxrXAGapPwbqHYAUjYV.DpCawCviZ2);
						CategoryResponseDto categoryResponseDto = FiOhPVaCHXLXNUl5Yfo.D35lls5iF(kNkAAf1oS8EBBquLcPe.D35lls5iF(videoPlayerViewModel, kNkAAf1oS8EBBquLcPe.DYxEH8uI3e), FiOhPVaCHXLXNUl5Yfo.JZTam2uQ2k);
						wuXoja6xGA4YsTL6UdU.D35lls5iF(channelSearch, (categoryResponseDto != null) ? V4VMaWmQYRpUqEIxujB.D35lls5iF(categoryResponseDto, V4VMaWmQYRpUqEIxujB.rPoaaBpdTR) : ((int?)null), wuXoja6xGA4YsTL6UdU.QntaINmy9f);
						apiQuery.Search = channelSearch;
						awaiter = DvNS3lad39MZYy86AET.D35lls5iF(videoPlayerViewModel.qvxqT7isTw, apiQuery, DvNS3lad39MZYy86AET.cL8aU2Q10h).GetAwaiter();
						if (!awaiter.IsCompleted)
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
						_003C_003Eu__1 = default(TaskAwaiter<ResponseList<ChannelResponseDto>>);
						num = (_003C_003E1__state = -1);
					}
					ResponseList<ChannelResponseDto> result = awaiter.GetResult();
					if (result != null && result.Status)
					{
						IEnumerator<ChannelResponseDto> enumerator = result.Data.Result.GetEnumerator();
						try
						{
							while (hjMnupQVVDlRZAYQJC.D35lls5iF(enumerator, hjMnupQVVDlRZAYQJC.QV1TFwytOj))
							{
								ChannelResponseDto current = enumerator.Current;
								VideoPlayerPlaylistItem videoPlayerPlaylistItem = new VideoPlayerPlaylistItem();
								CINH3eCBRcZO1fqc2r5.D35lls5iF(videoPlayerPlaylistItem, PlaylistItemType.TvChannel, CINH3eCBRcZO1fqc2r5.Gklatct9S2);
								m5sZxWmLHUhVHrJe8sC.D35lls5iF(videoPlayerPlaylistItem, pnvE8rm9NRTK7Tblimu.D35lls5iF(current, pnvE8rm9NRTK7Tblimu.hnlaVGRPT6), m5sZxWmLHUhVHrJe8sC.gKGa7Af3Kx);
								vQKA0r9sJ1kArsIHc16.D35lls5iF(videoPlayerPlaylistItem, WJbFtI6AObf2rNffLCy.D35lls5iF(current, WJbFtI6AObf2rNffLCy.hyPacPXw9c), vQKA0r9sJ1kArsIHc16.goRaMR7hWb);
								m5sZxWmLHUhVHrJe8sC.D35lls5iF(videoPlayerPlaylistItem, pnvE8rm9NRTK7Tblimu.D35lls5iF(current, pnvE8rm9NRTK7Tblimu.rhPaSybJPG), m5sZxWmLHUhVHrJe8sC.g0UaKgvgM5);
								hH6DVMBvgw3ANNRyBk6.D35lls5iF(videoPlayerPlaylistItem, pnvE8rm9NRTK7Tblimu.D35lls5iF(current, pnvE8rm9NRTK7Tblimu.rhPaSybJPG), hH6DVMBvgw3ANNRyBk6.s1Vw8Fi0h8);
								vQKA0r9sJ1kArsIHc16.D35lls5iF(videoPlayerPlaylistItem, WJbFtI6AObf2rNffLCy.D35lls5iF(current, WJbFtI6AObf2rNffLCy.qCoaNOcwbA), vQKA0r9sJ1kArsIHc16.CC5aOudWlX);
								jPB9Q5LdIM9wsuWV1q7.D35lls5iF(videoPlayerPlaylistItem, LsA6RHpKkbdnOn3fX60.D35lls5iF(current, LsA6RHpKkbdnOn3fX60.BpyauT9ebS), jPB9Q5LdIM9wsuWV1q7.zBkmYAib5p);
								m5sZxWmLHUhVHrJe8sC.D35lls5iF(videoPlayerPlaylistItem, pnvE8rm9NRTK7Tblimu.D35lls5iF(current, pnvE8rm9NRTK7Tblimu.NX1aPvwpkZ), m5sZxWmLHUhVHrJe8sC.j2SasXTb8u);
								VideoPlayerPlaylistItem item = videoPlayerPlaylistItem;
								gWjDbdmZEDgXehC8R2t.D35lls5iF(kNkAAf1oS8EBBquLcPe.D35lls5iF(videoPlayerViewModel, kNkAAf1oS8EBBquLcPe.DYxEH8uI3e), gWjDbdmZEDgXehC8R2t.MxkmjO1vRD).Add(item);
							}
						}
						finally
						{
							if (num < 0 && enumerator != null)
							{
								xLO56JniGyickVjO1Ot.D35lls5iF(enumerator, xLO56JniGyickVjO1Ot.ydbT2bsoH4);
							}
						}
						if (StartPlaying)
						{
							if (GmMLaTD7kV8rq88ZFvR.D35lls5iF(xrWtp71MaQsXtvtrqkf.D35lls5iF(Jr0pTQlovwB9pdID1EB.D35lls5iF(Jr0pTQlovwB9pdID1EB.CxrllgXtD4), xrWtp71MaQsXtvtrqkf.fxR1SMKb5A), iFZ5je3XFYKwkvcE5D.D35lls5iF(16466, iFZ5je3XFYKwkvcE5D.N06TeK0ao), GmMLaTD7kV8rq88ZFvR.VGG1KpDfXX))
							{
								_003C_003Ec__DisplayClass80_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass80_0();
								CS_0024_003C_003E8__locals2.SHpSRus4d0 = arHqIuLQE32UGutIac7.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(auEPOZ1NWYKXdU711jq.D35lls5iF(xrWtp71MaQsXtvtrqkf.D35lls5iF(Jr0pTQlovwB9pdID1EB.D35lls5iF(Jr0pTQlovwB9pdID1EB.CxrllgXtD4), xrWtp71MaQsXtvtrqkf.fxR1SMKb5A), iFZ5je3XFYKwkvcE5D.D35lls5iF(16466, iFZ5je3XFYKwkvcE5D.N06TeK0ao), auEPOZ1NWYKXdU711jq.Y1J1OKa53W), wq2usy8gNndpuTw5mR.ajcDe8nffb), arHqIuLQE32UGutIac7.Fa2LXljLFk);
								BbUsgb1HAFAD1uIhrpH.D35lls5iF(kNkAAf1oS8EBBquLcPe.D35lls5iF(videoPlayerViewModel, kNkAAf1oS8EBBquLcPe.DYxEH8uI3e), gWjDbdmZEDgXehC8R2t.D35lls5iF(kNkAAf1oS8EBBquLcPe.D35lls5iF(videoPlayerViewModel, kNkAAf1oS8EBBquLcPe.DYxEH8uI3e), gWjDbdmZEDgXehC8R2t.MxkmjO1vRD).FirstOrDefault((VideoPlayerPlaylistItem x) => WJbFtI6AObf2rNffLCy.D35lls5iF(x, WJbFtI6AObf2rNffLCy.T4uarxKlBV) == CS_0024_003C_003E8__locals2.SHpSRus4d0), BbUsgb1HAFAD1uIhrpH.Wuta09rJva);
							}
							if (NRXQg219ahcEpkUqugy.D35lls5iF(kNkAAf1oS8EBBquLcPe.D35lls5iF(videoPlayerViewModel, kNkAAf1oS8EBBquLcPe.DYxEH8uI3e), NRXQg219ahcEpkUqugy.J4U1D5ws5N) == null)
							{
								BbUsgb1HAFAD1uIhrpH.D35lls5iF(kNkAAf1oS8EBBquLcPe.D35lls5iF(videoPlayerViewModel, kNkAAf1oS8EBBquLcPe.DYxEH8uI3e), gWjDbdmZEDgXehC8R2t.D35lls5iF(kNkAAf1oS8EBBquLcPe.D35lls5iF(videoPlayerViewModel, kNkAAf1oS8EBBquLcPe.DYxEH8uI3e), gWjDbdmZEDgXehC8R2t.MxkmjO1vRD).FirstOrDefault(), BbUsgb1HAFAD1uIhrpH.Wuta09rJva);
							}
						}
					}
				}
				catch
				{
				}
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

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass81_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct MWR8c9E3AnHKfsBVoS : IAsyncStateMachine
		{
			public int w2VbxrmCCb;

			public AsyncTaskMethodBuilder MpTbyptcBF;

			public _003C_003Ec__DisplayClass81_0 JUYbp2vOhU;

			private TaskAwaiter v4MbiZlWEk;

			private void MoveNext()
			{
				int num = w2VbxrmCCb;
				_003C_003Ec__DisplayClass81_0 obj = JUYbp2vOhU;
				try
				{
					try
					{
						TaskAwaiter awaiter;
						if (num != 0)
						{
							awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(kxYFveE4H3pBXluJ1GJ.D35lls5iF(obj.H4rSEZOqvG, obj.lNjS9NHQT0, kxYFveE4H3pBXluJ1GJ.XgvcTkBflf), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
							if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
							{
								num = (w2VbxrmCCb = 0);
								v4MbiZlWEk = awaiter;
								MpTbyptcBF.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = v4MbiZlWEk;
							v4MbiZlWEk = default(TaskAwaiter);
							num = (w2VbxrmCCb = -1);
						}
						oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
					}
					catch (PROTVException)
					{
					}
				}
				catch (Exception ex2)
				{
					w2VbxrmCCb = -2;
					NNK1eXA7fWQ87oSUty7.D35lls5iF(ref MpTbyptcBF, ex2, NNK1eXA7fWQ87oSUty7.G3EAcW9Om7);
					return;
				}
				w2VbxrmCCb = -2;
				meFicnAMHIVtdhf671p.D35lls5iF(ref MpTbyptcBF, meFicnAMHIVtdhf671p.bsDASenQ5I);
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine P_0)
			{
				vxBFJcAKZoecNtbdqxt.D35lls5iF(ref MpTbyptcBF, P_0, vxBFJcAKZoecNtbdqxt.tuxANdhu18);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine P_0)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(P_0);
			}
		}

		public VideoPlayerViewModel H4rSEZOqvG;

		public bool lNjS9NHQT0;

		public _003C_003Ec__DisplayClass81_0()
		{
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
			base._002Ector();
		}

		[AsyncStateMachine(typeof(MWR8c9E3AnHKfsBVoS))]
		internal Task s1RSwm0BqJ()
		{
			MWR8c9E3AnHKfsBVoS stateMachine = default(MWR8c9E3AnHKfsBVoS);
			stateMachine.MpTbyptcBF = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
			stateMachine.JUYbp2vOhU = this;
			stateMachine.w2VbxrmCCb = -1;
			stateMachine.MpTbyptcBF.Start(ref stateMachine);
			return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine.MpTbyptcBF, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLoadAsync_003Ed__81 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public VideoPlayerViewModel _003C_003E4__this;

		public bool StartPlaying;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			VideoPlayerViewModel videoPlayerViewModel = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					_003C_003Ec__DisplayClass81_0 CS_0024_003C_003E8__locals3 = new _003C_003Ec__DisplayClass81_0();
					CS_0024_003C_003E8__locals3.H4rSEZOqvG = _003C_003E4__this;
					CS_0024_003C_003E8__locals3.lNjS9NHQT0 = StartPlaying;
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(W7S2sip6SDieZFVsNbd.D35lls5iF(videoPlayerViewModel, Expression.Lambda<Func<bool>>(OWBKr5pvc5MWsK1OMtR.D35lls5iF(o4bYL4peNeC2wWb8yjx.D35lls5iF(videoPlayerViewModel, sjYxHO8OWlc6X80hFj7.D35lls5iF(typeof(VideoPlayerViewModel).TypeHandle, sjYxHO8OWlc6X80hFj7.uWZ8ugU7r5), o4bYL4peNeC2wWb8yjx.oVdpGKjy2x), (MethodInfo)f5q427pRQZnrEKPy4Ws.D35lls5iF((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, f5q427pRQZnrEKPy4Ws.Bo9pk3m4k7), OWBKr5pvc5MWsK1OMtR.fZIpAAdi1v), Array.Empty<ParameterExpression>()), [AsyncStateMachine(typeof(_003C_003Ec__DisplayClass81_0.MWR8c9E3AnHKfsBVoS))] () =>
					{
						_003C_003Ec__DisplayClass81_0.MWR8c9E3AnHKfsBVoS stateMachine = default(_003C_003Ec__DisplayClass81_0.MWR8c9E3AnHKfsBVoS);
						stateMachine.MpTbyptcBF = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
						stateMachine.JUYbp2vOhU = CS_0024_003C_003E8__locals3;
						stateMachine.w2VbxrmCCb = -1;
						stateMachine.MpTbyptcBF.Start(ref stateMachine);
						return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine.MpTbyptcBF, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
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

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass82_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct mjZPLY9WHbqYICEo0Q : IAsyncStateMachine
		{
			public int xcsb3Q0MnN;

			public AsyncTaskMethodBuilder BwNbmyWniy;

			public _003C_003Ec__DisplayClass82_0 bffbX6GeUw;

			private TaskAwaiter<Response<IEnumerable<MovieResponseDto>>> TLibRwsQm5;

			private void MoveNext()
			{
				int num = xcsb3Q0MnN;
				_003C_003Ec__DisplayClass82_0 obj = bffbX6GeUw;
				try
				{
					try
					{
						TaskAwaiter<Response<IEnumerable<MovieResponseDto>>> awaiter;
						if (num != 0)
						{
							gWjDbdmZEDgXehC8R2t.D35lls5iF(kNkAAf1oS8EBBquLcPe.D35lls5iF(obj.iFbSONh6tW, kNkAAf1oS8EBBquLcPe.DYxEH8uI3e), gWjDbdmZEDgXehC8R2t.MxkmjO1vRD).Clear();
							ObservableCollection<VideoPlayerPlaylistItem> observableCollection = gWjDbdmZEDgXehC8R2t.D35lls5iF(kNkAAf1oS8EBBquLcPe.D35lls5iF(obj.iFbSONh6tW, kNkAAf1oS8EBBquLcPe.DYxEH8uI3e), gWjDbdmZEDgXehC8R2t.MxkmjO1vRD);
							VideoPlayerPlaylistItem videoPlayerPlaylistItem = new VideoPlayerPlaylistItem();
							CINH3eCBRcZO1fqc2r5.D35lls5iF(videoPlayerPlaylistItem, PlaylistItemType.Movie, CINH3eCBRcZO1fqc2r5.Gklatct9S2);
							m5sZxWmLHUhVHrJe8sC.D35lls5iF(videoPlayerPlaylistItem, eVlRnEIaHT0dqvCx0Kx.D35lls5iF(obj.OgnSrTwRyF, eVlRnEIaHT0dqvCx0Kx.ysQc4nFOds), m5sZxWmLHUhVHrJe8sC.gKGa7Af3Kx);
							hH6DVMBvgw3ANNRyBk6.D35lls5iF(videoPlayerPlaylistItem, QQLie3eYkZwbFFm9Jjw.D35lls5iF(obj.OgnSrTwRyF, QQLie3eYkZwbFFm9Jjw.T8RwSgEfbh), hH6DVMBvgw3ANNRyBk6.s1Vw8Fi0h8);
							vQKA0r9sJ1kArsIHc16.D35lls5iF(videoPlayerPlaylistItem, m9MGZR7k2RmVqYXYS5.D35lls5iF(obj.OgnSrTwRyF, m9MGZR7k2RmVqYXYS5.j871CQO7pP), vQKA0r9sJ1kArsIHc16.CC5aOudWlX);
							wuXoja6xGA4YsTL6UdU.D35lls5iF(videoPlayerPlaylistItem, V4VMaWmQYRpUqEIxujB.D35lls5iF(obj.OgnSrTwRyF, V4VMaWmQYRpUqEIxujB.NRbcLXoBgx), wuXoja6xGA4YsTL6UdU.LwFcE8EaHA);
							HwHG7ZaQ7c45wMQBnlK.D35lls5iF(videoPlayerPlaylistItem, mN4twN37Cb4EtEpQsEk.D35lls5iF(obj.OgnSrTwRyF, mN4twN37Cb4EtEpQsEk.v1FRHG4RTO), HwHG7ZaQ7c45wMQBnlK.YvYaXtGpdv);
							m5sZxWmLHUhVHrJe8sC.D35lls5iF(videoPlayerPlaylistItem, "", m5sZxWmLHUhVHrJe8sC.g0UaKgvgM5);
							jPB9Q5LdIM9wsuWV1q7.D35lls5iF(videoPlayerPlaylistItem, LsA6RHpKkbdnOn3fX60.D35lls5iF(obj.OgnSrTwRyF, LsA6RHpKkbdnOn3fX60.LyJcBYhKiS), jPB9Q5LdIM9wsuWV1q7.zBkmYAib5p);
							m5sZxWmLHUhVHrJe8sC.D35lls5iF(videoPlayerPlaylistItem, eVlRnEIaHT0dqvCx0Kx.D35lls5iF(mj3KqGafEtImrSw4deR.D35lls5iF(obj.pZgSHlLAdv, mj3KqGafEtImrSw4deR.u9nIZ7kA1i).FirstOrDefault(), eVlRnEIaHT0dqvCx0Kx.yCiIjncSix), m5sZxWmLHUhVHrJe8sC.j2SasXTb8u);
							observableCollection.Add(videoPlayerPlaylistItem);
							awaiter = H0KLsYc0W73WlN9d3GH.D35lls5iF(obj.iFbSONh6tW.d1kqG0pDgD, m9MGZR7k2RmVqYXYS5.D35lls5iF(obj.OgnSrTwRyF, m9MGZR7k2RmVqYXYS5.j871CQO7pP), H0KLsYc0W73WlN9d3GH.tiscrcqxVw).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = (xcsb3Q0MnN = 0);
								TLibRwsQm5 = awaiter;
								BwNbmyWniy.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = TLibRwsQm5;
							TLibRwsQm5 = default(TaskAwaiter<Response<IEnumerable<MovieResponseDto>>>);
							num = (xcsb3Q0MnN = -1);
						}
						IEnumerator<MovieResponseDto> enumerator = (awaiter.GetResult()?.Data).GetEnumerator();
						try
						{
							while (hjMnupQVVDlRZAYQJC.D35lls5iF(enumerator, hjMnupQVVDlRZAYQJC.QV1TFwytOj))
							{
								MovieResponseDto current = enumerator.Current;
								ObservableCollection<VideoPlayerPlaylistItem> observableCollection2 = gWjDbdmZEDgXehC8R2t.D35lls5iF(kNkAAf1oS8EBBquLcPe.D35lls5iF(obj.iFbSONh6tW, kNkAAf1oS8EBBquLcPe.DYxEH8uI3e), gWjDbdmZEDgXehC8R2t.MxkmjO1vRD);
								VideoPlayerPlaylistItem videoPlayerPlaylistItem2 = new VideoPlayerPlaylistItem();
								CINH3eCBRcZO1fqc2r5.D35lls5iF(videoPlayerPlaylistItem2, PlaylistItemType.Movie, CINH3eCBRcZO1fqc2r5.Gklatct9S2);
								m5sZxWmLHUhVHrJe8sC.D35lls5iF(videoPlayerPlaylistItem2, eVlRnEIaHT0dqvCx0Kx.D35lls5iF(current, eVlRnEIaHT0dqvCx0Kx.ysQc4nFOds), m5sZxWmLHUhVHrJe8sC.gKGa7Af3Kx);
								hH6DVMBvgw3ANNRyBk6.D35lls5iF(videoPlayerPlaylistItem2, QQLie3eYkZwbFFm9Jjw.D35lls5iF(current, QQLie3eYkZwbFFm9Jjw.T8RwSgEfbh), hH6DVMBvgw3ANNRyBk6.s1Vw8Fi0h8);
								vQKA0r9sJ1kArsIHc16.D35lls5iF(videoPlayerPlaylistItem2, m9MGZR7k2RmVqYXYS5.D35lls5iF(current, m9MGZR7k2RmVqYXYS5.j871CQO7pP), vQKA0r9sJ1kArsIHc16.CC5aOudWlX);
								kyPBxcceXsmsMUndAmF.D35lls5iF(videoPlayerPlaylistItem2, WJbFtI6AObf2rNffLCy.D35lls5iF(current, WJbFtI6AObf2rNffLCy.VKfC3dMTo1), kyPBxcceXsmsMUndAmF.QIRcGaQv4n);
								t3nlu3cRyQyLCwtJsvy.D35lls5iF(videoPlayerPlaylistItem2, uN1DaxTm1XRIu0SSp7h.D35lls5iF(current, uN1DaxTm1XRIu0SSp7h.r7aCnH9Gqo), t3nlu3cRyQyLCwtJsvy.paYckkM750);
								wuXoja6xGA4YsTL6UdU.D35lls5iF(videoPlayerPlaylistItem2, V4VMaWmQYRpUqEIxujB.D35lls5iF(current, V4VMaWmQYRpUqEIxujB.NRbcLXoBgx), wuXoja6xGA4YsTL6UdU.LwFcE8EaHA);
								HwHG7ZaQ7c45wMQBnlK.D35lls5iF(videoPlayerPlaylistItem2, mN4twN37Cb4EtEpQsEk.D35lls5iF(current, mN4twN37Cb4EtEpQsEk.v1FRHG4RTO), HwHG7ZaQ7c45wMQBnlK.YvYaXtGpdv);
								m5sZxWmLHUhVHrJe8sC.D35lls5iF(videoPlayerPlaylistItem2, "", m5sZxWmLHUhVHrJe8sC.g0UaKgvgM5);
								jPB9Q5LdIM9wsuWV1q7.D35lls5iF(videoPlayerPlaylistItem2, LsA6RHpKkbdnOn3fX60.D35lls5iF(current, LsA6RHpKkbdnOn3fX60.LyJcBYhKiS), jPB9Q5LdIM9wsuWV1q7.zBkmYAib5p);
								IEnumerable<LinkResponseDto> enumerable = mj3KqGafEtImrSw4deR.D35lls5iF(current, mj3KqGafEtImrSw4deR.X97cvGBY1G);
								object obj2;
								if (enumerable == null)
								{
									obj2 = null;
								}
								else
								{
									LinkResponseDto? linkResponseDto = enumerable.FirstOrDefault();
									obj2 = ((linkResponseDto != null) ? pnvE8rm9NRTK7Tblimu.D35lls5iF(linkResponseDto, pnvE8rm9NRTK7Tblimu.mONa2V216Z) : null);
								}
								m5sZxWmLHUhVHrJe8sC.D35lls5iF(videoPlayerPlaylistItem2, (string)obj2, m5sZxWmLHUhVHrJe8sC.j2SasXTb8u);
								observableCollection2.Add(videoPlayerPlaylistItem2);
							}
						}
						finally
						{
							if (num < 0 && enumerator != null)
							{
								xLO56JniGyickVjO1Ot.D35lls5iF(enumerator, xLO56JniGyickVjO1Ot.ydbT2bsoH4);
							}
						}
					}
					catch (PROTVException)
					{
					}
				}
				catch (Exception ex2)
				{
					xcsb3Q0MnN = -2;
					NNK1eXA7fWQ87oSUty7.D35lls5iF(ref BwNbmyWniy, ex2, NNK1eXA7fWQ87oSUty7.G3EAcW9Om7);
					return;
				}
				xcsb3Q0MnN = -2;
				meFicnAMHIVtdhf671p.D35lls5iF(ref BwNbmyWniy, meFicnAMHIVtdhf671p.bsDASenQ5I);
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine P_0)
			{
				vxBFJcAKZoecNtbdqxt.D35lls5iF(ref BwNbmyWniy, P_0, vxBFJcAKZoecNtbdqxt.tuxANdhu18);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine P_0)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(P_0);
			}
		}

		public VideoPlayerViewModel iFbSONh6tW;

		public MovieResponseDto OgnSrTwRyF;

		public RentResponseDto pZgSHlLAdv;

		public _003C_003Ec__DisplayClass82_0()
		{
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
			base._002Ector();
		}

		[AsyncStateMachine(typeof(mjZPLY9WHbqYICEo0Q))]
		internal Task mwrSe9jIoj()
		{
			mjZPLY9WHbqYICEo0Q stateMachine = default(mjZPLY9WHbqYICEo0Q);
			stateMachine.BwNbmyWniy = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
			stateMachine.bffbX6GeUw = this;
			stateMachine.xcsb3Q0MnN = -1;
			stateMachine.BwNbmyWniy.Start(ref stateMachine);
			return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine.BwNbmyWniy, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLoadAsync_003Ed__82 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public VideoPlayerViewModel _003C_003E4__this;

		public MovieResponseDto dto;

		public RentResponseDto rent;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			VideoPlayerViewModel videoPlayerViewModel = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					_003C_003Ec__DisplayClass82_0 CS_0024_003C_003E8__locals4 = new _003C_003Ec__DisplayClass82_0();
					CS_0024_003C_003E8__locals4.iFbSONh6tW = _003C_003E4__this;
					CS_0024_003C_003E8__locals4.OgnSrTwRyF = dto;
					CS_0024_003C_003E8__locals4.pZgSHlLAdv = rent;
					awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(W7S2sip6SDieZFVsNbd.D35lls5iF(videoPlayerViewModel, Expression.Lambda<Func<bool>>(OWBKr5pvc5MWsK1OMtR.D35lls5iF(o4bYL4peNeC2wWb8yjx.D35lls5iF(videoPlayerViewModel, sjYxHO8OWlc6X80hFj7.D35lls5iF(typeof(VideoPlayerViewModel).TypeHandle, sjYxHO8OWlc6X80hFj7.uWZ8ugU7r5), o4bYL4peNeC2wWb8yjx.oVdpGKjy2x), (MethodInfo)f5q427pRQZnrEKPy4Ws.D35lls5iF((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, f5q427pRQZnrEKPy4Ws.Bo9pk3m4k7), OWBKr5pvc5MWsK1OMtR.fZIpAAdi1v), Array.Empty<ParameterExpression>()), [AsyncStateMachine(typeof(_003C_003Ec__DisplayClass82_0.mjZPLY9WHbqYICEo0Q))] () =>
					{
						_003C_003Ec__DisplayClass82_0.mjZPLY9WHbqYICEo0Q stateMachine = default(_003C_003Ec__DisplayClass82_0.mjZPLY9WHbqYICEo0Q);
						stateMachine.BwNbmyWniy = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
						stateMachine.bffbX6GeUw = CS_0024_003C_003E8__locals4;
						stateMachine.xcsb3Q0MnN = -1;
						stateMachine.BwNbmyWniy.Start(ref stateMachine);
						return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine.BwNbmyWniy, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
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

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass84_0
	{
		public bool QN7Sg6G4WG;

		public _003C_003Ec__DisplayClass84_0()
		{
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
			base._002Ector();
		}

		internal bool wyPSoa4uWf(bool isConfirmed)
		{
			if (!isConfirmed)
			{
				QN7Sg6G4WG = false;
			}
			return true;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnOpenCommandExcuteAsync_003Ed__84 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public VideoPlayerPlaylistItem obj;

		public VideoPlayerViewModel _003C_003E4__this;

		private Response<MovieResponseDto> _003Cmvoie_003E5__2;

		private TaskAwaiter<Response<MovieResponseDto>> _003C_003Eu__1;

		private TaskAwaiter<Response<RentResponseDto>> _003C_003Eu__2;

		private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter _003C_003Eu__3;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			VideoPlayerViewModel videoPlayerViewModel = _003C_003E4__this;
			try
			{
				if ((uint)num <= 2u || this.obj != null)
				{
					try
					{
						TaskAwaiter<Response<MovieResponseDto>> awaiter3;
						TaskAwaiter<Response<RentResponseDto>> awaiter2;
						ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter awaiter;
						Response<RentResponseDto> result;
						VideoPlayerPlaylistItem videoPlayerPlaylistItem;
						Response<MovieResponseDto> response;
						object value;
						VideoPlayerPlaylistItem videoPlayerPlaylistItem2;
						object obj2;
						string text;
						Response<MovieResponseDto> result2;
						switch (num)
						{
						default:
							if (xllcp23egxiMKQFcV8K.D35lls5iF(this.obj, xllcp23egxiMKQFcV8K.w8jklxyeAB) == PlaylistItemType.TvChannel)
							{
								if (GmMLaTD7kV8rq88ZFvR.D35lls5iF(xrWtp71MaQsXtvtrqkf.D35lls5iF(Jr0pTQlovwB9pdID1EB.D35lls5iF(Jr0pTQlovwB9pdID1EB.CxrllgXtD4), xrWtp71MaQsXtvtrqkf.fxR1SMKb5A), iFZ5je3XFYKwkvcE5D.D35lls5iF(16466, iFZ5je3XFYKwkvcE5D.N06TeK0ao), GmMLaTD7kV8rq88ZFvR.VGG1KpDfXX))
								{
									EyxbpBGMcaXD02sIi7w.D35lls5iF(xrWtp71MaQsXtvtrqkf.D35lls5iF(Jr0pTQlovwB9pdID1EB.D35lls5iF(Jr0pTQlovwB9pdID1EB.CxrllgXtD4), xrWtp71MaQsXtvtrqkf.fxR1SMKb5A), iFZ5je3XFYKwkvcE5D.D35lls5iF(16466, iFZ5je3XFYKwkvcE5D.N06TeK0ao), WJbFtI6AObf2rNffLCy.D35lls5iF(this.obj, WJbFtI6AObf2rNffLCy.T4uarxKlBV), EyxbpBGMcaXD02sIi7w.z9EGSdF6KF);
								}
								else
								{
									EyxbpBGMcaXD02sIi7w.D35lls5iF(xrWtp71MaQsXtvtrqkf.D35lls5iF(Jr0pTQlovwB9pdID1EB.D35lls5iF(Jr0pTQlovwB9pdID1EB.CxrllgXtD4), xrWtp71MaQsXtvtrqkf.fxR1SMKb5A), iFZ5je3XFYKwkvcE5D.D35lls5iF(16466, iFZ5je3XFYKwkvcE5D.N06TeK0ao), WJbFtI6AObf2rNffLCy.D35lls5iF(this.obj, WJbFtI6AObf2rNffLCy.T4uarxKlBV), EyxbpBGMcaXD02sIi7w.y9uGuhNJgc);
								}
							}
							if (xllcp23egxiMKQFcV8K.D35lls5iF(this.obj, xllcp23egxiMKQFcV8K.w8jklxyeAB) == PlaylistItemType.Movie && pnvE8rm9NRTK7Tblimu.D35lls5iF(this.obj, pnvE8rm9NRTK7Tblimu.LAaahyfjjF) == null)
							{
								_003C_003Ec__DisplayClass84_0 CS_0024_003C_003E8__locals3 = new _003C_003Ec__DisplayClass84_0();
								CS_0024_003C_003E8__locals3.QN7Sg6G4WG = true;
								if (uN1DaxTm1XRIu0SSp7h.D35lls5iF(this.obj, uN1DaxTm1XRIu0SSp7h.IDYaxMhvGJ) == MediaCost.Paid)
								{
									string[] obj = new string[5]
									{
										iFZ5je3XFYKwkvcE5D.D35lls5iF(16076, iFZ5je3XFYKwkvcE5D.N06TeK0ao),
										pnvE8rm9NRTK7Tblimu.D35lls5iF(this.obj, pnvE8rm9NRTK7Tblimu.l04aYM6lDh),
										iFZ5je3XFYKwkvcE5D.D35lls5iF(16140, iFZ5je3XFYKwkvcE5D.N06TeK0ao),
										null,
										null
									};
									int num2 = WJbFtI6AObf2rNffLCy.D35lls5iF(this.obj, WJbFtI6AObf2rNffLCy.hKHagMCDU6);
									obj[3] = E1oqfbTdQ1YrEeaxoPg.D35lls5iF(ref num2, E1oqfbTdQ1YrEeaxoPg.beYTUkKTth);
									obj[4] = iFZ5je3XFYKwkvcE5D.D35lls5iF(16154, iFZ5je3XFYKwkvcE5D.N06TeK0ao);
									aOsAijCTnvLPVytuecl.D35lls5iF(EKUvcf6BZG4YrVDIJu7.D35lls5iF(obj, EKUvcf6BZG4YrVDIJu7.lI660m0xwr), delegate(bool isConfirmed)
									{
										if (!isConfirmed)
										{
											CS_0024_003C_003E8__locals3.QN7Sg6G4WG = false;
										}
										return true;
									}, "", aOsAijCTnvLPVytuecl.Qt4C45JP4A);
								}
								if (CS_0024_003C_003E8__locals3.QN7Sg6G4WG)
								{
									awaiter3 = a1dd23Co8uRUg80NYqF.D35lls5iF(videoPlayerViewModel.d1kqG0pDgD, m9MGZR7k2RmVqYXYS5.D35lls5iF(this.obj, m9MGZR7k2RmVqYXYS5.kIl3VviojT), a1dd23Co8uRUg80NYqF.GhoClwhL5B).GetAwaiter();
									if (!awaiter3.IsCompleted)
									{
										num = (_003C_003E1__state = 0);
										_003C_003Eu__1 = awaiter3;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
										return;
									}
									goto IL_026c;
								}
							}
							goto IL_03a4;
						case 0:
							awaiter3 = _003C_003Eu__1;
							_003C_003Eu__1 = default(TaskAwaiter<Response<MovieResponseDto>>);
							num = (_003C_003E1__state = -1);
							goto IL_026c;
						case 1:
							awaiter2 = _003C_003Eu__2;
							_003C_003Eu__2 = default(TaskAwaiter<Response<RentResponseDto>>);
							num = (_003C_003E1__state = -1);
							goto IL_02f1;
						case 2:
							{
								awaiter = _003C_003Eu__3;
								_003C_003Eu__3 = default(ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter);
								num = (_003C_003E1__state = -1);
								break;
							}
							IL_02f1:
							result = awaiter2.GetResult();
							videoPlayerPlaylistItem = this.obj;
							response = _003Cmvoie_003E5__2;
							if (response == null)
							{
								value = null;
							}
							else
							{
								MovieResponseDto data = response.Data;
								value = ((data != null) ? mN4twN37Cb4EtEpQsEk.D35lls5iF(data, mN4twN37Cb4EtEpQsEk.BBSai2pkTJ) : null);
							}
							HwHG7ZaQ7c45wMQBnlK.D35lls5iF(videoPlayerPlaylistItem, (IEnumerable<SubtitleResponseDto>)value, HwHG7ZaQ7c45wMQBnlK.YvYaXtGpdv);
							videoPlayerPlaylistItem2 = this.obj;
							if (result == null)
							{
								obj2 = null;
							}
							else
							{
								RentResponseDto data2 = result.Data;
								if (data2 == null)
								{
									obj2 = null;
								}
								else
								{
									IEnumerable<LinkResponseDto> enumerable = mj3KqGafEtImrSw4deR.D35lls5iF(data2, mj3KqGafEtImrSw4deR.Fx4aF2KXGD);
									if (enumerable == null)
									{
										obj2 = null;
									}
									else
									{
										LinkResponseDto? linkResponseDto = enumerable.FirstOrDefault();
										obj2 = ((linkResponseDto != null) ? pnvE8rm9NRTK7Tblimu.D35lls5iF(linkResponseDto, pnvE8rm9NRTK7Tblimu.mONa2V216Z) : null);
									}
								}
							}
							m5sZxWmLHUhVHrJe8sC.D35lls5iF(videoPlayerPlaylistItem2, (string)obj2, m5sZxWmLHUhVHrJe8sC.j2SasXTb8u);
							_003Cmvoie_003E5__2 = null;
							goto IL_03a4;
							IL_03a4:
							text = vr2NVdDHkMwed7KwMIr.D35lls5iF(pnvE8rm9NRTK7Tblimu.D35lls5iF(new Uri(UwSEfC4rh9eVlFenwI.D35lls5iF(pnvE8rm9NRTK7Tblimu.D35lls5iF(this.obj, pnvE8rm9NRTK7Tblimu.LAaahyfjjF), pnvE8rm9NRTK7Tblimu.D35lls5iF(this.obj, pnvE8rm9NRTK7Tblimu.SH0aZU9rMD), UwSEfC4rh9eVlFenwI.J6G3NC9nSO)), pnvE8rm9NRTK7Tblimu.fnLajxXY1u), vr2NVdDHkMwed7KwMIr.LtEayFwwxZ);
							text = qkk1pmaqjfrxm6HMLRO.D35lls5iF(qkk1pmaqjfrxm6HMLRO.D35lls5iF(text, iFZ5je3XFYKwkvcE5D.D35lls5iF(16492, iFZ5je3XFYKwkvcE5D.N06TeK0ao), iFZ5je3XFYKwkvcE5D.D35lls5iF(16498, iFZ5je3XFYKwkvcE5D.N06TeK0ao), qkk1pmaqjfrxm6HMLRO.FEAaJveLhR), iFZ5je3XFYKwkvcE5D.D35lls5iF(16508, iFZ5je3XFYKwkvcE5D.N06TeK0ao), iFZ5je3XFYKwkvcE5D.D35lls5iF(16514, iFZ5je3XFYKwkvcE5D.N06TeK0ao), qkk1pmaqjfrxm6HMLRO.FEAaJveLhR);
							awaiter = mchHD5pbvoLh6YJmlai.D35lls5iF(srgd79T1FovS2Zr1sHa.D35lls5iF(videoPlayerViewModel, srgd79T1FovS2Zr1sHa.R5ZmucJ4Yd), new Uri(text), mchHD5pbvoLh6YJmlai.ahJpW0oay7).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = (_003C_003E1__state = 2);
								_003C_003Eu__3 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							break;
							IL_026c:
							result2 = awaiter3.GetResult();
							_003Cmvoie_003E5__2 = result2;
							awaiter2 = sYW4HcCLj53QDe4wG8O.D35lls5iF(videoPlayerViewModel.d1kqG0pDgD, m9MGZR7k2RmVqYXYS5.D35lls5iF(this.obj, m9MGZR7k2RmVqYXYS5.kIl3VviojT), sYW4HcCLj53QDe4wG8O.UnSCEYLQ73).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num = (_003C_003E1__state = 1);
								_003C_003Eu__2 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
							goto IL_02f1;
						}
						awaiter.GetResult();
					}
					catch
					{
					}
				}
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

	private bool jnhqqtSyst;

	private bool zHxqIOZXCw;

	private bool LadqVMkGrI;

	private int ptYqaLejM4;

	private readonly IAppService xBYq0igajR;

	private readonly IMovieService d1kqG0pDgD;

	private readonly ILiveService qvxqT7isTw;

	private readonly IStoreContext e2dqZVRJ2Z;

	private MediaElement HrCqtl2Ifs;

	private VideoPlayerPlaylist NuIqS7f0yY;

	private VideoPlayerController advqf2ebqW;

	private VideoPlayerSettings eR0qKx0aHb;

	[CompilerGenerated]
	private PlaylistItemType qh9qkvYZP0;

	[CompilerGenerated]
	private string XRsq8PHl15;

	[CompilerGenerated]
	private ICommand QRSqQrjeLm;

	[CompilerGenerated]
	private ICommand pinqn1FeaS;

	[CompilerGenerated]
	private ICommand C18qbshypR;

	[CompilerGenerated]
	private ICommand hthq7dGiR2;

	[CompilerGenerated]
	private ICommand OQXq5vVOJs;

	[CompilerGenerated]
	private ICommand yFTqugvqWZ;

	public PlaylistItemType PlaylistItemType
	{
		[CompilerGenerated]
		get
		{
			return qh9qkvYZP0;
		}
		[CompilerGenerated]
		set
		{
			qh9qkvYZP0 = value;
		}
	}

	public VideoPlayerPlaylist VideoPlayerPlaylist
	{
		get
		{
			return NuIqS7f0yY;
		}
		set
		{
			SetProperty(ref NuIqS7f0yY, value, iFZ5je3XFYKwkvcE5D.D35lls5iF(10716, iFZ5je3XFYKwkvcE5D.N06TeK0ao));
		}
	}

	public VideoPlayerSettings VideoPlayerSettings
	{
		get
		{
			return eR0qKx0aHb;
		}
		set
		{
			SetProperty(ref eR0qKx0aHb, value, iFZ5je3XFYKwkvcE5D.D35lls5iF(10758, iFZ5je3XFYKwkvcE5D.N06TeK0ao));
		}
	}

	public VideoPlayerController Controller
	{
		get
		{
			return advqf2ebqW;
		}
		set
		{
			SetProperty(ref advqf2ebqW, value, iFZ5je3XFYKwkvcE5D.D35lls5iF(10800, iFZ5je3XFYKwkvcE5D.N06TeK0ao));
		}
	}

	public MediaElement MediaElement
	{
		get
		{
			return HrCqtl2Ifs;
		}
		set
		{
			_003C_003Ec__DisplayClass27_0 CS_0024_003C_003E8__locals6 = new _003C_003Ec__DisplayClass27_0();
			CS_0024_003C_003E8__locals6.sAUSAysyAW = value;
			CS_0024_003C_003E8__locals6.pygSN49AJ9 = this;
			SetProperty(ref HrCqtl2Ifs, CS_0024_003C_003E8__locals6.sAUSAysyAW, iFZ5je3XFYKwkvcE5D.D35lls5iF(10824, iFZ5je3XFYKwkvcE5D.N06TeK0ao), null, delegate
			{
				if (CS_0024_003C_003E8__locals6.sAUSAysyAW != null)
				{
					fp757nBYjo8889efKFJ.D35lls5iF(cdbdBC3E9OhMyh2CjfD.D35lls5iF(CS_0024_003C_003E8__locals6.pygSN49AJ9, cdbdBC3E9OhMyh2CjfD.BKrmNFK3ok), fp757nBYjo8889efKFJ.we7mOKxb1S);
					fp757nBYjo8889efKFJ.D35lls5iF(kNkAAf1oS8EBBquLcPe.D35lls5iF(CS_0024_003C_003E8__locals6.pygSN49AJ9, kNkAAf1oS8EBBquLcPe.DYxEH8uI3e), fp757nBYjo8889efKFJ.we7mOKxb1S);
				}
			});
		}
	}

	public bool IsPropertiesPanelOpen
	{
		get
		{
			return zHxqIOZXCw;
		}
		set
		{
			zHxqIOZXCw = value;
			qni3xrDkAJ3vF35eMav.D35lls5iF(this, iFZ5je3XFYKwkvcE5D.D35lls5iF(10852, iFZ5je3XFYKwkvcE5D.N06TeK0ao), qni3xrDkAJ3vF35eMav.QN6DuDtCWO);
		}
	}

	public bool IsSettingPanelOpen
	{
		get
		{
			return LadqVMkGrI;
		}
		set
		{
			LadqVMkGrI = value;
			qni3xrDkAJ3vF35eMav.D35lls5iF(this, iFZ5je3XFYKwkvcE5D.D35lls5iF(10898, iFZ5je3XFYKwkvcE5D.N06TeK0ao), qni3xrDkAJ3vF35eMav.QN6DuDtCWO);
		}
	}

	public bool IsPlaylistPanelOpen
	{
		get
		{
			return jnhqqtSyst;
		}
		set
		{
			jnhqqtSyst = value;
			qni3xrDkAJ3vF35eMav.D35lls5iF(this, iFZ5je3XFYKwkvcE5D.D35lls5iF(10938, iFZ5je3XFYKwkvcE5D.N06TeK0ao), qni3xrDkAJ3vF35eMav.QN6DuDtCWO);
		}
	}

	public int FontSelectedindex
	{
		get
		{
			return ptYqaLejM4;
		}
		set
		{
			_003C_003Ec__DisplayClass39_0 CS_0024_003C_003E8__locals9 = new _003C_003Ec__DisplayClass39_0();
			CS_0024_003C_003E8__locals9.y0QSChxjXe = value;
			CS_0024_003C_003E8__locals9.IJySYmxEBQ = this;
			SetProperty(ref ptYqaLejM4, CS_0024_003C_003E8__locals9.y0QSChxjXe, iFZ5je3XFYKwkvcE5D.D35lls5iF(10980, iFZ5je3XFYKwkvcE5D.N06TeK0ao), null, delegate
			{
				if (CS_0024_003C_003E8__locals9.y0QSChxjXe == 0)
				{
					wV1i6CmPpOFoyWU06ru.D35lls5iF(srgd79T1FovS2Zr1sHa.D35lls5iF(CS_0024_003C_003E8__locals9.IJySYmxEBQ, srgd79T1FovS2Zr1sHa.R5ZmucJ4Yd), 60.0, wV1i6CmPpOFoyWU06ru.OanmsOGBOd);
				}
				else if (CS_0024_003C_003E8__locals9.y0QSChxjXe == 1)
				{
					wV1i6CmPpOFoyWU06ru.D35lls5iF(srgd79T1FovS2Zr1sHa.D35lls5iF(CS_0024_003C_003E8__locals9.IJySYmxEBQ, srgd79T1FovS2Zr1sHa.R5ZmucJ4Yd), 50.0, wV1i6CmPpOFoyWU06ru.OanmsOGBOd);
				}
				else if (CS_0024_003C_003E8__locals9.y0QSChxjXe == 2)
				{
					wV1i6CmPpOFoyWU06ru.D35lls5iF(srgd79T1FovS2Zr1sHa.D35lls5iF(CS_0024_003C_003E8__locals9.IJySYmxEBQ, srgd79T1FovS2Zr1sHa.R5ZmucJ4Yd), 40.0, wV1i6CmPpOFoyWU06ru.OanmsOGBOd);
				}
			});
		}
	}

	public string Search
	{
		[CompilerGenerated]
		get
		{
			return XRsq8PHl15;
		}
		[CompilerGenerated]
		set
		{
			XRsq8PHl15 = value;
		}
	}

	public ICommand AddToFavorite
	{
		[CompilerGenerated]
		get
		{
			return QRSqQrjeLm;
		}
		[CompilerGenerated]
		set
		{
			QRSqQrjeLm = value;
		}
	}

	public ICommand LikeCommand
	{
		[CompilerGenerated]
		get
		{
			return pinqn1FeaS;
		}
		[CompilerGenerated]
		set
		{
			pinqn1FeaS = value;
		}
	}

	public ICommand DisLikeCommand
	{
		[CompilerGenerated]
		get
		{
			return C18qbshypR;
		}
		[CompilerGenerated]
		set
		{
			C18qbshypR = value;
		}
	}

	public ICommand PauseCommand
	{
		[CompilerGenerated]
		get
		{
			return hthq7dGiR2;
		}
		[CompilerGenerated]
		private set
		{
			hthq7dGiR2 = value;
		}
	}

	public ICommand PlayCommand
	{
		[CompilerGenerated]
		get
		{
			return OQXq5vVOJs;
		}
		[CompilerGenerated]
		private set
		{
			OQXq5vVOJs = value;
		}
	}

	public ICommand ChangeVideoHardwareDeviceCommand
	{
		[CompilerGenerated]
		get
		{
			return yFTqugvqWZ;
		}
		[CompilerGenerated]
		private set
		{
			yFTqugvqWZ = value;
		}
	}

	private void VVLPgtOj1C()
	{
		Q3OeRSTq6SNsAFQUUoG.D35lls5iF(this, new AsyncCommand<VideoPlayerPlaylistItem>(tjcP14LjYw), Q3OeRSTq6SNsAFQUUoG.ulrLfRVr7w);
		Q3OeRSTq6SNsAFQUUoG.D35lls5iF(this, new DelegateCommand(delegate
		{
			EcRAvP4y5i6535dlslT.D35lls5iF(this, EcRAvP4y5i6535dlslT.nyZEER87UF);
		}), Q3OeRSTq6SNsAFQUUoG.HlBLFpeZJq);
		Q3OeRSTq6SNsAFQUUoG.D35lls5iF(this, new DelegateCommand(delegate
		{
			EcRAvP4y5i6535dlslT.D35lls5iF(this, EcRAvP4y5i6535dlslT.BFEEBZQYOa);
		}), Q3OeRSTq6SNsAFQUUoG.FDGL2qlDGZ);
		Q3OeRSTq6SNsAFQUUoG.D35lls5iF(this, new DelegateCommand(delegate
		{
			EcRAvP4y5i6535dlslT.D35lls5iF(this, EcRAvP4y5i6535dlslT.cgtE01AVED);
		}), Q3OeRSTq6SNsAFQUUoG.T3pLZHORQp);
		Q3OeRSTq6SNsAFQUUoG.D35lls5iF(this, new DelegateCommand(delegate
		{
			EcRAvP4y5i6535dlslT.D35lls5iF(this, EcRAvP4y5i6535dlslT.wa6ErtAqq0);
		}), Q3OeRSTq6SNsAFQUUoG.QdNLjXEub0);
		Q3OeRSTq6SNsAFQUUoG.D35lls5iF(this, new DelegateCommand(delegate(object P_0)
		{
			KBhlAv9D2TgBJ1kkc0B.D35lls5iF(this, P_0, KBhlAv9D2TgBJ1kkc0B.ASCEeCbleC);
		}), Q3OeRSTq6SNsAFQUUoG.bZVLyN9keu);
	}

	public VideoPlayerViewModel()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector();
		EcRAvP4y5i6535dlslT.D35lls5iF(this, EcRAvP4y5i6535dlslT.eFELqpbCvt);
		xBYq0igajR = AppContainer.Resolve<IAppService>();
		d1kqG0pDgD = AppContainer.Resolve<IMovieService>();
		qvxqT7isTw = AppContainer.Resolve<ILiveService>();
		e2dqZVRJ2Z = AppContainer.Resolve<IStoreContext>();
		bNbrLrLJHkr1gsFkBeB.D35lls5iF(this, new VideoPlayerPlaylist(this), bNbrLrLJHkr1gsFkBeB.q9ZLb9Tr7s);
		VP3AAhLWsCDSDqXVeVl.D35lls5iF(this, new VideoPlayerController(this), VP3AAhLWsCDSDqXVeVl.P1gL5Zd7MN);
		Ctax9MLz9CAmna7QqT3.D35lls5iF(this, new VideoPlayerSettings(this), Ctax9MLz9CAmna7QqT3.wB3EoV9vre);
	}

	[AsyncStateMachine(typeof(_003COnAddToFavoriteCommandExcute_003Ed__70))]
	private Task tjcP14LjYw(VideoPlayerPlaylistItem P_0)
	{
		_003COnAddToFavoriteCommandExcute_003Ed__70 stateMachine = default(_003COnAddToFavoriteCommandExcute_003Ed__70);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine.dto = P_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	private void HwmPJrK7Fb()
	{
	}

	private void xF2Phg4wXX()
	{
	}

	[AsyncStateMachine(typeof(_003COnPauseCommandExcuteAsync_003Ed__73))]
	public void OnPauseCommandExcuteAsync()
	{
		_003COnPauseCommandExcuteAsync_003Ed__73 stateMachine = default(_003COnPauseCommandExcuteAsync_003Ed__73);
		stateMachine._003C_003Et__builder = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003COnPlayCommandExcuteAsync_003Ed__74))]
	public void OnPlayCommandExcuteAsync()
	{
		_003COnPlayCommandExcuteAsync_003Ed__74 stateMachine = default(_003COnPlayCommandExcuteAsync_003Ed__74);
		stateMachine._003C_003Et__builder = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void IAhPlrJcRq(object P_0)
	{
		if (S1a0wT9Ixre9OpDny8h.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(P_0, wq2usy8gNndpuTw5mR.ajcDe8nffb), iFZ5je3XFYKwkvcE5D.D35lls5iF(11018, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO))
		{
			zeZORlE9RynTPbHAG3o.D35lls5iF(TkGxlh3CuVnrJFKZIh9.D35lls5iF(this, TkGxlh3CuVnrJFKZIh9.tKMEl1yiYF), AVHWDeviceType.AV_HWDEVICE_TYPE_CUDA, zeZORlE9RynTPbHAG3o.elXEDj5jxQ);
		}
		else if (S1a0wT9Ixre9OpDny8h.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(P_0, wq2usy8gNndpuTw5mR.ajcDe8nffb), iFZ5je3XFYKwkvcE5D.D35lls5iF(11034, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO))
		{
			zeZORlE9RynTPbHAG3o.D35lls5iF(TkGxlh3CuVnrJFKZIh9.D35lls5iF(this, TkGxlh3CuVnrJFKZIh9.tKMEl1yiYF), AVHWDeviceType.AV_HWDEVICE_TYPE_DXVA2, zeZORlE9RynTPbHAG3o.elXEDj5jxQ);
		}
		else if (S1a0wT9Ixre9OpDny8h.D35lls5iF(wq2usy8gNndpuTw5mR.D35lls5iF(P_0, wq2usy8gNndpuTw5mR.ajcDe8nffb), iFZ5je3XFYKwkvcE5D.D35lls5iF(11054, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO))
		{
			zeZORlE9RynTPbHAG3o.D35lls5iF(TkGxlh3CuVnrJFKZIh9.D35lls5iF(this, TkGxlh3CuVnrJFKZIh9.tKMEl1yiYF), AVHWDeviceType.AV_HWDEVICE_TYPE_D3D11VA, zeZORlE9RynTPbHAG3o.elXEDj5jxQ);
		}
		else
		{
			zeZORlE9RynTPbHAG3o.D35lls5iF(TkGxlh3CuVnrJFKZIh9.D35lls5iF(this, TkGxlh3CuVnrJFKZIh9.tKMEl1yiYF), AVHWDeviceType.AV_HWDEVICE_TYPE_NONE, zeZORlE9RynTPbHAG3o.elXEDj5jxQ);
		}
	}

	private void xyJPUBSxjn(object P_0, EventArgs P_1)
	{
		foreach (VideoPlayerPlaylistItem item in YMtcchE175ZI5reK5BC.D35lls5iF(kNkAAf1oS8EBBquLcPe.D35lls5iF(this, kNkAAf1oS8EBBquLcPe.DYxEH8uI3e), YMtcchE175ZI5reK5BC.MdGE8mxnYB))
		{
			IEnumerator<EPGItemResponseDto> enumerator2 = LHX2RPEniIXFwofTA3i.D35lls5iF(item, LHX2RPEniIXFwofTA3i.bTJE37Tn8Y).GetEnumerator();
			try
			{
				while (hjMnupQVVDlRZAYQJC.D35lls5iF(enumerator2, hjMnupQVVDlRZAYQJC.QV1TFwytOj))
				{
					EPGItemResponseDto current = enumerator2.Current;
					qni3xrDkAJ3vF35eMav.D35lls5iF(current, iFZ5je3XFYKwkvcE5D.D35lls5iF(11076, iFZ5je3XFYKwkvcE5D.N06TeK0ao), qni3xrDkAJ3vF35eMav.W62ETIknen);
					qni3xrDkAJ3vF35eMav.D35lls5iF(current, iFZ5je3XFYKwkvcE5D.D35lls5iF(11088, iFZ5je3XFYKwkvcE5D.N06TeK0ao), qni3xrDkAJ3vF35eMav.W62ETIknen);
				}
			}
			finally
			{
				if (enumerator2 != null)
				{
					xLO56JniGyickVjO1Ot.D35lls5iF(enumerator2, xLO56JniGyickVjO1Ot.ydbT2bsoH4);
				}
			}
		}
	}

	[AsyncStateMachine(typeof(_003CLoadEpgItems_003Ed__77))]
	private Task jsDPLTFDhK()
	{
		_003CLoadEpgItems_003Ed__77 stateMachine = default(_003CLoadEpgItems_003Ed__77);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	[AsyncStateMachine(typeof(_003CLoadTvCategoriesItems_003Ed__78))]
	private Task qAEP2uOh6m()
	{
		_003CLoadTvCategoriesItems_003Ed__78 stateMachine = default(_003CLoadTvCategoriesItems_003Ed__78);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	[AsyncStateMachine(typeof(_003CLoadConfiguration_003Ed__79))]
	private Task jxZPzFT1qa(bool P_0)
	{
		_003CLoadConfiguration_003Ed__79 stateMachine = default(_003CLoadConfiguration_003Ed__79);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine.StartPlaying = P_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	[AsyncStateMachine(typeof(_003CLoadTvChannels_003Ed__80))]
	private Task kBKqcjKff0(bool P_0)
	{
		_003CLoadTvChannels_003Ed__80 stateMachine = default(_003CLoadTvChannels_003Ed__80);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine.StartPlaying = P_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	[AsyncStateMachine(typeof(_003CLoadAsync_003Ed__81))]
	public Task LoadAsync(bool StartPlaying = true)
	{
		_003CLoadAsync_003Ed__81 stateMachine = default(_003CLoadAsync_003Ed__81);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine.StartPlaying = StartPlaying;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	[AsyncStateMachine(typeof(_003CLoadAsync_003Ed__82))]
	public Task LoadAsync(MovieResponseDto dto, RentResponseDto rent)
	{
		_003CLoadAsync_003Ed__82 stateMachine = default(_003CLoadAsync_003Ed__82);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E4__this = this;
		stateMachine.dto = dto;
		stateMachine.rent = rent;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	public override void OnLoading()
	{
		Task task = kxYFveE4H3pBXluJ1GJ.D35lls5iF(this, true, kxYFveE4H3pBXluJ1GJ.EWNEL6BCkR);
		Action<Exception> action = null;
		bool flag = false;
		gBlEqv8jRKikCj2DMZp.D35lls5iF(task, ref action, ref flag, gBlEqv8jRKikCj2DMZp.pSp8ymt8Mu);
	}

	[AsyncStateMachine(typeof(_003COnOpenCommandExcuteAsync_003Ed__84))]
	public void OnOpenCommandExcuteAsync(VideoPlayerPlaylistItem obj)
	{
		_003COnOpenCommandExcuteAsync_003Ed__84 stateMachine = default(_003COnOpenCommandExcuteAsync_003Ed__84);
		stateMachine._003C_003Et__builder = XbrwjfkNjfftyyALC8.D35lls5iF(XbrwjfkNjfftyyALC8.wuNvIEjMb);
		stateMachine._003C_003E4__this = this;
		stateMachine.obj = obj;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[CompilerGenerated]
	private void zpZqjlH0DZ(object P_0)
	{
		EcRAvP4y5i6535dlslT.D35lls5iF(this, EcRAvP4y5i6535dlslT.nyZEER87UF);
	}

	[CompilerGenerated]
	private void EUTqvrU1ML(object P_0)
	{
		EcRAvP4y5i6535dlslT.D35lls5iF(this, EcRAvP4y5i6535dlslT.BFEEBZQYOa);
	}

	[CompilerGenerated]
	private void oEMqWFwPmk(object P_0)
	{
		EcRAvP4y5i6535dlslT.D35lls5iF(this, EcRAvP4y5i6535dlslT.cgtE01AVED);
	}

	[CompilerGenerated]
	private void yyFq4gHhmv(object P_0)
	{
		EcRAvP4y5i6535dlslT.D35lls5iF(this, EcRAvP4y5i6535dlslT.wa6ErtAqq0);
	}

	[CompilerGenerated]
	private void lnrqBt4vI7(object P_0)
	{
		KBhlAv9D2TgBJ1kkc0B.D35lls5iF(this, P_0, KBhlAv9D2TgBJ1kkc0B.ASCEeCbleC);
	}
}
