using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mono.Cecil.Cil;

namespace Earth.Runtime
{
    public abstract class Operations
    {
        public readonly static IExecutableOp[] Codes;

        static Operations()
        {
            // Create array.
            Codes = new IExecutableOp[(int)Code.Readonly];

            // Fill array.
            Codes[(int)Code.Br] = new OpCodes.Br();
            Codes[(int)Code.Br_S] = new OpCodes.Br();
            Codes[(int)Code.Call] = new OpCodes.Call();
            Codes[(int)Code.Ldarg] = new OpCodes.Ldarg();
            Codes[(int)Code.Ldc_I4] = new OpCodes.Ldc(OpCodes.LdcType.i4);
            Codes[(int)Code.Ldc_I4_S] = new OpCodes.Ldc(OpCodes.LdcType.i4);
            Codes[(int)Code.Ldc_I4_0] = new OpCodes.Ldc(OpCodes.LdcType.i4, 0);
            Codes[(int)Code.Ldc_I4_1] = new OpCodes.Ldc(OpCodes.LdcType.i4, 1);
            Codes[(int)Code.Ldc_I4_2] = new OpCodes.Ldc(OpCodes.LdcType.i4, 2);
            Codes[(int)Code.Ldc_I4_3] = new OpCodes.Ldc(OpCodes.LdcType.i4, 3);
            Codes[(int)Code.Ldc_I4_4] = new OpCodes.Ldc(OpCodes.LdcType.i4, 4);
            Codes[(int)Code.Ldc_I4_5] = new OpCodes.Ldc(OpCodes.LdcType.i4, 5);
            Codes[(int)Code.Ldc_I4_6] = new OpCodes.Ldc(OpCodes.LdcType.i4, 6);
            Codes[(int)Code.Ldc_I4_7] = new OpCodes.Ldc(OpCodes.LdcType.i4, 7);
            Codes[(int)Code.Ldc_I4_8] = new OpCodes.Ldc(OpCodes.LdcType.i4, 8);
            Codes[(int)Code.Ldc_I4_M1] = new OpCodes.Ldc(OpCodes.LdcType.i4, -1);
            Codes[(int)Code.Ldc_I8] = new OpCodes.Ldc(OpCodes.LdcType.i8);
            Codes[(int)Code.Ldc_R4] = new OpCodes.Ldc(OpCodes.LdcType.r4);
            Codes[(int)Code.Ldc_R8] = new OpCodes.Ldc(OpCodes.LdcType.r8);
            Codes[(int)Code.Ldloc] = new OpCodes.Ldloc();
            Codes[(int)Code.Ldloc_0] = new OpCodes.Ldloc(0);
            Codes[(int)Code.Ldloc_1] = new OpCodes.Ldloc(1);
            Codes[(int)Code.Ldloc_2] = new OpCodes.Ldloc(2);
            Codes[(int)Code.Ldloc_3] = new OpCodes.Ldloc(3);
            Codes[(int)Code.Ldloc_S] = new OpCodes.Ldloc();
            Codes[(int)Code.Ldstr] = new OpCodes.Ldstr();
            Codes[(int)Code.Nop] = new OpCodes.Nop();
            Codes[(int)Code.Ret] = new OpCodes.Ret();
            Codes[(int)Code.Stloc] = new OpCodes.Stloc();
            Codes[(int)Code.Stloc_0] = new OpCodes.Stloc(0);
            Codes[(int)Code.Stloc_1] = new OpCodes.Stloc(1);
            Codes[(int)Code.Stloc_2] = new OpCodes.Stloc(2);
            Codes[(int)Code.Stloc_3] = new OpCodes.Stloc(3);
            Codes[(int)Code.Stloc_S] = new OpCodes.Stloc();
        }
    }
}
