using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using BibliothèquePuissance4;

namespace Puissance_4
{
    public partial class page_param_JVIA : Form
    {

        /// <summary>
        /// attribut qui enregistre le choix de grille par l'utilisateur en fonction du radio bouton coché
        /// </summary>
        private int choixGrilleRadioButton;
        /// <summary>
        /// Attribut qui enregistre le pseudo du joueur entré dans la textbox
        /// </summary>
        private string pseudoJ;

        public int ChoixGrilleRadioButton { get => choixGrilleRadioButton; set => choixGrilleRadioButton = value; }
        public string PseudoJ { get => pseudoJ; set => pseudoJ = value; }


        /// <summary>
        /// constructeur de la page, il initialise les éléments
        /// </summary>
        public page_param_JVIA()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Méthode qui entregistre les informations choisies//entrées par l'utilisateur
        /// et qui ouvre la page de jeu JVJIA en fonction de celles-ci
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void boutonJouer_Click(object sender, EventArgs e)
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
            pseudoJ = pseudoJ1.Text;
            Partie_JVIA page_partieJVIA = new Partie_JVIA(this);
            page_partieJVIA.Show();
            this.Hide();
        }


        /// <summary>
        /// Méthode qui permet de retourner à la page d'accueil (ferme la page de paramétrages
        /// et ouvre la page d'accueil)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_accueil_Click(object sender, EventArgs e)
        {
            Accueil retour_accueil = new Accueil();
            retour_accueil.Show();
            this.Hide();
        }


    }
}