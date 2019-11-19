namespace DesignPatterns.Decorator.Decorators
{
    using Components;

    public class ChilliDecorator : PizzaDecorator
    {
        public ChilliDecorator(IPizza pizza) : base(pizza)
        {
        }

        public override string GetDescription()
        {
            return Pizza.GetDescription() + ", chilli";
        }

        public override double GetSellingCost()
        {
            return Pizza.GetSellingCost() + 1.3;
        }

        public bool IsHot(int heatLevel)
        {
            return heatLevel > 5;
        }
    }
}