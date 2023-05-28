namespace Puissance_4
{
    partial class page_param_JVJ
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            textBoxPseudoJ2 = new TextBox();
            textBoxPseudoJ1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            boutonJouer = new Button();
            button_accueil = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 49.8000031F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(49, 64);
            label1.Name = "label1";
            label1.Size = new Size(724, 76);
            label1.TabIndex = 0;
            label1.Text = "JOUEUR VS JOUEUR";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxPseudoJ2);
            groupBox1.Controls.Add(textBoxPseudoJ1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.Red;
            groupBox1.Location = new Point(28, 193);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(372, 191);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Choix Pseudos";
            // 
            // textBoxPseudoJ2
            // 
            textBoxPseudoJ2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxPseudoJ2.Location = new Point(164, 118);
            textBoxPseudoJ2.Margin = new Padding(3, 2, 3, 2);
            textBoxPseudoJ2.MaxLength = 15;
            textBoxPseudoJ2.Name = "textBoxPseudoJ2";
            textBoxPseudoJ2.Size = new Size(110, 23);
            textBoxPseudoJ2.TabIndex = 3;
            textBoxPseudoJ2.Text = "Luffy";
            textBoxPseudoJ2.TextAlign = HorizontalAlignment.Center;
            textBoxPseudoJ2.TextChanged += textBoxPseudo_TextChanged;
            textBoxPseudoJ2.KeyPress += textBoxPseudo_KeyPress;
            // 
            // textBoxPseudoJ1
            // 
            textBoxPseudoJ1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxPseudoJ1.Location = new Point(164, 51);
            textBoxPseudoJ1.Margin = new Padding(3, 2, 3, 2);
            textBoxPseudoJ1.MaxLength = 15;
            textBoxPseudoJ1.Name = "textBoxPseudoJ1";
            textBoxPseudoJ1.Size = new Size(110, 23);
            textBoxPseudoJ1.TabIndex = 2;
            textBoxPseudoJ1.Text = "Naruto";
            textBoxPseudoJ1.TextAlign = HorizontalAlignment.Center;
            textBoxPseudoJ1.TextChanged += textBoxPseudo_TextChanged;
            textBoxPseudoJ1.KeyPress += textBoxPseudo_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkOrange;
            label3.Location = new Point(36, 114);
            label3.Name = "label3";
            label3.Size = new Size(100, 25);
            label3.TabIndex = 1;
            label3.Text = "Joueur 2 :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkOrange;
            label2.Location = new Point(36, 48);
            label2.Name = "label2";
            label2.Size = new Size(100, 25);
            label2.TabIndex = 0;
            label2.Text = "Joueur 1 :";
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
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Choix Grille";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton3.ForeColor = Color.DarkOrange;
            radioButton3.Location = new Point(107, 139);
            radioButton3.Margin = new Padding(3, 2, 3, 2);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(111, 28);
            radioButton3.TabIndex = 2;
            radioButton3.Text = "Aléatoire";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton2.ForeColor = Color.DarkOrange;
            radioButton2.Location = new Point(107, 89);
            radioButton2.Margin = new Padding(3, 2, 3, 2);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(132, 29);
            radioButton2.TabIndex = 1;
            radioButton2.Text = "5 x 6 (Mini)";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton1.ForeColor = Color.DarkOrange;
            radioButton1.Location = new Point(107, 41);
            radioButton1.Margin = new Padding(3, 2, 3, 2);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(174, 29);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "6 x 7 (Classique)";
            radioButton1.UseVisualStyleBackColor = true;
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
            boutonJouer.TabIndex = 10;
            boutonJouer.Text = "JOUER";
            boutonJouer.UseVisualStyleBackColor = false;
            boutonJouer.Click += boutonJouer_Click;
            // 
            // button_accueil
            // 
            button_accueil.BackColor = Color.RoyalBlue;
            button_accueil.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_accueil.ForeColor = Color.Gold;
            button_accueil.Location = new Point(10, 10);
            button_accueil.Margin = new Padding(3, 2, 3, 2);
            button_accueil.Name = "button_accueil";
            button_accueil.Size = new Size(88, 26);
            button_accueil.TabIndex = 11;
            button_accueil.Text = "ACCUEIL";
            button_accueil.UseVisualStyleBackColor = false;
            button_accueil.Click += button_retour_accueil;
            // 
            // page_param_JVJ
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(859, 565);
            Controls.Add(button_accueil);
            Controls.Add(boutonJouer);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Location = new Point(100, 100);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "page_param_JVJ";
            Text = "Form2";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox textBoxPseudoJ2;
        private TextBox textBoxPseudoJ1;
        private Label label3;
        private Label label2;
        private GroupBox groupBox2;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button boutonJouer;
        private Button button_accueil;
    }
}