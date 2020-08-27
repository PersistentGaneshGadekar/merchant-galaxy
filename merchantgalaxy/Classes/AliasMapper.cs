using merchantgalaxy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace merchantgalaxy.Classes
{
    public class AliasMapper : IValidate
    {
        private Dictionary<string, string> aliasMap;

        public AliasMapper()
        {
            aliasMap = new Dictionary<string, string>();
        }

        public void AddAlias(string alias, string value)
        {
            if (!aliasMap.ContainsKey(alias)) aliasMap.Add(alias, value);
            else aliasMap[alias] = value;
        }

        public string GetValueForAlias(string alias)
        {
            return aliasMap[alias];
        }

        public bool Exists(string alias)
        {
            return aliasMap.ContainsKey(alias);
        }
        public Dictionary<string, string> getAliasMapper()
        {
            return aliasMap;
        }
    }
}
