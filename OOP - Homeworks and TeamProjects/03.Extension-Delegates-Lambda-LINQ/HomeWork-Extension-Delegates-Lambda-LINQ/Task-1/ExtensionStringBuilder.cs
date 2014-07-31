/* 
 * Implement an extension method Substring(int index, int length) 
 * for the class StringBuilder that returns new StringBuilder and 
 * has the same functionality as Substring in the class String.
*/

namespace Task_1
{
    using System;
    using System.Text;
    public static class ExtensionStringBuilder
    {
        public static StringBuilder Substring(this StringBuilder str, int index , int length)
        {
            StringBuilder returner = new StringBuilder();
            string tmp = str.ToString().Substring(index,length);
            return returner.Append(tmp);
        }
    }
}
