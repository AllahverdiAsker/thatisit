using System;

namespace Project3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = -9;
            Converting(ref number);
           

        }
        static void Converting(ref int number)
        {
            if (number > 0)
            {
                number = number * -1;
            }
            else if (number == 0)
            {

                number = number + 1;
            }
        }
    }
}
