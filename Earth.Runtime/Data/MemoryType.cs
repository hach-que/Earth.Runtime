using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Earth.Runtime.Data
{
    public abstract class MemoryType
    {
        public abstract byte[] GetBytes();
        public abstract object GetInternal();
    }
}
