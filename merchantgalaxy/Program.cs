using merchantgalaxy.BAL;
using merchantgalaxy.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace merchantgalaxy
{
    public class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\user\Desktop\data.txt";
            FileOperations fileOperations = new FileOperations();
            string[] lines = fileOperations.getInputFile(path);

            RomanConverter converter = new RomanConverter();
            //Dictionary<string, int> dictionaryRoman = converter.getRomanConverter();
            AliasMapper aliasMapper = new AliasMapper();
            CommodityIndex commodityIndex = new CommodityIndex();
            Console.WriteLine("\n--- Output Start ---");
            InitOperations initOperations = new InitOperations();
            Output output = new Output();
            if(lines !=  null && lines.Length > 0)
            {
                for (int i = 0; i < lines.Length; i++)
                {
                    if (i <= 3)
                    {
                        initOperations.AddAlias(lines[i], aliasMapper);
                    }
                    else if (!lines[i].ToLower().Contains("how") && lines[i].Contains("Credits"))
                    {
                        initOperations.AddCommodity(lines[i], aliasMapper, converter, commodityIndex);
                    }
                    else if (lines[i].ToLower().Contains("how much") && lines[i].Contains("is"))
                    {
                        output.displayPoints(lines[i], aliasMapper, converter);
                    }
                    else if (lines[i].ToLower().Contains("how many"))
                    {
                        output.displayCredits(lines[i], aliasMapper, converter, commodityIndex);

                    }
                    else if (lines[i].ToLower().Contains("how much") && !lines[i].Contains("is"))
                    {
                        Console.WriteLine("\nI have no idea what you are talking about");
                    }
                }
                Dictionary<string, int> dictionaryRoman = converter.getRomanConverter();
                Dictionary<string, string> dictionaryaliasMapper = aliasMapper.getAliasMapper();
                Dictionary<string, double> dictionaryCommodityIndex = commodityIndex.getCommodityIndex();
            }
         
            Console.WriteLine("\n--- Output End ---");
        }
    }
}
