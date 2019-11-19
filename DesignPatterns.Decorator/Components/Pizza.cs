namespace DesignPatterns.Decorator.Components
{
    public abstract class Pizza : IPizza
    {
        public abstract string GetDescription();

        public abstract double GetSellingCost();
    }
}