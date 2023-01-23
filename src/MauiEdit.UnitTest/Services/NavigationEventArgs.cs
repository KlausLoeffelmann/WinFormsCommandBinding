using MauiEdit.ViewModels;

namespace MauiEdit.UnitTest;

public class NavigationEventArgs : EventArgs
{
    public NavigationEventArgs(
        WinFormsViewController? registeredController = null,
        bool modalIfPossible = false)
    {
        RegisteredController = registeredController;
        ModalIfPossible = modalIfPossible;
    }

    public WinFormsViewController? RegisteredController { get; }
    public bool ModalIfPossible { get; }
}
