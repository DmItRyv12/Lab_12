using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Cat.voice);
            Console.ReadKey();
        }
        public class Cat
        {
            public static string voice;
            public const int countFeet = 4;
            public readonly bool wool = true;
            public string Neme { get; set; }

            public string Color { get; set; }

            int age;
            public int Age
            {
                set
                {
                    if (value > 0)
                    {
                        age = value;
                    }
                    else
                    {
                        Console.WriteLine("Возраст не может быть отрицательным");
                    }

                }
                get
                {
                    return age;
                }
            }
            static Cat()
            {
                voice = "Мяу";
            }
            public Cat(string neme, string color, int age, bool wool)
            {
                Neme = neme;
                Color = color;
                Age = age;
                this.wool = wool;
            }
            public void Say()
            {
                Console.WriteLine("Мяу! Меня зовут {0}! У меня {1} цвет. Мне {2} лет", Neme, Color, Age);
            }
        }
    }
}
