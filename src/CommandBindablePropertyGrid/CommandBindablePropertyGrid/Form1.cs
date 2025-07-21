using System;
using System.Windows.Forms;

namespace PropertyGridControllerService
{
    public partial class Form1 : Form
    {
        private object _selectedComponent;
        private IPropertyGridControllerService _propertyGridService;

        public Form1()
        {
            InitializeComponent();
            _propertyGridService = GetService<IPropertyGridControllerService>();

            _btnSortAlphabetically.Click +=
                async (s,e) => await _propertyGridService.SortAlphabeticallyAsync();

            _btnSortCategory.Click +=
                async (s, e) => await _propertyGridService.SortByCatogeryAsync();

            _btnExpandAll.Click +=
                async (s, e) => await _propertyGridService.ExpandAllAsync();

            _btnCollapseAll.Click +=
                async (s, e) => await _propertyGridService.CollapseAllAsync();

            _txtFilter.Click +=
                (s,e) => _filterablePropertyGrid.Filter = _txtFilter.Text;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            
            // Hook up click events for all controls in Panel1
            HookUpClickEvents(splitContainer1.Panel1);
        }

        T GetService<T>()
            => (T)(object)_filterablePropertyGrid;

        private void HookUpClickEvents(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                control.Click += Control_Click;
                
                // Recursively hook up events for child controls
                if (control.HasChildren)
                {
                    HookUpClickEvents(control);
                }
            }
        }

        private void Control_Click(object sender, EventArgs e)
        {
            var clickedControl = sender as Control;

            if (clickedControl != null)
            {
                _selectedComponent = clickedControl;
                _filterablePropertyGrid.SelectedObject = clickedControl;
            }
        }
    }
}
