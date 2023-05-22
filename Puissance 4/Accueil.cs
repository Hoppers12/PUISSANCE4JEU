using System.Drawing;
using System.Runtime.CompilerServices;

namespace Puissance_4
{
    public partial class Accueil : Form
    {
        //Création des label aperçu
        Label lblInfoJvJ = new Label();
        Label lblInfoJvIA = new Label();

        public Accueil()
        {
            // Style des labels des aperçus (point d'interrogation)
            lblInfoJvIA.BackColor = Color.FromArgb(205, 206, 204);
            lblInfoJvJ.BackColor = Color.FromArgb(205, 206, 204);
            InitializeComponent();
        }

        //Creation de la page de param 
        private void button1_Click(object sender, EventArgs e)
        {
            page_param_JVJ page2 = new page_param_JVJ();
            page2.Show(this);
            this.Hide();            // On cache la page d'accueil


            //this.OwnedForms; tableau qui contient les autres pages enfants 
        }

        //Creation de la page de param 
        private void button2_Click_1(object sender, EventArgs e)
        {
            page_param_JVIA page3 = new page_param_JVIA();
            page3.Show();
            this.Hide();

        }

        private void Accueil_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1000, 800);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void infoJVJ_MouseHover(object sender, EventArgs e)
        {

        }

        //Procédure qui affiche les infos lors du survol du "?" (jvj)
        private void infoJVJ_MouseEnter(object sender, EventArgs e)
        {

            this.Controls.Add(lblInfoJvJ);
            lblInfoJvJ.Size = new Size(280, 50);
            lblInfoJvJ.TextAlign = ContentAlignment.MiddleCenter;
            lblInfoJvJ.Location = new Point(infoJVJ.Location.X + 27, infoJVJ.Location.Y);
            lblInfoJvJ.Text = "Partie contre une vraie personne en local";
        }
        //Procédure de suppression de l'aperçu lorsque la souris quitte le ?
        private void infoJVJ_MouseLeave(object sender, EventArgs e)
        {
            this.Controls.Remove(lblInfoJvJ);
        }

        //Procédure qui affiche les infos lors du survol du "?" (jvia)
        private void InfoJVIA_MouseEnter(object sender, EventArgs e)
        {

            this.Controls.Add(lblInfoJvIA);
            lblInfoJvIA.Size = new Size(280, 50);
            lblInfoJvIA.TextAlign = ContentAlignment.MiddleCenter;
            lblInfoJvIA.Location = new Point(infoJVIA.Location.X + 27, infoJVIA.Location.Y);
            lblInfoJvIA.Text = "Partie contre une intellligence artificielle";
        }

        //Procédure de suppression de l'aperçu lorsque la souris quitte le ?
        private void InfoJVIA_MouseLeave(object sender, EventArgs e)
        {
            this.Controls.Remove(lblInfoJvIA);
        }

        private void infoJVJ_Click(object sender, EventArgs e)
        {

        }

        private void Accueil_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Affichez une boîte de dialogue de confirmation
                DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir fermer la fenêtre ?", "Confirmation de fermeture", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Si l'utilisateur clique sur Non, annulez la fermeture
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
