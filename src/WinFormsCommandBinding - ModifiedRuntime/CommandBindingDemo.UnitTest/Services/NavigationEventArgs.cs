using WinFormsCommandBinding.Models;

namespace CommandBindingDemo.UnitTest.Services
{
    public class NavigationEventArgs : EventArgs
    {
        public NavigationEventArgs(
            BindableBase? registeredController=null, 
            bool modalIfPossible=false)
        {
            RegisteredControler = registeredController;
            ModalIfPossible = modalIfPossible;
        }

        public BindableBase? RegisteredControler { get; }
        public bool ModalIfPossible { get; }
    }
}
