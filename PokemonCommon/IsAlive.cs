using System.Threading.Channels;
using PokemonCommon.Pokemons;

namespace PokemonCommon;

public static class IsAlive
{
    public static bool HealthPointCheck(Pokemon pokemonTarget, Pokemon pokemonAttacker)
    {
        if (pokemonAttacker.HealthPoints <= 0)
        {
            Console.WriteLine(pokemonTarget.Name + " won the match.");
            return false;
        }
        else if (pokemonTarget.HealthPoints <= 0)
        {
            Console.WriteLine(pokemonAttacker.Name + " won the match.");
            return false;
        }
        return true;
    }
}