
namespace Entreprise.WinForm_01
{
    partial class FormMdi
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.modalNoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modalYesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modalNoToolStripMenuItem,
            this.modalYesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // modalNoToolStripMenuItem
            // 
            this.modalNoToolStripMenuItem.Name = "modalNoToolStripMenuItem";
            this.modalNoToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.modalNoToolStripMenuItem.Text = "NoModal";
            this.modalNoToolStripMenuItem.Click += new System.EventHandler(this.modalNoToolStripMenuItem_Click);
            // 
            // modalYesToolStripMenuItem
            // 
            this.modalYesToolStripMenuItem.Name = "modalYesToolStripMenuItem";
            this.modalYesToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.modalYesToolStripMenuItem.Text = "YesModal";
            this.modalYesToolStripMenuItem.Click += new System.EventHandler(this.modalYesToolStripMenuItem_Click);
            // 
            // FormMdi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMdi";
            this.Text = "FormMdi";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem modalNoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modalYesToolStripMenuItem;
    }
}