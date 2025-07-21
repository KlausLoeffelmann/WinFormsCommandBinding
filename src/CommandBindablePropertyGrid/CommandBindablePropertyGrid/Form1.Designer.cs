namespace PropertyGridControllerService
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._filterablePropertyGrid = new PropertyGridControllerService.BindablePropertyGrid();
            this._txtFilter = new System.Windows.Forms.TextBox();
            this._btnRefresh = new System.Windows.Forms.Button();
            this._btnCollapseAll = new System.Windows.Forms.Button();
            this._btnExpandAll = new System.Windows.Forms.Button();
            this._btnSortCategory = new System.Windows.Forms.Button();
            this._btnSortAlphabetically = new System.Windows.Forms.Button();
            this._lblFilterCaption = new System.Windows.Forms.Label();
            this._statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this._statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.radioButton2);
            this.splitContainer1.Panel1.Controls.Add(this.radioButton1);
            this.splitContainer1.Panel1.Controls.Add(this.checkBox1);
            this.splitContainer1.Panel1.Controls.Add(this.richTextBox1);
            this.splitContainer1.Panel1.Controls.Add(this.listBox1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.button5);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(978, 593);
            this.splitContainer1.SplitterDistance = 457;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(42, 134);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(153, 32);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(30, 81);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(153, 32);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(30, 40);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(130, 32);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(205, 40);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(229, 256);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "Some Rich Text for the RichTextBox.";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 28;
            this.listBox1.Items.AddRange(new object[] {
            "ListBox Entry 1",
            "ListBox Entry 2",
            "ListBox Entry 3",
            "ListBox Entry 4"});
            this.listBox1.Location = new System.Drawing.Point(82, 352);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(225, 172);
            this.listBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 226);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(148, 70);
            this.button5.TabIndex = 0;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this._filterablePropertyGrid, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this._txtFilter, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this._btnRefresh, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this._btnCollapseAll, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this._btnExpandAll, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this._btnSortCategory, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this._btnSortAlphabetically, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this._lblFilterCaption, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(516, 593);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // _filterablePropertyGrid
            // 
            this._filterablePropertyGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._filterablePropertyGrid.Filter = "";
            this._filterablePropertyGrid.Location = new System.Drawing.Point(154, 46);
            this._filterablePropertyGrid.Margin = new System.Windows.Forms.Padding(4);
            this._filterablePropertyGrid.Name = "_filterablePropertyGrid";
            this.tableLayoutPanel1.SetRowSpan(this._filterablePropertyGrid, 4);
            this._filterablePropertyGrid.Size = new System.Drawing.Size(358, 432);
            this._filterablePropertyGrid.TabIndex = 0;
            this._filterablePropertyGrid.ToolbarVisible = false;
            // 
            // _txtFilter
            // 
            this._txtFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._txtFilter.Location = new System.Drawing.Point(154, 4);
            this._txtFilter.Margin = new System.Windows.Forms.Padding(4);
            this._txtFilter.Name = "_txtFilter";
            this._txtFilter.Size = new System.Drawing.Size(358, 34);
            this._txtFilter.TabIndex = 1;
            // 
            // _btnRefresh
            // 
            this._btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._btnRefresh.Location = new System.Drawing.Point(10, 492);
            this._btnRefresh.Margin = new System.Windows.Forms.Padding(10);
            this._btnRefresh.Name = "_btnRefresh";
            this._btnRefresh.Size = new System.Drawing.Size(130, 91);
            this._btnRefresh.TabIndex = 5;
            this._btnRefresh.Text = "Refresh";
            this._btnRefresh.UseVisualStyleBackColor = true;
            // 
            // _btnCollapseAll
            // 
            this._btnCollapseAll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._btnCollapseAll.Location = new System.Drawing.Point(10, 382);
            this._btnCollapseAll.Margin = new System.Windows.Forms.Padding(10);
            this._btnCollapseAll.Name = "_btnCollapseAll";
            this._btnCollapseAll.Size = new System.Drawing.Size(130, 90);
            this._btnCollapseAll.TabIndex = 6;
            this._btnCollapseAll.Text = "Collapse all";
            this._btnCollapseAll.UseVisualStyleBackColor = true;
            // 
            // _btnExpandAll
            // 
            this._btnExpandAll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._btnExpandAll.Location = new System.Drawing.Point(10, 272);
            this._btnExpandAll.Margin = new System.Windows.Forms.Padding(10);
            this._btnExpandAll.Name = "_btnExpandAll";
            this._btnExpandAll.Size = new System.Drawing.Size(130, 90);
            this._btnExpandAll.TabIndex = 4;
            this._btnExpandAll.Text = "Expand all";
            this._btnExpandAll.UseVisualStyleBackColor = true;
            // 
            // _btnSortCategory
            // 
            this._btnSortCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._btnSortCategory.Location = new System.Drawing.Point(10, 162);
            this._btnSortCategory.Margin = new System.Windows.Forms.Padding(10);
            this._btnSortCategory.Name = "_btnSortCategory";
            this._btnSortCategory.Size = new System.Drawing.Size(130, 90);
            this._btnSortCategory.TabIndex = 3;
            this._btnSortCategory.Text = "Sort Category";
            this._btnSortCategory.UseVisualStyleBackColor = true;
            // 
            // _btnSortAlphabetically
            // 
            this._btnSortAlphabetically.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._btnSortAlphabetically.Location = new System.Drawing.Point(10, 52);
            this._btnSortAlphabetically.Margin = new System.Windows.Forms.Padding(10);
            this._btnSortAlphabetically.Name = "_btnSortAlphabetically";
            this._btnSortAlphabetically.Size = new System.Drawing.Size(130, 90);
            this._btnSortAlphabetically.TabIndex = 2;
            this._btnSortAlphabetically.Text = "Sort Alpha";
            this._btnSortAlphabetically.UseVisualStyleBackColor = true;
            // 
            // _lblFilterCaption
            // 
            this._lblFilterCaption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._lblFilterCaption.AutoSize = true;
            this._lblFilterCaption.Location = new System.Drawing.Point(3, 7);
            this._lblFilterCaption.Name = "_lblFilterCaption";
            this._lblFilterCaption.Size = new System.Drawing.Size(144, 28);
            this._lblFilterCaption.TabIndex = 7;
            this._lblFilterCaption.Text = "Filter:";
            // 
            // _statusStrip
            // 
            this._statusStrip.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this._statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this._statusStrip.Location = new System.Drawing.Point(0, 593);
            this._statusStrip.Name = "_statusStrip";
            this._statusStrip.Size = new System.Drawing.Size(978, 37);
            this._statusStrip.TabIndex = 4;
            this._statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(179, 30);
            this.toolStripStatusLabel1.Text = "Selected Control:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 630);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this._statusStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Remote controllable, filterable PropertyGrid Prototype";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this._statusStrip.ResumeLayout(false);
            this._statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private BindablePropertyGrid _filterablePropertyGrid;
        private System.Windows.Forms.TextBox _txtFilter;
        private System.Windows.Forms.Button _btnSortAlphabetically;
        private System.Windows.Forms.Button _btnExpandAll;
        private System.Windows.Forms.Button _btnSortCategory;
        private System.Windows.Forms.Button _btnCollapseAll;
        private System.Windows.Forms.Button _btnRefresh;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.StatusStrip _statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label _lblFilterCaption;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

