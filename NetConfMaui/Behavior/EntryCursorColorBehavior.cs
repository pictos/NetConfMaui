namespace NetConfMaui.Behavior;
partial class EntryCursorColorBehavior
{
	public static readonly BindableProperty CursorColorProperty =
		BindableProperty.Create(nameof(CursorColor), typeof(Color), typeof(EntryCursorColorBehavior));

	public Color CursorColor
	{
		get => (Color)GetValue(CursorColorProperty);
		set => SetValue(CursorColorProperty, value);
	}
}
