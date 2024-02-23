using System;
using System.IO;
using System.Linq;
using System.Threading;

public class Program
{
    public static int delay = 800;
    public static ConsoleColor mainColor;
    public static ConsoleColor secondaryColor;
    public static ConsoleColor tretiaryColor = ConsoleColor.Gray;
    public static ConsoleColor treeColor = ConsoleColor.Gray;

    private static void InvalidInput()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Clear();
        Console.WriteLine("Некорректный ввод\n");
    }

    private static void SystemMessage(string mainText, string listText)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(mainText);
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine(listText);
    }


    public static void ChooseSeason()
    {
        Console.Clear();
        do
        {
            SystemMessage("Выбери сезон:", "1 – Зима \n2 – Весна \n3 – Лето \n4 – Осень\n");

            int.TryParse(Console.ReadLine(), out int seasonNumber);

            switch (seasonNumber)
            {
                case 1:
                    SetWinter();
                    return;
                case 2:
                    SetSpring();
                    return;
                case 3:
                    SetSummer();
                    return;
                case 4:
                    SetAutumn();
                    return;
                default:
                    InvalidInput();
                    break;
            }
        } while (true);
    }


    private static void SetWinter()
    {
        mainColor = ConsoleColor.Blue;
        secondaryColor = ConsoleColor.Cyan;
    }

    private static void SetSpring()
    {
        Console.Clear();
        do
        {
            SystemMessage("Выбери дерево:", "1 – Сакура \n2 – Яблоня \n3 – Сирень \n4 – Вишня \n5 – Микс\n");

            int.TryParse(Console.ReadLine(), out int treeNumber);

            switch (treeNumber)
            {
                case 1:
                    mainColor = ConsoleColor.Magenta;
                    secondaryColor = ConsoleColor.Magenta;
                    return;
                case 2:
                    mainColor = ConsoleColor.Gray;
                    secondaryColor = ConsoleColor.Green;
                    tretiaryColor = ConsoleColor.Green;
                    return;
                case 3:
                    mainColor = ConsoleColor.DarkMagenta;
                    secondaryColor = ConsoleColor.Green;
                    return;
                case 4:
                    mainColor = ConsoleColor.Magenta;
                    secondaryColor = ConsoleColor.Gray;
                    tretiaryColor = ConsoleColor.White;
                    return;
                case 5:
                    mainColor = ConsoleColor.Magenta;
                    secondaryColor = ConsoleColor.Green;
                    return;
                default:
                    InvalidInput();
                    break;
            }
        } while (true);
    }

    private static void SetSummer()
    {
        mainColor = ConsoleColor.DarkGreen;
        secondaryColor = ConsoleColor.Green;
    }

    private static void SetAutumn()
    {
        Console.Clear();
        do
        {
            SystemMessage("Выбери дерево:", "1 – Красное \n2 – Желтое \n3 – Микс\n");

            int.TryParse(Console.ReadLine(), out int treeNumber);

            switch (treeNumber)
            {
                case 1:
                    mainColor = ConsoleColor.Red;
                    secondaryColor = ConsoleColor.DarkRed;
                    return;
                case 2:
                    mainColor = ConsoleColor.Yellow;
                    secondaryColor = ConsoleColor.DarkYellow;
                    return;
                case 3:
                    mainColor = ConsoleColor.DarkRed;
                    secondaryColor = ConsoleColor.DarkYellow;
                    return;
                default:
                    InvalidInput();
                    break;
            }

        } while (true);
    }

    public static void SelectAnimation()
    {
        Console.Clear();

        string mainPath = "/Users/ku/Documents/coding/ascii-animations/bonsai/trees/";
        string[] treeNames = { "tree.txt", "tree1_1.txt", "tree2_1.txt", "tree2_2.txt" };
        string[] treePaths = treeNames.Select(name => Path.Combine(mainPath, name)).ToArray();

        int animationNumber;
        do
        {
            SystemMessage("Выбери бонсай", "1 – Без листвы \n2 – С листвой \n3 – С листвой +\n");

            if (int.TryParse(Console.ReadLine(), out animationNumber) && animationNumber >= 1 && animationNumber <= 3)
            {
                string path = treePaths[animationNumber - 1];
                string tree = File.ReadAllText(path);

                if (animationNumber == 3)
                {
                    PrintBonsai(tree, File.ReadAllText(treePaths[3]));
                }
                else
                {
                    PrintBonsai(tree);
                }
            }
            else
            {
                InvalidInput();
            }
        } while (animationNumber < 1 || animationNumber > 3);
    }

    public static void PrintBonsai(string tree)
    {
        Console.Clear();
        while (!Console.KeyAvailable)
        {
            SetChars(tree, 0, false);
            Console.Clear();
            SetChars(tree, 1, false);
            Console.Clear();
        }
    }

    public static void PrintBonsai(string tree1, string tree2)
    {
        Console.Clear();
        while (!Console.KeyAvailable)
        {
            Console.Clear();
            SetChars(tree1, 0, true);
            Console.Clear();
            SetChars(tree2, 1, true);
        }
    }
    public static void SetChars(string tree, int j, bool isDouble)
    {
        Console.Clear();
        ConsoleColor currentColor;

        for (int i = 0; i < tree.Length; i++)
        {
            j++;

            if (tree[i] == 'M')
            {
                currentColor = (j % 2 == 0) ? mainColor : tretiaryColor;
            }
            else if (tree[i] == '#')
            {
                currentColor = isDouble ? mainColor : (j % 2 == 0) ? mainColor : ConsoleColor.DarkGray;
            }
            else if (tree[i] == '"' || tree[i] == '.' || tree[i] == ',' || tree[i] == 39)
            {
                currentColor = secondaryColor;
            }
            else
            {
                currentColor = treeColor;
            }

            Console.ForegroundColor = currentColor;
            Console.Write(tree[i]);
        }

        Thread.Sleep(delay);
    }

    static void Main(string[] args)
    {
        ChooseSeason();
        SelectAnimation();
    }
}