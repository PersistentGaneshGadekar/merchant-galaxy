using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace merchantgalaxy.BAL
{
    public class FileOperations
    {
        public string[] getInputFile(string path)
        {
            string[] lines =  null;
            if (File.Exists(path))
            {
                string readText = File.ReadAllText(path);
                lines = readText.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                Console.WriteLine("--- Input Start ---");
                Console.WriteLine(readText);
                Console.WriteLine("--- Input End ---");
            }
            
            return lines;
        }
    }
}
