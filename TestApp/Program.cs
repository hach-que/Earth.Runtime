using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestApp
{
    class Program
    {
        static int Main(string[] args)
        {
            // This test application is read in by Mono.Cecil and
            // executed using Earth.Runtime.
            Console.WriteLine("Hello, world!");
            return 2398642;

            // This test application is read in by Mono.Cecil and
            // executed using Earth.Runtime.
            string myVar = "Hello,";
            myVar += " world!";
            Console.WriteLine(myVar);
            return 3;
        }
    }
}
