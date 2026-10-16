using System;
using System.Linq.Expressions;
using System.Reflection;

namespace PROTV.Abstractions.Helpers;

public static class ExpressionExtention
{
	public static T GetPropertyValue<T>(this Expression<Func<T>> lamba)
	{
		return lamba.Compile()();
	}

	public static void SetPropertyValue<T>(this Expression<Func<T>> lamba, T value)
	{
		MemberExpression obj = CxaTCBtIuwIuxCIINRe.IB3tMMvyI(lamba, CxaTCBtIuwIuxCIINRe.ltNtf79QYg) as MemberExpression;
		PropertyInfo propertyInfo = (PropertyInfo)ePKYKRtUCfKVBIfe7Cm.IB3tMMvyI(obj, ePKYKRtUCfKVBIfe7Cm.MIJt5PhWd4);
		object obj2 = XteDVftpS7vpk2OIHJb.IB3tMMvyI(zQNkEctlB0gFJt6O2WO.IB3tMMvyI(a9id6WtR3do0myWJrq9.IB3tMMvyI(CxaTCBtIuwIuxCIINRe.IB3tMMvyI(obj, CxaTCBtIuwIuxCIINRe.TDWt6Vqbcm), Array.Empty<ParameterExpression>(), a9id6WtR3do0myWJrq9.qbjtdjExxJ), zQNkEctlB0gFJt6O2WO.CcXtmdfyn5), Array.Empty<object>(), XteDVftpS7vpk2OIHJb.LcUtcM4SoJ);
		Ocg1idtqUjvpLN61Z2X.IB3tMMvyI(propertyInfo, obj2, value, Ocg1idtqUjvpLN61Z2X.NwwtOw02dU);
	}
}
