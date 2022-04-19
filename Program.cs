using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSlearning 
{
    class Program
    {
        static void Main(string[] args)
        {
            string characterName = "John";
            int characterAge;
            characterAge = 35;

            Console.WriteLine("There was once a man named " + characterName);
            Console.WriteLine("He was " + characterAge + " years old");
            Console.WriteLine("He really liked the name " + characterName);
            Console.WriteLine("But didn't like being " + characterAge);
            Console.ReadLine();
        }
    }
}

