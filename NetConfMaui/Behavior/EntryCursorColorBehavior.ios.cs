using Microsoft.Maui.Platform;
using UIKit;

namespace NetConfMaui.Behavior;
internal class EntryCursorColorBehavior : PlatformBehavior<Entry, UITextField>
{
	protected override void OnAttachedTo(Entry bindable, UITextField platformView)
	{
		platformView.TintColor = Colors.Red.ToPlatform();
	}
}
