using System;
using WinFormsCommandBinding.Models.Service;

namespace WinFormsCommandBinding.Models
{
    // Class implements INotifyPropertyChanged and simplifies it correct
    // handling over BindableBase by using [CallingMemberName]
    public class MainFormController : BindableBase
    {
        private RelayCommand _toolsOptionsCommand;
        private RelayCommand _toUpperCommand;
        private RelayCommand _newCommand;

        private const string YesButton = "Yes";
        private const string NoButton = "No";

        private string? _textDocument;

        public MainFormController(IServiceProvider serviceProvider)
            : base(serviceProvider)
        {
            _toolsOptionsCommand = new RelayCommand(ExecuteToolsOptionCommand);
            _toUpperCommand = new RelayCommand(ExecuteToUpper, CanExecuteContentDependingCommands);
            _newCommand = new RelayCommand(ExecuteNew, CanExecuteContentDependingCommands);
        }

        public RelayCommand ToolsOptionsCommand
        {
            get => _toolsOptionsCommand;
            set => SetProperty(ref _toolsOptionsCommand, value);
        }

        private void ExecuteToolsOptionCommand(object param)
        {
            var dialogService = ServiceProvider.GetRequiredService<IDialogService>();
            var optionsFormController = new OptionsFormController(ServiceProvider);
            dialogService.NavigateTo(optionsFormController, true);
        }

        public RelayCommand ToUpperCommand
        {
            get => _toUpperCommand;
            set => SetProperty(ref _toUpperCommand, value);
        }

        private void ExecuteToUpper(object param)
        {
            TextDocument = TextDocument.ToUpper();
        }

        public RelayCommand NewCommand
        {
            get => _newCommand;
            set => SetProperty(ref _newCommand, value);
        }

        private void ExecuteNew(object param)
        {
            // So, this is how we control the UI via a Controller or ViewModel.
            // We get the required Service over the ServiceProvider, 
            // which the Controller/ViewModels got via Dependency Injection...
            var dialogService = ServiceProvider.GetRequiredService<IDialogService>();

            // Now we use this dialogService to remote-control the UI completely
            // independent of the actual UI technology.
            var buttonString = dialogService.ShowMessageBox(
                title: "New Document",
                heading: "Do you want to create a new Document?",
                message: "You are about to create a new Document. The old document will be erased, changes you made will be lost.",
                buttons: new[] { YesButton, NoButton });

            if (buttonString == YesButton)
            {
                TextDocument = string.Empty;
            }
        }

        private bool CanExecuteContentDependingCommands() 
            => TextDocument.Length > 0;

        public string? TextDocument
        {
            get => _textDocument;
            set
            {
                var wasEmpty = String.IsNullOrEmpty(_textDocument);
                base.SetProperty(ref _textDocument, value);
                if (wasEmpty ^ string.IsNullOrEmpty(_textDocument))
                {
                    NewCommand.RaiseCanExecuteChanged();
                    ToUpperCommand.RaiseCanExecuteChanged();
                }
            }
        }
    }
}
