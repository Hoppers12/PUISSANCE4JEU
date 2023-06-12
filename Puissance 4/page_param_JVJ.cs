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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using BibliothèquePuissance4;


namespace Puissance_4
{
    public partial class frmParamJVJ : Form
    {
        /// <summary>
        /// Attribut qui désigne la grille choisie par le joueur en fonction du radioButton coché
        /// 1 --> Grille 1 / 2 --> Grille 2 / 0 --> Aléatoire entre les 2
        /// </summary>
        private int choixGrilleRadioButton;
        /// <summary>
        /// Attribut qui correspond au pseudo du J1 entré dans la textBox
        /// </summary>
        private string pseudoJ1;
        /// <summary>
        /// Attribut qui correspond au pseudo du J2 entré dans la TextBox
        /// </summary>
        private string pseudoJ2;

        public int ChoixGrilleRadioButton { get => choixGrilleRadioButton; set => choixGrilleRadioButton = value; }
        public string PseudoJ1 { get => pseudoJ1; set => pseudoJ1 = value; }
        public string PseudoJ2 { get => pseudoJ2; set => pseudoJ2 = value; }

        /// <summary>
        /// Constructeur de la page paramètre JVJ il initialise les éléments
        /// </summary>
        public frmParamJVJ()
        {
            int hauteurForm;
            int largeurForm;

            InitializeComponent();

            pseudoJ1 = txtPseudoJ1.Text;
            pseudoJ2 = txtPseudoJ2.Text;

            //définit la taille de l'interface par rapport à la place que ses composants vont prendre 
            hauteurForm = this.ClientSize.Height + 20;
            largeurForm = this.ClientSize.Width + 20;
            this.Size = new Size(largeurForm, hauteurForm);

        }


        /// <summary>
        /// Méthode événement Click sur le bouton Jouer. Elle enregistre dans les attributs
        /// les valeurs qui ont été saisies/choisies par le joueur 
        /// et ouvre la page de partie en lui passant l'objet courant
        /// </summary>
        private void btnJouer_Click(object sender, EventArgs e)
        {
            // On enregistre le numero de la grille choisie en fonction du radiobutton qui a été coché

            if (rdoGrilleClassique.Checked == true)
            {

                choixGrilleRadioButton = 1; // grille 1
            }
            else
            {
                if (rdoGrilleMini.Checked == true)
                {
                    choixGrilleRadioButton = 2; // grille 2
                }
                else
                {
                    if (rdoGrilleAleatoire.Checked == true)
                    {
                        choixGrilleRadioButton = 0; // grille 1 ou 2 (aléatoire)
                    }
                }


            }
            pseudoJ1 = txtPseudoJ1.Text;
            pseudoJ2 = txtPseudoJ2.Text;
            frmPagePartie page_partie_JVJ = new frmPagePartie(this, true); // On passe this en paramétre pour que la partie puisse connaitre ce qui a été coché ici
            page_partie_JVJ.Show();
            this.Close();
        }



        /// <summary>
        /// Méthode qui ouvre la page d'accueil et ferme la page de paramétrage au click sur le bouton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAccueil_Click(object sender, EventArgs e)
        {
            frmAccueil pageAccueil = new frmAccueil();
            pageAccueil.Show(this);
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
            if (txtPseudoJ1.Text == "" || txtPseudoJ2.Text == "")
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

