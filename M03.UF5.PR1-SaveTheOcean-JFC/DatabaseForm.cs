using M03.UF5.PR1_SaveTheOcean_JFC.Models;
using M03.UF5.PR1_SaveTheOcean_JFC.Persistence.Mapping;

namespace M03.UF5.PR1_SaveTheOcean_JFC
{
    public partial class DatabaseForm : Form
    {
        public Player currentPlayerGlobal;

        public DatabaseForm(Player plr)
        {
            currentPlayerGlobal = plr;
            InitializeComponent();
        }

        private void DatabaseForm_Load(object sender, EventArgs e)
        {
            AnimalDAO AnimalDAO = new AnimalDAO();
            dataGridView.DataSource = AnimalDAO.GetAllAnimals();
        }

        private void buttonCreateSelf_Click(object sender, EventArgs e)
        {
            NewAnimal animalForm = new NewAnimal(currentPlayerGlobal);
            this.Hide();
            animalForm.ShowDialog();
            this.Close();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView.Rows[e.RowIndex];
                Animal animal = new Animal
                {
                    Id = int.Parse(selectedRow.Cells["Id"].Value.ToString()),
                    Name = selectedRow.Cells["Name"].Value.ToString(),
                    Specie = selectedRow.Cells["Specie"].Value.ToString(),
                    Weight = double.Parse(selectedRow.Cells["Weight"].Value.ToString()),
                };
                AnimalChoice animalChoice = new AnimalChoice(animal, currentPlayerGlobal);
                this.Hide();
                animalChoice.ShowDialog();
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Rescates().ShowDialog();
        }
    }
}
