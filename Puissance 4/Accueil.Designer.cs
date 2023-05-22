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
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            infoJVJ = new PictureBox();
            infoJVIA = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)infoJVJ).BeginInit();
            ((System.ComponentModel.ISupportInitialize)infoJVIA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.AccessibleRole = AccessibleRole.None;
            button1.BackColor = Color.RoyalBlue;
            button1.Font = new Font("Segoe UI Black", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Yellow;
            button1.Location = new Point(371, 380);
            button1.Name = "button1";
            button1.Size = new Size(278, 77);
            button1.TabIndex = 1;
            button1.Text = " Joueur VS Joueur ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.RoyalBlue;
            button2.Font = new Font("Segoe UI Black", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.Yellow;
            button2.Location = new Point(371, 527);
            button2.Name = "button2";
            button2.Size = new Size(278, 77);
            button2.TabIndex = 2;
            button2.Text = " Joueur VS Ordi";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Source Sans Pro Black", 40F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Yellow;
            label2.Location = new Point(292, 237);
            label2.Name = "label2";
            label2.Size = new Size(422, 84);
            label2.TabIndex = 3;
            label2.Text = "Modes de jeu";
            label2.Click += label2_Click;
            // 
            // infoJVJ
            // 
            infoJVJ.BackColor = Color.White;
            infoJVJ.Image = (Image)resources.GetObject("infoJVJ.Image");
            infoJVJ.Location = new Point(655, 359);
            infoJVJ.Name = "infoJVJ";
            infoJVJ.Size = new Size(18, 21);
            infoJVJ.TabIndex = 4;
            infoJVJ.TabStop = false;
            infoJVJ.Click += infoJVJ_Click;
            infoJVJ.MouseEnter += infoJVJ_MouseEnter;
            infoJVJ.MouseLeave += infoJVJ_MouseLeave;
            infoJVJ.MouseHover += infoJVJ_MouseHover;
            // 
            // infoJVIA
            // 
            infoJVIA.BackColor = Color.White;
            infoJVIA.Image = (Image)resources.GetObject("infoJVIA.Image");
            infoJVIA.Location = new Point(653, 507);
            infoJVIA.Name = "infoJVIA";
            infoJVIA.Size = new Size(20, 21);
            infoJVIA.TabIndex = 6;
            infoJVIA.TabStop = false;
            infoJVIA.MouseEnter += InfoJVIA_MouseEnter;
            infoJVIA.MouseLeave += InfoJVIA_MouseLeave;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-31, 390);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(316, 223);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 60F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.CornflowerBlue;
            label1.Location = new Point(148, 63);
            label1.Name = "label1";
            label1.Size = new Size(719, 119);
            label1.TabIndex = 0;
            label1.Text = "PUISSANCE 4";
            label1.Click += label1_Click;
            // 
            // Accueil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(982, 753);
            Controls.Add(pictureBox1);
            Controls.Add(infoJVIA);
            Controls.Add(infoJVJ);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "Accueil";
            Text = "Form1";
            FormClosing += Accueil_FormClosing;
            Load += Accueil_Load;
            ((System.ComponentModel.ISupportInitialize)infoJVJ).EndInit();
            ((System.ComponentModel.ISupportInitialize)infoJVIA).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button button2;
        private Label label2;
        private PictureBox infoJVJ;
        private PictureBox infoJVIA;
        private PictureBox pictureBox1;
        private Label label1;
    }
}