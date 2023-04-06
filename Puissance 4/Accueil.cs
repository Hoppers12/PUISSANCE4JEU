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
            page_param_JVJ page2 = new page_param_JVJ();
            page2.Show();
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            page_param_JVIA page3 = new page_param_JVIA();
            page3.Show();
        }
    }
}