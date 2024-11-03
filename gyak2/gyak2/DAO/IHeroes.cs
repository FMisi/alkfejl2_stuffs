using gyak2.Model;

// DAO
namespace gyak2.DAO
{
    public interface IHeroes
    {
        #region hero muveletek
        bool AddHero(Hero hero);
        bool ModifyHero(Hero hero);
        IEnumerable<Hero> GetHeroes();
        Hero GetHero(int heroID);
        int HeroesCount();
        #endregion
    }
}
