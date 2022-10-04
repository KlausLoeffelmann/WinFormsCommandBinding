
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
            this._insertDemoTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this._columnNumberStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this._editorSurface = new WinFormsCommandBindingDemo.EditorControl();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this._rewrapButton = new System.Windows.Forms.Button();
            this._charWrapThreshold = new System.Windows.Forms.Label();
            this._mainMenuStrip.SuspendLayout();
            this._statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // _mainMenuStrip
            // 
            this._mainMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this._mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._fileToolStripMenuItem,
            this.toolStripMenuItem3,
            this.toolsToolStripMenuItem});
            this._mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this._mainMenuStrip.Name = "_mainMenuStrip";
            this._mainMenuStrip.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this._mainMenuStrip.Size = new System.Drawing.Size(1120, 42);
            this._mainMenuStrip.TabIndex = 0;
            this._mainMenuStrip.Text = "menuStrip1";
            // 
            // _fileToolStripMenuItem
            // 
            this._fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._newToolStripMenuItem,
            this._insertDemoTextToolStripMenuItem,
            this.toolStripMenuItem1,
            this._quitToolStripMenuItem});
            this._fileToolStripMenuItem.Name = "_fileToolStripMenuItem";
            this._fileToolStripMenuItem.Size = new System.Drawing.Size(71, 36);
            this._fileToolStripMenuItem.Text = "&File";
            // 
            // _newToolStripMenuItem
            // 
            this._newToolStripMenuItem.Name = "_newToolStripMenuItem";
            this._newToolStripMenuItem.Size = new System.Drawing.Size(322, 44);
            this._newToolStripMenuItem.Text = "New...";
            // 
            // _insertDemoTextToolStripMenuItem
            // 
            this._insertDemoTextToolStripMenuItem.Name = "_insertDemoTextToolStripMenuItem";
            this._insertDemoTextToolStripMenuItem.Size = new System.Drawing.Size(322, 44);
            this._insertDemoTextToolStripMenuItem.Text = "&Insert demo text";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(319, 6);
            // 
            // _quitToolStripMenuItem
            // 
            this._quitToolStripMenuItem.Name = "_quitToolStripMenuItem";
            this._quitToolStripMenuItem.Size = new System.Drawing.Size(322, 44);
            this._quitToolStripMenuItem.Text = "&Quit";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._convertToUpperToolStripMenuItem});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(74, 36);
            this.toolStripMenuItem3.Text = "&Edit";
            // 
            // _convertToUpperToolStripMenuItem
            // 
            this._convertToUpperToolStripMenuItem.Name = "_convertToUpperToolStripMenuItem";
            this._convertToUpperToolStripMenuItem.Size = new System.Drawing.Size(330, 44);
            this._convertToUpperToolStripMenuItem.Text = "Convert to upper";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._optionsToolStripMenuItem,
            this.toolStripMenuItem2});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(89, 36);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // _optionsToolStripMenuItem
            // 
            this._optionsToolStripMenuItem.Name = "_optionsToolStripMenuItem";
            this._optionsToolStripMenuItem.Size = new System.Drawing.Size(246, 44);
            this._optionsToolStripMenuItem.Text = "&Options...";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(243, 6);
            // 
            // _statusStrip
            // 
            this._statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this._statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._wordCountStatusStripLabel,
            this._rowNumberStatusLabel,
            this._columnNumberStatusLabel});
            this._statusStrip.Location = new System.Drawing.Point(0, 812);
            this._statusStrip.Name = "_statusStrip";
            this._statusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 23, 0);
            this._statusStrip.Size = new System.Drawing.Size(1120, 42);
            this._statusStrip.TabIndex = 1;
            this._statusStrip.Text = "statusStrip1";
            // 
            // _wordCountStatusStripLabel
            // 
            this._wordCountStatusStripLabel.Name = "_wordCountStatusStripLabel";
            this._wordCountStatusStripLabel.Size = new System.Drawing.Size(817, 32);
            this._wordCountStatusStripLabel.Spring = true;
            // 
            // _rowNumberStatusLabel
            // 
            this._rowNumberStatusLabel.Name = "_rowNumberStatusLabel";
            this._rowNumberStatusLabel.Size = new System.Drawing.Size(126, 32);
            this._rowNumberStatusLabel.Text = "Line: ####";
            // 
            // _columnNumberStatusLabel
            // 
            this._columnNumberStatusLabel.Name = "_columnNumberStatusLabel";
            this._columnNumberStatusLabel.Size = new System.Drawing.Size(152, 32);
            this._columnNumberStatusLabel.Text = "Column: ###";
            // 
            // _editorSurface
            // 
            this._editorSurface.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._editorSurface.Location = new System.Drawing.Point(24, 131);
            this._editorSurface.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this._editorSurface.Multiline = true;
            this._editorSurface.Name = "_editorSurface";
            this._editorSurface.Size = new System.Drawing.Size(1072, 657);
            this._editorSurface.TabIndex = 2;
            this._editorSurface.DataContextChanged += new System.EventHandler(this.MainForm_DataContextChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar1.AutoSize = false;
            this.trackBar1.Location = new System.Drawing.Point(20, 46);
            this.trackBar1.Maximum = 80;
            this.trackBar1.Minimum = 20;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(845, 50);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.Value = 60;
            // 
            // _rewrapButton
            // 
            this._rewrapButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._rewrapButton.Location = new System.Drawing.Point(957, 46);
            this._rewrapButton.Name = "_rewrapButton";
            this._rewrapButton.Size = new System.Drawing.Size(141, 50);
            this._rewrapButton.TabIndex = 4;
            this._rewrapButton.Text = "&Rewrap";
            this._rewrapButton.UseVisualStyleBackColor = true;
            this._rewrapButton.MouseEnter += new System.EventHandler(this.RewrapButton_MouseEnter);
            // 
            // _charWrapThreshold
            // 
            this._charWrapThreshold.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._charWrapThreshold.AutoSize = true;
            this._charWrapThreshold.Location = new System.Drawing.Point(879, 54);
            this._charWrapThreshold.Name = "_charWrapThreshold";
            this._charWrapThreshold.Size = new System.Drawing.Size(56, 32);
            this._charWrapThreshold.TabIndex = 5;
            this._charWrapThreshold.Text = "###";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 854);
            this.Controls.Add(this._charWrapThreshold);
            this.Controls.Add(this._rewrapButton);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this._editorSurface);
            this.Controls.Add(this._statusStrip);
            this.Controls.Add(this._mainMenuStrip);
            this.MainMenuStrip = this._mainMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.DataContextChanged += new System.EventHandler(this.MainForm_DataContextChanged);
            this._mainMenuStrip.ResumeLayout(false);
            this._mainMenuStrip.PerformLayout();
            this._statusStrip.ResumeLayout(false);
            this._statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
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
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button _rewrapButton;
        private System.Windows.Forms.Label _charWrapThreshold;
        private System.Windows.Forms.ToolStripMenuItem _insertDemoTextToolStripMenuItem;
    }
}

