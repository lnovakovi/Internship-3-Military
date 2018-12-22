using System;
using System.Collections.Generic;
using System.Text;

namespace Military
{
    public static class UtilityClass
    {
        public static int TryParseInt(string inputMessage)
        {
            Console.WriteLine(inputMessage);
            var enterInput = false;         
            var output = 0;
            do
            {
                var choiceMade = Console.ReadLine();
                enterInput = int.TryParse(choiceMade, out output);
                if (!enterInput)
                {
                    Console.WriteLine("Wrong type.");
                }
            } while (!enterInput);

            return output;
        }

        
    }
}
