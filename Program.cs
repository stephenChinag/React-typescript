using System;
using MyLibrary;

class Program
{
    static void Main()
    {
        var service = new GreetingService();
        Console.WriteLine(service.GetGreeting("Stephen"));
    }
}
