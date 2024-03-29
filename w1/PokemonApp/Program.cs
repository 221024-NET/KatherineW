﻿using System;
using PokemonApp;

namespace Program{

    class Program{

        static void Main(string[] args)
        {
            //Initializing an object
            //We call the constructor, and pass it the desired values for this object
            Pokemon pikachu = new Pokemon("Pikachu", 25, "Electric", 12, "Static");

            Pokemon pikachu2 = new Pokemon("Pikachu", 25, "Electric", 12);
            Pokemon charizard = new Pokemon("Charizard");

            Trainer trainer = new Trainer("Dave", "Trevenent", "Eevee", "Phantump", "Charmander", "Bulbasaur", "Arceus");
            Trainer lass = new Trainer("Young Lass", "Sylveon", "Spritzee", "Alcremie", "Kirlia", "Steenee", "Curiefly");
            Trainer gymLeader = new Trainer("Gym Leader Helen", "Phantump", "Gourgeist", "Dhelmise");
            


            //Calling an Instance method - belongs to the object itself.
            //Called by using object.method() 
        //    pikachu.PrintName();
        //    pikachu2.PrintName();
        //    charizard.PrintName();

            trainer.PrintTrainer();
            lass.PrintTrainer();
            gymLeader.PrintTrainer();
            //Calling a Static method - belongs to the class.
            //Called by using Class.method()
        //    Pokemon.PrintMessage();

            //Accessing a Static field - belongs to the class.
            //Called by referencing the class itself.
        //    Console.WriteLine(Pokemon.isPokemon);


        //    Console.WriteLine(pikachu.ToString());

        //    Console.WriteLine(pikachu.name);

        }
        

    }

}