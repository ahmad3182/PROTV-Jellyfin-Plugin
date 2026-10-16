using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;

namespace PROTV.Wpf.Helpers;

public static class TreeExtensions
{
	[CompilerGenerated]
	private sealed class _003CDescendants_003Ed__0 : IEnumerable<DependencyObject>, IEnumerable, IEnumerator<DependencyObject>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private DependencyObject _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private DependencyObject item;

		public DependencyObject _003C_003E3__item;

		private IEnumerator<DependencyObject> _003C_003E7__wrap1;

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
		public _003CDescendants_003Ed__0(int _003C_003E1__state)
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
			if ((uint)(num - -4) > 1u && (uint)(num - 1) > 1u)
			{
				return;
			}
			try
			{
				if (num != -4 && num != 2)
				{
					return;
				}
				try
				{
				}
				finally
				{
					YIm9yctLBn23GQIH06k.D35lls5iF(this, YIm9yctLBn23GQIH06k.rGJVX6A60r);
				}
			}
			finally
			{
				YIm9yctLBn23GQIH06k.D35lls5iF(this, YIm9yctLBn23GQIH06k.hY1VffYlyf);
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
				{
					_003C_003E1__state = -1;
					ILinqTree<DependencyObject> linqTree = new VisualTreeAdapter(item);
					_003C_003E7__wrap1 = linqTree.Children().GetEnumerator();
					_003C_003E1__state = -3;
					break;
				}
				case 1:
					_003C_003E1__state = -3;
					_003C_003E7__wrap3 = YKV9BbGjMx0viR9GjJi.D35lls5iF(_003Cchild_003E5__3, YKV9BbGjMx0viR9GjJi.R0dR2pwj1L).GetEnumerator();
					_003C_003E1__state = -4;
					goto IL_00d5;
				case 2:
					{
						_003C_003E1__state = -4;
						goto IL_00d5;
					}
					IL_00d5:
					if (hjMnupQVVDlRZAYQJC.D35lls5iF(_003C_003E7__wrap3, hjMnupQVVDlRZAYQJC.QV1TFwytOj))
					{
						DependencyObject current = _003C_003E7__wrap3.Current;
						_003C_003E2__current = current;
						_003C_003E1__state = 2;
						return true;
					}
					YIm9yctLBn23GQIH06k.D35lls5iF(this, YIm9yctLBn23GQIH06k.rGJVX6A60r);
					_003C_003E7__wrap3 = null;
					_003Cchild_003E5__3 = null;
					break;
				}
				if (hjMnupQVVDlRZAYQJC.D35lls5iF(_003C_003E7__wrap1, hjMnupQVVDlRZAYQJC.QV1TFwytOj))
				{
					_003Cchild_003E5__3 = _003C_003E7__wrap1.Current;
					_003C_003E2__current = _003Cchild_003E5__3;
					_003C_003E1__state = 1;
					return true;
				}
				YIm9yctLBn23GQIH06k.D35lls5iF(this, YIm9yctLBn23GQIH06k.hY1VffYlyf);
				_003C_003E7__wrap1 = null;
				return false;
			}
			catch
			{
				//try-fault
				YIm9yctLBn23GQIH06k.D35lls5iF(this, YIm9yctLBn23GQIH06k.lWyVFS8VPW);
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
			if (_003C_003E7__wrap1 != null)
			{
				xLO56JniGyickVjO1Ot.D35lls5iF(_003C_003E7__wrap1, xLO56JniGyickVjO1Ot.ydbT2bsoH4);
			}
		}

		private void _003C_003Em__Finally2()
		{
			_003C_003E1__state = -3;
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
			_003CDescendants_003Ed__0 obj;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == DwgsIttNEA2NshX7F1f.D35lls5iF(DwgsIttNEA2NshX7F1f.bsCtOtFCPy))
			{
				_003C_003E1__state = 0;
				obj = this;
			}
			else
			{
				obj = new _003CDescendants_003Ed__0(0);
			}
			obj.item = _003C_003E3__item;
			return obj;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return YvAvirtsK0bqTvZe6Cm.D35lls5iF(this, YvAvirtsK0bqTvZe6Cm.wMPV2CtfCs);
		}
	}

	[CompilerGenerated]
	private sealed class _003CDescendantsAndSelf_003Ed__1 : IEnumerable<DependencyObject>, IEnumerable, IEnumerator<DependencyObject>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private DependencyObject _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private DependencyObject item;

		public DependencyObject _003C_003E3__item;

		private IEnumerator<DependencyObject> _003C_003E7__wrap1;

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
		public _003CDescendantsAndSelf_003Ed__1(int _003C_003E1__state)
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
					YIm9yctLBn23GQIH06k.D35lls5iF(this, YIm9yctLBn23GQIH06k.Vo9VZILJHg);
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
					_003C_003E2__current = item;
					_003C_003E1__state = 1;
					return true;
				case 1:
					_003C_003E1__state = -1;
					_003C_003E7__wrap1 = YKV9BbGjMx0viR9GjJi.D35lls5iF(item, YKV9BbGjMx0viR9GjJi.R0dR2pwj1L).GetEnumerator();
					_003C_003E1__state = -3;
					break;
				case 2:
					_003C_003E1__state = -3;
					break;
				}
				if (hjMnupQVVDlRZAYQJC.D35lls5iF(_003C_003E7__wrap1, hjMnupQVVDlRZAYQJC.QV1TFwytOj))
				{
					DependencyObject current = _003C_003E7__wrap1.Current;
					_003C_003E2__current = current;
					_003C_003E1__state = 2;
					return true;
				}
				YIm9yctLBn23GQIH06k.D35lls5iF(this, YIm9yctLBn23GQIH06k.Vo9VZILJHg);
				_003C_003E7__wrap1 = null;
				return false;
			}
			catch
			{
				//try-fault
				YIm9yctLBn23GQIH06k.D35lls5iF(this, YIm9yctLBn23GQIH06k.OUyVjLEPra);
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
			if (_003C_003E7__wrap1 != null)
			{
				xLO56JniGyickVjO1Ot.D35lls5iF(_003C_003E7__wrap1, xLO56JniGyickVjO1Ot.ydbT2bsoH4);
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
			_003CDescendantsAndSelf_003Ed__1 obj;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == DwgsIttNEA2NshX7F1f.D35lls5iF(DwgsIttNEA2NshX7F1f.bsCtOtFCPy))
			{
				_003C_003E1__state = 0;
				obj = this;
			}
			else
			{
				obj = new _003CDescendantsAndSelf_003Ed__1(0);
			}
			obj.item = _003C_003E3__item;
			return obj;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return YvAvirtsK0bqTvZe6Cm.D35lls5iF(this, YvAvirtsK0bqTvZe6Cm.kujVyDnT03);
		}
	}

	[CompilerGenerated]
	private sealed class _003CAncestorsAndSelf_003Ed__3 : IEnumerable<DependencyObject>, IEnumerable, IEnumerator<DependencyObject>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private DependencyObject _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private DependencyObject item;

		public DependencyObject _003C_003E3__item;

		private IEnumerator<DependencyObject> _003C_003E7__wrap1;

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
		public _003CAncestorsAndSelf_003Ed__3(int _003C_003E1__state)
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
					YIm9yctLBn23GQIH06k.D35lls5iF(this, YIm9yctLBn23GQIH06k.HOxVJSpWLn);
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
					_003C_003E2__current = item;
					_003C_003E1__state = 1;
					return true;
				case 1:
					_003C_003E1__state = -1;
					_003C_003E7__wrap1 = YKV9BbGjMx0viR9GjJi.D35lls5iF(item, YKV9BbGjMx0viR9GjJi.hATRqiijGA).GetEnumerator();
					_003C_003E1__state = -3;
					break;
				case 2:
					_003C_003E1__state = -3;
					break;
				}
				if (hjMnupQVVDlRZAYQJC.D35lls5iF(_003C_003E7__wrap1, hjMnupQVVDlRZAYQJC.QV1TFwytOj))
				{
					DependencyObject current = _003C_003E7__wrap1.Current;
					_003C_003E2__current = current;
					_003C_003E1__state = 2;
					return true;
				}
				YIm9yctLBn23GQIH06k.D35lls5iF(this, YIm9yctLBn23GQIH06k.HOxVJSpWLn);
				_003C_003E7__wrap1 = null;
				return false;
			}
			catch
			{
				//try-fault
				YIm9yctLBn23GQIH06k.D35lls5iF(this, YIm9yctLBn23GQIH06k.M2PVbnIQYJ);
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
			if (_003C_003E7__wrap1 != null)
			{
				xLO56JniGyickVjO1Ot.D35lls5iF(_003C_003E7__wrap1, xLO56JniGyickVjO1Ot.ydbT2bsoH4);
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
			_003CAncestorsAndSelf_003Ed__3 obj;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == DwgsIttNEA2NshX7F1f.D35lls5iF(DwgsIttNEA2NshX7F1f.bsCtOtFCPy))
			{
				_003C_003E1__state = 0;
				obj = this;
			}
			else
			{
				obj = new _003CAncestorsAndSelf_003Ed__3(0);
			}
			obj.item = _003C_003E3__item;
			return obj;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return YvAvirtsK0bqTvZe6Cm.D35lls5iF(this, YvAvirtsK0bqTvZe6Cm.C8pVWpXudE);
		}
	}

	[CompilerGenerated]
	private sealed class _003CElements_003Ed__4 : IEnumerable<DependencyObject>, IEnumerable, IEnumerator<DependencyObject>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private DependencyObject _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private DependencyObject item;

		public DependencyObject _003C_003E3__item;

		private IEnumerator<DependencyObject> _003C_003E7__wrap1;

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
		public _003CElements_003Ed__4(int _003C_003E1__state)
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
			if (num == -3 || num == 1)
			{
				try
				{
				}
				finally
				{
					YIm9yctLBn23GQIH06k.D35lls5iF(this, YIm9yctLBn23GQIH06k.nbnV5YbuPx);
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
				{
					_003C_003E1__state = -1;
					ILinqTree<DependencyObject> linqTree = new VisualTreeAdapter(item);
					_003C_003E7__wrap1 = linqTree.Children().GetEnumerator();
					_003C_003E1__state = -3;
					break;
				}
				case 1:
					_003C_003E1__state = -3;
					break;
				}
				if (hjMnupQVVDlRZAYQJC.D35lls5iF(_003C_003E7__wrap1, hjMnupQVVDlRZAYQJC.QV1TFwytOj))
				{
					DependencyObject current = _003C_003E7__wrap1.Current;
					_003C_003E2__current = current;
					_003C_003E1__state = 1;
					return true;
				}
				YIm9yctLBn23GQIH06k.D35lls5iF(this, YIm9yctLBn23GQIH06k.nbnV5YbuPx);
				_003C_003E7__wrap1 = null;
				return false;
			}
			catch
			{
				//try-fault
				YIm9yctLBn23GQIH06k.D35lls5iF(this, YIm9yctLBn23GQIH06k.WKdVzpfjLC);
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
			if (_003C_003E7__wrap1 != null)
			{
				xLO56JniGyickVjO1Ot.D35lls5iF(_003C_003E7__wrap1, xLO56JniGyickVjO1Ot.ydbT2bsoH4);
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
			_003CElements_003Ed__4 obj;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == DwgsIttNEA2NshX7F1f.D35lls5iF(DwgsIttNEA2NshX7F1f.bsCtOtFCPy))
			{
				_003C_003E1__state = 0;
				obj = this;
			}
			else
			{
				obj = new _003CElements_003Ed__4(0);
			}
			obj.item = _003C_003E3__item;
			return obj;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return YvAvirtsK0bqTvZe6Cm.D35lls5iF(this, YvAvirtsK0bqTvZe6Cm.Gli7o4UiIv);
		}
	}

	[CompilerGenerated]
	private sealed class _003CElementsBeforeSelf_003Ed__5 : IEnumerable<DependencyObject>, IEnumerable, IEnumerator<DependencyObject>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private DependencyObject _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private DependencyObject item;

		public DependencyObject _003C_003E3__item;

		private IEnumerator<DependencyObject> _003C_003E7__wrap1;

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
		public _003CElementsBeforeSelf_003Ed__5(int _003C_003E1__state)
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
			if (num == -3 || num == 1)
			{
				try
				{
				}
				finally
				{
					YIm9yctLBn23GQIH06k.D35lls5iF(this, YIm9yctLBn23GQIH06k.EC17lVm4HI);
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
					if (YKV9BbGjMx0viR9GjJi.D35lls5iF(item, YKV9BbGjMx0viR9GjJi.hATRqiijGA).FirstOrDefault() == null)
					{
						return false;
					}
					_003C_003E7__wrap1 = YKV9BbGjMx0viR9GjJi.D35lls5iF(YKV9BbGjMx0viR9GjJi.D35lls5iF(item, YKV9BbGjMx0viR9GjJi.hATRqiijGA).First(), YKV9BbGjMx0viR9GjJi.uI5Rb2jJmH).GetEnumerator();
					_003C_003E1__state = -3;
					break;
				case 1:
					_003C_003E1__state = -3;
					break;
				}
				if (hjMnupQVVDlRZAYQJC.D35lls5iF(_003C_003E7__wrap1, hjMnupQVVDlRZAYQJC.QV1TFwytOj))
				{
					DependencyObject current = _003C_003E7__wrap1.Current;
					if (!GmMLaTD7kV8rq88ZFvR.D35lls5iF(current, item, GmMLaTD7kV8rq88ZFvR.BQ5Dcmx5Pp))
					{
						_003C_003E2__current = current;
						_003C_003E1__state = 1;
						return true;
					}
				}
				YIm9yctLBn23GQIH06k.D35lls5iF(this, YIm9yctLBn23GQIH06k.EC17lVm4HI);
				_003C_003E7__wrap1 = null;
				return false;
			}
			catch
			{
				//try-fault
				YIm9yctLBn23GQIH06k.D35lls5iF(this, YIm9yctLBn23GQIH06k.BiS79WwpO3);
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
			if (_003C_003E7__wrap1 != null)
			{
				xLO56JniGyickVjO1Ot.D35lls5iF(_003C_003E7__wrap1, xLO56JniGyickVjO1Ot.ydbT2bsoH4);
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
			_003CElementsBeforeSelf_003Ed__5 obj;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == DwgsIttNEA2NshX7F1f.D35lls5iF(DwgsIttNEA2NshX7F1f.bsCtOtFCPy))
			{
				_003C_003E1__state = 0;
				obj = this;
			}
			else
			{
				obj = new _003CElementsBeforeSelf_003Ed__5(0);
			}
			obj.item = _003C_003E3__item;
			return obj;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return YvAvirtsK0bqTvZe6Cm.D35lls5iF(this, YvAvirtsK0bqTvZe6Cm.ifP7DD0kfO);
		}
	}

	[CompilerGenerated]
	private sealed class _003CElementsAfterSelf_003Ed__6 : IEnumerable<DependencyObject>, IEnumerable, IEnumerator<DependencyObject>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private DependencyObject _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private DependencyObject item;

		public DependencyObject _003C_003E3__item;

		private bool _003CafterSelf_003E5__2;

		private IEnumerator<DependencyObject> _003C_003E7__wrap2;

		private DependencyObject _003Cchild_003E5__4;

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
		public _003CElementsAfterSelf_003Ed__6(int _003C_003E1__state)
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
			if (num == -3 || num == 1)
			{
				try
				{
				}
				finally
				{
					YIm9yctLBn23GQIH06k.D35lls5iF(this, YIm9yctLBn23GQIH06k.S9L7HeVKRl);
				}
			}
		}

		private bool MoveNext()
		{
			try
			{
				int num = _003C_003E1__state;
				if (num != 0)
				{
					if (num != 1)
					{
						return false;
					}
					_003C_003E1__state = -3;
					goto IL_00bf;
				}
				_003C_003E1__state = -1;
				if (YKV9BbGjMx0viR9GjJi.D35lls5iF(item, YKV9BbGjMx0viR9GjJi.hATRqiijGA).FirstOrDefault() == null)
				{
					return false;
				}
				_003CafterSelf_003E5__2 = false;
				_003C_003E7__wrap2 = YKV9BbGjMx0viR9GjJi.D35lls5iF(YKV9BbGjMx0viR9GjJi.D35lls5iF(item, YKV9BbGjMx0viR9GjJi.hATRqiijGA).First(), YKV9BbGjMx0viR9GjJi.uI5Rb2jJmH).GetEnumerator();
				_003C_003E1__state = -3;
				goto IL_00e8;
				IL_00bf:
				if (GmMLaTD7kV8rq88ZFvR.D35lls5iF(_003Cchild_003E5__4, item, GmMLaTD7kV8rq88ZFvR.BQ5Dcmx5Pp))
				{
					_003CafterSelf_003E5__2 = true;
				}
				_003Cchild_003E5__4 = null;
				goto IL_00e8;
				IL_00e8:
				if (hjMnupQVVDlRZAYQJC.D35lls5iF(_003C_003E7__wrap2, hjMnupQVVDlRZAYQJC.QV1TFwytOj))
				{
					_003Cchild_003E5__4 = _003C_003E7__wrap2.Current;
					if (_003CafterSelf_003E5__2)
					{
						_003C_003E2__current = _003Cchild_003E5__4;
						_003C_003E1__state = 1;
						return true;
					}
					goto IL_00bf;
				}
				YIm9yctLBn23GQIH06k.D35lls5iF(this, YIm9yctLBn23GQIH06k.S9L7HeVKRl);
				_003C_003E7__wrap2 = null;
				return false;
			}
			catch
			{
				//try-fault
				YIm9yctLBn23GQIH06k.D35lls5iF(this, YIm9yctLBn23GQIH06k.MmJ71KM5AO);
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
			if (_003C_003E7__wrap2 != null)
			{
				xLO56JniGyickVjO1Ot.D35lls5iF(_003C_003E7__wrap2, xLO56JniGyickVjO1Ot.ydbT2bsoH4);
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
			_003CElementsAfterSelf_003Ed__6 obj;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == DwgsIttNEA2NshX7F1f.D35lls5iF(DwgsIttNEA2NshX7F1f.bsCtOtFCPy))
			{
				_003C_003E1__state = 0;
				obj = this;
			}
			else
			{
				obj = new _003CElementsAfterSelf_003Ed__6(0);
			}
			obj.item = _003C_003E3__item;
			return obj;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return YvAvirtsK0bqTvZe6Cm.D35lls5iF(this, YvAvirtsK0bqTvZe6Cm.nPi78DHjrX);
		}
	}

	[CompilerGenerated]
	private sealed class _003CElementsAndSelf_003Ed__7 : IEnumerable<DependencyObject>, IEnumerable, IEnumerator<DependencyObject>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private DependencyObject _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private DependencyObject item;

		public DependencyObject _003C_003E3__item;

		private IEnumerator<DependencyObject> _003C_003E7__wrap1;

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
		public _003CElementsAndSelf_003Ed__7(int _003C_003E1__state)
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
					YIm9yctLBn23GQIH06k.D35lls5iF(this, YIm9yctLBn23GQIH06k.Tai7nl1YkN);
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
					_003C_003E2__current = item;
					_003C_003E1__state = 1;
					return true;
				case 1:
					_003C_003E1__state = -1;
					_003C_003E7__wrap1 = YKV9BbGjMx0viR9GjJi.D35lls5iF(item, YKV9BbGjMx0viR9GjJi.uI5Rb2jJmH).GetEnumerator();
					_003C_003E1__state = -3;
					break;
				case 2:
					_003C_003E1__state = -3;
					break;
				}
				if (hjMnupQVVDlRZAYQJC.D35lls5iF(_003C_003E7__wrap1, hjMnupQVVDlRZAYQJC.QV1TFwytOj))
				{
					DependencyObject current = _003C_003E7__wrap1.Current;
					_003C_003E2__current = current;
					_003C_003E1__state = 2;
					return true;
				}
				YIm9yctLBn23GQIH06k.D35lls5iF(this, YIm9yctLBn23GQIH06k.Tai7nl1YkN);
				_003C_003E7__wrap1 = null;
				return false;
			}
			catch
			{
				//try-fault
				vVrjdw73IXOSPm7hUTt.D35lls5iF(this, vVrjdw73IXOSPm7hUTt.erM7Th7yKy);
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
			if (_003C_003E7__wrap1 != null)
			{
				xLO56JniGyickVjO1Ot.D35lls5iF(_003C_003E7__wrap1, xLO56JniGyickVjO1Ot.ydbT2bsoH4);
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
			_003CElementsAndSelf_003Ed__7 obj;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == DwgsIttNEA2NshX7F1f.D35lls5iF(DwgsIttNEA2NshX7F1f.bsCtOtFCPy))
			{
				_003C_003E1__state = 0;
				obj = this;
			}
			else
			{
				obj = new _003CElementsAndSelf_003Ed__7(0);
			}
			obj.item = _003C_003E3__item;
			return obj;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return YvAvirtsK0bqTvZe6Cm.D35lls5iF(this, YvAvirtsK0bqTvZe6Cm.IGG7411Xi3);
		}
	}

	[IteratorStateMachine(typeof(_003CDescendants_003Ed__0))]
	public static IEnumerable<DependencyObject> Descendants(this DependencyObject item)
	{
		// ILSpy could not decompile this. Please report the exception below,
		// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
		// System.ArgumentException: An item with the same key has already been added. Key: 06001485 YIm9yctLBn23GQIH06k.D35lls5iF
		//    at System.Collections.Generic.Dictionary`2.TryInsert(TKey key, TValue value, InsertionBehavior behavior)
		//    at System.Collections.Generic.Dictionary`2.Add(TKey key, TValue value)
		//    at ICSharpCode.Decompiler.IL.ControlFlow.StateRangeAnalysis.AssignStateRanges(ILInstruction inst, LongSet stateRange) in /_/ICSharpCode.Decompiler/IL/ControlFlow/StateRangeAnalysis.cs:line 209
		//    at ICSharpCode.Decompiler.IL.ControlFlow.StateRangeAnalysis.AssignStateRanges(ILInstruction inst, LongSet stateRange) in /_/ICSharpCode.Decompiler/IL/ControlFlow/StateRangeAnalysis.cs:line 140
		//    at ICSharpCode.Decompiler.IL.ControlFlow.StateRangeAnalysis.AssignStateRanges(ILInstruction inst, LongSet stateRange) in /_/ICSharpCode.Decompiler/IL/ControlFlow/StateRangeAnalysis.cs:line 128
		//    at ICSharpCode.Decompiler.IL.ControlFlow.StateRangeAnalysis.AssignStateRanges(ILInstruction inst, LongSet stateRange) in /_/ICSharpCode.Decompiler/IL/ControlFlow/StateRangeAnalysis.cs:line 152
		//    at ICSharpCode.Decompiler.IL.ControlFlow.StateRangeAnalysis.AssignStateRanges(ILInstruction inst, LongSet stateRange) in /_/ICSharpCode.Decompiler/IL/ControlFlow/StateRangeAnalysis.cs:line 140
		//    at ICSharpCode.Decompiler.IL.ControlFlow.StateRangeAnalysis.AssignStateRanges(ILInstruction inst, LongSet stateRange) in /_/ICSharpCode.Decompiler/IL/ControlFlow/StateRangeAnalysis.cs:line 128
		//    at ICSharpCode.Decompiler.IL.ControlFlow.YieldReturnDecompiler.ConstructExceptionTable() in /_/ICSharpCode.Decompiler/IL/ControlFlow/YieldReturnDecompiler.cs:line 630
		//    at ICSharpCode.Decompiler.IL.ControlFlow.YieldReturnDecompiler.Run(ILFunction function, ILTransformContext context) in /_/ICSharpCode.Decompiler/IL/ControlFlow/YieldReturnDecompiler.cs:line 151
		//    at ICSharpCode.Decompiler.CSharp.CSharpDecompiler.DecompileBody(IMethod method, EntityDeclaration entityDecl, DecompileRun decompileRun, ITypeResolveContext decompilationContext, ExtensionInfo extensionInfo) in /_/ICSharpCode.Decompiler/CSharp/CSharpDecompiler.cs:line 2304
	}

	[IteratorStateMachine(typeof(_003CDescendantsAndSelf_003Ed__1))]
	public static IEnumerable<DependencyObject> DescendantsAndSelf(this DependencyObject item)
	{
		//yield-return decompiler failed: Unexpected fault block contents in MoveNext()
		return new _003CDescendantsAndSelf_003Ed__1(-2)
		{
			_003C_003E3__item = item
		};
	}

	public static IEnumerable<DependencyObject> Ancestors(this DependencyObject item)
	{
		ILinqTree<DependencyObject> linqTree = new VisualTreeAdapter(item);
		for (DependencyObject parent = linqTree.Parent; parent != null; parent = linqTree.Parent)
		{
			yield return parent;
			linqTree = new VisualTreeAdapter(parent);
		}
	}

	[IteratorStateMachine(typeof(_003CAncestorsAndSelf_003Ed__3))]
	public static IEnumerable<DependencyObject> AncestorsAndSelf(this DependencyObject item)
	{
		//yield-return decompiler failed: Unexpected fault block contents in MoveNext()
		return new _003CAncestorsAndSelf_003Ed__3(-2)
		{
			_003C_003E3__item = item
		};
	}

	[IteratorStateMachine(typeof(_003CElements_003Ed__4))]
	public static IEnumerable<DependencyObject> Elements(this DependencyObject item)
	{
		//yield-return decompiler failed: Unexpected fault block contents in MoveNext()
		return new _003CElements_003Ed__4(-2)
		{
			_003C_003E3__item = item
		};
	}

	[IteratorStateMachine(typeof(_003CElementsBeforeSelf_003Ed__5))]
	public static IEnumerable<DependencyObject> ElementsBeforeSelf(this DependencyObject item)
	{
		//yield-return decompiler failed: Unexpected fault block contents in MoveNext()
		return new _003CElementsBeforeSelf_003Ed__5(-2)
		{
			_003C_003E3__item = item
		};
	}

	[IteratorStateMachine(typeof(_003CElementsAfterSelf_003Ed__6))]
	public static IEnumerable<DependencyObject> ElementsAfterSelf(this DependencyObject item)
	{
		//yield-return decompiler failed: Unexpected fault block contents in MoveNext()
		return new _003CElementsAfterSelf_003Ed__6(-2)
		{
			_003C_003E3__item = item
		};
	}

	[IteratorStateMachine(typeof(_003CElementsAndSelf_003Ed__7))]
	public static IEnumerable<DependencyObject> ElementsAndSelf(this DependencyObject item)
	{
		//yield-return decompiler failed: Unexpected fault block contents in MoveNext()
		return new _003CElementsAndSelf_003Ed__7(-2)
		{
			_003C_003E3__item = item
		};
	}

	public static IEnumerable<DependencyObject> Descendants<T>(this DependencyObject item)
	{
		return (from i in YKV9BbGjMx0viR9GjJi.D35lls5iF(item, YKV9BbGjMx0viR9GjJi.R0dR2pwj1L)
			where i is T
			select i).Cast<DependencyObject>();
	}

	public static IEnumerable<DependencyObject> ElementsBeforeSelf<T>(this DependencyObject item)
	{
		return (from i in YKV9BbGjMx0viR9GjJi.D35lls5iF(item, YKV9BbGjMx0viR9GjJi.U4vRZ4neEg)
			where i is T
			select i).Cast<DependencyObject>();
	}

	public static IEnumerable<DependencyObject> ElementsAfterSelf<T>(this DependencyObject item)
	{
		return (from i in YKV9BbGjMx0viR9GjJi.D35lls5iF(item, YKV9BbGjMx0viR9GjJi.xRZRjUJckR)
			where i is T
			select i).Cast<DependencyObject>();
	}

	public static IEnumerable<DependencyObject> DescendantsAndSelf<T>(this DependencyObject item)
	{
		return (from i in YKV9BbGjMx0viR9GjJi.D35lls5iF(item, YKV9BbGjMx0viR9GjJi.ud4RyDfJyb)
			where i is T
			select i).Cast<DependencyObject>();
	}

	public static IEnumerable<DependencyObject> Ancestors<T>(this DependencyObject item)
	{
		return (from i in YKV9BbGjMx0viR9GjJi.D35lls5iF(item, YKV9BbGjMx0viR9GjJi.hATRqiijGA)
			where i is T
			select i).Cast<DependencyObject>();
	}

	public static IEnumerable<DependencyObject> AncestorsAndSelf<T>(this DependencyObject item)
	{
		return (from i in YKV9BbGjMx0viR9GjJi.D35lls5iF(item, YKV9BbGjMx0viR9GjJi.NGVRJfgWJP)
			where i is T
			select i).Cast<DependencyObject>();
	}

	public static IEnumerable<DependencyObject> Elements<T>(this DependencyObject item)
	{
		return (from i in YKV9BbGjMx0viR9GjJi.D35lls5iF(item, YKV9BbGjMx0viR9GjJi.uI5Rb2jJmH)
			where i is T
			select i).Cast<DependencyObject>();
	}

	public static IEnumerable<DependencyObject> ElementsAndSelf<T>(this DependencyObject item)
	{
		return (from i in YKV9BbGjMx0viR9GjJi.D35lls5iF(item, YKV9BbGjMx0viR9GjJi.SinRWZh7Pr)
			where i is T
			select i).Cast<DependencyObject>();
	}
}
