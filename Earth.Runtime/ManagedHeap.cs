using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Earth.Runtime
{
    public class ManagedHeap
    {
        private byte[] m_Memory = null;

        public ManagedHeap(int kb)
        {
            this.m_Memory = new byte[kb * 1024];
        }

        public byte Get(int idx)
        {
            return this.m_Memory[idx];
        }

        public byte[] Get(int idx, int len)
        {
            byte[] r = new byte[len];
            for (int i = 0; i < len; i++)
                r[i] = this.m_Memory[idx + i];
            return r;
        }

        public void Set(int idx, byte data)
        {
            this.m_Memory[idx] = data;
        }

        public void Set(int idx, int len, byte[] data)
        {
            for (int i = 0; i < len; i++)
                this.m_Memory[idx + i] = data[i];
        }
    }
}
