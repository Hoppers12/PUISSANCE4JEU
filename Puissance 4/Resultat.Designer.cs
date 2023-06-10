namespace Puissance_4
{
    partial class frmResultat
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
            lblPseudoVainqueur = new Label();
            btnRetourAccueil = new Button();
            btnRejouer = new Button();
            btnQuitterJeu = new Button();
            SuspendLayout();
            // 
            // lblPseudoVainqueur
            // 
            lblPseudoVainqueur.AutoSize = true;
            lblPseudoVainqueur.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPseudoVainqueur.ForeColor = Color.MidnightBlue;
            lblPseudoVainqueur.Location = new Point(29, 56);
            lblPseudoVainqueur.Name = "lblPseudoVainqueur";
            lblPseudoVainqueur.Size = new Size(57, 20);
            lblPseudoVainqueur.TabIndex = 0;
            lblPseudoVainqueur.Text = "label1";
            lblPseudoVainqueur.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnRetourAccueil
            // 
            btnRetourAccueil.BackColor = Color.RoyalBlue;
            btnRetourAccueil.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRetourAccueil.ForeColor = Color.Gold;
            btnRetourAccueil.Location = new Point(90, 96);
            btnRetourAccueil.Margin = new Padding(3, 2, 3, 2);
            btnRetourAccueil.Name = "btnRetourAccueil";
            btnRetourAccueil.Size = new Size(103, 36);
            btnRetourAccueil.TabIndex = 1;
            btnRetourAccueil.Text = "ACCUEIL";
            btnRetourAccueil.UseVisualStyleBackColor = false;
            btnRetourAccueil.Click += btnRetourAccueil_Click;
            // 
            // btnRejouer
            // 
            btnRejouer.BackColor = Color.RoyalBlue;
            btnRejouer.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRejouer.ForeColor = Color.Gold;
            btnRejouer.Location = new Point(90, 148);
            btnRejouer.Margin = new Padding(3, 2, 3, 2);
            btnRejouer.Name = "btnRejouer";
            btnRejouer.Size = new Size(103, 36);
            btnRejouer.TabIndex = 2;
            btnRejouer.Text = "REJOUER";
            btnRejouer.UseVisualStyleBackColor = false;
            btnRejouer.Click += btnRejouer_Click;
            // 
            // btnQuitterJeu
            // 
            btnQuitterJeu.BackColor = Color.RoyalBlue;
            btnQuitterJeu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnQuitterJeu.ForeColor = Color.Gold;
            btnQuitterJeu.Location = new Point(90, 197);
            btnQuitterJeu.Margin = new Padding(3, 2, 3, 2);
            btnQuitterJeu.Name = "btnQuitterJeu";
            btnQuitterJeu.Size = new Size(103, 38);
            btnQuitterJeu.TabIndex = 3;
            btnQuitterJeu.Text = "QUITTER";
            btnQuitterJeu.UseVisualStyleBackColor = false;
            btnQuitterJeu.Click += btnQuitterJeu_Click;
            // 
            // frmResultat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(290, 265);
            Controls.Add(btnQuitterJeu);
            Controls.Add(btnRejouer);
            Controls.Add(btnRetourAccueil);
            Controls.Add(lblPseudoVainqueur);
            Location = new Point(800, 800);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmResultat";
            Text = "Résultat";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPseudoVainqueur;
        private Button btnRetourAccueil;
        private Button btnRejouer;
        private Button btnQuitterJeu;
    }
}