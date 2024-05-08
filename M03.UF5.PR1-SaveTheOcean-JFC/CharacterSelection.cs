using M03.UF5.PR1_SaveTheOcean_JFC.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M03.UF5.PR1_SaveTheOcean_JFC
{
    public partial class CharacterSelection : Form
    {
        public CharacterSelection()
        {
            InitializeComponent();
        }

        private void CharacterSelection_Load(object sender, EventArgs e)
        {
            foreach (var item in Jobs.List)
            {
                comboBoxWork.Items.Add(item.Key);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "")
            {
                errorProvider1.SetError(textBoxUsername, "Este campo no puede estar vacío.");
            }
            else if (!errorProvider1.HasErrors)
            {
                XMLHandler.CreateXML("data.xml");
                string jobName = comboBoxWork.SelectedItem == null ? "Tecnico" : comboBoxWork.SelectedItem.ToString();
                Player plr = new Player(textBoxUsername.Text.ToLower(), jobName, Jobs.List[jobName]);
                plr = XMLHandler.CreateUser("data.xml", plr);
                this.Hide();
                DatabaseForm DatabaseForm = new DatabaseForm(plr);
                DatabaseForm.ShowDialog();
                this.Close();
            }
        }

        private void textBoxUsername_Leave(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "")
            {
                errorProvider1.SetError(textBoxUsername, "Este campo no puede estar vacío.");
            }
            else
            { 
                errorProvider1.Clear();
            }
        }
    }
}
