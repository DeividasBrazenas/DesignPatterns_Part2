namespace DesignPatterns.Decorator.Decorators
{
    using Components;

    public abstract class PizzaDecorator : IPizza
    {
        public IPizza Pizza;

        protected PizzaDecorator(IPizza pizza)
        {
            Pizza = pizza;
        }

        public virtual string GetDescription()
        {
            return Pizza.GetDescription();
        }

        public virtual double GetSellingCost()
        {
            return Pizza.GetSellingCost();
        }
    }
}