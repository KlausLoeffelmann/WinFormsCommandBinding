using System;
using System.Windows.Forms;

namespace WinFormsCommandBindingDemo
{
    /// <summary>
    /// Enhances the default <see cref="Form"/> to add the concept of <see cref="IDataContextTarget.DataContext"/>, which will be used for binding.
    /// </summary>
    public class DataContextForm : Form, IDataContextTarget
    {
        private static readonly object _eventDataContextChanged = new object();

        private object? _dataContext;

        public DataContextForm()
        {
        }

        /// <summary>
        /// Raised when the value of <see cref="IDataContextTarget.DataContext"/> changes.
        /// </summary>
        public event EventHandler<DataContextEventArgs> DataContextChanged
        {
            add { Events.AddHandler(_eventDataContextChanged, value); }
            remove { Events.RemoveHandler(_eventDataContextChanged, value); }
        }

        /// <inheritdoc/>
        object? IDataContextTarget.DataContext
        {
            get => _dataContext;
            set
            {
                if (_dataContext != value)
                {
                    _dataContext = value;
                    OnDataContextChanged(new DataContextEventArgs(value));
                }
            }
        }

        /// <summary>
        /// Raises the <see cref="DataContextChanged"/> event.
        /// </summary>
        protected virtual void OnDataContextChanged(DataContextEventArgs e)
            => (Events[_eventDataContextChanged] as EventHandler<DataContextEventArgs>)?.Invoke(this, e);
    }
}
