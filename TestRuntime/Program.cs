using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Earth.Runtime;
using Mono.Cecil;

namespace TestRuntime
{
    class Program
    {
        static void Main(string[] args)
        {
            VM vm = new VM(ModuleDefinition.ReadModule("TestApp.exe"));
            vm.Execute();
        }
    }
}
