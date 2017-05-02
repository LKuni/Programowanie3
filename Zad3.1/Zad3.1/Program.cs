using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad3._1
{
    public class Program
    {

        public double DivideNumbers(double A, double B)
        {
            if (B == 0)
                throw new ArgumentOutOfRangeException();
            return A / B;
        }


        static void Main(string[] args)
        {
            //Console.ReadLine();
        }
    }
}
