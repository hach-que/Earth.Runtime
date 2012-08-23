using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Earth.Runtime.Data
{
    public class ObjectReferenceType : MemoryType
    {
        // FIXME: Determine what actual type to store..
        private object m_Data;

        public ObjectReferenceType(object data)
        {
            this.m_Data = data;
        }

        public override byte[] GetBytes()
        {
            return new byte[0];
        }

        public override object GetInternal()
        {
            throw new NotSupportedException();
        }
    }
}
