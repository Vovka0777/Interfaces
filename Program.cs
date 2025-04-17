using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            bool play = false;
            bool record = false;
            bool pause = false;
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Выберите действие:\n1 - воспроизвести\n2 - записать\n3 - пауза\n4 - остановить\n5 - выход");
                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        if (play==false)
                        {
                            player.Play();
                            play = true;
                        }
                        else
                        {
                            Console.WriteLine("Воспроизведение уже запущено");
                        }
                        Console.WriteLine();

                        break;
                    case "2":
                        if (record == false)
                        {
                            player.Record();
                            record = true;
                        }
                        else
                        {
                            Console.WriteLine("Запись уже запущена");
                        }
                        Console.WriteLine();
                        break;
                    case "3":
                        if (play == true)
                        {
                            player.Pause();
                            play = false;
                            pause = true;
                        }
                        else if (record == true)
                        {
                            player.Pause();
                            record = false;
                            pause = true;
                        }
                        else if (pause == true)
                        {
                            Console.WriteLine("Пауза снята");
                            pause = false;
                        }
                        else
                        {
                            Console.WriteLine("Нет активного воспроизведения или записи");
                        }
                        Console.WriteLine();
                        break;
                    case "4":
                        if (play == true)
                        {
                            player.StopPlay();
                            play = false;
                        }
                        else if (record == true)
                        {
                            player.StopRecord();
                            record = false;
                        }
                        else
                        {
                            Console.WriteLine("Нет активного воспроизведения или записи");
                        }
                        Console.WriteLine();
                        break;
                    case "5":
                        Console.WriteLine("Выход из программы");
                        Console.Read();
                        flag = false; return;
                    default:
                        Console.WriteLine("Неверный выбор");
                        Console.WriteLine();
                        break;
                }
            }
            Console.Read();

        }
    }
}
