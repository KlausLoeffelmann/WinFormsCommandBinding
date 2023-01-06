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

            Application.Run(new SimpleTestForm());
            goto End;
            
            var mainForm = new MainForm();

            // We need a marshalling control.
            WinFormsDialogService.RegisterWinFormsAsyncHelper(WinFormsAsyncHelper.GetInstance(mainForm));

            var serviceProvider=SimpleServiceProvider.GetInstance();
            serviceProvider
                .GetRequiredService<WinFormsDialogService>()
                .RegisterUIController(
                    uiController: typeof(OptionsFormController), 
                    viewAsForm: typeof(OptionsForm));

            Application.Run(mainForm);


        End:;
        }
    }
}
