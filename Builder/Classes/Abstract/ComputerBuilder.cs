using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Classes
{
    public abstract class ComputerBuilder
    {
        protected Computer computer;

        public Computer Computer
        {
            get { return computer; }
        }
        public abstract void AddScreenSize();
        public abstract void AddKeyboard();
        public abstract void AddMonitorOperatingSystem();
        public abstract void AddRam();
        public abstract void AddHard();

    }
}
