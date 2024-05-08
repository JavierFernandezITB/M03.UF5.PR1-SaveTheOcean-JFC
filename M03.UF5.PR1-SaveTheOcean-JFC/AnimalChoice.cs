using M03.UF5.PR1_SaveTheOcean_JFC.Models;
using M03.UF5.PR1_SaveTheOcean_JFC.Persistence.Mapping;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace M03.UF5.PR1_SaveTheOcean_JFC
{
    public partial class AnimalChoice : Form
    {
        public Animal currentAnimalGlobal;
        public Rescue currentRescueGlobal;
        public Player currentPlayerGlobal;

        public AnimalChoice(Animal currentAnimal, Player currentPlayer)
        {
            currentAnimalGlobal = currentAnimal;
            currentPlayerGlobal = currentPlayer;
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void AnimalChoice_Load(object sender, EventArgs e)
        {
            RescueDAO rescueDAO = new RescueDAO();
            textBox6.Text = currentAnimalGlobal.Name;
            textBox8.Text = currentAnimalGlobal.Specie;
            textBox9.Text = currentAnimalGlobal.Weight.ToString();

            Rescue rescue = new Rescue(currentAnimalGlobal.Id);
            textBox1.Text = rescue.Code;
            textBox2.Text = rescue.Date;
            textBox4.Text = rescue.AG.ToString();
            textBox5.Text = rescue.Location;
            rescueDAO.Insert(rescue);
            currentRescueGlobal = rescue;
        }

        public static int TMarinaCalc(Rescue rescue)
        {
            int cram = 15;
            return (2 * rescue.AG + 3) - ((rescue.AG - 20) * 2) - cram;
        }

        public static int AMarinaCalc(Rescue rescue, bool iscram)
        {
            int cram = 5;
            if (iscram)
                cram = 0;
            return (rescue.AG - cram) / 5;
        }

        public static int CetaciCalc(Rescue rescue, bool iscram)
        {
            int cram = 50;
            if (iscram)
                cram = 0;
            return rescue.AG - (rescue.AG / 5) - cram;
        }

        public void ActionFinished()
        {
            if (currentRescueGlobal.AG <= 30)
            {
                MessageBox.Show("Felicidades! Has conseguido rescatar al bicho y has ganado 50 puntos de XP.\n Tu XP: " + (currentPlayerGlobal.Xp + 50));
                XMLHandler.ChangeXP("data.xml", currentPlayerGlobal.Name, currentPlayerGlobal.Xp + 50);
            } else
            {
                MessageBox.Show("Vaya! No has conseguido rescatar al bicho, has perdido 20 puntos de XP.\n Tu XP: " + (currentPlayerGlobal.Xp - 20));
                XMLHandler.ChangeXP("data.xml", currentPlayerGlobal.Name, currentPlayerGlobal.Xp - 20);
            }
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (currentAnimalGlobal.Specie)
            {
                case "Ave marina":
                    currentRescueGlobal.AG = AMarinaCalc(currentRescueGlobal, false);
                    break;
                case "Cetaceo":
                    currentRescueGlobal.AG = CetaciCalc(currentRescueGlobal, false);
                    break;
                case "Tortuga marina":
                    currentRescueGlobal.AG = TMarinaCalc(currentRescueGlobal);
                    break;
            }
            textBox4.Text = currentRescueGlobal.AG.ToString();
            ActionFinished();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (currentAnimalGlobal.Specie)
            {
                case "Ave marina":
                    currentRescueGlobal.AG = AMarinaCalc(currentRescueGlobal, true);
                    break;
                case "Cetaceo":
                    currentRescueGlobal.AG = CetaciCalc(currentRescueGlobal, true);
                    break;
                case "Tortuga marina":
                    currentRescueGlobal.AG = TMarinaCalc(currentRescueGlobal);
                    break;
            }
            textBox4.Text = currentRescueGlobal.AG.ToString();
            ActionFinished();
        }
    }
}
