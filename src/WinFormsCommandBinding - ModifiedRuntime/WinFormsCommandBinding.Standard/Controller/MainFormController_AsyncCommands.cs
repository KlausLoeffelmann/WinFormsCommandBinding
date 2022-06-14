using System.Threading.Tasks;
using WinFormsCommandBinding.Models.Service;

namespace WinFormsCommandBinding.Models
{
    // Class implements INotifyPropertyChanged and simplifies it correct
    // handling over BindableBase by using [CallingMemberName]
    public partial class MainFormController : BindableBase
    {
        private AsyncRelayCommand _toolsOptionsAsyncCommand;
        private AsyncRelayCommand _newAsyncCommand;
        private AsyncRelayCommand _toUpperAsyncCommand;
        private AsyncRelayCommand _insertDemoTextAsyncCommand;

        public const string YesButtonText = "Yes";
        public const string NoButtonText = "No";

        public AsyncRelayCommand NewAsyncCommand
        {
            get => _newAsyncCommand;
            set => SetProperty(ref _newAsyncCommand, value);
        }

        public AsyncRelayCommand ToolsOptionsAsyncCommand
        {
            get => _toolsOptionsAsyncCommand;
            set => SetProperty(ref _toolsOptionsAsyncCommand, value);
        }

        public AsyncRelayCommand ToUpperAsyncCommand
        {
            get => _toUpperAsyncCommand;
            set => SetProperty(ref _toUpperAsyncCommand, value);
        }

        private async Task ExecuteToolsOptionAsync(object? _)
        {
            var dialogService = ServiceProvider.GetRequiredService<IDialogService>();
            var optionsFormController = new OptionsFormController(ServiceProvider);
            await dialogService.NavigateToAsync(optionsFormController, true);
        }

        private async Task ExecuteToUpperAsync(object? _)
        {
            if (string.IsNullOrEmpty(_textDocument))
            {
                return;
            }

            string? textTemp = null;

            await Task.Run(() =>
            {
                textTemp = TextDocument?.ToUpper();
            });

            TextDocument = textTemp;
        }

        private async Task ExecuteInsertDemoTextAsync(object? _)
        {
            if (string.IsNullOrEmpty(_textDocument))
            {
                return;
            }

            string? textTemp = null;

            await Task.Run(() =>
            {
                textTemp = TextDocument?.ToUpper();
            });

            TextDocument = textTemp;
        }

        private async Task ExecuteNewAsync(object? _)
        {
            // So, this is how we control the UI via a Controller or ViewModel.
            // We get the required Service over the ServiceProvider, 
            // which the Controller/ViewModels got via Dependency Injection...
            var dialogService = ServiceProvider.GetRequiredService<IDialogService>();

            // Now we use this dialogService to remote-control the UI completely
            // independent of the actual UI technology.
            var buttonString = await dialogService.ShowMessageBoxAsync(
                title: "New Document",
                heading: "Do you want to create a new Document?",
                message: "You are about to create a new Document. The old document will be erased, changes you made will be lost.",
                buttons: new[] { YesButtonText, NoButtonText });

            if (buttonString == YesButtonText)
            {
                TextDocument = string.Empty;
            }
        }

        private bool CanExecuteContentDependingCommands(object? parameter)
            => TextDocument?.Length > 0;
    }
}
