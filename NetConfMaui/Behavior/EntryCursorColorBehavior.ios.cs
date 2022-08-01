using Microsoft.Maui.Platform;
using UIKit;

namespace NetConfMaui.Behavior;
partial class EntryCursorColorBehavior : PlatformBehavior<Entry, UITextField>
{
	UIColor oldCursorColor;
	protected override void OnAttachedTo(Entry bindable, UITextField platformView)
	{
		oldCursorColor = platformView.TintColor;
		if (CursorColor is null)
			platformView.TintColor = UIColor.Green;
		else
			platformView.TintColor = CursorColor.ToPlatform();
	}

	protected override void OnDetachedFrom(Entry bindable, UITextField platformView)
	{
		platformView.TintColor = oldCursorColor;
	}
}
