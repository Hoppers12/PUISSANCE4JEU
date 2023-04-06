namespace Puissance_4
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
            textBox1 = new TextBox();
            button1 = new Button();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton3);
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Controls.Add(radioButton1);
            groupBox2.Location = new Point(447, 175);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(328, 192);
            groupBox2.TabIndex = 5;
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
            radioButton3.TabStop = true;
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
            radioButton2.TabStop = true;
            radioButton2.Text = "6 x 6";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(122, 54);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(61, 24);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "6 x 7";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 28.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(186, 62);
            label1.Name = "label1";
            label1.Size = new Size(411, 61);
            label1.TabIndex = 3;
            label1.Text = "JOUEUR VS ORDI";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 273);
            label3.Name = "label3";
            label3.Size = new Size(148, 20);
            label3.TabIndex = 7;
            label3.Text = "Entrez votre pseudo :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(225, 273);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 8;
            textBox1.Text = "ThéoDu33";
            // 
            // button1
            // 
            button1.Location = new Point(278, 388);
            button1.Name = "button1";
            button1.Size = new Size(200, 50);
            button1.TabIndex = 9;
            button1.Text = "JOUER";
            button1.UseVisualStyleBackColor = true;
            // 
            // page_param_JVIA
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Name = "page_param_JVIA";
            Text = "Form1";
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
        private TextBox textBox1;
        private Button button1;
    }
}