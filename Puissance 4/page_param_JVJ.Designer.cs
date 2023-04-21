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
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            button1 = new Button();
            button_accueil = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 28.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(181, 44);
            label1.Name = "label1";
            label1.Size = new Size(474, 61);
            label1.TabIndex = 0;
            label1.Text = "JOUEUR VS JOUEUR";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(37, 169);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(326, 192);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Choix Pseudos";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(162, 141);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 3;
            textBox2.Text = "Luffy";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(162, 51);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 2;
            textBox1.Text = "Naruto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 141);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 1;
            label3.Text = "Joueur 2 :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 54);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 0;
            label2.Text = "Joueur 1 :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton3);
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Controls.Add(radioButton1);
            groupBox2.Location = new Point(460, 169);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(328, 192);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Choix Grille";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(122, 137);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(91, 24);
            radioButton3.TabIndex = 2;
            radioButton3.Text = "Aléatoire";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(122, 96);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(61, 24);
            radioButton2.TabIndex = 1;
            radioButton2.Text = "6 x 5";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(122, 54);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(61, 24);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "6 x 7";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(304, 378);
            button1.Name = "button1";
            button1.Size = new Size(200, 50);
            button1.TabIndex = 10;
            button1.Text = "JOUER";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button_accueil
            // 
            button_accueil.Location = new Point(26, 24);
            button_accueil.Name = "button_accueil";
            button_accueil.Size = new Size(94, 29);
            button_accueil.TabIndex = 11;
            button_accueil.Text = "ACCUEIL";
            button_accueil.UseVisualStyleBackColor = true;
            button_accueil.Click += button_retour_accueil;
            // 
            // page_param_JVJ
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_accueil);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
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
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private GroupBox groupBox2;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button button1;
        private Button button_accueil;
    }
}