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
    public partial class frmParamJVIA : Form
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
        public frmParamJVIA()
        {
            InitializeComponent();
            pseudoJ = lblPseudoJ1.Text;
            int hauteurForm;
            int largeurForm;

            //définit la taille de l'interface par rapport à la place que ses composants vont prendre 
            hauteurForm = this.ClientSize.Height + 20;
            largeurForm = this.ClientSize.Width + 20;
            this.Size = new Size(largeurForm, hauteurForm);
        }

        /// <summary>
        /// Méthode qui entregistre les informations choisies//entrées par l'utilisateur
        /// et qui ouvre la page de jeu JVJIA en fonction de celles-ci
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnJouer_Click(object sender, EventArgs e)
        {
            // On enregistre le numero de la grille choisie en fonction du radiobutton qui a été coché
            if (rdoGrilleClassique.Checked == true)
            {

                choixGrilleRadioButton = 1;
            }
            else
            {
                if (rdoGrilleMini.Checked == true)
                {
                    choixGrilleRadioButton = 2;
                }
                else
                {
                    if (rdoGrilleAleatoire.Checked == true)
                    {
                        choixGrilleRadioButton = 0;
                    }

                }


            }
            pseudoJ = lblPseudoJ1.Text;
            frmPagePartie page_partieJVIA = new frmPagePartie(this, false);
            page_partieJVIA.Show();
            this.Close();
        }


        /// <summary>
        /// Méthode qui permet de retourner à la page d'accueil (ferme la page de paramétrages
        /// et ouvre la page d'accueil)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAccueil_Click(object sender, EventArgs e)
        {
            frmAccueil retour_accueil = new frmAccueil();
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
            if (lblPseudoJ1.Text == "")
            {
                btnJouer.Enabled = false;
            }
            else
            {
                btnJouer.Enabled = true;
            }
        }

    }

}
