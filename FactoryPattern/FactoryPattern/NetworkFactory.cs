using System;
using FactoryPattern.Enum;
using FactoryPattern.MobileNetworkOperator;

namespace FactoryPattern
{
    // ReSharper disable once StringLiteralTypo
    public class NetworkFactory
    {
        public static INetwork CreateNetwork(NetworkType type)
        {
            return type switch
            {
                NetworkType.VIETTEL => new Viettel(),
                NetworkType.MOBIPHONE => new Mobiphone(),
                NetworkType.VINAPHONE => new Vinaphone(),
                _ => throw new ArgumentException("Invalid type")
            };
        }
    }
}