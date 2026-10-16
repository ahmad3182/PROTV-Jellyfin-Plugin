using System;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PROTV.Abstractions.Helpers;

public class AsyncValueCommand<T> : IAsyncValueCommand<T>, ICommand
{
	private readonly Func<T, ValueTask> upbId8snnC;

	private readonly Func<object?, bool> Fx0IGqqixK;

	private readonly Action<Exception>? xmRIZ1OLLt;

	private readonly bool lInIpO0GiL;

	private readonly WeakEventManager I4qI9v7n1k;

	public event EventHandler CanExecuteChanged
	{
		add
		{
			WeakEventManager i4qI9v7n1k = I4qI9v7n1k;
			Delegate handler = value;
			string eventName = q2no0WnPxDaipZawxT.IB3tMMvyI(176, q2no0WnPxDaipZawxT.eV4vC1LZv);
			L8n4k8tHDZuqhL8MwHK.IB3tMMvyI(i4qI9v7n1k, ref handler, ref eventName, L8n4k8tHDZuqhL8MwHK.sJotQb5yXM);
		}
		remove
		{
			WeakEventManager i4qI9v7n1k = I4qI9v7n1k;
			Delegate handler = value;
			string eventName = q2no0WnPxDaipZawxT.IB3tMMvyI(176, q2no0WnPxDaipZawxT.eV4vC1LZv);
			L8n4k8tHDZuqhL8MwHK.IB3tMMvyI(i4qI9v7n1k, ref handler, ref eventName, L8n4k8tHDZuqhL8MwHK.SOFtkGYy9D);
		}
	}

	public AsyncValueCommand(Func<T, ValueTask> execute, Func<object?, bool>? canExecute = null, Action<Exception>? onException = null, bool continueOnCapturedContext = false)
	{
		uiiVNagWnDNnTWnFgq.IB3tMMvyI(uiiVNagWnDNnTWnFgq.JyKLgPcm8);
		I4qI9v7n1k = new WeakEventManager();
		base._002Ector();
		upbId8snnC = execute ?? throw new ArgumentNullException(q2no0WnPxDaipZawxT.IB3tMMvyI(110, q2no0WnPxDaipZawxT.eV4vC1LZv), q2no0WnPxDaipZawxT.IB3tMMvyI(128, q2no0WnPxDaipZawxT.eV4vC1LZv));
		Fx0IGqqixK = canExecute ?? ((Func<object, bool>)((object? _) => true));
		xmRIZ1OLLt = onException;
		lInIpO0GiL = continueOnCapturedContext;
	}

	public bool CanExecute(object? parameter)
	{
		return Fx0IGqqixK(parameter);
	}

	public void RaiseCanExecuteChanged()
	{
		WeakEventManager i4qI9v7n1k = I4qI9v7n1k;
		object sender = this;
		object eventArgs = EventArgs.Empty;
		string eventName = q2no0WnPxDaipZawxT.IB3tMMvyI(176, q2no0WnPxDaipZawxT.eV4vC1LZv);
		PubcpKtWxlVHTsr0dAk.IB3tMMvyI(i4qI9v7n1k, ref sender, ref eventArgs, ref eventName, PubcpKtWxlVHTsr0dAk.j7ftJDXtjD);
	}

	public ValueTask ExecuteAsync(T parameter)
	{
		return upbId8snnC(parameter);
	}

	void ICommand.Execute(object parameter)
	{
		if (!(parameter is T parameter2))
		{
			if (parameter != null)
			{
				throw new InvalidCommandParameterException(qF26GttYUdNBHxRv49r.IB3tMMvyI(typeof(T).TypeHandle, qF26GttYUdNBHxRv49r.XkttDo3PTI), su3KGqt1CBw6EE7bFA0.IB3tMMvyI(parameter, su3KGqt1CBw6EE7bFA0.mymtyt47C7));
			}
			if (TLD0W5K9yiTCdcMEKT.IB3tMMvyI(abpMN6taZiFOZdnaKV9.IB3tMMvyI(qF26GttYUdNBHxRv49r.IB3tMMvyI(typeof(T).TypeHandle, qF26GttYUdNBHxRv49r.XkttDo3PTI), abpMN6taZiFOZdnaKV9.p6WtPmq2Cb), TLD0W5K9yiTCdcMEKT.yg1tB5F06K))
			{
				throw new InvalidCommandParameterException(qF26GttYUdNBHxRv49r.IB3tMMvyI(typeof(T).TypeHandle, qF26GttYUdNBHxRv49r.XkttDo3PTI));
			}
			rVpDB4tob3PJcAHEgwT.IB3tMMvyI(ExecuteAsync((T)parameter), ref xmRIZ1OLLt, ref lInIpO0GiL, rVpDB4tob3PJcAHEgwT.D4Jt8VluI8);
		}
		else
		{
			rVpDB4tob3PJcAHEgwT.IB3tMMvyI(ExecuteAsync(parameter2), ref xmRIZ1OLLt, ref lInIpO0GiL, rVpDB4tob3PJcAHEgwT.D4Jt8VluI8);
		}
	}
}
public class AsyncValueCommand : IAsyncValueCommand, ICommand
{
	private readonly Func<ValueTask> Lh4IR9S1nk;

