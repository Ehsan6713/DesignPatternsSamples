using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Classes
{
    public class FluentComputerBuilder
    {
        private readonly Computer computer;
        public FluentComputerBuilder(string computername)
        {
            computer = new Computer(computername);
        }
        public FluentComputerBuilder WithHard(string hard)
        {
            computer["hard"] = hard;
            return this;
        }
        public FluentComputerBuilder WithKeyboard(string keyboard)
        {
            computer["keyboard"] = keyboard;
            return this;
        }
        public FluentComputerBuilder WithOperatingSystem(string operatingSystem)
        {
            computer["operating_system"] = operatingSystem;
            return this;
        }
        public FluentComputerBuilder WithRam(string ram)
        {
            computer["ram"] = ram;
            return this;
        }
        public FluentComputerBuilder WithScreenSize(string screenSize)
        {
            computer["screen_size"] = screenSize;
            return this;
        }
        public Computer Build()
        {
            return computer;
        }
    }
}
