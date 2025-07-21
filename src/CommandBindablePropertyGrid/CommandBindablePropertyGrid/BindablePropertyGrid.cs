using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommandBindablePropertyGrid;

namespace PropertyGridControllerService
{
    public class BindablePropertyGrid
        : PropertyGrid, IPropertyGridControllerService
    {
        private List<ToolStripButton> _toolStripButtons = new List<ToolStripButton>();
        private FilterableObjectProxy _selectedObject = new FilterableObjectProxy(null, string.Empty);
        private ToolStrip _toolStrip;

        public BindablePropertyGrid()
        {
            ToolStripRenderer = new BindablePropertyGridToolStripRenderer(this);
            ToolbarVisible = false;
            base.SelectedObject = _selectedObject;
        }

        internal ToolStrip ToolStrip
        {
            get => _toolStrip;
            set
            {
                if (object.Equals(_toolStrip, value))
                {
                    return;
                }

                _toolStrip = value;
                CollectToolbarButtons();
            }
        }

        public string Filter
        {
            get => _selectedObject.Filter;
            set
            {
                _selectedObject.Filter = value;
                Refresh();
            }
        }

        public new object SelectedObject
        {
            get => _selectedObject.Value;

            set
            {
                _selectedObject.Value = value;
                Refresh();
            }
        }

        private void CollectToolbarButtons()
        {
            _toolStripButtons.Clear();

            // Get all the Buttons with a name in their Accessible Object from the ToolStrip:
            foreach (ToolStripItem item in ToolStrip.Items)
            {
                if (item is ToolStripButton toolStripButton
                    && !string.IsNullOrEmpty(item.AccessibilityObject.Name))
                {
                    _toolStripButtons.Add(toolStripButton);
                }
            }
        }

        Task IPropertyGridControllerService.CollapseAllAsync()
        {
            CollapseAllGridItems();
            return Task.CompletedTask;
        }

        Task IPropertyGridControllerService.ExpandAllAsync()
        {
            ExpandAllGridItems();
            return Task.CompletedTask;
        }

        Task IPropertyGridControllerService.FilterPropertiesAsync(string filterTerm)
        {
            Filter = filterTerm;
            return Task.CompletedTask;
        }

        Task IPropertyGridControllerService.ShowEventTabAsync()
        {
            _toolStripButtons[(int)PropertyGridCommand.ShowEvents].PerformClick();
            return Task.CompletedTask;
        }

        Task IPropertyGridControllerService.ShowPropertyTabAsync()
        {
            _toolStripButtons[(int)PropertyGridCommand.ShowProperties].PerformClick();
            return Task.CompletedTask;
        }

        Task IPropertyGridControllerService.SortAlphabeticallyAsync()
        {
            _toolStripButtons[(int)PropertyGridCommand.SortAlphabetically].PerformClick();
            return Task.CompletedTask;
        }

        Task IPropertyGridControllerService.SortByCatogeryAsync()
        {
            _toolStripButtons[(int)PropertyGridCommand.SortByCategory].PerformClick();
            return Task.CompletedTask;
        }
    }
}
