using merchantgalaxy.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace merchantgalaxy.Interfaces
{
    public interface IOutput
    {
          void displayPoints(string lines, AliasMapper aliasMapper, RomanConverter converter);
          void displayCredits(string lines, AliasMapper aliasMapper, RomanConverter converter, CommodityIndex commodityIndex);
    }
}
