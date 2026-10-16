using System.Windows;
using System.Windows.Media.Animation;

namespace PROTV.Wpf.Helpers;

public static class StoryboardHelpers
{
	public static void AddSlideFromLeft(this Storyboard storyboard, float seconds, double offset, float decelerationRatio = 1f, bool keepMargin = true, bool FillBehavior = false)
	{
		ThicknessAnimation thicknessAnimation = new ThicknessAnimation();
		vxpSXTnNiJtJZveTWAu.D35lls5iF(thicknessAnimation, new Duration(aNJrrPl4soK5NDOndiN.D35lls5iF(seconds, aNJrrPl4soK5NDOndiN.Ca9lahqtKS)), vxpSXTnNiJtJZveTWAu.sGenOfQp8k);
		STRn6F0y0SHvVTlcvlV.D35lls5iF(thicknessAnimation, new Thickness(0.0 - offset, 0.0, keepMargin ? offset : 0.0, 0.0), STRn6F0y0SHvVTlcvlV.F890qmBiy3);
		STRn6F0y0SHvVTlcvlV.D35lls5iF(thicknessAnimation, new Thickness(0.0), STRn6F0y0SHvVTlcvlV.Hyh0JrBVFa);
		mAdJWQ9yhneCbEXlGMc.D35lls5iF(thicknessAnimation, decelerationRatio, mAdJWQ9yhneCbEXlGMc.ExX0bXSSsA);
		ThicknessAnimation thicknessAnimation2 = thicknessAnimation;
		if (FillBehavior)
		{
			cptbHg0WCNu7N9eqVbq.D35lls5iF(thicknessAnimation2, System.Windows.Media.Animation.FillBehavior.HoldEnd, cptbHg0WCNu7N9eqVbq.BoO0562wKp);
		}
		R5pAM50zhvrFMiTvSLv.D35lls5iF((DependencyObject)(object)thicknessAnimation2, new PropertyPath(iFZ5je3XFYKwkvcE5D.D35lls5iF(12466, iFZ5je3XFYKwkvcE5D.N06TeK0ao)), R5pAM50zhvrFMiTvSLv.RlfrouCfWy);
		A3LkMErDqhVkMXokXWE.D35lls5iF(RjEMa5rlCuHUwffpgVV.D35lls5iF(storyboard, RjEMa5rlCuHUwffpgVV.gMnr9aWn8O), thicknessAnimation2, A3LkMErDqhVkMXokXWE.DVrrHAR0FL);
	}

	public static void AddSlideToLeft(this Storyboard storyboard, float seconds, double offset, float decelerationRatio = 1f, bool keepMargin = true, bool FillBehavior = false)
	{
		ThicknessAnimation thicknessAnimation = new ThicknessAnimation();
		vxpSXTnNiJtJZveTWAu.D35lls5iF(thicknessAnimation, new Duration(aNJrrPl4soK5NDOndiN.D35lls5iF(seconds, aNJrrPl4soK5NDOndiN.Ca9lahqtKS)), vxpSXTnNiJtJZveTWAu.sGenOfQp8k);
		STRn6F0y0SHvVTlcvlV.D35lls5iF(thicknessAnimation, new Thickness(0.0), STRn6F0y0SHvVTlcvlV.F890qmBiy3);
		STRn6F0y0SHvVTlcvlV.D35lls5iF(thicknessAnimation, new Thickness(0.0 - offset, 0.0, keepMargin ? offset : 0.0, 0.0), STRn6F0y0SHvVTlcvlV.Hyh0JrBVFa);
		mAdJWQ9yhneCbEXlGMc.D35lls5iF(thicknessAnimation, decelerationRatio, mAdJWQ9yhneCbEXlGMc.ExX0bXSSsA);
		ThicknessAnimation thicknessAnimation2 = thicknessAnimation;
		if (FillBehavior)
		{
			cptbHg0WCNu7N9eqVbq.D35lls5iF(thicknessAnimation2, System.Windows.Media.Animation.FillBehavior.HoldEnd, cptbHg0WCNu7N9eqVbq.BoO0562wKp);
		}
		R5pAM50zhvrFMiTvSLv.D35lls5iF((DependencyObject)(object)thicknessAnimation2, new PropertyPath(iFZ5je3XFYKwkvcE5D.D35lls5iF(12466, iFZ5je3XFYKwkvcE5D.N06TeK0ao)), R5pAM50zhvrFMiTvSLv.RlfrouCfWy);
		A3LkMErDqhVkMXokXWE.D35lls5iF(RjEMa5rlCuHUwffpgVV.D35lls5iF(storyboard, RjEMa5rlCuHUwffpgVV.gMnr9aWn8O), thicknessAnimation2, A3LkMErDqhVkMXokXWE.DVrrHAR0FL);
	}

