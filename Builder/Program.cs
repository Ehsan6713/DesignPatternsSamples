using Builder.Classes;
using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************Design1*************");
            //Design 1
            var Hp = new FluentComputerBuilder("Pavilion")
                .WithHard("512 SSd")
                .WithKeyboard("Type A")
                .WithRam("8 G")
                .WithScreenSize("16")
                .WithOperatingSystem("window 10")
                .Build();
            Console.WriteLine(Hp.ToString());

            Console.WriteLine("************Design2*************");
            //Design 2
            ComputerCreate hp = new ComputerCreate(new HpLaptop("Pavilion"));
            ComputerCreate apple = new ComputerCreate(new AppleLaptop("Apple MacBook"));
            hp.Create();
            apple.Create();
            Console.WriteLine(hp.ToString());
            Console.WriteLine(apple.ToString());
            Console.ReadKey();
        }
    }
}
