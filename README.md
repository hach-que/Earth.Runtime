Earth.Runtime
=============

A common language runtime implemented in C# (i.e. a CLR on a CLR).  This library loads assemblies using Mono.Cecil and then executes them.  It does _not_ compile the IL to native code before execution.

When combined with [Cosmos](http://cosmos.codeplex.com/), it will in theory allow a Cosmos kernel to run end-user applications without the applications needing to be compiled into the kernel.

In the future, it would be ideal if it were possible to use IL2CPU as a JIT for Earth.Runtime so that user applications can be run much faster, but whether this is realistic has not been explored.

Implementation Status
-----------------------------
Earth.Runtime currently supports a very small subset of the IL instructions (enough to run the TestApp and no more).  It is also lacking a proper object model yet for user and system-defined classes, as well as a garbage collector and a system for calling kernel / native code... so basically quite a lot of the CLR is missing.  Don't expect anything other than _very trivial_ programs to work under it.

If you want to help out or you implement features, fork this Git repository and create pull requests.  Make sure you stick with the coding convention used in Earth.Runtime.