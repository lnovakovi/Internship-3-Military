using System;

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

        public static bool CheckIfInputIsOk(int gDistance, int wDistance, int tankDistance, int warshipDistance)
        {
            if (gDistance + wDistance < tankDistance &&
                gDistance + wDistance < warshipDistance)
            {
                return true;
            }
            else
            {             
                    return false;                
            }
        }

        
    }
}
