using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using PROTV.DataAccess;
using PROTV.Wpf.Bootstrap;
using Unosquare.FFME;
using Unosquare.FFME.Common;

namespace PROTV.Wpf.Helpers;

public static class VideoPlayerHelpers
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSaveMediaItem_003Ed__3 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MediaElement media;

		public int mediaId;

		public double currentTime;

		public double duration;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_014a;
				}
				if (num == 1)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_01e3;
				}
				IClientDataStore clientDataStore = AppContainer.Resolve<IClientDataStore>();
				MoviePosition moviePosition = new MoviePosition();
				if (media != null && XLgPbA36DhJ4A0tFJ41.D35lls5iF(media, XLgPbA36DhJ4A0tFJ41.tP43pEUL5Y).HasValue)
				{
					vQKA0r9sJ1kArsIHc16.D35lls5iF(moviePosition, mediaId, vQKA0r9sJ1kArsIHc16.wsPEZMwIPh);
					mAdJWQ9yhneCbEXlGMc.D35lls5iF(moviePosition, currentTime, mAdJWQ9yhneCbEXlGMc.MyaEyFFaD3);
					mAdJWQ9yhneCbEXlGMc.D35lls5iF(moviePosition, duration, mAdJWQ9yhneCbEXlGMc.ew5EJPXkP2);
					if (bATk1clKMSyO8g9EVbN.D35lls5iF(moviePosition, bATk1clKMSyO8g9EVbN.EXVEbRTNDs) - bATk1clKMSyO8g9EVbN.D35lls5iF(moviePosition, bATk1clKMSyO8g9EVbN.yiiEWvK63c) >= 5.0 && bATk1clKMSyO8g9EVbN.D35lls5iF(moviePosition, bATk1clKMSyO8g9EVbN.yiiEWvK63c) >= 5.0)
					{
						mAdJWQ9yhneCbEXlGMc.D35lls5iF(moviePosition, bATk1clKMSyO8g9EVbN.D35lls5iF(moviePosition, bATk1clKMSyO8g9EVbN.yiiEWvK63c) - 2.0, mAdJWQ9yhneCbEXlGMc.MyaEyFFaD3);
						awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(id9FOtE5M6ovr3jBZuf.D35lls5iF(clientDataStore, moviePosition, id9FOtE5M6ovr3jBZuf.iU5EzJPaXm), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
						if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
						{
							num = (_003C_003E1__state = 0);
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_014a;
					}
					if (bATk1clKMSyO8g9EVbN.D35lls5iF(moviePosition, bATk1clKMSyO8g9EVbN.yiiEWvK63c) >= 5.0)
					{
						awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(ShJD1fBoTHqWZbnMAIM.D35lls5iF(clientDataStore, mediaId, ShJD1fBoTHqWZbnMAIM.JTIBlcAfan), QliBEUviwWqgtMcBndV.fSTvQKwkjK);
						if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
						{
							num = (_003C_003E1__state = 1);
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_01e3;
					}
				}
				goto end_IL_000e;
				IL_01e3:
				oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
				goto end_IL_000e;
				IL_014a:
				oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
				end_IL_000e:;
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

	public static void InitializeUdpConfiguration(ContainerConfiguration configuration, bool noBuffer)
	{
		dq1xgG9KNu7RfbYkGMV.D35lls5iF(configuration, dq1xgG9KNu7RfbYkGMV.xWD9NR1CqV)[iFZ5je3XFYKwkvcE5D.D35lls5iF(474, iFZ5je3XFYKwkvcE5D.N06TeK0ao)] = iFZ5je3XFYKwkvcE5D.D35lls5iF(3966, iFZ5je3XFYKwkvcE5D.N06TeK0ao);
		QnJnl7fVDKI4mA6voc.D35lls5iF(nXvH3V9ON1PquOtoxuq.D35lls5iF(configuration, nXvH3V9ON1PquOtoxuq.g2g9uaXBwW), noBuffer, QnJnl7fVDKI4mA6voc.J0Z9Ppmjjt);
		AKwYZ1lE8mnNaTGlMo6.D35lls5iF(nXvH3V9ON1PquOtoxuq.D35lls5iF(configuration, nXvH3V9ON1PquOtoxuq.g2g9uaXBwW), aNJrrPl4soK5NDOndiN.D35lls5iF(10.0, aNJrrPl4soK5NDOndiN.Ca9lahqtKS), AKwYZ1lE8mnNaTGlMo6.HSE9xIihv0);
	}

	public static void InitializeRtspConfiguration(ContainerConfiguration configuration, bool noBuffer)
	{
		dq1xgG9KNu7RfbYkGMV.D35lls5iF(configuration, dq1xgG9KNu7RfbYkGMV.xWD9NR1CqV)[iFZ5je3XFYKwkvcE5D.D35lls5iF(474, iFZ5je3XFYKwkvcE5D.N06TeK0ao)] = iFZ5je3XFYKwkvcE5D.D35lls5iF(3966, iFZ5je3XFYKwkvcE5D.N06TeK0ao);
		QnJnl7fVDKI4mA6voc.D35lls5iF(nXvH3V9ON1PquOtoxuq.D35lls5iF(configuration, nXvH3V9ON1PquOtoxuq.g2g9uaXBwW), noBuffer, QnJnl7fVDKI4mA6voc.J0Z9Ppmjjt);
		AKwYZ1lE8mnNaTGlMo6.D35lls5iF(configuration, aNJrrPl4soK5NDOndiN.D35lls5iF(10.0, aNJrrPl4soK5NDOndiN.Ca9lahqtKS), AKwYZ1lE8mnNaTGlMo6.zL6nlX0JV7);
	}

	public static void InitializeHttpConfiguration(ContainerConfiguration configuration, bool noBuffer)
	{
		dq1xgG9KNu7RfbYkGMV.D35lls5iF(configuration, dq1xgG9KNu7RfbYkGMV.xWD9NR1CqV)[iFZ5je3XFYKwkvcE5D.D35lls5iF(474, iFZ5je3XFYKwkvcE5D.N06TeK0ao)] = iFZ5je3XFYKwkvcE5D.D35lls5iF(3966, iFZ5je3XFYKwkvcE5D.N06TeK0ao);
		AKwYZ1lE8mnNaTGlMo6.D35lls5iF(configuration, aNJrrPl4soK5NDOndiN.D35lls5iF(10.0, aNJrrPl4soK5NDOndiN.Ca9lahqtKS), AKwYZ1lE8mnNaTGlMo6.zL6nlX0JV7);
		QnJnl7fVDKI4mA6voc.D35lls5iF(nXvH3V9ON1PquOtoxuq.D35lls5iF(configuration, nXvH3V9ON1PquOtoxuq.g2g9uaXBwW), noBuffer, QnJnl7fVDKI4mA6voc.J0Z9Ppmjjt);
		vQKA0r9sJ1kArsIHc16.D35lls5iF(nXvH3V9ON1PquOtoxuq.D35lls5iF(configuration, nXvH3V9ON1PquOtoxuq.g2g9uaXBwW), 524288, vQKA0r9sJ1kArsIHc16.km39hJJ5mo);
		AKwYZ1lE8mnNaTGlMo6.D35lls5iF(nXvH3V9ON1PquOtoxuq.D35lls5iF(configuration, nXvH3V9ON1PquOtoxuq.g2g9uaXBwW), aNJrrPl4soK5NDOndiN.D35lls5iF(1.0, aNJrrPl4soK5NDOndiN.Ca9lahqtKS), AKwYZ1lE8mnNaTGlMo6.HSE9xIihv0);
		vQKA0r9sJ1kArsIHc16.D35lls5iF(nXvH3V9ON1PquOtoxuq.D35lls5iF(configuration, nXvH3V9ON1PquOtoxuq.g2g9uaXBwW), 32768, vQKA0r9sJ1kArsIHc16.Ebr9YCG3u1);
	}

	[AsyncStateMachine(typeof(_003CSaveMediaItem_003Ed__3))]
	public static Task SaveMediaItem(MediaElement media, int mediaId, double currentTime, double duration)
	{
		_003CSaveMediaItem_003Ed__3 stateMachine = default(_003CSaveMediaItem_003Ed__3);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine.media = media;
		stateMachine.mediaId = mediaId;
		stateMachine.currentTime = currentTime;
		stateMachine.duration = duration;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}
}
