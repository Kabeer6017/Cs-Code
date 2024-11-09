using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
                   Console.WriteLine("A proud Knight named...");
            Console.ReadLine();
            Console.WriteLine("...walking into a bar. At the counter he met a...");
            Console.ReadLine();
            Console.WriteLine("...who asked him what he wanted to drink?");
            Console.ReadLine();
            Console.WriteLine("...shouted the Knight! The bartender shushed him quickly.");
            Console.ForegroundColor= ConsoleColor.Red;
            Console.WriteLine("But it was too late... A dragon ate them both.");
            Console.ResetColor();
            Console.ReadKey();
    }