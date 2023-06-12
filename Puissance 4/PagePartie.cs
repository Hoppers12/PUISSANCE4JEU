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
using System.Configuration;
using Microsoft.VisualBasic.Devices;
using System.Windows.Forms.VisualStyles;

namespace Puissance_4
{
    public partial class frmPagePartie : Form
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

        private Image imgPionRouge;
        private Image imgPionJaune;
        private Image imgPionAbs;

        private int nbColonne;
        private int nbLigne;

        public Puissance4 Partie { get => partie; set => partie = value; }
        public TableLayoutPanel GrilleDeJeu { get => grilleDeJeu; set => grilleDeJeu = value; }



        /// <summary>
        /// Constructeur de la page de jeu. Il initialise les composants et crée la grille de Jeu
        /// </summary>
        /// <param name="param">Il s'agit des informations de la pages paramétres utiles à la partie (taille grille + pseudo)</param>
        public frmPagePartie(object param, bool typeJeu)
        {
            InitializeComponent();

            //Nomenclature des joueurs pour faciliter la compréhension
            string PremierJoueur;
            string SecondJoueur;

            imgPionRouge = Image.FromFile($"{Application.StartupPath}../../../../assets/pion-rouge.png");
            imgPionJaune = Image.FromFile($"{Application.StartupPath}../../../../assets/pion-jaune.png");
            imgPionAbs = Image.FromFile($"{Application.StartupPath}../../../../assets/pion-absent.png");

            //prend les pseudos des joueurs si c'est une partie JVJ
            if (typeJeu)
            {
                frmParamJVJ paramJeu = (frmParamJVJ)param;
                PremierJoueur = paramJeu.PseudoJ1;
                SecondJoueur = paramJeu.PseudoJ2;
                choixGrille = paramJeu.ChoixGrilleRadioButton;
                lblTypePartie.Text = "Partie Joueur vs Joueur";
            }

            //prend le pseudo du joueur et définit le deuxième pseudo comme "IA" si c'est une partie JVIA
            else
            {
                frmParamJVIA paramJeu = (frmParamJVIA)param;
                PremierJoueur = paramJeu.PseudoJ;
                SecondJoueur = "IA";
                choixGrille = paramJeu.ChoixGrilleRadioButton;
                lblTypePartie.Text = "Partie Joueur vs IA";
            }


            //On initialise le label du joueur qui commencera lors du 1er tour (J1)
            lblJActif.Text = PremierJoueur;

            // Indique la couleur du joueur actif
            lblJActif.BackColor = Color.Red;

            // On va chercher la propriété qui correspond au radiobutton coché dans la page parametrage
            grilleDeJeu = new TableLayoutPanel();

            // Création de la partie de Puissance 4
            partie = new Puissance4(PremierJoueur, SecondJoueur, choixGrille, typeJeu);

            // On attribue la valeur entrée dans les input de la page param aux labels d'ici
            lblPseudoJ1.Text = PremierJoueur;
            lblPseudoJ2.Text = SecondJoueur;
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
            lblTailleGrille.Left = GrilleDeJeu.Left + GrilleDeJeu.Width / 2 - lblTailleGrille.Width / 2;

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
            grpJoueurActif.Left = grilleDeJeu.Left + grilleDeJeu.Size.Width + 20;

            //définit la taille de l'interface par rapport à la place que ses composants vont prendre et on prend en compte la taille de la grille aussi
            if (this.ClientSize.Height + 20 > grilleDeJeu.Top + grilleDeJeu.Bottom)
            {
                hauteurForm = this.ClientSize.Height + 20;
            }
            else
            {
                hauteurForm = grilleDeJeu.Top + grilleDeJeu.Bottom;
            }

            largeurForm = grpJoueurActif.Left + grpJoueurActif.Width + 20;
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
                    lblTailleGrille.Text = " Taille de la Grille : 6 x 7 ";
                    nbColonne = 7;
                    nbLigne = 6;
                    break;
                //Cas ou la grille 2 a été choisie par le joueur ou si celle ci a été choisi aléatoirement
                default:
                    lblTailleGrille.Text = " Taille de la Grille : 5 x 6 ";
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
                    casePion.Image = imgPionAbs;
                    casePion.Name = $"picCaseL{IndiceLigne + 1}C{IndiceColonne + 1}";
                    casePion.Click += Colonne_Click;
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
            if (lblJActif.Text == lblPseudoJ2.Text)
            {
                lblJActif.Text = lblPseudoJ1.Text;
                lblJActif.BackColor = Color.Red;
            }
            else
            {
                lblJActif.Text = lblPseudoJ2.Text;
                lblJActif.BackColor = Color.Yellow;
            }

        }



        /// <summary>
        /// Méthode qui enregistre le gagnant et ouvre une nouvelle page de victoire
        /// </summary>
        private void AffichageGagnant()
        {
            frmResultat pageResultat;
            switch (Partie.Gagnant)
            {
                case 0:
                    pageResultat = new frmResultat(this); // On ouvre une nouvelle page et on lui donne le joueur gagnant    
                    pageResultat.Show();
                    this.Enabled = false; //Freeze le jeu
                    break;
                case 1:
                    pageResultat = new frmResultat(Partie.J1, this); // On ouvre une nouvelle page et on lui donne le joueur gagnant    
                    pageResultat.Show();
                    this.Enabled = false; //Freeze le jeu
                    break;
                case 2:
                    pageResultat = new frmResultat(Partie.J2, this); //On ouvre une nouvelle page et on lui donne le joueur gagnant
                    pageResultat.Show();
                    this.Enabled = false;
                    break;

            }


        }



        /// <summary>
        /// Fonction qui joue le pion dans la colonne demandée au click sur la flèche
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Colonne_Click(object? sender, EventArgs e)
        {
            int colonneJoueeJoueur;
            int colonneJoueeIA;
            PictureBox colonneClick;

            if (sender is not null)
            {
                colonneClick = (PictureBox)sender;

                //en fonction du bouton cliqué, met la bonne colonne
                colonneJoueeJoueur = Convert.ToInt32(colonneClick.Name.Last() - 48);

                //si la colonne n'est pas pleine, il joue le coup sinon il fait rien
                if (Partie.GrilleJeu[0, colonneJoueeJoueur - 1] == 0)
                {
                    //joue le pion du joueur dans la colonne et vérification si le coup est gagnant
                    Partie.Jeu(colonneJoueeJoueur);
                    MajGrille();
                    AffichageGagnant();
                    ChangerPseudoJActif();
                    //L'IA joue son coup
                    if (Partie.ChoixMode == false && Partie.Gagnant != 1)
                    {
                        colonneJoueeIA = Partie.J2.CoupIA(Partie);
                        Partie.Jeu(colonneJoueeIA);
                        MajGrille();
                        AffichageGagnant();
                        ChangerPseudoJActif();
                    }
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
                        caseTraitee.Image = imgPionRouge;

                    }
                    else if (Partie.GrilleJeu[IndiceLigne, IndiceColonne] == 2)
                    {
                        caseTraitee.Image = imgPionJaune;

                    }
                    else if (Partie.GrilleJeu[IndiceLigne, IndiceColonne] == 0)
                    {
                        caseTraitee.Image = imgPionAbs;
                    }

                }
            }
        }

        private void PagePartie_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Affichez une boîte de dialogue de confirmation
                DialogResult fermeture = MessageBox.Show("Êtes-vous sûr de vouloir fermer la fenêtre ? \nLa partie sera totalement arrêté.", "Confirmation de fermeture", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Si l'utilisateur clique sur Non, annulez la fermeture
                if (fermeture == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}