	public static void AddSlideFromRight(this Storyboard storyboard, float seconds, double offset, float decelerationRatio = 1f, bool keepMargin = true, bool FillBehavior = false)
	{
		ThicknessAnimation thicknessAnimation = new ThicknessAnimation();
		vxpSXTnNiJtJZveTWAu.D35lls5iF(thicknessAnimation, new Duration(aNJrrPl4soK5NDOndiN.D35lls5iF(seconds, aNJrrPl4soK5NDOndiN.Ca9lahqtKS)), vxpSXTnNiJtJZveTWAu.sGenOfQp8k);
		STRn6F0y0SHvVTlcvlV.D35lls5iF(thicknessAnimation, new Thickness(keepMargin ? offset : 0.0, 0.0, 0.0 - offset, 0.0), STRn6F0y0SHvVTlcvlV.F890qmBiy3);
		STRn6F0y0SHvVTlcvlV.D35lls5iF(thicknessAnimation, new Thickness(0.0), STRn6F0y0SHvVTlcvlV.Hyh0JrBVFa);
		mAdJWQ9yhneCbEXlGMc.D35lls5iF(thicknessAnimation, decelerationRatio, mAdJWQ9yhneCbEXlGMc.ExX0bXSSsA);
		ThicknessAnimation thicknessAnimation2 = thicknessAnimation;
		if (FillBehavior)
		{
			cptbHg0WCNu7N9eqVbq.D35lls5iF(thicknessAnimation2, System.Windows.Media.Animation.FillBehavior.HoldEnd, cptbHg0WCNu7N9eqVbq.BoO0562wKp);
		}
		R5pAM50zhvrFMiTvSLv.D35lls5iF((DependencyObject)(object)thicknessAnimation2, new PropertyPath(iFZ5je3XFYKwkvcE5D.D35lls5iF(12466, iFZ5je3XFYKwkvcE5D.N06TeK0ao)), R5pAM50zhvrFMiTvSLv.RlfrouCfWy);
		A3LkMErDqhVkMXokXWE.D35lls5iF(RjEMa5rlCuHUwffpgVV.D35lls5iF(storyboard, RjEMa5rlCuHUwffpgVV.gMnr9aWn8O), thicknessAnimation2, A3LkMErDqhVkMXokXWE.DVrrHAR0FL);
	}

