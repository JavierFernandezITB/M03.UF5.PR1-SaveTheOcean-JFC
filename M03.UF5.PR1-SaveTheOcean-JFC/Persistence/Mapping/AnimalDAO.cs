using M03.UF5.PR1_SaveTheOcean_JFC.Models;
using M03.UF5.PR1_SaveTheOcean_JFC.Persistence.DAO;
using Npgsql;
using SaveTheOceanForm.Persistence.Utils;

namespace M03.UF5.PR1_SaveTheOcean_JFC.Persistence.Mapping
{
    public class AnimalDAO : IAnimalDAO
    {
        public void Insert(Animal animal)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(NpgsqlUtils.OpenConnection()))
            {
                conn.Open();
                using (NpgsqlCommand command = new NpgsqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "INSERT INTO animals (name, specie, weight) VALUES (@name, @specie, @weight)";
                    command.Parameters.AddWithValue("@name", animal.Name);
                    command.Parameters.AddWithValue("@specie", animal.Specie);
                    command.Parameters.AddWithValue("@weight", animal.Weight);
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Animal> GetAllAnimals()
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(NpgsqlUtils.OpenConnection()))
            {
                conn.Open();
                using (NpgsqlCommand command = new NpgsqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "SELECT id, name, specie, weight FROM Animals";
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        List<Animal> animals = new List<Animal>();
                        while (reader.Read())
                        {
                            Animal animal = new Animal();
                            animal.Id = int.Parse(reader["id"].ToString());
                            animal.Name  = reader["name"].ToString();
                            animal.Specie = reader["specie"].ToString();
                            animal.Weight = double.Parse(reader["weight"].ToString());
                            animals.Add(animal);
                        }
                        return animals;
                    }
                }
            }
        }
    }
}
