using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Windows.Input;

#nullable enable

namespace WinFormsCommandBinding
{
    public partial class BindableCommandComponent : Component, IBindableComponent
    {
        public event EventHandler? EventSourceComponentChanged;
        public event EventHandler? BindingContextChanged;
        public event EventHandler? CommandChanged;

        private BindingContext? _bindingContext;
        private ControlBindingsCollection? _dataBindings;
        private ICommand? _command;
        private Component? _eventSourceComponent;

        public BindableCommandComponent()
        {
            InitializeComponent();
        }

        public BindableCommandComponent(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private void UpdateBindings()
        {
            for (int i = 0; i < DataBindings.Count; i++)
            {
                BindingContext.UpdateBinding(BindingContext, DataBindings[i]);
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

        protected virtual void OnEventSourceComponentChanged(EventArgs e)
        {
            EventSourceComponentChanged?.Invoke(this, e);
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
                    _command = value;
                    OnCommandChanged(EventArgs.Empty);
                }
            }
        }

        public Component? EventSourceComponent
        {
            get => _eventSourceComponent;
            set
            {
                if (!Equals(_eventSourceComponent, value))
                {
                    _eventSourceComponent = value;
                    OnEventSourceComponentChanged(EventArgs.Empty);
                }
            }
        }
    }
}
