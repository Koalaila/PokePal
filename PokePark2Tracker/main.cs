using System;
using PokeCS;

namespace PokePark2Tracker
{
    class Program
    {
        private static PokemonTracker myPoke = new PokemonTracker();

        static void Main(string[] args)
        {
            Console.WriteLine(PokeCS.PokemonTracker.GetPokemon(165));
            //example usage for now
        }

        
    }
}