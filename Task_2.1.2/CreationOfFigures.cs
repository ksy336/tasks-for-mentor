using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Custom_Paint
{
    public class CreationOfFigures
    {
        int input;
        string str;

        public static Point Input(string name)
        {
            double x;
            double y;
            Console.Write($"{Environment.NewLine}{name} точка:" +
                $"{Environment.NewLine}X: ");
            double.TryParse(Console.ReadLine(), out x);
            Console.Write("Y: ");
            double.TryParse(Console.ReadLine(), out y);
            return new Point(x, y);
        }

        public void GetStarted()
        {
            do
            {
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1. Добавить фигуру");
                Console.WriteLine("2. Вывести фигуры");
                Console.WriteLine("3. Очистить холст");
                Console.WriteLine("4. Выход");
                str = Console.ReadLine();
            } while (!int.TryParse(str, out input));
            Console.Clear();

            switch (input)
            {
             case 1:

                    Console.WriteLine("Выбери фигуру для создания:");
                    Console.WriteLine("1. Создать линию:");
                    Console.WriteLine("2. Создать круг:");
                    Console.WriteLine("3. Создать кольцо: ");
                    Console.WriteLine("4. Создать треугольник: ");
                    Console.WriteLine("5. Создать прямоугольник");
                    Console.WriteLine("6. Создать квадрат: ");

                    string variant = Console.ReadLine();
                    Point point1;
                    Point point2;
                    Point point3;
                    Point point4;
                    double internalRadius;
                    double externalRadius;

                    switch (variant)
                    {
                        case 1:
                            point1 = Input("Первая точка");
                            point2 = Input("Вторая точка");
                            try
                            {
                                Side side = new Side(point1, point2);
                                user.Figures.Add(side);
                                Console.WriteLine($"Линия создана: {side}");
                                Console.WriteLine();
                                GetStarted();
                            }
                            catch
                            {
                                throw new Exception();
                            }
                            break;

                        case 2:
                            point1 = Input("Первая точка");
                            Console.Write("Введите радиус: ");
                            internalRadius = Console.ReadLine();
                            try
                            {
                                Circle circle = new Circle(point1, internalRadius);
                                user.Figures.Add(circle);
                                Console.WriteLine($"Круг создан: {circle}");
                                Console.WriteLine();
                                GetStarted();
                            }
                            catch
                            {
                                throw new Exception();
                            }
                            break;

                        case 3:
                            point1 = Input("Первая точка");
                            Console.Write("Введите внутренний радиус: ");
                            internalRadius = Console.ReadLine();
                            Console.Write("Введите внешний радиус: ");
                            externalRadius = Console.ReadLine();
                            try
                            {
                                Ring ring = new Ring(point1, internalRadius, externalRadius);
                                user.Figures.Add(ring);
                                Console.WriteLine($"Кольцо создано: {ring}");
                                Console.WriteLine();
                                GetStarted();
                            }
                            catch
                            {
                                throw new Exception();
                            }
                            break;

                        case 4:
                            point1 = Input("Первая точка");
                            point2 = Input("Вторая точка");
                            point3 = Input("Третья точка");

                            try
                            {
                                Triangle triangle = new Triangle(point1, point2, point3);
                                user.Figures.Add(triangle);
                                Console.WriteLine($"Треугольник создан: {triangle}");
                                Console.WriteLine();
                                GetStarted();
                            }
                            catch
                            {
                                throw new Exception();
                            }
                            break;

                        case 5:
                            point1 = Input("Первая точка");
                            point2 = Input("Вторая точка");
                            point3 = Input("Третья точка");
                            point4 = Input("Четвертая точка");

                            try
                            {
                                Rectangle rectangle = new Rectangle(point1, point2, point3, point4);
                                user.Figures.Add(rectangle);
                                Console.WriteLine($"Прямоугольник создан: {rectangle}");
                                Console.WriteLine();
                                GetStarted();
                            }
                            catch
                            {
                                throw new Exception();
                            }
                            break;

                        case 6:
                            point1 = Input("Первая точка");
                            point2 = Input("Вторая точка");
                            point3 = Input("Третья точка");
                            point4 = Input("Четвертая точка");

                            try
                            {
                                Square square = new Square(point1, point2, point3, point4);
                                user.Figures.Add(square);
                                Console.WriteLine($"Квадрат создан: {square}");
                                Console.WriteLine();
                                GetStarted();
                            }
                            catch
                            {
                                throw new Exception();
                            }
                            break;

                        default:
                            throw new NotImplementedException();
                    }
                    break;
            
            case 2:


            }

        }

    }



}
