using System;
using FactoryPattern.Enum;
using FactoryPattern.MobileNetworkOperator;

// ReSharper disable once IdentifierTypo
// ReSharper disable once StringLiteralTypo
namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            Console.WriteLine("====== VIETTEL ======");
            INetwork viettel = NetworkFactory.CreateNetwork(NetworkType.VIETTEL);
            Console.WriteLine(viettel.GetNameNetwork());
            Console.WriteLine(viettel.CheckAccountMoney());
            Console.WriteLine(viettel.GetCarrierNumber());
            
            Console.WriteLine("====== MOBIPHONE ======");
            INetwork mobiphone = NetworkFactory.CreateNetwork(NetworkType.MOBIPHONE);
            Console.WriteLine(mobiphone.GetNameNetwork());
            Console.WriteLine(mobiphone.CheckAccountMoney());
            Console.WriteLine(mobiphone.GetCarrierNumber());
        }
    }
}