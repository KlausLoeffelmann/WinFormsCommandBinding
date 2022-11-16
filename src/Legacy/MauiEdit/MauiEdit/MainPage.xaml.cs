namespace MauiEdit;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		InitializePlatformDependentComponent();
	}

	partial void InitializePlatformDependentComponent();
}
