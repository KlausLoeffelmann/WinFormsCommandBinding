using System;
using System.Windows.Forms;
using WinFormsCommandBinding.Models;
using WinFormsCommandBinding.Models.Service;
using WinFormsCommandBindingDemo.Services;

namespace WinFormsCommandBindingDemo
{
    static partial class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            var mainForm = new MainForm();
            mainForm.DataContext = new MainFormController(SimpleServiceProvider.GetInstance())
            {
                TextDocument = "Default text of text document."
            };

            var serviceProvider=SimpleServiceProvider.GetInstance();
            serviceProvider
                .GetRequiredService<WinFormsDialogService>()
                .RegisterUIController(
                    uiController: typeof(OptionsFormController), 
                    viewAsForm: typeof(OptionsForm));

            Application.Run((Form)mainForm);
        }
    }
}
