using System;
using System.Windows.Input;

namespace WinFormsCommandBinding.Models
{
    /// <summary>
    ///  Defines a command in a ViewModel/ViewController which can be bound to a property of type ICommand.
    /// </summary>
    /// <remarks></remarks>
    public class RelayCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private readonly Action<object> _execute;
        private readonly Func<bool> _canExecute;

        public RelayCommand(Action<object> execute) : this(execute, null)
        {
        }

        public RelayCommand(Action<object> execute, Func<bool> canExecute)
        {
            if (execute is null)
            {
                throw new ArgumentNullException(nameof(execute));
            }

            _execute = execute;
            _canExecute = canExecute;
        }

        public void RaiseCanExecuteChanged() 
            => CanExecuteChanged?.Invoke(this, EventArgs.Empty);

        public bool CanExecute(object parameter) 
            => _canExecute is null || _canExecute();

        public void Execute(object parameter) 
            => _execute(parameter);
    }
}
