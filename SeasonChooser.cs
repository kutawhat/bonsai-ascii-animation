using System;

namespace bonsai
{
    public static class SeasonChooser
    {
        // static ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));

        public static ConsoleColor MainColor;
        public static ConsoleColor SecondaryColor;
        public static ConsoleColor TretiaryColor = ConsoleColor.Gray;
        public static ConsoleColor TreeColor = ConsoleColor.Gray;
        
        public static void ChooseSeason()
    {
        bool isValidInput = false;

        do
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Выбери сезон:");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("1 – Зима \n2 – Весна \n3 – Лето \n4 – Осень");

            string userInput = Console.ReadLine();

            Console.Clear();

            if (int.TryParse(userInput, out int userNumber))
            {
                switch (userNumber)
                {
                    case 1:
                        MainColor = ConsoleColor.Blue;
                        SecondaryColor = ConsoleColor.Cyan;
                        isValidInput = true;
                        Console.Clear();
                        break;

                    case 2:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Выбери дерево:");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("1 – Сакура \n2 – Яблоня \n3 – Микс");

                        userInput = Console.ReadLine();

                        if (int.TryParse(userInput, out int treeNumber))
                        {
                            switch (treeNumber)
                            {
                                case 1:
                                    MainColor = ConsoleColor.Magenta;
                                    SecondaryColor = ConsoleColor.Magenta;
                                    isValidInput = true;
                                    Console.Clear();
                                    break;
                                case 2:
                                    MainColor = ConsoleColor.Gray;
                                    SecondaryColor = ConsoleColor.Green;
                                    TretiaryColor = ConsoleColor.Green;
                                    isValidInput = true;
                                    Console.Clear();
                                    break;
                                case 3:
                                    MainColor = ConsoleColor.Magenta;
                                    SecondaryColor = ConsoleColor.Green;
                                    isValidInput = true;
                                    Console.Clear();
                                    break;
                                default:
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Некорректный ввод\n");
                                    break;
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Некорректный ввод\n");
                        }
                        break;

                    case 3:
                        MainColor = ConsoleColor.DarkGreen;
                        SecondaryColor = ConsoleColor.Green;
                        isValidInput = true;
                        break;

                    case 4:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Выбери дерево:");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("1 – Красное \n2 – Желтое \n3 – Микс");

                        userInput = Console.ReadLine();

                        if (int.TryParse(userInput, out treeNumber))
                        {
                            switch (treeNumber)
                            {
                                case 1:
                                    MainColor = ConsoleColor.Red;
                                    SecondaryColor = ConsoleColor.DarkRed;
                                    isValidInput = true;
                                    Console.Clear();
                                    break;
                                case 2:
                                    MainColor = ConsoleColor.Yellow;
                                    SecondaryColor = ConsoleColor.DarkYellow;
                                    isValidInput = true;
                                    Console.Clear();
                                    break;
                                case 3:
                                    MainColor = ConsoleColor.DarkRed;
                                    SecondaryColor = ConsoleColor.DarkYellow;
                                    isValidInput = true;
                                    Console.Clear();
                                    break;
                                default:
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Некорректный ввод\n");
                                    break;
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Некорректный ввод\n");
                        }
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Некорректный ввод\n");
                        break;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Некорректный ввод\n");
            }
        } while (!isValidInput);
    }

    }
}