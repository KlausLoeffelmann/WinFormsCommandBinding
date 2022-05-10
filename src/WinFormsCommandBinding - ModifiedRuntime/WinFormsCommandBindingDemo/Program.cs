using System;
using System.Windows.Forms;
using WinFormsCommandBinding.Models;
using WinFormsCommandBinding.Models.Service;

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
            serviceProvider.GetRequiredService<WinFormsDialogService>().RegisterController(
                typeof(OptionsFormController), typeof(OptionsForm));

            Application.Run((Form)mainForm);
        }
    }
}
