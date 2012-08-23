using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mono.Cecil.Cil;
using Earth.Runtime.Data;

namespace Earth.Runtime.OpCodes
{
    public class Ldc : IExecutableOp
    {
        private LdcType m_Type;
        private object m_Parameter;

        public Ldc(LdcType type, object param = null)
        {
            this.m_Type = type;
            this.m_Parameter = param;
        }

        public void Execute(MethodState state, Instruction inst)
        {
            switch (this.m_Type)
            {
                case LdcType.i4:
                    if (this.m_Parameter == null)
                        state.EvaluationStack.Push(new Int32Type((Int32)inst.Operand));
                    else
                        state.EvaluationStack.Push(new Int32Type((Int32)this.m_Parameter));
                    break;
                case LdcType.i8:
                    state.EvaluationStack.Push(new Int64Type((Int64)inst.Operand));
                    break;
                case LdcType.r4:
                case LdcType.r8:
                    state.EvaluationStack.Push(new FloatingPointType((float)inst.Operand));
                    break;
            }
        }
    }

    public enum LdcType
    {
        i4,
        i8,
        r4,
        r8
    }
}
