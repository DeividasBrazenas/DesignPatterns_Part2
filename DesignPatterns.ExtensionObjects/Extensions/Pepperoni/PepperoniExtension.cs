namespace DesignPatterns.ExtensionObjects.Extensions.Pepperoni
{
    using Components;

    public class PepperoniExtension : IPepperoniExtension
    {
        private readonly IPizza _pizza;

        public PepperoniExtension(IPizza pizza)
        {
            _pizza = pizza;
        }

        public string GetDescription()
        {
            return ", pepperoni";
        }

        public double GetSellingCost()
        {
            return 3.5;
        }
    }
}