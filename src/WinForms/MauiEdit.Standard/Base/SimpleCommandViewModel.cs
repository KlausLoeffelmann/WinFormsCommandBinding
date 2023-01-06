using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WinFormsCommandBinding.Models
{
    public class SimpleCommandViewModel : INotifyPropertyChanged
    {
        // The event that is fired when a property changes.
        public event PropertyChangedEventHandler? PropertyChanged;

        // Backing field for the properties.
        private bool _commandAvailability;
        private RelayCommand _command;
        private string _commandResult = "* not invoked yet *";
        private int _invokeCount;

        public SimpleCommandViewModel()
        {
            _command = new RelayCommand(ExecuteCommand, CanExecuteCommand);
        }

        /// <summary>
        ///  Controls the command availability and is bound to the CheckBox of the Form.
        /// </summary>
        public bool CommandAvailability
        {
            get => _commandAvailability;
            set
            {
                if (_commandAvailability == value)
                {
                    return;
                }

                _commandAvailability = value;

                // When this property changes we need to notify the UI that the command availability has changed.
                // The command's availability is reflected through the button's enabled state, which is - 
                // because its command property is bound - automatically updated.
                _command.NotifyCanExecuteChanged();

                // Notify the UI that the property has changed.
                OnPropertyChanged();
            }
        }

        /// <summary>
        ///  Command that is bound to the button of the Form.
        ///  When the button is clicked, the command is executed.
        /// </summary>
        public RelayCommand Command
        {
            get => _command;
            set
            {
                if (_command == value)
                {
                    return;
                }

                _command = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        ///  The result of the command execution, which is bound to the Form's label.
        /// </summary>
        public string CommandResult
        {
            get => _commandResult;
            set
            {
                if (_commandResult == value)
                {
                    return;
                }

                _commandResult = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        ///  Method that is executed when the command is invoked.
        /// </summary>
        public void ExecuteCommand()
            => CommandResult = $"Command invoked {_invokeCount++} times.";

        /// <summary>
        ///  Method that determines whether the command can be executed. It reflects the 
        ///  property CommandAvailability, which in turn is bound to the CheckBox of the Form.
        /// </summary>
        public bool CanExecuteCommand()
            => CommandAvailability;

        // Notify the UI that one of the properties has changed.
        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
