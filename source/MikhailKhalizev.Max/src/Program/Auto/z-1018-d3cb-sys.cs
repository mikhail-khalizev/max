using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_d3cb-98dcc2f0")]
        public void /* sys */ Method_1018_d3cb()
        {
            ii(0x1018_d3cb, 5);  mov(eax, 0xe);                        /* mov eax, 0xe */
            ii(0x1018_d3d0, 2);  if(jmp_func(0x1018_d3bf, -0x13)) return;/* jmp 0x1018d3bf */
        }
    }
}
