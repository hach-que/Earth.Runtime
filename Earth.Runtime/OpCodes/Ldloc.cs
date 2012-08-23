using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mono.Cecil.Cil;

namespace Earth.Runtime.OpCodes
{
    public class Ldloc : IExecutableOp
    {
        private object m_Parameter;

        public Ldloc(object param = null)
        {
            this.m_Parameter = param;
        }

        public void Execute(MethodState state, Instruction inst)
        {
            // FIXME SECURITY: Verifier should ensure all ldloc access is under the local var max.
            if (this.m_Parameter == null)
                state.EvaluationStack.Push(state.LocalVariables[(int)inst.Operand]);
            else
                state.EvaluationStack.Push(state.LocalVariables[(int)this.m_Parameter]);
        }
    }
}
