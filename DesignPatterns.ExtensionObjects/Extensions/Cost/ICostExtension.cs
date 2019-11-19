namespace DesignPatterns.ExtensionObjects.Extensions.Cost
{
    public interface ICostExtension : IExtension
    {
        double GetCostToMake(double profit);

        double GetDeliveryCost(double distance);
    }
}