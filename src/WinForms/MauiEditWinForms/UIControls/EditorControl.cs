using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

namespace WinFormsCommandBindingDemo
{
    internal class EditorControl : TextBox
    {
        public event EventHandler? SelectionLengthChanged;
        public event EventHandler? CursorPositionChanged;

        private int _cursorPosition;
        private int _everCounter;

        public EditorControl() : base()
        {
        }

        private void UpdateSelectionInfo()
        {
            OnSelectionLengthChanged(EventArgs.Empty);
            CursorPosition = SelectionStart + SelectionLength;
            throw new Exception();
        }

        [Bindable(BindableSupport.Yes)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        public int CursorPosition
        {
            get => _cursorPosition;
            set
            {
                if (value == _cursorPosition)
                {
                    return;
                }

                Debug.Print($"--> Inside CursorPosition Setter: Value:{value}");
                _cursorPosition = value;
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

        protected virtual void OnSelectionLengthChanged(EventArgs e)
            => SelectionLengthChanged?.Invoke(this, e);

        protected virtual void OnCursorPositionChanged(EventArgs e)
        { 
            CursorPositionChanged?.Invoke(this, e);
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            // When EM_LINEFROMCHAR has been called, something changed with the Selection.
            if (m.Msg == 0xd6)
            {
                this.BeginInvoke(() => 
                {
                    try
                    {
                        UpdateSelectionInfo();
                    }
                    catch (Exception)
                    {
                    }
                });
            }
        }
    }
}
