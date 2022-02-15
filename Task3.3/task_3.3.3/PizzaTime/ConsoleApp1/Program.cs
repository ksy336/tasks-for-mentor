using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {

        static void Main(string[] args)
        {
         
            Buyer buyer = new Buyer("Ксения");
            Order order = new Order(buyer);
            order.Message += GetPizzaOrder;
            order.MakePizza(Pizza.Крудо);
            Console.ReadLine();
        }

        static void GetPizzaOrder(string order)
        {
            Console.WriteLine(order);
        }


    }

    public enum Pizza
    {
        Маргарита,
        Маринара,
        Неаполетано,
        Карбонара,
        Крудо
    }

    public class Pizzeria
    {
        public delegate void OrderHandler(Pizza pizza);
        public event OrderHandler Message;
        public void Cook(Pizza pizza)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Подождите, пицца готовится...");
                Thread.Sleep(3000);
            }

            Message?.Invoke(pizza);
        }


    }

    public class Buyer
    {
        public string Name { get; private set; }
        public Buyer(string name)
        {
            Name = name;
        }
    }

    public class Order
    {
        public delegate void OrderHandler(string order);
        public event OrderHandler Message;
        public Order(Buyer buyer)
        {
            this.buyer = buyer;
        }

        Buyer buyer;
       // Pizza pizza;
        Pizzeria pizzeria = new Pizzeria();

        public void MakePizza(Pizza pizza)
        {
            pizzeria.Message += DoneOrder;
            pizzeria.Cook(pizza);
        }
        public void DoneOrder(Pizza pizza)
        {
            Console.WriteLine($"Пицца {pizza} готова для {buyer.Name}!");
           
        }

    }

  

}