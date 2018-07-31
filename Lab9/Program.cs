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
            List<Students> students = new List<Students>();
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
            for (int i = 0; i < studentNames.Count; i++)
            {
            Students temp1 = new Students();
                temp1.Name = studentNames[i];
                temp1.Hobbie = hobbies[i];
                temp1.Origin = origin[i];
                temp1.Birthday = birthdays[i];

                students.Add(temp1);
            }

            while (true)
            {
                Console.Clear();
                Students temp = new Students();
                Console.WriteLine("Please provide a Name:");
                temp.Name = (Console.ReadLine());
                Console.WriteLine("Please provide a hobbie:");
                temp.Hobbie = (Console.ReadLine());
                Console.WriteLine("Please provide an origin:");
                temp.Origin = Console.ReadLine();
                Console.WriteLine("Please provide a birthday:");
                temp.Birthday = (Console.ReadLine());

                students.Add(temp);// add the temp object to the employees list
                Console.WriteLine("Do you want to add more employees?");
                string choice = Console.ReadLine();
                if (choice == "N")
                {
                    break;
                }
            }

            foreach (Students e in students)
            {
                Console.WriteLine($"{e.Name}, {e.Hobbie}, {e.Origin}, {e.Birthday}");
                Console.WriteLine("===================================================");
            }


        }


    }

}
