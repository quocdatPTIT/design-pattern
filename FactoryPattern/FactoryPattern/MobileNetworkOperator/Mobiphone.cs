namespace FactoryPattern.MobileNetworkOperator
{
    // ReSharper disable once StringLiteralTypo
    public class Mobiphone : INetwork
    {
        public string GetNameNetwork()
        {
            return "VINAPHONE";
        }

        public string CheckAccountMoney()
        {
            return "*101#";
        }

        public string[] GetCarrierNumber()
        {
            return new[] {"090", "093", "0120", "0121", "0122", "0126", "0128", "089"};
        }
    }
}