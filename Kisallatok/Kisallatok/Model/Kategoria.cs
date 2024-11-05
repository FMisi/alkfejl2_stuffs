using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kisallatok.Model
{
    /// <summary>
    /// A Kategoriat reprezentalo osztaly
    /// </summary>
    public class Kategoria
    {
        #region public properties
        public string Nev { get; set; }
        public virtual Kisallat ReferencedKisallat { get; set; }
        #endregion
    }
}
