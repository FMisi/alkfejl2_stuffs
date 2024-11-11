using Kisallatok.Model;

namespace Kisallatok.DAO
{
    public interface Dao
    {
        #region muveletek
        bool AddKisallat(Kisallat kisallat);

        bool AddKategoria(Kategoria kategoria);
        bool ModifyKisallat(Kisallat kisallat);
        IEnumerable<Kisallat> GetKisallatok();
        IEnumerable<Kategoria> GetKategoriak();
        Kisallat? GetKisallat(long kisallatID);
        int KisallatokCount();
        bool ExportaljadAzonnal();

        bool DeleteKisallat(long id);

        bool HasAnimalsInKategoria(string kategoriaNev);

        bool DeleteKategoria(string kategoriaNev);
        #endregion
    }
}
