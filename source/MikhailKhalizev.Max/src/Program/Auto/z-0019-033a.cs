using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_033a-c4af5c83")]
        public void Method_0019_033a()
        {
            ii(0x19_033a, 4); enterw(0, 0);                             /* enter 0x0, 0x0 */
            ii(0x19_033e, 5); movzx(esi, memw_a16[ss, bp + 0x8]);       /* movzx esi, word [bp+0x8] */
            ii(0x19_0343, 2); pushd(ebp);                               /* push ebp */
            ii(0x19_0345, 4); mov(ecx, memd_a16[ds, si + 0x3a]);        /* mov ecx, [si+0x3a] */
            ii(0x19_0349, 3); and(ch, 0xfc);                            /* and ch, 0xfc */
            ii(0x19_034c, 2); pushd(ecx);                               /* push ecx */
            ii(0x19_034e, 3); mov(eax, cs);                             /* mov eax, cs */
            ii(0x19_0351, 2); pushd(eax);                               /* push eax */
            ii(0x19_0353, 5); lea(eax, 0xf16);                          /* lea eax, [0xf16] */
            ii(0x19_0358, 2); pushd(eax);                               /* push eax */
            ii(0x19_035a, 4); mov(es, memw_a16[ds, 0x124]);             /* mov es, [0x124] */
            ii(0x19_035e, 3); mov(bx, memw_a16[ss, bp + 0x6]);          /* mov bx, [bp+0x6] */
            ii(0x19_0361, 2); pushd(ecx);                               /* push ecx */
            ii(0x19_0363, 2); pushw(0);                                 /* push 0x0 */
            ii(0x19_0365, 4); pushw(memw_a16[es, bx + 0x6]);            /* push word [es:bx+0x6] */
            ii(0x19_0369, 5); pushd(memd_a16[es, bx + 0x2]);            /* push dword [es:bx+0x2] */
            ii(0x19_036e, 3); pushw(memw_a16[ds, si + 0x4]);            /* push word [si+0x4] */
            ii(0x19_0371, 3); pushw(memw_a16[ds, si + 0x6]);            /* push word [si+0x6] */
            ii(0x19_0374, 1); popw(es);                                 /* pop es */
            ii(0x19_0375, 3); pushw(memw_a16[ds, si + 0x8]);            /* push word [si+0x8] */
            ii(0x19_0378, 2); popw(fs);                                 /* pop fs */
            ii(0x19_037a, 3); pushw(memw_a16[ds, si + 0xa]);            /* push word [si+0xa] */
            ii(0x19_037d, 2); popw(gs);                                 /* pop gs */
            ii(0x19_037f, 4); mov(eax, memd_a16[ds, si + 0x28]);        /* mov eax, [si+0x28] */
            ii(0x19_0383, 4); mov(ebx, memd_a16[ds, si + 0x1c]);        /* mov ebx, [si+0x1c] */
            ii(0x19_0387, 4); mov(ecx, memd_a16[ds, si + 0x24]);        /* mov ecx, [si+0x24] */
            ii(0x19_038b, 4); mov(edx, memd_a16[ds, si + 0x20]);        /* mov edx, [si+0x20] */
            ii(0x19_038f, 4); mov(ebp, memd_a16[ds, si + 0x14]);        /* mov ebp, [si+0x14] */
            ii(0x19_0393, 4); mov(edi, memd_a16[ds, si + 0xc]);         /* mov edi, [si+0xc] */
            ii(0x19_0397, 4); mov(esi, memd_a16[ds, si + 0x10]);        /* mov esi, [si+0x10] */
            ii(0x19_039b, 4); mov(ss, memw_a16[ds, 0]);                 /* mov ss, [0x0] */
            ii(0x19_039f, 4); movzx(esp, sp);                           /* movzx esp, sp */
            ii(0x19_03a3, 1); popw(ds);                                 /* pop ds */
            ii(0x19_03a4, 2); iretd();                                  /* iretd */
        }
    }
}
