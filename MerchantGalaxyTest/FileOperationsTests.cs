using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using merchantgalaxy.BAL;
namespace MerchantGalaxyTest
{
    public class FileOperationsTests
    {
        [Fact]
        public void getInputFileTest()
        {
            string path = @"C:\Users\user\Desktop\data.txt";
            FileOperations fileOperations = new FileOperations();
            string[] actula = fileOperations.getInputFile(path);
            //assert
            Assert.True(actula.Length > 0);
        }

        [Fact]
        public void getInputFile_IncorrectPathTest()
        {
            string path = @"C:\Users\user\Desktop\data__.txt";
            FileOperations fileOperations = new FileOperations();
            string[] actual = fileOperations.getInputFile(path);
            //assert
            Assert.True(actual ==  null);
        }
    }
}
