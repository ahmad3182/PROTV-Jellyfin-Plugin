using System;
using System.Globalization;

namespace PROTV.Wpf.Helpers;

public class ByteFormatter : BaseValueConverter<ByteFormatter>
{
	public override object Convert(object value, Type targetType, object format, CultureInfo culture)
	{
		double num = mBjHJeeM2UutvxFgdpS.D35lls5iF(value, BpLgsCe709fQc2qkAct.D35lls5iF(BpLgsCe709fQc2qkAct.pIEecDFslk), mBjHJeeM2UutvxFgdpS.GQBeSBImjw);
		string text = iFZ5je3XFYKwkvcE5D.D35lls5iF(13172, iFZ5je3XFYKwkvcE5D.N06TeK0ao);
		double num2 = 0.0;
		if (num >= 1024.0)
		{
			text = iFZ5je3XFYKwkvcE5D.D35lls5iF(13228, iFZ5je3XFYKwkvcE5D.N06TeK0ao);
			num2 = Ar1wWyeKiNmSEChFiZw.D35lls5iF(num / 1024.0, 2, Ar1wWyeKiNmSEChFiZw.clneNBmmgW);
		}
		if (num >= 1048576.0)
		{
			text = iFZ5je3XFYKwkvcE5D.D35lls5iF(13236, iFZ5je3XFYKwkvcE5D.N06TeK0ao);
			num2 = Ar1wWyeKiNmSEChFiZw.D35lls5iF(num / 1048576.0, 2, Ar1wWyeKiNmSEChFiZw.clneNBmmgW);
		}
		if (num >= 1073741824.0)
		{
			text = iFZ5je3XFYKwkvcE5D.D35lls5iF(13244, iFZ5je3XFYKwkvcE5D.N06TeK0ao);
			num2 = Ar1wWyeKiNmSEChFiZw.D35lls5iF(num / 1073741824.0, 2, Ar1wWyeKiNmSEChFiZw.clneNBmmgW);
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

	public ByteFormatter()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector();
	}
}
