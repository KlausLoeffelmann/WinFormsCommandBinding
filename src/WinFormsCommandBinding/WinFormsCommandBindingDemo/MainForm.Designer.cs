
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
            this.fileToolStripMenuItem = new WinFormsCommandBinding.Models.BindableToolStripMenuItem();
            this.newToolStripMenuItem = new WinFormsCommandBinding.Models.BindableToolStripMenuItem();
            this._mainFormControllerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new WinFormsCommandBinding.Models.BindableToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.convertToUpperToolStripMenuItem = new WinFormsCommandBinding.Models.BindableToolStripMenuItem();
            this.toolsToolStripMenuItem = new WinFormsCommandBinding.Models.BindableToolStripMenuItem();
            this.optionsToolStripMenuItem = new WinFormsCommandBinding.Models.BindableToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this._statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this._bindableCommandComponent = new WinFormsCommandBinding.BindableCommandComponent(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this._mainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._mainFormControllerBindingSource)).BeginInit();
            this._statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // _mainMenuStrip
            // 
            this._mainMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this._mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolStripMenuItem3,
            this.toolsToolStripMenuItem});
            this._mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this._mainMenuStrip.Name = "_mainMenuStrip";
            this._mainMenuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this._mainMenuStrip.Size = new System.Drawing.Size(992, 33);
            this._mainMenuStrip.TabIndex = 0;
            this._mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.toolStripMenuItem1,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DataBindings.Add(new System.Windows.Forms.Binding("Command", this._mainFormControllerBindingSource, "NewCommand", true));
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.newToolStripMenuItem.Text = "New...";
            // 
            // _mainFormControllerBindingSource
            // 
            this._mainFormControllerBindingSource.DataSource = typeof(WinFormsCommandBinding.Models.MainFormController);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(267, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.quitToolStripMenuItem.Text = "&Quit";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.convertToUpperToolStripMenuItem});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(58, 29);
            this.toolStripMenuItem3.Text = "&Edit";
            // 
            // convertToUpperToolStripMenuItem
            // 
            this.convertToUpperToolStripMenuItem.Name = "convertToUpperToolStripMenuItem";
            this.convertToUpperToolStripMenuItem.Size = new System.Drawing.Size(250, 34);
            this.convertToUpperToolStripMenuItem.Text = "Convert to upper";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.toolStripMenuItem2});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DataBindings.Add(new System.Windows.Forms.Binding("Command", this._mainFormControllerBindingSource, "ToolsOptionsCommand", true));
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(190, 34);
            this.optionsToolStripMenuItem.Text = "&Options...";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(187, 6);
            // 
            // _statusStrip
            // 
            this._statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this._statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this._statusStrip.Location = new System.Drawing.Point(0, 717);
            this._statusStrip.Name = "_statusStrip";
            this._statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 18, 0);
            this._statusStrip.Size = new System.Drawing.Size(992, 32);
            this._statusStrip.TabIndex = 1;
            this._statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(179, 25);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // _bindableCommandComponent
            // 
            this._bindableCommandComponent.DataBindings.Add(new System.Windows.Forms.Binding("Command", this._mainFormControllerBindingSource, "ToUpperCommand", true));
            this._bindableCommandComponent.EventSourceComponent = null;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._mainFormControllerBindingSource, "TextDocument", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox1.Location = new System.Drawing.Point(15, 39);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(962, 655);
            this.textBox1.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 749);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this._statusStrip);
            this.Controls.Add(this._mainMenuStrip);
            this.MainMenuStrip = this._mainMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this._mainMenuStrip.ResumeLayout(false);
            this._mainMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._mainFormControllerBindingSource)).EndInit();
            this._statusStrip.ResumeLayout(false);
            this._statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip _mainMenuStrip;
        private BindableToolStripMenuItem fileToolStripMenuItem;
        private BindableToolStripMenuItem newToolStripMenuItem;
        private BindableToolStripMenuItem quitToolStripMenuItem;
        private BindableToolStripMenuItem toolsToolStripMenuItem;
        private BindableToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.StatusStrip _statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private WinFormsCommandBinding.BindableCommandComponent _bindableCommandComponent;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource _mainFormControllerBindingSource;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private BindableToolStripMenuItem convertToUpperToolStripMenuItem;
    }
}

