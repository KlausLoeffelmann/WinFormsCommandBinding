using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WinFormsCommandBinding.Models;
using WinFormsCommandBinding.Models.Service;

namespace WinFormsCommandBindingDemo
{
    public interface IDataContextTarget
    {
        object DataContext { get; set; }
    }

    public class WinFormsDialogService : IDialogService
    {
        private readonly Dictionary<Type, Type> _controllerFormTypeLookup = new();

        public void RegisterController(Type controller, Type viewAsForm)
        {
            // TODO: Type Check as runtime.
            _controllerFormTypeLookup.Add(controller, viewAsForm);
        }

        public void NavigateTo(BindableBase registeredController, bool modalIfPossible = false)
        {
            if (_controllerFormTypeLookup.TryGetValue(registeredController.GetType(), out var viewType))
            {
                var view = (IDataContextTarget) Activator.CreateInstance(viewType);
                view.DataContext = registeredController;

                if (modalIfPossible)
                {
                    // Since the Buttons are command-bound
                    // the ViewModel knows the result.
                    ((Form)view).ShowDialog();
                }
                else
                {
                    // This needs more Infrastructure.
                    // We're only showing the Form.
                    // But the View inside the Form
                    // conainer could change to implement
                    // a real navigation.
                    ((Form)view).Show();
                }
            }
        }

        public string ShowMessageBox(string title, string heading, string message, params string[] buttons)
        {
            var mainDialogPage = new TaskDialogPage()
            {
                Caption = title,
                Heading = heading,
                Text = message,
                // TODO: This would need to be better configured.
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
            TaskDialogButton result = TaskDialog.ShowDialog(mainDialogPage);
            return result.Text;
        }
    }
}
