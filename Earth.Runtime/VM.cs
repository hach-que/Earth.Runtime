using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mono.Cecil;
using Mono.Cecil.Cil;

namespace Earth.Runtime
{
    public class VM
    {
        private ModuleDefinition m_Module;

        public VM(ModuleDefinition module)
        {
            this.m_Module = module;
        }

        public void Execute()
        {
            this.Execute(this.m_Module.EntryPoint);
        }

        public void Execute(MethodDefinition method)
        {
            ExecutionEngine engine = new ExecutionEngine();
            Thread thread = new Thread(engine);
            MethodState state = new MethodState(thread, method);
            thread.Methods.Push(state);
            thread.Execute();
        }
    }
}
