using WinFormsCommandBinding.Models;
using WinFormsCommandBinding.Models.Service;

namespace CommandBindingDemo.UnitTest.Services
{
    public class SimpleUnitTestDialogService : IDialogService
    {
        public event EventHandler<NavigationEventArgs>? NavigatedToRequested;
        public event EventHandler<ShowMessageBoxResultEventArgs>? ShowMessageBoxRequested;

        public void NavigateTo(BindableBase registeredController, bool modalIfPossible = false)
        {
            NavigatedToRequested?.Invoke(
                this,
                new NavigationEventArgs(
                    registeredController,
                    modalIfPossible));
        }

        public string ShowMessageBox(string title, string heading, string message, params string[] buttons)
        {
            ShowMessageBoxResultEventArgs eArgs = new();
            ShowMessageBoxRequested?.Invoke(this, eArgs);

            if (eArgs.ResultButtonText is null)
            {
                throw new NullReferenceException("MessageBox test result can't be null.");
            }

            return eArgs.ResultButtonText;
        }
    }
}
