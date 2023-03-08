using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace LogicalProgram
{

    class Client
    {

        public static void Main()
        {
            var serverObj = new Server(new DollarConverter());

            Console.WriteLine("Enter doller in number");
            string userInput = Console.ReadLine();

            if (userInput.Contains(','))
            {
                string[] data = userInput.Split(',');

                string doller = data[0];
                string cent = data[1];

                var resultdoller = serverObj.GetWorsBeforeComma(Convert.ToInt32(doller));
                var resultcent = serverObj.GetWordsAfterComma(Convert.ToInt32(cent));

                Console.WriteLine($" {resultdoller} dollars and {resultcent} cent");
            }
            else
            {
                var resultdoller = serverObj.GetWorsBeforeComma(Convert.ToInt32(userInput));
                Console.WriteLine($" {resultdoller} dollars");
            }
            Console.ReadKey();
        }

       

    }
}




