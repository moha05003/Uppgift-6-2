using System;
namespace Uppgift_6_2
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(störst(6, 7));
        }
        static int störst(int tal1, int tal2)
        {
            if (tal1 == tal2)
            {
                return tal1;
            }
            else if (tal1 > tal2)
            {
                return tal1;

            }
            else
                return tal2;
        }
    }
}
