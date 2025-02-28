using System;

namespace VariousOperators
{
    public class Program
    {
        private static void Main(string[] args)
        {
            //exercicio 4
            Console.WriteLine("Insere numero inteiro -não negativo: ");
            
            string str = Console.ReadLine();
            int n = int.Parse(str);

            
            Convert.ToByte(n);


           Console.WriteLine(n/2);
           Console.WriteLine(n<<3);
           Console.WriteLine(n^6);
           Console.WriteLine(n>10);

        }
    }
}
