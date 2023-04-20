using Puissance_4;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puissance_4
{
    public partial class page_param_JVJ : Form
    {
        public int choixGrilleRadioButton;
        public page_param_JVJ()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // Bouton "JOUER" Joueur VS JOUEUR
        {
            // On enregistre le numero de la grille choisie en fonction du radiobutton qui a été coché
            if (radioButton1.CausesValidation == true)
            {
                choixGrilleRadioButton = 1;
            }
            else
            {
                if (radioButton2.CausesValidation == true)
                {
                    choixGrilleRadioButton = 2;
                } else
                {
                    choixGrilleRadioButton = 0;
                }
            }
            Partie_JVJ page_partie_JVJ = new Partie_JVJ();
            page_partie_JVJ.Show();

        }


        //Retour à l'accueil sur le click du bouton accueil 
        private void button_retour_accueil(object sender, EventArgs e)
        {
            Accueil pageAccueil = new Accueil();
            pageAccueil.Show(this);
            this.Hide();
        }
    }
}
