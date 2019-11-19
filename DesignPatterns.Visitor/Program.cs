namespace DesignPatterns.Visitor
{
    using System;
    using Components;
    using Visitors;

    internal class Program
    {
        private static void Main(string[] args)
        {
            var pizza = new PizzaMargherita();
            var chilliVisitor = new ChilliVisitor(6);
            var costToMakeVisitor = new CostToMakeVisitor(2.5);
            var deliveryCostVisitor = new DeliveryCostVisitor(4);

            Console.WriteLine(pizza.AcceptVisitor(chilliVisitor));
            Console.WriteLine(pizza.AcceptVisitor(costToMakeVisitor));
            Console.WriteLine(pizza.AcceptVisitor(deliveryCostVisitor));

            Console.ReadKey();
        }
    }
}