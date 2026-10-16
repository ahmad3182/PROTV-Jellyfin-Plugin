using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace PROTV.Abstractions.Common;

[JsonConverter(typeof(StringEnumConverter))]
public enum PageAnimation
{
	None,
	SlideAndFadeInFromRight,
	SlideAndFadeInFromLeft,
	SlideAndFadeInFromBottom,
	SlideAndFadeInFromTop,
	SlideAndFadeOutToRight,
	SlideAndFadeOutToLeft,
	SlideAndFadeOutToBottom,
	SlideAndFadeOutToTop,
	FadeIn,
	FadeOut
}
