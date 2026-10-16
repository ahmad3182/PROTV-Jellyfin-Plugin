using System;
using System.Globalization;

namespace PROTV.Wpf.Helpers;

public class BitFormatter : BaseValueConverter<BitFormatter>
{
	public override object Convert(object value, Type targetType, object format, CultureInfo culture)
	{
		double num = mBjHJeeM2UutvxFgdpS.D35lls5iF(value, BpLgsCe709fQc2qkAct.D35lls5iF(BpLgsCe709fQc2qkAct.pIEecDFslk), mBjHJeeM2UutvxFgdpS.GQBeSBImjw);
		string text = iFZ5je3XFYKwkvcE5D.D35lls5iF(13102, iFZ5je3XFYKwkvcE5D.N06TeK0ao);
		double num2 = 0.0;
		if (num >= 1000.0)
		{
			text = iFZ5je3XFYKwkvcE5D.D35lls5iF(13118, iFZ5je3XFYKwkvcE5D.N06TeK0ao);
			num2 = Ar1wWyeKiNmSEChFiZw.D35lls5iF(num / 1000.0, 2, Ar1wWyeKiNmSEChFiZw.clneNBmmgW);
		}
		if (num >= 1000000.0)
		{
			text = iFZ5je3XFYKwkvcE5D.D35lls5iF(13136, iFZ5je3XFYKwkvcE5D.N06TeK0ao);
			num2 = Ar1wWyeKiNmSEChFiZw.D35lls5iF(num / 1000000.0, 2, Ar1wWyeKiNmSEChFiZw.clneNBmmgW);
		}
		if (num >= 1000000000.0)
		{
			text = iFZ5je3XFYKwkvcE5D.D35lls5iF(13154, iFZ5je3XFYKwkvcE5D.N06TeK0ao);
			num2 = Ar1wWyeKiNmSEChFiZw.D35lls5iF(num / 1000000000.0, 2, Ar1wWyeKiNmSEChFiZw.clneNBmmgW);
		}
		if (!S1a0wT9Ixre9OpDny8h.D35lls5iF(text, iFZ5je3XFYKwkvcE5D.D35lls5iF(13172, iFZ5je3XFYKwkvcE5D.N06TeK0ao), S1a0wT9Ixre9OpDny8h.FAJ9FZ9PrO))
		{
			return sydk2oeOgdj2VAxhwQj.D35lls5iF(iFZ5je3XFYKwkvcE5D.D35lls5iF(13178, iFZ5je3XFYKwkvcE5D.N06TeK0ao), num2, text, sydk2oeOgdj2VAxhwQj.fAWeuB9Bfq);
		}
		return sydk2oeOgdj2VAxhwQj.D35lls5iF(iFZ5je3XFYKwkvcE5D.D35lls5iF(13206, iFZ5je3XFYKwkvcE5D.N06TeK0ao), num2, text, sydk2oeOgdj2VAxhwQj.fAWeuB9Bfq);
	}

	public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}

	public BitFormatter()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector();
	}
}
