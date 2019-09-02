using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_d9ad-59c6abf9")]
        public void Method_0019_d9ad()
        {
            ii(0x19_d9ad, 4); mov(ebx, memd[ss, bp + 0xa]);             /* mov ebx, [bp+0xa] */
            ii(0x19_d9b1, 5); movzx(ecx, memw[ss, bp + 0xe]);           /* movzx ecx, word [bp+0xe] */
            ii(0x19_d9b6, 1); push(es);                                 /* push es */
            ii(0x19_d9b7, 2); push(esi);                                /* push esi */
            ii(0x19_d9b9, 4); mov(esi, memd[ss, bp + 6]);               /* mov esi, [bp+0x6] */
            ii(0x19_d9bd, 3); les(dx, memw[ss, bp + 0x10]);             /* les dx, [bp+0x10] */
            ii(0x19_d9c0, 4); movzx(edx, dx);                           /* movzx edx, dx */
            ii(0x19_d9c4, 2); @int(0x31);                               /* int 0x31 */
            ii(0x19_d9c6, 3); setae(al);                                /* setae al */
            ii(0x19_d9c9, 2); xor(ah, ah);                              /* xor ah, ah */
            ii(0x19_d9cb, 2); pop(esi);                                 /* pop esi */
            ii(0x19_d9cd, 1); pop(es);                                  /* pop es */
            ii(0x19_d9ce, 1); leave();                                  /* leave */
            ii(0x19_d9cf, 1); retf();                                   /* retf */
        }
    }
}
