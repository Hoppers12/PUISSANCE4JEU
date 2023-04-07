using Puissance_4;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puissance_4
{
    public partial class page_param_JVJ : Form
    {
        public page_param_JVJ()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // Bouton "JOUER" Joueur VS JOUEUR
        {
            Partie_JVJ page_partie_JVJ = new Partie_JVJ();
            page_partie_JVJ.Show();

        }
    }
}
