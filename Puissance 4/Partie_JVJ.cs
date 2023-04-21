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
        private page_param_JVJ param;
        private int choixGrille;
        public Puissance4 Jeu;
        public TableLayoutPanel tableLayoutPanel1;


        int nbColonne;
        int nbLigne;

        public Partie_JVJ(page_param_JVJ param)
        {
            InitializeComponent();
            choixGrille = param.choixGrilleRadioButton; // On va cherche la propriété qui correspond au radiobutton coché dans la page parametrage
            tableLayoutPanel1 = new TableLayoutPanel();
            Jeu = new Puissance4("Joueur 1", "Joueur 2", choixGrille, true);


            // creation de la grille en fonction du choix (Grille 1  / 2 ou Aléatoire entre ces 2)
            if (Jeu.choixGrille == 1)
            {
                LabelTailleGrille.Text = " Taille de la Grille : 6 x 7 ";
                initGrille1();
            }
            else
            {
                if (Jeu.choixGrille == 2)
                {
                    LabelTailleGrille.Text = " Taille de la Grille : 6 x 5 ";
                    initGrille2();


                }
                else
                {
                    Random aleatoire = new Random();
                    int grilleAleatoire = aleatoire.Next(1, 2);

                    if (grilleAleatoire == 1)
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

                    /* AMELIORER CA CAR MOCHE
                    // Set the corner radius (in pixels)
                    int cornerRadius = 10;

                    // Create a graphics path for the label
                    GraphicsPath path = new GraphicsPath();
                    path.StartFigure();
                    path.AddArc(0, 0, cornerRadius * 2, cornerRadius * 2, 180, 90);
                    path.AddLine(cornerRadius, 0, label1.Width - cornerRadius * 2, 0);
                    path.AddArc(label1.Width - cornerRadius * 2, 0, cornerRadius * 2, cornerRadius * 2, 270, 90);
                    path.AddLine(label1.Width, cornerRadius * 2, label1.Width, label1.Height - cornerRadius * 2);
                    path.AddArc(label1.Width - cornerRadius * 2, label1.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 0, 90);
                    path.AddLine(label1.Width - cornerRadius * 2, label1.Height, cornerRadius * 2, label1.Height);
                    path.AddArc(0, label1.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 90, 90);
                    path.CloseFigure();

                    // Set the region of the label to the graphics path
                    label.Region = new Region(path);
          

                    */

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
            button7.Location = new Point(721, 58);
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



        //Placement d'un pion dans la colonne 1
        private void Colonne1_Click(object sender, EventArgs e)
        {
            Jeu.JouerTour(1);
            MajGrille();
        }
        //Placement d'un pion dans la colonne 2
        private void Colonne2_Click(object sender, EventArgs e)
        {
            Jeu.JouerTour(2);
            MajGrille();
        }
        //Placement d'un pion dans la colonne 3
        private void Colonne3_Click(object sender, EventArgs e)
        {
            Jeu.JouerTour(3);
            MajGrille();
        }
        //Placement d'un pion dans la colonne 4
        private void Colonne4_Click(object sender, EventArgs e)
        {
            Jeu.JouerTour(4);
            MajGrille();
        }
        //Placement d'un pion dans la colonne 5
        private void Colonne5_Click(object sender, EventArgs e)
        {
            Jeu.JouerTour(5);
            MajGrille();
        }
        //Placement d'un pion dans la colonne 6
        private void Colonne6_Click(object sender, EventArgs e)
        {
            Jeu.JouerTour(6);
            MajGrille();
        }

        // Placement d'un pion dans la colonne 7
        private void Colonne7_Click(object sender, EventArgs e)
        {
            Jeu.JouerTour(7);
            MajGrille();
        }

        // Fonction de Mise à jour de la grille en fonction des modifications apportées
        private void MajGrille()

        {

            for (int IndiceLigne = 0; IndiceLigne < nbLigne; IndiceLigne++)
            {
                for (int IndiceColonne = 0; IndiceColonne < nbColonne; IndiceColonne++)
                {
                    // Modification de la la cellule en fonction de la nouvelle grille modifiée
                    if (Jeu.choixGrille == 1)
                    {
                        // On colorie les cases en fonction du numéro qu'il y a dans la case de la matrice du jeu ( 0 -> blanc(vide) ; 1 -> Rouge (J1) ; 2 -> Jaune (J2)
                        if (Jeu.grille1[IndiceLigne, IndiceColonne] == 1)
                        {
                            tableLayoutPanel1.GetControlFromPosition(IndiceColonne, IndiceLigne).BackColor = Color.Red;
                        }else
                        {
                            if (Jeu.grille1[IndiceLigne, IndiceColonne] == 2)
                            {
                                tableLayoutPanel1.GetControlFromPosition(IndiceColonne, IndiceLigne).BackColor = Color.Yellow;
                            }else
                            {
                                tableLayoutPanel1.GetControlFromPosition(IndiceColonne, IndiceLigne).BackColor = Color.White;
                            }
                        }
                        
                    }
                    else
                    {
                        if (Jeu.choixGrille == 2)
                        {
                            if (Jeu.grille2[IndiceLigne, IndiceColonne] == 1)
                            {
                                tableLayoutPanel1.GetControlFromPosition(IndiceColonne, IndiceLigne).BackColor = Color.Red;
                            }else
                            {
                                if (Jeu.grille2[IndiceLigne, IndiceColonne] == 2)
                                {
                                    tableLayoutPanel1.GetControlFromPosition(IndiceColonne, IndiceLigne).BackColor = Color.Yellow;
                                }else
                                {
                                    tableLayoutPanel1.GetControlFromPosition(IndiceColonne, IndiceLigne).BackColor = Color.White;
                                }
                            }
                            
                        }
                    }

                }
            }
        }

        //Ajouter les appels de methode des verifs de victoire + de grille pleine/colonne pleine + ^passage pseudo sur l'autre page + faire J V IA 

    }
}