using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Earth.Runtime.Data
{
    public class NativeIntType : MemoryType
    {
        private int m_Data;

        public NativeIntType(int data)
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
