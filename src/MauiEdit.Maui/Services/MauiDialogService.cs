using MauiEdit.ViewModels;

#nullable enable

namespace MauiEdit.Services;

internal class MauiDialogService : IDialogService
{
    private Page? _marshallingContextAsPage;
    private readonly Dictionary<Type, Type> _controllerFormTypeLookup = new();

    public async Task NavigateToAsync(ViewController registeredController, bool modalIfPossible = false)
    {
        if (_marshallingContextAsPage is null)
        {
            throw new NullReferenceException($"The marshalling context (a Maui Page) has not been setup.\n" +
                $"Call '{nameof(SetMarshallingContext)}' on '{nameof(IDialogService)}' to setup the page.");
        }

        if (_controllerFormTypeLookup.TryGetValue(registeredController.GetType(), out var viewType))
        {
            if (Activator.CreateInstance(viewType) is Page view)
            {
                view.BindingContext = registeredController;

                // For simplicity we're showing the Page on the modal stack always.
                await _marshallingContextAsPage.Navigation.PushModalAsync(view);
            }
        }
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

    public void RegisterUIController(Type uiController, Type viewAsForm)
    {
        _controllerFormTypeLookup.Add(uiController, viewAsForm);
    }
}
