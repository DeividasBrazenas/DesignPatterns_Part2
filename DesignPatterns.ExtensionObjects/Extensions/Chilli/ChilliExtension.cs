namespace DesignPatterns.ExtensionObjects.Extensions.Chilli
{
    using Components;

    public class ChilliExtension : IChilliExtension
    {
        private readonly IPizza _pizza;

        public ChilliExtension(IPizza pizza)
        {
            _pizza = pizza;
        }

        public string GetDescription()
        {
            return ", chilli";
        }

        public double GetSellingCost()
        {
            return 1.3;
        }

        public bool IsHot(int heatLevel)
        {
            return heatLevel > 5;
        }
    }
}