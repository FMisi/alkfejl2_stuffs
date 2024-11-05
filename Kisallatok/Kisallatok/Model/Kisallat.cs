using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kisallatok.Model
{
    /// <summary>
    /// A Kisallatot reprezentalo osztaly
    /// </summary>
    public class Kisallat
    {
        #region public properties
        public ulong ID { get; set; }
        public string Nev { get; set; }
        public string Nem { get; set; }
        public int Eletkor { get; set; }
        public double Suly { get; set; }
        public string Kategoria { get; set; }
        #endregion
    }
}
