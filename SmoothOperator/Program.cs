using System;

namespace SmoothOperator
{
    public class Program
    {
        private static void Main(string[] args)
        {
            //exercicio 1
            Console.WriteLine("Insere numero inteiro: ");
            
            string str = Console.ReadLine();
            int n = int.Parse(str);

            
            Convert.ToSByte(n);

           Console.WriteLine(--n);
           Console.WriteLine(++n);


        }
    }
}
