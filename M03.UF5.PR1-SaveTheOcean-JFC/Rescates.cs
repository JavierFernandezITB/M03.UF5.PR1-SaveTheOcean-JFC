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

namespace M03.UF5.PR1_SaveTheOcean_JFC
{
    public partial class Rescates : Form
    {
        public Rescates()
        {
            InitializeComponent();
        }

        private void Rescates_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new RescueDAO().GetAllRescues();
        }
    }
}
