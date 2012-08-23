using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mono.Cecil.Cil;

namespace Earth.Runtime.OpCodes
{
    public class Br : IExecutableOp
    {
        public void Execute(MethodState state, Instruction inst)
        {
            state.InstructionPointer = state.GetIndexOfInstruction((Instruction)inst.Operand);
        }
    }
}
