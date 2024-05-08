using M03.UF5.PR1_SaveTheOcean_JFC.Models;
using M03.UF5.PR1_SaveTheOcean_JFC.Persistence.Mapping;
using System.Text.RegularExpressions;

namespace M03.UF5.PR1_SaveTheOcean_JFC
{
    public partial class NewAnimal : Form
    {
        public Player currentPlayerGlobal;
        public NewAnimal(Player plr)
        {
            currentPlayerGlobal = plr;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!errorProvider1.HasErrors && textBox1.Text.Length > 0 && textBox3.Text.Length > 0)
            {
                DatabaseForm dbForm = new DatabaseForm(currentPlayerGlobal);
                AnimalDAO animalDAO = new AnimalDAO();
                Animal animal = new Animal();
                animal.Name = textBox1.Text;
                animal.Specie = comboBox1.SelectedItem.ToString();
                animal.Weight = double.Parse(textBox3.Text);
                animalDAO.Insert(animal);
                this.Hide();
                dbForm.ShowDialog();
                this.Close();
            }
        }

        private void NewAnimal_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Ave marina");
            comboBox1.Items.Add("Cetaceo");
            comboBox1.Items.Add("Tortuga marina");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            double result;
            if (!double.TryParse(textBox3.Text, out result))
            {
                textBox3.Text = "";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1, "Este campo no puede estar vacío.");
            }
            else
            {
                errorProvider1.Clear();
            }

        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text.Length <= 0)
            {
                errorProvider1.SetError(textBox3, "Este campo no puede estar vacío.");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
    }
}
