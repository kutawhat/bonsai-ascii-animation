﻿using System;
using System.IO;
using System.Threading;

public class Program
{
    public static ConsoleColor mainColor;
    public static ConsoleColor secondaryColor;
    public static ConsoleColor tretiaryColor = ConsoleColor.Gray;

    public static ConsoleColor treeColor = ConsoleColor.Gray;

    public static int delay = 800;

    // static ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));

    public static void ChooseSeason()
    {
        bool isValidInput = false;

        do
        {
            Console.WriteLine("Выбери сезон: \n 1 – Зима \n 2 – Весна \n 3 – Лето \n 4 – Осень");
            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int userNumber))
            {
                switch (userNumber)
                {
                    case 1:
                        mainColor = ConsoleColor.Blue;
                        secondaryColor = ConsoleColor.Cyan;
                        isValidInput = true;
                        break;

                    case 2:
                        Console.WriteLine("Выбери дерево: \n 1 – Сакура \n 2 – Яблоня \n 3 – Микс");
                        userInput = Console.ReadLine();
                        if (int.TryParse(userInput, out int treeNumber))
                        {
                            switch (treeNumber)
                            {
                                case 1:
                                    mainColor = ConsoleColor.Magenta;
                                    secondaryColor = ConsoleColor.Magenta;
                                    isValidInput = true;
                                    break;
                                case 2:
                                    mainColor = ConsoleColor.Gray;
                                    secondaryColor = ConsoleColor.Green;
                                    tretiaryColor = ConsoleColor.Green;
                                    isValidInput = true;
                                    break;
                                case 3:
                                    mainColor = ConsoleColor.Magenta;
                                    secondaryColor = ConsoleColor.Green;
                                    isValidInput = true;
                                    break;
                                default:
                                    Console.WriteLine("Некорректный ввод\n");
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Некорректный ввод\n");
                        }
                        break;

                    case 3:
                        mainColor = ConsoleColor.DarkGreen;
                        secondaryColor = ConsoleColor.Green;
                        isValidInput = true;
                        break;

                    case 4:
                        Console.WriteLine("Выбери дерево: \n 1 – Красное \n 2 – Желтое \n 3 – Микс");
                        userInput = Console.ReadLine();
                        if (int.TryParse(userInput, out treeNumber))
                        {
                            switch (treeNumber)
                            {
                                case 1:
                                    mainColor = ConsoleColor.Red;
                                    secondaryColor = ConsoleColor.DarkRed;
                                    isValidInput = true;
                                    break;
                                case 2:
                                    mainColor = ConsoleColor.Yellow;
                                    secondaryColor = ConsoleColor.DarkYellow;
                                    isValidInput = true;
                                    break;
                                case 3:
                                    mainColor = ConsoleColor.DarkRed;
                                    secondaryColor = ConsoleColor.DarkYellow;
                                    isValidInput = true;
                                    break;
                                default:
                                    Console.WriteLine("Некорректный ввод\n");
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Некорректный ввод\n");
                        }
                        break;

                    default:
                        Console.WriteLine("Некорректный ввод\n");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод\n");
            }
        } while (!isValidInput);
    }

    public static void PrintBonsai(string tree)
    {
        while (!Console.KeyAvailable)
        {
            Thread.Sleep(delay);

            int j = 0;

            for (int i = 0; i < tree.Length; i++)
            {
                j++;
                if (tree[i] == 'M')
                {
                    Console.ForegroundColor = (j % 2 == 0) ? mainColor : tretiaryColor;
                    Console.Write(tree[i]);
                }
                else if (tree[i] == '#')
                {
                    Console.ForegroundColor = (j % 2 == 0) ? mainColor : ConsoleColor.DarkGray;
                    Console.Write(tree[i]);
                }
                else if (tree[i] == '"' || tree[i] == '.' || tree[i] == ',' || tree[i] == 39)
                {
                    Console.ForegroundColor = secondaryColor;
                    Console.Write(tree[i]);
                }
                else
                {
                    Console.ForegroundColor = treeColor;
                    Console.Write(tree[i]);
                }
            }

            Thread.Sleep(delay);

            for (int i = 0; i < tree.Length; i++)
            {
                j++;
                if (tree[i] == 'M')
                {
                    Console.ForegroundColor = (j % 2 != 0) ? mainColor : tretiaryColor;
                    Console.Write(tree[i]);
                }
                else if (tree[i] == '#')
                {
                    Console.ForegroundColor = (j % 2 != 0) ? mainColor : ConsoleColor.DarkGray;
                    Console.Write(tree[i]);
                }
                else if (tree[i] == '"' || tree[i] == '.' || tree[i] == ',' || tree[i] == 39)
                {
                    Console.ForegroundColor = secondaryColor;
                    Console.Write(tree[i]);
                }
                else
                {
                    Console.ForegroundColor = treeColor;
                    Console.Write(tree[i]);
                }
            }
        }
    }

    public static void PrintBonsaiDouble(string tree1, string tree2)
    {
        while (!Console.KeyAvailable)
        {
            Thread.Sleep(delay);

            int j = 0;
            for (int i = 0; i < tree1.Length; i++)
            {
                j++;
                if (tree1[i] == 'M')
                {
                    Console.ForegroundColor = (j % 2 == 0) ? mainColor : tretiaryColor;
                    Console.Write(tree1[i]);
                }
                else if (tree1[i] == '#')
                {
                    Console.ForegroundColor = (j % 2 == 0) ? mainColor : ConsoleColor.Gray;
                    Console.Write(tree1[i]);
                }
                else if (tree1[i] == '"' || tree1[i] == '.' || tree1[i] == ',' || tree1[i] == 39)
                {
                    Console.ForegroundColor = secondaryColor;
                    Console.Write(tree1[i]);
                }
                else
                {
                    Console.ForegroundColor = treeColor;
                    Console.Write(tree1[i]);
                }
            }

            Thread.Sleep(delay);

            for (int i = 0; i < tree2.Length; i++)
            {
                j++;
                if (tree2[i] == 'M')
                {
                    Console.ForegroundColor = (j % 2 == 0) ? mainColor : tretiaryColor;
                    Console.Write(tree2[i]);
                }
                else if (tree2[i] == '#')
                {
                    Console.ForegroundColor = mainColor;
                    Console.Write(tree2[i]);
                }
                else if (tree2[i] == '"' || tree2[i] == '.' || tree2[i] == ',' || tree2[i] == 39)
                {
                    Console.ForegroundColor = secondaryColor;
                    Console.Write(tree2[i]);
                }
                else
                {
                    Console.ForegroundColor = treeColor;
                    Console.Write(tree2[i]);
                }
            }
        }
    }

    static void Main(string[] args)
    {
        ChooseSeason();

        //Путь до папки со всеми ascii деревьями
        string mainPath = "/Users/ku/Documents/coding/archive/csh/bonsai/trees/";
        string path;
        string tree;
        string treeName;

        int userNumber;
        do
        {
            Console.WriteLine("Выбери бонсай \r\n 1 – Без листвы \r\n 2 – С листвой \r\n 3 – С листвой +");
            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out userNumber))
            {
                switch (userNumber)
                {
                    case 1:
                        treeName = "tree.txt";
                        path = mainPath + treeName;
                        tree = File.ReadAllText(path);

                        PrintBonsai(tree);
                        break;
                    case 2:
                        treeName = "tree1_1.txt";
                        path = mainPath + treeName;
                        tree = File.ReadAllText(path);

                        PrintBonsai(tree);
                        break;
                    case 3:
                        string treeName1 = "tree2_1.txt";
                        string treeName2 = "tree2_2.txt";
                        string path1 = mainPath + treeName1;
                        string path2 = mainPath + treeName2;
                        string tree1 = File.ReadAllText(path1);
                        string tree2 = File.ReadAllText(path2);

                        PrintBonsaiDouble(tree1, tree2);
                        break;
                    default:
                        Console.WriteLine("Некорректный ввод\n");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод\n");
            }
        } while (userNumber < 1 || userNumber > 3);
    }
}
