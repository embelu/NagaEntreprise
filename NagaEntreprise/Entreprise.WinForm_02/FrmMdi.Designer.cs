
namespace Entreprise.WinForm_02
{
    partial class FrmMdi
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
            this.creationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entrepriseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creationToolStripMenuItem,
            this.listToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // creationToolStripMenuItem
            // 
            this.creationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entrepriseToolStripMenuItem,
            this.employeToolStripMenuItem,
            this.ouvrierToolStripMenuItem});
            this.creationToolStripMenuItem.Name = "creationToolStripMenuItem";
            this.creationToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.creationToolStripMenuItem.Text = "Création";
            // 
            // entrepriseToolStripMenuItem
            // 
            this.entrepriseToolStripMenuItem.Name = "entrepriseToolStripMenuItem";
            this.entrepriseToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.entrepriseToolStripMenuItem.Text = "Entreprise";
            this.entrepriseToolStripMenuItem.Click += new System.EventHandler(this.entrepriseToolStripMenuItem_Click);
            // 
            // employeToolStripMenuItem
            // 
            this.employeToolStripMenuItem.Name = "employeToolStripMenuItem";
            this.employeToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.employeToolStripMenuItem.Text = "Employé";
            this.employeToolStripMenuItem.Click += new System.EventHandler(this.employeToolStripMenuItem_Click);
            // 
            // ouvrierToolStripMenuItem
            // 
            this.ouvrierToolStripMenuItem.Name = "ouvrierToolStripMenuItem";
            this.ouvrierToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.ouvrierToolStripMenuItem.Text = "Ouvrier";
            this.ouvrierToolStripMenuItem.Click += new System.EventHandler(this.ouvrierToolStripMenuItem_Click);
            // 
            // listToolStripMenuItem
            // 
            this.listToolStripMenuItem.Name = "listToolStripMenuItem";
            this.listToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.listToolStripMenuItem.Text = "Liste";
            this.listToolStripMenuItem.Click += new System.EventHandler(this.listToolStripMenuItem_Click);
            // 
            // FrmMdi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMdi";
            this.Text = "FrmMdi";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem creationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entrepriseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ouvrierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listToolStripMenuItem;
    }
}