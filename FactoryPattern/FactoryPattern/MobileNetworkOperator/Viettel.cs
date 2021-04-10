namespace FactoryPattern.MobileNetworkOperator
{
    // ReSharper disable once StringLiteralTypo
    public class Viettel : INetwork
    {
        public string GetNameNetwork()
        {
            return "VIETTEL";
        }

        public string CheckAccountMoney()
        {
            return "*101#";
        }

        public string[] GetCarrierNumber()
        {
            return new[] {"086", "096", "097", "098", "032", "033", "034", "035", "036", "037", "038", "039"};
        }
    }
}