using System;
using System.Collections.Generic;
using System.Text;

namespace _01_Csharp_Big_Picture
{
    internal class Point
    {
        #region Auto-Implemented Properties
        /*
         * Auto-implemented properties (also called "auto-properties") let you declare
         * properties without writing explicit backing fields. The compiler automatically
         * creates a hidden private field for you.
         */

        #endregion
        public required double X { get; set; }

        #region Init property 
        /*  
         *  Init-only property C# 9+
         *  init accessors allow properties to be set only during object initialization,
         *  making them immutable after construction.
         * 
         *  Before init, you had to choose between:
         *  
         *  Mutable properties (unsafe - anyone can change them)
         *  Constructor parameters (verbose, especially with many properties)
         *  Readonly fields (can't use object initializers)
         *  
         *  Real-World Use: Perfect for DTOs, configuration objects, 
         *  API models - anything where you want immutability 
         *  but also clean initialization syntax.
         */
        #endregion

        public double Y { get; init; }

        override public string ToString() => $"X: {X}, Y: {Y}";
    }
}
