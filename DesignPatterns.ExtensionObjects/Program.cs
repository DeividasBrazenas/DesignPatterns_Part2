namespace DesignPatterns.ExtensionObjects
{
    using System;
    using Components;
    using Extensions.Chilli;
    using Extensions.Cost;
    using Extensions.Pepperoni;

    internal class Program
    {
        private static void Main(string[] args)
        {
            var pizza = new PizzaMargherita();

            var pepperoni = new PepperoniExtension(pizza);
            var chilli = new ChilliExtension(pizza);
            var cost = new CostExtension(pizza);

            pizza.AddExtension(pepperoni);
            pizza.AddExtension(chilli);
            pizza.AddExtension(cost);

            Console.WriteLine(pizza.GetDescription());
            Console.WriteLine(pizza.GetSellingCost());

            Console.WriteLine(pizza.GetExtension<ChilliExtension>().IsHot(6));

            Console.WriteLine(pizza.GetExtension<CostExtension>().GetDeliveryCost(4));
            Console.WriteLine(pizza.GetExtension<CostExtension>().GetCostToMake(2.5));

            Console.ReadKey();
        }
    }
}