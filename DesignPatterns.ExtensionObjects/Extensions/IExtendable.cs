namespace DesignPatterns.ExtensionObjects.Extensions
{
    public interface IExtendable
    {
        T GetExtension<T>() where T : IExtension;

        bool AddExtension<T>(T extension) where T : IExtension;

        bool RemoveExtension<T>() where T : IExtension;
    }
}