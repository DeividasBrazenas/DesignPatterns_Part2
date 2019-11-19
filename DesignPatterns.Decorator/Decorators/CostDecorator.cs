namespace DesignPatterns.Decorator.Decorators
{
    using Components;

    public class CostDecorator : PizzaDecorator
    {
        public CostDecorator(IPizza pizza) : base(pizza)
        {
        }

        public double GetCostToMake(double profit)
        {
            return Pizza.GetSellingCost() - profit;
        }

        public double GetDeliveryCost(double distance)
        {
            return distance * 0.5;
        }

        public override string GetDescription()
        {
            return $"{Pizza.GetDescription()}. Total cost is {Pizza.GetSellingCost()}";
        }
    }
}