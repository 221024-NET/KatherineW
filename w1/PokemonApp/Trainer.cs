using System;

namespace PokemonApp
{
    class Trainer
    {
        public string trainerName {get; set;}

        public string poke1 {get; set;}
        public string poke2 {get; set;}
        public string poke3 {get; set;}
        public string poke4 {get; set;}
        public string poke5 {get; set;}
        public string poke6 {get; set;}

        public string[] pokemonTeam;
        
        public Trainer(string name, string poke1, string poke2, string poke3, string poke4, string poke5, string poke6)
        {
            this.trainerName = name;
            this.pokemonTeam = new string[6]{poke1, poke2, poke3, poke4, poke5, poke6};
        }

        public Trainer(string name, string poke1, string poke2, string poke3)
        {
            this.trainerName = name;
            this.pokemonTeam = new string[3]{poke1, poke2, poke3};
        }

        public void PrintTrainer()
        {
            Console.WriteLine("I'm " + trainerName + "! Let's battle!");
            Console.WriteLine("My team is ");

            foreach (string poke in pokemonTeam)
            {
                Console.Write(" " + poke);
            }
            Console.WriteLine("!");
        }

    }
}
