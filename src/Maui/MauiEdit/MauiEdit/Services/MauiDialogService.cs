using WinFormsCommandBinding.Models;
using WinFormsCommandBinding.Models.Service;

namespace MauiEdit.Services
{
    internal class MauiDialogService : IDialogService
    {
        private Page? _marshallingContextAsPage;

        public async Task NavigateToAsync(BindableBase RegisteredController, bool modalIfPossible = false)
        {
            if (_marshallingContextAsPage is not null)
            {
                // await _marshallingContextAsPage.Navigation.PushModalAsync(page);
                await Task.CompletedTask;
                return;
            }

            throw new NullReferenceException($"The marshalling context (a Maui Page) has not been setup.\n" +
                $"Call '{nameof(SetMarshallingContext)}' on '{nameof(IDialogService)}' to setup the page.");
        }

        public void SetMarshallingContext(object syncContext)
        {
            _marshallingContextAsPage = syncContext as Page;
        }

        public async Task<string> ShowMessageBoxAsync(string title, string heading, string message, params string[] buttons)
        {
            if (_marshallingContextAsPage is not null)
            {
                return await _marshallingContextAsPage.DisplayAlert(title, message, buttons[1], buttons[0])
                    ? buttons[1]
                    : buttons[0];
            }

            throw new NullReferenceException($"The marshalling context (a Maui Page) has not been setup.\n" +
                $"Call '{nameof(SetMarshallingContext)}' on '{nameof(IDialogService)}' to setup the page.");
        }
    }
}
