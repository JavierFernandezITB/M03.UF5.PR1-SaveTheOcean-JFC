using Microsoft.Extensions.Configuration;
using System.Configuration;

namespace SaveTheOceanForm.Persistence.Utils
{
    public class NpgsqlUtils
    {
        public static string OpenConnection()
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string jsonPath = Path.Combine(basePath, "appsettings.json");

            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile(jsonPath, optional: false, reloadOnChange: true)
                .Build();

            return config.GetConnectionString("MyPostgresConn");
        }
    }
}