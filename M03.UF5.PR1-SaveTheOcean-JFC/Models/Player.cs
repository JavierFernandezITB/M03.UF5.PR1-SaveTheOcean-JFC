using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M03.UF5.PR1_SaveTheOcean_JFC.Models
{
    public class Player
    {
        public string Name { get; set; }
        public string Job { get; set; }
        public int Xp { get; set; }

        public Player(string name, string job, int xp)
        {
            Name = name;
            Job = job;
            Xp = xp;
        }
    }
}
