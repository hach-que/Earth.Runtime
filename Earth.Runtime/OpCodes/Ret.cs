using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mono.Cecil.Cil;

namespace Earth.Runtime.OpCodes
{
    public class Ret : IExecutableOp
    {
        public void Execute(MethodState state, Instruction inst)
        {
            state.InstructionPointer = MethodState.RETURN_INSTRUCTION_POINTER;
        }
    }
}
