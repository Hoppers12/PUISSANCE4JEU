using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
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
        private Puissance4 Jeu;
      

        int nbColonne;
        int nbLigne;
        
        public Partie_JVJ()
        {
            InitializeComponent();
            param = new page_param_JVJ();
            choixGrille = param.choixGrilleRadioButton; // On va cherche la propriété qui correspond au radiobutton coché dans la page parametrage
            Puissance4 Jeu = new Puissance4("Joueur 1", "Joueur 2", choixGrille, true);


            // creation de la grille en fonction du choix (Grille 1  / 2 ou Aléatoire entre ces 2)
            if (Jeu.choixGrille == 1)
            {
                initGrille1();
            }
            else
            {
                if (Jeu.choixGrille == 2)
                {
                    initGrille2();


                }else
                {
                    Random aleatoire = new Random();
                    int grilleAleatoire = aleatoire.Next(1,2);
                     
                    if (grilleAleatoire == 1)
                    {
                        initGrille1();
                    }else
                    {
                        initGrille2();
                    }

                }

            }


            
            // Initialisation de la grille (tout vide) 
            for (int IndiceLigne = 0; IndiceLigne < nbLigne; IndiceLigne++)
            {
                for (int IndiceColonne = 0; IndiceColonne < nbColonne; IndiceColonne++)
                {
                    Label label = new Label();
                    label.Text = Jeu.grille1[IndiceLigne, IndiceColonne].ToString();
                    label.Dock = DockStyle.Fill;
                    tableLayoutPanel1.Controls.Add(label, IndiceColonne, IndiceLigne);
                }
            }
            


        }

        private void initGrille1()
        {
            nbColonne = 7;
            nbLigne = 6;
            tableLayoutPanel1.BackColor = SystemColors.ActiveCaption;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;        // Initialisation du style de la grille 
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ForeColor = SystemColors.Highlight;
            tableLayoutPanel1.Location = new Point(40, 87);

            button7.Location = new Point(721, 58);
            button7.Name = "button7";
            button7.Size = new Size(100, 29);
            button7.TabIndex = 8;                       // Mise en place du 7 éme bouton effectif que pour la grille 1
            button7.Text = "button7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += Colonne7_Click;

            tableLayoutPanel1.Size = new Size(750, 350); // Définition la taille du TableLayoutPanel

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

        //Fonction qui crée la grille 2 
        private void initGrille2()
        {
            nbColonne = 6;
            nbLigne = 5;
            tableLayoutPanel1.BackColor = SystemColors.ActiveCaption;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;        // Initialisation du style de la grille 
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ForeColor = SystemColors.Highlight;
            tableLayoutPanel1.Location = new Point(50, 87);


            tableLayoutPanel1.Size = new Size(750, 350); // Définition la taille du TableLayoutPanel

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
                        tableLayoutPanel1.GetControlFromPosition(IndiceColonne, IndiceLigne).Text = Jeu.grille1[IndiceLigne, IndiceColonne].ToString();
                    }
                    else
                    {
                        if (Jeu.choixGrille == 2)
                        {
                            tableLayoutPanel1.GetControlFromPosition(IndiceColonne, IndiceLigne).Text = Jeu.grille2[IndiceLigne, IndiceColonne].ToString();
                        }
                    }

                }
            }
        }

        //Ajouter les appels de methode des verifs de victoire + de grille pleine/colonne pleine + ^passage pseudo sur l'autre page 

    }
}