using System;
using System.Windows.Input;

namespace WinFormsCommandBinding.Models
{
    // Implementation of ICommand - simplified version not taking parameters into account.
    public class RelayCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        private readonly Action _commandAction;
        private readonly Func<bool>? _canExecuteCommandAction;

        public RelayCommand(Action commandAction, Func<bool>? canExecuteCommandAction = null)
        {
            ArgumentNullException.ThrowIfNull(commandAction, nameof(commandAction));

            _commandAction = commandAction;
            _canExecuteCommandAction = canExecuteCommandAction;
        }

        // Implicit interface implementations, since there will never be the necessity to call this 
        // method directly. It will always exclusively be called by the bound command control.
        bool ICommand.CanExecute(object? parameter)
            => _canExecuteCommandAction is null || _canExecuteCommandAction.Invoke();

        void ICommand.Execute(object? parameter)
            => _commandAction.Invoke();

        /// <summary>
        ///  Triggers sending a notification, that the command availability has changed.
        /// </summary>
        public void NotifyCanExecuteChanged()
            => CanExecuteChanged?.Invoke(this, EventArgs.Empty);
    }
}
