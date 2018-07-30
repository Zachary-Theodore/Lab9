using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> studentNames = new List<string>()
        {
            "Mr. Meeseeks",
            "Lord Canti",
            "Solid Snake",
            "Cloud Strife",
            "King Mrgl-Mrgl"
        };
            List<string> hobbies = new List<string>()
        {
            "Completeing Tasks Before the Pain Drives them insane.",
            "Starting fires.",
            "Redacted",
            "Chocabo Breeding",
            "Observing the life of a Murloc"
        };
            List<string> origin = new List<string>()
        {
            "Meeseeks Box",
            "Naota Nandaba's Head",
            "Redacted",
            "Nibelheim",
            "Unclear"
        };
            List<string> birthdays = new List<string>()
        {
            "Now",
            "Then",
            "Later",
            "12/12/1986",
            "Party Time"
        };

            Console.WriteLine("Would you like to add any info.(Y/N)");
            string userInput = Console.ReadLine();
            bool truefalse = true;
            while (truefalse)
            {
                if (Regex.IsMatch(userInput, @"^y|Y$"))
                {
                    Console.WriteLine("Enter a Name to be stored:");
                    studentNames.Add(Console.ReadLine());
                    Console.WriteLine("Enter a hobby:");
                    hobbies.Add(Console.ReadLine());
                    Console.WriteLine("Enter a origin:");
                    origin.Add(Console.ReadLine());
                    Console.WriteLine("Enter a birthday:");
                    birthdays.Add(Console.ReadLine());
                    truefalse = false;
                }
                else if (Regex.IsMatch(userInput, @"^n|N$"))
                {
                    Console.WriteLine("Ok Lets Continue");
                    truefalse = false;
                }
                else
                {
                    Console.WriteLine("Please enter a y or n");
                    userInput = Console.ReadLine();
                }
            }

            Console.WriteLine("Enter a Number to learn more about a subject.");
            int nameNum = int.Parse(Console.ReadLine());
            while (nameNum<0 || nameNum>studentNames.Count)
            {

                Console.WriteLine("Error: Entered a value either out of Range or wrong format");
                Console.WriteLine("Please enter a number between 1 and 5;");
                nameNum = int.Parse(Console.ReadLine());
            }
            int indexName = nameNum;
            Console.WriteLine($"You chose {studentNames[indexName - 1]}!!!");
            Console.WriteLine("Would you like to learn more?(enter Origin or Hobby)");
            string pick1 = Console.ReadLine();
            while (!Regex.IsMatch(pick1, @"^Origin|origin|Hobby|hobby$"))
            {

                Console.WriteLine("Error: Please make sure to only enter one of the two options");
                Console.WriteLine("Please enter either Hobby or Origin");
                pick1 = Console.ReadLine();
            }
            if (pick1 == "Hobby" || pick1 == "hobby")
            {
                Console.WriteLine($"You chose {pick1}, {studentNames[indexName - 1]} loves to {hobbies[indexName - 1]} ");
            }
            else
            {
                Console.WriteLine($"You chose {pick1}, {studentNames[indexName - 1]} comes from {origin[indexName - 1]}. ");
            }
        }


    }
    
}
