using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Puissance_4;
using BibliothèquePuissance4;

namespace Puissance_4
{
    public partial class PagePartie : Form
    {
        /// <summary>
        /// Attribut qui stocke le numéro de la grille choisie dans le radioBouton de la page param
        /// (1 / 2 ou 3)
        /// </summary>
        private int choixGrille;
        /// <summary>
        /// Attribut correspondant à la partie elle même
        /// </summary>
        private Puissance4 partie;
        /// <summary>
        /// Attribut correspondant à la grille de puissance 4
        /// </summary>
        private TableLayoutPanel grilleDeJeu;


        Label vainqueur = new Label();
        private int nbColonne;
        private int nbLigne;

        public Puissance4 Partie { get => partie; set => partie = value; }
        public TableLayoutPanel GrilleDeJeu { get => grilleDeJeu; set => grilleDeJeu = value; }


        /// <summary>
        /// Constructeur de la page de jeu. Il initialise les composants et crée la grille de Jeu
        /// </summary>
        /// <param name="param">Il s'agit des informations de la pages paramétres utiles à la partie (taille grille + pseudo)</param>
        public PagePartie(object param, bool typeJeu)
        {
            InitializeComponent();

            int hauteurForm;
            int largeurForm;


            //Nomenclature des joueurs pour facilité la compréhension
            string PremierJoueur;
            string SecondJoueur;
            //prend les pseudos des joueurs si c'est une partie JVJ
            if (typeJeu)
            {
                page_param_JVJ paramJeu = (page_param_JVJ)param;
                PremierJoueur = paramJeu.PseudoJ1;
                SecondJoueur = paramJeu.PseudoJ2;
                choixGrille = paramJeu.ChoixGrilleRadioButton;
                lblTypePartie.Text = "Partie Joueur vs Joueur";
            }
            //prend le pseudo du joueur et définit le deuxième pseudo comme "IA" si c'est une partie JVIA
            else
            {
                page_param_JVIA paramJeu = (page_param_JVIA)param;
                PremierJoueur = paramJeu.PseudoJ;
                SecondJoueur = "IA";
                choixGrille = paramJeu.ChoixGrilleRadioButton;
                lblTypePartie.Text = "Partie Joueur vs IA";
            }



            //On initialise le label du joueur qui commencera lors du 1er tour (J1)
            JActif.Text = PremierJoueur;

            // Indique la couleur du joueur actif
            JActif.BackColor = Color.Red;

            // On va chercher la propriété qui correspond au radiobutton coché dans la page parametrage
            grilleDeJeu = new TableLayoutPanel();

            // Création de la partie de Puissance 4
            Partie = new Puissance4(PremierJoueur, SecondJoueur, choixGrille, typeJeu);

            // On attribue la valeur entrée dans les input de la page param aux labels d'ici
            J1.Text = PremierJoueur;
            J2.Text = SecondJoueur;
            creationGrille();

            //positionne bien le groupbox du joueur actif par rapport à la taille de la grille (de façons à ne pas la survoler)
            groupBoxJoueurActif.Left = grilleDeJeu.Location.X + grilleDeJeu.Size.Width + 20;

            //définit la taille de l'interface par rapport à la place que ses composants vont prendre et on prend en compte la taille de la grille aussi
            if (this.ClientSize.Height + 20 > grilleDeJeu.Top + grilleDeJeu.Bottom)
            {
                hauteurForm = this.ClientSize.Height + 20;
            }
            else
            {
                hauteurForm = grilleDeJeu.Top + grilleDeJeu.Bottom;
            }
            largeurForm = groupBoxJoueurActif.Right + groupBoxJoueurActif.Width / 2;
            this.Size = new Size(largeurForm, hauteurForm);

        }

        private void Partie_JVJ_Load(object sender, EventArgs e)
        {
            if (Partie.ChoixGrille == 2)
            {
                flecheColonne7.Visible = false;
            }
        }

        /// <summary>
        /// Méthode qui s'occupe d'initialiser la grille dans l'interface 
        /// en fonction du choix de grille réalisé
        /// </summary>
        private void creationGrille()
        {

            switch (Partie.ChoixGrille)
            {
                //Cas ou la grille 1 a été choisie par le joueur ou si elle a été choisi aléatoirement
                case 1:
                    LabelTailleGrille.Text = " Taille de la Grille : 6 x 7 ";
                    nbColonne = 7;
                    nbLigne = 6;
                    initGrille();
                    break;
                //Cas ou la grille 2 a été choisie par le joueur ou si celle ci a été choisi aléatoirement
                default:
                    LabelTailleGrille.Text = " Taille de la Grille : 5 x 6 ";
                    nbColonne = 6;
                    nbLigne = 5;
                    initGrille();
                    break;
            }


            grilleDeJeu.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;

            // Initialisation de la grille (tout vide) on met des labels dans chaque case
            initLabelDansGrille();
        }

