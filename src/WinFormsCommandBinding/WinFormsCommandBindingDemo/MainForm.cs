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

        protected override void OnDataContextChanged(object dataContext)
        {
            base.OnDataContextChanged(dataContext);
            _mainFormControllerBindingSource.DataSource = dataContext;
        }

        private void MainForm_AssignDataContext(object sender, DataContextEventArgs e) 
            => _mainFormControllerBindingSource.DataSource = e.DataContext;
    }
}
