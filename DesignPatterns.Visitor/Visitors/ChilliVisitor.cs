namespace DesignPatterns.Visitor.Visitors
{
    using Components;

    public class ChilliVisitor : IVisitor<bool>
    {
        private readonly int _heatLevel;

        public ChilliVisitor(int heatLevel)
        {
            _heatLevel = heatLevel;
        }

        public bool Visit(IPizza pizza)
        {
            return _heatLevel > 5;
        }
    }
}