using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entreprise.WinForm_01
{
    public partial class FormMdi : Form
    {
        public FormMdi()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void modalNoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNoModal formNoModal = new FormNoModal();
            formNoModal.MdiParent = this;
            formNoModal.WindowState = FormWindowState.Maximized;
            formNoModal.Show();
        }

        private void modalYesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormYesModal formYesModal = new FormYesModal(); 
            formYesModal.ShowDialog();
        }
    }
}
