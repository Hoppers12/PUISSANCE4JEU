﻿using System;
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
using System.Configuration;
using Microsoft.VisualBasic.Devices;
using System.Windows.Forms.VisualStyles;

namespace Puissance_4
{
    public partial class PagePartie : Form
    {
        /// <summary>
        /// Attribut qui stocke le numéro de la grille choisie dans le radioBouton de la page param
        /// </summary>
        /// <example>
        /// 1 (grille 1), 2 (grille 2) ou 3 (grille aléatoire)
        /// </example>
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
            //Nomenclature des joueurs pour faciliter la compréhension
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
        }



        /// <summary>
        /// Méthode qui va initialiser et positionner des éléments sur la page au chargement de celle-ci et en fonction des éléments placés, la taille de la page va changer et s'adapter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Partie_JVJ_Load(object sender, EventArgs e)
        {
            PictureBox picBoxJouerColonne;

            int hauteurForm;
            int largeurForm;

            //La grille du puissance 4 est créée
            creationGrille();

            //place le label indiquant la grille au centre de la grille
            LabelTailleGrille.Left = GrilleDeJeu.Left + GrilleDeJeu.Width / 2 - LabelTailleGrille.Width / 2;

            //Créée des boutons pour placer les pions dans les colonnes et alignes par rapport à ceux-ci
            for (int IndiceColonne = 0; IndiceColonne < nbColonne; IndiceColonne++)
            {
                picBoxJouerColonne = new PictureBox();
                picBoxJouerColonne.Size = new Size(66, 36);
                picBoxJouerColonne.Name = $"picFlecheColonne{IndiceColonne + 1}";
                picBoxJouerColonne.BackColor = Color.RoyalBlue;
                picBoxJouerColonne.Image = Image.FromFile($"{Application.StartupPath}../../../../assets/fleche.png");
                picBoxJouerColonne.SizeMode = PictureBoxSizeMode.Zoom;
                picBoxJouerColonne.Left = grilleDeJeu.Left + IndiceColonne * (grilleDeJeu.Size.Width / nbColonne);
                picBoxJouerColonne.Left += (grilleDeJeu.Width / nbColonne - picBoxJouerColonne.Width) / 2;
                picBoxJouerColonne.Top = GrilleDeJeu.Top - picBoxJouerColonne.Height - 20;
                picBoxJouerColonne.Click += Colonne_Click;
                this.Controls.Add(picBoxJouerColonne);
            }

            //positionne bien le groupbox du joueur actif par rapport à la taille de la grille (de façons à ne pas la survoler)
            groupBoxJoueurActif.Left = grilleDeJeu.Left + grilleDeJeu.Size.Width + 20;

            //définit la taille de l'interface par rapport à la place que ses composants vont prendre et on prend en compte la taille de la grille aussi
            if (this.ClientSize.Height + 20 > grilleDeJeu.Top + grilleDeJeu.Bottom)
            {
                hauteurForm = this.ClientSize.Height + 20;
            }
            else
            {
                hauteurForm = grilleDeJeu.Top + grilleDeJeu.Bottom;
            }

            largeurForm = groupBoxJoueurActif.Left + groupBoxJoueurActif.Width + 20;
            this.Size = new Size(largeurForm, hauteurForm);
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
                    break;
                //Cas ou la grille 2 a été choisie par le joueur ou si celle ci a été choisi aléatoirement
                default:
                    LabelTailleGrille.Text = " Taille de la Grille : 5 x 6 ";
                    nbColonne = 6;
                    nbLigne = 5;
                    break;
            }
            initGrille();
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
                    PictureBox casePion = new PictureBox();
                    casePion.Dock = DockStyle.Fill;
                    casePion.SizeMode = PictureBoxSizeMode.Zoom;
                    casePion.Image = Image.FromFile($"{Application.StartupPath}../../../../assets/pion-absent.png");
                    grilleDeJeu.Controls.Add(casePion, IndiceColonne, IndiceLigne);
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
            grilleDeJeu.Padding = new Padding(10, 20, 10, 20);
            grilleDeJeu.BackColor = Color.DarkBlue;
            grilleDeJeu.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;        // Initialisation du style de la grille 
            grilleDeJeu.AutoSizeMode = AutoSizeMode.GrowOnly;

