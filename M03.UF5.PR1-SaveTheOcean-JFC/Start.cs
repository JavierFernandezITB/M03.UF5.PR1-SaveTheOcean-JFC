namespace M03.UF5.PR1_SaveTheOcean_JFC
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            CharacterSelection CharacterSelectionForm = new CharacterSelection();
            this.Hide();
            CharacterSelectionForm.ShowDialog();
            this.Close();
        }
    }
}
