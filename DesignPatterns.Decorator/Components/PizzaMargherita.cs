namespace DesignPatterns.Decorator.Components
{
    public class PizzaMargherita : Pizza
    {
        public override string GetDescription()
        {
            return "Dough, tomatoes, mozzarella, basil";
        }

        public override double GetSellingCost()
        {
            return 5.00;
        }
    }
}