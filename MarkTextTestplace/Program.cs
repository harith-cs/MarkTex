using System;

public class Program
{
    public static void Main(string[] args)
    {
        if(args.Length == 0)
        {
            Console.WriteLine("Usage: MarkTexTestplace.exe <text> [-f]");
            return;
        }
        bool UseBold = true;
        if (args.Length > 1)
        {
            if(args[1] == "-f") UseBold = false;
        }
        Console.WriteLine(MarkTexRenderer.Convert(args[0], UseBold));
    }
}