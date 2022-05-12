using System;
using System.Runtime.CompilerServices;

namespace WinFormsCommandBinding.Models
{
    // Class implements INotifyPropertyChanged and simplifies it correct
    // handling over BindableBase by using [CallingMemberName]

    // Note: This class does not get serialized in this demo, but the
    // binding is working.
    public class OptionsFormController : BindableBase
    {
        private RelayCommand _okCommand;

        private bool _boolOption;
        private string? _textOption;
        private int _numOption;
        private DateTime _dateOption;

        private bool _isDirty;

        public OptionsFormController(IServiceProvider serviceProvider)
            : base(serviceProvider)
        {
            _okCommand = new RelayCommand(ExecuteOK, CanExecuteOK);
        }

        public RelayCommand OKCommand
        {
            get => _okCommand;
            set => base.SetProperty(ref _okCommand, value);
        }

        private void ExecuteOK(object? param)
        {
            Console.WriteLine($"Called ExecuteCommand, parameter: {param}");
        }

        private bool CanExecuteOK(object? _) => _isDirty;

        public bool BoolOption
        {
            get => _boolOption;
            set => base.SetProperty(ref _boolOption, value);
        }

        public string? TextOption
        {
            get => _textOption;
            set => base.SetProperty(ref _textOption, value);
        }

        public int NumOption
        {
            get => _numOption;
            set => base.SetProperty(ref _numOption, value);
        }

        public DateTime DateOption
        {
            get => _dateOption;
            set => base.SetProperty(ref _dateOption, value);
        }

        protected override void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            base.OnPropertyChanged(propertyName);
            if (!_isDirty)
            {
                _isDirty = true;
                OKCommand.RaiseCanExecuteChanged();
            }
        }
    }
}
