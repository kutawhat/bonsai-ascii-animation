using System;
using System.IO;
using System.Threading;

public class Program
{
    public static ConsoleColor mainColor;
    public static ConsoleColor secondaryColor;
    public static int delay = 800;

    // static ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));

    public static void ChooseSeason()
    {
        do
        {
            Console.WriteLine("Выбери сезон: \n 1 – Зима \n 2 – Весна \n 3 – Лето \n 4 – Осень");
            string userInput = Console.ReadLine();

            int userNumber;
            if (int.TryParse(userInput, out userNumber))
            {
                switch (userNumber)
                {
                    case 1:
                        mainColor = ConsoleColor.Blue;
                        secondaryColor = ConsoleColor.Cyan;
                        break;
                    case 2:
                        mainColor = ConsoleColor.Magenta;
                        secondaryColor = ConsoleColor.Magenta;
                        break;
                    case 3:
                        mainColor = ConsoleColor.DarkGreen;
                        secondaryColor = ConsoleColor.Green;
                        break;
                    case 4:
                        mainColor = ConsoleColor.Red;
                        secondaryColor = ConsoleColor.Yellow;
                        break;
                    default:
                        Console.WriteLine("Некорректное значение\n");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод\n");
            }
        } while (mainColor == 0);
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
                    Console.ForegroundColor = (j % 2 == 0) ? mainColor : ConsoleColor.Gray;
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
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write(tree[i]);
                }
            }

            Thread.Sleep(delay);

            for (int i = 0; i < tree.Length; i++)
            {
                j++;
                if (tree[i] == 'M')
                {
                    Console.ForegroundColor = (j % 2 != 0) ? mainColor : ConsoleColor.Gray;
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
                    Console.ForegroundColor = ConsoleColor.Gray;
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
                    Console.ForegroundColor = (j % 2 == 0) ? mainColor : ConsoleColor.Gray;
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
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write(tree1[i]);
                }
            }

            Thread.Sleep(delay);

            for (int i = 0; i < tree2.Length; i++)
            {
                j++;
                if (tree2[i] == 'M')
                {
                    Console.ForegroundColor = (j % 2 == 0) ? mainColor : ConsoleColor.Gray;
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
                    Console.ForegroundColor = ConsoleColor.Gray;
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
                        Console.WriteLine("Некорректное значение\n");
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
