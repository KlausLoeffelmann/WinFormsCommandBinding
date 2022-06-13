using System.Threading.Tasks;

namespace WinFormsCommandBinding.Models.Service
{
    // This is just an example how to implement the communication between the
    // FormsController and the View (the Form).
    public interface IDialogService
    {
        Task NavigateToAsync(BindableBase RegisteredController, bool modalIfPossible = false);
        Task<string> ShowMessageBoxAsync(string title, string heading, string message, params string[] buttons);
    }
}