	public static void AddSlideToRight(this Storyboard storyboard, float seconds, double offset, float decelerationRatio = 1f, bool keepMargin = true, bool FillBehavior = false)
	{
		ThicknessAnimation thicknessAnimation = new ThicknessAnimation();
		vxpSXTnNiJtJZveTWAu.D35lls5iF(thicknessAnimation, new Duration(aNJrrPl4soK5NDOndiN.D35lls5iF(seconds, aNJrrPl4soK5NDOndiN.Ca9lahqtKS)), vxpSXTnNiJtJZveTWAu.sGenOfQp8k);
		STRn6F0y0SHvVTlcvlV.D35lls5iF(thicknessAnimation, new Thickness(0.0), STRn6F0y0SHvVTlcvlV.F890qmBiy3);
		STRn6F0y0SHvVTlcvlV.D35lls5iF(thicknessAnimation, new Thickness(keepMargin ? offset : 0.0, 0.0, 0.0 - offset, 0.0), STRn6F0y0SHvVTlcvlV.Hyh0JrBVFa);
		mAdJWQ9yhneCbEXlGMc.D35lls5iF(thicknessAnimation, decelerationRatio, mAdJWQ9yhneCbEXlGMc.ExX0bXSSsA);
		ThicknessAnimation thicknessAnimation2 = thicknessAnimation;
		if (FillBehavior)
		{
			cptbHg0WCNu7N9eqVbq.D35lls5iF(thicknessAnimation2, System.Windows.Media.Animation.FillBehavior.HoldEnd, cptbHg0WCNu7N9eqVbq.BoO0562wKp);
		}
		R5pAM50zhvrFMiTvSLv.D35lls5iF((DependencyObject)(object)thicknessAnimation2, new PropertyPath(iFZ5je3XFYKwkvcE5D.D35lls5iF(12466, iFZ5je3XFYKwkvcE5D.N06TeK0ao)), R5pAM50zhvrFMiTvSLv.RlfrouCfWy);
		A3LkMErDqhVkMXokXWE.D35lls5iF(RjEMa5rlCuHUwffpgVV.D35lls5iF(storyboard, RjEMa5rlCuHUwffpgVV.gMnr9aWn8O), thicknessAnimation2, A3LkMErDqhVkMXokXWE.DVrrHAR0FL);
	}

	public static void AddSlideFromTop(this Storyboard storyboard, float seconds, double offset, float decelerationRatio = 1f, bool keepMargin = true)
	{
		ThicknessAnimation thicknessAnimation = new ThicknessAnimation();
		vxpSXTnNiJtJZveTWAu.D35lls5iF(thicknessAnimation, new Duration(aNJrrPl4soK5NDOndiN.D35lls5iF(seconds, aNJrrPl4soK5NDOndiN.Ca9lahqtKS)), vxpSXTnNiJtJZveTWAu.sGenOfQp8k);
		STRn6F0y0SHvVTlcvlV.D35lls5iF(thicknessAnimation, new Thickness(0.0, 0.0 - offset, 0.0, keepMargin ? offset : 0.0), STRn6F0y0SHvVTlcvlV.F890qmBiy3);
		STRn6F0y0SHvVTlcvlV.D35lls5iF(thicknessAnimation, new Thickness(0.0), STRn6F0y0SHvVTlcvlV.Hyh0JrBVFa);
		mAdJWQ9yhneCbEXlGMc.D35lls5iF(thicknessAnimation, decelerationRatio, mAdJWQ9yhneCbEXlGMc.ExX0bXSSsA);
		ThicknessAnimation thicknessAnimation2 = thicknessAnimation;
		R5pAM50zhvrFMiTvSLv.D35lls5iF((DependencyObject)(object)thicknessAnimation2, new PropertyPath(iFZ5je3XFYKwkvcE5D.D35lls5iF(12466, iFZ5je3XFYKwkvcE5D.N06TeK0ao)), R5pAM50zhvrFMiTvSLv.RlfrouCfWy);
		A3LkMErDqhVkMXokXWE.D35lls5iF(RjEMa5rlCuHUwffpgVV.D35lls5iF(storyboard, RjEMa5rlCuHUwffpgVV.gMnr9aWn8O), thicknessAnimation2, A3LkMErDqhVkMXokXWE.DVrrHAR0FL);
	}

