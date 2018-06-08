using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_2
{
    public static class ArrayExtensions
    {
        public static string ArrayToString(this int[] array, string delimiter)
        {
            var str = new StringBuilder(1000);
            foreach(var item in array)
                str.Append(item.ToString() + delimiter);
            str.Remove(str.ToString().LastIndexOf(delimiter), delimiter.Length);
            return str.ToString();
        }
    }
}
