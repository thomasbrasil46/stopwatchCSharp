﻿using System;
using System.Threading;

namespace stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu ()
        {
            Console.Clear();
            Console.WriteLine("S = Segundo => 10 S = 10 segundos.");
            Console.WriteLine("M = Minuto => 1 M = 1 minuto.");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja contar?");

            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length-1, 1));
            Console.WriteLine(data);
            Console.WriteLine(type);
        }

        static void Start (int time)
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
            Console.WriteLine("Stopwatch finalizado.");
            Thread.Sleep(2500);
        }
    }
}
