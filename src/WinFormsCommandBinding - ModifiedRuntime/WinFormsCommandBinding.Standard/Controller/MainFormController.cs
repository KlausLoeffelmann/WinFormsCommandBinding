using System;

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
        private int _charCountWrapThreshold = 60;

        public const string SampleTextDocument =@"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod
tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam,
quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.
Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu
fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa
qui officia deserunt mollit anim id est laborum.";

        private (int StartLine, int EndLine) _selectionStartLine;

        public MainFormController(IServiceProvider serviceProvider)
            : base(serviceProvider)
        {
            _toolsOptionsAsyncCommand = new AsyncRelayCommand(ExecuteToolsOptionAsync);
            _newAsyncCommand = new AsyncRelayCommand(ExecuteNewAsync, CanExecuteContentDependingCommands);
            _toUpperAsyncCommand = new AsyncRelayCommand(ExecuteToUpperAsync, CanExecuteContentDependingCommands);
            _insertDemoTextAsyncCommand = new AsyncRelayCommand(ExecuteInsertDemoTextAsync, CanExecuteContentDependingCommands);
            _rewrapAsyncCommand = new AsyncRelayCommand(ExecuteRewrapAsync, CanExecuteContentDependingCommands);
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

        public int CharCountWrapThreshold
        {
            get => _charCountWrapThreshold;
            set => SetProperty(ref _charCountWrapThreshold, value);
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

        public (int StartLine, int EndLine) SelectionLines
        {
            get => _selectionStartLine;
            set => SetProperty(ref _selectionStartLine, value);
        }
    }
}
