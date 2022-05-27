using System;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] listofnumbers = { 1, 3, 4 };
            int number = 1;
            Newnumber(ref listofnumbers, ref number);









        }

        static int  Newnumber(ref int[] listofnumbers, ref int number)
        {
            int[] newone = new int[listofnumbers.Length + 1];

            for (int i = 0; i < listofnumbers.Length; i++)
            {

                newone[i] = listofnumbers[i];

            }

            newone[newone.Length - 1] = number;
            Console.WriteLine(newone);
            return number;
            





        }
    }   }
