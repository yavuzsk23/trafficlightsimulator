using System;

class Program
{
    static void Main()
    {
        Console.Write("enter light color red, yellow, green ");
        string color = Console.ReadLine();

        if (color == "red")
            Console.WriteLine("stop");
        else if (color == "yellow")
            Console.WriteLine("get ready");
        else if (color == "green")
            Console.WriteLine("go");
        else
            Console.WriteLine("ınvalid color");
    }
}
