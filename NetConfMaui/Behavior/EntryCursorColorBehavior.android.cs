using Android.Graphics.Drawables;
using AndroidX.AppCompat.Widget;
using Microsoft.Maui.Platform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetConfMaui.Behavior;

//based on https://docs.microsoft.com/en-us/answers/questions/265520/how-to-dynamically-set-cursor-color-for-entry-and.html
internal class EntryCursorColorBehavior : PlatformBehavior<Entry, AppCompatEditText>
{
	protected override void OnAttachedTo(Entry bindable, AppCompatEditText platformView)
	{

		//platformView.SetTextCursorDrawable(Resource.Drawable.myCursor);

		var gradientDrawable = (StateListDrawable)MainActivity.Activity.GetDrawable(Resource.Drawable.myCursor);
		var drawableContainerState = gradientDrawable.GetConstantState() as DrawableContainer.DrawableContainerState;
		var childrens = drawableContainerState.GetChildren();
		var selectedItem = childrens[0] as GradientDrawable;

		selectedItem.SetStroke(2, Colors.Red.ToPlatform());

		platformView.TextCursorDrawable = gradientDrawable;
	}
}
