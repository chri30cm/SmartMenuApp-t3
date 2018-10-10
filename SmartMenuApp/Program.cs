﻿using System;
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
            string input = Console.ReadLine();

            int.TryParse(input, out int r);
            if (r != 1 && r != 2)
            {
                Console.WriteLine("Farvel");
                Console.ReadLine();
            }
            else
            {
                menu.Load(menu.ChooseLanguage(r));
                menu.Activate();
            }
        }
    }
}
