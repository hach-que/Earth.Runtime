using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Earth.Runtime.Data
{
    public class TransientPointerType : MemoryType
    {
        private IntPtr m_Data;

        public TransientPointerType(IntPtr data)
        {
            this.m_Data = data;
        }

        public override byte[] GetBytes()
        {
            return BitConverter.GetBytes(this.m_Data);
        }

        public override object GetInternal()
        {
            throw new NotSupportedException();
        }
    }
}
