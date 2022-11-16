#if ANDROID
	using AndroidX.AppCompat.Widget;
#endif

#if WINDOWS
	using Microsoft.UI.Xaml.Controls;
#endif

namespace MauiEdit;

public partial class MainPage : ContentPage
{
#if ANDROID
	private Timer? _timer;
#endif

	partial void InitializePlatformDependentComponent()
	{
		_editor.HandlerChanged += Editor_HandlerChanged;
#if ANDROID
		_timer = new Timer(TimerCallback, null, 0, 200);
#endif
	}

#if ANDROID
	private void TimerCallback(object? state)
	{
		if (_editor.Handler?.PlatformView is AppCompatEditText editor)
		{
			_editor.CursorPosition = editor.SelectionStart;
			_editor.SelectionLength = editor.SelectionEnd - editor.SelectionStart;
		}
	}
#endif

	private void Editor_HandlerChanged(object? sender, EventArgs e)
	{
		var editor = (Editor)sender!;
		var editorHandler = editor.Handler;

#if WINDOWS
		TextBox nativeTextBox = (TextBox) editorHandler!.PlatformView!;

		nativeTextBox.SelectionChanged += (sender, eArgs)=>
		{
			var textBox = (Microsoft.UI.Xaml.Controls.TextBox)sender;
			_editor.CursorPosition = textBox.SelectionStart;
			_editor.SelectionLength = textBox.SelectionLength;
        };
#endif
	}
}
