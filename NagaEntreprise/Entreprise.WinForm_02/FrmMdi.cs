﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entreprise.WinForm_02
{
    public partial class FrmMdi : Form
    {
        public FrmMdi()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void entrepriseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Societe societe = Societe.CreerSociete();
        }

        private void employeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEmploye frmEmploye = new FrmEmploye();
            frmEmploye.WindowState = FormWindowState.Maximized;
            frmEmploye.MdiParent = this;
            frmEmploye.Show();
        }

        private void ouvrierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOuvrier frmOuvrier = new FrmOuvrier();
            frmOuvrier.WindowState = FormWindowState.Maximized;
            frmOuvrier.MdiParent = this;
            frmOuvrier.Show();
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmList frmList = new FrmList();
            frmList.WindowState = FormWindowState.Maximized;
            frmList.MdiParent = this;
            frmList.Show();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTesting frmList = new FrmTesting();
            frmList.WindowState = FormWindowState.Maximized;
            frmList.MdiParent = this;
            frmList.Show();
        }
    }
}
