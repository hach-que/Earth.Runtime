using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mono.Cecil.Cil;
using Mono.Cecil;

namespace Earth.Runtime.OpCodes
{
    public class Call : IExecutableOp
    {
        public void Execute(MethodState state, Instruction inst)
        {
            if (inst.Operand is MemberReference)
            {
                if ((inst.Operand as MemberReference).FullName == "System.Void System.Console::WriteLine(System.String)")
                    Console.WriteLine((string)state.EvaluationStack.Pop());
                else
                    throw new NotSupportedException();
            }
            else
                throw new NotSupportedException();
        }
    }
}
