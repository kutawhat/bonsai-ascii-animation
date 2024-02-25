using System;
using System.IO;
using System.Linq;
using System.Threading;

public class Program
{
    private static int delay = 800;
    private static ConsoleColor mainColor;
    private static ConsoleColor secondaryColor;
    private static ConsoleColor tretiaryColor = ConsoleColor.Gray;
    private static ConsoleColor treeColor = ConsoleColor.Gray;
    private static ConsoleColor[] colors = {
        ConsoleColor.Black, ConsoleColor.Red, ConsoleColor.DarkRed, ConsoleColor.Yellow,
        ConsoleColor.DarkYellow, ConsoleColor.Green, ConsoleColor.DarkGreen,
        ConsoleColor.Cyan, ConsoleColor.DarkCyan, ConsoleColor.Blue,
        ConsoleColor.DarkBlue, ConsoleColor.Magenta, ConsoleColor.DarkMagenta,
        ConsoleColor.Gray, ConsoleColor.DarkGray, ConsoleColor.White
    };

    private static void InvalidInput()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Clear();
        Console.WriteLine("Некорректный ввод\n");
    }

    private static void SystemMessage(string mainText, string listText, ConsoleColor headColor, bool colorful)
    {
        Console.ForegroundColor = headColor;
        Console.WriteLine(mainText);
        if (!colorful)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(listText);
        }
        else
        {
            string[] lines = listText.Split('\n');
            for (int i = 0; i < lines.Length - 1; i++)
            {
                Console.ForegroundColor = colors[i + 1];
                Console.WriteLine(lines[i]);
            }
        }
    }

    public static void ChooseSeason()
    {
        Console.Clear();

        do
        {
            SystemMessage("Выбери сезон:", "1 – Зима \n2 – Весна \n3 – Лето \n4 – Осень \n5 – Свой вайб\n", ConsoleColor.Green, false);

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
                case 5:
                    SetCustom();
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
            SystemMessage("Выбери дерево:", "1 – Сакура \n2 – Павлония \n3 – Магнолия \n4 – Сирень \n5 – Вишня \n6 – Яблоня\n", ConsoleColor.Magenta, false);

            int.TryParse(Console.ReadLine(), out int treeNumber);

            switch (treeNumber)
            {
                case 1:
                    mainColor = ConsoleColor.Magenta;
                    secondaryColor = ConsoleColor.Magenta;
                    return;
                case 2:
                    mainColor = ConsoleColor.DarkMagenta;
                    secondaryColor = ConsoleColor.DarkMagenta;
                    return;
                case 3:
                    mainColor = ConsoleColor.Magenta;
                    secondaryColor = ConsoleColor.Green;
                    return;
                case 4:
                    mainColor = ConsoleColor.DarkMagenta;
                    secondaryColor = ConsoleColor.Green;
                    return;
                case 5:
                    mainColor = ConsoleColor.Magenta;
                    secondaryColor = ConsoleColor.Gray;
                    tretiaryColor = ConsoleColor.White;
                    return;
                case 6:
                    mainColor = ConsoleColor.Gray;
                    secondaryColor = ConsoleColor.Green;
                    tretiaryColor = ConsoleColor.Green;
                    return;
                default:
                    InvalidInput();
                    break;
            }
        } while (true);
    }

    private static void SetSummer()
    {
        do
        {
            SystemMessage("Выбери дерево:", "1 – Береза \n2 – Лимонное\n", ConsoleColor.DarkYellow, false);

            int.TryParse(Console.ReadLine(), out int treeNumber);

            switch (treeNumber)
            {
                case 1:
                    mainColor = ConsoleColor.DarkGreen;
                    secondaryColor = ConsoleColor.DarkGreen;
                    return;
                case 2:
                    mainColor = ConsoleColor.Yellow;
                    secondaryColor = ConsoleColor.Green;
                    return;
                default:
                    InvalidInput();
                    break;
            }
        } while (true);
    }

    private static void SetAutumn()
    {
        Console.Clear();

        do
        {
            SystemMessage("Выбери дерево:", "1 – Красное \n2 – Желтое \n3 – Микс\n", ConsoleColor.Yellow, false);

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

    private static void SetCustom()
    {
        mainColor = SetCustomHelper("Выбери основной цвет:", ConsoleColor.Gray);
        secondaryColor = SetCustomHelper("Выбери дополнительный цвет:", ConsoleColor.Gray);
    }

    private static ConsoleColor SetCustomHelper(string message, ConsoleColor headColor)
    {
        Console.Clear();

        ConsoleColor currentColor = colors[15];
        int userNumber;

        do
        {
            SystemMessage(message, "1  – Красный \n2  – Темно-красный \n3  – Желтый \n4  – Темно-желтый \n5  – Зеленый \n6  – Темно-зеленый \n7  – Голубой \n8  – Темно-голубой \n9  – Синий \n10 – Темно-синий \n11 – Фиолетовый \n12 – Розовый \n13 – Серый \n14 – Темно-серый \n15 – Белый\n", headColor, true);

            if (int.TryParse(Console.ReadLine(), out userNumber) && userNumber >= 1 && userNumber <= 15)
            {
                currentColor = colors[userNumber];
            }
            else
            {
                InvalidInput();
            }
        } while (userNumber < 1 || userNumber > 15);

        return currentColor;
    }

    public static void SelectAnimation()
    {
        Console.Clear();

        //Путь до папки со всеми ascii деревьями
        string mainPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "trees");
        string[] treeNames = { "tree.txt", "tree1_1.txt", "tree2_1.txt", "tree2_2.txt" };
        string[] treePaths = treeNames.Select(name => Path.Combine(mainPath, name)).ToArray();

        int animationNumber;
        do
        {
            SystemMessage("Выбери бонсай", "1 – Без листвы \n2 – С листвой \n3 – С листвой +\n", ConsoleColor.Blue, false);

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
            SetChars(tree, 1, false);
        }
    }

    public static void PrintBonsai(string tree1, string tree2)
    {
        Console.Clear();

        while (!Console.KeyAvailable)
        {
            SetChars(tree1, 0, true);
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