namespace WindowsFormsAppCommonProperties
{
    partial class mainForm
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
            this.targetButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.formSizeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // targetButton
            // 
            this.targetButton.Location = new System.Drawing.Point(0, 0);
            this.targetButton.Name = "targetButton";
            this.targetButton.Size = new System.Drawing.Size(100, 100);
            this.targetButton.TabIndex = 0;
            this.targetButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Location = new System.Drawing.Point(570, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 500);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controls";
            // 
            // formSizeLabel
            // 
            this.formSizeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.formSizeLabel.AutoSize = true;
            this.formSizeLabel.Location = new System.Drawing.Point(20, 530);
            this.formSizeLabel.Name = "formSizeLabel";
            this.formSizeLabel.Size = new System.Drawing.Size(148, 20);
            this.formSizeLabel.TabIndex = 2;
            this.formSizeLabel.Text = "Form size: 800, 600";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 544);
            this.Controls.Add(this.formSizeLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.targetButton);
            this.Name = "mainForm";
            this.Text = "(0,0)  Winforms Components - Common Controls";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button targetButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label formSizeLabel;
    }
}

