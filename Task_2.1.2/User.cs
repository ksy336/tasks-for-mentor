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
        public List<Figure> _figures;

        public User(string name)
        {
            Name = name;
            _figures = new List<Figure>();
           
        }

        public static GetUser(string name)
        {
            return new User(name) { Name = name, _figures = new List<Figure>() };
        } 
        public void AddFigure(Figure figure)
        {
            _figures.Add(figure);
        }

        public override string ToString() => Name;

    }
}

