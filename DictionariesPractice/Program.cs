using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionariesPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<key data type, value data type> dictionaryName
            Dictionary<string, int> studentGrades = new Dictionary<string, int>()
            {
                { "Kerry", 90 },
                { "Barry", 85 },
                { "Michelle", 100 }
            };

            Dictionary<string, string> snackMachine = new Dictionary<string, string>()
            {
                { "A1", "Snickers" },
                { "A2", "Sweedish Fish" },
                { "A3", "Sour Patch Kids" },
                { "A4", "Funyuns" }
            };

            Dictionary<int, string> drinkMachine = new Dictionary<int, string>();
            //using the Add method, let's add drinks to our drink machine.
            //This machine uses just a number to vend an item instead of
            //a letter-number pair. 

            drinkMachine.Add(10, "Ginger Ale");
            drinkMachine.Add(11, "Coca Cola");
            drinkMachine.Add(12, "Sprite");
            drinkMachine.Add(13, "Jack Daniels");
            drinkMachine.Add(14, "Orange Juice");
            drinkMachine.Add(15, "Gatorade");


            //count is a property. Returns the size of the dictionary.
            Console.WriteLine(drinkMachine.Count);

            //We have another property, called .Key
            foreach(KeyValuePair<int, string> drink in drinkMachine)
            {
                Console.WriteLine(drink.Key);
            }

            foreach(KeyValuePair<int, string> drink in drinkMachine)
            {
                Console.WriteLine(drink.Value);
            }


            //Create a dictionary for a theater coat check with 10 elements.
            //key is number is number and value is coat style
            //print all voalues to the console.

            Dictionary<int, string> coatCheck = new Dictionary<int, string>()
            {
                { 1, "trench coat" },
                { 2, "blazer" },
                { 3, "leather jacket" },
                { 4, "down jacket" },
                { 5, "pink windbreaker" },
                { 6, "hoodie" },
                { 7, "poncho" },
                { 8, "raincoat" },
                { 9, "Banana suit" },
                { 10, "Snuggie" }
            };

            foreach(KeyValuePair<int, string> coat in coatCheck)
            {
                Console.WriteLine(coat.Value);
            }

            Dictionary<string, string> valletService = new Dictionary<string, string>()
            {
                { "Gray", "Mazda" },
                { "Smith", "Kia" },
                { "Boyd", "Ford" },
                { "Adams", "Chrystler" },
                { "Davis", "Chevy" },
                { "Kepich", "Tesla" },
                { "James", "BMW" },
                { "Fink", "Nissan" },
                { "Micheletti", "Honda" },
                { "Brown", "VolksWagen"}
            };

            foreach(KeyValuePair<string, string> car in valletService)
            {
                Console.WriteLine(car.Key);
            }

            Dictionary<string, int> zooAnimals = new Dictionary<string, int>()
            {
                { "Lion", 40 },
                { "Zebra", 4 },
                { "Walrus", 67 },
                { "lemur", 43 },
                { "Great White Shark", 2 },
                { "Orangutang", 5 },
                { "Ostrach", 5 },
                { "Flamingo", 79 },
                { "Cat", 24 },
                { "Parrot", 32 }
            };

            //print the animal with the highest quantity to the console

            int highest = 0;
            foreach(KeyValuePair<string, int> animal in zooAnimals)
            {
                if (animal.Value > highest)
                {
                    highest = animal.Value;
                }
            }

            Console.WriteLine(highest);

            foreach(KeyValuePair<string, int> animal in zooAnimals)
            {
                if (animal.Value == highest)
                {
                    Console.WriteLine(animal.Key);
                }
            }
        }
    }
}
