using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace WinFormsCommandBindingDemo
{
    internal class EditorControl : TextBox
    {
        public event EventHandler? SelectionColumnChanged;
        public event EventHandler? SelectionRowChanged;

        private int _selectionRow;
        private int _selectionColumn;

        public EditorControl() : base()
        {
        }

        protected override void OnBindingContextChanged(EventArgs e)
        {
            base.OnBindingContextChanged(e);
            UpdateSelectionInfo();
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            UpdateSelectionInfo();
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
            var tempSelectionRow = GetLineFromCharIndex(SelectionStart) + 1;
            var tempSelectionColumn = (SelectionStart - GetFirstCharIndexOfCurrentLine()) + 1;

            if (tempSelectionRow != _selectionRow)
            {
                _selectionRow = tempSelectionRow;
                OnSelectionRowChanged(EventArgs.Empty);
            }

            if (tempSelectionColumn != _selectionColumn)
            {
                _selectionColumn = tempSelectionColumn;
                OnSelectionColumnChanged(EventArgs.Empty);
            }
        }

        protected virtual void OnSelectionRowChanged(EventArgs e)
        {
            SelectionRowChanged?.Invoke(this, e);
        }

        protected virtual void OnSelectionColumnChanged(EventArgs e)
        {
            SelectionColumnChanged?.Invoke(this, e);
        }

        [Bindable(BindableSupport.Yes)]
        public int SelectionRow
        {
            get => _selectionRow;
            set { }
        }

        [Bindable(BindableSupport.Yes)]
        public int SelectionColumn
        {
            get => _selectionColumn;
            set { }
        }
    }
}
