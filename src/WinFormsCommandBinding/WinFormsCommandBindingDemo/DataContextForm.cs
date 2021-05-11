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
    }
}
