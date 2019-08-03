using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("991cc982-b979-48e2-baa6-ba7b067c0df2")]
        public void Method_0014_fd64()
        {
            ii(0x14_fd64, 4); enterw(0, 0);                             /* enter 0x0, 0x0 */
            ii(0x14_fd68, 5); movzx(esi, memw_a16[ss, bp + 0x8]);       /* movzx esi, word [bp+0x8] */
            ii(0x14_fd6d, 3); mov(di, memw_a16[ds, si + 0x2c]);         /* mov di, [si+0x2c] */
            ii(0x14_fd70, 3); shl(di, 0x3);                             /* shl di, 0x3 */
            ii(0x14_fd73, 4); add(di, 0x142);                           /* add di, 0x142 */
            ii(0x14_fd77, 4); mov(ebx, memd_a16[ds, si + 0x3a]);        /* mov ebx, [si+0x3a] */
            ii(0x14_fd7b, 3); and(bh, 0xfa);                            /* and bh, 0xfa */
            ii(0x14_fd7e, 3); sub(ecx, ecx);                            /* sub ecx, ecx */
            ii(0x14_fd81, 2); mov(cx, cs);                              /* mov cx, cs */
            ii(0x14_fd83, 3); sub(edx, edx);                            /* sub edx, edx */
            ii(0x14_fd86, 3); mov(dx, 0x954);                           /* mov dx, 0x954 */
            ii(0x14_fd89, 4); test(memb_a16[ds, di + 0x6], 0x8);        /* test byte [di+0x6], 0x8 */
            ii(0x14_fd8d, 2); if(jzw(0x14_fd97, 0x8)) goto l_0x14_fd97; /* jz 0xfd97 */
            ii(0x14_fd8f, 2); pushd(ebx);                               /* push ebx */
            ii(0x14_fd91, 2); pushd(ecx);                               /* push ecx */
            ii(0x14_fd93, 2); pushd(edx);                               /* push edx */
            ii(0x14_fd95, 2); jmpw(0x14_fd9c, 0x5); goto l_0x14_fd9c;   /* jmp 0xfd9c */
        l_0x14_fd97:
            ii(0x14_fd97, 1); pushw(bx);                                /* push bx */
            ii(0x14_fd98, 1); pushw(cx);                                /* push cx */
            ii(0x14_fd99, 1); pushw(dx);                                /* push dx */
            ii(0x14_fd9a, 2); xchg(bx, bx);                             /* xchg bx, bx */
        l_0x14_fd9c:
            ii(0x14_fd9c, 4); mov(ebx, memd_a16[ds, si + 0x3a]);        /* mov ebx, [si+0x3a] */
            ii(0x14_fda0, 3); and(bh, 0xfc);                            /* and bh, 0xfc */
            ii(0x14_fda3, 2); pushd(ebx);                               /* push ebx */
            ii(0x14_fda5, 5); movzx(ebx, memw_a16[ds, di + 0x4]);       /* movzx ebx, word [di+0x4] */
            ii(0x14_fdaa, 3); mov(ecx, memd_a16[ds, di]);               /* mov ecx, [di] */
            ii(0x14_fdad, 2); pushd(ebx);                               /* push ebx */
            ii(0x14_fdaf, 2); pushd(ecx);                               /* push ecx */
            ii(0x14_fdb1, 3); pushw(memw_a16[ds, si + 0x4]);            /* push word [si+0x4] */
            ii(0x14_fdb4, 3); pushw(memw_a16[ds, si + 0x6]);            /* push word [si+0x6] */
            ii(0x14_fdb7, 1); popw(es);                                 /* pop es */
            ii(0x14_fdb8, 3); pushw(memw_a16[ds, si + 0x8]);            /* push word [si+0x8] */
            ii(0x14_fdbb, 2); popw(fs);                                 /* pop fs */
            ii(0x14_fdbd, 3); pushw(memw_a16[ds, si + 0xa]);            /* push word [si+0xa] */
            ii(0x14_fdc0, 2); popw(gs);                                 /* pop gs */
            ii(0x14_fdc2, 4); mov(eax, memd_a16[ds, si + 0x28]);        /* mov eax, [si+0x28] */
            ii(0x14_fdc6, 4); mov(ebx, memd_a16[ds, si + 0x1c]);        /* mov ebx, [si+0x1c] */
            ii(0x14_fdca, 4); mov(ecx, memd_a16[ds, si + 0x24]);        /* mov ecx, [si+0x24] */
            ii(0x14_fdce, 4); mov(edx, memd_a16[ds, si + 0x20]);        /* mov edx, [si+0x20] */
            ii(0x14_fdd2, 4); mov(ebp, memd_a16[ds, si + 0x14]);        /* mov ebp, [si+0x14] */
            ii(0x14_fdd6, 4); mov(edi, memd_a16[ds, si + 0xc]);         /* mov edi, [si+0xc] */
            ii(0x14_fdda, 4); mov(esi, memd_a16[ds, si + 0x10]);        /* mov esi, [si+0x10] */
            ii(0x14_fdde, 1); popw(ds);                                 /* pop ds */
            ii(0x14_fddf, 2); iretd(); return;                          /* iretd */
        }
    }
}