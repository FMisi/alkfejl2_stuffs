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

        private IList<Kategoria> kategoriak = new List<Kategoria>();

        public bool AddKategoria(Kategoria kategoria)
        {
            if (kategoria == null) { return false; }

            // ha nem akarok ugyanolyan nevut hozzaadni:
            if (kategoriak.Any(x => x.Nev == kategoria.Nev)) { return false; }

            kategoriak.Add(kategoria);
            return true;
        }

        public bool AddKisallat(Kisallat kisallat)
        {
            if (kisallat == null) { return false; }

            // ha nem akarok ugyanolyan nevut hozzaadni:
            // if (kisallatok.Any(x => x.Nev == kisallat.Nev)) { return false; }

            kisallatok.Add(kisallat);
            return true;
        }

        public IEnumerable<Kategoria> GetKategoriak()
        {
            return kategoriak;
        }

        public Kisallat GetKisallat(long kisallatID)
        {
            return kisallatok.FirstOrDefault(x => x.ID == kisallatID);
        }

        public IEnumerable<Kisallat> GetKisallatok()
        {
            return kisallatok;
        }

        public int KisallatokCount()
        {
            return kisallatok.Count;
        }

        public bool ModifyKisallat(Kisallat kisallat)
        {
            int storedIndex = kisallatok.IndexOf(kisallatok.FirstOrDefault(x => x.ID == kisallat.ID));

            if (storedIndex == -1) { return false; }

            kisallatok[storedIndex] = kisallat;

            return true;
        }
    }
}
