using System;
using System.Diagnostics;
using System.Windows.Forms;
using WinFormsCommandBinding.Models;
using static WinFormsCommandBindingDemo.Program;

namespace WinFormsCommandBindingDemo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // We're emulating a converter: Convert.From (View->ViewModel).
        // In this case we've bound types ViewModel.Tuple(int, int) to View.SelectedLines.
        // 'Parse' converts that from one to the other type.
        private void SelectedLinesbindings_Parse(object? sender, ConvertEventArgs e)
        {
            if (e.Value is SelectedLines selectedLines)
            {
                e.Value = (selectedLines.SelectedRowStart, selectedLines.SelectedRowEnd);
            }
        }

        private void SelectedLinesbindings_Format(object? sender, ConvertEventArgs e)
        {
            if (e.Value is ValueTuple<int,int> startEndLineTuple)
            {
                e.Value=new SelectedLines() 
                { 
                    SelectedRowStart=startEndLineTuple.Item1, 
                    SelectedRowEnd=startEndLineTuple.Item2 
                };
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            DataContext = new MainFormController(SimpleServiceProvider.GetInstance());
        }

        private void MainForm_DataContextChanged(object sender, EventArgs e)
            => _mainFormControllerBindingSource.DataSource = DataContext;

        private void RewrapButton_MouseEnter(object sender, EventArgs e)
        {
            Debug.Print(_rewrapButton.CanSelect.ToString());
        }
    }
}
