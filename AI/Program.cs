using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Media;

namespace AI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SoundPlayer workSound = new SoundPlayer(Properties.Resources.work);
            SoundPlayer dubstepSound = new SoundPlayer(Properties.Resources.dubstep);

            async Task PlayWork()
            {
                workSound.Play();
            }

            async Task PlayDubstep()
            {
                dubstepSound.Play();
            }

            int seconds = 0;
            Console.ForegroundColor = ConsoleColor.Blue;

            Random randTicks = new Random();

            Console.WriteLine("SeregaAI 2");

            while(true)
            {
                dubstepSound.Stop();

                Console.WriteLine("\nВведите запрос:");
                string request = Console.ReadLine();

                Console.WriteLine("\n");

                int totalTicks = randTicks.Next(40, 57);

                PlayWork();

                for (int ticks = 0; ticks < totalTicks; ticks++)
                {
                    int dotCount = (ticks % 3) + 1;
                    seconds = ticks / 3;
                    string dots = new string('.', dotCount).PadRight(3);

                    Console.Write($"\rОбработка запроса{dots}     Думает: {seconds} с ");

                    Thread.Sleep(333);
                }

                workSound.Stop();

                Thread.Sleep(3000);

                Console.WriteLine("\n");

                PlayDubstep();

                string firstWord = request.ToLower().Split()[0];

                switch (firstWord)
                {
                    case "как":
                        Console.WriteLine("\nНикак");
                        Console.ReadLine();
                        break;

                    case "почему":
                        Console.WriteLine("\nСам подумай");
                        Console.ReadLine();
                        break;

                    case "объясни":
                        Console.WriteLine("\nЯ не знаю");
                        Console.ReadLine();
                        break;

                    case "переведи":
                        Console.WriteLine("\nСам переведи");
                        Console.ReadLine();
                        break;

                    case "сделай":
                        Console.WriteLine("\nНет");
                        Console.ReadLine();
                        break;

                    case "что":
                        Console.WriteLine("\nНе че");
                        Console.ReadLine();
                        break;

                    case "че":
                        Console.WriteLine("\nНе че");
                        Console.ReadLine();
                        break;

                    case "напиши":
                        Console.WriteLine("\nНет");
                        Console.ReadLine();
                        break;

                    case "исправь":
                        Console.WriteLine("\nНет");
                        Console.ReadLine();
                        break;

                    case "придумай":
                        Console.WriteLine("\nСам придумай");
                        Console.ReadLine();
                        break;

                    case "выдели":
                        Console.WriteLine("\nНе");
                        Console.ReadLine();
                        break;

                    case "с":
                        Console.WriteLine("\nС того");
                        Console.ReadLine();
                        break;

                    case "куда":
                        Console.WriteLine("\nНахуй");
                        Console.ReadLine();
                        break;

                    case "давай":
                        Console.WriteLine("\nНе");
                        Console.ReadLine();
                        break;

                    case "переделай":
                        Console.WriteLine("\nНе");
                        Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine("\nПошел Нахуй");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}
