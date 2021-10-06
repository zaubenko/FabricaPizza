using System;
using System.Collections.Generic;
using System.Text;

namespace LAB
{
    abstract class Kafe
    {
        public string name { get; set; }
        public int price { get; set; }


        public Kafe(string n, int p)
        {
            name = n;
            price = p;
        }
        abstract public Eda Create();
    }

    class PizzaCreator : Kafe
    {
        public PizzaCreator(string n, int p) : base(n, p) { }
        public override Eda Create()
        {
            return new Pizza();
        }
    }

    class CocteileCreator : Kafe
    {
        public CocteileCreator(string n, int p) : base(n, p) { }
        public override Eda Create()
        {
            return new Cocteile();
        }
    }

    abstract class Eda
    { }
    class Pizza : Eda
    {
        public Pizza()
        {
            Console.WriteLine("Готовим пиццу");
        }
    }
    class Cocteile : Eda
    {
        public Cocteile()
        {
            Console.WriteLine("Готовим коктейль");
        }
    }

    class Program1
    {
        static void Main(string[] args)
        {
            Kafe one = new PizzaCreator("More", 199);
            Eda pizza = one.Create();
            Console.ReadLine();
        }
    }
}