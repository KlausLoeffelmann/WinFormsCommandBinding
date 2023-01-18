using MauiEdit.ViewModels;
using WinFormsCommandBinding.Models.Service;

namespace MauiEdit.UnitTest;

public class SimpleUnitTestDialogService : IDialogService {
    public event EventHandler<NavigationEventArgs>? NavigatedToRequested;
    public event EventHandler<ShowMessageBoxResultEventArgs>? ShowMessageBoxRequested;

    public async Task NavigateToAsync(WinFormsViewController registeredController, bool modalIfPossible = false) {
        NavigatedToRequested?.Invoke(
            this,
            new NavigationEventArgs(
                registeredController,
                modalIfPossible));

        await Task.CompletedTask;
    }

    public void SetMarshallingContext(object syncContext) {
        throw new NotImplementedException();
    }

    public Task<string> ShowMessageBoxAsync(string title, string heading, string message, params string[] buttons) {
        ShowMessageBoxResultEventArgs eArgs = new();
        ShowMessageBoxRequested?.Invoke(this, eArgs);

        if (eArgs.ResultButtonText is null) {
            throw new NullReferenceException("MessageBox test result can't be null.");
        }

        return Task.FromResult(eArgs.ResultButtonText);
    }
}
