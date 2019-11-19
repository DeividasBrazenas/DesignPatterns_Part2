namespace DesignPatterns.Visitor.Components
{
    public class PizzaFourCheese : Pizza
    {
        public override string GetDescription()
        {
            return "Dough, mozzarella, parmesan, ricotta, brie";
        }

        public override double GetSellingCost()
        {
            return 6.00;
        }
    }
}