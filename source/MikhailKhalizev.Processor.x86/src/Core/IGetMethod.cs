using System;
using MikhailKhalizev.Processor.x86.BinToCSharp.MethodInfo;

namespace MikhailKhalizev.Processor.x86.Core
{
    public interface IGetMethod
    {
        void GetMethod(out MethodInfoDto methodInfo, out Action method);
    }
}