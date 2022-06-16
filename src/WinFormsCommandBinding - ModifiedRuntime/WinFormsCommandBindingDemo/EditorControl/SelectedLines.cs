using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Windows.Forms;

namespace WinFormsCommandBindingDemo
{
    public struct SelectedLines
    {
        public int SelectedRowStart { get; set; }
        public int SelectedRowEnd { get; set; }
        public int SelectionStart { get; set; }
        public int SelectionEnd { get; set; }

        public override bool Equals([NotNullWhen(true)] object? obj)
        {
            if (obj is SelectedLines selectedLines)
            {
                return SelectedRowStart.Equals(selectedLines.SelectedRowStart) &&
                       SelectedRowEnd.Equals(selectedLines.SelectedRowEnd);
            }

            return false;
        }

        public override int GetHashCode()
            => ((SelectedRowStart << 16) ^ SelectedRowEnd).GetHashCode();

        internal static SelectedLines GetFromTextBox(TextBox textBox)
        {
            SelectedLines selectedLines = new();

            selectedLines.SelectedRowStart = 
                textBox.GetLineFromCharIndex(textBox.SelectionStart);

            selectedLines.SelectedRowEnd = 
                textBox.GetLineFromCharIndex(textBox.SelectionStart + textBox.SelectionLength);

            Debug.Print($"Selected Row Start/End {selectedLines.SelectedRowStart}" +
                $"/{selectedLines.SelectedRowEnd}");

            selectedLines.SelectionStart = textBox.SelectionStart;
            selectedLines.SelectionEnd = textBox.SelectionLength;

            return selectedLines;
        }
    }
}
