// Written by Swornashabi
// 2/17/2025

using System;
using System.Collections.Generic;

namespace Simula_s_Test
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Chest chest = new Chest();

            while(true)
            {
                Console.WriteLine($"The chest is {chest.GetState()}. What do you want to do?");
                string command = Console.ReadLine();

                switch(command)
                {
                    case "lock":
                        chest.Lock();
                        break;
                    case "unlock":
                        chest.Unlock();
                        break;
                    case "open":
                        chest.Open(); break;
                    case "close":
                        chest.Close(); break;
                    default:
                        Console.WriteLine("Invalid command. Try again.");
                        break;
                }
            }

        }

    }
}
