using System;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PROTV.Abstractions.Helpers;

public class AsyncCommand<T> : IAsyncCommand<T>, ICommand
{
	private readonly Func<T, Task> VKmI6Pj4IS;

	private readonly Func<object?, bool> KFoI72VrMr;

	private readonly Action<Exception>? HWcInSK90w;

	private readonly bool BbOICnkSeL;

	private readonly WeakEventManager mryIX0RBYE;

	public event EventHandler CanExecuteChanged
	{
		add
		{
			WeakEventManager weakEventManager = mryIX0RBYE;
			Delegate handler = value;
			string eventName = q2no0WnPxDaipZawxT.IB3tMMvyI(176, q2no0WnPxDaipZawxT.eV4vC1LZv);
			L8n4k8tHDZuqhL8MwHK.IB3tMMvyI(weakEventManager, ref handler, ref eventName, L8n4k8tHDZuqhL8MwHK.sJotQb5yXM);
		}
		remove
		{
			WeakEventManager weakEventManager = mryIX0RBYE;
			Delegate handler = value;
			string eventName = q2no0WnPxDaipZawxT.IB3tMMvyI(176, q2no0WnPxDaipZawxT.eV4vC1LZv);
			L8n4k8tHDZuqhL8MwHK.IB3tMMvyI(weakEventManager, ref handler, ref eventName, L8n4k8tHDZuqhL8MwHK.SOFtkGYy9D);
		}
	}

	public AsyncCommand(Func<T, Task> execute, Func<object?, bool>? canExecute = null, Action<Exception>? onException = null, bool continueOnCapturedContext = false)
	{
		uiiVNagWnDNnTWnFgq.IB3tMMvyI(uiiVNagWnDNnTWnFgq.JyKLgPcm8);
		mryIX0RBYE = new WeakEventManager();
		base._002Ector();
		VKmI6Pj4IS = execute ?? throw new ArgumentNullException(q2no0WnPxDaipZawxT.IB3tMMvyI(110, q2no0WnPxDaipZawxT.eV4vC1LZv), q2no0WnPxDaipZawxT.IB3tMMvyI(128, q2no0WnPxDaipZawxT.eV4vC1LZv));
		KFoI72VrMr = canExecute ?? ((Func<object, bool>)((object? _) => true));
		HWcInSK90w = onException;
		BbOICnkSeL = continueOnCapturedContext;
	}

	public bool CanExecute(object? parameter)
	{
		return KFoI72VrMr(parameter);
	}

	public void RaiseCanExecuteChanged()
	{
		WeakEventManager weakEventManager = mryIX0RBYE;
		object sender = this;
		object eventArgs = EventArgs.Empty;
		string eventName = q2no0WnPxDaipZawxT.IB3tMMvyI(176, q2no0WnPxDaipZawxT.eV4vC1LZv);
		PubcpKtWxlVHTsr0dAk.IB3tMMvyI(weakEventManager, ref sender, ref eventArgs, ref eventName, PubcpKtWxlVHTsr0dAk.j7ftJDXtjD);
	}

	public Task ExecuteAsync(T parameter)
	{
		return VKmI6Pj4IS(parameter);
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
			Mxptt2tbqgXMF9FeeZS.IB3tMMvyI(ExecuteAsync((T)parameter), ref HWcInSK90w, ref BbOICnkSeL, Mxptt2tbqgXMF9FeeZS.RXdt7ev8qx);
		}
		else
		{
			Mxptt2tbqgXMF9FeeZS.IB3tMMvyI(ExecuteAsync(parameter2), ref HWcInSK90w, ref BbOICnkSeL, Mxptt2tbqgXMF9FeeZS.RXdt7ev8qx);
		}
	}
}
public class AsyncCommand : IAsyncCommand, ICommand
{
	private readonly Func<Task> PEcImVP5MK;

	private readonly Func<object?, bool> bfEIwqdxsh;

	private readonly Action<Exception>? r2hIM78nT0;

	private readonly bool IiTIxeZriO;

	private readonly WeakEventManager GNlIVJNypM;

	public event EventHandler CanExecuteChanged
	{
		add
		{
			WeakEventManager gNlIVJNypM = GNlIVJNypM;
			Delegate handler = value;
			string eventName = q2no0WnPxDaipZawxT.IB3tMMvyI(176, q2no0WnPxDaipZawxT.eV4vC1LZv);
			L8n4k8tHDZuqhL8MwHK.IB3tMMvyI(gNlIVJNypM, ref handler, ref eventName, L8n4k8tHDZuqhL8MwHK.sJotQb5yXM);
		}
		remove
		{
			WeakEventManager gNlIVJNypM = GNlIVJNypM;
			Delegate handler = value;
			string eventName = q2no0WnPxDaipZawxT.IB3tMMvyI(176, q2no0WnPxDaipZawxT.eV4vC1LZv);
			L8n4k8tHDZuqhL8MwHK.IB3tMMvyI(gNlIVJNypM, ref handler, ref eventName, L8n4k8tHDZuqhL8MwHK.SOFtkGYy9D);
		}
	}

	public AsyncCommand(Func<Task> execute, Func<object?, bool>? canExecute = null, Action<Exception>? onException = null, bool continueOnCapturedContext = false)
	{
		uiiVNagWnDNnTWnFgq.IB3tMMvyI(uiiVNagWnDNnTWnFgq.JyKLgPcm8);
		GNlIVJNypM = new WeakEventManager();
		base._002Ector();
		PEcImVP5MK = execute ?? throw new ArgumentNullException(q2no0WnPxDaipZawxT.IB3tMMvyI(110, q2no0WnPxDaipZawxT.eV4vC1LZv), q2no0WnPxDaipZawxT.IB3tMMvyI(128, q2no0WnPxDaipZawxT.eV4vC1LZv));
		bfEIwqdxsh = canExecute ?? ((Func<object, bool>)((object? _) => true));
		r2hIM78nT0 = onException;
		IiTIxeZriO = continueOnCapturedContext;
	}

	public bool CanExecute(object? parameter)
	{
		return bfEIwqdxsh(parameter);
	}

	public void RaiseCanExecuteChanged()
	{
		WeakEventManager gNlIVJNypM = GNlIVJNypM;
		object sender = this;
		object eventArgs = EventArgs.Empty;
		string eventName = q2no0WnPxDaipZawxT.IB3tMMvyI(176, q2no0WnPxDaipZawxT.eV4vC1LZv);
		PubcpKtWxlVHTsr0dAk.IB3tMMvyI(gNlIVJNypM, ref sender, ref eventArgs, ref eventName, PubcpKtWxlVHTsr0dAk.j7ftJDXtjD);
	}

	public Task ExecuteAsync()
	{
		return PEcImVP5MK();
	}

	void ICommand.Execute(object parameter)
	{
		Mxptt2tbqgXMF9FeeZS.IB3tMMvyI(PEcImVP5MK(), ref r2hIM78nT0, ref IiTIxeZriO, Mxptt2tbqgXMF9FeeZS.RXdt7ev8qx);
	}
}
