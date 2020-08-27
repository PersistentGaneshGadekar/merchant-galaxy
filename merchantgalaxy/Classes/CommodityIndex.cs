using merchantgalaxy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace merchantgalaxy.Classes
{
    public class CommodityIndex : IValidate
    {
        private Dictionary<string, double> commodityMap;
        public CommodityIndex()
        {
            commodityMap = new Dictionary<string, double>();
        }
        public void AddCommodity(string name, double perUnitPrice)
        {
            if (!commodityMap.ContainsKey(name)) commodityMap.Add(name, perUnitPrice);
            else commodityMap[name] = perUnitPrice;
        }
        public double GetPriceByCommodity(string commodity)
        {
            return commodityMap[commodity];
        }
        public bool Exists(string commodity)
        {
            return commodityMap.ContainsKey(commodity);
        }
        public Dictionary<string, double> getCommodityIndex()
        {
            return commodityMap;
        }
    }
}
