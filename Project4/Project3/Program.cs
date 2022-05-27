using System;

namespace Project3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] allnumbers = { -1, -2, -4, -3 };
            Find(ref allnumbers);
            

        }

        static void Find(ref int[] allnumbers)
        
        {
            for(int i=0;i<allnumbers.Length; i++)
            {
                if (allnumbers[i] < 0)
                {
                    allnumbers[i] = allnumbers[i] * -1;
                }

                else if (allnumbers[i] == 0)
                {
                    allnumbers[i] = allnumbers[i] + 1;
                }

            }
            


        }
    }
}
