using System;

namespace ConsoleApp4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isHeroAlive = true;            
            double maxHealth = 10;

            while (isHeroAlive)
            {
                Console.WriteLine("Введите процент здоровья");

                double health = Convert.ToDouble(Console.ReadLine())/10;

                DrawHealthBar(health, maxHealth, 3, '#', '_');

                if (health <= 0)
                {
                    Console.WriteLine("Здоровье ниже нуля! Герой умер!");
                    isHeroAlive = false;                    
                }

                Console.ReadKey();

                Console.Clear();
            }            
        }
        static void DrawHealthBar(double health, double maxHealth, int Yposition, char symbolOfHealth, char symbolOfEmptyHealth)
        { 
            Console.SetCursorPosition(0, Yposition);

            Console.Write("[");

            for (int i = 0; i < health; i++)
            {
                Console.Write(symbolOfHealth);
            }

            for (double i = health; i < maxHealth; i++)
            {
                Console.Write(symbolOfEmptyHealth);
            }
            Console.WriteLine("]");

            double percentOfHealth = health * 100 / maxHealth;

            Console.WriteLine($"У героя {percentOfHealth} % здоровья");
        }        
    }
}
