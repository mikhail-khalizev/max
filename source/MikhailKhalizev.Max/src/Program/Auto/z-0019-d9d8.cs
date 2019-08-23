using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_d9d8-1d85313e")]
        public void Method_0019_d9d8()
        {
            ii(0x19_d9d8, 1); pushw(bp);                                /* push bp */
            ii(0x19_d9d9, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x19_d9db, 1); pushw(es);                                /* push es */
            ii(0x19_d9dc, 2); pushd(edi);                               /* push edi */
            ii(0x19_d9de, 4); les(edi, ss, bp + 0x6);                   /* les edi, [bp+0x6] */
            ii(0x19_d9e2, 4); mov(ecx, memd_a16[ss, bp + 0x10]);        /* mov ecx, [bp+0x10] */
            ii(0x19_d9e6, 4); mov(eax, memd_a16[ss, bp + 0xc]);         /* mov eax, [bp+0xc] */
            ii(0x19_d9ea, 4); rep_a32(() => stosd_a32());               /* a32 rep stosd */
            ii(0x19_d9ee, 2); popd(edi);                                /* pop edi */
            ii(0x19_d9f0, 1); popw(es);                                 /* pop es */
            ii(0x19_d9f1, 1); leavew();                                 /* leave */
            ii(0x19_d9f2, 1); retfw();                                  /* retf */
        }
    }
}
