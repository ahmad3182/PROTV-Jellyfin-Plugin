using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;

namespace PROTV.Wpf.Helpers;

public static class EnumerableTreeExtensions
{
	[CompilerGenerated]
	private sealed class _003CDrillDown_003Ed__0 : IEnumerable<DependencyObject>, IEnumerable, IEnumerator<DependencyObject>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private DependencyObject _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private IEnumerable<DependencyObject> items;

		public IEnumerable<DependencyObject> _003C_003E3__items;

		private Func<DependencyObject, IEnumerable<DependencyObject>> function;

		public Func<DependencyObject, IEnumerable<DependencyObject>> _003C_003E3__function;

		private IEnumerator<DependencyObject> _003C_003E7__wrap1;

		private IEnumerator<DependencyObject> _003C_003E7__wrap2;

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
		public _003CDrillDown_003Ed__0(int _003C_003E1__state)
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
			if ((uint)(num - -4) > 1u && num != 1)
			{
				return;
			}
			try
			{
				if (num != -4 && num != 1)
				{
					return;
				}
				try
				{
				}
				finally
				{
					vVrjdw73IXOSPm7hUTt.D35lls5iF(this, vVrjdw73IXOSPm7hUTt.cKm7LFOb8O);
				}
			}
			finally
			{
				vVrjdw73IXOSPm7hUTt.D35lls5iF(this, vVrjdw73IXOSPm7hUTt.iTD7E3GTvB);
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
					_003C_003E1__state = -4;
					goto IL_0099;
				}
				_003C_003E1__state = -1;
				_003C_003E7__wrap1 = items.GetEnumerator();
				_003C_003E1__state = -3;
				goto IL_00c0;
				IL_0099:
				if (hjMnupQVVDlRZAYQJC.D35lls5iF(_003C_003E7__wrap2, hjMnupQVVDlRZAYQJC.QV1TFwytOj))
				{
					DependencyObject current = _003C_003E7__wrap2.Current;
					_003C_003E2__current = current;
					_003C_003E1__state = 1;
					return true;
				}
				vVrjdw73IXOSPm7hUTt.D35lls5iF(this, vVrjdw73IXOSPm7hUTt.cKm7LFOb8O);
				_003C_003E7__wrap2 = null;
				goto IL_00c0;
				IL_00c0:
				if (hjMnupQVVDlRZAYQJC.D35lls5iF(_003C_003E7__wrap1, hjMnupQVVDlRZAYQJC.QV1TFwytOj))
				{
					DependencyObject current2 = _003C_003E7__wrap1.Current;
					_003C_003E7__wrap2 = function(current2).GetEnumerator();
					_003C_003E1__state = -4;
					goto IL_0099;
				}
				vVrjdw73IXOSPm7hUTt.D35lls5iF(this, vVrjdw73IXOSPm7hUTt.iTD7E3GTvB);
				_003C_003E7__wrap1 = null;
				return false;
			}
			catch
			{
				//try-fault
				vVrjdw73IXOSPm7hUTt.D35lls5iF(this, vVrjdw73IXOSPm7hUTt.x6y7BrfIdK);
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
			_003CDrillDown_003Ed__0 obj;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == DwgsIttNEA2NshX7F1f.D35lls5iF(DwgsIttNEA2NshX7F1f.bsCtOtFCPy))
			{
				_003C_003E1__state = 0;
				obj = this;
			}
			else
			{
				obj = new _003CDrillDown_003Ed__0(0);
			}
			obj.items = _003C_003E3__items;
			obj.function = _003C_003E3__function;
			return obj;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return YvAvirtsK0bqTvZe6Cm.D35lls5iF(this, YvAvirtsK0bqTvZe6Cm.koI70bBgak);
		}
	}

	[IteratorStateMachine(typeof(_003CDrillDown_003Ed__0))]
	private static IEnumerable<DependencyObject> zEKGOtpCs1(this IEnumerable<DependencyObject> P_0, Func<DependencyObject, IEnumerable<DependencyObject>> P_1)
	{
		// ILSpy could not decompile this. Please report the exception below,
		// along with the assembly it came from, at https://github.com/icsharpcode/ILSpy/issues/new
		// System.ArgumentException: An item with the same key has already been added. Key: 06001511 vVrjdw73IXOSPm7hUTt.D35lls5iF
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

	public static IEnumerable<DependencyObject> DrillDown<T>(this IEnumerable<DependencyObject> items, Func<DependencyObject, IEnumerable<DependencyObject>> function) where T : DependencyObject
	{
		IEnumerator<DependencyObject> enumerator = items.GetEnumerator();
		try
		{
			while (hjMnupQVVDlRZAYQJC.D35lls5iF(enumerator, hjMnupQVVDlRZAYQJC.QV1TFwytOj))
			{
				DependencyObject current = enumerator.Current;
				IEnumerator<DependencyObject> enumerator2 = function(current).GetEnumerator();
				try
				{
					while (hjMnupQVVDlRZAYQJC.D35lls5iF(enumerator2, hjMnupQVVDlRZAYQJC.QV1TFwytOj))
					{
						DependencyObject current2 = enumerator2.Current;
						if (current2 is T)
						{
							yield return (DependencyObject)(object)(T)(object)current2;
						}
					}
				}
				finally
				{
					if (enumerator2 != null)
					{
						xLO56JniGyickVjO1Ot.D35lls5iF(enumerator2, xLO56JniGyickVjO1Ot.ydbT2bsoH4);
					}
				}
			}
		}
		finally
		{
			if (enumerator != null)
			{
				xLO56JniGyickVjO1Ot.D35lls5iF(enumerator, xLO56JniGyickVjO1Ot.ydbT2bsoH4);
			}
		}
	}

	public static IEnumerable<DependencyObject> Descendants(this IEnumerable<DependencyObject> items)
	{
		return nG0f10R5cGaapFyCy5J.D35lls5iF(items, (DependencyObject i) => YKV9BbGjMx0viR9GjJi.D35lls5iF(i, YKV9BbGjMx0viR9GjJi.R0dR2pwj1L), nG0f10R5cGaapFyCy5J.P1ARz9LvZ5);
	}

	public static IEnumerable<DependencyObject> DescendantsAndSelf(this IEnumerable<DependencyObject> items)
	{
		return nG0f10R5cGaapFyCy5J.D35lls5iF(items, (DependencyObject i) => YKV9BbGjMx0viR9GjJi.D35lls5iF(i, YKV9BbGjMx0viR9GjJi.ud4RyDfJyb), nG0f10R5cGaapFyCy5J.P1ARz9LvZ5);
	}

	public static IEnumerable<DependencyObject> Ancestors(this IEnumerable<DependencyObject> items)
	{
		return nG0f10R5cGaapFyCy5J.D35lls5iF(items, (DependencyObject i) => YKV9BbGjMx0viR9GjJi.D35lls5iF(i, YKV9BbGjMx0viR9GjJi.hATRqiijGA), nG0f10R5cGaapFyCy5J.P1ARz9LvZ5);
	}

	public static IEnumerable<DependencyObject> AncestorsAndSelf(this IEnumerable<DependencyObject> items)
	{
		return nG0f10R5cGaapFyCy5J.D35lls5iF(items, (DependencyObject i) => YKV9BbGjMx0viR9GjJi.D35lls5iF(i, YKV9BbGjMx0viR9GjJi.NGVRJfgWJP), nG0f10R5cGaapFyCy5J.P1ARz9LvZ5);
	}

	public static IEnumerable<DependencyObject> Elements(this IEnumerable<DependencyObject> items)
	{
		return nG0f10R5cGaapFyCy5J.D35lls5iF(items, (DependencyObject i) => YKV9BbGjMx0viR9GjJi.D35lls5iF(i, YKV9BbGjMx0viR9GjJi.uI5Rb2jJmH), nG0f10R5cGaapFyCy5J.P1ARz9LvZ5);
	}

	public static IEnumerable<DependencyObject> ElementsAndSelf(this IEnumerable<DependencyObject> items)
	{
		return nG0f10R5cGaapFyCy5J.D35lls5iF(items, (DependencyObject i) => YKV9BbGjMx0viR9GjJi.D35lls5iF(i, YKV9BbGjMx0viR9GjJi.SinRWZh7Pr), nG0f10R5cGaapFyCy5J.P1ARz9LvZ5);
	}

	public static IEnumerable<DependencyObject> Descendants<T>(this IEnumerable<DependencyObject> items) where T : DependencyObject
	{
		return items.DrillDown<T>((DependencyObject i) => YKV9BbGjMx0viR9GjJi.D35lls5iF(i, YKV9BbGjMx0viR9GjJi.R0dR2pwj1L));
	}

	public static IEnumerable<DependencyObject> DescendantsAndSelf<T>(this IEnumerable<DependencyObject> items) where T : DependencyObject
	{
		return items.DrillDown<T>((DependencyObject i) => YKV9BbGjMx0viR9GjJi.D35lls5iF(i, YKV9BbGjMx0viR9GjJi.ud4RyDfJyb));
	}

	public static IEnumerable<DependencyObject> Ancestors<T>(this IEnumerable<DependencyObject> items) where T : DependencyObject
	{
		return items.DrillDown<T>((DependencyObject i) => YKV9BbGjMx0viR9GjJi.D35lls5iF(i, YKV9BbGjMx0viR9GjJi.hATRqiijGA));
	}

	public static IEnumerable<DependencyObject> AncestorsAndSelf<T>(this IEnumerable<DependencyObject> items) where T : DependencyObject
	{
		return items.DrillDown<T>((DependencyObject i) => YKV9BbGjMx0viR9GjJi.D35lls5iF(i, YKV9BbGjMx0viR9GjJi.NGVRJfgWJP));
	}

	public static IEnumerable<DependencyObject> Elements<T>(this IEnumerable<DependencyObject> items) where T : DependencyObject
	{
		return items.DrillDown<T>((DependencyObject i) => YKV9BbGjMx0viR9GjJi.D35lls5iF(i, YKV9BbGjMx0viR9GjJi.uI5Rb2jJmH));
	}

	public static IEnumerable<DependencyObject> ElementsAndSelf<T>(this IEnumerable<DependencyObject> items) where T : DependencyObject
	{
		return items.DrillDown<T>((DependencyObject i) => YKV9BbGjMx0viR9GjJi.D35lls5iF(i, YKV9BbGjMx0viR9GjJi.SinRWZh7Pr));
	}
}
