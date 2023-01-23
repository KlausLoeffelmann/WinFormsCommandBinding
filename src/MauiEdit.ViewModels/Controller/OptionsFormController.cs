using System;
using System.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiEdit.ViewModels;

// Class implements INotifyPropertyChanged and simplifies it correct
// handling over BindableBase by using [CallingMemberName]

// Note: This class does not get serialized in this demo, but the
// binding is working.
public class OptionsFormController : ViewController
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

    private void ExecuteOK()
    {
        Console.WriteLine($"Called ExecuteCommand.");
    }

    private bool CanExecuteOK() => _isDirty;

    public bool BoolOption
    {
        get => _boolOption;
        set => SetProperty(ref _boolOption, value);
    }

    public string? TextOption
    {
        get => _textOption;
        set => SetProperty(ref _textOption, value);
    }

    public int NumOption
    {
        get => _numOption;
        set => SetProperty(ref _numOption, value);
    }

    public DateTime DateOption
    {
        get => _dateOption;
        set => SetProperty(ref _dateOption, value);
    }

    protected override void OnPropertyChanged(PropertyChangedEventArgs e)
    {
        base.OnPropertyChanged(e);
        if (!_isDirty)
        {
            _isDirty = true;
            OKCommand.NotifyCanExecuteChanged();
        }
    }
}
