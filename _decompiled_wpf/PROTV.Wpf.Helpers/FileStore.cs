using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace PROTV.Wpf.Helpers;

public static class FileStore
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CWriteBytesAsync_003Ed__5 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public byte[] data;

		public string path;

		public CancellationToken token;

		private Stream _003Cfs_003E5__2;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			try
			{
				byte[] array = default(byte[]);
				if (num != 0)
				{
					array = M0oO1nVkHVLFWvQZIv5.D35lls5iF(data, M0oO1nVkHVLFWvQZIv5.lRwVACZS8Z);
					_003Cfs_003E5__2 = uR1obaV0EFv4qZuTiQG.D35lls5iF(path, true, uR1obaV0EFv4qZuTiQG.AM0V6FWVKs);
				}
				try
				{
					ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = SnJSHbGI2VM7Hr6K6mH.D35lls5iF(wtjrFDVpFjL7UboFokS.D35lls5iF(_003Cfs_003E5__2, array, 0, array.Length, token, wtjrFDVpFjL7UboFokS.dMlVwPTMHA), false, SnJSHbGI2VM7Hr6K6mH.QXqGdh50mj).GetAwaiter();
						if (!OFWTsIVCdBnIWR8nVKZ.D35lls5iF(ref awaiter, OFWTsIVCdBnIWR8nVKZ.nhLVmv1lK1))
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
						_003C_003Eu__1 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
						num = (_003C_003E1__state = -1);
					}
					D6PVClVac0gStwclpEu.D35lls5iF(ref awaiter, D6PVClVac0gStwclpEu.WeyVII1bFR);
				}
				finally
				{
					if (num < 0 && _003Cfs_003E5__2 != null)
					{
						xLO56JniGyickVjO1Ot.D35lls5iF(_003Cfs_003E5__2, xLO56JniGyickVjO1Ot.ydbT2bsoH4);
					}
				}
				_003Cfs_003E5__2 = null;
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

	public static Stream GetInputStream(string path, bool asynchronous)
	{
		return new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read, 4096, asynchronous);
	}

	public static Stream GetOutputStream(string path, bool asynchronous)
	{
		return new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None, 4096, asynchronous);
	}

	public static bool Exists(string path)
	{
		return M6ZErPEr2LZyWYpa5O.D35lls5iF(path, M6ZErPEr2LZyWYpa5O.WPpnHj4Wcq);
	}

	public static async Task<byte[]> ReadBytesAsync(string path, CancellationToken token)
	{
		Stream fs = uR1obaV0EFv4qZuTiQG.D35lls5iF(path, true, uR1obaV0EFv4qZuTiQG.ojhVrHnGSt);
		try
		{
			byte[] buff = new byte[CV4PJi6LR4KsuMQHWA7.D35lls5iF(fs, CV4PJi6LR4KsuMQHWA7.HVWVeheeyt)];
			await Ih58iQVG7dyIQdpiXct.D35lls5iF(fs, buff, 0, (int)CV4PJi6LR4KsuMQHWA7.D35lls5iF(fs, CV4PJi6LR4KsuMQHWA7.HVWVeheeyt), token, Ih58iQVG7dyIQdpiXct.wbZVRX3A4l).ConfigureAwait(continueOnCapturedContext: false);
			return M0oO1nVkHVLFWvQZIv5.D35lls5iF(buff, M0oO1nVkHVLFWvQZIv5.VipVvce5cb);
		}
		finally
		{
			if (fs != null)
			{
				xLO56JniGyickVjO1Ot.D35lls5iF(fs, xLO56JniGyickVjO1Ot.ydbT2bsoH4);
			}
		}
	}

	[AsyncStateMachine(typeof(_003CWriteBytesAsync_003Ed__5))]
	public static Task WriteBytesAsync(string path, byte[] data, CancellationToken token)
	{
		_003CWriteBytesAsync_003Ed__5 stateMachine = default(_003CWriteBytesAsync_003Ed__5);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine.path = path;
		stateMachine.data = data;
		stateMachine.token = token;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}
}
