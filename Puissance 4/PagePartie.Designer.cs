
using System;
namespace Puissance_4
{

    partial class frmPagePartie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPagePartie));
            lblTypePartie = new Label();
            lblTailleGrille = new Label();
            grpRegles = new GroupBox();
            txtRegles = new TextBox();
            label2 = new Label();
            lblJActif = new Label();
            grpJoueurActif = new GroupBox();
            grpJoueurs = new GroupBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            lblPseudoJ2 = new Label();
            lblPseudoJ1 = new Label();
            grpRegles.SuspendLayout();
            grpJoueurActif.SuspendLayout();
            grpJoueurs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTypePartie
            // 
            lblTypePartie.AutoSize = true;
            lblTypePartie.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblTypePartie.Location = new Point(35, 30);
            lblTypePartie.Name = "lblTypePartie";
            lblTypePartie.Size = new Size(87, 32);
            lblTypePartie.TabIndex = 0;
            lblTypePartie.Text = "(Partie)";
            // 
            // lblTailleGrille
            // 
            lblTailleGrille.AutoSize = true;
            lblTailleGrille.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblTailleGrille.Location = new Point(725, 30);
            lblTailleGrille.Name = "lblTailleGrille";
            lblTailleGrille.Size = new Size(170, 28);
            lblTailleGrille.TabIndex = 9;
            lblTailleGrille.Text = "(taille de la grille)";
            // 
            // grpRegles
            // 
            grpRegles.BackColor = Color.Gold;
            grpRegles.Controls.Add(txtRegles);
            grpRegles.Controls.Add(label2);
            grpRegles.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            grpRegles.Location = new Point(35, 106);
            grpRegles.Margin = new Padding(3, 2, 3, 2);
            grpRegles.Name = "grpRegles";
            grpRegles.Padding = new Padding(3, 2, 3, 2);
            grpRegles.Size = new Size(246, 242);
            grpRegles.TabIndex = 10;
            grpRegles.TabStop = false;
            grpRegles.Text = "Règles du jeu";
            // 
            // txtRegles
            // 
            txtRegles.BackColor = Color.Gold;
            txtRegles.BorderStyle = BorderStyle.None;
            txtRegles.Enabled = false;
            txtRegles.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtRegles.Location = new Point(24, 32);
            txtRegles.Multiline = true;
            txtRegles.Name = "txtRegles";
            txtRegles.Size = new Size(191, 193);
            txtRegles.TabIndex = 15;
            txtRegles.Text = "Placez un pion en appuyant sur la colonne ou les flèches lorsque votre pseudo est affiché. Le premier joueur à aligner 4 pions de sa couleur gagne la partie !";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 28);
            label2.Name = "label2";
            label2.Size = new Size(0, 28);
            label2.TabIndex = 0;
            // 
            // lblJActif
            // 
            lblJActif.AutoSize = true;
            lblJActif.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblJActif.Location = new Point(33, 35);
            lblJActif.Name = "lblJActif";
            lblJActif.Size = new Size(102, 21);
            lblJActif.TabIndex = 11;
            lblJActif.Text = "(Joueur Actif)";
            // 
            // grpJoueurActif
            // 
            grpJoueurActif.Controls.Add(lblJActif);
            grpJoueurActif.Location = new Point(1242, 383);
            grpJoueurActif.Margin = new Padding(3, 2, 3, 2);
            grpJoueurActif.Name = "grpJoueurActif";
            grpJoueurActif.Padding = new Padding(3, 2, 3, 2);
            grpJoueurActif.Size = new Size(131, 82);
            grpJoueurActif.TabIndex = 13;
            grpJoueurActif.TabStop = false;
            grpJoueurActif.Text = "Au tour de :";
            // 
            // grpJoueurs
            // 
            grpJoueurs.Controls.Add(pictureBox2);
            grpJoueurs.Controls.Add(pictureBox1);
            grpJoueurs.Controls.Add(lblPseudoJ2);
            grpJoueurs.Controls.Add(lblPseudoJ1);
            grpJoueurs.Location = new Point(52, 372);
            grpJoueurs.Margin = new Padding(3, 2, 3, 2);
            grpJoueurs.Name = "grpJoueurs";
            grpJoueurs.Padding = new Padding(3, 2, 3, 2);
            grpJoueurs.Size = new Size(219, 94);
            grpJoueurs.TabIndex = 14;
            grpJoueurs.TabStop = false;
            grpJoueurs.Text = "Joueurs";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(49, 56);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(35, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(49, 17);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // lblPseudoJ2
            // 
            lblPseudoJ2.AutoSize = true;
            lblPseudoJ2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblPseudoJ2.Location = new Point(116, 56);
            lblPseudoJ2.Name = "lblPseudoJ2";
            lblPseudoJ2.Size = new Size(103, 25);
            lblPseudoJ2.TabIndex = 1;
            lblPseudoJ2.Text = "(pseudo J2)";
            // 
            // lblPseudoJ1
            // 
            lblPseudoJ1.AutoSize = true;
            lblPseudoJ1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblPseudoJ1.Location = new Point(116, 20);
            lblPseudoJ1.Name = "lblPseudoJ1";
            lblPseudoJ1.Size = new Size(103, 25);
            lblPseudoJ1.TabIndex = 0;
            lblPseudoJ1.Text = "(pseudo J1)";
            // 
            // frmPagePartie
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(1347, 565);
            Controls.Add(grpJoueurs);
            Controls.Add(grpRegles);
            Controls.Add(lblTailleGrille);
            Controls.Add(lblTypePartie);
            Controls.Add(grpJoueurActif);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "frmPagePartie";
            Text = "Partie";
            FormClosing += PagePartie_FormClosing;
            Load += Partie_JVJ_Load;
            grpRegles.ResumeLayout(false);
            grpRegles.PerformLayout();
            grpJoueurActif.ResumeLayout(false);
            grpJoueurActif.PerformLayout();
            grpJoueurs.ResumeLayout(false);
            grpJoueurs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTypePartie;
        private Label lblTailleGrille;
        private GroupBox grpRegles;
        private Label label2;
        private GroupBox grpJoueurActif;
        private GroupBox grpJoueurs;
        private Label lblPseudoJ2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private TextBox txtRegles;
        internal Label lblJActif;
        internal Label lblPseudoJ1;
    }

}