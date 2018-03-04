using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachTim.Extensions
{
    public static class StringExtension
    {
        public static string RemoveWhiteSpacesAtEnds(this string str)
        {
            var splitedStr = str.Split(separator: new char []{ ' ', '\t' }, options:StringSplitOptions.RemoveEmptyEntries);
            var readyStr = string.Join(" ", splitedStr);
            return readyStr;
        }
        public static string[] RemoveWhiteSpacesAtEnds(this string[] strings)
        {
            var readyArr = strings.Select(str => str.RemoveWhiteSpacesAtEnds()).ToArray();
            return readyArr;
        }
    }
}
