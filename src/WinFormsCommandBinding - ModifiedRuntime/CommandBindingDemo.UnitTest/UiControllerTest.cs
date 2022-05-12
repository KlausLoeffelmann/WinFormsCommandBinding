using CommandBindingDemo.UnitTest.Services;
using WinFormsCommandBinding.Models;
using WinFormsCommandBinding.Models.Service;

namespace CommandBindingDemo.UnitTest
{
    public class MainFormUiControllerTest
    {
        internal const string SampleTextDocument = 
            @"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod 
              tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, 
              quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. 
              Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu 
              fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa 
              qui officia deserunt mollit anim id est laborum.";

        [Fact]
        public void MainFormNewDocumentTest()
        {
            var service = SimpleTestServiceProvider.GetInstance();
            var dialogService = (SimpleUnitTestDialogService?) service.GetService(typeof(IDialogService));
            int dialogState = 0;

            Assert.NotNull(dialogService);

            MainFormController mainFormController = new(service);
            
            // We clear the main document.
            mainFormController.TextDocument = string.Empty;

            // We assert, that the New command is disabled, and cannot be called.
            Assert.False(mainFormController.NewCommand.CanExecute(null));

            // We assign a new document.
            mainFormController.TextDocument = SampleTextDocument;

            // We assert, that the New command is enabl;ed, and _can_ be called.
            Assert.True(mainFormController.NewCommand.CanExecute(null));

            // We simulate the user requesting to 'New' the document,
            // but says "No" on the MessageDialogBox to actually clear it.
            dialogService!.ShowMessageBoxRequested += DialogService_ShowMessageBoxRequested;

            // We test the first time; our state machine returns "No" the first time.
            mainFormController.NewCommand.Execute(null);
            Assert.Equal(SampleTextDocument,mainFormController.TextDocument);

            // We test the second time; our state machine returns "Yes" the first time.
            mainFormController.NewCommand.Execute(null);
            Assert.Equal(SampleTextDocument, String.Empty);

            void DialogService_ShowMessageBoxRequested(object? sender, ShowMessageBoxResultEventArgs e) 
                => e.ResultButtonText = dialogState++ switch
                    {
                        0 => MainFormController.NoButtonText,
                        1 => MainFormController.YesButtonText,
                        _ => string.Empty
                    };
        }
    }
}
