using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Celci: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Celci celci = new Celci(x);
            Kelvin kelvin = celci;

            Console.WriteLine(kelvin.Degree);
        }

        public class Celci
        {
            public double Degree { get; set; }

            public Celci(double degree)
            {
                Degree = degree;
            }
        }
        public class Kelvin
        {
            public double Degree { get; set; }

            public Kelvin(double degree)
            {
                Degree = degree;
            }

            public static implicit operator Kelvin(Celci degree)
            {
                return new Kelvin(degree.Degree + 273);
            }
        }
    }
}
