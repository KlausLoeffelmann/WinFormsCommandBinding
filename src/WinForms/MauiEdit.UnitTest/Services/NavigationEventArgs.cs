using WinFormsCommandBinding.Models;

namespace CommandBindingDemo.UnitTest.Services
{
    public class NavigationEventArgs : EventArgs
    {
        public NavigationEventArgs(
            WinFormsViewController? registeredController=null, 
            bool modalIfPossible=false)
        {
            RegisteredControler = registeredController;
            ModalIfPossible = modalIfPossible;
        }

        public WinFormsViewController? RegisteredControler { get; }
        public bool ModalIfPossible { get; }
    }
}
