using System;
using MikhailKhalizev.Processor.x86.BinToCSharp.MethodInfo;

namespace MikhailKhalizev.Processor.x86.CSharpExecutor
{
    public interface ICompiledMethodCollection
    {
        void GetMethod(out MethodInfoDto methodInfo, out Action method);
    }
}