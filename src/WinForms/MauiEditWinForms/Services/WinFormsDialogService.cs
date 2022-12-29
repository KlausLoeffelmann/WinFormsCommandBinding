using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsCommandBinding.Models;
using WinFormsCommandBinding.Models.Service;

namespace WinFormsCommandBindingDemo.Services
{
    internal class WinFormsDialogService : IDialogService
    {
        private readonly Dictionary<Type, Type> _controllerFormTypeLookup = new();

        private static SynchronizationContext? s_winFormsSyncContext 
            = SynchronizationContext.Current;

        private static WinFormsAsyncHelper? s_asyncHelper;

        public static void RegisterWinFormsAsyncHelper(WinFormsAsyncHelper asyncHelper)
        {
            if (asyncHelper is null)
            {
                throw new ArgumentNullException(nameof(asyncHelper));
            }

            s_asyncHelper = asyncHelper;
        }

        public void RegisterUIController(Type uiController, Type viewAsForm)
        {
            if (s_winFormsSyncContext is null)
            {
                throw new Exception("Fail to retrieve a WinForms synchronization context, " +
                    "which is needed to run asynchronous Dialog Service calls.");
            }

            _controllerFormTypeLookup.Add(uiController, viewAsForm);
        }

        public async Task NavigateToAsync(WinFormsViewController registeredController, bool modalIfPossible = false)
        {
            if (_controllerFormTypeLookup.TryGetValue(registeredController.GetType(), out var viewType))
            {
                if (Activator.CreateInstance(viewType) is Form view)
                {
                    view.DataContext = registeredController;

                    if (modalIfPossible)
                    {
                        // Since the Buttons are supposed to be command-bound
                        // the ViewModel should know the dialog result via binding.
                        await s_asyncHelper!.InvokeAsync(
                            () => view.ShowDialog());
                    }
                    else
                    {
                        // This needs more Infrastructure.
                        // We're only showing the Form.
                        // But the View inside the Form
                        // container could change to implement
                        // a real navigation.
                        view.Show();
                    }
                }
            }
        }

        public async Task<string> ShowMessageBoxAsync(string title, string heading, string message, params string[] buttons)
        {
            var mainDialogPage = new TaskDialogPage()
            {
                Caption = title,
                Heading = heading,
                Text = message,

                // TODO: This has room for improvement!
                Icon = TaskDialogIcon.Information
            };

            var taskDialogButtons = new TaskDialogButtonCollection();

            foreach (var buttonString in buttons)
            {
                // Each of the buttons will be enabled and close the MessageBox.
                taskDialogButtons.Add(
                    new TaskDialogButton(
                        buttonString,
                        enabled: true,
                        allowCloseDialog: true));
            }

            mainDialogPage.Buttons = taskDialogButtons;

            TaskDialogButton result;

            result = await s_asyncHelper!.InvokeAsync(
                () => TaskDialog.ShowDialog(mainDialogPage));
            
            return result.ToString();
        }

        public void SetMarshallingContext(object syncContext)
        {
            throw new NotImplementedException();
        }
    }
}
