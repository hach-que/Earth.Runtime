using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Earth.Runtime.Data
{
    public class Int64Type : MemoryType
    {
        private Int64 m_Data;

        public Int64Type(Int64 data)
        {
            this.m_Data = data;
        }

        public override byte[] GetBytes()
        {
            return BitConverter.GetBytes(this.m_Data);
        }

        public override object GetInternal()
        {
            return this.m_Data;
        }
    }
}
