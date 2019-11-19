namespace DesignPatterns.Decorator.Decorators
{
    using Components;

    public class PepperoniDecorator : PizzaDecorator
    {
        public PepperoniDecorator(IPizza pizza) : base(pizza)
        {
        }

        public override string GetDescription()
        {
            return Pizza.GetDescription() + ", pepperoni";
        }

        public override double GetSellingCost()
        {
            return Pizza.GetSellingCost() + 3.5;
        }
    }
}