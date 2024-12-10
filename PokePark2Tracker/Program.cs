using System;
using PokeCS;

namespace PokePark2Tracker
{
    class Program
    {
        public static PokemonTracker myPoke = new PokemonTracker();

        static void Main(string[] args)
        {
           PokemonTracker.GetPokemon(1);
        }

        
    }
}