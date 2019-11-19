namespace DesignPatterns.ExtensionObjects.Components
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Extensions;

    public abstract class Pizza : IPizza, IExtendable
    {
        private readonly Dictionary<Type, IExtension> _extensions = new Dictionary<Type, IExtension>();

        public T GetExtension<T>() where T : IExtension
        {
            IExtension extension = null;

            _extensions?.TryGetValue(typeof(T), out extension);

            return (T) extension;
        }

        public bool AddExtension<T>(T extension) where T : IExtension
        {
            return _extensions?.TryAdd(typeof(T), extension) ?? false;
        }

        public bool RemoveExtension<T>() where T : IExtension
        {
            return _extensions?.Remove(typeof(T)) ?? false;
        }

        public virtual string GetDescription()
        {
            return _extensions.Aggregate("", (current, extension) => current + extension.Value.GetDescription());
        }

        public virtual double GetSellingCost()
        {
            return _extensions.Sum(extension => extension.Value.GetSellingCost());
        }
    }
}