	public static void AddSlideToTop(this Storyboard storyboard, float seconds, double offset, float decelerationRatio = 1f, bool keepMargin = true)
	{
		ThicknessAnimation thicknessAnimation = new ThicknessAnimation();
		vxpSXTnNiJtJZveTWAu.D35lls5iF(thicknessAnimation, new Duration(aNJrrPl4soK5NDOndiN.D35lls5iF(seconds, aNJrrPl4soK5NDOndiN.Ca9lahqtKS)), vxpSXTnNiJtJZveTWAu.sGenOfQp8k);
		STRn6F0y0SHvVTlcvlV.D35lls5iF(thicknessAnimation, new Thickness(0.0), STRn6F0y0SHvVTlcvlV.F890qmBiy3);
		STRn6F0y0SHvVTlcvlV.D35lls5iF(thicknessAnimation, new Thickness(0.0, 0.0 - offset, 0.0, keepMargin ? offset : 0.0), STRn6F0y0SHvVTlcvlV.Hyh0JrBVFa);
		mAdJWQ9yhneCbEXlGMc.D35lls5iF(thicknessAnimation, decelerationRatio, mAdJWQ9yhneCbEXlGMc.ExX0bXSSsA);
		ThicknessAnimation thicknessAnimation2 = thicknessAnimation;
		R5pAM50zhvrFMiTvSLv.D35lls5iF((DependencyObject)(object)thicknessAnimation2, new PropertyPath(iFZ5je3XFYKwkvcE5D.D35lls5iF(12466, iFZ5je3XFYKwkvcE5D.N06TeK0ao)), R5pAM50zhvrFMiTvSLv.RlfrouCfWy);
		A3LkMErDqhVkMXokXWE.D35lls5iF(RjEMa5rlCuHUwffpgVV.D35lls5iF(storyboard, RjEMa5rlCuHUwffpgVV.gMnr9aWn8O), thicknessAnimation2, A3LkMErDqhVkMXokXWE.DVrrHAR0FL);
	}

	public static void AddSlideFromBottom(this Storyboard storyboard, float seconds, double offset, float decelerationRatio = 1f, bool keepMargin = true)
	{
		ThicknessAnimation thicknessAnimation = new ThicknessAnimation();
		vxpSXTnNiJtJZveTWAu.D35lls5iF(thicknessAnimation, new Duration(aNJrrPl4soK5NDOndiN.D35lls5iF(seconds, aNJrrPl4soK5NDOndiN.Ca9lahqtKS)), vxpSXTnNiJtJZveTWAu.sGenOfQp8k);
		STRn6F0y0SHvVTlcvlV.D35lls5iF(thicknessAnimation, new Thickness(0.0, keepMargin ? offset : 0.0, 0.0, 0.0 - offset), STRn6F0y0SHvVTlcvlV.F890qmBiy3);
		STRn6F0y0SHvVTlcvlV.D35lls5iF(thicknessAnimation, new Thickness(0.0), STRn6F0y0SHvVTlcvlV.Hyh0JrBVFa);
		mAdJWQ9yhneCbEXlGMc.D35lls5iF(thicknessAnimation, decelerationRatio, mAdJWQ9yhneCbEXlGMc.ExX0bXSSsA);
		ThicknessAnimation thicknessAnimation2 = thicknessAnimation;
		R5pAM50zhvrFMiTvSLv.D35lls5iF((DependencyObject)(object)thicknessAnimation2, new PropertyPath(iFZ5je3XFYKwkvcE5D.D35lls5iF(12466, iFZ5je3XFYKwkvcE5D.N06TeK0ao)), R5pAM50zhvrFMiTvSLv.RlfrouCfWy);
		A3LkMErDqhVkMXokXWE.D35lls5iF(RjEMa5rlCuHUwffpgVV.D35lls5iF(storyboard, RjEMa5rlCuHUwffpgVV.gMnr9aWn8O), thicknessAnimation2, A3LkMErDqhVkMXokXWE.DVrrHAR0FL);
	}

