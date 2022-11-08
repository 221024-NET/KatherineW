using System;

namespace CollectionsExamples.App {
    public class DictionaryTests {
        Dictionary<string,string> dictionary = new Dictionary<string,string>();
        
        public DictionaryTests() {
            dictionary.Add("animal", "dog");
            //dictionary.Add("animal", "bird"); <-- Will NOT work. "animal" is the key, can only be one animal
            dictionary.Add("canine", "cat"); //We know cat is not a canine, just go with it
            dictionary.Add("herbivore", "hamster");

            Console.WriteLine("------Initializing Dictionary------");
            printSomething();
            Console.WriteLine("-----------------------------------");

            dictionary["canine"] = "dog"; //turns cat to dog

            Console.WriteLine("-------Modifying: Cat to Dog--------");
            printSomething();
            Console.WriteLine("------------------------------------");

            dictionary.Remove("animal"); //deletes the entry with the key "animal"

            Console.WriteLine("------Removing: Animal--------------");
            printSomething();
            Console.WriteLine("------------------------------------");
        }

        public void printSomething() {
            foreach (KeyValuePair<string,string> t in dictionary) {
                Console.WriteLine("Key: {0}, Value: {1}",t.Key, t.Value);
            }
        }
    }
}