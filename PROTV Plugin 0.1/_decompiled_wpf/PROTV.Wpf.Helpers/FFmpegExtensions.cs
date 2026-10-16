using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace PROTV.Wpf.Helpers;

public static class FFmpegExtensions
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLoadFFmpegLibrary_003Ed__0 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			try
			{
				if (num != 0)
				{
					iEiFM8eVSwxJTPFVS0.D35lls5iF(UwSEfC4rh9eVlFenwI.D35lls5iF(iFZ5je3XFYKwkvcE5D.D35lls5iF(16880, iFZ5je3XFYKwkvcE5D.N06TeK0ao), V5MooqlfITowrG9yf5v.D35lls5iF(V5MooqlfITowrG9yf5v.x8htxopPYN) ? iFZ5je3XFYKwkvcE5D.D35lls5iF(16914, iFZ5je3XFYKwkvcE5D.N06TeK0ao) : iFZ5je3XFYKwkvcE5D.D35lls5iF(16902, iFZ5je3XFYKwkvcE5D.N06TeK0ao), UwSEfC4rh9eVlFenwI.BPNLUJNA3), iEiFM8eVSwxJTPFVS0.dHLtYU9Sk8);
					BL5g3hTlaZ1Y7krOIPW.D35lls5iF(DwgsIttNEA2NshX7F1f.D35lls5iF(DwgsIttNEA2NshX7F1f.KOttgNxqgQ), BL5g3hTlaZ1Y7krOIPW.tpmtichVKR);
					aAo0ZCtQHZHsGWHoPB3.D35lls5iF(!V5MooqlfITowrG9yf5v.D35lls5iF(V5MooqlfITowrG9yf5v.HwelFVtd23), aAo0ZCtQHZHsGWHoPB3.YKmtXgfOAP);
				}
				try
				{
					ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = sl6lostfxdMUSFan99a.D35lls5iF(sl6lostfxdMUSFan99a.tmstFE0TIJ).GetAwaiter();
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
				catch
				{
					gsYNF433WqUIGma3CNX.D35lls5iF(iFZ5je3XFYKwkvcE5D.D35lls5iF(16926, iFZ5je3XFYKwkvcE5D.N06TeK0ao), "", gsYNF433WqUIGma3CNX.Ei5AVGtpvG);
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

	[AsyncStateMachine(typeof(_003CLoadFFmpegLibrary_003Ed__0))]
	public static Task LoadFFmpegLibrary()
	{
		_003CLoadFFmpegLibrary_003Ed__0 stateMachine = default(_003CLoadFFmpegLibrary_003Ed__0);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}
}