	public static void AddSlideToBottom(this Storyboard storyboard, float seconds, double offset, float decelerationRatio = 1f, bool keepMargin = true)
	{
		ThicknessAnimation thicknessAnimation = new ThicknessAnimation();
		vxpSXTnNiJtJZveTWAu.D35lls5iF(thicknessAnimation, new Duration(aNJrrPl4soK5NDOndiN.D35lls5iF(seconds, aNJrrPl4soK5NDOndiN.Ca9lahqtKS)), vxpSXTnNiJtJZveTWAu.sGenOfQp8k);
		STRn6F0y0SHvVTlcvlV.D35lls5iF(thicknessAnimation, new Thickness(0.0), STRn6F0y0SHvVTlcvlV.F890qmBiy3);
		STRn6F0y0SHvVTlcvlV.D35lls5iF(thicknessAnimation, new Thickness(0.0, keepMargin ? offset : 0.0, 0.0, 0.0 - offset), STRn6F0y0SHvVTlcvlV.Hyh0JrBVFa);
		mAdJWQ9yhneCbEXlGMc.D35lls5iF(thicknessAnimation, decelerationRatio, mAdJWQ9yhneCbEXlGMc.ExX0bXSSsA);
		ThicknessAnimation thicknessAnimation2 = thicknessAnimation;
		R5pAM50zhvrFMiTvSLv.D35lls5iF((DependencyObject)(object)thicknessAnimation2, new PropertyPath(iFZ5je3XFYKwkvcE5D.D35lls5iF(12466, iFZ5je3XFYKwkvcE5D.N06TeK0ao)), R5pAM50zhvrFMiTvSLv.RlfrouCfWy);
		A3LkMErDqhVkMXokXWE.D35lls5iF(RjEMa5rlCuHUwffpgVV.D35lls5iF(storyboard, RjEMa5rlCuHUwffpgVV.gMnr9aWn8O), thicknessAnimation2, A3LkMErDqhVkMXokXWE.DVrrHAR0FL);
	}

	public static void AddFadeIn(this Storyboard storyboard, float seconds, bool from = false, bool FillBehavior = false)
	{
		DoubleAnimation doubleAnimation = new DoubleAnimation();
		vxpSXTnNiJtJZveTWAu.D35lls5iF(doubleAnimation, new Duration(aNJrrPl4soK5NDOndiN.D35lls5iF(seconds, aNJrrPl4soK5NDOndiN.Ca9lahqtKS)), vxpSXTnNiJtJZveTWAu.sGenOfQp8k);
		YqunhentMQKNCD4wpOZ.D35lls5iF(doubleAnimation, 1.0, YqunhentMQKNCD4wpOZ.Pl6n74M0Z5);
		DoubleAnimation doubleAnimation2 = doubleAnimation;
		if (from)
		{
			YqunhentMQKNCD4wpOZ.D35lls5iF(doubleAnimation2, 0.0, YqunhentMQKNCD4wpOZ.b0CnVdTyrO);
		}
		if (FillBehavior)
		{
			cptbHg0WCNu7N9eqVbq.D35lls5iF(doubleAnimation2, System.Windows.Media.Animation.FillBehavior.HoldEnd, cptbHg0WCNu7N9eqVbq.BoO0562wKp);
		}
		R5pAM50zhvrFMiTvSLv.D35lls5iF((DependencyObject)(object)doubleAnimation2, new PropertyPath(iFZ5je3XFYKwkvcE5D.D35lls5iF(12482, iFZ5je3XFYKwkvcE5D.N06TeK0ao)), R5pAM50zhvrFMiTvSLv.RlfrouCfWy);
		A3LkMErDqhVkMXokXWE.D35lls5iF(RjEMa5rlCuHUwffpgVV.D35lls5iF(storyboard, RjEMa5rlCuHUwffpgVV.gMnr9aWn8O), doubleAnimation2, A3LkMErDqhVkMXokXWE.DVrrHAR0FL);
	}

	public static void AddFadeOut(this Storyboard storyboard, float seconds, bool FillBehavior = false)
	{
		DoubleAnimation doubleAnimation = new DoubleAnimation();
		vxpSXTnNiJtJZveTWAu.D35lls5iF(doubleAnimation, new Duration(aNJrrPl4soK5NDOndiN.D35lls5iF(seconds, aNJrrPl4soK5NDOndiN.Ca9lahqtKS)), vxpSXTnNiJtJZveTWAu.sGenOfQp8k);
		YqunhentMQKNCD4wpOZ.D35lls5iF(doubleAnimation, 0.0, YqunhentMQKNCD4wpOZ.Pl6n74M0Z5);
		DoubleAnimation doubleAnimation2 = doubleAnimation;
		if (FillBehavior)
		{
			cptbHg0WCNu7N9eqVbq.D35lls5iF(doubleAnimation2, System.Windows.Media.Animation.FillBehavior.HoldEnd, cptbHg0WCNu7N9eqVbq.BoO0562wKp);
		}
		R5pAM50zhvrFMiTvSLv.D35lls5iF((DependencyObject)(object)doubleAnimation2, new PropertyPath(iFZ5je3XFYKwkvcE5D.D35lls5iF(12482, iFZ5je3XFYKwkvcE5D.N06TeK0ao)), R5pAM50zhvrFMiTvSLv.RlfrouCfWy);
		A3LkMErDqhVkMXokXWE.D35lls5iF(RjEMa5rlCuHUwffpgVV.D35lls5iF(storyboard, RjEMa5rlCuHUwffpgVV.gMnr9aWn8O), doubleAnimation2, A3LkMErDqhVkMXokXWE.DVrrHAR0FL);
	}

