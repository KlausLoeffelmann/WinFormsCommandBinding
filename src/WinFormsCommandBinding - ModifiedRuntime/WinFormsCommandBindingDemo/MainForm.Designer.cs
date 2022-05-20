
using WinFormsCommandBinding.Models;

namespace WinFormsCommandBindingDemo
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this._mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this._fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this._quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this._convertToUpperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this._statusStrip = new System.Windows.Forms.StatusStrip();
            this._wordCountStatusStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this._rowNumberStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this._mainFormControllerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._columnNumberStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this._editorSurface = new WinFormsCommandBindingDemo.EditorControl();
            this._mainMenuStrip.SuspendLayout();
            this._statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._mainFormControllerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // _mainMenuStrip
            // 
            this._mainMenuStrip.DataContext = null;
            this._mainMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this._mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._fileToolStripMenuItem,
            this.toolStripMenuItem3,
            this.toolsToolStripMenuItem});
            this._mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this._mainMenuStrip.Name = "_mainMenuStrip";
            this._mainMenuStrip.Size = new System.Drawing.Size(794, 28);
            this._mainMenuStrip.TabIndex = 0;
            this._mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this._fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._newToolStripMenuItem,
            this.toolStripMenuItem1,
            this._quitToolStripMenuItem});
            this._fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this._fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this._fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this._newToolStripMenuItem.Name = "newToolStripMenuItem";
            this._newToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this._newToolStripMenuItem.Text = "New...";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(128, 6);
            // 
            // quitToolStripMenuItem
            // 
            this._quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this._quitToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this._quitToolStripMenuItem.Text = "&Quit";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._convertToUpperToolStripMenuItem});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(49, 24);
            this.toolStripMenuItem3.Text = "&Edit";
            // 
            // convertToUpperToolStripMenuItem
            // 
            this._convertToUpperToolStripMenuItem.Name = "convertToUpperToolStripMenuItem";
            this._convertToUpperToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this._convertToUpperToolStripMenuItem.Text = "Convert to upper";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._optionsToolStripMenuItem,
            this.toolStripMenuItem2});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // optionsToolStripMenuItem
            // 
            this._optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this._optionsToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this._optionsToolStripMenuItem.Text = "&Options...";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(150, 6);
            // 
            // _statusStrip
            // 
            this._statusStrip.DataContext = null;
            this._statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this._statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._wordCountStatusStripLabel,
            this._rowNumberStatusLabel,
            this._columnNumberStatusLabel});
            this._statusStrip.Location = new System.Drawing.Point(0, 573);
            this._statusStrip.Name = "_statusStrip";
            this._statusStrip.Size = new System.Drawing.Size(794, 26);
            this._statusStrip.TabIndex = 1;
            this._statusStrip.Text = "statusStrip1";
            // 
            // _wordCountStatusStripLabel
            // 
            this._wordCountStatusStripLabel.Name = "_wordCountStatusStripLabel";
            this._wordCountStatusStripLabel.Size = new System.Drawing.Size(575, 20);
            this._wordCountStatusStripLabel.Spring = true;
            this._wordCountStatusStripLabel.Text = "Words: ###";
            // 
            // _rowNumberStatusLabel
            // 
            this._rowNumberStatusLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._mainFormControllerBindingSource, "SelectionRow", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "Line:\\ 000"));
            this._rowNumberStatusLabel.Name = "_rowNumberStatusLabel";
            this._rowNumberStatusLabel.Size = new System.Drawing.Size(79, 20);
            this._rowNumberStatusLabel.Text = "Line: ####";
            // 
            // _mainFormControllerBindingSource
            // 
            this._mainFormControllerBindingSource.DataSource = typeof(WinFormsCommandBinding.Models.MainFormController);
            // 
            // _columnNumberStatusLabel
            // 
            this._columnNumberStatusLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._mainFormControllerBindingSource, "SelectionColumn", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "Col:\\ 00000"));
            this._columnNumberStatusLabel.Name = "_columnNumberStatusLabel";
            this._columnNumberStatusLabel.Size = new System.Drawing.Size(94, 20);
            this._columnNumberStatusLabel.Text = "Column: ###";
            // 
            // _editorSurface
            // 
            this._editorSurface.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._editorSurface.DataBindings.Add(new System.Windows.Forms.Binding("SelectionColumn", this._mainFormControllerBindingSource, "SelectionColumn", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this._editorSurface.DataBindings.Add(new System.Windows.Forms.Binding("SelectionRow", this._mainFormControllerBindingSource, "SelectionRow", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this._editorSurface.DataContext = null;
            this._editorSurface.Location = new System.Drawing.Point(12, 31);
            this._editorSurface.Multiline = true;
            this._editorSurface.Name = "_editorSurface";
            this._editorSurface.SelectionColumn = 0;
            this._editorSurface.SelectionRow = 0;
            this._editorSurface.Size = new System.Drawing.Size(770, 525);
            this._editorSurface.TabIndex = 2;
            this._editorSurface.DataContextChanged += new System.EventHandler(this.MainForm_DataContextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 599);
            this.Controls.Add(this._editorSurface);
            this.Controls.Add(this._statusStrip);
            this.Controls.Add(this._mainMenuStrip);
            this.MainMenuStrip = this._mainMenuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.DataContextChanged += new System.EventHandler(this.MainForm_DataContextChanged);
            this._mainMenuStrip.ResumeLayout(false);
            this._mainMenuStrip.PerformLayout();
            this._statusStrip.ResumeLayout(false);
            this._statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._mainFormControllerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip _mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem _fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _optionsToolStripMenuItem;
        private System.Windows.Forms.StatusStrip _statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel _wordCountStatusStripLabel;
        private EditorControl _editorSurface;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem _convertToUpperToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel _rowNumberStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel _columnNumberStatusLabel;
        private System.Windows.Forms.BindingSource _mainFormControllerBindingSource;
    }
}

