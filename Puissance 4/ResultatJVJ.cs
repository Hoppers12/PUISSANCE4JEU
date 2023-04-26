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

using static Program;

namespace Puissance_4
{
    public partial class ResultatJVJ : Form
    {
        
        string pseudoGagnant;
        Label labelAffichageVainqueur = new Label();

        public ResultatJVJ(Joueur Vainqueur)
        {
            pseudoGagnant = Vainqueur.pseudo;
            InitializeComponent();
            this.Controls.Add(labelAffichageVainqueur);
            labelAffichageVainqueur.Size = new Size(500, 500);
            labelAffichageVainqueur.Text = pseudoGagnant + " a remporté la partie";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
