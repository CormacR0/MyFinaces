namespace MyFinaces
{
    partial class Finaces
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
            this.lstFinaces = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstFinaces
            // 
            this.lstFinaces.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstFinaces.FormattingEnabled = true;
            this.lstFinaces.Location = new System.Drawing.Point(0, 0);
            this.lstFinaces.Name = "lstFinaces";
            this.lstFinaces.Size = new System.Drawing.Size(800, 450);
            this.lstFinaces.TabIndex = 0;
            this.lstFinaces.SelectedIndexChanged += new System.EventHandler(this.lstFinaces_SelectedIndexChanged);
            // 
            // Finaces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstFinaces);
            this.Name = "Finaces";
            this.Text = "Finaces";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstFinaces;
    }
}