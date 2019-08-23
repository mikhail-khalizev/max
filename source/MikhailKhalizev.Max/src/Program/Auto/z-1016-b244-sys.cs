using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_b244-b594099")]
        public void /* sys */ Method_1016_b244()
        {
            ii(0x1016_b244, 1); push(ebx);                              /* push ebx */
            ii(0x1016_b245, 6); mov(ebx, memd[ds, 0x101c_fb4c]);        /* mov ebx, [0x101cfb4c] */
            ii(0x1016_b24b, 2); mov(memd[ds, eax], ebx);                /* mov [eax], ebx */
            ii(0x1016_b24d, 5); mov(eax, memd[ds, 0x101c_fb50]);        /* mov eax, [0x101cfb50] */
            ii(0x1016_b252, 2); mov(memd[ds, edx], eax);                /* mov [edx], eax */
            ii(0x1016_b254, 1); pop(ebx);                               /* pop ebx */
        }
    }
}
