using gyak2.DAO;
using gyak2.Model;

namespace gyak2.Controller
{
    public class HeroesController
    {
        private readonly IHeroes dao;

        public HeroesController(IHeroes heroesDao)
        {
            dao = heroesDao;
        }

        public bool AddHero(Hero hero)
        {
            if (String.IsNullOrEmpty(hero.Name))
            {
                return false;
            }

            return dao.AddHero(hero);
        }

        public IEnumerable<Hero> GetHeroes()
        {
            return dao.GetHeroes();
        }

        public Hero GetHero(int id)
        {
            return dao.GetHero(id);
        }

        public bool ModifyHero(Hero hero)
        {
            return dao.ModifyHero(hero);
        }

        public int GetHeroesCount()
        {
            return dao.HeroesCount();
        }
    }
}
