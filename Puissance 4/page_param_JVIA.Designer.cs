﻿namespace Puissance_4
{
    partial class page_param_JVIA
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
            groupBox2 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label1 = new Label();
            label3 = new Label();
            pseudoJ1 = new TextBox();
            boutonJouer = new Button();
            button_accueil = new Button();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton3);
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Controls.Add(radioButton1);
            groupBox2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.Red;
            groupBox2.Location = new Point(456, 193);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(372, 191);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Choix Grille";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.ForeColor = Color.DarkOrange;
            radioButton3.Location = new Point(107, 140);
            radioButton3.Margin = new Padding(3, 2, 3, 2);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(110, 29);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Aléatoire";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.ForeColor = Color.DarkOrange;
            radioButton2.Location = new Point(107, 94);
            radioButton2.Margin = new Padding(3, 2, 3, 2);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(132, 29);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "5 x 6 (Mini)";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.ForeColor = Color.DarkOrange;
            radioButton1.Location = new Point(107, 47);
            radioButton1.Margin = new Padding(3, 2, 3, 2);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(174, 29);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "6 x 7 (Classique)";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 55.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(49, 64);
            label1.Name = "label1";
            label1.Size = new Size(677, 85);
            label1.TabIndex = 3;
            label1.Text = "JOUEUR VS ORDI";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkOrange;
            label3.Location = new Point(30, 293);
            label3.Name = "label3";
            label3.Size = new Size(201, 25);
            label3.TabIndex = 7;
            label3.Text = "Entrez votre pseudo :";
            // 
            // pseudoJ1
            // 
            pseudoJ1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            pseudoJ1.Location = new Point(269, 298);
            pseudoJ1.Margin = new Padding(3, 2, 3, 2);
            pseudoJ1.MaxLength = 10;
            pseudoJ1.Name = "pseudoJ1";
            pseudoJ1.Size = new Size(110, 23);
            pseudoJ1.TabIndex = 8;
            pseudoJ1.Text = "Annaïsse";
            pseudoJ1.TextAlign = HorizontalAlignment.Center;
            pseudoJ1.TextChanged += textBoxPseudo_TextChanged;
            pseudoJ1.KeyPress += textBoxPseudo_KeyPress;
            // 
            // boutonJouer
            // 
            boutonJouer.BackColor = Color.RoyalBlue;
            boutonJouer.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            boutonJouer.ForeColor = Color.Gold;
            boutonJouer.Location = new Point(305, 444);
            boutonJouer.Margin = new Padding(3, 2, 3, 2);
            boutonJouer.Name = "boutonJouer";
            boutonJouer.Size = new Size(243, 58);
            boutonJouer.TabIndex = 9;
            boutonJouer.Text = "JOUER";
            boutonJouer.UseVisualStyleBackColor = false;
            boutonJouer.Click += boutonJouer_Click;
            boutonJouer.KeyPress += textBoxPseudo_KeyPress;
            // 
            // button_accueil
            // 
            button_accueil.BackColor = Color.RoyalBlue;
            button_accueil.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_accueil.ForeColor = Color.Gold;
            button_accueil.Location = new Point(10, 9);
            button_accueil.Margin = new Padding(3, 2, 3, 2);
            button_accueil.Name = "button_accueil";
            button_accueil.Size = new Size(95, 27);
            button_accueil.TabIndex = 10;
            button_accueil.Text = "ACCUEIL";
            button_accueil.UseVisualStyleBackColor = false;
            button_accueil.Click += button_accueil_Click;
            // 
            // page_param_JVIA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(859, 565);
            Controls.Add(button_accueil);
            Controls.Add(boutonJouer);
            Controls.Add(pseudoJ1);
            Controls.Add(label3);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Location = new Point(100, 100);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "page_param_JVIA";
            Text = "Paramétrage J vs IA";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox2;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label1;
        private Label label3;
        private TextBox pseudoJ1;
        private Button boutonJouer;
        private Button button_accueil;
    }
}