	public static void ChangeWidth(this Storyboard storyboard, float seconds, double from, double to)
	{
		DoubleAnimationUsingKeyFrames doubleAnimationUsingKeyFrames = new DoubleAnimationUsingKeyFrames();
		vxpSXTnNiJtJZveTWAu.D35lls5iF(doubleAnimationUsingKeyFrames, new Duration(aNJrrPl4soK5NDOndiN.D35lls5iF(seconds, aNJrrPl4soK5NDOndiN.Ca9lahqtKS)), vxpSXTnNiJtJZveTWAu.sGenOfQp8k);
		DoubleAnimationUsingKeyFrames doubleAnimationUsingKeyFrames2 = doubleAnimationUsingKeyFrames;
		DoubleKeyFrameCollection doubleKeyFrameCollection = coCbf1r1XxeB5YHdgMG.D35lls5iF(doubleAnimationUsingKeyFrames2, coCbf1r1XxeB5YHdgMG.jDcr8utwcX);
		EasingDoubleKeyFrame easingDoubleKeyFrame = new EasingDoubleKeyFrame();
		mAdJWQ9yhneCbEXlGMc.D35lls5iF(easingDoubleKeyFrame, from, mAdJWQ9yhneCbEXlGMc.CwtrnQGWOh);
		tBX5I0r4EoeQTD1kulE.D35lls5iF(easingDoubleKeyFrame, yHRrorr3uhxrml66vUx.D35lls5iF(0.0, yHRrorr3uhxrml66vUx.CuXrT9YZF8), tBX5I0r4EoeQTD1kulE.w8drLeJSML);
		IMfsVNrEYjZP46BStpc.D35lls5iF(doubleKeyFrameCollection, easingDoubleKeyFrame, IMfsVNrEYjZP46BStpc.L7nrB4HrDH);
		DoubleKeyFrameCollection doubleKeyFrameCollection2 = coCbf1r1XxeB5YHdgMG.D35lls5iF(doubleAnimationUsingKeyFrames2, coCbf1r1XxeB5YHdgMG.jDcr8utwcX);
		EasingDoubleKeyFrame easingDoubleKeyFrame2 = new EasingDoubleKeyFrame();
		mAdJWQ9yhneCbEXlGMc.D35lls5iF(easingDoubleKeyFrame2, to, mAdJWQ9yhneCbEXlGMc.CwtrnQGWOh);
		tBX5I0r4EoeQTD1kulE.D35lls5iF(easingDoubleKeyFrame2, yHRrorr3uhxrml66vUx.D35lls5iF(1.0, yHRrorr3uhxrml66vUx.CuXrT9YZF8), tBX5I0r4EoeQTD1kulE.w8drLeJSML);
		IMfsVNrEYjZP46BStpc.D35lls5iF(doubleKeyFrameCollection2, easingDoubleKeyFrame2, IMfsVNrEYjZP46BStpc.L7nrB4HrDH);
		R5pAM50zhvrFMiTvSLv.D35lls5iF((DependencyObject)(object)doubleAnimationUsingKeyFrames2, new PropertyPath(iFZ5je3XFYKwkvcE5D.D35lls5iF(12500, iFZ5je3XFYKwkvcE5D.N06TeK0ao)), R5pAM50zhvrFMiTvSLv.RlfrouCfWy);
		A3LkMErDqhVkMXokXWE.D35lls5iF(RjEMa5rlCuHUwffpgVV.D35lls5iF(storyboard, RjEMa5rlCuHUwffpgVV.gMnr9aWn8O), doubleAnimationUsingKeyFrames2, A3LkMErDqhVkMXokXWE.DVrrHAR0FL);
	}

