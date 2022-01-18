using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDev
{
    public delegate void MoveHandler(Interfaces.IMovable sender, MoveEventArgs e);
    
    public class MoveEventArgs: EventArgs
    {
        public Point Point { get; private set; }
        public string Text { get; private set; }

        public MoveEventArgs(Point _p, string text)
        {
            Point = _p;
            Text = text;
        }
    }
}
