using System;

namespace ChatGPTOne
{
    public class Program
    {
        private static void Main(string[] args)
        {
           Exercicio 10
           
            string questions = Console.ReadLine();

            do 
                if (questions == "What is pie in Math?")
                {
                    Console.WriteLine("3.14");
                    break;
                   
                }

                else if (questions == "What are you?")
                { 
                    Console.Write("Im a computer");
                   break;
                }

                else if (questions == "What is todays date?")
                { 
                    Console.Write("Check a calendar");
                    break;
                }

                else if (questions == "What are you?")
                { 
                    Console.Write("Im a computer");
                   break;
                }

                else

                    Console.WriteLine($"Sorry didn't understand the question");               
            
                       
            while(questions != "EXIT");
        }
    }
}
