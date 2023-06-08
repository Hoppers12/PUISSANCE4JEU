namespace Puissance_4
{
    partial class Accueil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accueil));
            boutonJvj = new Button();
            boutonJvia = new Button();
            label2 = new Label();
            infoJVJ = new PictureBox();
            infoJVIA = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)infoJVJ).BeginInit();
            ((System.ComponentModel.ISupportInitialize)infoJVIA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // boutonJvj
            // 
            boutonJvj.AccessibleRole = AccessibleRole.None;
            boutonJvj.BackColor = Color.RoyalBlue;
            boutonJvj.Font = new Font("Segoe UI Black", 15F, FontStyle.Regular, GraphicsUnit.Point);
            boutonJvj.ForeColor = Color.Yellow;
            boutonJvj.Location = new Point(344, 313);
            boutonJvj.Margin = new Padding(3, 2, 3, 2);
            boutonJvj.Name = "boutonJvj";
            boutonJvj.Size = new Size(243, 58);
            boutonJvj.TabIndex = 1;
            boutonJvj.Text = " Joueur VS Joueur ";
            boutonJvj.UseVisualStyleBackColor = false;
            boutonJvj.Click += boutonJvjClick;
            boutonJvj.MouseEnter += bouton_Enter;
            boutonJvj.MouseLeave += bouton_Leave;
            // 
            // boutonJvia
            // 
            boutonJvia.BackColor = Color.RoyalBlue;
            boutonJvia.Font = new Font("Segoe UI Black", 15F, FontStyle.Regular, GraphicsUnit.Point);
            boutonJvia.ForeColor = Color.Yellow;
            boutonJvia.Location = new Point(344, 390);
            boutonJvia.Margin = new Padding(3, 2, 3, 2);
            boutonJvia.Name = "boutonJvia";
            boutonJvia.Size = new Size(243, 58);
            boutonJvia.TabIndex = 2;
            boutonJvia.Text = " Joueur VS Ordi";
            boutonJvia.UseVisualStyleBackColor = false;
            boutonJvia.Click += boutonJvjClick;
            boutonJvia.MouseEnter += bouton_Enter;
            boutonJvia.MouseLeave += bouton_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Source Sans Pro Black", 40F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(289, 186);
            label2.Name = "label2";
            label2.Size = new Size(340, 68);
            label2.TabIndex = 3;
            label2.Text = "Modes de jeu";
            // 
            // infoJVJ
            // 
            infoJVJ.BackColor = Color.RoyalBlue;
            infoJVJ.Image = (Image)resources.GetObject("infoJVJ.Image");
            infoJVJ.Location = new Point(591, 305);
            infoJVJ.Margin = new Padding(3, 2, 3, 2);
            infoJVJ.Name = "infoJVJ";
            infoJVJ.Size = new Size(32, 22);
            infoJVJ.SizeMode = PictureBoxSizeMode.Zoom;
            infoJVJ.TabIndex = 4;
            infoJVJ.TabStop = false;
            infoJVJ.MouseEnter += interrogation_MouseEnter;
            infoJVJ.MouseLeave += interrogation_MouseLeave;
            // 
            // infoJVIA
            // 
            infoJVIA.BackColor = Color.RoyalBlue;
            infoJVIA.Image = (Image)resources.GetObject("infoJVIA.Image");
            infoJVIA.Location = new Point(591, 390);
            infoJVIA.Margin = new Padding(3, 2, 3, 2);
            infoJVIA.Name = "infoJVIA";
            infoJVIA.Size = new Size(32, 22);
            infoJVIA.SizeMode = PictureBoxSizeMode.Zoom;
            infoJVIA.TabIndex = 6;
            infoJVIA.TabStop = false;
            infoJVIA.MouseEnter += interrogation_MouseEnter;
            infoJVIA.MouseLeave += interrogation_MouseLeave;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(10, 289);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(276, 167);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 60F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(125, 46);
            label1.Name = "label1";
            label1.Size = new Size(576, 91);
            label1.TabIndex = 0;
            label1.Text = "PUISSANCE 4";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(56, 9);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(190, 165);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(632, 9);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(193, 175);
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // Accueil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(859, 565);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(infoJVIA);
            Controls.Add(infoJVJ);
            Controls.Add(label2);
            Controls.Add(boutonJvia);
            Controls.Add(boutonJvj);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Location = new Point(100, 100);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "Accueil";
            Text = "Form1";
            FormClosing += Accueil_FormClosing;
            ((System.ComponentModel.ISupportInitialize)infoJVJ).EndInit();
            ((System.ComponentModel.ISupportInitialize)infoJVIA).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button boutonJvj;
        private Button boutonJvia;
        private Label label2;
        private PictureBox infoJVJ;
        private PictureBox infoJVIA;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}