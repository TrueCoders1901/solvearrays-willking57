using System;

namespace SolveArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            ArraySolver blah = new ArraySolver();
            blah.AverageEvens(new int[]{-2, -5, -8});
            Console.WriteLine("-2, -5, -8");
            Console.WriteLine(blah.AverageEvens(new int[] { -2, -5, -8 }));
            Console.ReadLine();
        }
    }
}
