namespace Puissance_4
{
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            page_JVJ page2 = new page_JVJ();
            page2.Show();
        }
    }
}