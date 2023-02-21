
namespace Day5
{
    partial class Form4
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
            this.SuspendLayout();
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form4_Paint_1);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form4_MouseClick);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Form4_MouseDoubleClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form4_MouseMove_1);
            this.ResumeLayout(false);

        }

        #endregion
    }
}