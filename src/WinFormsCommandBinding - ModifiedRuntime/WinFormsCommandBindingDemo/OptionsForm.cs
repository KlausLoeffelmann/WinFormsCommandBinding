using System;
using System.Windows.Forms;

namespace WinFormsCommandBindingDemo
{
    public partial class OptionsForm : Form
    {
        public OptionsForm()
        {
            InitializeComponent();
        }

        private void OptionsForm_AssignDataContext(object sender, EventArgs e)
            => _optionsFormControllerBindingSource.DataSource = DataContext;

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("test.");
        }
    }
}
