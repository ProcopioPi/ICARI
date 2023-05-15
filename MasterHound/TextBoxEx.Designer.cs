namespace MasterHound
{
    partial class TextBoxEx
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CMB_BOX = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // CMB_BOX
            // 
            this.CMB_BOX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CMB_BOX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CMB_BOX.FormattingEnabled = true;
            this.CMB_BOX.Location = new System.Drawing.Point(-3, -3);
            this.CMB_BOX.Margin = new System.Windows.Forms.Padding(2);
            this.CMB_BOX.Name = "CMB_BOX";
            this.CMB_BOX.Size = new System.Drawing.Size(273, 21);
            this.CMB_BOX.TabIndex = 28;
            // 
            // TextBoxEx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CMB_BOX);
            this.Name = "TextBoxEx";
            this.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Size = new System.Drawing.Size(300, 21);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CMB_BOX;
    }
}
