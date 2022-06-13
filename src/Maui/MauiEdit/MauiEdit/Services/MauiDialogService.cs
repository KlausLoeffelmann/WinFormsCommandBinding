using WinFormsCommandBinding.Models;
using WinFormsCommandBinding.Models.Service;

namespace MauiEdit.Services
{
    internal class MauiDialogService : IDialogService
    {
        public void NavigateTo(BindableBase RegisteredController, bool modalIfPossible = false)
        {
            throw new NotImplementedException();
        }

        public string ShowMessageBox(string title, string heading, string message, params string[] buttons)
        {
            throw new NotImplementedException();
        }
    }
}
