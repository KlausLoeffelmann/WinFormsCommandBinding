using System;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WinFormsCommandBinding.Models
{
    public class AsyncRelayCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        private readonly Func<object?, Task> _execute;
        private readonly Func<object?, bool>? _canExecute;

        public AsyncRelayCommand(Func<object?, Task> execute) : this(execute, null)
        {
        }

        public AsyncRelayCommand(Func<object?, Task> execute, Func<object?, bool>? canExecute)
        {
            _execute = execute ?? throw new ArgumentNullException(nameof(execute));
            _canExecute = canExecute;
        }

        public void RaiseCanExecuteChanged()
            => CanExecuteChanged?.Invoke(this, EventArgs.Empty);

        public bool CanExecute(object? parameter)
            => _canExecute is null || _canExecute(parameter);

        // This practically has event character, so async void is OK in this case.
        // It's only for when we've been called by the control which invokes us, though.
        // When the command needs to be executed directly, ...
        async void ICommand.Execute(object? parameter) 
            => await _execute(parameter);

        // ...it should rather be done as a "real" async call.
        public async Task ExecuteAsync(object? parameter)
            => await _execute(parameter);
    }
}

