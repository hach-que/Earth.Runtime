using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mono.Cecil.Cil;

namespace Earth.Runtime
{
    public interface IExecutableOp
    {
        void Execute(MethodState state, Instruction inst);
    }
}
