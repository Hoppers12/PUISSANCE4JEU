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
using Puissance_4;
using static Program;
namespace Puissance_4
{



    public partial class Partie_JVJ : Form
    {
        /// <summary>
        /// Attribut qui stocke le numéro de la grille choisie dans le radioBouton de la page param
        /// (1 / 2 ou 3
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
        public Partie_JVJ(page_param_JVJ param)
        {
            InitializeComponent();
            //Nomenclature des joueurs pour facilité la compréhension
            string PremierJoueur = param.PseudoJ1;
            string SecondJoueur = param.PseudoJ2;

            //On initialise le label du joueur qui commencera lors du 1er tour (J1)
            JActif.Text = PremierJoueur;
            JActif.BackColor = Color.Red;

            // On va chercher la propriété qui correspond au radiobutton coché dans la page parametrage
            choixGrille = param.ChoixGrilleRadioButton;
            grilleDeJeu = new TableLayoutPanel();

            // Création de la partie de Puissance 4
            Partie = new Puissance4(PremierJoueur, SecondJoueur, choixGrille, true);

            // On attribue la valeur entrée dans les input de la page param aux labels d'ici
            J1.Text = PremierJoueur;
            J2.Text = SecondJoueur;
            creationGrille();

        }

        /// <summary>
        /// Méthode qui s'occupe d'initialiser la grille dans l'interface 
        /// en fonction du choix de grille réalisé
        /// </summary>
        private void creationGrille()
        {

            switch (choixGrille)
            {
                //Cas ou la grille 1 a été choisie
                case 1:
                    LabelTailleGrille.Text = " Taille de la Grille : 6 x 7 ";
                    nbColonne = 7;
                    nbLigne = 6;
                    initGrille();
                    break;
                //Cas ou la grille 2 a été choisie
                case 2:
                    LabelTailleGrille.Text = " Taille de la Grille : 6 x 5 ";
                    nbColonne = 6;
                    nbLigne = 5;
                    initGrille();
                    break;

                // Cas ou le joueur a choisie la grille aléatoire
                default:
                    choixGrille = Partie.choixGrille;

                    if (choixGrille == 1)
                    {
                        LabelTailleGrille.Text = " Taille de la Grille : 6 x 7 ";
                        nbColonne = 7;
                        nbLigne = 6;
                        initGrille();
                        break;

                    }
                    else
                    {
                        LabelTailleGrille.Text = " Taille de la Grille : 6 x 5 ";
                        nbColonne = 6;
                        nbLigne = 5;
                        initGrille();
                        break;

                    }

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
                }
            }
            this.Controls.Add(grilleDeJeu);
        }

        /// <summary>
        /// Méthode qui créee le tableLayoutPanel qui fera office de grille
        /// </summary>
        private void initGrille()
        {
            grilleDeJeu.Size = new Size(1000, 500); // Définition la taille du TableLayoutPanel
            grilleDeJeu.BackColor = Color.DarkBlue;
            grilleDeJeu.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;        // Initialisation du style de la grille 
            grilleDeJeu.AutoSizeMode = AutoSizeMode.GrowOnly;
            grilleDeJeu.Location = new Point(400, 150);
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
        private void changerPseudoJActif()
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
        private void affichageGagnant()
        {
            if (Partie.gagnant == 1)
            {
                vainqueur.Text = Partie.J2.pseudo + " a remporté la partie";
                vainqueur.Location = new Point(0, 700);
                vainqueur.BackColor = Color.Red;

                // On ouvre une nouvelle page et on lui donne le joueur gagnant    
                ResultatJVJ pageResultat = new ResultatJVJ(Partie.J1);
                pageResultat.Show();
                this.Hide();// On ferme la page du Partie

            }
            else
            {
                if (Partie.gagnant == 2)
                {
                    vainqueur.Text = Partie.J2.pseudo + " a remporté la partie";
                    vainqueur.Location = new Point(0, 700);
                    vainqueur.BackColor = Color.Yellow;
                    ResultatJVJ pageResultat = new ResultatJVJ(Partie.J2); //On ouvre une nouvelle page et on lui donne le joueur gagnant
                    pageResultat.Show();
                    this.Hide();  // On ferme la page du jeu
                }
            }
        }



        /// <summary>
        /// Fonction qui joue le pion dans la colonne demandée au click sur la flèche
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Colonne_Click(object sender, EventArgs e)
        {
            PictureBox flecheClique = (PictureBox)sender;

            switch (flecheClique.Name)
            {
                case "flecheColonne1":
                    Partie.Jeu(1);
                    break;
                case "flecheColonne2":
                    Partie.Jeu(2);
                    break;
                case "flecheColonne3":
                    Partie.Jeu(3);
                    break;
                case "flecheColonne4":
                    Partie.Jeu(4);
                    break;
                case "flecheColonne5":
                    Partie.Jeu(5);
                    break;
                case "flecheColonne6":
                    Partie.Jeu(6);
                    break;
                case "flecheColonne7":
                    Partie.Jeu(7);
                    break;
            }
            MajGrille();
            affichageGagnant();
            changerPseudoJActif();
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
                    // Modification de la la cellule en fonction de la nouvelle grille modifiée
                    if (choixGrille == 1)
                    {
                        // On colorie les cases en fonction du numéro qu'il y a dans la case de la matrice du Partie ( 0 -> blanc(vide) ; 1 -> Rouge (J1) ; 2 -> Jaune (J2)
                        if (Partie.grille1[IndiceLigne, IndiceColonne] == 1)
                        {
                            grilleDeJeu.GetControlFromPosition(IndiceColonne, IndiceLigne).BackColor = Color.Red;
                        }
                        else
                        {
                            if (Partie.grille1[IndiceLigne, IndiceColonne] == 2)
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
                        if (choixGrille == 2)
                        {

                            Label label3 = new Label();
                            label3.Text = IndiceColonne.ToString();
                            if (Partie.grille2[IndiceLigne, IndiceColonne] == 1)
                            {
                                grilleDeJeu.GetControlFromPosition(IndiceColonne, IndiceLigne).BackColor = Color.Red;
                            }
                            else
                            {
                                if (Partie.grille2[IndiceLigne, IndiceColonne] == 2)
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