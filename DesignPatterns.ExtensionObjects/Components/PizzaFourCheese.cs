namespace DesignPatterns.ExtensionObjects.Components
{
    public class PizzaFourCheese : Pizza
    {
        public override string GetDescription()
        {
            return "Dough, mozzarella, parmesan, ricotta, brie" + base.GetDescription();
        }

        public override double GetSellingCost()
        {
            return 6.00 + base.GetSellingCost();
        }
    }
}