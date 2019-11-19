namespace DesignPatterns.ExtensionObjects.Extensions.Chilli
{
    public interface IChilliExtension : IExtension
    {
        bool IsHot(int heatLevel);
    }
}