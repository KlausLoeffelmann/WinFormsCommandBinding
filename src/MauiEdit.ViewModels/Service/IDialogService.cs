using System.Threading.Tasks;
using MauiEdit.ViewModels;

namespace WinFormsCommandBinding.Models.Service
{
    // This is just an example how to implement the communication between the
    // FormsController and the View (the Form).
    public interface IDialogService
    {
        void SetMarshallingContext(object syncContext);
        Task NavigateToAsync(WinFormsViewController RegisteredController, bool modalIfPossible = false);
        Task<string> ShowMessageBoxAsync(string title, string heading, string message, params string[] buttons);
    }
}
