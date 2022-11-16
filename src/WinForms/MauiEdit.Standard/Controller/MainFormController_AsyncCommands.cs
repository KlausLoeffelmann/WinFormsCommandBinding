﻿using CommunityToolkit.Mvvm.Input;
using System;
using System.Text;
using System.Threading.Tasks;
using WinFormsCommandBinding.Models.Service;

namespace WinFormsCommandBinding.Models
{
    // Class implements INotifyPropertyChanged and simplifies it correct
    // handling over BindableBase by using [CallingMemberName]
    public partial class MainFormController : WinFormsViewController
    {
        private AsyncRelayCommand _toolsOptionsAsyncCommand;
        private AsyncRelayCommand _newAsyncCommand;
        private AsyncRelayCommand _testAsyncCommand;
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

        public AsyncRelayCommand TestAsyncCommand
        {
            get => _testAsyncCommand;
            set => SetProperty(ref _testAsyncCommand, value);
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

        private async Task ExecuteTestAsync()
        {
            await Task.Delay(0);
        }

        private async Task ExecuteToolsOptionAsync()
        {
            var dialogService = ServiceProvider.GetRequiredService<IDialogService>();
            var optionsFormController = new OptionsFormController(ServiceProvider);
            await dialogService.NavigateToAsync(optionsFormController, true);
        }

        private async Task ExecuteToUpperAsync()
        {
            if (string.IsNullOrEmpty(TextDocument))
            {
                return;
            }

            string tempText = null!;
            var savedSelectionIndex = SelectionIndex;

            await Task.Run(() =>
            {
                var upperText = TextDocument[SelectionIndex..(SelectionIndex + SelectionLength)].ToUpper();

                tempText = string.Concat(
                    TextDocument[..SelectionIndex].AsSpan(),
                    upperText.AsSpan(),
                    TextDocument[(SelectionIndex + SelectionLength)..].AsSpan());
            });

            TextDocument = tempText;
            SelectionIndex = savedSelectionIndex;
        }

        private async Task ExecuteInsertDemoTextAsync()
        {
            TextDocument = GetTestText();
            await Task.CompletedTask;
        }

        private async Task ExecuteNewAsync()
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

        private async Task ExecuteRewrapAsync()
        {
            if (String.IsNullOrEmpty(TextDocument))
                return;

            var cursorPos = SelectionIndex;

            TextDocument = await Task.Run<string>(() =>
            {
                var firstPartEndPos = CharPosFromLineNumber(SelectionLines.StartLine - 1);
                var wrapPartEndPos = CharPosFromLineNumber(SelectionLines.EndLine);
                var lastPartEndPos = TextDocument.Length;

                string firstPart = TextDocument[0..(firstPartEndPos == -1 ? 0 : firstPartEndPos)];
                string wrapPart = TextDocument[(firstPartEndPos == -1 ? 0 : firstPartEndPos)..wrapPartEndPos];
                string lastPart = TextDocument[(wrapPartEndPos == lastPartEndPos ? lastPartEndPos : wrapPartEndPos)..lastPartEndPos];

                // Wrapping just the wrapPart.
                StringBuilder wrappedPart = new(wrapPart.Length);
                wrapPart = wrapPart.Replace(CarriageReturn, " ").Replace("  ", " ");

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
                        wrappedPart[lastPotentialWrapPos] = '\r';
                        lineCharCount = 0;
                    }

                    i++;
                }

                if (CarriageReturn != "\r")
                {
                    wrappedPart = wrappedPart.Replace("\r", CarriageReturn);
                }

                return (firstPart + wrappedPart.ToString() + CarriageReturn + lastPart);
            });

            SelectionIndex = cursorPos;
        }

        private bool CanExecuteContentDependingCommands()
            => TextDocument?.Length > 0;
    }
}
