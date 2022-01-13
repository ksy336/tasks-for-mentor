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
                    switch(variant)
                    {
                        case 1:
                            point1 = Input("Первая точка");
                            point2 = input("Вторая точка");
                            try
                            {
                                Side side = new Side(point1, point2);
                                user.Figures.Add();
                                Console.WriteLine($"Линия создана: {side}");
                                Console.WriteLine();
                                GetStarted();
                            }
                            catch
                            {
                                throw new Exception();
                            }
                    }
                    break;
                case 2:
                    ShowFigures();
                    break;
                case 3:
                    ClearAll();
                    break;
                case 4:
                    Exit();
                    break;
                default:
                    throw new NotImplementedException();
            }
        }

       

    }



}
