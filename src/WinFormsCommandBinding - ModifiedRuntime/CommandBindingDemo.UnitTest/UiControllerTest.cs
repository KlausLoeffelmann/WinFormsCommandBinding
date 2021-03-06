using CommandBindingDemo.UnitTest.Services;
using WinFormsCommandBinding.Models;
using WinFormsCommandBinding.Models.Service;

namespace CommandBindingDemo.UnitTest
{
    public class MainFormUiControllerTest
    {
        [Fact]
        public async Task MainFormNewDocumentTest()
        {
            var service = SimpleTestServiceProvider.GetInstance();
            var dialogService = (SimpleUnitTestDialogService?)service.GetService(typeof(IDialogService));
            int dialogState = 0;

            Assert.NotNull(dialogService);

            MainFormController mainFormController = new(service);

            // We clear the main document.
            mainFormController.TextDocument = string.Empty;

            // We assert, that the New command is disabled, and cannot be called.
            Assert.False(mainFormController.NewAsyncCommand.CanExecute(null));

            // We assign a new document.
            mainFormController.TextDocument = MainFormController.GetTestText();

            // We assert, that the New command is enabl;ed, and _can_ be called.
            Assert.True(mainFormController.NewAsyncCommand.CanExecute(null));

            // We simulate the user requesting to 'New' the document,
            // but says "No" on the MessageDialogBox to actually clear it.
            dialogService!.ShowMessageBoxRequested += DialogService_ShowMessageBoxRequested;

            // We test the first time; our state machine returns "No" the first time.
            await mainFormController.NewAsyncCommand.ExecuteAsync(null);
            Assert.Equal(MainFormController.GetTestText(), mainFormController.TextDocument);

            // We test the second time; our state machine returns "Yes" the first time.
            await mainFormController.NewAsyncCommand.ExecuteAsync(null);
            Assert.Equal(String.Empty, mainFormController.TextDocument);

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
