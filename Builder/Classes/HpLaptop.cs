using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Classes
{
    public class HpLaptop : ComputerBuilder
    {
        public HpLaptop(string name)
        {
            computer = new Computer(name);
        }

        public override void AddHard()
        {
            computer["hard"] = "512 GB";
        }

        public override void AddKeyboard()
        {
            computer["keyboard"] = "type B";
        }

        public override void AddMonitorOperatingSystem()
        {
            computer["operating_system"] = "Windows 11";
        }

        public override void AddRam()
        {
            computer["ram"] = "8 GB DDR4-3200 SDRAM (2 X 4 GB)";
        }

        public override void AddScreenSize()
        {
            computer["screen_size"] = "15.6";
        }
    }
}
