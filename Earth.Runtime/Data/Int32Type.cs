using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Earth.Runtime.Data
{
    public class Int32Type : MemoryType
    {
        private Int32 m_Data;

        public Int32Type(Int32 data)
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
