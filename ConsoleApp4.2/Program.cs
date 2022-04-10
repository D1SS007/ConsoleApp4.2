using System;

namespace ConsoleApp4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isHeroAlive = true;
            
            double maxHealth = 10;
            double maxMana = 10;

            int healthBarYPosition = 3;
            int manaBarYPosition = 6;
            int decreasingOfBarSize = 10;
            int percentage = 100;          

            while (isHeroAlive)
            {
                Console.WriteLine("Введите процент здоровья");

                double health = Convert.ToDouble(Console.ReadLine())/ decreasingOfBarSize;

                Console.WriteLine("Введите процент маны");

                double mana = Convert.ToDouble(Console.ReadLine()) / decreasingOfBarSize;

                Console.SetCursorPosition(0, healthBarYPosition);
                
                DrawBar(health, maxHealth, '#', '_', percentage, "здоровья");
                
                Console.SetCursorPosition(0, manaBarYPosition);

                DrawBar(mana, maxMana, '#', '_', percentage, "маны");

                if (health <= 0)
                {
                    Console.WriteLine("Здоровье ниже нуля! Герой умер!");
                    isHeroAlive = false;                    
                }

                Console.ReadKey();

                Console.Clear();
            }            
        }
        static void DrawBar(double value, double maxValue, char symbolOfValue, char symbolOfEmptyValue, int percentage , string text)
        {
            Console.Write("[");

            for (int i = 0; i < value; i++)
            {
                Console.Write(symbolOfValue);
            }

            for (double i = value; i < maxValue; i++)
            {
                Console.Write(symbolOfEmptyValue);
            }
            Console.WriteLine("]");

            double percentOfHealth = value * percentage / maxValue;

            Console.WriteLine($"У героя {percentOfHealth} % {text}");
        }        
    }
}

