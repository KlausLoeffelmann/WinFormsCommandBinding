using IDialogService = WinFormsCommandBinding.Models.Service.IDialogService;

namespace MauiEdit;

public partial class App : Application
{
    public App(IServiceProvider serviceProvider)
    {
		InitializeComponent();

        var dialogService = serviceProvider.GetRequiredService<IDialogService>();

        MainPage = new AppShell();
        dialogService.SetMarshallingContext(MainPage);

		MainPage.BindingContext = new WinFormsCommandBinding.Models.MainFormController(serviceProvider);
	}
}
