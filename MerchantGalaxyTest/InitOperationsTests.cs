using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using merchantgalaxy;
using merchantgalaxy.BAL;
using merchantgalaxy.Classes;

namespace MerchantGalaxyTest
{
    public class InitOperationsTests
    {
        [Fact]
        public void AddAlias_SetData()
        {
            FileOperations fileOperations = new FileOperations();
            AliasMapper aliasMapper = new AliasMapper();
            InitOperations initOperations = new InitOperations();
            initOperations.AddAlias("glob is I", aliasMapper);
            initOperations.AddAlias("prok is V", aliasMapper);
            initOperations.AddAlias("pish is X", aliasMapper);
            initOperations.AddAlias("tegj is L", aliasMapper);
            Assert.True(aliasMapper.getAliasMapper().Count > 0);
        }
        [Fact]
        public void AddAlias_DataNotPassed()
        {
            FileOperations fileOperations = new FileOperations();
            AliasMapper aliasMapper = new AliasMapper();
            InitOperations initOperations = new InitOperations();
            Assert.True(aliasMapper.getAliasMapper().Count  == 0);
        }

        [Fact]
        public void AddAlias_IncorrectDataPassed()
        {
            FileOperations fileOperations = new FileOperations();
            AliasMapper aliasMapper = new AliasMapper();
            InitOperations initOperations = new InitOperations();
            initOperations.AddAlias("prok", aliasMapper);
            Assert.True(aliasMapper.getAliasMapper().Count == 0);
        }
    }
}
