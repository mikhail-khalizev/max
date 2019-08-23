using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_fe48-93c8e80a")]
        public void Method_0018_fe48()
        {
            ii(0x18_fe48, 2); popd(ebx);                                /* pop ebx */
            ii(0x18_fe4a, 3); mov(al, memb[ds, si + 0x3b]);             /* mov al, [si+0x3b] */
            ii(0x18_fe4d, 2); and(al, 0x5);                             /* and al, 0x5 */
            ii(0x18_fe4f, 2); or(bh, al);                               /* or bh, al */
            ii(0x18_fe51, 4); mov(memd[ds, si + 0x3a], ebx);            /* mov [si+0x3a], ebx */
            ii(0x18_fe55, 3); pop(memw[ds, si + 0x4]);                  /* pop word [si+0x4] */
            ii(0x18_fe58, 4); popd(memd[ds, si + 0x14]);                /* pop dword [si+0x14] */
            ii(0x18_fe5c, 4); popd(memd[ds, si + 0x10]);                /* pop dword [si+0x10] */
            ii(0x18_fe60, 3); xor(eax, eax);                            /* xor eax, eax */
            ii(0x18_fe63, 1); pop(bp);                                  /* pop bp */
            ii(0x18_fe64, 1); retf();                                   /* retf */
        }
    }
}
