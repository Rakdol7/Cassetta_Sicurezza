namespace Cassetta_Sicurezza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Stato.Text = "CHIUSA";
        }

        private void Apri_Click(object sender, EventArgs e)
        {
            Stato.Text = "APERTA";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
