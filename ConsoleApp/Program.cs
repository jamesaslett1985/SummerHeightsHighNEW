using System;
using System.Linq;

namespace Code
{
    class Program
    {
        static void Main()
        {
            PrintToConsole("Welcome to the Summer Heights High character lookup system.");
            RunSummerHeighsHighUntilStopped();
            LineSpace();
            PrintToConsole("Thanks and goodbye. Press any key to exit.");
        }

        private static void RunSummerHeighsHighUntilStopped()
        {
            do
            {
                LineSpace();
                PrintToConsole("Please enter a character name from the following:");
                DisplayListOfCharacters();

                var userInput = Console.ReadLine();
                var characters = SummerHeightsHighService.Characters;

                while (!characters.ContainsKey(userInput))
                {
                    Console.WriteLine("Character not recognised. Please try again.");
                    userInput = Console.ReadLine();
                }

                LineSpace();

                var chosenCharacter = characters[userInput];
                Console.WriteLine($"The character you have chosen is {chosenCharacter.Name} ");

                var characterInfo = SummerHeightsHighService.ReturnCharacter(chosenCharacter);
                Array.ForEach(characterInfo, Console.WriteLine);

                LineSpace();
                PrintToConsole("Would you like to choose another character? Y/N");
                LineSpace();
            }
            while (char.ToLower(Console.ReadKey().KeyChar) == 'y');
        }

        private static void DisplayListOfCharacters()
        {
            var listOfCharacters = SummerHeightsHighService.Characters.Keys.ToArray();

            foreach (var character in listOfCharacters)
            {
                Console.Write(character.ToString() + " / ");
            }
        }

        private static void LineSpace()
        {
            Console.WriteLine();
        }

        private static void PrintToConsole(string input)
        {
            Console.WriteLine(input);
        }
    }
}
