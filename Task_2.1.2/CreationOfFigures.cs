using System;

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
                AddFigure();
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

    public void AddFigure()
    {
        var figure = figureStarter.GetStartedFigure(type);
        Console.WriteLine($"Фигура {figure} создана." + Environment.NewLine)
              }

}


