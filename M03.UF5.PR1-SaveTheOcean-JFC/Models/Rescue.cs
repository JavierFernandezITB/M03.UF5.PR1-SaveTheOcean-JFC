using System;

namespace M03.UF5.PR1_SaveTheOcean_JFC.Models
{
    public class Rescue
    {
        public string Code { get; set; }
        public string Date { get; set; }
        public int AG { get; set; }
        public string Location { get; set; }
        public int AnimalId { get; set; }

        public Rescue(int animalId) 
        {
            Code = GenerateRescueCode();
            Date = DateTime.Now.ToString();
            AG = GenerateAfectation();
            Location = GenerateLocation();
            AnimalId = animalId;
        }

        public Rescue() { }

        public static string GenerateRescueCode()
        {
            Random random = new Random();
            string code = "RES" + random.Next(0, 1000);
            return code;
        }
        public static int GenerateAfectation()
        {
            Random random = new Random();
            int afectation = random.Next(0, 100);
            return afectation;
        }

        public static string GenerateLocation()
        {
            Random random = new Random();
            List<string> locations = new() { "La playa", "Tu casa", "Baho del mar" };
            return locations[random.Next(0, locations.Count)];
        }
    }
}
