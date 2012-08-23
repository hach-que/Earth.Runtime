using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mono.Cecil.Cil;
using Mono.Cecil;

namespace Earth.Runtime
{
    public class MethodState
    {
        public const int RETURN_INSTRUCTION_POINTER = -1;

        public Thread Thread;
        public int InstructionPointer;
        public Stack<object> EvaluationStack; // FIXME: Must use .maxstack
        public object[] LocalVariables;
        public object[] IncomingArguments;
        public MethodBody Body;
        public List<object> LocalAllocation;
        // Return State managed by thread.

        public MethodState(Thread thread, MethodDefinition definition)
        {
            this.Thread = thread;
            this.InstructionPointer = 0;
            this.EvaluationStack = new Stack<object>(definition.Body.MaxStackSize);
            this.LocalVariables = new object[definition.Body.Variables.Count];
            this.IncomingArguments = new object[definition.Parameters.Count];
            this.Body = definition.Body;
            this.LocalAllocation = new List<object>();
        }

        public int GetIndexOfInstruction(Instruction inst)
        {
            // FIXME: This should be more efficent.
            return this.Body.Instructions.IndexOf(inst);
        }

        public void ExecuteSingle()
        {
            if (this.InstructionPointer >= this.Body.Instructions.Count)
            {
                this.InstructionPointer = RETURN_INSTRUCTION_POINTER;
                return;
            }
            Instruction inst = this.Body.Instructions[this.InstructionPointer++];
            IExecutableOp handler = Operations.Codes[(int)inst.OpCode.Code];
            if (handler == null)
                throw new NotSupportedException();
            Console.WriteLine(Enum.GetName(typeof(Code), inst.OpCode.Code).ToUpper());
            handler.Execute(this, inst);
        }

        public void Execute()
        {
            while (this.InstructionPointer != RETURN_INSTRUCTION_POINTER)
                this.ExecuteSingle();
        }
    }
}
