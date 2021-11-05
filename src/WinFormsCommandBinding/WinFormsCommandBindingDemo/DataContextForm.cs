using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsCommandBindingDemo
{
    public class DataContextForm : Form, IDataContextTarget
    {
        public event EventHandler<DataContextEventArgs> AssignDataContext;

        private object _dataContext;

        object IDataContextTarget.DataContext
        {
            get => _dataContext;
            set
            {
                AssignDataContext?.Invoke(this, new DataContextEventArgs(value));
                _dataContext = value;
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // DataContextForm
            // 
            this.ClientSize = new System.Drawing.Size(657, 468);
            this.Name = "DataContextForm";
            this.ResumeLayout(false);

        }
    }
}
