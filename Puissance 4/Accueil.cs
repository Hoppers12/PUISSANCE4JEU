using System.Drawing;
using System.Runtime.CompilerServices;

namespace Puissance_4
{
    public partial class Accueil : Form
    {
        /// <summary>
        /// Label aperçu au survol du "?" à côté de JVJ
        /// </summary>
        Label lblInfoJvJ = new Label();
        /// <summary>
        /// Label aperçu au survol du "?" à côté de JVIA
        /// </summary>
        Label lblInfoJvIA = new Label();


        /// <summary>
        /// Constructeur de la page d'accueil appellé lors de l'ouverture de la page
        /// Il initialise les composants
        /// </summary>
        public Accueil()
        {
            // Style des labels des aperçus (point d'interrogation)
            lblInfoJvIA.BackColor = Color.FromArgb(205, 206, 204);
            lblInfoJvJ.BackColor = Color.FromArgb(205, 206, 204);
            InitializeComponent();
            this.Size = new Size(1000, 800);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        /// <summary>
        /// Méthode appelé lors du click sur le bouton JVJ ou JVIA
        /// Elle ouvre la page de paramétrages et ferme l'accueil
        /// </summary>
        /// <param name="sender">L'élement avec lequel il y a l'intéraction</param>
        /// <param name="e">L'évenement click en tant que tel</param>
        private void boutonJvjClick(object sender, EventArgs e)
        {
            Button BoutonClique = (Button)sender;
            //Si le bouton cliqué est celui de JVJ alors on ouvre pageParamJvj sinon pageParamJvia

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
        /// Méthode qui affiche les infos lors du survol du "?"
        /// </summary>
        /// <param name="sender">L'élement avec lequel il y a l'intéraction</param>
        /// <param name="e">L'évenement en tant que tel</param>
        private void interrogation_MouseEnter(object sender, EventArgs e)
        {
            PictureBox imageSurvole = (PictureBox)sender;

            //Si il la pictureBox survolé est celle du JVJ ALORS ... SINON ...
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
        /// Méthode qui retire les infos lorsque la souris quitte le "?"
        /// </summary>
        /// <param name="sender">L'élement avec lequel il y a l'intéraction</param>
        /// <param name="e">L'évenement en tant que tel</param>
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
                // Affichez une boîte de dialogue de confirmation
                DialogResult fermeture = MessageBox.Show("Êtes-vous sûr de vouloir fermer la fenêtre ?", "Confirmation de fermeture", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Si l'utilisateur clique sur Non, annulez la fermeture
                if (fermeture == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        /// <summary>
        /// Méthode qui change la couleur du bouton à l'entrée de la souris
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bouton_Enter(object sender, EventArgs e)
        {
            Button boutonSurvole = (Button)sender;

            boutonSurvole.ForeColor = Color.Red;
        }

        /// <summary>
        /// Méthode qui change la couleur du bouton à la sortie de la souris
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
