using Kisallatok.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kisallatok.DAO
{
    public class DaoImpl : Dao
    {
        private IList<Kisallat> kisallatok = new List<Kisallat>();

        public bool AddKategoria(Kategoria kategoria)
        {
            throw new NotImplementedException();
        }

        public bool AddKisallat(Kisallat kisallat)
        {
            if (kisallat == null) { return false; }

            // ha nem akarok ugyanolyan nevut hozzaadni:
            // if (kisallatok.Any(x => x.Nev == kisallat.Nev)) { return false; }

            kisallatok.Add(kisallat);
            return true;
        }

        public Kisallat GetKisallat(int kisallatID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Kisallat> GetKisallatok()
        {
            throw new NotImplementedException();
        }

        public int KisallatokCount()
        {
            throw new NotImplementedException();
        }

        public bool ModifyKisallat(Kisallat kisallat)
        {
            throw new NotImplementedException();
        }
    }
}
