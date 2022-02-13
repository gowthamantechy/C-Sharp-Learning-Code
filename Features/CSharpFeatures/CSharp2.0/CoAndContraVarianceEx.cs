﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CSharpFeatures.CSharp2._0
{
    public class CoAndContraVarianceEx
    {

        static object GetObject() { return null; }
        static void SetObject(object obj) { }

        static string GetString() { return ""; }
        static void SetString(string str) { }
        static void Main()
        {

            // Assignment compatibility.
            string str = "test";
            // An object of a more derived type is assigned to an object of a less derived type.
            object obj = str;

            // Covariance.
            IEnumerable<string> strings = new List<string>();
            // An object that is instantiated with a more derived type argument
            // is assigned to an object instantiated with a less derived type argument.
            // Assignment compatibility is preserved.
            IEnumerable<object> objects = strings;

            // Contravariance.
            // Assume that the following method is in the class:
            // static void SetObject(object o) { }
            Action<object> actObject = SetObject;
            // An object that is instantiated with a less derived type argument
            // is assigned to an object instantiated with a more derived type argument.
            // Assignment compatibility is reversed.
            Action<string> actString = actObject;

            ReadKey();
        }
    }
}
