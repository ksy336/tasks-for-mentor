using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class User
    {
        public string Name { get; set; }
        public List<Figure> Figures { get; set; }

        public User(string name)
        {
            Name = name;
            Figures = new List<Figure>();
        }

        public static implicit operator User(string name)
        {
            return new User(name) { Name = name };
        }

        public override string ToString() => $"{Name}";

    }
}

