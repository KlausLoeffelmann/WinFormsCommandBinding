using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Windows.Input;

#nullable enable

namespace WinFormsCommandBinding.Models
{
    public class BindableToolStripMenuItem
        : ToolStripMenuItem, IBindableComponent
    {
        public event EventHandler? BindingContextChanged;
        public event EventHandler? CommandChanged;

        private BindingContext? _bindingContext;
        private ControlBindingsCollection? _dataBindings;
        private ICommand? _command;

        private void UpdateBindings()
        {
            foreach (Binding dataBinding in DataBindings)
            {
                BindingContext.UpdateBinding(BindingContext, dataBinding);
            }
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        protected virtual void OnBindingContextChanged(EventArgs e)
        {
            if (_bindingContext is not null)
            {
                UpdateBindings();
            }

            BindingContextChanged?.Invoke(this, e);
        }

        protected virtual void OnCommandChanged(EventArgs e)
        {
            CommandChanged?.Invoke(this, e);
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [RefreshProperties(RefreshProperties.All)]
        [ParenthesizePropertyName(true)]
        public ControlBindingsCollection DataBindings
        {
            get
            {
                if (_dataBindings is null)
                {
                    _dataBindings = new ControlBindingsCollection(this);
                }
                return _dataBindings;
            }
        }

        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public BindingContext BindingContext
        {
            get
            {
                _bindingContext ??= new BindingContext();
                return _bindingContext;
            }
            set
            {
                if (!Equals(_bindingContext, value))
                {
                    _bindingContext = value;
                    OnBindingContextChanged(EventArgs.Empty);
                }
            }
        }

        [DefaultValue(""), Bindable(true), Localizable(true)]
        public override string Text
        {
            get => base.Text;
            set => base.Text = value;
        }

        [Bindable(true),
         Browsable(false),
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ICommand? Command
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

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            if (Command?.CanExecute(null) ?? false)
            {
                Command.Execute(null);
            }
        }

        private void Command_CanExecuteChanged(object? sender, EventArgs e)
            => Enabled = _command?.CanExecute(null) ?? false;
    }
}
