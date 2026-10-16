using System;
using System.Globalization;

namespace PROTV.Wpf.Helpers;

public class PercentageFormatter : BaseValueConverter<PercentageFormatter>
{
	public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		double num = 0.0;
		if (value is int)
		{
			num = Ar1wWyeKiNmSEChFiZw.D35lls5iF((double)(int)value * 100.0, 0, Ar1wWyeKiNmSEChFiZw.clneNBmmgW);
			return QQLie3eYkZwbFFm9Jjw.D35lls5iF(T6EedHr0CxquZL0BWCa.D35lls5iF(iFZ5je3XFYKwkvcE5D.D35lls5iF(13710, iFZ5je3XFYKwkvcE5D.N06TeK0ao), num / 100.0, T6EedHr0CxquZL0BWCa.RU5rr1yw2Z), QQLie3eYkZwbFFm9Jjw.kXAegskyvp);
		}
		if (value is double num2)
		{
			num = num2;
		}
		num = Ar1wWyeKiNmSEChFiZw.D35lls5iF(num * 100.0, 0, Ar1wWyeKiNmSEChFiZw.clneNBmmgW);
		if (parameter == null || dcJjqelwgiZ4n97w1vs.D35lls5iF(num, dcJjqelwgiZ4n97w1vs.jM2lCY9POn) <= double.Epsilon)
		{
			return QQLie3eYkZwbFFm9Jjw.D35lls5iF(T6EedHr0CxquZL0BWCa.D35lls5iF(iFZ5je3XFYKwkvcE5D.D35lls5iF(13710, iFZ5je3XFYKwkvcE5D.N06TeK0ao), num, T6EedHr0CxquZL0BWCa.RU5rr1yw2Z), QQLie3eYkZwbFFm9Jjw.kXAegskyvp);
		}
		return QQLie3eYkZwbFFm9Jjw.D35lls5iF(sydk2oeOgdj2VAxhwQj.D35lls5iF(iFZ5je3XFYKwkvcE5D.D35lls5iF(13732, iFZ5je3XFYKwkvcE5D.N06TeK0ao), (num > 0.0) ? iFZ5je3XFYKwkvcE5D.D35lls5iF(13770, iFZ5je3XFYKwkvcE5D.N06TeK0ao) : iFZ5je3XFYKwkvcE5D.D35lls5iF(13762, iFZ5je3XFYKwkvcE5D.N06TeK0ao), dcJjqelwgiZ4n97w1vs.D35lls5iF(num, dcJjqelwgiZ4n97w1vs.jM2lCY9POn), sydk2oeOgdj2VAxhwQj.fAWeuB9Bfq), QQLie3eYkZwbFFm9Jjw.kXAegskyvp);
	}

	public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}

	public PercentageFormatter()
	{
		YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
		base._002Ector();
	}
}
