using System;
using System.ComponentModel;

namespace WinFormsCommandBinding.Models.Controller
{
    public class SimpleEditorController : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private string? _textDocument;
        
        // Simple class which implements the details of ICommand.
        private RelayCommand? _newCommand;

        public SimpleEditorController()
        {
            _newCommand = new(ExecuteRelayCommand, CanExecuteRelayCommand);
        }

        private void ExecuteRelayCommand(object? commandParameter)
            => TextDocument = String.Empty;

        private bool CanExecuteRelayCommand(object? commandParameter)
            => TextDocument != String.Empty;

        public RelayCommand? NewCommand
        {
            get => _newCommand;

            set
            {
                if (!Equals(_newCommand, value))
                {
                    _newCommand = value;
                    PropertyChanged?.Invoke(this, new(nameof(NewCommand)));
                }
            }
        }

        public string? TextDocument
        {
            get => _textDocument;

            set
            {
                var wasEmpty = String.IsNullOrEmpty(_textDocument);

                if (!Equals(_textDocument, value))
                {
                    _textDocument = value;
                    PropertyChanged?.Invoke(this, new(nameof(TextDocument)));

                    if (wasEmpty ^ string.IsNullOrEmpty(_textDocument))
                    {
                        // Execution-Context changed because the TextDocument was empty
                        // and now it's not anymore or viceversa.
                        NewCommand?.RaiseCanExecuteChanged();
                    }
                }
            }
        }
    }
}
