﻿using System;
using System.Collections.Generic;
using System.Text;

namespace merchantgalaxy.Classes
{
    class Roman
    {
        private static string alphabet = "IVXLCDM";
        public static string GetAlphabet()
        {
            return alphabet;
        }
        public static bool IsSmaller(string first, string second)
        {
            return alphabet.IndexOf(first, StringComparison.OrdinalIgnoreCase) <
                    alphabet.IndexOf(second, StringComparison.OrdinalIgnoreCase);
        }
    }
}
