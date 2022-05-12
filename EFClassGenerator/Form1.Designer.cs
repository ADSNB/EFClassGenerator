namespace EFClassGenerator
{
    partial class Form1
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtEntityOutput = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtTypeConfigurationOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.btnCopyClipBoardEntityOutput = new System.Windows.Forms.Button();
            this.btnCopyClipBoardTypeConfigurationOutput = new System.Windows.Forms.Button();
            this.cbCodeGeneratorType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(12, 72);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtInput.Size = new System.Drawing.Size(311, 316);
            this.txtInput.TabIndex = 0;
            // 
            // txtEntityOutput
            // 
            this.txtEntityOutput.Location = new System.Drawing.Point(455, 72);
            this.txtEntityOutput.Multiline = true;
            this.txtEntityOutput.Name = "txtEntityOutput";
            this.txtEntityOutput.ReadOnly = true;
            this.txtEntityOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtEntityOutput.Size = new System.Drawing.Size(311, 316);
            this.txtEntityOutput.TabIndex = 1;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(348, 214);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 44);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Generate Code";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerateCode);
            // 
            // txtTypeConfigurationOutput
            // 
            this.txtTypeConfigurationOutput.Location = new System.Drawing.Point(819, 72);
            this.txtTypeConfigurationOutput.Multiline = true;
            this.txtTypeConfigurationOutput.Name = "txtTypeConfigurationOutput";
            this.txtTypeConfigurationOutput.ReadOnly = true;
            this.txtTypeConfigurationOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtTypeConfigurationOutput.Size = new System.Drawing.Size(311, 316);
            this.txtTypeConfigurationOutput.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(455, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Entity Output";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(819, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Type Configuration Output";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(436, 440);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(352, 15);
            this.lblError.TabIndex = 6;
            this.lblError.Text = "If Something gone wrong this place will handle the error message";
            // 
            // btnCopyClipBoardEntityOutput
            // 
            this.btnCopyClipBoardEntityOutput.Location = new System.Drawing.Point(455, 388);
            this.btnCopyClipBoardEntityOutput.Name = "btnCopyClipBoardEntityOutput";
            this.btnCopyClipBoardEntityOutput.Size = new System.Drawing.Size(311, 23);
            this.btnCopyClipBoardEntityOutput.TabIndex = 7;
            this.btnCopyClipBoardEntityOutput.Text = "Copy to clipboard";
            this.btnCopyClipBoardEntityOutput.UseVisualStyleBackColor = true;
            this.btnCopyClipBoardEntityOutput.Click += new System.EventHandler(this.btnCopyClipBoardEntityOutput_Click);
            // 
            // btnCopyClipBoardTypeConfigurationOutput
            // 
            this.btnCopyClipBoardTypeConfigurationOutput.Location = new System.Drawing.Point(819, 388);
            this.btnCopyClipBoardTypeConfigurationOutput.Name = "btnCopyClipBoardTypeConfigurationOutput";
            this.btnCopyClipBoardTypeConfigurationOutput.Size = new System.Drawing.Size(311, 23);
            this.btnCopyClipBoardTypeConfigurationOutput.TabIndex = 8;
            this.btnCopyClipBoardTypeConfigurationOutput.Text = "Copy to clipboard";
            this.btnCopyClipBoardTypeConfigurationOutput.UseVisualStyleBackColor = true;
            this.btnCopyClipBoardTypeConfigurationOutput.Click += new System.EventHandler(this.btnCopyClipBoardTypeConfigurationOutput_Click);
            // 
            // cbCodeGeneratorType
            // 
            this.cbCodeGeneratorType.FormattingEnabled = true;
            this.cbCodeGeneratorType.Location = new System.Drawing.Point(12, 33);
            this.cbCodeGeneratorType.Name = "cbCodeGeneratorType";
            this.cbCodeGeneratorType.Size = new System.Drawing.Size(311, 23);
            this.cbCodeGeneratorType.TabIndex = 9;
            this.cbCodeGeneratorType.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 534);
            this.Controls.Add(this.cbCodeGeneratorType);
            this.Controls.Add(this.btnCopyClipBoardTypeConfigurationOutput);
            this.Controls.Add(this.btnCopyClipBoardEntityOutput);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTypeConfigurationOutput);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtEntityOutput);
            this.Controls.Add(this.txtInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtInput;
        private TextBox txtEntityOutput;
        private Button btnGenerate;
        private TextBox txtTypeConfigurationOutput;
        private Label label1;
        private Label label2;
        private Label lblError;
        private Button btnCopyClipBoardEntityOutput;
        private Button btnCopyClipBoardTypeConfigurationOutput;
        private ComboBox cbCodeGeneratorType;
    }
}