using mygalaxy.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace merchantgalaxy.Interfaces
{
    interface IOutput
    {
        public void displayPoints(string lines, AliasMapper aliasMapper, RomanConverter converter);
        public void displayCredits(string lines, AliasMapper aliasMapper, RomanConverter converter, CommodityIndex commodityIndex);
    }
}
