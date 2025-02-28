using System;
using System.Data;

namespace GuessTheNumber
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Random rnd = new Random();
            int numberToGuess = rnd.Next(31);
            
            

           
            while(true)
            {
                Console.WriteLine("Escreve um numero inteiro entre 0 e 30:");
                string str1 = Console.ReadLine();
                

                //if (str1 < 0)
                
                

                if (Convert.ToInt32(str1)<0 || Convert.ToInt32(str1)>30)
                {
                    Console.WriteLine("O numero inserido é  menor que 0 ou maior que 30");
                    
                }




                else if (Convert.ToInt32(str1) < numberToGuess || Convert.ToInt32(str1) > numberToGuess)
                {
                    Console.WriteLine("O numero inserido é  maior ou menor que o numero aleatorio");
                }




                else if(Convert.ToInt32(str1) == numberToGuess)
                {
                    Console.WriteLine("O numero inserido é  igual ao numero aleatorio");

                }

                break;


            }




        }
    }
}
