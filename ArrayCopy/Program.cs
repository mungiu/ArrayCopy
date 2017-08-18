using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] squares = { 1, 4, 9, 16 };

            ////copying squares[] values to copy[]
            //int[] copy = new int[8];
            //squares.CopyTo(copy, 2);

            //LINQ
            int[] copy = squares.ToArray();

            foreach (int value in copy)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine(string.Format(
                $"square == copy? {squares == copy}"));
        }
    }
}
