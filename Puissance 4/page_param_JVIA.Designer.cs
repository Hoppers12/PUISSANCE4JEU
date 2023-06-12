namespace Puissance_4
{
    partial class frmParamJVIA
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
            grpChoixGrille = new GroupBox();
            rdoGrilleAleatoire = new RadioButton();
            rdoGrilleMini = new RadioButton();
            rdoGrilleClassique = new RadioButton();
            lblTitre = new Label();
            lblPseudo = new Label();
            lblPseudoJ1 = new TextBox();
            btnJouer = new Button();
            btnAccueil = new Button();
            grpChoixGrille.SuspendLayout();
            SuspendLayout();
            // 
            // grpChoixGrille
            // 
            grpChoixGrille.Controls.Add(rdoGrilleAleatoire);
            grpChoixGrille.Controls.Add(rdoGrilleMini);
            grpChoixGrille.Controls.Add(rdoGrilleClassique);
            grpChoixGrille.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            grpChoixGrille.ForeColor = Color.Red;
            grpChoixGrille.Location = new Point(456, 193);
            grpChoixGrille.Margin = new Padding(3, 2, 3, 2);
            grpChoixGrille.Name = "grpChoixGrille";
            grpChoixGrille.Padding = new Padding(3, 2, 3, 2);
            grpChoixGrille.Size = new Size(372, 191);
            grpChoixGrille.TabIndex = 5;
            grpChoixGrille.TabStop = false;
            grpChoixGrille.Text = "Choix Grille";
            // 
            // rdoGrilleAleatoire
            // 
            rdoGrilleAleatoire.AutoSize = true;
            rdoGrilleAleatoire.ForeColor = Color.DarkOrange;
            rdoGrilleAleatoire.Location = new Point(107, 140);
            rdoGrilleAleatoire.Margin = new Padding(3, 2, 3, 2);
            rdoGrilleAleatoire.Name = "rdoGrilleAleatoire";
            rdoGrilleAleatoire.Size = new Size(110, 29);
            rdoGrilleAleatoire.TabIndex = 2;
            rdoGrilleAleatoire.TabStop = true;
            rdoGrilleAleatoire.Text = "Aléatoire";
            rdoGrilleAleatoire.UseVisualStyleBackColor = true;
            // 
            // rdoGrilleMini
            // 
            rdoGrilleMini.AutoSize = true;
            rdoGrilleMini.ForeColor = Color.DarkOrange;
            rdoGrilleMini.Location = new Point(107, 94);
            rdoGrilleMini.Margin = new Padding(3, 2, 3, 2);
            rdoGrilleMini.Name = "rdoGrilleMini";
            rdoGrilleMini.Size = new Size(132, 29);
            rdoGrilleMini.TabIndex = 1;
            rdoGrilleMini.TabStop = true;
            rdoGrilleMini.Text = "5 x 6 (Mini)";
            rdoGrilleMini.UseVisualStyleBackColor = true;
            // 
            // rdoGrilleClassique
            // 
            rdoGrilleClassique.AutoSize = true;
            rdoGrilleClassique.ForeColor = Color.DarkOrange;
            rdoGrilleClassique.Location = new Point(107, 47);
            rdoGrilleClassique.Margin = new Padding(3, 2, 3, 2);
            rdoGrilleClassique.Name = "rdoGrilleClassique";
            rdoGrilleClassique.Size = new Size(174, 29);
            rdoGrilleClassique.TabIndex = 0;
            rdoGrilleClassique.TabStop = true;
            rdoGrilleClassique.Text = "6 x 7 (Classique)";
            rdoGrilleClassique.UseVisualStyleBackColor = true;
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.Font = new Font("Microsoft Sans Serif", 55.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitre.ForeColor = Color.MidnightBlue;
            lblTitre.Location = new Point(99, 64);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(677, 85);
            lblTitre.TabIndex = 3;
            lblTitre.Text = "JOUEUR VS ORDI";
            // 
            // lblPseudo
            // 
            lblPseudo.AutoSize = true;
            lblPseudo.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblPseudo.ForeColor = Color.DarkOrange;
            lblPseudo.Location = new Point(49, 286);
            lblPseudo.Name = "lblPseudo";
            lblPseudo.Size = new Size(201, 25);
            lblPseudo.TabIndex = 7;
            lblPseudo.Text = "Entrez votre pseudo :";
            // 
            // lblPseudoJ1
            // 
            lblPseudoJ1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPseudoJ1.Location = new Point(267, 290);
            lblPseudoJ1.Margin = new Padding(3, 2, 3, 2);
            lblPseudoJ1.MaxLength = 10;
            lblPseudoJ1.Name = "lblPseudoJ1";
            lblPseudoJ1.Size = new Size(110, 23);
            lblPseudoJ1.TabIndex = 8;
            lblPseudoJ1.Text = "Annaïsse";
            lblPseudoJ1.TextAlign = HorizontalAlignment.Center;
            lblPseudoJ1.TextChanged += textBoxPseudo_TextChanged;
            lblPseudoJ1.KeyPress += textBoxPseudo_KeyPress;
            // 
            // btnJouer
            // 
            btnJouer.BackColor = Color.RoyalBlue;
            btnJouer.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnJouer.ForeColor = Color.Gold;
            btnJouer.Location = new Point(316, 444);
            btnJouer.Margin = new Padding(3, 2, 3, 2);
            btnJouer.Name = "btnJouer";
            btnJouer.Size = new Size(243, 58);
            btnJouer.TabIndex = 9;
            btnJouer.Text = "JOUER";
            btnJouer.UseVisualStyleBackColor = false;
            btnJouer.Click += btnJouer_Click;
            btnJouer.KeyPress += textBoxPseudo_KeyPress;
            // 
            // btnAccueil
            // 
            btnAccueil.BackColor = Color.RoyalBlue;
            btnAccueil.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAccueil.ForeColor = Color.Gold;
            btnAccueil.Location = new Point(21, 21);
            btnAccueil.Margin = new Padding(3, 2, 3, 2);
            btnAccueil.Name = "btnAccueil";
            btnAccueil.Size = new Size(95, 27);
            btnAccueil.TabIndex = 10;
            btnAccueil.Text = "ACCUEIL";
            btnAccueil.UseVisualStyleBackColor = false;
            btnAccueil.Click += btnAccueil_Click;
            // 
            // frmParamJVIA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(859, 565);
            Controls.Add(btnAccueil);
            Controls.Add(btnJouer);
            Controls.Add(lblPseudoJ1);
            Controls.Add(lblPseudo);
            Controls.Add(grpChoixGrille);
            Controls.Add(lblTitre);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Location = new Point(100, 100);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "frmParamJVIA";
            Text = "Paramétrage J vs IA";
            grpChoixGrille.ResumeLayout(false);
            grpChoixGrille.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpChoixGrille;
        private RadioButton rdoGrilleAleatoire;
        private RadioButton rdoGrilleMini;
        private RadioButton rdoGrilleClassique;
        private Label lblTitre;
        private Label lblPseudo;
        private TextBox lblPseudoJ1;
        private Button btnJouer;
        private Button btnAccueil;
    }
}