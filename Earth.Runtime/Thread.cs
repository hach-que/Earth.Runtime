using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Earth.Runtime
{
    public class Thread
    {
        public ExecutionEngine Engine = null;
        public Stack<MethodState> Methods = new Stack<MethodState>();

        public Thread(ExecutionEngine engine)
        {
            this.Engine = engine;
        }

        public void Execute()
        {
            while (this.Methods.Count > 0)
            {
                MethodState p = this.Methods.Peek();
                if (p.InstructionPointer == MethodState.RETURN_INSTRUCTION_POINTER)
                {
                    this.Methods.Pop();
                    continue;
                }
                p.ExecuteSingle();
            }
        }
    }
}
