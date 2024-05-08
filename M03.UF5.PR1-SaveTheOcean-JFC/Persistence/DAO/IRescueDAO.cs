using M03.UF5.PR1_SaveTheOcean_JFC.Models;

namespace M03.UF5.PR1_SaveTheOcean_JFC.Persistence.DAO
{
    public interface IRescueDAO
    {
        public void Insert(Rescue rescue);
        public List<Rescue> GetAllRescues();
    }
}
