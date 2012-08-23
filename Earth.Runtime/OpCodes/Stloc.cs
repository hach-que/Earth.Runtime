using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mono.Cecil.Cil;

namespace Earth.Runtime.OpCodes
{
    public class Stloc : IExecutableOp
    {
        private object m_Parameter;

        public Stloc(object param = null)
        {
            this.m_Parameter = param;
        }

        public void Execute(MethodState state, Instruction inst)
        {
            // FIXME SECURITY: Verifier should ensure all ldloc access is under the local var max.
            if (this.m_Parameter == null)
                state.LocalVariables[(int)inst.Operand] = state.EvaluationStack.Pop();
            else
                state.LocalVariables[(int)this.m_Parameter] = state.EvaluationStack.Pop();
        }
    }
}
