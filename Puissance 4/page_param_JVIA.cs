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
            this.Size = new Size(1000, 800);
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


        /// <summary>
        /// Méthode qui est appelée lorsque une lettre est entrée dans un TextBox
        /// Elle affiche une alerte si un espace est entrée + le supprime
        /// </summary>
        /// <param name="sender"> Text box</param>
        /// <param name="e">Appui sur une touche</param>
        private void textBoxPseudo_KeyPress(object sender, KeyPressEventArgs e)
        {
            System.Windows.Forms.TextBox textBoxActive = (System.Windows.Forms.TextBox)sender;
            if (e.KeyChar == ' ')
            {
                MessageBox.Show("L'espace n'est pas autorisé !");
                e.Handled = true; // Annule la saisie de l'espace
                textBoxActive.Text = textBoxActive.Text.TrimEnd(); // Supprime le dernier caractère (espace) de la TextBox
            }
        }

        /// <summary>
        /// Si un des 2 textBox de pseudo est vide alors le bouton n'est pas cliquable
        /// </summary>
        /// <param name="sender">textbox</param>
        /// <param name="e">changement de la valeur text</param>
        private void textBoxPseudo_TextChanged(object sender, EventArgs e)
        {
            // Si la zone de texte est vide alors on désactive les boutons
            if (pseudoJ1.Text == "")
            {
                boutonJouer.Enabled = false;
            }
            else
            {
                boutonJouer.Enabled = true;
            }
        }


    }

}
