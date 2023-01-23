using MauiEdit.ViewModels;

namespace MauiEdit.UnitTest;

public class NavigationEventArgs : EventArgs
{
    public NavigationEventArgs(
        ViewController? registeredController = null,
        bool modalIfPossible = false)
    {
        RegisteredController = registeredController;
        ModalIfPossible = modalIfPossible;
    }

    public ViewController? RegisteredController { get; }
    public bool ModalIfPossible { get; }
}
