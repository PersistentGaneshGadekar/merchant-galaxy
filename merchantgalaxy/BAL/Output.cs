using merchantgalaxy.Interfaces;
using merchantgalaxy.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace merchantgalaxy.BAL
{
    public class Output : IOutput
    {
        public void  displayPoints(string lines, AliasMapper aliasMapper, RomanConverter converter)
        {
            string[] parts = lines.Split(new string[] { " is " }, StringSplitOptions.RemoveEmptyEntries);
            string[] wordsInFirstPart = parts[0].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] wordsInSecondPart = parts[1].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder sb = new StringBuilder();
            string[] wordsInSecondPart1 = wordsInSecondPart.Take(wordsInSecondPart.Length - 1).ToArray();
            foreach (string alias in wordsInSecondPart1)
            {
                if (!aliasMapper.Exists(alias))
                {

                }
                else
                {
                    sb.Append(aliasMapper.GetValueForAlias(alias));
                }

            }

            Console.WriteLine(String.Format("\n{0} is {1}", string.Join(" ", wordsInSecondPart1), converter.CalculateDecimalValue(sb.ToString())));

        }

        public void  displayCredits(string lines, AliasMapper aliasMapper, RomanConverter converter, CommodityIndex commodityIndex)
        {
            //Console.WriteLine("Code here to print glob prok Silver is 68 Credits");
            string input = lines.Substring(0, lines.Length - 1);

            string[] parts = input.Split(new string[] { " is " }, StringSplitOptions.RemoveEmptyEntries);
            string[] words = parts[1].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string commodity = words[words.Length - 1];
            StringBuilder sb = new StringBuilder();

            //Create Roman Numeral from aliases
            for (int K = 0; K < words.Length - 1; K++)
            {
                sb.Append(aliasMapper.GetValueForAlias(words[K]));
            }

            //Convert Roman to Decimal
            double? totalUnits = converter.CalculateDecimalValue(sb.ToString());
            Console.WriteLine(String.Format("\n{0}is {1} Credits", parts[1], totalUnits.Value * commodityIndex.GetPriceByCommodity(commodity)));

        }

    }
}