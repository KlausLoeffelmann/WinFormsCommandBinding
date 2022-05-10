using System;
using System.Windows.Forms;

namespace WinFormsCommandBindingDemo
{
    public partial class MainForm : DataContextForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_DataContextChanged(object sender, EventArgs e)
            => _mainFormControllerBindingSource.DataSource = DataContext;
    }
}
