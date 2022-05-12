using System;
using System.Windows.Forms;

namespace WinFormsCommandBindingDemo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_DataContextChanged(object sender, EventArgs e)
            => _mainFormControllerBindingSource.DataSource = DataContext;
    }
}
