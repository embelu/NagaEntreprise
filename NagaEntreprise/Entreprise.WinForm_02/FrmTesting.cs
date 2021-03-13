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
    public partial class FrmTesting : Form
    {
        Societe _societe = Societe.CreerSociete();

        public FrmTesting()
        {
            InitializeComponent();
        }

        private void BtnTest_Click(object sender, EventArgs e)
        {
            MessageBox.Show("*** Ajout de 5 éléments dans la list Travailleur ***");
            _societe.AddTravailleur(1, "Baens", "Ludovic", 30, 500);
            _societe.AddTravailleur(2, "Masset", "Frédéric", 25, 1200);
            _societe.AddTravailleur(3, "Nadin", "Pascal", 35, 1300);
            _societe.AddTravailleur(4, "Fontana", "Pierre", 40, 1500);
            _societe.AddTravailleur(5, "Vanbelle", "Laurent", 15, 700);


            MessageBox.Show("Contenu de la liste :");
            foreach (var item in _societe.travailleurs)
            {
                MessageBox.Show(item.Id + " " + item.Nom + " " + item.Prenom + " " + item.Age + " " + item.Salaire());
            }
        }
    }
}
