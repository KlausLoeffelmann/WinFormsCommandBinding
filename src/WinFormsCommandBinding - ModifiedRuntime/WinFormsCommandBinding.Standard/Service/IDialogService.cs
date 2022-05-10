namespace WinFormsCommandBinding.Models.Service
{
    // This is just an example how to implement the communication between the
    // FormsController and the View (the Form).
    public interface IDialogService
    {
        void NavigateTo(BindableBase RegisteredController, bool modalIfPossible = false);
        string ShowMessageBox(string title, string heading, string message, params string[] buttons);
    }
}
