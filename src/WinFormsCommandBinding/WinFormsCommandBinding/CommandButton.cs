using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Windows.Input;

namespace WinFormsCommandBinding
{
    public class CommandButton : Button
    {
        public event EventHandler CommandChanged;

        private ICommand _command;

        [Bindable(true),
         Browsable(false),
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ICommand Command
        {
            get => _command;
            set
            {
                if (!Equals(_command, value))
                {
                    if (_command is not null)
                    {
                        _command.CanExecuteChanged -= Command_CanExecuteChanged;
                    }

                    // Q: Do we need to restore Enabled, if _command changes from {} to null?

                    _command = value;
                    OnCommandChanged(EventArgs.Empty);

                    if (_command is null)
                    {
                        return;
                    }

                    _command.CanExecuteChanged += Command_CanExecuteChanged;
                    Enabled = _command.CanExecute(null);
                }
            }
        }

        protected virtual void OnCommandChanged(EventArgs e) 
            => CommandChanged?.Invoke(this, e);

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            if (Command?.CanExecute(null) ?? false)
            {
                Command.Execute(null);
            }
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            if (!disposing)
            {
                return;
            }

            if (_command is not null)
            {
                _command.CanExecuteChanged -= Command_CanExecuteChanged;
            }
        }

        private void Command_CanExecuteChanged(object sender, EventArgs e) 
            => Enabled = _command.CanExecute(null);
    }
}
