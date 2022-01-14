using System.Text;

namespace Custom_Paint
{
    public abstract class Figure
    {
        public virtual double GetLength => 0;
        public virtual double GetArea => 0;

        public virtual string BulidString()
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine(ToString());
            str.AppendLine($"��������: {GetLength}");
            str.AppendLine($"�������: {GetArea}");
            return str.ToString();
        }
    }

}