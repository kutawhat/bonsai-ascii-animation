using System;
using System.IO;
using static bonsai.BonsaiPrinter;

namespace bonsai
{
    public static class TreeSelector
    {
        //Путь до папки со всеми ascii деревьями
        public static string MainPath = "/Users/ku/Documents/coding/archive/csh/bonsai/trees/";
        public static string Path;
        public static string Tree;
        public static string TreeName;

        public static int UserNumber;

        public static void SelectTree()
        {
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Выбери бонсай");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("1 – Без листвы \n2 – С листвой \n3 – С листвой +");

                string userInput = Console.ReadLine();

                if (int.TryParse(userInput, out UserNumber))
                {
                    switch (UserNumber)
                    {
                        case 1:
                            TreeName = "tree.txt";
                            Path = MainPath + TreeName;
                            Tree = File.ReadAllText(Path);

                            PrintBonsai(Tree);
                            break;
                        case 2:
                            TreeName = "tree1_1.txt";
                            Path = MainPath + TreeName;
                            Tree = File.ReadAllText(Path);

                            PrintBonsai(Tree);
                            break;
                        case 3:
                            string treeName1 = "tree2_1.txt";
                            string treeName2 = "tree2_2.txt";
                            string path1 = MainPath + treeName1;
                            string path2 = MainPath + treeName2;
                            string tree1 = File.ReadAllText(path1);
                            string tree2 = File.ReadAllText(path2);

                            PrintBonsaiDouble(tree1, tree2);
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
            } while (UserNumber < 1 || UserNumber > 3);
        }
    }
}