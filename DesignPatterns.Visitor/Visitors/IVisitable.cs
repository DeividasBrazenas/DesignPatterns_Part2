namespace DesignPatterns.Visitor.Visitors
{
    public interface IVisitable
    {
        T AcceptVisitor<T>(IVisitor<T> visitor);
    }
}