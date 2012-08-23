using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mono.Cecil.Cil;

namespace Earth.Runtime.OpCodes
{
    public class Ldarg : IExecutableOp
    {
        public void Execute(MethodState state, Instruction inst)
        {
            throw new NotSupportedException();
        }
    }
}
