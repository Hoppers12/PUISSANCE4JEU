using System.Drawing;
using System.Runtime.CompilerServices;

namespace Puissance_4
{
    public partial class Accueil : Form
    {
        /// <summary>
        /// Label aper�u au survol du "?" � c�t� de JVJ
        /// </summary>
        Label lblInfoJvJ = new Label();
        /// <summary>
        /// Label aper�u au survol du "?" � c�t� de JVIA
        /// </summary>
        Label lblInfoJvIA = new Label();


        /// <summary>
        /// Constructeur de la page d'accueil appell� lors de l'ouverture de la page
        /// Il initialise les composants
        /// </summary>
        public Accueil()
        {
            // Style des labels des aper�us (point d'interrogation)
            lblInfoJvIA.BackColor = Color.FromArgb(205, 206, 204);
            lblInfoJvJ.BackColor = Color.FromArgb(205, 206, 204);
            InitializeComponent();
            this.Size = new Size(1000, 800);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        /// <summary>
        /// M�thode appel� lors du click sur le bouton JVJ ou JVIA
        /// Elle ouvre la page de param�trages et ferme l'accueil
        /// </summary>
        /// <param name="sender">L'�lement avec lequel il y a l'int�raction</param>
        /// <param name="e">L'�venement click en tant que tel</param>
        private void boutonJvjClick(object sender, EventArgs e)
        {
            Button BoutonClique = (Button)sender;
            //Si le bouton cliqu� est celui de JVJ alors on ouvre pageParamJvj sinon pageParamJvia

            if (BoutonClique.Name == "boutonJvj")
            {
                page_param_JVJ page2 = new page_param_JVJ();
                page2.Show(this);
                this.Hide();
            }
            else
            {
                page_param_JVIA page3 = new page_param_JVIA();
                page3.Show();
                this.Hide();
            }


        }

        /// <summary>
        /// M�thode qui affiche les infos lors du survol du "?"
        /// </summary>
        /// <param name="sender">L'�lement avec lequel il y a l'int�raction</param>
        /// <param name="e">L'�venement en tant que tel</param>
        private void interrogation_MouseEnter(object sender, EventArgs e)
        {
            PictureBox imageSurvole = (PictureBox)sender;

            //Si il la pictureBox survol� est celle du JVJ ALORS ... SINON ...
            if (imageSurvole.Name == "infoJVJ")
            {
                this.Controls.Add(lblInfoJvJ);
                lblInfoJvJ.Size = new Size(280, 50);
                //Ajustement de l'emplacement du label
                lblInfoJvJ.TextAlign = ContentAlignment.MiddleCenter;
                lblInfoJvJ.Location = new Point(infoJVJ.Location.X + 27, infoJVJ.Location.Y);
                lblInfoJvJ.Text = "Partie contre une personne en local";
            }
            else
            {
                this.Controls.Add(lblInfoJvIA);
                lblInfoJvIA.Size = new Size(280, 50);
                //Ajustement de l'emplacement du label
                lblInfoJvIA.TextAlign = ContentAlignment.MiddleCenter;
                lblInfoJvIA.Location = new Point(infoJVIA.Location.X + 27, infoJVIA.Location.Y);
                lblInfoJvIA.Text = "Partie contre une intellligence artificielle";
            }

        }

        /// <summary>
        /// M�thode qui retire les infos lorsque la souris quitte le "?"
        /// </summary>
        /// <param name="sender">L'�lement avec lequel il y a l'int�raction</param>
        /// <param name="e">L'�venement en tant que tel</param>
        private void interrogation_MouseLeave(object sender, EventArgs e)
        {
            PictureBox imageSurvole = (PictureBox)sender;

            // Si il s'agit de la pictureBox de JVJ ... Sinon ...
            if (imageSurvole.Name == "infoJVJ")
            {
                this.Controls.Remove(lblInfoJvJ);
            }
            else
            {
                this.Controls.Remove(lblInfoJvIA);
            }

        }

        /// <summary>
        /// Fonction qui demande une confirmation avant de fermer la page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Accueil_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Affichez une bo�te de dialogue de confirmation
                DialogResult fermeture = MessageBox.Show("�tes-vous s�r de vouloir fermer la fen�tre ?", "Confirmation de fermeture", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Si l'utilisateur clique sur Non, annulez la fermeture
                if (fermeture == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        /// <summary>
        /// M�thode qui change la couleur du bouton � l'entr�e de la souris
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bouton_Enter(object sender, EventArgs e)
        {
            Button boutonSurvole = (Button)sender;

            boutonSurvole.ForeColor = Color.Red;
        }

        /// <summary>
        /// M�thode qui change la couleur du bouton � la sortie de la souris
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bouton_Leave(object sender, EventArgs e)
        {
            Button boutonSurvole = (Button)sender;

            boutonSurvole.ForeColor = Color.Yellow;
        }

    }
}
