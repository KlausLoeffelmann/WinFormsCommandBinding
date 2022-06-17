using System.Diagnostics;

namespace MauiEdit;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		_editor.HandlerChanged += Editor_HandlerChanged; ;
	}

	private void Editor_HandlerChanged(object sender, EventArgs e)
	{
		var editor=(Editor)sender;
		var editorHandler = editor.Handler;

#if WINDOWS
		Microsoft.UI.Xaml.Controls.TextBox platformView = 
			(Microsoft.UI.Xaml.Controls.TextBox) editorHandler.PlatformView;

		platformView.SelectionChanged += (sender, eArgs)=>
		{
			var textBox = (Microsoft.UI.Xaml.Controls.TextBox)sender;
			_editor.CursorPosition = textBox.SelectionStart;
			_editor.SelectionLength = textBox.SelectionLength;
        };
#endif
    }
}
