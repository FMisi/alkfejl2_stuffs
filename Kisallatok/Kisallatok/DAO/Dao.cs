using Kisallatok.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kisallatok.DAO
{
    public interface Dao
    {
        #region muveletek
        bool AddKisallat(Kisallat kisallat);

        bool AddKategoria(Kategoria kategoria);
        bool ModifyKisallat(Kisallat kisallat);
        IEnumerable<Kisallat> GetKisallatok();
        Kisallat GetKisallat(int kisallatID);
        int KisallatokCount();
        #endregion
    }
}
