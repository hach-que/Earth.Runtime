using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Earth.Runtime.TypeSystem
{
    public class TypeAttribute : Attribute
    {
        public TypeAttribute(string cilName, string libName)
        {
            this.CILName = cilName;
            this.LibraryName = libName;
        }

        public string CILName
        {
            get;
            private set;
        }

        public string LibraryName
        {
            get;
            private set;
        }
    }
}
