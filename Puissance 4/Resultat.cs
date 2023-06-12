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
    public partial class frmResultat : Form
    {

        string pseudoGagnant;
        frmPagePartie partie;

        /// <summary>
        /// Constructeur de la page de resultat
        /// il permet d'initialiser les composants et d'afficher le pseudo des gagnants
        /// si il y en a
        /// </summary>
        /// <param name="vainqueur">joueur vainqueur ou null si égalité/param>
        /// <param name="partieFinie">partie qui vient de se terminer</param>
        public frmResultat(Joueur vainqueur, frmPagePartie partieFinie)
        {
            partie = partieFinie;
            this.MaximizeBox = false;

            pseudoGagnant = vainqueur.Pseudo;
            InitializeComponent();
            lblPseudoVainqueur.Text = pseudoGagnant + " a remporté la partie";
        }

        public frmResultat(frmPagePartie partieFinie)
        {
            partie = partieFinie;
            this.MaximizeBox = false;
            pseudoGagnant = "";
            InitializeComponent();
            lblPseudoVainqueur.Text = "Match nul !";
        }

        /// <summary>
        /// Méthode d'événement loesque l'utilisateur clique sur le bouton retour accueil
        /// il ferme la page résultat et partie et retourne à l'accueil
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRetourAccueil_Click(object sender, EventArgs e)
        {
            frmAccueil pageAccueil = new frmAccueil();
            pageAccueil.Show();
            partie.Dispose();
            this.Close();
        }


        /// <summary>
        /// méthode évènementielle appelée au click sur le bouton rejouer
        /// elle permet de réinitialiser la grille tout en permettant
        /// de rejouer une partie avec les mêmes paramètres
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRejouer_Click(object sender, EventArgs e)
        {
            partie.Partie.InitGrille();
            partie.MajGrille();

            //Réinitialise le joueur qui joue en premier
            partie.lblJActif.Text = partie.lblPseudoJ1.Text;
            partie.lblJActif.BackColor = Color.Red;
            partie.Partie.JoueurSuivant = true;

            //redéfinit la partie comme "en cours" 
            partie.Partie.Gagnant = -1;

            //réactive la page de partie
            partie.Enabled = true;
            this.Close();
        }

        /// <summary>
        /// Methode evenementielle appelé au click sur le bouton quitter. 
        /// Elle ferme toutes les pages de jeux ouvertes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuitterJeu_Click(object sender, EventArgs e)
        {            
            this.Close();
            partie.Dispose();
        }
    }
}
