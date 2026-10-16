using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using PROTV.Abstractions.Services;
using PROTV.Wpf.Bootstrap;

namespace PROTV.Wpf.Helpers;

public class PROTVHelper
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetPROTVConnectionStautus_003Ed__5 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		private IStoreContext _003C_store_003E5__2;

		private TaskAwaiter<bool> _003C_003Eu__1;

		private HttpClient _003Cclient_003E5__3;

		private TaskAwaiter<HttpResponseMessage> _003C_003Eu__2;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			try
			{
				TaskAwaiter<bool> awaiter;
				if (num != 0)
				{
					if (num == 1)
					{
						goto IL_0098;
					}
					_003C_store_003E5__2 = AppContainer.Resolve<IStoreContext>();
					awaiter = NOb5NR7e9efP4HjXkQh.D35lls5iF(CrrEFrkdve0aLZsgajd.D35lls5iF(CrrEFrkdve0aLZsgajd.uSs7rPWAhe), NOb5NR7e9efP4HjXkQh.XII7GQcVIN).GetAwaiter();
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
					_003C_003Eu__1 = default(TaskAwaiter<bool>);
					num = (_003C_003E1__state = -1);
				}
				if (awaiter.GetResult())
				{
					goto IL_0098;
				}
				jPB9Q5LdIM9wsuWV1q7.D35lls5iF(_003C_store_003E5__2, false, jPB9Q5LdIM9wsuWV1q7.Iul7vHv4AP);
				m5sZxWmLHUhVHrJe8sC.D35lls5iF(_003C_store_003E5__2, iFZ5je3XFYKwkvcE5D.D35lls5iF(17064, iFZ5je3XFYKwkvcE5D.N06TeK0ao), m5sZxWmLHUhVHrJe8sC.qTK7A57CI8);
				goto end_IL_000e;
				IL_0098:
				try
				{
					if (num != 1)
					{
						_003Cclient_003E5__3 = new HttpClient();
					}
					try
					{
						TaskAwaiter<HttpResponseMessage> awaiter2;
						if (num != 1)
						{
							awaiter2 = xsEQxE7RWpQnSQqqFhI.D35lls5iF(_003Cclient_003E5__3, iFZ5je3XFYKwkvcE5D.D35lls5iF(17010, iFZ5je3XFYKwkvcE5D.N06TeK0ao), xsEQxE7RWpQnSQqqFhI.wWT7kqjaq4).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num = (_003C_003E1__state = 1);
								_003C_003Eu__2 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
						}
						else
						{
							awaiter2 = _003C_003Eu__2;
							_003C_003Eu__2 = default(TaskAwaiter<HttpResponseMessage>);
							num = (_003C_003E1__state = -1);
						}
						awaiter2.GetResult();
						jPB9Q5LdIM9wsuWV1q7.D35lls5iF(_003C_store_003E5__2, true, jPB9Q5LdIM9wsuWV1q7.Iul7vHv4AP);
						m5sZxWmLHUhVHrJe8sC.D35lls5iF(_003C_store_003E5__2, iFZ5je3XFYKwkvcE5D.D35lls5iF(14312, iFZ5je3XFYKwkvcE5D.N06TeK0ao), m5sZxWmLHUhVHrJe8sC.qTK7A57CI8);
					}
					finally
					{
						if (num < 0 && _003Cclient_003E5__3 != null)
						{
							xLO56JniGyickVjO1Ot.D35lls5iF(_003Cclient_003E5__3, xLO56JniGyickVjO1Ot.ydbT2bsoH4);
						}
					}
					_003Cclient_003E5__3 = null;
				}
				catch
				{
					jPB9Q5LdIM9wsuWV1q7.D35lls5iF(_003C_store_003E5__2, false, jPB9Q5LdIM9wsuWV1q7.Iul7vHv4AP);
					m5sZxWmLHUhVHrJe8sC.D35lls5iF(_003C_store_003E5__2, iFZ5je3XFYKwkvcE5D.D35lls5iF(14346, iFZ5je3XFYKwkvcE5D.N06TeK0ao), m5sZxWmLHUhVHrJe8sC.qTK7A57CI8);
				}
				end_IL_000e:;
			}
			catch (Exception ex)
			{
				_003C_003E1__state = -2;
				_003C_store_003E5__2 = null;
				NNK1eXA7fWQ87oSUty7.D35lls5iF(ref _003C_003Et__builder, ex, NNK1eXA7fWQ87oSUty7.G3EAcW9Om7);
				return;
			}
			_003C_003E1__state = -2;
			_003C_store_003E5__2 = null;
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

	public static string GetString(string key)
	{
		return auEPOZ1NWYKXdU711jq.D35lls5iF(Jr0pTQlovwB9pdID1EB.D35lls5iF(Jr0pTQlovwB9pdID1EB.CxrllgXtD4), key, auEPOZ1NWYKXdU711jq.GKLkm1yf4o) as string;
	}

	public static string GetString(string separator = ";", params string[] keyArr)
	{
		return tsvRNikaEmwAtSIhcw4.D35lls5iF(separator, keyArr.Select((string key) => auEPOZ1NWYKXdU711jq.D35lls5iF(Jr0pTQlovwB9pdID1EB.D35lls5iF(Jr0pTQlovwB9pdID1EB.CxrllgXtD4), key, auEPOZ1NWYKXdU711jq.GKLkm1yf4o) as string).ToList(), tsvRNikaEmwAtSIhcw4.uxTkI5QKnF);
	}

	public static List<string> GetStringList(params string[] keyArr)
	{
		return keyArr.Select((string key) => auEPOZ1NWYKXdU711jq.D35lls5iF(Jr0pTQlovwB9pdID1EB.D35lls5iF(Jr0pTQlovwB9pdID1EB.CxrllgXtD4), key, auEPOZ1NWYKXdU711jq.GKLkm1yf4o) as string).ToList();
	}

	public static T GetResource<T>(string key)
	{
		object obj = auEPOZ1NWYKXdU711jq.D35lls5iF(Jr0pTQlovwB9pdID1EB.D35lls5iF(Jr0pTQlovwB9pdID1EB.CxrllgXtD4), key, auEPOZ1NWYKXdU711jq.GKLkm1yf4o);
		if (obj is T)
		{
			return (T)obj;
		}
		return default(T);
	}

	public static string GetImageAbsoluteRoute(bool IsInternal, string ApiRoute)
	{
		if (M6ZErPEr2LZyWYpa5O.D35lls5iF(ApiRoute, M6ZErPEr2LZyWYpa5O.tZ53SRMKfw))
		{
			return "";
		}
		string text = "";
		text = ((!IsInternal) ? CrrEFrkdve0aLZsgajd.D35lls5iF(CrrEFrkdve0aLZsgajd.gwMktcYP6r) : CrrEFrkdve0aLZsgajd.D35lls5iF(CrrEFrkdve0aLZsgajd.jPokUZCBZB));
		return UwSEfC4rh9eVlFenwI.D35lls5iF(text, ApiRoute, UwSEfC4rh9eVlFenwI.BPNLUJNA3);
	}

	[AsyncStateMachine(typeof(_003CGetPROTVConnectionStautus_003Ed__5))]
	public static Task GetPROTVConnectionStautus()
	{
		_003CGetPROTVConnectionStautus_003Ed__5 stateMachine = default(_003CGetPROTVConnectionStautus_003Ed__5);
		stateMachine._003C_003Et__builder = uE6jkMCH6YsWbbVUWh.D35lls5iF(uE6jkMCH6YsWbbVUWh.YZdmLGYQ6);
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return ImxWYFaaXbRtc3peaZ.D35lls5iF(ref stateMachine._003C_003Et__builder, ImxWYFaaXbRtc3peaZ.VTlIUjPUC);
	}

	public PROTVHelper()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector();
	}
}
