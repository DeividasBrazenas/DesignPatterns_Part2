namespace DesignPatterns.ExtensionObjects.Components
{
    public class PizzaMargherita : Pizza
    {
        public override string GetDescription()
        {
            return "Dough, tomatoes, mozzarella, basil" + base.GetDescription();
        }

        public override double GetSellingCost()
        {
            return 5.00 + base.GetSellingCost();
        }
    }
}