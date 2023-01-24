
namespace WinFormsCommandBindingDemo
{
    partial class OptionsForm
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
            components = new System.ComponentModel.Container();
            _okButton = new System.Windows.Forms.Button();
            commandButton1 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            checkBox1 = new System.Windows.Forms.CheckBox();
            _optionsFormControllerBindingSource = new System.Windows.Forms.BindingSource(components);
            textBox1 = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            label3 = new System.Windows.Forms.Label();
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)_optionsFormControllerBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // _okButton
            // 
            _okButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            _okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            _okButton.Location = new System.Drawing.Point(250, 221);
            _okButton.Name = "_okButton";
            _okButton.Size = new System.Drawing.Size(114, 28);
            _okButton.TabIndex = 7;
            _okButton.Text = "OK";
            _okButton.UseVisualStyleBackColor = true;
            // 
            // commandButton1
            // 
            commandButton1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            commandButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            commandButton1.Location = new System.Drawing.Point(369, 221);
            commandButton1.Name = "commandButton1";
            commandButton1.Size = new System.Drawing.Size(114, 28);
            commandButton1.TabIndex = 8;
            commandButton1.Text = "Cancel";
            commandButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(26, 15);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(89, 20);
            label1.TabIndex = 0;
            label1.Text = "Text Option:";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", _optionsFormControllerBindingSource, "BoolOption", true));
            checkBox1.Location = new System.Drawing.Point(181, 60);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new System.Drawing.Size(145, 24);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "CheckBox Option";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // _optionsFormControllerBindingSource
            // 
            _optionsFormControllerBindingSource.DataSource = typeof(MauiEdit.ViewModels.OptionsFormController);
            // 
            // textBox1
            // 
            textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", _optionsFormControllerBindingSource, "TextOption", true));
            textBox1.Location = new System.Drawing.Point(181, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(301, 27);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(26, 108);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(118, 20);
            label2.TabIndex = 3;
            label2.Text = "Numeric Option:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            numericUpDown1.DataBindings.Add(new System.Windows.Forms.Binding("Value", _optionsFormControllerBindingSource, "NumericOption", true));
            numericUpDown1.Location = new System.Drawing.Point(181, 106);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new System.Drawing.Size(301, 27);
            numericUpDown1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(26, 158);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(94, 20);
            label3.TabIndex = 5;
            label3.Text = "Date Option:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", _optionsFormControllerBindingSource, "DateOption", true));
            dateTimePicker1.Location = new System.Drawing.Point(181, 153);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(301, 27);
            dateTimePicker1.TabIndex = 6;
            // 
            // OptionsForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(494, 260);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(numericUpDown1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(checkBox1);
            Controls.Add(label1);
            Controls.Add(commandButton1);
            Controls.Add(_okButton);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Name = "OptionsForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "OptionsForm";
            ((System.ComponentModel.ISupportInitialize)_optionsFormControllerBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button _okButton;
        private System.Windows.Forms.Button commandButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.BindingSource _optionsFormControllerBindingSource;
    }
}
