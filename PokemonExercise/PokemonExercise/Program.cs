using System;
using System.Collections.Generic;
using System.Linq;

public class Pokemon
{
    public string Name { get; set; }
    public string Type { get; set; } // Fajta
    public int Strength { get; set; } // Erő

    public Pokemon(string name, string type, int strength)
    {
        Name = name;
        Type = type;
        Strength = strength;
    }
}

public class Program
{
    public static void Main()
    {
        var pokemons = new List<Pokemon>
        {
            new Pokemon("Charizard", "Sárkány", 534),
            new Pokemon("Dragonite", "Sárkány", 600),
            new Pokemon("Pikachu", "Villám", 320),
            new Pokemon("Gyarados", "Vízi", 540),
            new Pokemon("Salamence", "Sárkány", 700),
            new Pokemon("Rayquaza", "Sárkány", 680),
            new Pokemon("Bulbasaur", "Növény", 318),
        };

        // 1. Listázd ki az összes sárkányt
        var dragons = pokemons.Where(p => p.Type == "Sárkány");
        Console.WriteLine("Sárkány típusú Pokémonok:");
        foreach (var dragon in dragons)
        {
            Console.WriteLine(dragon.Name);
        }

        // 2. Számold meg az összes sárkányt
        int dragonCount = pokemons.Count(p => p.Type == "Sárkány");
        Console.WriteLine($"\nSárkányok száma: {dragonCount}");

        // 3. Keresd meg a legerősebb Pokémon-t
        var strongestPokemon = pokemons.OrderByDescending(p => p.Strength).First();
        Console.WriteLine($"\nA legerősebb Pokémon: {strongestPokemon.Name}, Erő: {strongestPokemon.Strength}");

        // 4. Listázd ki az összes 600-nál nagyobb erővel rendelkező Pokémont (csak a nevük)
        var strongPokemons = pokemons.Where(p => p.Strength > 600).Select(p => p.Name);
        Console.WriteLine("\n600-nál erősebb Pokémonok:");
        foreach (var name in strongPokemons)
        {
            Console.WriteLine(name);
        }

        // 5. Listázd ki őket abc sorrendben
        var strongPokemonsSorted = strongPokemons.OrderBy(name => name);
        Console.WriteLine("\n600-nál erősebb Pokémonok abc sorrendben:");
        foreach (var name in strongPokemonsSorted)
        {
            Console.WriteLine(name);
        }

        // 6. Átlagold az összes Pokémon erejét
        double averageStrength = pokemons.Average(p => p.Strength);
        Console.WriteLine($"\nAz összes Pokémon átlagos ereje: {averageStrength}");
    }
}
