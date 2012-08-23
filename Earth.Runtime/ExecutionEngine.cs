using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Earth.Runtime
{
    public class ExecutionEngine
    {
        public List<Thread> Threads = new List<Thread>();
        public ManagedHeap Heap = new ManagedHeap(128 * 1024); // 128k
    }
}
