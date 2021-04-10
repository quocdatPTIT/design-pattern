namespace FactoryPattern.MobileNetworkOperator
{
    // ReSharper disable once StringLiteralTypo
    public class Vinaphone : INetwork
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
            return new[] {"091", "094", "083", "084", "085", "081", "082"};
        }
    }
}