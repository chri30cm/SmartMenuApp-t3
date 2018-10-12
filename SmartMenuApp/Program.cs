using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartMenuLibrary;

namespace SmartMenuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Run();
        }

        private void Run()
        {
            SmartMenu menu = new SmartMenu();
            Console.WriteLine("For Dansk: Tryk 1");
            Console.WriteLine("For English: Press 2");
            Console.WriteLine(" ");
            Console.Write(": ");

            int input = int.Parse(Console.ReadLine());
            if (input != 1 && input != 2)
            {
                Console.Clear();
                Console.WriteLine("Ups Farvel");
                Console.ReadLine();
            }
            else
            {
                menu.Load(menu.ChooseLanguage(input));
                menu.Activate();
            }
        }
    }
}
