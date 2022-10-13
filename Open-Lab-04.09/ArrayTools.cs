using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Open_Lab_04._09
{
    public class ArrayTools
    {
        public string[] RemoveDups(string[] strings)
        {
            string[] dist = strings.Distinct().ToArray();
            return dist;
        }
    } 
}
