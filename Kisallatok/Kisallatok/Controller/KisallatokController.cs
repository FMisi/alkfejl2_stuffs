using Kisallatok.Model;
using Kisallatok.DAO;

namespace Kisallatok.Controller
{
    public class KisallatokController
    {
        private readonly Dao dao;

        public KisallatokController(Dao kisallatokDao)
        {
            dao = kisallatokDao;
        }

        public bool AddKisallat(Kisallat kisallat)
        {
            if (String.IsNullOrEmpty(kisallat.Nev))
            {
                return false;
            }

            return dao.AddKisallat(kisallat);
        }

        public IEnumerable<Kisallat> GetKisallatok()
        {
            return dao.GetKisallatok();
        }

        public Kisallat GetKisallat(int id)
        {
            return dao.GetKisallat(id);
        }

        public bool ModifyKisallat(Kisallat kisallat)
        {
            return dao.ModifyKisallat(kisallat);
        }

        public int GetKisallatokCount()
        {
            return dao.KisallatokCount();
        }


    }
}
