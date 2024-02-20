using System;
using System.Threading;
using static bonsai.SeasonChooser;
using static bonsai.TreeSelector;

namespace bonsai
{
    public class BonsaiPrinter
    {
        public static int Delay = 800;
        
        public static void PrintBonsai(string tree)
    {
        Console.Clear();
        while (!Console.KeyAvailable)
        {
            Thread.Sleep(Delay);

            int j = 0;

            for (int i = 0; i < tree.Length; i++)
            {
                j++;
                if (tree[i] == 'M')
                {
                    Console.ForegroundColor = (j % 2 == 0) ? MainColor : TretiaryColor;
                    Console.Write(tree[i]);
                }
                else if (tree[i] == '#')
                {
                    Console.ForegroundColor = (j % 2 == 0) ? MainColor : ConsoleColor.DarkGray;
                    Console.Write(tree[i]);
                }
                else if (tree[i] == '"' || tree[i] == '.' || tree[i] == ',' || tree[i] == 39)
                {
                    Console.ForegroundColor = SecondaryColor;
                    Console.Write(tree[i]);
                }
                else
                {
                    Console.ForegroundColor = TreeColor;
                    Console.Write(tree[i]);
                }
            }

            Thread.Sleep(Delay);

            for (int i = 0; i < tree.Length; i++)
            {
                j++;
                if (tree[i] == 'M')
                {
                    Console.ForegroundColor = (j % 2 != 0) ? MainColor : TretiaryColor;
                    Console.Write(tree[i]);
                }
                else if (tree[i] == '#')
                {
                    Console.ForegroundColor = (j % 2 != 0) ? MainColor : ConsoleColor.DarkGray;
                    Console.Write(tree[i]);
                }
                else if (tree[i] == '"' || tree[i] == '.' || tree[i] == ',' || tree[i] == 39)
                {
                    Console.ForegroundColor = SecondaryColor;
                    Console.Write(tree[i]);
                }
                else
                {
                    Console.ForegroundColor = TreeColor;
                    Console.Write(tree[i]);
                }
            }
        }
    }

    public static void PrintBonsaiDouble(string tree1, string tree2)
    {
        Console.Clear();
        while (!Console.KeyAvailable)
        {
            Thread.Sleep(Delay);

            int j = 0;
            for (int i = 0; i < tree1.Length; i++)
            {
                j++;
                if (tree1[i] == 'M')
                {
                    Console.ForegroundColor = (j % 2 == 0) ? MainColor : TretiaryColor;
                    Console.Write(tree1[i]);
                }
                else if (tree1[i] == '#')
                {
                    Console.ForegroundColor = (j % 2 == 0) ? MainColor : ConsoleColor.Gray;
                    Console.Write(tree1[i]);
                }
                else if (tree1[i] == '"' || tree1[i] == '.' || tree1[i] == ',' || tree1[i] == 39)
                {
                    Console.ForegroundColor = SecondaryColor;
                    Console.Write(tree1[i]);
                }
                else
                {
                    Console.ForegroundColor = TreeColor;
                    Console.Write(tree1[i]);
                }
            }

            Thread.Sleep(Delay);

            for (int i = 0; i < tree2.Length; i++)
            {
                j++;
                if (tree2[i] == 'M')
                {
                    Console.ForegroundColor = (j % 2 == 0) ? MainColor : TretiaryColor;
                    Console.Write(tree2[i]);
                }
                else if (tree2[i] == '#')
                {
                    Console.ForegroundColor = MainColor;
                    Console.Write(tree2[i]);
                }
                else if (tree2[i] == '"' || tree2[i] == '.' || tree2[i] == ',' || tree2[i] == 39)
                {
                    Console.ForegroundColor = SecondaryColor;
                    Console.Write(tree2[i]);
                }
                else
                {
                    Console.ForegroundColor = TreeColor;
                    Console.Write(tree2[i]);
                }
            }
        }
        Console.Clear();
    }
    }
}