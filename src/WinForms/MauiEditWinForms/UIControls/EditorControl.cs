using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Input;

namespace WinFormsCommandBindingDemo
{
    internal class EditorControl : TextBox
    {
        public event EventHandler? SelectionLengthChanged;
        public event EventHandler? CursorPositionChanged;

        private int _cursorPosition;

        public EditorControl() : base()
        {
        }

        protected override void OnBindingContextChanged(EventArgs e)
        {
            base.OnBindingContextChanged(e);
            UpdateSelectionInfo();
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);

            var noReactionKeys = new[]
            {
                Keys.ShiftKey, Keys.ControlKey, Keys.Menu,
                Keys.LWin, Keys.RWin, Keys.PrintScreen,
                Keys.NumLock, Keys.Scroll,
                Keys.F1, Keys.F2, Keys.F3, Keys.F4, Keys.F5, Keys.F6,
                Keys.F7, Keys.F8, Keys.F9, Keys.F10, Keys.F11, Keys.F12
            };

            // If one of those keys has been pressed alone,
            // it does nothing to the selection, and we bail.
            if (!noReactionKeys
                .Select(item => (e.KeyCode == item && e.KeyData == item))
                .Any(item => item))
            {
                // Otherwise, the selection may have changed.
                UpdateSelectionInfo();
            }
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            UpdateSelectionInfo();
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            UpdateSelectionInfo();
        }

        private void UpdateSelectionInfo()
        {
            CursorPosition = this.SelectionStart;
            OnSelectionLengthChanged(EventArgs.Empty);
        }

        [Bindable(BindableSupport.Yes)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        public int CursorPosition
        {
            get => _cursorPosition;
            set
            {
                _cursorPosition = value;
                ChangeCursorPositionCore();
                OnCursorPositionChanged(EventArgs.Empty);
            }
        }

        [Bindable(BindableSupport.Yes)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        public new int SelectionLength
        {
            get => base.SelectionLength;

            // We emulate OneWayToSource binding by ignoring the setter.
            // But to trigger the value change, we call OnSelectionLengthChanged
            // from UpdateSelectionInfo.
            set { }
        }

        private void ChangeCursorPositionCore()
        {
            if (_cursorPosition != SelectionStart)
            {
                SelectionStart = CursorPosition;
            }
        }

        protected virtual void OnSelectionLengthChanged(EventArgs e)
            => SelectionLengthChanged?.Invoke(this, e);

        protected virtual void OnCursorPositionChanged(EventArgs e)
            => CursorPositionChanged?.Invoke(this, e);
    }
}
