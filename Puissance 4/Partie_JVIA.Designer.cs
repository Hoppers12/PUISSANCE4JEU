﻿namespace Puissance_4
{
    partial class Partie_JVIA
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
            LabelTailleGrille = new Label();
            Colonne1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(275, 35);
            label1.TabIndex = 0;
            label1.Text = "Partie Joueur VS Joueur";
            // 
            // LabelTailleGrille
            // 
            LabelTailleGrille.AutoSize = true;
            LabelTailleGrille.Location = new Point(380, 21);
            LabelTailleGrille.Name = "LabelTailleGrille";
            LabelTailleGrille.Size = new Size(50, 20);
            LabelTailleGrille.TabIndex = 9;
            LabelTailleGrille.Text = "label2";
            // 
            // Colonne1
            // 
            Colonne1.Location = new Point(92, 68);
            Colonne1.Name = "Colonne1";
            Colonne1.Size = new Size(100, 29);
            Colonne1.TabIndex = 2;
            Colonne1.Text = "Colonne1";
            Colonne1.UseVisualStyleBackColor = true;
            Colonne1.Click += Colonne1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(235, 68);
            button2.Name = "button2";
            button2.Size = new Size(100, 29);
            button2.TabIndex = 3;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Colonne2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(394, 68);
            button3.Name = "button3";
            button3.Size = new Size(100, 29);
            button3.TabIndex = 4;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Colonne3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(539, 68);
            button4.Name = "button4";
            button4.Size = new Size(100, 29);
            button4.TabIndex = 5;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += Colonne4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(671, 68);
            button5.Name = "button5";
            button5.Size = new Size(100, 29);
            button5.TabIndex = 6;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += Colonne5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(809, 68);
            button6.Name = "button6";
            button6.Size = new Size(100, 29);
            button6.TabIndex = 7;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += Colonne6_Click;
            // 
            // Partie_JVJ
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 753);
            Controls.Add(LabelTailleGrille);
            Controls.Add(button3);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(Colonne1);
            Controls.Add(label1);
            Name = "Partie_JVJ";
            Text = "Form1";
            Load += Partie_JVJ_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label LabelTailleGrille;
        private Button Colonne1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}