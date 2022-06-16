using System;
using System.Linq;
using System.Text;
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
        private AsyncRelayCommand _rewrapAsyncCommand;

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

        public AsyncRelayCommand InsertDemoTextAsyncCommand
        {
            get => _insertDemoTextAsyncCommand;
            set => SetProperty(ref _insertDemoTextAsyncCommand, value);
        }

        public AsyncRelayCommand RewrapAsyncCommand
        {
            get => _rewrapAsyncCommand;
            set => SetProperty(ref _rewrapAsyncCommand, value);
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
            TextDocument = SampleTextDocument;
            await Task.CompletedTask;
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

        private static int CharPosFromLineNumber(string text, int lineNumber)
        {
            if (lineNumber++ == -1)
            {
                return -1;
            }

            var span = text.AsSpan();
            int i = 0;

            do
            {
                if (span[i++] == '\n')
                    lineNumber--;

            } while (i < span.Length && lineNumber > 0);

            return i;
        }

        private async Task ExecuteRewrapAsync(object? _)
        {
            if (String.IsNullOrEmpty(TextDocument) ||
                (SelectionLines.StartLine == SelectionLines.EndLine))
                return;

            TextDocument = await Task.Run<string>(() =>
            {
                var tmpDoc = TextDocument.Replace("\r\n", "\n");

                var firstPartEndPos = CharPosFromLineNumber(tmpDoc, SelectionLines.StartLine-1);
                var wrapPartEndPos = CharPosFromLineNumber(tmpDoc, SelectionLines.EndLine);
                var lastPartEndPos = tmpDoc.Length;

                string firstPart = tmpDoc[0..(firstPartEndPos==-1 ? 0 : firstPartEndPos)];
                string wrapPart = tmpDoc[(firstPartEndPos == -1 ? 0 : firstPartEndPos)..wrapPartEndPos];
                string lastPart = tmpDoc[(wrapPartEndPos == lastPartEndPos ? lastPartEndPos : wrapPartEndPos + 1)..lastPartEndPos];

                // wrapping wrapPart
                StringBuilder wrappedPart = new(wrapPart.Length);
                wrapPart = wrapPart.Replace('\n', ' ');

                int i = 0;
                int lineCharCount = 0;
                int lastPotentialWrapPos = 0;

                while (i < wrapPart.Length)
                {
                    wrappedPart.Append(wrapPart[i]);

                    if (wrapPart[i] == ' ' || wrapPart[i] == '-')
                    {
                        lastPotentialWrapPos = i;
                    }

                    if (lineCharCount++ > CharCountWrapThreshold)
                    {
                        wrappedPart[lastPotentialWrapPos] = '\n';
                        lineCharCount = 0;
                    }

                    i++;
                }

                return (firstPart + wrappedPart.ToString() + "\n" + lastPart).Replace("\n", "\r\n");
            });
        }

        private bool CanExecuteContentDependingCommands(object? parameter)
            => TextDocument?.Length > 0;
    }
}
