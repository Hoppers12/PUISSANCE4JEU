using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Puissance_4;
using BibliothèquePuissance4;

namespace Puissance_4
{
    public partial class Resultat : Form
    {

        string pseudoGagnant;
        Label labelAffichageVainqueur = new Label();

        public Resultat(Joueur Vainqueur)
        {
            if (Vainqueur != null)
            {
                pseudoGagnant = Vainqueur.Pseudo;
                InitializeComponent();
                this.Controls.Add(labelAffichageVainqueur);
                labelAffichageVainqueur.Size = new Size(500, 500);
                labelAffichageVainqueur.Text = pseudoGagnant + " a remporté la partie";
            }
            else
            {
                pseudoGagnant = null;
                InitializeComponent();
                this.Controls.Add(labelAffichageVainqueur);
                labelAffichageVainqueur.Size = new Size(500, 500);
                labelAffichageVainqueur.Text = "Match nul !";
            }
        }

        private void Resultat_Load(object sender, EventArgs e)
        {

        }
    }
}
