using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Classes
{
    public class ComputerCreate
    {
        private ComputerBuilder _computerBuilder;
        public ComputerCreate(ComputerBuilder computerBuilder)
        {
            this._computerBuilder = computerBuilder;
        }
        public void Create()
        {
            _computerBuilder.AddHard();
            _computerBuilder.AddKeyboard();
            _computerBuilder.AddMonitorOperatingSystem();
            _computerBuilder.AddRam();
            _computerBuilder.AddScreenSize();
        }
        public override string ToString()
        {
            return _computerBuilder.Computer.ToString();
        }
    }
}