            xGrille = grpRegles.Left + grpRegles.Width + 20;
            yGrille = grpRegles.Location.Y + grpRegles.Height / 4;
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
                vainqueur.Text = Partie.J1G.Pseudo + " a remporté la partie";
                vainqueur.Location = new Point(0, 700);
                vainqueur.BackColor = Color.Red;
                Resultat pageResultat = new Resultat(Partie.J1G, this); // On ouvre une nouvelle page et on lui donne le joueur gagnant    
                pageResultat.Show(this);
                this.Enabled = false; //Freeze le jeu

            }
            else if (Partie.Gagnant == 2)
            {
                vainqueur.Text = Partie.J2G.Pseudo + " a remporté la partie";
                vainqueur.Location = new Point(0, 700);
                vainqueur.BackColor = Color.Yellow;
                Resultat pageResultat = new Resultat(Partie.J2G, this); //On ouvre une nouvelle page et on lui donne le joueur gagnant
                pageResultat.Show();
                this.Enabled = false;
            }

            else if (Partie.Gagnant == 0)
            {
                vainqueur.Text = "Match nul !";
                vainqueur.Location = new Point(0, 700);
                vainqueur.BackColor = Color.Blue;
                Resultat pageResultat = new Resultat(null, this); // On ouvre une nouvelle page et on lui donne le joueur gagnant    
                pageResultat.Show();
                this.Enabled = false; //Freeze le jeu
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
            PictureBox flecheCoupIA;

            //en fonction du bouton cliqué, met la bonne colonne
            colonneJoueeJoueur = Convert.ToInt32(flecheClique.Name.Last() - 48);


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
            if (Partie.ChoixMode == false && Partie.Gagnant != 1)
            {
                colonneJoueeIA = Partie.J2G.CoupIA(Partie);

                Partie.Jeu(colonneJoueeIA);
                MajGrille();
                AffichageGagnant();
                ChangerPseudoJActif();
                flecheCoupIA = (PictureBox)this.Controls[$"picFlecheColonne{colonneJoueeIA}"];

                if (Partie.GrilleJeu[0, colonneJoueeIA - 1] != 0)
                {
                    flecheCoupIA.Enabled = false;
                }
            }

        }

        /// <summary>
        ///  Méthode qui met à jour l'affichage de la grille en fonction des numéros
        ///  qui se trouvent dans chaque case de la matrice qui fait office de grille
        ///  dans le moteur du jeu
        /// </summary>
        public void MajGrille()

        {
            for (int IndiceLigne = 0; IndiceLigne < nbLigne; IndiceLigne++)
            {
                for (int IndiceColonne = 0; IndiceColonne < nbColonne; IndiceColonne++)
                {
                    PictureBox caseTraitee = (PictureBox)grilleDeJeu.GetControlFromPosition(IndiceColonne, IndiceLigne);
                    // On colorie les cases en fonction du numéro qu'il y a dans la case de la matrice du Partie (1 -> Rouge (J1) ; 2 -> Jaune (J2))
                    if (Partie.GrilleJeu[IndiceLigne, IndiceColonne] == 1)
                    {
                        caseTraitee.Image = Image.FromFile($"{Application.StartupPath}../../../../assets/pion-rouge.png");

                    }
                    else if (Partie.GrilleJeu[IndiceLigne, IndiceColonne] == 2)
                    {
                        caseTraitee.Image = Image.FromFile($"{Application.StartupPath}../../../../assets/pion-jaune.png");

                    }
                    else if (Partie.GrilleJeu[IndiceLigne, IndiceColonne] == 0 && caseTraitee.Image != Image.FromFile($"{Application.StartupPath}../../../../assets/pion-absent.png"))
                    {
                        caseTraitee.Image = Image.FromFile($"{Application.StartupPath}../../../../assets/pion-absent.png");
                    }

                }
            }
        }
    }
}