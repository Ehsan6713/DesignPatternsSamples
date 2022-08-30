using Builder.Classes;
using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var Hp = new FluentComputerBuilder("Pavilion")
                .WithHard("512 SSd")
                .WithKeyboard("Type A")
                .WithRam("8 G")
                .WithScreenSize("16")
                .WithOperatingSystem("window 10")
                .Build();
            Console.WriteLine(Hp.ToString());
        }
    }
}
