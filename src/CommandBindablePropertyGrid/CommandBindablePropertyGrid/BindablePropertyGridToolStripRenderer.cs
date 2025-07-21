using System.Windows.Forms;

namespace PropertyGridControllerService
{
    internal class BindablePropertyGridToolStripRenderer : ToolStripRenderer
    {
        BindablePropertyGrid _parentPropertyGrid;

        public BindablePropertyGridToolStripRenderer(BindablePropertyGrid propertyGrid)
        {
            _parentPropertyGrid = propertyGrid;
        }

        protected override void Initialize(ToolStrip toolStrip)
        {
            base.Initialize(toolStrip);
            _parentPropertyGrid.ToolStrip = toolStrip;
        }
    }
}
