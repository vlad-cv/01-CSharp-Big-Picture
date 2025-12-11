using System;
using System.Collections.Generic;
using System.Text;

namespace _01_Csharp_Big_Picture
{
    internal class Point
    {
        // Canonical properties
        public double X { get; set; }

        // Init-only property
        public double Y { get; init; }

        override public string ToString()
        {
            return $"X: {X}, Y: {Y}";
        }
    }
}
