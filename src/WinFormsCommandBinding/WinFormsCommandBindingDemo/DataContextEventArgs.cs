using System;

namespace WinFormsCommandBindingDemo
{
    public class DataContextEventArgs : EventArgs
    {
        public DataContextEventArgs(object? dataContext)
        {
            DataContext = dataContext;
        }

        public object? DataContext { get; }
    }
}
