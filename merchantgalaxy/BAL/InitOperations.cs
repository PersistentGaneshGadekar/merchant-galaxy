using merchantgalaxy.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace merchantgalaxy.BAL
{
    public class InitOperations
    {
        public void AddAlias(string lines, AliasMapper aliasMapper)
        {
            if (lines.Contains("is"))
            {
                string[] alies = lines.Split(new string[] { " is " }, StringSplitOptions.RemoveEmptyEntries);
                if(alies.Length  == 2 && alies[1] != "")
                {
                    string roman = alies[1];
                    aliasMapper.AddAlias(alies[0], alies[1]);
                }
            }
        }
        public void AddCommodity(string lines, AliasMapper aliasMapper, RomanConverter converter, CommodityIndex commodityIndex)
        {
            string[] parts = lines.Split(new string[] { " is " }, StringSplitOptions.RemoveEmptyEntries);
            string[] wordsInFirstPart = parts[0].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] wordsInSecondPart = parts[1].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            double decimalPrice = 0;
            Double.TryParse(wordsInSecondPart[0], out decimalPrice);

            string commodity = wordsInFirstPart[wordsInFirstPart.Length - 1];
            string aliasValue = string.Empty;

            //Create Roman Numeral from aliases
            StringBuilder sb = new StringBuilder();
            string[] wordsInFirstPart1 = wordsInFirstPart.Take(wordsInFirstPart.Length - 1).ToArray();
            foreach (string alias in wordsInFirstPart1)
            {

                sb.Append(aliasMapper.GetValueForAlias(alias));

            }
            double? totalUnits = converter.CalculateDecimalValue(sb.ToString());

            ////Calculate and store per unit price of commodity
            if (totalUnits.HasValue) commodityIndex.AddCommodity(commodity, decimalPrice / totalUnits.Value);
            else Console.WriteLine("\nError occurred while calculating commodity price");
        }
    }
}
