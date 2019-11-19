namespace DesignPatterns.Decorator.Decorators
{
    using Components;

    public static class DecoratorExtensions
    {
        public static T GetRole<T>(this IPizza pizza)
        {
            if (pizza.GetType().BaseType != typeof(PizzaDecorator)) return default;

            if (pizza.GetType() == typeof(T)) return (T) pizza;

            return ((PizzaDecorator) pizza).Pizza.GetRole<T>();
        }
    }
}