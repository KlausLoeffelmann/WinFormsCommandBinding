Imports System.ComponentModel
Imports System.Windows.Input

Public Class CommandTrackBar
    Inherits TrackBar
    Implements ICommandProvider

    Private _command As ICommand
    Private _commandParameter As Object

    Public Event CommandChanged As EventHandler Implements ICommandProvider.CommandChanged
    Public Event CommandCanExecuteChanged As EventHandler Implements ICommandProvider.CommandCanExecuteChanged
    Public Event CommandExecute As CancelEventHandler Implements ICommandProvider.CommandExecute
    Public Event CommandParameterChanged As EventHandler

    Public Property Command As ICommand _
        Implements ICommandProvider.Command
        Get
            Return _command
        End Get
        Set(value As ICommand)
            ICommandProvider.CommandSetter(Me, value, _command)
        End Set
    End Property

    Public Property CommandParameter As Object _
        Implements ICommandProvider.CommandParameter
        Get
            Return _commandParameter
        End Get
        Set(value As Object)
            _commandParameter = value
            OnCommandParameterChanged(EventArgs.Empty)
        End Set
    End Property

    Protected Overridable Sub OnCommandParameterChanged(e As EventArgs)
        RaiseEvent CommandParameterChanged(Me, e)
    End Sub

    Protected Overrides Sub OnDoubleClick(e As EventArgs)
        MyBase.OnDoubleClick(e)
        ICommandProvider.RequestCommandExecute(Me)
    End Sub

    ''' <summary>
    ''' Provides the previous Enabled value for the ICommandProvider implementation.
    ''' </summary>
    ''' <remarks>
    ''' The interface uses DFI to bring a consistent Command binding implementation along.
    ''' It therefore needs a backing field to save a previous Enabled setting, since
    ''' a components/controls Enabled property Is automatically controlled by the Command
    ''' binding through the CanExecute functionality of the Command binding.
    ''' </remarks>
    Private Property PreviousEnabledStatus As Boolean? _
        Implements ICommandProvider.PreviousEnabledStatus

    Private Shadows Property ICommandProvider_Enabled As Boolean _
        Implements ICommandProvider.Enabled
        Get
            Return MyBase.Enabled
        End Get
        Set(value As Boolean)
            MyBase.Enabled = value
        End Set
    End Property

    Private Sub HandleCommandChanged(e As EventArgs) _
            Implements ICommandProvider.HandleCommandChanged
        OnCommandChanged(e)
    End Sub

    Private Sub HandleCommandCanExecuteChanged(sender As Object, e As EventArgs) _
        Implements ICommandProvider.HandleCommandCanExecuteChanged
        OnCommandCanExecuteChanged(sender, e)
    End Sub

    Private Sub HandleCommandExecute(e As CancelEventArgs) _
        Implements ICommandProvider.HandleCommandExecute
        OnCommandExecute(e)
    End Sub

    Protected Overridable Sub OnCommandChanged(e As EventArgs)
        RaiseEvent CommandChanged(Me, e)
    End Sub

    Protected Overridable Sub OnCommandCanExecuteChanged(sender As Object, e As EventArgs)
        RaiseEvent CommandCanExecuteChanged(sender, e)
    End Sub

    Protected Overridable Sub OnCommandExecute(e As EventArgs)
        RaiseEvent CommandExecute(Me, e)
    End Sub
End Class
