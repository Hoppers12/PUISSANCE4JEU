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
        public Puissance4 Partie;
        public TableLayoutPanel tableLayoutPanel1;

        Label J1 = new Label();
        Label J2 = new Label();
        Label JActif = new Label();
        Label VS = new Label();
        Label JoueurActifPhrase = new Label();
        Label vainqueur = new Label();



        int nbColonne;
        int nbLigne;

        public void creationGrille()
        {

        }
        public Partie_JVJ(page_param_JVJ param)
        {
            InitializeComponent();
            //Nomenclature des joueurs pour facilité la compréhension
            string PremierJoueur = param.PseudoJ1;
            string SecondJoueur = param.PseudoJ2;

            choixGrille = param.ChoixGrilleRadioButton; // On va cherche la propriété qui correspond au radiobutton coché dans la page parametrage
            tableLayoutPanel1 = new TableLayoutPanel();

            Partie = new Puissance4(PremierJoueur, SecondJoueur, choixGrille, true);

            // Ajout des composants crées en attribut
            JoueurActifPhrase.Text = "Au tour de : ";
            this.Controls.Add(J1);
            this.Controls.Add(J2);
            this.Controls.Add(JActif);
            this.Controls.Add(VS);
            this.Controls.Add(JoueurActifPhrase);
            this.Controls.Add(vainqueur);

            // Placement des labels sur la page
            LabelTailleGrille.Location = new Point(600, 0);
            J1.Location = new Point(250, 0);
            VS.Location = new Point(350, 0);
            J2.Location = new Point(400, 0);
            JoueurActifPhrase.Location = new Point(500);
            JActif.Location = new Point(650, 0);
            LabelTailleGrille.Location = new Point(800, 0);
            vainqueur.Size = new Size(500, 50);

            // Indique la couleur du joueur actif
            JActif.BackColor = Color.Red;

            // On attribue la valeur entrée dans les input de la page param aux labels d'ici
            J1.Text = PremierJoueur;
            VS.Text = "VS";
            J2.Text = SecondJoueur;

            // On initialise le pseudo du J actif à J1 car c'est lui qui commence
            JActif.Text = PremierJoueur;

            // creation de la grille en fonction du choix (Grille 1  / 2 ou Aléatoire entre ces 2)
            if (choixGrille == 1)
            {
                LabelTailleGrille.Text = " Taille de la Grille : 6 x 7 ";
                initGrille1();
            }
            else
            {
                if (choixGrille == 2)
                {
                    LabelTailleGrille.Text = " Taille de la Grille : 6 x 5 ";
                    initGrille2();


                }
                else
                {
                    choixGrille = Partie.choixGrille;

                    if (choixGrille == 1)
                    {
                        LabelTailleGrille.Text = " Taille de la Grille : 6 x 7 ";
                        initGrille1();

                    }
                    else
                    {
                        LabelTailleGrille.Text = " Taille de la Grille : 6 x 5 ";
                        initGrille2();

                    }

                }



            }

            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;

            // Initialisation de la grille (tout vide) on met des labels dans chaque case
            initLabelDansGrille();
        }

        private void initLabelDansGrille()
        {
            for (int IndiceLigne = 0; IndiceLigne < nbLigne; IndiceLigne++)
            {
                for (int IndiceColonne = 0; IndiceColonne < nbColonne; IndiceColonne++)
                {
                    Label label = new Label();
                    label.Dock = DockStyle.Fill;
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    //label.AutoSize = false;
                    //label.MinimumSize = new Size(80, 40);                      // Centrage dans le label 
                    //label.MaximumSize = new Size(100, 50);

                    label.BorderStyle = BorderStyle.FixedSingle;
                    label.Margin = new Padding(5, 5, 5, 5);
                    label.Margin = new Padding(label.Margin.Left + 1, label.Margin.Top, label.Margin.Right, label.Margin.Bottom); // Epaissir les bordures des cellules

                    label.BackColor = Color.White;
                    tableLayoutPanel1.Controls.Add(label, IndiceColonne, IndiceLigne);




                }
            }


            this.Controls.Add(tableLayoutPanel1);
        }
        private void initGrille1()
        {
            nbColonne = 7;
            nbLigne = 6;


            tableLayoutPanel1.Size = new Size(1000, 500); // Définition la taille du TableLayoutPanel
            tableLayoutPanel1.BackColor = Color.DarkBlue;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;        // Initialisation du style de la grille 
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowOnly;
            tableLayoutPanel1.Location = new Point(100, 100);
            tableLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;




            Button button7 = new Button();
            this.Controls.Add(button7);
            button7.Location = new Point(980, 70);
            button7.Name = "button7";
            button7.Size = new Size(100, 29);
            button7.TabIndex = 8;                       // Mise en place du 7 éme bouton effectif que pour la grille 1
            button7.Text = "button7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += Colonne7_Click;




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
            nbColonne = 6;
            nbLigne = 5;
            tableLayoutPanel1.BackColor = Color.DarkBlue;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;        // Initialisation du style de la grille 
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ForeColor = SystemColors.Highlight;
            tableLayoutPanel1.Location = new Point(100, 100);


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

        //Placement d'un pion dans la colonne 1
        private void Colonne1_Click(object sender, EventArgs e)
        {
            Partie.Jeu(1);
            MajGrille();
            affichageGagnant();
            changerPseudoJActif();
        }


        //Placement d'un pion dans la colonne 2
        private void Colonne2_Click(object sender, EventArgs e)
        {
            Partie.Jeu(2);
            MajGrille();
            affichageGagnant();
            changerPseudoJActif();
        }
        //Placement d'un pion dans la colonne 3
        private void Colonne3_Click(object sender, EventArgs e)
        {
            Partie.Jeu(3);
            MajGrille();
            affichageGagnant();
            changerPseudoJActif();

        }
        //Placement d'un pion dans la colonne 4
        private void Colonne4_Click(object sender, EventArgs e)
        {
            Partie.Jeu(4);
            MajGrille();
            affichageGagnant();
            changerPseudoJActif();

        }
        //Placement d'un pion dans la colonne 5
        private void Colonne5_Click(object sender, EventArgs e)
        {
            Partie.Jeu(5);
            MajGrille();
            affichageGagnant();
            changerPseudoJActif();
        }
        //Placement d'un pion dans la colonne 6
        private void Colonne6_Click(object sender, EventArgs e)
        {
            Partie.Jeu(6);
            MajGrille();
            affichageGagnant();
            changerPseudoJActif();
        }


        // Placement d'un pion dans la colonne 7
        private void Colonne7_Click(object sender, EventArgs e)
        {
            Partie.Jeu(7);
            MajGrille();
            affichageGagnant();
            changerPseudoJActif();
        }

        // Fonction de Mise à jour de la grille en fonction des modifications apportées
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

        private void Partie_JVJ_Load(object sender, EventArgs e)
        {

        }
    }
}