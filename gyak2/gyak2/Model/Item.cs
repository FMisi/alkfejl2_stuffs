namespace gyak2.Model
{
    public class Item
    {
        #region public properties
        public int ID { get; set; }
        public int HeroID { get; set; }
        public string Name { get; set; }
        public virtual Hero ReferencedHero { get; set; }
        #endregion
    }
}
