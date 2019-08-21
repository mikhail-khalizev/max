using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_fd9c-3a6f4218")]
        public void Method_0018_fd9c()
        {
            ii(0x18_fd9c, 4); mov(ebx, memd_a16[ds, si + 0x3a]);        /* mov ebx, [si+0x3a] */
            ii(0x18_fda0, 3); and(bh, 0xfc);                            /* and bh, 0xfc */
            ii(0x18_fda3, 2); pushd(ebx);                               /* push ebx */
            ii(0x18_fda5, 5); movzx(ebx, memw_a16[ds, di + 0x4]);       /* movzx ebx, word [di+0x4] */
            ii(0x18_fdaa, 3); mov(ecx, memd_a16[ds, di]);               /* mov ecx, [di] */
            ii(0x18_fdad, 2); pushd(ebx);                               /* push ebx */
            ii(0x18_fdaf, 2); pushd(ecx);                               /* push ecx */
            ii(0x18_fdb1, 3); pushw(memw_a16[ds, si + 0x4]);            /* push word [si+0x4] */
            ii(0x18_fdb4, 3); pushw(memw_a16[ds, si + 0x6]);            /* push word [si+0x6] */
            ii(0x18_fdb7, 1); popw(es);                                 /* pop es */
            ii(0x18_fdb8, 3); pushw(memw_a16[ds, si + 0x8]);            /* push word [si+0x8] */
            ii(0x18_fdbb, 2); popw(fs);                                 /* pop fs */
            ii(0x18_fdbd, 3); pushw(memw_a16[ds, si + 0xa]);            /* push word [si+0xa] */
            ii(0x18_fdc0, 2); popw(gs);                                 /* pop gs */
            ii(0x18_fdc2, 4); mov(eax, memd_a16[ds, si + 0x28]);        /* mov eax, [si+0x28] */
            ii(0x18_fdc6, 4); mov(ebx, memd_a16[ds, si + 0x1c]);        /* mov ebx, [si+0x1c] */
            ii(0x18_fdca, 4); mov(ecx, memd_a16[ds, si + 0x24]);        /* mov ecx, [si+0x24] */
            ii(0x18_fdce, 4); mov(edx, memd_a16[ds, si + 0x20]);        /* mov edx, [si+0x20] */
            ii(0x18_fdd2, 4); mov(ebp, memd_a16[ds, si + 0x14]);        /* mov ebp, [si+0x14] */
            ii(0x18_fdd6, 4); mov(edi, memd_a16[ds, si + 0xc]);         /* mov edi, [si+0xc] */
            ii(0x18_fdda, 4); mov(esi, memd_a16[ds, si + 0x10]);        /* mov esi, [si+0x10] */
            ii(0x18_fdde, 1); popw(ds);                                 /* pop ds */
            ii(0x18_fddf, 2); iretd(); return;                          /* iretd */
        }
    }
}
