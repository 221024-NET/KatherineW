using PokeApp.Data;
using PokeApp.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeApp.App
{
    public class Game
    {
        // Fields
        IRepository repo;

        // Constructors
        public Game(IRepository repo)
        {
            this.repo = repo;
        }

        // Methods
        public bool UpdatePokemonName(Pokemon poke)
        {
            string newName = $"{poke.Name}update";
            try { this.repo.UpdatePokemonName(newName, poke.Id); }
            catch { return false; }

            poke.Name = newName;
            return true;
        }
    }
}
