using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.ExtensionMethods
{
    public static class StringExtension
    {
        public static string Reverse(this string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        public static void Main()
        {
            string str = "Hello World";
            string reversedStr = str.Reverse();
            Console.WriteLine(reversedStr); // Output: dlroW olleH
        }
    }   
}
