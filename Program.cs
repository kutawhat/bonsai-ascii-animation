using System.Threading;
using System.Text;
using System.IO;
using System;

namespace spring
{
    internal class Program
    {
        public static void PrintTreeAnimatedDemo(string tree)
        {
            while (!Console.KeyAvailable)
            {
                Thread.Sleep(700);

                int j = 0;
                for (int i = 0; i < tree.Length; i++)
                {
                    j++;
                    if (j % 2 == 0 && tree[i] == 'M')
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write(tree[i]);
                    }
                    else if (tree[i] == '"' || tree[i] == '.' || tree[i] == ',' || tree[i] == 39)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(tree[i]);
                    }
                    else if (tree[i] == '#')
                    {
                        Console.ForegroundColor = (j % 2 == 0) ? ConsoleColor.Magenta : ConsoleColor.DarkGray;
                        Console.Write(tree[i]);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write(tree[i]);
                    }
                }

                Thread.Sleep(1000);

                j = 0;
                for (int i = 0; i < tree.Length; i++)
                {
                    j++;
                    if (j % 2 != 0 && tree[i] == 'M')
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write(tree[i]);
                    }
                    else if (tree[i] == '"' || tree[i] == '.' || tree[i] == ',' || tree[i] == 39)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(tree[i]);
                    }
                    else if (tree[i] == '#')
                    {
                        Console.ForegroundColor = (j % 2 != 0) ? ConsoleColor.Magenta : ConsoleColor.DarkGray;
                        Console.Write(tree[i]);
                    }
                    else if (tree[i] == 'o')
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
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
        public static void PrintTreeAnimated(string tree)
        {
            while (!Console.KeyAvailable)
            {
                Thread.Sleep(700);

                int j = 0;
                int leaf = 1;

                for (int i = 0; i < tree.Length; i++)
                {
                    j++;
                    if (j % 2 == 0 && tree[i] == 'M')
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write(tree[i]);
                    }
                    else if (tree[i] == '"' || tree[i] == '.' || tree[i] == ',' || tree[i] == 39)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(tree[i]);
                    }
                    else if (tree[i] == '#')
                    {
                        if (leaf == 1 || leaf == 4 || leaf == 5)
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.Write(tree[i]);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.Write(tree[i]);
                        }
                        leaf++;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write(tree[i]);
                    }
                }

                Thread.Sleep(700);

                leaf = 1;

                for (int i = 0; i < tree.Length; i++)
                {
                    j++;
                    if (j % 2 != 0 && tree[i] == 'M')
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write(tree[i]);
                    }
                    else if (tree[i] == '"' || tree[i] == '.' || tree[i] == ',' || tree[i] == 39)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(tree[i]);
                    }
                    else if (tree[i] == '#')
                    {
                        if (leaf == 1 || leaf == 4 || leaf == 5)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.Write(tree[i]);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.Write(tree[i]);
                        }
                        leaf++;
                    }
                    else if (tree[i] == 'o')
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
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


        public static void Main(string[] args)
        {
            string path = "/Users/ku/Documents/coding/archive/csh/spring2/tree1_1.txt";
            string tree = File.ReadAllText(path);

            PrintTreeAnimated(tree);
        }
    }
}