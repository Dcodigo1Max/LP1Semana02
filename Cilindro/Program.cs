using System;

namespace Cilindro
{
    public class Program
    {
        private static void Main(string[] args)
        {
            //Exercicio 5
            
            //Pedir altura
            Console.WriteLine("Escreve a altura do cilindro:");
            string str1 = Console.ReadLine();
            int a = int.Parse(str1);
            Convert.ToDouble(a);

            //Pedir raio
            Console.WriteLine("Escreve o raio do cilindro:");
            string str2 = Console.ReadLine();
            int r = int.Parse(str2);
            Convert.ToDouble(r);
            
            
            //Calculo Volume
            Console.WriteLine("Calculo V:");
            double v = Math.PI * Math.Pow(r*r, a);
            
            Console.WriteLine(v);
            

            //Areasuperficie Sa
            Console.WriteLine("Calculo Sa:");
            double Sa = 2 *Math.PI * r * (r * a);
            Console.WriteLine(Sa);


        }
    }
}
