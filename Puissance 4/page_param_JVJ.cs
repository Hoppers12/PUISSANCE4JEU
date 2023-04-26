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
        public string pseudoJ1;
        public string pseudoJ2;


        public page_param_JVJ()
        {
            InitializeComponent();
            pseudoJ1 = textBox1.Text;
            pseudoJ2 = textBox2.Text;    // Gestion des pseudos dans un attribut pour les récupérer + tard


        }

        private void button1_Click(object sender, EventArgs e) // Bouton "JOUER" Joueur VS JOUEUR
        {
            // On enregistre le numero de la grille choisie en fonction du radiobutton qui a été coché
            if (radioButton1.Checked == true)
            {

                choixGrilleRadioButton = 1;
            }
            else
            {
                if (radioButton2.Checked == true)
                {
                    choixGrilleRadioButton = 2;
                }
                else
                {
                    if (radioButton3.Checked == true)
                    {
                        choixGrilleRadioButton = 0;
                    }

                }


            }

            Partie_JVJ page_partie_JVJ = new Partie_JVJ(this); // On passe this en paramétre pour que la partie puisse connaitre ce qui a été coché ici
            page_partie_JVJ.Show();


        }


        //Retour à l'accueil sur le click du bouton accueil 
        private void button_retour_accueil(object sender, EventArgs e)
        {
            Accueil pageAccueil = new Accueil();
            pageAccueil.Show(this);
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
