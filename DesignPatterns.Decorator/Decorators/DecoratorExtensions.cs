namespace DesignPatterns.Decorator.Decorators
{
    using Components;

    public static class DecoratorExtensions
    {
        public static T GetRole<T>(this IPizza component) where T : PizzaDecorator
        {
            switch (component)
            {
                case T requested:
                    return requested;
                case PizzaDecorator anotherDecorator:
                    return GetRole<T>(anotherDecorator.Pizza);
                default:
                    return null;
            }
        }

        public static PizzaDecorator RemoveRole<T>(this IPizza component) where T : PizzaDecorator
        {
            switch (component)
            {
                case T toRemove:
                    return toRemove.Pizza as PizzaDecorator;
                case PizzaDecorator decorator when decorator.Pizza is T toRemove:
                    decorator.Pizza = toRemove.Pizza;
                    return decorator;
                case PizzaDecorator decorator:
                    if (decorator.Pizza is PizzaDecorator)
                        decorator.Pizza = decorator.Pizza.RemoveRole<T>();
                    return decorator;
                default:
                    return null;
            }
        }
    }
}