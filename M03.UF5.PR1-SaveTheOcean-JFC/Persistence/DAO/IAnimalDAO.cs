using M03.UF5.PR1_SaveTheOcean_JFC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M03.UF5.PR1_SaveTheOcean_JFC.Persistence.DAO
{
    public interface IAnimalDAO
    {
        public void Insert(Animal animal);
        public List<Animal> GetAllAnimals();
    }
}
