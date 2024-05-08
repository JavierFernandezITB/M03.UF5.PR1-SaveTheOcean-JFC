using M03.UF5.PR1_SaveTheOcean_JFC.Models;
using M03.UF5.PR1_SaveTheOcean_JFC.Persistence.DAO;
using Npgsql;
using SaveTheOceanForm.Persistence.Utils;

namespace M03.UF5.PR1_SaveTheOcean_JFC.Persistence.Mapping
{
    public class RescueDAO : IRescueDAO
    {
        public void Insert(Rescue rescue)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(NpgsqlUtils.OpenConnection()))
            {
                conn.Open();
                using (NpgsqlCommand command = new NpgsqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "INSERT INTO rescues (code, date, ag, location, animalid) VALUES (@code, @date, @ag, @location, @animalid)";
                    command.Parameters.AddWithValue("@code", rescue.Code);
                    command.Parameters.AddWithValue("@date", rescue.Date);
                    command.Parameters.AddWithValue("@ag", rescue.AG);
                    command.Parameters.AddWithValue("@location", rescue.Location);
                    command.Parameters.AddWithValue("@animalid", rescue.AnimalId);
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Rescue> GetAllRescues()
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(NpgsqlUtils.OpenConnection()))
            {
                conn.Open();
                using (NpgsqlCommand command = new NpgsqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "SELECT code, date, ag, location, animalid FROM rescues";
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        List<Rescue> rescues = new List<Rescue>();
                        while (reader.Read())
                        {
                            Rescue rescue = new Rescue();
                            rescue.Code = reader["code"].ToString();
                            rescue.Date = reader["date"].ToString();
                            rescue.AG = int.Parse(reader["ag"].ToString());
                            rescue.Location = reader["location"].ToString();
                            rescue.AnimalId = int.Parse(reader["animalid"].ToString());
                            rescues.Add(rescue);
                        }
                        return rescues;
                    }
                }
            }
        }
    }
}
