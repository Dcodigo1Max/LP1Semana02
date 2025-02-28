using System;

namespace ValoresEspeciais
{
    public class Program
    {
        private static void Main(string[] args)
        {
            //exercicio 6
            long lg = 2;
            int i = (int) lg;

            float f = 3.4f;
            double x = (double) f;

            double c = 4.333;
            short s =(short) c;

            Console.WriteLine(i);
            Console.WriteLine(x);
            Console.WriteLine(s);

            double z = double.PositiveInfinity;
            double y = double.NegativeInfinity;

            double h = double.PositiveInfinity/double.NegativeInfinity;
            float h1 = float.NaN;

            Console.WriteLine(z);
            Console.WriteLine(y);
            Console.WriteLine(h1);


            //Exercicio 7
            int p = short.MaxValue;
            Console.WriteLine((short) (p+1));

            double q = 2 * double.MaxValue;
            Console.WriteLine(q);

            double a = double.MaxValue + 1;
            Console.WriteLine(a);


            float f1, f2;

            f1 = f2 = 10000.0f;

            Console.WriteLine(f1 ==f2 + 0.0001f);






        }
    }
}
