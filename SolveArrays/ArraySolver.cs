using System;
using System.Collections.Generic;

namespace SolveArrays
{
    public class ArraySolver
    {
        public int Sum(int[] listofnumbers)
        {
            int total = 0;
            foreach( var number in listofnumbers )
            {
                total = total + number;
            }
            return total;
     
        }

        public int SumEvens(int[] listofnumbers)
        {
            int total = 0;
            foreach( var number in listofnumbers )
            {
                if(number % 2 == 0)
                {
                    total = total + number;
                }
            }
            return total;
        }

        public double AverageEvens(int[] listofnumbers)
        {
            double total = 0;
            double count = 0;
            foreach( int number in listofnumbers )
            {
                if( number % 2 == 0 )
                {
                    total = total + number;
                    count++;
                }
            }

            if (count == 0)
            { return 0; }

            return total/count;
        }

        public bool IsSumOdd(List<int> listofnumbers)
        {

            int total;
            total = 0;

            foreach( var number in listofnumbers )
            {
                
                    total = total + number;
                
            }

            return (total%2 == 1)||(total%2==-1);
        }
    }
}
