using System.Text;

namespace Custom_Paint
{
    public class Side : Figure
    {
        public Point point1 { get; private set; }
        public Point point2 { get; private set; }
        public double Length => point1.Length(point2);

        public double AlphaAngle(Side side)
        {
            if (this.SecondPoint.Equals(side.point1))
            {
                double numerator = (this.point1.X - this.point2.X)
                    * (side.point2.X - side.point1.X)
                    + (this.point1.Y - this.point2.Y)
                    * (side.point2.Y - side.point1.Y);
                double denominator = Math.Abs(this.point2.Length(point1))
                    * Math.Abs(side.Length);
                return Math.Acos(numerator / denominator);
            }
            else
                throw new Exception();
        }
        public Side(Point first, Point second)
        {
            point1 = first;
            point2 = second;
        }

        public override string ToString()
        {
            return $"Side: ({point1}; {point2})";
        }
    }
}