using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Entreprise.ASP
{
    public partial class WebFormEntreprise : System.Web.UI.Page
    {
        Societe societe = Societe.CreerSociete();

        protected void Page_Load(object sender, EventArgs e)
        {  
            if (!Page.IsPostBack)
            {
                TBoxMatricule.Text = "Matricule";
            }
        }



        protected void TBoxMatricule_TextChanged(object sender, EventArgs e)
        {
            societe.Matricule = Int32.Parse(TBoxMatricule.Text);
        }

        protected void BtnEnvoyer_Click(object sender, EventArgs e)
        {
            LblMatricule.Text = TBoxMatricule.Text;
        }

         
    }
}