	public static void ChangeHeight(this Storyboard storyboard, float seconds, double from, double to)
	{
		DoubleAnimationUsingKeyFrames doubleAnimationUsingKeyFrames = new DoubleAnimationUsingKeyFrames();
		vxpSXTnNiJtJZveTWAu.D35lls5iF(doubleAnimationUsingKeyFrames, new Duration(aNJrrPl4soK5NDOndiN.D35lls5iF(seconds, aNJrrPl4soK5NDOndiN.Ca9lahqtKS)), vxpSXTnNiJtJZveTWAu.sGenOfQp8k);
		DoubleAnimationUsingKeyFrames doubleAnimationUsingKeyFrames2 = doubleAnimationUsingKeyFrames;
		DoubleKeyFrameCollection doubleKeyFrameCollection = coCbf1r1XxeB5YHdgMG.D35lls5iF(doubleAnimationUsingKeyFrames2, coCbf1r1XxeB5YHdgMG.jDcr8utwcX);
		EasingDoubleKeyFrame easingDoubleKeyFrame = new EasingDoubleKeyFrame();
		mAdJWQ9yhneCbEXlGMc.D35lls5iF(easingDoubleKeyFrame, from, mAdJWQ9yhneCbEXlGMc.CwtrnQGWOh);
		tBX5I0r4EoeQTD1kulE.D35lls5iF(easingDoubleKeyFrame, yHRrorr3uhxrml66vUx.D35lls5iF(0.0, yHRrorr3uhxrml66vUx.CuXrT9YZF8), tBX5I0r4EoeQTD1kulE.w8drLeJSML);
		IMfsVNrEYjZP46BStpc.D35lls5iF(doubleKeyFrameCollection, easingDoubleKeyFrame, IMfsVNrEYjZP46BStpc.L7nrB4HrDH);
		DoubleKeyFrameCollection doubleKeyFrameCollection2 = coCbf1r1XxeB5YHdgMG.D35lls5iF(doubleAnimationUsingKeyFrames2, coCbf1r1XxeB5YHdgMG.jDcr8utwcX);
		EasingDoubleKeyFrame easingDoubleKeyFrame2 = new EasingDoubleKeyFrame();
		mAdJWQ9yhneCbEXlGMc.D35lls5iF(easingDoubleKeyFrame2, to, mAdJWQ9yhneCbEXlGMc.CwtrnQGWOh);
		tBX5I0r4EoeQTD1kulE.D35lls5iF(easingDoubleKeyFrame2, yHRrorr3uhxrml66vUx.D35lls5iF(1.0, yHRrorr3uhxrml66vUx.CuXrT9YZF8), tBX5I0r4EoeQTD1kulE.w8drLeJSML);
		IMfsVNrEYjZP46BStpc.D35lls5iF(doubleKeyFrameCollection2, easingDoubleKeyFrame2, IMfsVNrEYjZP46BStpc.L7nrB4HrDH);
		R5pAM50zhvrFMiTvSLv.D35lls5iF((DependencyObject)(object)doubleAnimationUsingKeyFrames2, new PropertyPath(iFZ5je3XFYKwkvcE5D.D35lls5iF(12514, iFZ5je3XFYKwkvcE5D.N06TeK0ao)), R5pAM50zhvrFMiTvSLv.RlfrouCfWy);
		A3LkMErDqhVkMXokXWE.D35lls5iF(RjEMa5rlCuHUwffpgVV.D35lls5iF(storyboard, RjEMa5rlCuHUwffpgVV.gMnr9aWn8O), doubleAnimationUsingKeyFrames2, A3LkMErDqhVkMXokXWE.DVrrHAR0FL);
	}
}
