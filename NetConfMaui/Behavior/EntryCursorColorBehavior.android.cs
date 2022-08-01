using Android.Graphics.Drawables;
using AndroidX.AppCompat.Widget;
using Microsoft.Maui.Platform;

namespace NetConfMaui.Behavior;

//based on https://docs.microsoft.com/en-us/answers/questions/265520/how-to-dynamically-set-cursor-color-for-entry-and.html
partial class EntryCursorColorBehavior : PlatformBehavior<Entry, AppCompatEditText>
{
	protected override void OnAttachedTo(Entry bindable, AppCompatEditText platformView)
	{
		if (CursorColor is null)
			platformView.SetTextCursorDrawable(Resource.Drawable.myCursor);
		else
		{
			var gradientDrawable = (StateListDrawable)MainActivity.Activity.GetDrawable(Resource.Drawable.myCursor);
			var drawableContainerState = (DrawableContainer.DrawableContainerState)gradientDrawable.GetConstantState();
			var childrens = drawableContainerState.GetChildren();
			var selectedItem = (GradientDrawable)childrens[0];

			selectedItem.SetStroke(2, CursorColor.ToPlatform());

			platformView.TextCursorDrawable = gradientDrawable;
		}
	}
}
