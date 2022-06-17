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

        private (int StartLine, int EndLine) _selectionStartLine;

        public MainFormController(IServiceProvider serviceProvider)
            : base(serviceProvider)
        {
            _toolsOptionsAsyncCommand = new AsyncRelayCommand(ExecuteToolsOptionAsync);
            _newAsyncCommand = new AsyncRelayCommand(ExecuteNewAsync, CanExecuteContentDependingCommands);
            _toUpperAsyncCommand = new AsyncRelayCommand(ExecuteToUpperAsync, CanExecuteContentDependingCommands);
            _insertDemoTextAsyncCommand = new AsyncRelayCommand(ExecuteInsertDemoTextAsync);
            _rewrapAsyncCommand = new AsyncRelayCommand(ExecuteRewrapAsync);
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
            set
            {
                SetProperty(ref _selectionIndex, value);
                UpdateSelectionPosition();
            }
        }

        public (int StartLine, int EndLine) SelectionLines
        {
            get => _selectionStartLine;
            set => SetProperty(ref _selectionStartLine, value);
        }

        private void UpdateSelectionPosition()
        {
            if (string.IsNullOrEmpty(TextDocument))
            {
                SelectionRow = 0;
                SelectionColumn = 0;
                return;
            }

            var tmpDoc = TextDocument.Replace("\r\n", "\r");
            var crlf = "\r";

            int count, lineOffset;
            int previousPos = 0, pos = -crlf.Length;

            // Count the lines:
            for (count = 0; ; count++)
            {
                // When we completely at the right of the line, the previous pos is still it.
                if (pos == SelectionIndex)
                {
                    lineOffset = 0;
                }
                else
                {
                    lineOffset = 1;
                    previousPos = pos;
                }
                
                pos = tmpDoc.IndexOf(crlf, pos + crlf.Length);
                if (pos > SelectionIndex || pos == -1)
                    break;
            }

            SelectionRow = count + lineOffset;
            SelectionColumn = SelectionIndex - previousPos;
        }
    }
}
