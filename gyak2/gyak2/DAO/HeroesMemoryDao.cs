using gyak2.Model;

// DAOImpl
namespace gyak2.DAO
{
    public class HeroesMemoryDao : IHeroes
    {
        private IList<Hero> heroes = new List<Hero>();
        public bool AddHero(Hero hero)
        {
            if (hero == null) { return false; }

            // nem akarok ugyanolyna host hozzaadni
            if (heroes.Any(x => x.HeroName == hero.HeroName)) { return false; }

            heroes.Add(hero);
            return true;
        }

        public Hero GetHero(int heroID)
        {
            return heroes.FirstOrDefault(x => x.ID == heroID);
        }

        public IEnumerable<Hero> GetHeroes()
        {
            return heroes;
        }

        public int HeroesCount()
        {
            return heroes.Count;
        }

        public bool ModifyHero(Hero hero)
        {
            int storedIndex = heroes.IndexOf(heroes.FirstOrDefault(x => x.ID == hero.ID));

            if (storedIndex == -1) { return false; }

            heroes[storedIndex] = hero;

            return true;
        }
    }
}
