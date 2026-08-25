namespace ReadOnlyPropertyGridTest
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
            this.rPropertyGrid1 = new Rajeev.Windows.Forms.RPropertyGrid();
            this.checkBoxReadOnly = new System.Windows.Forms.CheckBox();
            this.checkBoxChangeObject = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // rPropertyGrid1
            // 
            this.rPropertyGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rPropertyGrid1.Location = new System.Drawing.Point(12, 12);
            this.rPropertyGrid1.Name = "rPropertyGrid1";
            this.rPropertyGrid1.ReadOnly = false;
            this.rPropertyGrid1.Size = new System.Drawing.Size(590, 511);
            this.rPropertyGrid1.TabIndex = 0;
            // 
            // checkBoxReadOnly
            // 
            this.checkBoxReadOnly.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxReadOnly.AutoSize = true;
            this.checkBoxReadOnly.Location = new System.Drawing.Point(12, 557);
            this.checkBoxReadOnly.Name = "checkBoxReadOnly";
            this.checkBoxReadOnly.Size = new System.Drawing.Size(76, 17);
            this.checkBoxReadOnly.TabIndex = 1;
            this.checkBoxReadOnly.Text = "Read Only";
            this.checkBoxReadOnly.UseVisualStyleBackColor = true;
            this.checkBoxReadOnly.CheckedChanged += new System.EventHandler(this.CheckBoxReadOnly_CheckedChanged);
            // 
            // checkBoxChangeObject
            // 
            this.checkBoxChangeObject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxChangeObject.AutoSize = true;
            this.checkBoxChangeObject.Location = new System.Drawing.Point(145, 557);
            this.checkBoxChangeObject.Name = "checkBoxChangeObject";
            this.checkBoxChangeObject.Size = new System.Drawing.Size(95, 17);
            this.checkBoxChangeObject.TabIndex = 2;
            this.checkBoxChangeObject.Text = "Change object";
            this.checkBoxChangeObject.UseVisualStyleBackColor = true;
            this.checkBoxChangeObject.CheckedChanged += new System.EventHandler(this.CheckBoxChangeObject_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 586);
            this.Controls.Add(this.checkBoxChangeObject);
            this.Controls.Add(this.checkBoxReadOnly);
            this.Controls.Add(this.rPropertyGrid1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Rajeev.Windows.Forms.RPropertyGrid rPropertyGrid1;
        private System.Windows.Forms.CheckBox checkBoxReadOnly;
        private System.Windows.Forms.CheckBox checkBoxChangeObject;
    }
}

