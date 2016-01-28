using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass1
{
    class UserInterface
    {
        // >Methods
        //
        // >Print a menu to the screen and await input. If input is valid, return the number they selected.
        public int GetUserInput()
        {
            // >Print the menu.
            this.PrintMenu();
            // >Get user input.
            string input = Console.ReadLine();

            while (input != "1" && input != "2")
            {
                Console.WriteLine("That is not a valid entry");
                Console.WriteLine("Please make a valid choice");
                Console.WriteLine("");
                // >Reprint the menu.
                this.PrintMenu();
                // >Get user input.
                input = Console.ReadLine();
            }

            return Int32.Parse(input);
        }
        
        // >Print the input to the screen.
        public void PrintAllOutput(string allOutPut)
        {
            Console.WriteLine(allOutPut);
        }

        // >Writes a menu to the screen.
        void PrintMenu()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Print List");
            Console.WriteLine("2. Exit");
        }





    }
}
