using System.Windows.Forms;

namespace WinFormsCommandBindingDemo
{
    public partial class OptionsForm : DataContextForm
    {
        public OptionsForm()
        {
            InitializeComponent();
        }

        private void OptionsForm_AssignDataContext(object sender, DataContextEventArgs e) 
            => _optionsFormControllerBindingSource.DataSource = e.DataContext;
    }
}
