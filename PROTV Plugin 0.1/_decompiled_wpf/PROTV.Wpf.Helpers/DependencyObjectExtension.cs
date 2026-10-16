using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;

namespace PROTV.Wpf.Helpers;

public static class DependencyObjectExtension
{
	[CompilerGenerated]
	private sealed class _003CGetVisualDescendants_003Ed__1 : IEnumerable<DependencyObject>, IEnumerable, IEnumerator<DependencyObject>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private DependencyObject _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private DependencyObject visual;

		public DependencyObject _003C_003E3__visual;

		private int _003Ci_003E5__2;

		private DependencyObject _003Cchild_003E5__3;

		private IEnumerator<DependencyObject> _003C_003E7__wrap3;

		DependencyObject IEnumerator<DependencyObject>.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public _003CGetVisualDescendants_003Ed__1(int _003C_003E1__state)
		{
			YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
			base._002Ector();
			this._003C_003E1__state = _003C_003E1__state;
			_003C_003El__initialThreadId = DwgsIttNEA2NshX7F1f.D35lls5iF(DwgsIttNEA2NshX7F1f.bsCtOtFCPy);
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			int num = _003C_003E1__state;
			if (num == -3 || num == 2)
			{
				try
				{
				}
				finally
				{
					YIm9yctLBn23GQIH06k.D35lls5iF(this, YIm9yctLBn23GQIH06k.ty6tu3x2RQ);
				}
			}
		}

		private bool MoveNext()
		{
			try
			{
				switch (_003C_003E1__state)
				{
				default:
					return false;
				case 0:
					_003C_003E1__state = -1;
					if (visual == null)
					{
						return false;
					}
					_003Ci_003E5__2 = 0;
					break;
				case 1:
					_003C_003E1__state = -1;
					_003C_003E7__wrap3 = YKV9BbGjMx0viR9GjJi.D35lls5iF(_003Cchild_003E5__3, YKV9BbGjMx0viR9GjJi.hQsGyRSMpu).GetEnumerator();
					_003C_003E1__state = -3;
					goto IL_00d3;
				case 2:
					{
						_003C_003E1__state = -3;
						goto IL_00d3;
					}
					IL_00d3:
					if (hjMnupQVVDlRZAYQJC.D35lls5iF(_003C_003E7__wrap3, hjMnupQVVDlRZAYQJC.QV1TFwytOj))
					{
						DependencyObject current = _003C_003E7__wrap3.Current;
						_003C_003E2__current = current;
						_003C_003E1__state = 2;
						return true;
					}
					YIm9yctLBn23GQIH06k.D35lls5iF(this, YIm9yctLBn23GQIH06k.ty6tu3x2RQ);
					_003C_003E7__wrap3 = null;
					_003Cchild_003E5__3 = null;
					_003Ci_003E5__2++;
					break;
				}
				if (_003Ci_003E5__2 < T9sNieeduAumIbMO43W.D35lls5iF(visual, T9sNieeduAumIbMO43W.YeDeUK3q8R))
				{
					_003Cchild_003E5__3 = tJmv7Vet2tiZMCree4E.D35lls5iF(visual, _003Ci_003E5__2, tJmv7Vet2tiZMCree4E.RWfeVmUdAF);
					_003C_003E2__current = _003Cchild_003E5__3;
					_003C_003E1__state = 1;
					return true;
				}
				return false;
			}
			catch
			{
				//try-fault
				YIm9yctLBn23GQIH06k.D35lls5iF(this, YIm9yctLBn23GQIH06k.juDtPoQDhj);
				throw;
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _003C_003Em__Finally1()
		{
			_003C_003E1__state = -1;
			if (_003C_003E7__wrap3 != null)
			{
				xLO56JniGyickVjO1Ot.D35lls5iF(_003C_003E7__wrap3, xLO56JniGyickVjO1Ot.ydbT2bsoH4);
			}
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		[DebuggerHidden]
		IEnumerator<DependencyObject> IEnumerable<DependencyObject>.GetEnumerator()
		{
			_003CGetVisualDescendants_003Ed__1 obj;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == DwgsIttNEA2NshX7F1f.D35lls5iF(DwgsIttNEA2NshX7F1f.bsCtOtFCPy))
			{
				_003C_003E1__state = 0;
				obj = this;
			}
			else
			{
				obj = new _003CGetVisualDescendants_003Ed__1(0);
			}
			obj.visual = _003C_003E3__visual;
			return obj;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return YvAvirtsK0bqTvZe6Cm.D35lls5iF(this, YvAvirtsK0bqTvZe6Cm.cJathvilm4);
		}
	}

	public static T GetVisualDescendant<T>(this DependencyObject visual) where T : DependencyObject
	{
		return (T)(object)YKV9BbGjMx0viR9GjJi.D35lls5iF(visual, YKV9BbGjMx0viR9GjJi.hQsGyRSMpu).FirstOrDefault((DependencyObject d) => d is T);
	}

	[IteratorStateMachine(typeof(_003CGetVisualDescendants_003Ed__1))]
	public static IEnumerable<DependencyObject> GetVisualDescendants(this DependencyObject visual)
	{
		//yield-return decompiler failed: Unexpected fault block contents in MoveNext()
		return new _003CGetVisualDescendants_003Ed__1(-2)
		{
			_003C_003E3__visual = visual
		};
	}

	public static T FindParentOfType<T>(this DependencyObject child) where T : class
	{
		DependencyObject val = Ay3UURGqrswmtonfScR.D35lls5iF(child, Ay3UURGqrswmtonfScR.hMlGJudNiF);
		if (val == null)
		{
			return null;
		}
		if (val is T result)
		{
			return result;
		}
		return val.FindParentOfType<T>();
	}
}
