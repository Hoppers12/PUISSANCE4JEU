namespace Puissance_4
{
    partial class frmParamJVJ
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
            lblTitre = new Label();
            grpChoixPseudo = new GroupBox();
            txtPseudoJ2 = new TextBox();
            txtPseudoJ1 = new TextBox();
            lblJ2 = new Label();
            lblJ1 = new Label();
            grpChoixGrille = new GroupBox();
            rdoGrilleAleatoire = new RadioButton();
            rdoGrilleMini = new RadioButton();
            rdoGrilleClassique = new RadioButton();
            btnJouer = new Button();
            btnAccueil = new Button();
            grpChoixPseudo.SuspendLayout();
            grpChoixGrille.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.Font = new Font("Microsoft Sans Serif", 49.8000031F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitre.ForeColor = Color.MidnightBlue;
            lblTitre.Location = new Point(75, 64);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(724, 76);
            lblTitre.TabIndex = 0;
            lblTitre.Text = "JOUEUR VS JOUEUR";
            // 
            // grpChoixPseudo
            // 
            grpChoixPseudo.Controls.Add(txtPseudoJ2);
            grpChoixPseudo.Controls.Add(txtPseudoJ1);
            grpChoixPseudo.Controls.Add(lblJ2);
            grpChoixPseudo.Controls.Add(lblJ1);
            grpChoixPseudo.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            grpChoixPseudo.ForeColor = Color.Red;
            grpChoixPseudo.Location = new Point(75, 193);
            grpChoixPseudo.Margin = new Padding(3, 2, 3, 2);
            grpChoixPseudo.Name = "grpChoixPseudo";
            grpChoixPseudo.Padding = new Padding(3, 2, 3, 2);
            grpChoixPseudo.Size = new Size(343, 191);
            grpChoixPseudo.TabIndex = 1;
            grpChoixPseudo.TabStop = false;
            grpChoixPseudo.Text = "Choix Pseudos";
            // 
            // txtPseudoJ2
            // 
            txtPseudoJ2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtPseudoJ2.Location = new Point(164, 118);
            txtPseudoJ2.Margin = new Padding(3, 2, 3, 2);
            txtPseudoJ2.MaxLength = 10;
            txtPseudoJ2.Name = "txtPseudoJ2";
            txtPseudoJ2.Size = new Size(110, 23);
            txtPseudoJ2.TabIndex = 3;
            txtPseudoJ2.Text = "Luffy";
            txtPseudoJ2.TextAlign = HorizontalAlignment.Center;
            txtPseudoJ2.TextChanged += textBoxPseudo_TextChanged;
            txtPseudoJ2.KeyPress += textBoxPseudo_KeyPress;
            // 
            // txtPseudoJ1
            // 
            txtPseudoJ1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtPseudoJ1.Location = new Point(164, 51);
            txtPseudoJ1.Margin = new Padding(3, 2, 3, 2);
            txtPseudoJ1.MaxLength = 10;
            txtPseudoJ1.Name = "txtPseudoJ1";
            txtPseudoJ1.Size = new Size(110, 23);
            txtPseudoJ1.TabIndex = 2;
            txtPseudoJ1.Text = "Naruto";
            txtPseudoJ1.TextAlign = HorizontalAlignment.Center;
            txtPseudoJ1.TextChanged += textBoxPseudo_TextChanged;
            txtPseudoJ1.KeyPress += textBoxPseudo_KeyPress;
            // 
            // lblJ2
            // 
            lblJ2.AutoSize = true;
            lblJ2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblJ2.ForeColor = Color.DarkOrange;
            lblJ2.Location = new Point(36, 114);
            lblJ2.Name = "lblJ2";
            lblJ2.Size = new Size(100, 25);
            lblJ2.TabIndex = 1;
            lblJ2.Text = "Joueur 2 :";
            // 
            // lblJ1
            // 
            lblJ1.AutoSize = true;
            lblJ1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblJ1.ForeColor = Color.DarkOrange;
            lblJ1.Location = new Point(36, 48);
            lblJ1.Name = "lblJ1";
            lblJ1.Size = new Size(100, 25);
            lblJ1.TabIndex = 0;
            lblJ1.Text = "Joueur 1 :";
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
            grpChoixGrille.Size = new Size(343, 191);
            grpChoixGrille.TabIndex = 2;
            grpChoixGrille.TabStop = false;
            grpChoixGrille.Text = "Choix Grille";
            // 
            // rdoGrilleAleatoire
            // 
            rdoGrilleAleatoire.AutoSize = true;
            rdoGrilleAleatoire.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            rdoGrilleAleatoire.ForeColor = Color.DarkOrange;
            rdoGrilleAleatoire.Location = new Point(51, 139);
            rdoGrilleAleatoire.Margin = new Padding(3, 2, 3, 2);
            rdoGrilleAleatoire.Name = "rdoGrilleAleatoire";
            rdoGrilleAleatoire.Size = new Size(111, 28);
            rdoGrilleAleatoire.TabIndex = 2;
            rdoGrilleAleatoire.Text = "Aléatoire";
            rdoGrilleAleatoire.UseVisualStyleBackColor = true;
            // 
            // rdoGrilleMini
            // 
            rdoGrilleMini.AutoSize = true;
            rdoGrilleMini.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            rdoGrilleMini.ForeColor = Color.DarkOrange;
            rdoGrilleMini.Location = new Point(51, 89);
            rdoGrilleMini.Margin = new Padding(3, 2, 3, 2);
            rdoGrilleMini.Name = "rdoGrilleMini";
            rdoGrilleMini.Size = new Size(132, 29);
            rdoGrilleMini.TabIndex = 1;
            rdoGrilleMini.Text = "5 x 6 (Mini)";
            rdoGrilleMini.UseVisualStyleBackColor = true;
            // 
            // rdoGrilleClassique
            // 
            rdoGrilleClassique.AutoSize = true;
            rdoGrilleClassique.Checked = true;
            rdoGrilleClassique.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            rdoGrilleClassique.ForeColor = Color.DarkOrange;
            rdoGrilleClassique.Location = new Point(51, 41);
            rdoGrilleClassique.Margin = new Padding(3, 2, 3, 2);
            rdoGrilleClassique.Name = "rdoGrilleClassique";
            rdoGrilleClassique.Size = new Size(174, 29);
            rdoGrilleClassique.TabIndex = 0;
            rdoGrilleClassique.TabStop = true;
            rdoGrilleClassique.Text = "6 x 7 (Classique)";
            rdoGrilleClassique.UseVisualStyleBackColor = true;
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
            btnJouer.TabIndex = 10;
            btnJouer.Text = "JOUER";
            btnJouer.UseVisualStyleBackColor = false;
            btnJouer.Click += btnJouer_Click;
            // 
            // btnAccueil
            // 
            btnAccueil.BackColor = Color.RoyalBlue;
            btnAccueil.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAccueil.ForeColor = Color.Gold;
            btnAccueil.Location = new Point(21, 21);
            btnAccueil.Margin = new Padding(3, 2, 3, 2);
            btnAccueil.Name = "btnAccueil";
            btnAccueil.Size = new Size(88, 26);
            btnAccueil.TabIndex = 11;
            btnAccueil.Text = "ACCUEIL";
            btnAccueil.UseVisualStyleBackColor = false;
            btnAccueil.Click += btnAccueil_Click;
            // 
            // frmParamJVJ
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(859, 565);
            Controls.Add(btnAccueil);
            Controls.Add(btnJouer);
            Controls.Add(grpChoixGrille);
            Controls.Add(grpChoixPseudo);
            Controls.Add(lblTitre);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Location = new Point(100, 100);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "frmParamJVJ";
            Text = "Paramétrage J vs J";
            grpChoixPseudo.ResumeLayout(false);
            grpChoixPseudo.PerformLayout();
            grpChoixGrille.ResumeLayout(false);
            grpChoixGrille.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitre;
        private GroupBox grpChoixPseudo;
        private TextBox txtPseudoJ2;
        private TextBox txtPseudoJ1;
        private Label lblJ2;
        private Label lblJ1;
        private GroupBox grpChoixGrille;
        private RadioButton rdoGrilleAleatoire;
        private RadioButton rdoGrilleMini;
        private RadioButton rdoGrilleClassique;
        private Button btnJouer;
        private Button btnAccueil;
    }
}