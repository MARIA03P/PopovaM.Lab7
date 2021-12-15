using System;
using System.Collections.Generic;
using System.Linq;

namespace Popova.Lab7.Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choose = 0;
            while (choose != 3)
            {
                Console.WriteLine("choose 1 or 2 or 3. exit");
                choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        FirstTask();
                        break;
                    case 2:
                        SecondTask();
                        break;
                    case 3:
                        break;
                    default:
                        break;
                }
            }
        }

        private static void SecondTask()
        {
            throw new NotImplementedException();
        }

        private static void FirstTask()
        {
            Console.WriteLine("Task 1 chosen.");
            Console.WriteLine("choose 1 or 2 ");
            int choose = int.Parse(Console.ReadLine());
            int Replace = int.Parse(Console.ReadLine());

            switch (choose)
            {
                case 1:
                    Console.WriteLine("enter a text");
                    string str = Console.ReadLine();
                    var chArray = str.ToCharArray();
                    chArray[0] = Replace.ToString()[0];
                    for (int i = 0; i < chArray.Length - 1; i++)
                    {
                        if (chArray[i] == (char)ConsoleKey.Spacebar)
                        {
                            chArray[i + 1] = Replace.ToString()[0];
                        }
                    }

                    str = string.Join("", chArray);
                    Console.WriteLine(str);
                    break;
                case 2:
                    Console.WriteLine("enter a text");
                    str = Console.ReadLine();
                    var words = str.Split(' ');
                    var wordsAfter = words.Select(word => Replace.ToString()[0] + word.Substring(1));
                    str = string.Join(" ", wordsAfter);
                    Console.WriteLine(str);
                    break;
            }
        }
    }
}
