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

        public bool AddKategoria(Kategoria kategoria)
        {
            if (String.IsNullOrEmpty(kategoria.Nev))
            {
                return false;
            }

            return dao.AddKategoria(kategoria);
        }

        public IEnumerable<Kisallat> GetKisallatok()
        {
            return dao.GetKisallatok();
        }

        public IEnumerable<Kategoria> GetKategoriak()
        {
            return dao.GetKategoriak();
        }

        public Kisallat? GetKisallat(long id)
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
        public bool ExportaljadAzonnal()
        {
            return dao.ExportaljadAzonnal();
        }
    }
}
