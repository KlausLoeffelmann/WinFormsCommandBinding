using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsCommandBindingDemo
{
    internal class EditorControl : TextBox
    {
        public event EventHandler? SelectionColumnChanged;
        public event EventHandler? SelectionRowChanged;
        public event EventHandler? SelectedLinesChanged;

        private int _selectionRow;
        private int _selectionColumn;

        private SelectedLines _selectedLines;
        private SelectedLines? _previousSelectedLines;

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
            var tempSelectionRowStart = GetLineFromCharIndex(SelectionStart) + 1;
            var tempSelectionRowEnd = GetLineFromCharIndex(SelectionStart + SelectionLength + 1);

            var tempSelectionColumn = (SelectionStart - GetFirstCharIndexOfCurrentLine()) + 1;

            if (tempSelectionRowStart != _selectionRow)
            {
                _selectionRow = tempSelectionRowStart;
                OnSelectionRowChanged(EventArgs.Empty);
            }

            if (tempSelectionColumn != _selectionColumn)
            {
                _selectionColumn = tempSelectionColumn;
                OnSelectionColumnChanged(EventArgs.Empty);
            }

            _selectedLines = SelectedLines.GetFromTextBox(this);

            if (!Equals(_previousSelectedLines, _selectedLines))
            {
                _previousSelectedLines = _selectedLines;
                OnSelectedLinesChanges(EventArgs.Empty);
            }
        }

        protected virtual void OnSelectionRowChanged(EventArgs e) 
            => SelectionRowChanged?.Invoke(this, e);

        protected virtual void OnSelectionColumnChanged(EventArgs e) 
            => SelectionColumnChanged?.Invoke(this, e);

        protected virtual void OnSelectedLinesChanges(EventArgs e) 
            => SelectedLinesChanged?.Invoke(this, e);

        [Bindable(BindableSupport.Yes)]
        public SelectedLines SelectedLines
        {
            get => _selectedLines;
            set { }
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
