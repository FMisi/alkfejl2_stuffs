namespace Kisallatok.Model
{
    /// <summary>
    /// A Kisallatot reprezentalo osztaly
    /// </summary>
    public class Kisallat
    {
        #region public properties
        public long ID { get; set; }
        public string Nev { get; set; }
        public string Nem { get; set; }
        public int Eletkor { get; set; }
        public decimal Suly { get; set; }
        public string Kategoria { get; set; }
        #endregion
    }
}
