using System;
using System.Threading.Tasks;
using WinFormsCommandBinding.Models.Service;

namespace WinFormsCommandBinding.Models
{
    // Class implements INotifyPropertyChanged and simplifies it correct
    // handling over BindableBase by using [CallingMemberName]
    public partial class MainFormController : BindableBase
    {
        private string? _textDocument;
        private int _selectionRow;
        private int _selectionColumn;
        private int _selectionIndex;

        public MainFormController(IServiceProvider serviceProvider)
            : base(serviceProvider)
        {
            _toolsOptionsAsyncCommand = new AsyncRelayCommand(ExecuteToolsOptionAsync);
            _newAsyncCommand = new AsyncRelayCommand(ExecuteNewAsync, CanExecuteContentDependingCommands);
            _toUpperAsyncCommand = new AsyncRelayCommand(ExecuteToUpperAsync, CanExecuteContentDependingCommands);
            _insertDemoTextAsyncCommand = new AsyncRelayCommand(ExecuteInsertDemoTextAsync, CanExecuteContentDependingCommands);
        }

        public string? TextDocument
        {
            get => _textDocument;
            set
            {
                var wasEmpty = String.IsNullOrEmpty(_textDocument);
                SetProperty(ref _textDocument, value);

                if (wasEmpty ^ string.IsNullOrEmpty(_textDocument))
                {
                    NewAsyncCommand.RaiseCanExecuteChanged();
                    ToUpperAsyncCommand.RaiseCanExecuteChanged();
                }
            }
        }

        public int SelectionRow
        {
            get => _selectionRow;
            set => SetProperty(ref _selectionRow, value);
        }

        public int SelectionColumn
        {
            get => _selectionColumn;
            set => SetProperty(ref _selectionColumn, value);
        }

        public int SelectionIndex
        {
            get => _selectionIndex;
            set => SetProperty(ref _selectionIndex, value);
        }
    }
}
