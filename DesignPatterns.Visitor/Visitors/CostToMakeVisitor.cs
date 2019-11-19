namespace DesignPatterns.Visitor.Visitors
{
    using Components;

    public class CostToMakeVisitor : IVisitor<double>
    {
        private readonly double _profit;

        public CostToMakeVisitor(double profit)
        {
            _profit = profit;
        }

        public double Visit(IPizza pizza)
        {
            return pizza.GetSellingCost() - _profit;
        }
    }
}