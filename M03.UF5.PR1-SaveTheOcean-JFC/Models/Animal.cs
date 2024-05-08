using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M03.UF5.PR1_SaveTheOcean_JFC.Models
{
    public class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Specie { get; set; }
        public double Weight { get; set; }

        public Animal(string name, string specie, double weight)
        {
            Name = name;
            Specie = specie;
            Weight = weight;
        }

        public Animal() { }
    }
}
