using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;

namespace PROTV.Wpf.ViewModels;

public class ObservableObject : INotifyPropertyChanged, IDisposable
{
	private readonly ConcurrentDictionary<string, bool> F0OBrcnFph;

	private readonly bool b8bBHHWvTj;

	[CompilerGenerated]
	private PropertyChangedEventHandler m_PropertyChanged;

	public event PropertyChangedEventHandler PropertyChanged
	{
		[CompilerGenerated]
		add
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.m_PropertyChanged;
			PropertyChangedEventHandler propertyChangedEventHandler2;
			do
			{
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)YN50h3TKBBEbtvEUKm0.D35lls5iF(propertyChangedEventHandler2, value, YN50h3TKBBEbtvEUKm0.UVSTNPSpmU);
				propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
			}
			while ((object)propertyChangedEventHandler != propertyChangedEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.m_PropertyChanged;
			PropertyChangedEventHandler propertyChangedEventHandler2;
			do
			{
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)YN50h3TKBBEbtvEUKm0.D35lls5iF(propertyChangedEventHandler2, value, YN50h3TKBBEbtvEUKm0.cNqTORCAOn);
				propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
			}
			while ((object)propertyChangedEventHandler != propertyChangedEventHandler2);
		}
	}

	protected ObservableObject()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		this._002Ector(useDeferredNotifications: false);
	}

	protected ObservableObject(bool useDeferredNotifications)
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		F0OBrcnFph = new ConcurrentDictionary<string, bool>();
		base._002Ector();
		b8bBHHWvTj = useDeferredNotifications;
	}

	protected bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = "", string[] notifyAlso = null, Action onChanged = null, Func<T, T, bool> validateValue = null)
	{
		if (EqualityComparer<T>.Default.Equals(storage, value))
		{
			return false;
		}
		if (validateValue != null && !validateValue(storage, value))
		{
			return false;
		}
		storage = value;
		onChanged?.Invoke();
		q5vAdkTuFNJdfBYdxSJ.D35lls5iF(this, propertyName, notifyAlso, q5vAdkTuFNJdfBYdxSJ.YnRTPCGbT2);
		return true;
	}

	protected void NotifyPropertyChanged(params string[] propertyNames)
	{
		q5vAdkTuFNJdfBYdxSJ.D35lls5iF(this, null, propertyNames, q5vAdkTuFNJdfBYdxSJ.YnRTPCGbT2);
	}

	private void Q6wBeQJUdE(string P_0, string[] P_1)
	{
		if (!M6ZErPEr2LZyWYpa5O.D35lls5iF(P_0, M6ZErPEr2LZyWYpa5O.rg89aHbgYh))
		{
			F0OBrcnFph[P_0] = true;
		}
		if (P_1 != null)
		{
			foreach (string text in P_1)
			{
				if (!M6ZErPEr2LZyWYpa5O.D35lls5iF(text, M6ZErPEr2LZyWYpa5O.rg89aHbgYh))
				{
					F0OBrcnFph[text] = true;
				}
			}
		}
		if (b8bBHHWvTj)
		{
			a3TTJQTso6aV0tRVDMR.D35lls5iF(UqHBOCPKma, a3TTJQTso6aV0tRVDMR.sGbThM9cUf);
		}
		else
		{
			xLO56JniGyickVjO1Ot.D35lls5iF(this, xLO56JniGyickVjO1Ot.TKHTxIo8dW);
		}
	}

	private void UqHBOCPKma()
	{
		string[] array = F0OBrcnFph.Keys.ToArray();
		foreach (string text in array)
		{
			if (F0OBrcnFph[text])
			{
				try
				{
					qni3xrDkAJ3vF35eMav.D35lls5iF(this, text, qni3xrDkAJ3vF35eMav.QN6DuDtCWO);
				}
				finally
				{
					F0OBrcnFph[text] = false;
				}
			}
		}
	}

	public void OnPropertyChanged([CallerMemberName] string propertyName = "")
	{
		this.m_PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName ?? string.Empty));
	}

	public virtual void Dispose()
	{
	}
}
