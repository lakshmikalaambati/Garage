using System;
using System.Collections.Generic;
using System.Text;

namespace Garage1._0
{
    public static class Util
    {

        internal static string AskForString(string prompt)
        {
            bool correct = true;
            string answer; 

            do 
            {
                Console.WriteLine(prompt);
                answer = Console.ReadLine();
                if (!string.IsNullOrEmpty(answer))
                {
                    correct = false;
                }
                else
                {
                    Console.WriteLine("Null or Empty Input..Enter valid input");
                }
            } while (correct); 

            return answer; 
        }

        internal static int AskForInt(string prompt)
        {
            bool success;
            int answer; //Scope

            do //Repeat
            {
                string input = AskForString(prompt);
                success = int.TryParse(input, out answer);
                if (!success)
                {
                    Console.WriteLine("Wrong format only numbers");
                }
            } while (!success);
            return answer;
        }
    }
}
