
using System;
namespace Puissance_4
{

    partial class PagePartie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PagePartie));
            lblTypePartie = new Label();
            LabelTailleGrille = new Label();
            groupBox1 = new GroupBox();
            richTextBox1 = new RichTextBox();
            label2 = new Label();
            JActif = new Label();
            groupBoxJoueurActif = new GroupBox();
            groupBox2 = new GroupBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            J2 = new Label();
            J1 = new Label();
            flecheColonne1 = new PictureBox();
            flecheColonne2 = new PictureBox();
            flecheColonne3 = new PictureBox();
            flecheColonne4 = new PictureBox();
            flecheColonne5 = new PictureBox();
            flecheColonne6 = new PictureBox();
            flecheColonne7 = new PictureBox();
            groupBox1.SuspendLayout();
            groupBoxJoueurActif.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)flecheColonne1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)flecheColonne2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)flecheColonne3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)flecheColonne4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)flecheColonne5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)flecheColonne6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)flecheColonne7).BeginInit();
            SuspendLayout();
            // 
            // lblTypePartie
            // 
            lblTypePartie.AutoSize = true;
            lblTypePartie.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblTypePartie.Location = new Point(10, 15);
            lblTypePartie.Name = "lblTypePartie";
            lblTypePartie.Size = new Size(87, 32);
            lblTypePartie.TabIndex = 0;
            lblTypePartie.Text = "(Partie)";
            // 
            // LabelTailleGrille
            // 
            LabelTailleGrille.AutoSize = true;
            LabelTailleGrille.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            LabelTailleGrille.Location = new Point(725, 30);
            LabelTailleGrille.Name = "LabelTailleGrille";
            LabelTailleGrille.Size = new Size(66, 28);
            LabelTailleGrille.TabIndex = 9;
            LabelTailleGrille.Text = "label2";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Gold;
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(35, 106);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(246, 242);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Règles du jeu";
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.Gold;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(31, 40);
            richTextBox1.Margin = new Padding(3, 2, 3, 2);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(187, 221);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "Placez un pion lorsque votre pseudo est colorée. Le premier joueur a aligner 4 pions de sa couleur gagne la partie !";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 28);
            label2.Name = "label2";
            label2.Size = new Size(0, 28);
            label2.TabIndex = 0;
            // 
            // JActif
            // 
            JActif.AutoSize = true;
            JActif.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            JActif.Location = new Point(33, 35);
            JActif.Name = "JActif";
            JActif.Size = new Size(52, 21);
            JActif.TabIndex = 11;
            JActif.Text = "label3";
            // 
            // groupBoxJoueurActif
            // 
            groupBoxJoueurActif.Controls.Add(JActif);
            groupBoxJoueurActif.Location = new Point(1242, 383);
            groupBoxJoueurActif.Margin = new Padding(3, 2, 3, 2);
            groupBoxJoueurActif.Name = "groupBoxJoueurActif";
            groupBoxJoueurActif.Padding = new Padding(3, 2, 3, 2);
            groupBoxJoueurActif.Size = new Size(131, 82);
            groupBoxJoueurActif.TabIndex = 13;
            groupBoxJoueurActif.TabStop = false;
            groupBoxJoueurActif.Text = "Au tour de :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pictureBox2);
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Controls.Add(J2);
            groupBox2.Controls.Add(J1);
            groupBox2.Location = new Point(52, 372);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(219, 94);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
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
            // J2
            // 
            J2.AutoSize = true;
            J2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            J2.Location = new Point(116, 54);
            J2.Name = "J2";
            J2.Size = new Size(65, 28);
            J2.TabIndex = 1;
            J2.Text = "label4";
            // 
            // J1
            // 
            J1.AutoSize = true;
            J1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            J1.Location = new Point(116, 20);
            J1.Name = "J1";
            J1.Size = new Size(65, 28);
            J1.TabIndex = 0;
            J1.Text = "label3";
            // 
            // flecheColonne1
            // 
            flecheColonne1.Image = (Image)resources.GetObject("flecheColonne1.Image");
            flecheColonne1.Location = new Point(396, 60);
            flecheColonne1.Margin = new Padding(3, 2, 3, 2);
            flecheColonne1.Name = "flecheColonne1";
            flecheColonne1.Size = new Size(66, 36);
            flecheColonne1.SizeMode = PictureBoxSizeMode.Zoom;
            flecheColonne1.TabIndex = 16;
            flecheColonne1.TabStop = false;
            flecheColonne1.Click += Colonne_Click;
            // 
            // flecheColonne2
            // 
            flecheColonne2.Image = (Image)resources.GetObject("flecheColonne2.Image");
            flecheColonne2.Location = new Point(505, 60);
            flecheColonne2.Margin = new Padding(3, 2, 3, 2);
            flecheColonne2.Name = "flecheColonne2";
            flecheColonne2.Size = new Size(66, 36);
            flecheColonne2.SizeMode = PictureBoxSizeMode.Zoom;
            flecheColonne2.TabIndex = 17;
            flecheColonne2.TabStop = false;
            flecheColonne2.Click += Colonne_Click;
            // 
            // flecheColonne3
            // 
            flecheColonne3.Image = (Image)resources.GetObject("flecheColonne3.Image");
            flecheColonne3.Location = new Point(622, 60);
            flecheColonne3.Margin = new Padding(3, 2, 3, 2);
            flecheColonne3.Name = "flecheColonne3";
            flecheColonne3.Size = new Size(66, 36);
            flecheColonne3.SizeMode = PictureBoxSizeMode.Zoom;
            flecheColonne3.TabIndex = 18;
            flecheColonne3.TabStop = false;
            flecheColonne3.Click += Colonne_Click;
            // 
            // flecheColonne4
            // 
            flecheColonne4.Image = (Image)resources.GetObject("flecheColonne4.Image");
            flecheColonne4.Location = new Point(746, 60);
            flecheColonne4.Margin = new Padding(3, 2, 3, 2);
            flecheColonne4.Name = "flecheColonne4";
            flecheColonne4.Size = new Size(66, 36);
            flecheColonne4.SizeMode = PictureBoxSizeMode.Zoom;
            flecheColonne4.TabIndex = 19;
            flecheColonne4.TabStop = false;
            flecheColonne4.Click += Colonne_Click;
            // 
            // flecheColonne5
            // 
            flecheColonne5.Image = (Image)resources.GetObject("flecheColonne5.Image");
            flecheColonne5.Location = new Point(873, 60);
            flecheColonne5.Margin = new Padding(3, 2, 3, 2);
            flecheColonne5.Name = "flecheColonne5";
            flecheColonne5.Size = new Size(66, 36);
            flecheColonne5.SizeMode = PictureBoxSizeMode.Zoom;
            flecheColonne5.TabIndex = 20;
            flecheColonne5.TabStop = false;
            flecheColonne5.Click += Colonne_Click;
            // 
            // flecheColonne6
            // 
            flecheColonne6.Image = (Image)resources.GetObject("flecheColonne6.Image");
            flecheColonne6.Location = new Point(998, 60);
            flecheColonne6.Margin = new Padding(3, 2, 3, 2);
            flecheColonne6.Name = "flecheColonne6";
            flecheColonne6.Size = new Size(66, 36);
            flecheColonne6.SizeMode = PictureBoxSizeMode.Zoom;
            flecheColonne6.TabIndex = 21;
            flecheColonne6.TabStop = false;
            flecheColonne6.Click += Colonne_Click;
            // 
            // flecheColonne7
            // 
            flecheColonne7.Image = (Image)resources.GetObject("flecheColonne7.Image");
            flecheColonne7.Location = new Point(1129, 60);
            flecheColonne7.Margin = new Padding(3, 2, 3, 2);
            flecheColonne7.Name = "flecheColonne7";
            flecheColonne7.Size = new Size(66, 36);
            flecheColonne7.SizeMode = PictureBoxSizeMode.Zoom;
            flecheColonne7.TabIndex = 22;
            flecheColonne7.TabStop = false;
            flecheColonne7.Click += Colonne_Click;
            // 
            // PagePartie
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(1384, 565);
            Controls.Add(flecheColonne7);
            Controls.Add(flecheColonne6);
            Controls.Add(flecheColonne5);
            Controls.Add(flecheColonne4);
            Controls.Add(flecheColonne3);
            Controls.Add(flecheColonne2);
            Controls.Add(flecheColonne1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(LabelTailleGrille);
            Controls.Add(lblTypePartie);
            Controls.Add(groupBoxJoueurActif);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "PagePartie";
            Text = "Partie";
            Load += Partie_JVJ_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBoxJoueurActif.ResumeLayout(false);
            groupBoxJoueurActif.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)flecheColonne1).EndInit();
            ((System.ComponentModel.ISupportInitialize)flecheColonne2).EndInit();
            ((System.ComponentModel.ISupportInitialize)flecheColonne3).EndInit();
            ((System.ComponentModel.ISupportInitialize)flecheColonne4).EndInit();
            ((System.ComponentModel.ISupportInitialize)flecheColonne5).EndInit();
            ((System.ComponentModel.ISupportInitialize)flecheColonne6).EndInit();
            ((System.ComponentModel.ISupportInitialize)flecheColonne7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTypePartie;
        private Label LabelTailleGrille;
        private GroupBox groupBox1;
        private Label label2;
        private RichTextBox richTextBox1;
        private Label JActif;
        private GroupBox groupBoxJoueurActif;
        private GroupBox groupBox2;
        private Label J1;
        private Label J2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox flecheColonne1;
        private PictureBox flecheColonne2;
        private PictureBox flecheColonne3;
        private PictureBox flecheColonne4;
        private PictureBox flecheColonne5;
        private PictureBox flecheColonne6;
        private PictureBox flecheColonne7;
    }

}