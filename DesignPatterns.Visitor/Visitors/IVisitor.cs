namespace DesignPatterns.Visitor.Visitors
{
    using Components;

    public interface IVisitor<out T>
    {
        T Visit(IPizza pizza);
    }
}