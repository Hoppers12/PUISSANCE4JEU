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
        PagePartie partie;

        /// <summary>
        /// Constructeur de la page de resultat
        /// il permet d'initialiser les composants et d'afficher le pseudo des gagnants
        /// si il y en a
        /// </summary>
        /// <param name="vainqueur">joueur vainqueur ou null si égalité/param>
        /// <param name="partieFinie">partie qui vient de se terminer</param>
        public Resultat(Joueur vainqueur, PagePartie partieFinie)
        {
            partie = partieFinie;

            if (vainqueur != null)
            {
                pseudoGagnant = vainqueur.Pseudo;
                InitializeComponent();
                labelPseudoVainqueur.Text = pseudoGagnant + " a remporté la partie";
            }
            else
            {
                pseudoGagnant = null;
                InitializeComponent();
                labelPseudoVainqueur.Text = "Match nul !";
            }
        }

        /// <summary>
        /// Methode d'événement clique sur le bouton retour accueil
        /// il ferme la page résultat et partie et retourne à l'accueil
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void boutonRetourAccueil_Click(object sender, EventArgs e)
        {
            Accueil pageAccueil = new Accueil();
            pageAccueil.Show();
            partie.Close();
            this.Close();
        }


        /// <summary>
        /// methode evenementielle appelé au click sur le bouton rejouer
        /// elle permet de réinitialiser la grille tout en permettant
        /// de rejouer une partie avec les meme paramétres
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void boutonRejouer_Click(object sender, EventArgs e)
        {
            partie.Partie.InitGrille();
            partie.MajGrille();
            partie.Partie.Gagnant = -1;
            partie.Enabled = true;
            this.Close();

        }

        /// <summary>
        /// Methode evenementielle appelé au click sur le bouton quitter. 
        /// toutes les pages de jeux ouvertes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void boutonQuitterJeu_Click(object sender, EventArgs e)
        {
            this.Close();
            partie.Close();
        }
    }
}
