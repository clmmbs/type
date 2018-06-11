using System;
using System.IO;

public class type
{
    static void Main(string[] args)
    {
        switch (args.Length)
        {
            case 1:
                if (args[0].Contains(";"))
                {
                    string[] files = args[0].Split(new char[] { ';' });
                    foreach (string file in files)
                    {
                        Console.WriteLine();
                        Console.WriteLine("now typing " + file);
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.Write(File.ReadAllText(file));
                    }
                }
                else
                {
                    string content = File.ReadAllText(args[0]);
                    Console.Write(content);
                }
                break;
            case 0:
                Console.WriteLine("the syntax is wrong");
                break;
            default:
                foreach (string file in args)
                {
                    Console.WriteLine();
                    Console.WriteLine("now typing " + file);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write(File.ReadAllText(file));
                }
                break;
        }
    }
}