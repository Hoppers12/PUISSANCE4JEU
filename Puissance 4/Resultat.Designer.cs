﻿namespace Puissance_4
{
    partial class Resultat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelPseudoVainqueur = new Label();
            boutonRetourAccueil = new Button();
            boutonRejouer = new Button();
            boutonQuitterJeu = new Button();
            SuspendLayout();
            // 
            // labelPseudoVainqueur
            // 
            labelPseudoVainqueur.AutoSize = true;
            labelPseudoVainqueur.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelPseudoVainqueur.ForeColor = Color.MidnightBlue;
            labelPseudoVainqueur.Location = new Point(29, 56);
            labelPseudoVainqueur.Name = "labelPseudoVainqueur";
            labelPseudoVainqueur.Size = new Size(57, 20);
            labelPseudoVainqueur.TabIndex = 0;
            labelPseudoVainqueur.Text = "label1";
            labelPseudoVainqueur.TextAlign = ContentAlignment.TopCenter;
            // 
            // boutonRetourAccueil
            // 
            boutonRetourAccueil.BackColor = Color.RoyalBlue;
            boutonRetourAccueil.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            boutonRetourAccueil.ForeColor = Color.Gold;
            boutonRetourAccueil.Location = new Point(90, 96);
            boutonRetourAccueil.Margin = new Padding(3, 2, 3, 2);
            boutonRetourAccueil.Name = "boutonRetourAccueil";
            boutonRetourAccueil.Size = new Size(103, 36);
            boutonRetourAccueil.TabIndex = 1;
            boutonRetourAccueil.Text = "ACCUEIL";
            boutonRetourAccueil.UseVisualStyleBackColor = false;
            boutonRetourAccueil.Click += boutonRetourAccueil_Click;
            // 
            // boutonRejouer
            // 
            boutonRejouer.BackColor = Color.RoyalBlue;
            boutonRejouer.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            boutonRejouer.ForeColor = Color.Gold;
            boutonRejouer.Location = new Point(90, 148);
            boutonRejouer.Margin = new Padding(3, 2, 3, 2);
            boutonRejouer.Name = "boutonRejouer";
            boutonRejouer.Size = new Size(103, 36);
            boutonRejouer.TabIndex = 2;
            boutonRejouer.Text = "REJOUER";
            boutonRejouer.UseVisualStyleBackColor = false;
            boutonRejouer.Click += boutonRejouer_Click;
            // 
            // boutonQuitterJeu
            // 
            boutonQuitterJeu.BackColor = Color.RoyalBlue;
            boutonQuitterJeu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            boutonQuitterJeu.ForeColor = Color.Gold;
            boutonQuitterJeu.Location = new Point(90, 197);
            boutonQuitterJeu.Margin = new Padding(3, 2, 3, 2);
            boutonQuitterJeu.Name = "boutonQuitterJeu";
            boutonQuitterJeu.Size = new Size(103, 38);
            boutonQuitterJeu.TabIndex = 3;
            boutonQuitterJeu.Text = "QUITTER";
            boutonQuitterJeu.UseVisualStyleBackColor = false;
            boutonQuitterJeu.Click += boutonQuitterJeu_Click;
            // 
            // Resultat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(290, 265);
            Controls.Add(boutonQuitterJeu);
            Controls.Add(boutonRejouer);
            Controls.Add(boutonRetourAccueil);
            Controls.Add(labelPseudoVainqueur);
            Location = new Point(800, 800);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Resultat";
            Text = "Résultat";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPseudoVainqueur;
        private Button boutonRetourAccueil;
        private Button boutonRejouer;
        private Button boutonQuitterJeu;
    }
}