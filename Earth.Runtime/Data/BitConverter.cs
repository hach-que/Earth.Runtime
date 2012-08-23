using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Earth.Runtime.Data
{
    public static class BitConverter
    {
        public static byte[] GetBytes(Int64 data)
        {
            byte[] result = new byte[8];
            for (int i = 0; i < 8; i++)
                result[i] = (byte)((data & (0xFF << (8 * i))) >> (8 * i));
            return result;
        }

        public static byte[] GetBytes(Int32 data)
        {
            byte[] result = new byte[4];
            for (int i = 0; i < 4; i++)
                result[i] = (byte)((data & (0xFF << (8 * i))) >> (8 * i));
            return result;
        }

        public static byte[] GetBytes(IntPtr data)
        {
            unsafe
            {
                byte[] result = new byte[sizeof(IntPtr)];
                for (int i = 0; i < 4; i++)
                    result[i] = (byte)(((int)data & (0xFF << (8 * i))) >> (8 * i));
                return result;
            }
        }

        public static byte[] GetBytes(float data)
        {
            // FIXME!
            #warning Floating-point byte conversion will not compile successfully under IL2CPU without implementation.
            return System.BitConverter.GetBytes(data);
        }
    }
}
