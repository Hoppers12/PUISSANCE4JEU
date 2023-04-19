using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Puissance_4;

using static Program;

namespace Puissance_4
{



    public partial class Partie_JVJ : Form
    {

        Puissance4 Jeu = new Puissance4("Joueur 1", "Joueur 2", 1, true);
        int nbColonne = 7;
        int nbLigne = 6;
        public Partie_JVJ()
        {
            InitializeComponent();

            // Initialisation de la grille (tout vide) 
            for (int IndiceLigne = 0; IndiceLigne < nbLigne; IndiceLigne++)
            {
                for (int IndiceColonne = 0; IndiceColonne < nbColonne; IndiceColonne++)
                {
                    Label label = new Label();
                    label.Text = Jeu.grille1[IndiceLigne, IndiceColonne].ToString();
                    tableLayoutPanel1.Controls.Add(label, IndiceColonne, IndiceLigne);
                }
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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
            Jeu.JouerTour(5);
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
                    tableLayoutPanel1.GetControlFromPosition(IndiceColonne, IndiceLigne).Text = Jeu.grille1[IndiceLigne, IndiceColonne].ToString();
                }
            }
        }

        //Ajouter les appels de methode des verifs de victoire + de grille pleine/colonne pleine

    }
}