	private readonly Func<object?, bool> BhQIsVME0A;

	private readonly Action<Exception>? mMaIkL5VpE;

	private readonly bool BlQIonpVnJ;

	private readonly WeakEventManager GsgIKD4VCQ;

	public event EventHandler CanExecuteChanged
	{
		add
		{
			WeakEventManager gsgIKD4VCQ = GsgIKD4VCQ;
			Delegate handler = value;
			string eventName = q2no0WnPxDaipZawxT.IB3tMMvyI(176, q2no0WnPxDaipZawxT.eV4vC1LZv);
			L8n4k8tHDZuqhL8MwHK.IB3tMMvyI(gsgIKD4VCQ, ref handler, ref eventName, L8n4k8tHDZuqhL8MwHK.sJotQb5yXM);
		}
		remove
		{
			WeakEventManager gsgIKD4VCQ = GsgIKD4VCQ;
			Delegate handler = value;
			string eventName = q2no0WnPxDaipZawxT.IB3tMMvyI(176, q2no0WnPxDaipZawxT.eV4vC1LZv);
			L8n4k8tHDZuqhL8MwHK.IB3tMMvyI(gsgIKD4VCQ, ref handler, ref eventName, L8n4k8tHDZuqhL8MwHK.SOFtkGYy9D);
		}
	}

	public AsyncValueCommand(Func<ValueTask> execute, Func<object?, bool>? canExecute = null, Action<Exception>? onException = null, bool continueOnCapturedContext = false)
	{
		uiiVNagWnDNnTWnFgq.IB3tMMvyI(uiiVNagWnDNnTWnFgq.JyKLgPcm8);
		GsgIKD4VCQ = new WeakEventManager();
		base._002Ector();
		Lh4IR9S1nk = execute ?? throw new ArgumentNullException(q2no0WnPxDaipZawxT.IB3tMMvyI(110, q2no0WnPxDaipZawxT.eV4vC1LZv), q2no0WnPxDaipZawxT.IB3tMMvyI(128, q2no0WnPxDaipZawxT.eV4vC1LZv));
		BhQIsVME0A = canExecute ?? ((Func<object, bool>)((object? _) => true));
		mMaIkL5VpE = onException;
		BlQIonpVnJ = continueOnCapturedContext;
	}

	public bool CanExecute(object? parameter)
	{
		return BhQIsVME0A(parameter);
	}

	public void RaiseCanExecuteChanged()
	{
		WeakEventManager gsgIKD4VCQ = GsgIKD4VCQ;
		object sender = this;
		object eventArgs = EventArgs.Empty;
		string eventName = q2no0WnPxDaipZawxT.IB3tMMvyI(176, q2no0WnPxDaipZawxT.eV4vC1LZv);
		PubcpKtWxlVHTsr0dAk.IB3tMMvyI(gsgIKD4VCQ, ref sender, ref eventArgs, ref eventName, PubcpKtWxlVHTsr0dAk.j7ftJDXtjD);
	}

	public ValueTask ExecuteAsync()
	{
		return Lh4IR9S1nk();
	}

	void ICommand.Execute(object parameter)
	{
		rVpDB4tob3PJcAHEgwT.IB3tMMvyI(Lh4IR9S1nk(), ref mMaIkL5VpE, ref BlQIonpVnJ, rVpDB4tob3PJcAHEgwT.D4Jt8VluI8);
	}
}
