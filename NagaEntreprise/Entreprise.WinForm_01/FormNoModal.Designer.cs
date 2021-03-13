
namespace Entreprise.WinForm_01
{
    partial class FormNoModal
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblMatricule = new System.Windows.Forms.Label();
            this.TboxMatricule = new System.Windows.Forms.TextBox();
            this.BtnEnvoyer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblMatricule
            // 
            this.LblMatricule.AutoSize = true;
            this.LblMatricule.Location = new System.Drawing.Point(21, 139);
            this.LblMatricule.Name = "LblMatricule";
            this.LblMatricule.Size = new System.Drawing.Size(46, 17);
            this.LblMatricule.TabIndex = 0;
            this.LblMatricule.Text = "label1";
            // 
            // TboxMatricule
            // 
            this.TboxMatricule.Location = new System.Drawing.Point(24, 31);
            this.TboxMatricule.Name = "TboxMatricule";
            this.TboxMatricule.Size = new System.Drawing.Size(231, 22);
            this.TboxMatricule.TabIndex = 1;
            this.TboxMatricule.TextChanged += new System.EventHandler(this.TboxMatricule_TextChanged);
            // 
            // BtnEnvoyer
            // 
            this.BtnEnvoyer.Location = new System.Drawing.Point(24, 74);
            this.BtnEnvoyer.Name = "BtnEnvoyer";
            this.BtnEnvoyer.Size = new System.Drawing.Size(231, 38);
            this.BtnEnvoyer.TabIndex = 2;
            this.BtnEnvoyer.Text = "ENVOYER";
            this.BtnEnvoyer.UseVisualStyleBackColor = true;
            this.BtnEnvoyer.Click += new System.EventHandler(this.BtnEnvoyer_Click);
            // 
            // FormNoModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnEnvoyer);
            this.Controls.Add(this.TboxMatricule);
            this.Controls.Add(this.LblMatricule);
            this.Name = "FormNoModal";
            this.Text = "FormNoModal";
            this.Load += new System.EventHandler(this.FormNoModal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblMatricule;
        private System.Windows.Forms.TextBox TboxMatricule;
        private System.Windows.Forms.Button BtnEnvoyer;
    }
}

