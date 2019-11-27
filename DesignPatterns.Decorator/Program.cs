namespace DesignPatterns.Decorator
{
    using System;
    using Components;
    using Decorators;

    internal class Program
    {
        private static void Main(string[] args)
        {
            var pizza = new CostDecorator(new ChilliDecorator(new PepperoniDecorator(new PizzaMargherita())));

            Console.WriteLine(pizza.GetDescription());
            Console.WriteLine(pizza.GetSellingCost());

            var chilliPizza = pizza.GetRole<ChilliDecorator>();
            Console.WriteLine(chilliPizza.IsHot(6));

            var pizzaCost = pizza.GetRole<CostDecorator>();
            Console.WriteLine(pizzaCost.GetDeliveryCost(4));
            Console.WriteLine(pizzaCost.GetCostToMake(2.5));

            pizza.RemoveRole<PepperoniDecorator>();

            Console.WriteLine(pizza.GetDescription());
            Console.WriteLine(pizza.GetSellingCost());

            Console.ReadKey();
        }
    }
}