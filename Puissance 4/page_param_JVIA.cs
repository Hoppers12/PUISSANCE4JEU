using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Puissance_4
{
    public partial class page_param_JVIA : Form
    {
        public int choixGrilleRadioButton;
        public string pseudoJ;
        public page_param_JVIA()
        {
            InitializeComponent();
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // On enregistre le numero de la grille choisie en fonction du radiobutton qui a été coché
            if (radioButton1.Checked == true)
            {

                choixGrilleRadioButton = 1;
            }
            else
            {
                if (radioButton2.Checked == true)
                {
                    choixGrilleRadioButton = 2;
                }
                else
                {
                    if (radioButton3.Checked == true)
                    {
                        choixGrilleRadioButton = 0;
                    }

                }


            }
            pseudoJ = pseudoJ1.Text;
            Partie_JVIA page_partieJVIA = new Partie_JVIA(this);
            page_partieJVIA.Show();
            this.Hide();
        }
    }
}