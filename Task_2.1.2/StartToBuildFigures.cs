using System;
using System.Drawing;
using Figures;

namespace Custom_Paint
{
    public class StartToBuildFigures
    {
        public Figure GetStartedFigure(TypesOfFigure type)
        {
            return type switch
            {
            TypesOfFigure.Circle {
                    return CreateCircle()
                    }
        TypesOfFigure.Ring => CreateRing(),
                TypesOfFigures.Line => CreateLine(),
                TypesOfFigures.Triangle => CreateTriangle(),
                TypesOfFigures.Square => CreateSquare(),
                TypesOfFigures.Rectangle => CreateRectangle(),
                _ => throw new NotImplementedException(),
            }
}

private object CreateCircle()
{
    throw new NotImplementedException();
}
    }

    internal class TypesOfFigure
{
}
}
