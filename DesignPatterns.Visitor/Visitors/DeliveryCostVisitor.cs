namespace DesignPatterns.Visitor.Visitors
{
    using Components;

    public class DeliveryCostVisitor : IVisitor<double>
    {
        private readonly double _distance;

        public DeliveryCostVisitor(double distance)
        {
            _distance = distance;
        }

        public double Visit(IPizza pizza)
        {
            return _distance * 0.5;
        }
    }
}