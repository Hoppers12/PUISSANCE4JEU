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
        private int choixGrille;
        private Puissance4 partie;
        private TableLayoutPanel tableLayoutPanel1;


        Label vainqueur = new Label();
        private int nbColonne;
        private int nbLigne;

        public Puissance4 Partie { get => partie; set => partie = value; }
        public TableLayoutPanel TableLayoutPanel1 { get => tableLayoutPanel1; set => tableLayoutPanel1 = value; }

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
            tableLayoutPanel1 = new TableLayoutPanel();
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
                    initGrille1();
                    break;
                //Cas ou la grille 2 a été choisie
                case 2:
                    LabelTailleGrille.Text = " Taille de la Grille : 6 x 5 ";
                    nbColonne = 6;
                    nbLigne = 5;
                    initGrille2();
                    break;

                // Cas ou le joueur a choisie la grille aléatoire
                default:
                    choixGrille = Partie.choixGrille;

                    if (choixGrille == 1)
                    {
                        LabelTailleGrille.Text = " Taille de la Grille : 6 x 7 ";
                        nbColonne = 7;
                        nbLigne = 6;
                        initGrille1();
                        break;

                    }
                    else
                    {
                        LabelTailleGrille.Text = " Taille de la Grille : 6 x 5 ";
                        nbColonne = 6;
                        nbLigne = 5;
                        initGrille2();
                        break;

                    }
                    break;

            }
   

            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;

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
                    Label label = new Label();
                    label.Dock = DockStyle.Fill;
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    label.BorderStyle = BorderStyle.FixedSingle;
                    label.Margin = new Padding(5, 5, 5, 5);
                    // Epaissir les bordures des cellules
                    label.Margin = new Padding(label.Margin.Left + 1, label.Margin.Top, label.Margin.Right, label.Margin.Bottom); 
                    label.BackColor = Color.White;
                    tableLayoutPanel1.Controls.Add(label, IndiceColonne, IndiceLigne);
                }
            }
            this.Controls.Add(tableLayoutPanel1);
        }


        private void initGrille1()
        {


            tableLayoutPanel1.Size = new Size(1000, 500); // Définition la taille du TableLayoutPanel
            tableLayoutPanel1.BackColor = Color.DarkBlue;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;        // Initialisation du style de la grille 
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowOnly;
            tableLayoutPanel1.Location = new Point(400, 150);
            tableLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;


            // Définir la taille des colonnes en fonction du nombre de colonnes
            for (int i = 0; i < nbColonne; i++)
            {
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / nbColonne));

            }

            // Définir la taille des lignes
            for (int i = 0; i < nbLigne; i++)
            {
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / nbLigne));
            }

        }

        //Fonction qui crée la grille 2 
        private void initGrille2()
        {
            tableLayoutPanel1.BackColor = Color.DarkBlue;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;        // Initialisation du style de la grille 
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ForeColor = SystemColors.Highlight;
            tableLayoutPanel1.Location = new Point(400, 150);


            tableLayoutPanel1.Size = new Size(1000, 500); // Définition la taille du TableLayoutPanel

            // Définir la taille des colonnes
            for (int i = 0; i < nbColonne; i++)
            {
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / nbColonne));
            }

            // Définir la taille des lignes
            for (int i = 0; i < nbLigne; i++)
            {
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / nbLigne));
            }

        }


        //Fonction qui changer le pseudo dans le label du joueur actif 
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
        // Fonction qui affiche le résultat de la partie à l'écran
        private void affichageGagnant()
        {
            if (Partie.gagnant == 1)
            {
                vainqueur.Text = Partie.J2.pseudo + " a remporté la partie";
                vainqueur.Location = new Point(0, 700);
                vainqueur.BackColor = Color.Red;
                ResultatJVJ pageResultat = new ResultatJVJ(Partie.J1); // On ouvre une nouvelle page et on lui donne le joueur gagnant    
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
        ///  Méthode qui met à jour l'affichage de la grille
        /// </summary>
        private void MajGrille()

        {
            if (choixGrille == 1)
            {
                nbLigne = 6;
                nbColonne = 7;
            }
            else
            {
                nbLigne = 5;
                nbColonne = 6;
            }

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
                            tableLayoutPanel1.GetControlFromPosition(IndiceColonne, IndiceLigne).BackColor = Color.Red;
                        }
                        else
                        {
                            if (Partie.grille1[IndiceLigne, IndiceColonne] == 2)
                            {
                                tableLayoutPanel1.GetControlFromPosition(IndiceColonne, IndiceLigne).BackColor = Color.Yellow;
                            }
                            else
                            {
                                tableLayoutPanel1.GetControlFromPosition(IndiceColonne, IndiceLigne).BackColor = Color.White;
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
                                tableLayoutPanel1.GetControlFromPosition(IndiceColonne, IndiceLigne).BackColor = Color.Red;
                            }
                            else
                            {
                                if (Partie.grille2[IndiceLigne, IndiceColonne] == 2)
                                {
                                    tableLayoutPanel1.GetControlFromPosition(IndiceColonne, IndiceLigne).BackColor = Color.Yellow;
                                }
                                else
                                {
                                    tableLayoutPanel1.GetControlFromPosition(IndiceColonne, IndiceLigne).BackColor = Color.White;
                                }
                            }

                        }
                    }

                }
            }
        }


    }
}