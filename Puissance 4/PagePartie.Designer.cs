
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
            grpRegles = new GroupBox();
            richTextBox1 = new RichTextBox();
            label2 = new Label();
            JActif = new Label();
            groupBoxJoueurActif = new GroupBox();
            groupBox2 = new GroupBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            J2 = new Label();
            J1 = new Label();
            grpRegles.SuspendLayout();
            groupBoxJoueurActif.SuspendLayout();
            groupBox2.SuspendLayout();
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
            // grpRegles
            // 
            grpRegles.BackColor = Color.Gold;
            grpRegles.Controls.Add(richTextBox1);
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
            groupBox2.Text = "Joueurs";
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
            // PagePartie
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(1347, 565);
            Controls.Add(groupBox2);
            Controls.Add(grpRegles);
            Controls.Add(LabelTailleGrille);
            Controls.Add(lblTypePartie);
            Controls.Add(groupBoxJoueurActif);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "PagePartie";
            Text = "Partie";
            Load += Partie_JVJ_Load;
            grpRegles.ResumeLayout(false);
            grpRegles.PerformLayout();
            groupBoxJoueurActif.ResumeLayout(false);
            groupBoxJoueurActif.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTypePartie;
        private Label LabelTailleGrille;
        private GroupBox grpRegles;
        private Label label2;
        private RichTextBox richTextBox1;
        private Label JActif;
        private GroupBox groupBoxJoueurActif;
        private GroupBox groupBox2;
        private Label J1;
        private Label J2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }

}