        /// <summary>
        /// Méthode qui est en charge de créer des labels dans chaque case de la grille
        /// ces labels auront le rôle de jetons
        /// </summary>
        private void initLabelDansGrille()
        {
            for (int IndiceLigne = 0; IndiceLigne < nbLigne; IndiceLigne++)
            {
                for (int IndiceColonne = 0; IndiceColonne < nbColonne; IndiceColonne++)
                {
                    Label casePion = new Label();
                    casePion.Dock = DockStyle.Fill;
                    casePion.TextAlign = ContentAlignment.MiddleCenter;
                    casePion.BorderStyle = BorderStyle.FixedSingle;
                    casePion.Margin = new Padding(5, 5, 5, 5);
                    // Epaissir les bordures des cellules
                    casePion.Margin = new Padding(casePion.Margin.Left + 1, casePion.Margin.Top, casePion.Margin.Right, casePion.Margin.Bottom);
                    casePion.BackColor = Color.White;

                    grilleDeJeu.Controls.Add(casePion, IndiceColonne, IndiceLigne);

                    //Aligne les boutons par rapport aux colonnes
                    if (IndiceLigne == 0)
                    {
                        switch (IndiceColonne)
                        {
                            case 0:
                                flecheColonne1.Left = grilleDeJeu.Left + IndiceColonne * (grilleDeJeu.Size.Width / nbColonne);
                                break;
                            case 1:
                                flecheColonne2.Left = grilleDeJeu.Left + IndiceColonne * (grilleDeJeu.Size.Width / nbColonne);
                                break;
                            case 2:
                                flecheColonne3.Left = grilleDeJeu.Left + IndiceColonne * (grilleDeJeu.Size.Width / nbColonne);
                                break;
                            case 3:
                                flecheColonne4.Left = grilleDeJeu.Left + IndiceColonne * (grilleDeJeu.Size.Width / nbColonne);
                                break;
                            case 4:
                                flecheColonne5.Left = grilleDeJeu.Left + IndiceColonne * (grilleDeJeu.Size.Width / nbColonne);
                                break;
                            case 5:
                                flecheColonne6.Left = grilleDeJeu.Left + IndiceColonne * (grilleDeJeu.Size.Width / nbColonne);
                                break;
                            default:
                                flecheColonne7.Left = grilleDeJeu.Left + IndiceColonne * (grilleDeJeu.Size.Width / nbColonne);
                                break;
                        }
                    }
                }
            }
            this.Controls.Add(grilleDeJeu);
        }

        /// <summary>
        /// Méthode qui créee le tableLayoutPanel qui fera office de grille
        /// </summary>
        private void initGrille()
        {
            int xGrille;
            int yGrille;
            grilleDeJeu.Size = new Size(1000, 500); // Définition la taille du TableLayoutPanel
            grilleDeJeu.BackColor = Color.DarkBlue;
            grilleDeJeu.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;        // Initialisation du style de la grille 
            grilleDeJeu.AutoSizeMode = AutoSizeMode.GrowOnly;

            xGrille = grpRegles.Left + grpRegles.Width + 20;
            yGrille = flecheColonne1.Top + flecheColonne1.Height + 20;
            grilleDeJeu.Location = new Point(xGrille, yGrille);

            grilleDeJeu.BorderStyle = BorderStyle.FixedSingle;


            // Définir la taille des colonnes en fonction du nombre de colonnes
            for (int i = 0; i < nbColonne; i++)
            {
                grilleDeJeu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / nbColonne));

            }

