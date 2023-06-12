namespace Puissance_4
{
    partial class frmAccueil
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccueil));
            btnJvj = new Button();
            btnJvia = new Button();
            lblTitre = new Label();
            picInfoJVJ = new PictureBox();
            picInfoJVIA = new PictureBox();
            picGrilleDeco = new PictureBox();
            lblPuissance4 = new Label();
            picDeco1 = new PictureBox();
            picDeco2 = new PictureBox();
            lblCreateurs = new Label();
            ((System.ComponentModel.ISupportInitialize)picInfoJVJ).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picInfoJVIA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picGrilleDeco).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picDeco1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picDeco2).BeginInit();
            SuspendLayout();
            // 
            // btnJvj
            // 
            btnJvj.AccessibleRole = AccessibleRole.None;
            btnJvj.BackColor = Color.RoyalBlue;
            btnJvj.Font = new Font("Segoe UI Black", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnJvj.ForeColor = Color.Yellow;
            btnJvj.Location = new Point(315, 313);
            btnJvj.Margin = new Padding(3, 2, 3, 2);
            btnJvj.Name = "btnJvj";
            btnJvj.Size = new Size(244, 58);
            btnJvj.TabIndex = 1;
            btnJvj.Text = " Joueur VS Joueur ";
            btnJvj.UseVisualStyleBackColor = false;
            btnJvj.Click += btnModeJeu_Click;
            btnJvj.MouseEnter += bouton_Enter;
            btnJvj.MouseLeave += bouton_Leave;
            // 
            // btnJvia
            // 
            btnJvia.BackColor = Color.RoyalBlue;
            btnJvia.Font = new Font("Segoe UI Black", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnJvia.ForeColor = Color.Yellow;
            btnJvia.Location = new Point(315, 390);
            btnJvia.Margin = new Padding(3, 2, 3, 2);
            btnJvia.Name = "btnJvia";
            btnJvia.Size = new Size(244, 58);
            btnJvia.TabIndex = 2;
            btnJvia.Text = " Joueur VS Ordi";
            btnJvia.UseVisualStyleBackColor = false;
            btnJvia.Click += btnModeJeu_Click;
            btnJvia.MouseEnter += bouton_Enter;
            btnJvia.MouseLeave += bouton_Leave;
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.Font = new Font("Source Sans Pro Black", 40F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitre.ForeColor = Color.Red;
            lblTitre.Location = new Point(256, 188);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(340, 68);
            lblTitre.TabIndex = 3;
            lblTitre.Text = "Modes de jeu";
            // 
            // picInfoJVJ
            // 
            picInfoJVJ.BackColor = Color.RoyalBlue;
            picInfoJVJ.Image = (Image)resources.GetObject("picInfoJVJ.Image");
            picInfoJVJ.Location = new Point(566, 313);
            picInfoJVJ.Margin = new Padding(3, 2, 3, 2);
            picInfoJVJ.Name = "picInfoJVJ";
            picInfoJVJ.Size = new Size(32, 22);
            picInfoJVJ.SizeMode = PictureBoxSizeMode.Zoom;
            picInfoJVJ.TabIndex = 4;
            picInfoJVJ.TabStop = false;
            picInfoJVJ.MouseEnter += interrogation_MouseEnter;
            picInfoJVJ.MouseLeave += interrogation_MouseLeave;
            // 
            // picInfoJVIA
            // 
            picInfoJVIA.BackColor = Color.RoyalBlue;
            picInfoJVIA.Image = (Image)resources.GetObject("picInfoJVIA.Image");
            picInfoJVIA.Location = new Point(566, 390);
            picInfoJVIA.Margin = new Padding(3, 2, 3, 2);
            picInfoJVIA.Name = "picInfoJVIA";
            picInfoJVIA.Size = new Size(32, 22);
            picInfoJVIA.SizeMode = PictureBoxSizeMode.Zoom;
            picInfoJVIA.TabIndex = 6;
            picInfoJVIA.TabStop = false;
            picInfoJVIA.MouseEnter += interrogation_MouseEnter;
            picInfoJVIA.MouseLeave += interrogation_MouseLeave;
            // 
            // picGrilleDeco
            // 
            picGrilleDeco.Image = (Image)resources.GetObject("picGrilleDeco.Image");
            picGrilleDeco.Location = new Point(10, 289);
            picGrilleDeco.Margin = new Padding(3, 2, 3, 2);
            picGrilleDeco.Name = "picGrilleDeco";
            picGrilleDeco.Size = new Size(276, 167);
            picGrilleDeco.SizeMode = PictureBoxSizeMode.Zoom;
            picGrilleDeco.TabIndex = 7;
            picGrilleDeco.TabStop = false;
            // 
            // lblPuissance4
            // 
            lblPuissance4.AutoSize = true;
            lblPuissance4.BackColor = Color.Transparent;
            lblPuissance4.Font = new Font("Microsoft Sans Serif", 60F, FontStyle.Bold, GraphicsUnit.Point);
            lblPuissance4.ForeColor = Color.MidnightBlue;
            lblPuissance4.Location = new Point(148, 58);
            lblPuissance4.Name = "lblPuissance4";
            lblPuissance4.Size = new Size(576, 91);
            lblPuissance4.TabIndex = 0;
            lblPuissance4.Text = "PUISSANCE 4";
            // 
            // picDeco1
            // 
            picDeco1.Image = (Image)resources.GetObject("picDeco1.Image");
            picDeco1.Location = new Point(13, 9);
            picDeco1.Margin = new Padding(3, 2, 3, 2);
            picDeco1.Name = "picDeco1";
            picDeco1.Size = new Size(214, 175);
            picDeco1.TabIndex = 8;
            picDeco1.TabStop = false;
            // 
            // picDeco2
            // 
            picDeco2.Image = (Image)resources.GetObject("picDeco2.Image");
            picDeco2.Location = new Point(624, 9);
            picDeco2.Margin = new Padding(3, 2, 3, 2);
            picDeco2.Name = "picDeco2";
            picDeco2.Size = new Size(223, 175);
            picDeco2.TabIndex = 9;
            picDeco2.TabStop = false;
            // 
            // lblCreateurs
            // 
            lblCreateurs.AutoSize = true;
            lblCreateurs.Font = new Font("Segoe UI Black", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCreateurs.ForeColor = Color.WhiteSmoke;
            lblCreateurs.Location = new Point(276, 506);
            lblCreateurs.Name = "lblCreateurs";
            lblCreateurs.Size = new Size(571, 15);
            lblCreateurs.TabIndex = 10;
            lblCreateurs.Text = "CIURLIK Robin, DAVID Claire, MENIVAL Efrem, PARENT Léa, SAVOYE Noa, SOARIZIKY Annaïsse";
            // 
            // frmAccueil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(860, 565);
            Controls.Add(lblCreateurs);
            Controls.Add(lblPuissance4);
            Controls.Add(picGrilleDeco);
            Controls.Add(picInfoJVIA);
            Controls.Add(picInfoJVJ);
            Controls.Add(lblTitre);
            Controls.Add(btnJvia);
            Controls.Add(btnJvj);
            Controls.Add(picDeco1);
            Controls.Add(picDeco2);
            Location = new Point(100, 100);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "frmAccueil";
            Text = "Accueil";
            FormClosing += Accueil_FormClosing;
            ((System.ComponentModel.ISupportInitialize)picInfoJVJ).EndInit();
            ((System.ComponentModel.ISupportInitialize)picInfoJVIA).EndInit();
            ((System.ComponentModel.ISupportInitialize)picGrilleDeco).EndInit();
            ((System.ComponentModel.ISupportInitialize)picDeco1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picDeco2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnJvj;
        private Button btnJvia;
        private Label lblTitre;
        private PictureBox picInfoJVJ;
        private PictureBox picInfoJVIA;
        private PictureBox picGrilleDeco;
        private Label lblPuissance4;
        private PictureBox picDeco1;
        private PictureBox picDeco2;
        private Label lblCreateurs;
    }
}