using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_5f28-3f9df27f")]
        public void /* sys */ Method_1018_5f28()
        {
            ii(0x1018_5f28, 1);  push(edx);                            /* push edx */
            ii(0x1018_5f29, 6);  mov(edx, memd[ds, 0x101b_e850]);      /* mov edx, [0x101be850] */
            ii(0x1018_5f2f, 5);  mov(memd[ds, 0x101b_e850], eax);      /* mov [0x101be850], eax */
            ii(0x1018_5f34, 3);  mov(memd[ds, eax + 16], edx);         /* mov [eax+0x10], edx */
            ii(0x1018_5f37, 1);  pop(edx);                             /* pop edx */
            ii(0x1018_5f38, 1);  ret();                                /* ret */
        }
    }
}