            // Définir la taille des lignes
            for (int i = 0; i < nbLigne; i++)
            {
                grilleDeJeu.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / nbLigne));
            }

        }




        /// <summary>
        /// Méthode qui modifie le nom et la couleur du label indiquant le joueur
        /// actif (joueur a qui c'est au tour de jouer)
        /// </summary>        
        private void ChangerPseudoJActif()
        {
            if (JActif.Text == J2.Text)
            {
                JActif.Text = J1.Text;
                JActif.BackColor = Color.Red;
            }
            else
            {
                JActif.Text = J2.Text;
                JActif.BackColor = Color.Yellow;
            }

        }

        /// <summary>
        /// Méthode qui enregistre le gagnant et ouvre une nouvelle page de victoire
        /// </summary>
        private void AffichageGagnant()
        {
            if (Partie.Gagnant == 1)
            {
                vainqueur.Text = Partie.J2G.Pseudo + " a remporté la partie";
                vainqueur.Location = new Point(0, 700);
                vainqueur.BackColor = Color.Red;
                ResultatJVJ pageResultat = new ResultatJVJ(Partie.J1G); // On ouvre une nouvelle page et on lui donne le joueur gagnant    
                pageResultat.Show();
                this.Hide();// On ferme la page de la partie
            }
            else if (Partie.Gagnant == 2)
            {
                vainqueur.Text = Partie.J2G.Pseudo + " a remporté la partie";
                vainqueur.Location = new Point(0, 700);
                vainqueur.BackColor = Color.Yellow;
                ResultatJVJ pageResultat = new ResultatJVJ(Partie.J2G); //On ouvre une nouvelle page et on lui donne le joueur gagnant
                pageResultat.Show();
                this.Hide();  // On ferme la page du jeu
            }

            else if (Partie.Gagnant == 0)
            {
                vainqueur.Text = "Match nul !";
                vainqueur.Location = new Point(0, 700);
                vainqueur.BackColor = Color.Blue;
                ResultatJVJ pageResultat = new ResultatJVJ(null); // On ouvre une nouvelle page et on lui donne le joueur gagnant    
                pageResultat.Show();
                this.Hide();// On ferme la page de la partie
            }

        }


        /// <summary>
        /// Fonction qui joue le pion dans la colonne demandée au click sur la flèche
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Colonne_Click(object sender, EventArgs e)
        {
            int colonneJoueeJoueur;
            int colonneJoueeIA;
            PictureBox flecheClique = (PictureBox)sender;

            //en fonction du bouton cliqué, met la bonne colonne
            switch (flecheClique.Name)
            {
                case "flecheColonne1":
                    colonneJoueeJoueur = 1;
                    break;
                case "flecheColonne2":
                    colonneJoueeJoueur = 2;
                    break;
                case "flecheColonne3":
                    colonneJoueeJoueur = 3;
                    break;
                case "flecheColonne4":
                    colonneJoueeJoueur = 4;
                    break;
                case "flecheColonne5":
                    colonneJoueeJoueur = 5;
                    break;
                case "flecheColonne6":
                    colonneJoueeJoueur = 6;
                    break;
                default:
                    colonneJoueeJoueur = 7;
                    break;
            }

            //joue le pion du joueur dans la colonne et vérification si le coup est gagnant
            Partie.Jeu(colonneJoueeJoueur);
            MajGrille();
            AffichageGagnant();
            ChangerPseudoJActif();


            //si la colonne jouée par le joueur est pleine après le coup, le bouton est désactivé 
            if (Partie.GrilleJeu[0, colonneJoueeJoueur - 1] != 0)
            {
                flecheClique.Enabled = false;
            }

            //L'IA joue son coup 
            if (Partie.ChoixMode == false && Partie.Gagnant == -1)
            {
                colonneJoueeIA = Partie.J2G.CoupIA(Partie);
                Partie.Jeu(colonneJoueeIA);
                MajGrille();
                AffichageGagnant();
                ChangerPseudoJActif();

            }
        }

        /// <summary>
        ///  Méthode qui met à jour l'affichage de la grille en fonction des numéros
        ///  qui se trouvent dans chaque case de la matrice qui fait office de grille
        ///  dans le moteur du jeu
        /// </summary>
        private void MajGrille()

        {
            for (int IndiceLigne = 0; IndiceLigne < nbLigne; IndiceLigne++)
            {
                for (int IndiceColonne = 0; IndiceColonne < nbColonne; IndiceColonne++)
                {
                    // On colorie les cases en fonction du numéro qu'il y a dans la case de la matrice du Partie ( 0 -> blanc(vide) ; 1 -> Rouge (J1) ; 2 -> Jaune (J2)
                    if (Partie.GrilleJeu[IndiceLigne, IndiceColonne] == 1)
                    {

                        // On colorie les cases en fonction du numéro qu'il y a dans la case de la matrice du Partie ( 0 -> blanc(vide) ; 1 -> Rouge (J1) ; 2 -> Jaune (J2)
                        if (Partie.GrilleJeu[IndiceLigne, IndiceColonne] == 1)
                        {
                            grilleDeJeu.GetControlFromPosition(IndiceColonne, IndiceLigne).BackColor = Color.Red;
                        }
                        else
                        {
                            if (Partie.GrilleJeu[IndiceLigne, IndiceColonne] == 2)
                            {
                                grilleDeJeu.GetControlFromPosition(IndiceColonne, IndiceLigne).BackColor = Color.Yellow;
                            }
                            else
                            {
                                grilleDeJeu.GetControlFromPosition(IndiceColonne, IndiceLigne).BackColor = Color.White;
                            }
                        }

                    }
                    else
                    {
                        if (Partie.GrilleJeu[IndiceLigne, IndiceColonne] == 2)
                        {

                            Label label3 = new Label();
                            label3.Text = IndiceColonne.ToString();
                            if (Partie.GrilleJeu[IndiceLigne, IndiceColonne] == 1)
                            {
                                grilleDeJeu.GetControlFromPosition(IndiceColonne, IndiceLigne).BackColor = Color.Red;
                            }
                            else
                            {
                                if (Partie.GrilleJeu[IndiceLigne, IndiceColonne] == 2)
                                {
                                    grilleDeJeu.GetControlFromPosition(IndiceColonne, IndiceLigne).BackColor = Color.Yellow;
                                }
                                else
                                {
                                    grilleDeJeu.GetControlFromPosition(IndiceColonne, IndiceLigne).BackColor = Color.White;
                                }
                            }


                        }
                    }

                }
            }
        }

    }
}