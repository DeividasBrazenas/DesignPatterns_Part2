namespace DesignPatterns.ExtensionObjects.Extensions.Cost
{
    using Components;

    public class CostExtension : ICostExtension
    {
        private readonly IPizza _pizza;

        public CostExtension(IPizza pizza)
        {
            _pizza = pizza;
        }

        public string GetDescription()
        {
            return $". Total cost is {_pizza.GetSellingCost()}";
        }

        public double GetSellingCost()
        {
            return 0;
        }

        public double GetCostToMake(double profit)
        {
            return _pizza.GetSellingCost() - profit;
        }

        public double GetDeliveryCost(double distance)
        {
            return distance * 0.5;
        }
    }
}