using System;
using System.Collections.Generic;
using System.Text;

namespace merchantgalaxy.Classes
{
    class RomanConverter
    {
        Dictionary<string, int> romanToDecimalMapper;

        public RomanConverter()
        {
            //Initialize toDecimalMapper
            romanToDecimalMapper = new Dictionary<string, int>();
            romanToDecimalMapper.Add("I", 1);
            romanToDecimalMapper.Add("V", 5);
            romanToDecimalMapper.Add("X", 10);
            romanToDecimalMapper.Add("L", 50);
            romanToDecimalMapper.Add("C", 100);
            romanToDecimalMapper.Add("D", 500);
            romanToDecimalMapper.Add("M", 1000);
        }

        public Dictionary<string,int> getRomanConverter()
        {
            return romanToDecimalMapper;
        }
        public double CalculateDecimalValue(string input)
        {
            double current = 0, next = 0, total = 0;

            for (int i = 0; i < input.Length; i++)
            {
                current = romanToDecimalMapper[input[i].ToString()];
                if (i < input.Length - 1) next = romanToDecimalMapper[input[i + 1].ToString()];

                if (current < next)
                {
                    total += next - current;
                    i++;
                }
                else { total += current; }
            }

            return total;
        }
    }
}
