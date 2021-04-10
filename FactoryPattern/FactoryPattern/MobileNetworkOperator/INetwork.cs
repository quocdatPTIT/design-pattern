namespace FactoryPattern.MobileNetworkOperator
{
    public interface INetwork
    {
        string GetNameNetwork();
        string CheckAccountMoney();
        string[] GetCarrierNumber();
    }
}