namespace Puissance_4
{
    public partial class Accueil : Form
    {
        public Accueil()
        {
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
    }
}