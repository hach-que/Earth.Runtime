using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Earth.Runtime.Data
{
    public class FloatingPointType : MemoryType
    {
        private float m_Data;

        public FloatingPointType(float data)
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
