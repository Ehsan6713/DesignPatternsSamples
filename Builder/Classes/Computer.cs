using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder.Classes
{
    /// <summary>
    /// product class
    /// </summary>
    public class Computer
    {
        private string name;
        private Dictionary<string, string> ingredients = new Dictionary<string, string>();
        public Computer(string name)
        {
            this.name = name;
        }
        public string this[string key]
        {
            get { return ingredients.Keys.Any(p => p == key) ? ingredients[key] : ""; }
            set { ingredients[key] = value; }
        }
        public string Display()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Computer Name {name}");
            sb.Append(Environment.NewLine);
            sb.Append($"Hard {ingredients["hard"]}");
            sb.Append(Environment.NewLine);
            sb.Append($"Screen Size {ingredients["screen_size"]}");
            sb.Append(Environment.NewLine);
            sb.Append($"Keyboard {ingredients["keyboard"]}");
            sb.Append(Environment.NewLine);
            sb.Append($"Operating System {ingredients["operating_system"]}");
            sb.Append(Environment.NewLine);
            sb.Append($"Ram {ingredients["ram"]}");
            sb.Append(Environment.NewLine);
            return sb.ToString();
        }
        public override string ToString()
        {
            return Display();
        }
    }
}
