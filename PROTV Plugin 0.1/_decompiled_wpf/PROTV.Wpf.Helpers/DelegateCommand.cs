using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Threading;

namespace PROTV.Wpf.Helpers;

public class DelegateCommand : ICommand
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass4_0
	{
		public DelegateCommand jwaktBZ5gP;

		public Action<object> zf7kSyVU21;

		public _003C_003Ec__DisplayClass4_0()
		{
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
			base._002Ector();
		}

		internal void OI3kZ1R1k2(object parameter)
		{
			Func<object, bool> p2TGbODlL = jwaktBZ5gP.P2TGbODlL6;
			if (p2TGbODlL == null || p2TGbODlL(parameter))
			{
				zf7kSyVU21(parameter);
			}
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass16_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct Ag2vdojZ3fJSGO7xrep : IAsyncStateMachine
		{
			public int qbuunuQbKy;

			public AsyncTaskMethodBuilder v1eubJpSDR;

			public _003C_003Ec__DisplayClass16_0 RiEu7ht5RO;

			private TaskAwaiter nt5u5N4nN7;

			private void MoveNext()
			{
				int num = qbuunuQbKy;
				_003C_003Ec__DisplayClass16_0 obj = RiEu7ht5RO;
				try
				{
					if (num == 0 || !uEUVCI48fycroqgRFqy.D35lls5iF(obj.FIDkKBs0JR, uEUVCI48fycroqgRFqy.VgGGwtLvOF))
					{
						try
						{
							TaskAwaiter awaiter;
							if (num != 0)
							{
								jPB9Q5LdIM9wsuWV1q7.D35lls5iF(obj.FIDkKBs0JR, true, jPB9Q5LdIM9wsuWV1q7.fgVcKf5sAy);
								awaiter = QliBEUviwWqgtMcBndV.D35lls5iF(tr8uv7cNCKvnjlfvPIY.D35lls5iF(bRAh8kDAgKIlehXIXku.D35lls5iF(Jr0pTQlovwB9pdID1EB.D35lls5iF(Jr0pTQlovwB9pdID1EB.CxrllgXtD4), bRAh8kDAgKIlehXIXku.oESD6ce9jH), obj.FIDkKBs0JR.RdAG7iYF5K, (DispatcherPriority)9, new object[1] { obj.YuikkhnpAB }, tr8uv7cNCKvnjlfvPIY.gcNcOcxd6R), QliBEUviwWqgtMcBndV.TijcuAZLod);
								if (!vrPRD5vXnGuEO7KBcDs.D35lls5iF(ref awaiter, vrPRD5vXnGuEO7KBcDs.p1FvfhKoi4))
								{
									num = (qbuunuQbKy = 0);
									nt5u5N4nN7 = awaiter;
									v1eubJpSDR.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
							}
							else
							{
								awaiter = nt5u5N4nN7;
								nt5u5N4nN7 = default(TaskAwaiter);
								num = (qbuunuQbKy = -1);
							}
							oiNJkpvFj6bPgLNYMHm.D35lls5iF(ref awaiter, oiNJkpvFj6bPgLNYMHm.Iylv2DG6BT);
						}
						catch (Exception)
						{
							throw;
						}
						finally
						{
							if (num < 0)
							{
								jPB9Q5LdIM9wsuWV1q7.D35lls5iF(obj.FIDkKBs0JR, false, jPB9Q5LdIM9wsuWV1q7.fgVcKf5sAy);
								YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.H1ScPNn7W9);
							}
						}
					}
				}
				catch (Exception ex2)
				{
					qbuunuQbKy = -2;
					NNK1eXA7fWQ87oSUty7.D35lls5iF(ref v1eubJpSDR, ex2, NNK1eXA7fWQ87oSUty7.G3EAcW9Om7);
					return;
				}
				qbuunuQbKy = -2;
				meFicnAMHIVtdhf671p.D35lls5iF(ref v1eubJpSDR, meFicnAMHIVtdhf671p.bsDASenQ5I);
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine P_0)
			{
				vxBFJcAKZoecNtbdqxt.D35lls5iF(ref v1eubJpSDR, P_0, vxBFJcAKZoecNtbdqxt.tuxANdhu18);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine P_0)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(P_0);
			}
		}

		public DelegateCommand FIDkKBs0JR;

		public object YuikkhnpAB;

		public _003C_003Ec__DisplayClass16_0()
		{
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
			base._002Ector();
		}

		[AsyncStateMachine(typeof(Ag2vdojZ3fJSGO7xrep))]
		internal Task zb2kfLD8HX()
		{
			Ag2vdojZ3fJSGO7xrep stateMachine = default(Ag2vdojZ3fJSGO7xrep);
			stateMachine.v1eubJpSDR = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
			stateMachine.RiEu7ht5RO = this;
			stateMachine.qbuunuQbKy = -1;
			stateMachine.v1eubJpSDR.Start(ref stateMachine);
			return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine.v1eubJpSDR, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
		}
	}

	private readonly object tWTGnchm2f;

	private readonly Func<object, bool> P2TGbODlL6;

	private readonly Action<object> RdAG7iYF5K;

	private bool lUgG5w5tIX;

	public bool IsExecuting
	{
		get
		{
			object obj = tWTGnchm2f;
			bool flag = false;
			try
			{
				H8qYncGAaDP9dt5ZWqR.D35lls5iF(obj, ref flag, H8qYncGAaDP9dt5ZWqR.JNiG6q9lbH);
				return lUgG5w5tIX;
			}
			finally
			{
				if (flag)
				{
					b3QyiYL4pm5cgsTYbRX.D35lls5iF(obj, b3QyiYL4pm5cgsTYbRX.oTMGpd9H2u);
				}
			}
		}
		private set
		{
			object obj = tWTGnchm2f;
			bool flag = false;
			try
			{
				H8qYncGAaDP9dt5ZWqR.D35lls5iF(obj, ref flag, H8qYncGAaDP9dt5ZWqR.JNiG6q9lbH);
				lUgG5w5tIX = value;
			}
			finally
			{
				if (flag)
				{
					b3QyiYL4pm5cgsTYbRX.D35lls5iF(obj, b3QyiYL4pm5cgsTYbRX.oTMGpd9H2u);
				}
			}
		}
	}

	public event EventHandler CanExecuteChanged
	{
		add
		{
			h1cny0GRMan50PsPPSR.D35lls5iF(value, h1cny0GRMan50PsPPSR.HtAGkElIbD);
		}
		remove
		{
			h1cny0GRMan50PsPPSR.D35lls5iF(value, h1cny0GRMan50PsPPSR.f6pGvlMKe6);
		}
	}

	public DelegateCommand(Action<object> execute, Func<object, bool> canExecute)
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		tWTGnchm2f = new object();
		_003C_003Ec__DisplayClass4_0 CS_0024_003C_003E8__locals4 = new _003C_003Ec__DisplayClass4_0();
		base._002Ector();
		CS_0024_003C_003E8__locals4.jwaktBZ5gP = this;
		CS_0024_003C_003E8__locals4.zf7kSyVU21 = execute ?? throw new ArgumentNullException(iFZ5je3XFYKwkvcE5D.D35lls5iF(14588, iFZ5je3XFYKwkvcE5D.N06TeK0ao));
		P2TGbODlL6 = canExecute;
		RdAG7iYF5K = delegate(object parameter)
		{
			Func<object, bool> p2TGbODlL = CS_0024_003C_003E8__locals4.jwaktBZ5gP.P2TGbODlL6;
			if (p2TGbODlL == null || p2TGbODlL(parameter))
			{
				CS_0024_003C_003E8__locals4.zf7kSyVU21(parameter);
			}
		};
	}

	public DelegateCommand(Action<object> execute)
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		this._002Ector(execute, null);
	}

	[DebuggerStepThrough]
	public bool CanExecute(object parameter)
	{
		if (uEUVCI48fycroqgRFqy.D35lls5iF(this, uEUVCI48fycroqgRFqy.VgGGwtLvOF))
		{
			return false;
		}
		if (P2TGbODlL6 != null)
		{
			return P2TGbODlL6(parameter);
		}
		return true;
	}

	public bool CanExecute()
	{
		return GmMLaTD7kV8rq88ZFvR.D35lls5iF(this, null, GmMLaTD7kV8rq88ZFvR.mhKGC05fPk);
	}

	public void Execute(object parameter)
	{
		Ru806sGmlHyilPEXtRG.D35lls5iF(this, parameter, Ru806sGmlHyilPEXtRG.kieGaPnPlQ);
	}

	public void Execute()
	{
		Ru806sGmlHyilPEXtRG.D35lls5iF(this, null, Ru806sGmlHyilPEXtRG.kieGaPnPlQ);
	}

	public ConfiguredTaskAwaitable ExecuteAsync(object parameter)
	{
		_003C_003Ec__DisplayClass16_0 obj = new _003C_003Ec__DisplayClass16_0();
		obj.FIDkKBs0JR = this;
		obj.YuikkhnpAB = parameter;
		return SnJSHbGI2VM7Hr6K6mH.D35lls5iF(TVLePdHICaM6OkL9Y6W.D35lls5iF([AsyncStateMachine(typeof(_003C_003Ec__DisplayClass16_0.Ag2vdojZ3fJSGO7xrep))] () =>
		{
			_003C_003Ec__DisplayClass16_0.Ag2vdojZ3fJSGO7xrep stateMachine = default(_003C_003Ec__DisplayClass16_0.Ag2vdojZ3fJSGO7xrep);
			stateMachine.v1eubJpSDR = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
			stateMachine.RiEu7ht5RO = obj;
			stateMachine.qbuunuQbKy = -1;
			stateMachine.v1eubJpSDR.Start(ref stateMachine);
			return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine.v1eubJpSDR, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
		}, TVLePdHICaM6OkL9Y6W.sqgHdsJXG7), true, SnJSHbGI2VM7Hr6K6mH.QXqGdh50mj);
	}

	public ConfiguredTaskAwaitable ExecuteAsync()
	{
		return Ru806sGmlHyilPEXtRG.D35lls5iF(this, null, Ru806sGmlHyilPEXtRG.kieGaPnPlQ);
	}
}
