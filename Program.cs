using System;
using System.Threading;

namespace StopWatch1
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = 10s => 10 segundo");
            Console.WriteLine("M = 10m => 10 minutos ");
            Console.WriteLine("0 = sair");
            Console.WriteLine("Quanto tempo deseja contar?");

            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length-1,1));
            int time = int.Parse(data.Substring(0, data.Length -1));
            int multiplier = 1;

            if(type == 'm')
            multiplier = 60;

            if(time == 0)
            System.Environment.Exit(0);

            PreStart(time*multiplier);
        }

        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("GO!!!!");
            Thread.Sleep(2500);

            Start(time);

        }
        static void Start(int time)
        {
            
            int currentTime = 0;
            
            while (currentTime != time)

            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Stopwatch finalizado, retornando para o menu");
            Thread.Sleep(2500);
        }  
         
    }
}