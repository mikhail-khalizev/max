using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("36427e89-b276-4a15-ae8b-94459b8e9a0f")]
        public void Method_0015_03a6()
        {
            ii(0x15_03a6, 2); pushfd();                                 /* pushfd */
            ii(0x15_03a8, 1); pushw(ds);                                /* push ds */
            ii(0x15_03a9, 2); pushd(esi);                               /* push esi */
            ii(0x15_03ab, 3); mov(si, 0xa8);                            /* mov si, 0xa8 */
            ii(0x15_03ae, 2); mov(ds, si);                              /* mov ds, si */
            ii(0x15_03b0, 2); mov(ss, si);                              /* mov ss, si */
            ii(0x15_03b2, 5); mov(esi, memd_a16[ds, 0xa42]);            /* mov esi, [0xa42] */
            ii(0x15_03b7, 4); popd(memd_a16[ds, si + 0x10]);            /* pop dword [si+0x10] */
            ii(0x15_03bb, 3); popw(memw_a16[ds, si + 0x4]);             /* pop word [si+0x4] */
            ii(0x15_03be, 4); mov(memd_a16[ds, si + 0x28], eax);        /* mov [si+0x28], eax */
            ii(0x15_03c2, 4); mov(memd_a16[ds, si + 0x1c], ebx);        /* mov [si+0x1c], ebx */
            ii(0x15_03c6, 4); mov(memd_a16[ds, si + 0x24], ecx);        /* mov [si+0x24], ecx */
            ii(0x15_03ca, 4); mov(memd_a16[ds, si + 0x20], edx);        /* mov [si+0x20], edx */
            ii(0x15_03ce, 4); mov(memd_a16[ds, si + 0xc], edi);         /* mov [si+0xc], edi */
            ii(0x15_03d2, 4); mov(memd_a16[ds, si + 0x14], ebp);        /* mov [si+0x14], ebp */
            ii(0x15_03d6, 3); mov(memw_a16[ds, si + 0x6], es);          /* mov [si+0x6], es */
            ii(0x15_03d9, 3); mov(memw_a16[ds, si + 0x8], fs);          /* mov [si+0x8], fs */
            ii(0x15_03dc, 3); mov(memw_a16[ds, si + 0xa], gs);          /* mov [si+0xa], gs */
            ii(0x15_03df, 2); popd(eax);                                /* pop eax */
            ii(0x15_03e1, 3); mov(bx, memw_a16[ds, si + 0x3a]);         /* mov bx, [si+0x3a] */
            ii(0x15_03e4, 3); and(bh, 0x3);                             /* and bh, 0x3 */
            ii(0x15_03e7, 2); or(ah, bh);                               /* or ah, bh */
            ii(0x15_03e9, 4); mov(memd_a16[ds, si + 0x3a], eax);        /* mov [si+0x3a], eax */
            ii(0x15_03ed, 3); xor(eax, eax);                            /* xor eax, eax */
            ii(0x15_03f0, 2); popd(ebp);                                /* pop ebp */
            ii(0x15_03f2, 1); leavew();                                 /* leave */
            ii(0x15_03f3, 1); retfw(); return;                          /* retf */
        }
    }
}
