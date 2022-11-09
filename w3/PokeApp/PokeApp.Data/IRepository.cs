using PokeApp.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeApp.Data
{
    public interface IRepository
    {
        public List<Pokemon> GetAllPokemon();
    }
}
