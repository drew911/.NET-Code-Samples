using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ListPractice
{
    class Program
    {
        public static string FirstLetterToUpper(string str)
        {
            if (str == null)
                return null;

            if (str.Length > 1)
                return char.ToUpper(str[0]) + str.Substring(1);

            return str.ToUpper();
        }

        static void Main(string[] args)
        {
            string[] lines =
         {
            "First line", "Second line", "Third line"
        };

            File.WriteAllLines("WriteLines.txt", lines);
        }

       
    }
}
