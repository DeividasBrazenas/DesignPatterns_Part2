namespace DesignPatterns.Visitor.Components
{
    using Visitors;

    public abstract class Pizza : IPizza, IVisitable
    {
        public abstract string GetDescription();

        public abstract double GetSellingCost();

        public T AcceptVisitor<T>(IVisitor<T> visitor)
        {
            return visitor.Visit(this);
        }
    }
}