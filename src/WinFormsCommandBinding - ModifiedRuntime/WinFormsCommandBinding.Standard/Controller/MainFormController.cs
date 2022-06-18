using System;
using System.Diagnostics;

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
        private int _selectionLength;

        private int _charCountWrapThreshold = 60;

        private (int StartLine, int EndLine) _selectionLines;

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
                (SelectionRow, SelectionColumn) = GetRowAndColumnFromPosition(_selectionIndex);
            }
        }

        public int SelectionLength
        {
            get => _selectionLength;
            set
            {
                SetProperty(ref _selectionLength, value);

                SelectionLines = (
                    SelectionRow,
                    GetRowAndColumnFromPosition(_selectionIndex + _selectionLength).Row);
            }
        }

        public (int StartLine, int EndLine) SelectionLines
        {
            get => _selectionLines;
            set
            {
                SetProperty(ref _selectionLines, value);
                Debug.Print($"SelectionLine: {_selectionLines}");
            }
        }

        private (int Row, int Column) GetRowAndColumnFromPosition(int position)
        {
            if (string.IsNullOrEmpty(TextDocument))
            {
                return (1, 1);
            }

            var crlf = "\r\n";

            int count, lineOffset;
            int previousPos = 0, pos = -crlf.Length;

            // Count the lines:
            for (count = 0; ; count++)
            {
                // When we completely at the right of the line, the previous pos is still it.
                if (pos == position)
                {
                    lineOffset = 0;
                }
                else
                {
                    lineOffset = 1;
                    previousPos = pos;
                }

                pos = TextDocument.IndexOf(crlf, pos + crlf.Length);
                if (pos > position || pos == -1)
                    break;
            }

            var row = count + lineOffset;
            var column = (position - 1) - previousPos;

            return (row, column);
        }
    }
}
