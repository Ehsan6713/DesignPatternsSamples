using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Classes
{
    public class AppleLaptop : ComputerBuilder
    {
        public AppleLaptop()
        {
            computer = new Computer("Apple MacBook");
        }
        public override void AddHard()
        {
            computer["hard"] = "512 SSD";
        }

        public override void AddKeyboard()
        {
            computer["keyboad"] = "type A";
        }

        public override void AddMonitorOperatingSystem()
        {
            computer["operating_system"] = "Mac Os X";
        }

        public override void AddRam()
        {
            computer["ram"] = "8 GB RAM";
        }

        public override void AddScreenSize()
        {
            computer["screen_size"] = "15.4";
        }
    }
}
